Imports System.IO

Public Class frmConfigProblem

    Dim adminid As Object

    Private Sub Config_ProblemBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Config_ProblemBindingSource.EndEdit()
        Me.Config_ProblemTableAdapter.Update(Me.DsADS.Config_Problem)
    End Sub

    Private Sub frmConfigProblem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsADS.Config_Problem' table. You can move, or remove it, as needed.
        Me.Config_ProblemTableAdapter.Fill(Me.DsADS.Config_Problem)
        'TODO: This line of code loads data into the 'DsADS.Config_Problem' table. You can move, or remove it, as needed.
        ' Me.Config_ProblemTableAdapter.Fill(Me.DsADS.Config_Problem)
    End Sub

    Private Sub tsLogIncident_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim adminid As Long
        Dim updatesuccess As Integer
        adminid = DirectCast(frmVPNadmins.VPNAdminsDataGridView.CurrentRow.Cells("IDColumn").Value, Long)
        With frmVPNadmins.VPNAdminsDataGridView.CurrentRow
            Me.Config_ProblemTableAdapter.ClearBeforeFill = True
            updatesuccess = Me.Config_ProblemTableAdapter.InsertQuery(adminid, _
                            frmEnvironment.ChildFormPRD.txtPersalNumber.Text.Trim, _
                            ADAdminDotNet.frmEnvironment.ChildFormPRD.txtFirst_NameTextBox.Text.Trim, _
                            ADAdminDotNet.frmEnvironment.ChildFormPRD.txtLast_NameTextBox.Text.Trim, _
                            Now().Date, InputBox("Please enter details of the problem here!!", "Short Description Of the Error", "", _
                                        (ActiveForm.Bottom - ActiveForm.Top) \ 2, _
                                        (ActiveForm.Right - ActiveForm.Left) \ 2))
        End With

    End Sub

    Private Sub Config_ProblemBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Config_ProblemBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Config_ProblemBindingSource.EndEdit()
        Me.Config_ProblemTableAdapter.Update(Me.DsADS.Config_Problem)
    End Sub

    Private Sub Config_ProblemDataGridView_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Config_ProblemDataGridView.CellContentDoubleClick
        Dim i As Integer
        Dim cAdminID As String = ""
        Dim cPersalNo As String = ""
        Dim dgv As DataGridView = DirectCast(sender, DataGridView)
        Dim hdr As DataGridViewCell = dgv.CurrentCell
        If DirectCast(hdr.OwningColumn.HeaderText.ToString.ToLower, String) = "persalno" Then
            cPersalNo = hdr.Value.ToString
            With frmEnvironment.ChildFormPRD
                .txtPersalNumber.Text = cPersalNo.Trim
                .btnActiveDirectory_Click(sender, e)
            End With
            Me.Hide()
        ElseIf hdr.OwningColumn.HeaderText.ToString.ToLower.Trim = "adminid" Then
            cAdminID = hdr.Value.ToString.Trim
            Me.Hide()
            If frmVPNadmins.Visible Then
                frmVPNadmins.Visible = True
            Else
                frmVPNadmins.Show()
            End If
            For i = 0 To frmVPNadmins.VPNAdminsDataGridView.RowCount - 1
                If frmVPNadmins.VPNAdminsDataGridView.CurrentRow.Cells("IDColumn").ToString.Trim = cAdminID.Trim Then
                    frmVPNadmins.VPNAdminsDataGridView.Rows.Item(i).Selected = True
                    Exit For
                End If
            Next
        End If

    End Sub

    Private Sub tsIncident_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsIncident.Click

        Dim txtVPNAdminsID As Long
        Dim adminid As Long
        Dim updatesuccess As Integer

        adminid = DirectCast(frmVPNadmins.VPNAdminsDataGridView.CurrentRow.Cells("IDColumn").Value, Long)
        txtVPNAdminsID = DirectCast(Me.Config_ProblemDataGridView.CurrentRow.Cells("txtVPNAdminsID").Value, Long)

        With Me.Config_ProblemDataGridView.CurrentRow
            Me.Config_ProblemTableAdapter.ClearBeforeFill = True
            updatesuccess = Me.Config_ProblemTableAdapter.InsertQuery(adminid, _
                            frmEnvironment.ChildFormPRD.txtPersalNumber.Text.Trim, _
                            ADAdminDotNet.frmEnvironment.ChildFormPRD.txtFirst_NameTextBox.Text.Trim, _
                            ADAdminDotNet.frmEnvironment.ChildFormPRD.txtLast_NameTextBox.Text.Trim, _
                            Now().Date, _
                            InputBox("Please enter details of the problem here!!", _
                            "Short Description Of the Error", _
                            "", _
                            (ActiveForm.Bottom - ActiveForm.Top) \ 2, _
                            (ActiveForm.Right - ActiveForm.Left) \ 2))

        End With

    End Sub

    Private Sub Config_ProblemDataGridView_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Config_ProblemDataGridView.KeyUp
        If e.KeyValue = 27 Then
            Me.Close()
        End If
    End Sub

    Private Sub frmConfigProblems_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(27) Then
            Me.Close()
        End If
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        adminid = frmVPNadmins.VPNAdminsDataGridView.CurrentRow.Cells("IDColumn").Value
        Dim txtVPNAdminsID As String = DirectCast(Me.Config_ProblemDataGridView.CurrentRow.Cells("txtVPNAdminsID").Value, String)
        Me.Validate()
        Me.Config_ProblemBindingSource.EndEdit()
        ' Me.Config_ProblemTableAdapter.UpdateConfigProblem(txtVPNAdminsID, frmVPNadmins.VPNAdminsDataGridView.CurrentRow.Cells("IDColumn").Value)
    End Sub

    Private Sub ExportToProlemxlsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExportToProlemxlsToolStripMenuItem.Click
        Dim mstr As String
        Dim tbl As DataTable
        tbl = Me.VpN_Admin_CategoriesTableAdapter1.GetData
        ExportCSV(tbl, AppPath() & "VpN_Admin_Categories.csv")
        mstr = AppPath() & "VpN_Admin_Categories.csv"
        If File.Exists(mstr) Then
            Process.Start(mstr)
        End If
    End Sub

    Private Sub Config_ProblemDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Config_ProblemDataGridView.CellContentClick

    End Sub
End Class
