<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewUsers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNewUsers))
        Me.VIP_USERS_NewUsersBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.VIP_USERS_NewUsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ads = New ADAdminDotNet.dsADS()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.VIP_USERS_NewUsersBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnCustInfo = New System.Windows.Forms.ToolStripButton()
        Me.VIP_USERS_NewUsersDataGridView = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PopulateValuesInRemedyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MarkAsDoneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CancelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ExportToNewAccountRequestscsvToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ARSystemDataSet = New ADAdminDotNet.dsARSystemDataSet()
        Me.bs_Remedy = New System.Windows.Forms.BindingSource(Me.components)
        Me.ta_Customer_Information = New ADAdminDotNet.dsARSystemDataSetTableAdapters.LOG_DM_Customer_InformationTableAdapter()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.VIP_USERS_NewUsersTableAdapter = New ADAdminDotNet.dsADSTableAdapters.VIP_USERS_NewUsersTableAdapter()
        Me.Persalnr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Title = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Firstname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Surname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Responsibility = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Accountlevel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Rank = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dept = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Province = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cell = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FIN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LOGIS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GFS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DPSA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Notes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DEPARTMENT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CFO_INFO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.VIP_USERS_NewUsersBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VIP_USERS_NewUsersBindingNavigator.SuspendLayout()
        CType(Me.VIP_USERS_NewUsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ads, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VIP_USERS_NewUsersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ARSystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_Remedy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VIP_USERS_NewUsersBindingNavigator
        '
        Me.VIP_USERS_NewUsersBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.VIP_USERS_NewUsersBindingNavigator.BindingSource = Me.VIP_USERS_NewUsersBindingSource
        Me.VIP_USERS_NewUsersBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.VIP_USERS_NewUsersBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.VIP_USERS_NewUsersBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.VIP_USERS_NewUsersBindingNavigatorSaveItem, Me.ToolStripSeparator1, Me.btnCustInfo})
        Me.VIP_USERS_NewUsersBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.VIP_USERS_NewUsersBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.VIP_USERS_NewUsersBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.VIP_USERS_NewUsersBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.VIP_USERS_NewUsersBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.VIP_USERS_NewUsersBindingNavigator.Name = "VIP_USERS_NewUsersBindingNavigator"
        Me.VIP_USERS_NewUsersBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.VIP_USERS_NewUsersBindingNavigator.Size = New System.Drawing.Size(824, 25)
        Me.VIP_USERS_NewUsersBindingNavigator.TabIndex = 0
        Me.VIP_USERS_NewUsersBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        Me.BindingNavigatorAddNewItem.Visible = False
        '
        'VIP_USERS_NewUsersBindingSource
        '
        Me.VIP_USERS_NewUsersBindingSource.DataMember = "VIP_USERS_NewUsers"
        Me.VIP_USERS_NewUsersBindingSource.DataSource = Me.Ads
        '
        'Ads
        '
        Me.Ads.DataSetName = "ads"
        Me.Ads.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        Me.BindingNavigatorDeleteItem.Visible = False
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'VIP_USERS_NewUsersBindingNavigatorSaveItem
        '
        Me.VIP_USERS_NewUsersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.VIP_USERS_NewUsersBindingNavigatorSaveItem.Enabled = False
        Me.VIP_USERS_NewUsersBindingNavigatorSaveItem.Image = CType(resources.GetObject("VIP_USERS_NewUsersBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.VIP_USERS_NewUsersBindingNavigatorSaveItem.Name = "VIP_USERS_NewUsersBindingNavigatorSaveItem"
        Me.VIP_USERS_NewUsersBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.VIP_USERS_NewUsersBindingNavigatorSaveItem.Text = "Save Data"
        Me.VIP_USERS_NewUsersBindingNavigatorSaveItem.Visible = False
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnCustInfo
        '
        Me.btnCustInfo.Image = CType(resources.GetObject("btnCustInfo.Image"), System.Drawing.Image)
        Me.btnCustInfo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCustInfo.Name = "btnCustInfo"
        Me.btnCustInfo.Size = New System.Drawing.Size(145, 22)
        Me.btnCustInfo.Text = "Customer Information"
        '
        'VIP_USERS_NewUsersDataGridView
        '
        Me.VIP_USERS_NewUsersDataGridView.AllowUserToAddRows = False
        Me.VIP_USERS_NewUsersDataGridView.AllowUserToDeleteRows = False
        Me.VIP_USERS_NewUsersDataGridView.AutoGenerateColumns = False
        Me.VIP_USERS_NewUsersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Persalnr, Me.Title, Me.Firstname, Me.Surname, Me.DataGridViewTextBoxColumn21, Me.Responsibility, Me.Accountlevel, Me.DataGridViewCheckBoxColumn1, Me.Rank, Me.Dept, Me.Province, Me.TelB, Me.Fax, Me.Cell, Me.EMail, Me.HR, Me.FIN, Me.LOGIS, Me.GFS, Me.DPSA, Me.Notes, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.ID, Me.DEPARTMENT, Me.CFO_INFO})
        Me.VIP_USERS_NewUsersDataGridView.ContextMenuStrip = Me.ContextMenuStrip1
        Me.VIP_USERS_NewUsersDataGridView.DataSource = Me.VIP_USERS_NewUsersBindingSource
        Me.VIP_USERS_NewUsersDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.VIP_USERS_NewUsersDataGridView.Name = "VIP_USERS_NewUsersDataGridView"
        Me.VIP_USERS_NewUsersDataGridView.ReadOnly = True
        Me.VIP_USERS_NewUsersDataGridView.RowHeadersWidth = 4
        Me.VIP_USERS_NewUsersDataGridView.Size = New System.Drawing.Size(823, 501)
        Me.VIP_USERS_NewUsersDataGridView.TabIndex = 1
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PopulateValuesInRemedyToolStripMenuItem, Me.ToolStripMenuItem2, Me.MarkAsDoneToolStripMenuItem, Me.ToolStripMenuItem1, Me.CancelToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(218, 82)
        '
        'PopulateValuesInRemedyToolStripMenuItem
        '
        Me.PopulateValuesInRemedyToolStripMenuItem.Name = "PopulateValuesInRemedyToolStripMenuItem"
        Me.PopulateValuesInRemedyToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.PopulateValuesInRemedyToolStripMenuItem.Text = "Populate Values In Remedy"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(214, 6)
        '
        'MarkAsDoneToolStripMenuItem
        '
        Me.MarkAsDoneToolStripMenuItem.Name = "MarkAsDoneToolStripMenuItem"
        Me.MarkAsDoneToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.MarkAsDoneToolStripMenuItem.Text = "Mark as Done"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(214, 6)
        '
        'CancelToolStripMenuItem
        '
        Me.CancelToolStripMenuItem.Name = "CancelToolStripMenuItem"
        Me.CancelToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.CancelToolStripMenuItem.Text = "Cancel"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 527)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode
        Me.StatusStrip1.Size = New System.Drawing.Size(824, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportToNewAccountRequestscsvToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(80, 20)
        Me.ToolStripDropDownButton1.Text = "Export Data"
        '
        'ExportToNewAccountRequestscsvToolStripMenuItem
        '
        Me.ExportToNewAccountRequestscsvToolStripMenuItem.Name = "ExportToNewAccountRequestscsvToolStripMenuItem"
        Me.ExportToNewAccountRequestscsvToolStripMenuItem.Size = New System.Drawing.Size(260, 22)
        Me.ExportToNewAccountRequestscsvToolStripMenuItem.Text = "Export to NewAccountRequests.csv"
        '
        'BindingSource1
        '
        Me.BindingSource1.DataSource = Me.ARSystemDataSet
        Me.BindingSource1.Position = 0
        '
        'ARSystemDataSet
        '
        Me.ARSystemDataSet.DataSetName = "ARSystemDataSet"
        Me.ARSystemDataSet.EnforceConstraints = False
        Me.ARSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'bs_Remedy
        '
        Me.bs_Remedy.DataMember = "LOG_DM_Customer_Information"
        Me.bs_Remedy.DataSource = Me.ARSystemDataSet
        '
        'ta_Customer_Information
        '
        Me.ta_Customer_Information.ClearBeforeFill = True
        '
        'VIP_USERS_NewUsersTableAdapter
        '
        Me.VIP_USERS_NewUsersTableAdapter.ClearBeforeFill = True
        '
        'Persalnr
        '
        Me.Persalnr.DataPropertyName = "Persalnr"
        Me.Persalnr.HeaderText = "Persalnr"
        Me.Persalnr.Name = "Persalnr"
        Me.Persalnr.ReadOnly = True
        '
        'Title
        '
        Me.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Title.DataPropertyName = "Title"
        Me.Title.HeaderText = "Title"
        Me.Title.Name = "Title"
        Me.Title.ReadOnly = True
        Me.Title.Width = 52
        '
        'Firstname
        '
        Me.Firstname.DataPropertyName = "Firstname"
        Me.Firstname.HeaderText = "Firstname"
        Me.Firstname.Name = "Firstname"
        Me.Firstname.ReadOnly = True
        '
        'Surname
        '
        Me.Surname.DataPropertyName = "Surname"
        Me.Surname.HeaderText = "Surname"
        Me.Surname.Name = "Surname"
        Me.Surname.ReadOnly = True
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "DownloadedBy"
        Me.DataGridViewTextBoxColumn21.HeaderText = "DownloadedBy"
        Me.DataGridViewTextBoxColumn21.MinimumWidth = 2
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        Me.DataGridViewTextBoxColumn21.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn21.Visible = False
        Me.DataGridViewTextBoxColumn21.Width = 2
        '
        'Responsibility
        '
        Me.Responsibility.DataPropertyName = "Responsibility"
        Me.Responsibility.HeaderText = "Responsibility"
        Me.Responsibility.Name = "Responsibility"
        Me.Responsibility.ReadOnly = True
        '
        'Accountlevel
        '
        Me.Accountlevel.DataPropertyName = "AcountLevel"
        Me.Accountlevel.HeaderText = "Account Level"
        Me.Accountlevel.Name = "Accountlevel"
        Me.Accountlevel.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Reset"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Reset"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        Me.DataGridViewCheckBoxColumn1.Width = 40
        '
        'Rank
        '
        Me.Rank.DataPropertyName = "Rank"
        Me.Rank.HeaderText = "Rank"
        Me.Rank.Name = "Rank"
        Me.Rank.ReadOnly = True
        '
        'Dept
        '
        Me.Dept.DataPropertyName = "Dept"
        Me.Dept.HeaderText = "Dept"
        Me.Dept.Name = "Dept"
        Me.Dept.ReadOnly = True
        '
        'Province
        '
        Me.Province.DataPropertyName = "Province"
        Me.Province.HeaderText = "Province"
        Me.Province.Name = "Province"
        Me.Province.ReadOnly = True
        '
        'TelB
        '
        Me.TelB.DataPropertyName = "TelB"
        Me.TelB.HeaderText = "TelB"
        Me.TelB.Name = "TelB"
        Me.TelB.ReadOnly = True
        '
        'Fax
        '
        Me.Fax.DataPropertyName = "Fax"
        Me.Fax.HeaderText = "Fax"
        Me.Fax.Name = "Fax"
        Me.Fax.ReadOnly = True
        '
        'Cell
        '
        Me.Cell.DataPropertyName = "Cell"
        Me.Cell.HeaderText = "Cell"
        Me.Cell.Name = "Cell"
        Me.Cell.ReadOnly = True
        '
        'EMail
        '
        Me.EMail.DataPropertyName = "EMail"
        Me.EMail.HeaderText = "EMail"
        Me.EMail.Name = "EMail"
        Me.EMail.ReadOnly = True
        '
        'HR
        '
        Me.HR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.HR.DataPropertyName = "HR"
        Me.HR.HeaderText = "HR"
        Me.HR.Name = "HR"
        Me.HR.ReadOnly = True
        Me.HR.Width = 48
        '
        'FIN
        '
        Me.FIN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FIN.DataPropertyName = "FIN"
        Me.FIN.HeaderText = "FIN"
        Me.FIN.Name = "FIN"
        Me.FIN.ReadOnly = True
        Me.FIN.Width = 49
        '
        'LOGIS
        '
        Me.LOGIS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.LOGIS.DataPropertyName = "LOGIS"
        Me.LOGIS.HeaderText = "LOGIS"
        Me.LOGIS.Name = "LOGIS"
        Me.LOGIS.ReadOnly = True
        Me.LOGIS.Width = 64
        '
        'GFS
        '
        Me.GFS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.GFS.DataPropertyName = "GFS"
        Me.GFS.HeaderText = "GFS"
        Me.GFS.Name = "GFS"
        Me.GFS.ReadOnly = True
        Me.GFS.Width = 53
        '
        'DPSA
        '
        Me.DPSA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DPSA.DataPropertyName = "DPSA"
        Me.DPSA.HeaderText = "DPSA"
        Me.DPSA.Name = "DPSA"
        Me.DPSA.ReadOnly = True
        Me.DPSA.Width = 61
        '
        'Notes
        '
        Me.Notes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Notes.DataPropertyName = "Notes"
        Me.Notes.HeaderText = "Notes"
        Me.Notes.Name = "Notes"
        Me.Notes.ReadOnly = True
        Me.Notes.Width = 60
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "Done"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Done"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "Created"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Created"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "Exported"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Exported"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        '
        'ID
        '
        Me.ID.DataPropertyName = "ID"
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        '
        'DEPARTMENT
        '
        Me.DEPARTMENT.DataPropertyName = "DEPARTMENT"
        Me.DEPARTMENT.HeaderText = "DEPARTMENT"
        Me.DEPARTMENT.Name = "DEPARTMENT"
        Me.DEPARTMENT.ReadOnly = True
        '
        'CFO_INFO
        '
        Me.CFO_INFO.DataPropertyName = "CFO_INFO"
        Me.CFO_INFO.HeaderText = "CFO_INFO"
        Me.CFO_INFO.Name = "CFO_INFO"
        Me.CFO_INFO.ReadOnly = True
        '
        'frmNewUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 549)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.VIP_USERS_NewUsersDataGridView)
        Me.Controls.Add(Me.VIP_USERS_NewUsersBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmNewUsers"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Account Requests"
        CType(Me.VIP_USERS_NewUsersBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VIP_USERS_NewUsersBindingNavigator.ResumeLayout(False)
        Me.VIP_USERS_NewUsersBindingNavigator.PerformLayout()
        CType(Me.VIP_USERS_NewUsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ads, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VIP_USERS_NewUsersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ARSystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_Remedy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Ads As Global.ADAdminDotNet.dsADS
    Friend WithEvents VIP_USERS_NewUsersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VIP_USERS_NewUsersTableAdapter As Global.ADAdminDotNet.dsADSTableAdapters.VIP_USERS_NewUsersTableAdapter
    Friend WithEvents VIP_USERS_NewUsersBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents VIP_USERS_NewUsersBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents VIP_USERS_NewUsersDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ExportToNewAccountRequestscsvToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ARSystemDataSet As Global.ADAdminDotNet.dsARSystemDataSet
    Friend WithEvents bs_Remedy As System.Windows.Forms.BindingSource
    Friend WithEvents ta_Customer_Information As Global.ADAdminDotNet.dsARSystemDataSetTableAdapters.LOG_DM_Customer_InformationTableAdapter
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MarkAsDoneToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CancelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

    Friend WithEvents PopulateValuesInRemedyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCustInfo As System.Windows.Forms.ToolStripButton
    Friend WithEvents Persalnr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Title As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Firstname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Surname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Responsibility As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Accountlevel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Rank As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dept As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Province As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelB As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fax As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cell As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EMail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FIN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LOGIS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GFS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DPSA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Notes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DEPARTMENT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CFO_INFO As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
