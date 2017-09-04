using System;
using System.IO;
using System.Web;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Configuration;
using Microsoft.VisualBasic;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.DirectoryServices;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.DirectoryServices.AccountManagement;
using System.Data;
using System.Xml;
using System.Collections.Specialized;


namespace VulindlelaFTPServer
{
    partial class FTPUser 
    {
        //int i;
        internal string Password=null;
        internal string Password2=null;
        internal Collection FTPUsers=null;
        internal bool IsAuthenticated;
        //Collection apprights=null;
        internal string UserName = "";
        internal string UserName2 = "";
        //bool accIsLocked = false;
        //bool accIsExpired = false;
        string accAuthenticated = "";
        internal string RootDirectory = "";
        internal string Applications="";
        internal string Departments="";
        internal string AccessLevel="";
        internal string HomeDepartment="";

        internal string CurrentWorkingDirectory = "\\";
        internal FTPClient ConnectedUser=null;
        
        public void LoadProfile(string UserName)
        {
            try
            {
               // string[] col = {};

                if (UserName == this.UserName) return;
                if ((this.UserName = UserName).Length == 0) return;

                accAuthenticated = VulindlelaFTPServer.Authenticate2010.AuthenticateIt(UserName, Password);
               
                //accIsExpired = VulindlelaFTPServer.Authenticate2010.IsExpired(UserName);
                //accIsLocked = VulindlelaFTPServer.Authenticate2010.IsLocked(UserName);
                
                StringCollection myCol = new StringCollection();
                StringCollection col = ApplicationSettings.GetFTPUsers3();

                string[] CurrUser = {};
                //CurrUser = col.ToString();

                if (UserName == this.UserName) return;
                if ((this.UserName = UserName).Length == 0) return;
                IsAuthenticated = false;

                for (int x = 0; x < myCol.Count - 1; x++)
                {
                    Interaction.MsgBox(myCol.ToString());
                }
                  //i += i;
                  //CurrUser = myuser;
                  //UserName = User.ToString(); 
                  //if (User.Name != UserName) continue;
                  //Password = User.Attributes.GetNamedItem("Password").Value;
                  //RootDirectory = User.Attributes.GetNamedItem("RootDirectory").Value;
                  //Applications = User.Attributes.GetNamedItem("Applications").Value;
                  //Departments = User.Attributes.GetNamedItem("Departments").Value;
                  //Departments = User.Attributes.GetNamedItem("AccessLevel").Value;
                  //AccessLevel = User.Attributes.GetNamedItem("HomeDepartment").Value;
                  //char[] Permissions = User.Attributes[3].Value.ToCharArray();
                  //break;
            }
            catch (Exception Ex)
            {
                ApplicationLog.Write(LogSource.FTP, Ex);
                //apprights = null;
            }
        }

        internal bool ChangeDirectory(string Dir)
        {
            CurrentWorkingDirectory = Dir;
            return true;
        }

        public bool IsExpired(string Username)
        {
            PrincipalContext principalContext = new PrincipalContext(ContextType.Domain,
                VulindlelaFTPServer.Properties.Settings.Default.VulIP,
                "CN=" + Username.Trim()  + ",OU=USERS,OU=Vulindlela3," +
                VulindlelaFTPServer.Properties.Settings.Default.VulDC,
                VulindlelaFTPServer.Properties.Settings.Default.VulMasterUser,
                VulindlelaFTPServer.Properties.Settings.Default.VulMasterPassword);
            UserPrincipal userPrincipal = UserPrincipal.FindByIdentity(principalContext, Username);
            bool result = (userPrincipal.AccountExpirationDate < DateTime.Now);
            userPrincipal.Dispose();
            principalContext.Dispose();
            return result;
        }

        public string getUserID(string Persalid)
        {
           string a;
            if ((a = Persalid.ToString().ToUpper().Substring(0, 1)) != null)
            {
                if (a == "P") return "1" + Persalid.Substring(1);
                if (a == "S") return "2" + Persalid.Substring(1);
                if (a == "V") return "3" + Persalid.Substring(1);
                if (a == "T") return "4" + Persalid.Substring(1);
            }
            return "0";
        }

        public bool IsLocked(string Username)
        {
            bool result = false;
            PrincipalContext principalContext = new PrincipalContext(ContextType.Domain, VulindlelaFTPServer.Properties.Settings.Default.VulIP, "CN=" + Username + ",OU=USERS,OU=Vulindlela3," +
                VulindlelaFTPServer.Properties.Settings.Default.VulDC, 
                VulindlelaFTPServer.Properties.Settings.Default.VulMasterUser,
                VulindlelaFTPServer.Properties.Settings.Default.VulMasterPassword);
            try 
                { UserPrincipal userPrincipal = UserPrincipal.FindByIdentity(principalContext, Username); result = userPrincipal.IsAccountLockedOut();}
            catch (Exception ) 
                { result = true;}
            finally 
                { principalContext.Dispose();} return result;
        }
        
        public bool Isvalid(string Username, string Password)
        {
            PrincipalContext principalContext = new PrincipalContext(ContextType.Domain, 
                    VulindlelaFTPServer.Properties.Settings.Default.VulIP , 
                    "CN=" + Username + ",OU=USERS,OU=Vulindlela3," + 
                    VulindlelaFTPServer.Properties.Settings.Default.VulDC, 
                    VulindlelaFTPServer.Properties.Settings.Default.VulMasterUser,
                    VulindlelaFTPServer.Properties.Settings.Default.VulMasterPassword);
            bool result;
            try
            {
                UserPrincipal.FindByIdentity(principalContext, Username);
                result = true;
            }
            catch (Exception )
            {
                result = false;
            }
            finally
            {
                principalContext.Dispose();
            }
            return result;
        }
        
        public int getFinYear()
        {
            if (DateTime.Now.Month < 4)
            {
                return DateTime.Now.Year - 1;
            }
            else
            {
                return DateTime.Now.Year;
            }
        }
        
        public static string GetEmailAddress(string _persalnumber)
        {
            string persalnumber = GetValidUsername(_persalnumber.Trim());

            PrincipalContext context = new PrincipalContext(ContextType.Domain, GetIPaddressString(), "CN=" + persalnumber + "," + GetLDAPString(), GetMasterUser(), GetMasterPwd());
            try
            {   UserPrincipal user = UserPrincipal.FindByIdentity(context, persalnumber);
                return (user.EmailAddress.ToLower().Trim());
            }
            catch (Exception)
            {   return "";}
        }
        
        public static string GetRealnameFromUsername(string _persalnumber)
        {
            string persalnumber = GetValidUsername(_persalnumber.Trim());
            PrincipalContext context = new PrincipalContext(ContextType.Domain, GetIPaddressString(), "CN=" + persalnumber + "," + GetLDAPString(), GetMasterUser(), GetMasterPwd());
            try
            {   UserPrincipal user = UserPrincipal.FindByIdentity(context, persalnumber);
                return (user.Name.ToLower().Trim() + " " + user.Surname.ToLower().Trim());
            }
            catch (Exception)
            {   return "Not Found";}
        }
        
        public static bool PopulatedFromAd = false;
        
        private const long ADS_SECURE_AUTHENTICATION = 0x0;
        
        public static int svrEnvironment=0;
        
        public static bool Cleartxt = true;
        
        public static string Tnumber = "";
        
        public enum ou_context
        {   APPLICATION_RIGHTS = 1,
            GOVERNMENT_STRUCTURE = 2,
            USERS = 3
        }
        
        public static string GetAppOUContext()
        {   string functionReturnValue = null;
            functionReturnValue = VulindlelaFTPServer.Properties.Settings.Default.VulCTXApp;
            return functionReturnValue;
        }
        
        public static string GetGovtOUContext()
        {   string functionReturnValue = null;
            functionReturnValue =  VulindlelaFTPServer.Properties.Settings.Default.VulCTXGovt;
            return functionReturnValue;
        }
        
        public static string GetUsersOUContext()
        {   string functionReturnValue = null;
            functionReturnValue = VulindlelaFTPServer.Properties.Settings.Default.VulCTXUsers;
            return functionReturnValue;
        }
        
        public static string GetCompleteCNOUContext(string groupname, ou_context cntxt)
        {   string Complete_CN_OU_Context = null;
            if (cntxt == ou_context.APPLICATION_RIGHTS)
            {
                Complete_CN_OU_Context = "CN=" + groupname.Trim() + "," + GetAppOUContext().Trim();
            }
            else if (cntxt == ou_context.GOVERNMENT_STRUCTURE)
            {
                Complete_CN_OU_Context = "CN=" + groupname.Trim() + "," + GetGovtOUContext().Trim();
            }
            else if (cntxt == ou_context.USERS)
            {
                Complete_CN_OU_Context = "CN=" + groupname.Trim() + "," + GetUsersOUContext().Trim();
            }
            return Complete_CN_OU_Context;
        }

        public static string GetDCString()
        {
            string functionReturnValue = null;
            functionReturnValue = VulindlelaFTPServer.Properties.Settings.Default.VulDC;
            return functionReturnValue;
        }

        public static string GetValidUsername(string _persalnumber)
        {
            string functionReturnValue = null;
            if (_persalnumber == null)
            {
                Interaction.MsgBox("Please enter a valid persal number", MsgBoxStyle.OkCancel | MsgBoxStyle.Critical, "System MEssage");
            }
            else
            {
                if (Strings.Left(_persalnumber.ToString().ToUpper().Trim(), 1) != "T")
                {
                    if (Strings.Left(_persalnumber.ToString().ToUpper().Trim(), 1) == "P")
                    {
                        functionReturnValue = _persalnumber.ToString().ToUpper().Trim();
                    }
                    else
                    {
                        functionReturnValue = "P" + _persalnumber.ToString().ToUpper().Trim();
                    }
                }
                else
                {
                    functionReturnValue = _persalnumber.ToString().ToUpper().Trim();
                }
            }
        return functionReturnValue;
        }
    
        public static string GetLDAPString()
        {
            string functionReturnValue = null;
            functionReturnValue = VulindlelaFTPServer.Properties.Settings.Default.AD_USERS_PRD.ToString();
            return functionReturnValue;
        }

        public static string GetIPaddressString()
        {   
            string ip;
            {
                ip = VulindlelaFTPServer.Properties.Settings.Default.VulIP.ToString();
            }
            return ip;
        }

        public static string GetMasterUser()
        {
            string functionReturnValue = null;
            functionReturnValue = VulindlelaFTPServer.Properties.Settings.Default.VulMasterUser.ToString();
            return functionReturnValue;
        }

        public static string GetMasterPwd()
        {
            string functionReturnValue = "";
            ///ftpCrypto enc = new ftpCrypto();
            functionReturnValue = VulindlelaFTPServer.Properties.Settings.Default.VulMasterPassword.ToString();
            ///enc = null;
            return functionReturnValue;
        }

        public static string GetValidPersalNumber(string persalnumber)
        {
            int slength = Microsoft.VisualBasic.Strings.Len(persalnumber.Trim());
            if (Microsoft.VisualBasic.Strings.Left(persalnumber.Trim(), 1).ToUpper() == "P")
            {
                return Microsoft.VisualBasic.Strings.Replace(persalnumber.Trim(), "P", "");
            }
            else
            {
                return persalnumber.Trim();
            }
        }

        public static bool GetIsValidUser(string _persalnumber)
        {
            bool IsValidUser = false;
            string persalnumber = GetValidUsername(_persalnumber.Trim());
            PrincipalContext context = new PrincipalContext(ContextType.Domain, GetIPaddressString(), "CN=" + persalnumber + "," + GetLDAPString(), GetMasterUser(), GetMasterPwd());
            try
            {
                UserPrincipal user = UserPrincipal.FindByIdentity(context, persalnumber);
                IsValidUser = (_persalnumber == user.GivenName.ToString());
            }
            catch (Exception)
            {
                IsValidUser = false;
            }
            return (IsValidUser);
        }

        public static System.DateTime GetAccountExpireDate(string _persalnumber)
        {
            System.DateTime functionReturnValue = default(System.DateTime);
            string PersalNumber = GetValidUsername(_persalnumber);
            PrincipalContext context = new PrincipalContext(ContextType.Domain, GetIPaddressString(), "CN=" + PersalNumber + "," + GetLDAPString(), GetMasterUser(), GetMasterPwd());
            UserPrincipal userPrincipal = UserPrincipal.FindByIdentity(context, PersalNumber);
            if (userPrincipal.AccountExpirationDate == null)
            {
                functionReturnValue = Convert.ToDateTime("1970/01/01 00:00:00").AddDays(-1);
            }
            else
            {
                functionReturnValue = Convert.ToDateTime(userPrincipal.AccountExpirationDate.Value);
            }
            return functionReturnValue;
        }
    
        public static Microsoft.VisualBasic.Collection GetUserGroups(string _persalnumber, string _pwd)
        {
            string persalnumber = GetValidUsername(_persalnumber);
            string usernme = GetMasterUser(); /// persalnumber;
            string pwd = GetMasterPwd();
            string get_ldap_string = GetLDAPString();
            string ldapstring = "LDAP://" + GetIPaddressString() + ",CN=" + persalnumber + "," + get_ldap_string;
            DirectoryEntry dsDirectoryEntry = new DirectoryEntry(ldapstring, usernme, pwd);
            string s = null;
            int bytCounter = 0;
            string strGroups = null;
            short shtCommaIndex = 0;
            Collection UserGroups = new Collection();
            short shtEqualsIndex = 0;
            StringBuilder sbUserGroups = new StringBuilder();
            DirectorySearcher dsSearcher = new DirectorySearcher(dsDirectoryEntry);

            dsSearcher.Filter = "saMAccountName=" + persalnumber;
            dsSearcher.PropertiesToLoad.Add("memberOf");

            try
            {
                SearchResult dsResult = dsSearcher.FindOne();
                if (dsResult == null) { return null; }
                for (bytCounter = 0; bytCounter <= (dsResult.Properties["memberOf"].Count - 1); bytCounter++)
                {
                    strGroups = dsResult.Properties["memberOf"][bytCounter].ToString();
                    char c = Convert.ToChar("=");
                    shtEqualsIndex = Convert.ToInt16(strGroups.IndexOf("=", 1));
                    shtCommaIndex = Convert.ToInt16(strGroups.IndexOf(",", 1));
                    if (shtEqualsIndex == -1) { return null; }
                    s = strGroups.Substring((shtEqualsIndex + 1), (shtCommaIndex - shtEqualsIndex) - 1);
                    UserGroups.Add(s);
                }
            }
            catch (Exception ex) 
            { 
                Interaction.MsgBox(ex.ToString()); 
            }
            return (UserGroups);
        }

        public static bool GetIsAccountLocked(string _persalnumber)
        {
            string PersalNumber = GetValidUsername(_persalnumber);
            PrincipalContext context = new PrincipalContext(ContextType.Domain, GetIPaddressString(), ",CN=" + PersalNumber + "," + GetLDAPString());
            UserPrincipal userPrincipal = UserPrincipal.FindByIdentity(context, PersalNumber);
            if (!string.IsNullOrEmpty(userPrincipal.AccountLockoutTime.ToString()))
            { 
                return true; 
            }
            else 
            { 
                return false; 
            }
        }

        internal bool Authenticate(string Password)
        {
            if (Password == this.Password)
            {
                IsAuthenticated = true;
            }
            else
            {
                IsAuthenticated = false;
            }
            return IsAuthenticated;
        }

        public static XmlNodeList GetFTPUserGroups()
        {
            string usr = GetMasterUser(); /// persalnumber;
            string pwd = GetMasterPwd();
            string get_ldap_string = GetLDAPString();
            string ldapstring = "LDAP://" + GetIPaddressString() + "/CN=FTP_ACCESS," + get_ldap_string;
            
            DirectoryEntry dsDirectoryEntry = new DirectoryEntry(ldapstring, usr, pwd);
            
            int i = 0;

            XmlNodeList FtpAccessUsers = null;

            DirectorySearcher dsSearcher = new DirectorySearcher(dsDirectoryEntry);

            dsSearcher.PropertiesToLoad.Add("memberOf");

            try
            {   
                SearchResult dsResult = dsSearcher.FindOne();
                if (dsResult == null) { return null; }
                
                for (i = 0; i <= (dsResult.Properties["memberOf"].Count - 1); i++)
                {   
                    FtpAccessUsers[i].Value = dsResult.Properties["memberOf"][i].ToString();
                    XmlNode User = FtpAccessUsers[i].Attributes.GetNamedItem("User");
                    User.Attributes.Append(ApplicationSettings.Settings.CreateAttribute("UserName"));
                    User.Attributes.Append(ApplicationSettings.Settings.CreateAttribute("Password"));
                    ApplicationSettings.SetFolderIcon(User.Attributes["Root"].Value);
                }
            }
            catch (Exception)
            { }
            return (FtpAccessUsers);
        }
    }

    public class adCrypto 
    {
        private const string _defaultpassword = "m@s1eweencrypt1onm@sj1en";
        private byte[] bytIV = { 121, 241, 10, 1, 132, 74, 11, 39, 255, 91, 45, 78, 14, 211, 22, 62 };
        private const char chrKeyFill = 'X';
        private const string strTextError = "#ERROR - {0}";
        private const int intMinSalt = 4;
        private const int intMaxSalt = 8;
        private const int intHashSize = 16;
        private const int intKeySize = 32;
         
        public string kodeer128(string strPlainText)
        {
            try
            {
                byte[] bytPlainText = null;
                byte[] bytKey = null;
                byte[] bytEncoded = null;
                MemoryStream objMemoryStream = new MemoryStream();
                RijndaelManaged objRijndaelManaged = new RijndaelManaged();
                strPlainText = strPlainText.Replace(Constants.vbNullChar, string.Empty);
                bytPlainText = Encoding.UTF8.GetBytes(strPlainText);
                bytKey = ConvertKeyToBytes(_defaultpassword);
                CryptoStream objCryptoStream = new CryptoStream(objMemoryStream, objRijndaelManaged.CreateEncryptor(bytKey, bytIV), CryptoStreamMode.Write);
                objCryptoStream.Write(bytPlainText, 0, bytPlainText.Length);
                objCryptoStream.FlushFinalBlock();
                bytEncoded = objMemoryStream.ToArray();
                objMemoryStream.Close();
                objCryptoStream.Close();
                return Convert.ToBase64String(bytEncoded);
            }
            catch (Exception ex)
            {
                return string.Format(strTextError, ex.Message);
            }
        }
               
        public string Dekodeer128(string strCryptText)
        {
            try
            {
                byte[] bytCryptText;
                byte[] bytKey;

                RijndaelManaged objRijndaelManaged = new RijndaelManaged();

                bytCryptText = ConvertKeyToBytes(strCryptText);
                bytKey = ConvertKeyToBytes(_defaultpassword);

                byte[] bytTemp = new byte[bytCryptText.Length + 1];
                MemoryStream objMemoryStream = new MemoryStream(bytCryptText);
                CryptoStream objCryptoStream = new CryptoStream(objMemoryStream, objRijndaelManaged.CreateDecryptor(bytKey, bytIV), CryptoStreamMode.Read);

                objCryptoStream.Read(bytTemp, 0, bytTemp.Length);
                objMemoryStream.Close();
                objCryptoStream.Close();

                return Encoding.UTF8.GetString(bytTemp).Replace(Constants.vbNullChar, string.Empty);
            }
            catch (Exception ex)
            {
                return string.Format(strTextError, ex.Message);
            }
        }

        public string ComputeMD5Hash(string strPlainText, byte[] bytSalt = null)
        {
            try
            {
                byte[] bytPlainText = Encoding.UTF8.GetBytes(strPlainText);
                HashAlgorithm hash = new MD5CryptoServiceProvider();

                if (bytSalt == null)
                {
                    Random rand = new Random();
                    int intSaltSize = rand.Next(intMinSalt, intMaxSalt);

                    bytSalt = new byte[intSaltSize];

                    RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
                    rng.GetNonZeroBytes(bytSalt);
                }

                byte[] bytPlainTextWithSalt = new byte[bytPlainText.Length + bytSalt.Length];

                bytPlainTextWithSalt = ConcatBytes(bytPlainText, bytSalt);

                byte[] bytHash = hash.ComputeHash(bytPlainTextWithSalt);
                byte[] bytHashWithSalt = new byte[bytHash.Length + bytSalt.Length];

                bytHashWithSalt = ConcatBytes(bytHash, bytSalt);

                return Convert.ToBase64String(bytHashWithSalt);
            }
            catch (Exception ex)
            {
                return string.Format(strTextError, ex.Message);
            }
        }
           
        public bool VerifyHash(string strPlainText, string strHashValue)
        {
            try
            {
                byte[] bytWithSalt = Convert.FromBase64String(strHashValue);
                if (bytWithSalt.Length < intHashSize) return false;
                byte[] bytSalt = new byte[bytWithSalt.Length - intHashSize];
                Array.Copy(bytWithSalt, intHashSize, bytSalt, 0, bytWithSalt.Length - intHashSize);
                string strExpectedHashString = ComputeMD5Hash(strPlainText, bytSalt);
                return strHashValue.Equals(strExpectedHashString);
            }
            catch (Exception)
            {
                return Convert.ToBoolean(null);
            }
        }

        private byte[] ConcatBytes(byte[] bytA, byte[] bytB)
        {
            try
            {
                byte[] bytX = new byte[((bytA.Length + bytB.Length))];

                Array.Copy(bytA, bytX, bytA.Length);
                Array.Copy(bytB, 0, bytX, bytA.Length, bytB.Length);
                return bytX;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private byte[] ConvertKeyToBytes(string strKey)
        {
            try
            {
                int intLength = strKey.Length;

                if (intLength < intKeySize)
                { strKey += Strings.StrDup(intKeySize - intLength, chrKeyFill); }
                else
                {
                    strKey = strKey.Substring(0, intKeySize);
                }
                return Encoding.UTF8.GetBytes(strKey);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}