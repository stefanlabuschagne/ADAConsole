using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Collections;
using System.Threading;

namespace VulindlelaFTPServer
{
    internal class FTPClient
    {
        #region Construction
        internal DateTime ConnectedTime;
        internal DateTime LastInteraction;

        // Used inside PORT method
        IPEndPoint ClientEndPoint = null;
        internal string SessionID
        {
            get
            {
                return ConnectedTime.Ticks.ToString();
            }
        }
        Socket ClientSocket;
        internal FTPUser ConnectedUser;

        internal string EndPoint
        {
            get
            {
                return ClientSocket.RemoteEndPoint.ToString();
            }
        }

        internal bool IsConnected
        {
            get
            {
                if (ClientSocket == null || !ClientSocket.Connected || ConnectedTime.ToString("HH:mm:ss") == LastInteraction.ToString("HH:mm:ss")) { Disconnect(); return false; }
                return true;
            }
        }

        bool DataTransferEnabled = false;
        TcpListener DataListener = null;

        //string Rename_FilePath="";

        byte[] BufferData = new byte[500];

        internal FTPClient(Socket ClientSocket)
        {
            this.ClientSocket = ClientSocket;
            //SubItems[1].Text = ClientSocket.RemoteEndPoint.ToString(); 
            ClientSocket.NoDelay = false;
            ConnectedTime = DateTime.Now;

            ConnectedUser = new FTPUser();
            //SubItems[3].Text = SubItems[4].Text = (CurrentUser.ConnectedTime = DateTime.Now).ToString("MMM dd, yyyy hh:mm:ss");

            // Report the client that the server is ready to serve.
            SendMessage("220 FTP Ready\r\n");

            // Wait for the command to be sent by the client
            ClientSocket.BeginReceive(BufferData, 0, BufferData.Length, SocketFlags.None, new AsyncCallback(CommandReceived), null);
            //ClientStream.BeginRead(BufferData, 0, BufferData.Length, new AsyncCallback(CommandReceived), null);
        }

        void CommandReceived(IAsyncResult arg)
        {
            #region Read and Parse commands
            int CommandSize = 0;
            try
            {
                CommandSize = ClientSocket.EndReceive(arg);
            }
            catch { }
            if (CommandSize == 0)
            {
                Disconnect(); return;
            }

            // Wait for the next command to be sent by the client
            try
            {
                ClientSocket.BeginReceive(BufferData, 0, BufferData.Length, SocketFlags.None, new AsyncCallback(CommandReceived), null);
            }
            catch { Disconnect(); }

            LastInteraction = DateTime.Now;
            string CommandText = Encoding.ASCII.GetString(BufferData, 0, CommandSize).TrimStart(' ');
            string CmdArguments = null, Command = null;
            int End = 0;
            if ((End = CommandText.IndexOf(' ')) == -1) End = (CommandText = CommandText.Trim()).Length;
            else CmdArguments = CommandText.Substring(End).TrimStart(' ');
            Command = CommandText.Substring(0, End).ToUpper();

            #endregion

            #region Execute Commands
            if (CmdArguments != null && CmdArguments.EndsWith("\r\n")) CmdArguments = CmdArguments.Substring(0, CmdArguments.Length - 2);
            bool CommandExecued = false;
            switch (Command)
            {
                case "USER":
                    if (CmdArguments != null && CmdArguments.Length > 0)
                    {
                        SendMessage("331 Password required!\r\n");
                        ConnectedUser.LoadProfile(CmdArguments.ToUpper());
                    }
                    CommandExecued = true;
                    break;
                case "PASS":
                    if (ConnectedUser.UserName == "")
                    {
                        SendMessage("503 Invalid User Name\r\n");
                        return;
                    }

                    if (ConnectedUser.Authenticate(CmdArguments))
                        SendMessage("230 Authentication Successful\r\n");
                    else SendMessage("530 Authentication Failed!\r\n");
                    CommandExecued = true;
                    break;
            }
            if (!CommandExecued)
            {
                if (ConnectedUser.IsAuthenticated)
                    switch (Command)
                    {
                        case "CDUP": CDUP(CmdArguments); break;
                        case "QUIT": SendMessage("221 FTP server signing off\r\n"); Disconnect(); break;
                        case "PORT": PORT(CmdArguments); break;
                        case "PASV": PASV(CmdArguments); break;
                        case "TYPE": TYPE(CmdArguments); break;
                        case "RETR": RETR(CmdArguments); break;
                        case "CWD":
                            string dir = GetExactPath(CmdArguments);
                            if (ConnectedUser.ChangeDirectory(dir)) 
								SendMessage("250 CWD command successful.\r\n");
                            else SendMessage("550 System can't find directory '" + dir + "'.\r\n"); 
							break;
                        case "STOR": STOR(CmdArguments); break;
                        case "APPE": APPE(CmdArguments); break;
                        case "RNFR": RNFR(CmdArguments); break;
                        case "RNTO": RNTO(CmdArguments); break;
                        case "PWD": SendMessage("257 \"" + ConnectedUser.CurrentWorkingDirectory.Replace('\\', '/') + "\"\r\n"); break;
                        case "LIST": LIST(CmdArguments); break;
                        case "NLST": NLST(CmdArguments); break;
                        case "NOOP": SendMessage("200 OK\r\n"); break;
                        default: SendMessage("500 Unknown Command.\r\n"); break;
                    }
                else SendMessage("530 Access Denied! Authenticate first\r\n");
            }
            #endregion
        }

        #endregion

        #region Command Methods

        void CDUP(string CmdArguments)
        {
            string[] pathParts = ConnectedUser.CurrentWorkingDirectory.Split('\\');
            if (pathParts.Length > 1)
            {
                ConnectedUser.CurrentWorkingDirectory = "";
                for (int i = 0; i < (pathParts.Length - 2); i++)
                {
                    ConnectedUser.CurrentWorkingDirectory += pathParts[i] + "\\";
                }
            }
            SendMessage("250 CDUP command successful.\r\n");
        } // OK

        void RETR(string CmdArguments)
        {
            string ReturnMessage = String.Empty;
            FileStream FS = null;
            Socket DataSocket = null;

            try
            {
                string Path = VulindlelaFTPServer.Properties.Settings.Default.FTPRoot + GetExactPath(CmdArguments);
                Path = Path.Substring(0, Path.Length - 1);

                FS = new FileStream(Path, FileMode.Open, FileAccess.Read, FileShare.Read);
            }
            catch
            {
                ReturnMessage = "550 Access denied or invalid path!\r\n";
                goto FinaliseAll;
            }

            DataSocket = GetDataSocket();
            if (DataSocket == null)
                goto FinaliseAll;

            try
            {
                byte[] data = new byte[(FS.Length > 100000) ? 100000 : (int)FS.Length];
                while (DataSocket.Send(data, 0, FS.Read(data, 0, data.Length), SocketFlags.None) != 0) ;
                ReturnMessage = "226 Transfer Complete.\r\n";
            }
            catch
            {
                ReturnMessage = "426 Transfer aborted.\r\n";
            }

        FinaliseAll:
            if (FS != null) FS.Close(); FS = null;
            if (DataSocket != null && DataSocket.Connected)
            {
                DataSocket.Shutdown(SocketShutdown.Both);
                DataSocket.Close();
            }
            DataSocket = null;
            SendMessage(ReturnMessage);
        }

        void STOR(string CmdArguments)
        {
            SendMessage("426 Access Denied.\r\n");
            return;
        }

        void DELE(string CmdArguments)
        {
            SendMessage("550 Access Denied.\r\n");
        }

        void APPE(string CmdArguments)
        {
            SendMessage("550 Access Denied.\r\n");
        }

        void RNFR(string CmdArguments)
        {
            SendMessage("550 Access Denied.\r\n");
        }

        void RNTO(string CmdArguments)
        {
            SendMessage("550 Access Denied.\r\n");
        }

        void RMD(string CmdArguments)
        {
            SendMessage("550 Access Denied.\r\n");
        }

        void MKD(string CmdArguments)
        {
            SendMessage("550 Access Denied.\r\n");
        }
        
        void LIST(string CmdArguments)
        {
            string Path = ConnectedUser.RootDirectory + GetExactPath(CmdArguments);
            Socket DataSocket = GetDataSocket();
            if (DataSocket == null)
            {
                return;
            }

            try
            {
                string[] FilesList = Directory.GetFiles(Path, "*.*", SearchOption.TopDirectoryOnly);
                string[] FoldersList = Directory.GetDirectories(Path, "*.*", SearchOption.TopDirectoryOnly);
                string strFilesList = "";

                foreach (string Folder in FoldersList)
                {
                    string date = Directory.GetCreationTime(Folder).ToString("MM-dd-yy hh:mmtt");
                    strFilesList += date + " <DIR> " + Folder.Substring(Folder.Replace('\\', '/').LastIndexOf('/') + 1) + "\r\n";
                }
                
                foreach (string FileName in FilesList)
                {
                    string date = File.GetCreationTime(FileName).ToString("MM-dd-yy hh:mmtt");
                    strFilesList += date + " " + new FileInfo(FileName).Length.ToString() + " " + FileName.Substring(FileName.Replace('\\', '/').LastIndexOf('/') + 1) + "\r\n";
                }

                DataSocket.Send(System.Text.Encoding.Default.GetBytes(strFilesList));
                SendMessage("226 Transfer Complete.\r\n");
            }
            catch (DirectoryNotFoundException)
            {
                SendMessage("550 Invalid path specified.\r\n");
            }
            catch
            {
                SendMessage("426 Connection closed; transfer aborted.\r\n");
            }
            finally
            {
                DataSocket.Shutdown(SocketShutdown.Both);
                DataSocket.Close(); DataSocket = null;
            }
        }

        void NLST(string CmdArguments)
        {
            string Path = ConnectedUser.RootDirectory + GetExactPath(CmdArguments);
            if (!Directory.Exists(Path))
            {
                SendMessage("550 Invalid Path.\r\n");
                return;
            }

            Socket DataSocket = GetDataSocket();
            if (DataSocket == null)
            {
                return;
            }

            try
            {
                string[] FoldersList = Directory.GetDirectories(Path, "*.*", SearchOption.TopDirectoryOnly);
                string FolderList = "";
                foreach (string Folder in FoldersList)
                {
                    FolderList += Folder.Substring(Folder.Replace('\\', '/').LastIndexOf('/') + 1) + "\r\n";
                }
                DataSocket.Send(System.Text.Encoding.Default.GetBytes(FolderList));
                DataSocket.Shutdown(SocketShutdown.Both);
                DataSocket.Close();

                SendMessage("226 Transfer Complete.\r\n");
            }
            catch
            {
                SendMessage("426 Connection closed; transfer aborted.\r\n");
            }
        }

        void TYPE(string CmdArguments)
        {
            if ((CmdArguments = CmdArguments.Trim().ToUpper()) == "A" || CmdArguments == "I")
                SendMessage("200 Type " + CmdArguments + " Accepted.\r\n");
            else SendMessage("500 Unknown Type.\r\n");
        }

        void PORT(string CmdArguments)
        {
            string[] IP_Parts = CmdArguments.Split(',');
            if (IP_Parts.Length != 6)
            {
                SendMessage("550 Invalid arguments.\r\n");
                return;
            }

            string ClientIP = IP_Parts[0] + "." + IP_Parts[1] + "." + IP_Parts[2] + "." + IP_Parts[3];
            int tmpPort = (Convert.ToInt32(IP_Parts[4]) << 8) | Convert.ToInt32(IP_Parts[5]);

            ClientEndPoint = new IPEndPoint(Dns.GetHostEntry(ClientIP).AddressList[0], tmpPort);

            DataTransferEnabled = false;

            SendMessage("200 Ready to connect to " + ClientIP + "\r\n");
        }

        void PASV(string CmdArguments)
        {
            // Open listener within the specified port range
            int tmpPort = ApplicationSettings.MinPassvPort;
        StartListener:
            if (DataListener != null) { DataListener.Stop(); DataListener = null; }
            try
            {
                DataListener = new TcpListener(IPAddress.Any, tmpPort);
                DataListener.Start();
            }
            catch
            {
                if (tmpPort < ApplicationSettings.MaxPassvPort)
                {
                    tmpPort++;
                    goto StartListener;
                }
                else
                {
                    SendMessage("500 Action Failed Retry\r\n");
                    return;
                }
            }

            //string tmpEndPoint = DataListener.LocalEndpoint.ToString();
            //tmpPort = Convert.ToInt32(tmpEndPoint.Substring(tmpEndPoint.IndexOf(':') + 1));

            string SocketEndPoint = ClientSocket.LocalEndPoint.ToString();
            SocketEndPoint = SocketEndPoint.Substring(0, SocketEndPoint.IndexOf(":")).Replace(".", ",") + "," + (tmpPort >> 8) + "," + (tmpPort & 255);
            DataTransferEnabled = true;

            SendMessage("227 Entering Passive Mode (" + SocketEndPoint + ").\r\n");
        }

        #endregion

        #region General Methods

        internal void Disconnect()
        {
            if (ClientSocket != null && ClientSocket.Connected) ClientSocket.Close(); ClientSocket = null;
            if (DataListener != null) DataListener.Stop(); DataListener = null;
            ClientEndPoint = null;
            ConnectedUser = null;

            BufferData = null;
            //Rename_FilePath = null;
            VulindlelaFTPServer.FTPServer.FTPClients.Remove(this);
            GC.Collect();
        }

        void SendMessage(string Data)
        {
            if (Data == null || Data == string.Empty) return;
            try
            {
                ClientSocket.Send(Encoding.ASCII.GetBytes(Data));
            }
            catch { Disconnect(); }
        }

        string GetExactPath(string Path)
        {
            if (Path == null) Path = "";

            string dir = Path.Replace("/", "\\");

            if (!dir.EndsWith("\\")) dir += "\\";

            if (!Path.StartsWith("/")) dir = ConnectedUser.CurrentWorkingDirectory + dir;

            ArrayList pathParts = new ArrayList();
            dir = dir.Replace("\\\\", "\\");
            string[] p = dir.Split('\\');
            pathParts.AddRange(p);

            for (int i = 0; i < pathParts.Count; i++)
            {
                if (pathParts[i].ToString() == "..")
                {
                    if (i > 0)
                    {
                        pathParts.RemoveAt(i - 1);
                        i--;
                    }

                    pathParts.RemoveAt(i);
                    i--;
                }
            }

            return dir.Replace("\\\\", "\\");
        }

        Socket GetDataSocket()
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
                            SendMessage("425 Data Connection Timed out\r\n");
                            return null;
                        }
                    }

                    DataSocket = DataListener.AcceptSocket();
                    SendMessage("125 Connected, Starting Data Transfer.\r\n");
                }
                else
                {
                    SendMessage("150 Connecting.\r\n");
                    DataSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    DataSocket.Connect(ClientEndPoint);
                }
            }
            catch
            {
                SendMessage("425 Can't open data connection.\r\n");
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

        #endregion
    }
}