Partial Class UserManagerControl
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

	#Region "Component Designer generated code"

	''' <summary> 
	''' Required method for Designer support - do not modify 
	''' the contents of this method with the code editor.
	''' </summary>
	Private Sub InitializeComponent()
        Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.lbUsers = New System.Windows.Forms.ListBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.tbUserHome = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbRListhidden = New System.Windows.Forms.CheckBox()
        Me.cbRRename = New System.Windows.Forms.CheckBox()
        Me.cbRDelete = New System.Windows.Forms.CheckBox()
        Me.cbRUpload = New System.Windows.Forms.CheckBox()
        Me.tbUserPass = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.tbUserName = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.FolderBrowser = New System.Windows.Forms.FolderBrowserDialog()
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainer1.Panel1.SuspendLayout()
        Me.splitContainer1.Panel2.SuspendLayout()
        Me.splitContainer1.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'splitContainer1
        '
        Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.splitContainer1.Name = "splitContainer1"
        '
        'splitContainer1.Panel1
        '
        Me.splitContainer1.Panel1.Controls.Add(Me.lbUsers)
        Me.splitContainer1.Panel1.Controls.Add(Me.label1)
        '
        'splitContainer1.Panel2
        '
        Me.splitContainer1.Panel2.Controls.Add(Me.btnBrowse)
        Me.splitContainer1.Panel2.Controls.Add(Me.tbUserHome)
        Me.splitContainer1.Panel2.Controls.Add(Me.label4)
        Me.splitContainer1.Panel2.Controls.Add(Me.groupBox1)
        Me.splitContainer1.Panel2.Controls.Add(Me.tbUserPass)
        Me.splitContainer1.Panel2.Controls.Add(Me.label3)
        Me.splitContainer1.Panel2.Controls.Add(Me.tbUserName)
        Me.splitContainer1.Panel2.Controls.Add(Me.label2)
        Me.splitContainer1.Size = New System.Drawing.Size(462, 221)
        Me.splitContainer1.SplitterDistance = 154
        Me.splitContainer1.TabIndex = 0
        '
        'lbUsers
        '
        Me.lbUsers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbUsers.FormattingEnabled = True
        Me.lbUsers.Location = New System.Drawing.Point(0, 13)
        Me.lbUsers.Name = "lbUsers"
        Me.lbUsers.Size = New System.Drawing.Size(154, 208)
        Me.lbUsers.TabIndex = 1
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.label1.Location = New System.Drawing.Point(0, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(37, 13)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Users:"
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(214, 130)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse.TabIndex = 7
        Me.btnBrowse.Text = "Browse ..."
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'tbUserHome
        '
        Me.tbUserHome.Location = New System.Drawing.Point(29, 132)
        Me.tbUserHome.Name = "tbUserHome"
        Me.tbUserHome.Size = New System.Drawing.Size(179, 20)
        Me.tbUserHome.TabIndex = 6
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(12, 116)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(61, 13)
        Me.label4.TabIndex = 5
        Me.label4.Text = "User home:"
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.cbRListhidden)
        Me.groupBox1.Controls.Add(Me.cbRRename)
        Me.groupBox1.Controls.Add(Me.cbRDelete)
        Me.groupBox1.Controls.Add(Me.cbRUpload)
        Me.groupBox1.Location = New System.Drawing.Point(15, 158)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(274, 67)
        Me.groupBox1.TabIndex = 4
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Rights"
        '
        'cbRListhidden
        '
        Me.cbRListhidden.AutoSize = True
        Me.cbRListhidden.Location = New System.Drawing.Point(89, 42)
        Me.cbRListhidden.Name = "cbRListhidden"
        Me.cbRListhidden.Size = New System.Drawing.Size(77, 17)
        Me.cbRListhidden.TabIndex = 3
        Me.cbRListhidden.Text = "List hidden"
        Me.cbRListhidden.UseVisualStyleBackColor = True
        '
        'cbRRename
        '
        Me.cbRRename.AutoSize = True
        Me.cbRRename.Location = New System.Drawing.Point(14, 42)
        Me.cbRRename.Name = "cbRRename"
        Me.cbRRename.Size = New System.Drawing.Size(66, 17)
        Me.cbRRename.TabIndex = 2
        Me.cbRRename.Text = "Rename"
        Me.cbRRename.UseVisualStyleBackColor = True
        '
        'cbRDelete
        '
        Me.cbRDelete.AutoSize = True
        Me.cbRDelete.Location = New System.Drawing.Point(89, 19)
        Me.cbRDelete.Name = "cbRDelete"
        Me.cbRDelete.Size = New System.Drawing.Size(57, 17)
        Me.cbRDelete.TabIndex = 1
        Me.cbRDelete.Text = "Delete"
        Me.cbRDelete.UseVisualStyleBackColor = True
        '
        'cbRUpload
        '
        Me.cbRUpload.AutoSize = True
        Me.cbRUpload.Location = New System.Drawing.Point(14, 19)
        Me.cbRUpload.Name = "cbRUpload"
        Me.cbRUpload.Size = New System.Drawing.Size(60, 17)
        Me.cbRUpload.TabIndex = 0
        Me.cbRUpload.Text = "Upload"
        Me.cbRUpload.UseVisualStyleBackColor = True
        '
        'tbUserPass
        '
        Me.tbUserPass.Location = New System.Drawing.Point(29, 77)
        Me.tbUserPass.Name = "tbUserPass"
        Me.tbUserPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbUserPass.Size = New System.Drawing.Size(260, 20)
        Me.tbUserPass.TabIndex = 3
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(12, 61)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(81, 13)
        Me.label3.TabIndex = 2
        Me.label3.Text = "User Password:"
        '
        'tbUserName
        '
        Me.tbUserName.Location = New System.Drawing.Point(29, 29)
        Me.tbUserName.Name = "tbUserName"
        Me.tbUserName.Size = New System.Drawing.Size(260, 20)
        Me.tbUserName.TabIndex = 1
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(12, 13)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(60, 13)
        Me.label2.TabIndex = 0
        Me.label2.Text = "User Name"
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.btnSave)
        Me.panel1.Controls.Add(Me.btnDelete)
        Me.panel1.Controls.Add(Me.btnAddNew)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel1.Location = New System.Drawing.Point(0, 221)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(462, 38)
        Me.panel1.TabIndex = 2
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(253, 6)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(119, 23)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save changes"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Enabled = False
        Me.btnDelete.Location = New System.Drawing.Point(128, 6)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(119, 23)
        Me.btnDelete.TabIndex = 1
        Me.btnDelete.Text = "Delete selected"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnAddNew
        '
        Me.btnAddNew.Location = New System.Drawing.Point(3, 6)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(114, 23)
        Me.btnAddNew.TabIndex = 0
        Me.btnAddNew.Text = "Add new"
        Me.btnAddNew.UseVisualStyleBackColor = True
        '
        'UserManagerControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.splitContainer1)
        Me.Controls.Add(Me.panel1)
        Me.Name = "UserManagerControl"
        Me.Size = New System.Drawing.Size(462, 259)
        Me.splitContainer1.Panel1.ResumeLayout(False)
        Me.splitContainer1.Panel1.PerformLayout()
        Me.splitContainer1.Panel2.ResumeLayout(False)
        Me.splitContainer1.Panel2.PerformLayout()
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer1.ResumeLayout(False)
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

	#End Region

	Private splitContainer1 As System.Windows.Forms.SplitContainer
	Private lbUsers As System.Windows.Forms.ListBox
	Private label1 As System.Windows.Forms.Label
	Private btnBrowse As System.Windows.Forms.Button
	Private tbUserHome As System.Windows.Forms.TextBox
	Private label4 As System.Windows.Forms.Label
	Private groupBox1 As System.Windows.Forms.GroupBox
	Private tbUserPass As System.Windows.Forms.TextBox
	Private label3 As System.Windows.Forms.Label
	Private tbUserName As System.Windows.Forms.TextBox
	Private label2 As System.Windows.Forms.Label
	Private cbRDelete As System.Windows.Forms.CheckBox
	Private cbRUpload As System.Windows.Forms.CheckBox
	Private cbRRename As System.Windows.Forms.CheckBox
	Private cbRListhidden As System.Windows.Forms.CheckBox
	Private panel1 As System.Windows.Forms.Panel
	Private btnSave As System.Windows.Forms.Button
	Private btnDelete As System.Windows.Forms.Button
	Private btnAddNew As System.Windows.Forms.Button
	Private FolderBrowser As System.Windows.Forms.FolderBrowserDialog
End Class
