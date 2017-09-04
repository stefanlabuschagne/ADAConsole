Imports System
Imports System.IO
Imports System.Web
Imports System.Text
Imports System.Net.Mail
Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class frmWebRequest

    Private Sub frmWebRequest_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(27) Then
            Me.Close()
        End If
    End Sub

    Private Sub GetByID1ToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetByID1ToolStripButton.Click

        Dim id As Integer
        Dim Accountlevel As String
        id = CLng(IdToolStripTextBox.Text)
        Accountlevel = AccLevelToolStripTextBox.Text
        Try
            Me.VIP_USERSTableAdapter.GetByID1(Me.Ads.VIP_USERS, CLng(IdToolStripTextBox.Text))
            Me.textAccLevel.Text = Accountlevel
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

       

    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub




    Private Sub frmWebRequest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetByID1ToolStripButton_Click(sender, e)
    End Sub

    Private Sub NOTESTextBox_TextChanged(sender As Object, e As EventArgs) Handles NOTESTextBox.TextChanged

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub
End Class