#Region "WS1"
'Server IP Address:                10.123.216.103
'Server’s Fully Qualified name:    DevLGRemV1.Logis.gov.za
'Domain name:                      Logis.gov.za
'Version of the OS:                Windows Server 2012 Standard
'                Environment:      Dev\Test Remedy


'Server IP Address:                10.123.216.104
'Server’s Fully Qualified name:    DevLGSqlV1.Logis.gov.za
'Domain name:                      Logis.gov.za
'Version of the OS:                Windows Server 2012 Standard
'Version of the SQL:               SQL 2012 Standard
'                Environment:      Dev\Test SQL
'                Access:           Logis\Vulindlela BMC     (Group)
'                Database:         ARSystem (Remedy)
'                                  Public, db_DataReader
'Imports ARNetToC.API
'Imports BMC.ARSystem

'Dim s As New BMC.ARSystem.Server
'Dim frm As String = "LOG_IN_Request_Tracking"
'Dim m As String = ""

's.Login("10.123.216.103", "T0005221", "logik007", "", 8080)


'Dim lst As New ArrayList
'lst = s.GetListForm()
'For i = 1 To lst.Count
'm += (lst(i)) & Chr(13) & Chr(10)
'Next
'MsgBox(m)
'Dim f = a.GetForm("LOG_IN_Request Tracking")

#End Region
Imports System.Diagnostics
Imports System.IO
Imports System.Text
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports Microsoft.SqlServer.Server

Public Class frmOpenRequests

    Private Sub frmOpenRequests_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Me.RemedyOpenRequestsTableAdapter.Fill(Me.ARSystemDataSet.RemedyOpenRequests)
    End Sub

    Private Sub frmOpenRequests_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress

        If e.KeyChar = Chr(27) Then
            Me.Close()
        End If
    End Sub

    Private Sub RemedyOpenRequestsDataGridView_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles RemedyOpenRequestsDataGridView.CellContentDoubleClick
        Cleartxt = False

        Dim sRequestNo As String = RemedyOpenRequestsDataGridView.Item("DataGridViewTextBoxColumn20", e.RowIndex).Value.ToString
        Dim sPersalNumber As String = RemedyOpenRequestsDataGridView.CurrentRow.Cells("DataGridViewTextBoxColumn70").Value.ToString().ToUpper
        Dim Environment As String = Me.Text
        Dim ws As New ARSWS.Webpage
        ws.Open_Request_No(RemedyOpenRequestsDataGridView.Item("DataGridViewTextBoxColumn20", e.RowIndex).Value.ToString, Environment)
        ws = Nothing

        sPersalNumber = Replace(sPersalNumber, "p", "")

        If ADAdminDotNet.frmEnvironment.ActiveMdiChild.Text = "Active Directory Console - PRD" Then
            ADAdminDotNet.frmEnvironment.ChildFormPRD.txtPersalNumber.Text = sPersalNumber.Trim
            ADAdminDotNet.frmEnvironment.ChildFormPRD.btnActiveDirectory_Click(sender, e)
            ADAdminDotNet.frmEnvironment.ChildFormPRD.txtRightsRequested.Text = RemedyOpenRequestsDataGridView.CurrentRow.Cells("DataGridViewTextBoxColumn14").Value.ToString
            ADAdminDotNet.frmEnvironment.ChildFormPRD.txtRemedyRequestNo.Text = sRequestNo.Trim
            ADAdminDotNet.frmEnvironment.ChildFormPRD.txtRemedyNo.Text = sRequestNo.Trim
        ElseIf ADAdminDotNet.frmEnvironment.ActiveMdiChild.Text = "Active Directory Console - QA" Then
            ADAdminDotNet.frmEnvironment.childformQA.txtPersalNumber.Text = sPersalNumber.Trim
            ADAdminDotNet.frmEnvironment.childformQA.btnActiveDirectory_Click(sender, e)
            ADAdminDotNet.frmEnvironment.childformQA.txtRightsRequested.Text = RemedyOpenRequestsDataGridView.CurrentRow.Cells("DataGridViewTextBoxColumn14").Value.ToString
            ADAdminDotNet.frmEnvironment.childformQA.txtRemedyRequestNo.Text = sRequestNo.Trim
            ADAdminDotNet.frmEnvironment.childformQA.txtRemedyNo.Text = sRequestNo.Trim
        End If

        'If My.MySettings.Default.PropertyValues("Close_Pick_Forms").PropertyValue = True Then
        Me.Close()
        '  End If




        'Cleartxt = False
        'Dim pro As Process
        'Dim ws As New ARSWS.Webpage
        'pro = ws.Open_Request_No(RemedyOpenRequestsDataGridView.Item("dgTxtRequest_No", e.RowIndex).Value.ToString)




        'Try
        '    ws.Open_Request(RemedyOpenRequestsDataGridView.Item("Request_No", e.RowIndex).Value.ToString)
        '    '(RemedyOpenRequestsDataGridView.CurrentRow.Cells("Request_N").Value.ToString)
        '    frmNewUsers.VIP_USERS_NewUsersDataGridView.CurrentRow.Cells("TelB").Value.ToString()
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try

        '' pro = ws.Open_Request_No(RemedyOpenRequestsDataGridView.Item("dgTxtRequest_No", e.RowIndex).Value.ToString)
        'Me.Close()

    End Sub

    Public Shared Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        frmOpenRequests.RemedyOpenRequestsTableAdapter.Fill(frmOpenRequests.ARSystemDataSet.RemedyOpenRequests)
        frmOpenRequests.Refresh()
    End Sub

    Private Sub ExportToCSVToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportToCSVToolStripMenuItem.Click
        Dim mstr As String
        ExportCSV(Me.ARSystemDataSet.RemedyOpenRequests, AppPath() & "Open_Remedy_Requests.csv")
        mstr = AppPath() & "Open_Remedy_Requests.csv"
        If File.Exists(mstr) Then
            Process.Start(mstr)
        End If
    End Sub

    Private Sub frmOpenRequests_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Me.RemedyOpenRequestsDataGridView.Width = Me.Width - 9
        Me.RemedyOpenRequestsDataGridView.Height = Me.Height - 82
    End Sub

    Private Sub frmOpenRequests_ResizeEnd(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ResizeEnd
        Me.RemedyOpenRequestsDataGridView.Width = Me.Width - 9
        Me.RemedyOpenRequestsDataGridView.Height = Me.Height - 82
    End Sub



    Private Sub mnuResetPassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuResetPassword.Click

    End Sub

    Private Sub RemedyOpenRequestsDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles RemedyOpenRequestsDataGridView.CellContentClick

    End Sub
End Class

Partial Public Class Triggers

    <SqlTrigger(Name:="UserNameAudit", Target:="Users", Event:="FOR INSERT")> _
    Public Shared Sub UserNameAudit()

        Dim triggContext As SqlTriggerContext = SqlContext.TriggerContext()
        Dim userName As New SqlParameter("@username", SqlDbType.NVarChar)

        If triggContext.TriggerAction = TriggerAction.Insert Then

            Using conn As New SqlConnection("context connection=true")
                conn.Open()
                Dim sqlComm As New SqlCommand
                Dim sqlP As SqlPipe = SqlContext.Pipe()
                sqlComm.Connection = conn
                sqlComm.CommandText = "SELECT UserName from INSERTED"
                userName.Value = sqlComm.ExecuteScalar.ToString()
                If IsEMailAddress(userName.ToString) Then
                    sqlComm.CommandText = "INSERT UsersAudit(UserName) VALUES(username)"
                    sqlP.Send(sqlComm.CommandText)
                    sqlP.ExecuteAndSend(sqlComm)
                End If
            End Using
        End If
    End Sub

    Public Shared Function IsEMailAddress(ByVal s As String) As Boolean
        Return Regex.IsMatch(s, "^([\w-]+\.)*?[\w-]+@[\w-]+\.([\w-]+\.)*?[\w]+$")
    End Function
End Class