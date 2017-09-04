Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports LibFTPServ.FTP
Imports System.IO

Public Partial Class UserManagerControl
	Inherits UserControl
	Private _um As UserManager
	Private _newcounter As Integer
	Private _modified As Boolean

	Public Sub New()
		InitializeComponent()
	End Sub

	Public WriteOnly Property Manager() As UserManager
		Set
			_um = value
			_newcounter = 1

			If File.Exists(Helpers.AppDir & "\users.xml") Then
				Try
					Dim s As Stream = File.OpenRead(Helpers.AppDir & "\users.xml")
					_um.Deserialize(s)
					s.Close()
					UpdateUserPanel()
				Catch generatedExceptionName As Exception
					MessageBox.Show("Can't load user data", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
				End Try
			End If
		End Set
	End Property

	Public Sub SaveConfiguration()
		Try
			If File.Exists(Helpers.AppDir & "\users.xml") Then
				File.Delete(Helpers.AppDir & "\users.xml")
			End If
			Dim s As Stream = File.Create(Helpers.AppDir & "\users.xml")
			_um.Serialize(s)
			s.Close()
			UpdateUserPanel()
		Catch generatedExceptionName As Exception
			MessageBox.Show("Can't save user data", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
		End Try
	End Sub

	Private Sub UpdateUserPanel()
		lbUsers.Items.Clear()
		lbUsers.Items.AddRange(_um.UserNames)
	End Sub

	Private Sub SetPermissions(perm As FTPUserPermission)
		cbRDelete.Checked = perm.Delete
		cbRListhidden.Checked = perm.ListHidden
		cbRRename.Checked = perm.Rename
		cbRUpload.Checked = perm.Upload
	End Sub

	Private Function SetPermissions() As FTPUserPermission
		Dim ret As New FTPUserPermission()
		ret.Upload = cbRUpload.Checked
		ret.Rename = cbRRename.Checked
		ret.ListHidden = cbRListhidden.Checked
		ret.Delete = cbRDelete.Checked
		Return ret
	End Function

    Private Sub lbUsers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbUsers.SelectedIndexChanged
        If lbUsers.SelectedIndex < 0 AndAlso lbUsers.SelectedIndex > lbUsers.Items.Count Then
            btnDelete.Enabled = False
        Else
            If _modified Then
                Dim dr As DialogResult = MessageBox.Show("User info changed. Save changes ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If dr = DialogResult.Yes Then
                    btnSave_Click(sender, e)
                End If
            End If

            tbUserName.Text = ""
            tbUserPass.Text = ""
            tbUserHome.Text = ""

            Dim u As FTPUser = _um(lbUsers.SelectedItem.ToString())

            tbUserName.Text = u.Name
            tbUserPass.Text = u.SHA1Password
            tbUserHome.Text = u.Startupdir
            SetPermissions(u.Permissions)

            btnDelete.Enabled = True
            _modified = False
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        _um.AddUser(New FTPUser("New user " & _newcounter.ToString(), ""))
        UpdateUserPanel()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim u As FTPUser = _um(lbUsers.SelectedItem.ToString())
        u.Name = tbUserName.Text
        u.SetPassword(tbUserPass.Text)
        u.Permissions = SetPermissions()
        u.Startupdir = tbUserHome.Text
        btnSave.Enabled = False
        UpdateUserPanel()
    End Sub

    Private Sub TextfieldChanged(sender As Object, e As EventArgs) Handles tbUserPass.TextChanged, tbUserName.TextChanged, tbUserHome.TextChanged
        _modified = True
        btnSave.Enabled = True
    End Sub

    Private Sub RightsChanges(sender As Object, e As EventArgs) Handles cbRUpload.CheckedChanged, cbRRename.CheckedChanged, cbRListhidden.CheckedChanged, cbRDelete.CheckedChanged
        _modified = True
        btnSave.Enabled = True
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        If Not String.IsNullOrEmpty(tbUserHome.Text) Then
            FolderBrowser.SelectedPath = tbUserHome.Text
        End If
        If FolderBrowser.ShowDialog() = DialogResult.OK Then
            tbUserHome.Text = FolderBrowser.SelectedPath
        End If
    End Sub
End Class
