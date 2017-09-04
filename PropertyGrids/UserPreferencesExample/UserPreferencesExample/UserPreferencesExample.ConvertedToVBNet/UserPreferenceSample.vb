Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports UserPreferencesExample.Properties

Public Partial Class UserPreferenceSample
	Inherits Form
	Private defaultSettings As Settings
	Public Sub New()
		InitializeComponent()
	End Sub

	Private Sub btnSave_Click(sender As Object, e As EventArgs)
		If defaultSettings IsNot Nothing Then
			'Save button's settings
			defaultSettings.ButtonBackColor = btnSave.BackColor
			defaultSettings.SaveButtonText = btnSave.Text

			'Save the Form's Settings
			defaultSettings.FirstFormHeader = Me.Text
			defaultSettings.FormBackColor = Me.BackColor
			defaultSettings.FormForeColor = Me.ForeColor
			defaultSettings.FormOpacity = Me.Opacity
			defaultSettings.FormWindowState = Me.WindowState
			defaultSettings.Save()
		End If
	End Sub

	Private Sub MyFirstForm_Load(sender As Object, e As EventArgs)
		defaultSettings = New Settings()
	End Sub

	Private Sub txtFormHeader_KeyPress(sender As Object, e As KeyPressEventArgs)

		If Me.Text.Equals(defaultSettings.FirstFormHeader) Then
			Me.Text = String.Empty
		Else
			Me.Text = Me.txtFormHeader.Text
		End If
	End Sub

	Private Sub txtButtonText_KeyPress(sender As Object, e As KeyPressEventArgs)
		If Me.btnSave.Text.Equals(defaultSettings.FirstFormHeader) Then
			Me.btnSave.Text = String.Empty
		Else
			Me.btnSave.Text = Me.txtButtonText.Text
		End If
	End Sub
End Class
