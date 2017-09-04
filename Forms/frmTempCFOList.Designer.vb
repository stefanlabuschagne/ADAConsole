<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTempCFOList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTempCFOList))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.DeleteFromTempTableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CancelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteFromCFOLIVEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.CancelToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CFODataSet2 = New ADAdminDotNet.CFODataSet()
        Me.CFOListoutBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FKCFOListTempCFOListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CFOListTempDataGridView = New System.Windows.Forms.DataGridView()
        Me.CFOListTemp2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CFODataSet = New ADAdminDotNet.CFODataSet()
        Me.CFOListout1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CFOListDataGridView = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersalNoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FullNamesDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SurnameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FaxDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CellDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DesignationDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepartmentDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeptCodeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProvinceDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CFOListoutBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CFOList_outTableAdapter = New ADAdminDotNet.CFODataSetTableAdapters.CFOList_outTableAdapter()
        Me.CFOListTemp_2TableAdapter = New ADAdminDotNet.CFODataSetTableAdapters.CFOListTemp_2TableAdapter()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersalNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FullNamesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SurnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FaxDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CellDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DesignationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepartmentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeptCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProvinceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CFOListTempBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ADSDataSet = New ADAdminDotNet.ADSDataSet()
        Me.CFOListTempBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CFOListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CFOListTempBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CFOListTableAdapter = New ADAdminDotNet.ADSDataSetTableAdapters.CFOListTableAdapter()
        Me.TableAdapterManager = New ADAdminDotNet.ADSDataSetTableAdapters.TableAdapterManager()
        Me.CFOListTempTableAdapter = New ADAdminDotNet.ADSDataSetTableAdapters.CFOListTempTableAdapter()
        Me.CFOListBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContextMenuStrip1.SuspendLayout()
        Me.ContextMenuStrip2.SuspendLayout()
        CType(Me.CFODataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CFOListoutBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKCFOListTempCFOListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CFOListTempDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CFOListTemp2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CFODataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CFOListout1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CFOListDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CFOListoutBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CFOListTempBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ADSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CFOListTempBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CFOListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CFOListTempBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CFOListBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 687)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1230, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PosToolStripMenuItem, Me.ToolStripMenuItem1, Me.DeleteFromTempTableToolStripMenuItem, Me.ToolStripMenuItem2, Me.CancelToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(205, 82)
        '
        'PosToolStripMenuItem
        '
        Me.PosToolStripMenuItem.Image = CType(resources.GetObject("PosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PosToolStripMenuItem.Name = "PosToolStripMenuItem"
        Me.PosToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.PosToolStripMenuItem.Text = "Post to CFO Table"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(201, 6)
        '
        'DeleteFromTempTableToolStripMenuItem
        '
        Me.DeleteFromTempTableToolStripMenuItem.Image = CType(resources.GetObject("DeleteFromTempTableToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DeleteFromTempTableToolStripMenuItem.Name = "DeleteFromTempTableToolStripMenuItem"
        Me.DeleteFromTempTableToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.DeleteFromTempTableToolStripMenuItem.Text = "Delete From Temp Table"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(201, 6)
        '
        'CancelToolStripMenuItem
        '
        Me.CancelToolStripMenuItem.Name = "CancelToolStripMenuItem"
        Me.CancelToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.CancelToolStripMenuItem.Text = "Cancel"
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteFromCFOLIVEToolStripMenuItem, Me.ToolStripMenuItem3, Me.CancelToolStripMenuItem1})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(190, 54)
        '
        'DeleteFromCFOLIVEToolStripMenuItem
        '
        Me.DeleteFromCFOLIVEToolStripMenuItem.Image = CType(resources.GetObject("DeleteFromCFOLIVEToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DeleteFromCFOLIVEToolStripMenuItem.Name = "DeleteFromCFOLIVEToolStripMenuItem"
        Me.DeleteFromCFOLIVEToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.DeleteFromCFOLIVEToolStripMenuItem.Text = "Delete From CFO LIVE"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(186, 6)
        '
        'CancelToolStripMenuItem1
        '
        Me.CancelToolStripMenuItem1.Name = "CancelToolStripMenuItem1"
        Me.CancelToolStripMenuItem1.Size = New System.Drawing.Size(189, 22)
        Me.CancelToolStripMenuItem1.Text = "Cancel"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Temporary CFO List for Approval"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(615, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Currrent CFO List"
        '
        'CFODataSet2
        '
        Me.CFODataSet2.DataSetName = "CFODataSet"
        Me.CFODataSet2.EnforceConstraints = False
        Me.CFODataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CFOListoutBindingSource
        '
        Me.CFOListoutBindingSource.DataMember = "CFOList_out"
        '
        'FKCFOListTempCFOListBindingSource
        '
        Me.FKCFOListTempCFOListBindingSource.DataMember = "FK_CFOListTemp_CFOList"
        Me.FKCFOListTempCFOListBindingSource.DataSource = Me.CFOListTempBindingSource
        '
        'CFOListTempDataGridView
        '
        Me.CFOListTempDataGridView.AllowUserToAddRows = False
        Me.CFOListTempDataGridView.AllowUserToDeleteRows = False
        Me.CFOListTempDataGridView.AllowUserToOrderColumns = True
        Me.CFOListTempDataGridView.AutoGenerateColumns = False
        Me.CFOListTempDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CFOListTempDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.PersalNoDataGridViewTextBoxColumn, Me.FullNamesDataGridViewTextBoxColumn, Me.SurnameDataGridViewTextBoxColumn, Me.TelDataGridViewTextBoxColumn, Me.FaxDataGridViewTextBoxColumn, Me.CellDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.DesignationDataGridViewTextBoxColumn, Me.DepartmentDataGridViewTextBoxColumn, Me.DeptCodeDataGridViewTextBoxColumn, Me.ProvinceDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn})
        Me.CFOListTempDataGridView.ContextMenuStrip = Me.ContextMenuStrip1
        Me.CFOListTempDataGridView.DataSource = Me.CFOListTempBindingSource2
        Me.CFOListTempDataGridView.Location = New System.Drawing.Point(12, 32)
        Me.CFOListTempDataGridView.MultiSelect = False
        Me.CFOListTempDataGridView.Name = "CFOListTempDataGridView"
        Me.CFOListTempDataGridView.ReadOnly = True
        Me.CFOListTempDataGridView.RowHeadersWidth = 20
        Me.CFOListTempDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CFOListTempDataGridView.ShowCellErrors = False
        Me.CFOListTempDataGridView.ShowRowErrors = False
        Me.CFOListTempDataGridView.Size = New System.Drawing.Size(587, 607)
        Me.CFOListTempDataGridView.TabIndex = 8
        '
        'CFOListTemp2BindingSource
        '
        Me.CFOListTemp2BindingSource.DataMember = "CFOListTemp_2"
        Me.CFOListTemp2BindingSource.DataSource = Me.CFODataSet
        '
        'CFODataSet
        '
        Me.CFODataSet.DataSetName = "CFODataSet"
        Me.CFODataSet.EnforceConstraints = False
        Me.CFODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CFOListout1BindingSource
        '
        Me.CFOListout1BindingSource.DataSource = Me.CFODataSet2
        Me.CFOListout1BindingSource.Position = 0
        '
        'CFOListDataGridView
        '
        Me.CFOListDataGridView.AllowUserToAddRows = False
        Me.CFOListDataGridView.AllowUserToDeleteRows = False
        Me.CFOListDataGridView.AutoGenerateColumns = False
        Me.CFOListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CFOListDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn1, Me.PersalNoDataGridViewTextBoxColumn1, Me.FullNamesDataGridViewTextBoxColumn1, Me.SurnameDataGridViewTextBoxColumn1, Me.TelDataGridViewTextBoxColumn1, Me.FaxDataGridViewTextBoxColumn1, Me.CellDataGridViewTextBoxColumn1, Me.EmailDataGridViewTextBoxColumn1, Me.DesignationDataGridViewTextBoxColumn1, Me.DepartmentDataGridViewTextBoxColumn1, Me.DeptCodeDataGridViewTextBoxColumn1, Me.ProvinceDataGridViewTextBoxColumn1})
        Me.CFOListDataGridView.ContextMenuStrip = Me.ContextMenuStrip2
        Me.CFOListDataGridView.DataSource = Me.CFOListBindingSource1
        Me.CFOListDataGridView.Location = New System.Drawing.Point(605, 38)
        Me.CFOListDataGridView.MultiSelect = False
        Me.CFOListDataGridView.Name = "CFOListDataGridView"
        Me.CFOListDataGridView.ReadOnly = True
        Me.CFOListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CFOListDataGridView.ShowCellErrors = False
        Me.CFOListDataGridView.ShowRowErrors = False
        Me.CFOListDataGridView.Size = New System.Drawing.Size(593, 605)
        Me.CFOListDataGridView.TabIndex = 8
        '
        'IDDataGridViewTextBoxColumn1
        '
        Me.IDDataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn1.Name = "IDDataGridViewTextBoxColumn1"
        Me.IDDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'PersalNoDataGridViewTextBoxColumn1
        '
        Me.PersalNoDataGridViewTextBoxColumn1.DataPropertyName = "PersalNo"
        Me.PersalNoDataGridViewTextBoxColumn1.HeaderText = "PersalNo"
        Me.PersalNoDataGridViewTextBoxColumn1.Name = "PersalNoDataGridViewTextBoxColumn1"
        Me.PersalNoDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'FullNamesDataGridViewTextBoxColumn1
        '
        Me.FullNamesDataGridViewTextBoxColumn1.DataPropertyName = "FullNames"
        Me.FullNamesDataGridViewTextBoxColumn1.HeaderText = "FullNames"
        Me.FullNamesDataGridViewTextBoxColumn1.Name = "FullNamesDataGridViewTextBoxColumn1"
        Me.FullNamesDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'SurnameDataGridViewTextBoxColumn1
        '
        Me.SurnameDataGridViewTextBoxColumn1.DataPropertyName = "Surname"
        Me.SurnameDataGridViewTextBoxColumn1.HeaderText = "Surname"
        Me.SurnameDataGridViewTextBoxColumn1.Name = "SurnameDataGridViewTextBoxColumn1"
        Me.SurnameDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'TelDataGridViewTextBoxColumn1
        '
        Me.TelDataGridViewTextBoxColumn1.DataPropertyName = "Tel"
        Me.TelDataGridViewTextBoxColumn1.HeaderText = "Tel"
        Me.TelDataGridViewTextBoxColumn1.Name = "TelDataGridViewTextBoxColumn1"
        Me.TelDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'FaxDataGridViewTextBoxColumn1
        '
        Me.FaxDataGridViewTextBoxColumn1.DataPropertyName = "Fax"
        Me.FaxDataGridViewTextBoxColumn1.HeaderText = "Fax"
        Me.FaxDataGridViewTextBoxColumn1.Name = "FaxDataGridViewTextBoxColumn1"
        Me.FaxDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'CellDataGridViewTextBoxColumn1
        '
        Me.CellDataGridViewTextBoxColumn1.DataPropertyName = "Cell"
        Me.CellDataGridViewTextBoxColumn1.HeaderText = "Cell"
        Me.CellDataGridViewTextBoxColumn1.Name = "CellDataGridViewTextBoxColumn1"
        Me.CellDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'EmailDataGridViewTextBoxColumn1
        '
        Me.EmailDataGridViewTextBoxColumn1.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn1.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn1.Name = "EmailDataGridViewTextBoxColumn1"
        Me.EmailDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DesignationDataGridViewTextBoxColumn1
        '
        Me.DesignationDataGridViewTextBoxColumn1.DataPropertyName = "Designation"
        Me.DesignationDataGridViewTextBoxColumn1.HeaderText = "Designation"
        Me.DesignationDataGridViewTextBoxColumn1.Name = "DesignationDataGridViewTextBoxColumn1"
        Me.DesignationDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DepartmentDataGridViewTextBoxColumn1
        '
        Me.DepartmentDataGridViewTextBoxColumn1.DataPropertyName = "Department"
        Me.DepartmentDataGridViewTextBoxColumn1.HeaderText = "Department"
        Me.DepartmentDataGridViewTextBoxColumn1.Name = "DepartmentDataGridViewTextBoxColumn1"
        Me.DepartmentDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DeptCodeDataGridViewTextBoxColumn1
        '
        Me.DeptCodeDataGridViewTextBoxColumn1.DataPropertyName = "DeptCode"
        Me.DeptCodeDataGridViewTextBoxColumn1.HeaderText = "DeptCode"
        Me.DeptCodeDataGridViewTextBoxColumn1.Name = "DeptCodeDataGridViewTextBoxColumn1"
        Me.DeptCodeDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'ProvinceDataGridViewTextBoxColumn1
        '
        Me.ProvinceDataGridViewTextBoxColumn1.DataPropertyName = "Province"
        Me.ProvinceDataGridViewTextBoxColumn1.HeaderText = "Province"
        Me.ProvinceDataGridViewTextBoxColumn1.Name = "ProvinceDataGridViewTextBoxColumn1"
        Me.ProvinceDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'CFOListoutBindingSource1
        '
        Me.CFOListoutBindingSource1.DataMember = "CFOList_out"
        Me.CFOListoutBindingSource1.DataSource = Me.CFODataSet
        '
        'CFOList_outTableAdapter
        '
        Me.CFOList_outTableAdapter.ClearBeforeFill = True
        '
        'CFOListTemp_2TableAdapter
        '
        Me.CFOListTemp_2TableAdapter.ClearBeforeFill = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PersalNoDataGridViewTextBoxColumn
        '
        Me.PersalNoDataGridViewTextBoxColumn.DataPropertyName = "PersalNo"
        Me.PersalNoDataGridViewTextBoxColumn.HeaderText = "PersalNo"
        Me.PersalNoDataGridViewTextBoxColumn.Name = "PersalNoDataGridViewTextBoxColumn"
        Me.PersalNoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FullNamesDataGridViewTextBoxColumn
        '
        Me.FullNamesDataGridViewTextBoxColumn.DataPropertyName = "FullNames"
        Me.FullNamesDataGridViewTextBoxColumn.HeaderText = "FullNames"
        Me.FullNamesDataGridViewTextBoxColumn.Name = "FullNamesDataGridViewTextBoxColumn"
        Me.FullNamesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SurnameDataGridViewTextBoxColumn
        '
        Me.SurnameDataGridViewTextBoxColumn.DataPropertyName = "Surname"
        Me.SurnameDataGridViewTextBoxColumn.HeaderText = "Surname"
        Me.SurnameDataGridViewTextBoxColumn.Name = "SurnameDataGridViewTextBoxColumn"
        Me.SurnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TelDataGridViewTextBoxColumn
        '
        Me.TelDataGridViewTextBoxColumn.DataPropertyName = "Tel"
        Me.TelDataGridViewTextBoxColumn.HeaderText = "Tel"
        Me.TelDataGridViewTextBoxColumn.Name = "TelDataGridViewTextBoxColumn"
        Me.TelDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FaxDataGridViewTextBoxColumn
        '
        Me.FaxDataGridViewTextBoxColumn.DataPropertyName = "Fax"
        Me.FaxDataGridViewTextBoxColumn.HeaderText = "Fax"
        Me.FaxDataGridViewTextBoxColumn.Name = "FaxDataGridViewTextBoxColumn"
        Me.FaxDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CellDataGridViewTextBoxColumn
        '
        Me.CellDataGridViewTextBoxColumn.DataPropertyName = "Cell"
        Me.CellDataGridViewTextBoxColumn.HeaderText = "Cell"
        Me.CellDataGridViewTextBoxColumn.Name = "CellDataGridViewTextBoxColumn"
        Me.CellDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DesignationDataGridViewTextBoxColumn
        '
        Me.DesignationDataGridViewTextBoxColumn.DataPropertyName = "Designation"
        Me.DesignationDataGridViewTextBoxColumn.HeaderText = "Designation"
        Me.DesignationDataGridViewTextBoxColumn.Name = "DesignationDataGridViewTextBoxColumn"
        Me.DesignationDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DepartmentDataGridViewTextBoxColumn
        '
        Me.DepartmentDataGridViewTextBoxColumn.DataPropertyName = "Department"
        Me.DepartmentDataGridViewTextBoxColumn.HeaderText = "Department"
        Me.DepartmentDataGridViewTextBoxColumn.Name = "DepartmentDataGridViewTextBoxColumn"
        Me.DepartmentDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DeptCodeDataGridViewTextBoxColumn
        '
        Me.DeptCodeDataGridViewTextBoxColumn.DataPropertyName = "DeptCode"
        Me.DeptCodeDataGridViewTextBoxColumn.HeaderText = "DeptCode"
        Me.DeptCodeDataGridViewTextBoxColumn.Name = "DeptCodeDataGridViewTextBoxColumn"
        Me.DeptCodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProvinceDataGridViewTextBoxColumn
        '
        Me.ProvinceDataGridViewTextBoxColumn.DataPropertyName = "Province"
        Me.ProvinceDataGridViewTextBoxColumn.HeaderText = "Province"
        Me.ProvinceDataGridViewTextBoxColumn.Name = "ProvinceDataGridViewTextBoxColumn"
        Me.ProvinceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        Me.GenderDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CFOListTempBindingSource2
        '
        Me.CFOListTempBindingSource2.DataMember = "CFOListTemp"
        Me.CFOListTempBindingSource2.DataSource = Me.ADSDataSet
        '
        'ADSDataSet
        '
        Me.ADSDataSet.DataSetName = "ADSDataSet"
        Me.ADSDataSet.EnforceConstraints = False
        Me.ADSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CFOListTempBindingSource
        '
        Me.CFOListTempBindingSource.DataMember = "CFOListTemp"
        Me.CFOListTempBindingSource.DataSource = Me.ADSDataSet
        '
        'CFOListBindingSource
        '
        Me.CFOListBindingSource.DataMember = "CFOList"
        Me.CFOListBindingSource.DataSource = Me.ADSDataSet
        '
        'CFOListTempBindingSource1
        '
        Me.CFOListTempBindingSource1.DataMember = "CFOListTemp"
        Me.CFOListTempBindingSource1.DataSource = Me.ADSDataSet
        '
        'CFOListTableAdapter
        '
        Me.CFOListTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CFOListTableAdapter = Me.CFOListTableAdapter
        Me.TableAdapterManager.CFOListTempTableAdapter = Me.CFOListTempTableAdapter
        Me.TableAdapterManager.UpdateOrder = ADAdminDotNet.ADSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CFOListTempTableAdapter
        '
        Me.CFOListTempTableAdapter.ClearBeforeFill = True
        '
        'CFOListBindingSource1
        '
        Me.CFOListBindingSource1.DataMember = "CFOList"
        Me.CFOListBindingSource1.DataSource = Me.ADSDataSet
        '
        'frmTempCFOList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1230, 709)
        Me.Controls.Add(Me.CFOListTempDataGridView)
        Me.Controls.Add(Me.CFOListDataGridView)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmTempCFOList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CFO Temp Table"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ContextMenuStrip2.ResumeLayout(False)
        CType(Me.CFODataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CFOListoutBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKCFOListTempCFOListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CFOListTempDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CFOListTemp2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CFODataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CFOListout1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CFOListDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CFOListoutBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CFOListTempBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ADSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CFOListTempBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CFOListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CFOListTempBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CFOListBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    'Friend WithEvents CFOListTableAdapter As ADAdminDotNet.ADSDataSetTableAdapters.CFOListTableAdapter
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents PosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DeleteFromTempTableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CancelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteFromCFOLIVEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CancelToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ADSDataSet As ADAdminDotNet.ADSDataSet
    Friend WithEvents CFOListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CFOListTableAdapter As ADAdminDotNet.ADSDataSetTableAdapters.CFOListTableAdapter
    Friend WithEvents TableAdapterManager As ADAdminDotNet.ADSDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CFOListTempTableAdapter As ADAdminDotNet.ADSDataSetTableAdapters.CFOListTempTableAdapter
    Friend WithEvents CFOListTempBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CFOListTempDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents FKCFOListTempCFOListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PersalNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FullNames As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Surname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fax As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cell As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Email As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Designation As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Department As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeptCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Province As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CFOListoutBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CFODataSet2 As ADAdminDotNet.CFODataSet
    Friend WithEvents CFOListout1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CFOListDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents CFOList_outTableAdapter As ADAdminDotNet.CFODataSetTableAdapters.CFOList_outTableAdapter
    Friend WithEvents CFODataSet As ADAdminDotNet.CFODataSet
    Friend WithEvents CFOListTemp2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CFOListTemp_2TableAdapter As ADAdminDotNet.CFODataSetTableAdapters.CFOListTemp_2TableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PersalNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FullNamesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SurnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FaxDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CellDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DesignationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DepartmentDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeptCodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProvinceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PersalNoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FullNamesDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SurnameDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FaxDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CellDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DesignationDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DepartmentDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeptCodeDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProvinceDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CFOListoutBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents CFOListTempBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents CFOListTempBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents CFOListBindingSource1 As System.Windows.Forms.BindingSource
    ' Friend WithEvents CFOList_out1TableAdapter As ADAdminDotNet.CFODataSetTableAdapters.CFOList_out1TableAdapter
End Class
