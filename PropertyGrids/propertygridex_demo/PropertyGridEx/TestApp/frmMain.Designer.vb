Imports PropertyGridEx
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.StatusLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.ContextMenuSaveBooks = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SaveBooksXml = New System.Windows.Forms.ToolStripMenuItem
        Me.ContextMenuSerialize = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.UsingXmlSerializerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UsingBinaryFormatterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ContextMenuSaveItems = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SaveItems = New System.Windows.Forms.ToolStripMenuItem
        Me.Properties = New PropertyGridEx.PropertyGridEx
        Me.ButtonExample1 = New System.Windows.Forms.ToolStripButton
        Me.ButtonExample2 = New System.Windows.Forms.ToolStripButton
        Me.ButtonExample3 = New System.Windows.Forms.ToolStripButton
        Me.ButtonSerialize = New System.Windows.Forms.ToolStripSplitButton
        Me.ButtonXML = New System.Windows.Forms.ToolStripSplitButton
        Me.btnDatatableSample = New System.Windows.Forms.ToolStripMenuItem
        Me.btnXMLEditorSample = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ButtonPrevious = New System.Windows.Forms.ToolStripButton
        Me.ButtonNext = New System.Windows.Forms.ToolStripButton
        Me.StatusStrip1.SuspendLayout()
        Me.ContextMenuSaveBooks.SuspendLayout()
        Me.ContextMenuSerialize.SuspendLayout()
        Me.ContextMenuSaveItems.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Tahoma", 6.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusLabel})
        Me.StatusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 346)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(347, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'StatusLabel
        '
        Me.StatusLabel.AutoToolTip = True
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(0, 17)
        '
        'ContextMenuSaveBooks
        '
        Me.ContextMenuSaveBooks.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveBooksXml})
        Me.ContextMenuSaveBooks.Name = "ContextMenuStrip1"
        Me.ContextMenuSaveBooks.Size = New System.Drawing.Size(171, 26)
        '
        'SaveBooksXml
        '
        Me.SaveBooksXml.Image = CType(resources.GetObject("SaveBooksXml.Image"), System.Drawing.Image)
        Me.SaveBooksXml.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SaveBooksXml.Name = "SaveBooksXml"
        Me.SaveBooksXml.Size = New System.Drawing.Size(170, 22)
        Me.SaveBooksXml.Text = "&Save books.xml"
        '
        'ContextMenuSerialize
        '
        Me.ContextMenuSerialize.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsingXmlSerializerToolStripMenuItem, Me.UsingBinaryFormatterToolStripMenuItem})
        Me.ContextMenuSerialize.Name = "ContextMenuStrip2"
        Me.ContextMenuSerialize.OwnerItem = Me.ButtonSerialize
        Me.ContextMenuSerialize.Size = New System.Drawing.Size(192, 48)
        '
        'UsingXmlSerializerToolStripMenuItem
        '
        Me.UsingXmlSerializerToolStripMenuItem.Name = "UsingXmlSerializerToolStripMenuItem"
        Me.UsingXmlSerializerToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.UsingXmlSerializerToolStripMenuItem.Text = "using XmlSerializer"
        '
        'UsingBinaryFormatterToolStripMenuItem
        '
        Me.UsingBinaryFormatterToolStripMenuItem.Name = "UsingBinaryFormatterToolStripMenuItem"
        Me.UsingBinaryFormatterToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.UsingBinaryFormatterToolStripMenuItem.Text = "using BinaryFormatter"
        '
        'ContextMenuSaveItems
        '
        Me.ContextMenuSaveItems.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveItems})
        Me.ContextMenuSaveItems.Name = "ContextMenuStrip2"
        Me.ContextMenuSaveItems.Size = New System.Drawing.Size(152, 26)
        '
        'SaveItems
        '
        Me.SaveItems.AutoToolTip = True
        Me.SaveItems.Image = CType(resources.GetObject("SaveItems.Image"), System.Drawing.Image)
        Me.SaveItems.Name = "SaveItems"
        Me.SaveItems.Size = New System.Drawing.Size(151, 22)
        Me.SaveItems.Text = "&Save Items..."
        '
        'Properties
        '
        Me.Properties.AutoSizeProperties = True
        '
        '
        '
        Me.Properties.DocCommentDescription.AccessibleName = ""
        Me.Properties.DocCommentDescription.AutoEllipsis = True
        Me.Properties.DocCommentDescription.BackColor = System.Drawing.Color.Transparent
        Me.Properties.DocCommentDescription.Cursor = System.Windows.Forms.Cursors.Default
        Me.Properties.DocCommentDescription.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Properties.DocCommentDescription.Location = New System.Drawing.Point(3, 19)
        Me.Properties.DocCommentDescription.Name = ""
        Me.Properties.DocCommentDescription.Size = New System.Drawing.Size(341, 36)
        Me.Properties.DocCommentDescription.TabIndex = 1
        Me.Properties.DocCommentImage = CType(resources.GetObject("Properties.DocCommentImage"), System.Drawing.Image)
        '
        '
        '
        Me.Properties.DocCommentTitle.AutoSize = True
        Me.Properties.DocCommentTitle.BackColor = System.Drawing.Color.Transparent
        Me.Properties.DocCommentTitle.Cursor = System.Windows.Forms.Cursors.Default
        Me.Properties.DocCommentTitle.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Properties.DocCommentTitle.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Properties.DocCommentTitle.Location = New System.Drawing.Point(3, 3)
        Me.Properties.DocCommentTitle.Name = ""
        Me.Properties.DocCommentTitle.Size = New System.Drawing.Size(111, 13)
        Me.Properties.DocCommentTitle.TabIndex = 0
        Me.Properties.DocCommentTitle.Text = "DocComment Title"
        Me.Properties.DocCommentTitle.UseMnemonic = False
        Me.Properties.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Properties.Location = New System.Drawing.Point(0, 0)
        Me.Properties.Name = "Properties"
        Me.Properties.SelectedObject = Me.Properties.Item
        Me.Properties.ShowCustomProperties = True
        Me.Properties.Size = New System.Drawing.Size(347, 346)
        Me.Properties.TabIndex = 2
        '
        '
        '
        Me.Properties.ToolStrip.AccessibleName = "ToolBar"
        Me.Properties.ToolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        Me.Properties.ToolStrip.AllowMerge = False
        Me.Properties.ToolStrip.AutoSize = False
        Me.Properties.ToolStrip.CanOverflow = False
        Me.Properties.ToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.Properties.ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.Properties.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ButtonExample1, Me.ButtonExample2, Me.ButtonExample3, Me.ButtonSerialize, Me.ButtonXML, Me.ToolStripSeparator1, Me.ButtonPrevious, Me.ButtonNext})
        Me.Properties.ToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.Properties.ToolStrip.Location = New System.Drawing.Point(0, 1)
        Me.Properties.ToolStrip.Name = ""
        Me.Properties.ToolStrip.Padding = New System.Windows.Forms.Padding(2, 0, 1, 0)
        Me.Properties.ToolStrip.Size = New System.Drawing.Size(347, 25)
        Me.Properties.ToolStrip.TabIndex = 1
        Me.Properties.ToolStrip.TabStop = True
        Me.Properties.ToolStrip.Text = "PropertyGridToolBar"
        '
        'ButtonExample1
        '
        Me.ButtonExample1.CheckOnClick = True
        Me.ButtonExample1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ButtonExample1.Image = CType(resources.GetObject("ButtonExample1.Image"), System.Drawing.Image)
        Me.ButtonExample1.ImageTransparentColor = System.Drawing.Color.Black
        Me.ButtonExample1.Name = "ButtonExample1"
        Me.ButtonExample1.Size = New System.Drawing.Size(23, 22)
        Me.ButtonExample1.Text = "Single properties"
        '
        'ButtonExample2
        '
        Me.ButtonExample2.CheckOnClick = True
        Me.ButtonExample2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ButtonExample2.Image = CType(resources.GetObject("ButtonExample2.Image"), System.Drawing.Image)
        Me.ButtonExample2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtonExample2.Name = "ButtonExample2"
        Me.ButtonExample2.Size = New System.Drawing.Size(23, 22)
        Me.ButtonExample2.Text = "Multiple properties"
        '
        'ButtonExample3
        '
        Me.ButtonExample3.CheckOnClick = True
        Me.ButtonExample3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ButtonExample3.Image = CType(resources.GetObject("ButtonExample3.Image"), System.Drawing.Image)
        Me.ButtonExample3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtonExample3.Name = "ButtonExample3"
        Me.ButtonExample3.Size = New System.Drawing.Size(23, 22)
        Me.ButtonExample3.Text = "Databinding properties"
        '
        'ButtonSerialize
        '
        Me.ButtonSerialize.AutoToolTip = False
        Me.ButtonSerialize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ButtonSerialize.DropDown = Me.ContextMenuSerialize
        Me.ButtonSerialize.Image = CType(resources.GetObject("ButtonSerialize.Image"), System.Drawing.Image)
        Me.ButtonSerialize.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtonSerialize.Name = "ButtonSerialize"
        Me.ButtonSerialize.Size = New System.Drawing.Size(32, 22)
        Me.ButtonSerialize.Text = "Load Items"
        Me.ButtonSerialize.ToolTipText = "Load Items..."
        '
        'ButtonXML
        '
        Me.ButtonXML.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ButtonXML.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnDatatableSample, Me.btnXMLEditorSample})
        Me.ButtonXML.Image = CType(resources.GetObject("ButtonXML.Image"), System.Drawing.Image)
        Me.ButtonXML.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ButtonXML.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtonXML.Name = "ButtonXML"
        Me.ButtonXML.Size = New System.Drawing.Size(42, 22)
        Me.ButtonXML.Text = "XML Samples"
        '
        'btnDatatableSample
        '
        Me.btnDatatableSample.Name = "btnDatatableSample"
        Me.btnDatatableSample.Size = New System.Drawing.Size(168, 22)
        Me.btnDatatableSample.Text = "Datatable sample"
        '
        'btnXMLEditorSample
        '
        Me.btnXMLEditorSample.Name = "btnXMLEditorSample"
        Me.btnXMLEditorSample.Size = New System.Drawing.Size(168, 22)
        Me.btnXMLEditorSample.Text = "XML Editor"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        Me.ToolStripSeparator1.Visible = False
        '
        'ButtonPrevious
        '
        Me.ButtonPrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ButtonPrevious.Enabled = False
        Me.ButtonPrevious.Image = CType(resources.GetObject("ButtonPrevious.Image"), System.Drawing.Image)
        Me.ButtonPrevious.ImageTransparentColor = System.Drawing.Color.White
        Me.ButtonPrevious.Name = "ButtonPrevious"
        Me.ButtonPrevious.Size = New System.Drawing.Size(23, 22)
        Me.ButtonPrevious.Text = "Previous"
        Me.ButtonPrevious.Visible = False
        '
        'ButtonNext
        '
        Me.ButtonNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ButtonNext.Image = CType(resources.GetObject("ButtonNext.Image"), System.Drawing.Image)
        Me.ButtonNext.ImageTransparentColor = System.Drawing.Color.White
        Me.ButtonNext.Name = "ButtonNext"
        Me.ButtonNext.Size = New System.Drawing.Size(23, 22)
        Me.ButtonNext.Text = "Next"
        Me.ButtonNext.Visible = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(347, 368)
        Me.Controls.Add(Me.Properties)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.Text = "Test PropertyGridEx"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ContextMenuSaveBooks.ResumeLayout(False)
        Me.ContextMenuSerialize.ResumeLayout(False)
        Me.ContextMenuSaveItems.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonExample1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ButtonExample2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ButtonExample3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ButtonNext As System.Windows.Forms.ToolStripButton
    Friend WithEvents ButtonPrevious As System.Windows.Forms.ToolStripButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents StatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Properties As PropertyGridEx.PropertyGridEx
    Friend WithEvents ContextMenuSaveBooks As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SaveBooksXml As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ButtonSerialize As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents ContextMenuSerialize As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents UsingXmlSerializerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsingBinaryFormatterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuSaveItems As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SaveItems As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ButtonXML As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents btnDatatableSample As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnXMLEditorSample As System.Windows.Forms.ToolStripMenuItem

End Class
