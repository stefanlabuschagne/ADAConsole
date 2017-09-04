<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStats
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStats))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnResetPasswords = New System.Windows.Forms.Button()
        Me.txtResetPasswords = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.txt_Users_Disabled_This_Month = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtp_Period_Starting = New System.Windows.Forms.DateTimePicker()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtp_Period_Ending = New System.Windows.Forms.DateTimePicker()
        Me.txtTotal_users_registered_on_Vulindlela = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_CFO_Approval_Requested = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_Users_Active_This_Month = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_New_Users_Created_in_This_Month = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Ads = New Global.ADAdminDotNet.dsADS()
        Me.AD_SNAPSHOT_USER_COUNTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AD_SNAPSHOT_USER_COUNTTableAdapter = New Global.ADAdminDotNet.dsADSTableAdapters.AD_SNAPSHOT_USER_COUNTTableAdapter()
        Me.ViewJJ_Max_User_COuntBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ViewJJ_Max_User_COuntTableAdapter = New Global.ADAdminDotNet.dsADSTableAdapters.ViewJJ_Max_User_COuntTableAdapter()
        Me.AD_Disabled_UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AD_Disabled_UsersTableAdapter = New Global.ADAdminDotNet.dsADSTableAdapters.AD_Disabled_UsersTableAdapter()
        Me.CFO_Letters_YearMonthBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CFO_Letters_YearMonthTableAdapter = New Global.ADAdminDotNet.dsADSTableAdapters.CFO_Letters_YearMonthTableAdapter()
        Me.AdconsolelogTableAdapter1 = New Global.ADAdminDotNet.dsADSTableAdapters.ADCONSOLELOGTableAdapter()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.Ads, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AD_SNAPSHOT_USER_COUNTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewJJ_Max_User_COuntBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AD_Disabled_UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CFO_Letters_YearMonthBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()

        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(357, 289)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnResetPasswords)
        Me.TabPage1.Controls.Add(Me.txtResetPasswords)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Button5)
        Me.TabPage1.Controls.Add(Me.txt_Users_Disabled_This_Month)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.dtp_Period_Starting)
        Me.TabPage1.Controls.Add(Me.Button7)
        Me.TabPage1.Controls.Add(Me.Button9)
        Me.TabPage1.Controls.Add(Me.Button6)
        Me.TabPage1.Controls.Add(Me.Button4)
        Me.TabPage1.Controls.Add(Me.Button3)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.dtp_Period_Ending)
        Me.TabPage1.Controls.Add(Me.txtTotal_users_registered_on_Vulindlela)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.TextBox5)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.txt_CFO_Approval_Requested)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txt_Users_Active_This_Month)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txt_New_Users_Created_in_This_Month)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(349, 263)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Month-End reporting"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnResetPasswords
        '
        Me.btnResetPasswords.Enabled = False
        Me.btnResetPasswords.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnResetPasswords.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResetPasswords.ForeColor = System.Drawing.Color.Transparent
        Me.btnResetPasswords.Image = Global.ADAdminDotNet.My.Resources.Resources.imgExcel
        Me.btnResetPasswords.Location = New System.Drawing.Point(320, 227)
        Me.btnResetPasswords.Name = "btnResetPasswords"
        Me.btnResetPasswords.Size = New System.Drawing.Size(24, 24)
        Me.btnResetPasswords.TabIndex = 31
        Me.ToolTip1.SetToolTip(Me.btnResetPasswords, "View total users registered in Excel")
        Me.btnResetPasswords.UseVisualStyleBackColor = True
        '
        'txtResetPasswords
        '
        Me.txtResetPasswords.BackColor = System.Drawing.SystemColors.Window
        Me.txtResetPasswords.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResetPasswords.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtResetPasswords.Location = New System.Drawing.Point(248, 229)
        Me.txtResetPasswords.Name = "txtResetPasswords"
        Me.txtResetPasswords.Size = New System.Drawing.Size(67, 20)
        Me.txtResetPasswords.TabIndex = 30
        Me.txtResetPasswords.Text = "0"
        Me.txtResetPasswords.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 232)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Reset Passwords"
        '
        'Button5
        '
        Me.Button5.Enabled = False
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.ForeColor = System.Drawing.Color.Transparent
        Me.Button5.Image = Global.ADAdminDotNet.My.Resources.Resources.imgExcel
        Me.Button5.Location = New System.Drawing.Point(320, 119)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(24, 24)
        Me.Button5.TabIndex = 28
        Me.ToolTip1.SetToolTip(Me.Button5, "View users disabled this month")
        Me.Button5.UseVisualStyleBackColor = True
        '
        'txt_Users_Disabled_This_Month
        '
        Me.txt_Users_Disabled_This_Month.BackColor = System.Drawing.SystemColors.Window
        Me.txt_Users_Disabled_This_Month.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Users_Disabled_This_Month.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_Users_Disabled_This_Month.Location = New System.Drawing.Point(248, 120)
        Me.txt_Users_Disabled_This_Month.Name = "txt_Users_Disabled_This_Month"
        Me.txt_Users_Disabled_This_Month.Size = New System.Drawing.Size(67, 20)
        Me.txt_Users_Disabled_This_Month.TabIndex = 27
        Me.txt_Users_Disabled_This_Month.Text = "0"
        Me.txt_Users_Disabled_This_Month.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(231, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Users [Disabled 60]  between Start && End dates"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(13, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 13)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Period Starting"
        '
        'dtp_Period_Starting
        '
        Me.dtp_Period_Starting.Location = New System.Drawing.Point(13, 34)
        Me.dtp_Period_Starting.Name = "dtp_Period_Starting"
        Me.dtp_Period_Starting.Size = New System.Drawing.Size(124, 20)
        Me.dtp_Period_Starting.TabIndex = 24
        '
        'Button7
        '
        Me.Button7.Enabled = False
        Me.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.ForeColor = System.Drawing.Color.Transparent
        Me.Button7.Image = Global.ADAdminDotNet.My.Resources.Resources.imgExcel
        Me.Button7.Location = New System.Drawing.Point(320, 199)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(24, 24)
        Me.Button7.TabIndex = 23
        Me.ToolTip1.SetToolTip(Me.Button7, "View total users registered in Excel")
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Enabled = False
        Me.Button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.ForeColor = System.Drawing.Color.Transparent
        Me.Button9.Image = Global.ADAdminDotNet.My.Resources.Resources.imgExcel
        Me.Button9.Location = New System.Drawing.Point(320, 171)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(24, 24)
        Me.Button9.TabIndex = 21
        Me.ToolTip1.SetToolTip(Me.Button9, "View CFO approvals in Excel")
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Enabled = False
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.ForeColor = System.Drawing.Color.Transparent
        Me.Button6.Image = Global.ADAdminDotNet.My.Resources.Resources.imgExcel
        Me.Button6.Location = New System.Drawing.Point(320, 145)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(24, 24)
        Me.Button6.TabIndex = 20
        Me.ToolTip1.SetToolTip(Me.Button6, "View CFO approvals Requested this month")
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.Transparent
        Me.Button4.Image = Global.ADAdminDotNet.My.Resources.Resources.imgExcel
        Me.Button4.Location = New System.Drawing.Point(320, 92)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(24, 24)
        Me.Button4.TabIndex = 18
        Me.ToolTip1.SetToolTip(Me.Button4, "View users disabled this month")
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.Transparent
        Me.Button3.Image = Global.ADAdminDotNet.My.Resources.Resources.imgExcel
        Me.Button3.Location = New System.Drawing.Point(320, 63)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(24, 24)
        Me.Button3.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.Button3, "View which users were created this month")
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(202, 17)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Period Ending"
        '
        'dtp_Period_Ending
        '
        Me.dtp_Period_Ending.Location = New System.Drawing.Point(202, 34)
        Me.dtp_Period_Ending.Name = "dtp_Period_Ending"
        Me.dtp_Period_Ending.Size = New System.Drawing.Size(124, 20)
        Me.dtp_Period_Ending.TabIndex = 15
        '
        'txtTotal_users_registered_on_Vulindlela
        '
        Me.txtTotal_users_registered_on_Vulindlela.BackColor = System.Drawing.SystemColors.Window
        Me.txtTotal_users_registered_on_Vulindlela.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal_users_registered_on_Vulindlela.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTotal_users_registered_on_Vulindlela.Location = New System.Drawing.Point(248, 201)
        Me.txtTotal_users_registered_on_Vulindlela.Name = "txtTotal_users_registered_on_Vulindlela"
        Me.txtTotal_users_registered_on_Vulindlela.Size = New System.Drawing.Size(67, 20)
        Me.txtTotal_users_registered_on_Vulindlela.TabIndex = 13
        Me.txtTotal_users_registered_on_Vulindlela.Text = "0"
        Me.txtTotal_users_registered_on_Vulindlela.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 204)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(171, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Total users registered on Vulindlela"
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox5.Location = New System.Drawing.Point(248, 174)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(67, 20)
        Me.TextBox5.TabIndex = 9
        Me.TextBox5.Text = "0"
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 177)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "CFO approvals this month"
        '
        'txt_CFO_Approval_Requested
        '
        Me.txt_CFO_Approval_Requested.BackColor = System.Drawing.SystemColors.Window
        Me.txt_CFO_Approval_Requested.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CFO_Approval_Requested.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_CFO_Approval_Requested.Location = New System.Drawing.Point(248, 147)
        Me.txt_CFO_Approval_Requested.Name = "txt_CFO_Approval_Requested"
        Me.txt_CFO_Approval_Requested.Size = New System.Drawing.Size(67, 20)
        Me.txt_CFO_Approval_Requested.TabIndex = 7
        Me.txt_CFO_Approval_Requested.Text = "0"
        Me.txt_CFO_Approval_Requested.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(178, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "CFO approvals requested this month"
        '
        'txt_Users_Active_This_Month
        '
        Me.txt_Users_Active_This_Month.BackColor = System.Drawing.SystemColors.Window
        Me.txt_Users_Active_This_Month.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Users_Active_This_Month.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_Users_Active_This_Month.Location = New System.Drawing.Point(248, 93)
        Me.txt_Users_Active_This_Month.Name = "txt_Users_Active_This_Month"
        Me.txt_Users_Active_This_Month.Size = New System.Drawing.Size(67, 20)
        Me.txt_Users_Active_This_Month.TabIndex = 4
        Me.txt_Users_Active_This_Month.Text = "0"
        Me.txt_Users_Active_This_Month.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(198, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "[Active] Users as at [Period Ending] date"
        '
        'txt_New_Users_Created_in_This_Month
        '
        Me.txt_New_Users_Created_in_This_Month.BackColor = System.Drawing.SystemColors.Window
        Me.txt_New_Users_Created_in_This_Month.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_New_Users_Created_in_This_Month.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_New_Users_Created_in_This_Month.Location = New System.Drawing.Point(248, 66)
        Me.txt_New_Users_Created_in_This_Month.Name = "txt_New_Users_Created_in_This_Month"
        Me.txt_New_Users_Created_in_This_Month.Size = New System.Drawing.Size(67, 20)
        Me.txt_New_Users_Created_in_This_Month.TabIndex = 1
        Me.txt_New_Users_Created_in_This_Month.Text = "0"
        Me.txt_New_Users_Created_in_This_Month.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(231, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "[New] users created between Start && End dates"
        '
        'btnCalculate
        '
        Me.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnCalculate.Location = New System.Drawing.Point(268, 307)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(101, 25)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "Calculate values"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.Tag = " "
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "View in Excel"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "excel.bmp")
        '
        'Ads
        '
        Me.Ads.DataSetName = "ads"
        Me.Ads.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AD_SNAPSHOT_USER_COUNTBindingSource
        '
        Me.AD_SNAPSHOT_USER_COUNTBindingSource.DataMember = "AD_SNAPSHOT_USER_COUNT"
        Me.AD_SNAPSHOT_USER_COUNTBindingSource.DataSource = Me.Ads
        '
        'AD_SNAPSHOT_USER_COUNTTableAdapter
        '
        Me.AD_SNAPSHOT_USER_COUNTTableAdapter.ClearBeforeFill = True
        '
        'ViewJJ_Max_User_COuntBindingSource
        '
        Me.ViewJJ_Max_User_COuntBindingSource.DataMember = "ViewJJ_Max_User_COunt"
        Me.ViewJJ_Max_User_COuntBindingSource.DataSource = Me.Ads
        '
        'ViewJJ_Max_User_COuntTableAdapter
        '
        Me.ViewJJ_Max_User_COuntTableAdapter.ClearBeforeFill = True
        '
        'AD_Disabled_UsersBindingSource
        '
        Me.AD_Disabled_UsersBindingSource.DataMember = "AD_Disabled_Users"
        Me.AD_Disabled_UsersBindingSource.DataSource = Me.Ads
        '
        'AD_Disabled_UsersTableAdapter
        '
        Me.AD_Disabled_UsersTableAdapter.ClearBeforeFill = True
        '
        'CFO_Letters_YearMonthBindingSource
        '
        Me.CFO_Letters_YearMonthBindingSource.DataMember = "CFO_Letters_YearMonth"
        Me.CFO_Letters_YearMonthBindingSource.DataSource = Me.Ads
        '
        'CFO_Letters_YearMonthTableAdapter
        '
        Me.CFO_Letters_YearMonthTableAdapter.ClearBeforeFill = True
        '
        'AdconsolelogTableAdapter1
        '
        Me.AdconsolelogTableAdapter1.ClearBeforeFill = True
        '
        'frmStats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 344)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmStats"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AD Admin Console Stats"
        Me.TopMost = True
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.Ads, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AD_SNAPSHOT_USER_COUNTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewJJ_Max_User_COuntBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AD_Disabled_UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CFO_Letters_YearMonthBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents txtTotal_users_registered_on_Vulindlela As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_CFO_Approval_Requested As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_Users_Active_This_Month As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_New_Users_Created_in_This_Month As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtp_Period_Ending As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents Ads As Global.ADAdminDotNet.dsADS
    Friend WithEvents AD_SNAPSHOT_USER_COUNTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AD_SNAPSHOT_USER_COUNTTableAdapter As Global.ADAdminDotNet.dsADSTableAdapters.AD_SNAPSHOT_USER_COUNTTableAdapter
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ViewJJ_Max_User_COuntBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ViewJJ_Max_User_COuntTableAdapter As Global.ADAdminDotNet.dsADSTableAdapters.ViewJJ_Max_User_COuntTableAdapter
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtp_Period_Starting As System.Windows.Forms.DateTimePicker
    Friend WithEvents AD_Disabled_UsersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AD_Disabled_UsersTableAdapter As Global.ADAdminDotNet.dsADSTableAdapters.AD_Disabled_UsersTableAdapter
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents txt_Users_Disabled_This_Month As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CFO_Letters_YearMonthBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CFO_Letters_YearMonthTableAdapter As Global.ADAdminDotNet.dsADSTableAdapters.CFO_Letters_YearMonthTableAdapter
    Friend WithEvents btnResetPasswords As System.Windows.Forms.Button
    Friend WithEvents txtResetPasswords As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents AdconsolelogTableAdapter1 As Global.ADAdminDotNet.dsADSTableAdapters.ADCONSOLELOGTableAdapter
End Class
