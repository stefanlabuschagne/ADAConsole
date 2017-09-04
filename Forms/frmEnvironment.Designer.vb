<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEnvironment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEnvironment))
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.btnPRD = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnQa = New System.Windows.Forms.ToolStripButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.AutomationTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Ads1 = New ADAdminDotNet.dsADS()
        Me.KICKOUTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KICKOUTTableAdapter = New ADAdminDotNet.dsADSTableAdapters.KICKOUTTableAdapter()
        Me.ToolStrip.SuspendLayout()
        CType(Me.Ads1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KICKOUTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip
        '
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPRD, Me.ToolStripSeparator2, Me.btnQa})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(1001, 25)
        Me.ToolStrip.TabIndex = 6
        Me.ToolStrip.Text = "ToolStrip"
        '
        'btnPRD
        '
        Me.btnPRD.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnPRD.Image = CType(resources.GetObject("btnPRD.Image"), System.Drawing.Image)
        Me.btnPRD.ImageTransparentColor = System.Drawing.Color.Black
        Me.btnPRD.Name = "btnPRD"
        Me.btnPRD.Size = New System.Drawing.Size(33, 22)
        Me.btnPRD.Text = "PRD"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btnQa
        '
        Me.btnQa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnQa.Image = CType(resources.GetObject("btnQa.Image"), System.Drawing.Image)
        Me.btnQa.ImageTransparentColor = System.Drawing.Color.Black
        Me.btnQa.Name = "btnQa"
        Me.btnQa.Size = New System.Drawing.Size(28, 22)
        Me.btnQa.Text = "QA"
        '
        'AutomationTimer
        '
        Me.AutomationTimer.Interval = 5000
        '
        'Ads1
        '
        Me.Ads1.DataSetName = "ads"
        Me.Ads1.EnforceConstraints = False
        Me.Ads1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KICKOUTBindingSource
        '
        Me.KICKOUTBindingSource.DataMember = "KICKOUT"
        Me.KICKOUTBindingSource.DataSource = Me.Ads1
        '
        'KICKOUTTableAdapter
        '
        Me.KICKOUTTableAdapter.ClearBeforeFill = True
        '
        'frmEnvironment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1001, 841)
        Me.Controls.Add(Me.ToolStrip)
        Me.IsMdiContainer = True
        Me.Name = "frmEnvironment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AD Admin DotNet 3.5"
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        CType(Me.Ads1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KICKOUTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPRD As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents btnQa As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Ads1 As Global.ADAdminDotNet.dsADS
    Friend WithEvents KICKOUTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KICKOUTTableAdapter As dsADSTableAdapters.KICKOUTTableAdapter
    Friend WithEvents AutomationTimer As System.Windows.Forms.Timer

End Class
