using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
namespace ADS7
{
	public class Authenticate
	{
		private Collection mvarCol_MemberOf = new Collection();
		private Collection mvarCol_MemberOf2 = new Collection();
		private Collection mvarCol_AppRights = new Collection();
		private bool mvarChange_password;
		private string ADSMasterUsername = "vulsystem";
		private string ADSMasterPassword = "Qsadoh!Qsadoh";
		private int ADSPasswordExpireAfter = 60;
		private int ADSMaxBadLogins = 4;
		private string _cnConn;
		private string mvarsConn;
		private string mvarTitle;
		private string mvarName;
		private string mvarSurname;
		private string mvarGivenName;
		private string mvarProvinceID;
		private string mvarProvinceTypeID;
		private string mvarProvince;
		private string mvarProvinceSName;
		private string mvarDepartmentID;
		private string mvarDepartmentTypeID;
		private string mvarDepartment;
		private string mvarDepartmentSName;
		private string mvarEMailAddress;
		private string mvarSAMaccountname;
		private string DC;
		private string IP_ADDRESS;
		private string mvarsRights = "";
		private string mvarsError;
		private Dictionary<string, string> Session_USER_RIGHTS = new Dictionary<string, string>();
		public string cnConn
		{
			get
			{
				return this._cnConn;
			}
			set
			{
				this._cnConn = value;
			}
		}
		public string sError
		{
			get
			{
				return this.mvarsError;
			}
			set
			{
				this.mvarsError = value;
			}
		}
		public bool change_password
		{
			get
			{
				return this.mvarChange_password;
			}
			set
			{
				this.mvarChange_password = value;
			}
		}
		public string Title
		{
			get
			{
				return this.mvarTitle;
			}
			set
			{
				this.mvarTitle = value;
			}
		}
		public string Name
		{
			get
			{
				return this.mvarName;
			}
			set
			{
				this.mvarName = value;
			}
		}
		public string SurName
		{
			get
			{
				return this.mvarSurname;
			}
			set
			{
				this.mvarSurname = value;
			}
		}
		public string GivenName
		{
			get
			{
				return this.mvarGivenName;
			}
			set
			{
				this.mvarGivenName = value;
			}
		}
		public string EmailAddress
		{
			get
			{
				return this.mvarEMailAddress;
			}
			set
			{
				this.mvarEMailAddress = value;
			}
		}
		public string SAMAccountName
		{
			get
			{
				return this.mvarSAMaccountname;
			}
			set
			{
				this.mvarSAMaccountname = value;
			}
		}
		public Collection MemberOf
		{
			get
			{
				return this.mvarCol_MemberOf;
			}
			private set
			{
				this.mvarCol_MemberOf = value;
			}
		}
		public Collection MemberOf2
		{
			get
			{
				return this.mvarCol_MemberOf2;
			}
			private set
			{
				this.mvarCol_MemberOf2 = value;
			}
		}
		public Collection Rights
		{
			get
			{
				return this.mvarCol_AppRights;
			}
			set
			{
				this.mvarCol_AppRights = value;
			}
		}
		public string sRights
		{
			get
			{
				return this.mvarsRights;
			}
			set
			{
				this.mvarsRights = value;
			}
		}
		public string DepartmentID
		{
			get
			{
				return this.mvarDepartmentID;
			}
			set
			{
				this.mvarDepartmentID = value;
			}
		}
		public string DepartmentTypeID
		{
			get
			{
				return this.mvarDepartmentTypeID;
			}
			set
			{
				this.mvarDepartmentTypeID = value;
			}
		}
		public string DepartmentSName
		{
			get
			{
				return this.mvarDepartmentSName;
			}
			set
			{
				this.mvarDepartmentSName = value;
			}
		}
		public string Department
		{
			get
			{
				return this.mvarDepartment;
			}
			set
			{
				this.mvarDepartment = value;
			}
		}
		public string ProvinceID
		{
			get
			{
				return this.mvarProvinceID;
			}
			set
			{
				this.mvarProvinceID = value;
			}
		}
		public string ProvinceTypeID
		{
			get
			{
				return this.mvarProvinceTypeID;
			}
			set
			{
				this.mvarProvinceTypeID = value;
			}
		}
		public string ProvinceSName
		{
			get
			{
				return this.mvarProvinceSName;
			}
			set
			{
				this.mvarProvinceSName = value;
			}
		}
		public string Province
		{
			get
			{
				return this.mvarProvince;
			}
			set
			{
				this.mvarProvince = value;
			}
		}
		public int getRightsCount
		{
			get
			{
				return this.mvarCol_AppRights.Count;
			}
		}
		public string getUserID(string Persalid)
		{
			string a;
			if ((a = Persalid.ToString().ToUpper().Substring(0, 1)) != null)
			{
				if (a == "P")
				{
					return "1" + Persalid.Substring(1);
				}
				if (a == "S")
				{
					return "2" + Persalid.Substring(1);
				}
				if (a == "V")
				{
					return "3" + Persalid.Substring(1);
				}
				if (a == "T")
				{
					return "4" + Persalid.Substring(1);
				}
			}
			return "0";
		}
		public void getADServer(string ServerShortName)
		{
			SqlConnection sqlConnection = new SqlConnection();
			sqlConnection.ConnectionString = this._cnConn;
			sqlConnection.Open();
			SqlDataReader sqlDataReader = new SqlCommand
			{
				Connection = sqlConnection,
				CommandText = "SELECT * FROM VIP..SERVER_TRANSLATION WHERE SHORT_NAME='" + ServerShortName.ToUpper() + "'",
				CommandType = CommandType.Text
			}.ExecuteReader();
			if (sqlDataReader.HasRows)
			{
				sqlDataReader.Read();
				this.IP_ADDRESS = sqlDataReader.GetValue(sqlDataReader.GetOrdinal("IP")).ToString();
				this.DC = sqlDataReader.GetValue(sqlDataReader.GetOrdinal("DC")).ToString();
			}
			else
			{
				this.IP_ADDRESS = "";
				this.DC = "";
				this.mvarsError = "SERVER_TRANSLATION FAILED";
			}
			sqlDataReader.Close();
		}
		public bool AuthenticateIt(string Username, string ADSPassword)
		{
			PrincipalContext principalContext = new PrincipalContext(ContextType.Domain, this.IP_ADDRESS, "CN=" + Username + ",OU=USERS,OU=Vulindlela3," + this.DC, Username, ADSPassword);
			if (!principalContext.ValidateCredentials(Username, ADSPassword))
			{
				principalContext.Dispose();
				return false;
			}
			UserPrincipal userPrincipal = UserPrincipal.FindByIdentity(principalContext, Username);
			this.SAMAccountName = userPrincipal.SamAccountName;
			this.Title = userPrincipal.DistinguishedName;
			this.Name = userPrincipal.Name;
			this.SurName = userPrincipal.Surname;
			this.GivenName = userPrincipal.GivenName;
			this.EmailAddress = userPrincipal.EmailAddress;
			DirectoryEntry searchRoot = new DirectoryEntry(string.Concat(new string[]
			{
				"LDAP://",
				this.IP_ADDRESS,
				"/CN=",
				Username,
				",OU=USERS,OU=Vulindlela3,",
				this.DC
			}), this.ADSMasterUsername, this.ADSMasterPassword);
			SearchResult searchResult = new DirectorySearcher(searchRoot)
			{
				Filter = "saMAccountName=" + Username,
				PropertiesToLoad = 
				{
					"memberOf"
				}
			}.FindOne();
			int count = searchResult.Properties["memberOf"].Count;
			for (int i = 0; i <= count - 1; i++)
			{
				string text = searchResult.Properties["memberOf"][i].ToString();
				text = text.Replace("OU=", "");
				text = text.Replace("CN=", "");
				string text2 = text.Replace("DC=", "");
				string[] array = text2.Split(new char[]
				{
					','
				});
				string[] array2 = array[0].Split(new char[]
				{
					'.'
				});
				if (array[1] == "GOVERNMENT_STRUCTURE")
				{
					if (array[0].IndexOf(".") >= 1)
					{
						string text3 = array2[0].ToUpper() + "=EXTENDED_DEPARTMENTS|";
						try
						{
							this.mvarCol_MemberOf2.Add(text3, text3, null, null);
						}
						catch (Exception)
						{
						}
						try
						{
							text2 = this.mvarCol_MemberOf2[text3] + "','" + array2[1];
							this.mvarCol_MemberOf2.Remove(text3);
							this.mvarCol_MemberOf2.Add(text2, text3, null, null);
							goto IL_33B;
						}
						catch (Exception ex)
						{
							this.mvarsError = "{ADS7.authenticate} authenticate: (" + ex.Message + ") " + ex.Source;
							userPrincipal.Dispose();
							principalContext.Dispose();
							bool result = false;
							return result;
						}
					}
					this.getDetails(array[0].ToString());
				}
				else
				{
					if (array[1] == "APPLICATION_RIGHTS")
					{
						string text3 = array2[0] + "=APPLICATION_RIGHTS|";
						try
						{
							this.mvarCol_MemberOf2.Add(text3, text3, null, null);
						}
						catch (Exception)
						{
						}
						try
						{
							text2 = this.mvarCol_MemberOf2[text3] + "','" + array2[1];
							this.mvarCol_MemberOf2.Remove(text3);
							this.mvarCol_MemberOf2.Add(text2, text3, null, null);
						}
						catch (Exception ex2)
						{
							this.mvarsError = "{ADS7.authenticate} authenticate: (" + ex2.Message + ") " + ex2.Source;
							userPrincipal.Dispose();
							principalContext.Dispose();
							bool result = false;
							return result;
						}
					}
				}
				IL_33B:
				this.mvarCol_MemberOf.Add(array, text, null, null);
			}
			SqlConnection sqlConnection = new SqlConnection(this._cnConn);
			sqlConnection.Open();
			SqlCommand sqlCommand = new SqlCommand();
			foreach (string text4 in this.mvarCol_MemberOf2)
			{
				//Console.WriteLine(text4);
				sqlCommand.Connection = sqlConnection;
				sqlCommand.CommandType = CommandType.Text;
				sqlCommand.CommandText = "SELECT APPLICATION_GROUP_ID, GROUP_SHORT_NAME FROM VIP_EXPANDED..APPLICATION_GROUPS WHERE UPPER(GROUP_SHORT_NAME)='" + text4.Substring(0, text4.IndexOf("=")) + "'";
				SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
				if (sqlDataReader.HasRows)
				{
					sqlDataReader.Read();
					this.add2Application(sqlDataReader.GetValue(sqlDataReader.GetOrdinal("APPLICATION_GROUP_ID")).ToString(), sqlDataReader.GetValue(sqlDataReader.GetOrdinal("GROUP_SHORT_NAME")).ToString(), text4.ToString());
				}
				sqlDataReader.Close();
			}
			if (this.mvarsRights.Length > 0)
			{
				this.mvarsRights = this.mvarsRights.Substring(1, this.mvarsRights.Length - 1);
			}
			userPrincipal.Dispose();
			principalContext.Dispose();
			return true;
		}
		public bool ChangePassword(string Username, string Password, string NewPassword)
		{
			PrincipalContext principalContext = new PrincipalContext(ContextType.Domain, this.IP_ADDRESS, "CN=" + Username + ",OU=USERS,OU=Vulindlela3," + this.DC, this.ADSMasterUsername, this.ADSMasterPassword);
			UserPrincipal userPrincipal = UserPrincipal.FindByIdentity(principalContext, Username);
			bool result;
			try
			{
				userPrincipal.ChangePassword(Password, NewPassword);
				userPrincipal.Save(principalContext);
				result = true;
			}
			catch (Exception ex)
			{
				this.mvarsError = ex.Message;
				result = false;
			}
			finally
			{
				userPrincipal.Dispose();
				principalContext.Dispose();
			}
			return result;
		}
		public bool IsExpired(string Username)
		{
			PrincipalContext principalContext = new PrincipalContext(ContextType.Domain, this.IP_ADDRESS, "CN=" + Username + ",OU=USERS,OU=Vulindlela3," + this.DC, this.ADSMasterUsername, this.ADSMasterPassword);
			UserPrincipal userPrincipal = UserPrincipal.FindByIdentity(principalContext, Username);
			bool result = userPrincipal.AccountExpirationDate < DateTime.Now;
			userPrincipal.Dispose();
			principalContext.Dispose();
			return result;
		}
		public bool IsLocked(string Username)
		{
			PrincipalContext principalContext = new PrincipalContext(ContextType.Domain, this.IP_ADDRESS, "CN=" + Username + ",OU=USERS,OU=Vulindlela3," + this.DC, this.ADSMasterUsername, this.ADSMasterPassword);
			bool result;
			try
			{
				UserPrincipal userPrincipal = UserPrincipal.FindByIdentity(principalContext, Username);
				result = userPrincipal.IsAccountLockedOut();
			}
			catch (Exception ex)
			{
				this.mvarsError = ex.Message;
				result = true;
			}
			finally
			{
				principalContext.Dispose();
			}
			return result;
		}
		public bool Isvalid(string Username, string Password)
		{
			PrincipalContext principalContext = new PrincipalContext(ContextType.Domain, this.IP_ADDRESS, "CN=" + Username + ",OU=USERS,OU=Vulindlela3," + this.DC, this.ADSMasterUsername, this.ADSMasterPassword);
			bool result;
			try
			{
				UserPrincipal.FindByIdentity(principalContext, Username);
				result = true;
				this.mvarsError = "";
			}
			catch (Exception ex)
			{
				this.mvarsError = ex.Message;
				result = false;
			}
			finally
			{
				principalContext.Dispose();
			}
			return result;
		}
		private void add2Application(string AppID, string AppShortName, string rigntsEntry)
		{
			Collection collection = new Collection();
			Collection item = new Collection();
			Collection item2 = new Collection();
			new Collection();
			try
			{
				collection.Add(item, "APPLICATION_RIGHTS", null, null);
				collection.Add(item2, "EXTENDED_DEPARTMENTS", null, null);
				collection.Add(new string[]
				{
					AppID,
					AppShortName
				}, "APPLICATION_DETAILS", null, null);
				this.mvarCol_AppRights.Add(collection, AppShortName, null, null);
			}
			catch (Exception)
			{
			}
			finally
			{
				SqlConnection sqlConnection = new SqlConnection();
				sqlConnection.ConnectionString = this._cnConn;
				sqlConnection.Open();
				SqlCommand sqlCommand = new SqlCommand();
				sqlCommand.Connection = sqlConnection;
				sqlCommand.CommandType = CommandType.Text;
				string text = rigntsEntry.Remove(0, rigntsEntry.IndexOf(",") + 1);
				if (rigntsEntry.ToUpper().Contains("APPLICATION_RIGHTS"))
				{
					sqlCommand.CommandText = "SELECT APPLICATION_ID, APPLICATION_SHORT_NAME FROM VIP_EXPANDED..APPLICATIONS WHERE APPLICATION_GROUP_ID=" + AppID + " ORDER BY APPLICATION_ID";
					SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
					if (sqlDataReader.HasRows)
					{
						while (sqlDataReader.Read())
						{
							this.mvarsRights = this.mvarsRights + "," + sqlDataReader.GetValue(sqlDataReader.GetOrdinal("APPLICATION_ID")).ToString();
						}
					}
					Collection collection2 = (Collection)((Collection)this.mvarCol_AppRights[AppShortName])["APPLICATION_RIGHTS"];
					collection2.Add(new string[]
					{
						AppID,
						text.ToString().Replace("'", "")
					}, null, null, null);
					sqlDataReader.Close();
				}
				else
				{
					sqlCommand.CommandText = string.Concat(new object[]
					{
						"SELECT DEPT_ID as SQL_ID, DEPT_DESCRIPTION as Description, DEPT_SHORT_NAME as SOURCE_ID FROM VIP_EXPANDED..VIEW_GOVERNMENT_STRUCTURE WHERE FINYEAR=",
						this.getFinYear(),
						" AND DEPT_SHORT_NAME IN(",
						text,
						"') ORDER BY SQL_ID"
					});
					sqlCommand.Connection = sqlConnection;
					SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
					if (sqlDataReader.HasRows)
					{
						while (sqlDataReader.Read())
						{
							Collection collection3 = (Collection)((Collection)this.mvarCol_AppRights[AppShortName])["EXTENDED_DEPARTMENTS"];
							collection3.Add(new string[]
							{
								sqlDataReader.GetValue(sqlDataReader.GetOrdinal("SQL_ID")).ToString(),
								sqlDataReader.GetValue(sqlDataReader.GetOrdinal("DESCRIPTION")).ToString(),
								sqlDataReader.GetValue(sqlDataReader.GetOrdinal("SOURCE_ID")).ToString()
							}, null, null, null);
						}
					}
					sqlDataReader.Close();
				}
			}
		}
		private void getDetails(string sname)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnConn);
			sqlConnection.Open();
			SqlDataReader sqlDataReader = new SqlCommand
			{
				CommandType = CommandType.Text,
				CommandText = "SELECT TOP 1 * FROM VIP_EXPANDED..VIEW_GOVERNMENT_STRUCTURE WHERE DEPT_SHORT_NAME='" + sname + "' ORDER BY FINYEAR DESC",
				Connection = sqlConnection
			}.ExecuteReader();
			if (sqlDataReader.HasRows)
			{
				while (sqlDataReader.Read())
				{
					this.mvarDepartmentSName = sname;
					this.mvarDepartment = sqlDataReader.GetValue(sqlDataReader.GetOrdinal("DEPT_DESCRIPTION")).ToString();
					this.mvarDepartmentID = sqlDataReader.GetValue(sqlDataReader.GetOrdinal("DEPT_ID")).ToString();
					this.mvarDepartmentTypeID = sqlDataReader.GetValue(sqlDataReader.GetOrdinal("DEPT_LEVEL_ID")).ToString();
					this.mvarProvinceSName = sqlDataReader.GetValue(sqlDataReader.GetOrdinal("NATPROV_SHORT_NAME")).ToString();
					this.mvarProvince = sqlDataReader.GetValue(sqlDataReader.GetOrdinal("NATPROV_DESCRIPTION")).ToString();
					this.mvarProvinceID = sqlDataReader.GetValue(sqlDataReader.GetOrdinal("NAT_PROV_ID")).ToString();
					this.mvarProvinceTypeID = sqlDataReader.GetValue(sqlDataReader.GetOrdinal("PROVINCE_FLAG")).ToString();
				}
			}
			sqlDataReader.Close();
		}
		public int getFinYear()
		{
			if (DateTime.Now.Month < 4)
			{
				return DateTime.Now.Year - 1;
			}
			return DateTime.Now.Year;
		}
		public bool MustChangePassword(string UserName, string Password)
		{
			DirectoryEntry searchRoot = new DirectoryEntry(string.Concat(new string[]
			{
				"LDAP://",
				this.IP_ADDRESS,
				"/CN=",
				UserName,
				",OU=USERS,OU=Vulindlela3,",
				this.DC
			}), this.ADSMasterUsername, this.ADSMasterPassword);
			SearchResult searchResult = new DirectorySearcher(searchRoot)
			{
				Filter = "saMAccountName=" + UserName,
				PropertiesToLoad = 
				{
					"UserFlags",
					"pwdLastSet"
				}
			}.FindOne();
			if (searchResult.Properties["pwdLastSet"].Count == 0)
			{
				return false;
			}
			string a = searchResult.Properties["pwdLastSet"][0].ToString();
			return a == "0";
		}
		private string getApplicationRights(int RightNumber)
		{
			string result;
			try
			{
				Collection collection = new Collection();
				Collection collection2 = new Collection();
				collection = (Collection)this.mvarCol_AppRights[RightNumber];
				collection2 = (Collection)collection["APPLICATION_RIGHTS"];
				string text = "";
				foreach (string[] array in collection2)
				{
					for (int i = 0; i <= array.Length - 1; i++)
					{
						text = text + array[i] + "|";
					}
				}
				if (text.Length > 0)
				{
					text = text.Substring(0, text.Length - 1);
				}
				result = text;
			}
			catch (Exception ex)
			{
				result = ex.Message;
			}
			return result;
		}
		private string getExtendedDepartments(int RightNumber)
		{
			string result;
			try
			{
				Collection collection = new Collection();
				Collection collection2 = new Collection();
				collection = (Collection)this.mvarCol_AppRights[RightNumber];
				collection2 = (Collection)collection["EXTENDED_DEPARTMENTS"];
				string text = "";
				foreach (string[] array in collection2)
				{
					for (int i = 0; i <= array.Length - 1; i++)
					{
						text = text + array[i] + "|";
					}
				}
				if (text.Length > 0)
				{
					text = text.Substring(0, text.Length - 1);
				}
				result = text;
			}
			catch (Exception ex)
			{
				result = ex.Message;
			}
			return result;
		}
		private string getApplicationDetails(int RightNumber)
		{
			string result;
			try
			{
				Collection collection = new Collection();
				collection = (Collection)this.mvarCol_AppRights[RightNumber];
				string[] array = (string[])collection["APPLICATION_DETAILS"];
				string text = "";
				for (int i = 0; i <= array.Length - 1; i++)
				{
					text = text + array[i] + "|";
				}
				if (text.Length > 0)
				{
					text = text.Substring(0, text.Length - 1);
				}
				result = text;
			}
			catch (Exception ex)
			{
				result = ex.Message;
			}
			return result;
		}
		public string getSessionVariables()
		{
			this.Session_USER_RIGHTS.Add("GFS_USER_TYPE", "0");
			this.Session_USER_RIGHTS.Add("HR_USER_TYPE", "0");
			this.Session_USER_RIGHTS.Add("FINANCIALS_USER_TYPE", "0");
			this.Session_USER_RIGHTS.Add("LOGIS_USER_TYPE", "0");
			this.Session_USER_RIGHTS.Add("DPSA_USER_TYPE", "0");
			this.Session_USER_RIGHTS.Add("AUDITGENL_USER_TYPE", "0");
			this.Session_USER_RIGHTS.Add("GENERAL_REPORTING_USER_TYPE", "0");
			this.Session_USER_RIGHTS.Add("PERSALPDF_USER_TYPE", "0");
			this.Session_USER_RIGHTS.Add("HR_OVERSIGHT_USER_TYPE", "0");
			foreach (Collection collection in this.mvarCol_AppRights)
			{
				//Console.Write("Stop Hier");
				if (((string[])collection["APPLICATION_DETAILS"])[1] == "FINANCIALS" | ((string[])collection["APPLICATION_DETAILS"])[1] == "HR" | ((string[])collection["APPLICATION_DETAILS"])[1] == "AUDITGENL" | ((string[])collection["APPLICATION_DETAILS"])[1] == "GENERAL_REPORTING" | ((string[])collection["APPLICATION_DETAILS"])[1] == "PERSALPDF" | ((string[])collection["APPLICATION_DETAILS"])[1] == "HR_OVERSIGHT" | ((string[])collection["APPLICATION_DETAILS"])[1] == "LOGIS")
				{
					this.ExtractAppRights(collection, ((string[])collection["APPLICATION_DETAILS"])[1]);
				}
				else
				{
					if (((string[])collection["APPLICATION_DETAILS"])[1] == "GFS")
					{
						this.Session_USER_RIGHTS["GFS_USER_TYPE"] = "1";
					}
					else
					{
						if (((string[])collection["APPLICATION_DETAILS"])[1] == "DPSA")
						{
							this.Session_USER_RIGHTS["DPSA_USER_TYPE"] = "1";
						}
					}
				}
			}
			string text = "";
			foreach (KeyValuePair<string, string> current in this.Session_USER_RIGHTS)
			{
				text = string.Concat(new string[]
				{
					text,
					current.Key,
					"|",
					current.Value,
					"|"
				});
			}
			if (text.Length > 0)
			{
				text = text.Substring(0, text.Length - 1);
			}
			return text;
		}
		private void ExtractAppRights(Collection DA_APP, string appCode)
		{
			new Collection();
			foreach (string[] array in (Collection)DA_APP["APPLICATION_RIGHTS"])
			{
				string key;
				switch (key = array[1].ToString())
				{
				case "":
					this.Session_USER_RIGHTS[appCode + "_USER_TYPE"] = "0";
					break;

				case "CON":
					this.Session_USER_RIGHTS[appCode + "_USER_TYPE"] = "1";
					break;

				case "NAT":
					this.Session_USER_RIGHTS[appCode + "_USER_TYPE"] = "2";
					break;

				case "PROV":
					this.Session_USER_RIGHTS[appCode + "_USER_TYPE"] = "3";
					break;

				case "OWN_PROV":
					if (this.mvarProvinceSName == "NAT")
					{
						this.Session_USER_RIGHTS[appCode + "_USER_TYPE"] = "2";
					}
					else
					{
						this.Session_USER_RIGHTS[appCode + "_USER_TYPE"] = "4";
					}
					break;

				case "OWN_DEPT":
					this.Session_USER_RIGHTS[appCode + "_USER_TYPE"] = "5";
					break;

				case "ASSIGN_DEPT":
					this.Session_USER_RIGHTS[appCode + "_USER_TYPE"] = "6";
					this.Session_USER_RIGHTS.Add(appCode + "_EXTEND_DEPTS", "");
					foreach (string[] array2 in (Collection)DA_APP["EXTENDED_DEPARTMENTS"])
					{
						this.Session_USER_RIGHTS[appCode + "_EXTEND_DEPTS"] = "'" + array2[2] + "'," + this.Session_USER_RIGHTS[appCode + "_EXTEND_DEPTS"];
					}
					this.Session_USER_RIGHTS[appCode + "_EXTEND_DICT"] = "";
					if (this.Session_USER_RIGHTS[appCode + "_EXTEND_DEPTS"].Length > 1)
					{
						this.Session_USER_RIGHTS[appCode + "_EXTEND_DEPTS"] = this.Session_USER_RIGHTS[appCode + "_EXTEND_DEPTS"].Substring(0, this.Session_USER_RIGHTS[appCode + "_EXTEND_DEPTS"].Length - 1);
					}
					break;
				}
			}
		}
	}
}
