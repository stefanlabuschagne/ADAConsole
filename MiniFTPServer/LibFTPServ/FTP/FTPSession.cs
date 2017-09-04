using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Linq;
using System.Threading;

namespace LibFTPServ.FTP
{
    class FTPSession
    {
        private DateTime _lastcmdtime, _conntime;
        private FTPServer _server;
        private string _currentDir, _localpath;
        private Socket _clientSocket, _datasocket;
        private string _connuser;
        private bool _isAuthenticated;
        private bool DataTransferEnabled = false;
        private TcpListener DataListener = null;
        private string _renamefrom;
        private byte[] _portBuffer = new byte[500];
        private bool _utf8, _activecommand;
        // Used inside PORT method
        IPEndPoint[] ClientEndPoints;
        FTPUserPermission _currentperms;

        internal string SessionID
        {
            get
            {
                return _conntime.Ticks.ToString();
            }
        }

        internal string EndPoint
        {
            get
            {
                return _clientSocket.RemoteEndPoint.ToString();
            }
        }

        internal bool IsConnected
        {
            get
            {
                if (_clientSocket == null || !_clientSocket.Connected || _conntime.ToString("HH:mm:ss") == _lastcmdtime.ToString("HH:mm:ss"))
                {
                    Disconnect();
                    return false;
                }
                return true;
            }
        }

        internal DateTime LastCommandTime
        {
            get { return _lastcmdtime; }
        }

        internal FTPSession(Socket ClientSocket, FTPServer serv, string startdir)
        {
            IPEndPoint p = (IPEndPoint)ClientSocket.LocalEndPoint;
            if (serv.BannedAdresses.Contains(p.Address) && !serv.AcceptedAdresses.Contains(p.Address)) Disconnect();
            else
            {
                this._clientSocket = ClientSocket;
                ClientSocket.NoDelay = false;
                _conntime = DateTime.Now;
                _server = serv;
                _currentDir = startdir;
                SendMessage("220 FTP Ready");

                // Wait for the command to be sent by the client
                ClientSocket.BeginReceive(_portBuffer, 0, _portBuffer.Length, SocketFlags.None, new AsyncCallback(CommandReceived), null);
            }
        }

        internal void Disconnect()
        {
            if (_clientSocket != null && _clientSocket.Connected) _clientSocket.Close();
            _clientSocket = null;
            if (DataListener != null) DataListener.Stop();
            DataListener = null;
            if (_datasocket != null && _datasocket.Connected) _datasocket.Close();
            _datasocket = null;
            _connuser = null;
            ClientEndPoints = null;
            _server.RemoveClient(this);
            _portBuffer = null;
            _renamefrom = null;
            GC.Collect();
        }

        void CommandReceived(IAsyncResult arg)
        {
            _activecommand = false;
            int CommandSize = 0;
            try { CommandSize = _clientSocket.EndReceive(arg); }
            catch { }
            if (CommandSize == 0)
            {
                Disconnect();
                //return;
            }

            // Wait for the next command to be sent by the client
            try
            {
                _clientSocket.BeginReceive(_portBuffer, 0, _portBuffer.Length, SocketFlags.None, new AsyncCallback(CommandReceived), null);
            }
            catch
            {
                Disconnect();
                return;
            }

            _lastcmdtime = DateTime.Now;
            string CommandText;
            if (_utf8) CommandText = Encoding.UTF8.GetString(_portBuffer, 0, CommandSize).TrimStart(' ');
            else CommandText = Encoding.ASCII.GetString(_portBuffer, 0, CommandSize).TrimStart(' ');
            string CmdArguments = null, Command = null;
            int End = 0;
            if ((End = CommandText.IndexOf(' ')) == -1) End = (CommandText = CommandText.Trim()).Length;
            else CmdArguments = CommandText.Substring(End).TrimStart(' ');
            Command = CommandText.Substring(0, End).ToUpper();

            if (CmdArguments != null && CmdArguments.EndsWith("\r\n")) CmdArguments = CmdArguments.Substring(0, CmdArguments.Length - 2);
            bool CommandExecued = false;
            switch (Command)
            {
                case "USER":
                    _activecommand = true;
                    if (CmdArguments != null && CmdArguments.Length > 0)
                    {
                        SendMessage("331 Password required!");
                        _connuser = CmdArguments;
                    }
                    CommandExecued = true;
                    break;
                case "PASS":
                    _activecommand = true;
                    if (_connuser == "")
                    {
                        SendMessage("503 Invalid User Name");
                        return;
                    }
                    if (_server.Users[_connuser] != null)
                    {
                        if (_server.Users[_connuser].SHA1Password == HelperFunctions.SHA1Hash(CmdArguments))
                        {
                            _isAuthenticated = true;
                            _currentDir = "/";
                            _currentperms = _server.Users.GetPermissions(_connuser);
                            if (string.IsNullOrEmpty(_server.Users[_connuser].Startupdir) || _server.Users[_connuser].Startupdir == "/") _localpath = _server.StartupDir;
                            else _localpath = _server.Users[_connuser].Startupdir;
                            _server.Call_Log(new FTPLogEventArgs(FTPLogEventType.UserConnect, _connuser, true, 230, "none"));
                            SendMessage("230 Authentication Successful");
                        }
                        else
                        {
                            SendMessage("530 Authentication Failed!");
                            _server.Call_Log(new FTPLogEventArgs(FTPLogEventType.UserConnect, _connuser, false, 530, "none"));
                        }
                    }
                    else
                    {
                        SendMessage("530 Authentication Failed!");
                        _server.Call_Log(new FTPLogEventArgs(FTPLogEventType.UserConnect, _connuser, false, 530, "none"));
                    }
                    CommandExecued = true;
                    break;
            }
            if (!CommandExecued)
            {
                if (!_isAuthenticated)
                {
                    SendMessage("530 Access Denied! Authenticate first");
                    return;
                }
                switch (Command.ToUpper())
                {
                    case "CWD":
                        _activecommand = true;
                        CWD(CmdArguments);
                        break;

                    case "CDUP":
                        _activecommand = true;
                        string[] pathParts = _currentDir.Split('/');
                        if (pathParts.Length > 1)
                        {
                            _currentDir = "";
                            for (int i = 0; i < (pathParts.Length - 2); i++) _currentDir += pathParts[i] + "/";
                            if (_currentDir.Length == 0) _currentDir = "/";
                        }
                        SendMessage("250 CDUP command successful.");
                        break;

                    case "QUIT":
                        _activecommand = true;
                        SendMessage("221 FTP server signing off");
                        Disconnect();
                        break;

                    case "PWD":
                        _activecommand = true;
                        SendMessage("257 \"" + _currentDir + "\"");
                        break;

                    case "PORT":
                        _activecommand = true;
                        PORT(CmdArguments); //done
                        break;

                    case "PASV":
                        _activecommand = true;
                        PASV(CmdArguments); //done
                        break;

                    case "TYPE":
                        _activecommand = true;
                        TYPE(CmdArguments); //done
                        break;

                    case "SYST":
                        _activecommand = true;
                        SendMessage("215 Windows_NT");
                        break;

                    case "NOOP":
                        _activecommand = true;
                        SendMessage("200 OK");
                        break;

                    case "RETR":
                        _activecommand = true;
                        RETR(CmdArguments);
                        break;

                    case "STOR":
                        _activecommand = true;
                        STOR(CmdArguments, false);
                        break;

                    case "APPE":
                        _activecommand = true;
                        APPE(CmdArguments);
                        break;

                    case "RNFR":
                        _activecommand = true;
                        RNFR(CmdArguments);
                        break;

                    case "RNTO":
                        _activecommand = true;
                        RNTO(CmdArguments);
                        break;
                    case "DELE":
                        _activecommand = true;
                        DELE(CmdArguments);
                        break;

                    case "RMD":
                        _activecommand = true;
                        RMD(CmdArguments);
                        break;

                    case "MKD":
                        _activecommand = true;
                        MKD(CmdArguments);
                        break;

                    case "LIST":
                        _activecommand = true;
                        LIST(_currentDir);
                        break;

                    case "NLST":
                        _activecommand = true;
                        NLST(CmdArguments);
                        break;

                    /*case "CLNT":
                        break;*/
                    case "MDTM":
                        _activecommand = true;
                        MDTM(CmdArguments);
                        break;

                    case "SIZE":
                        _activecommand = true;
                        SIZE(CmdArguments);
                        break;

                    case "OPTS":
                        _activecommand = true;
                        OPTS(CmdArguments);
                        break;

                    case "REIN":
                        _activecommand = true;
                        REIN(CmdArguments);
                        break;

                    case "STOU":
                        _activecommand = true;
                        STOR(CmdArguments, true);
                        break;

                    case "ABOR":
                    case "SHUTDOWN":
                        if (_datasocket != null && _datasocket.Connected) _datasocket.Close();
                        _datasocket = null;
                        GC.Collect();
                        SendMessage("200 Data transfer aborted");
                        _server.Call_Log(new FTPLogEventArgs(FTPLogEventType.Abort, _connuser, true, 200));
                        break;

                    case "FEAT":
                        SendMessage("  SIZE");
                        SendMessage("  MTDM");
                        SendMessage("211 Feature list end");
                        _server.Call_Log(new FTPLogEventArgs(FTPLogEventType.FeatureList, _connuser, true, 211));
                        break;

                    default:
                        SendMessage("500 Unknown Command.");
                        _server.Call_Log(new FTPLogEventArgs(FTPLogEventType.UnknownCommand, _connuser, true, 500, Command, CmdArguments));
                        break;

                    //	case "STAT":
                    //		break;

                    //	case "HELP":
                    //		break;

                    //	case "REST":
                    //		break;
                }
            }
        }

        #region CWD
        private void CWD(string CmdArguments)
        {
            string navpath;
            bool full = Fullpath(CmdArguments);
            if (full) navpath = CmdArguments;
            else navpath = _currentDir + "/" + CmdArguments;

            if (navpath.Contains(".."))
            {
                string[] parts = _currentDir.Split('/');
                StringBuilder sb = new StringBuilder();
                sb.Append('/');
                for (int i = 0; i < parts.Length - 1; i++)
                {
                    sb.Append(parts[i]);
                    sb.Append('/');
                }
                _currentDir = sb.ToString();
                _currentDir = HelperFunctions.FixPath(_currentDir);
                SendMessage("250 CWD command successful.");
                _server.Call_Log(new FTPLogEventArgs(FTPLogEventType.ChangeWorkDir, _connuser, true, 250, _currentDir));
            }
            else
            {
                if (DirectoryExists(navpath) || _server.VFS.PathExists(navpath))
                {
                    if (full) _currentDir = navpath;
                    else
                    {
                        _currentDir += "/" + CmdArguments;
                        _currentDir = HelperFunctions.FixPath(_currentDir);
                    }
                    SendMessage("250 CWD command successful.");
                    _server.Call_Log(new FTPLogEventArgs(FTPLogEventType.ChangeWorkDir, _connuser, true, 250, _currentDir));
                }
                else
                {
                    SendMessage("550 System can't find directory.");
                    _server.Call_Log(new FTPLogEventArgs(FTPLogEventType.ChangeWorkDir, _connuser, false, 250, _currentDir));
                }

            }

        }
        #endregion

        #region Type
        private void TYPE(string CmdArguments)
        {
            if ((CmdArguments = CmdArguments.Trim().ToUpper()) == "A" || CmdArguments == "I")
            {
                SendMessage("200 Type " + CmdArguments + " Accepted.");
                _server.Call_Log(new FTPLogEventArgs(FTPLogEventType.ChangeType, _connuser, true, 200, CmdArguments));
            }
            else
            {
                SendMessage("500 Unknown Type.");
                _server.Call_Log(new FTPLogEventArgs(FTPLogEventType.ChangeType, _connuser, false, 200, CmdArguments));
            }
        }
        #endregion

        #region PORT
        private void PORT(string CmdArguments)
        {
            string[] IP_Parts = CmdArguments.Split(',');
            if (IP_Parts.Length != 6)
            {
                SendMessage("550 Invalid arguments.");
                _server.Call_Log(new FTPLogEventArgs(FTPLogEventType.PortCommand, _connuser, false, 550, "Invalid arguments", CmdArguments));
                return;
            }

            string ClientIP = IP_Parts[0] + "." + IP_Parts[1] + "." + IP_Parts[2] + "." + IP_Parts[3];
            int tmpPort = (Convert.ToInt32(IP_Parts[4]) << 8) | Convert.ToInt32(IP_Parts[5]);

            IPAddress[] client = Dns.GetHostEntry(ClientIP).AddressList;
            ClientEndPoints = new IPEndPoint[client.Length];
            for (int i = 0; i < client.Length; i++)
            {
                ClientEndPoints[i] = new IPEndPoint(client[i], tmpPort);
            }
            DataTransferEnabled = false;

            SendMessage("200 Ready to connect to " + ClientIP + "");
            _server.Call_Log(new FTPLogEventArgs(FTPLogEventType.PortCommand, _connuser, true, 200, CmdArguments));
        }
        #endregion

        #region PASV
        private void PASV(string CmdArguments)
        {
            // Open listener within the specified port range
            int tmpPort = _server.PassivePortMinimum;
        StartListener:
            if (DataListener != null) { DataListener.Stop(); DataListener = null; }
            try
            {
                DataListener = new TcpListener(IPAddress.Any, tmpPort);
                DataListener.Start();
            }
            catch
            {
                if (tmpPort < _server.PassivePortMaximum)
                {
                    tmpPort++;
                    goto StartListener;
                }
                else
                {
                    SendMessage("500 Action Failed Retry");
                    _server.Call_Log(new FTPLogEventArgs(FTPLogEventType.PassiveMode, _connuser, false, 500));
                    return;
                }
            }

            //string tmpEndPoint = DataListener.LocalEndpoint.ToString();
            //tmpPort = Convert.ToInt32(tmpEndPoint.Substring(tmpEndPoint.IndexOf(':') + 1));

            string SocketEndPoint = _clientSocket.LocalEndPoint.ToString();

            SocketEndPoint = SocketEndPoint.Substring(0, SocketEndPoint.IndexOf(":")).Replace(".", ",") + "," + (tmpPort >> 8) + "," + (tmpPort & 255);
            DataTransferEnabled = true;

            SendMessage("227 Entering Passive Mode (" + SocketEndPoint + ").");
            _server.Call_Log(new FTPLogEventArgs(FTPLogEventType.PassiveMode, _connuser, true, 500, SocketEndPoint));
        }
        #endregion

        #region RETR
        private void RETR(string CmdArguments)
        {

            Stream fileStream = null;
            string navpath;
            bool full = Fullpath(CmdArguments);
            if (full) navpath = CmdArguments;
            else navpath = _currentDir + "/" + CmdArguments;


            string file = GetExactPath(navpath);
            try
            {
                if (_server.VFS.IsVirtualFile(navpath)) fileStream = _server.VFS.GetFileContents(navpath);
                else fileStream = File.OpenRead(file);
            }
            catch
            {
                SendMessage("550 Access denied or directory dosen't exist !");
                _server.Call_Log(new FTPLogEventArgs(FTPLogEventType.DownloadFile, _connuser, false, 550, file, "Access denied or directory dosen't exist"));
                return;
            }

            _datasocket = this.GetDataSocket();
            if (_datasocket == null) return;

            try
            {
                if (fileStream != null)
                {
                    SendMessage("250 Transfer started");
                    // ToDo: bandwidth limiting here
                    int readed = 1;
                    int cnt = 0;

                    if (_server.DownloadSpeedLimit > 0)
                    {
                        while (readed > 0)
                        {
                            byte[] data = new byte[10000];
                            readed = fileStream.Read(data, 0, data.Length);
                            cnt += readed;
                            _datasocket.Send(data, readed, SocketFlags.None);
                            if (cnt >= _server.DownloadSpeedLimit)
                            {
                                Thread.Sleep(1000);
                                cnt = 0;
                            }
                        }
                    }
                    else
                    {
                        while (readed > 0)
                        {
                            byte[] data = new byte[10000];
                            readed = fileStream.Read(data, 0, data.Length);
                            cnt += readed;
                            _datasocket.Send(data, readed, SocketFlags.None);
                        }
                    }
                }

                _datasocket.Shutdown(SocketShutdown.Both);
                _datasocket.Close();
                _datasocket = null;
                GC.Collect();

                SendMessage("226 Transfer Complete.");
                _server.Call_Log(new FTPLogEventArgs(FTPLogEventType.DownloadFile, _connuser, true, 226, file));
            }
            catch
            {
                SendMessage("426 Connection closed; transfer aborted.");
                _server.Call_Log(new FTPLogEventArgs(FTPLogEventType.DownloadFile, _connuser, false, 426, file, "Transfer aborted"));
            }

            fileStream.Close();
        }
        #endregion

        #region STOR
        private void STOR(string CmdArguments, bool unique)
        {
            if (_currentperms.Upload)
            {
                Stream fileStream = null;
                string file = null, name = null;
                try
                {
                    if (unique)
                    {
                        name = HelperFunctions.GenerateUniqueFileName();
                        file = GetExactPath(_currentDir + "/" + name);
                    }
                    else
                    {
                        name = CmdArguments;
                        file = GetExactPath(_currentDir + "/" + name);
                    }

                    if (File.Exists(file)) File.Delete(file);
                    fileStream = File.OpenWrite(file);
                    if (unique) SendMessage("250 " + name);
                    else SendMessage("250 Transfer started");
                }
                catch
                {
                    SendMessage("550 Access denied or directory dosen't exist !");
                    _server.Call_Log(new FTPLogEventArgs(FTPLogEventType.UploadFile, _connuser, false, 550, file, "Access denied or directory dosen't exist"));
                    return;
                }

                _datasocket = GetDataSocket();
                if (_datasocket == null) return;
                try
                {
                    if (fileStream != null)
                    {
                        // ToDo: bandwidth limiting here

                        int readed = 1;
                        int cnt = 0;

                        if (_server.UploadSpeedLimit > 0)
                        {

                            while (readed > 0)
                            {
                                byte[] data = new byte[10000];
                                readed = _datasocket.Receive(data);
                                cnt += readed;
                                fileStream.Write(data, 0, readed);
                                if (cnt > _server.UploadSpeedLimit)
                                {
                                    Thread.Sleep(1000);
                                    cnt = 0;
                                }
                            }
                        }
                        else
                        {
                            while (readed > 0)
                            {
                                byte[] data = new byte[10000];
                                readed = _datasocket.Receive(data);
                                fileStream.Write(data, 0, readed);
                            }
                        }
                    }

                    _datasocket.Shutdown(SocketShutdown.Both);
                    _datasocket.Close();
                    _datasocket = null;
                    GC.Collect();
                    SendMessage("226 Transfer Complete.");
                    _server.Call_Log(new FTPLogEventArgs(FTPLogEventType.UploadFile, _connuser, true, 226, file));
                }
                catch
                {
                    SendMessage("426 Connection closed; transfer aborted.");
                    _server.Call_Log(new FTPLogEventArgs(FTPLogEventType.UploadFile, _connuser, false, 426, file, "Transfer aborted"));
                }

                fileStream.Close();
            }
            else
            {
                SendMessage("550 Access denied");
                _server.Call_Log(new FTPLogEventArgs(FTPLogEventType.UploadFile, _connuser, false, 550, "Acces Denied"));
            }
        }
        #endregion

        #region DELE
        private void DELE(string CmdArguments)
        {
            if (_currentperms.Delete)
            {
                string navpath;
                bool full = Fullpath(CmdArguments);
                if (full) navpath = CmdArguments;
                else navpath = _currentDir + "/" + CmdArguments;

                string file = GetExactPath(navpath);

                try
                {
                    File.Delete(file);
                    SendMessage("250 file deleted.");
                    _server.Call_Log(new FTPLogEventArgs(FTPLogEventType.DeleteFile, _connuser, true, 250, file));
                }
                catch
                {
                    SendMessage("550 file delete failed");
                    _server.Call_Log(new FTPLogEventArgs(FTPLogEventType.DeleteFile, _connuser, false, 550, file, "Delete failed"));
                }
            }
            else
            {
                SendMessage("550 Acces Denied");
                _server.Call_Log(new FTPLogEventArgs(FTPLogEventType.DeleteFile, _connuser, false, 550, "Acces Denied"));
            }
        }
        #endregion

        #region APPE
        private void APPE(string CmdArguments)
        {
            Stream fileStream = null;
            string navpath;
            bool full = Fullpath(CmdArguments);
            if (full) navpath = CmdArguments;
            else navpath = _currentDir + "/" + CmdArguments;

            string file = GetExactPath(navpath);
            if (_currentperms.Upload)
            {
                try
                {
                    fileStream = File.Open(file, FileMode.Append);
                }
                catch
                {
                    SendMessage("550 File Upload error");
                    _server.Call_Log(new FTPLogEventArgs(FTPLogEventType.AppendFile, _connuser, false, 550, file, "File Upload error"));
                    return;
                }

                _datasocket = GetDataSocket();
                if (_datasocket == null) return;
                try
                {
                    if (fileStream != null)
                    {
                        // ToDo: bandwidth limiting here

                        int readed = 1;
                        while (readed > 0)
                        {
                            byte[] data = new byte[10000];
                            readed = _datasocket.Receive(data);
                            fileStream.Write(data, 0, readed);
                        }
                    }

                    _datasocket.Shutdown(SocketShutdown.Both);
                    _datasocket.Close();
                    _datasocket = null;
                    GC.Collect();
                    SendMessage("226 Transfer Complete.");
                    _server.Call_Log(new FTPLogEventArgs(FTPLogEventType.AppendFile, _connuser, true, 226, file));
                }
                catch
                {
                    SendMessage("426 Connection closed; transfer aborted.");
                    _server.Call_Log(new FTPLogEventArgs(FTPLogEventType.AppendFile, _connuser, false, 426, file, "Transfer aborted"));
                }

                fileStream.Close();

            }
            else
            {
                SendMessage("550 Access denied");
                _server.Call_Log(new FTPLogEventArgs(FTPLogEventType.AppendFile, _connuser, false, 550, "Access denied"));
            }

        }
        #endregion

        #region RNFR
        private void RNFR(string CmdArguments)
        {
            string navpath;
            bool full = Fullpath(CmdArguments);
            if (full) navpath = CmdArguments;
            else navpath = _currentDir + "/" + CmdArguments;

            string dir = GetExactPath(navpath);
            if (DirectoryExists(dir) || FileExists(dir))
            {
                SendMessage("350 Please specify destination name.");
                _renamefrom = dir;
            }
            else SendMessage("550 File or directory doesn't exist.");
        }
        #endregion

        #region RNTO
        private void RNTO(string CmdArguments)
        {
            if (_currentperms.Rename)
            {
                string navpath;
                bool full = Fullpath(CmdArguments);
                if (full) navpath = CmdArguments;
                else navpath = _currentDir + "/" + CmdArguments;

                if (string.IsNullOrEmpty(_renamefrom))
                {
                    SendMessage("503 Bad sequence of commands.");
                    return;
                }
                string dir = GetExactPath(navpath);

                try
                {
                    if (File.Exists(_renamefrom))
                    {
                        File.Move(_renamefrom, dir);
                        SendMessage("250 File renamed");
                        _server.Call_Log(new FTPLogEventArgs(FTPLogEventType.Rename, _connuser, true, 250, _renamefrom, dir));

                    }
                    else if (Directory.Exists(_renamefrom))
                    {
                        Directory.Move(_renamefrom, dir);
                        SendMessage("250 Directory renamed");
                        _server.Call_Log(new FTPLogEventArgs(FTPLogEventType.Rename, _connuser, true, 250, _renamefrom, dir));
                    }
                    else
                    {
                        SendMessage("550 Error renaming file or directory");
                        _server.Call_Log(new FTPLogEventArgs(FTPLogEventType.Rename, _connuser, false, 550, _renamefrom, dir));
                    }
                }
                catch
                {
                    SendMessage("550 Error renaming file or directory");
                    _server.Call_Log(new FTPLogEventArgs(FTPLogEventType.Rename, _connuser, false, 550, _renamefrom, dir));
                }
            }
            else
            {
                SendMessage("550 Acces denied");
                _server.Call_Log(new FTPLogEventArgs(FTPLogEventType.Rename, _connuser, false, 550, "Acces denied"));
            }

        }
        #endregion

        #region RMD
        private void RMD(string CmdArguments)
        {
            if (_currentperms.Delete)
            {
                string navpath;
                bool full = Fullpath(CmdArguments);
                if (full) navpath = CmdArguments;
                else navpath = _currentDir + "/" + CmdArguments;

                string dir = GetExactPath(navpath);
                try
                {
                    if (DirectoryExists(CmdArguments))
                    {
                        Directory.Delete(dir);
                        SendMessage("250 \"" + dir + "\" directory deleted");
                        _server.Call_Log(new FTPLogEventArgs(FTPLogEventType.DeleteDirectory, _connuser, true, 250, dir));
                    }
                    else
                    {
                        SendMessage("550 Directory deletion failed.");
                        _server.Call_Log(new FTPLogEventArgs(FTPLogEventType.DeleteDirectory, _connuser, false, 550, dir));
                    }
                }
                catch
                {
                    SendMessage("550 Directory deletion failed.");
                    _server.Call_Log(new FTPLogEventArgs(FTPLogEventType.DeleteDirectory, _connuser, false, 550, dir));
                }
            }
            else
            {
                SendMessage("550 Acces denied");
                _server.Call_Log(new FTPLogEventArgs(FTPLogEventType.DeleteDirectory, _connuser, false, 550, "Acces denied"));
            }
        }
        #endregion

        #region MKD
        private void MKD(string CmdArguments)
        {
            if (_currentperms.Upload)
            {
                string navpath;
                bool full = Fullpath(CmdArguments);
                if (full) navpath = CmdArguments;
                else navpath = _currentDir + "/" + CmdArguments;

                string dir = GetExactPath(navpath);

                try
                {
                    Directory.CreateDirectory(dir);
                    SendMessage("257 \"" + dir + "\" directory created.");
                    _server.Call_Log(new FTPLogEventArgs(FTPLogEventType.MakeDirectory, _connuser, true, 257, dir));
                }
                catch
                {
                    SendMessage("550 Directory creation failed.");
                    _server.Call_Log(new FTPLogEventArgs(FTPLogEventType.MakeDirectory, _connuser, false, 550, dir));
                }
            }
            else
            {
                SendMessage("550 Acces denied");
                _server.Call_Log(new FTPLogEventArgs(FTPLogEventType.MakeDirectory, _connuser, false, 550, "Acces denied"));
            }
        }
        #endregion

        #region LIST
        private void LIST(string CmdArguments)
        {
            List<FTPListItem> items = ListDir(CmdArguments);
            _datasocket = GetDataSocket();
            if (_datasocket == null) return;

            try
            {
                StringBuilder sb = new StringBuilder();
                foreach (FTPListItem itm in items)
                {
                    sb.Append(itm.ToString());

                }
                if (_utf8) _datasocket.Send(System.Text.Encoding.UTF8.GetBytes(sb.ToString()));
                else _datasocket.Send(System.Text.Encoding.ASCII.GetBytes(sb.ToString()));
                SendMessage("226 Transfer Complete.");
                _server.Call_Log(new FTPLogEventArgs(FTPLogEventType.ListDirectory, _connuser, true, 226, _currentDir));
                _datasocket.Shutdown(SocketShutdown.Both);
                _datasocket.Close();
                _datasocket = null;
                GC.Collect();
            }
            catch
            {
                SendMessage("426 Connection closed; transfer aborted.");
                _server.Call_Log(new FTPLogEventArgs(FTPLogEventType.ListDirectory, _connuser, false, 426, _currentDir, "Transfer aborted"));
            }
        }
        #endregion

        #region NLST
        private void NLST(string CmdArguments)
        {
            List<FTPListItem> items = ListDir(GetExactPath(CmdArguments));
            _datasocket = GetDataSocket();
            if (_datasocket == null) return;

            try
            {

                foreach (FTPListItem itm in items)
                {
                    if (_utf8) _datasocket.Send(System.Text.Encoding.UTF8.GetBytes(itm.Name.ToString()));
                    else _datasocket.Send(System.Text.Encoding.ASCII.GetBytes(itm.Name.ToString()));
                }
                _datasocket.Shutdown(SocketShutdown.Both);
                _datasocket.Close();
                _datasocket = null;
                GC.Collect();

                SendMessage("226 Transfer Complete.");
                _server.Call_Log(new FTPLogEventArgs(FTPLogEventType.ListFileNames, _connuser, true, 226, _currentDir));
            }
            catch
            {
                SendMessage("426 Connection closed; transfer aborted.");
                _server.Call_Log(new FTPLogEventArgs(FTPLogEventType.ListFileNames, _connuser, false, 426, _currentDir, "Transfer aborted"));
            }
        }
        #endregion

        #region SIZE
        private void SIZE(string CmdArguments)
        {
            string navpath;
            bool full = Fullpath(CmdArguments);
            if (full) navpath = CmdArguments;
            else navpath = _currentDir + "/" + CmdArguments;

            try
            {
                FileInfo fi = new FileInfo(GetExactPath(_currentDir + "/" + CmdArguments));
                string resp = fi.Length.ToString();
                SendMessage("250 " + resp);
                _server.Call_Log(new FTPLogEventArgs(FTPLogEventType.FileSize, _connuser, true, 250, navpath));
            }
            catch
            {
                SendMessage("550 File not found");
                _server.Call_Log(new FTPLogEventArgs(FTPLogEventType.FileSize, _connuser, false, 550, navpath));
            }
        }
        #endregion

        #region MTDM
        private void MDTM(string CmdArguments)
        {
            string navpath;
            bool full = Fullpath(CmdArguments);
            if (full) navpath = CmdArguments;
            else navpath = _currentDir + "/" + CmdArguments;

            try
            {
                FileInfo fi = new FileInfo(GetExactPath(navpath));
                string resp = fi.LastWriteTime.ToString("yyyyMMddHHmmss", new CultureInfo("en-US"));
                SendMessage("250 " + resp);
                _server.Call_Log(new FTPLogEventArgs(FTPLogEventType.FileModificationDate, _connuser, true, 250, navpath));
            }
            catch
            {
                SendMessage("550 File not found");
                _server.Call_Log(new FTPLogEventArgs(FTPLogEventType.FileModificationDate, _connuser, false, 550, navpath));
            }
        }
        #endregion

        #region OPTS
        private void OPTS(string CmdArguments)
        {
            string option = CmdArguments.ToUpper();
            switch (option)
            {
                case "UTF8 ON":
                    _utf8 = true;
                    SendMessage("200 UTF-8 Enabled");
                    _server.Call_Log(new FTPLogEventArgs(FTPLogEventType.OptionReceived, _connuser, true, 200, option));
                    break;
                case "UTF8 OFF":
                    _utf8 = false;
                    SendMessage("200 UTF-8 Disabled");
                    _server.Call_Log(new FTPLogEventArgs(FTPLogEventType.OptionReceived, _connuser, true, 200, option));
                    break;
                default:
                    SendMessage("504 Unrecognised option");
                    _server.Call_Log(new FTPLogEventArgs(FTPLogEventType.OptionReceived, _connuser, false, 200, option));
                    break;
            }
        }
        #endregion

        #region REIN
        private void REIN(string CmdArguments)
        {
            _connuser = null;
            _isAuthenticated = false;
            _currentperms.Reset();
            SendMessage("200 Connection reinitialized");
            _server.Call_Log(new FTPLogEventArgs(FTPLogEventType.ConnectionReinitialize, _connuser, true, 200));
        }
        #endregion

        #region Helper Functions
        private string GetExactPath(string path)
        {
            if (path == null) path = "";
            if (!path.StartsWith("/")) path = "/" + path;
            string local = _localpath + path.Replace("/", "\\");
            local = local.Replace("\\\\", "\\");
            return local;
        }

        private void SendMessage(string Data)
        {
            if (Data == null || Data == string.Empty) return;
            try
            {
                if (!Data.EndsWith("\r\n")) Data += "\r\n";
                byte[] rawdata = _utf8 ? Encoding.UTF8.GetBytes(Data) : Encoding.ASCII.GetBytes(Data);
                _clientSocket.Send(rawdata);
            }
            catch { Disconnect(); }
        }

        private bool DirectoryExists(string path)
        {
            return Directory.Exists(GetExactPath(path));
        }

        private bool FileExists(string path)
        {
            return File.Exists(GetExactPath(path));
        }

        private Socket GetDataSocket()
        {
            Socket DataSocket = null;
            try
            {
                if (DataTransferEnabled)
                {
                    int Count = 0;
                    while (!DataListener.Pending())
                    {
                        Thread.Sleep(1000);
                        Count++;
                        // Time out after 30 seconds
                        if (Count > 29)
                        {
                            SendMessage("425 Data Connection Timed out");
                            return null;
                        }
                    }

                    DataSocket = DataListener.AcceptSocket();
                    SendMessage("125 Connected, Starting Data Transfer.");
                }
                else
                {
                    SendMessage("150 Connecting.\r\n");
                    DataSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    bool suces = false;
                    for (int i = 0; i < ClientEndPoints.Length; i++)
                    {
                        try
                        {
                            DataSocket.Connect(ClientEndPoints[i]);
                            suces = true;
                            SendMessage("125 Connected, Starting Data Transfer.");
                            break;
                        }
                        catch { }
                    }
                    if (!suces) throw new Exception();
                }
            }
            catch
            {
                SendMessage("425 Can't open data connection.");
                return null;
            }
            finally
            {
                if (DataListener != null)
                {
                    DataListener.Stop();
                    DataListener = null;
                    GC.Collect();
                }
            }

            DataTransferEnabled = false;

            return DataSocket;
        }

        private List<FTPListItem> ListDir(string path)
        {
            List<FTPListItem> ret = new List<FTPListItem>();
            if (!_server.VFS.PathExists(path))
            {
                string[] dirs = Directory.GetDirectories(GetExactPath(path));
                string[] files = Directory.GetFiles(GetExactPath(path));
                FTPListItem tmp;
                DirectoryInfo di;
                FileInfo fi;

                foreach (string dir in dirs)
                {
                    di = new DirectoryInfo(dir);
                    if ((((di.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden) ||
                        ((di.Attributes & FileAttributes.System) == FileAttributes.System)) &&
                        !_currentperms.ListHidden) continue;
                    else
                    {
                        tmp = new FTPListItem(dir);
                        tmp.IsDir = true;
                        tmp.Date = di.LastWriteTime;
                        ret.Add(tmp);
                    }
                }

                foreach (string file in files)
                {
                    fi = new FileInfo(file);
                    if ((((fi.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden) ||
                        ((fi.Attributes & FileAttributes.System) == FileAttributes.System)) &&
                        !_currentperms.ListHidden) continue;
                    else
                    {
                        tmp = new FTPListItem(file);
                        tmp.IsDir = false;
                        tmp.Date = fi.LastWriteTime;
                        tmp.Size = fi.Length;
                        ret.Add(tmp);
                    }
                }
            }

            VFS.VFSDirectory vdir = _server.VFS.GetDirectory(path);
            if (vdir != null) ret.AddRange(vdir.ListDirectory());
            //ret.AddRange(_server.VFS.GetFilesOfDir(path));

            return ret;
        }

        private bool Fullpath(string path)
        {
            if (path.Split('/').Length > 1) return true;
            else return false;
        }
        #endregion
    }
}