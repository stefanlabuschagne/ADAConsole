Imports System.IO
Imports System.Text
'Imports BMC.ARSystem

Public Class frmResetPassword

    Dim ids As Integer

    Private Sub frmResetPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(27) Then
            Me.Close()
        End If
    End Sub

    Private Sub frmResetPassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ads.VIP_USERS_ResetPassword' table. You can move, or remove it, as needed.
            Me.VIP_USERS_ResetPasswordTableAdapter.Fill(Me.Ads.VIP_USERS_ResetPassword)
    End Sub

    Private Sub VIP_USERS_ResetPasswordDataGridView_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles VIP_USERS_ResetPasswordDataGridView.CellContentDoubleClick

        Cleartxt = False

        Dim persalnumber As String
        persalnumber = Replace(VIP_USERS_ResetPasswordDataGridView.CurrentRow.Cells("PersalNrDataGridViewTextBoxColumn").Value.ToString(), "P", "")
        persalnumber = Replace(persalnumber, "p", "")
        Dim email_address As String = Get_EmailAddress(persalnumber.Trim)

        Dim pro As Process
        Dim ws As New ARSWS.Webpage
        Dim Environment As String = Me.Text
        ' pro = ws.Open_CustomerInformation_For_PersalNo(persalnumber)

        ids = 0
        ids = Convert.ToInt32(VIP_USERS_ResetPasswordDataGridView.CurrentRow.Cells("IDDataGridViewTextBoxColumn").Value.ToString().ToLower)

        If (email_address.Length > 0) And (VIP_USERS_ResetPasswordDataGridView.CurrentRow.Cells("EMailDataGridViewTextBoxColumn").Value.ToString().ToLower <> email_address.Trim.ToLower) Then
            If MsgBox("WARNING!!!" & Chr(13) & Chr(10) & Chr(13) & Chr(10) & "NEW EMAIL: " & VIP_USERS_ResetPasswordDataGridView.CurrentRow.Cells("EMailDataGridViewTextBoxColumn").Value.ToString().ToLower & Chr(13) & Chr(10) & _
                   "OLD EMAIL: " & email_address.Trim.ToLower & Chr(13) & Chr(10) & Chr(13) & Chr(10) & _
                   "Do you want to procceed", MsgBoxStyle.YesNo, "EMail Addresses Differ") = MsgBoxResult.No Then
                Exit Sub
            End If
        End If

        Try
            'modFunctions.OpenRemedyCustomer1(Me.VIP_USERS_ResetPasswordDataGridView, sender, e, ARUSER.OpenMode.ARModify, "frmResetPassword")
            ws.Reset_Password(persalnumber, Environment)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Remedy System Message")
        End Try


        If ADAdminDotNet.frmEnvironment.ActiveMdiChild.Text = "Active Directory Console - PRD" Then
            ADAdminDotNet.frmEnvironment.ChildFormPRD.txtRemedyRequestNo.Text = ""
            ADAdminDotNet.frmEnvironment.ChildFormPRD.txtRemedyNo.Text = ""
            ADAdminDotNet.frmEnvironment.ChildFormPRD.txtPersalNumber.Text = persalnumber.Trim
            ADAdminDotNet.frmEnvironment.ChildFormPRD.btnActiveDirectory_Click(sender, e)
            ADAdminDotNet.frmEnvironment.ChildFormPRD.txtRightsRequested.Text = "Please reset my Password" & vbCrLf & "Notes = " & VIP_USERS_ResetPasswordDataGridView.CurrentRow.Cells("NotesDataGridViewTextBoxColumn").Value.ToString() & ""
        ElseIf ADAdminDotNet.frmEnvironment.ActiveMdiChild.Text = "Active Directory Console - QA" Then
            ADAdminDotNet.frmEnvironment.childformQA.txtRemedyRequestNo.Text = ""
            ADAdminDotNet.frmEnvironment.childformQA.txtRemedyNo.Text = ""
            ADAdminDotNet.frmEnvironment.childformQA.txtPersalNumber.Text = persalnumber.Trim
            ADAdminDotNet.frmEnvironment.childformQA.btnActiveDirectory_Click(sender, e)
            ADAdminDotNet.frmEnvironment.childformQA.txtRightsRequested.Text = "Please reset my Password" & Chr(13) & Chr(10) & "Notes = " & VIP_USERS_ResetPasswordDataGridView.CurrentRow.Cells("NotesDataGridViewTextBoxColumn").Value.ToString() & ""
        End If
        Me.Close()

    End Sub

    Public Sub FlagSuspiciousRemoveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlagSuspiciousRemoveToolStripMenuItem.Click

        Dim pID As Long = CLng(0)
        Dim persalno As String = ""
        pID = DirectCast(VIP_USERS_ResetPasswordDataGridView.CurrentRow.Cells("IDDataGridViewTextBoxColumn").Value, Long)
        persalno = VIP_USERS_ResetPasswordDataGridView.CurrentRow.Cells("PersalNrDataGridViewTextBoxColumn").Value.ToString().Trim
        Me.VIP_USERS_ResetPasswordTableAdapter.UpdateDoneTo3(pID)
        persalno = Get_ValidPersalNumber(persalno)
        If frmEnvironment.ChildFormPRD.Visible Then
            frmEnvironment.ChildFormPRD.ADCONSOLELOGTableAdapter.InsertIntoADAdminConsoleLog2(frmEnvironment.ChildFormPRD.tsLoggedOnUser.Text, persalno, "Flagged Status 3", False)
            Me.VIP_USERS_ResetPasswordTableAdapter.ClearBeforeFill = True
            Me.VIP_USERS_ResetPasswordTableAdapter.Fill(Me.Ads.VIP_USERS_ResetPassword)
            VIP_USERS_ResetPasswordDataGridView.Refresh()
            frmEnvironment.ChildFormPRD.Refresh_Log()
        Else
            frmEnvironment.childformQA.ADCONSOLELOGTableAdapter.InsertIntoADAdminConsoleLog2(frmEnvironment.childformQA.tsLoggedOnUser.Text, persalno, "Flagged Status 3", False)
            Me.VIP_USERS_ResetPasswordTableAdapter.ClearBeforeFill = True
            Me.VIP_USERS_ResetPasswordTableAdapter.Fill(Me.Ads.VIP_USERS_ResetPassword)
            VIP_USERS_ResetPasswordDataGridView.Refresh()
            frmEnvironment.childformQA.Refresh_Log()
        End If

    End Sub

    Private Sub ExportFlagged3ToCSVToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportFlagged3ToCSVToolStripMenuItem.Click
        ExportCSV(Me.VIP_USERS_ResetPasswordTableAdapter.GetFlagged3(), AppPath() & "User_Password_Resets.csv")
        If File.Exists(AppPath() & "User_Password_Resets.csv") Then
            Process.Start(AppPath() & "User_Password_Resets.csv")
        End If
    End Sub

    Private Sub VIP_USERS_ResetPasswordDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles VIP_USERS_ResetPasswordDataGridView.CellContentClick

    End Sub


End Class