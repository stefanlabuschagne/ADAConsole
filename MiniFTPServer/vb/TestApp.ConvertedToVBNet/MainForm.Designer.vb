Partial Class MainForm
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
		Me.components = New System.ComponentModel.Container()
		Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
		Me.tabControl1 = New System.Windows.Forms.TabControl()
		Me.tabPage1 = New System.Windows.Forms.TabPage()
		Me.PanelSettings = New System.Windows.Forms.Panel()
		Me.NumDlLimit = New System.Windows.Forms.NumericUpDown()
		Me.label3 = New System.Windows.Forms.Label()
		Me.label1 = New System.Windows.Forms.Label()
		Me.label2 = New System.Windows.Forms.Label()
		Me.NumPort = New System.Windows.Forms.NumericUpDown()
		Me.NumUlLimit = New System.Windows.Forms.NumericUpDown()
		Me.cbDlLimit = New System.Windows.Forms.CheckBox()
		Me.cbUlLimit = New System.Windows.Forms.CheckBox()
		Me.btnStop = New System.Windows.Forms.Button()
		Me.btnStart = New System.Windows.Forms.Button()
		Me.tabPage2 = New System.Windows.Forms.TabPage()
		Me.tabPage3 = New System.Windows.Forms.TabPage()
		Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
		Me.tbAllow = New System.Windows.Forms.TextBox()
		Me.label4 = New System.Windows.Forms.Label()
		Me.tbBan = New System.Windows.Forms.TextBox()
		Me.label5 = New System.Windows.Forms.Label()
		Me.notifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
		Me.tabPage4 = New System.Windows.Forms.TabPage()
		Me.LogList = New System.Windows.Forms.ListView()
		Me.[Date] = DirectCast(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.[Event] = DirectCast(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.User = DirectCast(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.Arguments = DirectCast(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.Succes = DirectCast(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.BtnLogClear = New System.Windows.Forms.Button()
		Me.userManager1 = New TestApp.UserManagerControl()
		Me.tabControl1.SuspendLayout()
		Me.tabPage1.SuspendLayout()
		Me.PanelSettings.SuspendLayout()
		DirectCast(Me.NumDlLimit, System.ComponentModel.ISupportInitialize).BeginInit()
		DirectCast(Me.NumPort, System.ComponentModel.ISupportInitialize).BeginInit()
		DirectCast(Me.NumUlLimit, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.tabPage2.SuspendLayout()
		Me.tabPage3.SuspendLayout()
		Me.splitContainer1.Panel1.SuspendLayout()
		Me.splitContainer1.Panel2.SuspendLayout()
		Me.splitContainer1.SuspendLayout()
		Me.tabPage4.SuspendLayout()
		Me.SuspendLayout()
		' 
		' tabControl1
		' 
		Me.tabControl1.Controls.Add(Me.tabPage1)
		Me.tabControl1.Controls.Add(Me.tabPage2)
		Me.tabControl1.Controls.Add(Me.tabPage3)
		Me.tabControl1.Controls.Add(Me.tabPage4)
		Me.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.tabControl1.Location = New System.Drawing.Point(0, 0)
		Me.tabControl1.Name = "tabControl1"
		Me.tabControl1.SelectedIndex = 0
		Me.tabControl1.Size = New System.Drawing.Size(463, 297)
		Me.tabControl1.TabIndex = 1
		' 
		' tabPage1
		' 
		Me.tabPage1.BackColor = System.Drawing.SystemColors.Control
		Me.tabPage1.Controls.Add(Me.PanelSettings)
		Me.tabPage1.Controls.Add(Me.btnStop)
		Me.tabPage1.Controls.Add(Me.btnStart)
		Me.tabPage1.Location = New System.Drawing.Point(4, 22)
		Me.tabPage1.Name = "tabPage1"
		Me.tabPage1.Padding = New System.Windows.Forms.Padding(3)
		Me.tabPage1.Size = New System.Drawing.Size(455, 271)
		Me.tabPage1.TabIndex = 0
		Me.tabPage1.Text = "General settings"
		' 
		' PanelSettings
		' 
		Me.PanelSettings.Controls.Add(Me.NumDlLimit)
		Me.PanelSettings.Controls.Add(Me.label3)
		Me.PanelSettings.Controls.Add(Me.label1)
		Me.PanelSettings.Controls.Add(Me.label2)
		Me.PanelSettings.Controls.Add(Me.NumPort)
		Me.PanelSettings.Controls.Add(Me.NumUlLimit)
		Me.PanelSettings.Controls.Add(Me.cbDlLimit)
		Me.PanelSettings.Controls.Add(Me.cbUlLimit)
		Me.PanelSettings.Dock = System.Windows.Forms.DockStyle.Top
		Me.PanelSettings.Location = New System.Drawing.Point(3, 3)
		Me.PanelSettings.Name = "PanelSettings"
		Me.PanelSettings.Size = New System.Drawing.Size(449, 204)
		Me.PanelSettings.TabIndex = 14
		' 
		' NumDlLimit
		' 
		Me.NumDlLimit.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.TestApp.Properties.Settings.[Default], "DownloadSpeed", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.NumDlLimit.Enabled = False
		Me.NumDlLimit.Location = New System.Drawing.Point(86, 75)
		Me.NumDlLimit.Maximum = New Decimal(New Integer() {12000, 0, 0, 0})
		Me.NumDlLimit.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.NumDlLimit.Name = "NumDlLimit"
		Me.NumDlLimit.Size = New System.Drawing.Size(120, 20)
		Me.NumDlLimit.TabIndex = 6
		Me.NumDlLimit.Value = Global.TestApp.Properties.Settings.[Default].DownloadSpeed
		' 
		' label3
		' 
		Me.label3.AutoSize = True
		Me.label3.Location = New System.Drawing.Point(212, 126)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(61, 13)
		Me.label3.TabIndex = 13
		Me.label3.Text = "Kbytes/sec"
		' 
		' label1
		' 
		Me.label1.AutoSize = True
		Me.label1.Location = New System.Drawing.Point(17, 10)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(63, 13)
		Me.label1.TabIndex = 0
		Me.label1.Text = "Server Port:"
		' 
		' label2
		' 
		Me.label2.AutoSize = True
		Me.label2.Location = New System.Drawing.Point(212, 77)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(61, 13)
		Me.label2.TabIndex = 12
		Me.label2.Text = "Kbytes/sec"
		' 
		' NumPort
		' 
		Me.NumPort.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.TestApp.Properties.Settings.[Default], "ServerPort", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.NumPort.Location = New System.Drawing.Point(86, 26)
		Me.NumPort.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
		Me.NumPort.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.NumPort.Name = "NumPort"
		Me.NumPort.Size = New System.Drawing.Size(120, 20)
		Me.NumPort.TabIndex = 4
		Me.NumPort.Value = Global.TestApp.Properties.Settings.[Default].ServerPort
		' 
		' NumUlLimit
		' 
		Me.NumUlLimit.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.TestApp.Properties.Settings.[Default], "UploadSpeed", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.NumUlLimit.Enabled = False
		Me.NumUlLimit.Location = New System.Drawing.Point(86, 124)
		Me.NumUlLimit.Maximum = New Decimal(New Integer() {12000, 0, 0, 0})
		Me.NumUlLimit.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.NumUlLimit.Name = "NumUlLimit"
		Me.NumUlLimit.Size = New System.Drawing.Size(120, 20)
		Me.NumUlLimit.TabIndex = 11
		Me.NumUlLimit.Value = Global.TestApp.Properties.Settings.[Default].UploadSpeed
		' 
		' cbDlLimit
		' 
		Me.cbDlLimit.AutoSize = True
		Me.cbDlLimit.Checked = Global.TestApp.Properties.Settings.[Default].DlLimit
		Me.cbDlLimit.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.TestApp.Properties.Settings.[Default], "DlLimit", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.cbDlLimit.Location = New System.Drawing.Point(20, 52)
		Me.cbDlLimit.Name = "cbDlLimit"
		Me.cbDlLimit.Size = New System.Drawing.Size(132, 17)
		Me.cbDlLimit.TabIndex = 9
		Me.cbDlLimit.Text = "Download Speed Limit"
		Me.cbDlLimit.UseVisualStyleBackColor = True
		AddHandler Me.cbDlLimit.CheckedChanged, New System.EventHandler(AddressOf Me.cbDlLimit_CheckedChanged)
		' 
		' cbUlLimit
		' 
		Me.cbUlLimit.AutoSize = True
		Me.cbUlLimit.Checked = Global.TestApp.Properties.Settings.[Default].Ullimit
		Me.cbUlLimit.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.TestApp.Properties.Settings.[Default], "Ullimit", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.cbUlLimit.Location = New System.Drawing.Point(20, 101)
		Me.cbUlLimit.Name = "cbUlLimit"
		Me.cbUlLimit.Size = New System.Drawing.Size(118, 17)
		Me.cbUlLimit.TabIndex = 10
		Me.cbUlLimit.Text = "Upload Speed Limit"
		Me.cbUlLimit.UseVisualStyleBackColor = True
		AddHandler Me.cbUlLimit.CheckedChanged, New System.EventHandler(AddressOf Me.cbUlLimit_CheckedChanged)
		' 
		' btnStop
		' 
		Me.btnStop.Enabled = False
		Me.btnStop.Location = New System.Drawing.Point(367, 213)
		Me.btnStop.Name = "btnStop"
		Me.btnStop.Size = New System.Drawing.Size(80, 50)
		Me.btnStop.TabIndex = 3
		Me.btnStop.Text = "Stop Server"
		Me.btnStop.UseVisualStyleBackColor = True
		AddHandler Me.btnStop.Click, New System.EventHandler(AddressOf Me.btnStop_Click)
		' 
		' btnStart
		' 
		Me.btnStart.Location = New System.Drawing.Point(281, 213)
		Me.btnStart.Name = "btnStart"
		Me.btnStart.Size = New System.Drawing.Size(80, 50)
		Me.btnStart.TabIndex = 2
		Me.btnStart.Text = "Start Server"
		Me.btnStart.UseVisualStyleBackColor = True
		AddHandler Me.btnStart.Click, New System.EventHandler(AddressOf Me.btnStart_Click)
		' 
		' tabPage2
		' 
		Me.tabPage2.Controls.Add(Me.userManager1)
		Me.tabPage2.Location = New System.Drawing.Point(4, 22)
		Me.tabPage2.Name = "tabPage2"
		Me.tabPage2.Padding = New System.Windows.Forms.Padding(3)
		Me.tabPage2.Size = New System.Drawing.Size(455, 271)
		Me.tabPage2.TabIndex = 1
		Me.tabPage2.Text = "Users"
		Me.tabPage2.UseVisualStyleBackColor = True
		' 
		' tabPage3
		' 
		Me.tabPage3.BackColor = System.Drawing.SystemColors.Control
		Me.tabPage3.Controls.Add(Me.splitContainer1)
		Me.tabPage3.Location = New System.Drawing.Point(4, 22)
		Me.tabPage3.Name = "tabPage3"
		Me.tabPage3.Padding = New System.Windows.Forms.Padding(3)
		Me.tabPage3.Size = New System.Drawing.Size(455, 271)
		Me.tabPage3.TabIndex = 2
		Me.tabPage3.Text = "Ip Ban"
		' 
		' splitContainer1
		' 
		Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
		Me.splitContainer1.Location = New System.Drawing.Point(3, 3)
		Me.splitContainer1.Name = "splitContainer1"
		' 
		' splitContainer1.Panel1
		' 
		Me.splitContainer1.Panel1.Controls.Add(Me.tbAllow)
		Me.splitContainer1.Panel1.Controls.Add(Me.label4)
		Me.splitContainer1.Panel1MinSize = 224
		' 
		' splitContainer1.Panel2
		' 
		Me.splitContainer1.Panel2.Controls.Add(Me.tbBan)
		Me.splitContainer1.Panel2.Controls.Add(Me.label5)
		Me.splitContainer1.Panel2MinSize = 10
		Me.splitContainer1.Size = New System.Drawing.Size(449, 265)
		Me.splitContainer1.SplitterDistance = 224
		Me.splitContainer1.SplitterWidth = 1
		Me.splitContainer1.TabIndex = 0
		' 
		' tbAllow
		' 
		Me.tbAllow.BackColor = System.Drawing.Color.LightGreen
		Me.tbAllow.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.TestApp.Properties.Settings.[Default], "AcceptList", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.tbAllow.Dock = System.Windows.Forms.DockStyle.Fill
		Me.tbAllow.Location = New System.Drawing.Point(0, 13)
		Me.tbAllow.Multiline = True
		Me.tbAllow.Name = "tbAllow"
		Me.tbAllow.Size = New System.Drawing.Size(224, 252)
		Me.tbAllow.TabIndex = 1
		Me.tbAllow.Text = Global.TestApp.Properties.Settings.[Default].AcceptList
		' 
		' label4
		' 
		Me.label4.AutoSize = True
		Me.label4.Dock = System.Windows.Forms.DockStyle.Top
		Me.label4.Location = New System.Drawing.Point(0, 0)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(152, 13)
		Me.label4.TabIndex = 0
		Me.label4.Text = "Alowed IP Adresses: (one/line)"
		' 
		' tbBan
		' 
		Me.tbBan.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(255)), CInt(CByte(128)), CInt(CByte(128)))
		Me.tbBan.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.TestApp.Properties.Settings.[Default], "BanList", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.tbBan.Dock = System.Windows.Forms.DockStyle.Fill
		Me.tbBan.Location = New System.Drawing.Point(0, 13)
		Me.tbBan.Multiline = True
		Me.tbBan.Name = "tbBan"
		Me.tbBan.Size = New System.Drawing.Size(224, 252)
		Me.tbBan.TabIndex = 2
		Me.tbBan.Text = Global.TestApp.Properties.Settings.[Default].BanList
		' 
		' label5
		' 
		Me.label5.AutoSize = True
		Me.label5.Dock = System.Windows.Forms.DockStyle.Top
		Me.label5.Location = New System.Drawing.Point(0, 0)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(154, 13)
		Me.label5.TabIndex = 1
		Me.label5.Text = "Banned IP Adresses: (one/line)"
		' 
		' notifyIcon
		' 
		Me.notifyIcon.Icon = DirectCast(resources.GetObject("notifyIcon.Icon"), System.Drawing.Icon)
		Me.notifyIcon.Text = "Mini FTP Server"
		Me.notifyIcon.Visible = True
		AddHandler Me.notifyIcon.Click, New System.EventHandler(AddressOf Me.notifyIcon_Click)
		' 
		' tabPage4
		' 
		Me.tabPage4.BackColor = System.Drawing.SystemColors.Control
		Me.tabPage4.Controls.Add(Me.BtnLogClear)
		Me.tabPage4.Controls.Add(Me.LogList)
		Me.tabPage4.Location = New System.Drawing.Point(4, 22)
		Me.tabPage4.Name = "tabPage4"
		Me.tabPage4.Padding = New System.Windows.Forms.Padding(3)
		Me.tabPage4.Size = New System.Drawing.Size(455, 271)
		Me.tabPage4.TabIndex = 3
		Me.tabPage4.Text = "Log"
		' 
		' LogList
		' 
		Me.LogList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.[Date], Me.[Event], Me.Succes, Me.User, Me.Arguments})
		Me.LogList.Dock = System.Windows.Forms.DockStyle.Top
		Me.LogList.Location = New System.Drawing.Point(3, 3)
		Me.LogList.Name = "LogList"
		Me.LogList.Size = New System.Drawing.Size(449, 236)
		Me.LogList.TabIndex = 0
		Me.LogList.UseCompatibleStateImageBehavior = False
		Me.LogList.View = System.Windows.Forms.View.Details
		' 
		' Date
		' 
		Me.[Date].Text = "Date"
		Me.[Date].Width = 100
		' 
		' Event
		' 
		Me.[Event].Text = "Event"
		Me.[Event].Width = 200
		' 
		' User
		' 
		Me.User.Text = "User"
		Me.User.Width = 100
		' 
		' Arguments
		' 
		Me.Arguments.Text = "Arguments"
		Me.Arguments.Width = 300
		' 
		' Succes
		' 
		Me.Succes.Text = "Succes ?"
		' 
		' BtnLogClear
		' 
		Me.BtnLogClear.Location = New System.Drawing.Point(8, 242)
		Me.BtnLogClear.Name = "BtnLogClear"
		Me.BtnLogClear.Size = New System.Drawing.Size(75, 23)
		Me.BtnLogClear.TabIndex = 1
		Me.BtnLogClear.Text = "Clear Log"
		Me.BtnLogClear.UseVisualStyleBackColor = True
		AddHandler Me.BtnLogClear.Click, New System.EventHandler(AddressOf Me.BtnLogClear_Click)
		' 
		' userManager1
		' 
		Me.userManager1.BackColor = System.Drawing.SystemColors.Control
		Me.userManager1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.userManager1.Location = New System.Drawing.Point(3, 3)
		Me.userManager1.Name = "userManager1"
		Me.userManager1.Size = New System.Drawing.Size(449, 265)
		Me.userManager1.TabIndex = 0
		' 
		' MainForm
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(463, 297)
		Me.Controls.Add(Me.tabControl1)
		Me.DataBindings.Add(New System.Windows.Forms.Binding("Location", Global.TestApp.Properties.Settings.[Default], "WindowPosition", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Icon = DirectCast(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Location = Global.TestApp.Properties.Settings.[Default].WindowPosition
		Me.MaximizeBox = False
		Me.Name = "MainForm"
		Me.Text = "Mini FTP Server"
		AddHandler Me.FormClosing, New System.Windows.Forms.FormClosingEventHandler(AddressOf Me.MainForm_FormClosing)
		AddHandler Me.Resize, New System.EventHandler(AddressOf Me.MainForm_Resize)
		Me.tabControl1.ResumeLayout(False)
		Me.tabPage1.ResumeLayout(False)
		Me.PanelSettings.ResumeLayout(False)
		Me.PanelSettings.PerformLayout()
		DirectCast(Me.NumDlLimit, System.ComponentModel.ISupportInitialize).EndInit()
		DirectCast(Me.NumPort, System.ComponentModel.ISupportInitialize).EndInit()
		DirectCast(Me.NumUlLimit, System.ComponentModel.ISupportInitialize).EndInit()
		Me.tabPage2.ResumeLayout(False)
		Me.tabPage3.ResumeLayout(False)
		Me.splitContainer1.Panel1.ResumeLayout(False)
		Me.splitContainer1.Panel1.PerformLayout()
		Me.splitContainer1.Panel2.ResumeLayout(False)
		Me.splitContainer1.Panel2.PerformLayout()
		Me.splitContainer1.ResumeLayout(False)
		Me.tabPage4.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub

	#End Region

	Private tabControl1 As System.Windows.Forms.TabControl
	Private tabPage1 As System.Windows.Forms.TabPage
	Private tabPage2 As System.Windows.Forms.TabPage
	Private tabPage3 As System.Windows.Forms.TabPage
	Private userManager1 As UserManagerControl
	Private NumPort As System.Windows.Forms.NumericUpDown
	Private btnStop As System.Windows.Forms.Button
	Private btnStart As System.Windows.Forms.Button
	Private label1 As System.Windows.Forms.Label
	Private PanelSettings As System.Windows.Forms.Panel
	Private NumDlLimit As System.Windows.Forms.NumericUpDown
	Private label3 As System.Windows.Forms.Label
	Private label2 As System.Windows.Forms.Label
	Private NumUlLimit As System.Windows.Forms.NumericUpDown
	Private cbDlLimit As System.Windows.Forms.CheckBox
	Private cbUlLimit As System.Windows.Forms.CheckBox
	Private splitContainer1 As System.Windows.Forms.SplitContainer
	Private tbAllow As System.Windows.Forms.TextBox
	Private label4 As System.Windows.Forms.Label
	Private tbBan As System.Windows.Forms.TextBox
	Private label5 As System.Windows.Forms.Label
	Private notifyIcon As System.Windows.Forms.NotifyIcon
	Private tabPage4 As System.Windows.Forms.TabPage
	Private LogList As System.Windows.Forms.ListView
	Private [Date] As System.Windows.Forms.ColumnHeader
	Private [Event] As System.Windows.Forms.ColumnHeader
	Private Succes As System.Windows.Forms.ColumnHeader
	Private User As System.Windows.Forms.ColumnHeader
	Private Arguments As System.Windows.Forms.ColumnHeader
	Private BtnLogClear As System.Windows.Forms.Button
End Class

