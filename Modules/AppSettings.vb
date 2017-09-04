Imports ADAdminDotNet.My
Imports System
Imports System.ComponentModel
Imports System.Drawing.Design
Imports System.Windows.Forms.Design

Namespace ADAdminDotNet.AdAdminConfigs
	Public Class AppSettings
		Public Class VulindlelaControllers
			Inherits StringConverter

			Private Vulindlela_Controllers As String()

			Public Sub New()
				Me.Vulindlela_Controllers = New String()() { "WCP,Ralton Kirby <Rkirby@pgwc.gov.za>|NCP,Michael Femmers <femmersm@ncpg.gov.za>", "WCP,Ralton Kirby <Rkirby@pgwc.gov.za>|NCP,Michael Femmers <femmersm@ncpg.gov.za>|GAU,Johan Vermeulen <johan.vermeulen@treasury.gov.za>" }
			End Sub

			Public Overrides Function GetStandardValues(context As ITypeDescriptorContext) As TypeConverter.StandardValuesCollection
				Return New TypeConverter.StandardValuesCollection(Me.Vulindlela_Controllers)
			End Function

			Public Overrides Function GetStandardValuesExclusive(context As ITypeDescriptorContext) As Boolean
				Return True
			End Function

			Public Overrides Function GetStandardValuesSupported(context As ITypeDescriptorContext) As Boolean
				Return True
			End Function
		End Class

		Private _Active_QA As String

		Private _Active_PRD As String

		Private _ValidUser As String

		Private _VulindlelaUser As String

		Private _SMPTPServerNames As String

		Private _BMCRemedyServerAddress As String

		Private _DefaultWebBrowserEXE As String

		Private _VulinSQLServerList As String

		Private _VulindlelaSQLServerAddress As String

		Private _VIP_ExpandedConnectionString As String

		Private _ADSQAConnectionString As String

		Private _ADSPRDConnectionString As String

		Private _ADSConnectionString As String

		Private _RemedySQLConnection As String

		Private _ARSystemConnectionString As String

		Private _AD_Users_PRD As String

		Private _AD_Users_QA As String

		Private _AD_DC_PRD As String

		Private _AD_DC_QA As String

		Private _ADSMasterPassword_PRD As String

		Private _ADSMasterPassword_QA As String

		Private _ContextApplicationPRD As String

		Private _ContextApplicationQA As String

		Private _VulindlelaContextPRD As String

		Private _VulindlelaContextQA As String

		Private _AD_ServerName_PRD As String

		Private _AD_ServerName_QA As String

		Private _ADSMasterUsername_PRD As String

		Private _ADSMasterUsername_QA As String

		Private _IP_Address_PRD As String

		Private _IP_Address_QA As String

		Private _WebUrlQA As String

		Private _WebUrlPRD As String

		Private _HelpDesk_PhoneNo As String

		Private _SMTPServerIPAddress As String

		Private _RemedyServerName As String

		Private _Vulindlela_Controllers As String

		Private _ARSServerName As String

		Private _ARServerPort As String

		Private _ARUser As String

		Private _ARPassword As String

		Private _DeptDescPair As String

		Private _WebBrowserExe As String

		Private _ProxyOveride As String

		Private _ProxyOverideCurrent As String

		Private _Close_Pick_Forms As Boolean

		<Category("Vulindlela Settings"), Description("Behaviour of picklists - Wheter to close or stay open")>
		Public Property Close_Pick_Forms() As Boolean
			Get
				Return Me._Close_Pick_Forms
			End Get
			Set(value As Boolean)
				Me._Close_Pick_Forms = value
			End Set
		End Property

		<Category("Proxy Server Settings"), Description("New Proxy Server Exception settings to be applied")>
		Public Property ProxyOveride() As String
			Get
				Return Me._ProxyOveride
			End Get
			Set(value As String)
				Me._ProxyOveride = value
			End Set
		End Property

		<Category("Proxy Server Settings"), Description("Current Proxy Server Exception settings"), TypeConverter(GetType(GetProxyOverideFromRegistry))>
		Public Property ProxyOverideCurrent() As String
			Get
				Return Me._ProxyOverideCurrent
			End Get
			Set(value As String)
				Me._ProxyOverideCurrent = value
			End Set
		End Property

		<Category("Vulindlela Settings"), Description("Vulindlela Controllers who are registered to get EMail communication"), TypeConverter(GetType(AppSettings.VulindlelaControllers))>
		Public Property Vulindlela_Controllers() As String
			Get
				Return Me._Vulindlela_Controllers
			End Get
			Set(value As String)
				Me._Vulindlela_Controllers = value
			End Set
		End Property

		<Category("BMC Remedy Configs"), Description("BMC Remedy Server hostname to be used in queries (not the FQDN)"), TypeConverter(GetType(BmcARSServerList))>
		Public Property ARSServerName() As String
			Get
				Return Me._ARSServerName
			End Get
			Set(value As String)
				Me._ARSServerName = value
			End Set
		End Property

		<Category("BMC Remedy Configs"), Description("BMC Remedy Webserver name to be used immediately after HTTP:// in calls"), TypeConverter(GetType(BmcWebServerList))>
		Public Property RemedyServerName() As String
			Get
				Return Me._RemedyServerName
			End Get
			Set(value As String)
				Me._RemedyServerName = value
			End Set
		End Property

		<Category("BMC Remedy Configs"), Description("BMC Remedy system password to be used by ADAdmin to logon")>
		Public Property ARPassword() As String
			Get
				Return Me._ARPassword
			End Get
			Set(value As String)
				Me._ARPassword = value
			End Set
		End Property

		<Category("BMC Remedy Configs"), Description("The curent BMC Remedy System user's name"), TypeConverter(GetType(VulindlelaUsers))>
		Public Property ARUser() As String
			Get
				Return Me._ARUser
			End Get
			Set(value As String)
				Me._ARUser = value
			End Set
		End Property

		<Category("Active Directory Configuration"), Description("Comma seperated value-pairs to define NATPROV descriptions")>
		Public Property DeptDescPair() As String
			Get
				Return Me._DeptDescPair
			End Get
			Set(value As String)
				Me._DeptDescPair = value
			End Set
		End Property

		<Category("Active Directory Configuration"), Description("'AD Admin' Master password for the Production Server environment"), [ReadOnly](True)>
		Public Property ADSMasterPassword_PRD() As String
			Get
				Return Me._ADSMasterPassword_PRD
			End Get
			Set(value As String)
				Me._ADSMasterPassword_PRD = value
			End Set
		End Property

		<Category("Active Directory Configuration"), Description("ADAdmin master password for QA environment"), [ReadOnly](True)>
		Public Property ADSMasterPassword_QA() As String
			Get
				Return Me._ADSMasterPassword_QA
			End Get
			Set(value As String)
				Me._ADSMasterPassword_QA = value
			End Set
		End Property

		<Category("Active Directory Configuration"), Description("LDAP String used to connect to the Active Directory USERS [Organisational Unit] of Active Directory in PRD"), [ReadOnly](True)>
		Public Property AD_Users_PRD() As String
			Get
				Return Me._AD_Users_PRD
			End Get
			Set(value As String)
				Me._AD_Users_PRD = value
			End Set
		End Property

		<Category("Active Directory Configuration"), Description("LDAP String used to connect to the Active Directory USERS [Organisational Unit] of Active Directory in QA"), [ReadOnly](True)>
		Public Property AD_Users_QA() As String
			Get
				Return Me._AD_Users_QA
			End Get
			Set(value As String)
				AddressOf Me.AD_Users_QA = value
			End Set
		End Property

		<Category("Vulindlela Settings"), Description("Help desk's phone number")>
		Public Property HelpDesk_PhoneNo() As String
			Get
				Return Me._HelpDesk_PhoneNo
			End Get
			Set(value As String)
				Me._HelpDesk_PhoneNo = value
			End Set
		End Property

		<Category("Vulindlela Settings"), Description("The SMTP EMail Server IP Address"), TypeConverter(GetType(SMTPServerList))>
		Public Property SMTPServerIPAddress() As String
			Get
				Return Me._SMTPServerIPAddress
			End Get
			Set(value As String)
				Me._SMTPServerIPAddress = value
			End Set
		End Property

		<Category("Vulindlela Settings"), Description("Select the current Vulindlela user from the list."), TypeConverter(GetType(VulindlelaUsers))>
		Public Property VulindlelaUser() As String
			Get
				Return Me._VulindlelaUser
			End Get
			Set(value As String)
				Me._VulindlelaUser = value
			End Set
		End Property

		<Category("Hosts && IP Addresses"), Description("Vulindlela SQL Server Address List"), TypeConverter(GetType(VulindlelaSqlServerList))>
		Public Property VulindlelaSqlServerAddress() As String
			Get
				Return Me._VulindlelaSQLServerAddress
			End Get
			Set(value As String)
				Me._VulindlelaSQLServerAddress = value
			End Set
		End Property

		<Category("Database Connections"), Description("BMC Remedy SQL Server connection strings to the SQL2012 instance")>
		Public Property RemedySqlConnection() As String
			Get
				Return Me._RemedySQLConnection
			End Get
			Set(value As String)
				Me._RemedySQLConnection = value
			End Set
		End Property

		<Category("Database Connections"), Description("BMC Remedy SQL Server connection strings to the SQL2005 instance")>
		Public Property ARSystemConnectionString() As String
			Get
				Return Me._ARSystemConnectionString
			End Get
			Set(value As String)
				Me._ARSystemConnectionString = value
			End Set
		End Property

		<Category("Database Connections"), Description("[Switcher] ADS Database connection string for the QA Environment (10.123.45.210)")>
		Public Property ADSQAConnectionString() As String
			Get
				Return Me._ADSQAConnectionString
			End Get
			Set(value As String)
				Me._ADSQAConnectionString = value
			End Set
		End Property

		<Category("Database Connections"), Description("VIP_EXPANDED Database connection string for the Prodution Environment (10.123.45.180)")>
		Public Property VIP_ExpandedConnectionString() As String
			Get
				Return Me._VIP_ExpandedConnectionString
			End Get
			Set(value As String)
				Me._VIP_ExpandedConnectionString = value
			End Set
		End Property

		<Category("Database Connections"), Description("[Switcher] ADS Database connection string for the Prodution Environment (10.123.45.180)")>
		Public Property ADSPRDConnectionString() As String
			Get
				Return Me._ADSPRDConnectionString
			End Get
			Set(value As String)
				Me._ADSPRDConnectionString = value
			End Set
		End Property

		<Category("Database Connections"), Description("[ACTIVE] ADS Database connection string for the Prodution Environment (10.123.45.180)")>
		Public Property ADSConnectionString() As String
			Get
				Return Me._ADSConnectionString
			End Get
			Set(value As String)
				Me._ADSConnectionString = value
			End Set
		End Property

		<Category("Vulindlela Settings"), Description("Default Web browser program executabe to be used when processing web requests"), Editor(GetType(FileNameEditor), GetType(UITypeEditor))>
		Public Property DefaultWebBrowserEXE() As String
			Get
				Return Me._DefaultWebBrowserEXE
			End Get
			Set(value As String)
				Me._DefaultWebBrowserEXE = value
			End Set
		End Property

		Public Sub New()
			Me._Active_QA = "True"
			Me._Active_PRD = "True"
			Me._ValidUser = "False"
			Me._VulindlelaUser = AddressOf AddressOf MySettings.[Default].VulindlelaUser
			Me._SMPTPServerNames = AddressOf AddressOf MySettings.[Default].SMTPServerIPAddress
			Me._BMCRemedyServerAddress = AddressOf AddressOf MySettings.[Default].ARSServerName
			Me._DefaultWebBrowserEXE = AddressOf AddressOf MySettings.[Default].WebBrowserEXE
			Me._VulindlelaSQLServerAddress = AddressOf AddressOf MySettings.[Default].IP_ADDRESS_PRD
			Me._VIP_ExpandedConnectionString = AddressOf AddressOf MySettings.[Default].VIP_EXPANDEDConnectionString
			Me._ADSQAConnectionString = AddressOf AddressOf MySettings.[Default].AdsQAConnectionString
			Me._ADSPRDConnectionString = AddressOf AddressOf MySettings.[Default].AdsPRDConnectionString
			Me._ADSConnectionString = AddressOf AddressOf MySettings.[Default].AdsConnectionString
			Me._RemedySQLConnection = AddressOf AddressOf MySettings.[Default].ARSystemConnectionStringNew
			Me._ARSystemConnectionString = AddressOf AddressOf MySettings.[Default].ARSystemConnectionStringOld
			Me._AD_Users_PRD = AddressOf AddressOf MySettings.[Default].AD_USERS_PRD
			Me._AD_Users_QA = AddressOf AddressOf MySettings.[Default].AD_USERS_QA
			Me._AD_DC_PRD = AddressOf AddressOf MySettings.[Default].AD_DC_PRD
			Me._AD_DC_QA = AddressOf AddressOf MySettings.[Default].AD_DC_QA
			Me._ADSMasterPassword_PRD = AddressOf AddressOf MySettings.[Default].ADSMasterPassword_PRD
			Me._ADSMasterPassword_QA = AddressOf AddressOf MySettings.[Default].ADSMasterPassword_QA
			Me._ContextApplicationPRD = AddressOf AddressOf MySettings.[Default].contextApplicationPRD
			Me._ContextApplicationQA = AddressOf AddressOf MySettings.[Default].contextApplicationQA
			Me._VulindlelaContextPRD = AddressOf AddressOf MySettings.[Default].VulindlelaContextPRD
			Me._VulindlelaContextQA = AddressOf AddressOf MySettings.[Default].VulindlelaContextQA
			Me._AD_ServerName_PRD = AddressOf AddressOf MySettings.[Default].AD_ServerName_PRD
			Me._AD_ServerName_QA = AddressOf AddressOf MySettings.[Default].AD_ServerName_QA
			Me._ADSMasterUsername_PRD = AddressOf AddressOf MySettings.[Default].ADSMasterUsername_PRD
			Me._ADSMasterUsername_QA = AddressOf AddressOf MySettings.[Default].ADSMasterUsername_QA
			Me._IP_Address_PRD = AddressOf AddressOf MySettings.[Default].IP_ADDRESS_PRD
			Me._IP_Address_QA = AddressOf AddressOf MySettings.[Default].IP_ADDRESS_QA
			Me._WebUrlQA = AddressOf AddressOf MySettings.[Default].WEBURLPRD
			Me._WebUrlPRD = AddressOf AddressOf MySettings.[Default].WEBURLQA
			Me._HelpDesk_PhoneNo = AddressOf AddressOf MySettings.[Default].HelpDesk_PhoneNo
			Me._SMTPServerIPAddress = AddressOf AddressOf MySettings.[Default].SMTPServerIPAddress
			Me._RemedyServerName = AddressOf AddressOf MySettings.[Default].RemedyServerName
			Me._Vulindlela_Controllers = AddressOf AddressOf MySettings.[Default].Vulindlela_Controllers
			Me._ARSServerName = AddressOf AddressOf MySettings.[Default].ARSServerName
			Me._ARServerPort = AddressOf AddressOf MySettings.[Default].ARServerPort
			Me._ARUser = AddressOf AddressOf MySettings.[Default].ARUser
			Me._ARPassword = AddressOf AddressOf MySettings.[Default].ARPassword
			Me._DeptDescPair = AddressOf AddressOf MySettings.[Default].DeptDescPair
			Me._WebBrowserExe = AddressOf AddressOf MySettings.[Default].WebBrowserEXE
			Me._ProxyOveride = AddressOf AddressOf MySettings.[Default].ProxyOveride
			Me._ProxyOverideCurrent = AddressOf AddressOf MySettings.[Default].ProxyOverideCurrent
			Me._Close_Pick_Forms = AddressOf AddressOf MySettings.[Default].Close_Pick_Forms
		End Sub

		Public Function GetStandardValuesExclusive(context As ITypeDescriptorContext) As Boolean
			Return True
		End Function

		Public Function GetStandardValuesSupported(context As ITypeDescriptorContext) As Boolean
			Return True
		End Function
	End Class
End Namespace
