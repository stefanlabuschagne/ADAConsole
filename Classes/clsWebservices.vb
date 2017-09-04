Imports System.IO
Imports System.Text
Imports System.Reflection
Imports System.Diagnostics
Imports System.Web.Services
Imports System.Data.SqlClient
Imports System.Xml.Serialization
Imports Microsoft.SqlServer.Server
Imports System.Text.RegularExpressions

Namespace ARSWS

    Partial Public Class Webpage

        Friend WithEvents view As Global.ADAdminDotNet.Dept
        Friend WithEvents ta_view As Global.ADAdminDotNet.DeptTableAdapters.View_Nat_All_Discr_VoteTableAdapter
        Private strRequestsNoURL As String
        Private Aruser As String = My.MySettings.Default.ARUser.Trim
        Dim ARPassword As String = My.MySettings.Default.ARPassword.Trim
        Dim WhoAmI As String = GetUsername()


        ' Dim e As New ARSWS.Webpage
        Dim enveron As New RemedyEnvironment.Environment

        Public Function Open_All_Requests_For_PersalNo(ByVal strPersalNo As String, ByVal Environment As String) As Process

            Dim ARSCustomerInfo As Object = enveron.CreateInstance(Environment)
            Dim AI As Object = Me.enveron.GetAuthenticationInfo(Environment)
            Dim Query_OutputMap As Object = enveron.getListOp(Environment)


            AI.userName = Aruser
            AI.password = ARPassword
            ARSCustomerInfo.AuthenticationInfoValue = AI

            Dim rRequestsNoURL As String = ""
            'rRequestsNoURL = "http://devlgremv1/arsys/forms/prodlgremv1/LOG_IN_Request+Tracking/Default+Administrator+View/?cacheid=87086f26&server=prodlgremv1&username=" & username & "&pwd=" & password & "&qual=%27Persal+Number%27+%3D+%22" & strPersalNo & "%22"

            rRequestsNoURL = "http://" & My.MySettings.Default.ARSServerName.Trim & "/arsys/forms/" & My.MySettings.Default.ARSServerName.Trim & "/LOG_IN_Request+Tracking/Default+Administrator+View/?cacheid=87086f26&server=" & My.MySettings.Default.ARSServerName.Trim & "&username=" & _
              Aruser.Trim & "&pwd=" & ARPassword.Trim & "&qual=%27Persal+Number%27+%3D+%22" & strPersalNo.Trim & "%22"

            Dim p As New ProcessStartInfo
            p.FileName = My.MySettings.Default.WebBrowserEXE
            p.Arguments = rRequestsNoURL
            Return Process.Start(p)

        End Function

        Public Function Open_Request_No(ByVal strRequestNo As String, ByVal Environment As String) As Process

            Dim ARSCustomerInfo As Object = enveron.CreateInstance(Environment)
            Dim AI As Object = Me.enveron.GetAuthenticationInfo(Environment)
            Dim Query_OutputMap As Object = enveron.getListOp(Environment)


            AI.userName = Aruser
            AI.password = ARPassword
            ARSCustomerInfo.AuthenticationInfoValue = AI



            If (Environment.Contains("- QA")) Then

                Dim rRequestsNoURL As String = "http://" & My.MySettings.Default.ARSServerDevelopment.Trim & _
                           "/arsys/forms/" & My.MySettings.Default.ARSServerDevelopment.Trim & _
                           "/LOG_IN_Request+Tracking/Default+Administrator+View/?server=" & My.MySettings.Default.ARSServerDevelopment.Trim & _
                           "&username=" & My.MySettings.Default.ARUser.Trim & _
                           "&pwd=" & My.MySettings.Default.ARPassword.Trim & _
                           "&qual=%27Request+No%27+%3D+%22" & strRequestNo.Trim & "%22"

                Process.Start(rRequestsNoURL)

            ElseIf (Environment.Contains("- PRD")) Then




                Dim rRequestsNoURL As String = "http://" & My.MySettings.Default.ARSServerName.Trim & _
                                         "/arsys/forms/" & My.MySettings.Default.ARSServerName.Trim & _
                                         "/LOG_IN_Request+Tracking/Default+Administrator+View/?server=" & My.MySettings.Default.ARSServerName.Trim & _
                                         "&username=" & My.MySettings.Default.ARUser.Trim & _
                                         "&pwd=" & My.MySettings.Default.ARPassword.Trim & _
                                         "&qual=%27Request+No%27+%3D+%22" & strRequestNo.Trim & "%22"

                Process.Start(rRequestsNoURL)



            End If

        End Function



        Public Sub OpenInWebBrowser(ByVal rRequestsNoURL As String)
            Dim p As New ProcessStartInfo
            p.FileName = My.MySettings.Default.WebBrowserEXE.ToString.Trim
            If File.Exists(p.FileName) Then
                p.Arguments = rRequestsNoURL
                Process.Start(p)
            Else
                MsgBox("Web browser as defined in your Configuration Settings cannot be located", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Configuration Issue")
                Exit Sub
            End If
        End Sub



        Public Function IsOnRemedy(ByVal PersalNo As String, ByVal environment As String) As Boolean
            Dim Returned_Persal_Number As String
            Dim NorecordFound As Boolean = False

            Dim ARSCustomerInfo As Object = enveron.CreateInstance(environment)
            Dim AI As Object = Me.enveron.GetAuthenticationInfo(environment)
            Dim Query_OutputMap As Object = enveron.getListOp(environment)

            ARSCustomerInfo.AuthenticationInfoValue = AI
            AI.userName = Aruser
            AI.password = ARPassword
            ARSCustomerInfo.AuthenticationInfoValue = AI

            Try
                Dim persal As String = "'Persal Number' LIKE """ + PersalNo + """"
                Query_OutputMap = ARSCustomerInfo.GetList(persal, "0", "2000")

                If Query_OutputMap Is Nothing Then
                    Return False
                Else
                    Return True

                End If
            Catch ex As Exception
                ' MessageBox.Show("User Does Not Exist on Remedy")
                Exit Function
            End Try
        End Function


        'Create a new user
        Public Sub Create_New_user(ByVal persalnumber As String, ByVal Environment As String)



            Me.Open_Customer_Information(persalnumber, Environment)







            'Dim ARSCustomerInfo As Object = enveron.CreateInstance(Environment)
            'Dim AI As Object = Me.enveron.GetAuthenticationInfo(Environment)
            'Dim Query_OutputMap As Object = enveron.getListOp(Environment)

            'Dim strFirstName As String = StrConv(frmNewUsers.VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("Firstname").Value.ToString().Trim, VbStrConv.ProperCase)
            '' Dim strLastName As String = "test"'
            'Dim strLastName As String = frmNewUsers.VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("Surname").Value.ToString().Trim
            'Dim strTitle As String = frmNewUsers.VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("Title").Value.ToString().Trim
            'Dim strResponsibility As String = frmNewUsers.VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("Responsibility").Value.ToString().Trim
            'Dim strOfficeNo As String = frmNewUsers.VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("TelB").Value.ToString().Trim
            'Dim strCell As String = frmNewUsers.VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("Cell").Value.ToString().Trim
            'Dim strFax As String = frmNewUsers.VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("Fax").Value.ToString().Trim
            'Dim strDeptName As String = frmNewUsers.VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("Dept").Value.ToString().Trim
            'Dim strDept As String = frmNewUsers.VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("Department").Value.ToString().Trim
            'Dim strRank As String = frmNewUsers.VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("Rank").Value.ToString().Trim
            'Dim strProvince As String = frmNewUsers.VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("Province").Value.ToString().Trim
            'Dim strEmail As String = frmNewUsers.VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("Email").Value.ToString().Trim
            'Dim strComment As String = frmNewUsers.VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("Notes").Value.ToString().Trim
            'Dim strHr As String = frmNewUsers.VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("HR").Value.ToString().Trim
            'Dim strFIN As String = frmNewUsers.VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("FIN").Value.ToString().Trim
            'Dim strGFS As String = frmNewUsers.VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("GFS").Value.ToString().Trim
            'Dim strDPSA As String = frmNewUsers.VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("DPSA").Value.ToString().Trim
            'Dim strinitials As String = ""
            'Dim strDeptType As String = ""
            'Dim rank As String = ""
            'Dim strDepartment As String = ""
            'Dim departmentname As String = ""
            'Dim strStroreNumber As String
            'Dim strCiyt As String
            'Dim Province As String
            'Dim VulGroup As String = "VULINDLELA"
            'Dim ta_Vul_Rem_Dept As Global.ADAdminDotNet.dsVIP_EXPANDEDTableAdapters.VUL_REM_DEPT_MAPTableAdapter
            'ta_Vul_Rem_Dept = New Global.ADAdminDotNet.dsVIP_EXPANDEDTableAdapters.VUL_REM_DEPT_MAPTableAdapter
            'Dim da_Vul_Rem_Dept As Global.ADAdminDotNet.dsVIP_EXPANDED.VUL_REM_DEPT_MAPDataTable

            'AI.userName = Aruser
            'AI.password = ARPassword
            'ARSCustomerInfo.AuthenticationInfoValue = AI

            'If Environment.Contains("- QA") Then
            '    ta_Vul_Rem_Dept.Connection.ConnectionString = My.MySettings.Default("VIP_EXPANDEDQAConnectionString2014")
            'Else
            '    ta_Vul_Rem_Dept.Connection.ConnectionString = My.MySettings.Default("VIP_EXPANDEDQAConnectionString2014")
            'End If


            'Try
            '    'This code create new user if  the user doesn’t  exist on remedy
            '    If (IsOnRemedy(persalnumber, Environment)) Then
            '        'IF user exist check for changes and update
            '        Dim Qualification As String = "'Persal Number' LIKE """ + persalnumber + """"
            '        Dim msgString As String = ""
            '        Dim lastnamemsg, emailmsg, faxmsg, officenomsg, stringBuilder As String
            '        Query_OutputMap = ARSCustomerInfo.GetList(Qualification, "0", "1")
            '        Dim LastName = "", Email = "", Fax = "", cell = "", officeNo = "", LastModifiedby = "", entryid = "", deptname As String
            '        entryid = Query_OutputMap(0).Entry_ID
            '        LastName = Query_OutputMap(0).Last_Name
            '        Email = Query_OutputMap(0).EMail
            '        cell = Query_OutputMap(0).Cellphone
            '        officeNo = Query_OutputMap(0).Telephone
            '        deptname = Query_OutputMap(0).Department_Name
            '        Fax = Query_OutputMap(0).Fax_Number
            '        entryid = Query_OutputMap(0).Entry_ID


            '        If (Fax Is Nothing) Then
            '            Fax = ""
            '        Else
            '            Fax = Fax
            '        End If

            '        If (cell Is Nothing) Then
            '            cell = ""
            '        Else
            '            cell = cell
            '        End If

            '        If (LastName.ToLower = strLastName.ToLower) And (Email.ToLower = strEmail.ToLower) And (Fax.ToLower = strFax.ToLower) And (officeNo.ToLower = strOfficeNo.ToLower) Then
            '            Open_Customer_Information(persalnumber, Environment)

            '        Else

            '            If (LastName.length > 0) And (LastName.ToLower > strLastName.ToLower) Then

            '                lastnamemsg = Chr(13) & Chr(10) & Chr(13) & Chr(10) & "OLD Surname :" & LastName & Chr(13) & Chr(10) & _
            '                              "NEW Surname :" & strLastName & Chr(13) & Chr(10)
            '            Else

            '                lastnamemsg = ""

            '            End If


            '            If (LastName.Length > 0) And (LastName.ToLower > strLastName.ToLower) Then

            '                lastnamemsg = Chr(13) & Chr(10) & "OLD Surname :" & LastName & Chr(13) & Chr(10) & _
            '                              "NEW Surname :" & strLastName & Chr(13) & Chr(10)
            '            Else

            '                lastnamemsg = ""

            '            End If


            '            If (Email.Length > 0) And (Email.ToLower > strEmail.ToLower) Then

            '                emailmsg = Chr(13) & Chr(10) & "OLD Email :" & Email & Chr(10) & _
            '                           "NEW Email :" & strEmail & Chr(13) & Chr(10)
            '            Else
            '                emailmsg = ""
            '            End If


            '            If (Fax.Length > 0) And (Fax.ToLower > strFax.ToLower) Then

            '                faxmsg = Chr(13) & Chr(10) & "OLD Fax :" & Fax & Chr(10) & _
            '                          "NEW Fax :" & strFax & Chr(13) & Chr(10)
            '            Else
            '                faxmsg = ""


            '            End If

            '            If (officeNo.Length > 0) And (officeNo.ToLower > strOfficeNo.ToLower) Then

            '                officenomsg = Chr(13) & Chr(10) & "OLD OFFICE NO. :" & officeNo & Chr(10) & _
            '                          "NEW OFFICE NO :" & strOfficeNo & Chr(13) & Chr(10)
            '            Else
            '                officenomsg = ""

            '            End If


            '            stringBuilder = lastnamemsg & emailmsg & faxmsg & officenomsg


            '            If stringBuilder <> Nothing Then
            '                If MsgBox("The following changes have been made to Customer's Information: " & Chr(13) & Chr(10) & stringBuilder & Chr(13) & Chr(10) & _
            '                 " Click Yes to update the above automatically, or No to update manually?", MsgBoxStyle.YesNo, "System Message") = MsgBoxResult.Yes Then
            '                    Me.Modify_Customer(persalnumber, entryid, Environment)
            '                    'Open_Customer_Information(persalnumber, Environment)
            '                Else
            '                    Open_Customer_Information(persalnumber, Environment)
            '                End If

            '            Else
            '                Open_Customer_Information(persalnumber, Environment)

            '            End If





            '        End If
            '    Else

            '        'Create None Gorverment Employees
            '        If persalnumber.Length = 13 Then

            '            If (strProvince = "National Departments") Then
            '                strDeptType = "National"
            '            Else
            '                strDeptType = frmNewUsers.VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("Province").Value.ToString
            '            End If



            '            Dim strNote As String = strComment
            '            Dim intlength As Integer = strNote.Length
            '            Dim intNumber As Integer = InStr(strNote, "s Motivation")

            '            Dim difference As String = intlength - intNumber
            '            Dim strNotes As String = LTrim(strNote.Substring(intNumber, difference))
            '            Dim strname As String = strFirstName + " " + strLastName
            '            Dim comment As String = "ID/Passport: " + persalnumber + ",  " + strNotes
            '            Dim q As String = """"
            '            comment = Regex.Replace(comment, "[^A-Za-z0-9\-/:,]", " ")
            '            Dim Motivation As String = ""
            '            If (comment.Length > 250) Then
            '                Motivation = (comment.Substring(1, 250))
            '            Else
            '                Motivation = comment
            '            End If
            '            Dim VulRole As String = "other"
            '            Dim strSystemgroup As String = "VULINDLELA"

            '            Try


            '                If Environment.Contains("- QA") Then

            '                    strRequestsNoURL = "http://devlgremv1/arsys/servlet/ViewFormServlet?form=LOG_DM_Customer+Information&server=devlgremv1&mode=Submit&username=" & _
            '                                  Aruser & "&pwd=" & ARPassword & "&F536870917=" & strFirstName & "&F536870918=" & strLastName & "&F536870926=" & strTitle & "&F536870923=" & strOfficeNo & "&F536870925=" & strEmail & "&F536870937=" & strRank & "&F536870967=" & strResponsibility & "&F536870979=" & strCell & "&F4=" & strDeptName & "&F536870928=" & strDeptType & "&F536870929=" & VulRole & "&F536870964=" & strSystemgroup & "&F536870931=" & Motivation & "&F536870930=" & strinitials
            '                    Process.Start(strRequestsNoURL)



            '                ElseIf Environment.Contains("- PRD") Then

            '                    strRequestsNoURL = "http://prodlgremv1/arsys/servlet/ViewFormServlet?form=e+Information&server=prodlgremv1&mode=Submit&username=" & _
            '                                  Aruser & "&pwd=" & ARPassword & "&F536870917=" & strFirstName & "&F536870918=" & strLastName & "&F536870926=" & strTitle & "&F536870923=" & strOfficeNo & "&F536870925=" & strEmail & "&F536870937=" & strRank & "&F536870967=" & strResponsibility & "&F536870979=" & strCell & "&F4=" & strDeptName & "&F536870928=" & strDeptType & "&F536870929=" & VulRole & "&F536870964=" & strSystemgroup & "&F536870931=" & Motivation & "&F536870930=" & strinitials
            '                    Process.Start(strRequestsNoURL)

            '                End If

            '            Catch ex As Exception
            '                MessageBox.Show(ex.Message)
            '            End Try 

            '        Else



            '            If (strRank = "") Then
            '                rank = "other"
            '            Else
            '                rank = strRank
            '            End If




            '            If (strDeptName Is Nothing) Then
            '                strDepartment = "None"

            '            Else

            '                If (strDeptName.Contains("Vote")) Then
            '                    strDeptName = LTrim(strDeptName.Substring(strDeptName.IndexOf(":"c) + 1))
            '                End If

            '                If (((ta_Vul_Rem_Dept.GetStoreNo(strDeptName, strProvince))) Is Nothing) Then
            '                    MessageBox.Show("Please make sure that the Department is on both remedy and Vulindlela")
            '                    Exit Sub

            '                Else
            '                    strStroreNumber = (ta_Vul_Rem_Dept.GetStoreNo(strDeptName, strProvince))
            '                    strDepartment = ta_Vul_Rem_Dept.GetARDepartmentName(strStroreNumber, strProvince)
            '                    strDeptType = ta_Vul_Rem_Dept.GetRem_Dept_Name(strStroreNumber, strProvince)

            '                End If

            '            End If




            '            Dim strRole As String = strResponsibility
            '            Dim Role As String
            '            Dim comment As String = ""

            '            If (strRole.Contains(",")) Then
            '                Dim intlen As Integer = strRole.Length
            '                Dim intNo As Integer = InStr(strRole, ",")

            '                Dim differences As String = intlen - intNo
            '                Dim RolefoComment As String = LTrim(strRole.Substring(intNo, differences))
            '                comment = "Additional Role(s): " + RolefoComment
            '                Dim maxvalue As Integer = intNo - 1
            '                Role = strRole.Substring(0, maxvalue)
            '            Else
            '                Role = strRole
            '            End If



            '            Dim strNote As String = strComment
            '            Dim intlength As Integer = strNote.Length
            '            Dim intNumber As Integer = InStr(strNote, "s Motivation")

            '            Dim difference As String = intlength - intNumber
            '            Dim strNotes As String = LTrim(strNote.Substring(intNumber, difference))



            '            Dim VulRole As String = "other"
            '            Dim strSystemgroup As String = "VULINDLELA"




            '            If MsgBox("New user will be added on Remedy, Do you want to continue?", MsgBoxStyle.YesNo, "System Message") = MsgBoxResult.Yes Then
            '            Else
            '                Exit Sub
            '            End If
            '            ' Dim aa As String = ARSCustomerInfo.Create(Aruser, strDepartment, Record_StatusType.Incomplete, StrConv(persalnumber, VbStrConv.ProperCase), strFirstName, StrConv(strLastName, VbStrConv.ProperCase), strOfficeNo, strFax, strEmail, strTitle, strDeptType, Role, "", comment, "", Remote_Access_AvailabilityType.Inactive, "", rank, "", 0, True, "", "", DateTime.Now, True, "", strCiyt, Province, "", "", "", "", "", "", "", "", strStroreNumber, "", "", "", "", Role, "", strCell, "", "", "", "", "", "", "", "", "", "", "", "", zDispInternal_Type.Yes, True, "", "", "", "")

            '            Me.Open_Customer_Information(persalnumber, Environment)


            '        End If



            '    End If


            'Catch ex As Exception
            '    MessageBox.Show(ex.Message)
            'End Try

        End Sub


        Public Sub Reset_Password(ByVal strPersalNumber As String, ByVal Environment As String)



            Me.Open_Customer_Information(strPersalNumber, Environment)


            'Dim ARSCustomerInfo As Object = enveron.CreateInstance(Environment)
            'Dim AI As Object = Me.enveron.GetAuthenticationInfo(Environment)
            'Dim Query_OutputMap As Object = enveron.getListOp(Environment)

            'AI.userName = Aruser
            'AI.password = ARPassword
            'ARSCustomerInfo.AuthenticationInfoValue = AI



            'Dim strID As String = frmResetPassword.VIP_USERS_ResetPasswordDataGridView.CurrentRow.Cells("IDDataGridViewTextBoxColumn").Value.ToString().Trim
            'Dim strFirstName As String = frmResetPassword.VIP_USERS_ResetPasswordDataGridView.CurrentRow.Cells("FirstnameDataGridViewTextBoxColumn").Value.ToString().Trim
            'Dim strLastName As String = frmResetPassword.VIP_USERS_ResetPasswordDataGridView.CurrentRow.Cells("SurnameDataGridViewTextBoxColumn").Value.ToString().Trim
            'Dim strTitle As String = frmResetPassword.VIP_USERS_ResetPasswordDataGridView.CurrentRow.Cells("TitleDataGridViewTextBoxColumn").Value.ToString().Trim
            'Dim strResponsibility As String = frmResetPassword.VIP_USERS_ResetPasswordDataGridView.CurrentRow.Cells("ResponsibilityDataGridViewTextBoxColumn").Value.ToString().Trim
            'Dim strOfficeNo As String = frmResetPassword.VIP_USERS_ResetPasswordDataGridView.CurrentRow.Cells("TelBDataGridViewTextBoxColumn").Value.ToString().Trim
            'Dim strCell As String = frmResetPassword.VIP_USERS_ResetPasswordDataGridView.CurrentRow.Cells("CellDataGridViewTextBoxColumn").Value.ToString().Trim
            'Dim strFax As String = frmResetPassword.VIP_USERS_ResetPasswordDataGridView.CurrentRow.Cells("FaxDataGridViewTextBoxColumn").Value().ToString().Trim
            'Dim strDeptName As String = frmResetPassword.VIP_USERS_ResetPasswordDataGridView.CurrentRow.Cells("DeptDataGridViewTextBoxColumn").Value.ToString().Trim
            'Dim strDept As String = frmResetPassword.VIP_USERS_ResetPasswordDataGridView.CurrentRow.Cells("DeptDataGridViewTextBoxColumn").Value.ToString().Trim
            'Dim strRank As String = frmResetPassword.VIP_USERS_ResetPasswordDataGridView.CurrentRow.Cells("RankDataGridViewTextBoxColumn").Value.ToString().Trim
            'Dim strProvince As String = frmResetPassword.VIP_USERS_ResetPasswordDataGridView.CurrentRow.Cells("ProvinceDataGridViewTextBoxColumn").Value.ToString().Trim
            'Dim strEmail As String = frmResetPassword.VIP_USERS_ResetPasswordDataGridView.CurrentRow.Cells("EmailDataGridViewTextBoxColumn").Value.ToString().Trim
            'Dim strComment As String = frmResetPassword.VIP_USERS_ResetPasswordDataGridView.CurrentRow.Cells("NotesDataGridViewTextBoxColumn").Value.ToString().Trim
            'Dim strHr As String = frmResetPassword.VIP_USERS_ResetPasswordDataGridView.CurrentRow.Cells("HRDataGridViewTextBoxColumn").Value.ToString().Trim
            'Dim strFIN As String = frmResetPassword.VIP_USERS_ResetPasswordDataGridView.CurrentRow.Cells("FINDataGridViewTextBoxColumn").Value.ToString().Trim
            'Dim strGFS As String = frmResetPassword.VIP_USERS_ResetPasswordDataGridView.CurrentRow.Cells("GFSDataGridViewTextBoxColumn").Value.ToString().Trim
            'Dim strDPSA As String = frmResetPassword.VIP_USERS_ResetPasswordDataGridView.CurrentRow.Cells("DPSADataGridViewTextBoxColumn").Value.ToString().Trim
            'Dim strDeptType As String = ""
            'Dim rank As String = ""
            'Dim strDepartment As String = ""
            'Dim departmentname As String = ""
            'Dim strStroreNumber As String
            'Dim strCiyt As String
            'Dim Province As String
            'Dim VulGroup As String = "VULINDLELA"



            'If (IsOnRemedy(strPersalNumber, Environment)) Then

            '    Dim Qualification As String = "'Persal Number' LIKE """ + strPersalNumber + """"
            '    Query_OutputMap = ARSCustomerInfo.GetList(Qualification, "0", "1")
            '    Dim LastName, Email, Fax, cell, officeNo, LastModifiedby, entryid, deptname As String
            '    Dim lastnamemsg, emailmsg, faxmsg, officenomsg, stringBuilder As String
            '    entryid = Query_OutputMap(0).Entry_ID
            '    LastName = Query_OutputMap(0).Last_Name
            '    Email = Query_OutputMap(0).EMail
            '    cell = Query_OutputMap(0).Cellphone
            '    officeNo = Query_OutputMap(0).Telephone
            '    deptname = Query_OutputMap(0).Department_Name
            '    Fax = CStr(Query_OutputMap(0).Fax_Number)



            '    entryid = Query_OutputMap(0).Entry_ID




            '    If (Fax Is Nothing) Then
            '        Fax = ""
            '    Else
            '        Fax = Fax
            '    End If

            '    If (cell Is Nothing) Then
            '        cell = ""
            '    Else
            '        cell = cell
            '    End If



            '    ' If (String.Compare(LastName.ToLower, strLastName.ToLower, False) Or String.Compare(Email.ToLower, strEmail.ToLower, False) Or String.Compare(Fax, strFax, False) Or String.Compare(officeNo, strOfficeNo, False)) Then
            '    If (LastName.ToLower = strLastName.ToLower) And (Email.ToLower = strEmail.ToLower) And (cell.ToLower = strCell.ToLower) And (Fax.ToLower = strFax.ToLower) And (officeNo.ToLower = strOfficeNo.ToLower) Then
            '        Try
            '            Open_Customer_Information(strPersalNumber, Environment)
            '        Catch ex As Exception

            '        End Try

            '    Else
            '        entryid = Query_OutputMap(0).Entry_ID

            '        If (LastName.Length > 0) And (LastName.ToLower > strLastName.ToLower) Then

            '            lastnamemsg = Chr(13) & Chr(10) & "OLD Surname :" & LastName & Chr(13) & Chr(10) & _
            '                          "NEW Surname :" & strLastName & Chr(13) & Chr(10)
            '        Else

            '            lastnamemsg = ""

            '        End If


            '        If (Email.Length > 0) And (Email.ToLower > strEmail.ToLower) Then

            '            emailmsg = Chr(13) & Chr(10) & "OLD Email :" & Email & Chr(10) & _
            '                       "NEW Email :" & strEmail & Chr(13) & Chr(10)
            '        Else
            '            emailmsg = ""
            '        End If


            '        If (Fax.Length > 0) And (Fax.ToLower > strFax.ToLower) Then

            '            faxmsg = Chr(13) & Chr(10) & "OLD Fax :" & Fax & Chr(10) & _
            '                      "NEW Fax :" & strFax & Chr(13) & Chr(10)
            '        Else
            '            faxmsg = ""


            '        End If

            '        If (officeNo.Length > 0) And (officeNo.ToLower > strOfficeNo.ToLower) Then

            '            officenomsg = Chr(13) & Chr(10) & "OLD OFFICE NO. :" & officeNo & Chr(10) & _
            '                      "NEW OFFICE NO :" & strOfficeNo & Chr(13) & Chr(10)
            '        Else
            '            officenomsg = ""

            '        End If


            '        stringBuilder = lastnamemsg & emailmsg & faxmsg & officenomsg

            '        If stringBuilder <> Nothing Then

            '            If MsgBox("The following changes have been made to Customer's Information: " & Chr(13) & Chr(10) & stringBuilder & Chr(13) & Chr(10) & _
            '                      " Click Yes to update the above automatically, or No to update manually?", MsgBoxStyle.YesNo, "System Message") = MsgBoxResult.Yes Then
            '                Me.Modify_Customer_reset_pass(strPersalNumber, entryid, Environment)
            '            Else
            '                Open_Customer_Information(strPersalNumber, Environment)
            '            End If
            '        End If
            '    End If

            'Else
            '    'MessageBox.Show("user does no exist on remedy")


            'End If



        End Sub

        Public Sub Modify_Customer_reset_pass(ByVal PersalNumber As String, ByVal _Entry_ID As String, ByVal Environment As String)
            Me.Open_Customer_Information(PersalNumber, Environment)
            'Dim ARSCustomerInfo As Object = enveron.CreateInstance(Environment)
            'Dim AI As Object = Me.enveron.GetAuthenticationInfo(Environment)
            'Dim Query_OutputMap As Object = enveron.getListOp(Environment)

            'ARSCustomerInfo.AuthenticationInfoValue = AI
            'AI.userName = Aruser
            'AI.password = ARPassword

            'Dim Qualification = "'Persal Number' LIKE """ + PersalNumber + """"
            'Query_OutputMap = ARSCustomerInfo.GetList(Qualification, "0", "10")


            'Dim strID As String = frmResetPassword.VIP_USERS_ResetPasswordDataGridView.CurrentRow.Cells("IDDataGridViewTextBoxColumn").Value.ToString().Trim
            'Dim strFirstName As String = Query_OutputMap(0).First_Name
            'Dim strLastName As String = frmResetPassword.VIP_USERS_ResetPasswordDataGridView.CurrentRow.Cells("SurnameDataGridViewTextBoxColumn").Value.ToString
            'Dim strTitle As String = Query_OutputMap(0).Title
            'Dim strResponsibility As String = Query_OutputMap(0).VULINDLELA_Role '
            'Dim strOfficeNo As String = frmResetPassword.VIP_USERS_ResetPasswordDataGridView.CurrentRow.Cells("TelBDataGridViewTextBoxColumn").Value.ToString
            'Dim strCell As String = frmResetPassword.VIP_USERS_ResetPasswordDataGridView.CurrentRow.Cells("CellDataGridViewTextBoxColumn").Value.ToString
            'Dim strFax As String = frmResetPassword.VIP_USERS_ResetPasswordDataGridView.CurrentRow.Cells("FaxDataGridViewTextBoxColumn").Value().ToString().Trim
            'Dim strDeptName As String = Query_OutputMap(0).Department_Name
            'Dim strDept As String = Query_OutputMap(0).Department_Type
            'Dim strRank As String = Query_OutputMap(0).Rank
            'Dim strProvince As String = Query_OutputMap(0).Province
            'Dim strEmail As String = frmResetPassword.VIP_USERS_ResetPasswordDataGridView.CurrentRow.Cells("EmailDataGridViewTextBoxColumn").Value.ToString
            'Dim strComment As String = Query_OutputMap(0).Comments
            'Dim strDeptType As String = ""
            'Dim rank As String = Query_OutputMap(0).Rank
            'Dim strDepartment As String = ""
            'Dim departmentname As String = ""
            'Dim strStroreNumber As String = Query_OutputMap(0).VULIN_Store_Number
            'Dim strCiyt As String = Query_OutputMap(0).City
            'Dim Province As String = Query_OutputMap(0).Province
            'Dim VulGroup As String = "VULINDLELA"
            'Dim strNickname As String = Query_OutputMap(0).Nickname
            'Dim strPostalCode As String = Query_OutputMap(0).Postal_Code
            'Dim strExtention As String = Query_OutputMap(0).Extension
            'Dim strBillingCode As String = Query_OutputMap(0).Billing_Code
            'Dim vulindleal_Role As String = Query_OutputMap(0).VULINDLELA_Role

            'Dim ta_Vul_Rem_Dept As Global.ADAdminDotNet.dsVIP_EXPANDEDTableAdapters.VUL_REM_DEPT_MAPTableAdapter
            'ta_Vul_Rem_Dept = New Global.ADAdminDotNet.dsVIP_EXPANDEDTableAdapters.VUL_REM_DEPT_MAPTableAdapter
            'Dim da_Vul_Rem_Dept As Global.ADAdminDotNet.dsVIP_EXPANDED.VUL_REM_DEPT_MAPDataTable


            ''If Environment.Contains("- QA") Then
            ''         ta_Vul_Rem_Dept.Connection.ConnectionString = My.MySettings.Default("VIP_EXPANDEDConnectionString2008QA")
            ''     Else
            ''         ta_Vul_Rem_Dept.Connection.ConnectionString = My.MySettings.Default("VIP_EXPANDEDConnectionString2008PRD")
            ''     End If




            ''ARSCustomerInfo.Set(StrConv(strLastName, VbStrConv.ProperCase), strOfficeNo, strFax, strEmail, strNickname, strCell, strExtention, strStroreNumber, _Entry_ID, vulindleal_Role, strTitle, strFirstName, StrConv(PersalNumber, VbStrConv.ProperCase))
            Me.Open_Customer_Information(PersalNumber, Environment)




        End Sub

        Public Sub Modify_Customer(ByVal PersalNumber As String, ByVal _Entry_ID As String, ByVal Environment As String)




            Me.Open_Customer_Information(PersalNumber, Environment) '    Dim ARSCustomerInfo As Object = enveron.CreateInstance(Environment)
            '    Dim AI As Object = Me.enveron.GetAuthenticationInfo(Environment)
            '    Dim Query_OutputMap As Object = enveron.getListOp(Environment)
            '    ' Dim Aruser As String = "T0008266"
            '    ' Dim ARPassword As String = "logik007"

            '    ARSCustomerInfo.AuthenticationInfoValue = AI
            '    AI.userName = Aruser
            '    AI.password = ARPassword

            '    Dim Qualification = "'Persal Number' LIKE """ + PersalNumber + """"
            '    Query_OutputMap = ARSCustomerInfo.GetList(Qualification, "0", "10")


            '    Dim strFirstName As String = Query_OutputMap(0).First_Name
            '    Dim strLastName As String = frmNewUsers.VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("Surname").Value.ToString().Trim
            '    Dim strTitle As String = Query_OutputMap(0).Title
            '    Dim strResponsibility As String = Query_OutputMap(0).VULINDLELA_Role
            '    Dim strOfficeNo As String = frmNewUsers.VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("TelB").Value.ToString().Trim
            '    Dim strCell As String = frmNewUsers.VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("Cell").Value.ToString().Trim
            '    Dim strFax As String = Query_OutputMap(0).Fax_Number
            '    Dim strDeptName As String = Query_OutputMap(0).Department_Name
            '    Dim strDept As String = Query_OutputMap(0).Department_Type
            '    Dim strRank As String = Query_OutputMap(0).Rank
            '    Dim strProvince As String = Query_OutputMap(0).Province
            '    Dim strEmail As String = frmNewUsers.VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("Email").Value.ToString().Trim
            '    Dim strComment As String = Query_OutputMap(0).Comments
            '    Dim strDeptType As String = ""
            '    Dim rank As String = Query_OutputMap(0).Rank
            '    Dim strDepartment As String = ""
            '    Dim departmentname As String = ""
            '    Dim strStroreNumber As String
            '    Dim strCiyt As String = Query_OutputMap(0).City
            '    Dim Province As String = Query_OutputMap(0).Province
            '    Dim VulGroup As String = "VULINDLELA"
            '    Dim strNickname As String = Query_OutputMap(0).Nickname
            '    Dim strPostalCode As String = Query_OutputMap(0).Postal_Code
            '    Dim strExtention As String = Query_OutputMap(0).Extension
            '    Dim strBillingCode As String = Query_OutputMap(0).Billing_Code
            '    Dim vulindleal_Role As String = Query_OutputMap(0).VULINDLELA_Role
            '    Dim StoreNumber As String = Query_OutputMap(0).VULIN_Store_Number




            '    Dim ta_Vul_Rem_Dept As Global.ADAdminDotNet.dsVIP_EXPANDEDTableAdapters.VUL_REM_DEPT_MAPTableAdapter
            '    ta_Vul_Rem_Dept = New Global.ADAdminDotNet.dsVIP_EXPANDEDTableAdapters.VUL_REM_DEPT_MAPTableAdapter
            '    Dim da_Vul_Rem_Dept As Global.ADAdminDotNet.dsVIP_EXPANDED.VUL_REM_DEPT_MAPDataTable

            '    If Environment.Contains("- QA") Then
            '        ta_Vul_Rem_Dept.Connection.ConnectionString = My.MySettings.Default("VIP_EXPANDEDQAConnectionString2014")
            '    Else
            '        ta_Vul_Rem_Dept.Connection.ConnectionString = My.MySettings.Default("ADSConnectionString2008PRD")
            '    End If
            '    ' ARSCustomerInfo.Set(strLastName, strOfficeNo, strFax, strEmail, strNickname, strCell, strExtention, StoreNumber, _Entry_ID, vulindleal_Role, strTitle, strFirstName, PersalNumber)
            '    Me.Open_Customer_Information(PersalNumber, Environment)

        End Sub

        Public Sub Open_Customer_Information(ByVal strPersalNumber As String, ByVal Environment As String)


            Dim ARSCustomerInfo As Object = enveron.CreateInstance(Environment)
            Dim AI As Object = Me.enveron.GetAuthenticationInfo(Environment)
            Dim Query_OutputMap1 As Object = enveron.getListOp(Environment)



            If Environment.Contains("- QA") Then

                Dim rRequestsNoURLs As String = "http://devlgremv1/arsys/servlet/ViewFormServlet?form=LOG_DM_Customer+Information&server=devlgremv1&username=" & _
                                                  Aruser & "&pwd=" & ARPassword & "&qual=%27Persal+Number%27" & "=" & "%22" & strPersalNumber & "%22"
                Process.Start(rRequestsNoURLs)


            ElseIf Environment.Contains("- PRD") Then

                Dim rRequestsNoURLs As String = "http://prodlgremv1/arsys/servlet/ViewFormServlet?form=LOG_DM_Customer+Information&server=prodlgremv1&username=" & _
                                                 Aruser & "&pwd=" & ARPassword & "&qual=%27Persal+Number%27" & "=" & "%22" & strPersalNumber & "%22"

                Process.Start(rRequestsNoURLs)


            End If


        End Sub


    End Class


End Namespace

Namespace ARSWS

    Partial Public Class Convert
        Private ARUser As String = My.MySettings.Default.ARUser.Trim
        Private ARPassword As String = My.MySettings.Default.ARPassword.Trim
        Private txtPersalNumber As String = frmMain.txtPersalNumber.Text
        Private RecMin As Integer = 1
        Private RecMax As Integer = 20
        Public _objectArray As [Object]()
        Private _values As Object
        Private _values1 As Object

        Public Sub New(ByVal objectArray__1 As [Object]())
            Me._objectArray = objectArray__1
        End Sub

        Private Property values(ByVal i As Integer) As Object
            Get
                Return _values1
            End Get
            Set(ByVal value As Object)
                _values1 = value
            End Set
        End Property

        Public Shared Sub Load(ByVal pDataColumnCollection As DataColumnCollection, ByVal pDataRow As DataRow, ByVal pObject As [Object])

            Dim t As Type = pObject.[GetType]()
            For i As Int32 = 0 To pDataColumnCollection.Count - 1
                Try
                    t.InvokeMember(pDataColumnCollection(i).ColumnName, BindingFlags.SetProperty, Nothing, pObject, New Object() {pDataRow(pDataColumnCollection(i).ColumnName)})
                Catch ex As Exception
                    If ex.ToString() IsNot Nothing Then
                    End If
                End Try
            Next

        End Sub

        Public Shared Function ObjArrayToDataSet(ByRef _ObjectArray As System.Array) As DataSet

            Dim dbs As New DataSet()
            Dim xmlSerializer As New XmlSerializer(_ObjectArray.[GetType]())
            Dim writer As New StringWriter()
            xmlSerializer.Serialize(writer, _ObjectArray)
            Dim reader As New StringReader(writer.ToString())
            dbs.ReadXml(reader)
            Return dbs


        End Function

        Public Function List_2_DataTable(Of T)(ByVal items As List(Of T)) As DataTable

            Dim values As Object
            Dim dataTable As New DataTable(GetType(T).Name)
            Dim Props As PropertyInfo() = GetType(T).GetProperties(BindingFlags.[Public] Or BindingFlags.Instance)
            For Each prop As PropertyInfo In Props
                dataTable.Columns.Add(prop.Name)
            Next
            For Each item As T In items
                values = New Object(Props.Length - 1) {}
                For i As Integer = 0 To Props.Length - 1
                    values(i) = Props(i).GetValue(item, Nothing)
                Next
                dataTable.Rows.Add(values)
            Next
            Return dataTable

        End Function

        Public Shared Sub Object_2_Table(ByVal pObject As [Object], ByRef pDataSet As DataSet, ByVal pTableName As [String])

            Dim t As Type = pObject.[GetType]()
            Dim tmpP As PropertyInfo() = t.GetProperties()
            If pDataSet.Tables(pTableName) Is Nothing Then
                pDataSet.Tables.Add(pTableName)
                For Each xtemp2 As PropertyInfo In tmpP
                    pDataSet.Tables(pTableName).Columns.Add(xtemp2.Name, xtemp2.PropertyType)
                Next
            End If
            Dim tmpObj As [Object]() = New [Object](tmpP.Length - 1) {}

            For i As Int32 = 0 To tmpObj.Length - 1
                tmpObj(i) = t.InvokeMember(tmpP(i).Name, BindingFlags.GetProperty, Nothing, pObject, New Object(-1) {})
            Next
            pDataSet.Tables(pTableName).LoadDataRow(tmpObj, True)

        End Sub




    End Class

End Namespace
