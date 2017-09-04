using System;
using System.Globalization;

namespace LibFTPServ.FTP
{
    /// <summary>
    /// An FTP User management class
    /// </summary>
    [Serializable]
    public class FTPUser
    {
        /// <summary>
        /// The Name of the user
        /// </summary>
        public string Name;
        
        /// <summary>
        /// The SHA1 hash of the user's password
        /// </summary>
        public string SHA1Password;

        /// <summary>
        /// The home directory of the userr
        /// </summary>
        public string Startupdir;

        /// <summary>
        /// The Permissions associated to the user
        /// </summary>
        public FTPUserPermission Permissions;


        /// <summary>
        /// Creates a new instance of FTPUser
        /// </summary>
        public FTPUser()
        {
            Permissions = new FTPUserPermission();
            Startupdir = "/";
        }

        /// <summary>
        /// Creates a new instance of FTPUser
        /// </summary>
        /// <param name="name">The name of the user</param>
        /// <param name="pass">The desired password for the user</param>
        public FTPUser(string name, string pass)
        {
            Permissions = new FTPUserPermission();
            Name = name;
            Startupdir = "/";
            SHA1Password = HelperFunctions.SHA1Hash(pass);
        }

        public void SetPassword(string pass)
        {
            SHA1Password = HelperFunctions.SHA1Hash(pass);
        }

        /// <summary>
        /// Creates a new instance of FTPUser
        /// </summary>
        /// <param name="name">The name of the user</param>
        /// <param name="pass">The desired password for the user</param>
        /// <param name="dir">The startup directory of the user</param>
        public FTPUser(string name, string pass, string dir): this(name, pass)
        {
            Startupdir = dir;
        }

        /// <summary>
        /// Returns a new Anonymus user
        /// </summary>
        public static FTPUser Anonymus
        {
            get
            {
                return new FTPUser("Anonymus", "");
            }
        }
    }

    internal class FTPListItem
    {
        public string Name;
        public bool IsDir;
        public long Size;
        public DateTime Date;

        public FTPListItem()
        {
            Name = "";
            IsDir = true;
            Size = 0;
            Date = DateTime.Now;
        }

        public FTPListItem(string name): this()
        {
            Name = name;
        }

        public override string ToString()
        {
            string datestr = Date.ToString("MM-dd-yy hh:mmtt", new CultureInfo("en-US"));
            if (IsDir) return datestr + " <DIR> " + Name.Substring(Name.Replace('\\', '/').LastIndexOf('/') + 1) + "\r\n";
            else return datestr + " " + Size.ToString() + " " + Name.Substring(Name.Replace('\\', '/').LastIndexOf('/') + 1) + "\r\n";
        } 
    }


    /// <summary>
    /// FTP User Permission management class
    /// </summary>
    [Serializable]
    public class FTPUserPermission
    {
        /// <summary>
        /// The User can upload
        /// </summary>
        public bool Upload;
        
        /// <summary>
        /// The user can delete files
        /// </summary>
        public bool Delete;

        /// <summary>
        /// The user can rename files
        /// </summary>
        public bool Rename;

        /// <summary>
        /// The user can see hidden files on directory and name list
        /// </summary>
        public bool ListHidden;

        /// <summary>
        /// Resets the current users permissions to default
        /// </summary>
        public void Reset()
        {
            Upload = false;
            Delete = false;
            Rename = false;
            ListHidden = false;
        }
    }
}
