<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVariationList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVariationList))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.AD_SNAPSHOT_EXCEPTIONSBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.AD_SNAPSHOT_EXCEPTIONSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsADS = New Global.ADAdminDotNet.dsADS()
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
        Me.AD_SNAPSHOT_EXCEPTIONSBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.AD_SNAPSHOT_EXCEPTIONSDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpiryDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AD_SNAPSHOT_EXCEPTIONSTableAdapter = New Global.ADAdminDotNet.dsADSTableAdapters.AD_SNAPSHOT_EXCEPTIONSTableAdapter()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripSplitButton()
        Me.ExportToCSVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.AD_SNAPSHOT_EXCEPTIONSBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AD_SNAPSHOT_EXCEPTIONSBindingNavigator.SuspendLayout()
        CType(Me.AD_SNAPSHOT_EXCEPTIONSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsADS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AD_SNAPSHOT_EXCEPTIONSDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()

        '
        'AD_SNAPSHOT_EXCEPTIONSBindingNavigator
        '
        Me.AD_SNAPSHOT_EXCEPTIONSBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AD_SNAPSHOT_EXCEPTIONSBindingNavigator.BindingSource = Me.AD_SNAPSHOT_EXCEPTIONSBindingSource
        Me.AD_SNAPSHOT_EXCEPTIONSBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AD_SNAPSHOT_EXCEPTIONSBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.AD_SNAPSHOT_EXCEPTIONSBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.AD_SNAPSHOT_EXCEPTIONSBindingNavigatorSaveItem, Me.ToolStripButton1})
        Me.AD_SNAPSHOT_EXCEPTIONSBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AD_SNAPSHOT_EXCEPTIONSBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AD_SNAPSHOT_EXCEPTIONSBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AD_SNAPSHOT_EXCEPTIONSBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AD_SNAPSHOT_EXCEPTIONSBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AD_SNAPSHOT_EXCEPTIONSBindingNavigator.Name = "AD_SNAPSHOT_EXCEPTIONSBindingNavigator"
        Me.AD_SNAPSHOT_EXCEPTIONSBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AD_SNAPSHOT_EXCEPTIONSBindingNavigator.Size = New System.Drawing.Size(626, 25)
        Me.AD_SNAPSHOT_EXCEPTIONSBindingNavigator.TabIndex = 0
        Me.AD_SNAPSHOT_EXCEPTIONSBindingNavigator.Text = "BindingNavigator1"
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
        'AD_SNAPSHOT_EXCEPTIONSBindingSource
        '
        Me.AD_SNAPSHOT_EXCEPTIONSBindingSource.DataMember = "AD_SNAPSHOT_EXCEPTIONS"
        Me.AD_SNAPSHOT_EXCEPTIONSBindingSource.DataSource = Me.DsADS
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
        'AD_SNAPSHOT_EXCEPTIONSBindingNavigatorSaveItem
        '
        Me.AD_SNAPSHOT_EXCEPTIONSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AD_SNAPSHOT_EXCEPTIONSBindingNavigatorSaveItem.Image = CType(resources.GetObject("AD_SNAPSHOT_EXCEPTIONSBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AD_SNAPSHOT_EXCEPTIONSBindingNavigatorSaveItem.Name = "AD_SNAPSHOT_EXCEPTIONSBindingNavigatorSaveItem"
        Me.AD_SNAPSHOT_EXCEPTIONSBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.AD_SNAPSHOT_EXCEPTIONSBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(125, 22)
        Me.ToolStripButton1.Text = "Add The Current User"
        '
        'AD_SNAPSHOT_EXCEPTIONSDataGridView
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Moccasin
        Me.AD_SNAPSHOT_EXCEPTIONSDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.AD_SNAPSHOT_EXCEPTIONSDataGridView.AutoGenerateColumns = False
        Me.AD_SNAPSHOT_EXCEPTIONSDataGridView.ColumnHeadersHeight = 19
        Me.AD_SNAPSHOT_EXCEPTIONSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.AD_SNAPSHOT_EXCEPTIONSDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.ExpiryDate})
        Me.AD_SNAPSHOT_EXCEPTIONSDataGridView.DataSource = Me.AD_SNAPSHOT_EXCEPTIONSBindingSource
        Me.AD_SNAPSHOT_EXCEPTIONSDataGridView.Location = New System.Drawing.Point(0, 28)
        Me.AD_SNAPSHOT_EXCEPTIONSDataGridView.Name = "AD_SNAPSHOT_EXCEPTIONSDataGridView"
        Me.AD_SNAPSHOT_EXCEPTIONSDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.AD_SNAPSHOT_EXCEPTIONSDataGridView.RowHeadersWidth = 4
        Me.AD_SNAPSHOT_EXCEPTIONSDataGridView.RowTemplate.Height = 18
        Me.AD_SNAPSHOT_EXCEPTIONSDataGridView.Size = New System.Drawing.Size(625, 443)
        Me.AD_SNAPSHOT_EXCEPTIONSDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "AccountNr"
        Me.DataGridViewTextBoxColumn2.HeaderText = "AccountNr"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "FirstName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "FirstName"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Lastname"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Lastname"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 200
        '
        'ExpiryDate
        '
        Me.ExpiryDate.DataPropertyName = "ExpiryDate"
        Me.ExpiryDate.HeaderText = "ExpiryDate"
        Me.ExpiryDate.Name = "ExpiryDate"
        Me.ExpiryDate.ToolTipText = "yyyy/mm/dd"
        '
        'AD_SNAPSHOT_EXCEPTIONSTableAdapter
        '
        Me.AD_SNAPSHOT_EXCEPTIONSTableAdapter.ClearBeforeFill = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 474)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode
        Me.StatusStrip1.Size = New System.Drawing.Size(626, 22)
        Me.StatusStrip1.TabIndex = 2
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
        Me.ExportToCSVToolStripMenuItem.Size = New System.Drawing.Size(264, 22)
        Me.ExportToCSVToolStripMenuItem.Text = "Export to Profiling_Variation_List.csv"
        '
        'frmVariationList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 496)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.AD_SNAPSHOT_EXCEPTIONSDataGridView)
        Me.Controls.Add(Me.AD_SNAPSHOT_EXCEPTIONSBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmVariationList"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Variation List"
        CType(Me.AD_SNAPSHOT_EXCEPTIONSBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AD_SNAPSHOT_EXCEPTIONSBindingNavigator.ResumeLayout(False)
        Me.AD_SNAPSHOT_EXCEPTIONSBindingNavigator.PerformLayout()
        CType(Me.AD_SNAPSHOT_EXCEPTIONSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsADS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AD_SNAPSHOT_EXCEPTIONSDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DsADS As Global.ADAdminDotNet.dsADS
    Friend WithEvents AD_SNAPSHOT_EXCEPTIONSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AD_SNAPSHOT_EXCEPTIONSTableAdapter As Global.ADAdminDotNet.dsADSTableAdapters.AD_SNAPSHOT_EXCEPTIONSTableAdapter
    Friend WithEvents AD_SNAPSHOT_EXCEPTIONSBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents AD_SNAPSHOT_EXCEPTIONSBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents AD_SNAPSHOT_EXCEPTIONSDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExpiryDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents ExportToCSVToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
