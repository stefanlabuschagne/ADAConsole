' Daar is 'n probleem met die CREATE button want DIT wil nie werk nie. 
' Somehow kry RONEL 'n probleem

Imports System
Imports System.Text
Imports System.Collections.Generic
Imports ActiveDs
Imports System.IO
Imports System.Web
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Windows.Forms
Imports System.Drawing.Printing
Imports System.DirectoryServices
Imports System.DirectoryServices.AccountManagement
Imports Microsoft.VisualBasic
Imports System.Reflection

Module modADS
    Public populated_from_ad As Boolean = False
    Private Const ADS_SECURE_AUTHENTICATION As Long = &H0
    Public svrEnvironment As Integer ' svrEnvironment = 1 = PRD
    Public Cleartxt As Boolean = True
    Public Tnumber As String = ""
    Dim dso As Object

    'Public cr As New ClsCrypto

    Public Sub Do_AddUser2UserGroups(ByVal _persalnumber As String, ByVal colGroups As Collection)
        Dim i As Integer
        Dim PersalNumber As String = Get_ValidUsername(_persalnumber)
        For i = 1 To colGroups.Count
            Try
                Do_AddToGroup(PersalNumber, colGroups(i).ToString, ou_context.USERS)
            Catch ex As Exception
            End Try
        Next i
    End Sub

    Public Enum domain
        vulprd = 1
        vulqa = 2
    End Enum

    Public Enum ou_context
        APPLICATION_RIGHTS = 1
        GOVERNMENT_STRUCTURE = 2
        USERS = 3
    End Enum

    Public Function Get_App_OU_Context() As String
        Get_App_OU_Context = ""
        If InStr(frmEnvironment.ActiveMdiChild.Text, "QA") > 0 Then
            Get_App_OU_Context = "OU=APPLICATION_RIGHTS," & My.Settings.VulindlelaContextQA.Trim
        ElseIf InStr(frmEnvironment.ActiveMdiChild.Text, "PRD") > 0 Then
            Get_App_OU_Context = "OU=APPLICATION_RIGHTS," & My.Settings.VulindlelaContextPRD.Trim
        End If
        Return (Get_App_OU_Context)
    End Function

    Public Function Get_Govt_OU_Context() As String
        Get_Govt_OU_Context = ""
        If InStr(frmEnvironment.ActiveMdiChild.Text, "QA") > 0 Then
            Get_Govt_OU_Context = "OU=GOVERNMENT_STRUCTURE," & My.Settings.VulindlelaContextQA.Trim
        ElseIf InStr(frmEnvironment.ActiveMdiChild.Text, "PRD") > 0 Then
            Get_Govt_OU_Context = "OU=GOVERNMENT_STRUCTURE," & My.Settings.VulindlelaContextPRD.Trim
        End If
        Return Get_Govt_OU_Context
    End Function

    Public Function Get_Users_OU_Context() As String
        Get_Users_OU_Context = ""
        If InStr(frmEnvironment.ActiveMdiChild.Text, "QA") > 0 Then
            Get_Users_OU_Context = "OU=USERS," & My.Settings.VulindlelaContextQA.Trim
        ElseIf InStr(frmEnvironment.ActiveMdiChild.Text, "PRD") > 0 Then
            Get_Users_OU_Context = "OU=USERS," & My.Settings.VulindlelaContextPRD.Trim
        End If
        Return Get_Users_OU_Context
    End Function

    Public Function Get_Complete_CN_OU_Context(ByVal groupname As String, ByVal cntxt As ou_context) As String
        Dim Complete_CN_OU_Context As String = ""
        If cntxt = ou_context.APPLICATION_RIGHTS Then
            Complete_CN_OU_Context = "CN=" & groupname.Trim & "," & Get_App_OU_Context().Trim
        ElseIf cntxt = ou_context.GOVERNMENT_STRUCTURE Then
            Complete_CN_OU_Context = "CN=" & groupname.Trim & "," & Get_Govt_OU_Context().Trim
        ElseIf cntxt = ou_context.USERS Then
            Complete_CN_OU_Context = "CN=" & groupname.Trim & "," & Get_Users_OU_Context().Trim
        End If
        Return Complete_CN_OU_Context
    End Function

    Public Function Get_DC_String() As String
        Get_DC_String = ""
        If InStr(frmEnvironment.ActiveMdiChild.Text, "QA") > 0 Then
            Get_DC_String = My.Settings.AD_DC_QA
        ElseIf InStr(frmEnvironment.ActiveMdiChild.Text, "PRD") > 0 Then
            Get_DC_String = My.Settings.AD_DC_PRD
        End If
        Return Get_DC_String
    End Function

    Public Function Get_ValidUsername(ByVal _persalnumber As String) As String
        Get_ValidUsername = ""
        If _persalnumber Is Nothing Then
            MsgBox("Please enter a valid persal number", MsgBoxStyle.OkOnly, "System MEssage")
        Else
            If Left(_persalnumber.ToString.ToUpper.Trim, 1) <> "T" Then
                If Left(_persalnumber.ToString.ToUpper.Trim, 1) = "P" Then
                    Get_ValidUsername = _persalnumber.ToString.ToUpper.Trim
                Else
                    Get_ValidUsername = "P" & _persalnumber.ToString.ToUpper.Trim
                End If
            Else
                Get_ValidUsername = _persalnumber.ToString.ToUpper.Trim
            End If
        End If
        Return Get_ValidUsername
    End Function

    Public Sub Do_Expire_Account_In_X_Days(ByVal days As Integer, ByVal _persalnumber As String)
        Dim PersalNumber As String = Get_ValidUsername(_persalnumber)
        Dim context As New PrincipalContext(ContextType.Domain, _
                                            Get_IPaddress_String(), _
                                            "CN=" & PersalNumber & _
                                            "," & Get_LDAP_String(), _
                                            Get_Master_User(), _
                                            Get_Master_Pwd())
        Dim user As UserPrincipal = UserPrincipal.FindByIdentity(context, PersalNumber)
        user.AccountExpirationDate = DateTime.Today.AddDays(days)

        'user.
        '  If (user.AccountExpirationDate < DateTime.Now) Then
        '   MessageBox.Show("Selected date has already passed")
        ' Else
            user.Save()
            '  End If


            If frmEnvironment.ChildFormPRD.Visible Then
                frmMain.ADCONSOLELOGTableAdapter.InsertIntoADAdminConsoleLog2(frmEnvironment.ChildFormPRD.tsLoggedOnUser.Text, _
                                                                 Get_ValidPersalNumber(PersalNumber), _
                                                                 "Do_Expire_Account_In_" & CStr(days) & "_Days", False)
                frmEnvironment.ChildFormPRD.Refresh_Log()

            Else
                frmMain.ADCONSOLELOGTableAdapter.InsertIntoADAdminConsoleLog2(frmEnvironment.childformQA.tsLoggedOnUser.Text, _
                                                                 Get_ValidPersalNumber(PersalNumber), _
                                                                 "Do_Expire_Account_In_" & CStr(days) & "_Days", False)
                frmEnvironment.childformQA.Refresh_Log()
            End If

    End Sub

    Public Sub Do_ExpirePasswordNow(ByVal _persalnumber As String)
        Dim PersalNumber As String = Get_ValidUsername(_persalnumber)
        Dim context As New PrincipalContext(ContextType.Domain, _
                                            Get_IPaddress_String(), _
                                            "CN=" & PersalNumber & _
                                            "," & Get_LDAP_String(), _
                                            Get_Master_User(), _
                                            Get_Master_Pwd())

        Dim user As UserPrincipal = UserPrincipal.FindByIdentity(context, PersalNumber)
        user.PasswordNeverExpires = False
        user.ExpirePasswordNow()
        user.Save()

        If frmEnvironment.ChildFormPRD.Visible Then
            frmEnvironment.ChildFormPRD.ADCONSOLELOGTableAdapter.InsertIntoADAdminConsoleLog2( _
                    frmEnvironment.ChildFormPRD.tsLabelVulname.Text, Get_ValidPersalNumber( _
                    frmEnvironment.ChildFormPRD.txtPersalNumber.Text.Trim), "Do_ExpirePasswordNow", False)
            frmEnvironment.ChildFormPRD.Refresh_Log()
        Else
            frmMain.ADCONSOLELOGTableAdapter.InsertIntoADAdminConsoleLog2( _
                    frmEnvironment.childformQA.tsLabelVulname.Text, Get_ValidPersalNumber( _
                    frmEnvironment.childformQA.txtPersalNumber.Text.Trim), "Do_ExpirePasswordNow", False)
            frmEnvironment.childformQA.Refresh_Log()
        End If

    End Sub

    Public Function Do_ResetPassword(ByVal _persalnumber As String) As Boolean

        Dim PersalNumber As String = Get_ValidUsername(_persalnumber)
        Dim context As New PrincipalContext(ContextType.Domain, _
                                            Get_IPaddress_String(), _
                                            "CN=" & PersalNumber & _
                                            "," & Get_LDAP_String(), _
                                            Get_Master_User(), _
                                            Get_Master_Pwd())
        Try
            Dim user As UserPrincipal = UserPrincipal.FindByIdentity(context, PersalNumber)
            user.PasswordNeverExpires = True
            user.SetPassword("password")
            user.Save()

            '############### JOHANNES VERMEULEN

            If frmEnvironment.ChildFormPRD.Visible Then
                frmEnvironment.ChildFormPRD.ADCONSOLELOGTableAdapter.InsertIntoADAdminConsoleLog2( _
                        frmEnvironment.ChildFormPRD.tsLabelVulname.Text, Get_ValidPersalNumber( _
                        frmEnvironment.ChildFormPRD.txtPersalNumber.Text.Trim), "Do_ResetPassword", False)
                frmEnvironment.ChildFormPRD.Refresh_Log()
            Else
                frmMain.ADCONSOLELOGTableAdapter.InsertIntoADAdminConsoleLog2( _
                        frmEnvironment.childformQA.tsLabelVulname.Text, Get_ValidPersalNumber( _
                        frmEnvironment.childformQA.txtPersalNumber.Text.Trim), "Do_ResetPassword", False)
                frmEnvironment.childformQA.Refresh_Log()
            End If
            Return True
        Catch ex As Exception

            Return False
        End Try

    End Function

    Public Sub Do_AccountExpirationDate(ByVal _persalnumber As String, ByVal strDate As String)
        Dim PersalNumber As String = Get_ValidUsername(_persalnumber)
        Dim context As New PrincipalContext(ContextType.Domain, _
                                            Get_IPaddress_String(), _
                                            "CN=" & PersalNumber & _
                                            "," & Get_LDAP_String(), _
                                            Get_Master_User(), _
                                            Get_Master_Pwd())

        Dim userPrincipal As UserPrincipal = userPrincipal.FindByIdentity(context, PersalNumber)
        'userPrincipal.RefreshExpiredPassword
        userPrincipal.AccountExpirationDate = CDate(strDate)
        userPrincipal.Save()
        If frmEnvironment.ChildFormPRD.Visible Then
            frmMain.ADCONSOLELOGTableAdapter.InsertIntoADAdminConsoleLog2(frmEnvironment.ChildFormPRD.tsLoggedOnUser.Text, _
                                                             Get_ValidPersalNumber(PersalNumber), _
                                                             "Do_AccountExpirationDate to : " & _
                                                                     strDate.Trim, False)
            frmEnvironment.ChildFormPRD.Refresh_Log()
        Else
            frmMain.ADCONSOLELOGTableAdapter.InsertIntoADAdminConsoleLog2(frmEnvironment.childformQA.tsLoggedOnUser.Text, _
                                                             Get_ValidPersalNumber(PersalNumber), _
                                                             "Do_AccountExpirationDate to : " & _
                                                                     strDate.Trim, False)
            frmEnvironment.childformQA.Refresh_Log()
        End If

    End Sub

    Public Function Get_IsAccountEnabled(ByVal _persalnumber As String) As Boolean
        Dim PersalNumber As String = Get_ValidUsername(_persalnumber)
        Dim context As New PrincipalContext(ContextType.Domain, _
                                            Get_IPaddress_String(), _
                                            "CN=" & PersalNumber & _
                                            "," & Get_LDAP_String(), _
                                            Get_Master_User(), _
                                            Get_Master_Pwd())

        Dim userPrincipal As UserPrincipal = userPrincipal.FindByIdentity(context, PersalNumber)
        Get_IsAccountEnabled = CType(userPrincipal.Enabled, Boolean)

    End Function

    Public Function Get_IsAccountDisabled2(ByVal _persalnumber As String) As Boolean
        Get_IsAccountDisabled2 = False
        Dim strError As String
        Dim PersalNumber As String = Get_ValidUsername(_persalnumber)
        Try
            Dim child As New System.DirectoryServices.DirectoryEntry("LDAP://" & _
                                                   Get_IPaddress_String() & "/" & _
                                                   Get_LDAP_String(), _
                                                   Get_Master_User(), _
                                                   Get_Master_Pwd())

            Dim searcher As New DirectorySearcher(child)
            Dim result As SearchResult
            Dim userEntry As DirectoryEntry
            Dim s As System.Collections.ICollection
            Dim col As New Microsoft.VisualBasic.Collection
            Dim i As Integer
            Dim ar(34) As String
            searcher.Filter = "(SAMAccountName=" & PersalNumber & ")"
            searcher.CacheResults = False
            result = searcher.FindOne
            userEntry = result.GetDirectoryEntry
            s = userEntry.Properties.PropertyNames
            For i = 0 To s.Count - 1
                ar(i) = s(i).ToString
            Next
            Get_IsAccountDisabled2 = CType(userEntry.Properties("AccountDisabled")(0), Boolean)
        Catch ex As Exception
            strError = ex.ToString
        End Try
        Return Get_IsAccountDisabled2
    End Function

    Public Function Get_badPwdCount(ByVal _persalnumber As String) As Boolean
        Dim strError As String
        Dim Get_IsAccountLocked2 As Boolean
        Dim PersalNumber As String = Get_ValidUsername(_persalnumber)
        Try
            Dim child As New System.DirectoryServices.DirectoryEntry("LDAP://" & _
                                                   Get_IPaddress_String() & "/" & _
                                                   Get_LDAP_String(), _
                                                   Get_Master_User(), _
                                                   Get_Master_Pwd())
            Dim searcher As New DirectorySearcher(child)
            Dim result As SearchResult
            Dim userEntry As DirectoryEntry
            Dim s As System.Collections.ICollection
            Dim col As New Microsoft.VisualBasic.Collection
            Dim i As Integer
            Dim ar(34) As String
            searcher.Filter = "(SAMAccountName=" & PersalNumber & ")"
            searcher.CacheResults = False
            result = searcher.FindOne
            userEntry = result.GetDirectoryEntry
            s = userEntry.Properties.PropertyNames
            For i = 0 To s.Count - 1
                ar(i) = s(i).ToString
            Next
            If CType(userEntry.Properties("badPwdCount").Value, Integer) >= 1 Then
                Get_IsAccountLocked2 = True
            Else
                Get_IsAccountLocked2 = False
            End If
        Catch ex As Exception
            strError = ex.ToString
        End Try
        Return Get_IsAccountLocked2
    End Function

    Public Sub Do_Unlockaccount(ByVal _persalnumber As String)
        Dim PersalNumber As String = Get_ValidUsername(_persalnumber)
        Dim context As New PrincipalContext(ContextType.Domain, _
                                            Get_IPaddress_String(), _
                                            "CN=" & PersalNumber & _
                                            "," & Get_LDAP_String(), _
                                            Get_Master_User(), _
                                            Get_Master_Pwd())

        Dim userPrincipal As UserPrincipal = userPrincipal.FindByIdentity(context, PersalNumber)

        userPrincipal.UnlockAccount()
        userPrincipal.Save()

        If frmEnvironment.ChildFormPRD.Visible Then
            frmMain.ADCONSOLELOGTableAdapter.InsertIntoADAdminConsoleLog2(frmEnvironment.ChildFormPRD.tsLoggedOnUser.Text, _
                                                             Get_ValidPersalNumber(PersalNumber), _
                                                             "Do_Unlockaccount", False)
            frmEnvironment.ChildFormPRD.Refresh_Log()
        Else
            frmMain.ADCONSOLELOGTableAdapter.InsertIntoADAdminConsoleLog2(frmEnvironment.childformQA.tsLoggedOnUser.Text, _
                                                             Get_ValidPersalNumber(PersalNumber), _
                                                             "Do_Unlockaccount", False)
            frmEnvironment.childformQA.Refresh_Log()
        End If

    End Sub

    Public Sub Do_EnableAccount(ByVal _persalnumber As String)
        If String.IsNullOrEmpty(_persalnumber) Then
            MsgBox("No account number to enable", MsgBoxStyle.Critical, "System Message")
            Exit Sub
        End If
        Dim PersalNumber As String = Get_ValidUsername(_persalnumber)
        Dim context As New PrincipalContext(ContextType.Domain, _
                                            Get_IPaddress_String(), _
                                            "CN=" & PersalNumber & _
                                            "," & Get_LDAP_String(), _
                                            Get_Master_User(), _
                                            Get_Master_Pwd())
        Dim userPrincipal As UserPrincipal = userPrincipal.FindByIdentity(context, PersalNumber)

        userPrincipal.Enabled = True
        userPrincipal.Save()

        If frmEnvironment.ChildFormPRD.Visible Then
            frmEnvironment.ChildFormPRD.ADCONSOLELOGTableAdapter.InsertIntoADAdminConsoleLog2( _
                    frmEnvironment.ChildFormPRD.tsLabelVulname.Text, Get_ValidPersalNumber( _
                    frmEnvironment.ChildFormPRD.txtPersalNumber.Text.Trim), "Do_EnableAccount", False)
            frmEnvironment.ChildFormPRD.Refresh_Log()
        Else
            frmEnvironment.childformQA.ADCONSOLELOGTableAdapter.InsertIntoADAdminConsoleLog2( _
                    frmEnvironment.childformQA.tsLabelVulname.Text, Get_ValidPersalNumber( _
                    frmEnvironment.childformQA.txtPersalNumber.Text.Trim), "Do_EnableAccount", False)
            frmEnvironment.childformQA.Refresh_Log()
        End If

    End Sub

    Public Sub Do_DisableAccount(ByVal _persalnumber As String)
        If String.IsNullOrEmpty(_persalnumber) Then
            MsgBox("No account number to disable", MsgBoxStyle.Critical, "System Message")
            Exit Sub
        End If
        Dim PersalNumber As String = Get_ValidUsername(_persalnumber)
        Dim context As New PrincipalContext(ContextType.Domain, _
                                            Get_IPaddress_String(), _
                                            "CN=" & PersalNumber & _
                                            "," & Get_LDAP_String(), _
                                            Get_Master_User(), _
                                            Get_Master_Pwd())

        Dim userPrincipal As UserPrincipal = userPrincipal.FindByIdentity(context, PersalNumber)

        userPrincipal.Enabled = False
        userPrincipal.Save()

        If frmEnvironment.ChildFormPRD.Visible Then
            frmEnvironment.ChildFormPRD.ADCONSOLELOGTableAdapter.InsertIntoADAdminConsoleLog2( _
                    frmEnvironment.ChildFormPRD.tsLabelVulname.Text, Get_ValidPersalNumber( _
                    frmEnvironment.ChildFormPRD.txtPersalNumber.Text.Trim), "Do_DisableAccount", False)
            frmEnvironment.ChildFormPRD.Refresh_Log()
        Else
            frmEnvironment.childformQA.ADCONSOLELOGTableAdapter.InsertIntoADAdminConsoleLog2( _
                    frmEnvironment.childformQA.tsLabelVulname.Text, Get_ValidPersalNumber( _
                    frmEnvironment.childformQA.txtPersalNumber.Text.Trim), "Do_DisableAccount", False)
            frmEnvironment.childformQA.Refresh_Log()
        End If

    End Sub

    Public Function Get_Department(ByVal _persalnumber As String) As String
        Dim dsDirectoryEntry As New DirectoryEntry("LDAP://" & _
                                                   Get_IPaddress_String() & "/" & _
                                                   Get_LDAP_String(), _
                                                   Get_Master_User(), _
                                                   Get_Master_Pwd())
        Dim dsSearcher As New DirectorySearcher(dsDirectoryEntry)
        Dim department As String

        dsSearcher.Filter = "saMAccountName=" & Get_ValidUsername(_persalnumber)
        dsSearcher.PropertiesToLoad.Add("department")
        Dim dsResult As SearchResult = dsSearcher.FindOne
        Try
            department = CType(dsResult.Properties("department")(0), String) & ""
            Get_Department = department
            Return Get_Department
        Catch ex As Exception
            ' Please no msgboxes here
            Return ""
        End Try
    End Function

    Public Function Get_LDAP_String() As String
        Get_LDAP_String = ""
        Try
            If InStr(frmEnvironment.ActiveMdiChild.Text, "QA") > 0 Then
                Get_LDAP_String = My.Settings.AD_USERS_QA
            End If
        Catch ex As Exception
            Get_LDAP_String = ""
        End Try

        Try
            If InStr(frmEnvironment.ActiveMdiChild.Text, "PRD") > 0 Then
                Get_LDAP_String = My.Settings.AD_USERS_PRD
            End If
        Catch ex As Exception
            Get_LDAP_String = ""
        End Try
    End Function

    Public Function Get_IPaddress_String() As String
        Get_IPaddress_String = ""
        Try
            If InStr(frmEnvironment.ActiveMdiChild.Text, "QA") > 0 Then
                Get_IPaddress_String = My.Settings.IP_ADDRESS_QA
            End If
        Catch ex As Exception
            Get_IPaddress_String = ""
        End Try
        Try
            If InStr(frmEnvironment.ActiveMdiChild.Text, "PRD") > 0 Then
                Get_IPaddress_String = My.Settings.IP_ADDRESS_PRD
            End If
        Catch ex As Exception
            Get_IPaddress_String = ""
        End Try
        Return Get_IPaddress_String
    End Function

    Public Function Get_Master_User() As String
        Get_Master_User = ""
        Try
            If InStr(frmEnvironment.ActiveMdiChild.Text, "QA") > 0 Then
                Get_Master_User = My.Settings.ADSMasterUsername_QA
            End If
        Catch ex As Exception
            Get_Master_User = ""
        End Try

        Try
            If InStr(frmEnvironment.ActiveMdiChild.Text, "PRD") > 0 Then
                Get_Master_User = My.Settings.ADSMasterUsername_PRD
            End If
        Catch ex As Exception
            Get_Master_User = ""
        End Try
    End Function

    Public Function Get_Master_Pwd() As String
        Get_Master_Pwd = ""
        Try
            Dim enc As New ClsCrypto
            If InStr(frmEnvironment.ActiveMdiChild.Text, "QA") > 0 Then
                Get_Master_Pwd = enc.Dekodeer128(My.Settings.ADSMasterPassword_QA.ToString)
            End If
            enc = Nothing
        Catch ex1 As Exception
            Get_Master_Pwd = ""
        End Try
        Try
            Dim enc As New ClsCrypto
            If InStr(frmEnvironment.ActiveMdiChild.Text, "PRD") > 0 Then
                Get_Master_Pwd = enc.Dekodeer128(My.Settings.ADSMasterPassword_PRD.ToString)
            End If
            enc = Nothing
        Catch ex2 As Exception
            Get_Master_Pwd = ""
        End Try
    End Function

    Public Function Get_LastLogon(ByVal _persalnumber As String) As Date
        Dim PersalNumber As String = Get_ValidUsername(_persalnumber)
        Dim context As New PrincipalContext(ContextType.Domain, _
                                            Get_IPaddress_String(), _
                                            "CN=" & PersalNumber & _
                                            "," & Get_LDAP_String(), _
                                            Get_Master_User(), _
                                            Get_Master_Pwd())

        Dim userPrincipal As UserPrincipal = userPrincipal.FindByIdentity(context, PersalNumber)
        On Error Resume Next
        Get_LastLogon = userPrincipal.LastLogon.Value
    End Function

    Public Sub Do_SaveDepartment(ByVal _persalnumber As String, _
                                 ByVal department As String, _
                                 ByVal Company As String, _
                                 ByVal facsimileTelephoneNumber As String, _
                                 ByVal TelephoneNumber As String, _
                                 ByVal mobile As String)

        Dim persalnumber As String = Get_ValidUsername(_persalnumber)
        Dim dsDirectoryEntry As New DirectoryEntry("LDAP://" & _
                                                   Get_IPaddress_String() & "/" & _
                                                   Get_LDAP_String(), _
                                                   Get_Master_User(), _
                                                   Get_Master_Pwd())
        Dim user As DirectoryEntry
        Dim dsSearcher As New DirectorySearcher(dsDirectoryEntry)
        dsSearcher.Filter = "saMAccountName=" & persalnumber

        Dim dsResult As SearchResult = dsSearcher.FindOne
        user = dsResult.GetDirectoryEntry

        If department.Length = 0 Then : department = "None" : End If
        If user.Properties("department").Count = 0 Then : user.Properties("department").Add(department & "")
        Else : user.Properties("department").Item(0) = department & "" : End If
        user.CommitChanges()

        If mobile.Length = 0 Then : mobile = "None" : End If
        If user.Properties("mobile").Count = 0 Then : user.Properties("mobile").Add(mobile & "")
        Else : user.Properties("mobile").Item(0) = mobile & "" : End If
        user.CommitChanges()

        If TelephoneNumber.Length = 0 Then : TelephoneNumber = "None" : End If
        If user.Properties("telephoneNumber").Count = 0 Then : user.Properties("telephoneNumber").Add(TelephoneNumber & "")
        Else : user.Properties("telephoneNumber").Item(0) = TelephoneNumber & "" : End If
        user.CommitChanges()

        If frmEnvironment.ChildFormPRD.Visible Then
            frmEnvironment.ChildFormPRD.ADCONSOLELOGTableAdapter.InsertIntoADAdminConsoleLog2( _
                    frmEnvironment.ChildFormPRD.tsLabelVulname.Text, Get_ValidPersalNumber( _
                    frmEnvironment.ChildFormPRD.txtPersalNumber.Text.Trim), "Do_SaveDepartment", False)
            frmEnvironment.ChildFormPRD.Refresh_Log()
        Else
            frmEnvironment.childformQA.ADCONSOLELOGTableAdapter.InsertIntoADAdminConsoleLog2( _
                    frmEnvironment.childformQA.tsLabelVulname.Text, Get_ValidPersalNumber( _
                    frmEnvironment.childformQA.txtPersalNumber.Text.Trim), "Do_SaveDepartment", False)
            frmEnvironment.childformQA.Refresh_Log()
        End If

    End Sub

    Public Sub Do_DeleteUser(ByVal _persalnumber As String)

        Dim persalnumber As String = Get_ValidUsername(_persalnumber)
        Dim context As New PrincipalContext(ContextType.Domain, _
                                            Get_IPaddress_String(), _
                                            "CN=" & persalnumber & _
                                            "," & Get_LDAP_String(), _
                                            Get_Master_User(), _
                                            Get_Master_Pwd())

        Dim user As UserPrincipal = UserPrincipal.FindByIdentity(context, persalnumber)
        user.Delete()

        If frmEnvironment.ChildFormPRD.Visible Then
            frmEnvironment.ChildFormPRD.ADCONSOLELOGTableAdapter.InsertIntoADAdminConsoleLog2( _
                    frmEnvironment.ChildFormPRD.tsLabelVulname.Text, Get_ValidPersalNumber( _
                    frmEnvironment.ChildFormPRD.txtPersalNumber.Text.Trim), "Do_DeleteProfile", False)
            frmEnvironment.ChildFormPRD.Refresh_Log()
        Else
            frmEnvironment.childformQA.ADCONSOLELOGTableAdapter.InsertIntoADAdminConsoleLog2( _
                    frmEnvironment.childformQA.tsLabelVulname.Text, Get_ValidPersalNumber( _
                    frmEnvironment.childformQA.txtPersalNumber.Text.Trim), "Do_DeleteProfile", False)
            frmEnvironment.childformQA.Refresh_Log()
        End If

    End Sub

    Public Sub Do_CreateUser( _
               ByVal PersalNumber As String, _
               ByVal FirstName As String, _
               ByVal LastName As String, _
               ByVal EMail As String, _
               ByVal shortcode As String, _
               ByVal phonenumber As String, _
               ByVal mobile As String, _
               ByVal Rank As String)

        Dim context As New PrincipalContext(ContextType.Domain, _
                                                    Get_IPaddress_String(), _
                                                    Get_LDAP_String(), _
                                                    Get_Master_User(), _
                                                    Get_Master_Pwd())

        Dim user As New UserPrincipal(context, PersalNumber, "password", True)

        Dim de As New DirectoryServices.DirectoryEntry
        Dim entry As New DirectoryServices.DirectorySearcher(de, "CN=" & PersalNumber & "," & Get_LDAP_String())
        ' entry.
        user.GivenName = FirstName & ""
        user.Surname = LastName & ""
        user.EmailAddress = EMail & ""
        user.Description = shortcode & "" & " - " & FirstName & "" & " " & LastName & "" & "(" & Rank & "" & ")"
        user.DisplayName = FirstName & "" & " " & LastName & ""
        user.PasswordNeverExpires = True
        user.VoiceTelephoneNumber = phonenumber & ""
        user.Save()
        Do_SaveDepartment(PersalNumber & "", shortcode & "", "", "", phonenumber & "", mobile & "")


        Dim ta_newuser As Global.ADAdminDotNet.dsADSTableAdapters.VIP_USERS_NewUsersTableAdapter
        ta_newuser = New ADAdminDotNet.dsADSTableAdapters.VIP_USERS_NewUsersTableAdapter
       
        Dim s As String
        Dim dt As New DataTable
        Dim DEPTCODE As String

        'Dim newUserID As String = ""
        'If PersalNumber = "" Then
        'Else
        '    dt = ta_newuser.GetDataByPresalNr(PersalNumber)
        '    If dt.Rows.Count > 0 Then
        '        newUserID = dt.Rows(0).Item("ID").ToString.Trim
        '    Else

        '    End If

        'End If

        ' MarkAsDoneNewuser(newUserID)
        If frmEnvironment.ChildFormPRD.Visible Then
            ' frmEnvironment.ChildFormPRD.VIP_USERS_NewUsersTableAdapter.UpdateDoneToCompleted(PersalNumber.Trim)
            frmEnvironment.ChildFormPRD.ADCONSOLELOGTableAdapter.InsertIntoADAdminConsoleLog2( _
                    frmEnvironment.ChildFormPRD.tsLabelVulname.Text, Get_ValidPersalNumber( _
                    frmEnvironment.ChildFormPRD.txtPersalNumber.Text.Trim), "Do_CreateUser", False)
            frmEnvironment.ChildFormPRD.Refresh_Log()
        Else
            frmEnvironment.childformQA.ADCONSOLELOGTableAdapter.InsertIntoADAdminConsoleLog2( _
                    frmEnvironment.childformQA.tsLabelVulname.Text, Get_ValidPersalNumber( _
                    frmEnvironment.childformQA.txtPersalNumber.Text.Trim), "Do_CreateUser", False)
            frmEnvironment.childformQA.Refresh_Log()
        End If


    End Sub

    Public Sub Do_UpdateUser( _
               ByVal _PersalNumber As String, _
               ByVal FirstName As String, _
               ByVal LastName As String, _
               ByVal EMail As String, _
               ByVal shortcode As String, _
               ByVal phonenumber As String, _
               ByVal Rank As String, _
               ByVal company As String, _
               ByVal fax As String, _
               ByVal tel As String, _
               ByVal mobile As String)

        Dim PersalNumber As String = Get_ValidUsername(_PersalNumber)

        Dim context As New PrincipalContext(ContextType.Domain, _
                                            Get_IPaddress_String(), _
                                            "CN=" & PersalNumber & _
                                            "," & Get_LDAP_String(), _
                                            Get_Master_User(), _
                                            Get_Master_Pwd())

        Dim user As UserPrincipal = UserPrincipal.FindByIdentity(context, PersalNumber & "")

        user.GivenName = FirstName & ""
        user.Surname = LastName & ""
        user.EmailAddress = EMail & ""
        user.Description = shortcode & "" & " - " & FirstName & " " & LastName & "" & "(" & Rank & "" & ")"
        user.DisplayName = FirstName & "" & " " & LastName & ""
        user.PasswordNeverExpires = True
        user.Save()
        Do_SaveDepartment(PersalNumber & "", shortcode & "", company & "", fax & "", tel & "", mobile & "")
        frmMain.WriteAdminLogEntry("Do_UpdateUser")
        ' frmEnvironment.ChildFormPRD.VIP_USERS_NewUsersTableAdapter.UpdateDoneToCompleted(Get_ValidPersalNumber(PersalNumber.Trim))
    End Sub

    Public Function Get_ValidPersalNumber(ByVal persalnumber As String) As String
        Dim slength As Integer = Microsoft.VisualBasic.Len(persalnumber.Trim)
        If Microsoft.VisualBasic.Left(persalnumber.Trim, 1).ToUpper = "P" Then
            Return Microsoft.VisualBasic.Replace(persalnumber.Trim, "P", "")
        Else
            Return persalnumber.Trim
        End If
    End Function

    Public Function Get_IsValidUser(ByVal _persalnumber As String) As Boolean

        Dim persalnumber As String = Get_ValidUsername(_persalnumber.Trim)
        Dim context As New PrincipalContext(ContextType.Domain, _
                                            Get_IPaddress_String(), _
                                            "CN=" & persalnumber & _
                                            "," & Get_LDAP_String(), _
                                            Get_Master_User(), _
                                            Get_Master_Pwd())

        Try
            Dim user As UserPrincipal = UserPrincipal.FindByIdentity(context, persalnumber)
            'My.Settings.ValidUser = True
            Return True
        Catch ex As Exception
            'My.Settings.ValidUser = False
            Return False
        End Try

    End Function
    'Get_UserGroups
    Public Function Do_RemoveFromGroup_Collection(ByVal SamAccountNo As String, ByVal GroupNameCollection As Microsoft.VisualBasic.Collection) As Boolean

        ' cntx = ou_context.GOVERNMENT_STRUCTURE
        Dim i As Integer
        Dim usr As String = Get_Master_User()
        Dim pwd As String = Get_Master_Pwd()
        Dim ipaddress As String = Get_IPaddress_String()
        Dim dso As IADsOpenDSObject = DirectCast(GetObject("LDAP:"), IADsOpenDSObject)
        Dim oGroup As IADsGroup
        Dim fullcntx As String = ""

        For i = 1 To GroupNameCollection.Count
            Try
                fullcntx = GroupNameCollection(i)
                oGroup = DirectCast(dso.OpenDSObject("LDAP://" & ipaddress & "/" & fullcntx, usr, pwd, ADS_SECURE_AUTHENTICATION), IADsGroup)
                oGroup.Remove("LDAP://CN=" & Trim$(SamAccountNo) & "," & Get_Users_OU_Context())
                oGroup.SetInfo()
            Catch ex As Exception
            End Try
        Next

        usr = Nothing
        pwd = Nothing
        ipaddress = Nothing
        oGroup = Nothing
        dso = Nothing

    End Function

    'Public Function Do_Compare_New_And_Old_Current_Return_Valid_Col(ByVal SamAccountNo As String, _
    '                                                                ByVal NewAD_Collection As Microsoft.VisualBasic.Collection, _
    '                                                                ByVal CurrentAD_Collection As Microsoft.VisualBasic.Collection) As Microsoft.VisualBasic.Collection
    '    ' cntx = ou_context.GOVERNMENT_STRUCTURE
    '    ' Do a cmpare of both the collections and only remove the ones that shold not be there

    '    Dim usr As String = Get_Master_User()
    '    Dim pwd As String = Get_Master_Pwd()
    '    Dim ipaddress As String = Get_IPaddress_String()
    '    Dim dso As IADsOpenDSObject = DirectCast(GetObject("LDAP:"), IADsOpenDSObject)
    '    Dim oGroup As IADsGroup
    '    Dim fullcntx As String = ""
    '    Debug.Print(CurrentAD_Collection.Count)
    '    Debug.Print(NewAD_Collection.Count)
    '    For i = 1 To NewAD_Collection.Count
    '        Try
    '            fullcntx = NewAD_Collection(i)
    '            oGroup = DirectCast(dso.OpenDSObject("LDAP://" & ipaddress & "/" & fullcntx, usr, pwd, ADS_SECURE_AUTHENTICATION), IADsGroup)
    '            oGroup.Remove("LDAP://CN=" & Trim$(SamAccountNo) & "," & Get_Users_OU_Context())
    '            oGroup.SetInfo()
    '        Catch ex As Exception
    '        End Try
    '    Next

    '    usr = Nothing
    '    pwd = Nothing
    '    ipaddress = Nothing
    '    oGroup = Nothing
    '    dso = Nothing
    '    Return col

    'End Function

    Public Function Do_RemoveFromGroup(ByVal SamAccountNo As String, ByVal GroupName As String, ByVal cntx As ou_context) As Boolean

        ' cntx = ou_context.GOVERNMENT_STRUCTURE
        ' SamAccountName = "T0005221"
        ' Groupname = "FTP_ACCESS.OWN_DEPT"


        Dim usr As String = Get_Master_User()
        Dim pwd As String = Get_Master_Pwd()
        Dim ipaddress As String = Get_IPaddress_String()
        Dim KLKLL As String = Get_Complete_CN_OU_Context(GroupName, cntx)
        Dim oGroup As IADsGroup
        Try
            Dim dso As IADsOpenDSObject = DirectCast(GetObject("LDAP:"), IADsOpenDSObject)
            oGroup = DirectCast(dso.OpenDSObject("LDAP://" & ipaddress & "/" & KLKLL, usr, pwd, ADS_SECURE_AUTHENTICATION), IADsGroup)
            oGroup.Remove("LDAP://CN=" & Trim$(SamAccountNo) & "," & Get_Users_OU_Context())
            oGroup.SetInfo()
            Return True
        Catch ex As Exception
            Return False
        Finally
            usr = Nothing
            pwd = Nothing
            ipaddress = Nothing
            KLKLL = Nothing
            oGroup = Nothing
            dso = Nothing
        End Try
    End Function

    Public Sub Do_RemoveUserFromAllGroups(ByVal username As String)

        Dim i As Integer
        Dim colGroups As Collection
        colGroups = Get_UserGroups(username)
        Err.Clear()
        For i = 1 To colGroups.Count
            If InStr(1, colGroups(i).ToString, ".CON") > 0 Or _
               InStr(1, colGroups(i).ToString, ".NAT") > 0 Or _
               InStr(1, colGroups(i).ToString, ".PROV") > 0 Or _
               InStr(1, colGroups(i).ToString, ".OWN_PROV") > 0 Or _
               InStr(1, colGroups(i).ToString, ".OWN_DEPT") > 0 Or _
               InStr(1, colGroups(i).ToString, ".ASSIGN_DEPT") > 0 Or _
               InStr(1, colGroups(i).ToString, "FLAG.IN_HOUSE_APPS_RESPONSIBILITIES") > 0 Then
                Try
                    Do_RemoveFromGroup(username, colGroups(i).ToString, ou_context.APPLICATION_RIGHTS)
                Catch ex As Exception
                End Try
            Else
                If InStr(1, colGroups(i).ToString, ".") > 0 Then
                    Try
                        Do_RemoveFromGroup(username, colGroups(i).ToString, ou_context.GOVERNMENT_STRUCTURE)
                    Catch ex As Exception
                    End Try
                End If
            End If
        Next
        colGroups = Get_UserGroups(username)
        i = Nothing
        colGroups = Nothing
    End Sub

    Public Sub Do_AddUser2ApplGroups(ByVal _persalnumber As String, ByVal colGroups As Collection)
        Dim i As Integer
        Dim PersalNumber As String = Get_ValidUsername(_persalnumber)
        For i = 1 To colGroups.Count
            Try
                Do_AddToGroup(PersalNumber, colGroups(i).ToString, ou_context.APPLICATION_RIGHTS)
            Catch ex As Exception
            End Try
        Next i
    End Sub

    Public Function Get_AccountExpireDate(ByVal _persalnumber As String) As Date

        Dim PersalNumber As String = Get_ValidUsername(_persalnumber)
        Dim context As New PrincipalContext(ContextType.Domain, _
                                            Get_IPaddress_String(), _
                                            "CN=" & PersalNumber & _
                                            "," & Get_LDAP_String(), _
                                            Get_Master_User(), _
                                            Get_Master_Pwd())


        Dim userPrincipal As UserPrincipal = userPrincipal.FindByIdentity(context, PersalNumber)
        'userPrincipal

        If userPrincipal.AccountExpirationDate Is Nothing Then
            Get_AccountExpireDate = #1/1/1970#
            Get_AccountExpireDate = Get_AccountExpireDate.AddDays(-1)
        Else
            Get_AccountExpireDate = CType(userPrincipal.AccountExpirationDate, Date)
        End If

    End Function

    Public Sub Do_AccountNeverExpire(ByVal _persalnumber As String)

        Dim PersalNumber As String = Get_ValidUsername(_persalnumber)
        Dim context As New PrincipalContext(ContextType.Domain, _
                                            Get_IPaddress_String(), _
                                            "CN=" & PersalNumber & _
                                            "," & Get_LDAP_String(), _
                                            Get_Master_User(), _
                                            Get_Master_Pwd())

        Dim userPrincipal As UserPrincipal = userPrincipal.FindByIdentity(context, PersalNumber)
        userPrincipal.AccountExpirationDate = Nothing
        userPrincipal.Save()
        frmMain.WriteAdminLogEntry("Do_AccountNeverExpire")
    End Sub

    Public Function Get_UserGroups(ByVal _persalnumber As String) As Microsoft.VisualBasic.Collection

        Dim persalnumber As String = Get_ValidUsername(_persalnumber)
        Dim dsDirectoryEntry As New DirectoryEntry("LDAP://" & Get_IPaddress_String() & _
                                                   "/CN=" & persalnumber & _
                                                    "," & Get_LDAP_String(), Get_Master_User(), Get_Master_Pwd())

        Dim s As String
        Dim bytCounter As Integer
        Dim strGroups As String
        Dim shtCommaIndex As Integer
        Dim UserGroups As New Microsoft.VisualBasic.Collection
        Dim shtEqualsIndex As Integer
        Dim sbUserGroups As New StringBuilder
        Dim dsSearcher As New DirectorySearcher(dsDirectoryEntry)

        dsSearcher.Filter = "saMAccountName=" & persalnumber
        dsSearcher.PropertiesToLoad.Add("memberOf")

        Try
            Dim dsResult As SearchResult = dsSearcher.FindOne
            If dsResult Is Nothing Then
                Return Nothing
            End If
            For bytCounter = 0 To (dsResult.Properties("memberOf").Count - 1)
                strGroups = CType(dsResult.Properties("memberOf")(bytCounter), String)
                shtEqualsIndex = strGroups.IndexOf("=", 1)
                shtCommaIndex = strGroups.IndexOf(",", 1)
                If shtEqualsIndex = -1 Then
                    Return Nothing
                End If
                s = strGroups.Substring((shtEqualsIndex + 1), (shtCommaIndex - shtEqualsIndex) - 1)
                UserGroups.Add(s)
                ' UserGroups.save()
            Next
        Catch ex As Exception
            MsgBox("Error occured - Get_UserGroups")
        End Try

        Return UserGroups

    End Function

    Public Sub Get_AccountLockoutTime(ByVal _persalnumber As String)
        Dim PersalNumber As String = Get_ValidUsername(_persalnumber)
        Dim context As New PrincipalContext(ContextType.Domain, _
                                            Get_IPaddress_String(), _
                                            "CN=" & PersalNumber & _
                                            "," & Get_LDAP_String(), _
                                            Get_Master_User(), _
                                            Get_Master_Pwd())

        Dim userPrincipal As UserPrincipal = userPrincipal.FindByIdentity(context, PersalNumber)

        userPrincipal.UnlockAccount()
        If userPrincipal.AccountLockoutTime.Value < Now Then

        End If

        userPrincipal.Save()
        frmMain.WriteAdminLogEntry("Do_Unlockaccount")

    End Sub

    Public Function Get_IsAccountLocked(ByVal _persalnumber As String) As Boolean
        Dim PersalNumber As String = Get_ValidUsername(_persalnumber)
        Dim context As New PrincipalContext(ContextType.Domain, _
                                            Get_IPaddress_String(), _
                                            "CN=" & PersalNumber & _
                                            "," & Get_LDAP_String(), _
                                            Get_Master_User(), _
                                            Get_Master_Pwd())

        Dim userPrincipal As UserPrincipal = userPrincipal.FindByIdentity(context, PersalNumber)
        If userPrincipal.AccountLockoutTime.ToString <> "" Then
            If frmEnvironment.ChildFormPRD.Visible Then
                frmEnvironment.ChildFormPRD.chkLocked.ForeColor = Color.Black
            Else
                frmEnvironment.childformQA.chkLocked.ForeColor = Color.Black
            End If
            Return True
        Else
            If frmEnvironment.ChildFormPRD.Visible Then
                frmEnvironment.ChildFormPRD.chkLocked.ForeColor = Color.Red
            Else
                frmEnvironment.childformQA.chkLocked.ForeColor = Color.Red
            End If
            Return False
        End If

    End Function

    Public Function Do_AddToGroup(ByVal SamAccountNo As String, _
                                  ByVal GroupName As String, _
                                  ByVal cntx As ou_context) As Boolean

        Dim oGroup As IADsGroup
        Dim dso As IADsOpenDSObject

        Try
            dso = DirectCast(GetObject("LDAP:"), IADsOpenDSObject)
            oGroup = DirectCast(dso.OpenDSObject("LDAP://" & Get_IPaddress_String() & "/" & Get_Complete_CN_OU_Context(GroupName, cntx), Get_Master_User(), Get_Master_Pwd(), ADS_SECURE_AUTHENTICATION), IADsGroup)
            oGroup.Add("LDAP://CN=" & SamAccountNo.Trim & "," & Get_Users_OU_Context())
            oGroup.SetInfo()

        Catch ex As Exception
        Finally
            oGroup = Nothing
            dso = Nothing
        End Try

        Return True

    End Function

    Public Function Do_AddToAssignedGroup(ByVal SamAccountNo As String, _
                                          ByVal GroupName As String, _
                                          ByVal ApplicationName As String, _
                                         ByVal cntx As ou_context) As Boolean

        Dim oGroup As IADsGroup
        Dim dso As IADsOpenDSObject

        Try
            dso = DirectCast(GetObject("LDAP:"), IADsOpenDSObject)
            oGroup = DirectCast(dso.OpenDSObject("LDAP://" & Get_IPaddress_String() & "/" & Get_Complete_CN_OU_Context(ApplicationName & "." & GroupName, cntx), Get_Master_User(), Get_Master_Pwd(), ADS_SECURE_AUTHENTICATION), IADsGroup)
            oGroup.Add("LDAP://CN=" & SamAccountNo.Trim & "," & Get_Users_OU_Context())
            oGroup.SetInfo()

        Catch ex As Exception
            'MsgBox(ApplicationName & "." & GroupName & "=> group does not exist on Active Directory", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        Finally
            oGroup = Nothing
            dso = Nothing
        End Try

        Return True

    End Function

    Public Sub GetGroupUsers(ByVal strGroupName As String)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        '
        '    Returns all the users of a specific group
        '    Each user on seperate line in the string
        '    The group name being passed is not case sensitive
        '
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        Dim dsDirectorySearcher As New DirectorySearcher
        Dim strUsers As String
        Dim shtEqualsIndex As Integer
        Dim shtCommaIndex As Integer
        Dim sbGroupUsers As New StringBuilder

        'Filter by group name
        With dsDirectorySearcher
            .Filter = "sAMAccountName=" & strGroupName
            .PropertiesToLoad.Add("member")

            Try
                'Retrieve results
                Dim dsResult As SearchResult = .FindOne
                Dim shtCounter As Integer

                If dsResult Is Nothing Then
                    'No results returned
                    Return
                End If

                For shtCounter = 0 To dsResult.Properties("member").Count - 1
                    strUsers = dsResult.Properties("member")(shtCounter).ToString

                    'Get index of equals and comma
                    shtEqualsIndex = strUsers.IndexOf("=", 1)
                    shtCommaIndex = strUsers.IndexOf(",", 1)

                    If shtEqualsIndex = -1 Then
                        Return
                    End If

                    'Extract name from string and append to string builder
                    sbGroupUsers.Append(strUsers.Substring((shtEqualsIndex + 1), (shtCommaIndex - shtEqualsIndex) - 1))
                    sbGroupUsers.Append(ControlChars.CrLf)

                Next

            Catch ex As Exception
                MessageBox.Show("Error in GetGroupUsers Function" & vbNewLine & vbNewLine _
                    & ex.Message, "Active Directory Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try

        End With

        Return

    End Sub

    Public Function GetUserGroups(ByVal strDomain As String, ByVal strLoginName As String) As String

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        '
        '    Returns all the groups that a specific user belongs too
        '    Each group is on a seperate line in the string
        '
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim dsDirectoryEntry As New DirectoryEntry("LDAP://" & _
                                                   Get_IPaddress_String() & "/" & _
                                                   Get_LDAP_String(), _
                                                   Get_Master_User(), _
                                                   Get_Master_Pwd())
        Dim dsSearcher As New DirectorySearcher(dsDirectoryEntry)

        Dim bytCounter As Integer
        Dim strGroups As String
        Dim shtEqualsIndex As Integer
        Dim shtCommaIndex As Integer
        Dim sbUserGroups As New StringBuilder

        dsSearcher.Filter = "saMAccountName=" & strLoginName
        dsSearcher.PropertiesToLoad.Add("user")

        Try
            Dim dsResult As SearchResult = dsSearcher.FindOne

            If dsResult Is Nothing Then
                'No results returned
                Return Nothing
            End If

            'Loop thru each of the groups returned
            For bytCounter = 0 To (dsResult.Properties("memberOf").Count - 1)
                strGroups = CType(dsResult.Properties("memberOf")(bytCounter), String)

                'Parse string and append the groups names into string builder

                'Get index of equals and comma
                shtEqualsIndex = strGroups.IndexOf("=", 1)
                shtCommaIndex = strGroups.IndexOf(",", 1)

                If shtEqualsIndex = -1 Then
                    Return Nothing
                End If

                sbUserGroups.Append(strGroups.Substring((shtEqualsIndex + 1), (shtCommaIndex - shtEqualsIndex) - 1))
                sbUserGroups.Append(ControlChars.CrLf)
            Next

        Catch ex As Exception
            MessageBox.Show("Error in GetUserGroups Function" & vbNewLine & vbNewLine _
                & ex.Message, "Active Directory Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return sbUserGroups.ToString.Trim

    End Function

    Public Sub Create_Government_Group_QA(ByVal groupname As String)

        Dim newGroupPrincipal As GroupPrincipal
        'Try
        Using ouPrincipalContext As PrincipalContext = New PrincipalContext( _
                                    ContextType.Domain, _
                                    "10.123.45.210", _
                                    Get_Govt_OU_Context, _
                                    Get_Master_User(), _
                                    Get_Master_Pwd())
            Try
                newGroupPrincipal = New GroupPrincipal(ouPrincipalContext)
                With newGroupPrincipal
                    .Name = groupname
                    .IsSecurityGroup = False
                    .GroupScope = GroupScope.Global
                    .SamAccountName = groupname
                    .Save()
                End With
                frmMain.WriteAdminLogEntry(groupname & " created")
            Catch ex As Exception
                frmMain.WriteAdminLogEntry(groupname & " NOT created - FAILED")
            End Try
        End Using
        'Catch ex As Exception
        'End Try

    End Sub

    Public Sub Create_Government_Group(ByVal groupname As String)

        Dim newGroupPrincipal As GroupPrincipal
        'Try
        Using ouPrincipalContext As PrincipalContext = New PrincipalContext( _
                                    ContextType.Domain, _
                                    Get_IPaddress_String(), _
                                    Get_Govt_OU_Context, _
                                    Get_Master_User(), _
                                    Get_Master_Pwd())
            Try
                newGroupPrincipal = New GroupPrincipal(ouPrincipalContext)
                With newGroupPrincipal
                    .Name = groupname
                    .IsSecurityGroup = False
                    .GroupScope = GroupScope.Global
                    .SamAccountName = groupname
                    .Save()
                End With
                frmMain.WriteAdminLogEntry(groupname & " created")
            Catch ex As Exception
                frmMain.WriteAdminLogEntry(groupname & " NOT created - FAILED")
            End Try
        End Using
        'Catch ex As Exception
        'End Try

    End Sub

    Public Sub Create_Application_Group(ByVal groupname As String)

        Dim newGroupPrincipal As GroupPrincipal
        Dim mGroup As String
        Dim oGroup As GroupPrincipal
        Dim IpAddress As String = Get_IPaddress_String()
        Dim GetMasterUser As String = Get_Master_User()
        Dim cntx As String = Get_Complete_CN_OU_Context(groupname, ou_context.APPLICATION_RIGHTS)
        Dim GetMasterPwd As String = Get_Master_Pwd()

        Using ouPrincipalContext As PrincipalContext = New PrincipalContext(ContextType.Domain, _
                                    Get_IPaddress_String(), _
                                    Get_App_OU_Context, _
                                    Get_Master_User(), _
                                    Get_Master_Pwd())
            frmMain.WriteAdminLogEntry(groupname & " created")
            Try
                dso = GetObject("LDAP:")
                oGroup = DirectCast(dso.OpenDSObject("LDAP://" & IpAddress & "/" & cntx, GetMasterUser, GetMasterPwd, ADS_SECURE_AUTHENTICATION), GroupPrincipal)
                mGroup = oGroup.Name.ToString
            Catch ex As Exception
                newGroupPrincipal = New GroupPrincipal(ouPrincipalContext)
                With newGroupPrincipal
                    .Name = groupname
                    .IsSecurityGroup = False
                    .GroupScope = GroupScope.Global
                    .SamAccountName = groupname
                    .Save()
                End With
            End Try

        End Using

    End Sub

    Public Sub Insert_CFO_Record(ByVal Dept_Code As String, _
                                          ByVal Fullname As String, _
                                          ByVal CompanyName As String, _
                                          ByVal Email1Address As String, _
                                          ByVal NAT_PROV_ID As Long, _
                                          ByVal VoteID As Long, _
                                          ByVal FirstName As String, _
                                          ByVal BusinessTelephoneNumber As String, _
                                          ByVal Gender As String, _
                                          ByVal Initials As String, _
                                          ByVal Lastname As String, _
                                          ByVal BusinessAddress As String, _
                                          ByVal BusinessFaxNumber As String)

        Dim pDept_Code As New SqlClient.SqlParameter("@Dept_Code", SqlDbType.VarChar, 15)
        Dim pFullname As New SqlClient.SqlParameter("@Fullname", SqlDbType.VarChar, 50)
        Dim pCompanyName As New SqlClient.SqlParameter("@CompanyName", SqlDbType.VarChar, 50)
        Dim pEmail1Address As New SqlClient.SqlParameter("@Email1Address ", SqlDbType.VarChar, 150)
        Dim pNAT_PROV_ID As New SqlClient.SqlParameter("@NAT_PROV_ID", SqlDbType.BigInt)
        Dim pVoteID As New SqlClient.SqlParameter("@VoteID", SqlDbType.BigInt)
        Dim pFirstName As New SqlClient.SqlParameter("@FirstName", SqlDbType.VarChar, 50)
        Dim pBusinessTelephoneNumber As New SqlClient.SqlParameter("@BusinessTelephoneNumber", SqlDbType.VarChar, 50)
        Dim pGender As New SqlClient.SqlParameter("@Gender", SqlDbType.VarChar, 50)
        Dim pInitials As New SqlClient.SqlParameter("@Initials", SqlDbType.VarChar, 50)
        Dim pLastname As New SqlClient.SqlParameter("@Lastname", SqlDbType.VarChar, 50)
        Dim pBusinessAddress As New SqlClient.SqlParameter("@BusinessAddress", SqlDbType.VarChar, 50)
        Dim pBusinessFaxNumber As New SqlClient.SqlParameter("@BusinessFaxNumber", SqlDbType.VarChar, 50)

        Dim cnADS As New SqlConnection
        Dim cmdCFO As New SqlCommand("InsertCFO", cnADS)

        cnADS.ConnectionString = My.Settings.AdsConnectionString
        cnADS.Open()
        cmdCFO.CommandType = CommandType.StoredProcedure

        ' Set all the relevant values here

        pDept_Code.Value = Dept_Code & ""
        pFullname.Value = Fullname & ""
        pCompanyName.Value = CompanyName & ""
        pEmail1Address.Value = Email1Address & ""
        pNAT_PROV_ID.Value = NAT_PROV_ID + 0
        pVoteID.Value = VoteID + 0
        pFirstName.Value = FirstName & ""
        pBusinessTelephoneNumber.Value = BusinessTelephoneNumber & ""
        pGender.Value = Gender & ""
        pInitials.Value = Initials & ""
        pLastname.Value = Lastname & ""
        pBusinessAddress.Value = BusinessAddress & ""
        pBusinessFaxNumber.Value = BusinessFaxNumber & ""

        cmdCFO.Parameters.Add(pDept_Code)
        cmdCFO.Parameters.Add(pFullname)
        cmdCFO.Parameters.Add(pCompanyName)
        cmdCFO.Parameters.Add(pEmail1Address)
        cmdCFO.Parameters.Add(pNAT_PROV_ID)
        cmdCFO.Parameters.Add(pVoteID)
        cmdCFO.Parameters.Add(pFirstName)
        cmdCFO.Parameters.Add(pBusinessTelephoneNumber)
        cmdCFO.Parameters.Add(pGender)
        cmdCFO.Parameters.Add(pInitials)
        cmdCFO.Parameters.Add(pLastname)
        cmdCFO.Parameters.Add(pBusinessAddress)
        cmdCFO.Parameters.Add(pBusinessFaxNumber)

        '**************************    
        cmdCFO.ExecuteNonQuery()
        '**************************    

        cmdCFO.Parameters.Remove(pDept_Code)
        cmdCFO.Parameters.Remove(pFullname)
        cmdCFO.Parameters.Remove(pCompanyName)
        cmdCFO.Parameters.Remove(pEmail1Address)
        cmdCFO.Parameters.Remove(pNAT_PROV_ID)
        cmdCFO.Parameters.Remove(pVoteID)
        cmdCFO.Parameters.Remove(pFirstName)
        cmdCFO.Parameters.Remove(pBusinessTelephoneNumber)
        cmdCFO.Parameters.Remove(pGender)
        cmdCFO.Parameters.Remove(pInitials)
        cmdCFO.Parameters.Remove(pLastname)
        cmdCFO.Parameters.Remove(pBusinessAddress)
        cmdCFO.Parameters.Remove(pBusinessFaxNumber)

        cmdCFO.Dispose()
        cmdCFO = Nothing

        cnADS.Close()
        cnADS = Nothing

    End Sub

    Public Function Get_EmailAddress(ByVal _persalnumber As String) As String

        Dim persalnumber As String = Get_ValidUsername(_persalnumber.Trim)
        Dim context As New PrincipalContext(ContextType.Domain, _
                                            Get_IPaddress_String(), _
                                            "CN=" & persalnumber & _
                                            "," & Get_LDAP_String(), _
                                            Get_Master_User(), _
                                            Get_Master_Pwd())

        Try
            Dim user As UserPrincipal = UserPrincipal.FindByIdentity(context, persalnumber)
            Return (user.EmailAddress.ToLower()).Trim
        Catch ex As Exception
            Return ""
        End Try

    End Function

    Public Function Get_Realname_From_Username(ByVal _persalnumber As String) As String

        Dim persalnumber As String = Get_ValidUsername(_persalnumber.Trim)
        Dim context As New PrincipalContext(ContextType.Domain, _
                                            Get_IPaddress_String(), _
                                            "CN=" & persalnumber & _
                                            "," & Get_LDAP_String(), _
                                            Get_Master_User(), _
                                            Get_Master_Pwd())

        Try
            Dim user As UserPrincipal = UserPrincipal.FindByIdentity(context, persalnumber)
            Return (user.Name.ToLower()).Trim & " " & (user.Surname.ToLower()).Trim
        Catch ex As Exception
            Return "Not Found"
        End Try
    End Function

    Public Function Does_Account_Exist(ByVal _persalnumber As String) As Integer
        If String.IsNullOrEmpty(_persalnumber) Then
            Exit Function
        End If
        Dim PersalNumber As String = Get_ValidUsername(_persalnumber)
        Dim context As New PrincipalContext(ContextType.Domain, _
                                            Get_IPaddress_String(), _
                                            "CN=" & PersalNumber & _
                                            "," & Get_LDAP_String(), _
                                            Get_Master_User(), _
                                            Get_Master_Pwd())

        If _persalnumber = "" Then
            Return 3
        End If

        Try
            Dim userPrincipal As UserPrincipal = userPrincipal.FindByIdentity(context, PersalNumber)
            If UCase(Trim(userPrincipal.DisplayName)) = UCase(Trim(PersalNumber)) Then
                Return 1
            End If
        Catch ex As Exception
            Return 2
        End Try
        Return 0
    End Function

    'Public Function GetSIPAddress(ByVal email As String) As String

    '    Dim directoryEntry As New System.DirectoryServices.DirectoryEntry("LDAP://" & _
    '                                   Get_IPaddress_String() & "/" & _
    '                                   Get_LDAP_String(), _
    '                                   Get_Master_User(), _
    '                                   Get_Master_Pwd())


    '    Dim resultValue As String = ""

    '    Using HostingEnvironment.Impersonate()
    '        Dim directorySearcher As New DirectorySearcher(directoryEntry)
    '        directorySearcher.Filter = String.Format("(&(objectClass=user)(objectCategory=user) (mail={0}))", email)

    '        directorySearcher.PropertiesToLoad.Add("msRTCSIP-PrimaryUserAddress")

    '        Dim result As SearchResult = directorySearcher.FindOne()

    '        If result IsNot Nothing Then
    '            If result.Properties("msRTCSIP-PrimaryUserAddress") IsNot Nothing Then
    '                resultValue = result.Properties("msRTCSIP-PrimaryUserAddress")(0).ToString()
    '                resultValue = "'" & resultValue & "'"
    '            End If
    '        End If
    '    End Using
    '    Return resultValue
    'End Function

    Public Function Do_AddFlag(ByVal SamAccountNo As String, _
                                ByVal GroupName As String, _
                                ByVal cntx As ou_context) As Boolean

        Dim oGroup As IADsGroup
        Dim dso As IADsOpenDSObject

        Try
            dso = DirectCast(GetObject("LDAP:"), IADsOpenDSObject)
            oGroup = DirectCast(dso.OpenDSObject("LDAP://" & Get_IPaddress_String() & "/" & Get_Complete_CN_OU_Context(GroupName, cntx), Get_Master_User(), Get_Master_Pwd(), ADS_SECURE_AUTHENTICATION), IADsGroup)
            oGroup.Add("LDAP://CN=" & SamAccountNo.Trim & "," & Get_Users_OU_Context())
            oGroup.SetInfo()

        Catch ex As Exception
        Finally
            oGroup = Nothing
            dso = Nothing
        End Try

        Return True

    End Function

    Public Function Get_Resolved_MemberOf_Context_Collection(ByVal _persalnumber As String) As Microsoft.VisualBasic.Collection

        Dim persalnumber As String = Get_ValidUsername(_persalnumber)
        Dim dsDirectoryEntry As New DirectoryEntry("LDAP://" & Get_IPaddress_String() & _
                                                   "/CN=" & persalnumber & _
                                                    "," & Get_LDAP_String(), Get_Master_User(), Get_Master_Pwd())

        Dim bytCounter As Integer
        Dim strGroups As String
        Dim UserGroups As New Microsoft.VisualBasic.Collection
        Dim sbUserGroups As New StringBuilder
        Dim dsSearcher As New DirectorySearcher(dsDirectoryEntry)

        dsSearcher.Filter = "saMAccountName=" & persalnumber
        dsSearcher.PropertiesToLoad.Add("memberOf")

        Try
            Dim dsResult As SearchResult = dsSearcher.FindOne
            If dsResult Is Nothing Then
                Return Nothing
            End If
            For bytCounter = 0 To (dsResult.Properties("memberOf").Count - 1)
                strGroups = CType(dsResult.Properties("memberOf")(bytCounter), String)
                UserGroups.Add(strGroups)
            Next
        Catch ex As Exception
        End Try

        dsDirectoryEntry = Nothing
        bytCounter = Nothing
        sbUserGroups = Nothing
        dsSearcher = Nothing

        Return UserGroups

    End Function



    Public Sub MarkAsDone(ByVal strID As String, ByVal strPersalnumber As String)

        Dim pID As Long = CLng(0)
        Dim persalno As String = ""
        Dim Ads As Global.ADAdminDotNet.dsADS
        Ads = New ADAdminDotNet.dsADS
        'pID = DirectCast(VIP_USERS_ResetPasswordDataGridView.CurrentRow.Cells("IDDataGridViewTextBoxColumn").Value, Long)
        ' persalno = VIP_USERS_ResetPasswordDataGridView.CurrentRow.Cells("PersalNrDataGridViewTextBoxColumn").Value.ToString().Trim

        pID = CLng(strID) 'strID 'DirectCast(strID, Long)
        persalno = strPersalnumber 'VIP_USERS_ResetPasswordDataGridView.CurrentRow.Cells("PersalNrDataGridViewTextBoxColumn").Value.ToString().Trim
 
        frmResetPassword.VIP_USERS_ResetPasswordTableAdapter.UpdateDoneTo3(pID)
        persalno = Get_ValidPersalNumber(persalno)
        If frmEnvironment.ChildFormPRD.Visible Then
            frmEnvironment.ChildFormPRD.ADCONSOLELOGTableAdapter.InsertIntoADAdminConsoleLog2(frmEnvironment.ChildFormPRD.tsLoggedOnUser.Text, persalno, "Flagged Status 3", False)
            frmResetPassword.VIP_USERS_ResetPasswordTableAdapter.ClearBeforeFill = True
            frmResetPassword.VIP_USERS_ResetPasswordTableAdapter.Fill(Ads.VIP_USERS_ResetPassword)
            frmResetPassword.VIP_USERS_ResetPasswordDataGridView.Refresh()
            frmEnvironment.ChildFormPRD.Refresh_Log()
        Else
            frmEnvironment.childformQA.ADCONSOLELOGTableAdapter.InsertIntoADAdminConsoleLog2(frmEnvironment.childformQA.tsLoggedOnUser.Text, persalno, "Flagged Status 3", False)
            frmResetPassword.VIP_USERS_ResetPasswordTableAdapter.ClearBeforeFill = True
            frmResetPassword.VIP_USERS_ResetPasswordTableAdapter.Fill(Ads.VIP_USERS_ResetPassword)
            frmResetPassword.VIP_USERS_ResetPasswordDataGridView.Refresh()
            frmEnvironment.childformQA.Refresh_Log()
        End If

    End Sub



    Public Sub MarkAsDoneNewuser(ByVal strID As String)
        Try
            Dim selectedrowindex As Integer
            Dim id2flag As Long
            Dim VIP_USERS_NewUsersTableAdapter As Global.ADAdminDotNet.dsADSTableAdapters.VIP_USERS_NewUsersTableAdapter
            VIP_USERS_NewUsersTableAdapter = New ADAdminDotNet.dsADSTableAdapters.VIP_USERS_NewUsersTableAdapter
            Dim Ads As Global.ADAdminDotNet.dsADS
            Ads = New ADAdminDotNet.dsADS
            selectedrowindex = frmNewUsers.VIP_USERS_NewUsersDataGridView.SelectedRows.Item(0).Index

            id2flag = CLng(strID)
            VIP_USERS_NewUsersTableAdapter.FlagCompletedByID(id2flag)
            frmNewUsers.VIP_USERS_NewUsersTableAdapter.Fill(Ads.VIP_USERS_NewUsers)
        Catch ex As Exception

        End Try


        'If selectedrowindex > -1 Then
        '    If MsgBox("Are you sure you want to mark " & vbCrLf & _
        '                  "  EntryID : " & VIP_USERS_NewUsersDataGridView.Rows(selectedrowindex).Cells("ID").Value.ToString & vbCrLf & _
        '                  "  UserID : " & VIP_USERS_NewUsersDataGridView.Rows(selectedrowindex).Cells("PersalNr").Value.ToString & vbCrLf & _
        '                  "  TelB : " & VIP_USERS_NewUsersDataGridView.Rows(selectedrowindex).Cells("TelB").Value.ToString & vbCrLf & _
        '                  "  Cell : " & VIP_USERS_NewUsersDataGridView.Rows(selectedrowindex).Cells("Cell").Value.ToString & vbCrLf & _
        '                  "  EMail : " & VIP_USERS_NewUsersDataGridView.Rows(selectedrowindex).Cells("EMail").Value.ToString & vbCrLf & _
        '                  "as completed?", MsgBoxStyle.OkCancel, "System Message") = MsgBoxResult.Ok Then
        '        If MsgBox("Are you sure???" & VIP_USERS_NewUsersDataGridView.Rows(selectedrowindex).Cells("PersalNr").Value.ToString & " as completed?", MsgBoxStyle.OkCancel, "System Message") = MsgBoxResult.Ok Then
        '            id2flag = CLng(VIP_USERS_NewUsersDataGridView.Rows(selectedrowindex).Cells("ID").Value)
        '            VIP_USERS_NewUsersTableAdapter.FlagCompletedByID(id2flag)
        '            Me.VIP_USERS_NewUsersTableAdapter.Fill(Me.Ads.VIP_USERS_NewUsers)
        '        End If
        '    End If
        'End If

    End Sub


    'Public Function Get_AllGroups(ByVal ldap_ou_string As String) As Microsoft.VisualBasic.Collection

    '    Dim PersalNumber As String = Get_ValidUsername(_persalnumber)
    '    Dim context As New PrincipalContext(ContextType.Domain, _
    '                                        Get_IPaddress_String(), _
    '                                        "CN=" & PersalNumber & _
    '                                        "," & Get_LDAP_String(), _
    '                                        Get_Master_User(), _
    '                                        Get_Master_Pwd())

    '    Dim i As Integer
    '    Dim colGroups As Collection
    '    colGroups = Get_UserGroups(PersalNumber)

    '    For i = 1 To colGroups.Count
    '        Try
    '            Do_RemoveFromGroup(PersalNumber, colGroups(i).ToString, ou_context.GOVERNMENT_STRUCTURE)
    '        Catch ex As Exception
    '        End Try
    '        Try
    '            Do_RemoveFromGroup(PersalNumber, colGroups(i).ToString, ou_context.APPLICATION_RIGHTS)
    '        Catch ex As Exception
    '        End Try
    '    Next

    'End Function

End Module
