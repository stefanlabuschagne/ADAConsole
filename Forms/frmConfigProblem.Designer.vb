<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfigProblem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfigProblem))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripSplitButton()
        Me.ExportToProlemxlsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CalncelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Config_ProblemBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.Config_ProblemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.Config_ProblemBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsIncident = New System.Windows.Forms.ToolStripButton()
        Me.Config_ProblemDataGridView = New System.Windows.Forms.DataGridView()
        Me.txtVPNAdminsID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtPersalno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtSurname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtDatetime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtProblem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtDeptCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chkProblemSolved = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.chkVPNProblem = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.chkPolicyProblem = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Config_ProblemTableAdapter = New ADAdminDotNet.dsADSTableAdapters.Config_ProblemTableAdapter()
        Me.VpN_Admin_CategoriesTableAdapter1 = New ADAdminDotNet.dsADSTableAdapters.VPN_Admin_CategoriesTableAdapter()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.Config_ProblemBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Config_ProblemBindingNavigator.SuspendLayout()
        CType(Me.Config_ProblemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsADS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Config_ProblemDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 573)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(660, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportToProlemxlsToolStripMenuItem, Me.ToolStripMenuItem1, Me.CalncelToolStripMenuItem})
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(83, 20)
        Me.ToolStripStatusLabel1.Text = "Export Data"
        '
        'ExportToProlemxlsToolStripMenuItem
        '
        Me.ExportToProlemxlsToolStripMenuItem.Name = "ExportToProlemxlsToolStripMenuItem"
        Me.ExportToProlemxlsToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.ExportToProlemxlsToolStripMenuItem.Text = "Export to Problem.csv"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(186, 6)
        '
        'CalncelToolStripMenuItem
        '
        Me.CalncelToolStripMenuItem.Name = "CalncelToolStripMenuItem"
        Me.CalncelToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.CalncelToolStripMenuItem.Text = "Cancel"
        '
        'Config_ProblemBindingNavigator
        '
        Me.Config_ProblemBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Config_ProblemBindingNavigator.BindingSource = Me.Config_ProblemBindingSource
        Me.Config_ProblemBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Config_ProblemBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Config_ProblemBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Config_ProblemBindingNavigatorSaveItem, Me.ToolStripSeparator1, Me.tsIncident})
        Me.Config_ProblemBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Config_ProblemBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Config_ProblemBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Config_ProblemBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Config_ProblemBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Config_ProblemBindingNavigator.Name = "Config_ProblemBindingNavigator"
        Me.Config_ProblemBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Config_ProblemBindingNavigator.Size = New System.Drawing.Size(660, 25)
        Me.Config_ProblemBindingNavigator.TabIndex = 1
        Me.Config_ProblemBindingNavigator.Text = "BindingNavigator1"
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
        'Config_ProblemBindingSource
        '
        Me.Config_ProblemBindingSource.DataMember = "Config_Problem"
        Me.Config_ProblemBindingSource.DataSource = Me.DsADS
        '
        'DsADS
        '
        Me.DsADS.DataSetName = "dsADS"
        Me.DsADS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'Config_ProblemBindingNavigatorSaveItem
        '
        Me.Config_ProblemBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Config_ProblemBindingNavigatorSaveItem.Image = CType(resources.GetObject("Config_ProblemBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Config_ProblemBindingNavigatorSaveItem.Name = "Config_ProblemBindingNavigatorSaveItem"
        Me.Config_ProblemBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Config_ProblemBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tsIncident
        '
        Me.tsIncident.Image = CType(resources.GetObject("tsIncident.Image"), System.Drawing.Image)
        Me.tsIncident.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsIncident.Name = "tsIncident"
        Me.tsIncident.Size = New System.Drawing.Size(93, 22)
        Me.tsIncident.Text = "Log Incident"
        '
        'Config_ProblemDataGridView
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        Me.Config_ProblemDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Config_ProblemDataGridView.AutoGenerateColumns = False
        Me.Config_ProblemDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Config_ProblemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Config_ProblemDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.txtVPNAdminsID, Me.txtPersalno, Me.txtName, Me.txtSurname, Me.txtDatetime, Me.txtProblem, Me.txtDeptCode, Me.chkProblemSolved, Me.chkVPNProblem, Me.chkPolicyProblem})
        Me.Config_ProblemDataGridView.DataSource = Me.Config_ProblemBindingSource
        Me.Config_ProblemDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Config_ProblemDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.Config_ProblemDataGridView.Name = "Config_ProblemDataGridView"
        Me.Config_ProblemDataGridView.RowHeadersWidth = 10
        Me.Config_ProblemDataGridView.Size = New System.Drawing.Size(660, 548)
        Me.Config_ProblemDataGridView.TabIndex = 2
        '
        'txtVPNAdminsID
        '
        Me.txtVPNAdminsID.DataPropertyName = "VPNAdminsID"
        Me.txtVPNAdminsID.HeaderText = "AdminID"
        Me.txtVPNAdminsID.Name = "txtVPNAdminsID"
        Me.txtVPNAdminsID.Width = 72
        '
        'txtPersalno
        '
        Me.txtPersalno.DataPropertyName = "Persalno"
        Me.txtPersalno.HeaderText = "PersalNo"
        Me.txtPersalno.Name = "txtPersalno"
        Me.txtPersalno.Width = 75
        '
        'txtName
        '
        Me.txtName.DataPropertyName = "Name"
        Me.txtName.HeaderText = "Name"
        Me.txtName.Name = "txtName"
        Me.txtName.Width = 60
        '
        'txtSurname
        '
        Me.txtSurname.DataPropertyName = "Surname"
        Me.txtSurname.HeaderText = "Surname"
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Width = 74
        '
        'txtDatetime
        '
        Me.txtDatetime.DataPropertyName = "Datetime"
        Me.txtDatetime.HeaderText = "Logged"
        Me.txtDatetime.Name = "txtDatetime"
        Me.txtDatetime.Width = 68
        '
        'txtProblem
        '
        Me.txtProblem.DataPropertyName = "Problem"
        Me.txtProblem.HeaderText = "Problem"
        Me.txtProblem.Name = "txtProblem"
        Me.txtProblem.Width = 70
        '
        'txtDeptCode
        '
        Me.txtDeptCode.DataPropertyName = "DeptCode"
        Me.txtDeptCode.HeaderText = "DeptCode"
        Me.txtDeptCode.Name = "txtDeptCode"
        Me.txtDeptCode.Width = 80
        '
        'chkProblemSolved
        '
        Me.chkProblemSolved.DataPropertyName = "ProblemSolved"
        Me.chkProblemSolved.FalseValue = "False"
        Me.chkProblemSolved.HeaderText = "Solved"
        Me.chkProblemSolved.IndeterminateValue = "False"
        Me.chkProblemSolved.Name = "chkProblemSolved"
        Me.chkProblemSolved.TrueValue = "True"
        Me.chkProblemSolved.Width = 46
        '
        'chkVPNProblem
        '
        Me.chkVPNProblem.DataPropertyName = "VPNProblem"
        Me.chkVPNProblem.FalseValue = "False"
        Me.chkVPNProblem.HeaderText = "VPN"
        Me.chkVPNProblem.IndeterminateValue = "False"
        Me.chkVPNProblem.Name = "chkVPNProblem"
        Me.chkVPNProblem.TrueValue = "True"
        Me.chkVPNProblem.Width = 35
        '
        'chkPolicyProblem
        '
        Me.chkPolicyProblem.DataPropertyName = "PolicyProblem"
        Me.chkPolicyProblem.FalseValue = "False"
        Me.chkPolicyProblem.HeaderText = "Policy"
        Me.chkPolicyProblem.IndeterminateValue = "False"
        Me.chkPolicyProblem.Name = "chkPolicyProblem"
        Me.chkPolicyProblem.TrueValue = "True"
        Me.chkPolicyProblem.Width = 41
        '
        'Config_ProblemTableAdapter
        '
        Me.Config_ProblemTableAdapter.ClearBeforeFill = True
        '
        'VpN_Admin_CategoriesTableAdapter1
        '
        Me.VpN_Admin_CategoriesTableAdapter1.ClearBeforeFill = True
        '
        'frmConfigProblem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(660, 595)
        Me.Controls.Add(Me.Config_ProblemDataGridView)
        Me.Controls.Add(Me.Config_ProblemBindingNavigator)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmConfigProblem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Config Problems Identified"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.Config_ProblemBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Config_ProblemBindingNavigator.ResumeLayout(False)
        Me.Config_ProblemBindingNavigator.PerformLayout()
        CType(Me.Config_ProblemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsADS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Config_ProblemDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents ExportToProlemxlsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CalncelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DsADS As Global.ADAdminDotNet.dsADS
    Friend WithEvents Config_ProblemBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Config_ProblemTableAdapter As Global.ADAdminDotNet.dsADSTableAdapters.Config_ProblemTableAdapter
    Friend WithEvents Config_ProblemBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Config_ProblemBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsIncident As System.Windows.Forms.ToolStripButton
    Friend WithEvents Config_ProblemDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VpN_Admin_CategoriesTableAdapter1 As Global.ADAdminDotNet.dsADSTableAdapters.VPN_Admin_CategoriesTableAdapter
    Friend WithEvents txtVPNAdminsID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtPersalno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtSurname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtDatetime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtProblem As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtDeptCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chkProblemSolved As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents chkVPNProblem As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents chkPolicyProblem As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
