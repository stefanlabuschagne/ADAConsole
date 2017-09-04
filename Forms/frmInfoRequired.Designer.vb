
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInfoRequired
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInfoRequired))
        Me.InfoReqMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CLoseThisRemedyRequest = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.NoCFOLetterReceivedInTimeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ExportToExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExportEstablishementxlsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExportCFOApprovalsOutstandingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsInfoRequiredLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.LOG_IN_Request_TrackingBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.LOG_IN_Request_TrackingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ARSystemDataSet = New ADAdminDotNet.dsARSystemDataSet()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.LOG_IN_Request_TrackingDataGridView = New System.Windows.Forms.DataGridView()
        Me.LOGINRequestTracking2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RemedyOpenRequestsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VIEW_CFO_RULES_FLAGS_OUTSTANDINGBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LOG_IN_Request_TrackingTableAdapter = New ADAdminDotNet.dsARSystemDataSetTableAdapters.LOG_IN_Request_TrackingTableAdapter()
        Me.VIEW_CFO_RULES_FLAGS_OUTSTANDINGTableAdapter = New ADAdminDotNet.dsARSystemDataSetTableAdapters.VIEW_CFO_RULES_FLAGS_OUTSTANDINGTableAdapter()
        Me.RemedyOpenRequestsTableAdapter = New ADAdminDotNet.dsARSystemDataSetTableAdapters.RemedyOpenRequestsTableAdapter()
        Me.EstablishmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ads = New ADAdminDotNet.dsADS()
        Me.Ta_Establishment = New ADAdminDotNet.dsADSTableAdapters.ta_Establishment()
        Me.LOGDMCustomerInformation1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LOG_DM_Customer_Information1TableAdapter = New ADAdminDotNet.dsARSystemDataSetTableAdapters.LOG_DM_Customer_Information1TableAdapter()
        Me.LOG_IN_Request_Tracking2TableAdapter = New ADAdminDotNet.dsARSystemDataSetTableAdapters.LOG_IN_Request_Tracking2TableAdapter()
        Me.Request_No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Persal_Number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Solution = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.First_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Last_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Department_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Captured = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Due = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Long_Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Group_x = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InfoReqMenu.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.LOG_IN_Request_TrackingBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LOG_IN_Request_TrackingBindingNavigator.SuspendLayout()
        CType(Me.LOG_IN_Request_TrackingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ARSystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOG_IN_Request_TrackingDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOGINRequestTracking2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RemedyOpenRequestsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VIEW_CFO_RULES_FLAGS_OUTSTANDINGBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstablishmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ads, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOGDMCustomerInformation1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InfoReqMenu
        '
        Me.InfoReqMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CLoseThisRemedyRequest, Me.ToolStripMenuItem2, Me.NoCFOLetterReceivedInTimeToolStripMenuItem})
        Me.InfoReqMenu.Name = "InfoReqMenu"
        Me.InfoReqMenu.Size = New System.Drawing.Size(237, 54)
        '
        'CLoseThisRemedyRequest
        '
        Me.CLoseThisRemedyRequest.Name = "CLoseThisRemedyRequest"
        Me.CLoseThisRemedyRequest.Size = New System.Drawing.Size(236, 22)
        Me.CLoseThisRemedyRequest.Text = "Close this Remedy Request"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(233, 6)
        '
        'NoCFOLetterReceivedInTimeToolStripMenuItem
        '
        Me.NoCFOLetterReceivedInTimeToolStripMenuItem.Name = "NoCFOLetterReceivedInTimeToolStripMenuItem"
        Me.NoCFOLetterReceivedInTimeToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.NoCFOLetterReceivedInTimeToolStripMenuItem.Text = "No CFO Letter received in time"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1, Me.tsInfoRequiredLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 657)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode
        Me.StatusStrip1.Size = New System.Drawing.Size(795, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportToExcelToolStripMenuItem, Me.ToolStripMenuItem1, Me.ExportEstablishementxlsToolStripMenuItem, Me.ToolStripMenuItem3, Me.ExportCFOApprovalsOutstandingToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(80, 20)
        Me.ToolStripDropDownButton1.Text = "Export Data"
        '
        'ExportToExcelToolStripMenuItem
        '
        Me.ExportToExcelToolStripMenuItem.Name = "ExportToExcelToolStripMenuItem"
        Me.ExportToExcelToolStripMenuItem.Size = New System.Drawing.Size(296, 22)
        Me.ExportToExcelToolStripMenuItem.Text = "Export to InfoRequired.csv"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(293, 6)
        '
        'ExportEstablishementxlsToolStripMenuItem
        '
        Me.ExportEstablishementxlsToolStripMenuItem.Name = "ExportEstablishementxlsToolStripMenuItem"
        Me.ExportEstablishementxlsToolStripMenuItem.Size = New System.Drawing.Size(296, 22)
        Me.ExportEstablishementxlsToolStripMenuItem.Text = "Export to ExportedEstabQuery.csv"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(293, 6)
        '
        'ExportCFOApprovalsOutstandingToolStripMenuItem
        '
        Me.ExportCFOApprovalsOutstandingToolStripMenuItem.Name = "ExportCFOApprovalsOutstandingToolStripMenuItem"
        Me.ExportCFOApprovalsOutstandingToolStripMenuItem.Size = New System.Drawing.Size(296, 22)
        Me.ExportCFOApprovalsOutstandingToolStripMenuItem.Text = "Export to CFO_Approvals_Outstanding.csv"
        '
        'tsInfoRequiredLabel
        '
        Me.tsInfoRequiredLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.tsInfoRequiredLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tsInfoRequiredLabel.Name = "tsInfoRequiredLabel"
        Me.tsInfoRequiredLabel.Size = New System.Drawing.Size(120, 17)
        Me.tsInfoRequiredLabel.Text = "tsInfoRequiredLabel"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'LOG_IN_Request_TrackingBindingNavigator
        '
        Me.LOG_IN_Request_TrackingBindingNavigator.AddNewItem = Nothing
        Me.LOG_IN_Request_TrackingBindingNavigator.BindingSource = Me.LOG_IN_Request_TrackingBindingSource
        Me.LOG_IN_Request_TrackingBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.LOG_IN_Request_TrackingBindingNavigator.DeleteItem = Nothing
        Me.LOG_IN_Request_TrackingBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.ToolStripSeparator1, Me.ToolStripButton1})
        Me.LOG_IN_Request_TrackingBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.LOG_IN_Request_TrackingBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.LOG_IN_Request_TrackingBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.LOG_IN_Request_TrackingBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.LOG_IN_Request_TrackingBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.LOG_IN_Request_TrackingBindingNavigator.Name = "LOG_IN_Request_TrackingBindingNavigator"
        Me.LOG_IN_Request_TrackingBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.LOG_IN_Request_TrackingBindingNavigator.Size = New System.Drawing.Size(795, 25)
        Me.LOG_IN_Request_TrackingBindingNavigator.TabIndex = 0
        Me.LOG_IN_Request_TrackingBindingNavigator.Text = "BindingNavigator1"
        '
        'LOG_IN_Request_TrackingBindingSource
        '
        Me.LOG_IN_Request_TrackingBindingSource.DataMember = "LOG_IN_Request_Tracking"
        Me.LOG_IN_Request_TrackingBindingSource.DataSource = Me.ARSystemDataSet
        '
        'ARSystemDataSet
        '
        Me.ARSystemDataSet.DataSetName = "ARSystemDataSet"
        Me.ARSystemDataSet.EnforceConstraints = False
        Me.ARSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(66, 22)
        Me.ToolStripButton1.Text = "Refresh"
        '
        'LOG_IN_Request_TrackingDataGridView
        '
        Me.LOG_IN_Request_TrackingDataGridView.AllowUserToAddRows = False
        Me.LOG_IN_Request_TrackingDataGridView.AllowUserToDeleteRows = False
        Me.LOG_IN_Request_TrackingDataGridView.AutoGenerateColumns = False
        Me.LOG_IN_Request_TrackingDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader
        Me.LOG_IN_Request_TrackingDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        Me.LOG_IN_Request_TrackingDataGridView.CausesValidation = False
        Me.LOG_IN_Request_TrackingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LOG_IN_Request_TrackingDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Request_No, Me.Persal_Number, Me.Solution, Me.First_Name, Me.Last_Name, Me.Department_Name, Me.DataGridViewTextBoxColumn1, Me.Captured, Me.Due, Me.Long_Description, Me.Group_x})
        Me.LOG_IN_Request_TrackingDataGridView.ContextMenuStrip = Me.InfoReqMenu
        Me.LOG_IN_Request_TrackingDataGridView.DataSource = Me.LOGINRequestTracking2BindingSource
        Me.LOG_IN_Request_TrackingDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LOG_IN_Request_TrackingDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.LOG_IN_Request_TrackingDataGridView.MultiSelect = False
        Me.LOG_IN_Request_TrackingDataGridView.Name = "LOG_IN_Request_TrackingDataGridView"
        Me.LOG_IN_Request_TrackingDataGridView.ReadOnly = True
        Me.LOG_IN_Request_TrackingDataGridView.RowHeadersWidth = 4
        Me.LOG_IN_Request_TrackingDataGridView.ShowEditingIcon = False
        Me.LOG_IN_Request_TrackingDataGridView.ShowRowErrors = False
        Me.LOG_IN_Request_TrackingDataGridView.Size = New System.Drawing.Size(795, 632)
        Me.LOG_IN_Request_TrackingDataGridView.TabIndex = 1
        '
        'LOGINRequestTracking2BindingSource
        '
        Me.LOGINRequestTracking2BindingSource.DataMember = "LOG_IN_Request_Tracking2"
        Me.LOGINRequestTracking2BindingSource.DataSource = Me.ARSystemDataSet
        '
        'RemedyOpenRequestsBindingSource
        '
        Me.RemedyOpenRequestsBindingSource.DataMember = "RemedyOpenRequests"
        Me.RemedyOpenRequestsBindingSource.DataSource = Me.ARSystemDataSet
        '
        'VIEW_CFO_RULES_FLAGS_OUTSTANDINGBindingSource
        '
        Me.VIEW_CFO_RULES_FLAGS_OUTSTANDINGBindingSource.DataMember = "VIEW_CFO_RULES_FLAGS_OUTSTANDING"
        Me.VIEW_CFO_RULES_FLAGS_OUTSTANDINGBindingSource.DataSource = Me.ARSystemDataSet
        '
        'LOG_IN_Request_TrackingTableAdapter
        '
        Me.LOG_IN_Request_TrackingTableAdapter.ClearBeforeFill = True
        '
        'VIEW_CFO_RULES_FLAGS_OUTSTANDINGTableAdapter
        '
        Me.VIEW_CFO_RULES_FLAGS_OUTSTANDINGTableAdapter.ClearBeforeFill = True
        '
        'RemedyOpenRequestsTableAdapter
        '
        Me.RemedyOpenRequestsTableAdapter.ClearBeforeFill = True
        '
        'EstablishmentBindingSource
        '
        Me.EstablishmentBindingSource.DataMember = "Establishment"
        Me.EstablishmentBindingSource.DataSource = Me.Ads
        '
        'Ads
        '
        Me.Ads.DataSetName = "ads"
        Me.Ads.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Ta_Establishment
        '
        Me.Ta_Establishment.ClearBeforeFill = True
        '
        'LOGDMCustomerInformation1BindingSource
        '
        Me.LOGDMCustomerInformation1BindingSource.DataMember = "LOG_DM_Customer_Information1"
        Me.LOGDMCustomerInformation1BindingSource.DataSource = Me.ARSystemDataSet
        '
        'LOG_DM_Customer_Information1TableAdapter
        '
        Me.LOG_DM_Customer_Information1TableAdapter.ClearBeforeFill = True
        '
        'LOG_IN_Request_Tracking2TableAdapter
        '
        Me.LOG_IN_Request_Tracking2TableAdapter.ClearBeforeFill = True
        '
        'Request_No
        '
        Me.Request_No.DataPropertyName = "Request_No"
        Me.Request_No.HeaderText = "Request No"
        Me.Request_No.Name = "Request_No"
        Me.Request_No.ReadOnly = True
        Me.Request_No.Width = 5
        '
        'Persal_Number
        '
        Me.Persal_Number.DataPropertyName = "Persal_Number"
        Me.Persal_Number.HeaderText = "Persal Number"
        Me.Persal_Number.Name = "Persal_Number"
        Me.Persal_Number.ReadOnly = True
        Me.Persal_Number.Width = 5
        '
        'Solution
        '
        Me.Solution.DataPropertyName = "Solution"
        Me.Solution.HeaderText = "Solution"
        Me.Solution.Name = "Solution"
        Me.Solution.ReadOnly = True
        Me.Solution.Width = 5
        '
        'First_Name
        '
        Me.First_Name.DataPropertyName = "First_Name"
        Me.First_Name.HeaderText = "First Name"
        Me.First_Name.Name = "First_Name"
        Me.First_Name.ReadOnly = True
        Me.First_Name.Width = 5
        '
        'Last_Name
        '
        Me.Last_Name.DataPropertyName = "Last_Name"
        Me.Last_Name.HeaderText = "Last Name"
        Me.Last_Name.Name = "Last_Name"
        Me.Last_Name.ReadOnly = True
        Me.Last_Name.Width = 5
        '
        'Department_Name
        '
        Me.Department_Name.DataPropertyName = "Department_Name"
        Me.Department_Name.HeaderText = "Department Name"
        Me.Department_Name.Name = "Department_Name"
        Me.Department_Name.ReadOnly = True
        Me.Department_Name.Width = 5
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Department_Name"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Department Name"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 5
        '
        'Captured
        '
        Me.Captured.DataPropertyName = "Captured"
        Me.Captured.HeaderText = "Captured"
        Me.Captured.Name = "Captured"
        Me.Captured.ReadOnly = True
        Me.Captured.Width = 5
        '
        'Due
        '
        Me.Due.DataPropertyName = "Due"
        Me.Due.HeaderText = "Due"
        Me.Due.Name = "Due"
        Me.Due.ReadOnly = True
        Me.Due.Width = 5
        '
        'Long_Description
        '
        Me.Long_Description.DataPropertyName = "Long_Description"
        Me.Long_Description.HeaderText = "Long Description"
        Me.Long_Description.Name = "Long_Description"
        Me.Long_Description.ReadOnly = True
        Me.Long_Description.Width = 5
        '
        'Group_x
        '
        Me.Group_x.DataPropertyName = "Group_x"
        Me.Group_x.HeaderText = "Group_x"
        Me.Group_x.Name = "Group_x"
        Me.Group_x.ReadOnly = True
        Me.Group_x.Width = 5
        '
        'frmInfoRequired
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(795, 679)
        Me.Controls.Add(Me.LOG_IN_Request_TrackingDataGridView)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.LOG_IN_Request_TrackingBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmInfoRequired"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Info Required / Refer to Client"
        Me.InfoReqMenu.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.LOG_IN_Request_TrackingBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LOG_IN_Request_TrackingBindingNavigator.ResumeLayout(False)
        Me.LOG_IN_Request_TrackingBindingNavigator.PerformLayout()
        CType(Me.LOG_IN_Request_TrackingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ARSystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOG_IN_Request_TrackingDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOGINRequestTracking2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RemedyOpenRequestsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VIEW_CFO_RULES_FLAGS_OUTSTANDINGBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstablishmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ads, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOGDMCustomerInformation1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ARSystemDataSet As Global.ADAdminDotNet.dsARSystemDataSet
    Friend WithEvents LOG_IN_Request_TrackingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LOG_IN_Request_TrackingTableAdapter As Global.ADAdminDotNet.dsARSystemDataSetTableAdapters.LOG_IN_Request_TrackingTableAdapter
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ExportToExcelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExportEstablishementxlsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Ads As Global.ADAdminDotNet.dsADS
    Friend WithEvents EstablishmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ta_Establishment As Global.ADAdminDotNet.dsADSTableAdapters.ta_Establishment
    Friend WithEvents InfoReqMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CLoseThisRemedyRequest As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NoCFOLetterReceivedInTimeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExportCFOApprovalsOutstandingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents LOG_IN_Request_TrackingBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents VIEW_CFO_RULES_FLAGS_OUTSTANDINGBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VIEW_CFO_RULES_FLAGS_OUTSTANDINGTableAdapter As Global.ADAdminDotNet.dsARSystemDataSetTableAdapters.VIEW_CFO_RULES_FLAGS_OUTSTANDINGTableAdapter
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents LOG_IN_Request_TrackingDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents tsInfoRequiredLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents RequestNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PersalNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DepartmentNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LongDescriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DepartmentTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EMailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RemedyOpenRequestsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RemedyOpenRequestsTableAdapter As ADAdminDotNet.dsARSystemDataSetTableAdapters.RemedyOpenRequestsTableAdapter
    Friend WithEvents LOGDMCustomerInformation1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LOG_DM_Customer_Information1TableAdapter As ADAdminDotNet.dsARSystemDataSetTableAdapters.LOG_DM_Customer_Information1TableAdapter
    Friend WithEvents LOGINRequestTracking2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LOG_IN_Request_Tracking2TableAdapter As ADAdminDotNet.dsARSystemDataSetTableAdapters.LOG_IN_Request_Tracking2TableAdapter
    Friend WithEvents Request_No As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Persal_Number As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Solution As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents First_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Last_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Department_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Captured As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Due As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Long_Description As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Group_x As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
