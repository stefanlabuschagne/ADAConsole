Imports System.IO

Public Class frmEstablishment

    Public ExportFileName As String = "AllData.csv"

    Private Sub EstablishmentDataGridView_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles EstablishmentDataGridView.KeyUp
        If e.KeyValue = 27 Then
            Me.Close()
        End If
    End Sub

    Private Sub ExportAllToCSVToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportAllToCSVToolStripMenuItem.Click

        Dim table As New DataTable
        Dim mstr As String = ""
        Me.txtSCODE.Text = ""
        'Me.txtJOBTITLE.Text = ""
        Me.txtNAME.Text = ""
        ExportFileName = Me.txtJOBTITLE.Text & ".csv"
        Me.Ta_Establishment.FillBy_JOBTITLE(Me.Ads.Establishment, "%" & txtSCODE.Text.Trim & "%")
        Me.ExportAllToCSVToolStripMenuItem.Text = "Export to " & Me.txtJOBTITLE.Text & ".csv"
        ExportCSV(table, AppPath() & Me.txtJOBTITLE.Text & ".csv")
        mstr = AppPath() & "Referred_for_CFO_Approval.csv"
        If File.Exists(mstr) Then
            Process.Start(mstr)
        End If



        Dim tbl As New System.Data.DataTable
        Dim path As String
        tbl = Me.Ta_Establishment.GetDataByAll
        path = AppPath() & "Establishment_All.csv"
        ExportCSV(tbl, path)
        If File.Exists(path) Then
            Process.Start(path)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' Me.txtSCODE.Text = ""
        Me.txtJOBTITLE.Text = ""
        Me.txtNAME.Text = ""
        Me.Data_PersonnelAndAppointment002TableAdapter.FillBy_SName(Me.HRDataSet.Data_PersonnelAndAppointment002, "%" & txtSCODE.Text.Trim & "%")
        Me.ExportAllToCSVToolStripMenuItem.Text = "Export to " & Me.txtSCODE.Text & ".csv"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.txtSCODE.Text = ""
        Me.txtJOBTITLE.Text = ""
        'Me.txtNAME.Text = ""
        Me.Data_PersonnelAndAppointment002TableAdapter.FillBy_SUR_INI(Me.HRDataSet.Data_PersonnelAndAppointment002, "%" & txtNAME.Text.Trim & "%")
        Me.ExportAllToCSVToolStripMenuItem.Text = "Export to " & Me.txtNAME.Text & ".csv"
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim table As New DataTable
        Dim mstr As String = ""
        Me.txtSCODE.Text = ""
        Me.txtNAME.Text = ""
        ExportFileName = Me.txtJOBTITLE.Text & ".csv"
        Me.Data_PersonnelAndAppointment002TableAdapter.FillBy_JOBTITLE(Me.HRDataSet.Data_PersonnelAndAppointment002, "%" & txtJOBTITLE.Text.Trim & "%")
        Me.ExportAllToCSVToolStripMenuItem.Text = "Export to " & Me.txtJOBTITLE.Text & ".csv"
        ExportCSV(table, AppPath() & Me.txtJOBTITLE.Text & ".csv")
        mstr = AppPath() & "Referred_for_CFO_Approval.csv"
        If File.Exists(mstr) Then
            Process.Start(mstr)
        End If

        'Dim mstr As String
        'Dim table As DataTable
        'table = Me.CFOApproval_ta.GetCFOApproval
        'If File.Exists(AppPath() & "Referred_for_CFO_Approval.csv") Then
        '    If MsgBox("File exists. Do you want to delete the current file?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
        '        File.Delete(AppPath() & "Referred_for_CFO_Approval.csv")
        '    End If
        'End If
        'ExportCSV(table, AppPath() & "Referred_for_CFO_Approval.csv")
        'mstr = AppPath() & "Referred_for_CFO_Approval.csv"
        'If File.Exists(mstr) Then
        '    Process.Start(mstr)
        'End If

    End Sub

    Private Sub txtSCODE_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSCODE.KeyUp
        If e.KeyValue = 27 Then
            Me.Close()
        End If
    End Sub

    Private Sub frmEstablishment_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(27) Then
            Me.Close()
        End If
    End Sub

    Private Sub EstablishmentDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles EstablishmentDataGridView.CellContentClick

    End Sub
End Class