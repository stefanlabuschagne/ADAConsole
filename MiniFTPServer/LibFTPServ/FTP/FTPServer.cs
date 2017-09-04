using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Timers;
using LibFTPServ.VFS;

namespace LibFTPServ.FTP
{
    /// <summary>
    /// FTP server class
    /// </summary>
    public class FTPServer
    {
        private TcpListener FTPListener;
        private int _port, _pass_min, _pass_max;
        private string _startdir;
        private List<IPAddress> _banlist;
        private List<IPAddress> _acceptlist;
        private List<FTPSession> FTPClients;
        private UserManager _userlist;
        private int _maxInactiveTime;
        private Timer DisconectInactive;
        private VFSManager _VFS;
        private int _dlLimit, _ulLumit;

        /// <summary>
        /// Creates a new Instance of FTPServer
        /// </summary>
        public FTPServer()
        {
            FTPClients = new List<FTPSession>();
            _pass_min = 20000;
            _pass_max = 40000;
            _dlLimit = -1;
            _ulLumit = -1;
            _banlist = new List<IPAddress>();
            _acceptlist = new List<IPAddress>();
            _userlist = new UserManager();
            _port = 21;
            _maxInactiveTime = 30;
            _VFS = new VFSManager();
            DisconectInactive = new Timer(_maxInactiveTime * 1000);
            DisconectInactive.Elapsed += new ElapsedEventHandler(DisconectInactive_Elapsed);
        }

        void DisconectInactive_Elapsed(object sender, ElapsedEventArgs e)
        {
            TimeSpan ts;
            List<FTPSession> remove = new List<FTPSession>();
            foreach (FTPSession s in FTPClients)
            {
                ts = DateTime.Now - s.LastCommandTime;
                if (ts.TotalSeconds > _maxInactiveTime) remove.Add(s);
            }

            foreach (FTPSession rs in remove)
            {
                rs.Disconnect();
                FTPClients.Remove(rs);
            }
        }


        internal void RemoveClient(FTPSession s)
        {
            this.FTPClients.Remove(s);
        }

        #region Properties
        internal string Status
        {
            get { if (FTPListener == null)return "value=\"0\""; else return "value=\"1\" checked"; }
        }

        public int InactiveClientTimeOut
        {
            get { return _maxInactiveTime; }
            set 
            { 
                _maxInactiveTime = value;
                DisconectInactive.Interval = 1000 * _maxInactiveTime;
            }
        }

        internal bool IsRunning
        {
            get { return FTPListener != null; }
        }

        /// <summary>
        /// Gets or sets the ftp default port
        /// </summary>
        public int Port
        {
            get { return _port; }
            set
            {
                if (IsRunning) throw new InvalidOperationException("Port can only be changed when server is not running");
                _port = value;
            }
        }

        /// <summary>
        /// Gets or sets the minumum passive port number
        /// </summary>
        public int PassivePortMinimum
        {
            get { return _pass_min; }
            set
            {
                if (IsRunning) throw new InvalidOperationException("PassivePortMinum can only be changed when server is not running");
                _pass_min = value;
            }
        }

        /// <summary>
        /// Gets or sets the maximum passive port number
        /// </summary>
        public int PassivePortMaximum
        {
            get { return _pass_max; }
            set
            {
                if (IsRunning) throw new InvalidOperationException("PassivePortMaximum can only be changed when server is not running");
                _pass_max = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the global startup directory
        /// </summary>
        public string StartupDir
        {
            get { return _startdir; }
            set
            {
                if (IsRunning) throw new InvalidOperationException("Start dir can only be changed when server is not running");
                _startdir = value;
            }
        }

        /// <summary>
        /// Gets the List of Banned Adresses on the server
        /// </summary>
        public List<IPAddress> BannedAdresses
        {
            get { return _banlist; }
        }

        /// <summary>
        /// Gets the always accepted list of Adresses on the server
        /// </summary>
        public List<IPAddress> AcceptedAdresses
        {
            get { return _acceptlist; }
        }

        /// <summary>
        /// Gets the user manager associated to this server
        /// </summary>
        public UserManager Users
        {
            get { return _userlist; }
        }


        /// <summary>
        /// Gets or sets the Server downlaod speed limit in Bytes/second. -1 is disabled
        /// </summary>
        public int DownloadSpeedLimit
        {
            get { return _dlLimit; }
            set { _dlLimit = value; }
        }

        /// <summary>
        /// Gets or sets the Server upload speed limit in Bytes/second. -1 disabled
        /// </summary>
        public int UploadSpeedLimit
        {
            get { return _ulLumit; }
            set { _ulLumit = value; }
        }

        public VFSManager VFS
        {
            get { return _VFS; }
            set 
            {
                if (IsRunning) throw new InvalidOperationException("VFS can only be changed when server is not running");
                _VFS = value;
            }
        }

        #endregion

        /// <summary>
        /// Starts the server
        /// </summary>
        public void Start()
        {
            Stop();

            FTPListener = new TcpListener(IPAddress.Any, _port);
            FTPListener.Start(20);
            //DisconectInactive.Start();
            // Start accepting the incoming clients.
            FTPListener.BeginAcceptSocket(new AsyncCallback(NewFTPClientArrived), null);
        }

        /// <summary>
        /// Stops the server
        /// </summary>
        public void Stop()
        {
            if (FTPListener != null)
            {
                FTPListener.Stop();
                DisconectInactive.Stop();
                FTPListener = null;
            }
        }

        private void NewFTPClientArrived(IAsyncResult arg)
        {
            try
            {
                FTPClients.Add(new FTPSession(FTPListener.EndAcceptSocket(arg), this, _startdir));
                FTPListener.BeginAcceptSocket(new AsyncCallback(NewFTPClientArrived), null);
            }
            catch { }
        }

        #region Events

        /// <summary>
        /// Event occures when a Logable event occures.
        /// </summary>
        public event FTPLogEventHandler OnLogEvent;

        internal virtual void Call_Log(FTPLogEventArgs e)
        {
            if (OnLogEvent != null) OnLogEvent(this, e);
        }

        #endregion
    }
}