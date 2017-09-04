Partial Class UserPreferenceSample
	''' <summary>
	''' Required designer variable.
	''' </summary>
	Private components As System.ComponentModel.IContainer = Nothing

	''' <summary>
	''' Clean up any resources being used.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(disposing As Boolean)
		If disposing AndAlso (components IsNot Nothing) Then
			components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub

	#Region "Windows Form Designer generated code"

	''' <summary>
	''' Required method for Designer support - do not modify
	''' the contents of this method with the code editor.
	''' </summary>
	Private Sub InitializeComponent()
		Me.btnSave = New System.Windows.Forms.Button()
		Me.tbcMyTab = New System.Windows.Forms.TabControl()
		Me.tbPage1 = New System.Windows.Forms.TabPage()
		Me.propertyGrid1 = New System.Windows.Forms.PropertyGrid()
		Me.tbPage2 = New System.Windows.Forms.TabPage()
		Me.propertyGridButton = New System.Windows.Forms.PropertyGrid()
		Me.txtFormHeader = New System.Windows.Forms.TextBox()
		Me.label1 = New System.Windows.Forms.Label()
		Me.label2 = New System.Windows.Forms.Label()
		Me.txtButtonText = New System.Windows.Forms.TextBox()
		Me.tbcMyTab.SuspendLayout()
		Me.tbPage1.SuspendLayout()
		Me.tbPage2.SuspendLayout()
		Me.SuspendLayout()
		' 
		' btnSave
		' 
		Me.btnSave.BackColor = Global.UserPreferencesExample.Properties.Settings.[Default].ButtonBackColor
		Me.btnSave.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.UserPreferencesExample.Properties.Settings.[Default], "SaveButtonText", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.btnSave.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.UserPreferencesExample.Properties.Settings.[Default], "ButtonBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.btnSave.Location = New System.Drawing.Point(345, 444)
		Me.btnSave.Name = "btnSave"
		Me.btnSave.Size = New System.Drawing.Size(75, 23)
		Me.btnSave.TabIndex = 0
		Me.btnSave.Text = Global.UserPreferencesExample.Properties.Settings.[Default].SaveButtonText
		Me.btnSave.UseVisualStyleBackColor = False
		AddHandler Me.btnSave.Click, New System.EventHandler(AddressOf Me.btnSave_Click)
		' 
		' tbcMyTab
		' 
		Me.tbcMyTab.Controls.Add(Me.tbPage1)
		Me.tbcMyTab.Controls.Add(Me.tbPage2)
		Me.tbcMyTab.Location = New System.Drawing.Point(12, 29)
		Me.tbcMyTab.Name = "tbcMyTab"
		Me.tbcMyTab.SelectedIndex = 0
		Me.tbcMyTab.Size = New System.Drawing.Size(408, 409)
		Me.tbcMyTab.TabIndex = 1
		' 
		' tbPage1
		' 
		Me.tbPage1.Controls.Add(Me.propertyGrid1)
		Me.tbPage1.Location = New System.Drawing.Point(4, 22)
		Me.tbPage1.Name = "tbPage1"
		Me.tbPage1.Padding = New System.Windows.Forms.Padding(3)
		Me.tbPage1.Size = New System.Drawing.Size(400, 383)
		Me.tbPage1.TabIndex = 0
		Me.tbPage1.Text = "Form Properties"
		Me.tbPage1.UseVisualStyleBackColor = True
		' 
		' propertyGrid1
		' 
		Me.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.propertyGrid1.Location = New System.Drawing.Point(3, 3)
		Me.propertyGrid1.Name = "propertyGrid1"
		Me.propertyGrid1.SelectedObject = Me
		Me.propertyGrid1.Size = New System.Drawing.Size(394, 377)
		Me.propertyGrid1.TabIndex = 0
		' 
		' tbPage2
		' 
		Me.tbPage2.Controls.Add(Me.propertyGridButton)
		Me.tbPage2.Location = New System.Drawing.Point(4, 22)
		Me.tbPage2.Name = "tbPage2"
		Me.tbPage2.Padding = New System.Windows.Forms.Padding(3)
		Me.tbPage2.Size = New System.Drawing.Size(400, 383)
		Me.tbPage2.TabIndex = 1
		Me.tbPage2.Text = "Button Properties"
		Me.tbPage2.UseVisualStyleBackColor = True
		' 
		' propertyGridButton
		' 
		Me.propertyGridButton.Dock = System.Windows.Forms.DockStyle.Fill
		Me.propertyGridButton.Location = New System.Drawing.Point(3, 3)
		Me.propertyGridButton.Name = "propertyGridButton"
		Me.propertyGridButton.SelectedObject = Me.btnSave
		Me.propertyGridButton.Size = New System.Drawing.Size(394, 377)
		Me.propertyGridButton.TabIndex = 0
		' 
		' txtFormHeader
		' 
		Me.txtFormHeader.Location = New System.Drawing.Point(83, 3)
		Me.txtFormHeader.Name = "txtFormHeader"
		Me.txtFormHeader.Size = New System.Drawing.Size(100, 20)
		Me.txtFormHeader.TabIndex = 2
		AddHandler Me.txtFormHeader.KeyPress, New System.Windows.Forms.KeyPressEventHandler(AddressOf Me.txtFormHeader_KeyPress)
		' 
		' label1
		' 
		Me.label1.AutoSize = True
		Me.label1.Location = New System.Drawing.Point(13, 6)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(68, 13)
		Me.label1.TabIndex = 3
		Me.label1.Text = "Form Header"
		' 
		' label2
		' 
		Me.label2.AutoSize = True
		Me.label2.Location = New System.Drawing.Point(194, 6)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(59, 13)
		Me.label2.TabIndex = 5
		Me.label2.Text = "Buton Text"
		' 
		' txtButtonText
		' 
		Me.txtButtonText.Location = New System.Drawing.Point(264, 3)
		Me.txtButtonText.Name = "txtButtonText"
		Me.txtButtonText.Size = New System.Drawing.Size(100, 20)
		Me.txtButtonText.TabIndex = 4
		AddHandler Me.txtButtonText.KeyPress, New System.Windows.Forms.KeyPressEventHandler(AddressOf Me.txtButtonText_KeyPress)
		' 
		' UserPreferenceSample
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = Global.UserPreferencesExample.Properties.Settings.[Default].FormBackColor
		Me.ClientSize = New System.Drawing.Size(432, 479)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.txtButtonText)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.txtFormHeader)
		Me.Controls.Add(Me.tbcMyTab)
		Me.Controls.Add(Me.btnSave)
		Me.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.UserPreferencesExample.Properties.Settings.[Default], "FirstFormHeader", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.DataBindings.Add(New System.Windows.Forms.Binding("WindowState", Global.UserPreferencesExample.Properties.Settings.[Default], "FormWindowState", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.UserPreferencesExample.Properties.Settings.[Default], "FormForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.DataBindings.Add(New System.Windows.Forms.Binding("Opacity", Global.UserPreferencesExample.Properties.Settings.[Default], "FormOpacity", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.UserPreferencesExample.Properties.Settings.[Default], "FormBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.ForeColor = Global.UserPreferencesExample.Properties.Settings.[Default].FormForeColor
		Me.Name = "UserPreferenceSample"
		Me.Opacity = Global.UserPreferencesExample.Properties.Settings.[Default].FormOpacity
		Me.Text = Global.UserPreferencesExample.Properties.Settings.[Default].FirstFormHeader
		Me.WindowState = Global.UserPreferencesExample.Properties.Settings.[Default].FormWindowState
		AddHandler Me.Load, New System.EventHandler(AddressOf Me.MyFirstForm_Load)
		Me.tbcMyTab.ResumeLayout(False)
		Me.tbPage1.ResumeLayout(False)
		Me.tbPage2.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	#End Region

	Private btnSave As System.Windows.Forms.Button
	Private tbcMyTab As System.Windows.Forms.TabControl
	Private tbPage1 As System.Windows.Forms.TabPage
	Private tbPage2 As System.Windows.Forms.TabPage
	Private propertyGridButton As System.Windows.Forms.PropertyGrid
	Private propertyGrid1 As System.Windows.Forms.PropertyGrid
	Private txtFormHeader As System.Windows.Forms.TextBox
	Private label2 As System.Windows.Forms.Label
	Private txtButtonText As System.Windows.Forms.TextBox
	Private label1 As System.Windows.Forms.Label
End Class
