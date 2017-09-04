<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRequestTracking
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRequestTracking))
        Me.LOG_IN_Request_TrackingBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.LOG_IN_Request_TrackingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsARSystemDataSet = New ADAdminDotNet.dsARSystemDataSet()
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
        Me.LOG_IN_Request_TrackingBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.LOG_IN_Request_TrackingDataGridView = New System.Windows.Forms.DataGridView()
        Me.Request_No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Request_Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Request_Category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Submitter = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Assigned_to = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Owner = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Entry_Date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Due_Date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Persal_Number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.First_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Last_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Department_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Long_Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Solution = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Functional_Area = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Group_x = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Department_Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telephone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.E_Mail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Assignee_Group = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Project = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Request_Log = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Request_History = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Request_Source = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Original_Due_Date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Closed_Date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Priority = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Re_Assigned = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Re_Opened = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Last_Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Updated_By = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.System_Group = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Root_Cause = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RequestNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersalNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SolutionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepartmentNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LongDescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupxDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepartmentTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelephoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LOGINRequestTrackingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StatusStrip2 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton()
        Me.ExportToExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExportToXMLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.LOG_IN_Request_TrackingTableAdapter = New ADAdminDotNet.dsARSystemDataSetTableAdapters.LOG_IN_Request_TrackingTableAdapter()
        CType(Me.LOG_IN_Request_TrackingBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LOG_IN_Request_TrackingBindingNavigator.SuspendLayout()
        CType(Me.LOG_IN_Request_TrackingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsARSystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOG_IN_Request_TrackingDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOGINRequestTrackingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'LOG_IN_Request_TrackingBindingNavigator
        '
        Me.LOG_IN_Request_TrackingBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.LOG_IN_Request_TrackingBindingNavigator.BindingSource = Me.LOG_IN_Request_TrackingBindingSource
        Me.LOG_IN_Request_TrackingBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.LOG_IN_Request_TrackingBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.LOG_IN_Request_TrackingBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.LOG_IN_Request_TrackingBindingNavigatorSaveItem})
        Me.LOG_IN_Request_TrackingBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.LOG_IN_Request_TrackingBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.LOG_IN_Request_TrackingBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.LOG_IN_Request_TrackingBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.LOG_IN_Request_TrackingBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.LOG_IN_Request_TrackingBindingNavigator.Name = "LOG_IN_Request_TrackingBindingNavigator"
        Me.LOG_IN_Request_TrackingBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.LOG_IN_Request_TrackingBindingNavigator.Size = New System.Drawing.Size(1045, 25)
        Me.LOG_IN_Request_TrackingBindingNavigator.TabIndex = 0
        Me.LOG_IN_Request_TrackingBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
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
        'LOG_IN_Request_TrackingBindingNavigatorSaveItem
        '
        Me.LOG_IN_Request_TrackingBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.LOG_IN_Request_TrackingBindingNavigatorSaveItem.Enabled = False
        Me.LOG_IN_Request_TrackingBindingNavigatorSaveItem.Image = CType(resources.GetObject("LOG_IN_Request_TrackingBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.LOG_IN_Request_TrackingBindingNavigatorSaveItem.Name = "LOG_IN_Request_TrackingBindingNavigatorSaveItem"
        Me.LOG_IN_Request_TrackingBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.LOG_IN_Request_TrackingBindingNavigatorSaveItem.Text = "Save Data"
        '
        'LOG_IN_Request_TrackingDataGridView
        '
        Me.LOG_IN_Request_TrackingDataGridView.AllowUserToAddRows = False
        Me.LOG_IN_Request_TrackingDataGridView.AllowUserToDeleteRows = False
        Me.LOG_IN_Request_TrackingDataGridView.AllowUserToOrderColumns = True
        Me.LOG_IN_Request_TrackingDataGridView.AutoGenerateColumns = False
        Me.LOG_IN_Request_TrackingDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.LOG_IN_Request_TrackingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LOG_IN_Request_TrackingDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Request_No, Me.Request_Type, Me.Request_Category, Me.Submitter, Me.Assigned_to, Me.Owner, Me.Entry_Date, Me.Due_Date, Me.Status, Me.Persal_Number, Me.First_Name, Me.Last_Name, Me.Department_Name, Me.Long_Description, Me.Solution, Me.Functional_Area, Me.Group_x, Me.Department_Type, Me.Telephone, Me.E_Mail, Me.Assignee_Group, Me.Project, Me.Request_Log, Me.Request_History, Me.Request_Source, Me.Original_Due_Date, Me.Closed_Date, Me.Priority, Me.Re_Assigned, Me.Re_Opened, Me.Last_Status, Me.Updated_By, Me.System_Group, Me.Root_Cause, Me.RequestNoDataGridViewTextBoxColumn, Me.PersalNumberDataGridViewTextBoxColumn, Me.SolutionDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.DepartmentNameDataGridViewTextBoxColumn, Me.LongDescriptionDataGridViewTextBoxColumn, Me.GroupxDataGridViewTextBoxColumn, Me.DepartmentTypeDataGridViewTextBoxColumn, Me.TelephoneDataGridViewTextBoxColumn, Me.EMailDataGridViewTextBoxColumn})
        Me.LOG_IN_Request_TrackingDataGridView.DataSource = Me.LOGINRequestTrackingBindingSource
        Me.LOG_IN_Request_TrackingDataGridView.Location = New System.Drawing.Point(0, 28)
        Me.LOG_IN_Request_TrackingDataGridView.Name = "LOG_IN_Request_TrackingDataGridView"
        Me.LOG_IN_Request_TrackingDataGridView.ReadOnly = True
        Me.LOG_IN_Request_TrackingDataGridView.RowHeadersWidth = 10
        Me.LOG_IN_Request_TrackingDataGridView.Size = New System.Drawing.Size(1025, 650)
        Me.LOG_IN_Request_TrackingDataGridView.TabIndex = 1
        '
        'Request_No
        '
        Me.Request_No.DataPropertyName = "Request_No"
        Me.Request_No.HeaderText = "Request_No"
        Me.Request_No.Name = "Request_No"
        Me.Request_No.ReadOnly = True
        '
        'Request_Type
        '
        Me.Request_Type.DataPropertyName = "Request_Type"
        Me.Request_Type.HeaderText = "Request_Type"
        Me.Request_Type.Name = "Request_Type"
        Me.Request_Type.ReadOnly = True
        '
        'Request_Category
        '
        Me.Request_Category.DataPropertyName = "Request_Category"
        Me.Request_Category.HeaderText = "Request_Category"
        Me.Request_Category.Name = "Request_Category"
        Me.Request_Category.ReadOnly = True
        '
        'Submitter
        '
        Me.Submitter.DataPropertyName = "Submitter"
        Me.Submitter.HeaderText = "Submitter"
        Me.Submitter.Name = "Submitter"
        Me.Submitter.ReadOnly = True
        '
        'Assigned_to
        '
        Me.Assigned_to.DataPropertyName = "Assigned_to"
        Me.Assigned_to.HeaderText = "Assigned_to"
        Me.Assigned_to.Name = "Assigned_to"
        Me.Assigned_to.ReadOnly = True
        '
        'Owner
        '
        Me.Owner.DataPropertyName = "Owner"
        Me.Owner.HeaderText = "Owner"
        Me.Owner.Name = "Owner"
        Me.Owner.ReadOnly = True
        '
        'Entry_Date
        '
        Me.Entry_Date.DataPropertyName = "Entry_Date"
        Me.Entry_Date.HeaderText = "Entry_Date"
        Me.Entry_Date.Name = "Entry_Date"
        Me.Entry_Date.ReadOnly = True
        '
        'Due_Date
        '
        Me.Due_Date.DataPropertyName = "Due_Date"
        Me.Due_Date.HeaderText = "Due_Date"
        Me.Due_Date.Name = "Due_Date"
        Me.Due_Date.ReadOnly = True
        '
        'Status
        '
        Me.Status.DataPropertyName = "Status"
        Me.Status.HeaderText = "Status"
        Me.Status.Name = "Status"
        Me.Status.ReadOnly = True
        Me.Status.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Persal_Number
        '
        Me.Persal_Number.DataPropertyName = "Persal_Number"
        Me.Persal_Number.HeaderText = "Persal_Number"
        Me.Persal_Number.Name = "Persal_Number"
        Me.Persal_Number.ReadOnly = True
        '
        'First_Name
        '
        Me.First_Name.DataPropertyName = "First_Name"
        Me.First_Name.HeaderText = "First_Name"
        Me.First_Name.Name = "First_Name"
        Me.First_Name.ReadOnly = True
        '
        'Last_Name
        '
        Me.Last_Name.DataPropertyName = "Last_Name"
        Me.Last_Name.HeaderText = "Last_Name"
        Me.Last_Name.Name = "Last_Name"
        Me.Last_Name.ReadOnly = True
        '
        'Department_Name
        '
        Me.Department_Name.DataPropertyName = "Department_Name"
        Me.Department_Name.HeaderText = "Department_Name"
        Me.Department_Name.Name = "Department_Name"
        Me.Department_Name.ReadOnly = True
        '
        'Long_Description
        '
        Me.Long_Description.DataPropertyName = "Long_Description"
        Me.Long_Description.HeaderText = "Long_Description"
        Me.Long_Description.Name = "Long_Description"
        Me.Long_Description.ReadOnly = True
        '
        'Solution
        '
        Me.Solution.DataPropertyName = "Solution"
        Me.Solution.HeaderText = "Solution"
        Me.Solution.Name = "Solution"
        Me.Solution.ReadOnly = True
        '
        'Functional_Area
        '
        Me.Functional_Area.DataPropertyName = "Functional_Area"
        Me.Functional_Area.HeaderText = "Functional_Area"
        Me.Functional_Area.Name = "Functional_Area"
        Me.Functional_Area.ReadOnly = True
        '
        'Group_x
        '
        Me.Group_x.DataPropertyName = "Group_x"
        Me.Group_x.HeaderText = "Group_x"
        Me.Group_x.Name = "Group_x"
        Me.Group_x.ReadOnly = True
        '
        'Department_Type
        '
        Me.Department_Type.DataPropertyName = "Department_Type"
        Me.Department_Type.HeaderText = "Department_Type"
        Me.Department_Type.Name = "Department_Type"
        Me.Department_Type.ReadOnly = True
        '
        'Telephone
        '
        Me.Telephone.DataPropertyName = "Telephone"
        Me.Telephone.HeaderText = "Telephone"
        Me.Telephone.Name = "Telephone"
        Me.Telephone.ReadOnly = True
        '
        'E_Mail
        '
        Me.E_Mail.DataPropertyName = "E_Mail"
        Me.E_Mail.HeaderText = "E_Mail"
        Me.E_Mail.Name = "E_Mail"
        Me.E_Mail.ReadOnly = True
        '
        'Assignee_Group
        '
        Me.Assignee_Group.DataPropertyName = "Assignee_Group"
        Me.Assignee_Group.HeaderText = "Assignee_Group"
        Me.Assignee_Group.Name = "Assignee_Group"
        Me.Assignee_Group.ReadOnly = True
        '
        'Project
        '
        Me.Project.DataPropertyName = "Project"
        Me.Project.HeaderText = "Project"
        Me.Project.Name = "Project"
        Me.Project.ReadOnly = True
        '
        'Request_Log
        '
        Me.Request_Log.DataPropertyName = "Request_Log"
        Me.Request_Log.HeaderText = "Request_Log"
        Me.Request_Log.Name = "Request_Log"
        Me.Request_Log.ReadOnly = True
        '
        'Request_History
        '
        Me.Request_History.DataPropertyName = "Request_History"
        Me.Request_History.HeaderText = "Request_History"
        Me.Request_History.Name = "Request_History"
        Me.Request_History.ReadOnly = True
        '
        'Request_Source
        '
        Me.Request_Source.DataPropertyName = "Request_Source"
        Me.Request_Source.HeaderText = "Request_Source"
        Me.Request_Source.Name = "Request_Source"
        Me.Request_Source.ReadOnly = True
        '
        'Original_Due_Date
        '
        Me.Original_Due_Date.DataPropertyName = "Original_Due_Date"
        Me.Original_Due_Date.HeaderText = "Original_Due_Date"
        Me.Original_Due_Date.Name = "Original_Due_Date"
        Me.Original_Due_Date.ReadOnly = True
        '
        'Closed_Date
        '
        Me.Closed_Date.DataPropertyName = "Closed_Date"
        Me.Closed_Date.HeaderText = "Closed_Date"
        Me.Closed_Date.Name = "Closed_Date"
        Me.Closed_Date.ReadOnly = True
        '
        'Priority
        '
        Me.Priority.DataPropertyName = "Priority"
        Me.Priority.HeaderText = "Priority"
        Me.Priority.Name = "Priority"
        Me.Priority.ReadOnly = True
        '
        'Re_Assigned
        '
        Me.Re_Assigned.DataPropertyName = "Re_Assigned"
        Me.Re_Assigned.HeaderText = "Re_Assigned"
        Me.Re_Assigned.Name = "Re_Assigned"
        Me.Re_Assigned.ReadOnly = True
        '
        'Re_Opened
        '
        Me.Re_Opened.DataPropertyName = "Re_Opened"
        Me.Re_Opened.HeaderText = "Re_Opened"
        Me.Re_Opened.Name = "Re_Opened"
        Me.Re_Opened.ReadOnly = True
        '
        'Last_Status
        '
        Me.Last_Status.DataPropertyName = "Last_Status"
        Me.Last_Status.HeaderText = "Last_Status"
        Me.Last_Status.Name = "Last_Status"
        Me.Last_Status.ReadOnly = True
        '
        'Updated_By
        '
        Me.Updated_By.DataPropertyName = "Updated_By"
        Me.Updated_By.HeaderText = "Updated_By"
        Me.Updated_By.Name = "Updated_By"
        Me.Updated_By.ReadOnly = True
        '
        'System_Group
        '
        Me.System_Group.DataPropertyName = "System_Group"
        Me.System_Group.HeaderText = "System_Group"
        Me.System_Group.Name = "System_Group"
        Me.System_Group.ReadOnly = True
        '
        'Root_Cause
        '
        Me.Root_Cause.DataPropertyName = "Root_Cause"
        Me.Root_Cause.HeaderText = "Root_Cause"
        Me.Root_Cause.Name = "Root_Cause"
        Me.Root_Cause.ReadOnly = True
        '
        'RequestNoDataGridViewTextBoxColumn
        '
        Me.RequestNoDataGridViewTextBoxColumn.DataPropertyName = "Request_No"
        Me.RequestNoDataGridViewTextBoxColumn.HeaderText = "Request_No"
        Me.RequestNoDataGridViewTextBoxColumn.Name = "RequestNoDataGridViewTextBoxColumn"
        Me.RequestNoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PersalNumberDataGridViewTextBoxColumn
        '
        Me.PersalNumberDataGridViewTextBoxColumn.DataPropertyName = "Persal_Number"
        Me.PersalNumberDataGridViewTextBoxColumn.HeaderText = "Persal_Number"
        Me.PersalNumberDataGridViewTextBoxColumn.Name = "PersalNumberDataGridViewTextBoxColumn"
        Me.PersalNumberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SolutionDataGridViewTextBoxColumn
        '
        Me.SolutionDataGridViewTextBoxColumn.DataPropertyName = "Solution"
        Me.SolutionDataGridViewTextBoxColumn.HeaderText = "Solution"
        Me.SolutionDataGridViewTextBoxColumn.Name = "SolutionDataGridViewTextBoxColumn"
        Me.SolutionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "First_Name"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "First_Name"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        Me.FirstNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "Last_Name"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "Last_Name"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        Me.LastNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DepartmentNameDataGridViewTextBoxColumn
        '
        Me.DepartmentNameDataGridViewTextBoxColumn.DataPropertyName = "Department_Name"
        Me.DepartmentNameDataGridViewTextBoxColumn.HeaderText = "Department_Name"
        Me.DepartmentNameDataGridViewTextBoxColumn.Name = "DepartmentNameDataGridViewTextBoxColumn"
        Me.DepartmentNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LongDescriptionDataGridViewTextBoxColumn
        '
        Me.LongDescriptionDataGridViewTextBoxColumn.DataPropertyName = "Long_Description"
        Me.LongDescriptionDataGridViewTextBoxColumn.HeaderText = "Long_Description"
        Me.LongDescriptionDataGridViewTextBoxColumn.Name = "LongDescriptionDataGridViewTextBoxColumn"
        Me.LongDescriptionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GroupxDataGridViewTextBoxColumn
        '
        Me.GroupxDataGridViewTextBoxColumn.DataPropertyName = "Group_x"
        Me.GroupxDataGridViewTextBoxColumn.HeaderText = "Group_x"
        Me.GroupxDataGridViewTextBoxColumn.Name = "GroupxDataGridViewTextBoxColumn"
        Me.GroupxDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DepartmentTypeDataGridViewTextBoxColumn
        '
        Me.DepartmentTypeDataGridViewTextBoxColumn.DataPropertyName = "Department_Type"
        Me.DepartmentTypeDataGridViewTextBoxColumn.HeaderText = "Department_Type"
        Me.DepartmentTypeDataGridViewTextBoxColumn.Name = "DepartmentTypeDataGridViewTextBoxColumn"
        Me.DepartmentTypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TelephoneDataGridViewTextBoxColumn
        '
        Me.TelephoneDataGridViewTextBoxColumn.DataPropertyName = "Telephone"
        Me.TelephoneDataGridViewTextBoxColumn.HeaderText = "Telephone"
        Me.TelephoneDataGridViewTextBoxColumn.Name = "TelephoneDataGridViewTextBoxColumn"
        Me.TelephoneDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EMailDataGridViewTextBoxColumn
        '
        Me.EMailDataGridViewTextBoxColumn.DataPropertyName = "E_Mail"
        Me.EMailDataGridViewTextBoxColumn.HeaderText = "E_Mail"
        Me.EMailDataGridViewTextBoxColumn.Name = "EMailDataGridViewTextBoxColumn"
        Me.EMailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LOGINRequestTrackingBindingSource
        '
        Me.LOGINRequestTrackingBindingSource.DataMember = "LOG_IN_Request_Tracking"
        Me.LOGINRequestTrackingBindingSource.DataSource = Me.DsARSystemDataSet
        '
        'StatusStrip2
        '
        Me.StatusStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSplitButton1})
        Me.StatusStrip2.Location = New System.Drawing.Point(0, 698)
        Me.StatusStrip2.Name = "StatusStrip2"
        Me.StatusStrip2.Size = New System.Drawing.Size(1045, 22)
        Me.StatusStrip2.TabIndex = 3
        Me.StatusStrip2.Text = "StatusStrip2"
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripSplitButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportToExcelToolStripMenuItem, Me.ToolStripMenuItem3, Me.ExportToXMLToolStripMenuItem, Me.ToolStripMenuItem2, Me.ToolStripMenuItem1})
        Me.ToolStripSplitButton1.Image = CType(resources.GetObject("ToolStripSplitButton1.Image"), System.Drawing.Image)
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(32, 20)
        Me.ToolStripSplitButton1.Text = "ToolStripSplitButton1"
        '
        'ExportToExcelToolStripMenuItem
        '
        Me.ExportToExcelToolStripMenuItem.Name = "ExportToExcelToolStripMenuItem"
        Me.ExportToExcelToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.ExportToExcelToolStripMenuItem.Text = "Export to Excel"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(147, 6)
        '
        'ExportToXMLToolStripMenuItem
        '
        Me.ExportToXMLToolStripMenuItem.Name = "ExportToXMLToolStripMenuItem"
        Me.ExportToXMLToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.ExportToXMLToolStripMenuItem.Text = "Export to XML"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(147, 6)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(147, 6)
        '
        'LOG_IN_Request_TrackingTableAdapter
        '
        Me.LOG_IN_Request_TrackingTableAdapter.ClearBeforeFill = True
        '
        'frmRequestTracking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1045, 720)
        Me.Controls.Add(Me.StatusStrip2)
        Me.Controls.Add(Me.LOG_IN_Request_TrackingDataGridView)
        Me.Controls.Add(Me.LOG_IN_Request_TrackingBindingNavigator)
        Me.Name = "frmRequestTracking"
        Me.Text = "frmRequestTracking"
        CType(Me.LOG_IN_Request_TrackingBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LOG_IN_Request_TrackingBindingNavigator.ResumeLayout(False)
        Me.LOG_IN_Request_TrackingBindingNavigator.PerformLayout()
        CType(Me.LOG_IN_Request_TrackingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsARSystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOG_IN_Request_TrackingDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOGINRequestTrackingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip2.ResumeLayout(False)
        Me.StatusStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DsARSystemDataSet As ADAdminDotNet.dsARSystemDataSet
    Friend WithEvents LOG_IN_Request_TrackingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LOG_IN_Request_TrackingTableAdapter As ADAdminDotNet.dsARSystemDataSetTableAdapters.LOG_IN_Request_TrackingTableAdapter
    Friend WithEvents LOG_IN_Request_TrackingBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents LOG_IN_Request_TrackingBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents LOG_IN_Request_TrackingDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents StatusStrip2 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripSplitButton1 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents ExportToExcelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExportToXMLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LOGINRequestTrackingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Request_No As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Request_Type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Request_Category As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Submitter As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Assigned_to As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Owner As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Entry_Date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Due_Date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Persal_Number As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents First_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Last_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Department_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Long_Description As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Solution As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Functional_Area As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Group_x As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Department_Type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Telephone As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents E_Mail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Assignee_Group As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Project As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Request_Log As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Request_History As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Request_Source As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Original_Due_Date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Closed_Date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Priority As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Re_Assigned As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Re_Opened As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Last_Status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Updated_By As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents System_Group As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Root_Cause As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RequestNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PersalNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SolutionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DepartmentNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LongDescriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupxDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DepartmentTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelephoneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EMailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AssignedtoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastStatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UpdatedByDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubmitterDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RequestTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AssigneeGroupDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProjectDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OwnerDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RequestLogDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RequestHistoryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RequestCategoryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RequestSourceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FunctionalAreaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EntryDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DueDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OriginalDueDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClosedDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriorityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReAssignedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReOpenedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SystemGroupDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RootCauseDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
