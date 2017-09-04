<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmControllers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmControllers))
        Me.Vulindlela_ControllersBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.Vulindlela_ControllersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.Vulindlela_ControllersBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Vulindlela_ControllersDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RSA = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.NAT = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PROV = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.OwnDept = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.IsACFO = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Monthly_Summary = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ExportToExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Ta_Vulindlela_Controllers = New ADAdminDotNet.dsADSTableAdapters.ta_Vulindlela_Controllers()
        Me.Get_shortcodeTableAdapter1 = New ADAdminDotNet.dsADSTableAdapters.get_shortcodeTableAdapter()
        CType(Me.Vulindlela_ControllersBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Vulindlela_ControllersBindingNavigator.SuspendLayout()
        CType(Me.Vulindlela_ControllersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsADS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vulindlela_ControllersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Vulindlela_ControllersBindingNavigator
        '
        Me.Vulindlela_ControllersBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Vulindlela_ControllersBindingNavigator.BindingSource = Me.Vulindlela_ControllersBindingSource
        Me.Vulindlela_ControllersBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Vulindlela_ControllersBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Vulindlela_ControllersBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Vulindlela_ControllersBindingNavigatorSaveItem})
        Me.Vulindlela_ControllersBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Vulindlela_ControllersBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Vulindlela_ControllersBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Vulindlela_ControllersBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Vulindlela_ControllersBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Vulindlela_ControllersBindingNavigator.Name = "Vulindlela_ControllersBindingNavigator"
        Me.Vulindlela_ControllersBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Vulindlela_ControllersBindingNavigator.Size = New System.Drawing.Size(835, 25)
        Me.Vulindlela_ControllersBindingNavigator.TabIndex = 0
        Me.Vulindlela_ControllersBindingNavigator.Text = "BindingNavigator1"
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
        'Vulindlela_ControllersBindingSource
        '
        Me.Vulindlela_ControllersBindingSource.DataMember = "Vulindlela_Controllers"
        Me.Vulindlela_ControllersBindingSource.DataSource = Me.DsADS
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
        'Vulindlela_ControllersBindingNavigatorSaveItem
        '
        Me.Vulindlela_ControllersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Vulindlela_ControllersBindingNavigatorSaveItem.Image = CType(resources.GetObject("Vulindlela_ControllersBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Vulindlela_ControllersBindingNavigatorSaveItem.Name = "Vulindlela_ControllersBindingNavigatorSaveItem"
        Me.Vulindlela_ControllersBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Vulindlela_ControllersBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Vulindlela_ControllersDataGridView
        '
        Me.Vulindlela_ControllersDataGridView.AutoGenerateColumns = False
        Me.Vulindlela_ControllersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Vulindlela_ControllersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Vulindlela_ControllersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.RSA, Me.NAT, Me.PROV, Me.OwnDept, Me.IsACFO, Me.Monthly_Summary})
        Me.Vulindlela_ControllersDataGridView.DataSource = Me.Vulindlela_ControllersBindingSource
        Me.Vulindlela_ControllersDataGridView.Location = New System.Drawing.Point(2, 26)
        Me.Vulindlela_ControllersDataGridView.Name = "Vulindlela_ControllersDataGridView"
        Me.Vulindlela_ControllersDataGridView.RowHeadersWidth = 4
        Me.Vulindlela_ControllersDataGridView.Size = New System.Drawing.Size(831, 586)
        Me.Vulindlela_ControllersDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "FullName"
        Me.DataGridViewTextBoxColumn1.FillWeight = 190.0!
        Me.DataGridViewTextBoxColumn1.HeaderText = "Full Name"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 190
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 190
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "EMail"
        Me.DataGridViewTextBoxColumn2.FillWeight = 190.0!
        Me.DataGridViewTextBoxColumn2.HeaderText = "EMail Address"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 99
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "SCode"
        Me.DataGridViewTextBoxColumn3.FillWeight = 70.0!
        Me.DataGridViewTextBoxColumn3.HeaderText = "SCode"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 64
        '
        'RSA
        '
        Me.RSA.DataPropertyName = "Controller_RSA"
        Me.RSA.FalseValue = "False"
        Me.RSA.FillWeight = 30.0!
        Me.RSA.HeaderText = "RSA"
        Me.RSA.IndeterminateValue = "False"
        Me.RSA.Name = "RSA"
        Me.RSA.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.RSA.ThreeState = True
        Me.RSA.TrueValue = "True"
        Me.RSA.Width = 35
        '
        'NAT
        '
        Me.NAT.DataPropertyName = "Controller_NAT"
        Me.NAT.FalseValue = "False"
        Me.NAT.FillWeight = 30.0!
        Me.NAT.HeaderText = "NAT"
        Me.NAT.IndeterminateValue = "False"
        Me.NAT.Name = "NAT"
        Me.NAT.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.NAT.ThreeState = True
        Me.NAT.TrueValue = "True"
        Me.NAT.Width = 35
        '
        'PROV
        '
        Me.PROV.DataPropertyName = "Controller_Prov"
        Me.PROV.FalseValue = "False"
        Me.PROV.FillWeight = 30.0!
        Me.PROV.HeaderText = "PROV"
        Me.PROV.IndeterminateValue = "False"
        Me.PROV.Name = "PROV"
        Me.PROV.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PROV.ThreeState = True
        Me.PROV.TrueValue = "True"
        Me.PROV.Width = 43
        '
        'OwnDept
        '
        Me.OwnDept.DataPropertyName = "Controller_Dept"
        Me.OwnDept.FalseValue = "False"
        Me.OwnDept.HeaderText = "OwnDept"
        Me.OwnDept.IndeterminateValue = "Fasle"
        Me.OwnDept.Name = "OwnDept"
        Me.OwnDept.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.OwnDept.ThreeState = True
        Me.OwnDept.TrueValue = "True"
        Me.OwnDept.Width = 58
        '
        'IsACFO
        '
        Me.IsACFO.DataPropertyName = "CFO"
        Me.IsACFO.FalseValue = "False"
        Me.IsACFO.HeaderText = "Is CFO?"
        Me.IsACFO.IndeterminateValue = "False"
        Me.IsACFO.Name = "IsACFO"
        Me.IsACFO.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IsACFO.ThreeState = True
        Me.IsACFO.TrueValue = "True"
        Me.IsACFO.Width = 51
        '
        'Monthly_Summary
        '
        Me.Monthly_Summary.DataPropertyName = "Monthly_Summary"
        Me.Monthly_Summary.FalseValue = "False"
        Me.Monthly_Summary.HeaderText = "Get Summary?"
        Me.Monthly_Summary.IndeterminateValue = "False"
        Me.Monthly_Summary.Name = "Monthly_Summary"
        Me.Monthly_Summary.ThreeState = True
        Me.Monthly_Summary.TrueValue = "True"
        Me.Monthly_Summary.Width = 82
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 612)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(835, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportToExcelToolStripMenuItem, Me.ToolStripMenuItem1, Me.ToolStripMenuItem2})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(80, 20)
        Me.ToolStripDropDownButton1.Text = "Export Data"
        '
        'ExportToExcelToolStripMenuItem
        '
        Me.ExportToExcelToolStripMenuItem.Name = "ExportToExcelToolStripMenuItem"
        Me.ExportToExcelToolStripMenuItem.Size = New System.Drawing.Size(306, 22)
        Me.ExportToExcelToolStripMenuItem.Text = "Export to Vulindlela_User_Distributionlist.csv"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(303, 6)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(306, 22)
        Me.ToolStripMenuItem2.Text = "Cancel"
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(453, 342)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(59, 43)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Button1"
        Me.btnClose.UseVisualStyleBackColor = True
        Me.btnClose.Visible = False
        '
        'Ta_Vulindlela_Controllers
        '
        Me.Ta_Vulindlela_Controllers.ClearBeforeFill = True
        '
        'Get_shortcodeTableAdapter1
        '
        Me.Get_shortcodeTableAdapter1.ClearBeforeFill = True
        '
        'frmControllers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(835, 634)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Vulindlela_ControllersDataGridView)
        Me.Controls.Add(Me.Vulindlela_ControllersBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmControllers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vulindlela  Controllers and CFO's"
        CType(Me.Vulindlela_ControllersBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Vulindlela_ControllersBindingNavigator.ResumeLayout(False)
        Me.Vulindlela_ControllersBindingNavigator.PerformLayout()
        CType(Me.Vulindlela_ControllersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsADS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vulindlela_ControllersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DsADS As Global.ADAdminDotNet.dsADS
    Friend WithEvents Vulindlela_ControllersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ta_Vulindlela_Controllers As Global.ADAdminDotNet.dsADSTableAdapters.ta_Vulindlela_Controllers
    Friend WithEvents Vulindlela_ControllersBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Vulindlela_ControllersBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Vulindlela_ControllersDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ExportToExcelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Get_shortcodeTableAdapter1 As Global.ADAdminDotNet.dsADSTableAdapters.get_shortcodeTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RSA As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents NAT As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents PROV As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents OwnDept As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents IsACFO As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Monthly_Summary As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
