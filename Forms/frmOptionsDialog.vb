Imports System.IO
Imports System
Imports AdAdminConsole
Imports System.Drawing
Imports System.Configuration
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Xml
Imports System.Windows.Forms.Design
Imports System.ComponentModel.StringConverter
Imports ExpandableObjectConverter
Imports System.Drawing.Design
Imports System.ComponentModel.CategoryAttribute
Imports System.Globalization
Imports System.ComponentModel.TypeConverter
Imports System.ComponentModel.TypeConverter.StandardValuesCollection
Imports System.Reflection
Imports ADAdminDotNet.ADAdminConsole.Configuration
Imports ADAdminDotNet.ADAdminConsole.CustomClass
Imports ADAdminDotNet.clsRegistry
'Imports TAFactory.IconPack

Public Class frmOptionsDialog
    Inherits System.Windows.Forms.Form
    Private MayResize As Boolean

    Private Sub frmOptionsDialog_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyValue = 27 Then
            Me.Close()
        End If
    End Sub

    Private Sub frmOptionsDialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PropertyGrid1.Size = New Size(Me.Width - 18 - 3, Me.Height - 45)
        Me.Text = "Configure Active Directory Admin"
        Dim appset As MyPropetyGrid.AppSettings = New MyPropetyGrid.AppSettings
        PropertyGrid1.SelectedObject = appset
        frmOptionsDialog.PropertyGridManipulator.MoveSplitterToLongestDisplayName(Me.PropertyGrid1, 90)
        RefreshBrowserIcon()
        Me.Focus()
    End Sub
    Private Sub RefreshBrowserIcon()
        Dim propobj As Object = PropertyGrid1.SelectedObject
        ' Dim ico As ADAdminDotNet.TAFactory.IconPack.IconHelper
        '  Dim iconfilename As String = DirectCast(propobj, AdAdminConfigs.AppSettings).DefaultWebBrowserEXE
        Dim f As System.IO.File
        ' If f.Exists(iconfilename) Then
        'TestWebbrowser.Image = ico.GetAssociatedIcon(iconfilename, TAFactory.IconPack.IconFlags.OpenIcon).ToBitmap
        ' End If
        propobj = Nothing
    End Sub
    Private Sub frmOptionsDialog_ResizeBegin(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ResizeBegin
        If Me.Visible Then
            MayResize = True
        Else
            MayResize = False
        End If
    End Sub

    ''
    ''  Autosize Button Code
    ''
    Private Sub ToolStripButton2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmOptionsDialog.PropertyGridManipulator.MoveSplitterToLongestDisplayName(Me.PropertyGrid1, 90)
    End Sub

    ''
    ''  Open Hosts Button Code
    ''
    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsBtnOpenHosts.Click
        '10.123.216.100 prodlgcimv1 
        Dim rHostsPath As String = "c:\windows\system32\drivers\etc"
        Dim p As New ProcessStartInfo
        p.FileName = "notepad.exe"
        p.Arguments = rHostsPath & "\hosts"
        Process.Start(p)
    End Sub

    ''
    ''  Edit Config Button Code
    ''
    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsBtnEditConfigFile.Click
        Dim p As New ProcessStartInfo
        p.FileName = "notepad.exe"
        p.Arguments = AppPath() & "\ADAdminConsole.exe.config"
        Process.Start(p)
    End Sub

    ''
    ''  Reload Config Button Code
    ''

    ''
    ''  Save Button Code
    ''
    Private Sub tsBtnSAVE_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsBtnSAVE.Click

        Dim i As Integer
        Dim AppConfigFileName As String = ""
        Dim appaaa As Object = PropertyGrid1.SelectedObject

        AppConfigFileName = AppPath() & "ADAdminConsole.exe.config"

        Dim mycount As Integer = My.MySettings.Default.PropertyValues.Count

        My.MySettings.Default.PropertyValues("AD_Users_PRD").PropertyValue = DirectCast(appaaa, ADAdminDotNet.MyPropetyGrid.AppSettings).AD_Users_PRD
        My.MySettings.Default.PropertyValues("AD_Users_QA").PropertyValue = DirectCast(appaaa, ADAdminDotNet.MyPropetyGrid.AppSettings).AD_Users_QA
        My.MySettings.Default.PropertyValues("ADSConnectionString").PropertyValue = DirectCast(appaaa, ADAdminDotNet.MyPropetyGrid.AppSettings).ADSConnectionString
        My.MySettings.Default.PropertyValues("ADSMasterPassword_PRD").PropertyValue = DirectCast(appaaa, ADAdminDotNet.MyPropetyGrid.AppSettings).ADSMasterPassword_PRD
        My.MySettings.Default.PropertyValues("ADSMasterPassword_QA").PropertyValue = DirectCast(appaaa, ADAdminDotNet.MyPropetyGrid.AppSettings).ADSMasterPassword_QA
        '  My.MySettings.Default.PropertyValues("AdsPRDConnectionString2014").PropertyValue = DirectCast(appaaa, ADAdminDotNet.MyPropetyGrid.AppSettings).AdsPRDConnectionString2014
        '  My.MySettings.Default.PropertyValues("AdsPRDConnectionString2014").PropertyValue = DirectCast(appaaa, ADAdminDotNet.MyPropetyGrid.AppSettings).AdsPRDConnectionString2014
        ' My.MySettings.Default.PropertyValues("ADSQAConnectionString2014").PropertyValue = DirectCast(appaaa, ADAdminDotNet.MyPropetyGrid.AppSettings).ADSQAConnectionString2014
        'My.MySettings.Default.PropertyValues("ADSQAConnectionString2014").PropertyValue = DirectCast(appaaa, ADAdminDotNet.MyPropetyGrid.AppSettings).ADSQAConnectionString2014
        My.MySettings.Default.PropertyValues("ARPassword").PropertyValue = DirectCast(appaaa, ADAdminDotNet.MyPropetyGrid.AppSettings).ARPassword
        My.MySettings.Default.PropertyValues("ARSystemConnectionString").PropertyValue = DirectCast(appaaa, ADAdminDotNet.MyPropetyGrid.AppSettings).ARSystemConnectionString
        My.MySettings.Default.PropertyValues("DeptDescPair").PropertyValue = DirectCast(appaaa, ADAdminDotNet.MyPropetyGrid.AppSettings).DeptDescPair
        My.MySettings.Default.PropertyValues("HelpDesk_PhoneNo").PropertyValue = DirectCast(appaaa, ADAdminDotNet.MyPropetyGrid.AppSettings).HelpDesk_PhoneNo
        My.MySettings.Default.PropertyValues("ARUser").PropertyValue = DirectCast(appaaa, ADAdminDotNet.MyPropetyGrid.AppSettings).ARUser
        My.MySettings.Default.PropertyValues("SMTPServerIPAddress").PropertyValue = DirectCast(appaaa, ADAdminDotNet.MyPropetyGrid.AppSettings).SMTPServerIPAddress
        My.MySettings.Default.PropertyValues("VIP_ExpandedConnectionString").PropertyValue = DirectCast(appaaa, ADAdminDotNet.MyPropetyGrid.AppSettings).VIP_ExpandedConnectionString
        My.MySettings.Default.PropertyValues("WebBrowserEXE").PropertyValue = DirectCast(appaaa, ADAdminDotNet.MyPropetyGrid.AppSettings).DefaultWebBrowserEXE
        My.MySettings.Default.PropertyValues("ARSServerName").PropertyValue = DirectCast(appaaa, ADAdminDotNet.MyPropetyGrid.AppSettings).ARSServerName
        My.MySettings.Default.PropertyValues("RemedyServerName").PropertyValue = DirectCast(appaaa, ADAdminDotNet.MyPropetyGrid.AppSettings).RemedyServerName
        My.MySettings.Default.PropertyValues("Vulindlela_Controllers").PropertyValue = DirectCast(appaaa, ADAdminDotNet.MyPropetyGrid.AppSettings).Vulindlela_Controllers
        My.MySettings.Default.PropertyValues("ProxyOveride").PropertyValue = DirectCast(appaaa, ADAdminDotNet.MyPropetyGrid.AppSettings).ProxyOveride
        '  My.MySettings.Default.PropertyValues("ProxyOverideCurrent").PropertyValue = DirectCast(appaaa, ADAdminDotNet.MyPropetyGrid.AppSettings).ProxyOverideCurrent
        My.MySettings.Default.PropertyValues("VulindlelaUser").PropertyValue = DirectCast(appaaa, ADAdminDotNet.MyPropetyGrid.AppSettings).VulindlelaUser
        My.MySettings.Default.PropertyValues("Close_Pick_Forms").PropertyValue = DirectCast(appaaa, ADAdminDotNet.MyPropetyGrid.AppSettings).Close_Pick_Forms
        My.MySettings.Default.Save()
        My.Settings.Save()

        RefreshBrowserIcon()
        Me.Text = "Application Configuration (Settings Saved)"

    End Sub


#Region "tsBtnEncrypt - Encrypt Button Code"

#Region "tsBtnEncrypt"
    Private Sub tsBtnEncrypt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmKodeer.ShowDialog()
    End Sub
#End Region

#Region "tsBtnEncrypt - Encrypt Button Code"
#End Region

#Region "tsBtnEncrypt - Encrypt Button Code"
#End Region

#Region "tsBtnToets - Toets Button Code"
    ''
    ''  tsBtnToets - Toets Button Code
    ''

#End Region

#End Region

#Region "tsBtnToets - Toets Button Code"
    ''
    ''  tsBtnToets - Toets Button Code
    ''
    Private Sub tsCloseBrowsers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsCloseBrowsers.Click
        Try
            Dim processes As Process() = Process.GetProcesses()
            Dim array As Process() = processes
            For i As Integer = 0 To array.Length - 1
                Dim process As Process = array(i)
                If process.ProcessName = "iexplore" Or process.ProcessName = "chrome" Then
                    process.Kill()
                    If process IsNot Nothing Then
                        process.Dispose()
                    End If
                End If
            Next
        Catch ex_43 As Exception
        End Try
    End Sub
#End Region

    Public Class PropertyGridManipulator

        Public Shared Sub MoveSplitter(ByVal propertyGrid As PropertyGrid, ByVal x As Integer)

            Dim propertyGridView As Object = GetType(PropertyGrid).InvokeMember("gridView", BindingFlags.GetField Or BindingFlags.NonPublic Or BindingFlags.Instance, Nothing, propertyGrid, Nothing)
            propertyGridView.[GetType]().InvokeMember("MoveSplitterTo", BindingFlags.InvokeMethod Or BindingFlags.NonPublic Or BindingFlags.Instance, Nothing, propertyGridView, New Object() {x})
        End Sub

        Public Shared Sub MoveSplitterToLongestDisplayName(ByVal propertyGrid As PropertyGrid, ByVal iPadding As Integer)

            Dim i As Integer = 0

            Try
                Dim pgObjectType As Type = propertyGrid.SelectedObject.[GetType]()
                Dim longestDisplayName As String = ""
                ' Iterate through all the properties of the class.
                For Each mInfo As PropertyInfo In pgObjectType.GetProperties()
                    ' Iterate through all the Attributes for each property.
                    For i = 0 To pgObjectType.GetProperties().Count - 1
                        ' Check for the AnimalType attribute.
                        'If pgObjectType.GetProperties().ElementAt(i).Attributes.ToString = mInfo.Name Then
                        If mInfo.Name = pgObjectType.GetProperties().ElementAt(i).Name Then
                            If pgObjectType.GetProperties().GetValue(i).ToString.Length >= longestDisplayName.Length Then
                                longestDisplayName = mInfo.Name
                            End If
                        End If
                    Next
                Next

                Dim textSize As Size = TextRenderer.MeasureText(longestDisplayName, propertyGrid.Font)
                PropertyGridManipulator.MoveSplitter(propertyGrid, textSize.Width + iPadding + 35)

            Catch exception1 As Exception
                MessageBox.Show(exception1.Message)
            End Try

        End Sub

    End Class

    Private Sub PropertyGrid1_Invalidated(ByVal sender As Object, ByVal e As System.Windows.Forms.InvalidateEventArgs) Handles PropertyGrid1.Invalidated
        Me.Text = "Application Configuration (Settings NOT Saved)"
    End Sub  ' end public static void MoveSplitterToLongestDisplayName(PropertyGrid propertyGrid, int iPadding)}

    Private Sub PropertyGrid1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PropertyGrid1.KeyPress
        If e.KeyChar = Chr(27) Then
            Me.Close()
        End If
    End Sub

    Private Sub ToolStrip1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ToolStrip1.KeyPress
        If e.KeyChar = Chr(27) Then
            Me.Close()
        End If
    End Sub

    Private Sub tsClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsClose.Click
        Me.Close()
    End Sub

    Private Sub TestWebbrowser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TestWebbrowser.Click
        Dim web As New ARSWS.Webpage
        web.OpenInWebBrowser("")
        web = Nothing
    End Sub

    Private Sub PropertyGrid1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles PropertyGrid1.TextChanged
        RefreshBrowserIcon()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim m As New clsMxLookup
        Dim s As Boolean = False
        s = m.IsEmailAddressValid("vults@treasury.gov.za")
        m = Nothing
        If s = True Then
            MsgBox("EMail Address Exists")
        Else
            MsgBox("No Such EMail Address")
        End If
        m = Nothing
    End Sub

    Private Sub PropertyGrid1_Click(sender As Object, e As EventArgs) Handles PropertyGrid1.Click

    End Sub
End Class

Public Class SpellingOptionsConverter
    Inherits ExpandableObjectConverter
End Class

Public Class PropertyGridManipulator

    Public Shared Sub MoveSplitter(ByVal propertyGrid As PropertyGrid, ByVal x As Integer)
        Dim propertyGridView As Object = GetType(PropertyGrid).InvokeMember("gridView", BindingFlags.GetField Or BindingFlags.NonPublic Or BindingFlags.Instance, Nothing, propertyGrid, Nothing)
        propertyGridView.[GetType]().InvokeMember("MoveSplitterTo", BindingFlags.InvokeMethod Or BindingFlags.NonPublic Or BindingFlags.Instance, Nothing, propertyGridView, New Object() {x})
    End Sub

    Public Shared Sub MoveSplitterToLongestDisplayName(ByVal propertyGrid As PropertyGrid, ByVal iPadding As Integer)
        Dim i As Integer = 0
        Try
            Dim pgObjectType As Type = propertyGrid.SelectedObject.[GetType]()
            Dim longestDisplayName As String = ""
            ' Iterate through all the properties of the class.
            For Each mInfo As PropertyInfo In pgObjectType.GetProperties()
                ' Iterate through all the Attributes for each property.
                For i = 0 To pgObjectType.GetProperties().Count - 1
                    ' Check for the AnimalType attribute.
                    'If pgObjectType.GetProperties().ElementAt(i).Attributes.ToString = mInfo.Name Then
                    If mInfo.Name = pgObjectType.GetProperties().ElementAt(i).Name Then
                        If pgObjectType.GetProperties().GetValue(i).ToString.Length >= longestDisplayName.Length Then
                            longestDisplayName = mInfo.Name
                        End If
                    End If
                Next
            Next

            Dim textSize As Size = TextRenderer.MeasureText(longestDisplayName, propertyGrid.Font)
            PropertyGridManipulator.MoveSplitter(propertyGrid, textSize.Width + iPadding + 35)

        Catch exception1 As Exception
            'do nothing for now --
            'if exception was thrown the private method MoveSplitterTo
            'of the C# version 2.0 framework's PropertyGrid's
            'PropertyGridView probably is no
            'longer named the same or has a different
            'method signature in the current C# framework
            MessageBox.Show(exception1.Message)
        End Try
    End Sub

    'Private Sub tsBtnReloadConfig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsBtnReloadConfig.Click
    '    Dim appset As AdAdminConfigs.AppSettings = New AdAdminConfigs.AppSettings
    '    PropertyGrid1.SelectedObject = appset
    '    frmOptionsDialog.PropertyGridManipulator.MoveSplitterToLongestDisplayName(Me.PropertyGrid1, 90)
    'End Sub


End Class  ' end public static void MoveSplitterToLongestDisplayName(PropertyGrid propertyGrid, int iPadding)}

#Region "Legacy"
'Declaration


'Dim i As Integer
'Dim AppConfigFileName As String = ""
'Dim appaaa As Object = PropertyGrid1.SelectedObject

'AppConfigFileName = AppPath() & "ADAdminConsole.exe.config"

'Dim mycount As Integer = My.MySettings.Default.PropertyValues.Count

'ConfigurationSettings.AppSettings.Set("AD_Users_PRD", DirectCast(appaaa, ADAdminDotNet.AppSettings).AD_Users_PRD)
'ConfigurationSettings.AppSettings.Set("AD_Users_QA", DirectCast(appaaa, ADAdminDotNet.AppSettings).AD_Users_QA)
'ConfigurationSettings.AppSettings.Set("ADSConnectionString", DirectCast(appaaa, ADAdminDotNet.AppSettings).ADSConnectionString)
'ConfigurationSettings.AppSettings.Set("ADSMasterPassword_PRD", DirectCast(appaaa, ADAdminDotNet.AppSettings).ADSMasterPassword_PRD)
'ConfigurationSettings.AppSettings.Set("ADSMasterPassword_QA", DirectCast(appaaa, ADAdminDotNet.AppSettings).ADSMasterPassword_QA)
'ConfigurationSettings.AppSettings.Set("ADSPRDConnectionString", DirectCast(appaaa, ADAdminDotNet.AppSettings).ADSPRDConnectionString)
'ConfigurationSettings.AppSettings.Set("ADSPRDConnectionString", DirectCast(appaaa, ADAdminDotNet.AppSettings).ADSPRDConnectionString)
'ConfigurationSettings.AppSettings.Set("ADSQAConnectionString", DirectCast(appaaa, ADAdminDotNet.AppSettings).ADSQAConnectionString)
'ConfigurationSettings.AppSettings.Set("ADSQAConnectionString", DirectCast(appaaa, ADAdminDotNet.AppSettings).ADSQAConnectionString)
'ConfigurationSettings.AppSettings.Set("ARPassword", DirectCast(appaaa, ADAdminDotNet.AppSettings).ARPassword)
'ConfigurationSettings.AppSettings.Set("ARSystemConnectionString", DirectCast(appaaa, ADAdminDotNet.AppSettings).ARSystemConnectionString)
'ConfigurationSettings.AppSettings.Set("BmcRemedySqlServerAddress", DirectCast(appaaa, ADAdminDotNet.AppSettings).BmcRemedySqlServerAddress)
'ConfigurationSettings.AppSettings.Set("DefaultWebBrowserEXE", DirectCast(appaaa, ADAdminDotNet.AppSettings).DefaultWebBrowserEXE)
'ConfigurationSettings.AppSettings.Set("DeptDescPair", DirectCast(appaaa, ADAdminDotNet.AppSettings).DeptDescPair)
'ConfigurationSettings.AppSettings.Set("HelpDesk_PhoneNo", DirectCast(appaaa, ADAdminDotNet.AppSettings).HelpDesk_PhoneNo)
'ConfigurationSettings.AppSettings.Set("LOG_DM_Customer_Information_BasicWs__c", DirectCast(appaaa, ADAdminDotNet.AppSettings).LOG_DM_Customer_Information_BasicWs__c)
'ConfigurationSettings.AppSettings.Set("LOG_DM_Department_BasicWs__c", DirectCast(appaaa, ADAdminDotNet.AppSettings).LOG_DM_Department_BasicWs__c)
'ConfigurationSettings.AppSettings.Set("Log_Dm_Personnel_BasicWs__c", DirectCast(appaaa, ADAdminDotNet.AppSettings).Log_Dm_Personnel_BasicWs__c)
'ConfigurationSettings.AppSettings.Set("LOG_IN_Request_Tracking_BasicWs__c", DirectCast(appaaa, ADAdminDotNet.AppSettings).LOG_IN_Request_Tracking_BasicWs__c)
'ConfigurationSettings.AppSettings.Set("RemedySqlConnection", DirectCast(appaaa, ADAdminDotNet.AppSettings).RemedySqlConnection)
'ConfigurationSettings.AppSettings.Set("RemedyUserName", DirectCast(appaaa, ADAdminDotNet.AppSettings).RemedyUserName)
'ConfigurationSettings.AppSettings.Set("SMTPServerIPAddress", DirectCast(appaaa, ADAdminDotNet.AppSettings).SMTPServerIPAddress)
'ConfigurationSettings.AppSettings.Set("VIP_ExpandedConnectionString", DirectCast(appaaa, ADAdminDotNet.AppSettings).VIP_ExpandedConnectionString)
'ConfigurationSettings.AppSettings.Set("VulindlelaSqlServerAddress", DirectCast(appaaa, ADAdminDotNet.AppSettings).VulindlelaSqlServerAddress)
'ConfigurationSettings.AppSettings.Set("VulindlelaUser", DirectCast(appaaa, ADAdminDotNet.AppSettings).VulindlelaUser)

'My.Settings.Save()


'Dim str As String
'ConfigurationSettings.AppSettings.Set(myAppSettings("appStr").ToString()
'Dim conStringname As String = "LocalSqlServer"
'Dim conString As String = "data source=.\SQLEXPRESS;Integrated Security=SSPI;AttachDBFilename=|DataDirectory|aspnetdb.mdf;User Instance=true"
'Dim providerName As String = "System.Data.SqlClient"

'Dim config As System.Configuration.ConfigurationSettings = System.Configuration.ConfigurationSettings.OpenExeConfiguration(ConfigurationUserLevel.None)
'Dim connStrSettings As New ConnectionStringSettings()
'connStrSettings.Name = conStringname
'connStrSettings.ConnectionString = conString
'connStrSettings.ProviderName = providerName

'config.ConnectionStrings.ConnectionStrings.Add(connStrSettings)

'' Add an entry to appSettings section. 
'Dim appStgCnt As Integer = ConfigurationManager.AppSettings.Count
'Dim newKey As String = "NewKey" & appStgCnt.ToString()

'Dim newValue As String = Date.Now.ToLongDateString() & " " & Date.Now.ToLongTimeString()

'config.AppSettings.Settings.Add(newKey, newValue)

'' Save the configuration file.
'customSection.SectionInformation.ForceSave = True
'config.Save(ConfigurationSaveMode.Full)

'Console.WriteLine("Created configuration file: {0}", config.FilePath)

'Catch err As ConfigurationErrorsException
'    Console.WriteLine("CreateConfigurationFile: {0}", err.ToString())
'End Try

'//////////////////////////////////////////////

#End Region
