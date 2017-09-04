<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReferrals
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReferrals))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.CFOApprovalBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.RULES_FLAGSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsADS = New ADAdminDotNet.dsADS()
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
        Me.CFOApprovalBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.btnRefresh = New System.Windows.Forms.ToolStripButton()
        Me.CFOApprovalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddAVulindlelaCommentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MarkThisEntryAsPROFILEDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RollbackClosedReferralToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.CancelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LOG_IN_Request_TrackingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsARSystemDataSet = New ADAdminDotNet.dsARSystemDataSet()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ExportToExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsLblReferredPerson = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LOG_IN_Request_TrackingTableAdapter = New ADAdminDotNet.dsARSystemDataSetTableAdapters.LOG_IN_Request_TrackingTableAdapter()
        Me.CFOApprovalDataGridView = New System.Windows.Forms.DataGridView()
        Me.RequestNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CFOApproval_ta = New ADAdminDotNet.dsADSTableAdapters.CFOApproval_ta()
        Me.RULES_FLAGSTableAdapter = New ADAdminDotNet.dsADSTableAdapters.RULES_FLAGSTableAdapter()
        CType(Me.CFOApprovalBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CFOApprovalBindingNavigator.SuspendLayout()
        CType(Me.RULES_FLAGSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsADS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CFOApprovalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.LOG_IN_Request_TrackingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsARSystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.CFOApprovalDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CFOApprovalBindingNavigator
        '
        Me.CFOApprovalBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CFOApprovalBindingNavigator.BindingSource = Me.RULES_FLAGSBindingSource
        Me.CFOApprovalBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CFOApprovalBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CFOApprovalBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CFOApprovalBindingNavigatorSaveItem, Me.btnRefresh})
        Me.CFOApprovalBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CFOApprovalBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CFOApprovalBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CFOApprovalBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CFOApprovalBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CFOApprovalBindingNavigator.Name = "CFOApprovalBindingNavigator"
        Me.CFOApprovalBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CFOApprovalBindingNavigator.Size = New System.Drawing.Size(878, 28)
        Me.CFOApprovalBindingNavigator.TabIndex = 0
        Me.CFOApprovalBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Margin = New System.Windows.Forms.Padding(2)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.Padding = New System.Windows.Forms.Padding(2)
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        Me.BindingNavigatorAddNewItem.Visible = False
        '
        'RULES_FLAGSBindingSource
        '
        Me.RULES_FLAGSBindingSource.DataMember = "RULES_FLAGS"
        Me.RULES_FLAGSBindingSource.DataSource = Me.DsADS
        '
        'DsADS
        '
        Me.DsADS.DataSetName = "dsADS"
        Me.DsADS.EnforceConstraints = False
        Me.DsADS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Margin = New System.Windows.Forms.Padding(2)
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Padding = New System.Windows.Forms.Padding(2)
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(39, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Margin = New System.Windows.Forms.Padding(2)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.Padding = New System.Windows.Forms.Padding(2)
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        Me.BindingNavigatorDeleteItem.Visible = False
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Margin = New System.Windows.Forms.Padding(2)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.Padding = New System.Windows.Forms.Padding(2)
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Margin = New System.Windows.Forms.Padding(2)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.Padding = New System.Windows.Forms.Padding(2)
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Margin = New System.Windows.Forms.Padding(2)
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Padding = New System.Windows.Forms.Padding(2)
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 24)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Margin = New System.Windows.Forms.Padding(2)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Padding = New System.Windows.Forms.Padding(2)
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Margin = New System.Windows.Forms.Padding(2)
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Padding = New System.Windows.Forms.Padding(2)
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 24)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Margin = New System.Windows.Forms.Padding(2)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.Padding = New System.Windows.Forms.Padding(2)
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Margin = New System.Windows.Forms.Padding(2)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.Padding = New System.Windows.Forms.Padding(2)
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Margin = New System.Windows.Forms.Padding(2)
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Padding = New System.Windows.Forms.Padding(2)
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 24)
        '
        'CFOApprovalBindingNavigatorSaveItem
        '
        Me.CFOApprovalBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CFOApprovalBindingNavigatorSaveItem.Enabled = False
        Me.CFOApprovalBindingNavigatorSaveItem.Image = CType(resources.GetObject("CFOApprovalBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CFOApprovalBindingNavigatorSaveItem.Margin = New System.Windows.Forms.Padding(2)
        Me.CFOApprovalBindingNavigatorSaveItem.Name = "CFOApprovalBindingNavigatorSaveItem"
        Me.CFOApprovalBindingNavigatorSaveItem.Padding = New System.Windows.Forms.Padding(2)
        Me.CFOApprovalBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 24)
        Me.CFOApprovalBindingNavigatorSaveItem.Text = "Save Data"
        Me.CFOApprovalBindingNavigatorSaveItem.Visible = False
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnRefresh.Image = Global.ADAdminDotNet.My.Resources.Resources.imgICO_shell320044
        Me.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRefresh.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Padding = New System.Windows.Forms.Padding(2)
        Me.btnRefresh.Size = New System.Drawing.Size(75, 24)
        Me.btnRefresh.Text = "Refresh"
        '
        'CFOApprovalBindingSource
        '
        Me.CFOApprovalBindingSource.DataMember = "CFOApproval"
        Me.CFOApprovalBindingSource.DataSource = Me.DsADS
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddAVulindlelaCommentToolStripMenuItem, Me.ToolStripMenuItem2, Me.MarkThisEntryAsPROFILEDToolStripMenuItem, Me.ToolStripMenuItem1, Me.RollbackClosedReferralToolStripMenuItem, Me.ToolStripMenuItem3, Me.CancelToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(302, 110)
        '
        'AddAVulindlelaCommentToolStripMenuItem
        '
        Me.AddAVulindlelaCommentToolStripMenuItem.Name = "AddAVulindlelaCommentToolStripMenuItem"
        Me.AddAVulindlelaCommentToolStripMenuItem.Size = New System.Drawing.Size(301, 22)
        Me.AddAVulindlelaCommentToolStripMenuItem.Text = "Add a Vulindlela Comment "
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(298, 6)
        '
        'MarkThisEntryAsPROFILEDToolStripMenuItem
        '
        Me.MarkThisEntryAsPROFILEDToolStripMenuItem.Name = "MarkThisEntryAsPROFILEDToolStripMenuItem"
        Me.MarkThisEntryAsPROFILEDToolStripMenuItem.Size = New System.Drawing.Size(301, 22)
        Me.MarkThisEntryAsPROFILEDToolStripMenuItem.Text = "Mark this Entry as [PROFILED by Vulindlela]"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(298, 6)
        '
        'RollbackClosedReferralToolStripMenuItem
        '
        Me.RollbackClosedReferralToolStripMenuItem.Name = "RollbackClosedReferralToolStripMenuItem"
        Me.RollbackClosedReferralToolStripMenuItem.Size = New System.Drawing.Size(301, 22)
        Me.RollbackClosedReferralToolStripMenuItem.Text = "Rollback Closed Referral"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(298, 6)
        '
        'CancelToolStripMenuItem
        '
        Me.CancelToolStripMenuItem.Name = "CancelToolStripMenuItem"
        Me.CancelToolStripMenuItem.Size = New System.Drawing.Size(301, 22)
        Me.CancelToolStripMenuItem.Text = "Cancel"
        '
        'LOG_IN_Request_TrackingBindingSource
        '
        Me.LOG_IN_Request_TrackingBindingSource.DataMember = "LOG_IN_Request_Tracking"
        Me.LOG_IN_Request_TrackingBindingSource.DataSource = Me.DsARSystemDataSet
        '
        'DsARSystemDataSet
        '
        Me.DsARSystemDataSet.DataSetName = "dsARSystemDataSet"
        Me.DsARSystemDataSet.EnforceConstraints = False
        Me.DsARSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1, Me.tsLblReferredPerson})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 563)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode
        Me.StatusStrip1.Size = New System.Drawing.Size(878, 24)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportToExcelToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(80, 22)
        Me.ToolStripDropDownButton1.Text = "Export Data"
        '
        'ExportToExcelToolStripMenuItem
        '
        Me.ExportToExcelToolStripMenuItem.Name = "ExportToExcelToolStripMenuItem"
        Me.ExportToExcelToolStripMenuItem.Size = New System.Drawing.Size(273, 22)
        Me.ExportToExcelToolStripMenuItem.Text = "Export to Open_Remedy_Requests.csv"
        '
        'tsLblReferredPerson
        '
        Me.tsLblReferredPerson.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.tsLblReferredPerson.ForeColor = System.Drawing.Color.DarkBlue
        Me.tsLblReferredPerson.Name = "tsLblReferredPerson"
        Me.tsLblReferredPerson.Padding = New System.Windows.Forms.Padding(2)
        Me.tsLblReferredPerson.Size = New System.Drawing.Size(126, 19)
        Me.tsLblReferredPerson.Text = "tsLblReferredPerson"
        '
        'LOG_IN_Request_TrackingTableAdapter
        '
        Me.LOG_IN_Request_TrackingTableAdapter.ClearBeforeFill = True
        '
        'CFOApprovalDataGridView
        '
        Me.CFOApprovalDataGridView.AllowUserToAddRows = False
        Me.CFOApprovalDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CFOApprovalDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.CFOApprovalDataGridView.AutoGenerateColumns = False
        Me.CFOApprovalDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.CFOApprovalDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.CFOApprovalDataGridView.CausesValidation = False
        Me.CFOApprovalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CFOApprovalDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RequestNo, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewCheckBoxColumn2})
        Me.CFOApprovalDataGridView.ContextMenuStrip = Me.ContextMenuStrip1
        Me.CFOApprovalDataGridView.DataSource = Me.CFOApprovalBindingSource
        Me.CFOApprovalDataGridView.Location = New System.Drawing.Point(0, 28)
        Me.CFOApprovalDataGridView.Margin = New System.Windows.Forms.Padding(2)
        Me.CFOApprovalDataGridView.MultiSelect = False
        Me.CFOApprovalDataGridView.Name = "CFOApprovalDataGridView"
        Me.CFOApprovalDataGridView.ReadOnly = True
        Me.CFOApprovalDataGridView.RowHeadersWidth = 4
        Me.CFOApprovalDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CFOApprovalDataGridView.ShowCellErrors = False
        Me.CFOApprovalDataGridView.ShowEditingIcon = False
        Me.CFOApprovalDataGridView.ShowRowErrors = False
        Me.CFOApprovalDataGridView.Size = New System.Drawing.Size(878, 535)
        Me.CFOApprovalDataGridView.TabIndex = 3
        '
        'RequestNo
        '
        Me.RequestNo.DataPropertyName = "RequestNo"
        Me.RequestNo.HeaderText = "RequestNo"
        Me.RequestNo.Name = "RequestNo"
        Me.RequestNo.ReadOnly = True
        Me.RequestNo.Width = 86
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "FlowDescription"
        Me.DataGridViewTextBoxColumn2.HeaderText = "FlowDescription"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 107
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CFODate"
        Me.DataGridViewTextBoxColumn3.HeaderText = "CFODate"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 76
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "CFOComments"
        Me.DataGridViewTextBoxColumn4.HeaderText = "CFOComments"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 102
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "NTDate"
        Me.DataGridViewTextBoxColumn5.HeaderText = "NTDate"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 70
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "NTComments"
        Me.DataGridViewTextBoxColumn6.HeaderText = "NTComments"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 96
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "VulCompleted"
        Me.DataGridViewTextBoxColumn7.HeaderText = "VulCompleted"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 97
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "VULComments"
        Me.DataGridViewTextBoxColumn8.HeaderText = "VULComments"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 102
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Isrunning"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Isrunning"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        Me.DataGridViewCheckBoxColumn1.Width = 56
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "Active"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "Active"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.ReadOnly = True
        Me.DataGridViewCheckBoxColumn2.Width = 43
        '
        'CFOApproval_ta
        '
        Me.CFOApproval_ta.ClearBeforeFill = True
        '
        'RULES_FLAGSTableAdapter
        '
        Me.RULES_FLAGSTableAdapter.ClearBeforeFill = True
        '
        'frmReferrals
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(878, 587)
        Me.Controls.Add(Me.CFOApprovalDataGridView)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.CFOApprovalBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmReferrals"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Referred"
        CType(Me.CFOApprovalBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CFOApprovalBindingNavigator.ResumeLayout(False)
        Me.CFOApprovalBindingNavigator.PerformLayout()
        CType(Me.RULES_FLAGSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsADS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CFOApprovalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.LOG_IN_Request_TrackingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsARSystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.CFOApprovalDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DsADS As Global.ADAdminDotNet.dsADS
    Friend WithEvents CFOApprovalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CFOApproval_ta As Global.ADAdminDotNet.dsADSTableAdapters.CFOApproval_ta
    Friend WithEvents CFOApprovalBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents CFOApprovalBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ExportToExcelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DsARSystemDataSet As Global.ADAdminDotNet.dsARSystemDataSet
    Friend WithEvents LOG_IN_Request_TrackingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LOG_IN_Request_TrackingTableAdapter As Global.ADAdminDotNet.dsARSystemDataSetTableAdapters.LOG_IN_Request_TrackingTableAdapter
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MarkThisEntryAsPROFILEDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CancelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RULES_FLAGSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RULES_FLAGSTableAdapter As Global.ADAdminDotNet.dsADSTableAdapters.RULES_FLAGSTableAdapter
    Friend WithEvents CFOApprovalDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents RequestNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents btnRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents AddAVulindlelaCommentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RollbackClosedReferralToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsLblReferredPerson As System.Windows.Forms.ToolStripStatusLabel
End Class
