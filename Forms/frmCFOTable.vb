Imports System.IO

Public Class frmCFOTable

    Private Sub CFOListBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CFOListBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CFOListBindingSource.EndEdit()
        Me.CFOListTableAdapter.Update(Me.DsADS.CFOList)
    End Sub

    Private Sub frmCFOTable_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsADS.CFOList' table. You can move, or remove it, as needed.
        Me.CFOListTableAdapter.Fill(Me.DsADS.CFOList)
    End Sub

    Private Sub txtDeptCode_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDeptCode.KeyUp

        Me.CFOListTableAdapter.FillByDept_Code(Me.DsADS.CFOList, "%" & txtDeptCode.Text.Trim & "%")
        If e.KeyValue = 27 Then
            Me.Close()
        End If
    End Sub

    Private Sub txtPersalNo_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPersalNo.KeyUp
        Me.CFOListTableAdapter.FillByPersalNo(Me.DsADS.CFOList, "%" & txtPersalNo.Text.Trim & "%")
        If e.KeyValue = 27 Then
            Me.Close()
        End If
    End Sub

    Private Sub txtSurname_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSurname.KeyUp
        Me.CFOListTableAdapter.FillBySurname(Me.DsADS.CFOList, "%" & txtSurname.Text.Trim & "%")
        If e.KeyValue = 27 Then
            Me.Close()
        End If
    End Sub

    Private Sub ExportToCFOListcsvToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportToCFOListcsvToolStripMenuItem.Click
        Dim tbl As New DataTable
        Dim path As String
        tbl = Me.CFOListTableAdapter.GetData()
        ExportCSV(tbl, AppPath() & "Chief_Financial_Officers.csv")
        path = AppPath() & "Chief_Financial_Officers.csv"
        If File.Exists(path) Then
            Process.Start(path)
        End If

    End Sub

    Private Sub CFOListDataGridView_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles CFOListDataGridView.CellContentDoubleClick
        Dim txtPersalNo As String = ""
        Dim ws As New ARSWS.Webpage
        Dim pro As New Process
        Dim Environment As String = Me.Text

        txtPersalNo = Me.CFOListDataGridView.CurrentRow.Cells("dgPersalNo").Value 'Persal_Number
        pro = ws.Open_All_Requests_For_PersalNo(txtPersalNo, Environment)
        Me.Cursor = Cursors.Arrow

    End Sub


    Private Sub CFOListDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles CFOListDataGridView.DataError
        Try
            If String.IsNullOrEmpty(DirectCast(CFOListDataGridView.Item(e.ColumnIndex, e.RowIndex).Value, String)) Then
                CFOListDataGridView.Item(e.ColumnIndex, e.RowIndex).Value = "-Unclassified-"
            End If
        Catch ex As Exception
            CFOListDataGridView.Item(e.ColumnIndex, e.RowIndex).Value = "-Error-"
        End Try
    End Sub

    Private Sub CFOListDataGridView_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CFOListDataGridView.KeyUp
        If e.KeyValue = 27 Then
            Me.Close()
        End If
    End Sub

    Private Sub tsButtonFlagInvalids_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsButtonFlagInvalids.Click

        'Dim dt As New DataTable
        'Dim persalno As String
        'Dim r As DataGridViewRow

        'For Each r In Me.CFOListDataGridView.Rows
        '    persalno = r.Cells(2).Value.trim
        '    If r.Cells(2).Value = "" Then
        '    Else
        '        dt = Me.Ta_Establishment.GetData(Me.txtPersalNumber.Text)
        '        If dt.Rows.Count > 0 Then
        '            Return True
        '        Else
        '            Return False
        '        End If

        '    End If
        '    Me.Cursor = Cursors.Arrow
        'Next

    End Sub

    Private Sub CFOListDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles CFOListDataGridView.CellContentClick

    End Sub
End Class