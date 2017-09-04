Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports LibFTPServ.FTP
Imports LibFTPServ.VFS

Public Partial Class MainForm
	Inherits Form
	Private _serv As FTPServer

	Public Sub New()
		InitializeComponent()
		_serv = New FTPServer()
		AddHandler _serv.OnLogEvent, New FTPLogEventHandler(AddressOf _serv_OnLogEvent)
		_serv.DownloadSpeedLimit = 120 * 1024
		userManager1.Manager = _serv.Users
	End Sub

	Private Sub _serv_OnLogEvent(sender As Object, e As FTPLogEventArgs)
		Dim litem As New ListViewItem()
		litem.Text = e.EventDate.ToShortTimeString()
		litem.SubItems.Add(Helpers.FtpEventToString(e.EventType))
		litem.SubItems.Add(Helpers.BoolConvert(e.Succes))
		litem.SubItems.Add(e.User)

		Dim args As New StringBuilder()
		For Each arg As String In e.arguments
			args.Append(arg)
			args.Append(", ")
		Next
		litem.SubItems.Add(args.ToString())
		LogList.Items.Add(litem)
	End Sub

	Private Function CanStart() As Boolean
		If _serv.Users.Count < 1 Then
			Return False
		End If
		If _serv.Port < 1 Then
			Return False
		End If
		Return True
	End Function

	Private Sub btnStart_Click(sender As Object, e As EventArgs)
		Dim addr As System.Net.IPAddress
		If CanStart() Then
			btnStop.Enabled = True
			btnStart.Enabled = False
			PanelSettings.Enabled = False

			If cbDlLimit.Checked Then
				_serv.DownloadSpeedLimit = CInt(Math.Truncate(NumDlLimit.Value * 1024))
			Else
				_serv.DownloadSpeedLimit = -1
			End If

			If cbUlLimit.Checked Then
				_serv.UploadSpeedLimit = CInt(Math.Truncate(NumUlLimit.Value * 1024))
			Else
				_serv.UploadSpeedLimit = -1
			End If

			For Each ip As String In tbAllow.Lines
				System.Net.IPAddress.TryParse(ip, addr)
				_serv.AcceptedAdresses.Add(addr)
			Next

			For Each ip As String In tbBan.Lines
				System.Net.IPAddress.TryParse(ip, addr)
				_serv.BannedAdresses.Add(addr)
			Next

			_serv.Port = CInt(Math.Truncate(NumPort.Value))
			_serv.Start()
		Else
			MessageBox.Show("Server can't start, because there are no users defined.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
		End If
	End Sub

	Private Sub btnStop_Click(sender As Object, e As EventArgs)
		btnStop.Enabled = False
		btnStart.Enabled = True
		PanelSettings.Enabled = True
		_serv.[Stop]()
	End Sub

	Private Sub cbUlLimit_CheckedChanged(sender As Object, e As EventArgs)
		NumUlLimit.Enabled = cbUlLimit.Checked
	End Sub

	Private Sub cbDlLimit_CheckedChanged(sender As Object, e As EventArgs)
		NumDlLimit.Enabled = cbDlLimit.Checked
	End Sub

	Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs)
		If Not btnStart.Enabled Then
			btnStop_Click(sender, Nothing)
		End If
		Properties.Settings.[Default].Save()
		userManager1.SaveConfiguration()
	End Sub

	Private Sub MainForm_Resize(sender As Object, e As EventArgs)
		If Me.WindowState = FormWindowState.Minimized Then
			Me.Visible = False
		Else
			Me.Visible = True
		End If
	End Sub

	Private Sub notifyIcon_Click(sender As Object, e As EventArgs)
		If Not Me.Visible Then
			Me.Visible = True
			Me.BringToFront()
			Me.WindowState = FormWindowState.Normal
		Else
			Me.WindowState = FormWindowState.Minimized
			Me.Visible = False
		End If
	End Sub

	Private Sub BtnLogClear_Click(sender As Object, e As EventArgs)
		LogList.Items.Clear()
	End Sub
End Class
