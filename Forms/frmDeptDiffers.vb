Imports System.IO
Imports System.Text

Public Class frmDeptDiffers

    Private Sub Department_DiffersDataGridView_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Department_DiffersDataGridView.KeyUp
        If e.KeyValue = 27 Then
            Me.Close()
        End If
    End Sub

    Private Sub frmDeptDiffers_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(27) Then
            Me.Close()
        End If
    End Sub

    Private Sub Department_DiffersBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Department_DiffersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Department_DiffersBindingSource.EndEdit()
        Me.Department_DiffersTableAdapter.Update(Me.DsADS.Department_Differs)

    End Sub

    Private Sub frmDeptDiffers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsADS.Department_Differs' table. You can move, or remove it, as needed.
            Me.Department_DiffersTableAdapter.Fill(Me.DsADS.Department_Differs)
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Dim tbl As New System.Data.DataTable
        Dim path As String
        tbl = Me.Department_DiffersTableAdapter.GetData
        ExportCSV(tbl, AppPath() & "Department_Differs.csv")
        path = AppPath() & "Department_Differs.csv"
        If File.Exists(path) Then
            Process.Start(path)
        End If
    End Sub

    Private Sub Department_DiffersDataGridView_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Department_DiffersDataGridView.CellContentDoubleClick

        If ADAdminDotNet.frmEnvironment.ActiveMdiChild.Text = "Active Directory Console - PRD" Then
            ADAdminDotNet.frmEnvironment.ChildFormPRD.txtPersalNumber.Text = _
                    Me.Department_DiffersDataGridView.CurrentRow.Cells(0).Value.ToString()
            ADAdminDotNet.frmEnvironment.ChildFormPRD.btnActiveDirectory_Click(sender, e)
        ElseIf ADAdminDotNet.frmEnvironment.ActiveMdiChild.Text = "Active Directory Console - QA" Then
            ADAdminDotNet.frmEnvironment.childformQA.txtPersalNumber.Text = _
                    Me.Department_DiffersDataGridView.CurrentRow.Cells(0).Value.ToString()
            ADAdminDotNet.frmEnvironment.childformQA.btnActiveDirectory_Click(sender, e)
        End If
        Me.Close()

    End Sub

    Private Sub Department_DiffersDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Department_DiffersDataGridView.CellContentClick

    End Sub
End Class