using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using Microsoft.VisualBasic.CompilerServices;
using System.Runtime.InteropServices;

namespace VulindlelaFTPServer
{
    internal partial class Authenticate2010
    {
        /// <summary>
        /// Only The Private Internal Variables
        /// </summary>
        /// 

        internal static Microsoft.VisualBasic.Collection mvarCol_MemberOf = new Microsoft.VisualBasic.Collection();
        internal static Microsoft.VisualBasic.Collection mvarCol_MemberOf2 = new Microsoft.VisualBasic.Collection();
        internal static Microsoft.VisualBasic.Collection mvarCol_AppRights = new Microsoft.VisualBasic.Collection();
        private bool mvarChange_password;
        private static string ADSMasterUsername = VulindlelaFTPServer.Properties.Settings.Default.VulMasterUser;
        private static string ADSMasterPassword = VulindlelaFTPServer.Properties.Settings.Default.VulMasterPassword;
       // private int ADSPasswordExpireAfter = 60;
       // private int ADSMaxBadLogins = 4;
        private static string _cnConn;
       // private string mvarsConn;
        private static string mvarTitle;
        private static string mvarName;
        private static string mvarSurname;
        private static string mvarGivenName;
        private static string mvarProvinceID;
        private static string mvarProvinceTypeID;
        private static string mvarProvince;
        private static string mvarProvinceSName;
        private static string mvarDepartmentID;
        private static string mvarDepartmentTypeID;
        private static string mvarDepartment;
        private static string mvarDepartmentSName;
        private static string mvarEMailAddress;
        private static string mvarSAMaccountname;
        private static string DC;
        private static string IP_ADDRESS;
        private static string mvarsRights = "";
        private static string mvarsError;
        private static void getDetails(string sname)
        {
            SqlConnection DaConnection = new SqlConnection(_cnConn);
            DaConnection.Open();
            SqlCommand DaCommand = new SqlCommand();
            SqlDataReader DaDataReader;


            DaCommand.CommandType = CommandType.Text;
            DaCommand.CommandText = "SELECT TOP 1 * FROM VIP_EXPANDED..VIEW_GOVERNMENT_STRUCTURE WHERE DEPT_SHORT_NAME='" + sname + "' ORDER BY FINYEAR DESC";
            DaCommand.Connection = DaConnection;

            DaDataReader = DaCommand.ExecuteReader();

            if (DaDataReader.HasRows)
            {
                while (DaDataReader.Read())
                {
                    mvarDepartmentSName = sname;
                    mvarDepartment = DaDataReader.GetValue(DaDataReader.GetOrdinal("DEPT_DESCRIPTION")).ToString();
                    mvarDepartmentID = DaDataReader.GetValue(DaDataReader.GetOrdinal("DEPT_ID")).ToString();
                    mvarDepartmentTypeID = DaDataReader.GetValue(DaDataReader.GetOrdinal("DEPT_LEVEL_ID")).ToString();
                    mvarProvinceSName = DaDataReader.GetValue(DaDataReader.GetOrdinal("NATPROV_SHORT_NAME")).ToString();
                    mvarProvince = DaDataReader.GetValue(DaDataReader.GetOrdinal("NATPROV_DESCRIPTION")).ToString();
                    mvarProvinceID = DaDataReader.GetValue(DaDataReader.GetOrdinal("NAT_PROV_ID")).ToString();
                    mvarProvinceTypeID = DaDataReader.GetValue(DaDataReader.GetOrdinal("PROVINCE_FLAG")).ToString();
                }
            }

            DaDataReader.Close();
        }
        private static void add2Application(string AppID, string AppShortName, string rigntsEntry)
        {

            // On Error GoTo AppAlreadyAdded
            Microsoft.VisualBasic.Collection xxx = new Microsoft.VisualBasic.Collection();
            Microsoft.VisualBasic.Collection colRights = new Microsoft.VisualBasic.Collection(); ;
            Microsoft.VisualBasic.Collection colExtendedDepts = new Microsoft.VisualBasic.Collection(); ;
            Microsoft.VisualBasic.Collection colAppDetails = new Microsoft.VisualBasic.Collection(); ;
            string line = "";

            try
            {

                xxx.Add(colRights, "APPLICATION_RIGHTS", null, null);
                xxx.Add(colExtendedDepts, "EXTENDED_DEPARTMENTS", null, null);
                xxx.Add(new string[2] { AppID, AppShortName }, "APPLICATION_DETAILS", null, null);

                mvarCol_AppRights.Add(xxx, AppShortName, null, null);

            }

            catch (Exception )
            {

                // Do The Finally part Here then!!!
                // MessageBox.Show(ex.Message);

            }
            finally
            {


                // AppAlreadyAdded

                SqlConnection DaConnection;
                SqlCommand DaCommand;
                SqlDataReader DaDataReader;

                DaConnection = new SqlConnection();
                DaConnection.ConnectionString = _cnConn;  /* As set by the user */
                DaConnection.Open();

                DaCommand = new SqlCommand();
                /* Setting the connecction like this is just for test now!!! */
                DaCommand.Connection = DaConnection;
                DaCommand.CommandType = System.Data.CommandType.Text;

                // line = Right(rightsEntry, Len(rightsEntry) - InStr(1, rigntsEntry, ","));
                line = rigntsEntry.Remove(0, rigntsEntry.IndexOf(",") + 1);

                if (rigntsEntry.ToUpper().Contains("APPLICATION_RIGHTS"))
                {
                    DaCommand.CommandText = "SELECT APPLICATION_ID, APPLICATION_SHORT_NAME FROM VIP_EXPANDED..APPLICATIONS WHERE APPLICATION_GROUP_ID=" + AppID + " ORDER BY APPLICATION_ID";
                    DaDataReader = DaCommand.ExecuteReader();

                    if (DaDataReader.HasRows)
                    {
                        while (DaDataReader.Read())
                        {
                            mvarsRights = mvarsRights + "," + DaDataReader.GetValue(DaDataReader.GetOrdinal("APPLICATION_ID")).ToString();
                        }
                    }


                    // Dis 'n moeilike ene die!!

                    // SOLUTION!!!
                    Microsoft.VisualBasic.Collection b = (Microsoft.VisualBasic.Collection)((Microsoft.VisualBasic.Collection)mvarCol_AppRights[AppShortName])["APPLICATION_RIGHTS"];
                    b.Add(new string[2] { AppID, line.ToString().Replace("'", "") }, null, null, null);

                    DaDataReader.Close();

                }
                else
                {

                    DaCommand.CommandText = "SELECT DEPT_ID as SQL_ID, DEPT_DESCRIPTION as Description, DEPT_SHORT_NAME as SOURCE_ID FROM VIP_EXPANDED..VIEW_GOVERNMENT_STRUCTURE WHERE FINYEAR=" + getFinYear() + " AND DEPT_SHORT_NAME IN(" + line + "') ORDER BY SQL_ID";
                    DaCommand.Connection = DaConnection;
                    DaDataReader = DaCommand.ExecuteReader();

                    if (DaDataReader.HasRows)
                    {
                        while (DaDataReader.Read())
                        {

                            // Dis moeilike ene die!!
                            // mvarCol_AppRights(AppShortName)("EXTENDED_DEPARTMENTS").Add(Array(DaDataReader.GetValue(DaDataReader.GetOrdinal("SQL_ID")).ToString(), DaDataReader.GetValue(DaDataReader.GetOrdinal("DESCRIPTION")).ToString(), DaDataReader.GetValue(DaDataReader.GetOrdinal("SOURCE_ID")).ToString()));                                                          


                            // SOLUTION!!
                            Microsoft.VisualBasic.Collection b = (Microsoft.VisualBasic.Collection)((Microsoft.VisualBasic.Collection)mvarCol_AppRights[AppShortName])["EXTENDED_DEPARTMENTS"];
                            b.Add(new string[3] { DaDataReader.GetValue(DaDataReader.GetOrdinal("SQL_ID")).ToString(), DaDataReader.GetValue(DaDataReader.GetOrdinal("DESCRIPTION")).ToString(), DaDataReader.GetValue(DaDataReader.GetOrdinal("SOURCE_ID")).ToString() }, null, null, null);

                        }
                    }

                    DaDataReader.Close();

                }


            }

        }
 

        /// <summary>
        /// All the PUBLIC Variables
        /// </summary>
       
        internal string cnConn
        {
            get { return _cnConn; }
            set { _cnConn = value; }
        }
        internal string sError
        {
            get { return mvarsError; }
            set { mvarsError = value; }
        }
        internal bool change_password
        {
            get { return mvarChange_password; }
            set { mvarChange_password = value; }

        }
        internal static string Title
        {
            get { return mvarTitle; }
            set { mvarTitle = value; }

        }
        internal static string Name
        {
            get { return mvarName; }
            set { mvarName = value; }

        }
        internal static string SurName
        {
            get 
            { 
                return mvarSurname; 
            }
            set 
            { 
                mvarSurname = value; 
            }

        }
        internal static string GivenName
        {
            get { return mvarGivenName; }
            set { mvarGivenName = value; }

        }
        internal static string EmailAddress
        {
            get { return mvarEMailAddress; }
            set { mvarEMailAddress = value; }
        }
        internal static string SAMAccountName
        {
            get { return mvarSAMaccountname; }
            set { mvarSAMaccountname = value; }

        }
        internal static Microsoft.VisualBasic.Collection MemberOf
        {
            get { return mvarCol_MemberOf; }
            set { mvarCol_MemberOf = value; }
        }
        internal static Microsoft.VisualBasic.Collection MemberOf2
        {
            get { return mvarCol_MemberOf2; }
            set { mvarCol_MemberOf2 = value; }

        }
        internal static Microsoft.VisualBasic.Collection Rights
        {
            get { return mvarCol_AppRights; }
            set { mvarCol_AppRights = value; }
        }
        internal string sRights
        {
            get { return mvarsRights; }
            set { mvarsRights = value; }

        }
        internal string DepartmentID
        {
            get { return mvarDepartmentID; }
            set { mvarDepartmentID = value; }

        }
        internal string DepartmentTypeID
        {
            get { return mvarDepartmentTypeID; }
            set { mvarDepartmentTypeID = value; }

        }
        internal string DepartmentSName
        {
            get { return mvarDepartmentSName; }
            set { mvarDepartmentSName = value; }
        }
        internal string Department
        {
            get { return mvarDepartment; }
            set { mvarDepartment = value; }
        }
        internal string ProvinceID
        {
            get { return mvarProvinceID; }
            set { mvarProvinceID = value; }
        }
        internal string ProvinceTypeID
        {
            get { return mvarProvinceTypeID; }
            set { mvarProvinceTypeID = value; }
        }
        internal string ProvinceSName
        {
            get { return mvarProvinceSName; }
            set { mvarProvinceSName = value; }
        }
        internal string Province
        {
            get { return mvarProvince; }
            set { mvarProvince = value; }
        }
        internal string getUserID(string Persalid)
        {

            // c# strings are zero based!!!

            switch (Persalid.ToString().ToUpper().Substring(0, 1))
            {

                case "P":

                    return ("1" + (Persalid.Substring(1)));

                case "S":

                    return ("2" + (Persalid.Substring(1)));

                case "V":

                    return ("3" + (Persalid.Substring(1)));

                case "T":

                    return ("4" + (Persalid.Substring(1)));

                default:

                    return "0";

            }
        }
        internal void getADServer(string ServerShortName)
        {

            /* Issue a Command to get the IPADDRESS and DC Back from teh Database  */

            SqlConnection DaConnection;
            SqlCommand DaCommand;
            SqlDataReader DaDataReader;

            DaConnection = new SqlConnection();
            DaConnection.ConnectionString = _cnConn;  /* As set by the user */
            DaConnection.Open();

            DaCommand = new SqlCommand();
            /* Setting the connecction like this is just for test now!!! */
            DaCommand.Connection = DaConnection;
            DaCommand.CommandText = "SELECT * FROM VIP..SERVER_TRANSLATION WHERE SHORT_NAME='" + ServerShortName.ToUpper() + "'";
            DaCommand.CommandType = System.Data.CommandType.Text;
            DaDataReader = DaCommand.ExecuteReader();

            if (DaDataReader.HasRows)
            {
                // Set the Privare Variables of the class
                DaDataReader.Read();
                IP_ADDRESS = DaDataReader.GetValue(DaDataReader.GetOrdinal("IP")).ToString();
                DC = DaDataReader.GetValue(DaDataReader.GetOrdinal("DC")).ToString();
            }
            else
            {
                IP_ADDRESS = "";
                DC = "";
                mvarsError = "SERVER_TRANSLATION FAILED";
            }

            /* Close the objects before we release them */
            DaConnection.Close();
            DaDataReader.Close();

        }
        internal static string AuthenticateIt(string Username, string ADSPassword)
        {
            PrincipalContext DaContext = new PrincipalContext(ContextType.Domain,
                                    IP_ADDRESS,
                                    "CN=" + Username + ",OU=USERS,OU=Vulindlela3," + DC,
                                    ADSMasterUsername,
                                    ADSMasterPassword);

            UserPrincipal ObjUser = UserPrincipal.FindByIdentity(DaContext, Username);

            // Get the users details and extract it.
            SAMAccountName = ObjUser.SamAccountName;
            Title = ObjUser.DistinguishedName;
            Name = ObjUser.Name;
            SurName = ObjUser.Surname;
            GivenName = ObjUser.GivenName;
            EmailAddress = ObjUser.EmailAddress;


            // Now get the collection's details (The RIGHTS OF THE USER!!!)
            string app;
            string entry;

            DirectorySearcher dsSearcher;
            DirectoryEntry dsDirectoryEntry;

            dsDirectoryEntry = new DirectoryEntry("LDAP://" + IP_ADDRESS + "/CN=" + Username + ",OU=USERS,OU=Vulindlela3," + DC, ADSMasterUsername, ADSMasterPassword);

            dsSearcher = new DirectorySearcher(dsDirectoryEntry);

            dsSearcher.Filter = "saMAccountName=" + Username;
            dsSearcher.PropertiesToLoad.Add("memberOf");

            SearchResult dsResult = dsSearcher.FindOne();

            int ColCount = dsResult.Properties["memberOf"].Count;

            for (byte bytCounter = 0; bytCounter <= (ColCount - 1); bytCounter++)
            {

                entry = dsResult.Properties["memberOf"][bytCounter].ToString(); entry = entry.Replace("OU=", ""); entry = entry.Replace("CN=", "");
                string xas = entry.Replace("DC=", "");

                string[] tempArray = xas.Split(','); // 100!!!
                string[] temparray2 = tempArray[0].Split('.');

                if (tempArray[1] == "GOVERNMENT_STRUCTURE")  // It's either the department or extended departments for an app.
                {
                    if (tempArray[0].IndexOf(".") >= 1)  //  It's an extended dept.
                    {
                        // On error resume next 
                        app = temparray2[0].ToString() + "=EXTENDED_DEPARTMENTS|";
                        mvarCol_MemberOf2.Add(app, app, null, null);


                        try
                        {
                            xas = mvarCol_MemberOf2[app] + "','" + temparray2[1];
                            mvarCol_MemberOf2.Remove(app);
                            mvarCol_MemberOf2.Add(xas, app, null, null);
                        }
                        catch (Exception ex)
                        {
                            // On Error GoTo err_handler
                            mvarsError = "{ADS6.authenticate} authenticate: (" + ex.Message + ") " + ex.Source;
                            return "false";

                            // Release Objects befor quitting 

                        }

                    }
                    else // Own dept.
                    {
                        getDetails(tempArray[0].ToString());
                    }

                }
                else if (tempArray[1] == "APPLICATION_RIGHTS") //  It's app right assignment
                {

                    app = temparray2[0] + "=APPLICATION_RIGHTS|";

                    try
                    {
                        mvarCol_MemberOf2.Add(app, app, null, null);
                    }
                    catch (Exception )
                    {
                        // On Error Resume Next 
                        // Soos in Richard se VB6 DLL
                    }


                    try
                    {
                        xas = mvarCol_MemberOf2[app] + "','" + temparray2[1];
                        mvarCol_MemberOf2.Remove(app);
                        mvarCol_MemberOf2.Add(xas, app, null, null);  // THEY ARE key / value PAIRS.
                    }
                    catch (Exception ex)
                    {
                        //  On Error GoTo err_handler
                        mvarsError = "{ADS6.authenticate} authenticate: (" + ex.Message + ") " + ex.Source;
                        return "false";
                        // Release Objects befor quitting 

                    }

                }

                // Create a Collection of Arrays!!
                mvarCol_MemberOf.Add(tempArray, entry, null, null);

            }

            SqlConnection DaConnection = new SqlConnection(_cnConn); DaConnection.Open();
            SqlCommand DaCommand = new SqlCommand();
            SqlDataReader DaDataReader;

            foreach (string DaEntry in mvarCol_MemberOf2)
            {
                Console.WriteLine(DaEntry);

                DaCommand.Connection = DaConnection;
                DaCommand.CommandType = CommandType.Text;
                DaCommand.CommandText = "SELECT APPLICATION_GROUP_ID, GROUP_SHORT_NAME FROM VIP_EXPANDED..APPLICATION_GROUPS WHERE UPPER(GROUP_SHORT_NAME)='" + DaEntry.Substring(0, DaEntry.IndexOf("=")) + "'";

                DaDataReader = DaCommand.ExecuteReader();

                if (DaDataReader.HasRows)
                {
                    DaDataReader.Read();  // Advances to da first Row......
                    add2Application(DaDataReader.GetValue(DaDataReader.GetOrdinal("APPLICATION_GROUP_ID")).ToString(), DaDataReader.GetValue(DaDataReader.GetOrdinal("GROUP_SHORT_NAME")).ToString(), DaEntry.ToString());
                }
                DaDataReader.Close();

            }


            if (mvarsRights.Length > 0)
            {
                mvarsRights = mvarsRights.Substring(1, mvarsRights.Length - 1); //  Right(mvarsRights, (mvarsRights.Length) - 1);
            }

            return "true";

        }
        internal static bool IsExpired(string Username)
        {
            PrincipalContext DaContext = new PrincipalContext(ContextType.Domain,
                                                IP_ADDRESS,
                                                "CN=" + Username + ",OU=USERS,OU=Vulindlela3," + DC,
                                                ADSMasterUsername,
                                                ADSMasterPassword);

            UserPrincipal user = UserPrincipal.FindByIdentity(DaContext, Username);

            if (user.AccountExpirationDate < DateTime.Now)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        internal static bool IsLocked(string Username)
        {

            PrincipalContext DaContext = new PrincipalContext(ContextType.Domain,
                                                IP_ADDRESS,
                                                "CN=" + Username + ",OU=USERS,OU=Vulindlela3," + DC,
                                                ADSMasterUsername,
                                                ADSMasterPassword);
            UserPrincipal User;
            try
            {
                User = UserPrincipal.FindByIdentity(DaContext, Username);
                return User.IsAccountLockedOut();
            }
            catch (Exception ex)
            {
                mvarsError = ex.Message;
                return false;
            }
            finally
            {
                // Release objects from memory
                User = null;
                DaContext = null;
            }


        }
        internal static bool Isvalid(string Username, string Password)
        {
            /*  Logic to link to ADS to See is user is Valid */

            // Log in to AD as master user
            PrincipalContext DaContext = new PrincipalContext(ContextType.Domain,
                                                IP_ADDRESS,
                                                "CN=" + Username + ",OU=USERS,OU=Vulindlela3," + DC,
                                                ADSMasterUsername,
                                                ADSMasterPassword);
            UserPrincipal User;

            // Check whether a user exists in AD (Password not checked here!!)

            try
            {
                // Try and create a user, if it exist!!
                User = UserPrincipal.FindByIdentity(DaContext, Username);
                return true;
            }
            catch (Exception ex)
            {
                // Invalid User that tried to log on or something
                mvarsError = ex.Message;
                return false;
            }

            finally
            {
                // Release objects from memory
                User = null;
                DaContext = null;
            }

        }
        internal static int getFinYear()
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
    }
}













