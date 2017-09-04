Imports System
Imports Microsoft.SqlServer.Dts.Runtime.Package
Imports Microsoft.SqlServer.Dts.Runtime.Wrapper
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Deployment
Imports System.Net.Mime

Public Class frmRunSSIS

    Private Sub frmRunSSIS_Load(sender As System.Object, e As System.EventArgs)
        Me.LinkLabel1.Text = My.MySettings.Default.PropertyValues.Item("PakageFilePath").PropertyValue
    End Sub

    Private Sub frmRunSSIS_Load_1(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.View_Stageable_ApplicationsTableAdapter.Fill(Me.Ds.View_Stageable_Applications)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim pkgLocation As String = ""
        Dim pkg As New Microsoft.SqlServer.Dts.Runtime.Package
        Dim app As New Microsoft.SqlServer.Dts.Runtime.Application
        Dim pkgResults As New Microsoft.SqlServer.Dts.Runtime.DTSExecResult
        pkgLocation = Me.LinkLabel1.Text.Trim
        Try
            pkg = app.LoadPackage(pkgLocation, Nothing)
            Dim vars As Microsoft.SqlServer.Dts.Runtime.Variables = pkg.Variables
            vars("Application").Value = Me.NameComboBox.SelectedItem.ToString()
            pkgResults = pkg.Execute()
            txtLog.Text = pkgResults
        Catch ex As Exception
            MsgBox("", MsgBoxStyle.Critical + MsgBoxStyle.OkCancel, "File does  not exist")
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.OpenFileDialog1.InitialDirectory = System.IO.Path.GetDirectoryName(Me.LinkLabel1.Text)
        Me.OpenFileDialog1.FileName = System.IO.Path.GetFileName(Me.LinkLabel1.Text)
        Me.OpenFileDialog1.ShowDialog(Me)
        Me.LinkLabel1.Text = Me.OpenFileDialog1.FileName
        My.MySettings.Default("PakageFilePath") = Me.OpenFileDialog1.FileName
        Me.OpenFileDialog1.Title = "Please Select the Package file..."
    End Sub
End Class