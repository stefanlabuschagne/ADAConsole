Imports System
Imports mshtml
Imports System.IO
Imports System.Web
Imports System.Text
Imports System.Net.Mail

Public Class frmNewUsers

    Public colVals As New Microsoft.VisualBasic.Collection
    Public strProfileRequested As String = ""

    Private Sub ExportToNewAccountRequestscsvToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportToNewAccountRequestscsvToolStripMenuItem.Click
        Dim mstr As String
        ExportCSV(Me.VIP_USERS_NewUsersTableAdapter.GetData(), AppPath() & "NewAccountRequests.csv")
        mstr = AppPath() & "NewAccountRequests.csv"
        If File.Exists(mstr) Then
            Process.Start(mstr)
        End If

    End Sub

    Private Sub frmNewUsers_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(27) Then
            Me.Close()
        End If
    End Sub


    Private Sub frmNewUsers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            VIP_USERS_NewUsersDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            Me.VIP_USERS_NewUsersTableAdapter.FillBy1(Me.Ads.VIP_USERS_NewUsers)
            Me.ta_Customer_Information.Fill(Me.ARSystemDataSet.LOG_DM_Customer_Information)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
           
    End Sub

    Private Sub frmOpenRequests_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Me.VIP_USERS_NewUsersDataGridView.Width = Me.Width - 9
        Me.VIP_USERS_NewUsersDataGridView.Height = Me.Height - 82
    End Sub

    Private Sub frmOpenRequests_ResizeEnd(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ResizeEnd
        Me.VIP_USERS_NewUsersDataGridView.Width = Me.Width - 9
        Me.VIP_USERS_NewUsersDataGridView.Height = Me.Height - 82
    End Sub

    Private Sub VIP_USERS_NewUsersDataGridView_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles VIP_USERS_NewUsersDataGridView.KeyUp
        If e.KeyValue = 27 Then
            Me.Close()
        End If
    End Sub

    Private Function CheckEstab(ByVal persalnumber As String) As Boolean
        CheckEstab = False
        If frmEnvironment.ChildFormPRD.Visible Then
            If Not String.IsNullOrEmpty(persalnumber) Then
                Return frmEnvironment.ChildFormPRD.IsOnEstablishment(persalnumber)
            Else
                Return False
            End If
        ElseIf frmEnvironment.childformQA.Visible Then
            If Not String.IsNullOrEmpty(persalnumber) Then
                Return frmEnvironment.childformQA.IsOnEstablishment(persalnumber)
            Else
                Return False
            End If
        End If
    End Function
    
    Public Function ParseFile_Email(ByVal TemplateFilePath As String, _
                          ByVal FieldAndValues As Collection, ByVal colTO As Collection, _
                          ByVal colCC As Collection, _
                          ByVal returnaddress As String, Optional ByVal subject As String = "") As String

        ParseFile_Email = ""
        Dim t As TextReader
        Dim i As Integer, j As Integer, a() As String, fil As String
        Dim EmailMessage As MailMessage = New MailMessage
        Dim thisusername As String
        Dim apppath As String
        Dim persalnumber As String

        apppath = System.AppDomain.CurrentDomain.BaseDirectory

        persalnumber = VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("Persalnr").Value.ToString

        If frmEnvironment.ChildFormPRD.Visible Then
            thisusername = Get_ValidUsername(persalnumber)
        Else
            thisusername = Get_ValidUsername(persalnumber)
        End If

        t = New StreamReader(apppath & TemplateFilePath & ".htt")
        fil = t.ReadToEnd
        t.Close()
        t.Dispose()

        For i = 1 To FieldAndValues.Count
            a = Split(FieldAndValues.Item(i).ToString, "~~")

            For j = 0 To UBound(a)
                If j Mod 2 = 0 Then
                    fil = Replace(fil, "[[" & a(j) & "]]", a(j + 1))
                End If
            Next
        Next i

        If colTO.Count > 0 Then
            For i = 1 To colTO.Count
                EmailMessage.To.Add(colTO(i).ToString.Trim)
            Next
        End If

        If colCC.Count > 0 Then
            For i = 1 To colCC.Count
                EmailMessage.CC.Add(colCC(i).ToString.Trim)
            Next
        End If

        EmailMessage.From = New MailAddress(returnaddress)
        If subject.Trim = "" Then
            EmailMessage.Subject = Replace(TemplateFilePath, ".htt", "") & " : " & thisusername.Trim
        Else
            EmailMessage.Subject = subject
        End If

        EmailMessage.Body = fil
        EmailMessage.Priority = MailPriority.High
        EmailMessage.IsBodyHtml = True

        Dim htmlView As AlternateView = AlternateView.CreateAlternateViewFromString(EmailMessage.Body, Nothing, "text/html")
        apppath = System.AppDomain.CurrentDomain.BaseDirectory
        Dim logo As New LinkedResource(apppath & "NTlogo.jpg")
        logo.ContentId = "ntlogo"
        htmlView.LinkedResources.Add(logo)
        EmailMessage.AlternateViews.Add(htmlView)

        Dim smtp As New SmtpClient(My.Settings.SMTPServerIPAddress.Trim)
        smtp.Send(EmailMessage)
        smtp = Nothing

    End Function

    'Private Sub VIP_USERS_NewUsersDataGridView_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles VIP_USERS_NewUsersDataGridView.CellDoubleClick

    '    Dim selectedrowindex As Integer
    '    selectedrowindex = VIP_USERS_NewUsersDataGridView.SelectedRows.Item(0).Index

    '    Dim i As Integer
    '    Dim a() As String
    '    Dim tbl1 As DataTable
    '    Dim persalnumber As String
    '    Dim subject As String = ""
    '    Dim tooltipstring As String = ""
    '    Dim returnaddress As String = ""
    '    Dim col As New Microsoft.VisualBasic.Collection
    '    Dim colCC As New Microsoft.VisualBasic.Collection
    '    Dim colTO As New Microsoft.VisualBasic.Collection
    '    'Added 2015/02/23
    '    Dim ARSCustomerInfo As New LOG_DM_Customer_Information_BasicWS__cService
    '    Dim AI As New AuthenticationInfo
    '    Dim Arpassword As String
    '    Dim Aruser As String





    '    Dim rRequestsNoURL As String

    '    Aruser = "Ronel.Ilsley"
    '    Arpassword = "logik007"

    '    AI.userName = Aruser
    '    AI.password = Arpassword
    '    ARSCustomerInfo.AuthenticationInfoValue = AI

    '    ' btnCustInfo_Click(sender, e)
    '    ' Me.WindowState = FormWindowState.Minimized

    '    'persalnumber = VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("PersalNr").Value.ToString

    '    'Added 2015/02/19
    '    Dim strFirstName As String = VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("Firstname").Value.ToString
    '    Dim strLastName As String = VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("Surname").Value.ToString
    '    Dim strTitle As String = VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("Title").Value.ToString
    '    Dim strResponsibility As String = "Other"
    '    'VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("Responsibility").Value.ToString
    '    Dim strOfficeNo As String = VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("TelB").Value.ToString
    '    Dim strCell As String = VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("Cell").Value.ToString
    '    Dim strFax As String = VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("Fax").Value.ToString
    '    Dim strDeptCode As String = VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("Dept").Value.ToString
    '    Dim strDept As String = VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("Department").Value.ToString
    '    Dim strRank As String = VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("Rank").Value.ToString
    '    Dim strProvince As String = VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("Province").Value.ToString
    '    Dim strEmail As String = VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("Email").Value.ToString
    '    Dim strComment As String = VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("Notes").Value.ToString
    '    Dim strHr As String = VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("HR").Value.ToString
    '    Dim strFIN As String = VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("FIN").Value.ToString
    '    Dim strGFS As String = VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("GFS").Value.ToString
    '    Dim strDPSA As String = VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("DPSA").Value.ToString
    '    Dim strP As String = "8801233456782"
    '    'btnCustInfo_Click(sender, e)
    '    'calling a persal number
    '    ' Dim ws As New ARSWS.Webpage

    '    'ws = New ARSWS.Webpage
    '    '  ws.Get_PersalNumber(strP)





    '    'Dim strRequestsNoURL As String = "http://prodlgremv1/arsys/servlet/ViewFormServlet?form=LOG_DM_Customer+Information&server=prodlgremv1&mode=Submit&username=" & _
    '    'strP & "&pwd=" & Arpassword & "&F8=" & strP & "&F536870917=" & strFirstName & "&F536870918=" & strLastName & "&536870926=" & strTitle & "&F536870931=" & strComment & "&F536870923=" & strOfficeNo & "&F536870925=" & strEmail & "&F536870937=" & strRank & "&F536870967=" & strResponsibility
    '    'Process.Start(strRequestsNoURL)


    '    Cleartxt = False
    '    persalnumber = "10058982"
    '    'VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("PersalNr").Value.ToString

    '    ' tbl1 = frmEnvironment.ChildFormPRD.ta_Vulindlela_Email.GetData("EMail To Verify Against Establishment")

    '    'If tbl1.Rows.Count > 0 Then
    '    '    subject = tbl1.Rows(0).Item("SUBJECT").ToString
    '    '    returnaddress = tbl1.Rows(0).Item("RETURN_ADDRESS").ToString

    '    '    a = Split(tbl1.Rows(0).Item("TO_ADDRESS").ToString, ";")
    '    '    If a(0) <> "" Then
    '    '        For i = 0 To UBound(a)
    '    '            colTO.Add(a(i))
    '    '        Next
    '    '    End If

    '    '    a = Split(tbl1.Rows(0).Item("CC_ADDRESS").ToString, ";")

    '    '    If a(0) <> "" Then
    '    '        For i = 0 To UBound(a)
    '    '            colCC.Add(a(i))
    '    '        Next
    '    '    End If

    '    'End If
    '    ' Verify all new users against Estab before creation

    '    If Me.CheckEstab(persalnumber) Then
    '        If MsgBox("User EXIST on Persal Establishment, Do you want to continue ?", MsgBoxStyle.YesNo, "System Message") = MsgBoxResult.Yes Then
    '        Else
    '            'Open Remedy via URl 

    '            rRequestsNoURL = "http://prodlgremv1/arsys/servlet/ViewFormServlet?form=LOG_DM_Customer+Information&server=prodlgremv1&mode=Submit&username=" & _
    '         strP & "&pwd=" & Arpassword & "&F8="

    '            Process.Start(rRequestsNoURL)

    '            btnCustInfo_Click(sender, e)
    '            Me.WindowState = FormWindowState.Minimized
    '            Exit Sub
    '        End If
    '    Else


    '        If MsgBox("User does NOT exist on Persal Establishment." & vbCrLf & _
    '                  "Do you want to check if he/she has been appointed" & vbCrLf & _
    '                  "since the last Estab update?" & vbCrLf & vbCrLf & _
    '                  "Send An EMail To Verify ?", MsgBoxStyle.YesNo, "System Message") = MsgBoxResult.Yes Then

    '            'col.Add("persal_no~~" & VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("PersalNr").Value.ToString & "")
    '            'col.Add("first_name~~" & VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("Firstname").Value.ToString & "")
    '            'col.Add("last_name~~" & VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("Surname").Value.ToString.Trim & "")
    '            'col.Add("dept_code~~" & VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("DEPARTMENT").Value.ToString.Trim & "")
    '            'col.Add("dept_name~~" & VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("DEPARTMENT").Value.ToString.Trim & "")
    '            'col.Add("comments~~" & VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("Notes").Value.ToString.Trim & "")
    '            'ParseFile_Email("EMail To Verify Against Establishment", col, colTO, colCC, returnaddress)
    '            'col = Nothing

    '            If frmEnvironment.ChildFormPRD.Visible Then
    '                frmEnvironment.ChildFormPRD.ADCONSOLELOGTableAdapter.InsertIntoADAdminConsoleLog2(frmEnvironment.ChildFormPRD.tsLoggedOnUser.Text, _
    '                                                                 Get_ValidPersalNumber(persalnumber), _
    '                                                                 "Client not on Estab : Requested Info", False)
    '                frmEnvironment.ChildFormPRD.Refresh_Log()
    '            Else
    '                frmEnvironment.childformQA.ADCONSOLELOGTableAdapter.InsertIntoADAdminConsoleLog2(frmEnvironment.childformQA.tsLoggedOnUser.Text, _
    '                                                                 Get_ValidPersalNumber(persalnumber), _
    '                                                               "Client not on Estab : Requested Info", False)
    '                frmEnvironment.childformQA.Refresh_Log()
    '            End If
    '            If MsgBox("Do you want to go ahead and populate a new Remedy Customer anyway?", MsgBoxStyle.YesNo, "System Message") = MsgBoxResult.Yes Then
    '            Else
    '                Exit Sub
    '            End If
    '        Else
    '            btnCustInfo_Click(sender, e)
    '            Me.WindowState = FormWindowState.Minimized
    '            Exit Sub
    '        End If
    '    End If

    '    strProfileRequested = ""

    '    If VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("HR").Value.ToString() <> "None" Then
    '        strProfileRequested = strProfileRequested & "HR = " & VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("HR").Value.ToString() & " | "
    '    End If

    '    If VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("FIN").Value.ToString() <> "None" Then
    '        strProfileRequested = strProfileRequested & "FIN = " & VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("FIN").Value.ToString() & " | "
    '    End If

    '    If VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("LOGIS").Value.ToString() <> "None" Then
    '        strProfileRequested = strProfileRequested & "LOGIS = " & VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("LOGIS").Value.ToString() & " | "
    '    End If

    '    If VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("GFS").Value.ToString() <> "None" Then
    '        strProfileRequested = strProfileRequested & "GFS = " & VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("GFS").Value.ToString() & " | "
    '    End If

    '    If VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("DPSA").Value.ToString() <> "None" Then
    '        strProfileRequested = strProfileRequested & "DPSA = " & VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("DPSA").Value.ToString() & " | "
    '    End If

    '    If VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("Notes").Value.ToString() <> "" Then
    '        strProfileRequested = strProfileRequested & "Notes = " & VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("Notes").Value.ToString()
    '    End If

    '    If ADAdminDotNet.frmEnvironment.ActiveMdiChild.Text = "Active Directory Console - PRD" Then
    '        ADAdminDotNet.frmEnvironment.ChildFormPRD.txtRemedyRequestNo.Text = ""
    '        ADAdminDotNet.frmEnvironment.ChildFormPRD.txtRemedyNo.Text = ""
    '        ADAdminDotNet.frmEnvironment.ChildFormPRD.txtRightsRequested.Text = ""
    '        ADAdminDotNet.frmEnvironment.ChildFormPRD.txtRightsRequested.Text = tooltipstring
    '    ElseIf ADAdminDotNet.frmEnvironment.ActiveMdiChild.Text = "Active Directory Console - QA" Then
    '        ADAdminDotNet.frmEnvironment.childformQA.txtRemedyRequestNo.Text = ""
    '        ADAdminDotNet.frmEnvironment.ChildFormPRD.txtRemedyNo.Text = ""
    '        ADAdminDotNet.frmEnvironment.childformQA.txtRightsRequested.Text = ""
    '        ADAdminDotNet.frmEnvironment.childformQA.txtRightsRequested.Text = tooltipstring
    '    End If

    '    btnCustInfo_Click(sender, e)
    '    Me.WindowState = FormWindowState.Minimized
    '    Me.Close()

    'End Sub

    'Private Sub PopulateValuesInRemedyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PopulateValuesInRemedyToolStripMenuItem.Click

    '    Dim selectedrowindex As Integer
    '    selectedrowindex = VIP_USERS_NewUsersDataGridView.SelectedRows.Item(0).Index

    '    Dim i As Integer
    '    Dim a() As String
    '    Dim tbl1 As DataTable
    '    Dim persalnumber As String
    '    Dim subject As String = ""
    '    Dim tooltipstring As String = ""
    '    Dim returnaddress As String = ""
    '    Dim col As New Microsoft.VisualBasic.Collection
    '    Dim colCC As New Microsoft.VisualBasic.Collection
    '    Dim colTO As New Microsoft.VisualBasic.Collection

    '    Cleartxt = False
    '    persalnumber = VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("PersalNr").Value.ToString

    '    tbl1 = frmEnvironment.ChildFormPRD.ta_Vulindlela_Email.GetData("EMail To Verify Against Establishment")

    '    If tbl1.Rows.Count > 0 Then
    '        subject = tbl1.Rows(selectedrowindex).Item("SUBJECT").ToString
    '        returnaddress = tbl1.Rows(selectedrowindex).Item("RETURN_ADDRESS").ToString

    '        a = Split(tbl1.Rows(selectedrowindex).Item("TO_ADDRESS").ToString, ";")
    '        If a(0) <> "" Then
    '            For i = 0 To UBound(a)
    '                colTO.Add(a(i))
    '            Next
    '        End If

    '        a = Split(tbl1.Rows(selectedrowindex).Item("CC_ADDRESS").ToString, ";")

    '        If a(0) <> "" Then
    '            For i = 0 To UBound(a)
    '                colCC.Add(a(i))
    '            Next
    '        End If

    '    End If

    '    ' Verify all new users against Estab before creation
    '    If Me.CheckEstab(persalnumber) Then

    '        If MsgBox("User EXIST on Persal Establishment, Do you want to continue ?", MsgBoxStyle.YesNo, "System Message") = MsgBoxResult.Yes Then
    '        Else
    '            'modFunctions.OpenRemedyCustomerOLD2(Me.VIP_USERS_NewUsersDataGridView, sender, e, selectedrowindex, ARUSER.OpenMode.ARModify, "frmNewUsers")
    '            Me.WindowState = FormWindowState.Minimized
    '            Exit Sub
    '        End If
    '    Else

    '        If MsgBox("User does NOT exist on Persal Establishment." & vbCrLf & _
    '                  "Do you want to check if he/she has been appointed" & vbCrLf & _
    '                  "since the last Estab update?" & vbCrLf & vbCrLf & _
    '                  "Send An EMail To Verify ?", MsgBoxStyle.YesNo, "System Message") = MsgBoxResult.Yes Then

    '            col.Add("persal_no~~" & VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("PersalNr").Value.ToString & "")
    '            col.Add("first_name~~" & VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("Firstname").Value.ToString & "")
    '            col.Add("last_name~~" & VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("Surname").Value.ToString.Trim & "")
    '            col.Add("dept_code~~" & VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("DEPARTMENT").Value.ToString.Trim & "")
    '            col.Add("dept_name~~" & VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("DEPARTMENT").Value.ToString.Trim & "")
    '            col.Add("comments~~" & VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("Notes").Value.ToString.Trim & "")
    '            ParseFile_Email("EMail To Verify Against Establishment", col, colTO, colCC, returnaddress)
    '            col = Nothing

    '            If frmEnvironment.ChildFormPRD.Visible Then
    '                frmEnvironment.ChildFormPRD.ADCONSOLELOGTableAdapter.InsertIntoADAdminConsoleLog2(frmEnvironment.ChildFormPRD.tsLoggedOnUser.Text, _
    '                                                                 Get_ValidPersalNumber(persalnumber), _
    '                                                                 "Client not on Estab : Requested Info", False)
    '                frmEnvironment.ChildFormPRD.Refresh_Log()
    '            Else
    '                frmEnvironment.childformQA.ADCONSOLELOGTableAdapter.InsertIntoADAdminConsoleLog2(frmEnvironment.childformQA.tsLoggedOnUser.Text, _
    '                                                                 Get_ValidPersalNumber(persalnumber), _
    '                                                               "Client not on Estab : Requested Info", False)
    '                frmEnvironment.childformQA.Refresh_Log()
    '            End If
    '            If MsgBox("Do you want to go ahead and populate a new Remedy Customer anyway?", MsgBoxStyle.YesNo, "System Message") = MsgBoxResult.Yes Then
    '            Else
    '                Exit Sub
    '            End If
    '        Else
    '            'modFunctions.OpenRemedyCustomerOLD2(Me.VIP_USERS_NewUsersDataGridView, sender, e, selectedrowindex, ARUSER.OpenMode.ARModify, "frmNewUsers")
    '            Me.WindowState = FormWindowState.Minimized
    '            Exit Sub
    '        End If
    '    End If

    '    'modFunctions.OpenRemedyCustomerOLD2(Me.VIP_USERS_NewUsersDataGridView, sender, e, selectedrowindex, ARUSER.OpenMode.ARModify, "frmNewUsers")

    '    Me.WindowState = FormWindowState.Minimized

    '    If VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("Persalnr").Value.ToString.Trim.Length = 13 Then
    '        If Tnumber <> "" Then
    '            VIP_USERS_NewUsersTableAdapter.CopyID(VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("Persalnr").Value.ToString, Tnumber)
    '        End If
    '    End If

    '    tooltipstring = "Please create a profile with the following access rights." & vbCrLf
    '    If VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("HR").Value.ToString() <> "None" Then
    '        tooltipstring = tooltipstring + "HR = " & VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("HR").Value.ToString() & " | "
    '    End If

    '    If VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("FIN").Value.ToString() <> "None" Then
    '        tooltipstring = tooltipstring + "FIN = " & VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("FIN").Value.ToString() & " | "
    '    End If

    '    If VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("LOGIS").Value.ToString() <> "None" Then
    '        tooltipstring = tooltipstring + "LOGIS = " & VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("LOGIS").Value.ToString() & " | "
    '    End If

    '    If VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("GFS").Value.ToString() <> "None" Then
    '        tooltipstring = tooltipstring + "GFS = " & VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("GFS").Value.ToString() & " | "
    '    End If

    '    If VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("DPSA").Value.ToString() <> "None" Then
    '        tooltipstring = tooltipstring + "DPSA = " & VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("DPSA").Value.ToString()
    '    End If

    '    If VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("Notes").Value.ToString() <> "" Then
    '        tooltipstring = tooltipstring + "" & vbCrLf & "Notes = " & VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("Notes").Value.ToString()
    '    End If

    '    If ADAdminDotNet.frmEnvironment.ActiveMdiChild.Text = "Active Directory Console - PRD" Then
    '        ADAdminDotNet.frmEnvironment.ChildFormPRD.txtRemedyRequestNo.Text = ""
    '        ADAdminDotNet.frmEnvironment.ChildFormPRD.txtRemedyNo.Text = ""
    '        ADAdminDotNet.frmEnvironment.ChildFormPRD.txtRightsRequested.Text = ""
    '        ADAdminDotNet.frmEnvironment.ChildFormPRD.txtRightsRequested.Text = tooltipstring
    '    ElseIf ADAdminDotNet.frmEnvironment.ActiveMdiChild.Text = "Active Directory Console - QA" Then
    '        ADAdminDotNet.frmEnvironment.childformQA.txtRemedyRequestNo.Text = ""
    '        ADAdminDotNet.frmEnvironment.ChildFormPRD.txtRemedyNo.Text = ""
    '        ADAdminDotNet.frmEnvironment.childformQA.txtRightsRequested.Text = ""
    '        ADAdminDotNet.frmEnvironment.childformQA.txtRightsRequested.Text = tooltipstring
    '    End If

    '    Me.Close()

    'End Sub

    Private Sub MarkAsDoneToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MarkAsDoneToolStripMenuItem.Click
        Dim selectedrowindex As Integer
        Dim id2flag As Long
        selectedrowindex = VIP_USERS_NewUsersDataGridView.SelectedRows.Item(0).Index
        If selectedrowindex > -1 Then
            If MsgBox("Are you sure you want to mark " & vbCrLf & _
                          "  EntryID : " & VIP_USERS_NewUsersDataGridView.Rows(selectedrowindex).Cells("ID").Value.ToString & vbCrLf & _
                          "  UserID : " & VIP_USERS_NewUsersDataGridView.Rows(selectedrowindex).Cells("PersalNr").Value.ToString & vbCrLf & _
                          "  TelB : " & VIP_USERS_NewUsersDataGridView.Rows(selectedrowindex).Cells("TelB").Value.ToString & vbCrLf & _
                          "  Cell : " & VIP_USERS_NewUsersDataGridView.Rows(selectedrowindex).Cells("Cell").Value.ToString & vbCrLf & _
                          "  EMail : " & VIP_USERS_NewUsersDataGridView.Rows(selectedrowindex).Cells("EMail").Value.ToString & vbCrLf & _
                          "as completed?", MsgBoxStyle.OkCancel, "System Message") = MsgBoxResult.Ok Then
                If MsgBox("Are you sure???" & VIP_USERS_NewUsersDataGridView.Rows(selectedrowindex).Cells("PersalNr").Value.ToString & " as completed?", MsgBoxStyle.OkCancel, "System Message") = MsgBoxResult.Ok Then
                    id2flag = CLng(VIP_USERS_NewUsersDataGridView.Rows(selectedrowindex).Cells("ID").Value)
                    VIP_USERS_NewUsersTableAdapter.FlagCompletedByID(id2flag)
                    Me.VIP_USERS_NewUsersTableAdapter.Fill(Me.Ads.VIP_USERS_NewUsers)
                End If
            End If
        End If
    End Sub

    Private Sub btnCustInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCustInfo.Click



        ''frmMain.timerCOUNTS.Stop()
        ''frmMain.TimerKickout.Stop()
        ''frmMain.tmrPersalNumber.Stop()
        ''frmMain.ButtonsRefreshTimer.Stop()

        ''Dim url As String
        ''Dim ARUser As String = My.MySettings.Default.ARUser.Trim
        ''Dim ARPassword As String = My.MySettings.Default.ARPassword.Trim
        ''Dim txtPersalNumber As String = frmMain.txtPersalNumber.Text
        ''Dim selectedrowindex As Integer = VIP_USERS_NewUsersDataGridView.CurrentRow.Index

        ''colVals.Clear()


        ''Check if the user Exist on database Persal Number
        ''if the user Exist display
        ''if the user dont exist create

        ''   Dim ARSCustomerInfo As New WS_CI__cService
        'Dim AI As New AuthenticationInfo
        'Dim Query_OutputMap() As OutputMapping5GetListValues
        'Dim ws As New ARSWS.Webpage
        'ws = New ARSWS.Webpage
        'Dim Arpassword As String
        'Dim Aruser As String
        'Dim Return_Persal_Number
        'Dim strPersalNumber As String = "T0008266"
        'Aruser = "Ronel.Ilsley"
        'Arpassword = "logik007"
        'AI.userName = Aruser
        'AI.password = Arpassword
        '' ARSCustomerInfo.AuthenticationInfoValue = AI


        'Try

        '    If ("") Then
        '        'open Remed
        '    End If

        '    'Dim persal As String = "'Entry ID'=" + """0075191"""
        '    'Query_OutputMap = ARSCustomerInfo.GetList(Entryid, "0", "1000000000000")

        '    'Dim aa As String = ARSCustomerInfo.Create("T0008266", "Water Affairs", Record_StatusType.Incomplete, "T6660064", "mgz", "Surname", "08392122432", "0126652342", "web1.service@gmail.com", "Mr", "Gauteng", "Other", "", "", "", Remote_Access_AvailabilityType.Inactive, "", "15", "", 20, True, "", "", DateTime.Now, True, "Box 2042", "Wingate Park", "Gauteng", "", "", "", "", "", "opn", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", zDispInternal_Type.Yes, True, "", "", "", "")

        'Catch ex As Exception

        'End Try





        'Dim strProfileRequested As String = ""

        'If VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("HR").Value.ToString() <> "None" Then
        '    strProfileRequested = strProfileRequested & "HR = " & VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("HR").Value.ToString() & " | "
        'End If

        'If VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("FIN").Value.ToString() <> "None" Then
        '    strProfileRequested = strProfileRequested & "FIN = " & VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("FIN").Value.ToString() & " | "
        'End If

        'If VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("LOGIS").Value.ToString() <> "None" Then
        '    strProfileRequested = strProfileRequested & "LOGIS = " & VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("LOGIS").Value.ToString() & " | "
        'End If

        'If VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("GFS").Value.ToString() <> "None" Then
        '    strProfileRequested = strProfileRequested & "GFS = " & VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("GFS").Value.ToString() & " | "
        'End If

        'If VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("DPSA").Value.ToString() <> "None" Then
        '    strProfileRequested = strProfileRequested & "DPSA = " & VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("DPSA").Value.ToString() & " | "
        'End If

        'If VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("Notes").Value.ToString() <> "" Then
        '    strProfileRequested = strProfileRequested & "Notes = " & VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("Notes").Value.ToString()
        'End If

        ''With VIP_USERS_NewUsersDataGridView

        ''    colVals.Add(.Rows(selectedrowindex).Cells("PersalNr").Value.ToString & "", "F8")
        ''    colVals.Add(.Rows(selectedrowindex).Cells("DEPARTMENT").Value.ToString & "", "arid_Department_Name")
        ''    colVals.Add(.Rows(selectedrowindex).Cells("Title").Value.ToString & "", "arid_Title")
        ''    colVals.Add(.Rows(selectedrowindex).Cells("Firstname").Value.ToString & "", "arid_First_Name")
        ''    colVals.Add(.Rows(selectedrowindex).Cells("Surname").Value.ToString & "", "arid_Last_Name")
        ''    colVals.Add(.Rows(selectedrowindex).Cells("Rank").Value.ToString & "", "arid_Rank")
        ''    colVals.Add(.Rows(selectedrowindex).Cells("TelB").Value.ToString & "", "arid_Telephone")
        ''    colVals.Add(.Rows(selectedrowindex).Cells("Cell").Value.ToString & "", "arid_Cellphone")
        ''    colVals.Add(.Rows(selectedrowindex).Cells("EMail").Value.ToString & "", "arid_E_Mail")
        ''    colVals.Add(strProfileRequested & "", "arid_Comments")
        ''    colVals.Add(.Rows(selectedrowindex).Cells("Dept").Value.ToString & "", "arid_Department_Type")
        ''    colVals.Add(Strings.Left(.Rows(selectedrowindex).Cells("Firstname").Value.ToString, 1) & "", "arid_Initial")
        ''End With




        ''url = "http://prodlgremv1/arsys/servlet/ViewFormServlet?form=LOG_DM_Customer+Information&server=prodlgremv1&username=" & Aruser.Trim & "&pwd=" & Arpassword.Trim
        ''Process.Start(url)


        'With frmWebBrowser
        '    ' .WebBrowser1.Navigate(url)
        '    Do While .WebBrowser1.IsBusy
        '    Loop
        '    .WebBrowser1.Show()
        '    .Show()
        'End With

        'frmMain.timerCOUNTS.Start()
        'frmMain.TimerKickout.Start()
        'frmMain.tmrPersalNumber.Start()
        'frmMain.ButtonsRefreshTimer.Start()

    End Sub

    'Private Sub btnCustInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCustInfo.Click

    '    frmMain.timerCOUNTS.Stop()
    '    frmMain.TimerKickout.Stop()
    '    frmMain.tmrPersalNumber.Stop()
    '    frmMain.ButtonsRefreshTimer.Stop()

    '    Dim url As String
    '    Dim ARUser As String = My.MySettings.Default.ARUser.Trim
    '    Dim ARPassword As String = My.MySettings.Default.ARPassword.Trim
    '    Dim txtPersalNumber As String = frmMain.txtPersalNumber.Text
    '    Dim selectedrowindex As Integer = VIP_USERS_NewUsersDataGridView.CurrentRow.Index

    '    colVals.Clear()

    '    strProfileRequested = ""

    '    If VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("HR").Value.ToString() <> "None" Then
    '        strProfileRequested = strProfileRequested & "HR = " & VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("HR").Value.ToString() & " | "
    '    End If

    '    If VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("FIN").Value.ToString() <> "None" Then
    '        strProfileRequested = strProfileRequested & "FIN = " & VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("FIN").Value.ToString() & " | "
    '    End If

    '    If VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("LOGIS").Value.ToString() <> "None" Then
    '        strProfileRequested = strProfileRequested & "LOGIS = " & VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("LOGIS").Value.ToString() & " | "
    '    End If

    '    If VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("GFS").Value.ToString() <> "None" Then
    '        strProfileRequested = strProfileRequested & "GFS = " & VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("GFS").Value.ToString() & " | "
    '    End If

    '    If VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("DPSA").Value.ToString() <> "None" Then
    '        strProfileRequested = strProfileRequested & "DPSA = " & VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("DPSA").Value.ToString() & " | "
    '    End If

    '    If VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("Notes").Value.ToString() <> "" Then
    '        strProfileRequested = strProfileRequested & "Notes = " & VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("Notes").Value.ToString()
    '    End If


    '    With VIP_USERS_NewUsersDataGridView

    '        colVals.Add(.Rows(selectedrowindex).Cells("PersalNr").Value.ToString & "", "F8")
    '        colVals.Add(.Rows(selectedrowindex).Cells("DEPARTMENT").Value.ToString & "", "arid_Department_Name")
    '        colVals.Add(.Rows(selectedrowindex).Cells("Title").Value.ToString & "", "arid_Title")
    '        colVals.Add(.Rows(selectedrowindex).Cells("Firstname").Value.ToString & "", "arid_First_Name")
    '        colVals.Add(.Rows(selectedrowindex).Cells("Surname").Value.ToString & "", "arid_Last_Name")
    '        colVals.Add(.Rows(selectedrowindex).Cells("Rank").Value.ToString & "", "arid_Rank")
    '        colVals.Add(.Rows(selectedrowindex).Cells("TelB").Value.ToString & "", "arid_Telephone")
    '        colVals.Add(.Rows(selectedrowindex).Cells("Cell").Value.ToString & "", "arid_Cellphone")
    '        colVals.Add(.Rows(selectedrowindex).Cells("EMail").Value.ToString & "", "arid_E_Mail")
    '        colVals.Add(strProfileRequested & "", "arid_Comments")
    '        colVals.Add(.Rows(selectedrowindex).Cells("Dept").Value.ToString & "", "arid_Department_Type")
    '        colVals.Add(Strings.Left(.Rows(selectedrowindex).Cells("Firstname").Value.ToString, 1) & "", "arid_Initial")
    '    End With

    '    url = "http://prodlgremv1/arsys/servlet/ViewFormServlet?form=LOG_DM_Customer+Information&server=prodlgremv1&username=" & ARUser.Trim & "&pwd=" & ARPassword.Trim
    '    Process.Start(url)


    '    With frmWebBrowser
    '        .WebBrowser1.Navigate(url)
    '        Do While .WebBrowser1.IsBusy
    '        Loop
    '        .WebBrowser1.Show()
    '        .Show()
    '    End With

    '    frmMain.timerCOUNTS.Start()
    '    frmMain.TimerKickout.Start()
    '    frmMain.tmrPersalNumber.Start()
    '    frmMain.ButtonsRefreshTimer.Start()

    'End Sub


    Private Sub VIP_USERS_NewUsersDataGridView_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles VIP_USERS_NewUsersDataGridView.CellDoubleClick

        Dim i As Integer
        Dim a() As String
        Dim tbl1 As DataTable
        Dim persalnumber As String
        Dim subject As String = ""
        Dim tooltipstring As String = ""
        Dim returnaddress As String = ""
        Dim col As New Microsoft.VisualBasic.Collection
        Dim colCC As New Microsoft.VisualBasic.Collection
        Dim colTO As New Microsoft.VisualBasic.Collection
        Dim ws As New ARSWS.Webpage
        Dim Environment As String = Me.Text
        ws = New ARSWS.Webpage
        persalnumber = VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("PersalNr").Value.ToString().Trim
        Cleartxt = False
        
        tbl1 = frmEnvironment.ChildFormPRD.ta_Vulindlela_Email.GetData("EMail To Verify Against Establishment")

        If tbl1.Rows.Count > 0 Then
            subject = tbl1.Rows(0).Item("SUBJECT").ToString
            returnaddress = tbl1.Rows(0).Item("RETURN_ADDRESS").ToString

            a = Split(tbl1.Rows(0).Item("TO_ADDRESS").ToString, ";")
            If a(0) <> "" Then
                For i = 0 To UBound(a)
                    colTO.Add(a(i))
                Next
            End If

            a = Split(tbl1.Rows(0).Item("CC_ADDRESS").ToString, ";")

            If a(0) <> "" Then
                For i = 0 To UBound(a)
                    colCC.Add(a(i))
                Next
            End If

        End If

        ' Verify all new users against Estab before creation
        If Me.CheckEstab(persalnumber) Then
            If MsgBox("User EXIST on Persal Establishment, Do you want to continue ?", MsgBoxStyle.YesNo, "System Message") = MsgBoxResult.Yes Then
            Else
                '  ws.Open_Customer_Information(persalnumber)
                'modFunctions.OpenRemedyCustomer2(Me.VIP_USERS_NewUsersDataGridView, sender, e, ARUSER.OpenMode.ARModify, "frmNewUsers")
                Me.WindowState = FormWindowState.Minimized
                Exit Sub
            End If
        Else
            If MsgBox("User does NOT exist on Persal Establishment." & vbCrLf & _
                "Do you want to check if he/she has been appointed" & vbCrLf & _
                "since the last Estab update?" & vbCrLf & vbCrLf & _
                 "Send An EMail To Verify ?", MsgBoxStyle.YesNo, "System Message") = MsgBoxResult.Yes Then

                col.Add("persal_no~~" & VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("PersalNr").Value.ToString & "")
                col.Add("first_name~~" & VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("Firstname").Value.ToString & "")
                col.Add("last_name~~" & VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("Surname").Value.ToString.Trim & "")
                col.Add("dept_code~~" & VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("DEPARTMENT").Value.ToString.Trim & "")
                col.Add("dept_name~~" & VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("DEPARTMENT").Value.ToString.Trim & "")
                col.Add("comments~~" & VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("Notes").Value.ToString.Trim & "")
                ParseFile_Email("EMail To Verify Against Establishment", col, colTO, colCC, returnaddress)
                col = Nothing

                If frmEnvironment.ChildFormPRD.Visible Then
                    frmEnvironment.ChildFormPRD.ADCONSOLELOGTableAdapter.InsertIntoADAdminConsoleLog2(frmEnvironment.ChildFormPRD.tsLoggedOnUser.Text, _
                                                                     Get_ValidPersalNumber(persalnumber), _
                                                                     "Client not on Estab : Requested Info", False)
                    frmEnvironment.ChildFormPRD.Refresh_Log()
                Else
                    frmEnvironment.childformQA.ADCONSOLELOGTableAdapter.InsertIntoADAdminConsoleLog2(frmEnvironment.childformQA.tsLoggedOnUser.Text, _
                                                                     Get_ValidPersalNumber(persalnumber), _
                                                                   "Client not on Estab : Requested Info", False)
                    frmEnvironment.childformQA.Refresh_Log()
                End If
                If MsgBox("Do you want to go ahead and populate a new Remedy Customer anyway?", MsgBoxStyle.YesNo, "System Message") = MsgBoxResult.Yes Then
                Else
                    Exit Sub
                End If
                ws.Create_New_user(persalnumber, Environment)
                Me.WindowState = FormWindowState.Minimized
                Exit Sub
            End If
        End If
        ws.Create_New_user(persalnumber, Environment)
        Me.WindowState = FormWindowState.Minimized
        If VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("Persalnr").Value.ToString.Trim.Length = 13 Then
            If Tnumber <> "" Then
                VIP_USERS_NewUsersTableAdapter.CopyID(VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("Persalnr").Value.ToString, Tnumber)
            End If
        End If
        tooltipstring = "Please create a profile with the following access rights." & vbCrLf
        If VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("HR").Value.ToString() <> "None" Then
            tooltipstring = tooltipstring + "HR = " & VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("HR").Value.ToString() & " | "
        End If
        If VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("FIN").Value.ToString() <> "None" Then
            tooltipstring = tooltipstring + "FIN = " & VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("FIN").Value.ToString() & " | "
        End If
        If VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("LOGIS").Value.ToString() <> "None" Then
            tooltipstring = tooltipstring + "LOGIS = " & VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("LOGIS").Value.ToString() & " | "
        End If
        If VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("GFS").Value.ToString() <> "None" Then
            tooltipstring = tooltipstring + "GFS = " & VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("GFS").Value.ToString() & " | "
        End If
        If VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("DPSA").Value.ToString() <> "None" Then
            tooltipstring = tooltipstring + "DPSA = " & VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("DPSA").Value.ToString()
        End If
        If VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("Notes").Value.ToString() <> "" Then
            tooltipstring = tooltipstring + "" & vbCrLf & "Notes = " & VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("Notes").Value.ToString()
        End If

        If frmEnvironment.ActiveMdiChild.Text = "Active Directory Console - PRD" Then
            frmEnvironment.ChildFormPRD.txtRemedyRequestNo.Text = ""
            frmEnvironment.ChildFormPRD.txtRemedyNo.Text = ""
            frmEnvironment.ChildFormPRD.txtRightsRequested.Text = ""
            ADAdminDotNet.frmEnvironment.ChildFormPRD.txtPersalNumber.Text = persalnumber.Trim
            ADAdminDotNet.frmEnvironment.ChildFormPRD.btnActiveDirectory_Click(sender, e)
            frmEnvironment.ChildFormPRD.txtRightsRequested.Text = tooltipstring
        ElseIf frmEnvironment.ActiveMdiChild.Text = "Active Directory Console - QA" Then
            frmEnvironment.childformQA.txtRemedyRequestNo.Text = ""
            frmEnvironment.childformQA.txtRemedyNo.Text = ""
            frmEnvironment.childformQA.txtRightsRequested.Text = ""
            ADAdminDotNet.frmEnvironment.childformQA.txtPersalNumber.Text = persalnumber.Trim
            ADAdminDotNet.frmEnvironment.childformQA.btnActiveDirectory_Click(sender, e)
            frmEnvironment.childformQA.txtRightsRequested.Text = tooltipstring
        End If



        Me.Close()


    End Sub


    Private Sub VIP_USERS_NewUsersBindingNavigator_RefreshItems(sender As Object, e As EventArgs) Handles VIP_USERS_NewUsersBindingNavigator.RefreshItems

    End Sub

    Private Sub VIP_USERS_NewUsersDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles VIP_USERS_NewUsersDataGridView.CellContentClick

    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub
End Class


