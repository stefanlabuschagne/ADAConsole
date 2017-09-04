<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResetPassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmResetPassword))
        Me.VIP_USERS_ResetPasswordBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
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
        Me.VIP_USERS_ResetPasswordBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.VIP_USERS_ResetPasswordDataGridView = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FlagSuspiciousRemoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CancelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ExportFlagged3ToCSVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToExcelOpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersalNrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProvinceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeptDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SurnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResponsibilityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RankDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FaxDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CellDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HRDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FINDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LOGISDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GFSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DPSADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NotesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResetDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CreatedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExportedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DownloadedByDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VIP_USERS_ResetPasswordBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ads = New ADAdminDotNet.dsADS()
        Me.VIP_USERS_ResetPasswordTableAdapter = New ADAdminDotNet.dsADSTableAdapters.VIP_USERS_ResetPasswordTableAdapter()
        CType(Me.VIP_USERS_ResetPasswordBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VIP_USERS_ResetPasswordBindingNavigator.SuspendLayout()
        CType(Me.VIP_USERS_ResetPasswordDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.VIP_USERS_ResetPasswordBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ads, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VIP_USERS_ResetPasswordBindingNavigator
        '
        Me.VIP_USERS_ResetPasswordBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.VIP_USERS_ResetPasswordBindingNavigator.BindingSource = Me.VIP_USERS_ResetPasswordBindingSource
        Me.VIP_USERS_ResetPasswordBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.VIP_USERS_ResetPasswordBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.VIP_USERS_ResetPasswordBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.VIP_USERS_ResetPasswordBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.VIP_USERS_ResetPasswordBindingNavigatorSaveItem})
        Me.VIP_USERS_ResetPasswordBindingNavigator.Location = New System.Drawing.Point(3, 0)
        Me.VIP_USERS_ResetPasswordBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.VIP_USERS_ResetPasswordBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.VIP_USERS_ResetPasswordBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.VIP_USERS_ResetPasswordBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.VIP_USERS_ResetPasswordBindingNavigator.Name = "VIP_USERS_ResetPasswordBindingNavigator"
        Me.VIP_USERS_ResetPasswordBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.VIP_USERS_ResetPasswordBindingNavigator.Size = New System.Drawing.Size(209, 25)
        Me.VIP_USERS_ResetPasswordBindingNavigator.TabIndex = 0
        Me.VIP_USERS_ResetPasswordBindingNavigator.Text = "BindingNavigator1"
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
        'VIP_USERS_ResetPasswordBindingNavigatorSaveItem
        '
        Me.VIP_USERS_ResetPasswordBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.VIP_USERS_ResetPasswordBindingNavigatorSaveItem.Enabled = False
        Me.VIP_USERS_ResetPasswordBindingNavigatorSaveItem.Image = CType(resources.GetObject("VIP_USERS_ResetPasswordBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.VIP_USERS_ResetPasswordBindingNavigatorSaveItem.Name = "VIP_USERS_ResetPasswordBindingNavigatorSaveItem"
        Me.VIP_USERS_ResetPasswordBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.VIP_USERS_ResetPasswordBindingNavigatorSaveItem.Text = "Save Data"
        Me.VIP_USERS_ResetPasswordBindingNavigatorSaveItem.Visible = False
        '
        'VIP_USERS_ResetPasswordDataGridView
        '
        Me.VIP_USERS_ResetPasswordDataGridView.AllowUserToAddRows = False
        Me.VIP_USERS_ResetPasswordDataGridView.AllowUserToDeleteRows = False
        Me.VIP_USERS_ResetPasswordDataGridView.AllowUserToOrderColumns = True
        Me.VIP_USERS_ResetPasswordDataGridView.AutoGenerateColumns = False
        Me.VIP_USERS_ResetPasswordDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.VIP_USERS_ResetPasswordDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.PersalNrDataGridViewTextBoxColumn, Me.ProvinceDataGridViewTextBoxColumn, Me.DeptDataGridViewTextBoxColumn, Me.TitleDataGridViewTextBoxColumn, Me.FirstnameDataGridViewTextBoxColumn, Me.SurnameDataGridViewTextBoxColumn, Me.ResponsibilityDataGridViewTextBoxColumn, Me.RankDataGridViewTextBoxColumn, Me.TelBDataGridViewTextBoxColumn, Me.FaxDataGridViewTextBoxColumn, Me.CellDataGridViewTextBoxColumn, Me.EMailDataGridViewTextBoxColumn, Me.HRDataGridViewTextBoxColumn, Me.FINDataGridViewTextBoxColumn, Me.LOGISDataGridViewTextBoxColumn, Me.GFSDataGridViewTextBoxColumn, Me.DPSADataGridViewTextBoxColumn, Me.NotesDataGridViewTextBoxColumn, Me.DoneDataGridViewTextBoxColumn, Me.ResetDataGridViewCheckBoxColumn, Me.CreatedDataGridViewTextBoxColumn, Me.ExportedDataGridViewTextBoxColumn, Me.DownloadedByDataGridViewTextBoxColumn})
        Me.VIP_USERS_ResetPasswordDataGridView.ContextMenuStrip = Me.ContextMenuStrip1
        Me.VIP_USERS_ResetPasswordDataGridView.DataSource = Me.VIP_USERS_ResetPasswordBindingSource
        Me.VIP_USERS_ResetPasswordDataGridView.Location = New System.Drawing.Point(3, 0)
        Me.VIP_USERS_ResetPasswordDataGridView.Name = "VIP_USERS_ResetPasswordDataGridView"
        Me.VIP_USERS_ResetPasswordDataGridView.ReadOnly = True
        Me.VIP_USERS_ResetPasswordDataGridView.RowHeadersWidth = 4
        Me.VIP_USERS_ResetPasswordDataGridView.Size = New System.Drawing.Size(842, 612)
        Me.VIP_USERS_ResetPasswordDataGridView.TabIndex = 1
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FlagSuspiciousRemoveToolStripMenuItem, Me.ToolStripMenuItem1, Me.CancelToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(170, 54)
        '
        'FlagSuspiciousRemoveToolStripMenuItem
        '
        Me.FlagSuspiciousRemoveToolStripMenuItem.Name = "FlagSuspiciousRemoveToolStripMenuItem"
        Me.FlagSuspiciousRemoveToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.FlagSuspiciousRemoveToolStripMenuItem.Text = "Remove from Log"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(166, 6)
        '
        'CancelToolStripMenuItem
        '
        Me.CancelToolStripMenuItem.Name = "CancelToolStripMenuItem"
        Me.CancelToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.CancelToolStripMenuItem.Text = "Cancel"
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.BottomToolStripPanel
        '
        Me.ToolStripContainer1.BottomToolStripPanel.Controls.Add(Me.StatusStrip1)
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.VIP_USERS_ResetPasswordDataGridView)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(845, 615)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(845, 662)
        Me.ToolStripContainer1.TabIndex = 3
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.VIP_USERS_ResetPasswordBindingNavigator)
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 0)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(845, 22)
        Me.StatusStrip1.TabIndex = 0
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportFlagged3ToCSVToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(80, 20)
        Me.ToolStripDropDownButton1.Text = "Export Data"
        '
        'ExportFlagged3ToCSVToolStripMenuItem
        '
        Me.ExportFlagged3ToCSVToolStripMenuItem.Name = "ExportFlagged3ToCSVToolStripMenuItem"
        Me.ExportFlagged3ToCSVToolStripMenuItem.Size = New System.Drawing.Size(260, 22)
        Me.ExportFlagged3ToCSVToolStripMenuItem.Text = "Export to User_Password_Resets.csv"
        '
        'ExportToExcelOpenToolStripMenuItem
        '
        Me.ExportToExcelOpenToolStripMenuItem.Name = "ExportToExcelOpenToolStripMenuItem"
        Me.ExportToExcelOpenToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.ExportToExcelOpenToolStripMenuItem.Text = "Export to Excel && Open"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(197, 22)
        Me.ToolStripMenuItem2.Text = "Export to Excel && Open"
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Width = 43
        '
        'PersalNrDataGridViewTextBoxColumn
        '
        Me.PersalNrDataGridViewTextBoxColumn.DataPropertyName = "PersalNr"
        Me.PersalNrDataGridViewTextBoxColumn.HeaderText = "PersalNr"
        Me.PersalNrDataGridViewTextBoxColumn.Name = "PersalNrDataGridViewTextBoxColumn"
        Me.PersalNrDataGridViewTextBoxColumn.ReadOnly = True
        Me.PersalNrDataGridViewTextBoxColumn.Width = 72
        '
        'ProvinceDataGridViewTextBoxColumn
        '
        Me.ProvinceDataGridViewTextBoxColumn.DataPropertyName = "Province"
        Me.ProvinceDataGridViewTextBoxColumn.HeaderText = "Province"
        Me.ProvinceDataGridViewTextBoxColumn.Name = "ProvinceDataGridViewTextBoxColumn"
        Me.ProvinceDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProvinceDataGridViewTextBoxColumn.Width = 74
        '
        'DeptDataGridViewTextBoxColumn
        '
        Me.DeptDataGridViewTextBoxColumn.DataPropertyName = "Dept"
        Me.DeptDataGridViewTextBoxColumn.HeaderText = "Dept"
        Me.DeptDataGridViewTextBoxColumn.Name = "DeptDataGridViewTextBoxColumn"
        Me.DeptDataGridViewTextBoxColumn.ReadOnly = True
        Me.DeptDataGridViewTextBoxColumn.Width = 55
        '
        'TitleDataGridViewTextBoxColumn
        '
        Me.TitleDataGridViewTextBoxColumn.DataPropertyName = "Title"
        Me.TitleDataGridViewTextBoxColumn.HeaderText = "Title"
        Me.TitleDataGridViewTextBoxColumn.Name = "TitleDataGridViewTextBoxColumn"
        Me.TitleDataGridViewTextBoxColumn.ReadOnly = True
        Me.TitleDataGridViewTextBoxColumn.Width = 52
        '
        'FirstnameDataGridViewTextBoxColumn
        '
        Me.FirstnameDataGridViewTextBoxColumn.DataPropertyName = "Firstname"
        Me.FirstnameDataGridViewTextBoxColumn.HeaderText = "Firstname"
        Me.FirstnameDataGridViewTextBoxColumn.Name = "FirstnameDataGridViewTextBoxColumn"
        Me.FirstnameDataGridViewTextBoxColumn.ReadOnly = True
        Me.FirstnameDataGridViewTextBoxColumn.Width = 77
        '
        'SurnameDataGridViewTextBoxColumn
        '
        Me.SurnameDataGridViewTextBoxColumn.DataPropertyName = "Surname"
        Me.SurnameDataGridViewTextBoxColumn.HeaderText = "Surname"
        Me.SurnameDataGridViewTextBoxColumn.Name = "SurnameDataGridViewTextBoxColumn"
        Me.SurnameDataGridViewTextBoxColumn.ReadOnly = True
        Me.SurnameDataGridViewTextBoxColumn.Width = 74
        '
        'ResponsibilityDataGridViewTextBoxColumn
        '
        Me.ResponsibilityDataGridViewTextBoxColumn.DataPropertyName = "Responsibility"
        Me.ResponsibilityDataGridViewTextBoxColumn.HeaderText = "Responsibility"
        Me.ResponsibilityDataGridViewTextBoxColumn.Name = "ResponsibilityDataGridViewTextBoxColumn"
        Me.ResponsibilityDataGridViewTextBoxColumn.ReadOnly = True
        Me.ResponsibilityDataGridViewTextBoxColumn.Width = 96
        '
        'RankDataGridViewTextBoxColumn
        '
        Me.RankDataGridViewTextBoxColumn.DataPropertyName = "Rank"
        Me.RankDataGridViewTextBoxColumn.HeaderText = "Rank"
        Me.RankDataGridViewTextBoxColumn.Name = "RankDataGridViewTextBoxColumn"
        Me.RankDataGridViewTextBoxColumn.ReadOnly = True
        Me.RankDataGridViewTextBoxColumn.Width = 58
        '
        'TelBDataGridViewTextBoxColumn
        '
        Me.TelBDataGridViewTextBoxColumn.DataPropertyName = "TelB"
        Me.TelBDataGridViewTextBoxColumn.HeaderText = "TelB"
        Me.TelBDataGridViewTextBoxColumn.Name = "TelBDataGridViewTextBoxColumn"
        Me.TelBDataGridViewTextBoxColumn.ReadOnly = True
        Me.TelBDataGridViewTextBoxColumn.Width = 54
        '
        'FaxDataGridViewTextBoxColumn
        '
        Me.FaxDataGridViewTextBoxColumn.DataPropertyName = "Fax"
        Me.FaxDataGridViewTextBoxColumn.HeaderText = "Fax"
        Me.FaxDataGridViewTextBoxColumn.Name = "FaxDataGridViewTextBoxColumn"
        Me.FaxDataGridViewTextBoxColumn.ReadOnly = True
        Me.FaxDataGridViewTextBoxColumn.Width = 49
        '
        'CellDataGridViewTextBoxColumn
        '
        Me.CellDataGridViewTextBoxColumn.DataPropertyName = "Cell"
        Me.CellDataGridViewTextBoxColumn.HeaderText = "Cell"
        Me.CellDataGridViewTextBoxColumn.Name = "CellDataGridViewTextBoxColumn"
        Me.CellDataGridViewTextBoxColumn.ReadOnly = True
        Me.CellDataGridViewTextBoxColumn.Width = 49
        '
        'EMailDataGridViewTextBoxColumn
        '
        Me.EMailDataGridViewTextBoxColumn.DataPropertyName = "EMail"
        Me.EMailDataGridViewTextBoxColumn.HeaderText = "EMail"
        Me.EMailDataGridViewTextBoxColumn.Name = "EMailDataGridViewTextBoxColumn"
        Me.EMailDataGridViewTextBoxColumn.ReadOnly = True
        Me.EMailDataGridViewTextBoxColumn.Width = 58
        '
        'HRDataGridViewTextBoxColumn
        '
        Me.HRDataGridViewTextBoxColumn.DataPropertyName = "HR"
        Me.HRDataGridViewTextBoxColumn.HeaderText = "HR"
        Me.HRDataGridViewTextBoxColumn.Name = "HRDataGridViewTextBoxColumn"
        Me.HRDataGridViewTextBoxColumn.ReadOnly = True
        Me.HRDataGridViewTextBoxColumn.Width = 48
        '
        'FINDataGridViewTextBoxColumn
        '
        Me.FINDataGridViewTextBoxColumn.DataPropertyName = "FIN"
        Me.FINDataGridViewTextBoxColumn.HeaderText = "FIN"
        Me.FINDataGridViewTextBoxColumn.Name = "FINDataGridViewTextBoxColumn"
        Me.FINDataGridViewTextBoxColumn.ReadOnly = True
        Me.FINDataGridViewTextBoxColumn.Width = 49
        '
        'LOGISDataGridViewTextBoxColumn
        '
        Me.LOGISDataGridViewTextBoxColumn.DataPropertyName = "LOGIS"
        Me.LOGISDataGridViewTextBoxColumn.HeaderText = "LOGIS"
        Me.LOGISDataGridViewTextBoxColumn.Name = "LOGISDataGridViewTextBoxColumn"
        Me.LOGISDataGridViewTextBoxColumn.ReadOnly = True
        Me.LOGISDataGridViewTextBoxColumn.Width = 64
        '
        'GFSDataGridViewTextBoxColumn
        '
        Me.GFSDataGridViewTextBoxColumn.DataPropertyName = "GFS"
        Me.GFSDataGridViewTextBoxColumn.HeaderText = "GFS"
        Me.GFSDataGridViewTextBoxColumn.Name = "GFSDataGridViewTextBoxColumn"
        Me.GFSDataGridViewTextBoxColumn.ReadOnly = True
        Me.GFSDataGridViewTextBoxColumn.Width = 53
        '
        'DPSADataGridViewTextBoxColumn
        '
        Me.DPSADataGridViewTextBoxColumn.DataPropertyName = "DPSA"
        Me.DPSADataGridViewTextBoxColumn.HeaderText = "DPSA"
        Me.DPSADataGridViewTextBoxColumn.Name = "DPSADataGridViewTextBoxColumn"
        Me.DPSADataGridViewTextBoxColumn.ReadOnly = True
        Me.DPSADataGridViewTextBoxColumn.Width = 61
        '
        'NotesDataGridViewTextBoxColumn
        '
        Me.NotesDataGridViewTextBoxColumn.DataPropertyName = "Notes"
        Me.NotesDataGridViewTextBoxColumn.HeaderText = "Notes"
        Me.NotesDataGridViewTextBoxColumn.Name = "NotesDataGridViewTextBoxColumn"
        Me.NotesDataGridViewTextBoxColumn.ReadOnly = True
        Me.NotesDataGridViewTextBoxColumn.Width = 60
        '
        'DoneDataGridViewTextBoxColumn
        '
        Me.DoneDataGridViewTextBoxColumn.DataPropertyName = "Done"
        Me.DoneDataGridViewTextBoxColumn.HeaderText = "Done"
        Me.DoneDataGridViewTextBoxColumn.Name = "DoneDataGridViewTextBoxColumn"
        Me.DoneDataGridViewTextBoxColumn.ReadOnly = True
        Me.DoneDataGridViewTextBoxColumn.Width = 58
        '
        'ResetDataGridViewCheckBoxColumn
        '
        Me.ResetDataGridViewCheckBoxColumn.DataPropertyName = "Reset"
        Me.ResetDataGridViewCheckBoxColumn.HeaderText = "Reset"
        Me.ResetDataGridViewCheckBoxColumn.Name = "ResetDataGridViewCheckBoxColumn"
        Me.ResetDataGridViewCheckBoxColumn.ReadOnly = True
        Me.ResetDataGridViewCheckBoxColumn.Width = 41
        '
        'CreatedDataGridViewTextBoxColumn
        '
        Me.CreatedDataGridViewTextBoxColumn.DataPropertyName = "Created"
        Me.CreatedDataGridViewTextBoxColumn.HeaderText = "Created"
        Me.CreatedDataGridViewTextBoxColumn.Name = "CreatedDataGridViewTextBoxColumn"
        Me.CreatedDataGridViewTextBoxColumn.ReadOnly = True
        Me.CreatedDataGridViewTextBoxColumn.Width = 69
        '
        'ExportedDataGridViewTextBoxColumn
        '
        Me.ExportedDataGridViewTextBoxColumn.DataPropertyName = "Exported"
        Me.ExportedDataGridViewTextBoxColumn.HeaderText = "Exported"
        Me.ExportedDataGridViewTextBoxColumn.Name = "ExportedDataGridViewTextBoxColumn"
        Me.ExportedDataGridViewTextBoxColumn.ReadOnly = True
        Me.ExportedDataGridViewTextBoxColumn.Width = 74
        '
        'DownloadedByDataGridViewTextBoxColumn
        '
        Me.DownloadedByDataGridViewTextBoxColumn.DataPropertyName = "DownloadedBy"
        Me.DownloadedByDataGridViewTextBoxColumn.HeaderText = "DownloadedBy"
        Me.DownloadedByDataGridViewTextBoxColumn.Name = "DownloadedByDataGridViewTextBoxColumn"
        Me.DownloadedByDataGridViewTextBoxColumn.ReadOnly = True
        Me.DownloadedByDataGridViewTextBoxColumn.Width = 104
        '
        'VIP_USERS_ResetPasswordBindingSource
        '
        Me.VIP_USERS_ResetPasswordBindingSource.DataMember = "VIP_USERS_ResetPassword"
        Me.VIP_USERS_ResetPasswordBindingSource.DataSource = Me.Ads
        '
        'Ads
        '
        Me.Ads.DataSetName = "ads"
        Me.Ads.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VIP_USERS_ResetPasswordTableAdapter
        '
        Me.VIP_USERS_ResetPasswordTableAdapter.ClearBeforeFill = True
        '
        'frmResetPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(845, 662)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmResetPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reset Password Requests"
        CType(Me.VIP_USERS_ResetPasswordBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VIP_USERS_ResetPasswordBindingNavigator.ResumeLayout(False)
        Me.VIP_USERS_ResetPasswordBindingNavigator.PerformLayout()
        CType(Me.VIP_USERS_ResetPasswordDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.VIP_USERS_ResetPasswordBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ads, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Ads As Global.ADAdminDotNet.dsADS
    Friend WithEvents VIP_USERS_ResetPasswordBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VIP_USERS_ResetPasswordTableAdapter As Global.ADAdminDotNet.dsADSTableAdapters.VIP_USERS_ResetPasswordTableAdapter
    Friend WithEvents VIP_USERS_ResetPasswordBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents VIP_USERS_ResetPasswordBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents VIP_USERS_ResetPasswordDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents FlagSuspiciousRemoveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CancelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ExportToExcelOpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ExportFlagged3ToCSVToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PersalNrDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProvinceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeptDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SurnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ResponsibilityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RankDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelBDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FaxDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CellDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EMailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HRDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FINDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LOGISDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GFSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DPSADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NotesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DoneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ResetDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents CreatedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExportedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DownloadedByDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
