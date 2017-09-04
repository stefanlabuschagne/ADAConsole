Imports System.IO

Public Class frmVulExceptions

    Private Sub EXCLUSIONSBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EXCLUSIONSBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EXCLUSIONSBindingSource.EndEdit()
        Me.EXCLUSIONSTableAdapter.Update(Me.DsADS.EXCLUSIONS)

    End Sub

    Private Sub frmVulExceptions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsADS.EXCLUSIONS' table. You can move, or remove it, as needed.
        Me.EXCLUSIONSTableAdapter.FillExclusions(Me.DsADS.EXCLUSIONS)

    End Sub

    Private Sub Export2ExcelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Export2ExcelToolStripMenuItem.Click
        Dim tbl As New DataTable
        Dim path As String
        tbl = Me.EXCLUSIONSTableAdapter.GetDataExclusions()
        path = AppPath() & "VulindlelaExceptions.csv"
        ExportCSV(tbl, path)
        If File.Exists(path) Then
            Process.Start(path)
        End If
    End Sub

End Class