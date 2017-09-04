Imports System.Diagnostics
Imports System.IO
Imports System.Text

Public Class frmInfoRequired

    'Private Property persalnumber() As String

    Private Sub frmInfoRequired_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(27) Then
            Me.Close()
        End If
    End Sub


    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click

        Me.LOG_IN_Request_TrackingTableAdapter.ClearBeforeFill = True
        LOG_IN_Request_TrackingDataGridView.DataSource = Nothing
        LOG_IN_Request_TrackingDataGridView.DataSource = LOG_IN_Request_TrackingBindingSource
        Me.LOG_IN_Request_TrackingTableAdapter.FillByRefer2Client(Me.ARSystemDataSet.LOG_IN_Request_Tracking)
        Me.Refresh()

        If LOG_IN_Request_TrackingDataGridView.Rows.Count > 0 Then
            LOG_IN_Request_TrackingDataGridView.Rows(0).Selected = True
        End If

    End Sub

    Private Sub frmInfoRequired_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ARSystemDataSet.LOG_IN_Request_Tracking2' table. You can move, or remove it, as needed.
        Me.LOG_IN_Request_Tracking2TableAdapter.FillByRefer2Client(Me.ARSystemDataSet.LOG_IN_Request_Tracking2)
        'TODO: This line of code loads data into the 'ARSystemDataSet.RemedyOpenRequests' table. You can move, or remove it, as needed.
        Me.RemedyOpenRequestsTableAdapter.Fill(Me.ARSystemDataSet.RemedyOpenRequests)

        'Try
        '    Me.LOG_IN_Request_Tracking2TableAdapter.ClearBeforeFill = True
        '    LOG_IN_Request_TrackingDataGridView.DataSource = Nothing
        '    LOG_IN_Request_TrackingDataGridView.DataSource = LOGINRequestTracking2BindingSource
        '    RemedyOpenRequestsTableAdapter.FillByRefer2Client(Me.ARSystemDataSet.RemedyOpenRequests)
        '    Me.Refresh()
        'Catch ex As Exception
        'End Try

        'If LOG_IN_Request_TrackingDataGridView.Rows.Count > 0 Then
        '    LOG_IN_Request_TrackingDataGridView.Rows(0).Selected = True
        'End If

    End Sub

    Private Sub ExportToExcelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportToExcelToolStripMenuItem.Click
        Dim mstr As String
        Dim table As DataTable
        table = Me.LOG_IN_Request_TrackingTableAdapter.GetRefer2Client
        ExportCSV(table, AppPath() & "InfoRequired.csv")
        mstr = AppPath() & "InfoRequired.csv"
        If File.Exists(mstr) Then
            Process.Start(mstr)
        End If
    End Sub

    Private Sub LOG_IN_Request_TrackingDataGridView_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles LOG_IN_Request_TrackingDataGridView.CellContentDoubleClick
        Cleartxt = False

        Dim txtRequestNo As String = ""
        Dim ws As New ARSWS.Webpage
        Dim Environment As String = Me.Text

        txtRequestNo = LOG_IN_Request_TrackingDataGridView.Item("Request_No", e.RowIndex).Value
        ws.Open_Request_No(txtRequestNo, Environment)

        ADAdminDotNet.frmMain.txtPersalNumber.Text = LOG_IN_Request_TrackingDataGridView.Item("Persal_Number", e.RowIndex).Value.ToString

        If ADAdminDotNet.frmEnvironment.ActiveMdiChild.Text = "Active Directory Console - PRD" Then
            ADAdminDotNet.frmEnvironment.ChildFormPRD.txtRightsRequested.Text = ""
            ADAdminDotNet.frmEnvironment.ChildFormPRD.txtPersalNumber.Text = LOG_IN_Request_TrackingDataGridView.CurrentRow.Cells("Persal_Number").Value.ToString()
            ADAdminDotNet.frmEnvironment.ChildFormPRD.btnActiveDirectory_Click(sender, e)
            ADAdminDotNet.frmEnvironment.ChildFormPRD.txtRightsRequested.Text = "REQUEST : " & LOG_IN_Request_TrackingDataGridView.CurrentRow.Cells("Request_No").Value.ToString()
            ADAdminDotNet.frmEnvironment.ChildFormPRD.txtRightsRequested.Text += " " & vbCrLf & LOG_IN_Request_TrackingDataGridView.CurrentRow.Cells("Long_Description").Value.ToString()
            ADAdminDotNet.frmEnvironment.ChildFormPRD.txtRemedyRequestNo.Text = LOG_IN_Request_TrackingDataGridView.CurrentRow.Cells("Request_No").Value.ToString()
            ADAdminDotNet.frmEnvironment.ChildFormPRD.txtRemedyNo.Text = LOG_IN_Request_TrackingDataGridView.CurrentRow.Cells("Request_No").Value.ToString()
        ElseIf ADAdminDotNet.frmEnvironment.ActiveMdiChild.Text = "Active Directory Console - QA" Then
            ADAdminDotNet.frmEnvironment.childformQA.txtRightsRequested.Text = ""
            ADAdminDotNet.frmEnvironment.childformQA.txtPersalNumber.Text = LOG_IN_Request_TrackingDataGridView.CurrentRow.Cells("Persal_Number").Value.ToString()
            ADAdminDotNet.frmEnvironment.childformQA.btnActiveDirectory_Click(sender, e)
            ADAdminDotNet.frmEnvironment.childformQA.txtRightsRequested.Text = "REQUEST : " & LOG_IN_Request_TrackingDataGridView.CurrentRow.Cells("Request_No").Value.ToString()
            ADAdminDotNet.frmEnvironment.childformQA.txtRightsRequested.Text += " " & vbCrLf & LOG_IN_Request_TrackingDataGridView.CurrentRow.Cells("Long_Description").Value.ToString()
            ADAdminDotNet.frmEnvironment.childformQA.txtRemedyRequestNo.Text = LOG_IN_Request_TrackingDataGridView.CurrentRow.Cells("Request_No").Value.ToString()
            ADAdminDotNet.frmEnvironment.childformQA.txtRemedyNo.Text = LOG_IN_Request_TrackingDataGridView.CurrentRow.Cells("Request_No").Value.ToString()
        End If

        ws = Nothing
        Me.Cursor = Cursors.Arrow

        If My.MySettings.Default.PropertyValues("Close_Pick_Forms").PropertyValue = True Then
            Me.Close()
        End If
    End Sub

    Private Sub ExportEstablishementxlsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportEstablishementxlsToolStripMenuItem.Click

        Dim dt As New DataTable
        Dim dtRequests As New DataTable
        Dim path As String
        Dim sstr As String
        Dim s As String
        Dim i As Integer
        Dim sw As StreamWriter

        path = AppPath() & "ExportedEstabQuery.csv"


        If File.Exists(path) Then

            If MsgBox("The file " & path.Trim + " you want to create exists. Do you want to delete it? And try again", MsgBoxStyle.YesNo, "File Exists") = MsgBoxResult.Yes Then
                Try
                    File.Delete(path)
                Catch ex As Exception
                    MsgBox("Cannot delete file " & path.Trim + ". It is being used by some process.", MsgBoxStyle.OkOnly, "Error deleting file")
                End Try
            End If

        Else
            sw = File.CreateText(path)
            sstr = "PERSALNR,SNAME,SUR_INI,PROVDESC,DEPTDESC,RANKDESC,JOBTITLE,PAYDIST,PAYPOINT,APPTNAT"

            sw.WriteLine(sstr)

            For i = 0 To Me.LOG_IN_Request_TrackingDataGridView.RowCount - 1

                dt = DirectCast(Me.Ta_Establishment.GetData(DirectCast(LOG_IN_Request_TrackingDataGridView.Item("Persal_Number", i).Value, String)), DataTable)
                If dt.Rows.Count > 0 Then
                    s = ""
                    s += dt.Rows(0).Item("PERSALNR").ToString.Trim & ","
                    s += dt.Rows(0).Item("SNAME").ToString.Trim & ","
                    s += dt.Rows(0).Item("SUR_INI").ToString.Trim & ","
                    s += dt.Rows(0).Item("PROVDESC").ToString.Trim & ","
                    s += dt.Rows(0).Item("DEPTDESC").ToString.Trim & ","
                    s += dt.Rows(0).Item("RANKDESC").ToString.Trim & ","
                    s += dt.Rows(0).Item("JOBTITLE").ToString.Trim & ","
                    s += dt.Rows(0).Item("PAYDIST").ToString.Trim & ","
                    s += dt.Rows(0).Item("PAYPOINT").ToString.Trim & ","
                    s += dt.Rows(0).Item("APPTNAT").ToString.Trim

                    sw.WriteLine(s)

                End If

            Next
            sw.Flush()
            sw.Close()
        End If

        If File.Exists(path) Then
            Process.Start(path)
        End If

        sw = Nothing

    End Sub

    Private Sub FillToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        '    Me.Ta_Establishment.Fill(Me.Ads.Establishment, PersalnumberToolStripTextBox.Text)
        'Catch ex As System.Exception
        '    System.Windows.Forms.MessageBox.Show(ex.Message)
        'End Try

    End Sub

    Private Sub frmInfoRequired_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Me.LOG_IN_Request_TrackingDataGridView.Width = Me.Width - 9
        Me.LOG_IN_Request_TrackingDataGridView.Height = Me.Height - 82
    End Sub

    Private Sub frmInfoRequired_ResizeEnd(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ResizeEnd
        Me.LOG_IN_Request_TrackingDataGridView.Width = Me.Width - 9
        Me.LOG_IN_Request_TrackingDataGridView.Height = Me.Height - 82
    End Sub

    'Private Sub CLoseThisRemedyRequestToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles CLoseThisRemedyRequest.Click

    '    'Dim mm As String
    '    'mm = LOG_IN_Request_TrackingDataGridView.Item(0, e.).ToString

    '    Dim i As Integer
    '    Dim userid As String
    '    Dim pwd As String
    '    Dim MyEntryID As String
    '    Dim a As ARUSER.COMAppObj = New ARUSER.COMAppObj
    '    Dim RemedyProcess As Process
    '    Dim SessionID As VariantType
    '    Dim RemedyForm As ARUSER.ICOMFormWnd
    '    Dim MyResultForm As ARUSER.COMQueryResult
    '    Dim InfoRequiredCol As New Microsoft.VisualBasic.Collection
    '    Dim RemedyQueryObject As ARUSER.ICOMQueryResultSet
    '    Dim RemedyProcesses() As Process = Process.GetProcessesByName("ARUSER")

    '    If frmEnvironment.ChildFormPRD.Visible Then
    '        frmEnvironment.ChildFormPRD.timerCOUNTS.Stop()
    '    Else
    '        frmEnvironment.childformQA.timerCOUNTS.Stop()
    '    End If

    '    Try
    '        RemedyForm = DirectCast(a.OpenForm(0, My.Settings.RemedyServerName.Trim, "LOG_IN_Request Tracking", ARUSER.OpenMode.ARQuery, 0), ARUSER.ICOMFormWnd)
    '    Catch ex As Exception
    '        If Err.Number = -2147216284 Then
    '            For Each RemedyProcess In RemedyProcesses
    '                RemedyProcess.Kill()
    '            Next
    '        End If
    '        If Err.Number = -2147216287 Or Err.Number = -2147023174 Then
    '            For i = 1 To 3
    '                userid = InputBox("Please enter your Remedy User ID Please?", "System Message", ADAdminDotNet.My.MySettings.Default.ARUser)
    '                pwd = InputBox("Enter your password please", "System Message", "logik007")
    '                If userid = "" Or pwd = "" Then
    '                    MsgBox("You did not enter valid values", MsgBoxStyle.OkOnly)
    '                    If frmEnvironment.ChildFormPRD.Visible Then
    '                        frmEnvironment.ChildFormPRD.timerCOUNTS.Start()
    '                    Else
    '                        frmEnvironment.childformQA.timerCOUNTS.Start()
    '                    End If
    '                    Exit Sub
    '                End If
    '                SessionID = DirectCast(a.Login(userid.ToString, pwd, 0), VariantType)
    '                If Err.Number = -2147467259 Then
    '                    MsgBox(Err.Description)
    '                    a.Logout(0)
    '                    a = Nothing
    '                Else
    '                    Exit For
    '                End If
    '            Next
    '        End If
    '    End Try

    '    Try

    '        RemedyForm = DirectCast(a.OpenForm(0, My.Settings.RemedyServerName.Trim, "LOG_IN_Request Tracking", ARUSER.OpenMode.ARQuery, 0), ARUSER.ICOMFormWnd)
    '        RemedyForm.GetField("Request_No").Value = RequestNumber
    '        RemedyForm.GetField("Solution").Value = RemedyForm.GetField("Solution").Value.ToString & " - CFO Letter Not Received in time"
    '        RemedyQueryObject = DirectCast(RemedyForm.Query(""), ARUSER.ICOMQueryResultSet)

    '        If RemedyQueryObject.Count > 0 Then
    '            MyResultForm = DirectCast(RemedyQueryObject.Item(1), ARUSER.COMQueryResult)
    '            MyEntryID = MyResultForm.entryId
    '            RemedyForm = DirectCast(a.LoadForm(0, My.Settings.RemedyServerName.Trim, "LOG_IN_Request Tracking", MyEntryID, DirectCast(eOpenMode, ARUSER.OpenMode), 1), ARUSER.ICOMFormWnd)
    '        End If

    '        If frmEnvironment.ChildFormPRD.Visible Then
    '            With frmEnvironment.ChildFormPRD
    '                .txtPersalNumber.Text = persalnumber
    '                .btnActiveDirectory_Click(sender, e)
    '                .txtPersalNumber.Focus()
    '                .txtPersalNumber.SelectAll()
    '                .timerCOUNTS.Start()
    '            End With
    '        Else
    '            With frmEnvironment.childformQA
    '                .txtPersalNumber.Text = persalnumber
    '                .btnActiveDirectory_Click(sender, e)
    '                .txtPersalNumber.Focus()
    '                .txtPersalNumber.SelectAll()
    '                .timerCOUNTS.Start()
    '            End With
    '        End If

    '    Catch ex As Exception
    '        If Err.Number = -2147216287 Then
    '            MsgBox("An internal error occured please try again", MsgBoxStyle.Critical)
    '            If frmEnvironment.ChildFormPRD.Visible Then
    '                frmEnvironment.ChildFormPRD.timerCOUNTS.Start()
    '            Else
    '                frmEnvironment.childformQA.timerCOUNTS.Start()
    '            End If
    '            Exit Sub
    '        End If
    '    End Try
    '    If frmEnvironment.ChildFormPRD.Visible Then
    '        frmEnvironment.ChildFormPRD.timerCOUNTS.Start()
    '    Else
    '        frmEnvironment.childformQA.timerCOUNTS.Start()
    '    End If

    'End Sub

    Private Sub NoCFOLetterReceivedInTimeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NoCFOLetterReceivedInTimeToolStripMenuItem.Click

        Dim mm As String = ""
        Dim counter As Integer
        Dim rownumber As Integer
        Dim i As Integer
        rownumber = 0
        For counter = 0 To (LOG_IN_Request_TrackingDataGridView.SelectedCells.Count - 1)
            If LOG_IN_Request_TrackingDataGridView.SelectedCells(counter).FormattedValueType Is Type.GetType("System.String") Then
                Dim value As String = Nothing
                rownumber = LOG_IN_Request_TrackingDataGridView.SelectedCells(counter).RowIndex
                For i = 0 To 9
                    mm += LOG_IN_Request_TrackingDataGridView.Rows(rownumber).Cells(i).Value.ToString.Trim & vbCrLf
                Next
                MsgBox(mm, MsgBoxStyle.Exclamation, "Title")
            End If
        Next
    End Sub

    Private Sub LOG_IN_Request_TrackingDataGridView_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles LOG_IN_Request_TrackingDataGridView.KeyUp
        If e.KeyValue = 27 Then
            Me.Close()
        End If
    End Sub

    Private Sub ExportCFOApprovalsOutstandingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportCFOApprovalsOutstandingToolStripMenuItem.Click
        Dim dt As New DataTable
        Dim dtRequests As New DataTable
        Dim path As String
        Dim sstr As String
        Dim sw As StreamWriter
        Dim s As String = ""



        path = AppPath() & "CFO_Approvals_Outstanding.csv"

        If File.Exists(path) Then

            If MsgBox("The file " & path.Trim + " you want to create exists. Do you want to delete it? And try again", MsgBoxStyle.YesNo, "File Exists") = MsgBoxResult.Yes Then
                Try
                    File.Delete(path)
                    MsgBox("Please try to create the file again!", MsgBoxStyle.OkOnly, "Error in deleting the file at first")
                Catch ex As Exception
                    MsgBox("Cannot delete file " & path.Trim + ". It is being used by some process.", MsgBoxStyle.OkOnly, "Error deleting file")
                End Try
            End If

        Else
            sw = File.CreateText(path)

            sstr = "CFOPersalNo,CFOComments,RemedyReqNo,CFOFullNames,CFOSurname,CFOTel, CFOCell,CFOEmail, CFODesignation, CFODeptCode, CFODepartment"

            sw.WriteLine(sstr)

            'For i = 0 To Me.LOG_IN_Request_TrackingDataGridView.RowCount - 1
            Me.VIEW_CFO_RULES_FLAGS_OUTSTANDINGTableAdapter.Connection.ConnectionString = My.Settings.AdsConnectionString
            dt = Me.VIEW_CFO_RULES_FLAGS_OUTSTANDINGTableAdapter.GetDataVIEW_CFO_RULES_FLAGS_OUTSTANDING()

            For Each row As DataRow In dt.Rows

                s = ""
                s += row.Item("CFOPersalNo").ToString.Trim & ","
                s += row.Item("CFOComments").ToString.Trim & ","
                s += row.Item("RemedyReqNo").ToString.Trim & ","
                s += row.Item("CFOFullNames").ToString.Trim & ","
                s += row.Item("CFOSurname").ToString.Trim & ","
                s += row.Item("CFOTel").ToString.Trim & ","
                s += row.Item("CFOCell").ToString.Trim & ","
                s += row.Item("CFOEmail").ToString.Trim & ","
                s += row.Item("CFODesignation").ToString.Trim & ","
                s += row.Item("CFODeptCode").ToString.Trim & ","
                s += row.Item("CFODepartment").ToString.Trim

                sw.WriteLine(s)

            Next

            sw.Flush()
            sw.Close()

        End If

        If File.Exists(path) Then
            Process.Start(path)
        End If

        sw = Nothing

    End Sub

    Private Sub CLoseThisRemedyRequestToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CLoseThisRemedyRequest.Click
        Dim requestnumberclicked As String = Me.LOG_IN_Request_TrackingDataGridView.CurrentRow.Cells("Request_No").Value
        'Me.dsADSTableAdapters.RULES_FLAGSTableAdapter()
        'Me.VIP_USERS_NewUsersTableAdapter.FlagCompletedByID(123)
        'UpdateDoneToCompleted()
        'Me.dsADS.RULES_FLAGS1DataTable(requestnumberclicked)
    End Sub

    Private Sub LOG_IN_Request_TrackingDataGridView_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LOG_IN_Request_TrackingDataGridView.SelectionChanged

        Dim s As String = ""
        Dim tt As String = ""

        Dim requestno As String = ""
        requestno = LOG_IN_Request_TrackingDataGridView.CurrentRow.Cells("Request_No").Value.ToString

        Dim dt As DataTable
        Me.VIEW_CFO_RULES_FLAGS_OUTSTANDINGTableAdapter.Connection.ConnectionString = My.Settings.AdsConnectionString
        dt = Me.VIEW_CFO_RULES_FLAGS_OUTSTANDINGTableAdapter.GetDataVIEW_CFO_RULES_FLAGS_OUTSTANDING()

        If dt.Rows.Count > 0 Then

            For Each row As DataRow In dt.Rows

                If row("RemedyReqNo").trim = requestno.Trim Then

                    s = "Request #: " & row.Item("RemedyReqNo").ToString.Trim & " | " & _
                        row.Item("CFOPersalNo").ToString.Trim & " | " & _
                        row.Item("CFOFullNames").ToString.Trim & " " & row.Item("CFOSurname").ToString.Trim & " | " & _
                        row.Item("CFOTel").ToString.Trim & " | " & _
                        row.Item("CFOCell").ToString.Trim & " | " & _
                        row.Item("CFOEmail").ToString.Trim & " | " & _
                        row.Item("CFODeptCode").ToString.Trim

                    Me.tsInfoRequiredLabel.Text = s

                    tt = s.Replace("|", vbCrLf)
                    LOG_IN_Request_TrackingDataGridView.CurrentRow.Cells(0).ToolTipText = tt

                    Exit For
                Else
                    Me.tsInfoRequiredLabel.Text = "No Information"
                    LOG_IN_Request_TrackingDataGridView.CurrentRow.Cells(0).ToolTipText = "No Information"
                End If

            Next

        End If

        requestno = Nothing
        s = Nothing
        dt = Nothing

    End Sub

    Private Sub LOG_IN_Request_TrackingDataGridView_CellMouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles LOG_IN_Request_TrackingDataGridView.CellMouseMove
        LOG_IN_Request_TrackingDataGridView_SelectionChanged(sender, e)
    End Sub

    Private Sub LOG_IN_Request_TrackingDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles LOG_IN_Request_TrackingDataGridView.CellContentClick

    End Sub
End Class

#Region "Newer"

'Imports ARNetToC.API
'Imports BMC.ARSystem
'Imports System.Diagnostics
'Imports System.IO
'Imports System.Text

'Public Class frmInfoRequired

'    Dim persalnumber As String

'    Private Sub frmInfoRequired_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
'        If e.KeyChar = Chr(27) Then
'            Me.Close()
'        End If
'    End Sub

'    Private Sub frmInfoRequired_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
'        'TODO: This line of code loads data into the 'ARSystemDataSet.VIEW_CFO_RULES_FLAGS_OUTSTANDING' table. You can move, or remove it, as needed.
'        Me.VIEW_CFO_RULES_FLAGS_OUTSTANDINGTableAdapter.FillVIEW_CFO_RULES_FLAGS_OUTSTANDING(Me.ARSystemDataSet.VIEW_CFO_RULES_FLAGS_OUTSTANDING)
'        'TODO: This line of code loads data into the 'ARSystemDataSet.VIEW_CFO_RULES_FLAGS_OUTSTANDING' table. You can move, or remove it, as needed.
'        'Me.VIEW_CFO_RULES_FLAGS_OUTSTANDINGTableAdapter.FillVIEW_CFO_RULES_FLAGS_OUTSTANDING(Me.ARSystemDataSet.VIEW_CFO_RULES_FLAGS_OUTSTANDING)
'        'TODO: This line of code loads data into the 'ARSystemDataSet.LOG_IN_Request_Tracking' table. You can move, or remove it, as needed.
'        Me.LOG_IN_Request_TrackingTableAdapter.FillByRefer2Client(Me.ARSystemDataSet.LOG_IN_Request_Tracking)
'        If ADAdminDotNet.frmEnvironment.ActiveMdiChild.Text = "Active Directory Console - PRD" Then
'            ADAdminDotNet.frmEnvironment.ChildFormPRD.txtRemedyRequestNo.Text = ""
'            ADAdminDotNet.frmEnvironment.ChildFormPRD.txtRemedyNo.Text = ""
'        ElseIf ADAdminDotNet.frmEnvironment.ActiveMdiChild.Text = "Active Directory Console - QA" Then
'            ADAdminDotNet.frmEnvironment.childformQA.txtRemedyRequestNo.Text = ""
'            ADAdminDotNet.frmEnvironment.childformQA.txtRemedyNo.Text = ""
'        End If

'    End Sub

'    Private Sub ExportToExcelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportToExcelToolStripMenuItem.Click
'        Dim mstr As String
'        Dim table As DataTable
'        table = Me.LOG_IN_Request_TrackingTableAdapter.GetRefer2Client
'        ExportCSV(table, AppPath() & "InfoRequired.csv")
'        mstr = AppPath() & "InfoRequired.csv"
'        If File.Exists(mstr) Then
'            Process.Start(mstr)
'        End If
'    End Sub

'    'Private Sub LOG_IN_Request_TrackingDataGridView_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles LOG_IN_Request_TrackingDataGridView.CellContentDoubleClick

'    '    Dim path As String
'    '    Dim apppath As String
'    '    apppath = System.AppDomain.CurrentDomain.BaseDirectory

'    '    If Not System.IO.Directory.Exists(apppath & "requests") Then
'    '        System.IO.Directory.SetAccessControl(apppath, AddSecurityAccessRule())
'    '        System.IO.Directory.CreateDirectory(apppath & "requests", AddSecurityAccessRule())
'    '    End If

'    '    System.IO.Directory.SetAccessControl(apppath & "requests", AddSecurityAccessRule())

'    '    path = apppath & "requests\" & Replace(Replace(DirectCast(LOG_IN_Request_TrackingDataGridView.Item(0, e.RowIndex).Value, String), "/", "_"), ":", "_") & ".artask"

'    '    If File.Exists(path) Then
'    '    Else
'    '        Dim sw As StreamWriter = File.CreateText(path)
'    '        sw.WriteLine("[Shortcut]")
'    '        sw.WriteLine("Name = LOG_IN_Request Tracking")
'    '        sw.WriteLine("Type = 0")
'    '        sw.WriteLine("Server = " & My.Settings.RemedyServerName.Trim)
'    '        sw.WriteLine("Join = 0")
'    '        sw.WriteLine("Ticket = " & DirectCast(LOG_IN_Request_TrackingDataGridView.Item("Request_No", e.RowIndex).Value, String))
'    '        sw.Flush()
'    '        sw.Close()
'    '    End If
'    '    Cleartxt = False

'    '    ADAdminDotNet.frmMain.txtPersalNumber.Text = LOG_IN_Request_TrackingDataGridView.Item("Persal_Number", e.RowIndex).Value.ToString
'    '    If ADAdminDotNet.frmEnvironment.ActiveMdiChild.Text = "Active Directory Console - PRD" Then
'    '        ADAdminDotNet.frmEnvironment.ChildFormPRD.txtRemedyRequestNo.Text = LOG_IN_Request_TrackingDataGridView.CurrentRow.Cells("Request_No").Value.ToString()
'    '        ADAdminDotNet.frmEnvironment.ChildFormPRD.txtRemedyNo.Text = LOG_IN_Request_TrackingDataGridView.CurrentRow.Cells("Request_No").Value.ToString()
'    '        ADAdminDotNet.frmEnvironment.ChildFormPRD.txtRightsRequested.Text = ""
'    '        ADAdminDotNet.frmEnvironment.ChildFormPRD.txtPersalNumber.Text = LOG_IN_Request_TrackingDataGridView.CurrentRow.Cells("Persal_Number").Value.ToString()
'    '        ADAdminDotNet.frmEnvironment.ChildFormPRD.txtRightsRequested.Text = "REQUEST : " & LOG_IN_Request_TrackingDataGridView.CurrentRow.Cells("Request_No").Value.ToString()
'    '        ADAdminDotNet.frmEnvironment.ChildFormPRD.txtRightsRequested.Text += " " & LOG_IN_Request_TrackingDataGridView.CurrentRow.Cells("Long_Description").Value.ToString()
'    '        ADAdminDotNet.frmEnvironment.ChildFormPRD.btnActiveDirectory_Click(sender, e)
'    '    ElseIf ADAdminDotNet.frmEnvironment.ActiveMdiChild.Text = "Active Directory Console - QA" Then
'    '        ADAdminDotNet.frmEnvironment.childformQA.txtRemedyRequestNo.Text = LOG_IN_Request_TrackingDataGridView.CurrentRow.Cells("Request_No").Value.ToString()
'    '        ADAdminDotNet.frmEnvironment.childformQA.txtRemedyNo.Text = LOG_IN_Request_TrackingDataGridView.CurrentRow.Cells("Request_No").Value.ToString()
'    '        ADAdminDotNet.frmEnvironment.childformQA.txtRightsRequested.Text = ""
'    '        ADAdminDotNet.frmEnvironment.childformQA.txtPersalNumber.Text = LOG_IN_Request_TrackingDataGridView.CurrentRow.Cells("Persal_Number").Value.ToString()
'    '        ADAdminDotNet.frmEnvironment.childformQA.txtRightsRequested.Text = "REQUEST : " & LOG_IN_Request_TrackingDataGridView.CurrentRow.Cells("Request_No").Value.ToString()
'    '        ADAdminDotNet.frmEnvironment.childformQA.btnActiveDirectory_Click(sender, e)
'    '    End If
'    '    'If File.Exists(path) Then
'    '    '    Process.Start(path)
'    '    'End If
'    '    Me.Close()
'    'End Sub

'    Private Sub ExportEstablishementxlsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportEstablishementxlsToolStripMenuItem.Click

'        Dim dt As New DataTable
'        Dim dtRequests As New DataTable
'        Dim path As String
'        Dim sstr As String
'        Dim s As String
'        Dim i As Integer
'        Dim sw As StreamWriter

'        path = AppPath() & "ExportedEstabQuery.csv"


'        If File.Exists(path) Then

'            If MsgBox("The file " & path.Trim + " you want to create exists. Do you want to delete it? And try again", MsgBoxStyle.YesNo, "File Exists") = MsgBoxResult.Yes Then
'                Try
'                    File.Delete(path)
'                Catch ex As Exception
'                    MsgBox("Cannot delete file " & path.Trim + ". It is being used by some process.", MsgBoxStyle.OkOnly, "Error deleting file")
'                End Try
'            End If

'        Else
'            sw = File.CreateText(path)
'            sstr = "PERSALNR,SNAME,SUR_INI,PROVDESC,DEPTDESC,RANKDESC,JOBTITLE,PAYDIST,PAYPOINT,APPTNAT"

'            sw.WriteLine(sstr)

'            For i = 0 To Me.LOG_IN_Request_TrackingDataGridView.RowCount - 1

'                dt = DirectCast(Me.Ta_Establishment.GetData(DirectCast(LOG_IN_Request_TrackingDataGridView.Item("Persal_Number", i).Value, String)), DataTable)
'                If dt.Rows.Count > 0 Then
'                    s = ""
'                    s += dt.Rows(0).Item("PERSALNR").ToString.Trim & ","
'                    s += dt.Rows(0).Item("SNAME").ToString.Trim & ","
'                    s += dt.Rows(0).Item("SUR_INI").ToString.Trim & ","
'                    s += dt.Rows(0).Item("PROVDESC").ToString.Trim & ","
'                    s += dt.Rows(0).Item("DEPTDESC").ToString.Trim & ","
'                    s += dt.Rows(0).Item("RANKDESC").ToString.Trim & ","
'                    s += dt.Rows(0).Item("JOBTITLE").ToString.Trim & ","
'                    s += dt.Rows(0).Item("PAYDIST").ToString.Trim & ","
'                    s += dt.Rows(0).Item("PAYPOINT").ToString.Trim & ","
'                    s += dt.Rows(0).Item("APPTNAT").ToString.Trim

'                    sw.WriteLine(s)

'                End If

'            Next
'            sw.Flush()
'            sw.Close()
'        End If

'        If File.Exists(path) Then
'            Process.Start(path)
'        End If

'        sw = Nothing

'    End Sub

'    Private Sub FillToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
'        'Try
'        '    Me.Ta_Establishment.Fill(Me.Ads.Establishment, PersalnumberToolStripTextBox.Text)
'        'Catch ex As System.Exception
'        '    System.Windows.Forms.MessageBox.Show(ex.Message)
'        'End Try

'    End Sub

'    Private Sub frmInfoRequired_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
'        Me.LOG_IN_Request_TrackingDataGridView.Width = Me.Width - 9
'        Me.LOG_IN_Request_TrackingDataGridView.Height = Me.Height - 82
'    End Sub

'    Private Sub frmInfoRequired_ResizeEnd(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ResizeEnd
'        Me.LOG_IN_Request_TrackingDataGridView.Width = Me.Width - 9
'        Me.LOG_IN_Request_TrackingDataGridView.Height = Me.Height - 82
'    End Sub

'    Private Sub CLoseThisRemedyRequestToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles CLoseThisRemedyRequest.Click

'        'Dim mm As String
'        'mm = LOG_IN_Request_TrackingDataGridView.Item(0, e.).ToString

'        Dim i As Integer
'        Dim userid As String
'        Dim pwd As String
'        Dim MyEntryID As String
'        Dim a As ARUSER.COMAppObj = New ARUSER.COMAppObj

'        'Dim a As BMC.ARSystem.COMMethod = New BMC.ARSystem.ARForm ' ARSystem.COMMethod
'        'a.
'        'Dim RemedyProcess As Process
'        'Dim SessionID As VariantType
'        Dim RemedyForm As ARUSER.ICOMFormWnd
'        'Dim RemedyForm As New BMC.ARSystem.RegularForm

'        'Dim MyResultForm As ARUSER.COMQueryResult
'        'Dim MyResultForm As RemedyForm

'        'COMQueryResult()
'        Dim InfoRequiredCol As New Microsoft.VisualBasic.Collection
'        Dim RemedyQueryObject As ARUSER.ICOMQueryResultSet
'        'Dim li As New BMC.ARSystem.Utilities.Common.Login
'        'Dim a As New BMC.ARSystem.RegularForm

'        Dim RemedyProcesses() As Process = Process.GetProcessesByName("ARUSER")

'        If frmEnvironment.ChildFormPRD.Visible Then
'            frmEnvironment.ChildFormPRD.timerCOUNTS.Stop()
'        Else
'            frmEnvironment.childformQA.timerCOUNTS.Stop()
'        End If

'        Try
'            'RemedyForm =    DirectCast(a.(0, My.Settings.RemedyServerName.Trim, "LOG_IN_Request Tracking", ARUSER.OpenMode.ARQuery, 0), ARUSER.ICOMFormWnd)
'        Catch ex As Exception
'            If Err.Number = -2147216284 Then
'                For Each RemedyProcess In RemedyProcesses
'                    RemedyProcess.Kill()
'                Next
'            End If
'            If Err.Number = -2147216287 Or Err.Number = -2147023174 Then
'                For i = 1 To 3
'                    userid = InputBox("Please enter your Remedy User ID Please?", "System Message", "T000")
'                    pwd = InputBox("Enter your password please", "System Message", "logik007")
'                    If userid = "" Or pwd = "" Then
'                        MsgBox("You did not enter valid values", MsgBoxStyle.OkOnly)
'                        If frmEnvironment.ChildFormPRD.Visible Then
'                            frmEnvironment.ChildFormPRD.timerCOUNTS.Start()
'                        Else
'                            frmEnvironment.childformQA.timerCOUNTS.Start()
'                        End If
'                        Exit Sub
'                    End If
'                    'SessionID = DirectCast(a.Login(userid.ToString, pwd, 0), VariantType)
'                    If Err.Number = -2147467259 Then
'                        MsgBox(Err.Description)
'                        '                        a.Logout(0)
'                        a = Nothing
'                    Else
'                        Exit For
'                    End If
'                Next
'            End If
'        End Try

'        Try

'            RemedyForm = DirectCast(a.OpenForm(0, My.Settings.RemedyServerName.Trim, "LOG_IN_Request Tracking", ARUSER.OpenMode.ARQuery, 0), ARUSER.ICOMFormWnd)
'            RemedyForm.GetField("Request_No").Value = RequestNumber
'            RemedyForm.GetField("Solution").Value = RemedyForm.GetField("Solution").Value & " - CFO Letter Not Received in time"
'            RemedyQueryObject = DirectCast(RemedyForm.Query(""), ARUSER.ICOMQueryResultSet)

'            If RemedyQueryObject.Count > 0 Then
'                MyResultForm = DirectCast(RemedyQueryObject.Item(1), ARUSER.COMQueryResult)
'                MyEntryID = MyResultForm.entryId
'                RemedyForm = DirectCast(a.LoadForm(0, My.Settings.RemedyServerName.Trim, "LOG_IN_Request Tracking", MyEntryID, DirectCast(eOpenMode, ARUSER.OpenMode), 1), ARUSER.ICOMFormWnd)
'            End If

'            If frmEnvironment.ChildFormPRD.Visible Then
'                With frmEnvironment.ChildFormPRD
'                    .txtPersalNumber.Text = persalnumber
'                    .btnActiveDirectory_Click(sender, e)
'                    .txtPersalNumber.Focus()
'                    .txtPersalNumber.SelectAll()
'                    .timerCOUNTS.Start()
'                End With
'            Else
'                With frmEnvironment.childformQA
'                    .txtPersalNumber.Text = persalnumber
'                    .btnActiveDirectory_Click(sender, e)
'                    .txtPersalNumber.Focus()
'                    .txtPersalNumber.SelectAll()
'                    .timerCOUNTS.Start()
'                End With
'            End If

'        Catch ex As Exception
'            If Err.Number = -2147216287 Then
'                MsgBox("An internal error occured please try again", MsgBoxStyle.Critical)
'                If frmEnvironment.ChildFormPRD.Visible Then
'                    frmEnvironment.ChildFormPRD.timerCOUNTS.Start()
'                Else
'                    frmEnvironment.childformQA.timerCOUNTS.Start()
'                End If
'                Exit Sub
'            End If
'        End Try
'        If frmEnvironment.ChildFormPRD.Visible Then
'            frmEnvironment.ChildFormPRD.timerCOUNTS.Start()
'        Else
'            frmEnvironment.childformQA.timerCOUNTS.Start()
'        End If

'    End Sub

'    Private Sub NoCFOLetterReceivedInTimeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NoCFOLetterReceivedInTimeToolStripMenuItem.Click

'        Dim mm As String = ""
'        Dim counter As Integer
'        Dim rownumber As Integer
'        Dim i As Integer
'        rownumber = 0
'        For counter = 0 To (LOG_IN_Request_TrackingDataGridView.SelectedCells.Count - 1)
'            If LOG_IN_Request_TrackingDataGridView.SelectedCells(counter).FormattedValueType Is Type.GetType("System.String") Then
'                Dim value As String = Nothing
'                rownumber = LOG_IN_Request_TrackingDataGridView.SelectedCells(counter).RowIndex
'                For i = 0 To 9
'                    mm += LOG_IN_Request_TrackingDataGridView.Rows(rownumber).Cells(i).Value.ToString.Trim & vbCrLf
'                Next
'                MsgBox(mm, MsgBoxStyle.Exclamation, "Title")
'            End If
'        Next
'    End Sub

'    Private Sub LOG_IN_Request_TrackingDataGridView_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles LOG_IN_Request_TrackingDataGridView.KeyUp
'        If e.KeyValue = 27 Then
'            Me.Close()
'        End If
'    End Sub

'    Private Sub ExportCFOApprovalsOutstandingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportCFOApprovalsOutstandingToolStripMenuItem.Click
'        Dim dt As New DataTable
'        Dim dtRequests As New DataTable
'        Dim path As String
'        Dim sstr As String
'        Dim sw As StreamWriter
'        Dim s As String = ""

'        path = AppPath() & "CFO_Approvals_Outstanding.csv"

'        If File.Exists(path) Then

'            If MsgBox("The file " & path.Trim + " you want to create exists. Do you want to delete it? And try again", MsgBoxStyle.YesNo, "File Exists") = MsgBoxResult.Yes Then
'                Try
'                    File.Delete(path)
'                    MsgBox("Please try to create the file again!", MsgBoxStyle.OkOnly, "Error in deleting the file at first")
'                Catch ex As Exception
'                    MsgBox("Cannot delete file " & path.Trim + ". It is being used by some process.", MsgBoxStyle.OkOnly, "Error deleting file")
'                End Try
'            End If

'        Else
'            sw = File.CreateText(path)

'            sstr = "CFOPersalNo,CFOComments,RemedyReqNo,CFOFullNames,CFOSurname,CFOTel, CFOCell,CFOEmail, CFODesignation, CFODeptCode, CFODepartment"

'            sw.WriteLine(sstr)

'            'For i = 0 To Me.LOG_IN_Request_TrackingDataGridView.RowCount - 1

'            dt = Me.VIEW_CFO_RULES_FLAGS_OUTSTANDINGTableAdapter.GetDataVIEW_CFO_RULES_FLAGS_OUTSTANDING()

'            For Each row As DataRow In dt.Rows

'                s = ""
'                s += row.Item("CFOPersalNo").ToString.Trim & ","
'                s += row.Item("CFOComments").ToString.Trim & ","
'                s += row.Item("RemedyReqNo").ToString.Trim & ","
'                s += row.Item("CFOFullNames").ToString.Trim & ","
'                s += row.Item("CFOSurname").ToString.Trim & ","
'                s += row.Item("CFOTel").ToString.Trim & ","
'                s += row.Item("CFOCell").ToString.Trim & ","
'                s += row.Item("CFOEmail").ToString.Trim & ","
'                s += row.Item("CFODesignation").ToString.Trim & ","
'                s += row.Item("CFODeptCode").ToString.Trim & ","
'                s += row.Item("CFODepartment").ToString.Trim

'                sw.WriteLine(s)

'            Next

'            sw.Flush()
'            sw.Close()

'        End If

'        If File.Exists(path) Then
'            Process.Start(path)
'        End If

'        sw = Nothing

'    End Sub

'    'Private Sub OpenRequest(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click

'    '    Me.LOG_IN_Request_TrackingTableAdapter.ClearBeforeFill = True
'    '    For Each dr In LOG_IN_Request_TrackingDataGridView.Rows
'    '        If dr.cells(0).value = Nothing Then
'    '            LOG_IN_Request_TrackingDataGridView.Rows.Remove(dr)
'    '        End If
'    '    Next
'    '    LOG_IN_Request_TrackingDataGridView.DataSource = Nothing
'    '    LOG_IN_Request_TrackingDataGridView.DataSource = LOG_IN_Request_TrackingBindingSource
'    '    Me.LOG_IN_Request_TrackingTableAdapter.FillByRefer2Client(Me.ARSystemDataSet.LOG_IN_Request_Tracking)
'    '    Me.Refresh()

'    'End Sub

'    Private Sub CLoseThisRemedyRequestToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CLoseThisRemedyRequest.Click
'        'Dim requestnumberclicked As String = VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("Request_No").value
'        'dsADSTableAdapters.RULES_FLAGSTableAdapter
'        'VIP_USERS_NewUsersTableAdapter.FlagCompletedByID(123)
'        'UpdateDoneToCompleted()
'        'dsADS.RULES_FLAGS1DataTable.(requestnumberclicked)
'        MsgBox("Please call Johan Vermeulen")
'    End Sub

'    'Private Sub OpenRequest()

'    '    '        Dim svr As New BMC.ARSystem.Server()
'    '    '        svr.Login("10.123.216.103", "T0005221", "logk007", "")

'    '    ''Search a Remedy Form Start

'    '    'Dim RequestID As String = "000000000000001"
'    '    'Dim FromForm As String = DirectCast(svr.GetListEntry("LOG_IN_Request Tracking", String.Format("'1' = ""{0}""", RequestID))(0), BMC.ARSystem.EntryDescription).Description
'    '    'Dim qualification As String = String.Format("'1' = " & RequestID)
'    '    'Dim fieldList As New BMC.ARSystem.EntryListFieldList()

'    '    'fieldList.Add(New BMC.ARSystem.EntryListField(8))
'    '    'fieldList.Add(New BMC.ARSystem.EntryListField(3))

'    '    'Dim entryList = svr.GetListEntryWithFields("LOG_IN_Request Tracking", qualification, fieldList, 0, 0)

'    '    'Console.WriteLine(entryList(0).FieldValues(8))
'    '    'Console.WriteLine(entryList(0).FieldValues(3))
'    '    'Console.ReadLine()

'    'End Sub

'    'Private Sub LOG_IN_Request_TrackingDataGridView_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles LOG_IN_Request_TrackingDataGridView.CellContentDoubleClick
'    '    Me.LOG_IN_Request_TrackingTableAdapter.ClearBeforeFill = True
'    '    For Each dr In LOG_IN_Request_TrackingDataGridView.Rows
'    '        If dr.cells(0).value = Nothing Then
'    '            LOG_IN_Request_TrackingDataGridView.Rows.Remove(dr)
'    '        End If
'    '    Next
'    '    LOG_IN_Request_TrackingDataGridView.DataSource = Nothing
'    '    LOG_IN_Request_TrackingDataGridView.DataSource = LOG_IN_Request_TrackingBindingSource
'    '    Me.LOG_IN_Request_TrackingTableAdapter.FillByRefer2Client(Me.ARSystemDataSet.LOG_IN_Request_Tracking)
'    '    Me.Refresh()
'    'End Sub
'End Class

#End Region