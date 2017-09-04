using System;
using System.IO;
using System.Xml;
using System.Net;
using System.Text;
using System.Data;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.DirectoryServices;
using System.DirectoryServices.ActiveDirectory;
using System.DirectoryServices.AccountManagement;
using Microsoft.VisualBasic;
using System.Collections.Specialized;

namespace VulindlelaFTPServer
{
    enum SettingsKey
    {
        MAX_PASSV_PORT,
        MIN_PASSV_PORT,
        FTP_PORT,
        AUTO_START_FTP,
        ENABLE_FTP_LOGGING,
        ENABLE_NOTIFY_ICON,
        ENABLE_FTPFOLDER_ICON,
        ENABLE_QUICK_CONFIG_MENU,
        AUTO_SEND_ERROR_REPORT,
        MOVE_FILES_TO_RECYCLE_BIN,
        DATE_TIME_FORMAT
    }

    internal partial class ApplicationSettings
    {
        #region Declerations

        internal static XmlDocument Settings = null;
        internal static FTPServer FtpServer;
        internal static DriveInfo[] Drives;
        static string _HostName = null, _DataPath = null;

        #endregion

        #region Properties

        #region Other Settings

        internal static string DataPath
        {
            get
            {
                return _DataPath;
            }
        }
        internal static bool AutoStartFTP = Convert.ToBoolean(Properties.Settings.Default.AUTO_START_FTP);
        internal static bool EnableFTPLogging = Convert.ToBoolean(Properties.Settings.Default.ENABLE_FTP_LOGGING);
        internal static string HostName
        {
            get
            {
                return _HostName;
            }
        }
        internal static int FTPPort
        {
            get
            {
                return Convert.ToInt32(Properties.Settings.Default.FTP_PORT);
            }
            set
            {
                value.ToString();
            }
        }
        internal static int MaxPassvPort
        {
            get
            {
                return Convert.ToInt32(Properties.Settings.Default.MAX_PASSV_PORT);
            }
            set
            {
                value.ToString();
            }
        }
        internal static int MinPassvPort
        {
            get
            {
                return Convert.ToInt32(Properties.Settings.Default.MIN_PASSV_PORT);
            }
            set
            {
                value.ToString();
            }
        }

        #endregion

        #region General settings

        internal static bool EnableNotifyIcon
        {
            get
            {
                return Convert.ToBoolean(Properties.Settings.Default.ENABLE_NOTIFY_ICON);
            }
            set
            {
                Convert.ToBoolean(value);
            }
        }
        internal static bool ChangeFTPFoldersIcon
        {
            get
            {
                return Convert.ToBoolean(VulindlelaFTPServer.Properties.Settings.Default.ENABLE_FTPFOLDER_ICON);
            }
            set
            {
                if (Convert.ToBoolean(VulindlelaFTPServer.Properties.Settings.Default.ENABLE_FTPFOLDER_ICON))
                {
                    if (!value)
                    {
                        XmlNodeList UserList = FTPUser.GetFTPUserGroups();

                        foreach (XmlNode User in UserList)
                            RemoveFolderIcon(User.Attributes["Root"].Value);
                    }
                }
                else
                {
                    if (value)
                    {
                        XmlNodeList UserList = FTPUser.GetFTPUserGroups();

                        foreach (XmlNode User in UserList)
                            SetFolderIcon(User.Attributes["Root"].Value);
                    }
                }
                VulindlelaFTPServer.Properties.Settings.Default.ENABLE_FTPFOLDER_ICON = value;
            }
        }
        internal static bool EnableQuickConfigMenu
        {
            get
            {
                return Convert.ToBoolean(VulindlelaFTPServer.Properties.Settings.Default.ENABLE_QUICK_CONFIG_MENU);
            }
            set
            {
                Convert.ToBoolean(value);
            }
        }
        internal static bool AutoSendErrorReport = false;
        internal static string DateTimeFormat
        {
            get
            {
                return Convert.ToString(VulindlelaFTPServer.Properties.Settings.Default.DATE_TIME_FORMAT);
            }
            set
            {
                Convert.ToString(value);
            }
        }

        #endregion

        #endregion

        #region General Methods

        internal static void ReadSettings()
        {
            Drives = DriveInfo.GetDrives();
            string _HostName = Dns.GetHostName();
            string _DataPath = Properties.Settings.Default.FTPRoot;
            if (!_DataPath.EndsWith("\\")) _DataPath += "\\";

            XmlDocument Settings = new XmlDocument();

            try
            {
                if (File.Exists(DataPath + "Settings.xml"))
                {
                    FileStream RawStream = new FileStream(DataPath + "Settings.xml", FileMode.Open, FileAccess.Read);

                    byte[] Buffer = new byte[(int)RawStream.Length];
                    RawStream.Read(Buffer, 0, Buffer.Length);
                    RawStream.Close(); RawStream = null;
                    MemoryStream Stream = new MemoryStream(Buffer);
                    TextReader Reader = new StreamReader(Stream, Encoding.UTF8);
                    Settings.Load(Reader);
                    Reader.Close();
                    Stream.Close();
                    Buffer = null;
                }
                else Settings.LoadXml(global::VulindlelaFTPServer.Properties.Resources.Settings);
            }
            catch (Exception Ex)
            {
                ApplicationLog.Write(LogSource.FTP, Ex);
            }
        }
        static byte[] Crypt(byte[] Buffer)
        {
            for (int i = 0; i < Buffer.Length; i++)
            {
                Buffer[i] ^= 36;
            }
            return Buffer;
        }
        internal static void SetFolderIcon(string Path)
        {
            if (!ChangeFTPFoldersIcon) return;
            try
            {
                if (Directory.Exists(Path))
                {
                    string IconFileInfo = System.IO.Path.Combine(Path, "Desktop.ini");
                    if (File.Exists(IconFileInfo))
                    {
                        File.SetAttributes(IconFileInfo, FileAttributes.Normal);
                        File.Move(IconFileInfo, "_Desktop.ini");
                    }

                    StreamWriter SW = new StreamWriter(IconFileInfo);
                    SW.WriteLine("[.ShellClassInfo]");
                    SW.WriteLine(@"IconFile=" + System.IO.Path.Combine(_DataPath, "Icons\\Folder.ico"));
                    SW.WriteLine("IconIndex=0");
                    SW.WriteLine("SET_BY_ADVFTPSVR");
                    SW.Close(); SW = null;

                    File.SetAttributes(IconFileInfo, FileAttributes.Hidden | FileAttributes.System);
                    File.SetAttributes(System.IO.Path.Combine(Path, "_Desktop.ini"), FileAttributes.Hidden | FileAttributes.System);
                }
            }
            catch { }
        }
        static void RemoveFolderIcon(string Path)
        {
            if (!ChangeFTPFoldersIcon) return;
            try
            {
                if (Directory.Exists(Path))
                {
                    string IconFileInfo = System.IO.Path.Combine(Path, "Desktop.ini");
                    bool DeleteFile = true;
                    if (File.Exists(IconFileInfo))
                    {
                        StreamReader SR = new StreamReader(IconFileInfo);
                        DeleteFile = (SR.BaseStream.Length < 1024 && SR.ReadToEnd().IndexOf("SET_BY_ADVFTPSVR") != -1);
                        SR.Close(); SR = null;
                        if (DeleteFile) File.Delete(IconFileInfo);
                    }
                    if (File.Exists(System.IO.Path.Combine(Path, "_Desktop.ini")))
                    {
                        if (DeleteFile)
                        {
                            File.SetAttributes(System.IO.Path.Combine(Path, "_Desktop.ini"), FileAttributes.Normal);
                            File.Move(System.IO.Path.Combine(Path, "_Desktop.ini"), "Desktop.ini");
                        }
                        else File.Delete(System.IO.Path.Combine(Path, "_Desktop.ini"));
                    }
                    File.SetAttributes(IconFileInfo, FileAttributes.Hidden | FileAttributes.System);
                }
            }
            catch { }
        }
        static string GetSettingsAsString(SettingsKey Key)
        {
            XmlNodeList SettingsList = Settings.DocumentElement.SelectSingleNode("SETTINGS").ChildNodes;
            string returnValue = string.Empty;

            foreach (XmlNode Setting in SettingsList)
            {
                if (Setting.Attributes["NAME"].Value != Key.ToString()) continue;

                returnValue = Setting.Attributes["VALUE"].Value;
                break;
            }
            return returnValue;
        }
        static bool GetSettingsAsBool(SettingsKey Key)
        {
            return GetSettingsAsString(Key) == "1";
        }
        static void ChangeSettings(SettingsKey Key, string Value)
        {
            XmlNode SettingsNode = Settings.DocumentElement.SelectSingleNode("SETTINGS");

            foreach (XmlNode Setting in SettingsNode.ChildNodes)
            {
                if (Setting.Attributes["NAME"].Value != Key.ToString()) continue;

                Setting.Attributes["VALUE"].Value = Value;
                return;
            }
            XmlNode NewSetting = Settings.CreateElement("KEY");
            XmlAttribute Attrib = Settings.CreateAttribute("NAME");
            Attrib.Value = Key.ToString();
            NewSetting.Attributes.Append(Attrib);

            Attrib = Settings.CreateAttribute("NAME");
            Attrib.Value = Value;
            NewSetting.Attributes.Append(Attrib);

            SettingsNode.AppendChild(NewSetting);
        }
        static void ChangeSettings(SettingsKey Key, bool Value)
        {
            ChangeSettings(Key, (Value) ? "1" : "0");
        }

        #endregion

        #region User Account Methods

        internal static bool GetFTPUserGroups(string UserName)
        {
            string usernme = FTPUser.GetMasterUser(); /// persalnumber;
            string pwd = FTPUser.GetMasterPwd();
            string get_ldap_string = FTPUser.GetLDAPString();
            string ldapstring = "LDAP://" + FTPUser.GetIPaddressString() + "/CN=FTP_ACCESS," + get_ldap_string;

            DirectoryEntry dsDirectoryEntry = new DirectoryEntry(ldapstring, usernme, pwd);

            //string s = null;

            XmlNodeList Users = GetUserList();
            XmlNode User = ApplicationSettings.Settings.CreateElement("User");
            User.Attributes.Append(ApplicationSettings.Settings.CreateAttribute("UserName"));
            User.Attributes.Append(ApplicationSettings.Settings.CreateAttribute("Password"));
            User.Attributes.Append(ApplicationSettings.Settings.CreateAttribute("RootDirectory"));
            User.Attributes.Append(ApplicationSettings.Settings.CreateAttribute("PermissionSet"));
            User.Attributes.Append(ApplicationSettings.Settings.CreateAttribute("Enabled"));
            Settings.DocumentElement.SelectSingleNode("UserAccount").AppendChild(User);

            User.Attributes[0].Value = UserName.ToUpper();

            return true;
        }
        internal static XmlNodeList GetFTPUsers()
        {
            string usr = FTPUser.GetMasterUser();
            string pwd = FTPUser.GetMasterPwd();
            string get_ldap_string = FTPUser.GetAppOUContext();
            string ldapstring = "LDAP://" + FTPUser.GetIPaddressString() + "/CN=FTP_ACCESS," + get_ldap_string;

            DirectoryEntry dsDirectoryEntry = new DirectoryEntry(ldapstring, usr, pwd);
            XmlNodeList UserGroups = null;
            SearchResultCollection dsResultCollecion = null;
            XmlAttribute UserAttributes = null;
            XmlNode User = null;

            int i = 0;

            DirectorySearcher dsSearcher = new DirectorySearcher(dsDirectoryEntry);

            dsSearcher.PropertiesToLoad.Add("memberOf");

            try
            {
                dsResultCollecion = dsSearcher.FindAll();
                if (dsResultCollecion == null) return null;
                for (i = 0; i <= (dsResultCollecion.PropertiesLoaded.LongLength - 1); i++)
                {
                    User.Value = dsResultCollecion.PropertiesLoaded[0].ToString();
                    User.Attributes.Append(UserAttributes);
                    UserGroups[i].AppendChild(User);
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.ToString());
            }
            return (UserGroups);
        }
        internal static XmlNodeList GetUserList()
        {
            XmlNodeList FtpUsers = ApplicationSettings.GetFTPUsers();
            return (FtpUsers);
        }
        public static Collection GetUserGroups(string _persalnumber)
        {
            string usr = FTPUser.GetMasterUser();
            string pwd = FTPUser.GetMasterPwd();
            string get_ldap_string = FTPUser.GetAppOUContext();
            string ldapstring = "LDAP://" + FTPUser.GetIPaddressString() + "/CN=FTP_ACCESS," + get_ldap_string;

            DirectoryEntry dsDirectoryEntry = new DirectoryEntry(ldapstring, usr, pwd);

            int bytCounter = 0;
            string strGroups = null;
            Microsoft.VisualBasic.Collection UserGroups = new Microsoft.VisualBasic.Collection();
            StringBuilder sbUserGroups = new StringBuilder();
            DirectorySearcher dsSearcher = new DirectorySearcher(dsDirectoryEntry);
            dsSearcher.PropertiesToLoad.Add("memberOf");

            try
            {
                SearchResult dsResult = dsSearcher.FindOne();
                if (dsResult == null)
                {
                    return null;
                }
                for (bytCounter = 0; bytCounter <= (dsResult.Properties["memberOf"].Count - 1); bytCounter++)
                {
                    strGroups = dsResult.Properties["memberOf"][0].ToString();
                    UserGroups.Add(strGroups);
                }
            }
            catch (Exception)
            {
            }
            return (UserGroups);

        }
        internal bool CreateFTPUser(string UserName, string Password, string RootPath, string PermissionSet, bool Enabled)
        {
            //if (IsUserExists(UserName)) return false;

            XmlNodeList Users = GetUserList();
            XmlNode User = ApplicationSettings.Settings.CreateElement("User");
            User.Attributes.Append(ApplicationSettings.Settings.CreateAttribute("UserName"));
            User.Attributes.Append(ApplicationSettings.Settings.CreateAttribute("Password"));
            User.Attributes.Append(ApplicationSettings.Settings.CreateAttribute("Root"));
            User.Attributes.Append(ApplicationSettings.Settings.CreateAttribute("PermissionSet"));
            User.Attributes.Append(ApplicationSettings.Settings.CreateAttribute("Enabled"));
            Settings.DocumentElement.SelectSingleNode("UserAccount").AppendChild(User);

            User.Attributes[0].Value = UserName.ToUpper();
            User.Attributes[1].Value = Password;
            User.Attributes[2].Value = RootPath;
            User.Attributes[3].Value = PermissionSet;
            User.Attributes[4].Value = (Enabled) ? "1" : "0";
            SetFolderIcon(RootPath);
            return true;
        }
        internal static bool GetUser(string UserName, out string Password, out string RootPath, out string PermissionSet, out bool Enabled)
        {
            XmlNode User = GetUser(UserName);
            Password = PermissionSet = RootPath = null;
            Enabled = false;
            if (User == null) return false;

            Password = User.Attributes[1].Value;
            PermissionSet = User.Attributes[3].Value;
            RootPath = User.Attributes[2].Value;
            Enabled = User.Attributes[4].Value == "1";

            return true;
        }
        internal static XmlNode GetUser(string UserName)
        {
            XmlNodeList Users = GetUserList();
            XmlNode User = null;

            for (int i = 0; i < Users.Count; i++)
            {
                if (Users[i].Attributes[0].Value.ToUpper() != UserName) continue;
                User = Users[i]; break;
            }

            return User;
        }

        #endregion

        //internal static Collection GetGroupUsers(string strGroupName)
        //{
        //    string usr = FTPUser.GetMasterUser(); /// persalnumber;
        //    string pwd = FTPUser.GetMasterPwd();
        //    string get_ldap_string = FTPUser.GetAppOUContext();
        //    string ldapstring = "LDAP://" + FTPUser.GetIPaddressString() + "/CN=FTP_ACCESS," + get_ldap_string;

        //    DirectoryEntry de = new DirectoryEntry(ldapstring, usernme, pwd);
        //    DirectorySearcher ds = new DirectorySearcher(de);
        //    Collection sbGroupUsers = null;
        //    {
        //        ds.PropertiesToLoad.Add("memberOf");
        //        try
        //        {
        //            SearchResultCollection dsResultColl = ds.FindAll();

        //            short shtCounter = 0;

        //            if (dsResultColl == null)
        //            { return null; }
        //            //ResultPropertyCollection myResultPropColl;
        //            //strUsers = dsResultColl.Properties["memberOf"].IndexOf(shtCounter).ToString();
        //            //sbGroupUsers.Add(strUsers.ToString().Trim());
        //            //sbGroupUsers.Add(ControlChars.CrLf);

        //            foreach (string myKey in myResultPropColl.PropertyNames)
        //            {
        //                string tab = "    ";
        //                Console.WriteLine(myKey + " = ");
        //                foreach (Object myCollection in myResultPropColl[myKey])
        //                {
        //                    Console.WriteLine(tab + myCollection);
        //                }
        //            }

        //            ds.Dispose();
        //            de.Dispose();
        //        }

        //        catch (Exception ex)
        //        {
        //            Interaction.MsgBox("Error in GetGroupUsers Function" + Constants.vbNewLine + ex.Message.ToString(), MsgBoxStyle.Information, "Active Directory Error");
        //        }
        //    }
        //    return sbGroupUsers;
        //}

        public static StringCollection GetFTPUsers3()
        {
            string usr = FTPUser.GetMasterUser(); /// persalnumber;
            string pwd = FTPUser.GetMasterPwd();
            string get_ldap_string = FTPUser.GetAppOUContext();
            
            StringCollection col = new StringCollection();

            string ldapstring = "LDAP://" + FTPUser.GetIPaddressString() + "/CN=FTP_ACCESS," + get_ldap_string;

            try
            {
                DirectoryEntry de = new DirectoryEntry(ldapstring,usr,pwd);
                DirectorySearcher ds = new DirectorySearcher(de);
                SearchResult sr = ds.FindOne();
                if (sr != null)
                {
                    DirectoryEntry myde = sr.GetDirectoryEntry();
                    string mySearchResultPath = sr.Path;
                    ResultPropertyCollection myResultPropColl;
                    myResultPropColl = sr.Properties;
                    foreach (string user in myde.Properties)
                    {
                        Interaction.MsgBox(user.ToString(), MsgBoxStyle.OkOnly , "System Message");
                    }
                    de.Dispose();
                    myde.Dispose();
                }
                else
                {
                    //Console.WriteLine("The '" + myLDAPPath + "' path not found.");
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
            return (col);
        }
    }
}
