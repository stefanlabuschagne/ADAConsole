<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsersNotOnEstab
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsersNotOnEstab))
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.txt_Not_On_Estab_Thismonth = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Ads = New ADAdminDotNet.dsADS()
        Me.Not_On_Estab_Thismonth_CountBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Not_On_Estab_Thismonth_CountTableAdapter = New ADAdminDotNet.dsADSTableAdapters.Not_On_Estab_Thismonth_CountTableAdapter()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.Ads, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Not_On_Estab_Thismonth_CountBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()

        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(140, 95)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 25)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "Calculate values"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(250, 95)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 25)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Export to Excel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(342, 77)
        Me.TabControl1.TabIndex = 35
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button5)
        Me.TabPage1.Controls.Add(Me.txt_Not_On_Estab_Thismonth)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(334, 51)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Establishment Stats"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Enabled = False
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.ForeColor = System.Drawing.Color.Transparent
        Me.Button5.Image = Global.ADAdminDotNet.My.Resources.Resources.imgExcel
        Me.Button5.Location = New System.Drawing.Point(292, 14)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(24, 24)
        Me.Button5.TabIndex = 39
        Me.Button5.UseVisualStyleBackColor = True
        '
        'txt_Not_On_Estab_Thismonth
        '
        Me.txt_Not_On_Estab_Thismonth.BackColor = System.Drawing.SystemColors.Window
        Me.txt_Not_On_Estab_Thismonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Not_On_Estab_Thismonth.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_Not_On_Estab_Thismonth.Location = New System.Drawing.Point(220, 16)
        Me.txt_Not_On_Estab_Thismonth.Name = "txt_Not_On_Estab_Thismonth"
        Me.txt_Not_On_Estab_Thismonth.Size = New System.Drawing.Size(67, 20)
        Me.txt_Not_On_Estab_Thismonth.TabIndex = 36
        Me.txt_Not_On_Estab_Thismonth.Text = "0"
        Me.txt_Not_On_Estab_Thismonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(186, 13)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Users not on Establishment this month"
        '
        'Ads
        '
        Me.Ads.DataSetName = "ads"
        Me.Ads.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Not_On_Estab_Thismonth_CountBindingSource
        '
        Me.Not_On_Estab_Thismonth_CountBindingSource.DataMember = "Not_On_Estab_Thismonth_Count"
        Me.Not_On_Estab_Thismonth_CountBindingSource.DataSource = Me.Ads
        '
        'Not_On_Estab_Thismonth_CountTableAdapter
        '
        Me.Not_On_Estab_Thismonth_CountTableAdapter.ClearBeforeFill = True
        '
        'frmUsersNotOnEstab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 129)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmUsersNotOnEstab"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stats (Establishment)"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.Ads, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Not_On_Estab_Thismonth_CountBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents txt_Not_On_Estab_Thismonth As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Ads As ADAdminDotNet.dsADS
    Friend WithEvents Not_On_Estab_Thismonth_CountBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Not_On_Estab_Thismonth_CountTableAdapter As ADAdminDotNet.dsADSTableAdapters.Not_On_Estab_Thismonth_CountTableAdapter
End Class
