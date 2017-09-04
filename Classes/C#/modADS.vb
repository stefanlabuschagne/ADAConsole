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
        If InStr(frmEnvironment.ActiveMdiChild.Text, "QA") > 0 Then
            Get_App_OU_Context = "OU=APPLICATION_RIGHTS," & My.Settings.VulindlelaContextQA.Trim
        ElseIf InStr(frmEnvironment.ActiveMdiChild.Text, "PRD") > 0 Then
            Get_App_OU_Context = "OU=APPLICATION_RIGHTS," & My.Settings.VulindlelaContextPRD.Trim
        End If
    End Function

    Public Function Get_Govt_OU_Context() As String
        If InStr(frmEnvironment.ActiveMdiChild.Text, "QA") > 0 Then
            Get_Govt_OU_Context = "OU=GOVERNMENT_STRUCTURE," & My.Settings.VulindlelaContextQA.Trim
        ElseIf InStr(frmEnvironment.ActiveMdiChild.Text, "PRD") > 0 Then
            Get_Govt_OU_Context = "OU=GOVERNMENT_STRUCTURE," & My.Settings.VulindlelaContextPRD.Trim
        End If
        Return Get_Govt_OU_Context
    End Function

    Public Function Get_Users_OU_Context() As String
        If InStr(frmEnvironment.ActiveMdiChild.Text, "QA") > 0 Then
            Get_Users_OU_Context = "OU=USERS," & My.Settings.VulindlelaContextQA.Trim
        ElseIf InStr(frmEnvironment.ActiveMdiChild.Text, "PRD") > 0 Then
            Get_Users_OU_Context = "OU=USERS," & My.Settings.VulindlelaContextPRD.Trim
        End If
        Return Get_Users_OU_Context
    End Function

    Public Function Get_Complete_CN_OU_Context(ByVal groupname As String, ByVal cntxt As ou_context) As String
        Dim Complete_CN_OU_Context As String
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
        If InStr(frmEnvironment.ActiveMdiChild.Text, "QA") > 0 Then
            Get_DC_String = My.Settings.AD_DC_QA
        ElseIf InStr(frmEnvironment.ActiveMdiChild.Text, "PRD") > 0 Then
            Get_DC_String = My.Settings.AD_DC_PRD
        End If
        Return Get_DC_String
    End Function

    Public Function Get_ValidUsername(ByVal _persalnumber As String) As String
        If _persalnumber Is Nothing Then
            MsgBox("Please enter a valid persal number", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "System MEssage")
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
        user.Save()

        If frmEnvironment.ChildFormPRD.Visible Then
            frmMain.ADCONSOLELOGTableAdapter.InsertIntoADAdminConsoleLog2(frmEnvironment.ChildFormPRD.tsLoggedOnUser.Text, _
                                                             Get_ValidPersalNumber(PersalNumber), _
                                                             "Do_Expire_Account_In_" & CStr(days) & "_Days", 0)
            frmEnvironment.ChildFormPRD.Refresh_Log()

        Else
            frmMain.ADCONSOLELOGTableAdapter.InsertIntoADAdminConsoleLog2(frmEnvironment.childformQA.tsLoggedOnUser.Text, _
                                                             Get_ValidPersalNumber(PersalNumber), _
                                                             "Do_Expire_Account_In_" & CStr(days) & "_Days", 0)
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
                    frmEnvironment.ChildFormPRD.txtPersalNumber.Text.Trim), "Do_ExpirePasswordNow", 0)
            frmEnvironment.ChildFormPRD.Refresh_Log()
        Else
            frmMain.ADCONSOLELOGTableAdapter.InsertIntoADAdminConsoleLog2( _
                    frmEnvironment.childformQA.tsLabelVulname.Text, Get_ValidPersalNumber( _
                    frmEnvironment.childformQA.txtPersalNumber.Text.Trim), "Do_ExpirePasswordNow", 0)
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
                        frmEnvironment.ChildFormPRD.txtPersalNumber.Text.Trim), "Do_ResetPassword", 0)
                frmEnvironment.ChildFormPRD.Refresh_Log()
            Else
                frmMain.ADCONSOLELOGTableAdapter.InsertIntoADAdminConsoleLog2( _
                        frmEnvironment.childformQA.tsLabelVulname.Text, Get_ValidPersalNumber( _
                        frmEnvironment.childformQA.txtPersalNumber.Text.Trim), "Do_ResetPassword", 0)
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
                                                                     strDate.Trim, 0)
            frmEnvironment.ChildFormPRD.Refresh_Log()
        Else
            frmMain.ADCONSOLELOGTableAdapter.InsertIntoADAdminConsoleLog2(frmEnvironment.childformQA.tsLoggedOnUser.Text, _
                                                             Get_ValidPersalNumber(PersalNumber), _
                                                             "Do_AccountExpirationDate to : " & _
                                                                     strDate.Trim, 0)
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

    End Function

    Public Function Get_badPwdCount(ByVal _persalnumber As String) As Boolean

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
            If userEntry.Properties("badPwdCount").Value >= 1 Then
                Get_IsAccountLocked2 = True
            Else
                Get_IsAccountLocked2 = False
            End If
        Catch ex As Exception
            strError = ex.ToString
        End Try

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
        'If userPrincipal.AccountLockoutTime.Value < Now Then

        'End If

        userPrincipal.Save()

        If frmEnvironment.ChildFormPRD.Visible Then
            frmMain.ADCONSOLELOGTableAdapter.InsertIntoADAdminConsoleLog2(frmEnvironment.ChildFormPRD.tsLoggedOnUser.Text, _
                                                             Get_ValidPersalNumber(PersalNumber), _
                                                             "Do_Unlockaccount", 0)
            frmEnvironment.ChildFormPRD.Refresh_Log()
        Else
            frmMain.ADCONSOLELOGTableAdapter.InsertIntoADAdminConsoleLog2(frmEnvironment.childformQA.tsLoggedOnUser.Text, _
                                                             Get_ValidPersalNumber(PersalNumber), _
                                                             "Do_Unlockaccount", 0)
            frmEnvironment.childformQA.Refresh_Log()
        End If

    End Sub

    Public Sub Do_EnableAccount(ByVal _persalnumber As String)
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
                    frmEnvironment.ChildFormPRD.txtPersalNumber.Text.Trim), "Do_EnableAccount", 0)
            frmEnvironment.ChildFormPRD.Refresh_Log()
        Else
            frmEnvironment.childformQA.ADCONSOLELOGTableAdapter.InsertIntoADAdminConsoleLog2( _
                    frmEnvironment.childformQA.tsLabelVulname.Text, Get_ValidPersalNumber( _
                    frmEnvironment.childformQA.txtPersalNumber.Text.Trim), "Do_EnableAccount", 0)
            frmEnvironment.childformQA.Refresh_Log()
        End If

    End Sub

    Public Sub Do_DisableAccount(ByVal _persalnumber As String)
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
                    frmEnvironment.ChildFormPRD.txtPersalNumber.Text.Trim), "Do_DisableAccount", 0)
            frmEnvironment.ChildFormPRD.Refresh_Log()
        Else
            frmEnvironment.childformQA.ADCONSOLELOGTableAdapter.InsertIntoADAdminConsoleLog2( _
                    frmEnvironment.childformQA.tsLabelVulname.Text, Get_ValidPersalNumber( _
                    frmEnvironment.childformQA.txtPersalNumber.Text.Trim), "Do_DisableAccount", 0)
            frmEnvironment.childformQA.Refresh_Log()
        End If

    End Sub

    Public Function Get_Department(ByVal _persalnumber As String) As String
        'ByVal get_ipaddress_string As String, ByVal dmn As domain

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
        End Try

    End Function

    Public Function Get_LDAP_String() As String
        If InStr(frmEnvironment.ActiveMdiChild.Text, "QA") > 0 Then
            Get_LDAP_String = My.Settings.AD_USERS_QA
        ElseIf InStr(frmEnvironment.ActiveMdiChild.Text, "PRD") > 0 Then
            Get_LDAP_String = My.Settings.AD_USERS_PRD
        End If
    End Function

    Public Function Get_IPaddress_String() As String
        If InStr(frmEnvironment.ActiveMdiChild.Text, "QA") > 0 Then
            Get_IPaddress_String = My.Settings.IP_ADDRESS_QA
        ElseIf InStr(frmEnvironment.ActiveMdiChild.Text, "PRD") > 0 Then
            Get_IPaddress_String = My.Settings.IP_ADDRESS_PRD
        End If
    End Function

    Public Function Get_Master_User() As String
        If InStr(frmEnvironment.ActiveMdiChild.Text, "QA") > 0 Then
            Get_Master_User = My.Settings.ADSMasterUsername_QA
        ElseIf InStr(frmEnvironment.ActiveMdiChild.Text, "PRD") > 0 Then
            Get_Master_User = My.Settings.ADSMasterUsername_PRD
        End If
    End Function

    Public Function Get_Master_Pwd() As String
        Dim enc As New ClsCrypto
        If InStr(frmEnvironment.ActiveMdiChild.Text, "QA") > 0 Then
            Get_Master_Pwd = enc.Dekodeer128(My.Settings.ADSMasterPassword_QA.ToString)
        ElseIf InStr(frmEnvironment.ActiveMdiChild.Text, "PRD") > 0 Then
            Get_Master_Pwd = enc.Dekodeer128(My.Settings.ADSMasterPassword_PRD.ToString)
        End If
        enc = Nothing
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
        Get_LastLogon = userPrincipal.LastLogon()

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
                    frmEnvironment.ChildFormPRD.txtPersalNumber.Text.Trim), "Do_SaveDepartment", 0)
            frmEnvironment.ChildFormPRD.Refresh_Log()
        Else
            frmEnvironment.childformQA.ADCONSOLELOGTableAdapter.InsertIntoADAdminConsoleLog2( _
                    frmEnvironment.childformQA.tsLabelVulname.Text, Get_ValidPersalNumber( _
                    frmEnvironment.childformQA.txtPersalNumber.Text.Trim), "Do_SaveDepartment", 0)
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
                    frmEnvironment.ChildFormPRD.txtPersalNumber.Text.Trim), "Do_DeleteProfile", 0)
            frmEnvironment.ChildFormPRD.Refresh_Log()
        Else
            frmEnvironment.childformQA.ADCONSOLELOGTableAdapter.InsertIntoADAdminConsoleLog2( _
                    frmEnvironment.childformQA.tsLabelVulname.Text, Get_ValidPersalNumber( _
                    frmEnvironment.childformQA.txtPersalNumber.Text.Trim), "Do_DeleteProfile", 0)
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

        Do_SaveDepartment(PersalNumber & "", shortcode & "", company & "", fax & "", tel & "", mobile & "")

        If frmEnvironment.ChildFormPRD.Visible Then
            frmEnvironment.ChildFormPRD.ADCONSOLELOGTableAdapter.InsertIntoADAdminConsoleLog2( _
                    frmEnvironment.ChildFormPRD.tsLabelVulname.Text, Get_ValidPersalNumber( _
                    frmEnvironment.ChildFormPRD.txtPersalNumber.Text.Trim), "Do_CreateUser", 0)
            frmEnvironment.ChildFormPRD.Refresh_Log()
        Else
            frmEnvironment.childformQA.ADCONSOLELOGTableAdapter.InsertIntoADAdminConsoleLog2( _
                    frmEnvironment.childformQA.tsLabelVulname.Text, Get_ValidPersalNumber( _
                    frmEnvironment.childformQA.txtPersalNumber.Text.Trim), "Do_CreateUser", 0)
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
            My.Settings.ValidUser = True
            Return True
        Catch ex As Exception
            My.Settings.ValidUser = False
            Return False
        End Try

    End Function

    Public Function Do_RemoveFromGroup(ByVal SamAccountNo As String, _
                                         ByVal GroupName As String, _
                                         ByVal cntx As ou_context) As Boolean

        Dim oGroup As IADsGroup
        Dim dso As IADsOpenDSObject

        Try
            dso = GetObject("LDAP:")
            oGroup = dso.OpenDSObject("LDAP://" & Get_IPaddress_String() & "/" & _
                                      Get_Complete_CN_OU_Context(GroupName, cntx), _
                                      Get_Master_User(), _
                                      Get_Master_Pwd(), _
                                      ADS_SECURE_AUTHENTICATION)

            oGroup.Remove("LDAP://CN=" & Trim$(SamAccountNo) & "," & Get_Users_OU_Context())
            oGroup.SetInfo()

        Catch ex As Exception
        Finally
            oGroup = Nothing
            dso = Nothing
        End Try

        Return False

    End Function

    Public Sub Do_RemoveUserFromAllGroups(ByVal username As String)

        Dim i As Integer
        Dim colGroups As Collection
        colGroups = Get_UserGroups(username)
        Err.Clear()
        For i = 1 To colGroups.Count
            Try
                Do_RemoveFromGroup(username, colGroups(i).ToString, ou_context.GOVERNMENT_STRUCTURE)
            Catch ex As Exception
                MsgBox("Error GOVERNMENT_STRUCTURE", MsgBoxStyle.OkOnly, "Error")
            End Try
            Try
                Do_RemoveFromGroup(username, colGroups(i).ToString, ou_context.APPLICATION_RIGHTS)
            Catch ex As Exception
                MsgBox("Error APPLICATION_RIGHTS", MsgBoxStyle.OkOnly, "Error")
            End Try
            Try
                Do_RemoveFromGroup(username, colGroups(i).ToString, ou_context.USERS)
            Catch ex As Exception
                MsgBox("Error APPLICATION_RIGHTS", MsgBoxStyle.OkOnly, "Error")
            End Try
        Next
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

        If userPrincipal.AccountExpirationDate Is Nothing Then
            Get_AccountExpireDate = #1/1/1970#
            Get_AccountExpireDate = Get_AccountExpireDate.AddDays(-1)
        Else
            Get_AccountExpireDate = userPrincipal.AccountExpirationDate
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
        Dim shtCommaIndex As Short
        Dim UserGroups As New Microsoft.VisualBasic.Collection
        Dim shtEqualsIndex As Short
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
                'UserGroups.save()
            Next
        Catch ex As Exception
            MsgBox("Error occured - Get_UserGroups")
        End Try
        'GetUserGroups = UserGroups

        Return UserGroups

    End Function

    Public Function Get_AllGroups(ByVal ldap_ou_string As String) As Microsoft.VisualBasic.Collection

        Dim PersalNumber As String = Get_ValidUsername(_persalnumber)
        Dim context As New PrincipalContext(ContextType.Domain, _
                                            Get_IPaddress_String(), _
                                            "CN=" & PersalNumber & _
                                            "," & Get_LDAP_String(), _
                                            Get_Master_User(), _
                                            Get_Master_Pwd())

        Dim i As Integer
        Dim colGroups As Collection
        colGroups = Get_UserGroups(username)

        For i = 1 To colGroups.Count
            Try
                Do_RemoveFromGroup(username, colGroups(i).ToString, ou_context.GOVERNMENT_STRUCTURE)
            Catch ex As Exception
            End Try
            Try
                Do_RemoveFromGroup(username, colGroups(i).ToString, ou_context.APPLICATION_RIGHTS)
            Catch ex As Exception
            End Try
        Next

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
            dso = GetObject("LDAP:")
            oGroup = dso.OpenDSObject("LDAP://" & Get_IPaddress_String() & "/" & _
                                      Get_Complete_CN_OU_Context(GroupName, cntx), _
                                      Get_Master_User(), _
                                      Get_Master_Pwd(), _
                                      ADS_SECURE_AUTHENTICATION)

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
            dso = GetObject("LDAP:")
            oGroup = dso.OpenDSObject("LDAP://" & Get_IPaddress_String() & "/" & _
                                      Get_Complete_CN_OU_Context(ApplicationName & "." & GroupName, cntx), _
                                      Get_Master_User(), _
                                      Get_Master_Pwd(), _
                                      ADS_SECURE_AUTHENTICATION)

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

    Public Function GetGroupUsers(ByVal strGroupName As String)

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        '
        '    Returns all the users of a specific group
        '    Each user on seperate line in the string
        '    The group name being passed is not case sensitive
        '
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        Dim dsDirectorySearcher As New DirectorySearcher
        Dim strUsers As String
        Dim shtEqualsIndex As Short
        Dim shtCommaIndex As Short
        Dim sbGroupUsers As New StringBuilder

        'Filter by group name
        With dsDirectorySearcher
            .Filter = "sAMAccountName=" & strGroupName
            .PropertiesToLoad.Add("member")

            Try
                'Retrieve results
                Dim dsResult As SearchResult = .FindOne
                Dim shtCounter As Short

                If dsResult Is Nothing Then
                    'No results returned
                    Return Nothing
                End If

                For shtCounter = 0 To dsResult.Properties("member").Count - 1
                    strUsers = dsResult.Properties("member")(shtCounter)

                    'Get index of equals and comma
                    shtEqualsIndex = strUsers.IndexOf("=", 1)
                    shtCommaIndex = strUsers.IndexOf(",", 1)

                    If shtEqualsIndex = -1 Then
                        Return Nothing
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

        Return sbGroupUsers.ToString

    End Function

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
        Dim shtEqualsIndex As Short
        Dim shtCommaIndex As Short
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

    Public Sub Create_Government_Group(ByVal groupname As String)

        Dim newGroupPrincipal As GroupPrincipal

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
            End Try

        End Using

    End Sub

    Public Sub Create_Application_Group(ByVal groupname As String)

        Dim newGroupPrincipal As GroupPrincipal
        Dim mGroup As String

        Using ouPrincipalContext As PrincipalContext = New PrincipalContext(ContextType.Domain, _
                                    Get_IPaddress_String(), _
                                    Get_App_OU_Context, _
                                    Get_Master_User(), _
                                    Get_Master_Pwd())

            cntx = Get_Complete_CN_OU_Context(groupname, ou_context.APPLICATION_RIGHTS)
            frmMain.WriteAdminLogEntry(groupname & " created")
            Try
                dso = GetObject("LDAP:")
                oGroup = dso.OpenDSObject("LDAP://" & IpAddress & "/" & cntx, _
                                                                        GetMasterUser, _
                                                                        GetMasterPwd, _
                                                                        ADS_SECURE_AUTHENTICATION)
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

    '*********************************************************************************
    ' create a user account with S.DS
    Public Sub CreateUser()
        Dim container As New DirectoryEntry("LDAP://ou=TechWriters,dc=fabrikam,dc=com")
        Dim newUser As DirectoryEntry = container.Children.Add("cn=userDS1", "user")
        newUser.Properties("sAMAccountName").Value = "UserAccountDS"
        newUser.Properties("givenName").Value = "User"
        newUser.Properties("sn").Value = "One"
        newUser.CommitChanges()
        newUser.Invoke("SetPassword", New Object() {"pAssw0rdO1"})
        newUser.Properties("pwdLastSet").Value = 0
        newUser.Properties("userAccountControl").Value = 512
        newUser.CommitChanges()
    End Sub

    ' a simple search using S.DS
    Public Sub DsSearchExample()
        Using root As New DirectoryEntry("LDAP://dc=fabrikam,dc=com")
            Using searcher As New DirectorySearcher(root)
                searcher.SearchScope = SearchScope.Subtree
                searcher.Filter = "(&(objectCategory=person)(objectClass=user)(name=user*)(userAccountControl:1.2.840.113556.1.4.803:=2))"
                Dim results As SearchResultCollection = searcher.FindAll()

                For Each result As SearchResult In results

                    Console.WriteLine(result.Path)
                Next
            End Using
        End Using
    End Sub

    'Public Sub refresh_cfo_list()

    '    Dim path As String
    '    Dim strcsv As String
    '    Dim apppath As String
    '    Dim Fldr As Outlook.Folder
    '    Dim olApp As New Outlook.Application
    '    Dim olCi As Outlook.ContactItem
    '    Dim OutNS As Outlook.NameSpace

    '    On Error Resume Next

    '    OutNS = olApp.GetNamespace("MAPI")
    '    OutNS.Logon(, , True, True)

    '    Fldr = OutNS.Folders("Public Folders").Folders("All Public Folders").Folders("BR_Accountant-General").Folders("Contacts")

    '    apppath = System.AppDomain.CurrentDomain.BaseDirectory

    'If Not System.IO.Directory.Exists(apppath & "CFO Lists") Then
    '   System.IO.Directory.CreateDirectory(apppath & "CFO Lists",AddSecurityAccessRule())
    'else
    'System.IO.Directory.CreateDirectory(apppath & "CFO Lists",AddSecurityAccessRule())
    'End If

    '    path = apppath & "CFO_List.csv"

    '    If File.Exists(path) Then
    '        File.Delete(path)
    '    End If

    '    Dim sw As StreamWriter = File.CreateText(path)

    '    strcsv = ""
    '    sw.WriteLine("Dept_Code," & _
    '                 "Fullname," & _
    '                 "CompanyName," & _
    '                 "Email1Address," & _
    '                 "NAT_PROV_ID," & _
    '                 "VoteID," & _
    '                 "FirstName," & _
    '                 "BusinessTelephoneNumber," & _
    '                 "Gender," & _
    '                 "Initials," & _
    '                 "BusinessAddress," & _
    '                 "BusinessFaxNumber," & _
    '                 "JobTitle," & _
    '                 "LastName")
    '    strcsv = ""
    '    Dim i As Integer
    '    For Each item In Fldr.Items

    '        strcsv = ""
    '        strcsv = strcsv & Chr(34) & item.user4.Trim & "" & Chr(34) & ","
    '        strcsv = strcsv & Chr(34) & item.FullName.Trim & "" & Chr(34) & ","
    '        strcsv = strcsv & Chr(34) & Item.CompanyName.Trim & "" & Chr(34) & ","
    '        strcsv = strcsv & Chr(34) & item.Email1Address.Trim & "" & Chr(34) & ","
    '        strcsv = strcsv & Chr(34) & item.user1.Trim & "" & Chr(34) & ","
    '        strcsv = strcsv & Chr(34) & item.user2.Trim & "" & Chr(34) & ","
    '        strcsv = strcsv & Chr(34) & item.FirstName.Trim & "" & Chr(34) & ","
    '        strcsv = strcsv & Chr(34) & item.BusinessTelephoneNumber.Trim & "" & Chr(34) & ","
    '        strcsv = strcsv & Chr(34) & item.Gender.ToString.Trim & "" & Chr(34) & ","
    '        strcsv = strcsv & Chr(34) & item.Initials.Trim & "" & Chr(34) & ","
    '        strcsv = strcsv & Chr(34) & item.BusinessAddress.Trim & "" & Chr(34) & ","
    '        strcsv = strcsv & Chr(34) & item.BusinessFaxNumber.Trim & "" & Chr(34) & ","
    '        strcsv = strcsv & Chr(34) & item.JobTitle.Trim & "" & Chr(34) & ","
    '        strcsv = strcsv & Chr(34) & item.LastName.Trim & "" & Chr(34) & ","

    '        sw.WriteLine(strcsv.Trim)

    '    Next

    '    OutNS.Logoff()

    '    sw.Flush()
    '    sw.Close()

    '    If File.Exists(path) Then
    '        Process.Start(path)
    '    End If

    '    olCi = Nothing
    '    Fldr = Nothing
    '    olNs = Nothing
    '    olApp = Nothing

    'End Sub

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

        Dim pDept_Code As New SqlParameter("@Dept_Code", SqlDbType.VarChar, 15)
        Dim pFullname As New SqlParameter("@Fullname", SqlDbType.VarChar, 50)
        Dim pCompanyName As New SqlParameter("@CompanyName", SqlDbType.VarChar, 50)
        Dim pEmail1Address As New SqlParameter("@Email1Address ", SqlDbType.VarChar, 150)
        Dim pNAT_PROV_ID As New SqlParameter("@NAT_PROV_ID", SqlDbType.BigInt)
        Dim pVoteID As New SqlParameter("@VoteID", SqlDbType.BigInt)
        Dim pFirstName As New SqlParameter("@FirstName", SqlDbType.VarChar, 50)
        Dim pBusinessTelephoneNumber As New SqlParameter("@BusinessTelephoneNumber", SqlDbType.VarChar, 50)
        Dim pGender As New SqlParameter("@Gender", SqlDbType.VarChar, 50)
        Dim pInitials As New SqlParameter("@Initials", SqlDbType.VarChar, 50)
        Dim pLastname As New SqlParameter("@Lastname", SqlDbType.VarChar, 50)
        Dim pBusinessAddress As New SqlParameter("@BusinessAddress", SqlDbType.VarChar, 50)
        Dim pBusinessFaxNumber As New SqlParameter("@BusinessFaxNumber", SqlDbType.VarChar, 50)

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



    End Function

End Module
