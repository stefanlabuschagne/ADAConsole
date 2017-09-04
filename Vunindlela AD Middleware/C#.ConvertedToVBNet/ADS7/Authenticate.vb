Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.DirectoryServices
Imports System.DirectoryServices.AccountManagement

Namespace ADS7
	Public Class Authenticate
		Private mvarCol_MemberOf As New Collection()
		Private mvarCol_MemberOf2 As New Collection()
		Private mvarCol_AppRights As New Collection()
		Private mvarChange_password As Boolean
		Private ADSMasterUsername As String = "vulsystem"
		Private ADSMasterPassword As String = "Qsadoh!Qsadoh"
		Private ADSPasswordExpireAfter As Integer = 60
		Private ADSMaxBadLogins As Integer = 4
		Private _cnConn As String
		Private mvarsConn As String
		Private mvarTitle As String
		Private mvarName As String
		Private mvarSurname As String
		Private mvarGivenName As String
		Private mvarProvinceID As String
		Private mvarProvinceTypeID As String
		Private mvarProvince As String
		Private mvarProvinceSName As String
		Private mvarDepartmentID As String
		Private mvarDepartmentTypeID As String
		Private mvarDepartment As String
		Private mvarDepartmentSName As String
		Private mvarEMailAddress As String
		Private mvarSAMaccountname As String
		Private DC As String
		Private IP_ADDRESS As String
		Private mvarsRights As String = ""
		Private mvarsError As String
		Private Session_USER_RIGHTS As New Dictionary(Of String, String)()
		Public Property cnConn() As String
			Get
				Return Me._cnConn
			End Get
			Set
				Me._cnConn = value
			End Set
		End Property
		Public Property sError() As String
			Get
				Return Me.mvarsError
			End Get
			Set
				Me.mvarsError = value
			End Set
		End Property
		Public Property change_password() As Boolean
			Get
				Return Me.mvarChange_password
			End Get
			Set
				Me.mvarChange_password = value
			End Set
		End Property
		Public Property Title() As String
			Get
				Return Me.mvarTitle
			End Get
			Set
				Me.mvarTitle = value
			End Set
		End Property
		Public Property Name() As String
			Get
				Return Me.mvarName
			End Get
			Set
				Me.mvarName = value
			End Set
		End Property
		Public Property SurName() As String
			Get
				Return Me.mvarSurname
			End Get
			Set
				Me.mvarSurname = value
			End Set
		End Property
		Public Property GivenName() As String
			Get
				Return Me.mvarGivenName
			End Get
			Set
				Me.mvarGivenName = value
			End Set
		End Property
		Public Property EmailAddress() As String
			Get
				Return Me.mvarEMailAddress
			End Get
			Set
				Me.mvarEMailAddress = value
			End Set
		End Property
		Public Property SAMAccountName() As String
			Get
				Return Me.mvarSAMaccountname
			End Get
			Set
				Me.mvarSAMaccountname = value
			End Set
		End Property
		Public Property MemberOf() As Collection
			Get
				Return Me.mvarCol_MemberOf
			End Get
			Private Set
				Me.mvarCol_MemberOf = value
			End Set
		End Property
		Public Property MemberOf2() As Collection
			Get
				Return Me.mvarCol_MemberOf2
			End Get
			Private Set
				Me.mvarCol_MemberOf2 = value
			End Set
		End Property
		Public Property Rights() As Collection
			Get
				Return Me.mvarCol_AppRights
			End Get
			Set
				Me.mvarCol_AppRights = value
			End Set
		End Property
		Public Property sRights() As String
			Get
				Return Me.mvarsRights
			End Get
			Set
				Me.mvarsRights = value
			End Set
		End Property
		Public Property DepartmentID() As String
			Get
				Return Me.mvarDepartmentID
			End Get
			Set
				Me.mvarDepartmentID = value
			End Set
		End Property
		Public Property DepartmentTypeID() As String
			Get
				Return Me.mvarDepartmentTypeID
			End Get
			Set
				Me.mvarDepartmentTypeID = value
			End Set
		End Property
		Public Property DepartmentSName() As String
			Get
				Return Me.mvarDepartmentSName
			End Get
			Set
				Me.mvarDepartmentSName = value
			End Set
		End Property
		Public Property Department() As String
			Get
				Return Me.mvarDepartment
			End Get
			Set
				Me.mvarDepartment = value
			End Set
		End Property
		Public Property ProvinceID() As String
			Get
				Return Me.mvarProvinceID
			End Get
			Set
				Me.mvarProvinceID = value
			End Set
		End Property
		Public Property ProvinceTypeID() As String
			Get
				Return Me.mvarProvinceTypeID
			End Get
			Set
				Me.mvarProvinceTypeID = value
			End Set
		End Property
		Public Property ProvinceSName() As String
			Get
				Return Me.mvarProvinceSName
			End Get
			Set
				Me.mvarProvinceSName = value
			End Set
		End Property
		Public Property Province() As String
			Get
				Return Me.mvarProvince
			End Get
			Set
				Me.mvarProvince = value
			End Set
		End Property
		Public ReadOnly Property getRightsCount() As Integer
			Get
				Return Me.mvarCol_AppRights.Count
			End Get
		End Property
		
		Public Function getUserID(Persalid As String) As String
			
			Dim a As String =""
			
			a = Persalid.ToString.ToUpper.Substring(0, 1)
				
			If a IsNot Nothing Then
				If a = "P" Then
					Return "1" & Persalid.Substring(1)
				End If
				If a = "S" Then
					Return "2" & Persalid.Substring(1)
				End If
				If a = "V" Then
					Return "3" & Persalid.Substring(1)
				End If
				If a = "T" Then
					Return "4" & Persalid.Substring(1)
				End If
			End If
			Return "0"
		End Function
		
		Public Sub getADServer(ServerShortName As String)
			
			Dim sqlCn As New SqlConnection()
			sqlCn.ConnectionString = Me._cnConn
			sqlCn.Open
			
			Dim sqlDR As New SqlDataReader = New SqlCommand
			
			sqlDR.Connection = sqlCn
			sqlDR.CommandText = "SELECT * FROM VIP..SERVER_TRANSLATION WHERE SHORT_NAME='" & ServerShortName.ToUpper & "'"
			sqlDR.CommandType = CommandType.Text
			sqlDR.ExecuteReader 
			
			If sqlDR.HasRows Then
				sqlDR.Read()
				Me.IP_ADDRESS = sqlDataReader.GetValue(sqlDR.GetOrdinal("IP")).ToString()
				Me.DC = sqlDataReader.GetValue(sqlDR.GetOrdinal("DC")).ToString()
			Else
				Me.IP_ADDRESS = ""
				Me.DC = ""
				Me.mvarsError = "SERVER_TRANSLATION FAILED"
			End If
			Close()
		End Sub
		Public Function AuthenticateIt(Username As String, ADSPassword As String) As Boolean
			Dim principalContext As New PrincipalContext(ContextType.Domain, Me.IP_ADDRESS, "CN=" & Username & ",OU=USERS,OU=Vulindlela3," & Me.DC, Username, ADSPassword)
			If Not principalContext.ValidateCredentials(Username, ADSPassword) Then
				principalContext.Dispose()
				Return False
			End If
			Dim userPrincipal__1 As UserPrincipal = UserPrincipal.FindByIdentity(principalContext, Username)
			Me.SAMAccountName = userPrincipal__1.SamAccountName
			Me.Title = userPrincipal__1.DistinguishedName
			Me.Name = userPrincipal__1.Name
			Me.SurName = userPrincipal__1.Surname
			Me.GivenName = userPrincipal__1.GivenName
			Me.EmailAddress = userPrincipal__1.EmailAddress
			Dim searchRoot As New DirectoryEntry(String.Concat(New String() {"LDAP://", Me.IP_ADDRESS, "/CN=", Username, ",OU=USERS,OU=Vulindlela3,", Me.DC}), Me.ADSMasterUsername, Me.ADSMasterPassword)
			Dim searchResult As SearchResult = New DirectorySearcher(searchRoot) With { _
				Key .Filter = "saMAccountName=" & Username, _
				Key .PropertiesToLoad = {"memberOf"} _
			}.FindOne()
			Dim count As Integer = searchResult.Properties("memberOf").Count
			For i As Integer = 0 To count - 1
				Dim text As String = searchResult.Properties("memberOf")(i).ToString()
				text = text.Replace("OU=", "")
				text = text.Replace("CN=", "")
				Dim text2 As String = text.Replace("DC=", "")
				Dim array As String() = text2.Split(New Char() {","C})
				Dim array2 As String() = array(0).Split(New Char() {"."C})
				If array(1) = "GOVERNMENT_STRUCTURE" Then
					If array(0).IndexOf(".") >= 1 Then
						Dim text3 As String = array2(0).ToUpper() & "=EXTENDED_DEPARTMENTS|"
						Try
							Me.mvarCol_MemberOf2.Add(text3, text3, Nothing, Nothing)
						Catch generatedExceptionName As Exception
						End Try
						Try
							text2 = Convert.ToString(Me.mvarCol_MemberOf2(text3)) & "','" & array2(1)
							Me.mvarCol_MemberOf2.Remove(text3)
							Me.mvarCol_MemberOf2.Add(text2, text3, Nothing, Nothing)
							GoTo IL_33B
						Catch ex As Exception
							Me.mvarsError = "{ADS7.authenticate} authenticate: (" & ex.Message & ") " & ex.Source
							userPrincipal__1.Dispose()
							principalContext.Dispose()
							Dim result As Boolean = False
							Return result
						End Try
					End If
					Me.getDetails(array(0).ToString())
				Else
					If array(1) = "APPLICATION_RIGHTS" Then
						Dim text3 As String = array2(0) & "=APPLICATION_RIGHTS|"
						Try
							Me.mvarCol_MemberOf2.Add(text3, text3, Nothing, Nothing)
						Catch generatedExceptionName As Exception
						End Try
						Try
							text2 = Convert.ToString(Me.mvarCol_MemberOf2(text3)) & "','" & array2(1)
							Me.mvarCol_MemberOf2.Remove(text3)
							Me.mvarCol_MemberOf2.Add(text2, text3, Nothing, Nothing)
						Catch ex2 As Exception
							Me.mvarsError = "{ADS7.authenticate} authenticate: (" & ex2.Message & ") " & ex2.Source
							userPrincipal__1.Dispose()
							principalContext.Dispose()
							Dim result As Boolean = False
							Return result
						End Try
					End If
				End If
				IL_33B:
				Me.mvarCol_MemberOf.Add(array, text, Nothing, Nothing)
			Next
			Dim sqlConnection As New SqlConnection(Me._cnConn)
			sqlConnection.Open()
			Dim sqlCommand As New SqlCommand()
			For Each text4 As String In Me.mvarCol_MemberOf2
				'Console.WriteLine(text4);
				sqlCommand.Connection = sqlConnection
				sqlCommand.CommandType = CommandType.Text
				sqlCommand.CommandText = "SELECT APPLICATION_GROUP_ID, GROUP_SHORT_NAME FROM VIP_EXPANDED..APPLICATION_GROUPS WHERE UPPER(GROUP_SHORT_NAME)='" & text4.Substring(0, text4.IndexOf("=")) & "'"
				Dim sqlDataReader As SqlDataReader = sqlCommand.ExecuteReader()
				If sqlDataReader.HasRows Then
					sqlDataReader.Read()
					Me.add2Application(sqlDataReader.GetValue(sqlDataReader.GetOrdinal("APPLICATION_GROUP_ID")).ToString(), sqlDataReader.GetValue(sqlDataReader.GetOrdinal("GROUP_SHORT_NAME")).ToString(), text4.ToString())
				End If
				sqlDataReader.Close()
			Next
			If Me.mvarsRights.Length > 0 Then
				Me.mvarsRights = Me.mvarsRights.Substring(1, Me.mvarsRights.Length - 1)
			End If
			userPrincipal__1.Dispose()
			principalContext.Dispose()
			Return True
		End Function
		Public Function ChangePassword(Username As String, Password As String, NewPassword As String) As Boolean
			Dim principalContext As New PrincipalContext(ContextType.Domain, Me.IP_ADDRESS, "CN=" & Username & ",OU=USERS,OU=Vulindlela3," & Me.DC, Me.ADSMasterUsername, Me.ADSMasterPassword)
			Dim userPrincipal__1 As UserPrincipal = UserPrincipal.FindByIdentity(principalContext, Username)
			Dim result As Boolean
			Try
				userPrincipal__1.ChangePassword(Password, NewPassword)
				userPrincipal__1.Save(principalContext)
				result = True
			Catch ex As Exception
				Me.mvarsError = ex.Message
				result = False
			Finally
				userPrincipal__1.Dispose()
				principalContext.Dispose()
			End Try
			Return result
		End Function
		Public Function IsExpired(Username As String) As Boolean
			Dim principalContext As New PrincipalContext(ContextType.Domain, Me.IP_ADDRESS, "CN=" & Username & ",OU=USERS,OU=Vulindlela3," & Me.DC, Me.ADSMasterUsername, Me.ADSMasterPassword)
			Dim userPrincipal__1 As UserPrincipal = UserPrincipal.FindByIdentity(principalContext, Username)
			Dim result As Boolean = userPrincipal__1.AccountExpirationDate < DateTime.Now
			userPrincipal__1.Dispose()
			principalContext.Dispose()
			Return result
		End Function
		Public Function IsLocked(Username As String) As Boolean
			Dim principalContext As New PrincipalContext(ContextType.Domain, Me.IP_ADDRESS, "CN=" & Username & ",OU=USERS,OU=Vulindlela3," & Me.DC, Me.ADSMasterUsername, Me.ADSMasterPassword)
			Dim result As Boolean
			Try
				Dim userPrincipal__1 As UserPrincipal = UserPrincipal.FindByIdentity(principalContext, Username)
				result = userPrincipal__1.IsAccountLockedOut()
			Catch ex As Exception
				Me.mvarsError = ex.Message
				result = True
			Finally
				principalContext.Dispose()
			End Try
			Return result
		End Function
		Public Function Isvalid(Username As String, Password As String) As Boolean
			Dim principalContext As New PrincipalContext(ContextType.Domain, Me.IP_ADDRESS, "CN=" & Username & ",OU=USERS,OU=Vulindlela3," & Me.DC, Me.ADSMasterUsername, Me.ADSMasterPassword)
			Dim result As Boolean
			Try
				UserPrincipal.FindByIdentity(principalContext, Username)
				result = True
				Me.mvarsError = ""
			Catch ex As Exception
				Me.mvarsError = ex.Message
				result = False
			Finally
				principalContext.Dispose()
			End Try
			Return result
		End Function
		Private Sub add2Application(AppID As String, AppShortName As String, rigntsEntry As String)
			Dim collection As New Collection()
			Dim item As New Collection()
			Dim item2 As New Collection()
			New Collection()
			Try
				collection.Add(item, "APPLICATION_RIGHTS", Nothing, Nothing)
				collection.Add(item2, "EXTENDED_DEPARTMENTS", Nothing, Nothing)
				collection.Add(New String() {AppID, AppShortName}, "APPLICATION_DETAILS", Nothing, Nothing)
				Me.mvarCol_AppRights.Add(collection, AppShortName, Nothing, Nothing)
			Catch generatedExceptionName As Exception
			Finally
				Dim sqlConnection As New SqlConnection()
				sqlConnection.ConnectionString = Me._cnConn
				sqlConnection.Open()
				Dim sqlCommand As New SqlCommand()
				sqlCommand.Connection = sqlConnection
				sqlCommand.CommandType = CommandType.Text
				Dim text As String = rigntsEntry.Remove(0, rigntsEntry.IndexOf(",") + 1)
				If rigntsEntry.ToUpper().Contains("APPLICATION_RIGHTS") Then
					sqlCommand.CommandText = "SELECT APPLICATION_ID, APPLICATION_SHORT_NAME FROM VIP_EXPANDED..APPLICATIONS WHERE APPLICATION_GROUP_ID=" & AppID & " ORDER BY APPLICATION_ID"
					Dim sqlDataReader As SqlDataReader = sqlCommand.ExecuteReader()
					If sqlDataReader.HasRows Then
						While sqlDataReader.Read()
							Me.mvarsRights = Me.mvarsRights & "," & sqlDataReader.GetValue(sqlDataReader.GetOrdinal("APPLICATION_ID")).ToString()
						End While
					End If
					Dim collection2 As Collection = DirectCast(DirectCast(Me.mvarCol_AppRights(AppShortName), Collection)("APPLICATION_RIGHTS"), Collection)
					collection2.Add(New String() {AppID, text.ToString().Replace("'", "")}, Nothing, Nothing, Nothing)
					sqlDataReader.Close()
				Else
					sqlCommand.CommandText = String.Concat(New Object() {"SELECT DEPT_ID as SQL_ID, DEPT_DESCRIPTION as Description, DEPT_SHORT_NAME as SOURCE_ID FROM VIP_EXPANDED..VIEW_GOVERNMENT_STRUCTURE WHERE FINYEAR=", Me.getFinYear(), " AND DEPT_SHORT_NAME IN(", text, "') ORDER BY SQL_ID"})
					sqlCommand.Connection = sqlConnection
					Dim sqlDataReader As SqlDataReader = sqlCommand.ExecuteReader()
					If sqlDataReader.HasRows Then
						While sqlDataReader.Read()
							Dim collection3 As Collection = DirectCast(DirectCast(Me.mvarCol_AppRights(AppShortName), Collection)("EXTENDED_DEPARTMENTS"), Collection)
							collection3.Add(New String() {sqlDataReader.GetValue(sqlDataReader.GetOrdinal("SQL_ID")).ToString(), sqlDataReader.GetValue(sqlDataReader.GetOrdinal("DESCRIPTION")).ToString(), sqlDataReader.GetValue(sqlDataReader.GetOrdinal("SOURCE_ID")).ToString()}, Nothing, Nothing, Nothing)
						End While
					End If
					sqlDataReader.Close()
				End If
			End Try
		End Sub
		Private Sub getDetails(sname As String)
			Dim sqlConnection As New SqlConnection(Me._cnConn)
			sqlConnection.Open()
			Dim sqlDataReader As SqlDataReader = New SqlCommand() With { _
				Key .CommandType = CommandType.Text, _
				Key .CommandText = "SELECT TOP 1 * FROM VIP_EXPANDED..VIEW_GOVERNMENT_STRUCTURE WHERE DEPT_SHORT_NAME='" & sname & "' ORDER BY FINYEAR DESC", _
				Key .Connection = sqlConnection _
			}.ExecuteReader()
			If sqlDataReader.HasRows Then
				While sqlDataReader.Read()
					Me.mvarDepartmentSName = sname
					Me.mvarDepartment = sqlDataReader.GetValue(sqlDataReader.GetOrdinal("DEPT_DESCRIPTION")).ToString()
					Me.mvarDepartmentID = sqlDataReader.GetValue(sqlDataReader.GetOrdinal("DEPT_ID")).ToString()
					Me.mvarDepartmentTypeID = sqlDataReader.GetValue(sqlDataReader.GetOrdinal("DEPT_LEVEL_ID")).ToString()
					Me.mvarProvinceSName = sqlDataReader.GetValue(sqlDataReader.GetOrdinal("NATPROV_SHORT_NAME")).ToString()
					Me.mvarProvince = sqlDataReader.GetValue(sqlDataReader.GetOrdinal("NATPROV_DESCRIPTION")).ToString()
					Me.mvarProvinceID = sqlDataReader.GetValue(sqlDataReader.GetOrdinal("NAT_PROV_ID")).ToString()
					Me.mvarProvinceTypeID = sqlDataReader.GetValue(sqlDataReader.GetOrdinal("PROVINCE_FLAG")).ToString()
				End While
			End If
			sqlDataReader.Close()
		End Sub
		Public Function getFinYear() As Integer
			If DateTime.Now.Month < 4 Then
				Return DateTime.Now.Year - 1
			End If
			Return DateTime.Now.Year
		End Function
		Public Function MustChangePassword(UserName As String, Password As String) As Boolean
			Dim searchRoot As New DirectoryEntry(String.Concat(New String() {"LDAP://", Me.IP_ADDRESS, "/CN=", UserName, ",OU=USERS,OU=Vulindlela3,", Me.DC}), Me.ADSMasterUsername, Me.ADSMasterPassword)
			Dim searchResult As SearchResult = New DirectorySearcher(searchRoot) With { _
				Key .Filter = "saMAccountName=" & UserName, _
				Key .PropertiesToLoad = {"UserFlags", "pwdLastSet"} _
			}.FindOne()
			If searchResult.Properties("pwdLastSet").Count = 0 Then
				Return False
			End If
			Dim a As String = searchResult.Properties("pwdLastSet")(0).ToString()
			Return a = "0"
		End Function
		Private Function getApplicationRights(RightNumber As Integer) As String
			Dim result As String
			Try
				Dim collection As New Collection()
				Dim collection2 As New Collection()
				collection = DirectCast(Me.mvarCol_AppRights(RightNumber), Collection)
				collection2 = DirectCast(collection("APPLICATION_RIGHTS"), Collection)
				Dim text As String = ""
				For Each array As String() In collection2
					For i As Integer = 0 To array.Length - 1
						text = text & array(i) & "|"
					Next
				Next
				If text.Length > 0 Then
					text = text.Substring(0, text.Length - 1)
				End If
				result = text
			Catch ex As Exception
				result = ex.Message
			End Try
			Return result
		End Function
		Private Function getExtendedDepartments(RightNumber As Integer) As String
			Dim result As String
			Try
				Dim collection As New Collection()
				Dim collection2 As New Collection()
				collection = DirectCast(Me.mvarCol_AppRights(RightNumber), Collection)
				collection2 = DirectCast(collection("EXTENDED_DEPARTMENTS"), Collection)
				Dim text As String = ""
				For Each array As String() In collection2
					For i As Integer = 0 To array.Length - 1
						text = text & array(i) & "|"
					Next
				Next
				If text.Length > 0 Then
					text = text.Substring(0, text.Length - 1)
				End If
				result = text
			Catch ex As Exception
				result = ex.Message
			End Try
			Return result
		End Function
		Private Function getApplicationDetails(RightNumber As Integer) As String
			Dim result As String
			Try
				Dim collection As New Collection()
				collection = DirectCast(Me.mvarCol_AppRights(RightNumber), Collection)
				Dim array As String() = DirectCast(collection("APPLICATION_DETAILS"), String())
				Dim text As String = ""
				For i As Integer = 0 To array.Length - 1
					text = text & array(i) & "|"
				Next
				If text.Length > 0 Then
					text = text.Substring(0, text.Length - 1)
				End If
				result = text
			Catch ex As Exception
				result = ex.Message
			End Try
			Return result
		End Function
		Public Function getSessionVariables() As String
			Me.Session_USER_RIGHTS.Add("GFS_USER_TYPE", "0")
			Me.Session_USER_RIGHTS.Add("HR_USER_TYPE", "0")
			Me.Session_USER_RIGHTS.Add("FINANCIALS_USER_TYPE", "0")
			Me.Session_USER_RIGHTS.Add("LOGIS_USER_TYPE", "0")
			Me.Session_USER_RIGHTS.Add("DPSA_USER_TYPE", "0")
			Me.Session_USER_RIGHTS.Add("AUDITGENL_USER_TYPE", "0")
			Me.Session_USER_RIGHTS.Add("GENERAL_REPORTING_USER_TYPE", "0")
			Me.Session_USER_RIGHTS.Add("PERSALPDF_USER_TYPE", "0")
			Me.Session_USER_RIGHTS.Add("HR_OVERSIGHT_USER_TYPE", "0")
			For Each collection As Collection In Me.mvarCol_AppRights
				'Console.Write("Stop Hier");
				If DirectCast(collection("APPLICATION_DETAILS"), String())(1) = "FINANCIALS" Or DirectCast(collection("APPLICATION_DETAILS"), String())(1) = "HR" Or DirectCast(collection("APPLICATION_DETAILS"), String())(1) = "AUDITGENL" Or DirectCast(collection("APPLICATION_DETAILS"), String())(1) = "GENERAL_REPORTING" Or DirectCast(collection("APPLICATION_DETAILS"), String())(1) = "PERSALPDF" Or DirectCast(collection("APPLICATION_DETAILS"), String())(1) = "HR_OVERSIGHT" Or DirectCast(collection("APPLICATION_DETAILS"), String())(1) = "LOGIS" Then
					Me.ExtractAppRights(collection, DirectCast(collection("APPLICATION_DETAILS"), String())(1))
				Else
					If DirectCast(collection("APPLICATION_DETAILS"), String())(1) = "GFS" Then
						Me.Session_USER_RIGHTS("GFS_USER_TYPE") = "1"
					Else
						If DirectCast(collection("APPLICATION_DETAILS"), String())(1) = "DPSA" Then
							Me.Session_USER_RIGHTS("DPSA_USER_TYPE") = "1"
						End If
					End If
				End If
			Next
			Dim text As String = ""
			For Each current As KeyValuePair(Of String, String) In Me.Session_USER_RIGHTS
				text = String.Concat(New String() {text, current.Key, "|", current.Value, "|"})
			Next
			If text.Length > 0 Then
				text = text.Substring(0, text.Length - 1)
			End If
			Return text
		End Function
		Private Sub ExtractAppRights(DA_APP As Collection, appCode As String)
			New Collection()
			For Each array As String() In DirectCast(DA_APP("APPLICATION_RIGHTS"), Collection)
				Dim key As String
				Select Case InlineAssignHelper(key, array(1).ToString())
					Case ""
						Me.Session_USER_RIGHTS(appCode & "_USER_TYPE") = "0"
						Exit Select

					Case "CON"
						Me.Session_USER_RIGHTS(appCode & "_USER_TYPE") = "1"
						Exit Select

					Case "NAT"
						Me.Session_USER_RIGHTS(appCode & "_USER_TYPE") = "2"
						Exit Select

					Case "PROV"
						Me.Session_USER_RIGHTS(appCode & "_USER_TYPE") = "3"
						Exit Select

					Case "OWN_PROV"
						If Me.mvarProvinceSName = "NAT" Then
							Me.Session_USER_RIGHTS(appCode & "_USER_TYPE") = "2"
						Else
							Me.Session_USER_RIGHTS(appCode & "_USER_TYPE") = "4"
						End If
						Exit Select

					Case "OWN_DEPT"
						Me.Session_USER_RIGHTS(appCode & "_USER_TYPE") = "5"
						Exit Select

					Case "ASSIGN_DEPT"
						Me.Session_USER_RIGHTS(appCode & "_USER_TYPE") = "6"
						Me.Session_USER_RIGHTS.Add(appCode & "_EXTEND_DEPTS", "")
						For Each array2 As String() In DirectCast(DA_APP("EXTENDED_DEPARTMENTS"), Collection)
							Me.Session_USER_RIGHTS(appCode & "_EXTEND_DEPTS") = "'" & array2(2) & "'," & Me.Session_USER_RIGHTS(appCode & "_EXTEND_DEPTS")
						Next
						Me.Session_USER_RIGHTS(appCode & "_EXTEND_DICT") = ""
						If Me.Session_USER_RIGHTS(appCode & "_EXTEND_DEPTS").Length > 1 Then
							Me.Session_USER_RIGHTS(appCode & "_EXTEND_DEPTS") = Me.Session_USER_RIGHTS(appCode & "_EXTEND_DEPTS").Substring(0, Me.Session_USER_RIGHTS(appCode & "_EXTEND_DEPTS").Length - 1)
						End If
						Exit Select
				End Select
			Next
		End Sub
		Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, value As T) As T
			target = value
			Return value
		End Function
	End Class
End Namespace
