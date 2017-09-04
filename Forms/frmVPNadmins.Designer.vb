<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVPNadmins
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVPNadmins))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripSplitButton()
        Me.ExportToCSVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VPN_Categories = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VPN_Admin_CategoriesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.VPN_AdminsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsADS = New Global.ADAdminDotNet.dsADS()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.VPN_Admin_CategoriesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.tsName = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.tsSurname = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsSourceId = New System.Windows.Forms.ToolStripLabel()
        Me.tsDept = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.VPNAdminsDataGridView = New System.Windows.Forms.DataGridView()
        Me.Title = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.First_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Last_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email_1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email_1_Display = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Categories = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Business_Address_City = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Business_Address_Region = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Company = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Business_Phone_1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Business_Phone_2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mobile_Phone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Job_Title = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Manager_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Department = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email_2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email_2_Display = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.VPN_Admin_CategoriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VPN_Admin_CategoriesTableAdapter = New Global.ADAdminDotNet.dsADSTableAdapters.VPN_Admin_CategoriesTableAdapter()
        Me.VPN_AdminsTableAdapter = New Global.ADAdminDotNet.dsADSTableAdapters.VPN_AdminsTableAdapter()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.VPN_Admin_CategoriesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VPN_Admin_CategoriesBindingNavigator.SuspendLayout()
        CType(Me.VPN_AdminsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsADS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VPNAdminsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VPN_Admin_CategoriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()

        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 654)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode
        Me.StatusStrip1.Size = New System.Drawing.Size(911, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportToCSVToolStripMenuItem})
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(83, 20)
        Me.ToolStripStatusLabel1.Text = "Export Data"
        '
        'ExportToCSVToolStripMenuItem
        '
        Me.ExportToCSVToolStripMenuItem.Name = "ExportToCSVToolStripMenuItem"
        Me.ExportToCSVToolStripMenuItem.Size = New System.Drawing.Size(250, 22)
        Me.ExportToCSVToolStripMenuItem.Text = "Export to VPN_Administrators.csv"
        '
        'VPN_Categories
        '
        Me.VPN_Categories.DataPropertyName = "Categories"
        Me.VPN_Categories.HeaderText = "Categories"
        Me.VPN_Categories.Name = "VPN_Categories"
        Me.VPN_Categories.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.VPN_Categories.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Business_Phone_1"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Business_Phone_1"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Business_Phone_2"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Business_Phone_2"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Mobile_Phone"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Mobile_Phone"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Job_Title"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Job_Title"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Manager_Name"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Manager_Name"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Department"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Department"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Email_1"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Email_1"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Email_2"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Email_2"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Email_1_Display"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Email_1_Display"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Email_2_Display"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Email_2_Display"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn18.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        '
        'VPN_Admin_CategoriesBindingNavigator
        '
        Me.VPN_Admin_CategoriesBindingNavigator.AddNewItem = Me.BindingNavigatorCountItem
        Me.VPN_Admin_CategoriesBindingNavigator.BindingSource = Me.VPN_AdminsBindingSource
        Me.VPN_Admin_CategoriesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.VPN_Admin_CategoriesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.VPN_Admin_CategoriesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.VPN_Admin_CategoriesBindingNavigatorSaveItem, Me.ToolStripSeparator1, Me.ToolStripLabel1, Me.tsName, Me.ToolStripSeparator2, Me.ToolStripLabel2, Me.tsSurname, Me.ToolStripSeparator3, Me.tsSourceId, Me.tsDept, Me.ToolStripSeparator4, Me.ToolStripButton1})
        Me.VPN_Admin_CategoriesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.VPN_Admin_CategoriesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveLastItem
        Me.VPN_Admin_CategoriesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.VPN_Admin_CategoriesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.VPN_Admin_CategoriesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.VPN_Admin_CategoriesBindingNavigator.Name = "VPN_Admin_CategoriesBindingNavigator"
        Me.VPN_Admin_CategoriesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.VPN_Admin_CategoriesBindingNavigator.Size = New System.Drawing.Size(911, 25)
        Me.VPN_Admin_CategoriesBindingNavigator.TabIndex = 1
        Me.VPN_Admin_CategoriesBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'VPN_AdminsBindingSource
        '
        Me.VPN_AdminsBindingSource.DataMember = "VPN_Admins"
        Me.VPN_AdminsBindingSource.DataSource = Me.DsADS
        '
        'DsADS
        '
        Me.DsADS.DataSetName = "dsADS"
        Me.DsADS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
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
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "of {0}"
        '
        'VPN_Admin_CategoriesBindingNavigatorSaveItem
        '
        Me.VPN_Admin_CategoriesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.VPN_Admin_CategoriesBindingNavigatorSaveItem.Image = CType(resources.GetObject("VPN_Admin_CategoriesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.VPN_Admin_CategoriesBindingNavigatorSaveItem.Name = "VPN_Admin_CategoriesBindingNavigatorSaveItem"
        Me.VPN_Admin_CategoriesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.VPN_Admin_CategoriesBindingNavigatorSaveItem.Text = "of {0}"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(39, 22)
        Me.ToolStripLabel1.Text = "Name"
        '
        'tsName
        '
        Me.tsName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.tsName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.tsName.BackColor = System.Drawing.Color.SeaShell
        Me.tsName.Name = "tsName"
        Me.tsName.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(54, 22)
        Me.ToolStripLabel2.Text = "Surname"
        '
        'tsSurname
        '
        Me.tsSurname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.tsSurname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.tsSurname.BackColor = System.Drawing.Color.SeaShell
        Me.tsSurname.Name = "tsSurname"
        Me.tsSurname.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'tsSourceId
        '
        Me.tsSourceId.Name = "tsSourceId"
        Me.tsSourceId.Size = New System.Drawing.Size(63, 22)
        Me.tsSourceId.Text = "Dept Code"
        '
        'tsDept
        '
        Me.tsDept.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.tsDept.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.tsDept.BackColor = System.Drawing.Color.SeaShell
        Me.tsDept.Name = "tsDept"
        Me.tsDept.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.BackColor = System.Drawing.Color.Bisque
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(100, 22)
        Me.ToolStripButton1.Text = "Config Problems"
        '
        'VPNAdminsDataGridView
        '
        Me.VPNAdminsDataGridView.AutoGenerateColumns = False
        Me.VPNAdminsDataGridView.ColumnHeadersHeight = 25
        Me.VPNAdminsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.VPNAdminsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Title, Me.First_Name, Me.Last_Name, Me.Email_1, Me.Email_1_Display, Me.Categories, Me.Business_Address_City, Me.Business_Address_Region, Me.Company, Me.Business_Phone_1, Me.Business_Phone_2, Me.Mobile_Phone, Me.Job_Title, Me.Manager_Name, Me.Department, Me.Email_2, Me.Email_2_Display, Me.IDColumn})
        Me.VPNAdminsDataGridView.DataSource = Me.VPN_AdminsBindingSource
        Me.VPNAdminsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VPNAdminsDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.VPNAdminsDataGridView.Name = "VPNAdminsDataGridView"
        Me.VPNAdminsDataGridView.RowHeadersWidth = 15
        Me.VPNAdminsDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.VPNAdminsDataGridView.Size = New System.Drawing.Size(911, 629)
        Me.VPNAdminsDataGridView.TabIndex = 2
        '
        'Title
        '
        Me.Title.DataPropertyName = "Title"
        Me.Title.HeaderText = "Title"
        Me.Title.Name = "Title"
        '
        'First_Name
        '
        Me.First_Name.DataPropertyName = "First_Name"
        Me.First_Name.HeaderText = "First Name"
        Me.First_Name.Name = "First_Name"
        '
        'Last_Name
        '
        Me.Last_Name.DataPropertyName = "Last_Name"
        Me.Last_Name.HeaderText = "Last Name"
        Me.Last_Name.Name = "Last_Name"
        '
        'Email_1
        '
        Me.Email_1.DataPropertyName = "Email_1"
        Me.Email_1.HeaderText = "Email1"
        Me.Email_1.Name = "Email_1"
        '
        'Email_1_Display
        '
        Me.Email_1_Display.DataPropertyName = "Email_1_Display"
        Me.Email_1_Display.HeaderText = "Email1 Display"
        Me.Email_1_Display.Name = "Email_1_Display"
        '
        'Categories
        '
        Me.Categories.DataPropertyName = "Categories"
        Me.Categories.HeaderText = "Categories"
        Me.Categories.Name = "Categories"
        '
        'Business_Address_City
        '
        Me.Business_Address_City.DataPropertyName = "Business_Address_City"
        Me.Business_Address_City.HeaderText = "City"
        Me.Business_Address_City.Name = "Business_Address_City"
        '
        'Business_Address_Region
        '
        Me.Business_Address_Region.DataPropertyName = "Business_Address_Region"
        Me.Business_Address_Region.HeaderText = "Region"
        Me.Business_Address_Region.Name = "Business_Address_Region"
        '
        'Company
        '
        Me.Company.DataPropertyName = "Company"
        Me.Company.HeaderText = "Company"
        Me.Company.Name = "Company"
        '
        'Business_Phone_1
        '
        Me.Business_Phone_1.DataPropertyName = "Business_Phone_1"
        Me.Business_Phone_1.HeaderText = "Phone1"
        Me.Business_Phone_1.Name = "Business_Phone_1"
        '
        'Business_Phone_2
        '
        Me.Business_Phone_2.DataPropertyName = "Business_Phone_2"
        Me.Business_Phone_2.HeaderText = "Phone2"
        Me.Business_Phone_2.Name = "Business_Phone_2"
        '
        'Mobile_Phone
        '
        Me.Mobile_Phone.DataPropertyName = "Mobile_Phone"
        Me.Mobile_Phone.HeaderText = "Mobile Phone"
        Me.Mobile_Phone.Name = "Mobile_Phone"
        '
        'Job_Title
        '
        Me.Job_Title.DataPropertyName = "Job_Title"
        Me.Job_Title.HeaderText = "Job Title"
        Me.Job_Title.Name = "Job_Title"
        '
        'Manager_Name
        '
        Me.Manager_Name.DataPropertyName = "Manager_Name"
        Me.Manager_Name.HeaderText = "Manager Name"
        Me.Manager_Name.Name = "Manager_Name"
        '
        'Department
        '
        Me.Department.DataPropertyName = "Department"
        Me.Department.HeaderText = "Department"
        Me.Department.Name = "Department"
        '
        'Email_2
        '
        Me.Email_2.DataPropertyName = "Email_2"
        Me.Email_2.HeaderText = "Email2"
        Me.Email_2.Name = "Email_2"
        '
        'Email_2_Display
        '
        Me.Email_2_Display.DataPropertyName = "Email_2_Display"
        Me.Email_2_Display.HeaderText = "Email2 Display"
        Me.Email_2_Display.Name = "Email_2_Display"
        '
        'IDColumn
        '
        Me.IDColumn.DataPropertyName = "ID"
        Me.IDColumn.HeaderText = "ID"
        Me.IDColumn.Name = "IDColumn"
        Me.IDColumn.ReadOnly = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'VPN_Admin_CategoriesBindingSource
        '
        Me.VPN_Admin_CategoriesBindingSource.DataMember = "VPN_Admin_Categories"
        Me.VPN_Admin_CategoriesBindingSource.DataSource = Me.DsADS
        '
        'VPN_Admin_CategoriesTableAdapter
        '
        Me.VPN_Admin_CategoriesTableAdapter.ClearBeforeFill = True
        '
        'VPN_AdminsTableAdapter
        '
        Me.VPN_AdminsTableAdapter.ClearBeforeFill = True
        '
        'frmVPNadmins
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(911, 676)
        Me.Controls.Add(Me.VPNAdminsDataGridView)
        Me.Controls.Add(Me.VPN_Admin_CategoriesBindingNavigator)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmVPNadmins"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VPN Admins"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.VPN_Admin_CategoriesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VPN_Admin_CategoriesBindingNavigator.ResumeLayout(False)
        Me.VPN_Admin_CategoriesBindingNavigator.PerformLayout()
        CType(Me.VPN_AdminsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsADS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VPNAdminsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VPN_Admin_CategoriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents VPN_Categories As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DsADS As Global.ADAdminDotNet.dsADS
    Friend WithEvents VPN_Admin_CategoriesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VPN_Admin_CategoriesTableAdapter As Global.ADAdminDotNet.dsADSTableAdapters.VPN_Admin_CategoriesTableAdapter
    Friend WithEvents VPN_Admin_CategoriesBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents VPN_Admin_CategoriesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents VPN_AdminsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VPN_AdminsTableAdapter As Global.ADAdminDotNet.dsADSTableAdapters.VPN_AdminsTableAdapter
    Friend WithEvents VPNAdminsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tsName As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tsSurname As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsSourceId As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tsDept As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents ExportToCSVToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Title As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents First_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Last_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Email_1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Email_1_Display As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Categories As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Business_Address_City As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Business_Address_Region As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Company As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Business_Phone_1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Business_Phone_2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Mobile_Phone As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Job_Title As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Manager_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Department As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Email_2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Email_2_Display As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
