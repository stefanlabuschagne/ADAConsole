<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRunSSIS
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
        Dim Database_idLabel As System.Windows.Forms.Label
        Me.Ds = New WindowsApplication3.ds()
        Me.View_Stageable_ApplicationsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Stageable_ApplicationsTableAdapter = New WindowsApplication3.dsTableAdapters.View_Stageable_ApplicationsTableAdapter()
        Me.TableAdapterManager = New WindowsApplication3.dsTableAdapters.TableAdapterManager()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.NameComboBox = New System.Windows.Forms.ComboBox()
        Me.ViewStageableApplicationsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.txtLog = New System.Windows.Forms.TextBox()
        Database_idLabel = New System.Windows.Forms.Label()
        CType(Me.Ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Stageable_ApplicationsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewStageableApplicationsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Database_idLabel
        '
        Database_idLabel.AutoSize = True
        Database_idLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Database_idLabel.Location = New System.Drawing.Point(12, 59)
        Database_idLabel.Name = "Database_idLabel"
        Database_idLabel.Size = New System.Drawing.Size(134, 17)
        Database_idLabel.TabIndex = 2
        Database_idLabel.Text = "Application to Stage"
        '
        'Ds
        '
        Me.Ds.DataSetName = "ds"
        Me.Ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'View_Stageable_ApplicationsBindingSource
        '
        Me.View_Stageable_ApplicationsBindingSource.DataMember = "View_Stageable_Applications"
        Me.View_Stageable_ApplicationsBindingSource.DataSource = Me.Ds
        '
        'View_Stageable_ApplicationsTableAdapter
        '
        Me.View_Stageable_ApplicationsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication3.dsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 248)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(472, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(375, 76)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 30)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Execute"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'NameComboBox
        '
        Me.NameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Stageable_ApplicationsBindingSource, "name", True))
        Me.NameComboBox.DataSource = Me.Ds
        Me.NameComboBox.DisplayMember = "View_Stageable_Applications.name"
        Me.NameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.NameComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameComboBox.FormattingEnabled = True
        Me.NameComboBox.Location = New System.Drawing.Point(12, 80)
        Me.NameComboBox.Name = "NameComboBox"
        Me.NameComboBox.Size = New System.Drawing.Size(357, 24)
        Me.NameComboBox.TabIndex = 5
        Me.NameComboBox.ValueMember = "View_Stageable_Applications.name"
        '
        'ViewStageableApplicationsBindingSource
        '
        Me.ViewStageableApplicationsBindingSource.DataMember = "View_Stageable_Applications"
        Me.ViewStageableApplicationsBindingSource.DataSource = Me.Ds
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(12, 21)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(524, 21)
        Me.LinkLabel1.TabIndex = 6
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = Global.WindowsApplication3.My.MySettings.Default.PakageFilePath
        Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.DefaultExt = "dtsx"
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "DTS Packages|*.dtsx|All Files|*.*"
        '
        'txtLog
        '
        Me.txtLog.Location = New System.Drawing.Point(15, 111)
        Me.txtLog.Multiline = True
        Me.txtLog.Name = "txtLog"
        Me.txtLog.Size = New System.Drawing.Size(450, 128)
        Me.txtLog.TabIndex = 7
        '
        'frmRunSSIS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 270)
        Me.Controls.Add(Me.txtLog)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.NameComboBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Database_idLabel)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "frmRunSSIS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Execute SQL Server Package"
        Me.TopMost = True
        CType(Me.Ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Stageable_ApplicationsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewStageableApplicationsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Ds As WindowsApplication3.ds
    Friend WithEvents View_Stageable_ApplicationsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Stageable_ApplicationsTableAdapter As WindowsApplication3.dsTableAdapters.View_Stageable_ApplicationsTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication3.dsTableAdapters.TableAdapterManager
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents NameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ViewStageableApplicationsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtLog As System.Windows.Forms.TextBox

End Class
