Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Xml

Namespace DotBits.Configuration
	''' <summary>
	''' The application will be compiled both as a .DLL and a .EXE. The DLL can be referenced
	''' by other Windows Forms applications and used to instantiate the ConfigEditor form. 
	''' If ConfigEditor is called from the DLL - static void Main(string[] args) will not
	''' be called - in which case the constructor will determine the configuration
	''' filename.
	''' 
	''' If the .EXE is called - optional args can be supplied to specify the Xml configuration
	''' file to use.
	''' 
	''' Configuration Loading and Saving methods have been kept clean from the interface
	''' event handlers. Compiled as a .DLL these methods could be called from an administrative
	''' ASP.Net Web Form which would could add text controls dynamically to the page to build a
	''' Web Form that contains all the key value pairs for all the properties in the custom
	''' class - allowing the configuration of the Web application to be set or changed remotely.
	''' </summary>		
	Public Class ConfigEditor
		Inherits System.Windows.Forms.Form

		#Region "Variables, Properties and Controls"

		'private data
		Private _configFilename As String = ""
		Private _isDirty As Boolean
		Private Property IsDirty() As Boolean
			Get
				Return _isDirty
			End Get
			Set
				_isDirty = value
			End Set
		End Property

		'public properties
		Public Overridable Property ConfigFilename() As String
			Get
				Return _configFilename
			End Get
			Set
				_configFilename = value
				Me.txtConfigurationFile.Text = _configFilename
			End Set
		End Property

		'Controls
		Private btnSave As System.Windows.Forms.Button
		Private btnClose As System.Windows.Forms.Button
		Private txtConfigurationFile As System.Windows.Forms.TextBox
		Private propertyGrid1 As System.Windows.Forms.PropertyGrid
		Private btnLoad As System.Windows.Forms.Button
		Private openFileDialog1 As System.Windows.Forms.OpenFileDialog
		Private groupBox1 As System.Windows.Forms.GroupBox
		Private lblTitle As System.Windows.Forms.Label
		Private pictureBox1 As System.Windows.Forms.PictureBox

		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		#End Region

		''' <summary>
		''' If called from static void Main(string[] args) during a .EXE startup, 
		''' then the the value of this.ConfigFilename may be overwritten by an optional 
		''' argument passed to Main.
		''' </summary>
		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'Set the configuration file value based on a couple of rules.
			'If Bin is the last directory in the Executable path, then it's in a 
			'Web/Bin directory and we'll load Web.config from the directory above. 
			'If not, then we'll look for a configuration file in the executable
			'directory *.Config (if for some reason there is more than one - which there
			'shoudn't be - we'll take the first one).
			'If we're being called from Main(string[] args) and a parameter was 
			'passed then this value will be replaced when Main(string[] args) completes.
			Dim dir As String = System.IO.Path.GetDirectoryName(Application.ExecutablePath)
			If dir.LastIndexOf("\bin") = dir.Length - 4 Then
				'\Bin is at the end of the directory path and the application has been called
				'from a Web project folder.
				Me.ConfigFilename = dir.Remove(dir.Length - 3, 3) + "Web.Config"
			Else
				Dim configFiles As String() = System.IO.Directory.GetFiles(dir, "*.Config")
				If configFiles.Length > 0 Then
					Me.ConfigFilename = configFiles(0)
				Else
					Me.ConfigFilename = ""
				End If
			End If
		End Sub

		''' <summary>
		''' If the .EXE is called, optional args can be supplied to specify the Xml configuration
		''' file to use.
		''' </summary>
		<STAThread()> _
		Private Shared Sub Main(ByVal args As String())
			Dim frmConfig As New ConfigEditor()
			If args.Length > 0 Then
				frmConfig.ConfigFilename = args(0)
			End If
			Application.Run(frmConfig)
		End Sub

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConfigEditor))
            Me.btnSave = New System.Windows.Forms.Button
            Me.btnClose = New System.Windows.Forms.Button
            Me.txtConfigurationFile = New System.Windows.Forms.TextBox
            Me.propertyGrid1 = New System.Windows.Forms.PropertyGrid
            Me.btnLoad = New System.Windows.Forms.Button
            Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog
            Me.groupBox1 = New System.Windows.Forms.GroupBox
            Me.pictureBox1 = New System.Windows.Forms.PictureBox
            Me.lblTitle = New System.Windows.Forms.Label
            Me.groupBox1.SuspendLayout()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'btnSave
            '
            Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSave.Location = New System.Drawing.Point(404, 541)
            Me.btnSave.Name = "btnSave"
            Me.btnSave.Size = New System.Drawing.Size(120, 24)
            Me.btnSave.TabIndex = 1
            Me.btnSave.Text = "&Save Settings"
            '
            'btnClose
            '
            Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnClose.Location = New System.Drawing.Point(532, 541)
            Me.btnClose.Name = "btnClose"
            Me.btnClose.Size = New System.Drawing.Size(64, 24)
            Me.btnClose.TabIndex = 2
            Me.btnClose.Text = "&Done"
            '
            'txtConfigurationFile
            '
            Me.txtConfigurationFile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtConfigurationFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtConfigurationFile.Location = New System.Drawing.Point(7, 509)
            Me.txtConfigurationFile.Name = "txtConfigurationFile"
            Me.txtConfigurationFile.ReadOnly = True
            Me.txtConfigurationFile.Size = New System.Drawing.Size(557, 20)
            Me.txtConfigurationFile.TabIndex = 16
            '
            'propertyGrid1
            '
            Me.propertyGrid1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.propertyGrid1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.propertyGrid1.LineColor = System.Drawing.SystemColors.ScrollBar
            Me.propertyGrid1.Location = New System.Drawing.Point(7, 49)
            Me.propertyGrid1.Name = "propertyGrid1"
            Me.propertyGrid1.PropertySort = System.Windows.Forms.PropertySort.Categorized
            Me.propertyGrid1.Size = New System.Drawing.Size(589, 454)
            Me.propertyGrid1.TabIndex = 0
            Me.propertyGrid1.ToolbarVisible = False
            '
            'btnLoad
            '
            Me.btnLoad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnLoad.Location = New System.Drawing.Point(572, 509)
            Me.btnLoad.Name = "btnLoad"
            Me.btnLoad.Size = New System.Drawing.Size(24, 20)
            Me.btnLoad.TabIndex = 17
            Me.btnLoad.Text = "..."
            '
            'groupBox1
            '
            Me.groupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.groupBox1.BackColor = System.Drawing.Color.White
            Me.groupBox1.Controls.Add(Me.pictureBox1)
            Me.groupBox1.Controls.Add(Me.lblTitle)
            Me.groupBox1.Location = New System.Drawing.Point(-16, -24)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(635, 66)
            Me.groupBox1.TabIndex = 18
            Me.groupBox1.TabStop = False
            '
            'pictureBox1
            '
            Me.pictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
            Me.pictureBox1.Location = New System.Drawing.Point(579, 28)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(48, 31)
            Me.pictureBox1.TabIndex = 1
            Me.pictureBox1.TabStop = False
            '
            'lblTitle
            '
            Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTitle.Location = New System.Drawing.Point(32, 29)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New System.Drawing.Size(272, 29)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "Application Settings"
            '
            'ConfigEditor
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(605, 573)
            Me.Controls.Add(Me.groupBox1)
            Me.Controls.Add(Me.btnLoad)
            Me.Controls.Add(Me.propertyGrid1)
            Me.Controls.Add(Me.txtConfigurationFile)
            Me.Controls.Add(Me.btnClose)
            Me.Controls.Add(Me.btnSave)
            Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "ConfigEditor"
            Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Application Configuration"
            Me.groupBox1.ResumeLayout(False)
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
		#End Region

		#Region "Form Layout and Event Handlers"
		''' <summary>
		''' On FormLoad event handler which will call the LoadConfiguration helper method.
		''' /// <param name="sender"></param>
		''' <param name="e"></param>
        Private Sub ConfigEditor_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Try
                If System.IO.File.Exists(Me.ConfigFilename) Then
                    Me.propertyGrid1.SelectedObject = LoadConfiguration(Me.ConfigFilename)
                    LayoutForm(DirectCast(Me.propertyGrid1.SelectedObject, CustomClass))
                End If
            Catch ex As Exception
                MessageBox.Show("Failed to load the configuration file. Reason(" + ex.Message + ")", "Application Configuration", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
            Me.propertyGrid1.Focus()
        End Sub


        ''' <summary>
        ''' Check the state of IsDirty before closing the form and prompt the
        ''' user to save their changes if IsDirty == true.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub btnClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClose.Click

            If Me.IsDirty = True Then
                Dim result As DialogResult = MessageBox.Show("Save Application Configuration changes before closing?", "Application Configuration", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    Try
                        SaveConfiguration(Me.ConfigFilename, DirectCast(Me.propertyGrid1.SelectedObject, CustomClass))
                        MessageBox.Show("Application Configuration changes have been saved.", "Application Configuration", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Close()
                    Catch ex As Exception
                        MessageBox.Show("Failed to btnSave configuration. Reason(" + ex.Message + ")", "Application Configuration", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End Try
                ElseIf result = DialogResult.No Then
                    Me.Close()
                End If
            Else
                Me.Close()
            End If
        End Sub

        ''' <summary>
        ''' Save the state of the property grid back to the Xml configuration file.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
            Try
                SaveConfiguration(Me.ConfigFilename, DirectCast(Me.propertyGrid1.SelectedObject, CustomClass))
                MessageBox.Show("Application Configuration changes have been saved.", "Application Configuration", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.IsDirty = False
                Me.propertyGrid1.Focus()
            Catch ex As Exception
                MessageBox.Show("Failed to btnSave configuration. Reason(" + ex.Message + ")", "Application Configuration", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End Sub


        ''' <summary>
        ''' Property value changed - set the IsDirty flag to true.
        ''' </summary>
        Private Sub propertyGrid1_PropertyValueChanged(ByVal s As Object, ByVal e As System.Windows.Forms.PropertyValueChangedEventArgs) Handles propertyGrid1.PropertyValueChanged
            Me.IsDirty = True
        End Sub

        ''' <summary>
        ''' Load a selected configuration file.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub btnLoad_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLoad.Click
            openFileDialog1.Filter = "Configuration Files (*.config)| *.config"
            Dim result As DialogResult = openFileDialog1.ShowDialog()
            If result = DialogResult.OK Then
                Me.ConfigFilename = openFileDialog1.FileName
                Me.propertyGrid1.SelectedObject = LoadConfiguration(Me.ConfigFilename)
                LayoutForm(DirectCast(Me.propertyGrid1.SelectedObject, CustomClass))
                Me.propertyGrid1.Focus()
            End If
        End Sub

		''' <summary>
		''' This method will look at the Maximum value of either a property name or it's
		''' value (which ever is greater) and adjust the width of the form accordingly.
		''' The Property Grid is set to Anchor Left, Top and Right so it will expand along
		''' with the form.
		''' </summary>
		''' <param name="customClass"></param>
		Private Sub LayoutForm(ByVal customClass As CustomClass)
			'MaxLength is the number of characters. At our current
			'font size we need to allow for an acceptable multiplier in pixels.
			If customClass.MaxLength > 95 Then
				Me.Width = 665
			Else
				Me.Width = customClass.MaxLength * 7
			End If
		End Sub

		#End Region

		#Region "Configuration Loading and Saving Methods"
		''' <summary>
		''' Load the Xml Configuration document and populate our CustomClass with a dynamic property
		''' for each of the supported configuration sections. We're only supporting three sections here.
		''' The default appSettings, plus our standard ApplicationConfiguration
		''' and CommonConfiguration section handlers. These handlers are derived from IConfigurationSectionHandler.
		''' They have extended support for the Description attribute in addition to the Key, Value 
		''' pair attributes in the Xml configuration file.
		''' This could easily be extended to include support for any section under the configuration
		''' section that has the <add key="value" value="value"/> structure (assuming you haven't written a
		''' completely new Xml structure for your custom configuration section).
		''' </summary>
		Public Function LoadConfiguration(ByVal configurationFile As String) As CustomClass
			Dim customClass As New CustomClass()
			Try
				Dim xmlDoc As New XmlDocument()
				xmlDoc.Load(configurationFile)
				Dim configuration As XmlNode = xmlDoc.SelectSingleNode("configuration")

				'Build the node list
				Dim sectionList As XmlNodeList = configuration.ChildNodes
				For y As Integer = 0 To sectionList.Count - 1
					Dim settingsList As XmlNodeList = xmlDoc.SelectNodes("configuration/" + sectionList(y).Name + "/add")
					If settingsList.Count <> 0 AndAlso settingsList IsNot Nothing Then
						For i As Integer = 0 To settingsList.Count - 1
							'Add a property to customClass for each node found.				
							Dim atrribKey As XmlAttribute = settingsList(i).Attributes("key")
							Dim attribValue As XmlAttribute = settingsList(i).Attributes("value")
							Dim attribDescription As XmlAttribute = settingsList(i).Attributes("description")
							If atrribKey IsNot Nothing AndAlso attribValue IsNot Nothing Then
								'If there's no description for the key - assign the name to the description.
								'The description attribute is displayed below the name in the property grid.
								If attribDescription Is Nothing Then
									attribDescription = atrribKey
								End If
								'We'll at least test to see if it's a boolean property and set the type here
								'to force the property grid to display a dropdown list of True or False.
								Dim propType As Type
								If attribValue.Value.ToLower() = "true" OrElse attribValue.Value.ToLower() = "false" Then
									propType = GetType(Boolean)
								Else
									propType = GetType(String)
								End If
								'Now add the property
								customClass.AddProperty(atrribKey.Value.ToString(), attribValue.Value.ToString(), attribDescription.Value.ToString(), sectionList(y).Name, propType, False, _
									False)
							End If
						Next
					End If
				Next
				xmlDoc = Nothing
			Catch ex As Exception
				Throw ex
			End Try
			Return customClass
		End Function

		''' <summary>
		''' We're only supporting three sections here at the moment.
		''' The default appSettings, plus our standard ApplicationConfiguration
		''' and CommonConfiguration section handlers. These handlers have extended support for
		''' the Description attribute in addition to the Key, Value pair attributes 
		''' in the Xml configuration file.
		''' </summary>
		Public Sub SaveConfiguration(ByVal configurationFile As String, ByVal customClass As CustomClass)
			Try
				'Reload the configuration file
				Dim xmlDoc As New XmlDocument()
				xmlDoc.Load(configurationFile)
				'Save a backup version
				xmlDoc.Save(configurationFile + "_bak")
				'Populate our property collection. 
				Dim props As PropertyDescriptorCollection = customClass.GetProperties()
				'Repolulate the three supported sections
				RepopulateXmlSection("ApplicationConfiguration", xmlDoc, props)
				RepopulateXmlSection("CommonConfiguration", xmlDoc, props)
				RepopulateXmlSection("appSettings", xmlDoc, props)
				xmlDoc.Save(configurationFile)
			Catch ex As Exception
				Throw ex
			End Try
		End Sub


		''' <summary>
		''' Repopulates the Xml section in the Xml Document by finding the matching key name
		''' values in the property collection and Xml node list.
		''' </summary>
		Private Sub RepopulateXmlSection(ByVal sectionName As String, ByVal xmlDoc As XmlDocument, ByVal props As PropertyDescriptorCollection)
			Dim nodes As XmlNodeList = xmlDoc.SelectNodes("configuration/" + sectionName + "/add")
			For i As Integer = 0 To nodes.Count - 1
				'Find the property in the property collection with the same name as the current node in the Xml document
				Dim [property] As CustomClass.DynamicProperty = DirectCast(props(nodes(i).Attributes("key").Value), CustomClass.DynamicProperty)
				If [property] IsNot Nothing Then
					'Set the node value to the property value (which will have been set in the Property grid.
					nodes(i).Attributes("value").Value = [property].GetValue(Nothing).ToString()
					'Check to see if we have a value for our extended custom xml attribute - the description attribute.
					'The default description is the property name when no descripyion attribute is present.
					'If they're not the same - then a value was passed when the property was created.
					If [property].Description <> [property].Name Then
						'double check here that there is in fact a description attribute
						If nodes(i).Attributes("description") IsNot Nothing Then
							nodes(i).Attributes("description").Value = [property].Description
						End If
					End If
				End If
			Next
		End Sub

		#End Region

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub
	End Class
End Namespace
