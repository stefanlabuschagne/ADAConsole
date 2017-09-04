<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOpenRequests
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOpenRequests))
        Me.RemedyOpenRequestsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.RemedyOpenRequestsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ARSystemDataSet = New ADAdminDotNet.dsARSystemDataSet()
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
        Me.RemedyOpenRequestsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.btnRefresh = New System.Windows.Forms.ToolStripButton()
        Me.RemedyOpenRequestsDataGridView = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MarkAsDoneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CancelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuResetPassword = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuCancel = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ExportToCSVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Last_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.First_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Request_No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Persal_Number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Entry_Date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RemedyOpenRequestsTableAdapter = New ADAdminDotNet.dsARSystemDataSetTableAdapters.RemedyOpenRequestsTableAdapter()
        Me.Owner = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Due_Date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn70 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn110 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn120 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.RemedyOpenRequestsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RemedyOpenRequestsBindingNavigator.SuspendLayout()
        CType(Me.RemedyOpenRequestsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ARSystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RemedyOpenRequestsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RemedyOpenRequestsBindingNavigator
        '
        Me.RemedyOpenRequestsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.RemedyOpenRequestsBindingNavigator.BindingSource = Me.RemedyOpenRequestsBindingSource
        Me.RemedyOpenRequestsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.RemedyOpenRequestsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.RemedyOpenRequestsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.RemedyOpenRequestsBindingNavigatorSaveItem, Me.btnRefresh})
        Me.RemedyOpenRequestsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.RemedyOpenRequestsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.RemedyOpenRequestsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.RemedyOpenRequestsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.RemedyOpenRequestsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.RemedyOpenRequestsBindingNavigator.Name = "RemedyOpenRequestsBindingNavigator"
        Me.RemedyOpenRequestsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.RemedyOpenRequestsBindingNavigator.Size = New System.Drawing.Size(792, 25)
        Me.RemedyOpenRequestsBindingNavigator.Stretch = True
        Me.RemedyOpenRequestsBindingNavigator.TabIndex = 0
        Me.RemedyOpenRequestsBindingNavigator.Text = "BindingNavigator1"
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
        'RemedyOpenRequestsBindingSource
        '
        Me.RemedyOpenRequestsBindingSource.DataMember = "RemedyOpenRequests"
        Me.RemedyOpenRequestsBindingSource.DataSource = Me.ARSystemDataSet
        '
        'ARSystemDataSet
        '
        Me.ARSystemDataSet.DataSetName = "ARSystemDataSet"
        Me.ARSystemDataSet.EnforceConstraints = False
        Me.ARSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'RemedyOpenRequestsBindingNavigatorSaveItem
        '
        Me.RemedyOpenRequestsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RemedyOpenRequestsBindingNavigatorSaveItem.Enabled = False
        Me.RemedyOpenRequestsBindingNavigatorSaveItem.Image = CType(resources.GetObject("RemedyOpenRequestsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.RemedyOpenRequestsBindingNavigatorSaveItem.Name = "RemedyOpenRequestsBindingNavigatorSaveItem"
        Me.RemedyOpenRequestsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.RemedyOpenRequestsBindingNavigatorSaveItem.Text = "Save Data"
        Me.RemedyOpenRequestsBindingNavigatorSaveItem.Visible = False
        '
        'btnRefresh
        '
        Me.btnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(50, 22)
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'RemedyOpenRequestsDataGridView
        '
        Me.RemedyOpenRequestsDataGridView.AllowUserToAddRows = False
        Me.RemedyOpenRequestsDataGridView.AllowUserToDeleteRows = False
        Me.RemedyOpenRequestsDataGridView.AllowUserToOrderColumns = True
        Me.RemedyOpenRequestsDataGridView.AutoGenerateColumns = False
        Me.RemedyOpenRequestsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.RemedyOpenRequestsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Owner, Me.Due_Date, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn70, Me.DataGridViewTextBoxColumn110, Me.DataGridViewTextBoxColumn120, Me.DataGridViewTextBoxColumn14})
        Me.RemedyOpenRequestsDataGridView.ContextMenuStrip = Me.ContextMenuStrip2
        Me.RemedyOpenRequestsDataGridView.DataSource = Me.RemedyOpenRequestsBindingSource
        Me.RemedyOpenRequestsDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.RemedyOpenRequestsDataGridView.Name = "RemedyOpenRequestsDataGridView"
        Me.RemedyOpenRequestsDataGridView.ReadOnly = True
        Me.RemedyOpenRequestsDataGridView.RowHeadersWidth = 4
        Me.RemedyOpenRequestsDataGridView.Size = New System.Drawing.Size(792, 498)
        Me.RemedyOpenRequestsDataGridView.TabIndex = 1
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MarkAsDoneToolStripMenuItem, Me.ToolStripMenuItem1, Me.CancelToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(147, 54)
        '
        'MarkAsDoneToolStripMenuItem
        '
        Me.MarkAsDoneToolStripMenuItem.Name = "MarkAsDoneToolStripMenuItem"
        Me.MarkAsDoneToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.MarkAsDoneToolStripMenuItem.Text = "Mark as Done"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(143, 6)
        '
        'CancelToolStripMenuItem
        '
        Me.CancelToolStripMenuItem.Name = "CancelToolStripMenuItem"
        Me.CancelToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.CancelToolStripMenuItem.Text = "Cancel"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuResetPassword, Me.ToolStripSeparator1, Me.mnuCancel})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(192, 54)
        '
        'mnuResetPassword
        '
        Me.mnuResetPassword.Name = "mnuResetPassword"
        Me.mnuResetPassword.Size = New System.Drawing.Size(191, 22)
        Me.mnuResetPassword.Text = "Reset Password on AD"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(188, 6)
        '
        'mnuCancel
        '
        Me.mnuCancel.Name = "mnuCancel"
        Me.mnuCancel.Size = New System.Drawing.Size(191, 22)
        Me.mnuCancel.Text = "Cancel"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 526)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode
        Me.StatusStrip1.Size = New System.Drawing.Size(792, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportToCSVToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(80, 20)
        Me.ToolStripDropDownButton1.Text = "Export Data"
        '
        'ExportToCSVToolStripMenuItem
        '
        Me.ExportToCSVToolStripMenuItem.Name = "ExportToCSVToolStripMenuItem"
        Me.ExportToCSVToolStripMenuItem.Size = New System.Drawing.Size(263, 22)
        Me.ExportToCSVToolStripMenuItem.Text = "Export to OpenRemedyRequests.csv"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Request_No"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Request Nr"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 66
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Persal_Number"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Persal Nr"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 60
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Entry_Date"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Entry Date"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 120
        '
        'Last_Name
        '
        Me.Last_Name.DataPropertyName = "Last_Name"
        Me.Last_Name.HeaderText = "Last_Name"
        Me.Last_Name.Name = "Last_Name"
        '
        'First_Name
        '
        Me.First_Name.DataPropertyName = "First_Name"
        Me.First_Name.HeaderText = "First_Name"
        Me.First_Name.Name = "First_Name"
        '
        'Request_No
        '
        Me.Request_No.DataPropertyName = "Request_No"
        Me.Request_No.HeaderText = "Request_No"
        Me.Request_No.Name = "Request_No"
        '
        'Persal_Number
        '
        Me.Persal_Number.DataPropertyName = "Persal_Number"
        Me.Persal_Number.HeaderText = "Persal_Number"
        Me.Persal_Number.Name = "Persal_Number"
        '
        'Entry_Date
        '
        Me.Entry_Date.DataPropertyName = "Entry_Date"
        Me.Entry_Date.HeaderText = "Entry_Date"
        Me.Entry_Date.Name = "Entry_Date"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Last_Name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Last_Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "First_Name"
        Me.DataGridViewTextBoxColumn4.HeaderText = "First_Name"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'RemedyOpenRequestsTableAdapter
        '
        Me.RemedyOpenRequestsTableAdapter.ClearBeforeFill = True
        '
        'Owner
        '
        Me.Owner.DataPropertyName = "Owner"
        Me.Owner.HeaderText = "Owner"
        Me.Owner.Name = "Owner"
        Me.Owner.ReadOnly = True
        '
        'Due_Date
        '
        Me.Due_Date.DataPropertyName = "Due_Date"
        Me.Due_Date.HeaderText = "Due_Date"
        Me.Due_Date.Name = "Due_Date"
        Me.Due_Date.ReadOnly = True
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "Request_No"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Request_No"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        Me.DataGridViewTextBoxColumn20.Width = 5
        '
        'DataGridViewTextBoxColumn70
        '
        Me.DataGridViewTextBoxColumn70.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.DataGridViewTextBoxColumn70.DataPropertyName = "Persal_Number"
        Me.DataGridViewTextBoxColumn70.HeaderText = "Persal_Number"
        Me.DataGridViewTextBoxColumn70.Name = "DataGridViewTextBoxColumn70"
        Me.DataGridViewTextBoxColumn70.ReadOnly = True
        Me.DataGridViewTextBoxColumn70.Width = 5
        '
        'DataGridViewTextBoxColumn110
        '
        Me.DataGridViewTextBoxColumn110.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.DataGridViewTextBoxColumn110.DataPropertyName = "Last_Name"
        Me.DataGridViewTextBoxColumn110.HeaderText = "Last_Name"
        Me.DataGridViewTextBoxColumn110.Name = "DataGridViewTextBoxColumn110"
        Me.DataGridViewTextBoxColumn110.ReadOnly = True
        Me.DataGridViewTextBoxColumn110.Width = 5
        '
        'DataGridViewTextBoxColumn120
        '
        Me.DataGridViewTextBoxColumn120.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.DataGridViewTextBoxColumn120.DataPropertyName = "First_Name"
        Me.DataGridViewTextBoxColumn120.HeaderText = "First_Name"
        Me.DataGridViewTextBoxColumn120.Name = "DataGridViewTextBoxColumn120"
        Me.DataGridViewTextBoxColumn120.ReadOnly = True
        Me.DataGridViewTextBoxColumn120.Width = 5
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Long_Description"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Long_Description"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Width = 5
        '
        'frmOpenRequests
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 548)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.RemedyOpenRequestsBindingNavigator)
        Me.Controls.Add(Me.RemedyOpenRequestsDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmOpenRequests"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Open Requests"
        CType(Me.RemedyOpenRequestsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RemedyOpenRequestsBindingNavigator.ResumeLayout(False)
        Me.RemedyOpenRequestsBindingNavigator.PerformLayout()
        CType(Me.RemedyOpenRequestsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ARSystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RemedyOpenRequestsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RemedyOpenRequestsTableAdapter As Global.ADAdminDotNet.dsARSystemDataSetTableAdapters.RemedyOpenRequestsTableAdapter
    Friend WithEvents ARSystemDataSet As Global.ADAdminDotNet.dsARSystemDataSet
    Friend WithEvents RemedyOpenRequestsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RemedyOpenRequestsBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents RemedyOpenRequestsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents RemedyOpenRequestsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents btnRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuResetPassword As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuCancel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Name2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ExportToCSVToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Long_Description As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MarkAsDoneToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CancelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Last_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents First_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Request_No As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Persal_Number As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Entry_Date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Owners As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mOwner As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Owner As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Due_Date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn70 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn110 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn120 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    'Friend WithEvents Name As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
