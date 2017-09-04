<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOptionsDialog
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOptionsDialog))
        Me.PropertyGrid1 = New System.Windows.Forms.PropertyGrid
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ResetToDeaultToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.CancelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.tsBtnSAVE = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tsBtnOpenHosts = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.tsBtnEditConfigFile = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.tsCloseBrowsers = New System.Windows.Forms.ToolStripButton
        Me.tsClose = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.TestWebbrowser = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ContextMenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PropertyGrid1
        '
        Me.PropertyGrid1.CategoryForeColor = System.Drawing.Color.DarkBlue
        Me.PropertyGrid1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.PropertyGrid1.LineColor = System.Drawing.SystemColors.Control
        Me.PropertyGrid1.Location = New System.Drawing.Point(0, 44)
        Me.PropertyGrid1.Margin = New System.Windows.Forms.Padding(2)
        Me.PropertyGrid1.Name = "PropertyGrid1"
        Me.PropertyGrid1.Size = New System.Drawing.Size(1019, 661)
        Me.PropertyGrid1.TabIndex = 7
        Me.PropertyGrid1.ViewForeColor = System.Drawing.SystemColors.WindowFrame
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResetToDeaultToolStripMenuItem, Me.ToolStripMenuItem2, Me.CancelToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(158, 54)
        '
        'ResetToDeaultToolStripMenuItem
        '
        Me.ResetToDeaultToolStripMenuItem.Name = "ResetToDeaultToolStripMenuItem"
        Me.ResetToDeaultToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.ResetToDeaultToolStripMenuItem.Text = "Reset to Default"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(154, 6)
        '
        'CancelToolStripMenuItem
        '
        Me.CancelToolStripMenuItem.Name = "CancelToolStripMenuItem"
        Me.CancelToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.CancelToolStripMenuItem.Text = "Cancel"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(23, 23)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsBtnSAVE, Me.ToolStripSeparator1, Me.tsBtnOpenHosts, Me.ToolStripSeparator3, Me.tsBtnEditConfigFile, Me.ToolStripSeparator5, Me.tsCloseBrowsers, Me.tsClose, Me.ToolStripSeparator2, Me.TestWebbrowser, Me.ToolStripSeparator4, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(2)
        Me.ToolStrip1.Size = New System.Drawing.Size(1019, 39)
        Me.ToolStrip1.TabIndex = 6
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsBtnSAVE
        '
        Me.tsBtnSAVE.Image = CType(resources.GetObject("tsBtnSAVE.Image"), System.Drawing.Image)
        Me.tsBtnSAVE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsBtnSAVE.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnSAVE.Margin = New System.Windows.Forms.Padding(2)
        Me.tsBtnSAVE.Name = "tsBtnSAVE"
        Me.tsBtnSAVE.Padding = New System.Windows.Forms.Padding(2)
        Me.tsBtnSAVE.Size = New System.Drawing.Size(139, 31)
        Me.tsBtnSAVE.Text = "&Save Configuration"
        Me.tsBtnSAVE.ToolTipText = "Save Config"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 35)
        Me.ToolStripSeparator1.Visible = False
        '
        'tsBtnOpenHosts
        '
        Me.tsBtnOpenHosts.Image = Global.ADAdminDotNet.My.Resources.Resources.nav_new
        Me.tsBtnOpenHosts.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnOpenHosts.Name = "tsBtnOpenHosts"
        Me.tsBtnOpenHosts.Padding = New System.Windows.Forms.Padding(2)
        Me.tsBtnOpenHosts.Size = New System.Drawing.Size(121, 32)
        Me.tsBtnOpenHosts.Text = "Open Hosts File"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 35)
        '
        'tsBtnEditConfigFile
        '
        Me.tsBtnEditConfigFile.Image = Global.ADAdminDotNet.My.Resources.Resources.imgADS
        Me.tsBtnEditConfigFile.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnEditConfigFile.Name = "tsBtnEditConfigFile"
        Me.tsBtnEditConfigFile.Padding = New System.Windows.Forms.Padding(2)
        Me.tsBtnEditConfigFile.Size = New System.Drawing.Size(118, 32)
        Me.tsBtnEditConfigFile.Text = "Edit Config File"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 35)
        Me.ToolStripSeparator5.Visible = False
        '
        'tsCloseBrowsers
        '
        Me.tsCloseBrowsers.Image = CType(resources.GetObject("tsCloseBrowsers.Image"), System.Drawing.Image)
        Me.tsCloseBrowsers.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsCloseBrowsers.Name = "tsCloseBrowsers"
        Me.tsCloseBrowsers.Padding = New System.Windows.Forms.Padding(2)
        Me.tsCloseBrowsers.Size = New System.Drawing.Size(134, 32)
        Me.tsCloseBrowsers.Text = "Close All Browsers"
        '
        'tsClose
        '
        Me.tsClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        '  Me.tsClose.Image = Global.ADAdminDotNet.My.Resources.Resources.shell32_dll_I0149_0409
        Me.tsClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsClose.Name = "tsClose"
        Me.tsClose.Padding = New System.Windows.Forms.Padding(2)
        Me.tsClose.Size = New System.Drawing.Size(67, 32)
        Me.tsClose.Text = "Close"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 35)
        '
        'TestWebbrowser
        '
        Me.TestWebbrowser.Image = Global.ADAdminDotNet.My.Resources.Resources.target
        Me.TestWebbrowser.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TestWebbrowser.Name = "TestWebbrowser"
        Me.TestWebbrowser.Size = New System.Drawing.Size(125, 32)
        Me.TestWebbrowser.Text = "Test Webbrowser"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 35)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.ADAdminDotNet.My.Resources.Resources.airplane
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(213, 32)
        Me.ToolStripButton1.Text = "MX Lookup vults@treasury.gov.za"
        '
        'frmOptionsDialog
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(1019, 761)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.PropertyGrid1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOptionsDialog"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Application Configuration"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PropertyGrid1 As System.Windows.Forms.PropertyGrid
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsBtnSAVE As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ResetToDeaultToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CancelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsBtnOpenHosts As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsBtnEditConfigFile As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsCloseBrowsers As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TestWebbrowser As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
End Class
