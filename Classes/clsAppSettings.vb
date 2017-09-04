'VulindlelaUsers
Imports System
Imports System.IO
Imports System.Xml
Imports System.Text
Imports System.Reflection
Imports System.Collections
Imports System.Configuration
Imports System.Collections.Specialized
Imports System.Windows.Forms.Design
Imports System.ComponentModel.StringConverter
Imports ExpandableObjectConverter
Imports System.Drawing.Design
Imports System.ComponentModel
Imports System.ComponentModel.CategoryAttribute
Imports System.Windows.Forms
Imports System.Globalization
Imports System.ComponentModel.TypeConverter
Imports System.ComponentModel.TypeConverter.StandardValuesCollection
Imports System.Drawing

'Imports System.ComponentModel
'Imports System.Drawing.Design
'Imports System.Globalization
'Imports System.Xml
'Imports System.Xml.Serialization
'Imports System.Reflection
'Imports System.Windows.Forms.Design
'Imports System.ComponentModel.StringConverter
'Imports ExpandableObjectConverter
'Imports System.ComponentModel.CategoryAttribute
'Imports System.Windows.Forms
'Imports System.ComponentModel.TypeConverter
'Imports System.ComponentModel.TypeConverter.StandardValuesCollection
'Imports System
'Imports System.Drawing

'Namespace MyPropetyGrid

'    Public Class AppSettings
'        '//////////////////////////////////////////////////

'        Private _BMCRemedySQLServerAddress As String = ""
'        Private _VulindlelaSQLServerAddress As String = ""
'        Private _ConfigFile As String = "ADAdminConsole.exe.config"
'        Private _DefaultWebBrowserEXE As String = "C:\Users\vul2126\AppData\Local\Google\Chrome\Application\chrome.exe"
'        Private _ConfigFolder As String = ""
'        Private _LastName As Person
'        Private _ARSystemConnectionString As String = "Data Source=10.123.216.102\SQL2005;Initial Catalog=ARSystem;Persist Security Info=True;User ID=Vulindlela;Password=vulindlela123"
'        Private _ADSQAConnectionString As String = "Data Source=10.123.45.210;Initial Catalog=Ads;Persist Security Info=True;User ID=sa;Password=S@P@SSW0RD"
'        Private _VIP_ExpandedConnectionString As String = "Data Source=10.123.45.180;Initial Catalog=VIP_EXPANDED;Persist Security Info=True;User ID=sa;Password=M33Q1Serv!ce09"
'        Private _ADSPRDConnectionString As String = "Data Source=10.123.45.180;Initial Catalog=Ads;Persist Security Info=True;User ID=sa;Password=M33Q1Serv!ce09"
'        Private _ADSConnectionString As String = "Data Source=10.123.45.180;Initial Catalog=Ads;Persist Security Info=True;User ID=sa;Password=M33Q1Serv!ce09"
'        Private _RemedySQLConnection As String = "Data Source=10.123.216.106\SQL2012;Initial Catalog=ARSystem;Integrated Security=True"

'        Private _LOG_DM_Department_BasicWs__c As String = "http://prodlgremv1/arsys/services/ARService?server=ProdLGRemV1&webService=LOG_DM_Department_BasicWS__c"
'        Private _LOG_DM_Personnel_BasicWs__c As String = "http://prodlgremv1/arsys/services/ARService?server=ProdLGRemV1&webService=LOG_DM_Personnel_BasicWS__c"
'        Private _LOG_IN_Request_Tracking_BasicWs__c As String = "http://prodlgremv1/arsys/services/ARService?server=ProdLGRemV1&webService=LOG_IN_Request_Tracking_BasicWS__c"
'        Private _LOG_DM_Customer_Information_BasicWs__c As String = "http://prodlgremv1/arsys/services/ARService?server=ProdLGRemV1&webService=LOG_DM_Customer_Information_BasicWS__c"

'        Private _ARSystemConnectionStringOld As String = "Data Source=10.123.216.102\SQL2005;Initial Catalog=ARSystem;Persist Security Info=True;User ID=Vulindlela;Password=vulindlela123"
'        Private _ARSystemDevConnectionString As String = "Data Source=10.123.216.106\SQL2012;Initial Catalog=ARSystem;Integrated Security=True"

'        Private _AD_Users_PRD As String = "OU=USERS,OU=Vulindlela3,DC=vulindlelaprd,DC=gov,DC=za"
'        Private _AD_Users_QA As String = "OU=USERS,OU=Vulindlela3,DC=vulqa,DC=pwv,DC=gov,DC=za"
'        Private _AD_DC_PRD As String = "DC=vulprd,DC=pwv,DC=gov,DC=za"
'        Private _AD_DC_QA As String = "DC=vulqa,DC=pwv,DC=gov,DC=za"
'        Private _ADSMasterPassword_PRD As String = "UnRlqHdCaqp8mOHvR2N3bg=="
'        Private _ADSMasterPassword_QA As String = "UnRlqHdCaqp8mOHvR2N3bg=="
'        Private _ContextApplicationPRD As String = "OU=APPLICATION_RIGHTS,OU=Vulindlela3,DC=vulindlelaprd,DC=gov,DC=za"
'        Private _ContextApplicationQA As String = "OU=APPLICATION_RIGHTS,OU=Vulindlela3,DC=vulqa,DC=pwv,DC=gov,DC=za"
'        Private _VulindlelaContextPRD As String = "OU=Vulindlela3,DC=vulindlelaprd,DC=gov,DC=za"
'        Private _VulindlelaContextQA As String = "OU=Vulindlela3,DC=vulqa,DC=pwv,DC=gov,DC=za"
'        Private _AD_ServerName_PRD As String = "VULWEB"
'        Private _AD_ServerName_QA As String = "VULQA1"
'        Private _ADSMasterUsername_PRD As String = "vulsystem"
'        Private _ADSMasterUsername_QA As String = "vulsystem"

'        Private _Active_QA As String = "True"
'        Private _Active_PRD As String = "True"

'        Private _IP_Address_PRD As String = "10.123.45.180"
'        Private _IP_Address_QA As String = "10.123.45.210"

'        Private _WebUrlQA As String = "http://10.123.45.210/"
'        Private _WebUrlPRD As String = "http://www.vulindlela.gov.za/"
'        Private _ValidUser As String = "False"
'        Private _HelpDeskPhoneNo As String = "012-6574444"
'        Private _SMTPServerIPAddress As String = "10.123.45.210"
'        Private _RemedyServerName As String = "ProdLGRemV1.Logis.gov.za"
'        Private _RemedyUserName As String = "T0005221"
'        Private _Vulindlela_Controllers As String = "WCP,Ralton Kirby &lt;Rkirby@pgwc.gov.za&gt;|NCP,Michael Femmers &lt;femmersm@ncpg.gov.za&gt;"
'        Private _ARSServerName As String = "ProdLGRemV1.Logis.gov.za"
'        Private _ARServerPort As String = "80"
'        Private _ARUser As String = "T0005221"
'        Private _ARPassword As String = "logik007"
'        Private _DeptDescPair As String = ""
'        Private _WebBrowserExe As String = ""

'        '<TypeConverter(GetType(Person)), _
'        'CategoryAttribute("Vulindlela Settings"), _
'        'DefaultValueAttribute("012-6574444"), _
'        'Description("Select your prefered favor of pasta from the list.")> _
'        'Public Property LastName() As String
'        '    Get
'        '        Return _LastName()
'        '    End Get
'        '    Set(ByVal Value As String)
'        '        _LastName() = Value
'        '    End Set
'        'End Property



'        <DescriptionAttribute("Phone number appearing on outgoing emails"), _
'        CategoryAttribute("Active Directory Context")> _
'        Public Property AD_Users_PRD() As String
'            Get
'                Return _AD_Users_PRD
'            End Get
'            Set(ByVal Value As String)
'                _AD_Users_PRD = Value
'            End Set
'        End Property

'        <DescriptionAttribute("Phone number appearing on outgoing emails"), _
'        CategoryAttribute("Active Directory Context")> _
'        Public Property AD_Users_QA() As String
'            Get
'                Return _AD_Users_QA
'            End Get
'            Set(ByVal Value As String)
'                AD_Users_QA = Value
'            End Set
'        End Property

'        <DescriptionAttribute("Phone number appearing on outgoing emails"), _
'        CategoryAttribute("Vulindlela Settings"), _
'        DefaultValueAttribute("012-6574444")> _
'        Public Property HelpDeskPhoneNo() As String
'            Get
'                Return _HelpDeskPhoneNo
'            End Get
'            Set(ByVal Value As String)
'                _HelpDeskPhoneNo = Value
'            End Set
'        End Property

'        <DescriptionAttribute("The SMTP EMail Server IP Address"), _
'         CategoryAttribute("Vulindlela Settings")> _
'        Public Property SMTPServerIPAddress() As String
'            Get
'                Return _SMTPServerIPAddress
'            End Get
'            Set(ByVal Value As String)
'                _SMTPServerIPAddress = Value
'            End Set
'        End Property

'        <TypeConverter(GetType(BmcSqlServerList)), _
'        Category("SQL Servers"), _
'        Description("Select your prefered favor of pasta from the list.")> _
'        Public Property BmcRemedySqlServerAddress() As String
'            Get
'                Return _BMCRemedySQLServerAddress
'            End Get
'            Set(ByVal Value As String)
'                _BMCRemedySQLServerAddress = Value
'            End Set
'        End Property

'        <TypeConverter(GetType(Person)), _
'        Category("Vulindlela Settings"), _
'        Description("Select the user from the lists.")> _
'        Public Property CurrentUser() As String
'            Get
'                Return _BMCRemedySQLServerAddress
'            End Get
'            Set(ByVal Value As String)
'                _BMCRemedySQLServerAddress = Value
'            End Set
'        End Property


'        ''
'        '' VulindlelaSqlServerList
'        ''
'        <TypeConverter(GetType(VulindlelaSqlServerList)), _
'        Category("SQL Servers"), _
'        Description("Select your prefered favor of pasta from the list.")> _
'        Public Property VulindlelaSqlServerAddress() As String
'            Get
'                Return _VulindlelaSQLServerAddress
'            End Get
'            Set(ByVal Value As String)
'                _VulindlelaSQLServerAddress = Value
'            End Set
'        End Property

'        <Category("Default Programs"), _
'        Editor(GetType(FolderNameEditor), GetType(UITypeEditor))> _
'        Public Property ConfigFolder() As String
'            Get
'                Return _ConfigFolder
'            End Get
'            Set(ByVal Value As String)
'                _ConfigFolder = Value
'            End Set
'        End Property

'        <DescriptionAttribute("Webservice Endpoints for LOG_DM_Department_BasicWs__c"), _
'        ReadOnlyAttribute(True), _
'        CategoryAttribute("Web Service Endpoints"), DefaultValueAttribute(True)> _
'        Public Property LOG_DM_Department_BasicWs__c() As String
'            Get
'                Return _LOG_DM_Department_BasicWs__c
'            End Get
'            Set(ByVal Value As String)
'                _LOG_DM_Department_BasicWs__c = Value
'            End Set
'        End Property

'        <DescriptionAttribute("Webservice Endpoints for LOG_DN_Personnel_BasicWs__c"), _
'        ReadOnlyAttribute(True), _
'        CategoryAttribute("Web Service Endpoints"), DefaultValueAttribute(True)> _
'        Public Property Log_Dm_Personnel_BasicWs__c() As String
'            Get
'                Return _LOG_DM_Personnel_BasicWs__c
'            End Get
'            Set(ByVal Value As String)
'                _LOG_DM_Personnel_BasicWs__c = Value
'            End Set
'        End Property

'        <DescriptionAttribute("Webservice Endpoints for log_In_Request_Tracking_BasicWs__c"), _
'        ReadOnlyAttribute(True), _
'        CategoryAttribute("Web Service Endpoints"), DefaultValueAttribute(True)> _
'        Public Property LOG_IN_Request_Tracking_BasicWs__c() As String
'            Get
'                Return _LOG_IN_Request_Tracking_BasicWs__c
'            End Get
'            Set(ByVal Value As String)
'                _LOG_IN_Request_Tracking_BasicWs__c = Value
'            End Set
'        End Property

'        <DescriptionAttribute("Webservice Endpoints for log_Dm_Customer_Information_BasicWs__c"), _
'        ReadOnlyAttribute(True), _
'        CategoryAttribute("Web Service Endpoints"), DefaultValueAttribute(True)> _
'        Public Property LOG_DM_Customer_Information_BasicWs__c() As String
'            Get
'                Return _LOG_DM_Customer_Information_BasicWs__c
'            End Get
'            Set(ByVal Value As String)
'                _LOG_DM_Customer_Information_BasicWs__c = Value
'            End Set
'        End Property

'        <DescriptionAttribute("ARSystem Connecion String to 10.123.216.106\SQL2012"), _
'        CategoryAttribute("Connection String"), _
'        ReadOnlyAttribute(False), _
'        DefaultValueAttribute("Data Source=10.123.216.106\SQL2012;Initial Catalog=ARSystem;Integrated Security=True")> _
'        Public Property RemedySqlConnection() As String
'            Get
'                Return _RemedySQLConnection
'            End Get
'            Set(ByVal Value As String)
'                _RemedySQLConnection = Value
'            End Set
'        End Property

'        <DescriptionAttribute("SQL Server Connection string to ARSystem .\SQL2005"), _
'        CategoryAttribute("Connection String")> _
'        Public Property ARSystemConnectionString() As String
'            Get
'                Return _ARSystemConnectionString
'            End Get
'            Set(ByVal Value As String)
'                _ARSystemConnectionString = Value
'            End Set
'        End Property

'        <DescriptionAttribute("Connection string to ADS in QA Environment (10.123.45.210)"), _
'        CategoryAttribute("Connection String")> _
'        Public Property ADSQAConnectionString() As String
'            Get
'                Return _ADSQAConnectionString
'            End Get
'            Set(ByVal Value As String)
'                _ADSQAConnectionString = Value
'            End Set
'        End Property

'        <DescriptionAttribute("Connection string to VIP_EXPANDED in Prodution Environment (10.123.45.180)"), _
'        CategoryAttribute("Connection String"), _
'        DefaultValueAttribute("Data Source=10.123.45.180;Initial Catalog=VIP_EXPANDED;Persist Security Info=True;User ID=sa;Password=M33Q1Serv!ce09")> _
'        Public Property VIP_ExpandedConnectionString() As String
'            Get
'                Return _VIP_ExpandedConnectionString
'            End Get
'            Set(ByVal Value As String)
'                _VIP_ExpandedConnectionString = Value
'            End Set
'        End Property

'        <DescriptionAttribute("Connection string to ADS Prodution Environment (10.123.45.180)"), _
'        CategoryAttribute("Connection String"), _
'        DefaultValueAttribute("Data Source=10.123.45.180;Initial Catalog=Ads;Persist Security Info=True;User ID=sa;Password=M33Q1Serv!ce09")> _
'        Public Property ADSPRDConnectionString() As String
'            Get
'                Return _ADSPRDConnectionString
'            End Get
'            Set(ByVal Value As String)
'                _ADSPRDConnectionString = Value
'            End Set
'        End Property

'        <DescriptionAttribute("Connection string to ADS in the Prodution Environment (10.123.45.180)"), _
'        CategoryAttribute("Connection String"), _
'        ReadOnlyAttribute(False), _
'        DefaultValueAttribute("Data Source=10.123.45.180;Initial Catalog=Ads;Persist Security Info=True;User ID=sa;Password=M33Q1Serv!ce09")> _
'        Public Property ADSConnectionString() As String
'            Get
'                Return _ADSConnectionString
'            End Get
'            Set(ByVal Value As String)
'                _ADSConnectionString = Value
'            End Set
'        End Property


'        Public Overloads Function GetarSystemConnectionString(ByVal context As ITypeDescriptorContext) As StandardValuesCollection
'            Return New StandardValuesCollection(New String() { _
'            "Data Source=10.123.216.106\SQL2012;Initial Catalog=ARSystem;Integrated Security=True", _
'            "Data Source=10.123.45.210;Initial Catalog=ADS;Persist Security Info=True;User ID=sa;Password=S@P@SSW0RD", _
'            "Data Source=10.123.45.180;Initial Catalog=ADS;User ID=sa;Password=M33Q1Serv!ce09"})
'        End Function

'        'Returns whether the collection of standard values returned from GetStandardValues is 
'        'an exclusive list. Returning False would change the drop down list to an editable combo box
'        Public Overloads Function GetStandardValuesExclusive _
'            (ByVal context As System.ComponentModel.ITypeDescriptorContext) As Boolean

'            Return True
'        End Function

'        'Returns whether this object supports a standard set of values that can be picked from a list.
'        Public Overloads Function GetStandardValuesSupported _
'            (ByVal context As System.ComponentModel.ITypeDescriptorContext) As Boolean
'            Return True
'        End Function

'        <DescriptionAttribute("Select the binary file of the default Web Browser"), _
'        CategoryAttribute("Vulindlela Settings"), _
'        Editor(GetType(FileNameEditor), GetType(UITypeEditor))> _
'        Public Property DefaultWebBrowserEXE() As String
'            Get
'                Return _DefaultWebBrowserEXE
'            End Get
'            Set(ByVal Value As String)
'                _DefaultWebBrowserEXE = Value
'            End Set
'        End Property

'    End Class

'    Public Class FileNameConverter
'        Inherits StringConverter
'    End Class

'    <TypeConverter(GetType(StreetAddressConverter))> _
'    Public Class StreetAddress
'        Public Sub New()
'        End Sub
'        Public Sub New(ByVal txt As String)
'            Dim fields() As String = txt.Split(","c)
'            m_Street = fields(0)
'            m_City = fields(1)
'            m_State = fields(2)
'        End Sub
'        Public Sub New(ByVal new_street As String, ByVal new_city As String, ByVal new_state As String)
'            m_Street = new_street
'            m_City = new_city
'            m_State = new_state
'        End Sub

'        Public Overrides Function ToString() As String
'            Return m_Street & "," & m_City & "," & State
'        End Function

'        Private m_Street As String
'        Public Property Street() As String
'            Get
'                Return m_Street
'            End Get
'            Set(ByVal Value As String)
'                m_Street = Value
'            End Set
'        End Property

'        Private m_City As String
'        Public Property City() As String
'            Get
'                Return m_City
'            End Get
'            Set(ByVal Value As String)
'                m_City = Value
'            End Set
'        End Property

'        Private m_State As String
'        Public Property State() As String
'            Get
'                Return m_State
'            End Get
'            Set(ByVal Value As String)
'                m_State = Value
'            End Set
'        End Property
'    End Class

'    Public Class StreetAddress2
'        Public Sub New()
'        End Sub
'        Public Sub New(ByVal new_street As String, ByVal new_city As String, ByVal new_state As String)
'            m_Street = new_street
'            m_City = new_city
'            m_State = new_state
'        End Sub

'        Public Overrides Function ToString() As String
'            Return m_Street & "," & m_City & "," & State
'        End Function

'        Private m_Street As String
'        Public Property Street() As String
'            Get
'                Return m_Street
'            End Get
'            Set(ByVal Value As String)
'                m_Street = Value
'            End Set
'        End Property

'        Private m_City As String
'        Public Property City() As String
'            Get
'                Return m_City
'            End Get
'            Set(ByVal Value As String)
'                m_City = Value
'            End Set
'        End Property

'        Private m_State As String
'        Public Property State() As String
'            Get
'                Return m_State
'            End Get
'            Set(ByVal Value As String)
'                m_State = Value
'            End Set
'        End Property
'    End Class

'    Public Class AddressCollection
'        Inherits CollectionBase

'        Default Public Property Item(ByVal index As Integer) As StreetAddress
'            Get
'                Return CType(List(index), StreetAddress)
'            End Get
'            Set(ByVal Value As StreetAddress)
'                List(index) = Value
'            End Set
'        End Property

'        Public Sub Add(ByVal street_address As StreetAddress)
'            List.Add(street_address)
'        End Sub

'        Public Function IndexOf(ByVal value As StreetAddress) As Integer
'            Return List.IndexOf(value)
'        End Function

'        Public Sub Insert(ByVal index As Integer, ByVal value As StreetAddress)
'            List.Insert(index, value)
'        End Sub

'        Public Sub Remove(ByVal value As StreetAddress)
'            List.Remove(value)
'        End Sub

'        Public Function Contains(ByVal value As StreetAddress) As Boolean
'            Return List.Contains(value)
'        End Function

'        Protected Overrides Sub OnInsert(ByVal index As Integer, ByVal value As Object)
'            If Not value.GetType() Is GetType(StreetAddress) Then
'                Throw New ArgumentException("Value must be of type StreetAddress.", "value")
'            End If
'        End Sub

'        Protected Overrides Sub OnRemove(ByVal index As Integer, ByVal value As Object)
'            If Not value.GetType() Is GetType(StreetAddress) Then
'                Throw New ArgumentException("Value must be of type StreetAddress.", "value")
'            End If
'        End Sub

'        Protected Overrides Sub OnSet(ByVal index As Integer, ByVal oldValue As Object, ByVal newValue As Object)
'            If Not newValue.GetType() Is GetType(StreetAddress) Then
'                Throw New ArgumentException("New value must be of type StreetAddress.", "newValue")
'            End If
'        End Sub

'        Protected Overrides Sub OnValidate(ByVal value As Object)
'            If Not value.GetType() Is GetType(StreetAddress) Then
'                Throw New ArgumentException("Value must be of type StreetAddress.", "value")
'            End If
'        End Sub

'        Public Sub New()
'        End Sub
'        Public Sub New(ByVal txt As String)
'            Dim addresses() As String = txt.Split(New Char() {";"})

'            For Each address_text As String In addresses
'                Try
'                    Me.List.Add(New StreetAddress(address_text))
'                Catch
'                    Throw New InvalidCastException( _
'                        "Invalid StreetAddress serialization '" & _
'                        address_text & "'")
'                End Try
'            Next address_text
'        End Sub

'        Public Overrides Function ToString() As String
'            Dim txt As String = ""
'            For Each street_address As StreetAddress In MyBase.List
'                txt &= ";" & street_address.ToString()
'            Next street_address

'            If txt.Length > 0 Then txt = txt.Substring(1)

'            Return txt
'        End Function
'    End Class

'    Public Class AddressCollectionConverter
'        Inherits TypeConverter

'        Public Overloads Overrides Function CanConvertFrom(ByVal context As System.ComponentModel.ITypeDescriptorContext, ByVal sourceType As System.Type) As Boolean
'            If (sourceType.Equals(GetType(String))) Then
'                Return True
'            Else
'                Return MyBase.CanConvertFrom(context, sourceType)
'            End If
'        End Function

'        Public Overloads Overrides Function CanConvertTo(ByVal context As System.ComponentModel.ITypeDescriptorContext, ByVal destinationType As System.Type) As Boolean
'            If (destinationType.Equals(GetType(String))) Then
'                Return True
'            Else
'                Return MyBase.CanConvertTo(context, destinationType)
'            End If
'        End Function

'        Public Overloads Overrides Function ConvertFrom(ByVal context As System.ComponentModel.ITypeDescriptorContext, ByVal culture As System.Globalization.CultureInfo, ByVal value As Object) As Object
'            If (TypeOf value Is String) Then
'                Dim txt As String = CType(value, String)
'                Return New AddressCollection(txt)
'            Else
'                Return MyBase.ConvertFrom(context, culture, value)
'            End If
'        End Function

'        Public Overloads Overrides Function ConvertTo(ByVal context As System.ComponentModel.ITypeDescriptorContext, ByVal culture As System.Globalization.CultureInfo, ByVal value As Object, ByVal destinationType As System.Type) As Object
'            If (destinationType.Equals(GetType(String))) Then
'                Return value.ToString()
'            Else
'                Return MyBase.ConvertTo(context, culture, value, destinationType)
'            End If
'        End Function

'        Public Overloads Overrides Function GetPropertiesSupported(ByVal context As ITypeDescriptorContext) As Boolean
'            Return True
'        End Function

'        Public Overloads Overrides Function GetProperties(ByVal context As ITypeDescriptorContext, ByVal value As Object, ByVal Attribute() As Attribute) As PropertyDescriptorCollection
'            Return TypeDescriptor.GetProperties(value)
'        End Function
'    End Class

'    Public Class Person
'        Public Sub New()
'            m_Address = New StreetAddress
'        End Sub

'        Private m_Addresses As New AddressCollection
'        <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
'        Public Property Addresses() As AddressCollection
'            Get
'                Return m_Addresses
'            End Get
'            Set(ByVal Value As AddressCollection)
'                m_Addresses = Value
'            End Set
'        End Property

'        Private m_Point As Point
'        Public Property Location() As Point
'            Get
'                Return m_Point
'            End Get
'            Set(ByVal Value As Point)
'                m_Point = Value
'            End Set
'        End Property

'        Private m_FirstName As String
'        Public Property FirstName() As String
'            Get
'                Return (m_FirstName)
'            End Get
'            Set(ByVal Value As String)
'                m_FirstName = Value
'            End Set
'        End Property

'        Private m_LastName As String
'        Public Property LastName() As String
'            Get
'                Return (m_LastName)
'            End Get
'            Set(ByVal Value As String)
'                m_LastName = Value
'            End Set
'        End Property

'        Private m_Address As StreetAddress
'        Public Property Address() As StreetAddress
'            Get
'                Return (m_Address)
'            End Get
'            Set(ByVal Value As StreetAddress)
'                m_Address = Value
'            End Set
'        End Property

'    End Class

'    Public Class Person2
'        Public Sub New()
'            m_Address = New StreetAddress2
'        End Sub

'        Private m_Point As Point
'        Public Property Location() As Point
'            Get
'                Return m_Point
'            End Get
'            Set(ByVal Value As Point)
'                m_Point = Value
'            End Set
'        End Property

'        Private m_FirstName As String
'        Public Property FirstName() As String
'            Get
'                Return (m_FirstName)
'            End Get
'            Set(ByVal Value As String)
'                m_FirstName = Value
'            End Set
'        End Property

'        Private m_LastName As String
'        Public Property LastName() As String
'            Get
'                Return (m_LastName)
'            End Get
'            Set(ByVal Value As String)
'                m_LastName = Value
'            End Set
'        End Property

'        Private m_Address As StreetAddress2

'        Public Property Address() As StreetAddress2
'            Get
'                Return (m_Address)
'            End Get
'            Set(ByVal Value As StreetAddress2)
'                m_Address = Value
'            End Set
'        End Property
'    End Class

'    Public Class StreetAddressConverter
'        Inherits TypeConverter

'        Public Overloads Overrides Function CanConvertFrom(ByVal context As System.ComponentModel.ITypeDescriptorContext, ByVal sourceType As System.Type) As Boolean
'            If (sourceType.Equals(GetType(String))) Then
'                Return True
'            Else
'                Return MyBase.CanConvertFrom(context, sourceType)
'            End If
'        End Function

'        Public Overloads Overrides Function CanConvertTo(ByVal context As System.ComponentModel.ITypeDescriptorContext, ByVal destinationType As System.Type) As Boolean
'            If (destinationType.Equals(GetType(String))) Then
'                Return True
'            Else
'                Return MyBase.CanConvertTo(context, destinationType)
'            End If
'        End Function

'        Public Overloads Overrides Function ConvertFrom(ByVal context As System.ComponentModel.ITypeDescriptorContext, ByVal culture As System.Globalization.CultureInfo, ByVal value As Object) As Object
'            If (TypeOf value Is String) Then
'                Dim txt As String = CType(value, String)
'                Try
'                    Return New StreetAddress(txt)
'                Catch
'                    Throw New InvalidCastException( _
'                        "Invalid StreetAddress serialization '" & _
'                        value & "'")
'                End Try
'            Else
'                Return MyBase.ConvertFrom(context, culture, value)
'            End If
'        End Function

'        Public Overloads Overrides Function ConvertTo(ByVal context As System.ComponentModel.ITypeDescriptorContext, ByVal culture As System.Globalization.CultureInfo, ByVal value As Object, ByVal destinationType As System.Type) As Object
'            If (destinationType.Equals(GetType(String))) Then
'                Return value.ToString()
'            Else
'                Return MyBase.ConvertTo(context, culture, value, destinationType)
'            End If
'        End Function

'        Public Overloads Overrides Function GetPropertiesSupported(ByVal context As ITypeDescriptorContext) As Boolean
'            Return True
'        End Function

'        Public Overloads Overrides Function GetProperties(ByVal context As ITypeDescriptorContext, ByVal value As Object, ByVal Attribute() As Attribute) As PropertyDescriptorCollection
'            Return TypeDescriptor.GetProperties(value)
'        End Function

'    End Class

'    Public Class WebservicesList

'        Inherits System.ComponentModel.StringConverter
'        Private WebServiceNames As String() = New String() {"10.123.216.106\SQL2012", "10.123.216.102\SQL2005"}

'        'Returns a collection of standard values for the data type this type converter is designed for.
'        Public Overloads Overrides Function GetStandardValues _
'            (ByVal context As System.ComponentModel.ITypeDescriptorContext) _
'            As System.ComponentModel.TypeConverter.StandardValuesCollection

'            Return New StandardValuesCollection(WebServiceNames)
'        End Function

'        'Returns whether the collection of standard values returned from GetStandardValues is 
'        'an exclusive list. Returning False would change the drop down list to an editable combo box
'        Public Overloads Overrides Function GetStandardValuesExclusive _
'            (ByVal context As System.ComponentModel.ITypeDescriptorContext) As Boolean

'            Return True
'        End Function

'        'Returns whether this object supports a standard set of values that can be picked from a list.
'        Public Overloads Overrides Function GetStandardValuesSupported _
'            (ByVal context As System.ComponentModel.ITypeDescriptorContext) As Boolean

'            Return True
'        End Function

'    End Class

'    Public Class BmcSqlServerList

'        Inherits System.ComponentModel.StringConverter

'        Private BmcSqlServerNames As String() = New String() { _
'           "10.123.216.106\SQL2012", _
'            "10.123.216.106\SQL2005", _
'            "ProdLGRemV1\SQL2005", _
'            "ProdLGRemV1\SQL2012"}

'        'Returns a collection of standard values for the data type this type converter is designed for.
'        Public Overloads Overrides Function GetStandardValues _
'            (ByVal context As System.ComponentModel.ITypeDescriptorContext) _
'            As System.ComponentModel.TypeConverter.StandardValuesCollection

'            Return New StandardValuesCollection(BmcSqlServerNames)
'        End Function

'        'Returns whether the collection of standard values returned from GetStandardValues is 
'        'an exclusive list. Returning False would change the drop down list to an editable combo box
'        Public Overloads Overrides Function GetStandardValuesExclusive _
'            (ByVal context As System.ComponentModel.ITypeDescriptorContext) As Boolean

'            Return True
'        End Function

'        'Returns whether this object supports a standard set of values that can be picked from a list.
'        Public Overloads Overrides Function GetStandardValuesSupported _
'            (ByVal context As System.ComponentModel.ITypeDescriptorContext) As Boolean

'            Return True
'        End Function

'    End Class

'    Public Class VulindlelaSqlServerList

'        Inherits System.ComponentModel.StringConverter
'        Private VulindlelaSqlServerNames As String() = New String() {"10.123.45.180", "10.123.45.210"}

'        'Returns a collection of standard values for the data type this type converter is designed for.
'        Public Overloads Overrides Function GetStandardValues _
'            (ByVal context As System.ComponentModel.ITypeDescriptorContext) _
'            As System.ComponentModel.TypeConverter.StandardValuesCollection

'            Return New StandardValuesCollection(VulindlelaSqlServerNames)
'        End Function

'        'Returns whether the collection of standard values returned from GetStandardValues is 
'        'an exclusive list. Returning False would change the drop down list to an editable combo box
'        Public Overloads Overrides Function GetStandardValuesExclusive _
'            (ByVal context As System.ComponentModel.ITypeDescriptorContext) As Boolean
'            Return True
'        End Function

'        'Returns whether this object supports a standard set of values that can be picked from a list.
'        Public Overloads Overrides Function GetStandardValuesSupported _
'            (ByVal context As System.ComponentModel.ITypeDescriptorContext) As Boolean
'            Return True
'        End Function

'    End Class

'    <Serializable(), _
'    XmlRootAttribute("CustomProperty")> _
'    Public Class CustomProperty

'#Region "Protected variables"

'        ' Common properties
'        Protected sName As String = ""
'        Protected WithEvents oValue As Object = Nothing
'        Protected bIsReadOnly As Boolean = False
'        Protected bVisible As Boolean = True
'        Protected sDescription As String = ""
'        Protected sCategory As String = ""
'        Protected bIsPassword As Boolean = Nothing
'        Protected bIsPercentage As Boolean = Nothing
'        Protected bParenthesize As Boolean = Nothing

'        ' Filename editor properties
'        Protected sFilter As String = Nothing
'        Protected eDialogType As UIFilenameEditor.FileDialogType = UIFilenameEditor.FileDialogType.LoadFileDialog
'        Protected bUseFileNameEditor As Boolean = False

'        ' Custom choices properties
'        Protected oChoices As CustomChoices = Nothing

'        ' Browsable properties
'        Protected bIsBrowsable As Boolean = False
'        Protected sBrowsableText = ""
'        Protected eBrowsablePropertyLabel As BrowsableTypeConverter.LabelStyle = BrowsableTypeConverter.LabelStyle.lsEllipsis

'        ' Dynamic properties
'        Protected bRef As Boolean = False
'        Protected oRef As Object = Nothing
'        Protected sProp As String = ""

'        ' Databinding properties
'        Protected oDatasource As Object = Nothing
'        Protected sDisplayMember As String = Nothing
'        Protected sValueMember As String = Nothing
'        Protected oSelectedValue As Object = Nothing
'        Protected oSelectedItem As Object = Nothing
'        Protected bIsDropdownResizable As Boolean = Nothing

'        ' 3-dots button event handler        
'        Protected MethodDelegate As UICustomEventEditor.OnClick

'        ' Extended Attributes
'        <NonSerialized()> Protected oCustomAttributes As AttributeCollection = Nothing
'        Protected oTag As Object = Nothing
'        Protected oDefaultValue As Object = Nothing
'        Protected oDefaultType As Type = Nothing

'        ' Custom Editor and Custom Type Converter
'        <NonSerialized()> Protected oCustomEditor As UITypeEditor = Nothing
'        <NonSerialized()> Protected oCustomTypeConverter As TypeConverter = Nothing

'        ' Public Events
'        Public Event OnBubbleEvent(ByVal index As Integer, ByVal value As Object)

'#End Region

'#Region "Public methods"

'        Public Sub New()
'            sName = "New Property"
'            oValue = New String("")
'        End Sub

'        Public Sub New(ByVal strName As String, ByVal objValue As Object, Optional ByVal boolIsReadOnly As Boolean = True, Optional ByVal strCategory As String = "", Optional ByVal strDescription As String = "", Optional ByVal boolVisible As Boolean = True)
'            sName = strName
'            oValue = objValue
'            bIsReadOnly = boolIsReadOnly
'            sDescription = strDescription
'            sCategory = strCategory
'            bVisible = boolVisible
'            If oValue IsNot Nothing Then
'                oDefaultValue = oValue
'                If TypeOf oValue Is CustomPropertyCollection Then
'                    AddHandler CType(oValue, CustomPropertyCollection).OnChange, AddressOf OnCollectionChange
'                End If
'            End If
'        End Sub

'        Public Sub New(ByVal strName As String, ByRef objRef As Object, ByVal strProp As String, Optional ByVal boolIsReadOnly As Boolean = True, Optional ByVal strCategory As String = "", Optional ByVal strDescription As String = "", Optional ByVal boolVisible As Boolean = True)
'            sName = strName
'            bIsReadOnly = boolIsReadOnly
'            sDescription = strDescription
'            sCategory = strCategory
'            bVisible = boolVisible
'            bRef = True
'            oRef = objRef
'            sProp = strProp
'            If Value IsNot Nothing Then
'                oDefaultValue = Value
'            End If
'        End Sub

'        Public Sub New(ByVal strName As String, ByVal node As XmlNode, Optional ByVal strCategory As String = "", Optional ByVal strDescription As String = "")
'            sName = strName
'            sCategory = strCategory
'            sDescription = strDescription
'            oValue = LoadXmlNode(node, Nothing)
'        End Sub

'        Public Function ToXml() As String
'            Dim attr As String = RTrim(" " & Me.BrowsableText)
'            Dim result As String = "<" & Me.Name & attr & ">"
'            If TypeOf Me.Value Is CustomPropertyCollection Then
'                Dim cpc As CustomPropertyCollection = CType(Me.Value, CustomPropertyCollection)
'                For Each c As CustomProperty In cpc
'                    result += c.ToXml
'                Next
'            Else
'                If Me.Value IsNot Nothing Then result += Me.Value.ToString
'            End If
'            result += "</" & Me.Name & ">"
'            Return result
'        End Function

'        Protected Shared Sub CreateBrowsableProperty(ByRef p As CustomProperty, ByVal node As XmlNode, ByVal nsMgr As XmlNamespaceManager)
'            Dim text As String = ""
'            p.Value = LoadXmlNode(node, nsMgr)
'            For Each attr As XmlAttribute In node.Attributes
'                If text.Length > 0 Then text += " "
'                text += String.Format("{0}=""{1}""", attr.Name, attr.Value.ToString)
'            Next
'            p.IsBrowsable = True
'            p.BrowsableText = text

'        End Sub

'        Public Shared Function LoadXmlNode(ByVal node As XmlNode, ByVal nsMgr As XmlNamespaceManager) As CustomPropertyCollection
'            Dim nodes As XmlNodeList = node.ChildNodes
'            Dim result As New CustomPropertyCollection()

'            For Each child As XmlNode In nodes
'                Dim p As New CustomProperty(child.Name, Nothing, False, "")

'                If child.ChildNodes.Count > 1 Then
'                    ' Node has childs and must be browsable
'                    CreateBrowsableProperty(p, child, nsMgr)

'                ElseIf child.ChildNodes.Count = 1 Then

'                    ' Node has 1 child node, checking to remove #text
'                    If child.FirstChild IsNot Nothing Then
'                        If child.FirstChild.Name = "#text" Then
'                            p.Value = child.FirstChild.Value
'                        Else
'                            CreateBrowsableProperty(p, child, nsMgr)
'                        End If
'                    Else
'                        p.Value = ""
'                    End If

'                Else

'                    ' Node is a terminal node
'                    If child.Value IsNot Nothing Then
'                        p.Value = child.Value.ToString
'                    Else
'                        p.Value = ""
'                    End If
'                End If
'                p.DefaultValue = p.Value
'                p.Tag = child.OuterXml
'                result.Add(p)
'            Next
'            Return result
'        End Function

'        Public Sub RebuildAttributes()
'            If bUseFileNameEditor Then
'                BuildAttributes_FilenameEditor()
'            ElseIf oChoices IsNot Nothing AndAlso oChoices.Count > 0 Then
'                BuildAttributes_CustomChoices()
'            ElseIf oDatasource IsNot Nothing Then
'                BuildAttributes_ListboxEditor()
'            ElseIf bIsBrowsable Then
'                BuildAttributes_BrowsableProperty()
'            ElseIf MethodDelegate IsNot Nothing Then
'                BuildAttributes_CustomEventProperty()
'            End If
'        End Sub

'#End Region

'#Region "Private methods"

'        Private Sub BuildAttributes_FilenameEditor()
'            Dim attrs As ArrayList = New ArrayList()
'            Dim FilterAttribute As New UIFilenameEditor.FileDialogFilterAttribute(sFilter)
'            Dim SaveDialogAttribute As New UIFilenameEditor.SaveFileAttribute
'            Dim attrArray As Attribute()
'            attrs.Add(FilterAttribute)
'            If eDialogType = UIFilenameEditor.FileDialogType.SaveFileDialog Then attrs.Add(SaveDialogAttribute)
'            attrArray = attrs.ToArray(GetType(Attribute))
'            oCustomAttributes = New AttributeCollection(attrArray)
'        End Sub

'        Private Sub BuildAttributes_CustomChoices()
'            If oChoices IsNot Nothing Then
'                Dim list As New CustomChoices.CustomChoicesAttributeList(oChoices.Items)
'                Dim attrs As ArrayList = New ArrayList()
'                Dim attrArray As Attribute()
'                attrs.Add(list)
'                attrArray = attrs.ToArray(GetType(Attribute))
'                oCustomAttributes = New AttributeCollection(attrArray)
'            End If
'        End Sub

'        Private Sub BuildAttributes_ListboxEditor()
'            If oDatasource IsNot Nothing Then
'                Dim ds As New UIListboxEditor.UIListboxDatasource(oDatasource)
'                Dim vm As New UIListboxEditor.UIListboxValueMember(sValueMember)
'                Dim dm As New UIListboxEditor.UIListboxDisplayMember(sDisplayMember)
'                Dim ddr As UIListboxEditor.UIListboxIsDropDownResizable = Nothing
'                Dim attrs As ArrayList = New ArrayList()
'                attrs.Add(ds)
'                attrs.Add(vm)
'                attrs.Add(dm)
'                If bIsDropdownResizable Then
'                    ddr = New UIListboxEditor.UIListboxIsDropDownResizable
'                    attrs.Add(ddr)
'                End If
'                Dim attrArray As Attribute()
'                attrArray = attrs.ToArray(GetType(Attribute))
'                oCustomAttributes = New AttributeCollection(attrArray)
'            End If
'        End Sub

'        Private Sub BuildAttributes_BrowsableProperty()
'            Dim style As New BrowsableTypeConverter.BrowsableLabelStyleAttribute(eBrowsablePropertyLabel)
'            Dim text As New BrowsableTypeConverter.BrowsableLabelTextAttribute(sBrowsableText)
'            oCustomAttributes = New AttributeCollection(New Attribute() {style, text})
'        End Sub

'        Private Sub BuildAttributes_CustomEventProperty()
'            Dim attr As New UICustomEventEditor.DelegateAttribute(MethodDelegate)
'            oCustomAttributes = New AttributeCollection(New Attribute() {attr})
'        End Sub

'        Private Property DataColumn() As Object
'            Get
'                Dim oRow As DataRow = CType(oRef, System.Data.DataRow)
'                If oRow.RowState <> DataRowState.Deleted Then
'                    If oDatasource Is Nothing Then
'                        Return oRow(sProp)
'                    Else
'                        Dim oLookupTable As DataTable = TryCast(oDatasource, DataTable)
'                        If oLookupTable IsNot Nothing Then
'                            Return oLookupTable.Select(sValueMember & "=" & oRow(sProp))(0).Item(sDisplayMember)
'                        Else
'                            Err.Raise(vbObjectError + 513, , "Bind of DataRow with a DataSource that is not a DataTable is not possible")
'                            Return Nothing
'                        End If
'                    End If
'                Else
'                    Return Nothing
'                End If
'            End Get
'            Set(ByVal value As Object)
'                Dim oRow As DataRow = CType(oRef, System.Data.DataRow)
'                If oRow.RowState <> DataRowState.Deleted Then
'                    If oDatasource Is Nothing Then
'                        oRow(sProp) = value
'                    Else
'                        Dim oLookupTable As DataTable = TryCast(oDatasource, DataTable)
'                        If oLookupTable IsNot Nothing Then
'                            If oLookupTable.Columns(sDisplayMember).DataType.Equals(System.Type.GetType("System.String")) Then
'                                oRow(sProp) = oLookupTable.Select(oLookupTable.Columns(sDisplayMember).ColumnName & " = '" & value & "'")(0).Item(sValueMember)
'                            Else
'                                oRow(sProp) = oLookupTable.Select(oLookupTable.Columns(sDisplayMember).ColumnName & " = " & value)(0).Item(sValueMember)
'                            End If
'                        Else
'                            Err.Raise(vbObjectError + 514, , "Bind of DataRow with a DataSource that is not a DataTable is impossible")
'                        End If
'                    End If
'                End If
'            End Set
'        End Property

'        Private Sub OnCollectionChange(ByVal index As Integer, ByVal value As Object)
'            RaiseEvent OnBubbleEvent(index, value)
'        End Sub

'#End Region

'#Region "Public properties"

'        <Category("Appearance"), _
'         DisplayName("Name"), _
'         DescriptionAttribute("Display Name of the CustomProperty."), _
'         ParenthesizePropertyName(True), _
'         XmlElementAttribute("Name")> _
'        Public Property Name() As String
'            Get
'                Return sName
'            End Get
'            Set(ByVal value As String)
'                sName = value
'            End Set
'        End Property

'        <Category("Appearance"), _
'         DisplayName("ReadOnly"), _
'         DescriptionAttribute("Set read only attribute of the CustomProperty."), _
'         XmlElementAttribute("ReadOnly")> _
'        Public Property IsReadOnly() As Boolean
'            Get
'                Return bIsReadOnly
'            End Get
'            Set(ByVal value As Boolean)
'                bIsReadOnly = value
'            End Set
'        End Property

'        <Category("Appearance"), _
'         DescriptionAttribute("Set visibility attribute of the CustomProperty.")> _
'        Public Property Visible() As Boolean
'            Get
'                Return bVisible
'            End Get
'            Set(ByVal value As Boolean)
'                bVisible = value
'            End Set
'        End Property

'        <Category("Appearance"), _
'         DescriptionAttribute("Represent the Value of the CustomProperty.")> _
'        Public Property Value() As Object
'            Get
'                If bRef Then
'                    If TryCast(oRef, DataRow) IsNot Nothing Then
'                        Return Me.DataColumn
'                    Else
'                        Return CallByName(oRef, sProp, CallType.Get)
'                    End If
'                Else
'                    Return oValue
'                End If
'            End Get
'            Set(ByVal value As Object)
'                If bRef Then
'                    If TryCast(oRef, DataRow) IsNot Nothing Then
'                        Me.DataColumn = value
'                    Else
'                        CallByName(oRef, sProp, CallType.Set, value)
'                    End If
'                Else
'                    oValue = value
'                End If
'                If TypeOf oValue Is CustomPropertyCollection Then
'                    AddHandler CType(oValue, CustomPropertyCollection).OnChange, AddressOf OnCollectionChange
'                End If
'            End Set
'        End Property

'        <Category("Appearance"), _
'         DescriptionAttribute("Set description associated with the CustomProperty.")> _
'        Public Property Description() As String
'            Get
'                Return sDescription
'            End Get
'            Set(ByVal value As String)
'                sDescription = value
'            End Set
'        End Property

'        <Category("Appearance"), Browsable(False), _
'         DescriptionAttribute("Set category associated with the CustomProperty.")> _
'        Public Property Category() As String
'            Get
'                Return sCategory
'            End Get
'            Set(ByVal value As String)
'                sCategory = value
'            End Set
'        End Property

'        <XmlIgnore(), Browsable(False)> _
'        Public ReadOnly Property Type() As System.Type
'            Get
'                If oValue IsNot Nothing Then
'                    Return oValue.GetType
'                Else
'                    If oDefaultType IsNot Nothing Then
'                        Return oDefaultType
'                    Else
'                        If oDefaultValue IsNot Nothing Then
'                            Return oDefaultValue.GetType
'                        Else
'                            Return Nothing
'                        End If
'                    End If
'                End If
'            End Get
'        End Property

'        <XmlIgnore(), Browsable(False)> _
'        Public Property Attributes() As AttributeCollection
'            Get
'                Return oCustomAttributes
'            End Get
'            Set(ByVal value As AttributeCollection)
'                oCustomAttributes = value
'            End Set
'        End Property

'        <Category("Behavior"), _
'         DescriptionAttribute("Indicates if the property is browsable or not."), _
'         XmlElementAttribute(IsNullable:=False), Browsable(False)> _
'        Public Property IsBrowsable() As Boolean
'            Get
'                Return bIsBrowsable
'            End Get
'            Set(ByVal value As Boolean)
'                bIsBrowsable = value
'                If value = True Then
'                    BuildAttributes_BrowsableProperty()
'                End If
'            End Set
'        End Property

'        <Category("Behavior"), _
'         DescriptionAttribute("Specify the label shown when the property is browsable"), _
'         XmlElementAttribute(IsNullable:=False), Browsable(False)> _
'        Public Property BrowsableText() As String
'            Get
'                Return sBrowsableText
'            End Get
'            Set(ByVal value As String)
'                sBrowsableText = value
'                eBrowsablePropertyLabel = BrowsableTypeConverter.LabelStyle.lsText
'                BuildAttributes_BrowsableProperty()
'            End Set
'        End Property

'        <Category("Appearance"), _
'         DisplayName("Parenthesize"), _
'         DescriptionAttribute("Indicates whether the name of the associated property is displayed with parentheses in the Properties window."), _
'         DefaultValue(False), _
'         XmlElementAttribute("Parenthesize"), Browsable(False)> _
'        Public Property Parenthesize() As Boolean
'            Get
'                Return bParenthesize
'            End Get
'            Set(ByVal value As Boolean)
'                bParenthesize = value
'            End Set
'        End Property

'        <Category("Behavior"), _
'         DescriptionAttribute("Indicates the style of the label when a property is browsable."), _
'         XmlElementAttribute(IsNullable:=False), Browsable(False)> _
'        Public Property BrowsableLabelStyle() As BrowsableTypeConverter.LabelStyle
'            Get
'                Return eBrowsablePropertyLabel
'            End Get
'            Set(ByVal value As BrowsableTypeConverter.LabelStyle)
'                Dim Update As Boolean = False
'                If value <> eBrowsablePropertyLabel Then Update = True
'                eBrowsablePropertyLabel = value
'                If Update Then
'                    Dim style As New BrowsableTypeConverter.BrowsableLabelStyleAttribute(value)
'                    oCustomAttributes = New AttributeCollection(New Attribute() {style})
'                End If
'            End Set
'        End Property

'        <Category("Behavior"), _
'         DescriptionAttribute("Indicates if the property is masked or not."), _
'         XmlElementAttribute(IsNullable:=False), Browsable(False)> _
'        Public Property IsPassword() As Boolean
'            Get
'                Return bIsPassword
'            End Get
'            Set(ByVal value As Boolean)
'                bIsPassword = value
'            End Set
'        End Property

'        <Category("Behavior"), _
'         DescriptionAttribute("Indicates if the property represents a value in percentage."), _
'         XmlElementAttribute(IsNullable:=False), Browsable(False)> _
'        Public Property IsPercentage() As Boolean
'            Get
'                Return bIsPercentage
'            End Get
'            Set(ByVal value As Boolean)
'                bIsPercentage = value
'            End Set
'        End Property

'        <Category("Behavior"), _
'         DescriptionAttribute("Indicates if the property uses a FileNameEditor converter."), _
'         XmlElementAttribute(IsNullable:=False), Browsable(False)> _
'        Public Property UseFileNameEditor() As Boolean
'            Get
'                Return bUseFileNameEditor
'            End Get
'            Set(ByVal value As Boolean)
'                bUseFileNameEditor = value
'            End Set
'        End Property

'        <Category("Behavior"), _
'         DescriptionAttribute("Apply a filter to FileNameEditor converter."), _
'         XmlElementAttribute(IsNullable:=False), Browsable(False)> _
'        Public Property FileNameFilter() As String
'            Get
'                Return sFilter
'            End Get
'            Set(ByVal value As String)
'                Dim UpdateAttributes As Boolean = False
'                If value <> sFilter Then UpdateAttributes = True
'                sFilter = value
'                If UpdateAttributes Then BuildAttributes_FilenameEditor()
'            End Set
'        End Property

'        <Category("Behavior"), _
'         DescriptionAttribute("DialogType of the FileNameEditor."), _
'         XmlElementAttribute(IsNullable:=False), Browsable(False)> _
'        Public Property FileNameDialogType() As UIFilenameEditor.FileDialogType
'            Get
'                Return eDialogType
'            End Get
'            Set(ByVal value As UIFilenameEditor.FileDialogType)
'                Dim UpdateAttributes As Boolean = False
'                If value <> eDialogType Then UpdateAttributes = True
'                eDialogType = value
'                If UpdateAttributes Then BuildAttributes_FilenameEditor()
'            End Set
'        End Property

'        <Category("Behavior"), _
'         DescriptionAttribute("Custom Choices list."), _
'         XmlElementAttribute(IsNullable:=False), Browsable(False)> _
'        Public Property Choices() As CustomChoices
'            Get
'                Return oChoices
'            End Get
'            Set(ByVal value As CustomChoices)
'                oChoices = value
'                BuildAttributes_CustomChoices()
'            End Set
'        End Property

'        <Category("Databinding"), _
'         XmlIgnore(), Browsable(False)> _
'        Public Property Datasource() As Object
'            Get
'                Return oDatasource
'            End Get
'            Set(ByVal value As Object)
'                oDatasource = value
'                BuildAttributes_ListboxEditor()
'            End Set
'        End Property

'        <Category("Databinding"), _
'         XmlElementAttribute(IsNullable:=False), Browsable(False)> _
'        Public Property ValueMember() As String
'            Get
'                Return sValueMember
'            End Get
'            Set(ByVal value As String)
'                sValueMember = value
'                BuildAttributes_ListboxEditor()
'            End Set
'        End Property

'        <Category("Databinding"), _
'         XmlElementAttribute(IsNullable:=False), Browsable(False)> _
'        Public Property DisplayMember() As String
'            Get
'                Return sDisplayMember
'            End Get
'            Set(ByVal value As String)
'                sDisplayMember = value
'                BuildAttributes_ListboxEditor()
'            End Set
'        End Property

'        <Category("Databinding"), _
'         XmlElementAttribute(IsNullable:=False), Browsable(False)> _
'        Public Property SelectedValue() As Object
'            Get
'                Return oSelectedValue
'            End Get
'            Set(ByVal value As Object)
'                oSelectedValue = value
'            End Set
'        End Property

'        <Category("Databinding"), _
'         XmlElementAttribute(IsNullable:=False), Browsable(False)> _
'        Public Property SelectedItem() As Object
'            Get
'                Return oSelectedItem
'            End Get
'            Set(ByVal value As Object)
'                oSelectedItem = value
'            End Set
'        End Property

'        <Category("Databinding"), _
'         XmlElementAttribute(IsNullable:=False), Browsable(False)> _
'        Public Property IsDropdownResizable() As Boolean
'            Get
'                Return bIsDropdownResizable
'            End Get
'            Set(ByVal value As Boolean)
'                bIsDropdownResizable = value
'                BuildAttributes_ListboxEditor()
'            End Set
'        End Property

'        <XmlIgnore(), Browsable(False)> _
'        Public Property CustomEditor() As UITypeEditor
'            Get
'                Return oCustomEditor
'            End Get
'            Set(ByVal value As UITypeEditor)
'                oCustomEditor = value
'            End Set
'        End Property

'        <XmlIgnore(), Browsable(False)> _
'        Public Property CustomTypeConverter() As TypeConverter
'            Get
'                Return oCustomTypeConverter
'            End Get
'            Set(ByVal value As TypeConverter)
'                oCustomTypeConverter = value
'            End Set
'        End Property

'        <XmlIgnore(), Browsable(False)> _
'        Public Property Tag() As Object
'            Get
'                Return oTag
'            End Get
'            Set(ByVal value As Object)
'                oTag = value
'            End Set
'        End Property

'        <XmlIgnore(), Browsable(False)> _
'        Public Property DefaultValue() As Object
'            Get
'                Return oDefaultValue
'            End Get
'            Set(ByVal value As Object)
'                oDefaultValue = value
'            End Set
'        End Property

'        <XmlIgnore(), Browsable(False)> _
'        Public Property DefaultType() As Type
'            Get
'                Return oDefaultType
'            End Get
'            Set(ByVal value As Type)
'                oDefaultType = value
'            End Set
'        End Property

'        <XmlIgnore(), Browsable(False)> _
'        Public Property OnClick() As UICustomEventEditor.OnClick
'            Get
'                Return MethodDelegate
'            End Get
'            Set(ByVal value As UICustomEventEditor.OnClick)
'                MethodDelegate = value
'                BuildAttributes_CustomEventProperty()
'            End Set
'        End Property

'        Public Property HasChildNodes() As Boolean
'            Get
'                Return TypeOf Value Is CustomPropertyCollection
'            End Get
'            Set(ByVal value As Boolean)
'                If value = True Then
'                    Me.Value = New CustomPropertyCollection
'                    AddHandler CType(oValue, CustomPropertyCollection).OnChange, AddressOf OnCollectionChange
'                End If
'            End Set
'        End Property

'#End Region

'#Region "CustomPropertyDescriptor"
'        Public Class CustomPropertyDescriptor
'            Inherits PropertyDescriptor
'            Protected oCustomProperty As CustomProperty
'            Public Sub New(ByVal myProperty As CustomProperty, ByVal attrs() As Attribute)
'                MyBase.New(myProperty.Name, attrs)
'                If myProperty Is Nothing Then
'                    oCustomProperty = Nothing
'                Else : oCustomProperty = myProperty
'                End If
'            End Sub
'            Public Overrides Function CanResetValue(ByVal component As Object) As Boolean
'                If oCustomProperty.DefaultValue IsNot Nothing OrElse oCustomProperty.DefaultType IsNot Nothing Then
'                    Return True
'                Else
'                    Return False
'                End If
'            End Function
'            Public Overrides ReadOnly Property ComponentType() As System.Type
'                Get
'                    Return Me.GetType
'                End Get
'            End Property
'            Public Overrides Function GetValue(ByVal component As Object) As Object
'                Return oCustomProperty.Value
'            End Function
'            Public Overrides ReadOnly Property IsReadOnly() As Boolean
'                Get
'                    Return oCustomProperty.IsReadOnly
'                End Get
'            End Property
'            Public Overrides ReadOnly Property PropertyType() As System.Type
'                Get
'                    Return oCustomProperty.Type
'                End Get
'            End Property
'            Public Overrides Sub ResetValue(ByVal component As Object)
'                oCustomProperty.Value = oCustomProperty.DefaultValue
'                Me.OnValueChanged(component, EventArgs.Empty)
'            End Sub
'            Public Overrides Sub SetValue(ByVal component As Object, ByVal value As Object)
'                oCustomProperty.Value = value
'                Me.OnValueChanged(component, EventArgs.Empty)
'            End Sub
'            Public Overrides Function ShouldSerializeValue(ByVal component As Object) As Boolean
'                Dim oValue As Object = oCustomProperty.Value
'                If oCustomProperty.DefaultValue IsNot Nothing AndAlso _
'                   oValue IsNot Nothing Then
'                    Return Not oValue.Equals(oCustomProperty.DefaultValue)
'                Else
'                    Return False
'                End If
'            End Function
'            Public Overrides ReadOnly Property Description() As String
'                Get
'                    Return oCustomProperty.Description
'                End Get
'            End Property
'            Public Overrides ReadOnly Property Category() As String
'                Get
'                    Return oCustomProperty.Category
'                End Get
'            End Property
'            Public Overrides ReadOnly Property DisplayName() As String
'                Get
'                    Return oCustomProperty.Name
'                End Get
'            End Property
'            Public Overrides ReadOnly Property IsBrowsable() As Boolean
'                Get
'                    Return oCustomProperty.IsBrowsable
'                End Get
'            End Property
'            Public ReadOnly Property CustomProperty()
'                Get
'                    Return oCustomProperty
'                End Get
'            End Property
'        End Class
'#End Region

'    End Class

'    Public Class UIFilenameEditor
'        Inherits System.Drawing.Design.UITypeEditor

'        Public Overloads Overrides Function GetEditStyle(ByVal context As  _
'                        ITypeDescriptorContext) As UITypeEditorEditStyle
'            If Not context Is Nothing AndAlso Not context.Instance Is Nothing Then
'                If Not context.PropertyDescriptor.IsReadOnly Then
'                    Return UITypeEditorEditStyle.Modal
'                End If
'            End If
'            Return UITypeEditorEditStyle.None
'        End Function

'        <RefreshProperties(RefreshProperties.All)> _
'        Public Overloads Overrides Function EditValue( _
'                    ByVal context As ITypeDescriptorContext, _
'                    ByVal provider As System.IServiceProvider, _
'                    ByVal value As [Object]) As [Object]
'            If context Is Nothing OrElse provider Is Nothing _
'                    OrElse context.Instance Is Nothing Then
'                Return MyBase.EditValue(provider, value)
'            End If

'            Dim fileDlg As FileDialog
'            If context.PropertyDescriptor.Attributes(GetType(SaveFileAttribute)) Is Nothing Then
'                fileDlg = New OpenFileDialog
'            Else
'                fileDlg = New SaveFileDialog
'            End If
'            fileDlg.Title = "Select " & context.PropertyDescriptor.DisplayName
'            fileDlg.FileName = value

'            Dim filterAtt As FileDialogFilterAttribute = _
'                context.PropertyDescriptor.Attributes(GetType(FileDialogFilterAttribute))
'            If Not filterAtt Is Nothing Then fileDlg.Filter = filterAtt.Filter
'            If fileDlg.ShowDialog() = DialogResult.OK Then
'                value = fileDlg.FileName
'            End If
'            fileDlg.Dispose()
'            Return value
'        End Function

'        <AttributeUsage(AttributeTargets.Property)> _
'        Public Class FileDialogFilterAttribute
'            Inherits Attribute
'            Private _filter As String

'            Public ReadOnly Property Filter() As String
'                Get
'                    Return Me._filter
'                End Get
'            End Property

'            Public Sub New(ByVal filter As String)
'                MyBase.New()
'                Me._filter = filter
'            End Sub
'        End Class

'        <AttributeUsage(AttributeTargets.Property)> _
'        Public Class SaveFileAttribute
'            Inherits Attribute
'        End Class

'        Public Enum FileDialogType
'            LoadFileDialog
'            SaveFileDialog
'        End Enum
'    End Class

'    <Serializable()> _
'Public Class CustomChoices
'        Inherits ArrayList

'        Public Sub New()

'        End Sub

'        Public Sub New(ByVal array As ArrayList, ByVal IsSorted As Boolean)
'            Me.AddRange(array)
'            If IsSorted Then Me.Sort()
'        End Sub

'        Public Sub New(ByVal array As ArrayList)
'            Me.AddRange(array)
'        End Sub

'        Public Sub New(ByVal array() As String, ByVal IsSorted As Boolean)
'            Me.AddRange(array)
'            If IsSorted Then Me.Sort()
'        End Sub

'        Public Sub New(ByVal array() As String)
'            Me.AddRange(array)
'        End Sub

'        Public Sub New(ByVal array() As Integer, ByVal IsSorted As Boolean)
'            Me.AddRange(array)
'            If IsSorted Then Me.Sort()
'        End Sub

'        Public Sub New(ByVal array() As Integer)
'            Me.AddRange(array)
'        End Sub

'        Public Sub New(ByVal array() As Double, ByVal IsSorted As Boolean)
'            Me.AddRange(array)
'            If IsSorted Then Me.Sort()
'        End Sub

'        Public Sub New(ByVal array() As Double)
'            Me.AddRange(array)
'        End Sub

'        Public Sub New(ByVal array() As Object, ByVal IsSorted As Boolean)
'            Me.AddRange(array)
'            If IsSorted Then Me.Sort()
'        End Sub

'        Public Sub New(ByVal array() As Object)
'            Me.AddRange(array)
'        End Sub

'        Public ReadOnly Property Items() As ArrayList
'            Get
'                Return Me
'            End Get
'            'Set(ByVal value As ArrayList)
'            '    MyBase.Clear()
'            '    MyBase.AddRange(value)
'            'End Set
'        End Property

'        Public Class CustomChoicesTypeConverter
'            Inherits TypeConverter
'            Private oChoices As CustomChoicesAttributeList = Nothing
'            Public Overrides Function GetStandardValuesSupported(ByVal context As System.ComponentModel.ITypeDescriptorContext) As Boolean
'                Dim Choices As CustomChoicesAttributeList = context.PropertyDescriptor.Attributes(GetType(CustomChoicesAttributeList))
'                If Not oChoices Is Nothing Then Return True
'                If Not Choices Is Nothing Then
'                    oChoices = Choices
'                    GetStandardValuesSupported = True
'                Else
'                    GetStandardValuesSupported = False
'                End If
'            End Function
'            Public Overrides Function GetStandardValuesExclusive(ByVal context As System.ComponentModel.ITypeDescriptorContext) As Boolean
'                Dim Choices As CustomChoicesAttributeList = context.PropertyDescriptor.Attributes(GetType(CustomChoicesAttributeList))
'                If Not oChoices Is Nothing Then Return True
'                If Not Choices Is Nothing Then
'                    oChoices = Choices
'                    GetStandardValuesExclusive = True
'                Else
'                    GetStandardValuesExclusive = False
'                End If
'            End Function
'            Public Overrides Function GetStandardValues(ByVal context As System.ComponentModel.ITypeDescriptorContext) As System.ComponentModel.TypeConverter.StandardValuesCollection
'                Dim Choices As CustomChoicesAttributeList = context.PropertyDescriptor.Attributes(GetType(CustomChoicesAttributeList))
'                If Not oChoices Is Nothing Then
'                    Return oChoices.Values
'                End If
'                Return MyBase.GetStandardValues(context)
'            End Function
'        End Class

'        Public Class CustomChoicesAttributeList
'            Inherits Attribute
'            Private oList As New ArrayList

'            Public ReadOnly Property Item() As ArrayList
'                Get
'                    Return Me.oList
'                End Get
'            End Property

'            Public ReadOnly Property Values() As TypeConverter.StandardValuesCollection
'                Get
'                    Return New TypeConverter.StandardValuesCollection(Me.oList)
'                End Get
'            End Property

'            Public Sub New(ByVal List() As String)
'                MyBase.New()
'                oList.AddRange(List)
'            End Sub

'            Public Sub New(ByVal List As ArrayList)
'                MyBase.New()
'                oList.AddRange(List)
'            End Sub

'            Public Sub New(ByVal List As ListBox.ObjectCollection)
'                MyBase.New()
'                oList.AddRange(List)
'            End Sub
'        End Class
'    End Class

'    Public Class BrowsableTypeConverter

'        Inherits ExpandableObjectConverter

'        Public Enum LabelStyle
'            lsNormal
'            lsTypeName
'            lsEllipsis
'            lsText
'        End Enum

'        Public Class BrowsableLabelStyleAttribute
'            Inherits Attribute
'            Private eLabelStyle As LabelStyle = LabelStyle.lsEllipsis
'            Public Sub New(ByVal LabelStyle As LabelStyle)
'                eLabelStyle = LabelStyle
'            End Sub
'            Public Property LabelStyle() As LabelStyle
'                Get
'                    Return eLabelStyle
'                End Get
'                Set(ByVal value As LabelStyle)
'                    eLabelStyle = value
'                End Set
'            End Property
'        End Class

'        Public Class BrowsableLabelTextAttribute
'            Inherits Attribute
'            Private strText As String = ""
'            Public Sub New(ByVal value As String)
'                strText = value
'            End Sub
'            Public Property Text() As String
'                Get
'                    Return strText
'                End Get
'                Set(ByVal value As String)
'                    strText = value
'                End Set
'            End Property
'        End Class

'        Public Overrides Function CanConvertTo(ByVal context As System.ComponentModel.ITypeDescriptorContext, ByVal destinationType As System.Type) As Boolean
'            Return True
'        End Function

'        Public Overrides Function ConvertTo(ByVal context As System.ComponentModel.ITypeDescriptorContext, ByVal culture As System.Globalization.CultureInfo, ByVal value As Object, ByVal destinationType As System.Type) As Object
'            Dim Style As BrowsableLabelStyleAttribute = context.PropertyDescriptor.Attributes(GetType(BrowsableLabelStyleAttribute))
'            If Not Style Is Nothing Then
'                Select Case Style.LabelStyle
'                    Case LabelStyle.lsNormal
'                        Return MyBase.ConvertTo(context, culture, value, destinationType)
'                    Case LabelStyle.lsTypeName
'                        Return "(" & value.GetType.Name & ")"
'                    Case LabelStyle.lsEllipsis
'                        Return "(...)"
'                    Case LabelStyle.lsText
'                        Dim text As BrowsableLabelTextAttribute = context.PropertyDescriptor.Attributes(GetType(BrowsableLabelTextAttribute))
'                        If text IsNot Nothing Then
'                            Return text.Text
'                        End If
'                End Select
'            End If
'            Return MyBase.ConvertTo(context, culture, value, destinationType)
'        End Function

'    End Class

'    Public Class UICustomEventEditor
'        Inherits System.Drawing.Design.UITypeEditor

'        Public Delegate Function OnClick(ByVal sender As Object, ByVal e As EventArgs) As Object
'        Protected m_MethodDelegate As UICustomEventEditor.OnClick
'        Protected m_sender As CustomProperty.CustomPropertyDescriptor

'        Public Overloads Overrides Function GetEditStyle(ByVal context As  _
'                        ITypeDescriptorContext) As UITypeEditorEditStyle
'            If Not context Is Nothing AndAlso Not context.Instance Is Nothing Then
'                If Not context.PropertyDescriptor.IsReadOnly Then
'                    Return UITypeEditorEditStyle.Modal
'                End If
'            End If
'            Return UITypeEditorEditStyle.None
'        End Function

'        <RefreshProperties(RefreshProperties.All)> _
'        Public Overloads Overrides Function EditValue( _
'                    ByVal context As ITypeDescriptorContext, _
'                    ByVal provider As System.IServiceProvider, _
'                    ByVal value As [Object]) As [Object]
'            If context Is Nothing OrElse provider Is Nothing _
'                    OrElse context.Instance Is Nothing Then
'                Return MyBase.EditValue(provider, value)
'            End If
'            If m_MethodDelegate Is Nothing Then
'                Dim attr As DelegateAttribute = context.PropertyDescriptor.Attributes(GetType(DelegateAttribute))
'                m_MethodDelegate = attr.GetMethod
'            End If
'            If m_sender Is Nothing Then
'                m_sender = TryCast(context.PropertyDescriptor, CustomProperty.CustomPropertyDescriptor)
'            End If
'            Return m_MethodDelegate.Invoke(m_sender, Nothing)
'        End Function

'        <AttributeUsage(AttributeTargets.Property)> _
'        Public Class DelegateAttribute
'            Inherits Attribute
'            Protected m_MethodDelegate As UICustomEventEditor.OnClick

'            Public ReadOnly Property GetMethod() As UICustomEventEditor.OnClick
'                Get
'                    Return Me.m_MethodDelegate
'                End Get
'            End Property

'            Public Sub New(ByVal MethodDelegate As UICustomEventEditor.OnClick)
'                MyBase.New()
'                Me.m_MethodDelegate = MethodDelegate
'            End Sub
'        End Class

'    End Class

'    Public Class UIListboxEditor
'        Inherits UITypeEditor

'        Private bIsDropDownResizable As Boolean = False
'        Private WithEvents oList As New ListBox
'        Private oSelectedValue As Object = Nothing
'        Private oEditorService As IWindowsFormsEditorService

'        Public Overloads Overrides Function GetEditStyle(ByVal context As  _
'        ITypeDescriptorContext) As UITypeEditorEditStyle
'            If Not context Is Nothing AndAlso Not context.Instance Is Nothing Then
'                Dim attribute As UIListboxIsDropDownResizable = context.PropertyDescriptor.Attributes(GetType(UIListboxIsDropDownResizable))
'                If attribute IsNot Nothing Then
'                    bIsDropDownResizable = True
'                End If
'                Return UITypeEditorEditStyle.DropDown
'            End If
'            Return UITypeEditorEditStyle.None
'        End Function

'        Public Overrides ReadOnly Property IsDropDownResizable() As Boolean
'            Get
'                Return bIsDropDownResizable
'            End Get
'        End Property

'        <RefreshProperties(RefreshProperties.All)> _
'        Public Overrides Function EditValue(ByVal context As System.ComponentModel.ITypeDescriptorContext, ByVal provider As System.IServiceProvider, ByVal value As Object) As Object
'            If context Is Nothing OrElse provider Is Nothing _
'            OrElse context.Instance Is Nothing Then
'                Return MyBase.EditValue(provider, value)
'            End If

'            oEditorService = provider.GetService(GetType(IWindowsFormsEditorService))
'            If oEditorService IsNot Nothing Then

'                ' Get the Back reference to the Custom Property
'                Dim oDescriptor As CustomProperty.CustomPropertyDescriptor = context.PropertyDescriptor
'                Dim cp As CustomProperty = oDescriptor.CustomProperty

'                ' Declare attributes
'                Dim datasource As UIListboxDatasource
'                Dim valuemember As UIListboxValueMember
'                Dim displaymember As UIListboxDisplayMember

'                ' Get attributes
'                With context.PropertyDescriptor
'                    datasource = .Attributes(GetType(UIListboxDatasource))
'                    valuemember = .Attributes(GetType(UIListboxValueMember))
'                    displaymember = .Attributes(GetType(UIListboxDisplayMember))
'                End With

'                With oList
'                    .BorderStyle = BorderStyle.None
'                    .IntegralHeight = True
'                    .SelectionMode = SelectionMode.One

'                    If datasource IsNot Nothing Then
'                        .DataSource = datasource.Value
'                    End If

'                    If displaymember IsNot Nothing Then
'                        .DisplayMember = displaymember.Value
'                    End If

'                    If valuemember IsNot Nothing Then
'                        .ValueMember = valuemember.Value
'                    End If

'                    If value IsNot Nothing Then
'                        If value.GetType.Name = "String" Then
'                            .Text = value
'                        Else
'                            .SelectedItem = value
'                        End If
'                    End If

'                End With

'                AddHandler oList.SelectedIndexChanged, AddressOf Me.SelectedItem

'                oEditorService.DropDownControl(oList)
'                If oList.SelectedIndices.Count = 1 Then
'                    cp.SelectedItem = oList.SelectedItem
'                    cp.SelectedValue = oSelectedValue
'                    value = oList.Text
'                End If
'                oEditorService.CloseDropDown()
'            Else
'                Return MyBase.EditValue(provider, value)
'            End If

'            Return value

'        End Function

'        Private Sub SelectedItem(ByVal sender As Object, ByVal e As EventArgs)
'            If oEditorService IsNot Nothing Then
'                If oList.SelectedValue IsNot Nothing Then oSelectedValue = oList.SelectedValue
'                oEditorService.CloseDropDown()
'            End If
'        End Sub

'        Public Class UIListboxDatasource
'            Inherits Attribute
'            Private oDataSource As Object
'            Public Sub New(ByRef Datasource As Object)
'                oDataSource = Datasource
'            End Sub
'            Public ReadOnly Property Value() As Object
'                Get
'                    Return oDataSource
'                End Get
'            End Property
'        End Class

'        Public Class UIListboxValueMember
'            Inherits Attribute
'            Private sValueMember As String
'            Public Sub New(ByVal ValueMember As String)
'                sValueMember = ValueMember
'            End Sub
'            Public Property Value() As String
'                Get
'                    Return sValueMember
'                End Get
'                Set(ByVal value As String)
'                    sValueMember = value
'                End Set
'            End Property
'        End Class

'        Public Class UIListboxDisplayMember
'            Inherits Attribute
'            Private sDisplayMember As String
'            Public Sub New(ByVal DisplayMember As String)
'                sDisplayMember = DisplayMember
'            End Sub
'            Public Property Value() As String
'                Get
'                    Return sDisplayMember
'                End Get
'                Set(ByVal value As String)
'                    sDisplayMember = value
'                End Set
'            End Property

'        End Class

'        Public Class UIListboxIsDropDownResizable
'            Inherits Attribute
'        End Class

'    End Class

'    <Serializable()> _
'    Public Class CustomPropertyCollection
'        Inherits System.Collections.CollectionBase
'        Implements ICustomTypeDescriptor

'        Public Event OnChange(ByVal index As Integer, ByVal value As Object)

'#Region "Collection related methods"
'        Public Overridable Function Add(ByVal value As CustomProperty) As Integer
'            If TypeOf value.Value Is CustomPropertyCollection Then
'                AddHandler value.OnBubbleEvent, AddressOf HandleBubbleEvent
'            End If
'            Return MyBase.List.Add(value)
'        End Function

'        Public Overridable Function Add(ByVal strName As String, ByVal objValue As Object, Optional ByVal boolIsReadOnly As Boolean = True, Optional ByVal strCategory As String = "", Optional ByVal strDescription As String = "", Optional ByVal boolVisible As Boolean = True) As Integer
'            Dim value As New CustomProperty(strName, objValue, boolIsReadOnly, strCategory, strDescription, boolVisible)
'            If TypeOf value.Value Is CustomPropertyCollection Then
'                AddHandler value.OnBubbleEvent, AddressOf HandleBubbleEvent
'            End If
'            Return MyBase.List.Add(value)
'        End Function

'        Public Overridable Function Add(ByVal strName As String, ByRef objRef As Object, ByVal strProp As String, Optional ByVal boolIsReadOnly As Boolean = True, Optional ByVal strCategory As String = "", Optional ByVal strDescription As String = "", Optional ByVal boolVisible As Boolean = True) As Integer
'            Dim value As New CustomProperty(strName, objRef, strProp, boolIsReadOnly, strCategory, strDescription, boolVisible)
'            If TypeOf value.Value Is CustomPropertyCollection Then
'                AddHandler value.OnBubbleEvent, AddressOf HandleBubbleEvent
'            End If
'            Return MyBase.List.Add(value)
'        End Function

'        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As CustomProperty
'            Get
'                Return DirectCast(MyBase.List.Item(index), CustomProperty)
'            End Get
'        End Property

'        Public Overridable Sub Remove(ByVal Name As String)
'            Dim CustomProp As CustomProperty
'            For Each CustomProp In MyBase.List
'                If CustomProp.Name = Name Then
'                    MyBase.List.Remove(CustomProp)
'                    Return
'                End If
'            Next
'        End Sub

'        Protected Overrides Sub OnClearComplete()
'            MyBase.OnClearComplete()
'            RaiseEvent OnChange(-1, Nothing)
'        End Sub

'        Protected Sub HandleBubbleEvent(ByVal index As Integer, ByVal value As Object)
'            RaiseEvent OnChange(index, value)
'        End Sub

'#End Region

'#Region "Implements ICustomTypeDescriptor"
'        Public Function GetAttributes() As System.ComponentModel.AttributeCollection Implements System.ComponentModel.ICustomTypeDescriptor.GetAttributes
'            Return TypeDescriptor.GetAttributes(Me, True)
'        End Function

'        Public Function GetClassName() As String Implements System.ComponentModel.ICustomTypeDescriptor.GetClassName
'            Return TypeDescriptor.GetClassName(Me, True)
'        End Function

'        Public Function GetComponentName() As String Implements System.ComponentModel.ICustomTypeDescriptor.GetComponentName
'            Return TypeDescriptor.GetComponentName(Me, True)
'        End Function

'        Public Function GetConverter() As System.ComponentModel.TypeConverter Implements System.ComponentModel.ICustomTypeDescriptor.GetConverter
'            Return TypeDescriptor.GetConverter(Me, True)
'        End Function

'        Public Function GetDefaultEvent() As System.ComponentModel.EventDescriptor Implements System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent
'            Return TypeDescriptor.GetDefaultEvent(Me, True)
'        End Function

'        Public Function GetDefaultProperty() As System.ComponentModel.PropertyDescriptor Implements System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty
'            Return TypeDescriptor.GetDefaultProperty(Me, True)
'        End Function

'        Public Function GetEditor(ByVal editorBaseType As System.Type) As Object Implements System.ComponentModel.ICustomTypeDescriptor.GetEditor
'            Return TypeDescriptor.GetEditor(Me, editorBaseType, True)
'        End Function

'        Public Function GetEvents() As System.ComponentModel.EventDescriptorCollection Implements System.ComponentModel.ICustomTypeDescriptor.GetEvents
'            Return TypeDescriptor.GetEvents(Me, True)
'        End Function

'        Public Function GetEvents(ByVal attributes() As System.Attribute) As System.ComponentModel.EventDescriptorCollection Implements System.ComponentModel.ICustomTypeDescriptor.GetEvents
'            Return TypeDescriptor.GetEvents(Me, attributes, True)
'        End Function

'        Public Function GetProperties() As System.ComponentModel.PropertyDescriptorCollection Implements System.ComponentModel.ICustomTypeDescriptor.GetProperties
'            Return TypeDescriptor.GetProperties(Me, True)
'        End Function

'        Public Function GetProperties(ByVal attributes() As System.Attribute) As System.ComponentModel.PropertyDescriptorCollection Implements System.ComponentModel.ICustomTypeDescriptor.GetProperties

'            Dim Properties As New PropertyDescriptorCollection(Nothing)
'            Dim CustomProp As CustomProperty
'            For Each CustomProp In MyBase.List
'                If CustomProp.Visible Then
'                    Dim attrs As ArrayList = New ArrayList()

'                    ' Expandable Object Converter
'                    If CustomProp.IsBrowsable Then
'                        attrs.Add(New TypeConverterAttribute(GetType(BrowsableTypeConverter)))
'                    End If

'                    ' The Filename Editor
'                    If CustomProp.UseFileNameEditor = True Then
'                        attrs.Add(New EditorAttribute(GetType(UIFilenameEditor), GetType(UITypeEditor)))
'                    End If

'                    ' Custom Choices Type Converter
'                    If CustomProp.Choices IsNot Nothing AndAlso CustomProp.Choices.Count > 0 Then
'                        attrs.Add(New TypeConverterAttribute(GetType(CustomChoices.CustomChoicesTypeConverter)))
'                    End If

'                    ' Password Property
'                    If CustomProp.IsPassword Then
'                        attrs.Add(New PasswordPropertyTextAttribute(True))
'                    End If

'                    ' Parenthesize Property
'                    If CustomProp.Parenthesize Then
'                        attrs.Add(New ParenthesizePropertyNameAttribute(True))
'                    End If

'                    ' Datasource
'                    If CustomProp.Datasource IsNot Nothing Then
'                        attrs.Add(New EditorAttribute(GetType(UIListboxEditor), GetType(UITypeEditor)))
'                    End If

'                    ' Custom Editor
'                    If CustomProp.CustomEditor IsNot Nothing Then
'                        attrs.Add(New EditorAttribute(CustomProp.CustomEditor.GetType, GetType(UITypeEditor)))
'                    End If

'                    ' Custom Type Converter
'                    If CustomProp.CustomTypeConverter IsNot Nothing Then
'                        attrs.Add(New TypeConverterAttribute(CustomProp.CustomTypeConverter.GetType))
'                    End If

'                    ' Is Percentage
'                    If CustomProp.IsPercentage Then
'                        attrs.Add(New TypeConverterAttribute(GetType(OpacityConverter)))
'                    End If

'                    ' 3-dots button event delegate
'                    If CustomProp.OnClick IsNot Nothing Then
'                        attrs.Add(New EditorAttribute(GetType(UICustomEventEditor), GetType(UITypeEditor)))
'                    End If

'                    ' Default value attribute
'                    If CustomProp.DefaultType IsNot Nothing Then
'                        ' Default type attribute
'                        If CustomProp.DefaultType IsNot Nothing Then
'                            attrs.Add(New DefaultValueAttribute(CustomProp.DefaultType, CustomProp.DefaultValue))
'                        End If
'                    Else
'                        If CustomProp.Value IsNot Nothing Then
'                            attrs.Add(New DefaultValueAttribute(CustomProp.Type, CustomProp.Value.ToString))
'                        End If
'                    End If

'                    ' Extra Attributes
'                    If CustomProp.Attributes IsNot Nothing Then
'                        attrs.AddRange(CustomProp.Attributes)
'                    End If

'                    ' Add my own attributes
'                    Dim attrArray As Attribute() = attrs.ToArray(GetType(Attribute))
'                    Properties.Add(New CustomProperty.CustomPropertyDescriptor(CustomProp, attrArray))
'                End If
'            Next
'            Return Properties
'        End Function


'        Public Function GetPropertyOwner(ByVal pd As System.ComponentModel.PropertyDescriptor) As Object Implements System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner
'            Return Me
'        End Function

'#End Region

'#Region "Serialize & Deserialize related methods"

'        Public Sub SaveXml(ByVal filename As String)
'            Dim serializer As New XmlSerializer(GetType(CustomPropertyCollection))
'            Dim writer As New IO.FileStream(filename, IO.FileMode.Create)
'            Try
'                serializer.Serialize(writer, Me)
'            Catch ex As Exception
'                MsgBox(ex.InnerException.Message)
'            End Try
'            writer.Close()
'        End Sub

'        Public Function LoadXml(ByVal filename As String, Optional ByVal UpdateDefaultValue As Boolean = False) As Boolean
'            Try
'                Dim serializer As New XmlSerializer(GetType(CustomPropertyCollection))
'                Dim reader As New IO.FileStream(filename, IO.FileMode.Open)

'                Dim cpc As CustomPropertyCollection = CType(serializer.Deserialize(reader), CustomPropertyCollection)
'                For Each customprop As CustomProperty In cpc
'                    If UpdateDefaultValue Then customprop.DefaultValue = customprop.Value
'                    customprop.RebuildAttributes()
'                    Me.Add(customprop)
'                Next
'                cpc = Nothing
'                reader.Close()
'                Return True

'            Catch exIO As System.IO.FileNotFoundException
'                Return False

'            Catch ex As Exception
'                MsgBox(ex.InnerException, MsgBoxStyle.Critical, ex.Message)
'                Return False
'            End Try

'        End Function

'        Public Sub SaveBinary(ByVal filename As String)
'            Dim stream As IO.Stream = IO.File.Create(filename)
'            Dim serializer As New Runtime.Serialization.Formatters.Binary.BinaryFormatter
'            Try
'                serializer.Serialize(stream, Me)
'            Catch ex As Exception
'                MsgBox(ex.InnerException.Message)
'            End Try
'            stream.Close()
'        End Sub

'        Public Function LoadBinary(ByVal filename As String) As Boolean
'            Try
'                Dim stream As IO.Stream = IO.File.Open(filename, IO.FileMode.Open)
'                Dim formatter As New Runtime.Serialization.Formatters.Binary.BinaryFormatter()
'                If stream.Length > 0 Then
'                    Dim cpc As CustomPropertyCollection = CType(formatter.Deserialize(stream), CustomPropertyCollection)
'                    For Each customprop As CustomProperty In cpc
'                        customprop.RebuildAttributes()
'                        Me.Add(customprop)
'                    Next
'                    cpc = Nothing
'                    stream.Close()
'                    Return True
'                Else
'                    stream.Close()
'                    Return False
'                End If

'            Catch ex As Exception
'                Return False
'            End Try
'        End Function

'#End Region

'    End Class

'End Namespace


Namespace MyPropetyGrid

    Public Class AppSettings

        '
        '   Comment by      : JOHAN VERMEULEN
        '   Comment date    : 2014/06/19
        '

        ' All web services were decommisioned because I could not get stable and predictable results with the queries via SOAP 1.1 
        ' which is he current standard supported by the BMC Remedy Webservices. 
        ' These Web services are extremely poorly documented or propriety info and the comunication simply does not 
        ' work effectively enough to conclude this in the time boundaries allocated 
        '
        'Private _LOG_DM_Department_BasicWs__c As String = "http://Remedy.Treasury.gov.za/arsys/services/ARService?server=ProdLGRemV1&webService=LOG_DM_Department_BasicWS__c"
        'Private _LOG_DM_Personnel_BasicWs__c As String = "http://Remedy.Treasury.gov.za/arsys/services/ARService?server=ProdLGRemV1&webService=LOG_DM_Personnel_BasicWS__c"
        'Private _LOG_IN_Request_Tracking_BasicWs__c As String = "http://Remedy.Treasury.gov.za/arsys/services/ARService?server=ProdLGRemV1&webService=LOG_IN_Request_Tracking_BasicWS__c"
        'Private _LOG_DM_Customer_Information_BasicWs__c As String = "http://Remedy.Treasury.gov.za/arsys/services/ARService?server=ProdLGRemV1&webService=LOG_DM_Customer_Information_BasicWS__c"
        'Private _LastName As String = My.MySettings.Default.RemedyUserName

        Private _Active_QA As String = "True"
        Private _Active_PRD As String = "True"
        Private _ValidUser As String = "False"
        Private _VulindlelaUser As String = My.MySettings.Default.VulindlelaUser
        Private _SMPTPServerNames As String = My.MySettings.Default.SMTPServerIPAddress
        Private _BMCRemedyServerAddress As String = My.MySettings.Default.ARSServerName
        Private _DefaultWebBrowserEXE As String = My.MySettings.Default.WebBrowserEXE
        Private _VulinSQLServerList As String
        Private _VulindlelaSQLServerAddress As String = My.MySettings.Default.IP_ADDRESS_PRD
        Private _VIP_ExpandedConnectionString As String = My.MySettings.Default.VIP_EXPANDEDConnectionString
        Private _ADSQAConnectionString As String = My.MySettings.Default.ADSQAConnectionString2014
        Private _ADSPRDConnectionString As String = My.MySettings.Default.AdsConnectionString
        Private _ADSConnectionString As String = My.MySettings.Default.AdsConnectionString
        Private _RemedySQLConnection As String = My.MySettings.Default.ARSystemConnectionString
        Private _ARSystemConnectionString As String = My.MySettings.Default.ARSystemConnectionString
        Private _AD_Users_PRD As String = My.MySettings.Default.AD_USERS_PRD
        Private _AD_Users_QA As String = My.MySettings.Default.AD_USERS_QA
        Private _AD_DC_PRD As String = My.MySettings.Default.AD_DC_PRD
        Private _AD_DC_QA As String = My.MySettings.Default.AD_DC_QA
        Private _ADSMasterPassword_PRD As String = My.MySettings.Default.ADSMasterPassword_PRD
        Private _ADSMasterPassword_QA As String = My.MySettings.Default.ADSMasterPassword_QA
        Private _ContextApplicationPRD As String = My.MySettings.Default.contextApplicationPRD
        Private _ContextApplicationQA As String = My.MySettings.Default.contextApplicationQA '"OU=APPLICATION_RIGHTS,OU=Vulindlela3,DC=vulqa,DC=pwv,DC=gov,DC=za"
        Private _VulindlelaContextPRD As String = My.MySettings.Default.VulindlelaContextPRD  '"OU=Vulindlela3,DC=vulindlelaprd,DC=gov,DC=za"
        Private _VulindlelaContextQA As String = My.MySettings.Default.VulindlelaContextQA  '"OU=Vulindlela3,DC=vulqa,DC=pwv,DC=gov,DC=za"
        Private _AD_ServerName_PRD As String = My.MySettings.Default.AD_ServerName_PRD '"VULWEB"
        Private _AD_ServerName_QA As String = My.MySettings.Default.AD_ServerName_QA '"VULQA1"
        Private _ADSMasterUsername_PRD As String = My.MySettings.Default.ADSMasterUsername_PRD '"vulsystem"
        Private _ADSMasterUsername_QA As String = My.MySettings.Default.ADSMasterUsername_QA '"vulsystem"
        Private _IP_Address_PRD As String = My.MySettings.Default.IP_ADDRESS_PRD '"10.123.45.180"
        Private _IP_Address_QA As String = My.MySettings.Default.IP_ADDRESS_QA '"10.123.45.210"
        Private _WebUrlQA As String = My.MySettings.Default.WEBURLPRD '"http://10.123.45.210/"
        Private _WebUrlPRD As String = My.MySettings.Default.WEBURLQA '"http://www.vulindlela.gov.za/"
        Private _HelpDesk_PhoneNo As String = My.MySettings.Default.HelpDesk_PhoneNo '"012-6574444"
        Private _SMTPServerIPAddress As String = My.MySettings.Default.SMTPServerIPAddress '"10.123.45.210"
        Private _RemedyServerName As String = My.MySettings.Default.RemedyServerName '"remedy.treasury.gov.za"
        Private _Vulindlela_Controllers As String = My.MySettings.Default.Vulindlela_Controllers '"WCP,Ralton Kirby <Rkirby@pgwc.gov.za>|NCP,Michael Femmers <femmersm@ncpg.gov.za>"
        Private _ARSServerName As String = My.MySettings.Default.ARSServerName '"ProdLGRemV1"
        Private _ARServerPort As String = My.MySettings.Default.ARServerPort '"80"
        Private _ARUser As String = My.Settings.Default.ARUser '" (...) "
        Private _ARPassword As String = My.Settings.Default.ARPassword '"logik007"
        Private _DeptDescPair As String = My.MySettings.Default.DeptDescPair 'mpu_|Mpumalanga,kzn_|Kwazulu Natal,nop_|Limpopo,gau_|Gauteng,wcp_|Western Cape,ecp_|Eastern Cape,nwp_|North West,fsp_|Free State
        Private _WebBrowserExe As String = My.MySettings.Default.WebBrowserEXE '"C:\Users\vul2126\AppData\Local\Google\Chrome\Application\chrome.exe"
        Private _ProxyOveride As String = My.MySettings.Default.ProxyOveride '"C:\Users\vul2126\AppData\Local\Google\Chrome\Application\chrome.exe"
        Private _ProxyOverideCurrent As String = My.MySettings.Default.VIP_EXPANDEDConnectionString  '"C:\Users\vul2126\AppData\Local\Google\Chrome\Application\chrome.exe"
        Private _Close_Pick_Forms As Boolean = My.MySettings.Default.Close_Pick_Forms 'False
        'Private _VulindlelaUser As String = My.MySettings.Default.VulindlelaUser

        <Category("Vulindlela Settings"), _
         Description("Behaviour of picklists - Wheter to close or stay open")> _
        Public Property Close_Pick_Forms() As Boolean
            Get
                Return _Close_Pick_Forms
            End Get
            Set(ByVal Value As Boolean)
                _Close_Pick_Forms = Value
            End Set
        End Property

        <Category("Proxy Server Settings"), _
         Description("New Proxy Server Exception settings to be applied")> _
        Public Property ProxyOveride() As String
            Get
                Return _ProxyOveride
            End Get
            Set(ByVal Value As String)
                _ProxyOveride = Value
            End Set
        End Property

        <TypeConverter(GetType(GetProxyOverideFromRegistry)), _
          Category("Proxy Server Settings"), _
          Description("Current Proxy Server Exception settings")> _
        Public Property ProxyOverideCurrent() As String
            Get
                Return _ProxyOverideCurrent
            End Get
            Set(ByVal Value As String)
                _ProxyOverideCurrent = Value
            End Set
        End Property

        <TypeConverter(GetType(VulindlelaControllers)), _
        Category("Vulindlela Settings"), _
        Description("Vulindlela Controllers who are registered to get EMail communication")> _
        Public Property Vulindlela_Controllers() As String
            Get
                Return _Vulindlela_Controllers
            End Get
            Set(ByVal Value As String)
                _Vulindlela_Controllers = Value
            End Set
        End Property

        Public Class VulindlelaControllers
            Inherits System.ComponentModel.StringConverter
            Private Vulindlela_Controllers As String() = New String() {"WCP,Ronel Ilsley <Ronel.Ilsley@treasury.gov.za>|NCP,Michael Femmers <femmersm@ncpg.gov.za>", "WCP,Ronel Ilsley <Ronel.Ilsley@treasury.gov.za>|NCP,Michael Femmers <femmersm@ncpg.gov.za>|GAU,Johan Vermeulen <>"}
            Public Overloads Overrides Function GetStandardValues(ByVal context As System.ComponentModel.ITypeDescriptorContext) As System.ComponentModel.TypeConverter.StandardValuesCollection
                Return New StandardValuesCollection(Vulindlela_Controllers)
            End Function
            Public Overloads Overrides Function GetStandardValuesExclusive(ByVal context As System.ComponentModel.ITypeDescriptorContext) As Boolean
                Return True
            End Function
            Public Overloads Overrides Function GetStandardValuesSupported(ByVal context As System.ComponentModel.ITypeDescriptorContext) As Boolean
                Return True
            End Function
        End Class

        <TypeConverter(GetType(BmcARSServerList)), _
        CategoryAttribute("BMC Remedy Configs"), _
        Description("BMC Remedy Server hostname to be used in queries (not the FQDN)")> _
        Public Property ARSServerName() As String
            Get
                Return _ARSServerName
            End Get
            Set(ByVal Value As String)
                _ARSServerName = Value
            End Set
        End Property

        <TypeConverter(GetType(BmcWebServerList)), _
        CategoryAttribute("BMC Remedy Configs"), _
        Description("BMC Remedy Webserver name to be used immediately after HTTP:// in calls")> _
        Public Property RemedyServerName() As String
            Get
                Return _RemedyServerName
            End Get
            Set(ByVal Value As String)
                _RemedyServerName = Value
            End Set
        End Property

        <DescriptionAttribute("BMC Remedy system password to be used by ADAdmin to logon"), _
        CategoryAttribute("BMC Remedy Configs")> _
        Public Property ARPassword() As String
            Get
                Return _ARPassword
            End Get
            Set(ByVal Value As String)
                _ARPassword = Value
            End Set
        End Property

        <TypeConverter(GetType(VulindlelaUsers)), _
        Category("BMC Remedy Configs"), _
        Description("The curent BMC Remedy System user's name")> _
        Public Property ARUser() As String
            Get
                Return _ARUser
            End Get
            Set(ByVal Value As String)
                _ARUser = Value
            End Set
        End Property

        <DescriptionAttribute("Comma seperated value-pairs to define NATPROV descriptions"), _
        CategoryAttribute("Active Directory Configuration")> _
        Public Property DeptDescPair() As String
            Get
                Return _DeptDescPair
            End Get
            Set(ByVal Value As String)
                _DeptDescPair = Value
            End Set
        End Property

        <DescriptionAttribute("'AD Admin' Master password for the Production Server environment"), _
         ReadOnlyAttribute(True), _
        CategoryAttribute("Active Directory Configuration")> _
        Public Property ADSMasterPassword_PRD() As String
            Get
                Return _ADSMasterPassword_PRD
            End Get
            Set(ByVal Value As String)
                _ADSMasterPassword_PRD = Value
            End Set
        End Property

        <DescriptionAttribute("ADAdmin master password for QA environment"), _
         ReadOnlyAttribute(True), _
        CategoryAttribute("Active Directory Configuration")> _
        Public Property ADSMasterPassword_QA() As String
            Get
                Return _ADSMasterPassword_QA
            End Get
            Set(ByVal Value As String)
                _ADSMasterPassword_QA = Value
            End Set
        End Property

        <DescriptionAttribute("LDAP String used to connect to the Active Directory USERS [Organisational Unit] of Active Directory in PRD"), _
         ReadOnlyAttribute(True), _
        CategoryAttribute("Active Directory Configuration")> _
        Public Property AD_Users_PRD() As String
            Get
                Return _AD_Users_PRD
            End Get
            Set(ByVal Value As String)
                _AD_Users_PRD = Value
            End Set
        End Property

        <DescriptionAttribute("LDAP String used to connect to the Active Directory USERS [Organisational Unit] of Active Directory in QA"), _
         ReadOnlyAttribute(True), _
        CategoryAttribute("Active Directory Configuration")> _
        Public Property AD_Users_QA() As String
            Get
                Return _AD_Users_QA
            End Get
            Set(ByVal Value As String)
                AD_Users_QA = Value
            End Set
        End Property

        <DescriptionAttribute("Help desk's phone number"), _
        CategoryAttribute("Vulindlela Settings")> _
        Public Property HelpDesk_PhoneNo() As String
            Get
                Return _HelpDesk_PhoneNo
            End Get
            Set(ByVal Value As String)
                _HelpDesk_PhoneNo = Value
            End Set
        End Property

        <TypeConverter(GetType(SMTPServerList)), _
         CategoryAttribute("Vulindlela Settings"), _
         DescriptionAttribute("The SMTP EMail Server IP Address")> _
        Public Property SMTPServerIPAddress() As String
            Get
                Return _SMTPServerIPAddress
            End Get
            Set(ByVal Value As String)
                _SMTPServerIPAddress = Value
            End Set
        End Property

        <TypeConverter(GetType(VulindlelaUsers)), _
        Category("Vulindlela Settings"), _
        Description("Select the current Vulindlela user from the list.")> _
        Public Property VulindlelaUser() As String
            Get
                Return _VulindlelaUser
            End Get
            Set(ByVal Value As String)
                _VulindlelaUser = Value
            End Set
        End Property

        <TypeConverter(GetType(VulindlelaSqlServerList)), _
        Category("Hosts && IP Addresses"), _
        Description("Vulindlela SQL Server Address List")> _
        Public Property VulindlelaSqlServerAddress() As String
            Get
                Return _VulindlelaSQLServerAddress
            End Get
            Set(ByVal Value As String)
                _VulindlelaSQLServerAddress = Value
            End Set
        End Property

        <DescriptionAttribute("BMC Remedy SQL Server connection strings to the SQL2012 instance"), _
        Category("Database Connections")> _
        Public Property RemedySqlConnection() As String
            Get
                Return _RemedySQLConnection
            End Get
            Set(ByVal Value As String)
                _RemedySQLConnection = Value
            End Set
        End Property

        <DescriptionAttribute("BMC Remedy SQL Server connection strings to the SQL2005 instance"), _
           Category("Database Connections")> _
        Public Property ARSystemConnectionString() As String
            Get
                Return _ARSystemConnectionString
            End Get
            Set(ByVal Value As String)
                _ARSystemConnectionString = Value
            End Set
        End Property

        '<DescriptionAttribute("[Switcher] ADS Database connection string for the QA Environment (10.123.45.210)"), _
        'CategoryAttribute("Database Connections")> _
        'Public Property ADSQAConnectionString() As String
        '    Get
        '        Return _ADSQAConnectionString
        '    End Get
        '    Set(ByVal Value As String)
        '        _ADSQAConnectionString = Value
        '    End Set
        'End Property

        <DescriptionAttribute("VIP_EXPANDED Database connection string for the Prodution Environment (10.123.45.180)"), _
        CategoryAttribute("Database Connections")> _
        Public Property VIP_ExpandedConnectionString() As String
            Get
                Return _VIP_ExpandedConnectionString
            End Get
            Set(ByVal Value As String)
                _VIP_ExpandedConnectionString = Value
            End Set
        End Property

        <DescriptionAttribute("[Switcher] ADS Database connection string for the Prodution Environment (10.123.45.180)"), _
        CategoryAttribute("Database Connections")> _
        Public Property ADSPRDConnectionString() As String
            Get
                Return _ADSPRDConnectionString
            End Get
            Set(ByVal Value As String)
                _ADSPRDConnectionString = Value
            End Set
        End Property

        <DescriptionAttribute("[ACTIVE] ADS Database connection string for the Prodution Environment (10.123.45.180)"), _
        CategoryAttribute("Database Connections")> _
        Public Property ADSConnectionString() As String
            Get
                Return _ADSConnectionString
            End Get
            Set(ByVal Value As String)
                _ADSConnectionString = Value
            End Set
        End Property

        Public Overloads Function GetStandardValuesExclusive(ByVal context As System.ComponentModel.ITypeDescriptorContext) As Boolean
            Return True
        End Function

        Public Overloads Function GetStandardValuesSupported(ByVal context As System.ComponentModel.ITypeDescriptorContext) As Boolean
            Return True
        End Function

        <DescriptionAttribute("Default Web browser program executabe to be used when processing web requests"), _
         CategoryAttribute("Vulindlela Settings"), _
         Editor(GetType(FileNameEditor), GetType(UITypeEditor))> _
        Public Property DefaultWebBrowserEXE() As String
            Get
                Return _DefaultWebBrowserEXE
            End Get
            Set(ByVal Value As String)
                _DefaultWebBrowserEXE = Value
            End Set
        End Property

    End Class

    Public Class FileNameConverter
        Inherits StringConverter
    End Class

    Public Class WebservicesList
        Inherits System.ComponentModel.StringConverter
        Private WebServiceNames As String() = New String() {"ProdLGSqlV1\SQL2012", "10.123.216.106\SQL2012", "10.123.216.102\SQL2005"}
        Public Overloads Overrides Function GetStandardValues(ByVal context As System.ComponentModel.ITypeDescriptorContext) As System.ComponentModel.TypeConverter.StandardValuesCollection
            Return New StandardValuesCollection(WebServiceNames)
        End Function
        Public Overloads Overrides Function GetStandardValuesExclusive(ByVal context As System.ComponentModel.ITypeDescriptorContext) As Boolean
            Return True
        End Function
        Public Overloads Overrides Function GetStandardValuesSupported(ByVal context As System.ComponentModel.ITypeDescriptorContext) As Boolean
            Return True
        End Function
    End Class

    Public Class VulinSQLServers
        Inherits System.ComponentModel.StringConverter
        Private VulinSQLServerList As String() = New String() {"10.123.45.180", "10.123.45.210", "10.123.45.165", "10.123.45.165\SQL2000_STD", "VULINMET2", "10.123.45.175"}
        Public Overloads Overrides Function GetStandardValues(ByVal context As System.ComponentModel.ITypeDescriptorContext) As System.ComponentModel.TypeConverter.StandardValuesCollection
            Return New StandardValuesCollection(VulinSQLServerList)
        End Function
        Public Overloads Overrides Function GetStandardValuesExclusive(ByVal context As System.ComponentModel.ITypeDescriptorContext) As Boolean
            Return True
        End Function
        Public Overloads Overrides Function GetStandardValuesSupported(ByVal context As System.ComponentModel.ITypeDescriptorContext) As Boolean
            Return True
        End Function
    End Class

    Public Class VulindlelaUsers
        Inherits System.ComponentModel.StringConverter
        Private VulindlelaUserNames As String() = New String() {"Ronel.Ilsley", "T0006137", "T0003022", "Elaine.Eybers", "Masaila.Nale", "Masaila", "T0008266", "T0007198", "T0008266"}
        Public Overloads Overrides Function GetStandardValues _
            (ByVal context As System.ComponentModel.ITypeDescriptorContext) _
            As System.ComponentModel.TypeConverter.StandardValuesCollection
            Return New StandardValuesCollection(VulindlelaUserNames)
        End Function
        Public Overloads Overrides Function GetStandardValuesExclusive _
            (ByVal context As System.ComponentModel.ITypeDescriptorContext) As Boolean
            Return True
        End Function
        Public Overloads Overrides Function GetStandardValuesSupported _
            (ByVal context As System.ComponentModel.ITypeDescriptorContext) As Boolean
            Return True
        End Function
    End Class

    Public Class SMTPServerList
        Inherits System.ComponentModel.StringConverter
        Private SMPTPServerNames As String() = New String() {"VulQAIIS.vulqa.pwv.gov.za", "10.135.220.11", "10.120.50.54", "10.120.50.45", "10.131.171.154"}
        Public Overloads Overrides Function GetStandardValues(ByVal context As System.ComponentModel.ITypeDescriptorContext) As System.ComponentModel.TypeConverter.StandardValuesCollection
            Return New StandardValuesCollection(SMPTPServerNames)
        End Function
        Public Overloads Overrides Function GetStandardValuesExclusive(ByVal context As System.ComponentModel.ITypeDescriptorContext) As Boolean
            Return True
        End Function
        Public Overloads Overrides Function GetStandardValuesSupported(ByVal context As System.ComponentModel.ITypeDescriptorContext) As Boolean
            Return True
        End Function
    End Class

    Public Class VulindlelaSqlServerList

        Inherits System.ComponentModel.StringConverter
        Private VulindlelaSqlServerNames As String() = New String() {"10.120.50.55", "10.120.50.72"}

        'Returns a collection of standard values for the data type this type converter is designed for.
        Public Overloads Overrides Function GetStandardValues _
            (ByVal context As System.ComponentModel.ITypeDescriptorContext) _
            As System.ComponentModel.TypeConverter.StandardValuesCollection

            Return New StandardValuesCollection(VulindlelaSqlServerNames)
        End Function

        'Returns whether the collection of standard values returned from GetStandardValues is 
        'an exclusive list. Returning False would change the drop down list to an editable combo box
        Public Overloads Overrides Function GetStandardValuesExclusive _
            (ByVal context As System.ComponentModel.ITypeDescriptorContext) As Boolean
            Return True
        End Function

        'Returns whether this object supports a standard set of values that can be picked from a list.
        Public Overloads Overrides Function GetStandardValuesSupported _
            (ByVal context As System.ComponentModel.ITypeDescriptorContext) As Boolean
            Return True
        End Function

    End Class

    Public Class BmcARSServerList
        Inherits System.ComponentModel.StringConverter
        Private BmcArsServerNames As String() = New String() {"prodlgremv1", "prodlgremb1"}
        Public Overloads Overrides Function GetStandardValues(ByVal context As System.ComponentModel.ITypeDescriptorContext) As System.ComponentModel.TypeConverter.StandardValuesCollection
            Return New StandardValuesCollection(BmcArsServerNames)
        End Function
        Public Overloads Overrides Function GetStandardValuesExclusive(ByVal context As System.ComponentModel.ITypeDescriptorContext) As Boolean
            Return True
        End Function
        Public Overloads Overrides Function GetStandardValuesSupported(ByVal context As System.ComponentModel.ITypeDescriptorContext) As Boolean
            Return True
        End Function
    End Class

    Public Class BmcWebServerList
        Inherits System.ComponentModel.StringConverter
        Private BmcWebServerNames As String() = New String() {"Remedy.Treasury.gov.za", "Remedy.Logis.gov.za", "10.123.216.99"}

        Public Overloads Overrides Function GetStandardValues(ByVal context As System.ComponentModel.ITypeDescriptorContext) As System.ComponentModel.TypeConverter.StandardValuesCollection
            Return New StandardValuesCollection(BmcWebServerNames)
        End Function
        Public Overloads Overrides Function GetStandardValuesExclusive(ByVal context As System.ComponentModel.ITypeDescriptorContext) As Boolean
            Return True
        End Function
        Public Overloads Overrides Function GetStandardValuesSupported(ByVal context As System.ComponentModel.ITypeDescriptorContext) As Boolean
            Return True
        End Function
    End Class

    Public Class GetProxyOverideFromRegistry
        Inherits System.ComponentModel.StringConverter
        Dim oReg As New ADAdminDotNet.appRegistry
        Private ProxyOverideCurrent As String() = New String() {My.MySettings.Default.ProxyOveride, oReg.GetRegKeyValue(appRegistry.RegRoots.HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Internet Settings", "ProxyOverride")}
        Public Overloads Overrides Function GetStandardValues(ByVal context As System.ComponentModel.ITypeDescriptorContext) As System.ComponentModel.TypeConverter.StandardValuesCollection
            Return New StandardValuesCollection(ProxyOverideCurrent)
        End Function
        Public Overloads Overrides Function GetStandardValuesExclusive(ByVal context As System.ComponentModel.ITypeDescriptorContext) As Boolean
            Return True
        End Function
        Public Overloads Overrides Function GetStandardValuesSupported(ByVal context As System.ComponentModel.ITypeDescriptorContext) As Boolean
            Return True
        End Function
    End Class

End Namespace

#Region "Deprecated"
'<TypeConverter(GetType(StreetAddressConverter))> _
'Public Class StreetAddress
'    Public Sub New()
'    End Sub
'    Public Sub New(ByVal txt As String)
'        Dim fields() As String = txt.Split(","c)
'        m_Street = fields(0)
'        m_City = fields(1)
'        m_State = fields(2)
'    End Sub
'    Public Sub New(ByVal new_street As String, ByVal new_city As String, ByVal new_state As String)
'        m_Street = new_street
'        m_City = new_city
'        m_State = new_state
'    End Sub

'    Public Overrides Function ToString() As String
'        Return m_Street & "," & m_City & "," & State
'    End Function

'    Private m_Street As String
'    Public Property Street() As String
'        Get
'            Return m_Street
'        End Get
'        Set(ByVal Value As String)
'            m_Street = Value
'        End Set
'    End Property

'    Private m_City As String
'    Public Property City() As String
'        Get
'            Return m_City
'        End Get
'        Set(ByVal Value As String)
'            m_City = Value
'        End Set
'    End Property

'    Private m_State As String
'    Public Property State() As String
'        Get
'            Return m_State
'        End Get
'        Set(ByVal Value As String)
'            m_State = Value
'        End Set
'    End Property
'End Class

'Public Class StreetAddress2
'    Public Sub New()
'    End Sub
'    Public Sub New(ByVal new_street As String, ByVal new_city As String, ByVal new_state As String)
'        m_Street = new_street
'        m_City = new_city
'        m_State = new_state
'    End Sub

'    Public Overrides Function ToString() As String
'        Return m_Street & "," & m_City & "," & State
'    End Function

'    Private m_Street As String
'    Public Property Street() As String
'        Get
'            Return m_Street
'        End Get
'        Set(ByVal Value As String)
'            m_Street = Value
'        End Set
'    End Property

'    Private m_City As String
'    Public Property City() As String
'        Get
'            Return m_City
'        End Get
'        Set(ByVal Value As String)
'            m_City = Value
'        End Set
'    End Property

'    Private m_State As String
'    Public Property State() As String
'        Get
'            Return m_State
'        End Get
'        Set(ByVal Value As String)
'            m_State = Value
'        End Set
'    End Property
'End Class

'Public Class AddressCollection
'    Inherits CollectionBase

'    Default Public Property Item(ByVal index As Integer) As StreetAddress
'        Get
'            Return CType(List(index), StreetAddress)
'        End Get
'        Set(ByVal Value As StreetAddress)
'            List(index) = Value
'        End Set
'    End Property

'    Public Sub Add(ByVal street_address As StreetAddress)
'        List.Add(street_address)
'    End Sub

'    Public Function IndexOf(ByVal value As StreetAddress) As Integer
'        Return List.IndexOf(value)
'    End Function

'    Public Sub Insert(ByVal index As Integer, ByVal value As StreetAddress)
'        List.Insert(index, value)
'    End Sub

'    Public Sub Remove(ByVal value As StreetAddress)
'        List.Remove(value)
'    End Sub

'    Public Function Contains(ByVal value As StreetAddress) As Boolean
'        Return List.Contains(value)
'    End Function

'    Protected Overrides Sub OnInsert(ByVal index As Integer, ByVal value As Object)
'        If Not value.GetType() Is GetType(StreetAddress) Then
'            Throw New ArgumentException("Value must be of type StreetAddress.", "value")
'        End If
'    End Sub

'    Protected Overrides Sub OnRemove(ByVal index As Integer, ByVal value As Object)
'        If Not value.GetType() Is GetType(StreetAddress) Then
'            Throw New ArgumentException("Value must be of type StreetAddress.", "value")
'        End If
'    End Sub

'    Protected Overrides Sub OnSet(ByVal index As Integer, ByVal oldValue As Object, ByVal newValue As Object)
'        If Not newValue.GetType() Is GetType(StreetAddress) Then
'            Throw New ArgumentException("New value must be of type StreetAddress.", "newValue")
'        End If
'    End Sub

'    Protected Overrides Sub OnValidate(ByVal value As Object)
'        If Not value.GetType() Is GetType(StreetAddress) Then
'            Throw New ArgumentException("Value must be of type StreetAddress.", "value")
'        End If
'    End Sub

'    Public Sub New()
'    End Sub

'    Public Sub New(ByVal txt As String)
'        Dim addresses() As String = txt.Split(New Char() {";"})

'        For Each address_text As String In addresses
'            Try
'                Me.List.Add(New StreetAddress(address_text))
'            Catch
'                Throw New InvalidCastException( _
'                    "Invalid StreetAddress serialization '" & _
'                    address_text & "'")
'            End Try
'        Next address_text
'    End Sub

'    Public Overrides Function ToString() As String
'        Dim txt As String = ""
'        For Each street_address As StreetAddress In MyBase.List
'            txt &= ";" & street_address.ToString()
'        Next street_address

'        If txt.Length > 0 Then txt = txt.Substring(1)

'        Return txt
'    End Function
'End Class

'Public Class AddressCollectionConverter
'    Inherits TypeConverter

'    Public Overloads Overrides Function CanConvertFrom(ByVal context As System.ComponentModel.ITypeDescriptorContext, ByVal sourceType As System.Type) As Boolean
'        If (sourceType.Equals(GetType(String))) Then
'            Return True
'        Else
'            Return MyBase.CanConvertFrom(context, sourceType)
'        End If
'    End Function

'    Public Overloads Overrides Function CanConvertTo(ByVal context As System.ComponentModel.ITypeDescriptorContext, ByVal destinationType As System.Type) As Boolean
'        If (destinationType.Equals(GetType(String))) Then
'            Return True
'        Else
'            Return MyBase.CanConvertTo(context, destinationType)
'        End If
'    End Function

'    Public Overloads Overrides Function ConvertFrom(ByVal context As System.ComponentModel.ITypeDescriptorContext, ByVal culture As System.Globalization.CultureInfo, ByVal value As Object) As Object
'        If (TypeOf value Is String) Then
'            Dim txt As String = CType(value, String)
'            Return New AddressCollection(txt)
'        Else
'            Return MyBase.ConvertFrom(context, culture, value)
'        End If
'    End Function

'    Public Overloads Overrides Function ConvertTo(ByVal context As System.ComponentModel.ITypeDescriptorContext, ByVal culture As System.Globalization.CultureInfo, ByVal value As Object, ByVal destinationType As System.Type) As Object
'        If (destinationType.Equals(GetType(String))) Then
'            Return value.ToString()
'        Else
'            Return MyBase.ConvertTo(context, culture, value, destinationType)
'        End If
'    End Function

'    Public Overloads Overrides Function GetPropertiesSupported(ByVal context As ITypeDescriptorContext) As Boolean
'        Return True
'    End Function

'    Public Overloads Overrides Function GetProperties(ByVal context As ITypeDescriptorContext, ByVal value As Object, ByVal Attribute() As Attribute) As PropertyDescriptorCollection
'        Return TypeDescriptor.GetProperties(value)
'    End Function
'End Class

'Public Class StreetAddressConverter
'    Inherits TypeConverter
'    Public Overloads Overrides Function CanConvertFrom(ByVal context As System.ComponentModel.ITypeDescriptorContext, ByVal sourceType As System.Type) As Boolean
'        If (sourceType.Equals(GetType(String))) Then : Return True : Else : Return MyBase.CanConvertFrom(context, sourceType) : End If
'    End Function

'    Public Overloads Overrides Function CanConvertTo(ByVal context As System.ComponentModel.ITypeDescriptorContext, ByVal destinationType As System.Type) As Boolean
'        If (destinationType.Equals(GetType(String))) Then : Return True : Else : Return MyBase.CanConvertTo(context, destinationType) : End If
'    End Function

'    Public Overloads Overrides Function ConvertFrom(ByVal context As System.ComponentModel.ITypeDescriptorContext, ByVal culture As System.Globalization.CultureInfo, ByVal value As Object) As Object
'        If (TypeOf value Is String) Then : Dim txt As String = CType(value, String) : Try : Return New StreetAddress(txt) : Catch : Throw New InvalidCastException("Invalid StreetAddress serialization '" & value & "'") : End Try
'        Else : Return MyBase.ConvertFrom(context, culture, value) : End If
'    End Function

'    Public Overloads Overrides Function ConvertTo(ByVal context As System.ComponentModel.ITypeDescriptorContext, ByVal culture As System.Globalization.CultureInfo, ByVal value As Object, ByVal destinationType As System.Type) As Object
'        If (destinationType.Equals(GetType(String))) Then : Return value.ToString() : Else : Return MyBase.ConvertTo(context, culture, value, destinationType) : End If
'    End Function
'    Public Overloads Overrides Function GetPropertiesSupported(ByVal context As ITypeDescriptorContext) As Boolean
'        Return True
'    End Function
'    Public Overloads Overrides Function GetProperties(ByVal context As ITypeDescriptorContext, ByVal value As Object, ByVal Attribute() As Attribute) As PropertyDescriptorCollection
'        Return TypeDescriptor.GetProperties(value)
'    End Function
'End Class

#End Region
