<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWebRequest
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
        Dim NOTESLabel As System.Windows.Forms.Label
        Dim DOWNLOADEDBYLabel As System.Windows.Forms.Label
        Dim EXPORTEDLabel As System.Windows.Forms.Label
        Dim CREATEDLabel As System.Windows.Forms.Label
        Dim RESET_PASSWORDLabel As System.Windows.Forms.Label
        Dim EMAILLabel As System.Windows.Forms.Label
        Dim CEL_TELLabel As System.Windows.Forms.Label
        Dim FAX_TELLabel As System.Windows.Forms.Label
        Dim BUS_TELLabel As System.Windows.Forms.Label
        Dim RANKLabel As System.Windows.Forms.Label
        Dim RESPONSIBILITYLabel As System.Windows.Forms.Label
        Dim SURNAMELabel As System.Windows.Forms.Label
        Dim FIRSTNAMELabel As System.Windows.Forms.Label
        Dim TITLELabel As System.Windows.Forms.Label
        Dim USERIDLabel As System.Windows.Forms.Label
        Dim IDLabel As System.Windows.Forms.Label
        Dim REQ_HRLabel As System.Windows.Forms.Label
        Dim REQ_DPSALabel As System.Windows.Forms.Label
        Dim REQ_FINANCIALSLabel As System.Windows.Forms.Label
        Dim REQ_GFSLabel As System.Windows.Forms.Label
        Dim REQ_LOGISLabel As System.Windows.Forms.Label
        Dim Acclevel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWebRequest))
        Me.IdToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.IdToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.GetByID1ToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.GetByID1ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.AccLevelToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.NOTESTextBox = New System.Windows.Forms.TextBox()
        Me.VIP_USERSBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ads = New ADAdminDotNet.dsADS()
        Me.DOWNLOADEDBYTextBox = New System.Windows.Forms.TextBox()
        Me.EXPORTEDDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CREATEDDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.RESET_PASSWORDCheckBox = New System.Windows.Forms.CheckBox()
        Me.EMAILTextBox = New System.Windows.Forms.TextBox()
        Me.CEL_TELTextBox = New System.Windows.Forms.TextBox()
        Me.FAX_TELTextBox = New System.Windows.Forms.TextBox()
        Me.BUS_TELTextBox = New System.Windows.Forms.TextBox()
        Me.RANKTextBox = New System.Windows.Forms.TextBox()
        Me.RESPONSIBILITYTextBox = New System.Windows.Forms.TextBox()
        Me.SURNAMETextBox = New System.Windows.Forms.TextBox()
        Me.FIRSTNAMETextBox = New System.Windows.Forms.TextBox()
        Me.TITLETextBox = New System.Windows.Forms.TextBox()
        Me.USERIDTextBox = New System.Windows.Forms.TextBox()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.textAccLevel = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.REQ_HRTextBox = New System.Windows.Forms.TextBox()
        Me.REQ_FINANCIALSTextBox = New System.Windows.Forms.TextBox()
        Me.REQ_DPSATextBox = New System.Windows.Forms.TextBox()
        Me.REQ_LOGISTextBox = New System.Windows.Forms.TextBox()
        Me.REQ_GFSTextBox = New System.Windows.Forms.TextBox()
        Me.VIP_USERSTableAdapter = New ADAdminDotNet.dsADSTableAdapters.VIP_USERSTableAdapter()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        NOTESLabel = New System.Windows.Forms.Label()
        DOWNLOADEDBYLabel = New System.Windows.Forms.Label()
        EXPORTEDLabel = New System.Windows.Forms.Label()
        CREATEDLabel = New System.Windows.Forms.Label()
        RESET_PASSWORDLabel = New System.Windows.Forms.Label()
        EMAILLabel = New System.Windows.Forms.Label()
        CEL_TELLabel = New System.Windows.Forms.Label()
        FAX_TELLabel = New System.Windows.Forms.Label()
        BUS_TELLabel = New System.Windows.Forms.Label()
        RANKLabel = New System.Windows.Forms.Label()
        RESPONSIBILITYLabel = New System.Windows.Forms.Label()
        SURNAMELabel = New System.Windows.Forms.Label()
        FIRSTNAMELabel = New System.Windows.Forms.Label()
        TITLELabel = New System.Windows.Forms.Label()
        USERIDLabel = New System.Windows.Forms.Label()
        IDLabel = New System.Windows.Forms.Label()
        REQ_HRLabel = New System.Windows.Forms.Label()
        REQ_DPSALabel = New System.Windows.Forms.Label()
        REQ_FINANCIALSLabel = New System.Windows.Forms.Label()
        REQ_GFSLabel = New System.Windows.Forms.Label()
        REQ_LOGISLabel = New System.Windows.Forms.Label()
        Acclevel = New System.Windows.Forms.Label()
        Me.GetByID1ToolStrip.SuspendLayout()
        CType(Me.VIP_USERSBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ads, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NOTESLabel
        '
        NOTESLabel.AutoSize = True
        NOTESLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NOTESLabel.Location = New System.Drawing.Point(252, 22)
        NOTESLabel.Name = "NOTESLabel"
        NOTESLabel.Size = New System.Drawing.Size(47, 13)
        NOTESLabel.TabIndex = 32
        NOTESLabel.Text = "NOTES:"
        '
        'DOWNLOADEDBYLabel
        '
        DOWNLOADEDBYLabel.AutoSize = True
        DOWNLOADEDBYLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DOWNLOADEDBYLabel.Location = New System.Drawing.Point(6, 82)
        DOWNLOADEDBYLabel.Name = "DOWNLOADEDBYLabel"
        DOWNLOADEDBYLabel.Size = New System.Drawing.Size(85, 13)
        DOWNLOADEDBYLabel.TabIndex = 30
        DOWNLOADEDBYLabel.Text = "Downloaded By:"
        '
        'EXPORTEDLabel
        '
        EXPORTEDLabel.AutoSize = True
        EXPORTEDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EXPORTEDLabel.Location = New System.Drawing.Point(6, 61)
        EXPORTEDLabel.Name = "EXPORTEDLabel"
        EXPORTEDLabel.Size = New System.Drawing.Size(52, 13)
        EXPORTEDLabel.TabIndex = 28
        EXPORTEDLabel.Text = "Exported:"
        '
        'CREATEDLabel
        '
        CREATEDLabel.AutoSize = True
        CREATEDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CREATEDLabel.Location = New System.Drawing.Point(6, 43)
        CREATEDLabel.Name = "CREATEDLabel"
        CREATEDLabel.Size = New System.Drawing.Size(73, 13)
        CREATEDLabel.TabIndex = 26
        CREATEDLabel.Text = "Date Created:"
        '
        'RESET_PASSWORDLabel
        '
        RESET_PASSWORDLabel.AutoSize = True
        RESET_PASSWORDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RESET_PASSWORDLabel.Location = New System.Drawing.Point(6, 20)
        RESET_PASSWORDLabel.Name = "RESET_PASSWORDLabel"
        RESET_PASSWORDLabel.Size = New System.Drawing.Size(87, 13)
        RESET_PASSWORDLabel.TabIndex = 24
        RESET_PASSWORDLabel.Text = "Reset Password:"
        '
        'EMAILLabel
        '
        EMAILLabel.AutoSize = True
        EMAILLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EMAILLabel.Location = New System.Drawing.Point(5, 232)
        EMAILLabel.Name = "EMAILLabel"
        EMAILLabel.Size = New System.Drawing.Size(77, 13)
        EMAILLabel.TabIndex = 22
        EMAILLabel.Text = "EMail Address:"
        '
        'CEL_TELLabel
        '
        CEL_TELLabel.AutoSize = True
        CEL_TELLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CEL_TELLabel.Location = New System.Drawing.Point(12, 202)
        CEL_TELLabel.Name = "CEL_TELLabel"
        CEL_TELLabel.Size = New System.Drawing.Size(62, 13)
        CEL_TELLabel.TabIndex = 20
        CEL_TELLabel.Text = "Cellular Tel:"
        '
        'FAX_TELLabel
        '
        FAX_TELLabel.AutoSize = True
        FAX_TELLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FAX_TELLabel.Location = New System.Drawing.Point(11, 181)
        FAX_TELLabel.Name = "FAX_TELLabel"
        FAX_TELLabel.Size = New System.Drawing.Size(67, 13)
        FAX_TELLabel.TabIndex = 18
        FAX_TELLabel.Text = "Fax Number:"
        '
        'BUS_TELLabel
        '
        BUS_TELLabel.AutoSize = True
        BUS_TELLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BUS_TELLabel.Location = New System.Drawing.Point(12, 161)
        BUS_TELLabel.Name = "BUS_TELLabel"
        BUS_TELLabel.Size = New System.Drawing.Size(46, 13)
        BUS_TELLabel.TabIndex = 16
        BUS_TELLabel.Text = "Bus Tel:"
        '
        'RANKLabel
        '
        RANKLabel.AutoSize = True
        RANKLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RANKLabel.Location = New System.Drawing.Point(12, 139)
        RANKLabel.Name = "RANKLabel"
        RANKLabel.Size = New System.Drawing.Size(36, 13)
        RANKLabel.TabIndex = 14
        RANKLabel.Text = "Rank:"
        '
        'RESPONSIBILITYLabel
        '
        RESPONSIBILITYLabel.AutoSize = True
        RESPONSIBILITYLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RESPONSIBILITYLabel.Location = New System.Drawing.Point(8, 89)
        RESPONSIBILITYLabel.Name = "RESPONSIBILITYLabel"
        RESPONSIBILITYLabel.Size = New System.Drawing.Size(74, 13)
        RESPONSIBILITYLabel.TabIndex = 12
        RESPONSIBILITYLabel.Text = "Responsibility:"
        '
        'SURNAMELabel
        '
        SURNAMELabel.AutoSize = True
        SURNAMELabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SURNAMELabel.Location = New System.Drawing.Point(8, 67)
        SURNAMELabel.Name = "SURNAMELabel"
        SURNAMELabel.Size = New System.Drawing.Size(52, 13)
        SURNAMELabel.TabIndex = 10
        SURNAMELabel.Text = "Surname:"
        '
        'FIRSTNAMELabel
        '
        FIRSTNAMELabel.AutoSize = True
        FIRSTNAMELabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FIRSTNAMELabel.Location = New System.Drawing.Point(8, 45)
        FIRSTNAMELabel.Name = "FIRSTNAMELabel"
        FIRSTNAMELabel.Size = New System.Drawing.Size(55, 13)
        FIRSTNAMELabel.TabIndex = 8
        FIRSTNAMELabel.Text = "Firstname:"
        '
        'TITLELabel
        '
        TITLELabel.AutoSize = True
        TITLELabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TITLELabel.Location = New System.Drawing.Point(8, 22)
        TITLELabel.Name = "TITLELabel"
        TITLELabel.Size = New System.Drawing.Size(30, 13)
        TITLELabel.TabIndex = 6
        TITLELabel.Text = "Title:"
        '
        'USERIDLabel
        '
        USERIDLabel.AutoSize = True
        USERIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        USERIDLabel.Location = New System.Drawing.Point(6, 104)
        USERIDLabel.Name = "USERIDLabel"
        USERIDLabel.Size = New System.Drawing.Size(43, 13)
        USERIDLabel.TabIndex = 4
        USERIDLabel.Text = "UserID:"
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.Location = New System.Drawing.Point(146, 20)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 2
        IDLabel.Text = "ID:"
        '
        'REQ_HRLabel
        '
        REQ_HRLabel.AutoSize = True
        REQ_HRLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        REQ_HRLabel.Location = New System.Drawing.Point(6, 18)
        REQ_HRLabel.Name = "REQ_HRLabel"
        REQ_HRLabel.Size = New System.Drawing.Size(81, 13)
        REQ_HRLabel.TabIndex = 34
        REQ_HRLabel.Text = "Requested HR:"
        '
        'REQ_DPSALabel
        '
        REQ_DPSALabel.AutoSize = True
        REQ_DPSALabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        REQ_DPSALabel.Location = New System.Drawing.Point(7, 106)
        REQ_DPSALabel.Name = "REQ_DPSALabel"
        REQ_DPSALabel.Size = New System.Drawing.Size(94, 13)
        REQ_DPSALabel.TabIndex = 42
        REQ_DPSALabel.Text = "Requested DPSA:"
        '
        'REQ_FINANCIALSLabel
        '
        REQ_FINANCIALSLabel.AutoSize = True
        REQ_FINANCIALSLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        REQ_FINANCIALSLabel.Location = New System.Drawing.Point(6, 40)
        REQ_FINANCIALSLabel.Name = "REQ_FINANCIALSLabel"
        REQ_FINANCIALSLabel.Size = New System.Drawing.Size(112, 13)
        REQ_FINANCIALSLabel.TabIndex = 36
        REQ_FINANCIALSLabel.Text = "Requested Financials:"
        '
        'REQ_GFSLabel
        '
        REQ_GFSLabel.AutoSize = True
        REQ_GFSLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        REQ_GFSLabel.Location = New System.Drawing.Point(7, 84)
        REQ_GFSLabel.Name = "REQ_GFSLabel"
        REQ_GFSLabel.Size = New System.Drawing.Size(86, 13)
        REQ_GFSLabel.TabIndex = 40
        REQ_GFSLabel.Text = "Requested GFS:"
        '
        'REQ_LOGISLabel
        '
        REQ_LOGISLabel.AutoSize = True
        REQ_LOGISLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        REQ_LOGISLabel.Location = New System.Drawing.Point(7, 62)
        REQ_LOGISLabel.Name = "REQ_LOGISLabel"
        REQ_LOGISLabel.Size = New System.Drawing.Size(97, 13)
        REQ_LOGISLabel.TabIndex = 38
        REQ_LOGISLabel.Text = "Requested LOGIS:"
        '
        'IdToolStripLabel
        '
        Me.IdToolStripLabel.Name = "IdToolStripLabel"
        Me.IdToolStripLabel.Size = New System.Drawing.Size(20, 22)
        Me.IdToolStripLabel.Text = "id:"
        '
        'IdToolStripTextBox
        '
        Me.IdToolStripTextBox.Name = "IdToolStripTextBox"
        Me.IdToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'GetByID1ToolStripButton
        '
        Me.GetByID1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.GetByID1ToolStripButton.Name = "GetByID1ToolStripButton"
        Me.GetByID1ToolStripButton.Size = New System.Drawing.Size(59, 22)
        Me.GetByID1ToolStripButton.Text = "GetByID1"
        '
        'GetByID1ToolStrip
        '
        Me.GetByID1ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IdToolStripLabel, Me.IdToolStripTextBox, Me.GetByID1ToolStripButton, Me.AccLevelToolStripTextBox})
        Me.GetByID1ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.GetByID1ToolStrip.Name = "GetByID1ToolStrip"
        Me.GetByID1ToolStrip.Size = New System.Drawing.Size(579, 25)
        Me.GetByID1ToolStrip.TabIndex = 44
        Me.GetByID1ToolStrip.Text = "GetByID1ToolStrip"
        Me.GetByID1ToolStrip.Visible = False
        '
        'AccLevelToolStripTextBox
        '
        Me.AccLevelToolStripTextBox.Name = "AccLevelToolStripTextBox"
        Me.AccLevelToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'NOTESTextBox
        '
        Me.NOTESTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VIP_USERSBindingSource1, "NOTES", True))
        Me.NOTESTextBox.Location = New System.Drawing.Point(305, 19)
        Me.NOTESTextBox.Multiline = True
        Me.NOTESTextBox.Name = "NOTESTextBox"
        Me.NOTESTextBox.Size = New System.Drawing.Size(243, 175)
        Me.NOTESTextBox.TabIndex = 33
        '
        'VIP_USERSBindingSource1
        '
        Me.VIP_USERSBindingSource1.AllowNew = False
        Me.VIP_USERSBindingSource1.DataMember = "VIP_USERS"
        Me.VIP_USERSBindingSource1.DataSource = Me.Ads
        '
        'Ads
        '
        Me.Ads.DataSetName = "ads"
        Me.Ads.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DOWNLOADEDBYTextBox
        '
        Me.DOWNLOADEDBYTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VIP_USERSBindingSource1, "DOWNLOADEDBY", True))
        Me.DOWNLOADEDBYTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DOWNLOADEDBYTextBox.Location = New System.Drawing.Point(122, 79)
        Me.DOWNLOADEDBYTextBox.Name = "DOWNLOADEDBYTextBox"
        Me.DOWNLOADEDBYTextBox.Size = New System.Drawing.Size(121, 20)
        Me.DOWNLOADEDBYTextBox.TabIndex = 31
        '
        'EXPORTEDDateTimePicker
        '
        Me.EXPORTEDDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VIP_USERSBindingSource1, "EXPORTED", True))
        Me.EXPORTEDDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EXPORTEDDateTimePicker.Location = New System.Drawing.Point(122, 57)
        Me.EXPORTEDDateTimePicker.Name = "EXPORTEDDateTimePicker"
        Me.EXPORTEDDateTimePicker.Size = New System.Drawing.Size(121, 20)
        Me.EXPORTEDDateTimePicker.TabIndex = 29
        '
        'CREATEDDateTimePicker
        '
        Me.CREATEDDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VIP_USERSBindingSource1, "CREATED", True))
        Me.CREATEDDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CREATEDDateTimePicker.Location = New System.Drawing.Point(122, 39)
        Me.CREATEDDateTimePicker.Name = "CREATEDDateTimePicker"
        Me.CREATEDDateTimePicker.Size = New System.Drawing.Size(121, 20)
        Me.CREATEDDateTimePicker.TabIndex = 27
        '
        'RESET_PASSWORDCheckBox
        '
        Me.RESET_PASSWORDCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.VIP_USERSBindingSource1, "RESET_PASSWORD", True))
        Me.RESET_PASSWORDCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RESET_PASSWORDCheckBox.Location = New System.Drawing.Point(122, 15)
        Me.RESET_PASSWORDCheckBox.Name = "RESET_PASSWORDCheckBox"
        Me.RESET_PASSWORDCheckBox.Size = New System.Drawing.Size(18, 24)
        Me.RESET_PASSWORDCheckBox.TabIndex = 25
        Me.RESET_PASSWORDCheckBox.UseVisualStyleBackColor = True
        '
        'EMAILTextBox
        '
        Me.EMAILTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VIP_USERSBindingSource1, "EMAIL", True))
        Me.EMAILTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EMAILTextBox.Location = New System.Drawing.Point(92, 229)
        Me.EMAILTextBox.Name = "EMAILTextBox"
        Me.EMAILTextBox.Size = New System.Drawing.Size(459, 20)
        Me.EMAILTextBox.TabIndex = 23
        '
        'CEL_TELTextBox
        '
        Me.CEL_TELTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VIP_USERSBindingSource1, "CEL_TEL", True))
        Me.CEL_TELTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CEL_TELTextBox.Location = New System.Drawing.Point(92, 206)
        Me.CEL_TELTextBox.Name = "CEL_TELTextBox"
        Me.CEL_TELTextBox.Size = New System.Drawing.Size(150, 20)
        Me.CEL_TELTextBox.TabIndex = 21
        '
        'FAX_TELTextBox
        '
        Me.FAX_TELTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VIP_USERSBindingSource1, "FAX_TEL", True))
        Me.FAX_TELTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FAX_TELTextBox.Location = New System.Drawing.Point(92, 184)
        Me.FAX_TELTextBox.Name = "FAX_TELTextBox"
        Me.FAX_TELTextBox.Size = New System.Drawing.Size(150, 20)
        Me.FAX_TELTextBox.TabIndex = 19
        '
        'BUS_TELTextBox
        '
        Me.BUS_TELTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VIP_USERSBindingSource1, "BUS_TEL", True))
        Me.BUS_TELTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BUS_TELTextBox.Location = New System.Drawing.Point(92, 161)
        Me.BUS_TELTextBox.Name = "BUS_TELTextBox"
        Me.BUS_TELTextBox.Size = New System.Drawing.Size(150, 20)
        Me.BUS_TELTextBox.TabIndex = 17
        '
        'RANKTextBox
        '
        Me.RANKTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VIP_USERSBindingSource1, "RANK", True))
        Me.RANKTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RANKTextBox.Location = New System.Drawing.Point(92, 139)
        Me.RANKTextBox.Name = "RANKTextBox"
        Me.RANKTextBox.Size = New System.Drawing.Size(150, 20)
        Me.RANKTextBox.TabIndex = 15
        '
        'RESPONSIBILITYTextBox
        '
        Me.RESPONSIBILITYTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VIP_USERSBindingSource1, "RESPONSIBILITY", True))
        Me.RESPONSIBILITYTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RESPONSIBILITYTextBox.Location = New System.Drawing.Point(93, 90)
        Me.RESPONSIBILITYTextBox.Name = "RESPONSIBILITYTextBox"
        Me.RESPONSIBILITYTextBox.Size = New System.Drawing.Size(150, 20)
        Me.RESPONSIBILITYTextBox.TabIndex = 13
        '
        'SURNAMETextBox
        '
        Me.SURNAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VIP_USERSBindingSource1, "SURNAME", True))
        Me.SURNAMETextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SURNAMETextBox.Location = New System.Drawing.Point(93, 67)
        Me.SURNAMETextBox.Name = "SURNAMETextBox"
        Me.SURNAMETextBox.Size = New System.Drawing.Size(150, 20)
        Me.SURNAMETextBox.TabIndex = 11
        '
        'FIRSTNAMETextBox
        '
        Me.FIRSTNAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VIP_USERSBindingSource1, "FIRSTNAME", True))
        Me.FIRSTNAMETextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FIRSTNAMETextBox.Location = New System.Drawing.Point(92, 42)
        Me.FIRSTNAMETextBox.Name = "FIRSTNAMETextBox"
        Me.FIRSTNAMETextBox.Size = New System.Drawing.Size(150, 20)
        Me.FIRSTNAMETextBox.TabIndex = 9
        '
        'TITLETextBox
        '
        Me.TITLETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VIP_USERSBindingSource1, "TITLE", True))
        Me.TITLETextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TITLETextBox.Location = New System.Drawing.Point(93, 16)
        Me.TITLETextBox.Name = "TITLETextBox"
        Me.TITLETextBox.Size = New System.Drawing.Size(51, 20)
        Me.TITLETextBox.TabIndex = 7
        '
        'USERIDTextBox
        '
        Me.USERIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VIP_USERSBindingSource1, "USERID", True))
        Me.USERIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.USERIDTextBox.Location = New System.Drawing.Point(122, 101)
        Me.USERIDTextBox.Name = "USERIDTextBox"
        Me.USERIDTextBox.Size = New System.Drawing.Size(71, 20)
        Me.USERIDTextBox.TabIndex = 5
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VIP_USERSBindingSource1, "ID", True))
        Me.IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTextBox.Location = New System.Drawing.Point(172, 17)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(71, 20)
        Me.IDTextBox.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(RESET_PASSWORDLabel)
        Me.GroupBox2.Controls.Add(Me.RESET_PASSWORDCheckBox)
        Me.GroupBox2.Controls.Add(CREATEDLabel)
        Me.GroupBox2.Controls.Add(Me.CREATEDDateTimePicker)
        Me.GroupBox2.Controls.Add(EXPORTEDLabel)
        Me.GroupBox2.Controls.Add(DOWNLOADEDBYLabel)
        Me.GroupBox2.Controls.Add(Me.DOWNLOADEDBYTextBox)
        Me.GroupBox2.Controls.Add(Me.EXPORTEDDateTimePicker)
        Me.GroupBox2.Controls.Add(IDLabel)
        Me.GroupBox2.Controls.Add(Me.IDTextBox)
        Me.GroupBox2.Controls.Add(USERIDLabel)
        Me.GroupBox2.Controls.Add(Me.USERIDTextBox)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 288)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(253, 130)
        Me.GroupBox2.TabIndex = 46
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Other Information"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Acclevel)
        Me.GroupBox3.Controls.Add(Me.textAccLevel)
        Me.GroupBox3.Controls.Add(TITLELabel)
        Me.GroupBox3.Controls.Add(Me.TITLETextBox)
        Me.GroupBox3.Controls.Add(Me.FIRSTNAMETextBox)
        Me.GroupBox3.Controls.Add(FIRSTNAMELabel)
        Me.GroupBox3.Controls.Add(NOTESLabel)
        Me.GroupBox3.Controls.Add(Me.NOTESTextBox)
        Me.GroupBox3.Controls.Add(Me.SURNAMETextBox)
        Me.GroupBox3.Controls.Add(SURNAMELabel)
        Me.GroupBox3.Controls.Add(EMAILLabel)
        Me.GroupBox3.Controls.Add(Me.RESPONSIBILITYTextBox)
        Me.GroupBox3.Controls.Add(Me.EMAILTextBox)
        Me.GroupBox3.Controls.Add(RESPONSIBILITYLabel)
        Me.GroupBox3.Controls.Add(CEL_TELLabel)
        Me.GroupBox3.Controls.Add(Me.RANKTextBox)
        Me.GroupBox3.Controls.Add(Me.CEL_TELTextBox)
        Me.GroupBox3.Controls.Add(RANKLabel)
        Me.GroupBox3.Controls.Add(FAX_TELLabel)
        Me.GroupBox3.Controls.Add(Me.BUS_TELTextBox)
        Me.GroupBox3.Controls.Add(Me.FAX_TELTextBox)
        Me.GroupBox3.Controls.Add(BUS_TELLabel)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(560, 269)
        Me.GroupBox3.TabIndex = 47
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Requestor Details"
        '
        'textAccLevel
        '
        Me.textAccLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textAccLevel.Location = New System.Drawing.Point(93, 113)
        Me.textAccLevel.Name = "textAccLevel"
        Me.textAccLevel.Size = New System.Drawing.Size(150, 20)
        Me.textAccLevel.TabIndex = 34
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(REQ_HRLabel)
        Me.GroupBox1.Controls.Add(Me.REQ_HRTextBox)
        Me.GroupBox1.Controls.Add(REQ_DPSALabel)
        Me.GroupBox1.Controls.Add(Me.REQ_FINANCIALSTextBox)
        Me.GroupBox1.Controls.Add(Me.REQ_DPSATextBox)
        Me.GroupBox1.Controls.Add(REQ_FINANCIALSLabel)
        Me.GroupBox1.Controls.Add(REQ_GFSLabel)
        Me.GroupBox1.Controls.Add(Me.REQ_LOGISTextBox)
        Me.GroupBox1.Controls.Add(Me.REQ_GFSTextBox)
        Me.GroupBox1.Controls.Add(REQ_LOGISLabel)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(314, 288)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(253, 130)
        Me.GroupBox1.TabIndex = 48
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rights Requested"
        '
        'REQ_HRTextBox
        '
        Me.REQ_HRTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VIP_USERSBindingSource1, "REQ_HR", True))
        Me.REQ_HRTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REQ_HRTextBox.Location = New System.Drawing.Point(122, 15)
        Me.REQ_HRTextBox.Name = "REQ_HRTextBox"
        Me.REQ_HRTextBox.Size = New System.Drawing.Size(121, 20)
        Me.REQ_HRTextBox.TabIndex = 35
        '
        'REQ_FINANCIALSTextBox
        '
        Me.REQ_FINANCIALSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VIP_USERSBindingSource1, "REQ_FINANCIALS", True))
        Me.REQ_FINANCIALSTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REQ_FINANCIALSTextBox.Location = New System.Drawing.Point(122, 37)
        Me.REQ_FINANCIALSTextBox.Name = "REQ_FINANCIALSTextBox"
        Me.REQ_FINANCIALSTextBox.Size = New System.Drawing.Size(121, 20)
        Me.REQ_FINANCIALSTextBox.TabIndex = 37
        '
        'REQ_DPSATextBox
        '
        Me.REQ_DPSATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VIP_USERSBindingSource1, "REQ_DPSA", True))
        Me.REQ_DPSATextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REQ_DPSATextBox.Location = New System.Drawing.Point(122, 103)
        Me.REQ_DPSATextBox.Name = "REQ_DPSATextBox"
        Me.REQ_DPSATextBox.Size = New System.Drawing.Size(121, 20)
        Me.REQ_DPSATextBox.TabIndex = 43
        '
        'REQ_LOGISTextBox
        '
        Me.REQ_LOGISTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VIP_USERSBindingSource1, "REQ_LOGIS", True))
        Me.REQ_LOGISTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REQ_LOGISTextBox.Location = New System.Drawing.Point(122, 59)
        Me.REQ_LOGISTextBox.Name = "REQ_LOGISTextBox"
        Me.REQ_LOGISTextBox.Size = New System.Drawing.Size(121, 20)
        Me.REQ_LOGISTextBox.TabIndex = 39
        '
        'REQ_GFSTextBox
        '
        Me.REQ_GFSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VIP_USERSBindingSource1, "REQ_GFS", True))
        Me.REQ_GFSTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REQ_GFSTextBox.Location = New System.Drawing.Point(122, 81)
        Me.REQ_GFSTextBox.Name = "REQ_GFSTextBox"
        Me.REQ_GFSTextBox.Size = New System.Drawing.Size(121, 20)
        Me.REQ_GFSTextBox.TabIndex = 41
        '
        'VIP_USERSTableAdapter
        '
        Me.VIP_USERSTableAdapter.ClearBeforeFill = True
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "VIP_USERS"
        Me.BindingSource1.DataSource = Me.Ads
        '
        'Acclevel
        '
        Acclevel.AutoSize = True
        Acclevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Acclevel.Location = New System.Drawing.Point(12, 113)
        Acclevel.Name = "Acclevel"
        Acclevel.Size = New System.Drawing.Size(58, 13)
        Acclevel.TabIndex = 35
        Acclevel.Text = "Acc Level:"
        '
        'frmWebRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 432)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GetByID1ToolStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmWebRequest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Web request Detail"
        Me.GetByID1ToolStrip.ResumeLayout(False)
        Me.GetByID1ToolStrip.PerformLayout()
        CType(Me.VIP_USERSBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ads, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents VIP_USERSTableAdapter As Global.ADAdminDotNet.dsADSTableAdapters.VIP_USERSTableAdapter
    Friend WithEvents Ads As Global.ADAdminDotNet.dsADS
    Friend WithEvents VIP_USERSBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents IdToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents IdToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents GetByID1ToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents GetByID1ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents NOTESTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DOWNLOADEDBYTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EXPORTEDDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents CREATEDDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents RESET_PASSWORDCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents EMAILTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CEL_TELTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FAX_TELTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BUS_TELTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RANKTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RESPONSIBILITYTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SURNAMETextBox As System.Windows.Forms.TextBox
    Friend WithEvents FIRSTNAMETextBox As System.Windows.Forms.TextBox
    Friend WithEvents TITLETextBox As System.Windows.Forms.TextBox
    Friend WithEvents USERIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents REQ_HRTextBox As System.Windows.Forms.TextBox
    Friend WithEvents REQ_FINANCIALSTextBox As System.Windows.Forms.TextBox
    Friend WithEvents REQ_DPSATextBox As System.Windows.Forms.TextBox
    Friend WithEvents REQ_LOGISTextBox As System.Windows.Forms.TextBox
    Friend WithEvents REQ_GFSTextBox As System.Windows.Forms.TextBox
    Friend WithEvents textAccLevel As System.Windows.Forms.TextBox
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents AccLevelToolStripTextBox As System.Windows.Forms.ToolStripTextBox
End Class
