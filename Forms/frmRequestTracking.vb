Imports System.Diagnostics
Imports System.IO
Imports System.Text
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports Microsoft.SqlServer.Server

Public Class frmRequestTracking

    Private Sub frmRequestTracking_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsARSystemDataSet.LOG_IN_Request_Tracking' table. You can move, or remove it, as needed.
        'Me.LOG_IN_Request_TrackingTableAdapter.FillBy(Me.DsARSystemDataSet.LOG_IN_Request_Tracking)
        Me.RemedyOpenRequestsTableAdapter.Fill(Me.ARSystemDataSet.RemedyOpenRequests)
    End Sub

    Private Sub ExportToExcelToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExportToExcelToolStripMenuItem.Click
        Dim mstr As String
        ExportCSV(Me.DsARSystemDataSet.LOG_IN_Request_Tracking, AppPath() & "LOG_IN_Request_Tracking.csv")
        mstr = AppPath() & "LOG_IN_Request_Tracking.csv"
        If File.Exists(mstr) Then
            Process.Start(mstr)
        End If
    End Sub

    Private Sub ExportToXMLToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExportToXMLToolStripMenuItem.Click
        Dim mstr As String
        ExportXML(Me.DsARSystemDataSet.LOG_IN_Request_Tracking, AppPath() & "LOG_IN_Request_Tracking.xlsx")
        mstr = AppPath() & "LOG_IN_Request_Tracking.xml"
        If File.Exists(mstr) Then
            Process.Start(AppPath())
        End If
    End Sub

    Private Sub FillByToolStripButton_Click(sender As System.Object, e As System.EventArgs)
        Try
            Me.RemedyOpenRequestsTableAdapter.Fill(Me.ARSystemDataSet.RemedyOpenRequests)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Function RemedyOpenRequestsTableAdapter() As Object
        Throw New NotImplementedException
    End Function

    Private Function ARSystemDataSet() As Object
        Throw New NotImplementedException
    End Function

End Class