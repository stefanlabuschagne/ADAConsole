Imports System.IO

Public Class frmRemedyBySurname

    Private Sub frmRemedyBySurname_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim a As DataGridView
        'a = Me.RemedyByFirstLetterOfSurnameDataGridView
        Me.RemedyByFirstLetterOfSurnameTableAdapter.FillByFirstLetterOfSurname(Me.ARSystemDataSet.RemedyByFirstLetterOfSurname(), "A")
        ' This does not work. It seems it does not retain focus
        'If Me.RemedyByFirstLetterOfSurnameDataGridView.RowCount > 0 Then
        '    Me.RemedyByFirstLetterOfSurnameDataGridView.Rows(1).Cells(1).Selected = True
        'End If
        'a.HitTest(a.Rows(1).Cells(0).
        'Me.RemedyByFirstLetterOfSurnameDataGridView.Columns(1)..Focus()


        If frmEnvironment.ChildFormPRD.Visible Then

            ' My.MySettings.Default("AdsConnectionString") = My.MySettings.Default.Default("AdsPRDConnectionString")

            Me.RemedyByFirstLetterOfSurnameTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemProdConnectionString")
            Me.RemedyByFirstLetterOfSurnameTableAdapter.FillByFirstLetterOfSurname(Me.ARSystemDataSet.RemedyByFirstLetterOfSurname(), "A")

        ElseIf frmEnvironment.childformQA.Visible Then

            Me.RemedyByFirstLetterOfSurnameTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemDevConnectionString")
            Me.RemedyByFirstLetterOfSurnameTableAdapter.FillByFirstLetterOfSurname(Me.ARSystemDataSet.RemedyByFirstLetterOfSurname(), "A")

        End If
    End Sub
    Private Sub TabControl1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TabControl1.KeyUp
        If e.KeyValue = 27 Then
            Me.Close()
        End If
    End Sub
    Private Sub txtSearch_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyUp
        If e.KeyValue = 27 Then
            Me.Close()
        End If
    End Sub
    Private Sub frmRemedyBySurname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(27) Then
            Me.Close()
        End If
    End Sub

    Private Sub TabControl1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.Click
        Me.RemedyByFirstLetterOfSurnameTableAdapter.FillByFirstLetterOfSurname(Me.ARSystemDataSet.RemedyByFirstLetterOfSurname(), TabControl1.SelectedTab.Text.ToUpper.Trim & "%")
    End Sub

    Private Sub frmRemedyBySurname_ResizeEnd(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ResizeEnd

        Dim x As Integer, y As Integer
        Try
            x = Me.RemedyByFirstLetterOfSurnameDataGridView.Width
            y = Me.RemedyByFirstLetterOfSurnameDataGridView.Height - Me.StatusStrip1.Height
            Me.RemedyByFirstLetterOfSurnameDataGridView.Width = Me.Width - 18
            Me.RemedyByFirstLetterOfSurnameDataGridView.Height = Me.Height - 93 - Me.StatusStrip1.Height
        Catch ex As Exception
            Me.RemedyByFirstLetterOfSurnameDataGridView.Width = x
            Me.RemedyByFirstLetterOfSurnameDataGridView.Height = y
        End Try

    End Sub

    Private Sub RemedyByFirstLetterOfSurnameDataGridView_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles RemedyByFirstLetterOfSurnameDataGridView.CellContentDoubleClick
        frmEnvironment.ChildFormPRD.txtPersalNumber.Text = RemedyByFirstLetterOfSurnameDataGridView.CurrentRow.Cells(0).Value.ToString()
        frmEnvironment.ChildFormPRD.btnActiveDirectory_Click(sender, e)
        Me.Hide()
    End Sub

    Private Sub RemedyByFirstLetterOfSurnameDataGridView_keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles RemedyByFirstLetterOfSurnameDataGridView.KeyPress
        If e.KeyChar = Chr(27) Then
            Me.Close()
        End If
    End Sub

    Private Sub ExportSelectedTabToCSVToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportSelectedTabToCSVToolStripMenuItem.Click
        txtSearch_TextChanged(sender, e)
        Dim path As String = AppPath() & "Remedy_" & Me.TabControl1.SelectedTab.Text.Trim & ".csv"
        Dim tbl As System.Data.DataTable
        tbl = Me.RemedyByFirstLetterOfSurnameTableAdapter.GetDataByFirstLetterOfSurname(Me.TabControl1.SelectedTab.Text.Trim & "%")
        ExportCSV(tbl, path)
        If File.Exists(path) Then
            Process.Start(path)
        End If
        tbl.Dispose()
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Me.RemedyByFirstLetterOfSurnameTableAdapter.FillByFirstLetterOfSurname(Me.ARSystemDataSet.RemedyByFirstLetterOfSurname(), txtSearch.Text.Trim & "%")
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Me.RemedyByFirstLetterOfSurnameTableAdapter.FillByFirstLetterOfSurname(Me.ARSystemDataSet.RemedyByFirstLetterOfSurname(), "%")
        ' txtSearch_TextChanged(sender, e)
        ExportCSV(Me.ARSystemDataSet.RemedyByFirstLetterOfSurname(), AppPath() & "Vulindlela_Remedy_Clients.csv")
        If File.Exists(AppPath() & "Vulindlela_Remedy_Clients.csv") Then
            Process.Start(AppPath() & "Vulindlela_Remedy_Clients.csv")
        End If
        'tbl = Nothing
    End Sub

    Private Sub TabControl1_Selecting(sender As Object, e As System.Windows.Forms.TabControlCancelEventArgs) Handles TabControl1.Selecting
        ToolStripDropDownButton1.DropDownItems("ExportSelectedTabToCSVToolStripMenuItem").Text = "Export to Remedy_" & Me.TabControl1.SelectedTab.Text.Trim & ".csv"
    End Sub

    Private Sub A_GotFocus(sender As Object, e As System.EventArgs) Handles A.GotFocus
        Me.RemedyByFirstLetterOfSurnameTableAdapter.FillByFirstLetterOfSurname(Me.ARSystemDataSet.RemedyByFirstLetterOfSurname(), "A%")
    End Sub

    Private Sub RemedyByFirstLetterOfSurnameDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles RemedyByFirstLetterOfSurnameDataGridView.CellContentClick

    End Sub
End Class