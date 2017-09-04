using System;

namespace LibFTPServ.FTP
{
    /// <summary>
    /// Event Type Enumeration
    /// </summary>
    public enum FTPLogEventType
    {
        /// <summary>
        /// Occures when a user trys to connect to the server
        /// </summary>
        UserConnect,
        
        /// <summary>
        /// Occures when a user disconects from the server
        /// </summary>
        UserDisconnect,
        
        /// <summary>
        /// Occures when a cwd command recived
        /// </summary>
        ChangeWorkDir,
        
        /// <summary>
        /// Occures when a dele command recived
        /// </summary>
        DeleteFile,
        
        /// <summary>
        /// Occures when a list command is recived
        /// </summary>
        ListDirectory,

        /// <summary>
        /// Occures when a mkd command is recived
        /// </summary>
        MakeDirectory,
        
        /// <summary>
        /// Occures when a nlst command is recived
        /// </summary>
        ListFileNames,

        /// <summary>
        /// Occures when a pasv command is recived
        /// </summary>
        PassiveMode,

        /// <summary>
        /// Occures when a port command is recived
        /// </summary>
        PortCommand,

        /// <summary>
        /// Occures when a retr command is recived
        /// </summary>
        DownloadFile,

        /// <summary>
        /// Occures when a rmd command is recived
        /// </summary>
        DeleteDirectory,

        /// <summary>
        /// Occures when a rnfr and rnto command pair is recived
        /// </summary>
        Rename,

        /// <summary>
        /// Occures wehen a stor coomand is recived
        /// </summary>
        UploadFile,

        /// <summary>
        /// Occures when a type command is recived
        /// </summary>
        ChangeType,

        /// <summary>
        /// Occures when an appe command is recived
        /// </summary>
        AppendFile,


        /// <summary>
        /// Occures when a size command is recived
        /// </summary>
        FileSize,

        /// <summary>
        /// Occures when a mtdm command is recived
        /// </summary>
        FileModificationDate,

        /// <summary>
        /// Occures when an opts command is recived
        /// </summary>
        OptionReceived,

        /// <summary>
        /// Occures when a rein command is recived
        /// </summary>
        ConnectionReinitialize,

        /// <summary>
        /// Occures when an abor commnad is recived
        /// </summary>
        Abort,

        /// <summary>
        /// Occures when a feat command is recived
        /// </summary>
        FeatureList,

        /// <summary>
        /// Occures when an unknown command is recived
        /// </summary>
        UnknownCommand
    }

    /// <summary>
    /// Log Event args
    /// </summary>
    public class FTPLogEventArgs: EventArgs
    {
        private DateTime _date;
        private FTPLogEventType _type;
        private bool _eventsucces;
        private string[] _arguments;
        private int _responsecode;
        private string _user;

        /// <summary>
        /// Creates a new instance of LogEventArgs
        /// </summary>
        /// <param name="EventType">The Type of the event</param>
        /// <param name="User">Current FTP User</param>
        /// <param name="Succes">Completed succesfully or not</param>
        /// <param name="Response">Server Response code</param>
        /// <param name="arguments">Event specific arguments</param>
        public FTPLogEventArgs(FTPLogEventType EventType, string User, bool Succes, int Response,params string[] arguments)
        {
            _date = DateTime.Now;
            _type = EventType;
            _eventsucces = Succes;
            _arguments = arguments;
            _responsecode = Response;
            _user = User;
        }

        /// <summary>
        /// The Date and Time of the event
        /// </summary>
        public DateTime EventDate
        {
            get { return _date; }
        }

        /// <summary>
        /// Gets if the Event raising command completed succesfully or not
        /// </summary>
        public bool Succes
        {
            get { return _eventsucces; }
        }

        /// <summary>
        /// Gets the user associated to the event
        /// </summary>
        public string User
        {
            get { return _user; }
        }

        /// <summary>
        /// Event type
        /// </summary>
        public FTPLogEventType EventType
        {
            get { return _type; }
        }

        /// <summary>
        /// Event Arguments related to the event type
        /// </summary>
        public string[] arguments
        {
            get { return _arguments; }
        }

        /// <summary>
        /// Gets the server Response code for the event
        /// </summary>
        public int Response
        {
            get { return _responsecode; }
        }

        /// <summary>
        /// Gets a specific event argument
        /// </summary>
        /// <param name="index">the index of the event argument to get</param>
        /// <returns>The the specific event argument</returns>
        public string this[int index]
        {
            get { return _arguments[index]; }
        }

        /// <summary>
        /// Gets the count of the event arguments
        /// </summary>
        public int Length
        {
            get { return _arguments.Length; }
        }
    }

    public delegate void FTPLogEventHandler(object sender, FTPLogEventArgs e);
}
