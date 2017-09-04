Imports System.IO
Imports ActiveDs
Imports System.Web
Imports System.Text
Imports System.Net.Mail
Imports ADAdminDotNet.My
Imports System.Configuration
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CallType
Imports System.Drawing.Printing
Imports ADAdminDotNet.modMailMerge
Imports System.DirectoryServices
Imports System.DirectoryServices.AccountManagement
Imports ADAdminDotNet.WS_Utils
Imports System.Windows.Forms.Form

Public Enum Designation
    ChiefFinancialOfficer = 1
    BudgetOfficer = 2
End Enum

Public Class frmMain

#Region "Definitions with code"
    Private Const ADS_SECURE_AUTHENTICATION As Long = &H0
    Public CI As Integer
    Public ticks As Integer = 10
    Public StartKickout As Integer
    Public svrEnvironment As Integer
    Private ds As DataSet, jv As modJoinView
    Public lvwColumnSorter As New ListViewColumnSorter
    Public ids As Long = 0
    Dim remedy_req As String
    Dim jobdescription As String
    Dim accessnow As String
    Dim accessrequired As String
    Dim establishment As String
    Dim i As Integer
    Dim h As String
    Dim Strmemberof As Object
    Dim tbl1 As dsADS.Vulindlela_EmailDataTable
    Dim a As String()
    Dim fullname As String
    Dim telephone As String
    Dim cellular As String
    Dim RESPONSIBILITIES As String
    Dim a_HR_OVERSIGHT As Object
    Dim a_notes As Object
    Dim a_responsibility As Object
    Dim a_AccountLevel As Object

    Private Sub btnVariationList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVariationList.Click

        If frmEnvironment.ChildFormPRD.Visible Then

            frmVariationList.AD_SNAPSHOT_EXCEPTIONSTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
            frmVariationList.Text = "Variation List - PRD"

            If frmVariationList.Visible Then
                frmVariationList.TopMost = True
            Else
                frmVariationList.Show()
                frmVariationList.TopMost = True
            End If

        ElseIf frmEnvironment.childformQA.Visible Then

            frmVariationList.AD_SNAPSHOT_EXCEPTIONSTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")

            frmVariationList.Text = "Variation List - QA"


            If frmVariationList.Visible Then
                frmVariationList.TopMost = True
            Else
                frmVariationList.Show()
                frmVariationList.TopMost = True
            End If

        End If

    End Sub


    Public Function getNewUsers_Dumi() As String

        Dim sqlConnection1 As New SqlConnection("Data Source=10.123.45.210;Initial Catalog=Ads;Persist Security Info=True;User ID=sa;Password=S@P@SSW0RD")
        Dim rowsAffected As Integer
        sqlConnection1.Open()

        Dim cmd As New SqlCommand("dbo.CountNewUsers", sqlConnection1)

        Dim reader As SqlDataReader = cmd.ExecuteReader()
        Dim DTResults As New DataTable

        DTResults.Load(reader)

        sqlConnection1.Close()



        Return DTResults.Rows(0)(0).ToString.ToString

    End Function

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsShared.DsProvinces' table. You can move, or remove it, as needed.
        Me.DsProvincesTableAdapter.Fill(Me.DsShared.DsProvinces)
        'TODO: This line of code loads data into the 'DsShared.VIEW_Assigned_Department' table. You can move, or remove it, as needed.
        Me.VIEW_Assigned_DepartmentTableAdapter.Fill(Me.DsShared.VIEW_Assigned_Department)
        'TODO: This line of code loads data into the 'DsShared.View_Dept' table. You can move, or remove it, as needed.
        Me.View_DeptTableAdapter.Fill(Me.DsShared.View_Dept)
        'TODO: This line of code loads data into the 'HRDataSet.DIMENSION_BUSINESS_UNIT' table. You can move, or remove it, as needed.
        '  Me.DIMENSION_BUSINESS_UNITTableAdapter.Fill(Me.HRDataSet.DIMENSION_BUSINESS_UNIT)

        'TODO: This line of code loads data into the 'DsARSystemDataSet.LOG_IN_Request_Tracking2' table. You can move, or remove it, as needed.
        Me.LOG_IN_Request_Tracking2TableAdapter.FillByRefer2Client(Me.DsARSystemDataSet.LOG_IN_Request_Tracking2)

        Me.Ta_VIEW_Assigned_Departments1.Fill(Me.VIP_EXPANDED.VIEW_Assigned_Departments)
        Try
            Dim ads As New Global.ADAdminDotNet.dsADS
            Me.tmrPersalNumber.Start()

            Me.CFOListTableAdapter.Fill(Me.Ads1.CFOList)
            Me.Department_DiffersTableAdapter.Fill(Me.Ads1.Department_Differs)
            Me.VIEW_CFO_APPPLICATION_TOOK_TO_LONGTableAdapter.Fill(Me.Ads1.VIEW_CFO_APPPLICATION_TOOK_TO_LONG, "")
            Me.ExportActiveDirectoryDatabaseToolStripMenuItem.Enabled = True
            '  Me.ta_VIEW_departments1.FillNatProf(Me.VIP_EXPANDED.VIEW_departments)
            Me.Ta_VIEW_APPLICATION_RIGHTS1.FillGetApplicationEnums(Me.VIP_EXPANDED.VIEW_APPLICATION_RIGHTS)
            Me.Ta_VIEW_Assigned_Departments1.Fill(Me.VIP_EXPANDED.VIEW_Assigned_Departments)
            Me.Ta_VIEW_GOVERNMENT_STRUCTURE1.FillNatProf(Me.VIP_EXPANDED.VIEW_GOVERNMENT_STRUCTURE)
            ' REMEDY CHANGES
            '  Me.LOG_DM_PersonnelTableAdapter.Fill(Me.ARSystemDataSet.LOG_DM_Personnel)
            ' Me.LOG_IN_Request_Tracking1TableAdapter.Fill(Me.ARSystemDataSet.LOG_IN_Request_Tracking1)
            '  Me.RemedyOpenRequestsTableAdapter.Fill(Me.ARSystemDataSet.RemedyOpenRequests)
            Me.Ta_Vulindlela_Controllers.Fill(Me.Ads1.Vulindlela_Controllers)
            chkProfileCategories.Cursor = Cursors.Arrow
            lwApplicationRoles.Cursor = Cursors.Arrow
            tsStatus.Text = ""
            tsUsername.Text = (Me.GetUserFirstName.Trim & " " & Me.GetUserLastName.Trim).Trim
            tsLabelVulname.Text = Me.GetUserName(Me.GetLoginName.Trim).Trim
            tsMachineName.Text = Me.GetComputerName.Trim
            tsLoggedOnUser.Text = Me.GetLoginName.Trim

            Me.Ta_VIEW_APPLICATION_RIGHTS1.FillGetApplicationEnums(Me.VIP_EXPANDED.VIEW_APPLICATION_RIGHTS)
            Me.Ta_VIEW_Assigned_Departments1.Fill(Me.VIP_EXPANDED.VIEW_Assigned_Departments)
            '   Me.ta_VIEW_departments1.FillNatProf(Me.VIP_EXPANDED.VIEW_departments)
            Me.Ta_VIEW_GOVERNMENT_STRUCTURE1.FillNatProf(Me.VIP_EXPANDED.VIEW_GOVERNMENT_STRUCTURE)
            svrEnvironment = 1
            Me.rbPRD.Checked = True


            timerCOUNTS_Tick(sender, e)
            Me.CountNewUsersTableAdapter.FillCountNewUsers(Me.Ads1.CountNewUsers)
            Me.GetResetPasswordsTableAdapter1.Fill(Me.Ads1.GetResetPasswords)
            Ads1.EnforceConstraints = False
            'Me.Ads.GetResetPasswords.EnforceConstraints = False
            'Vulindlela_Controllers.EnforceConstraints = False

            Me.HRDataSet.EnforceConstraints = False
            Me.cboNatProv_SelectedIndexChanged(sender, e)
            Me.load_lv_assigned_departments()
            Me.load_lv_application_rights()
            Me.TabControl1.TabPages.Remove(tab_Flagged)
            timerCOUNTS.Start()
            lvFlags.Visible = False

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Me.Cursor = Cursors.Arrow


    End Sub


    Public Sub cboNatProv_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboNatProv.SelectedIndexChanged
        Dim s As String = ""
        Dim rr As DataRow
        Dim col As Integer = 0
        Dim dt As New DataTable
        Me.lwDepartments.Items.Clear()
        If Me.cboNatProv.SelectedValue Is Nothing Then
            Me.lwDepartments.Items.Clear()
        Else
            Me.lwDepartments.Items.Clear()
            s = Me.cboNatProv.SelectedValue.ToString
            dt = Me.View_DeptTableAdapter.GetDataBy(s)
            Dim str(dt.Columns.Count) As String
            For Each rr In dt.Rows
                For col = 0 To dt.Columns.Count - 1
                    str(col) = rr(col).ToString()
                Next
                Dim lv As New ListViewItem(str)
                Me.lwDepartments.Items.Add(lv)
            Next
        End If
        Me.Cursor = Cursors.Arrow
    End Sub

    Public Sub New()
        InitializeComponent()
        Dim lvwColumnSorter As New ListViewColumnSorter
        Me.lwApplicationRoles.ListViewItemSorter = lvwColumnSorter
        Me.txtPersalNumber.Focus()
    End Sub

    Public Sub Resetfields_not_persalnumber(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Clear_Textboxes_Values(sender, e)
    End Sub

    Public Function c_u_c(ByVal cString As Object) As String
        On Error Resume Next
    End Function

    Private Sub Clear_Textboxes_Values(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Using Me
            txtPersalNumber.Text = ""
            txtTitleTextBox.Text = ""
            txtFirst_NameTextBox.Text = ""
            txtLast_NameTextBox.Text = ""
            txtTelephoneTextBox.Text = ""
            txtCellphoneTextBox.Text = ""
            txtFax_NumberTextBox.Text = ""
            txtE_MailTextBox.Text = ""
            txtDepartment_NameTextBox.Text = ""
            txtDepartment_TypeTextBox.Text = ""
            txtRankTextBox.Text = ""
            txtPersalNumber.Focus()
        End Using
    End Sub ' Clears the values on screen

    Private Sub frmMain_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Keys.F12.ToString Then
            Me.btnKodeer_Click(sender, e)
        ElseIf e.KeyChar = Keys.F11.ToString Then
            frmAD_create_new_shortcode.Show(Me)
        End If
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub frmMain_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        If ADAdminDotNet.frmEnvironment.ActiveMdiChild.Text = "Active Directory Console - PRD" Then
            ADAdminDotNet.frmEnvironment.ChildFormPRD.txtRemedyRequestNo.Text = ""
            ADAdminDotNet.frmEnvironment.ChildFormPRD.txtRemedyNo.Text = ""
        ElseIf ADAdminDotNet.frmEnvironment.ActiveMdiChild.Text = "Active Directory Console - QA" Then
            ADAdminDotNet.frmEnvironment.childformQA.txtRemedyRequestNo.Text = ""
            ADAdminDotNet.frmEnvironment.childformQA.txtRemedyNo.Text = ""
        End If
        Me.txtPersalNumber.Focus()
        Me.txtPersalNumber.SelectAll()
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub btnResetPassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResetPassword.Click
        'Reset Password Requests

        If frmEnvironment.ActiveMdiChild.Text.Contains("PRD") Then

            frmResetPassword.Text = "Reset Password Requests - PRD"
            frmResetPassword.VIP_USERS_ResetPasswordTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
            frmResetPassword.ShowDialog()
            frmResetPassword.Focus()

        Else

            frmResetPassword.Text = "Reset Password Requests - QA"
            frmResetPassword.VIP_USERS_ResetPasswordTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
            frmResetPassword.ShowDialog()
            frmResetPassword.Focus()

        End If

        btnNewUsers.Enabled = True
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub btnNewUsers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewUsers.Click

        If frmEnvironment.ActiveMdiChild.Text.Contains("PRD") Then

            frmNewUsers.Text = "New Account Requests - PRD"
            frmNewUsers.VIP_USERS_NewUsersTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
            frmNewUsers.ta_Customer_Information.Connection.ConnectionString = My.MySettings.Default("ARSystemProdConnectionString")
            frmNewUsers.ShowDialog()
            frmNewUsers.Focus()

        Else

            frmNewUsers.Text = "New Account Requests - QA"
            frmNewUsers.VIP_USERS_NewUsersTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
            frmNewUsers.ta_Customer_Information.Connection.ConnectionString = My.MySettings.Default("ARSystemDevConnectionString")
            frmNewUsers.ShowDialog()
            frmNewUsers.Focus()

        End If
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub ByRequestToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByRequestToolStripMenuItem.Click
        btnOpenRequests_Click(sender, e)
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub btnOpenRequests_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenRequests.Click

        If frmEnvironment.ActiveMdiChild.Text.Contains("PRD") Then

            frmOpenRequests.Text = "Open Requests - PRD"

            frmOpenRequests.RemedyOpenRequestsTableAdapter.Connection.ConnectionString = My.MySettings.Default("ARSystemProdConnectionString")
            frmOpenRequests.ShowDialog()
        Else

            frmOpenRequests.Text = "Open Requests - QA"
            frmOpenRequests.RemedyOpenRequestsTableAdapter.Connection.ConnectionString = My.MySettings.Default("ARSystemDevConnectionString")
            frmOpenRequests.ShowDialog()
            frmOpenRequests.Focus()

        End If

        Me.Cursor = Cursors.Arrow


    End Sub

    Private Sub OpenQAWebToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.txtPersalNumber.Text = "" Then
            Process.Start(MySettings.Default("WEBURLQA").ToString)
        Else
            Process.Start(MySettings.Default("WEBURLQA").ToString & "index.asp?UserName=" & modADS.Get_ValidUsername(Me.txtPersalNumber.Text).Trim.ToUpper)
        End If
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub OpenPRDWebToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.txtPersalNumber.Text = "" Then
            Process.Start(MySettings.Default("WEBURLPRD").ToString)
        Else

            ' Process.Start("http://www.vulindlela.gov.za/index.htm?" & "index.asp?UserName=" & modADS.Get_ValidUsername(Me.txtPersalNumber.Text).Trim.ToUpper)
            Process.Start(MySettings.Default("WEBURLPRD").ToString & "index.asp?UserName=" & modADS.Get_ValidUsername(Me.txtPersalNumber.Text).Trim.ToUpper)
        End If
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub QAWebToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QAWebToolStripMenuItem.Click
        OpenQAWebToolStripMenuItem1_Click(sender, e)
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub PRDWebToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PRDWebToolStripMenuItem.Click
        OpenPRDWebToolStripMenuItem1_Click(sender, e)
        Me.Cursor = Cursors.Arrow
    End Sub

    Public Sub createOU(ByVal _siteName As String, ByVal _domainPath As String)
        Dim myDomain As New System.DirectoryServices.DirectoryEntry("LDAP://10.123.45.160/" & _
                                                                    _domainPath, _
                                                                    Get_Master_User(), Get_Master_Pwd(), _
                                                                    DirectoryServices.AuthenticationTypes.Secure)
        myDomain.Children.Add(_siteName, "organizationalUnit")
        MsgBox("Successfully created " & _siteName & " OU")
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub FillToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ''Me.Cursor = Cursors.WaitCursor
        Try
            Me.Get_shortcodeTableAdapter.Fill(Me.Ads1.get_shortcode, tsLoggedOnUser.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub ByRequestToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        btnOpenRequests_Click(sender, e)
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub BySurnameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BySurnameToolStripMenuItem.Click

        If frmEnvironment.ActiveMdiChild.Text.Contains("PRD") Then

            My.MySettings.Default("AdsConnectionString") = My.MySettings.Default.Default("ADSConnectionString2014")
            frmRemedyBySurname.Text = "Remedy By Surname - PRD"
            frmRemedyBySurname.ShowDialog()
            frmRemedyBySurname.Focus()

        Else

            ' frmRemedyBySurname.RemedyByFirstLetterOfSurnameTableAdapter.connection.connectionString = My.MySettings.Default.Default("AdsPRDConnectionString")
            frmRemedyBySurname.Text = "Remedy By Surname - QA"
            frmRemedyBySurname.ShowDialog()
            frmRemedyBySurname.Focus()

        End If

    End Sub

    Private Sub BySurnameToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmRemedyBySurname.Show()
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub OpenQAWebToolStripMenuItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenQAWebToolStripMenuItem1.Click
        OpenQAWebToolStripMenuItem1_Click(sender, e)
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub OpenPRDWebToolStripMenuItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenPRDWebToolStripMenuItem1.Click
        OpenPRDWebToolStripMenuItem1_Click(sender, e)
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub FillBy1ToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.LOG_DM_Customer_InformationTableAdapter.FillBy1(Me.ARSystemDataSet.LOG_DM_Customer_Information)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub lwAssignedDepartments_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim i As Integer
        Dim it As ListViewItem
        Try
            it = lwA.SelectedItems(0)
        Catch ex As Exception
            it = Nothing
            Exit Sub
        End Try
        If it.Index > -1 Then
            i = it.Index
            it.Checked = True
        End If
        Me.Cursor = Cursors.Arrow
    End Sub

  

    Public Sub remedy_fill(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim i As Integer


        'If (Not frmEnvironment.ActiveMdiChild Is Nothing) Then


        '    If frmEnvironment.ActiveMdiChild.Text.Contains("- PRD") Then

        '        Me.GetResetPasswordsTableAdapter1.Connection.ConnectionString = My.MySettings.Default.Default("AdsPRDConnectionString")
        '        Me.Department_DiffersTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("AdsPRDConnectionString")
        '        Me.VIEW_CFO_APPPLICATION_TOOK_TO_LONGTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("AdsConnectionString")
        '        Me.ta_VIEW_departments1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDConnectionString")
        '        Me.Ta_VIEW_APPLICATION_RIGHTS1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDConnectionString")
        '        Me.Ta_VIEW_Assigned_Departments1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDConnectionString")
        '        Me.Ta_VIEW_GOVERNMENT_STRUCTURE1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDConnectionString")
        '        Me.LOG_IN_Request_TrackingTableAdapter1.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemProdConnectionString")
        '        Me.LOG_DM_Customer_InformationTableAdapter1.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemProdConnectionString")
        '        Me.LOG_DM_PersonnelTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemProdConnectionString")
        '        Me.LOG_IN_Request_TrackingTableAdapter1.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemProdConnectionString")
        '        Me.Ta_Vulindlela_Controllers.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemProdConnectionString")
        '        Me.Ta_VIEW_APPLICATION_RIGHTS1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDConnectionString")
        '        Me.Ta_VIEW_Assigned_Departments1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDConnectionString")
        '        ' Me.ta_VIEW_departments1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDConnectionString2008PRD")
        '        Me.Ta_VIEW_GOVERNMENT_STRUCTURE1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDConnectionString")
        '        Me.CountNewUsersTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("AdsPRDConnectionString")
        '        Me.GetResetPasswordsTableAdapter1.Connection.ConnectionString = My.MySettings.Default.Default("AdsPRDConnectionString")
        '        Me.RemedyOpenRequestsTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemProdConnectionString")
        '        Me.Ta_Vulindlela_Controllers.Connection.ConnectionString = My.MySettings.Default.Default("AdsPRDConnectionString")
        '        Me.RULES_FLAGSTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("AdsPRDConnectionString")
        '        Me.Data_PersonnelAndAppointment002TableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("AdsPRDConnectionString")
        '        Me.Ta_Estab2.Connection.ConnectionString = My.MySettings.Default.Default("AdsPRDConnectionString")


        '    Else

        '        Me.GetResetPasswordsTableAdapter1.Connection.ConnectionString = My.MySettings.Default.Default("AdsQAConnectionString")
        '        Me.Department_DiffersTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("AdsQAConnectionString")
        '        Me.VIEW_CFO_APPPLICATION_TOOK_TO_LONGTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("AdsQAConnectionString")
        '        Me.Ta_VIEW_APPLICATION_RIGHTS1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDConnectionStringQA")
        '        Me.Ta_VIEW_Assigned_Departments1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDConnectionStringQA")
        '        Me.Ta_VIEW_GOVERNMENT_STRUCTURE1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDConnectionStringQA")
        '        Me.LOG_IN_Request_TrackingTableAdapter1.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemDevConnectionString")
        '        Me.LOG_DM_Customer_InformationTableAdapter1.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemDevConnectionString")
        '        Me.LOG_DM_PersonnelTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemDevConnectionString")
        '        Me.Ta_Vulindlela_Controllers.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemDevConnectionString")
        '        Me.Ta_VIEW_APPLICATION_RIGHTS1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDConnectionStringQA")
        '        Me.Ta_VIEW_Assigned_Departments1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDConnectionStringQA")
        '        Me.ta_VIEW_departments1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDConnectionStringQA")
        '        Me.Ta_VIEW_GOVERNMENT_STRUCTURE1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDConnectionStringQA")
        '        Me.CountNewUsersTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("AdsQAConnectionString")
        '        Me.GetResetPasswordsTableAdapter1.Connection.ConnectionString = My.MySettings.Default.Default("AdsQAConnectionString")
        '        Me.RemedyOpenRequestsTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemDevConnectionString")
        '        Me.Ta_Vulindlela_Controllers.Connection.ConnectionString = My.MySettings.Default.Default("AdsQAConnectionString")
        '        Me.RULES_FLAGSTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("AdsQAConnectionString")
        '        Me.Data_PersonnelAndAppointment002TableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("AdsQAConnectionString")
        '        Me.Ta_Estab2.Connection.ConnectionString = My.MySettings.Default.Default("AdsQAConnectionString")


        '    End If

        'End If



        If (Not frmEnvironment.ActiveMdiChild Is Nothing) Then

            If frmEnvironment.ActiveMdiChild.Text.Contains("- PRD") Then

                Me.GetResetPasswordsTableAdapter1.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
                Me.Department_DiffersTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
                Me.VIEW_CFO_APPPLICATION_TOOK_TO_LONGTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
                '     Me.ta_VIEW_departments1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDConnectionString")
                Me.Ta_VIEW_APPLICATION_RIGHTS1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDPRDConnectionString2014")
                Me.Ta_VIEW_Assigned_Departments1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDPRDConnectionString2014")
                Me.Ta_VIEW_GOVERNMENT_STRUCTURE1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDPRDConnectionString2014")
                Me.LOG_IN_Request_TrackingTableAdapter1.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemProdConnectionString")
                Me.LOG_DM_Customer_InformationTableAdapter1.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemProdConnectionString")
                Me.LOG_DM_PersonnelTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemProdConnectionString")
                Me.LOG_IN_Request_TrackingTableAdapter1.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemProdConnectionString")
                Me.Ta_Vulindlela_Controllers.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemProdConnectionString")
                Me.Ta_VIEW_APPLICATION_RIGHTS1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDPRDConnectionString2014")
                Me.Ta_VIEW_Assigned_Departments1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDPRDConnectionString2014")
                '  Me.ta_VIEW_departments1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDConnectionString2008PRD")
                Me.Ta_VIEW_GOVERNMENT_STRUCTURE1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDPRDConnectionString2014")
                Me.CountNewUsersTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("AdsPRDConnectionString2014")
                Me.GetResetPasswordsTableAdapter1.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
                Me.RemedyOpenRequestsTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemProdConnectionString")
                Me.Ta_Vulindlela_Controllers.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
                Me.RULES_FLAGSTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
                Me.Data_PersonnelAndAppointment002TableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
                Me.Ta_Estab2.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
                Me.LOG_IN_Request_Tracking2TableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemProdConnectionString")
                Me.VIP_USERSTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
                Me.ta_KICKOUT.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
                My.MySettings.Default.Default("AdsConnectionString") = My.MySettings.Default.Default("ADSPRDConnectionString2014")
                Me.CountNewUsersTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
                Me.VIP_USERS_ResetPasswordTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
                Me.VIP_USERS_NewUsersTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
                Me.ADCONSOLELOGTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
                Me.HR_DataTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("HR_MISConnectionStringPRD")














                'Me.GetResetPasswordsTableAdapter1.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                'Me.Department_DiffersTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                'Me.VIEW_CFO_APPPLICATION_TOOK_TO_LONGTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                'Me.Ta_VIEW_APPLICATION_RIGHTS1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")
                'Me.Ta_VIEW_Assigned_Departments1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")
                'Me.Ta_VIEW_GOVERNMENT_STRUCTURE1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")
                'Me.LOG_IN_Request_TrackingTableAdapter1.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemDevConnectionString")
                'Me.LOG_DM_Customer_InformationTableAdapter1.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemDevConnectionString")
                'Me.LOG_DM_PersonnelTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemDevConnectionString")
                'Me.Ta_Vulindlela_Controllers.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemDevConnectionString")
                'Me.Ta_VIEW_APPLICATION_RIGHTS1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")
                'Me.Ta_VIEW_Assigned_Departments1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")
                'Me.ta_VIEW_departments1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")
                'Me.Ta_VIEW_GOVERNMENT_STRUCTURE1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")
                'Me.CountNewUsersTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                'Me.GetResetPasswordsTableAdapter1.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                'Me.RemedyOpenRequestsTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemDevConnectionString")
                'Me.Ta_Vulindlela_Controllers.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                'Me.RULES_FLAGSTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                'Me.Data_PersonnelAndAppointment002TableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                'Me.Ta_Estab2.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                'Me.LOG_IN_Request_Tracking2TableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemDevConnectionString")
                'Me.VIP_USERSTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                'Me.RULES_FLAGSTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                'Me.CountNewUsersTableAdapter.Connection.ConnectionString = My.MySettings.Default("ADSQAConnectionString2014")
                ''My.MySettings.Default.Default("AdsConnectionString") = My.MySettings.Default.Default("ADSQAConnectionString2014")
                'Me.ta_KICKOUT.Connection.ConnectionString = My.MySettings.Default("ADSQAConnectionString2014")

                ''My.MySettings.Default("AdsConnectionString") = My.MySettings.Default("ADSQAConnectionString2014")
                ''My.MySettings.Default("ADSPRDConnectionString2014") = My.MySettings.Default("ADSQAConnectionString2014")
                ''My.MySettings.Default.Default("VIP_EXPANDEDConnectionString") = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")

                ''My.MySettings.Default.Default("ARSystemConnectionString") = My.MySettings.Default.Default("ARSystemDevConnectionString")
                ''My.MySettings.Default.Default("ARSystemProdConnectionString") = My.MySettings.Default.Default("ARSystemDevConnectionString")



            Else

                Me.GetResetPasswordsTableAdapter1.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                Me.Department_DiffersTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                Me.VIEW_CFO_APPPLICATION_TOOK_TO_LONGTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                Me.Ta_VIEW_APPLICATION_RIGHTS1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")
                Me.Ta_VIEW_Assigned_Departments1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")
                Me.Ta_VIEW_GOVERNMENT_STRUCTURE1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")
                Me.LOG_IN_Request_TrackingTableAdapter1.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemDevConnectionString")
                Me.LOG_DM_Customer_InformationTableAdapter1.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemDevConnectionString")
                Me.LOG_DM_PersonnelTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemDevConnectionString")
                Me.Ta_Vulindlela_Controllers.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemDevConnectionString")
                Me.Ta_VIEW_APPLICATION_RIGHTS1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")
                Me.Ta_VIEW_Assigned_Departments1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")
                '   Me.ta_VIEW_departments1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")
                Me.Ta_VIEW_GOVERNMENT_STRUCTURE1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")
                Me.CountNewUsersTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                Me.GetResetPasswordsTableAdapter1.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                Me.RemedyOpenRequestsTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemDevConnectionString")
                Me.Ta_Vulindlela_Controllers.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                Me.RULES_FLAGSTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                Me.Data_PersonnelAndAppointment002TableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                Me.Ta_Estab2.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                Me.LOG_IN_Request_Tracking2TableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemDevConnectionString")
                Me.VIP_USERSTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                Me.RULES_FLAGSTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                Me.CountNewUsersTableAdapter.Connection.ConnectionString = My.MySettings.Default("ADSQAConnectionString2014")
                Me.VIP_USERS_ResetPasswordTableAdapter.Connection.ConnectionString = My.MySettings.Default("ADSQAConnectionString2014")
                Me.VIP_USERS_NewUsersTableAdapter.Connection.ConnectionString = My.MySettings.Default("ADSQAConnectionString2014")
                'My.MySettings.Default.Default("AdsConnectionString") = My.MySettings.Default.Default("ADSQAConnectionString2014")
                Me.ta_KICKOUT.Connection.ConnectionString = My.MySettings.Default("ADSQAConnectionString2014")
                Me.ADCONSOLELOGTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                Me.HR_DataTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("HR_MISConnectionStringDev")

                'My.MySettings.Default("AdsConnectionString") = My.MySettings.Default("ADSQAConnectionString2014")
                'My.MySettings.Default("ADSPRDConnectionString2014") = My.MySettings.Default("ADSQAConnectionString2014")
                'My.MySettings.Default.Default("VIP_EXPANDEDConnectionString") = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")

                'My.MySettings.Default.Default("ARSystemConnectionString") = My.MySettings.Default.Default("ARSystemDevConnectionString")
                'My.MySettings.Default.Default("ARSystemProdConnectionString") = My.MySettings.Default.Default("ARSystemDevConnectionString")

            End If

        End If



        If Me.txtPersalNumber.Text = "" Then
        Else
            If Microsoft.VisualBasic.Left(txtPersalNumber.Text, 1).ToUpper <> "T" Then
                Try
                    Dim provcode As String
                    Dim estab As DataTable = Me.HR_DataTableAdapter.GetData(Me.txtPersalNumber.Text.Trim.ToUpper)
                    Dim deptcode As String
                    If estab.Rows.Count > 0 Then
                        deptcode = estab.Rows(0).Item(0).ToString()
                        If estab.Rows(0).Item(0).ToString().IndexOf("_") > 0 Then
                            provcode = Microsoft.VisualBasic.Left(estab.Rows(0).Item(0).ToString(), 3)
                        Else
                            provcode = "nat"
                        End If
                        Me.cboNatProv.SelectedValue = provcode
                    End If
                Catch ex As Exception
                    MsgBox("Establisment Database is offline at the moment. Please try again later", MsgBoxStyle.OkOnly, "System Message")
                End Try
            End If
        End If


        For i = 0 To lwApplicationRoles.Items.Count - 1
            lwApplicationRoles.Items(i).Checked = False
            lwApplicationRoles.Items(i).BackColor = Color.White
        Next


        Try
            Me.LOG_DM_Customer_InformationTableAdapter1.FillBy_PersalNumber(ARSystemDataSet.LOG_DM_Customer_Information, Me.txtPersalNumber.Text.Trim.ToUpper)
            Me.LOG_IN_Request_TrackingTableAdapter1.FillBy_Persalnumber(ARSystemDataSet.LOG_IN_Request_Tracking, Me.txtPersalNumber.Text.Trim.ToUpper)
            Me.ADCONSOLELOGTableAdapter.Fill(Me.Ads1.ADCONSOLELOG, Me.txtPersalNumber.Text.Trim.ToUpper)
            Me.VIP_USERSTableAdapter.Fill(Me.Ads1.VIP_USERS, Me.txtPersalNumber.Text.Trim.ToUpper)
            Me.txtPersalNumber.Focus()
            Me.txtPersalNumber.SelectAll()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Me.Cursor = Cursors.Arrow
    End Sub

    Public Sub get_ad_info(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim grps As Collection
        Dim dept As String

        grps = modADS.Get_UserGroups(modADS.Get_ValidUsername(Me.txtPersalNumber.Text))
        dept = modADS.Get_Department(modADS.Get_ValidUsername(Me.txtPersalNumber.Text))

        Me.Cursor = Cursors.Arrow
    End Sub

    Public Sub set_departments(ByVal DEPTCODE As String, ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim i As Integer
        Dim item As ListViewItem
        Dim natprov As String
        Dim natprovcode() As String
        Dim provcode As String

        natprovcode = Split(DEPTCODE, "_")

        If natprovcode.Count > 1 Then
            provcode = natprovcode(0)
        Else
            provcode = "nat"
        End If

        For i = 0 To Me.cboNatProv.Items.Count - 1
            natprov = Me.cboNatProv.Items(i).Item(0).ToString()
            If natprov = provcode Then
                Me.cboNatProv.SelectedIndex = i
                Exit For
            End If
        Next

        For Each item In lwDepartments.Items
            If item.SubItems(1).Text = DEPTCODE Then
                item.Selected = True
                item.Focused = True
                item.EnsureVisible()
                Exit Sub
            End If
        Next

        For Each item In lwA.Items
            If item.SubItems(1).Text = DEPTCODE Then
                item.Selected = True
                item.Focused = True
                item.EnsureVisible()
                Exit Sub
            End If
        Next


        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub lwDepartments_ItemCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles lwDepartments.ItemCheck
        Dim item As ListViewItem

        If CI = e.Index Then
            Exit Sub
        End If

        For Each item In lwDepartments.Items
            item.Checked = False
            item.BackColor = Color.White
        Next
        CI = e.Index
        lwDepartments.Items(e.Index).Checked = True
        lwDepartments.Items(e.Index).BackColor = Color.Gainsboro

        Me.Cursor = Cursors.Arrow
    End Sub
    ' JOHAN VERMEULEN
    Private Sub lwDepartments_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lwDepartments.SelectedIndexChanged

        Dim i As Integer
        Dim it As ListViewItem
        Dim item As ListViewItem
        Dim checkedItems2 As ListView.CheckedListViewItemCollection

        Try
            it = lwDepartments.SelectedItems(0)
            it.BackColor = Color.Gainsboro
        Catch ex As Exception
            it = Nothing
            Exit Sub
        End Try


        checkedItems2 = lwDepartments.CheckedItems

        If it.Index > -1 Then
            i = it.Index

            If checkedItems2.Count > 0 Then

                For Each item In checkedItems2
                    item.Checked = False
                    item.BackColor = Color.White
                Next

            End If

            it.Checked = True

        End If
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub rbAccountLevel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbAccountLevel2.Click
        Me.TabControl1.SelectTab(0)
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub rbAccountLevel3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbAccountLevel3.Click
        Me.TabControl1.SelectTab(0)
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub rbAccountLevel4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbAccountLevel4.Click
        Me.TabControl1.SelectTab(0)
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub rbAccountLevel5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbAccountLevel5.Click
        Me.TabControl1.SelectTab(0)
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub rbAccountLevel6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbAccountLevel6.Click
        Me.TabControl1.SelectTab(0)
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub rbAccountLevel7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.TabControl1.SelectTab(1)
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub lwApplicationRoles_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lwApplicationRoles.ColumnClick
        If e.Column = lvwColumnSorter.SortColumn Then
            If lvwColumnSorter.Order = Windows.Forms.SortOrder.Ascending Then
                lvwColumnSorter.Order = Windows.Forms.SortOrder.Descending
            Else
                lvwColumnSorter.Order = Windows.Forms.SortOrder.Ascending
            End If
        Else
            lvwColumnSorter.SortColumn = e.Column
            lvwColumnSorter.Order = Windows.Forms.SortOrder.Ascending
        End If

        Me.lwApplicationRoles.Sort()
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub chkProfileCategories_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)


        Dim i As Integer, x As Integer, ss As String
        Dim level As String = ""
        If Me.rbAccountLevel2.Checked Then
            level = Me.rbAccountLevel2.Tag.ToString
        ElseIf Me.rbAccountLevel3.Checked Then
            level = Me.rbAccountLevel3.Tag.ToString
        ElseIf Me.rbAccountLevel4.Checked Then
            level = Me.rbAccountLevel4.Tag.ToString
        ElseIf Me.rbAccountLevel5.Checked Then
            level = Me.rbAccountLevel5.Tag.ToString
        ElseIf Me.rbAccountLevel6.Checked Then
            level = Me.rbAccountLevel6.Tag.ToString
        ElseIf Me.rbAccountLevel7.Checked Then
            level = Me.rbAccountLevel7.Tag.ToString
        End If

        For i = 0 To chkProfileCategories.CheckedIndices.Count - 1
            ss = chkProfileCategories.Items(chkProfileCategories.CheckedIndices.Item(i)).ToString
            For x = 0 To Me.lwApplicationRoles.Items.Count - 1
                If Not Me.lwApplicationRoles.Items(x).Checked And _
                    Me.lwApplicationRoles.Items(x).SubItems(1).Text.ToUpper = ss.ToUpper & "." & level.ToUpper Then
                    Me.lwApplicationRoles.Items(x).Checked = True
                End If
                If Not Me.lwApplicationRoles.Items(x).Checked And _
                    Me.lwApplicationRoles.Items(x).SubItems(1).Text.ToUpper = ss.ToUpper Then
                    Me.lwApplicationRoles.Items(x).Checked = True
                End If
            Next
        Next
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub rbAccountLevel2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbAccountLevel2.CheckedChanged
        For Each item As ListViewItem In Me.lwA.CheckedItems
            item.Checked = False
        Next
        chkProfileCategories_ItemChecked(sender, e)
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub rbAccountLevel3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbAccountLevel3.CheckedChanged
        For Each item As ListViewItem In Me.lwA.CheckedItems
            item.Checked = False
        Next
        chkProfileCategories_ItemChecked(sender, e)
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub rbAccountLevel4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbAccountLevel4.CheckedChanged
        For Each item As ListViewItem In Me.lwA.CheckedItems
            item.Checked = False
        Next
        chkProfileCategories_ItemChecked(sender, e)
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub rbAccountLevel5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbAccountLevel5.CheckedChanged
        For Each item As ListViewItem In Me.lwA.CheckedItems
            item.Checked = False
        Next
        chkProfileCategories_ItemChecked(sender, e)
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub rbAccountLevel6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbAccountLevel6.CheckedChanged
        'ENTIRE RSA
        For Each item As ListViewItem In Me.lwA.CheckedItems
            item.Checked = False
        Next
        chkProfileCategories_ItemChecked(sender, e)
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub rbAccountLevel7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbAccountLevel7.CheckedChanged
        chkProfileCategories_ItemChecked(sender, e)
        Me.Cursor = Cursors.Arrow
    End Sub

    ' This is working quite fine
    ' IN HOUSE

    Public Sub load_lv_assigned_department_rights()
        Dim rr As DataRow
        Dim col As Integer = 0
        Dim dt As DataTable = Me.Ta_VIEW_APPLICATION_RIGHTS.GetApplicationEnums()
        Dim str(2) As String

        Me.lwApplicationRoles.Items.Clear()

        For Each rr In dt.Rows
            str(1) = rr(1).ToString.Trim
            str(2) = rr(0).ToString.Trim
            Dim lv As New ListViewItem(str)
            Me.lwApplicationRoles.Items.Add(lv)
            lv = Nothing
        Next

        Me.Cursor = Cursors.Arrow

    End Sub

    Private Sub load_lv_maindepartment(ByVal persalnumber As String)

        Dim i As Integer
        Dim natprov As String
        Dim userDept As String = modADS.Get_Department(persalnumber)

        If InStr(userDept, "_") = 0 Then
            natprov = "nat"
        Else
            natprov = Microsoft.VisualBasic.Left(userDept, 3)
        End If

        For i = 0 To Me.cboNatProv.Items.Count - 1
            If Me.cboNatProv.Items(i).Item(0).ToString = natprov Then
                Me.cboNatProv.SelectedIndex = i
            End If
        Next

        For i = 0 To Me.lwDepartments.Items.Count - 1
            If Me.lwDepartments.Items(i).SubItems(1).Text.Trim.ToUpper = userDept.Trim.ToUpper Then
                Me.lwDepartments.Items(i).Checked = True
                Me.lwDepartments.Items(i).BackColor = Color.Gainsboro
                Me.lwDepartments.Items(i).EnsureVisible()
            End If
        Next

        For i = 0 To Me.lwA.Items.Count - 1
            If Me.lwA.Items(i).SubItems(1).Text.Trim.ToUpper = userDept.Trim.ToUpper Then
                Me.lwA.Items(i).Checked = True
                Me.lwA.Items(i).BackColor = Color.Gainsboro
                Me.lwA.Items(i).EnsureVisible()
            End If
        Next
        Me.Cursor = Cursors.Arrow

    End Sub

    Private Sub tsBtnDeleteUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsBtnDeleteUser.Click
        If MsgBox("Are you sure you wanna delete this user profile?", MsgBoxStyle.YesNo, "System Message") = MsgBoxResult.Yes Then

            Do_DeleteUser(Get_ValidUsername(Me.txtPersalNumber.Text))
            Do_FrmButtons(True, False, False)
            Do_FrmLists()
            btnActiveDirectory_Click(sender, e)

        End If
        Me.Cursor = Cursors.Arrow
    End Sub

    Public Sub Do_FrmButtons(ByVal btnNew As Boolean, ByVal btnUpdate As Boolean, ByVal btnDelete As Boolean)

        If btnNew = True Then
            Me.tsBtnNewUser.Enabled = True
            Me.chkLocked.Enabled = False
            Me.chkEnabled.Enabled = False
            Me.btnExpireAccXdays.Enabled = False
            Me.dtpAccountExpireDate.Enabled = False
        Else
            Me.tsBtnNewUser.Enabled = False
            Me.chkLocked.Enabled = True
            Me.chkEnabled.Enabled = True
            Me.btnExpireAccXdays.Enabled = True
            Me.dtpAccountExpireDate.Enabled = True
        End If

        If btnUpdate = True Then
            Me.tsBtnUpdateUser.Enabled = True
        Else
            Me.tsBtnUpdateUser.Enabled = False
        End If

        If btnDelete = True Then
            Me.tsBtnDeleteUser.Enabled = True
        Else
            Me.tsBtnDeleteUser.Enabled = False
        End If

        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub btnExpirePassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExpirePassword.Click


        Dim s As String
        Dim dt As New DataTable
        Dim DEPTCODE As String
        Dim Ids As String



        ' Dim Ids As String = dt.Rows(0).Item("Id").ToString.Trim & "" & ControlChars.CrLf 'frmResetPassword.VIP_USERS_ResetPasswordDataGridView.CurrentRow.Cells("PersalNrDataGridViewTextBoxColumn").Value.ToString().Trim



        If Not Me.txtPersalNumber.Text = "" Then

            If MsgBox("Are you sure your want to FORCE a password change?", MsgBoxStyle.YesNo, "System Message") = MsgBoxResult.Yes Then
                Do_EnableAccount(Get_ValidPersalNumber(Me.txtPersalNumber.Text))
                Do_ExpirePasswordNow(Get_ValidPersalNumber(Me.txtPersalNumber.Text))
                MsgBox("User : " & Me.txtPersalNumber.Text.Trim.ToUpper & " password forced.", MsgBoxStyle.OkOnly, "System Message")
            End If

            If MsgBox("Do you want to send an EMail to the user as well?", MsgBoxStyle.YesNo, "System Message") = MsgBoxResult.Yes Then
                NotifyUserAccountResetToolStripMenuItem_Click(sender, e)
                MsgBox("Email sent to : " & Me.txtPersalNumber.Text.Trim.ToUpper, MsgBoxStyle.OkOnly, "System Message")
            End If





            If Me.txtPersalNumber.Text = "" Then
            Else
                'dt = Me.VIP_USERS_ResetPasswordTableAdapter.GetDataByPersal(Me.txtPersalNumber.Text)
                If dt.Rows.Count > 0 Then
                    Ids = dt.Rows(0).Item("ID").ToString.Trim


                    'DEPTCODE = ""
                    ' set_departments(dt.Rows(0).Item(0).ToString.Trim, sender, e)
                    'MsgBox(s, MsgBoxStyle.OkOnly, "System Message")
                Else

                End If

            End If






            ' modADS.MarkAsDone(Ids, Me.txtPersalNumber.Text)

            ' frmResetPassword.FlagSuspiciousRemoveToolStripMenuItem_Click(sender, e)

        End If
        Me.Cursor = Cursors.Arrow
    End Sub

    Public Function build_ftp_access_col() As Microsoft.VisualBasic.Collection
        Dim item As ListViewItem
        Dim col As New Microsoft.VisualBasic.Collection
        Dim ii As Integer = chkProfileCategories.CheckedItems.Count
        Dim checkedItems As ListView.CheckedListViewItemCollection = chkProfileCategories.CheckedItems

        For Each item In checkedItems
            If item.Text.ToString.ToUpper = "FTP_ACCESS" Then
                col.Add(item.Text)
            End If
        Next
        build_ftp_access_col = col
        Return build_ftp_access_col

    End Function

    Public Function build_chkProfileCategories_col() As Microsoft.VisualBasic.Collection
        Dim item As ListViewItem
        Dim col As New Microsoft.VisualBasic.Collection
        Dim ii As Integer = chkProfileCategories.CheckedItems.Count
        Dim checkedItems As ListView.CheckedListViewItemCollection = chkProfileCategories.CheckedItems

        For Each item In checkedItems
            col.Add(item.Text)
        Next
        build_chkProfileCategories_col = col

        Return build_chkProfileCategories_col

    End Function

    Public Function create_ad_applevel_collection() As Microsoft.VisualBasic.Collection
        Dim applevel As String
        Dim col As New Microsoft.VisualBasic.Collection

        If rbAccountLevel2.Checked Then
            applevel = rbAccountLevel2.Tag.ToString
        ElseIf rbAccountLevel3.Checked Then
            applevel = rbAccountLevel3.Tag.ToString
        ElseIf rbAccountLevel4.Checked Then
            applevel = rbAccountLevel4.Tag.ToString
        ElseIf rbAccountLevel5.Checked Then
            applevel = rbAccountLevel5.Tag.ToString
        ElseIf rbAccountLevel6.Checked Then
            applevel = rbAccountLevel6.Tag.ToString
        ElseIf rbAccountLevel7.Checked Then
            applevel = rbAccountLevel7.Tag.ToString
        End If

        For i As Integer = 0 To Me.lwA.CheckedItems.Count - 1
            col.Add(Me.lwA.CheckedItems(i).SubItems(1).Text.Trim & "." & applevel.Trim)
        Next
        create_ad_applevel_collection = col

        Me.Cursor = Cursors.Arrow

    End Function

    Public Function GetUserName(Optional ByVal strLoginName As String = "", Optional ByVal strDomainName As String = "TREASURY") As String

        Dim strPath As String = ""
        Dim strDomain As String = ""
        Dim strLogin As String = ""
        Dim strFullName As String = ""

        If strDomainName = "" Then
            strDomain = Me.GetDomainName()
        Else
            strDomain = strDomainName
        End If

        If strLoginName = "" Then
            strLogin = Me.GetLoginName()
        Else
            strLogin = strLoginName
        End If

        strPath = "WinNT://" & strDomain & "/" & strLogin

        Dim dsDirectoryEntry As DirectoryEntry = New DirectoryEntry(strPath)

        Try
            strFullName = CType(dsDirectoryEntry.Invoke("Get", "FullName"), String)
        Catch ex As Exception
            strFullName = "None"
        Finally
            dsDirectoryEntry.Close()
            dsDirectoryEntry.Dispose()
        End Try
        GetUserName = strFullName
        Me.Cursor = Cursors.Arrow
    End Function

    Public Function GetUserFirstName(Optional ByVal strFullName As String = "") As String
        If strFullName.Trim = "" Then strFullName = GetUserName()
        If strFullName.IndexOf(" ") >= 0 Then
            Return strFullName.Substring(0, strFullName.IndexOf(" ")).Trim
        Else
            Return strFullName
        End If
        Me.Cursor = Cursors.Arrow
    End Function

    Public Function GetUserLastName(Optional ByVal strFullName As String = "") As String
        If strFullName.IndexOf(" ") >= 0 Then
            Return strFullName.Substring(strFullName.IndexOf(" ") + 1).Trim
        Else
            Return strFullName
        End If
    End Function

    Public Function GetLoginName() As String
        Return System.Environment.UserName
    End Function

    Public Function GetDomainName() As String
        Dim strDomain As String
        strDomain = System.Security.Principal.WindowsIdentity.GetCurrent.Name
        strDomain = Mid(strDomain, 1, InStr(strDomain, "\") - 1)
        Return strDomain
    End Function

    Public Function GetComputerName() As String
        Return System.Environment.MachineName
    End Function

    Private Sub chkAccountStatus_ItemCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs)
        If e.NewValue = CheckState.Checked And e.Index = 0 Then
            tsStatus.Text = "Account is Locked"
        ElseIf e.NewValue = CheckState.Unchecked And e.Index = 0 Then
            modADS.Do_Unlockaccount(txtPersalNumber.Text)
        ElseIf e.NewValue = CheckState.Checked And e.Index = 1 Then
            modADS.Do_EnableAccount(txtPersalNumber.Text)
        ElseIf e.NewValue = CheckState.Unchecked And e.Index = 1 Then
            modADS.Do_DisableAccount(txtPersalNumber.Text)
        End If
    End Sub

    Private Sub chkEnabled_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkEnabled.Click
        If chkEnabled.CheckState = CheckState.Unchecked Then
            modADS.Do_DisableAccount(txtPersalNumber.Text)
        ElseIf chkEnabled.CheckState = CheckState.Checked Then
            modADS.Do_EnableAccount(txtPersalNumber.Text)
        End If
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub chkLocked_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkLocked.CheckedChanged

        If chkLocked.CheckState = CheckState.Unchecked Then
            modADS.Do_Unlockaccount(txtPersalNumber.Text)
            chkLocked.BackColor = Color.Gainsboro
            If frmEnvironment.ChildFormPRD.Visible Then
                Me.ADCONSOLELOGTableAdapter.InsertIntoADAdminConsoleLog2(frmEnvironment.ChildFormPRD.tsLabelVulname.Text, Get_ValidPersalNumber(txtPersalNumber.Text.Trim), "Account Unlocked", False)
                frmEnvironment.ChildFormPRD.Refresh_Log()
            Else
                Me.ADCONSOLELOGTableAdapter.InsertIntoADAdminConsoleLog2(frmEnvironment.childformQA.tsLabelVulname.Text, Get_ValidPersalNumber(txtPersalNumber.Text.Trim), "Account Unlocked", False)
                frmEnvironment.childformQA.Refresh_Log()
            End If
        Else
            chkLocked.BackColor = Color.Red
        End If

    End Sub

    Public Sub txtPersalNumberKeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Me.txtPersalNumber_KeyPress(sender, e)
    End Sub

    Private Sub uncheck_chkProfileCategories_all(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim y As Integer
        For y = 0 To chkProfileCategories.Items.Count - 1
            chkProfileCategories.Items(y).Checked = False
        Next
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub TitleLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        uncheck_chkProfileCategories_all(sender, e)
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub txtPersalNumber_Enter(sender As Object, e As EventArgs) Handles txtPersalNumber.Enter

    End Sub
    Public Sub txtPersalNumber_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPersalNumber.KeyPress
        If e.KeyChar.ToString = Chr(13) Then
            tsLabelREMEDY.Text = ""
            btnActiveDirectory_Click(sender, e)
        End If
    End Sub

    Public Sub load_lv_application_rights()
        Dim rr As DataRow
        Dim col As Integer = 0
        Dim dt As DataTable = Me.Ta_VIEW_APPLICATION_RIGHTS1.GetApplicationEnums()
        Dim str(2) As String

        Me.lwApplicationRoles.Items.Clear()
        For Each rr In dt.Rows
            str(1) = rr(1).ToString.Trim
            str(2) = rr(0).ToString.Trim
            Dim lv As New ListViewItem(str)
            Me.lwApplicationRoles.Items.Add(lv)
            lv = Nothing
        Next

        str(1) = "99 - User Develops Custom Applications"
        str(2) = "FLAG.IN_HOUSE_APPS_RESPONSIBILITIES"

        Dim lv2 As New ListViewItem(str)
        Me.lwApplicationRoles.Items.Add(lv2)
        lv2 = Nothing

        Me.Cursor = Cursors.Arrow

    End Sub

    Private Sub chkProfileCategories_ItemChecked(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkProfileCategories.ItemChecked

        Dim i As Integer, x As Integer, ss As String
        Dim level As String = ""

        If Me.rbAccountLevel2.Checked Then
            level = Me.rbAccountLevel2.Tag.ToString
        ElseIf Me.rbAccountLevel3.Checked Then
            level = Me.rbAccountLevel3.Tag.ToString
        ElseIf Me.rbAccountLevel4.Checked Then
            level = Me.rbAccountLevel4.Tag.ToString
        ElseIf Me.rbAccountLevel5.Checked Then
            level = Me.rbAccountLevel5.Tag.ToString
        ElseIf Me.rbAccountLevel6.Checked Then
            level = Me.rbAccountLevel6.Tag.ToString
        ElseIf Me.rbAccountLevel7.Checked Then
            level = Me.rbAccountLevel7.Tag.ToString
        End If

        For x = 0 To Me.lwApplicationRoles.Items.Count - 1
            Me.lwApplicationRoles.Items(x).Checked = False
        Next

        If level IsNot Nothing Then

            For i = 1 To chkProfileCategories.CheckedIndices.Count
                ss = chkProfileCategories.Items(chkProfileCategories.CheckedIndices.Item(i - 1)).Text.ToString
                For x = 1 To Me.lwApplicationRoles.Items.Count
                    If Not Me.lwApplicationRoles.Items(x - 1).Checked And _
                        Me.lwApplicationRoles.Items(x - 1).SubItems(1).Text.ToUpper = ss.ToUpper & "." & level.ToUpper Then
                        If ss.ToUpper = "FTP_ACCESS" And level.ToUpper = "ASSIGN_DEPT" Then
                            ' Do  Nothing 
                        Else
                            Me.lwApplicationRoles.Items(x - 1).Checked = True
                        End If

                    End If
                Next
            Next

        End If

        ButtonsRefreshTimer_Tick(sender, e)
        Me.Cursor = Cursors.Arrow

    End Sub

    Public Sub Do_FrmLists()

        For i As Integer = 0 To Me.lwDepartments.Items.Count - 1
            Me.lwDepartments.Items(i).Checked = False
            Me.lwDepartments.Items(i).BackColor = Color.White
        Next

        For i As Integer = 0 To Me.lwApplicationRoles.Items.Count - 1
            Me.lwApplicationRoles.Items(i).Checked = False
            Me.lwApplicationRoles.Items(i).BackColor = Color.White
        Next

        For i As Integer = 0 To Me.lwA.Items.Count - 1
            Me.lwA.Items(i).Checked = False
            Me.lwA.Items(i).BackColor = Color.White
        Next

        Me.Cursor = Cursors.Arrow

    End Sub

    Public Sub Refresh_Log()
        Me.ADCONSOLELOGTableAdapter.Fill(Ads1.ADCONSOLELOG, Me.txtPersalNumber.Text.Trim.ToUpper)
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Function Get_Vulindlela_ProvController(ByVal SCode As String) As Microsoft.VisualBasic.Collection

        Dim pos As Integer
        Dim row As DataRow
        Dim pcode As String
        Dim tbl As New DataTable
        Dim col As New Microsoft.VisualBasic.Collection

        pos = Microsoft.VisualBasic.InStr(1, SCode, "_")
        If pos > 0 Then
            pcode = Microsoft.VisualBasic.Left(SCode, pos - 1)
        End If

        If Microsoft.VisualBasic.Len(pcode) > 0 Then
            tbl = Me.Ta_Vulindlela_Controllers.GetDataByProvController(pcode)
        Else
            tbl = Me.Ta_Vulindlela_Controllers.GetDataByProvController("NAT")
        End If


        SyncLock col
            For Each row In tbl.Rows
                col.Add(row("FullName").ToString & " <" & row("EMail").ToString & ">")
            Next
        End SyncLock


        Return col

    End Function

    Private Sub NotifyUserAccountUpdatedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotifyUserAccountUpdatedToolStripMenuItem.Click

        If txtPersalNumber.Text.Trim = "" Then
            Exit Sub
        End If

        Dim i As Integer
        Dim a() As String
        Dim scode As String = ""
        Dim subject As String = ""
        Dim applcol As String = ""
        Dim deptcol As String = ""

        Dim tbl1 As DataTable
        Dim returnaddress As String = ""
        Dim persalnumber As String = ""
        Dim col As New Microsoft.VisualBasic.Collection
        Dim colTO As New Microsoft.VisualBasic.Collection
        Dim colCC As New Microsoft.VisualBasic.Collection
        Dim appl_col As New Microsoft.VisualBasic.Collection
        Dim dept_col As New Microsoft.VisualBasic.Collection

        scode = Me.lwDepartments.CheckedItems(0).SubItems(1).Text.Trim
        persalnumber = modADS.Get_ValidUsername(Me.txtPersalNumber.Text.Trim)

        tbl1 = Me.ta_Vulindlela_Email.GetData("Vulindlela User Created or Updated as Follows")
        colCC = Get_Vulindlela_ProvController(scode)

        If tbl1.Rows.Count > 0 Then

            subject = tbl1.Rows(0).Item("SUBJECT").ToString
            returnaddress = tbl1.Rows(0).Item("RETURN_ADDRESS").ToString

            colTO.Add(Me.txtE_MailTextBox.Text.Trim)

            a = Split(tbl1.Rows(0).Item("TO_ADDRESS").ToString, ";")
            If a(0) <> "" Then
                For i = 0 To UBound(a)
                    colTO.Add(a(i))
                Next
            End If
            a = Split(tbl1.Rows(0).Item("CC_ADDRESS").ToString, ";")
            If a(0) <> "" Then
                For i = 0 To UBound(a)
                    colCC.Add(a(i))
                Next
            End If

        End If


        If lwApplicationRoles.CheckedItems.Count > 0 Then
            For i = 0 To lwApplicationRoles.CheckedItems.Count - 1
                applcol += lwApplicationRoles.CheckedItems(i).SubItems(1).Text.ToString() & " " & "<BR>"
            Next
        Else
            applcol = " "
        End If


        deptcol = ""
        If lwA.CheckedItems.Count > 0 Then
            For i = 0 To lwA.CheckedItems.Count - 1
                deptcol += lwA.CheckedItems(i).SubItems(1).Text.ToString() & " (" & lwA.CheckedItems(i).SubItems(2).Text.ToString() & ")<BR>"
            Next
        Else
            deptcol = scode
        End If

        col.Add("username~~" & persalnumber & "")
        col.Add("helpdesk_phoneno~~" & My.Settings.HelpDesk_PhoneNo.Trim() & "")
        col.Add("email_address~~" & Me.txtE_MailTextBox.Text.Trim & "")
        col.Add("title~~" & Me.txtTitleTextBox.Text.Trim & "")
        col.Add("name~~" & Me.txtFirst_NameTextBox.Text.Trim & "")
        col.Add("lastname~~" & Me.txtLast_NameTextBox.Text.Trim & "")
        col.Add("telephonenumber~~" & Me.txtTelephoneTextBox.Text.Trim & "")
        col.Add("cellular~~" & Me.txtCellphoneTextBox.Text.Trim & "")
        col.Add("email~~" & Me.txtE_MailTextBox.Text.Trim & "")
        col.Add("own_dept~~" & scode & " (" & Me.lwDepartments.CheckedItems(0).SubItems(2).Text.Trim & ")")
        col.Add("appl_col~~" & applcol)
        col.Add("dept_col~~" & deptcol)

        ParseFile_Email("Vulindlela User Created or Updated as Follows.htt", col, colTO, colCC, returnaddress)

        col = Nothing

        If frmEnvironment.ChildFormPRD.Visible Then
            frmEnvironment.ChildFormPRD.ADCONSOLELOGTableAdapter.InsertIntoADAdminConsoleLog2( _
                    frmEnvironment.ChildFormPRD.tsLabelVulname.Text, Get_ValidPersalNumber( _
                    frmEnvironment.ChildFormPRD.txtPersalNumber.Text.Trim), "EMailed : " & Me.txtE_MailTextBox.Text.Trim, False)
            frmEnvironment.ChildFormPRD.Refresh_Log()
        Else
            frmEnvironment.childformQA.ADCONSOLELOGTableAdapter.InsertIntoADAdminConsoleLog2( _
                    frmEnvironment.childformQA.tsLabelVulname.Text, Get_ValidPersalNumber( _
                    frmEnvironment.childformQA.txtPersalNumber.Text.Trim), "EMailed : " & Me.txtE_MailTextBox.Text.Trim, False)
            frmEnvironment.childformQA.Refresh_Log()
        End If

        Me.Cursor = Cursors.Arrow

        MsgBox("User : " & Me.txtPersalNumber.Text.Trim.ToUpper & " profile Created or Updated.", MsgBoxStyle.OkOnly, "System Message")

    End Sub

    Public Sub NotifyUserAccountResetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotifyUserAccountResetToolStripMenuItem.Click

        If ADAdminDotNet.frmEnvironment.ActiveMdiChild.Text = "Active Directory Console - PRD" Then
            If frmEnvironment.ChildFormPRD.txtPersalNumber.Text.Trim = "" Then
                Exit Sub
            End If
        ElseIf ADAdminDotNet.frmEnvironment.ActiveMdiChild.Text = "Active Directory Console - QA" Then
            If frmEnvironment.childformQA.txtPersalNumber.Text.Trim = "" Then
                Exit Sub
            End If
        End If

        Dim i As Integer
        Dim a() As String
        Dim scode As String = ""
        Dim subject As String = ""
        Dim applcol As String = ""
        Dim deptcol As String = ""

        Dim tbl1 As DataTable
        Dim returnaddress As String = ""
        Dim persalnumber As String = ""
        Dim col As New Microsoft.VisualBasic.Collection
        Dim colTO As New Microsoft.VisualBasic.Collection
        Dim colCC As New Microsoft.VisualBasic.Collection

        If Me.lwDepartments.CheckedItems.Count > 0 Then
            scode = Me.lwDepartments.CheckedItems(0).SubItems(1).Text.Trim
            persalnumber = modADS.Get_ValidUsername(Me.txtPersalNumber.Text.Trim)

            tbl1 = Me.ta_Vulindlela_Email.GetData("Vulindlela User Account Reset")
            colCC = Get_Vulindlela_ProvController(scode)

            If tbl1.Rows.Count > 0 Then

                subject = tbl1.Rows(0).Item("SUBJECT").ToString
                returnaddress = tbl1.Rows(0).Item("RETURN_ADDRESS").ToString

                colTO.Add(Me.txtE_MailTextBox.Text.Trim)

                a = Split(tbl1.Rows(0).Item("TO_ADDRESS").ToString, ";")
                If a(0) <> "" Then
                    For i = 0 To UBound(a)
                        colTO.Add(a(i))
                    Next
                End If
                a = Split(tbl1.Rows(0).Item("CC_ADDRESS").ToString, ";")
                If a(0) <> "" Then
                    For i = 0 To UBound(a)
                        colCC.Add(a(i))
                    Next
                End If

            End If

            col.Add("username~~" & persalnumber & "")
            col.Add("helpdesk_phoneno~~" & My.Settings.HelpDesk_PhoneNo.Trim() & "")
            col.Add("email_address~~" & Me.txtE_MailTextBox.Text.Trim & "")

            ParseFile_Email("Vulindlela User Account Reset.htt", col, colTO, colCC, returnaddress)

            col = Nothing

            If frmEnvironment.ChildFormPRD.Visible Then
                frmEnvironment.ChildFormPRD.ADCONSOLELOGTableAdapter.InsertIntoADAdminConsoleLog2( _
                        frmEnvironment.ChildFormPRD.tsLabelVulname.Text, Get_ValidPersalNumber( _
                        frmEnvironment.ChildFormPRD.txtPersalNumber.Text.Trim), "Reset & EMailed : " & Me.txtE_MailTextBox.Text.Trim, False)
                frmEnvironment.ChildFormPRD.Refresh_Log()
            Else
                frmEnvironment.childformQA.ADCONSOLELOGTableAdapter.InsertIntoADAdminConsoleLog2( _
                        frmEnvironment.childformQA.tsLabelVulname.Text, Get_ValidPersalNumber( _
                        frmEnvironment.childformQA.txtPersalNumber.Text.Trim), "Reset & EMailed : " & Me.txtE_MailTextBox.Text.Trim, False)
                frmEnvironment.childformQA.Refresh_Log()
            End If
            MsgBox("User : " & Me.txtPersalNumber.Text.Trim.ToUpper & " Password Reset.", MsgBoxStyle.OkOnly, "System Message")
            timerCOUNTS_Tick(sender, e)

        End If

        Me.Cursor = Cursors.Arrow

    End Sub

    Private Sub EMailToVerifyAgainstEstablishmentToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EMailToVerifyAgainstEstablishmentToolStripMenuItem1.Click, EMailToVerifyAgainstEstablishmentToolStripMenuItem.Click

        If txtPersalNumber.Text.Trim = "" Then
            Exit Sub
        End If

        Dim i As Integer
        Dim a() As String
        Dim subject As String = ""
        Dim tbl1 As DataTable
        Dim returnaddress As String = ""
        Dim col As New Microsoft.VisualBasic.Collection
        Dim colTO As New Microsoft.VisualBasic.Collection
        Dim colCC As New Microsoft.VisualBasic.Collection
        Dim comments As String
        Try
            If frmEnvironment.wrong_department.Trim = "" Then
                comments = InputBox("Do you want to add any comments to the EMail before it is sent?", "Comments?", "Department as captured on the web - " & frmEnvironment.wrong_department.Trim)
            End If
        Catch ex As Exception
            comments = InputBox("Do you want to add any comments to the EMail before it is sent?", "Comments?", "None")
        End Try

        If comments.Trim = "" Then
            comments = "None"
        End If

        tbl1 = Me.ta_Vulindlela_Email.GetData("EMail To Verify Against Establishment")

        If tbl1.Rows.Count > 0 Then
            subject = tbl1.Rows(0).Item("SUBJECT").ToString
            returnaddress = tbl1.Rows(0).Item("RETURN_ADDRESS").ToString
            a = Split(tbl1.Rows(0).Item("TO_ADDRESS").ToString, ";")
            If a(0) <> "" Then
                For i = 0 To UBound(a)
                    colTO.Add(a(i))
                Next
            End If

            a = Split(tbl1.Rows(0).Item("CC_ADDRESS").ToString, ";")

            If a(0) <> "" Then
                For i = 0 To UBound(a)
                    colCC.Add(a(i))
                Next
            End If

        End If

        col.Add("persal_no~~" & Me.txtPersalNumber.Text.Trim & "")
        col.Add("first_name~~" & Me.txtFirst_NameTextBox.Text.Trim & "")
        col.Add("last_name~~" & Me.txtLast_NameTextBox.Text.Trim & "")
        col.Add("dept_code~~" & Me.txtDepartment_TypeTextBox.Text.Trim & "")
        col.Add("dept_name~~" & Me.txtDepartment_NameTextBox.Text.Trim & "")
        col.Add("comments~~" & comments & "")

        ParseFile_Email("EMail To Verify Against Establishment.htt", col, colTO, colCC, returnaddress)

        If frmEnvironment.ChildFormPRD.Visible Then
            frmEnvironment.ChildFormPRD.ADCONSOLELOGTableAdapter.InsertIntoADAdminConsoleLog2( _
                    frmEnvironment.ChildFormPRD.tsLabelVulname.Text, Get_ValidPersalNumber( _
                    frmEnvironment.ChildFormPRD.txtPersalNumber.Text.Trim), "Client not on Estab : Requested Info", False)
            frmEnvironment.ChildFormPRD.Refresh_Log()
        Else
            frmEnvironment.childformQA.ADCONSOLELOGTableAdapter.InsertIntoADAdminConsoleLog2( _
                    frmEnvironment.childformQA.tsLabelVulname.Text, Get_ValidPersalNumber( _
                    frmEnvironment.childformQA.txtPersalNumber.Text.Trim), "Client not on Estab : Requested Info", False)
            frmEnvironment.childformQA.Refresh_Log()
        End If
        col = Nothing

        Me.Cursor = Cursors.Arrow

    End Sub


    Private Sub Label13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.ADCONSOLELOGDataGridView.Refresh()
        timerCOUNTS_Tick(sender, e)
    End Sub

    Private Sub tsBtnUpdateUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsBtnUpdateUser.Click

        Dim i As Integer
        If lwAppRoles2.Items.Count < 1 Then
            MsgBox("Please make sure all items are selected", MsgBoxStyle.Critical, "System Message")
            Exit Sub
        End If
        Dim persalnumber As String
        Dim x As Integer
        Dim colAssigned As New Microsoft.VisualBasic.Collection
        Dim colCurrentMemberOf As New Microsoft.VisualBasic.Collection
        Dim applevel As String = ""
        persalnumber = Get_ValidUsername(txtPersalNumber.Text.Trim)




        '
        ' Cache eers alles anders kan jy be weer alles restore nie
        ''
        'Dim ValidCol As New Microsoft.VisualBasic.Collection

        'ValidCol = Do_Compare_New_And_Old_Current_Return_Valid_Col(Me.txtPersalNumber.Text, _
        '                                                       modADS.Get_Resolved_MemberOf_Context_Collection(Me.txtPersalNumber.Text), _
        '                                                       modADS.Get_Resolved_MemberOf_Context_Collection(Me.txtPersalNumber.Text))

        ''
        ' Maak alles soon om seker te maak daars nie sediment in die AD nie
        '
        colCurrentMemberOf = Get_Resolved_MemberOf_Context_Collection(persalnumber)
        Do_RemoveFromGroup_Collection(persalnumber, Get_Resolved_MemberOf_Context_Collection(persalnumber))

        Try
            If Not IsValidEmail(txtE_MailTextBox.Text.Trim.ToLower) Then
                MsgBox("The EMail Address in the Email field is invalid", MsgBoxStyle.OkOnly, "Invalid EMail Address")
            End If

            ' Delete al User objects

            Do_UpdateUser(persalnumber, _
                          StrConv(txtFirst_NameTextBox.Text.Trim & "", VbStrConv.ProperCase), _
                          StrConv(txtLast_NameTextBox.Text.Trim & "", VbStrConv.ProperCase), _
                          txtE_MailTextBox.Text.Trim.ToLower & "", _
                          lwDepartments.CheckedItems(0).SubItems(1).Text.Trim & "", _
                          DirectCast(IIf(txtCellphoneTextBox.Text.ToString.Trim & "" = "", txtTelephoneTextBox.Text.ToString.Trim & "", txtCellphoneTextBox.Text.ToString.Trim & ""), String), _
                          txtRankTextBox.Text.Trim & "", "Comp", _
                          txtFax_NumberTextBox.Text.Trim & "", _
                          txtTelephoneTextBox.Text.Trim & "", _
                          txtCellphoneTextBox.Text.Trim & "")

            Do_AddUser2ApplGroups(persalnumber, create_ad_appl_group_collection())

            Do_AddUser2ApplGroups(persalnumber, build_ftp_access_col())

            Do_AddToGroup(persalnumber, lwDepartments.CheckedItems(0).SubItems(1).Text.Trim, ou_context.GOVERNMENT_STRUCTURE)

            For i = 0 To Me.lvFlags.CheckedItems.Count - 1
                Do_AddFlag(persalnumber, lvFlags.CheckedItems(i).SubItems(2).Text.Trim, ou_context.APPLICATION_RIGHTS)
            Next

            Do_EnableAccount(persalnumber)

            colAssigned = build_chkProfileCategories_col()

            If rbAccountLevel7.Checked Then
                For x = 1 To colAssigned.Count
                    For i = 0 To lwA.CheckedItems.Count - 1
                        modADS.Do_AddToAssignedGroup(persalnumber, lwA.CheckedItems(i).SubItems(1).Text.Trim, colAssigned(x).ToString, ou_context.GOVERNMENT_STRUCTURE)
                    Next
                Next
            Else '' This when rbAccountLevel7 is FALSE
                For x = 1 To colAssigned.Count
                    modADS.Do_AddToAssignedGroup(persalnumber, lwDepartments.CheckedItems(0).SubItems(1).Text.Trim, colAssigned(x).ToString, ou_context.GOVERNMENT_STRUCTURE)
                Next
                For x = 1 To colAssigned.Count
                    For i = 0 To lwA.CheckedItems.Count - 1
                        modADS.Do_AddToAssignedGroup(persalnumber, lwA.CheckedItems(i).SubItems(1).Text.Trim, colAssigned(x).ToString, ou_context.GOVERNMENT_STRUCTURE)
                    Next
                Next
            End If

            ' Reset the timer here

            btnActiveDirectory_Click(sender, e)

            ' VIP_USERS_NewUsersTableAdapter.UpdateDoneToCompleted(persalnumber)
            frmEnvironment.ChildFormPRD.VIP_USERS_NewUsersTableAdapter.UpdateDoneToCompleted(Get_ValidPersalNumber(persalnumber.Trim))


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "System Message")
        End Try

        If sender.name = "tsBtnUpdateUser" Then
            If MsgBox("Do you want to reset the Password as well.", MsgBoxStyle.YesNo, "System Message") = MsgBoxResult.Yes Then
                Do_ResetPassword(persalnumber)
            End If
            If MsgBox("NOTIFY The User via eMail ?", MsgBoxStyle.YesNo, "System Message") = MsgBoxResult.Yes Then
                NotifyUserAccountUpdatedToolStripMenuItem_Click(sender, e)
            End If
        End If

        colAssigned = Nothing

        If Not String.IsNullOrEmpty(Me.txtRemedyRequestNo.Text) Then
            Rules_Flags_Valid_Delete_Requestno(Me.txtRemedyRequestNo.Text)
        End If

        Me.Cursor = Cursors.Arrow

    End Sub

    Public Sub btnActiveDirectory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActiveDirectory.Click

        ' JOHAN WAS HERE



        If (Not frmEnvironment.ActiveMdiChild Is Nothing) Then

            If frmEnvironment.ActiveMdiChild.Text.Contains("- PRD") Then

                Me.GetResetPasswordsTableAdapter1.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
                Me.Department_DiffersTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
                Me.VIEW_CFO_APPPLICATION_TOOK_TO_LONGTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
                '     Me.ta_VIEW_departments1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDConnectionString")
                Me.Ta_VIEW_APPLICATION_RIGHTS1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDPRDConnectionString2014")
                Me.Ta_VIEW_Assigned_Departments1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDPRDConnectionString2014")
                Me.Ta_VIEW_GOVERNMENT_STRUCTURE1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDPRDConnectionString2014")
                Me.LOG_IN_Request_TrackingTableAdapter1.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemProdConnectionString")
                Me.LOG_DM_Customer_InformationTableAdapter1.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemProdConnectionString")
                Me.LOG_DM_PersonnelTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemProdConnectionString")
                Me.LOG_IN_Request_TrackingTableAdapter1.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemProdConnectionString")
                Me.Ta_Vulindlela_Controllers.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemProdConnectionString")
                Me.Ta_VIEW_APPLICATION_RIGHTS1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDPRDConnectionString2014")
                Me.Ta_VIEW_Assigned_Departments1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDPRDConnectionString2014")
                '  Me.ta_VIEW_departments1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDConnectionString2008PRD")
                Me.Ta_VIEW_GOVERNMENT_STRUCTURE1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDPRDConnectionString2014")
                Me.CountNewUsersTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("AdsPRDConnectionString2014")
                Me.GetResetPasswordsTableAdapter1.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
                Me.RemedyOpenRequestsTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemProdConnectionString")
                Me.Ta_Vulindlela_Controllers.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
                Me.RULES_FLAGSTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
                Me.Data_PersonnelAndAppointment002TableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
                Me.Ta_Estab2.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
                Me.LOG_IN_Request_Tracking2TableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemProdConnectionString")
                Me.VIP_USERSTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
                Me.ta_KICKOUT.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
                My.MySettings.Default.Default("AdsConnectionString") = My.MySettings.Default.Default("ADSPRDConnectionString2014")
                Me.CountNewUsersTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
                Me.VIP_USERS_ResetPasswordTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
                Me.VIP_USERS_NewUsersTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
                Me.ADCONSOLELOGTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
                Me.HR_DataTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("HR_MISConnectionStringPRD")














                'Me.GetResetPasswordsTableAdapter1.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                'Me.Department_DiffersTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                'Me.VIEW_CFO_APPPLICATION_TOOK_TO_LONGTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                'Me.Ta_VIEW_APPLICATION_RIGHTS1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")
                'Me.Ta_VIEW_Assigned_Departments1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")
                'Me.Ta_VIEW_GOVERNMENT_STRUCTURE1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")
                'Me.LOG_IN_Request_TrackingTableAdapter1.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemDevConnectionString")
                'Me.LOG_DM_Customer_InformationTableAdapter1.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemDevConnectionString")
                'Me.LOG_DM_PersonnelTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemDevConnectionString")
                'Me.Ta_Vulindlela_Controllers.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemDevConnectionString")
                'Me.Ta_VIEW_APPLICATION_RIGHTS1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")
                'Me.Ta_VIEW_Assigned_Departments1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")
                'Me.ta_VIEW_departments1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")
                'Me.Ta_VIEW_GOVERNMENT_STRUCTURE1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")
                'Me.CountNewUsersTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                'Me.GetResetPasswordsTableAdapter1.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                'Me.RemedyOpenRequestsTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemDevConnectionString")
                'Me.Ta_Vulindlela_Controllers.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                'Me.RULES_FLAGSTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                'Me.Data_PersonnelAndAppointment002TableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                'Me.Ta_Estab2.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                'Me.LOG_IN_Request_Tracking2TableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemDevConnectionString")
                'Me.VIP_USERSTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                'Me.RULES_FLAGSTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                'Me.CountNewUsersTableAdapter.Connection.ConnectionString = My.MySettings.Default("ADSQAConnectionString2014")
                ''My.MySettings.Default.Default("AdsConnectionString") = My.MySettings.Default.Default("ADSQAConnectionString2014")
                'Me.ta_KICKOUT.Connection.ConnectionString = My.MySettings.Default("ADSQAConnectionString2014")

                ''My.MySettings.Default("AdsConnectionString") = My.MySettings.Default("ADSQAConnectionString2014")
                ''My.MySettings.Default("ADSPRDConnectionString2014") = My.MySettings.Default("ADSQAConnectionString2014")
                ''My.MySettings.Default.Default("VIP_EXPANDEDConnectionString") = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")

                ''My.MySettings.Default.Default("ARSystemConnectionString") = My.MySettings.Default.Default("ARSystemDevConnectionString")
                ''My.MySettings.Default.Default("ARSystemProdConnectionString") = My.MySettings.Default.Default("ARSystemDevConnectionString")



            Else

                Me.GetResetPasswordsTableAdapter1.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                Me.Department_DiffersTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                Me.VIEW_CFO_APPPLICATION_TOOK_TO_LONGTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                Me.Ta_VIEW_APPLICATION_RIGHTS1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")
                Me.Ta_VIEW_Assigned_Departments1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")
                Me.Ta_VIEW_GOVERNMENT_STRUCTURE1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")
                Me.LOG_IN_Request_TrackingTableAdapter1.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemDevConnectionString")
                Me.LOG_DM_Customer_InformationTableAdapter1.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemDevConnectionString")
                Me.LOG_DM_PersonnelTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemDevConnectionString")
                Me.Ta_Vulindlela_Controllers.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemDevConnectionString")
                Me.Ta_VIEW_APPLICATION_RIGHTS1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")
                Me.Ta_VIEW_Assigned_Departments1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")
                '   Me.ta_VIEW_departments1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")
                Me.Ta_VIEW_GOVERNMENT_STRUCTURE1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")
                Me.CountNewUsersTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                Me.GetResetPasswordsTableAdapter1.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                Me.RemedyOpenRequestsTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemDevConnectionString")
                Me.Ta_Vulindlela_Controllers.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                Me.RULES_FLAGSTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                Me.Data_PersonnelAndAppointment002TableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                Me.Ta_Estab2.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                Me.LOG_IN_Request_Tracking2TableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemDevConnectionString")
                Me.VIP_USERSTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                Me.RULES_FLAGSTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                Me.CountNewUsersTableAdapter.Connection.ConnectionString = My.MySettings.Default("ADSQAConnectionString2014")
                Me.VIP_USERS_ResetPasswordTableAdapter.Connection.ConnectionString = My.MySettings.Default("ADSQAConnectionString2014")
                Me.VIP_USERS_NewUsersTableAdapter.Connection.ConnectionString = My.MySettings.Default("ADSQAConnectionString2014")
                'My.MySettings.Default.Default("AdsConnectionString") = My.MySettings.Default.Default("ADSQAConnectionString2014")
                Me.ta_KICKOUT.Connection.ConnectionString = My.MySettings.Default("ADSQAConnectionString2014")
                Me.ADCONSOLELOGTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                Me.HR_DataTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("HR_MISConnectionStringDev")

                'My.MySettings.Default("AdsConnectionString") = My.MySettings.Default("ADSQAConnectionString2014")
                'My.MySettings.Default("ADSPRDConnectionString2014") = My.MySettings.Default("ADSQAConnectionString2014")
                'My.MySettings.Default.Default("VIP_EXPANDEDConnectionString") = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")

                'My.MySettings.Default.Default("ARSystemConnectionString") = My.MySettings.Default.Default("ARSystemDevConnectionString")
                'My.MySettings.Default.Default("ARSystemProdConnectionString") = My.MySettings.Default.Default("ARSystemDevConnectionString")

            End If

        End If

        If Cleartxt Then
            Me.txtRightsRequested.Text = ""
            Cleartxt = True
        End If

        cboNatProv.SelectedValue = 0

        Dim colGroup As Collection
        Dim mtest1 As String = "", mtest2 As String = ""
        Dim AssignAppl As String = "", a() As String
        Dim persalnumber As String = Get_ValidUsername(Me.txtPersalNumber.Text)
        Dim z As Integer, x As Integer, i As Integer
        Dim p As Integer, q As Integer
        Dim r As Integer, s As Integer, t As Integer
        Dim u As Integer, max As Integer, strApplication As String, strLevel As String

        Me.remedy_fill(sender, e)
        uncheck_chkProfileCategories_all(sender, e)
        reset_all_listviews()

        If Get_IsValidUser(persalnumber) Then

            '
            tsCreatedDate.Text = " | Profile Created : " & Me.Get_User_Creation_Date(persalnumber)
            tsLabelProfileCreated.Text = " | Profile Created : " & Me.Get_User_Creation_Date(persalnumber)
            tsCreatedDate.Text = tsCreatedDate.Text & " | Profile Modified : " & Me.Get_User_Modified_Date(persalnumber)
            tsLabelProfileCreated.Text = tsCreatedDate.Text & " | Profile Modified : " & Me.Get_User_Modified_Date(persalnumber)
            tsLabelProfileCreated.Text = tsCreatedDate.Text & " | Last Logged On : " & modADS.Get_LastLogon(persalnumber)
            tsLabelProfileCreated.Text = tsCreatedDate.Text & " | Logons : " & Get_User_LogonCount(persalnumber).ToString
            tsLabelProfileCreated.Text = tsCreatedDate.Text & " | Bad Logons : " & Me.Get_User_BadLogons(persalnumber).ToString
            '

            '
            Do_FrmButtons(False, True, True)
            '
            Try

                colGroup = modADS.Get_UserGroups(persalnumber)

                For i = 1 To colGroup.Count
                    If InStr(1, colGroup(i).ToString.ToUpper, "FLAG.") > 0 Then
                        If Strings.UCase(Me.lvFlags.Items(i - 1).SubItems(1).Text).Trim = Strings.UCase(colGroup(i).ToString.ToUpper).Trim Then
                            Me.lvFlags.Items(i - 1).Checked = True
                        Else
                            Me.lvFlags.Items(i - 1).Checked = False
                        End If
                    End If
                Next


                Me.load_lv_maindepartment(persalnumber)

                Me.load_lv_application_rights()

                If colGroup.Count > 0 Then


                    For p = 0 To chkProfileCategories.Items.Count - 1
                        chkProfileCategories.Items(p).Checked = False
                    Next



                    For q = 0 To lwA.Items.Count - 1
                        Me.lwA.Items(q).Checked = False
                    Next



                    cboAssDepts.Items.Clear()


                    For x = 1 To colGroup.Count
                        mtest1 = colGroup(x).ToString.ToUpper.Trim

                        If InStr(1, mtest1, ".") > 0 Then
                            a = Split(mtest1, ".")
                            AssignAppl = a(0) & "."
                            z = InStr(1, mtest1, ".")

                            If z > 0 Then
                                mtest2 = Replace(mtest1, AssignAppl, "")
                            Else
                                mtest2 = mtest1.Substring(z)
                            End If

                        End If

                        '
                        For i = 0 To Me.lwApplicationRoles.Items.Count - 1

                            ' lwApplicationRoles assignments
                            If Me.lwApplicationRoles.Items(i).SubItems(1).Text.Trim.ToUpper = colGroup(x).ToString.ToUpper.Trim Then
                                max = chkProfileCategories.Items.Count - 1

                                For u = 0 To max
                                    strApplication = Microsoft.VisualBasic.Left(Me.lwApplicationRoles.Items(i).SubItems(1).Text, InStr(Me.lwApplicationRoles.Items(i).SubItems(1).Text, ".") - 1)
                                    strLevel = ""
                                    If strApplication = chkProfileCategories.Items(u).Text.ToString() Then
                                        chkProfileCategories.Items(u).Checked = True
                                    End If
                                Next
                                Me.lwApplicationRoles.Items(i).Checked = True
                                Me.lwApplicationRoles.Items(i).BackColor = Color.Gainsboro
                                Me.lwApplicationRoles.Items(i).EnsureVisible()
                            End If
                        Next
                        '

                        '
                        For r = 0 To Me.lwA.Items.Count - 1
                            If Me.lwA.Items(r).SubItems(1).Text.Trim.ToUpper = mtest2 Then
                                Me.lwA.Items(r).Checked = True
                                Me.lwA.Items(r).EnsureVisible()
                            End If
                        Next
                        '
                    Next x

                    '
                    For s = 0 To Me.lwA.Items.Count - 1
                        If Me.lwA.Items(s).Checked = True Then
                            cboAssDepts.Items.Add(Me.lwA.Items(s).SubItems(1).Text)
                            Me.lwA.Items(s).EnsureVisible()
                        End If
                    Next s
                    '

                End If

                Dim cPROV As Integer
                Dim cOWN_PROV As Integer
                Dim cOWN_DEPT As Integer
                Dim cnat As Integer
                Dim ccon As Integer
                Dim ctot As Integer
                Dim cASSIGN_DEPT As Integer

                If colGroup.Count > 0 Then

                    For t = 1 To colGroup.Count
                        If InStr(1, colGroup(t).ToString, ".") > 0 Then
                            a = Split(colGroup(t).ToString, ".")
                            If InStr(1, a(1), "CON") > 0 Then
                                ccon += 1
                                ctot += 1
                            ElseIf InStr(1, a(1), "NAT") > 0 Then
                                cnat += 1
                                ctot += 1
                            ElseIf InStr(1, a(1), "OWN_DEPT") > 0 Then
                                cOWN_DEPT += 1
                                ctot += 1
                            ElseIf InStr(1, a(1), "OWN_PROV") > 0 Then
                                cOWN_PROV += 1
                                ctot += 1
                            ElseIf InStr(1, a(1), "PROV") > 0 Then
                                cPROV += 1
                                ctot += 1
                            ElseIf InStr(1, a(1), "ASSIGN_DEPT") > 0 Then
                                cASSIGN_DEPT += 1
                                ctot += 1
                            End If
                            strLevel = a(1)
                        End If
                    Next t



                End If
                If IIf(ccon = ctot, 1, 0) + IIf(cnat = ctot, 1, 0) + IIf(cOWN_DEPT = ctot, 1, 0) + IIf(cOWN_PROV = ctot, 1, 0) + IIf(cPROV = ctot, 1, 0) + IIf(cASSIGN_DEPT = ctot, 1, 0) = 0 Then
                    If MsgBox("This profile is damaged. Do you want to delete it?", MsgBoxStyle.YesNo, "System Message") = MsgBoxResult.Yes Then
                        tsBtnDeleteUser_Click(sender, e)
                    End If
                Else
                    rbAccountLevel2.Checked = IIf(cOWN_DEPT = ctot, 1, 0)
                    rbAccountLevel3.Checked = IIf(cOWN_PROV = ctot, 1, 0)
                    rbAccountLevel4.Checked = IIf(cnat = ctot, 1, 0)
                    rbAccountLevel5.Checked = IIf(cPROV = ctot, 1, 0)
                    rbAccountLevel6.Checked = IIf(ccon = ctot, 1, 0)
                    rbAccountLevel7.Checked = IIf(cASSIGN_DEPT = ctot, 1, 0)
                    '*+*
                End If

                chkEnabled.Checked = modADS.Get_IsAccountEnabled(persalnumber)
                chkLocked.Checked = modADS.Get_IsAccountLocked(persalnumber)
                dtpAccountExpireDate.Value = modADS.Get_AccountExpireDate(persalnumber)


                If (Get_IsAccountEnabled(persalnumber)) Then
                    chkEnabled.Checked = True
                    'dtpAccountExpireDate.Checked = False
                Else
                    chkEnabled.Checked = False
                    dtpAccountExpireDate.Checked = True

                End If

                If dtpAccountExpireDate.Value < #1/1/1970# Then
                    dtpAccountExpireDate.Checked = False
                End If



                For i = 0 To lvFlags.CheckedItems.Count - 1
                    lvFlags.CheckedItems(i).SubItems(2).Text.Trim()
                Next

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

        Cleartxt = True

    End Sub

    Public Sub reset_all_listviews()

        'Me.Cursor = Cursors.WaitCursor

        Dim i As Integer

        For i = 0 To Me.lvFlags.Items.Count - 1
            Me.lvFlags.Items(i).Checked = False
            Me.lvFlags.Items(i).BackColor = Color.White
        Next

        For i = 0 To Me.lwA.Items.Count - 1
            Me.lwA.Items(i).Checked = False
            Me.lwA.Items(i).BackColor = Color.White
        Next

        For i = 0 To Me.lwDepartments.Items.Count - 1
            Me.lwDepartments.Items(i).Checked = False
            Me.lwDepartments.Items(i).BackColor = Color.White
        Next

        For i = 0 To Me.lwApplicationRoles.Items.Count - 1
            Me.lwApplicationRoles.Items(i).Checked = False
            Me.lwApplicationRoles.Items(i).BackColor = Color.White
        Next


        Me.Cursor = Cursors.Arrow

    End Sub

    Private Sub SendCustomerNotificationMailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SendCustomerNotificationMailsToolStripMenuItem.Click

        Dim pwd As String = ""
        pwd = InputBox("Please enter the password please?", "Password for Mass Mail funtion", "")

        If pwd.Trim = "tasneem" Then

            Dim r As DataRow, x As Integer = 0
            Dim a() As String
            Dim subject As String = ""
            Dim returnaddress As String = ""
            Dim col As New Microsoft.VisualBasic.Collection
            Dim colTO As New Microsoft.VisualBasic.Collection
            Dim colCC As New Microsoft.VisualBasic.Collection
            Dim tbl1 As DataTable = Me.ta_Vulindlela_Email.GetData("Request Closure Notification")
            Dim tblCustInfo As DataTable

            tblCustInfo = Me.LOG_IN_Request_TrackingTableAdapter1.getCustomerNotification
            x = tblCustInfo.Rows.Count

            If MsgBox("Are you very sure that you want to send all " & x.ToString.Trim & " closure emails??", MsgBoxStyle.YesNo, "System Message") = MsgBoxResult.Yes Then

                Me.ARSystemDataSet.EnforceConstraints = False

                x = 0

                For Each r In tblCustInfo.Rows



                    x += 1

                    If tbl1.Rows.Count > 0 Then

                        subject = tbl1.Rows(0).Item("SUBJECT").ToString & " - Request Nr: " & r.Item("Request_No").ToString
                        returnaddress = tbl1.Rows(0).Item("RETURN_ADDRESS").ToString

                        ' TO
                        If InStr(1, r.Item("E_Mail").ToString.Trim, "@") > 0 Then
                            colTO.Add(r.Item("E_Mail").ToString.Trim)
                            'colTO.Add("")
                            'colTO.Add("ronel.ilsley@treasury.gov.za")
                        Else
                            colTO.Add("vults@treasury.gov.za")
                        End If

                        ' CC
                        a = Split(tbl1.Rows(0).Item("CC_ADDRESS").ToString, ";")
                        If a(0) <> "" Then
                            For i = 0 To UBound(a)
                                colCC.Add(a(i))
                            Next
                        End If

                    End If

                    col.Add("first_name~~" & r.Item("First_Name").ToString & "")
                    col.Add("helpdesk_phoneno~~" & My.Settings.HelpDesk_PhoneNo.Trim() & "")
                    col.Add("request_no~~" & r.Item("Request_No").ToString & "")
                    col.Add("long_description~~" & r.Item("Long_Description").ToString & "")
                    col.Add("solution~~" & r.Item("Solution").ToString & "")
                    col.Add("entry_date~~" & r.Item("Entry_Date").ToString & "")
                    col.Add("closure_date~~" & DateAdd(DateInterval.Day, 7, Now()) & "")
                    ParseFile_Email("Request Closure Notification.htt", col, colTO, colCC, returnaddress, subject)


                    Me.CustomerInfoTableAdapter.NewCustomerINfo(r.Item("Request_No").ToString, colTO(1).ToString)
                    subject = ""
                    returnaddress = ""
                    colTO.Clear()
                    colCC.Clear()
                    col.Clear()


                Next
                col = Nothing
                colTO = Nothing
                colCC = Nothing

                MsgBox("Mail sent for " & x.ToString & " requests.", MsgBoxStyle.OkOnly, "System Message")

            End If

        End If

    End Sub

    Private Sub btnKodeer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        frmKodeer.Show()
        Me.Cursor = Cursors.Arrow

    End Sub

    Private Sub lwApplicationRoles_ItemChecked(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles lwApplicationRoles.ItemChecked

        Me.timerCOUNTS.Stop()

        Dim i As Integer
        Dim str(2) As String

        '
        lwAppRoles2.Items.Clear()
        For i = 0 To Me.lwApplicationRoles.CheckedItems.Count - 1
            str(1) = Me.lwApplicationRoles.CheckedItems(i).SubItems(1).Text
            str(2) = Me.lwApplicationRoles.CheckedItems(i).SubItems(2).Text
            Dim lv As New ListViewItem(str)
            lwAppRoles2.Items.Add(lv)
        Next
        '

        Me.timerCOUNTS.Start()

    End Sub

    Private Sub RemoveUserFromNewUserListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveUserFromNewUserListToolStripMenuItem.Click
        If MsgBox("Are you sure you want to remove this user from the new user list?", MsgBoxStyle.YesNo, "System Message") = MsgBoxResult.Yes Then

            ADCONSOLELOGTableAdapter.UpdateResetPasswordBit(txtPersalNumber.Text)
            frmNewUsers.VIP_USERS_NewUsersDataGridView.Refresh()

        End If
    End Sub

    Private Sub rbServerEnvironment_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles rbServerEnvironment.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            btnKodeer_Click(sender, e)
        End If
    End Sub

#Region "CFO CRUD List Form Procs"

    Public Sub InsertCFO_Record(ByVal Dept_Code As String, _
                                ByVal Fullname As String, _
                                ByVal CompanyName As String, _
                                ByVal Email1Address As String, _
                                ByVal NAT_PROV_ID As String, _
                                ByVal VoteID As String, _
                                ByVal FirstName As String, _
                                ByVal Gender As String, _
                                ByVal Initials As String, _
                                ByVal Lastname As String, _
                                ByVal BusinessAddress As String, _
                                ByVal BusinessFaxNumber As String)


        Dim cnADS As New SqlConnection
        cnADS.ConnectionString = My.Settings.AdsConnectionString
        cnADS.Open()

        Dim cmdInsertCFO As New SqlCommand("InsertCFO", cnADS)
        cmdInsertCFO.CommandType = CommandType.StoredProcedure

        Dim pDept_Code As New SqlParameter("@Dept_Code", SqlDbType.VarChar, 15)
        Dim pFullname As New SqlParameter("@Fullname", SqlDbType.VarChar, 50)
        Dim pCompanyName As New SqlParameter("@CompanyName", SqlDbType.VarChar, 50)
        Dim pEmail1Address As New SqlParameter("@Email1Address", SqlDbType.VarChar, 150)
        Dim pNAT_PROV_ID As New SqlParameter("@NAT_PROV_ID", SqlDbType.BigInt, 8)
        Dim pVoteID As New SqlParameter("@VoteID", SqlDbType.BigInt, 8)
        Dim pFirstName As New SqlParameter("@FirstName", SqlDbType.VarChar, 50)
        Dim pBusinessTelephoneNumber As New SqlParameter("@BusinessTelephoneNumber", SqlDbType.VarChar, 50)
        Dim pGender As New SqlParameter("@Gender", SqlDbType.VarChar, 50)
        Dim pInitials As New SqlParameter("@Initials", SqlDbType.VarChar, 50)
        Dim pLastname As New SqlParameter("@Lastname", SqlDbType.VarChar, 50)
        Dim pBusinessAddress As New SqlParameter("@BusinessAddress", SqlDbType.VarChar, 50)
        Dim pBusinessFaxNumber As New SqlParameter("@BusinessFaxNumber", SqlDbType.VarChar, 50)

        cnADS.ConnectionString = My.Settings.AdsConnectionString
        cmdInsertCFO.CommandType = CommandType.StoredProcedure

        pDept_Code.Value = Dept_Code
        pFullname.Value = Fullname
        pCompanyName.Value = CompanyName
        pEmail1Address.Value = Email1Address
        pNAT_PROV_ID.Value = NAT_PROV_ID
        pFirstName.Value = VoteID
        pBusinessTelephoneNumber.Value = FirstName
        pGender.Value = Gender
        pInitials.Value = Initials
        pLastname.Value = Lastname
        pBusinessAddress.Value = BusinessAddress
        pBusinessFaxNumber.Value = BusinessFaxNumber

        With cmdInsertCFO
            .Parameters.Add(pDept_Code)
            .Parameters.Add(pFullname)
            .Parameters.Add(pCompanyName)
            .Parameters.Add(pEmail1Address)
            .Parameters.Add(pNAT_PROV_ID)
            .Parameters.Add(pFirstName)
            .Parameters.Add(pBusinessTelephoneNumber)
            .Parameters.Add(pGender)
            .Parameters.Add(pInitials)
            .Parameters.Add(pLastname)
            .Parameters.Add(pBusinessAddress)
            .Parameters.Add(pBusinessFaxNumber)
            .ExecuteNonQuery()
            .Parameters.Remove(pDept_Code)
            .Parameters.Remove(pFullname)
            .Parameters.Remove(pCompanyName)
            .Parameters.Remove(pEmail1Address)
            .Parameters.Remove(pNAT_PROV_ID)
            .Parameters.Remove(pFirstName)
            .Parameters.Remove(pBusinessTelephoneNumber)
            .Parameters.Remove(pGender)
            .Parameters.Remove(pInitials)
            .Parameters.Remove(pLastname)
            .Parameters.Remove(pBusinessAddress)
            .Parameters.Remove(pBusinessFaxNumber)
        End With


    End Sub

    'Public Sub Delete_CFO_Records()


    '    Dim cnADS As New OleDbConnection
    '    cnADS.ConnectionString = My.Settings.AdsOleDBConnectionString
    '    cnADS.Open()

    '    Dim cmdDeleteCFO As New OleDbCommand("DeleteCFO", cnADS)
    '    cmdDeleteCFO.CommandType = CommandType.StoredProcedure
    '    cmdDeleteCFO.ExecuteNonQuery()

    '    cnADS.Close()
    '    cnADS.Dispose()
    '    cnADS = Nothing


    'End Sub


    Public Sub Delete_CFO_Records()


        Dim cnADS As New SqlConnection
        cnADS.ConnectionString = My.Settings.AdsConnectionString
        cnADS.Open()

        Dim cmdDeleteCFO As New SqlCommand("DeleteCFO", cnADS)
        cmdDeleteCFO.CommandType = CommandType.StoredProcedure
        cmdDeleteCFO.ExecuteNonQuery()

        cnADS.Close()
        cnADS.Dispose()
        cnADS = Nothing


    End Sub

    Public Sub Create_CFO_List(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

        Dim path As String
        Dim apppath As String

        apppath = System.AppDomain.CurrentDomain.BaseDirectory

        If Not System.IO.Directory.Exists(apppath & "CFO Lists") Then
            System.IO.Directory.SetAccessControl(apppath, AddSecurityAccessRule())
            System.IO.Directory.CreateDirectory(apppath & "CFO Lists", AddSecurityAccessRule())
        End If
        System.IO.Directory.SetAccessControl(apppath & "CFO Lists", AddSecurityAccessRule())

        path = apppath & "CFO Lists\" & gridRequests.Item(0, e.RowIndex).Value.ToString & ".csv"

        If File.Exists(path) Then
            File.Delete(path)
        End If

        Dim sw As StreamWriter = File.CreateText(path)
        sw.WriteLine("Rank,Persal_no,Acc_no,Vote,Shortcode,Last_Name,First_Name,Phone_No,Cell_No,E_mail,Account_Status,HR,Financial,Supply_Chain_Management,Own_Dept,Assigned_Depts, Nat_Depts,Own_Province,All_Provinces,RSA")

        For i = 1 To gridRequests.RowCount
            sw.WriteLine("Ticket = " & gridRequests.Item(0, e.RowIndex).ToString)
        Next

        sw.Flush()
        sw.Close()
        If File.Exists(path) Then
            Process.Start(path)
        End If

        Me.Cursor = Cursors.Arrow

    End Sub

#End Region

#Region "CFO Approval - Procedures and Functions"

    Private Function look_up_CFO_for_this_person() As String

        Dim scode As String
        Dim tbl1 As DataTable
        Dim tbl2 As DataTable
        Dim Email, PersalNo, Surname, FullNames As String

        If String.IsNullOrEmpty(Me.txtPersalNumber.Text.Trim) Then
            scode = ""
        Else
            tbl1 = Me.VIP_USERS1TableAdapter.GetDeptCode_From_Persalno(Me.txtPersalNumber.Text.Trim)
            scode = tbl1.Rows(0).Item("department").ToString
            If String.IsNullOrEmpty(scode) Then ' This means this user has no department in VIP_USERS Table
                ' Resolve it against AD
                scode = modADS.Get_Department(Me.txtPersalNumber.Text.Trim)
            End If
        End If

        'If String.IsNullOrEmpty(scode) Then
        If MsgBox("Do you want to provide a Specific Persal Number of an authoritive Person that may approve this Access??", MsgBoxStyle.YesNo, "Specify your Own CFO/Budget Officer?") = MsgBoxResult.No Then
            scode = Me.lwDepartments.CheckedItems.Item(0).SubItems(1).Text
            'scode = Me.lwDepartments.CheckedItems.Item(0)Text
            If String.IsNullOrEmpty(scode) Then
                look_up_CFO_for_this_person = ",,,"
                'MsgBox("Error occured since no CFO details exist for : " & txtPersalNumber.Text.Trim)
            Else
                tbl2 = Me.CFOListTableAdapter.GetDataByDept_Code(scode)
                If tbl2.Rows.Count > 0 Then
                    Email = tbl2.Rows(0).Item("Email").ToString()
                    PersalNo = tbl2.Rows(0).Item("PersalNo").ToString()
                    Surname = tbl2.Rows(0).Item("Surname").ToString()
                    FullNames = tbl2.Rows(0).Item("FullNames").ToString()
                    look_up_CFO_for_this_person = Email & "," & PersalNo & "," & Surname & "," & FullNames
                Else
                    MsgBox("This department i.o.w. = " & scode & " Does not seem to have a CFO in the CFO Table", MsgBoxStyle.OkOnly, "System Message")
                    look_up_CFO_for_this_person = ""
                    Exit Function
                End If
            End If
        Else
            Email = InputBox("Provide EMail Address", "CFO's EMail address", "")
            PersalNo = InputBox("Provide Valid Persal Number please", "Valid Persal Number of CFO", "")
            Surname = InputBox("Provide Valid Surname of CFO", "Valid Surname of CFO", "")
            FullNames = InputBox("Provide Valid FirstNames of CFO", "Valid FirstNames of CFO", "")
            If String.IsNullOrEmpty(Email) Or String.IsNullOrEmpty(PersalNo) Or String.IsNullOrEmpty(Surname) Or String.IsNullOrEmpty(FullNames) Then
                look_up_CFO_for_this_person = ",,,"
            Else
                look_up_CFO_for_this_person = Email & "," & PersalNo & "," & Surname & "," & FullNames
            End If

        End If

        tbl1 = Nothing
        tbl2 = Nothing

    End Function

    Private Sub RequestACFOLetterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RequestACFOLetterToolStripMenuItem.Click, RequestACFOLetterFromClientToolStripMenuItem.Click
        If lwDepartments.CheckedItems.Count > 0 Then
        Else
            MsgBox("Province & Dept - must be checked")
            Exit Sub
        End If
        'MsgBox("To send a CFO Letter request please select an entry in the Weblog and then rightclick to popup the menu and send.")
        Me.TabControl1.SelectTab(4)
        Exit Sub
    End Sub

    Private Sub send_CFO_noreply_email()

        'Me.Cursor = Cursors.WaitCursor

        Dim webid As Integer = 0

        If VIP_USERSDataGridView.RowCount > 0 Then

            If VIP_USERSDataGridView.SelectedRows.Count > 0 Then
                webid = DirectCast(VIP_USERSDataGridView.Item(0, VIP_USERSDataGridView.SelectedRows(VIP_USERSDataGridView.SelectedRows.Count - 1).Index).Value, Integer)
            Else
                MsgBox("Pleasse select an entry first")
                Exit Sub
            End If

            If txtPersalNumber.Text.Trim = "" Then
                Exit Sub
            End If

            Dim i As Integer
            Dim a() As String
            Dim subject As String = ""
            Dim tbl1 As DataTable
            Dim returnaddress As String = ""
            Dim a_HR As String
            Dim a_FIN As String
            Dim a_SCM As String
            Dim a_PERSALPDF As String
            Dim fullname As String
            Dim accessrequired As String
            Dim col As New Microsoft.VisualBasic.Collection
            Dim colTO As New Microsoft.VisualBasic.Collection
            Dim colCC As New Microsoft.VisualBasic.Collection

            tbl1 = Me.ta_Vulindlela_Email.GetData("No CFO letter received")

            If tbl1.Rows.Count > 0 Then
                subject = tbl1.Rows(0).Item("SUBJECT").ToString
                returnaddress = tbl1.Rows(0).Item("RETURN_ADDRESS").ToString
                a = Split(Me.txtE_MailTextBox.Text.Trim, ";")
                If a(0) <> "" Then
                    For i = 0 To UBound(a)
                        colTO.Add(a(i))
                    Next
                End If
                a = Split(tbl1.Rows(0).Item("CC_ADDRESS").ToString, ";")
                If a(0) <> "" Then
                    For i = 0 To UBound(a)
                        colCC.Add(a(i))
                    Next
                End If
            End If

            Dim BUS_TEL As String
            Dim CEL_TEL As String

            BUS_TEL = VIP_USERSDataGridView.Item("BUS_TEL", VIP_USERSDataGridView.SelectedRows(VIP_USERSDataGridView.SelectedRows.Count - 1).Index).Value.ToString
            CEL_TEL = VIP_USERSDataGridView.Item("CEL_TEL", VIP_USERSDataGridView.SelectedRows(VIP_USERSDataGridView.SelectedRows.Count - 1).Index).Value.ToString
            a_HR = VIP_USERSDataGridView.Item("REQ_HR", VIP_USERSDataGridView.SelectedRows(VIP_USERSDataGridView.SelectedRows.Count - 1).Index).Value.ToString
            a_FIN = VIP_USERSDataGridView.Item("REQ_FINANCIALS", VIP_USERSDataGridView.SelectedRows(VIP_USERSDataGridView.SelectedRows.Count - 1).Index).Value.ToString
            a_SCM = VIP_USERSDataGridView.Item("REQ_LOGIS", VIP_USERSDataGridView.SelectedRows(VIP_USERSDataGridView.SelectedRows.Count - 1).Index).Value.ToString
            a_PERSALPDF = VIP_USERSDataGridView.Item("REQ_PERSALPDF", VIP_USERSDataGridView.SelectedRows(VIP_USERSDataGridView.SelectedRows.Count - 1).Index).Value.ToString
            a_notes = VIP_USERSDataGridView.Item("NOTES", VIP_USERSDataGridView.SelectedRows(VIP_USERSDataGridView.SelectedRows.Count - 1).Index).Value
            a_responsibility = VIP_USERSDataGridView.Item("RESPONSIBILITY", VIP_USERSDataGridView.SelectedRows(VIP_USERSDataGridView.SelectedRows.Count - 1).Index).Value
            a_AccountLevel = VIP_USERSDataGridView.Item("SPHERE", VIP_USERSDataGridView.SelectedRows(VIP_USERSDataGridView.SelectedRows.Count - 1).Index).Value
            accessrequired = "<table border='1'>" & _
                                 "<tr><td bgcolor='gainsboro'><font face='verdana' size='2' color='black'><b>Application Required</b></font></td><td bgcolor='gainsboro'><font face='verdana' size='2' color='black'><b>Access Level Required</font></b></td></tr>" & _
                                 "<tr><td><font face='verdana' size='2'>Financial applications</font></td><td><font face='verdana' size='2' color='blue'>" & a_FIN.Trim & "</font></td></tr>" & _
                                 "<tr><td><font face='verdana' size='2'>Supply Chain applications</font></td><td><font face='verdana' size='2' color='blue'>" & a_SCM.Trim & "</font></td></tr>" & _
                                 "<tr><td><font face='verdana' size='2'>Human Resources applications</font></td><td><font face='verdana' size='2' color='blue'>" & a_HR.Trim & "</font></td></tr>" & _
                                 "<tr><td><font face='verdana' size='2'>Persal PDF applications</font></td><td><font face='verdana' size='2' color='blue'>" & a_PERSALPDF.Trim & "</font></td></tr>" & _
                             "</table></font>"

            fullname = Me.txtTitleTextBox.Text.Trim & " " & Me.txtFirst_NameTextBox.Text.Trim & ", " & Me.txtLast_NameTextBox.Text.Trim()

            col.Add("fullname~~" & fullname & "")

            col.Add("persal_no~~" & Me.txtPersalNumber.Text.Trim & "")

            If Me.lwDepartments.CheckedItems.Count < 1 Then
                col.Add("department~~" & "Not declared" & "")
            Else
                col.Add("department~~" & Me.txtDepartment_TypeTextBox.Text.Trim & " - " & Me.txtDepartment_NameTextBox.Text.Trim & "")
            End If

            If a_responsibility.ToString.Length = 0 Then
                col.Add("responsibility~~" & "Not declared" & "")
            Else
                col.Add("responsibility~~" & a_responsibility.ToString & "")
            End If


            If a_AccountLevel.ToString.Length = 0 Then
                col.Add("SPHERE~~" & "Not declared" & "")
            Else
                col.Add("SPHERE~~" & a_AccountLevel.ToString & "")
            End If


            If accessrequired.Length = 0 Then
                col.Add("accessrequired~~" & "None<br>" & "")
            Else
                col.Add("accessrequired~~" & accessrequired & "")
            End If

            If BUS_TEL.Length = 0 Then
                col.Add("BUS_TEL~~" & "None" & "")
            Else
                col.Add("BUS_TEL~~" & BUS_TEL & "")
            End If

            If CEL_TEL.Length = 0 Then
                col.Add("CEL_TEL~~" & "None" & "")
            Else
                col.Add("CEL_TEL~~" & CEL_TEL & "")
            End If

            If a_notes.ToString.Trim.Length = 0 Then
                col.Add("notes~~" & "None" & "")
            Else
                col.Add("notes~~" & a_notes.ToString.Trim & "")
            End If

            col.Add("datelogged~~" & VIP_USERSDataGridView.Item("CREATED", VIP_USERSDataGridView.SelectedRows(VIP_USERSDataGridView.SelectedRows.Count - 1).Index).ToString)

            If MsgBox("Are you sure you want to send this email to the user?", MsgBoxStyle.YesNo, "System Message") = MsgBoxResult.Yes Then
                ParseFile_Email("No CFO letter received in time.htt", col, colTO, colCC, returnaddress)
                If frmEnvironment.ChildFormPRD.Visible Then
                    Me.ADCONSOLELOGTableAdapter.InsertIntoADAdminConsoleLog2(frmEnvironment.ChildFormPRD.tsLabelVulname.Text, _
                                                                     Get_ValidPersalNumber(txtPersalNumber.Text.Trim), _
                                                                     "No CFO letter received in time: Requested Info", False)
                    frmEnvironment.ChildFormPRD.Refresh_Log()
                Else
                    Me.ADCONSOLELOGTableAdapter.InsertIntoADAdminConsoleLog2(frmEnvironment.childformQA.tsLabelVulname.Text, _
                                                                     Get_ValidPersalNumber(txtPersalNumber.Text.Trim), _
                                                                     "No CFO letter received in time: Requested Info", False)
                    frmEnvironment.childformQA.Refresh_Log()
                End If

                MsgBox("EMail Sent", MsgBoxStyle.OkOnly, "System Message")

            End If

            col = Nothing
            colTO = Nothing
            colCC = Nothing
            tbl1 = Nothing

        Else
            MsgBox("Cannot send a CFO Letter request - please ask the user to log a web request first")
            Exit Sub
        End If

    End Sub           '' Stuur 'n CFO Approval Request

    Private Sub NO_CFO_letter_received_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NO_cfo_letter_received.Click
        ''Me.Cursor = Cursors.WaitCursor
        SendEMailNoCFOLetterReceivedInTimeToolStripMenuItem_Click(sender, e)
        'Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub CFO_letter_received_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cfo_letter_received.Click

        Dim webid As Integer = 0

        ' There is a problem when we send the CFO letter for the second time
        ' in cases like this we need to close the previous one and take from the role
        ' as declined

        Dim BUS_TEL As String
        Dim CEL_TEL As String

        Dim accessnow As String
        Dim jobdescription As String
        Dim n_FIN, n_HR, n_LOGIS, n_PERSALPDF, n_HR_OVERSIGHT, n_Level As String
        Dim i As Integer
        Dim a() As String
        Dim subject As String = ""
        Dim tbl1 As DataTable
        Dim returnaddress As String = ""
        Dim a_HR As String, a_FIN As String, a_SCM As String, a_PERSALPDF As String
        Dim fullname As String, accessrequired As String
        Dim col As New Microsoft.VisualBasic.Collection
        Dim colTO As New Microsoft.VisualBasic.Collection
        Dim colCC As New Microsoft.VisualBasic.Collection

        If VIP_USERSDataGridView.RowCount > 0 Then

            If VIP_USERSDataGridView.SelectedRows.Count > 0 Then
                webid = DirectCast(VIP_USERSDataGridView.Item(0, VIP_USERSDataGridView.SelectedRows(VIP_USERSDataGridView.SelectedRows.Count - 1).Index).Value, Integer)

            Else
                MsgBox("Please select an entry first")
                Exit Sub
            End If

            If txtPersalNumber.Text.Trim = "" Then
                Exit Sub
            End If

            tbl1 = Me.ta_Vulindlela_Email.GetData("Letter from your Chief Financial Officer required")

            ' ******************************************************
            '           TEST ROUTINE FOR CFO APPROVALS
            ' ******************************************************

            'If MsgBox("Do you want to send a Test CFO Approval?", _
            '              MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, _
            '              "System Message") = MsgBoxResult.Yes Then
            '    If tbl1.Rows.Count > 0 Then
            '        subject = "CFO Approval Request2"
            '        returnaddress = "Johan Vermeulen <>"
            '        colTO.Add("Johan Vermeulen <>")
            '    End If

            '    colCC.Add("Johan Vermeulen <>")
            '    jobdescription = "Consultant"
            '    BUS_TEL = "012-6574316"
            '    CEL_TEL = "082 781 0415"
            '    a_HR = "HR.ALL"
            '    a_FIN = "FIN.ALL"
            '    a_SCM = "SCM.ALL"
            '    a_PERSALPDF = "PERSALPDF.ALL"
            '    a_HR_OVERSIGHT = "HR_OVERSIGHT.ALL"
            '    a_notes = "Notes about nothing"
            '    a_responsibility = "Responsibility"
            '    n_FIN = "Test" : n_HR = "Test" : n_LOGIS = "Test" : n_PERSALPDF = "Test" : n_HR_OVERSIGHT = "Test"

            '    accessrequired = "<table border='1'>" & _
            '          "<tr><td bgcolor='gainsboro'><font face='verdana' size='2' color='black'><b>Application Required</b></font></td><td bgcolor='gainsboro'><font face='verdana' size='2' color='black'><b>Access Level Required</font></b></td></tr>" & _
            '          "<tr><td><font face='verdana' size='2'>Financial applications</font></td><td><font face='verdana' size='2' color='blue'>" & a_FIN.Trim & "</font></td></tr>" & _
            '          "<tr><td><font face='verdana' size='2'>Supply Chain applications</font></td><td><font face='verdana' size='2' color='blue'>" & a_SCM.Trim & "</font></td></tr>" & _
            '          "<tr><td><font face='verdana' size='2'>Human Resources applications</font></td><td><font face='verdana' size='2' color='blue'>" & a_HR.Trim & "</font></td></tr>" & _
            '          "<tr><td><font face='verdana' size='2'>HR Oversight applications</font></td><td><font face='verdana' size='2' color='blue'>" & a_HR_OVERSIGHT.Trim & "</font></td></tr>" & _
            '          "<tr><td><font face='verdana' size='2'>Persal PDF applications</font></td><td><font face='verdana' size='2' color='blue'>" & a_PERSALPDF.Trim & "</font></td></tr>" & _
            '         "</table></font>"
            '    fullname = "Mr Johan Vermeulen"
            '    col.Add("fullname~~" & fullname & "")
            '    col.Add("persal_no~~" & "13038010") ' Elmari de Witt se ou nommer
            '    If Me.lwDepartments.CheckedItems.Count > 0 Then
            '        col.Add("department~~" & Me.lwDepartments.CheckedItems(0).SubItems(1).Text & " - " & Me.lwDepartments.CheckedItems(0).SubItems(2).Text & "")
            '    Else
            '        col.Add("department~~" & Me.txtDepartment_TypeTextBox.Text.Trim & " - " & Me.txtDepartment_NameTextBox.Text.Trim & "")
            '    End If
            '    col.Add("jobdescription~~" & jobdescription & "")
            '    col.Add("accessnow~~" & accessnow & "")
            '    col.Add("responsibility~~" & a_responsibility & "")
            '    col.Add("accessrequired~~" & accessrequired & "")
            '    col.Add("BUS_TEL~~" & BUS_TEL & "")
            '    col.Add("CEL_TEL~~" & CEL_TEL & "")
            '    col.Add("notes~~" & "Lots of test notes")

            '    ParseFile_Email("Request a CFO Letter.htt", col, colTO, colCC, returnaddress)
            '    MsgBox("EMail Sent", MsgBoxStyle.OkOnly, "System Message")

            'Else

            If MsgBox("Are you sure you want to send this email to the user?", _
                 MsgBoxStyle.YesNo, _
                "System Message") = MsgBoxResult.Yes Then

                If tbl1.Rows.Count > 0 Then
                    subject = tbl1.Rows(0).Item("SUBJECT").ToString
                    returnaddress = tbl1.Rows(0).Item("RETURN_ADDRESS").ToString
                    a = Split(Me.txtE_MailTextBox.Text.Trim, ";")
                    If a(0) <> "" Then
                        For i = 0 To UBound(a)
                            colTO.Add(a(i))
                        Next
                    End If
                    a = Split(tbl1.Rows(0).Item("CC_ADDRESS").ToString, ";")
                    If a(0) <> "" Then
                        For i = 0 To UBound(a)
                            colCC.Add(a(i))
                        Next
                    End If
                End If

                If chkProfileCategories.CheckedItems.Count > 0 Then

                    n_PERSALPDF = "" : n_FIN = "" : n_HR = "" : n_HR_OVERSIGHT = "" : n_LOGIS = ""

                    If rbAccountLevel2.Checked Then n_Level = rbAccountLevel2.Text
                    If rbAccountLevel3.Checked Then n_Level = rbAccountLevel3.Text
                    If rbAccountLevel4.Checked Then n_Level = rbAccountLevel4.Text
                    If rbAccountLevel5.Checked Then n_Level = rbAccountLevel5.Text
                    If rbAccountLevel6.Checked Then n_Level = rbAccountLevel6.Text
                    If rbAccountLevel7.Checked Then n_Level = rbAccountLevel7.Text

                    n_FIN = "None" : n_HR = "None" : n_LOGIS = "None" : n_PERSALPDF = "None" : n_HR_OVERSIGHT = "None"

                    For i = 0 To chkProfileCategories.CheckedItems.Count - 1
                        If chkProfileCategories.CheckedItems(i).Text = "PERSALPDF" Then
                            n_PERSALPDF = n_Level.Trim
                        End If
                        If chkProfileCategories.CheckedItems(i).Text = "LOGIS" Then
                            n_LOGIS = n_Level.Trim
                        End If
                        If chkProfileCategories.CheckedItems(i).Text = "FINANCIALS" Then
                            n_FIN = n_Level.Trim
                        End If
                        If chkProfileCategories.CheckedItems(i).Text = "HR" Then
                            n_HR = n_Level.Trim
                        End If
                        If chkProfileCategories.CheckedItems(i).Text = "HR_OVERSIGHT" Then
                            n_HR_OVERSIGHT = n_Level.Trim
                        End If

                    Next
                Else

                    n_FIN = "None" : n_HR = "None" : n_LOGIS = "None" : n_PERSALPDF = "None" : n_HR_OVERSIGHT = "None"

                End If

                Dim tbl_job As DataTable = Me.Ta_Estab2.GetData_JOB_DESCRIPTION(Me.txtPersalNumber.Text.Trim.ToUpper)
                If tbl_job.Rows.Count > 0 Then
                    jobdescription = tbl_job.Rows(0).Item(0).ToString()
                Else
                    jobdescription = "Not found"
                End If
                accessnow = ""
                accessnow = "<table border='1'>" & _
                      "<tr><td bgcolor='gainsboro'><font face='verdana' size='2' color='black'><b>Application</b></font></td><td bgcolor='gainsboro'><font face='verdana' size='2' color='black'><b>Access currently</font></b></td></tr>" & _
                      "<tr><td><font face='verdana' size='2'>Financial applications</font></td><td><font face='verdana' size='2' color='blue'>" & n_FIN.Trim & "</font></td></tr>" & _
                      "<tr><td><font face='verdana' size='2'>Supply Chain applications</font></td><td><font face='verdana' size='2' color='blue'>" & n_LOGIS.Trim & "</font></td></tr>" & _
                      "<tr><td><font face='verdana' size='2'>Human Resources applications</font></td><td><font face='verdana' size='2' color='blue'>" & n_HR.Trim & "</font></td></tr>" & _
                      "<tr><td><font face='verdana' size='2'>HR Oversight applications</font></td><td><font face='verdana' size='2' color='blue'>" & n_HR_OVERSIGHT.Trim & "</font></td></tr>" & _
                      "<tr><td><font face='verdana' size='2'>Persal PDF applications</font></td><td><font face='verdana' size='2' color='blue'>" & n_PERSALPDF.Trim & "</font></td></tr>" & _
                     "</table></font>"

                BUS_TEL = DirectCast(VIP_USERSDataGridView.Item("BUS_TEL", VIP_USERSDataGridView.SelectedRows(VIP_USERSDataGridView.SelectedRows.Count - 1).Index).Value, String)
                CEL_TEL = DirectCast(VIP_USERSDataGridView.Item("CEL_TEL", VIP_USERSDataGridView.SelectedRows(VIP_USERSDataGridView.SelectedRows.Count - 1).Index).Value, String)
                a_HR = DirectCast(VIP_USERSDataGridView.Item("REQ_HR", VIP_USERSDataGridView.SelectedRows(VIP_USERSDataGridView.SelectedRows.Count - 1).Index).Value, String)
                a_FIN = DirectCast(VIP_USERSDataGridView.Item("REQ_FINANCIALS", VIP_USERSDataGridView.SelectedRows(VIP_USERSDataGridView.SelectedRows.Count - 1).Index).Value, String)
                a_SCM = DirectCast(VIP_USERSDataGridView.Item("REQ_LOGIS", VIP_USERSDataGridView.SelectedRows(VIP_USERSDataGridView.SelectedRows.Count - 1).Index).Value, String)
                a_PERSALPDF = DirectCast(VIP_USERSDataGridView.Item("REQ_PERSALPDF", VIP_USERSDataGridView.SelectedRows(VIP_USERSDataGridView.SelectedRows.Count - 1).Index).Value, String)
                a_HR_OVERSIGHT = DirectCast(VIP_USERSDataGridView.Item("REQ_HR_OVERSIGHT", VIP_USERSDataGridView.SelectedRows(VIP_USERSDataGridView.SelectedRows.Count - 1).Index).Value, String)
                a_notes = DirectCast(VIP_USERSDataGridView.Item("NOTES", VIP_USERSDataGridView.SelectedRows(VIP_USERSDataGridView.SelectedRows.Count - 1).Index).Value, String)
                a_responsibility = DirectCast(VIP_USERSDataGridView.Item("RESPONSIBILITY", VIP_USERSDataGridView.SelectedRows(VIP_USERSDataGridView.SelectedRows.Count - 1).Index).Value, String)
                accessrequired = "<table border='1'>" & _
                      "<tr><td bgcolor='gainsboro'><font face='verdana' size='2' color='black'><b>Application Required</b></font></td><td bgcolor='gainsboro'><font face='verdana' size='2' color='black'><b>Access Level Required</font></b></td></tr>" & _
                      "<tr><td><font face='verdana' size='2'>Financial applications</font></td><td><font face='verdana' size='2' color='blue'>" & DirectCast(a_FIN.Trim, String) & "</font></td></tr>" & _
                      "<tr><td><font face='verdana' size='2'>Supply Chain applications</font></td><td><font face='verdana' size='2' color='blue'>" & DirectCast(a_SCM.Trim, String) & "</font></td></tr>" & _
                      "<tr><td><font face='verdana' size='2'>Human Resources applications</font></td><td><font face='verdana' size='2' color='blue'>" & DirectCast(a_HR.Trim, String) & "</font></td></tr>" & _
                      "<tr><td><font face='verdana' size='2'>HR Oversight applications</font></td><td><font face='verdana' size='2' color='blue'>" & DirectCast(a_HR_OVERSIGHT.Trim, String) & "</font></td></tr>" & _
                      "<tr><td><font face='verdana' size='2'>Persal PDF applications</font></td><td><font face='verdana' size='2' color='blue'>" & DirectCast(a_PERSALPDF.Trim, String) & "</font></td></tr>" & _
                     "</table></font>"
                fullname = Me.txtTitleTextBox.Text.Trim & " " & Me.txtFirst_NameTextBox.Text.Trim & ", " & Me.txtLast_NameTextBox.Text.Trim()
                col.Add("fullname~~" & fullname & "")
                col.Add("persal_no~~" & Me.txtPersalNumber.Text.Trim & "")
                If Me.lwDepartments.CheckedItems.Count > 0 Then
                    col.Add("department~~" & Me.lwDepartments.CheckedItems(0).SubItems(1).Text & " - " & Me.lwDepartments.CheckedItems(0).SubItems(2).Text & "")
                Else
                    col.Add("department~~" & Me.txtDepartment_TypeTextBox.Text.Trim & " - " & Me.txtDepartment_NameTextBox.Text.Trim & "")
                End If
                col.Add("jobdescription~~" & jobdescription & "")
                col.Add("accessnow~~" & accessnow & "")
                col.Add("responsibility~~" & a_responsibility.ToString & "")
                col.Add("accessrequired~~" & accessrequired & "")
                col.Add("BUS_TEL~~" & BUS_TEL & "")
                col.Add("CEL_TEL~~" & CEL_TEL & "")
                If MsgBox("Do you want to add a comment to this EMail?", MsgBoxStyle.YesNo, "Vulindlela Comment?") = MsgBoxResult.Yes Then
                    Dim mtext As String = ""
                    mtext = "<b>Vulindlela Comment:</b><br>" & InputBox("Do want to add a comment to this EMail", "User Support Comment", "")
                    a_notes = mtext & "<br><br><b>User Comment</b><br>" & a_notes.ToString
                    col.Add("notes~~" & a_notes.ToString.Trim & "")
                Else
                    col.Add("notes~~" & a_notes.ToString.Trim & "")
                End If

                If frmEnvironment.ChildFormPRD.Visible Then
                    Me.ADCONSOLELOGTableAdapter.InsertIntoADAdminConsoleLog2(frmEnvironment.ChildFormPRD.tsLabelVulname.Text, _
                                 Get_ValidPersalNumber(txtPersalNumber.Text.Trim), _
                                 "CFO Letter Requested : Requested Info", True)
                    frmEnvironment.ChildFormPRD.Refresh_Log()
                    ADCONSOLELOGTableAdapter.UpdateCFOFlag(Me.txtPersalNumber.Text.Trim, 1)
                Else
                    Me.ADCONSOLELOGTableAdapter.InsertIntoADAdminConsoleLog2(frmEnvironment.childformQA.tsLabelVulname.Text, _
                                 Get_ValidPersalNumber(txtPersalNumber.Text.Trim), _
                                 "CFO Letter Requested : Requested Info", True)
                    frmEnvironment.childformQA.Refresh_Log()
                    'ADCONSOLELOGTableAdapter.UpdateCFOFlag(Me.txtPersalNumber.Text.Trim, 1)
                End If

                ParseFile_Email("Request a CFO Letter.htt", col, colTO, colCC, returnaddress)
                MsgBox("EMail Sent", MsgBoxStyle.OkOnly, "System Message")

            End If

        Else

            MsgBox("Cannot send a CFO Letter request - please ask the user to log a web request first")
            Exit Sub

        End If

        col = Nothing
        colTO = Nothing
        colCC = Nothing
        tbl1 = Nothing

    End Sub

    Private Sub tsCFO_Approval_Request_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsCFO_Approval_Request.Click
        SendEMailFORMCFOApprovalToolStripMenuItem_Click(sender, e)
    End Sub       '' SendEMailFORMCFOApprovalToolStripMenuItem_Click

    Private Sub EMailAPPROVALFORMCFOApprovalRequestToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EMailAPPROVALFORMCFOApprovalRequestToolStripMenuItem.Click

        If txtPersalNumber.Text.Trim = "" Then
            MsgBox("Persal Number is empty", MsgBoxStyle.OkOnly, "Missing Information")
            Exit Sub
        End If

        If Me.txtRightsRequested.Text.Trim = "" Then
            MsgBox("Request Information is empty", MsgBoxStyle.OkOnly, "Missing Information")
            Exit Sub
        End If

        Dim i As Integer = 0
        Dim a() As String
        Dim subject As String = ""
        Dim tbl1 As DataTable
        Dim returnaddress As String = ""

        Dim col As New Microsoft.VisualBasic.Collection
        Dim colTO As New Microsoft.VisualBasic.Collection
        Dim colCC As New Microsoft.VisualBasic.Collection

        Dim accessnow As String = ""
        Dim jobdescription As String = ""
        Dim n_FIN As String = "", n_HR As String = "", n_LOGIS As String = "", n_PERSALPDF As String = "", n_HR_OVERSIGHT As String = "", n_Level As String = ""

        If chkProfileCategories.CheckedItems.Count > 0 Then
            n_FIN = "" : n_HR = "" : n_LOGIS = "" : n_PERSALPDF = "" : n_HR_OVERSIGHT = ""

            If rbAccountLevel2.Checked Then : n_Level = rbAccountLevel2.Text : End If
            If rbAccountLevel3.Checked Then : n_Level = rbAccountLevel3.Text : End If
            If rbAccountLevel4.Checked Then : n_Level = rbAccountLevel4.Text : End If
            If rbAccountLevel5.Checked Then : n_Level = rbAccountLevel5.Text : End If
            If rbAccountLevel6.Checked Then : n_Level = rbAccountLevel6.Text : End If
            If rbAccountLevel7.Checked Then : n_Level = rbAccountLevel7.Text : End If

            n_FIN = "None" : n_HR = "None" : n_LOGIS = "None" : n_PERSALPDF = "None" : n_HR_OVERSIGHT = "None"
            For i = 0 To chkProfileCategories.CheckedItems.Count - 1
                If chkProfileCategories.CheckedItems(i).Text = "LOGIS" Then : n_LOGIS = n_Level.Trim : End If
                If chkProfileCategories.CheckedItems(i).Text = "FINANCIALS" Then : n_FIN = n_Level.Trim : End If
                If chkProfileCategories.CheckedItems(i).Text = "HR" Then : n_HR = n_Level.Trim : End If
                If chkProfileCategories.CheckedItems(i).Text = "PERSALPDF" Then : n_PERSALPDF = n_Level.Trim : End If
                If chkProfileCategories.CheckedItems(i).Text = "HR_OVERSIGHT" Then : n_HR_OVERSIGHT = n_Level.Trim : End If
            Next

        Else
            n_FIN = "None" : n_HR = "None" : n_LOGIS = "None" : n_PERSALPDF = "None" : n_HR_OVERSIGHT = "None"
        End If

        Dim tbl_job As DataTable = Me.HR_DataTableAdapter.GetDataBy_jobdescription(Me.txtPersalNumber.Text.Trim)

        If tbl_job.Rows.Count > 0 Then : jobdescription = tbl_job.Rows(0).Item("jobdescription").ToString()
        Else : jobdescription = "Not found"
        End If

        accessnow = ""
        accessnow = "<table border='1'>" & _
                             "<tr><td bgcolor='gainsboro'><font face='verdana' size='2' color='black'><b>Application</b></font></td><td bgcolor='gainsboro'><font face='verdana' size='2' color='black'><b>Access currently</font></b></td></tr>" & _
                             "<tr><td><font face='verdana' size='2'>Financial applications</font></td><td><font face='verdana' size='2' color='blue'>" & n_FIN.Trim & "</font></td></tr>" & _
                             "<tr><td><font face='verdana' size='2'>Supply Chain applications</font></td><td><font face='verdana' size='2' color='blue'>" & n_LOGIS.Trim & "</font></td></tr>" & _
                             "<tr><td><font face='verdana' size='2'>Human Resources applications</font></td><td><font face='verdana' size='2' color='blue'>" & n_HR.Trim & "</font></td></tr>" & _
                             "<tr><td><font face='verdana' size='2'>HR Oversight applications</font></td><td><font face='verdana' size='2' color='blue'>" & n_HR_OVERSIGHT.Trim & "</font></td></tr>" & _
                             "<tr><td><font face='verdana' size='2'>Persal PDF applications</font></td><td><font face='verdana' size='2' color='blue'>" & n_PERSALPDF.Trim & "</font></td></tr>" & _
                         "</table></font>"

        tbl1 = Me.ta_Vulindlela_Email.GetData("Refer To NT Financial Functions2")

        If tbl1.Rows.Count > 0 Then
            subject = tbl1.Rows(0).Item("SUBJECT").ToString
            returnaddress = tbl1.Rows(0).Item("RETURN_ADDRESS").ToString
            a = Split(returnaddress, ";")
            If a(0) <> "" Then
                For i = 0 To UBound(a)
                    colTO.Add(a(i))
                Next
            End If
        End If
        a = Split(tbl1.Rows(0).Item("CC_ADDRESS").ToString, ";")
        If a(0) <> "" Then
            For i = 0 To UBound(a)
                colCC.Add(a(i))
            Next
        End If

        col.Add("persal_no~~" & Me.txtPersalNumber.Text.Trim & "")
        col.Add("title~~" & Me.txtTitleTextBox.Text.Trim & "")
        col.Add("telephone~~" & Me.txtTelephoneTextBox.Text.Trim & "")
        col.Add("cellphone~~" & Me.txtCellphoneTextBox.Text.Trim & "")
        col.Add("firstnames~~" & Me.txtFirst_NameTextBox.Text.Trim & "")
        col.Add("lastname~~" & Me.txtLast_NameTextBox.Text.Trim & "")
        col.Add("deptname~~" & Me.txtDepartment_NameTextBox.Text.Trim & "")
        col.Add("depttype~~" & Me.txtDepartment_TypeTextBox.Text.Trim & "")
        col.Add("rank~~" & Me.txtRankTextBox.Text.Trim & "")
        col.Add("establishment~~" & CheckEstablishment(sender, e))
        col.Add("remedy_req~~" & Me.txtRightsRequested.Text.Trim & "")
        col.Add("requestno~~" & Me.txtRemedyRequestNo.Text.Trim & "")
        col.Add("r~~" & Me.txtRemedyRequestNo.Text.Trim & "")
        col.Add("accessnow~~" & accessnow.Trim & "")

        If Not String.IsNullOrEmpty(Me.txtRemedyRequestNo.Text) Then
            Rules_Flags_Valid_Insert_Requestno(Me.txtRemedyRequestNo.Text)
        Else
            MsgBox("There is not a Request Number to capture", MsgBoxStyle.OkOnly, "System Message")
            Exit Sub
        End If

        ParseFile_Email("Refer To NT Financial Functions2.htt", col, colTO, colCC, returnaddress)
        Insert_Requestno_Into_Rules_Flags(Me.txtRemedyRequestNo.Text)

        If frmEnvironment.ChildFormPRD.Visible Then
            Me.ADCONSOLELOGTableAdapter.InsertIntoADAdminConsoleLog2(frmEnvironment.ChildFormPRD.tsLabelVulname.Text, _
                                                             Get_ValidPersalNumber(txtPersalNumber.Text.Trim), _
                                                             "Refer To NT Financial Functions2", False)
            frmEnvironment.ChildFormPRD.Refresh_Log()
        Else
            Me.ADCONSOLELOGTableAdapter.InsertIntoADAdminConsoleLog2(frmEnvironment.childformQA.tsLabelVulname.Text, _
                                                             Get_ValidPersalNumber(txtPersalNumber.Text.Trim), _
                                                           "Refer To NT Financial Functions2", False)
            frmEnvironment.childformQA.Refresh_Log()
        End If

        col = Nothing

        Me.Cursor = Cursors.Arrow

        MsgBox("EMail Sent", MsgBoxStyle.OkOnly, "System Message")

    End Sub

    Private Sub SendEMailNoCFOLetterReceivedInTimeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SendEMailNoCFOLetterReceivedInTimeToolStripMenuItem.Click

        ' PSEUDO CODE
        ' ===========
        ' Check if a Persalnumber exist in the search box in Console Screen
        ' VIEW_CFO_APPPLICATION_TOOK_TO_LONG
        '       ACTIVITY LIKE '%CFO Letter Requested : Requested Info%'
        '       HAVING (CLIENTNUMBER NOT NULL) AND 
        '       DATETIME <= (TODAY - 14) AND 
        '       CFO (FLAG) = 1
        ' Parses Email template file by the name of "No CFO letter received in time.htt"
        ' Insert Into ADAdmin Console Log 
        '       Logged On User
        '       Persalno
        '       Description of "Flagged status 3 - CFO Letter Not Received"
        '       Sets the CFO (Flag) to 3
        Dim recs, i As Integer
        Dim cc, cc2() As String
        Dim returnaddress As String = ""
        Dim tbl As New System.Data.DataTable
        Dim tbl1 As New System.Data.DataTable
        Dim colTO, colCC, col As New Microsoft.VisualBasic.Collection
        Dim validpersalno As String

        If String.IsNullOrEmpty(frmEnvironment.ChildFormPRD.txtPersalNumber.Text) Then
            MsgBox("There's no persalnumber to use", MsgBoxStyle.OkOnly, "System Message")
            Exit Sub
        Else

            tbl1 = Me.ta_Vulindlela_Email.GetData("No CFO letter received in time")

            For Each r As DataRow In tbl1.Rows
                returnaddress = r("RETURN_ADDRESS").ToString & ""
                cc = r("CC_ADDRESS").ToString & ""
                cc2 = Split(cc, ";")
                For i = 0 To UBound(cc2)
                    colCC.Add(cc2(i))
                Next
                Exit For
            Next

            tbl = VIEW_CFO_APPPLICATION_TOOK_TO_LONGTableAdapter.GetData(Me.txtPersalNumber.Text.Trim)
            recs = tbl.Rows.Count

            If recs > 0 Then

                For Each r As DataRow In tbl.Rows
                    validpersalno = Get_ValidPersalNumber(r("CLIENTNUMBER").ToString)
                    col.Clear()
                    col.Add("fullname~~" & r("SUR_INI").ToString & "")
                    col.Add("persal_no~~" & r("CLIENTNUMBER").ToString & "")
                    col.Add("BUS_TEL~~" & r("BUS_TEL").ToString & "")
                    col.Add("CEL_TEL~~" & r("CEL_TEL").ToString & "")
                    col.Add("LETTER_DATE~~" & r("LETTER_DATE").ToString & "")
                    ParseFile_Email_Batch("No CFO letter received in time.htt", col, colTO, colCC, returnaddress, r("CLIENTNUMBER").ToString & "")
                    MsgBox("Mail sent", MsgBoxStyle.OkOnly, "System Message")
                    ADCONSOLELOGTableAdapter.InsertIntoADAdminConsoleLog2(tsLabelVulname.Text, validpersalno, "Flagged status 3 - CFO Letter Not Received", True)
                Next
            Else
                MsgBox("The program has searched for persons who more than 14 Days ago " & vbCrLf & _
                       "received CFO Letter Requests throught the system but could not " & vbCrLf & _
                       "find anyone that qualify for the criteria at this time", _
                       MsgBoxStyle.OkOnly, "System Message")
            End If

            tbl = Nothing
            colTO = Nothing
            colCC = Nothing
            col = Nothing

        End If

    End Sub

    Private Sub EMailAPPROVALFORMBudgetOfficerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EMailApprovalRequestChiefFinancialOfficer.Click
        tsSendEMailFORMBOApprovalToolStripMenuItem_Click(sender, e)
    End Sub '' EMailAPPROVALFORMBudgetOfficer

    Public Sub Insert_Requestno_Into_Rules_Flags(ByVal requestno As String)
        Dim tbl As DataTable
        tbl = Me.RULES_FLAGSTableAdapter.Get_Existing_Flag(requestno)
        If tbl.Rows.Count < 1 Then
            If String.IsNullOrEmpty(requestno) Then
            Else
                Me.RULES_FLAGSTableAdapter.Flag_Insert_RequestNo(requestno)
            End If
        End If
        tbl = Nothing
        Return
    End Sub

    Public Sub Update_Rules_Flags_With_CFOID(ByVal requestno As String, ByVal cfoid As String)

        Me.RULES_FLAGSTableAdapter.Flag_Update_CFOid_RequestNo(requestno, cfoid & "")

    End Sub

    Public Sub tsSendEMailFORMBOApprovalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EMailApprovalRequestChiefFinancialOfficer.Click

        Dim BOemail As New Collection

        If txtPersalNumber.Text.Trim = "" Then
            MsgBox("Persal Number is empty", MsgBoxStyle.OkOnly, "Missing Information")
            Exit Sub
        End If

        If Me.txtRightsRequested.Text.Trim = "" Then
            MsgBox("Request Information is empty", MsgBoxStyle.OkOnly, "Missing Information")
            Exit Sub
        End If
        Dim requestno As String = ""
        Dim i As Integer = 0
        Dim a() As String
        Dim subject As String = ""
        Dim tbl1 As DataTable
        Dim returnaddress As String = ""

        Dim col As New Microsoft.VisualBasic.Collection
        Dim colTO As New Microsoft.VisualBasic.Collection
        Dim colCC As New Microsoft.VisualBasic.Collection

        Dim accessnow As String
        Dim jobdescription As String
        Dim n_FIN As String, n_HR As String, n_LOGIS As String, n_PERSALPDF As String, n_HR_OVERSIGHT As String, n_Level As String

        If chkProfileCategories.CheckedItems.Count > 0 Then
            n_FIN = ""
            n_HR = ""
            n_LOGIS = ""
            n_PERSALPDF = ""
            n_HR_OVERSIGHT = ""

            If rbAccountLevel2.Checked Then
                n_Level = rbAccountLevel2.Text
            End If

            If rbAccountLevel3.Checked Then
                n_Level = rbAccountLevel3.Text
            End If

            If rbAccountLevel4.Checked Then
                n_Level = rbAccountLevel4.Text
            End If

            If rbAccountLevel5.Checked Then
                n_Level = rbAccountLevel5.Text
            End If

            If rbAccountLevel6.Checked Then
                n_Level = rbAccountLevel6.Text
            End If

            If rbAccountLevel7.Checked Then
                n_Level = rbAccountLevel7.Text
            End If

            n_HR = "None"
            n_FIN = "None"
            n_LOGIS = "None"
            n_PERSALPDF = "None"
            n_HR_OVERSIGHT = "None"

            For i = 0 To chkProfileCategories.CheckedItems.Count - 1

                If chkProfileCategories.CheckedItems(i).Text = "LOGIS" Then
                    n_LOGIS = n_Level.Trim
                End If

                If chkProfileCategories.CheckedItems(i).Text = "FINANCIALS" Then
                    n_FIN = n_Level.Trim
                End If

                If chkProfileCategories.CheckedItems(i).Text = "HR" Then
                    n_HR = n_Level.Trim
                End If

                If chkProfileCategories.CheckedItems(i).Text = "PERSALPDF" Then
                    n_PERSALPDF = n_Level.Trim
                End If

                If chkProfileCategories.CheckedItems(i).Text = "HR_OVERSIGHT" Then
                    n_HR_OVERSIGHT = n_Level.Trim
                End If

            Next

        Else
            n_HR = "None"
            n_FIN = "None"
            n_LOGIS = "None"
            n_PERSALPDF = "None"
            n_HR_OVERSIGHT = "None"
        End If

        Dim tbl_job As DataTable = Me.HR_DataTableAdapter.GetDataBy_jobdescription(Me.txtPersalNumber.Text.Trim)
        If tbl_job.Rows.Count > 0 Then
            jobdescription = tbl_job.Rows(0).Item("jobdescription").ToString()
        Else
            jobdescription = "Not found"
        End If
        accessnow = ""
        accessnow = "<table border='1'>" & _
                             "<tr><td bgcolor='gainsboro'><font face='verdana' size='2' color='black'><b>Application</b></font></td><td bgcolor='gainsboro'><font face='verdana' size='2' color='black'><b>Access currently</font></b></td></tr>" & _
                             "<tr><td><font face='verdana' size='2'>Financial applications</font></td><td><font face='verdana' size='2' color='blue'>" & n_FIN.Trim & "</font></td></tr>" & _
                             "<tr><td><font face='verdana' size='2'>Supply Chain applications</font></td><td><font face='verdana' size='2' color='blue'>" & n_LOGIS.Trim & "</font></td></tr>" & _
                             "<tr><td><font face='verdana' size='2'>Human Resources applications</font></td><td><font face='verdana' size='2' color='blue'>" & n_HR.Trim & "</font></td></tr>" & _
                             "<tr><td><font face='verdana' size='2'>HR Oversight applications</font></td><td><font face='verdana' size='2' color='blue'>" & n_HR_OVERSIGHT.Trim & "</font></td></tr>" & _
                             "<tr><td><font face='verdana' size='2'>Persal PDF applications</font></td><td><font face='verdana' size='2' color='blue'>" & n_PERSALPDF.Trim & "</font></td></tr>" & _
                     "</table></font>"

        tbl1 = Me.ta_Vulindlela_Email.GetData("CFO Approval Request2")

        If tbl1.Rows.Count > 0 Then
            subject = tbl1.Rows(0).Item("SUBJECT").ToString
            returnaddress = tbl1.Rows(0).Item("RETURN_ADDRESS").ToString
            a = Split(returnaddress, ";")
            If a(0) <> "" Then
                For i = 0 To UBound(a)
                    colTO.Add(a(i))
                Next
            End If
        End If
        a = Split(tbl1.Rows(0).Item("CC_ADDRESS").ToString, ";")
        If a(0) <> "" Then
            For i = 0 To UBound(a)
                colCC.Add(a(i))
            Next
        End If

        Dim cfo() As String
        cfo = Split(look_up_CFO_for_this_person, ",")
        col.Add("persal_no~~" & Me.txtPersalNumber.Text.Trim & "")
        col.Add("title~~" & Me.txtTitleTextBox.Text.Trim & "")
        col.Add("telephone~~" & Me.txtTelephoneTextBox.Text.Trim & "")
        col.Add("cellphone~~" & Me.txtCellphoneTextBox.Text.Trim & "")
        col.Add("firstnames~~" & Me.txtFirst_NameTextBox.Text.Trim & "")
        col.Add("lastname~~" & Me.txtLast_NameTextBox.Text.Trim & "")
        col.Add("deptname~~" & Me.txtDepartment_NameTextBox.Text.Trim & "")
        col.Add("depttype~~" & Me.txtDepartment_TypeTextBox.Text.Trim & "")
        col.Add("rank~~" & Me.txtRankTextBox.Text.Trim & "")
        col.Add("establishment~~" & CheckEstablishment(sender, e))
        col.Add("remedy_req~~" & Me.txtRightsRequested.Text.Trim & "")
        col.Add("requestno~~" & Me.txtRemedyRequestNo.Text.Trim & "")
        col.Add("r~~" & Me.txtRemedyRequestNo.Text.Trim & "")
        col.Add("accessnow~~" & accessnow.Trim & "")
        col.Add("cfoname~~" & ", " & cfo(3).Trim & " " & cfo(2).Trim & " (" & cfo(1).Trim & ")")
        col.Add("u~~" & cfo(1).Trim & "")

        ' Enter the CFO persalnumber and the request number into the database to 
        ' ensure that when it is sent back an entry can be found in the table
        ' for control purposes.

        BOemail.Add(cfo(0))

        requestno = Me.txtRemedyRequestNo.Text.Trim & ""

        ' Only Insert the flag so that this entry show in list

        '' Budget Officers
        ''''''''''''''''''''''''
        ''''''''''''''''''''''''
        Insert_Requestno_Into_Rules_Flags(requestno)

        ' Only Insert the flag so that it show in list

        '' Budget Officers
        ''''''''''''''''''''''''
        ''''''''''''''''''''''''
        ParseFile_Email("CFO Approval Request2.htt", col, BOemail, colCC, returnaddress)

        ' Only Insert the flag so that it show in list

        '' Budget Officers
        ''''''''''''''''''''''''
        ''''''''''''''''''''''''
        '''''''''''''''''''''''''Update_Rules_Flags_With_CFOID(requestno, cfo(1).Trim & "")

        If frmEnvironment.ChildFormPRD.Visible Then
            '' Budget Officers
            ''''''''''''''''''''''''
            ''''''''''''''''''''''''
            ''''''''''''''''''''''''Me.ADCONSOLELOGTableAdapter.InsertIntoADAdminConsoleLog2(frmEnvironment.ChildFormPRD.tsLabelVulname.Text, _
            ''''''''''''''''''''''''                                                 Get_ValidPersalNumber(txtPersalNumber.Text.Trim), _
            ''''''''''''''''''''''''                                                 "CFO Approval Request2", 0)

            frmEnvironment.ChildFormPRD.Refresh_Log()
        Else
            '' Budget Officers
            ''''''''''''''''''''''''
            ''''''''''''''''''''''''
            ''''''''''''''''''''''''Me.ADCONSOLELOGTableAdapter.InsertIntoADAdminConsoleLog2(frmEnvironment.childformQA.tsLabelVulname.Text, _
            ''''''''''''''''''''''''                                                 Get_ValidPersalNumber(txtPersalNumber.Text.Trim), _
            ''''''''''''''''''''''''                                               "CFO Approval Request2", 0)
            frmEnvironment.childformQA.Refresh_Log()
        End If

        col = Nothing

        If Not String.IsNullOrEmpty(Me.txtRemedyRequestNo.Text) Then
            '' Budget Officers
            ''''''''''''''''''''''''
            ''''''''''''''''''''''''
            ''''''''''''''''''''''''Rules_Flags_Valid_Insert_Requestno(Me.txtRemedyRequestNo.Text)
        End If

        Me.Cursor = Cursors.Arrow

        MsgBox("EMail Sent", MsgBoxStyle.OkOnly, "System Message")

    End Sub '' Budget Officers

    Private Sub btnReferrals_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReferrals.Click
        Cleartxt = False
        frmReferrals.ShowDialog()
    End Sub

    Public Sub Rules_Flags_Valid_Delete_Requestno(ByVal requestno As String)

        Dim tbl As DataTable
        tbl = Me.RULES_FLAGS_VALIDTableAdapter.GetRulesFlagValid(requestno)
        If tbl.Rows.Count > 0 Then
            Me.RULES_FLAGS_VALIDTableAdapter.Flag_Valid_Delete(requestno)
        End If
        tbl = Nothing

    End Sub

    Public Sub Rules_Flags_Valid_Insert_Requestno(ByVal requestno As String)

        Dim tbl As DataTable
        tbl = Me.RULES_FLAGS_VALIDTableAdapter.GetRulesFlagValid(requestno)
        If tbl.Rows.Count = 0 Then
            Me.RULES_FLAGS_VALIDTableAdapter.Flag_Valid_Insert(requestno)
        End If
        tbl = Nothing

    End Sub

    ' Delete CFO
    'Private Sub ToolStripMenuItem44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem44.Click
    '    Delete_CFO_Records()
    '    Retrieve_Contacts()
    'End Sub

#End Region



    Private Sub NotifyUserRequestRemovedOffQueueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotifyUserRequestRemovedOffQueueToolStripMenuItem.Click, NotifyUserRequestRemovedOffQueueToolStripMenuItem1.Click

        'Me.Cursor = Cursors.WaitCursor

        If ADAdminDotNet.frmEnvironment.ActiveMdiChild.Text = "Active Directory Console - PRD" Then

            If frmEnvironment.ChildFormPRD.txtPersalNumber.Text.Trim = "" Then
                Exit Sub
            End If

        ElseIf ADAdminDotNet.frmEnvironment.ActiveMdiChild.Text = "Active Directory Console - QA" Then

            If frmEnvironment.childformQA.txtPersalNumber.Text.Trim = "" Then
                Exit Sub
            End If

        End If

        Dim i As Integer
        Dim a() As String
        Dim scode As String = ""
        Dim subject As String = ""
        Dim applcol As String = ""
        Dim deptcol As String = ""

        Dim tbl1 As DataTable
        Dim returnaddress As String = ""
        Dim DateReceived As String = ""
        Dim col As New Microsoft.VisualBasic.Collection
        Dim colTO As New Microsoft.VisualBasic.Collection
        Dim colCC As New Microsoft.VisualBasic.Collection
        Dim persalnumber As String

        If Me.lwDepartments.CheckedItems.Count > 0 Then

            scode = Me.lwDepartments.CheckedItems(0).SubItems(1).Text.Trim
            persalnumber = modADS.Get_ValidUsername(Me.txtPersalNumber.Text.Trim)

            tbl1 = Me.ta_Vulindlela_Email.GetData("Vulindlela User Account Reset")
            colCC = Get_Vulindlela_ProvController(scode)

            If tbl1.Rows.Count > 0 Then

                subject = tbl1.Rows(0).Item("SUBJECT").ToString
                returnaddress = tbl1.Rows(0).Item("RETURN_ADDRESS").ToString
                DateReceived = tbl1.Rows(0).Item("CREATED").ToString

                colTO.Add(Me.txtE_MailTextBox.Text.Trim)

                a = Split(tbl1.Rows(0).Item("TO_ADDRESS").ToString, ";")
                If a(0) <> "" Then

                    For i = 0 To UBound(a)
                        colTO.Add(a(i))
                    Next

                End If

                a = Split(tbl1.Rows(0).Item("CC_ADDRESS").ToString, ";")

                If a(0) <> "" Then

                    For i = 0 To UBound(a)
                        colCC.Add(a(i))
                    Next

                End If

            End If

            col.Add("username~~" & persalnumber & "")
            col.Add("helpdesk_phoneno~~" & My.Settings.HelpDesk_PhoneNo.Trim() & "")
            col.Add("email_address~~" & Me.txtE_MailTextBox.Text.Trim & "")

            '     ParseFile_Email("Email No CFO letter received in time.htt", col, colTO, colCC, returnaddress)

            col = Nothing

            If frmEnvironment.ChildFormPRD.Visible Then

                Me.ADCONSOLELOGTableAdapter.InsertIntoADAdminConsoleLog2(frmEnvironment.ChildFormPRD.tsLabelVulname.Text, _
                                                                 Get_ValidPersalNumber(persalnumber), _
                                                                 "Request taken off queue : " & Me.txtE_MailTextBox.Text.Trim, False)
                frmEnvironment.ChildFormPRD.Refresh_Log()
            Else

                Me.ADCONSOLELOGTableAdapter.InsertIntoADAdminConsoleLog2(frmEnvironment.childformQA.tsLabelVulname.Text, _
                                                                 Get_ValidPersalNumber(persalnumber), _
                                                                 "Request taken off queue : " & Me.txtE_MailTextBox.Text.Trim, False)
                frmEnvironment.childformQA.Refresh_Log()

            End If
            Me.Cursor = Cursors.Arrow
            MsgBox("User : " & Me.txtPersalNumber.Text.Trim.ToUpper & " Request taken off queue.", MsgBoxStyle.OkOnly, "System Message")
            timerCOUNTS_Tick(sender, e)

        End If

        Me.Cursor = Cursors.Arrow

    End Sub

    Private Sub CreateFreshADSnapshotToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If MsgBox("Are you sure you want to export the entire database. This will take several minutes?", MsgBoxStyle.YesNo, "Export AD Database to Excel") = MsgBoxResult.Yes Then
            Hourglass(True)
            modADSExport.Create_Snapshot()
            Hourglass(False)
            MsgBox("AD Export Completed")
        End If

    End Sub

    Private Sub Hourglass(ByVal Show As Boolean)

        If Show = True Then
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Else
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End If
        Return

    End Sub

    Public Sub create_dept_ad(ByVal deptname As String)

        Create_Government_Group(deptname)
        Create_Government_Group("FINANCIALS." & deptname)
        Create_Government_Group("HR." & deptname)
        Create_Government_Group("DPSA." & deptname)
        Create_Government_Group("AUDITGENL." & deptname)
        Create_Government_Group("LOGIS." & deptname)
        Create_Government_Group("GENERAL_REPORTING." & deptname)
        Create_Government_Group("GFS." & deptname)
        Create_Government_Group("PERSALFTP." & deptname)

    End Sub

    Private Sub MonthEndStats_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MonthEndStats.Click
        frmStats.Show()
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub UsersNotOnEstablishmentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsersNotOnEstablishmentToolStripMenuItem.Click
        frmUsersNotOnEstab.Show()
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub Label17_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        frmAD_create_new_shortcode.Show()
    End Sub

    Public Function Get_User_Creation_Date(ByVal username As String) As String

        Dim dso As IADs
        Dim oUser As IADsUser
        Dim connectstring As String
        Dim enc As New ClsCrypto

        On Error GoTo FoundError
        dso = DirectCast(GetObject("LDAP:"), IADs)
        If frmEnvironment.ChildFormPRD.Visible Then
            connectstring = "LDAP://" & My.MySettings.Default.IP_ADDRESS_PRD & "/CN=" & username & "," & My.MySettings.Default.AD_USERS_PRD
            oUser = DirectCast(dso.OpenDSObject(connectstring, My.MySettings.Default.ADSMasterUsername_PRD, enc.Dekodeer128(My.MySettings.Default.ADSMasterPassword_PRD.ToString), 1), IADsUser)
        Else
            connectstring = "LDAP://" & My.MySettings.Default.IP_ADDRESS_QA & "/CN=" & username & "," & My.MySettings.Default.AD_USERS_QA
            oUser = DirectCast(dso.OpenDSObject(connectstring, My.MySettings.Default.ADSMasterUsername_QA, enc.Dekodeer128(My.MySettings.Default.ADSMasterPassword_QA.ToString), 1), IADsUser)
        End If

        Return Microsoft.VisualBasic.Left(oUser.Get("whenCreated").ToString, 10)

FoundError:

        dso = Nothing
        oUser = Nothing
        connectstring = ""

    End Function

    Public Function Get_User_BadLogons(ByVal username As String) As Long

        Dim dso As IADs
        Dim oUser As IADsUser
        Dim connectstring As String
        Dim enc As New ClsCrypto

        On Error GoTo FoundError

        If frmEnvironment.ChildFormPRD.Visible Then
            connectstring = "LDAP://" & My.MySettings.Default.IP_ADDRESS_PRD & "/CN=" & username & "," & My.MySettings.Default.AD_USERS_PRD
            dso = DirectCast(GetObject("LDAP:"), IADs)
            oUser = DirectCast(dso.OpenDSObject(connectstring, My.MySettings.Default.ADSMasterUsername_PRD, enc.Dekodeer128(My.MySettings.Default.ADSMasterPassword_PRD.ToString), 1), IADsUser)
        Else
            connectstring = "LDAP://" & My.MySettings.Default.IP_ADDRESS_QA & "/CN=" & username & "," & My.MySettings.Default.AD_USERS_QA
            dso = DirectCast(GetObject("LDAP:"), IADs)
            oUser = DirectCast(dso.OpenDSObject(connectstring, My.MySettings.Default.ADSMasterUsername_QA, enc.Dekodeer128(My.MySettings.Default.ADSMasterPassword_QA.ToString), 1), IADsUser)
        End If

        Return DirectCast(oUser.Get("badPwdCount"), Long)

FoundError:

        dso = Nothing
        oUser = Nothing
        connectstring = ""

    End Function

    Public Function Get_User_LogonCount(ByVal username As String) As Long

        Dim dso As IADs
        Dim oUser As IADsUser
        Dim connectstring As String
        Dim enc As New ClsCrypto

        On Error GoTo FoundError

        If frmEnvironment.ChildFormPRD.Visible Then
            connectstring = "LDAP://" & My.MySettings.Default.IP_ADDRESS_PRD & "/CN=" & username & "," & My.MySettings.Default.AD_USERS_PRD
            dso = DirectCast(GetObject("LDAP:"), IADs)
            oUser = DirectCast(dso.OpenDSObject(connectstring, My.MySettings.Default.ADSMasterUsername_PRD, enc.Dekodeer128(My.MySettings.Default.ADSMasterPassword_PRD.ToString), 1), IADsUser)
        Else
            connectstring = "LDAP://" & My.MySettings.Default.IP_ADDRESS_QA & "/CN=" & username & "," & My.MySettings.Default.AD_USERS_QA
            dso = DirectCast(GetObject("LDAP:"), IADs)
            oUser = DirectCast(dso.OpenDSObject(connectstring, My.MySettings.Default.ADSMasterUsername_QA, enc.Dekodeer128(My.MySettings.Default.ADSMasterPassword_QA.ToString), 1), IADsUser)
        End If

        Return DirectCast(oUser.Get("logonCount"), Long)

FoundError:

        dso = Nothing
        oUser = Nothing
        connectstring = ""

    End Function

    Public Function Get_User_Modified_Date(ByVal username As String) As String

        Dim dso As IADs
        Dim oUser As IADsUser
        Dim connectstring As String
        Dim enc As New ClsCrypto

        On Error GoTo FoundError
        dso = DirectCast(GetObject("LDAP:"), IADs)
        If frmEnvironment.ChildFormPRD.Visible Then
            connectstring = "LDAP://" & My.MySettings.Default.IP_ADDRESS_PRD & "/CN=" & username & "," & My.MySettings.Default.AD_USERS_PRD
            oUser = DirectCast(dso.OpenDSObject(connectstring, My.MySettings.Default.ADSMasterUsername_PRD, enc.Dekodeer128(My.MySettings.Default.ADSMasterPassword_PRD.ToString), 1), IADsUser)
        Else
            connectstring = "LDAP://" & My.MySettings.Default.IP_ADDRESS_QA & "/CN=" & username & "," & My.MySettings.Default.AD_USERS_QA
            oUser = DirectCast(dso.OpenDSObject(connectstring, My.MySettings.Default.ADSMasterUsername_QA, enc.Dekodeer128(My.MySettings.Default.ADSMasterPassword_QA.ToString), 1), IADsUser)
        End If
        Return Microsoft.VisualBasic.Left(oUser.Get("whenChanged").ToString, 10)

FoundError:
        dso = Nothing
        oUser = Nothing
        connectstring = ""

    End Function

    Private Sub BySurnameToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BySurnameToolStripMenuItem1.Click
        frmRemedyBySurname.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim oGroup As IADsGroup
        Dim GroupName As String = ""
        Dim cntx As String, mGroup As String
        Dim IpAddress As String = Get_IPaddress_String()
        Dim GetMasterUser As String = Get_Master_User()
        Dim GetMasterPwd As String = Get_Master_Pwd()
        Dim dso As IADs = DirectCast(GetObject("LDAP:"), IADs)


        For Each item As ListViewItem In lwA.CheckedItems
            '*************************************************************************************
            '1. Create the Base Group 
            GroupName = item.SubItems(1).Text.Trim & ""
            cntx = Get_Complete_CN_OU_Context(GroupName.ToString, ou_context.GOVERNMENT_STRUCTURE)
            Try
                oGroup = DirectCast(dso.OpenDSObject("LDAP://" & IpAddress & "/" & cntx, GetMasterUser, GetMasterPwd, ADS_SECURE_AUTHENTICATION), IADsGroup)
                mGroup = oGroup.Name.ToString
            Catch ex As Exception
                Create_Government_Group(GroupName)
            End Try
            '*************************************************************************************
            '2. Create the AUDITGENL Group
            GroupName = "AUDITGENL." & item.SubItems(1).Text.Trim
            cntx = Get_Complete_CN_OU_Context(GroupName, ou_context.GOVERNMENT_STRUCTURE)
            Try

                oGroup = DirectCast(dso.OpenDSObject("LDAP://" & IpAddress & "/" & cntx, GetMasterUser, GetMasterPwd, ADS_SECURE_AUTHENTICATION), IADsGroup)
                mGroup = oGroup.Name.ToString
            Catch ex As Exception
                Create_Government_Group(GroupName)
            End Try
            '*************************************************************************************
            '3. Create the DPSA Group
            GroupName = "DPSA." & item.SubItems(1).Text.Trim
            cntx = Get_Complete_CN_OU_Context(GroupName, ou_context.GOVERNMENT_STRUCTURE)
            Try
                oGroup = DirectCast(dso.OpenDSObject("LDAP://" & IpAddress & "/" & cntx, GetMasterUser, GetMasterPwd, ADS_SECURE_AUTHENTICATION), IADsGroup)
                mGroup = oGroup.Name.ToString
            Catch ex As Exception
                Create_Government_Group(GroupName)
            End Try
            '*************************************************************************************
            '4. Create the FINANCIALS Group
            GroupName = "FINANCIALS." & item.SubItems(1).Text.Trim
            cntx = Get_Complete_CN_OU_Context(GroupName, ou_context.GOVERNMENT_STRUCTURE)
            Try
                oGroup = DirectCast(dso.OpenDSObject("LDAP://" & IpAddress & "/" & cntx, GetMasterUser, GetMasterPwd, ADS_SECURE_AUTHENTICATION), IADsGroup)
                mGroup = oGroup.Name.ToString
            Catch ex As Exception
                Create_Government_Group(GroupName)
            End Try
            '*************************************************************************************
            '5. Create the GENERAL_REPORTING Group
            GroupName = "GENERAL_REPORTING." & item.SubItems(1).Text.Trim
            cntx = Get_Complete_CN_OU_Context(GroupName, ou_context.GOVERNMENT_STRUCTURE)
            Try
                oGroup = DirectCast(dso.OpenDSObject("LDAP://" & IpAddress & "/" & cntx, GetMasterUser, GetMasterPwd, ADS_SECURE_AUTHENTICATION), IADsGroup)
                mGroup = oGroup.Name.ToString
            Catch ex As Exception
                Create_Government_Group(GroupName)
            End Try
            '*************************************************************************************
            '6. Create the GFS Group
            GroupName = "GFS." & item.SubItems(1).Text.Trim
            cntx = Get_Complete_CN_OU_Context(GroupName, ou_context.GOVERNMENT_STRUCTURE)
            Try
                oGroup = DirectCast(dso.OpenDSObject("LDAP://" & IpAddress & "/" & cntx, GetMasterUser, GetMasterPwd, ADS_SECURE_AUTHENTICATION), IADsGroup)
                mGroup = oGroup.Name.ToString
            Catch ex As Exception
                Create_Government_Group(GroupName)
            End Try
            '*************************************************************************************
            '7. Create the HR Group
            GroupName = "HR." & item.SubItems(1).Text.Trim
            cntx = Get_Complete_CN_OU_Context(GroupName, ou_context.GOVERNMENT_STRUCTURE)
            Try
                oGroup = DirectCast(dso.OpenDSObject("LDAP://" & IpAddress & "/" & cntx, GetMasterUser, GetMasterPwd, ADS_SECURE_AUTHENTICATION), IADsGroup)
                mGroup = oGroup.Name.ToString
            Catch ex As Exception
                Create_Government_Group(GroupName)
            End Try
            '*************************************************************************************
            '8. Create the HR_OVERSIGHT Group
            GroupName = "HR_OVERSIGHT." & item.SubItems(1).Text.Trim
            cntx = Get_Complete_CN_OU_Context(GroupName, ou_context.GOVERNMENT_STRUCTURE)
            Try
                oGroup = DirectCast(dso.OpenDSObject("LDAP://" & IpAddress & "/" & cntx, GetMasterUser, GetMasterPwd, ADS_SECURE_AUTHENTICATION), IADsGroup)
                mGroup = oGroup.Name.ToString
            Catch ex As Exception
                Create_Government_Group(GroupName)
            End Try
            '*************************************************************************************
            '9. Create the LOGIS Group
            GroupName = "LOGIS." & item.SubItems(1).Text.Trim
            cntx = Get_Complete_CN_OU_Context(GroupName, ou_context.GOVERNMENT_STRUCTURE)
            Try
                oGroup = DirectCast(dso.OpenDSObject("LDAP://" & IpAddress & "/" & cntx, GetMasterUser, GetMasterPwd, ADS_SECURE_AUTHENTICATION), IADsGroup)
                mGroup = oGroup.Name.ToString
            Catch ex As Exception
                Create_Government_Group(GroupName)
            End Try
            '*************************************************************************************
            '10. Create the PERSALPDF Group
            GroupName = "PERSALPDF." & item.SubItems(1).Text.Trim
            cntx = Get_Complete_CN_OU_Context(GroupName, ou_context.GOVERNMENT_STRUCTURE)
            Try
                oGroup = DirectCast(dso.OpenDSObject("LDAP://" & IpAddress & "/" & cntx, GetMasterUser, GetMasterPwd, ADS_SECURE_AUTHENTICATION), IADsGroup)
                mGroup = oGroup.Name.ToString
            Catch ex As Exception
                Create_Government_Group(GroupName)
            End Try

        Next

        dso = Nothing
        oGroup = Nothing

    End Sub

    Private Sub SelectAllCheckbox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectAllCheckbox.CheckedChanged

        Me.SuspendLayout()
        Me.Cursor = Cursors.AppStarting
        Me.lwA.Cursor = Cursors.AppStarting
        Me.TabControl1.Cursor = Cursors.AppStarting

        If SelectAllCheckbox.Checked Then
            For Each item As ListViewItem In lwA.Items
                item.Checked = True
            Next
            rbAccountLevel7.Checked = True
        Else
            For Each item As ListViewItem In lwA.CheckedItems
                item.Checked = False
            Next
            rbAccountLevel2.Checked = True
        End If

        Me.lwA.Cursor = Cursors.Arrow
        Me.Cursor = Cursors.Arrow
        Me.TabControl1.Cursor = Cursors.Arrow

        Me.ResumeLayout()

    End Sub

    Private Sub lwA_ItemChecked(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles lwA.ItemChecked
        lblCount.Text = lwA.CheckedItems.Count.ToString & " Departments Selected"
    End Sub

    Private Sub chkProfileCategories_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        build_chkProfileCategories_col()
    End Sub

    Private Sub btnDeptDiffers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeptDiffers.Click
        'frmDeptDiffers.ShowDialog()

        If frmEnvironment.ActiveMdiChild.Text.Contains("PRD") Then

            frmDeptDiffers.Text = "Departments that are different on Establishment - PRD"
            frmDeptDiffers.ShowDialog()
            frmDeptDiffers.Focus()

        Else

            frmDeptDiffers.Text = "Departments that are different on Establishment - QA"
            ' frmDeptDiffers.Department_DiffersTableAdapter.Connection.ConnectionString = My.MySettings.Default("ARSystemDevConnectionString1")
            frmDeptDiffers.ShowDialog()
            frmDeptDiffers.Focus()

        End If

        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub btnToFollowUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnToFollowUp.Click

        If frmEnvironment.ActiveMdiChild.Text.Contains("PRD") Then

            frmInfoRequired.Text = "Info Required / Refer to Client - PRD"
            frmInfoRequired.RemedyOpenRequestsTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemDevConnectionString")
            frmInfoRequired.LOG_IN_Request_Tracking2TableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemDevConnectionString")
            frmInfoRequired.ShowDialog()
            frmInfoRequired.Focus()

        Else
            'ARSystemDevConnectionString
            frmInfoRequired.Text = "Info Required / Refer to Client - QA"
            frmInfoRequired.RemedyOpenRequestsTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemDevConnectionString")
            frmInfoRequired.LOG_IN_Request_Tracking2TableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemDevConnectionString")
            frmInfoRequired.ShowDialog()
            frmInfoRequired.Focus()

        End If

        Me.Cursor = Cursors.Arrow


    End Sub

    Private Sub VIP_USERSDataGridView_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles VIP_USERSDataGridView.CellContentDoubleClick


        On Error Resume Next

        If frmEnvironment.ActiveMdiChild.Text.Contains("PRD") Then

            frmWebRequest.Text = "Web request Detail - PRD"
            frmWebRequest.VIP_USERSTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
            frmWebRequest.IdToolStripTextBox.Text = VIP_USERSDataGridView.Item(0, e.RowIndex).Value.ToString
            frmWebRequest.AccLevelToolStripTextBox.Text = VIP_USERSDataGridView.Item(10, e.RowIndex).Value.ToString
            frmWebRequest.ShowDialog()

        Else
            frmWebRequest.Text = "Web request Detail - QA"
            frmWebRequest.VIP_USERSTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
            frmWebRequest.IdToolStripTextBox.Text = VIP_USERSDataGridView.Item(0, e.RowIndex).Value.ToString
            frmWebRequest.AccLevelToolStripTextBox.Text = VIP_USERSDataGridView.Item(10, e.RowIndex).Value.ToString
            frmWebRequest.ShowDialog()

        End If



        Me.Cursor = Cursors.Arrow

    End Sub

    Public Sub _7(ByVal strArgs As String)
        ' Notify Call Centre via EMail 
        Dim args() As String
        args = Split(strArgs, ",")
        MsgBox("_7" & " " & args(0).Trim & " : " & args(1).Trim)
    End Sub

    Public Sub _8(ByVal strArgs As String)
        ' Notify National Treasury via EMail 
        Dim args() As String
        args = Split(strArgs, ",")
        MsgBox("_8" & " " & args(0).Trim & " : " & args(1).Trim)
    End Sub

    Public Sub _9(ByVal strArgs As String)
        ' Notify User via EMail
        Dim args() As String
        args = Split(strArgs, ",")
        MsgBox("_9" & " " & args(0).Trim & " : " & args(1).Trim)
    End Sub

    Public Sub _20(ByVal strArgs As String)
        Dim args() As String
        Dim requestno As String
        Dim approverid As String
        Dim scode As String = ""
        Dim subject As String = ""
        Dim applcol As String = ""
        Dim deptcol As String = ""
        Dim cfoname As String = ""
        Dim persalnumber As String = ""
        Dim returnaddress As String = ""
        Dim Strmemberof As String = ""
        Dim colmemberof As Microsoft.VisualBasic.Collection
        Dim col As New Microsoft.VisualBasic.Collection
        Dim colTO As New Microsoft.VisualBasic.Collection
        Dim colCC As New Microsoft.VisualBasic.Collection

        If String.IsNullOrEmpty(scode) Then
            MsgBox("User department does not have a CFO assigned", MsgBoxStyle.OkOnly, "This department has no CFO")
        Else
            args = Split(strArgs, ",")
            requestno = args(0).Trim
            approverid = args(1).Trim()

            persalnumber = LOG_IN_Request_TrackingTableAdapter.GetPersalFromRequestNO(requestno).ToString
            scode = resolve_user_department(persalnumber)
            remedy_req = requestno
            jobdescription = ""
            accessnow = ""
            accessrequired = ""
            establishment = ""

            colmemberof = Get_UserGroups(persalnumber)

            i = 1
            h = "<table border='1'><tr><td>"


            For i = 1 To colmemberof.Count
                If i = 1 Then
                    Strmemberof += colmemberof(i).ToString & "<br />"
                End If
            Next

            h += "</td></tr></table>"

            tbl1 = Me.ta_Vulindlela_Email.GetData("CFO Approval Request.htt")
            'colCC = Get_Vulindlela_ProvController(scode)

            If tbl1.Rows.Count > 0 Then

                subject = tbl1.Rows(0).Item("SUBJECT").ToString
                returnaddress = tbl1.Rows(0).Item("RETURN_ADDRESS").ToString

                colTO.Add(Me.txtE_MailTextBox.Text.Trim)

                a = Split(tbl1.Rows(0).Item("TO_ADDRESS").ToString, ";")
                If a(0) <> "" Then
                    For i = 0 To UBound(a)
                        colTO.Add(a(i))
                    Next
                End If
                a = Split(tbl1.Rows(0).Item("CC_ADDRESS").ToString, ";")
                If a(0) <> "" Then
                    For i = 0 To UBound(a)
                        colCC.Add(a(i))
                    Next
                End If

            End If

            '   User Information
            col.Add("persal_no~~" & persalnumber & "")
            col.Add("remedy_req~~" & requestno & "")
            col.Add("fullname~~" & fullname & "")
            col.Add("BUS_TEL~~" & telephone & "")
            col.Add("CEL_TEL~~" & cellular & "")
            col.Add("department~~" & persalnumber & "")
            col.Add("responsibility~~" & RESPONSIBILITIES & "")
            col.Add("jobdescription~~" & jobdescription & "")
            col.Add("accessnow~~" & accessnow & "")
            col.Add("accessrequired~~" & accessrequired & "")
            col.Add("establishment~~" & establishment & "")
            col.Add("cfoname~~" & approverid & "")

            ParseFile_Email("Vulindlela User Account Reset.htt", col, colTO, colCC, returnaddress)

            col = Nothing

            Me.ADCONSOLELOGTableAdapter.InsertIntoADAdminConsoleLog2(frmEnvironment.ChildFormPRD.tsLabelVulname.Text, _
                                                                 Get_ValidPersalNumber(persalnumber), _
                                                                 "Reset & EMailed : " & Me.txtE_MailTextBox.Text.Trim, False)
            frmEnvironment.ChildFormPRD.Refresh_Log()
        End If

    End Sub

    Public Sub _26(ByVal strArgs As String)
        Dim args() As String
        args = Split(strArgs, ",")
        MsgBox("_26" & " " & args(0).Trim & " : " & args(1).Trim)
    End Sub

    Function resolve_user_department(ByVal userid As String) As String
        If userid.Length > 12 Then '
            resolve_user_department = ""
        ElseIf userid.Length < 12 And InStr(1, userid, "T") > 0 Then
            resolve_user_department = resolve_dept_against_AD(userid)
        ElseIf userid.Length <= 8 Then
            resolve_user_department = resolve_dept_against_ESTAB(userid)
        Else
            resolve_user_department = String.Empty
        End If
        Return resolve_user_department
    End Function

    Function resolve_dept_against_ESTAB(ByVal userid As String) As String
        Dim dt As DataTable
        dt = HR_DataTableAdapter.GetUserDepartCode(userid)
        If dt.Rows.Count > 0 Then
            resolve_dept_against_ESTAB = dt.Rows(0).Item("SNAME").ToString
        Else
            resolve_dept_against_ESTAB = ""
        End If
        dt = Nothing
    End Function

    Function resolve_user_against_VIP_USERS(ByVal userid As String) As String
        Dim dt As DataTable
        dt = Me.HR_DataTableAdapter.GetUserDepartCode(userid)
        If dt.Rows.Count > 0 Then
            resolve_user_against_VIP_USERS = dt.Rows(0).Item("SNAME").ToString
        Else
            resolve_user_against_VIP_USERS = ""
        End If
        dt = Nothing
    End Function

    Function resolve_dept_against_AD(ByVal userid As String) As String
        resolve_dept_against_AD = Get_Department(userid)
    End Function

    Function resolve_app_level(ByVal code As Integer) As String
        If code = 1 Then
            resolve_app_level = "RSA"
        ElseIf code = 2 Then
            resolve_app_level = "National"
        ElseIf code = 3 Then
            resolve_app_level = "All Provinces"
        ElseIf code = 4 Then
            resolve_app_level = "Own Province"
        ElseIf code = 5 Then
            resolve_app_level = "Own Department"
        ElseIf code = 6 Then
            resolve_app_level = "Assigned Departments"
        ElseIf code = 7 Then
            resolve_app_level = "Other"
        Else
            resolve_app_level = String.Empty
        End If
        Return resolve_app_level.ToString
    End Function

    Private Sub dtpAccountExpireDate_CloseUp(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not Me.txtPersalNumber.Text = "" Then
            modADS.Do_AccountExpirationDate(txtPersalNumber.Text, dtpAccountExpireDate.ToString)
        End If
    End Sub

    Private Sub dtpAccountExpireDate_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If dtpAccountExpireDate.Checked = False Then
            modADS.Do_AccountNeverExpire(txtPersalNumber.Text)
            dtpAccountExpireDate.Value = modADS.Get_AccountExpireDate(txtPersalNumber.Text)
            dtpAccountExpireDate.Checked = False
        End If
    End Sub

    Private Sub AmmendVulindlelaExclusionListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AmmendVulindlelaExclusionListToolStripMenuItem.Click

        frmVulExceptions.Show()

    End Sub

    Private Sub searchEstablishment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles searchEstablishment.Click


        Dim s As String
        Dim dt As New DataTable
        Dim DEPTCODE As String

        If Me.txtPersalNumber.Text = "" Then
        Else

            Try

                dt = Me.HR_DataTableAdapter.GetData(Me.txtPersalNumber.Text)
                If dt.Rows.Count > 0 Then
                    s = ""
                    s += "Department : " & dt.Rows(0).Item("SNAME").ToString.Trim & "" & ControlChars.CrLf
                    s += "Persal No : " & dt.Rows(0).Item("PERSALNR").ToString.Trim & "" & ControlChars.CrLf
                    s += "Person : " & dt.Rows(0).Item("SUR_INI").ToString.Trim & "" & ControlChars.CrLf
                    s += "Nat / Prov : " & dt.Rows(0).Item("PROVDESC").ToString.Trim & "" & ControlChars.CrLf
                    s += "Dept Desc : " & dt.Rows(0).Item("DEPTDESC").ToString.Trim & "" & ControlChars.CrLf
                    s += "Rank : " & dt.Rows(0).Item("RANKDESC").ToString.Trim & "" & ControlChars.CrLf
                    s += "Job Title : " & dt.Rows(0).Item("JOBTITLE").ToString.Trim & "" & ControlChars.CrLf
                    s += "Paypoint : " & dt.Rows(0).Item("PAYPOINT").ToString.Trim & "" & ControlChars.CrLf
                    s += "District : " & dt.Rows(0).Item("PAYDIST").ToString.Trim & "" & ControlChars.CrLf
                    s += "Appointment Type : " & dt.Rows(0).Item("APPTNAT").ToString.Trim & "" & ControlChars.CrLf
                    's += "Salary Level :  17 " '& dt.Rows(0).Item("APPTNAT").ToString.Trim & "" & ControlChars.CrLf

                    DEPTCODE = ""
                    set_departments(dt.Rows(0).Item("SNAME").ToString.Trim, sender, e)
                    MsgBox(s, MsgBoxStyle.OkOnly, "System Message")
                Else
                    MsgBox("Cannot find this person on Establishment", MsgBoxStyle.OkOnly, "System Message")
                End If


            Catch ex As Exception
                MsgBox("Cannot find this person on Establishment", MsgBoxStyle.OkOnly, "System Message")
            End Try

        End If
        Me.Cursor = Cursors.Arrow

    End Sub

    Private Sub ToolStripMenuItem71_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem71.Click
        Me.SuspendLayout()
        btnActiveDirectory_Click(sender, e)
        Me.ResumeLayout()
    End Sub       '' btnActiveDirectory_Click

    Private Sub ToolStripMenuItem56_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem56.Click
        Me.SuspendLayout()
        ReferToNTFinancialFunctionsToolStripMenuItem_Click(sender, e)
        Me.ResumeLayout()
    End Sub       '' ReferToNTFinancialFunctionsToolStripMenuItem_Click

    Private Sub ExportActiveDirectoryDatabase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportActiveDirectoryDatabase.Click

        Dim mstr As String
        Dim tbl As New System.Data.DataTable

        tbl = Me.AD_SNAPSHOT_ALLTableAdapter1.GetDataBy

        If tbl.Rows.Count > 0 Then
            mstr = AppPath() & "AD_Snapshot.csv"
            modExportModule.ExportCSV(tbl, mstr)
            If File.Exists(mstr) Then
                Process.Start(mstr)
            End If

        End If

        Me.Cursor = Cursors.Arrow

    End Sub

    Private Sub ToolStripMenuItem46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem46.Click
        End
    End Sub       '' End the Program

    Private Sub NotifyUserNewAccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotifyUserNewAccount.Click

        If txtPersalNumber.Text.Trim = "" Then
            Exit Sub
        End If
        NotifyUserAccountUpdatedToolStripMenuItem_Click(sender, e)

    End Sub       '' txtPersalNumber.Text.Trim = "" Exit Sub

    Private Sub NotifyUserAccountUpdated_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotifyUserAccountUpdated.Click

        NotifyUserAccountUpdatedToolStripMenuItem_Click(sender, e)

    End Sub       '' NotifyUserAccountUpdatedToolStripMenuItem_Click

    Private Sub NotifyUserAccountReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotifyUserAccountReset.Click

        NotifyUserAccountResetToolStripMenuItem_Click(sender, e)

    End Sub       '' NotifyUserAccountResetToolStripMenuItem_Click

    Private Sub NotifyUserRequestRemovedoffQueue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotifyUserRequestRemovedoffQueue.Click

        NotifyUserRequestRemovedOffQueueToolStripMenuItem_Click(sender, e)

    End Sub       '' NotifyUserRequestRemovedOffQueueToolStripMenuItem_Click

    Private Sub EMailToVerifyAgainstEstablishment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EMailToVerifyAgainstEstablishment.Click

        EMailToVerifyAgainstEstablishmentToolStripMenuItem1_Click(sender, e)

    End Sub       '' EMailToVerifyAgainstEstablishmentToolStripMenuItem1_Click


    Private Sub ToolStripTextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPersalNumber.KeyPress

        txtPersalNumber_KeyPress(sender, e)

    End Sub      '' txtPersalNumber_KeyPress

    Private Sub searchByRequest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles searchByRequest.Click

        btnOpenRequests_Click(sender, e)

    End Sub       '' ByRequestToolStripMenuItem1_Click

    Private Sub ToolStripMenuItem73_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles searchBySurname.Click

        frmRemedyBySurname.Show()

    End Sub       '' BySurnameToolStripMenuItem1_Click

    Private Sub searchByEstablishment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'frmEstablishment.Show()

    End Sub       '' ByEstablishmentToolStripMenuItem_Click

    Private Sub tsDeptDiffers1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsDeptDiffers1.Click



        If frmEnvironment.ActiveMdiChild.Text.Contains("PRD") Then

            frmDeptDiffers.Department_DiffersTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
            frmDeptDiffers.Text = "Departments that are different on Establishment - PRD"
            frmDeptDiffers.ShowDialog()
            frmDeptDiffers.Focus()
        Else
            frmDeptDiffers.Department_DiffersTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
            frmDeptDiffers.Text = "Departments that are different on Establishment - QA"
            frmDeptDiffers.ShowDialog()
            frmDeptDiffers.Focus()
        End If

    End Sub

    'Private Sub tsBtnNewUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsBtnNewUser0.Click
    '    tsBtnNewUser_Click(sender, e)
    'End Sub             '' tsBtnNewUser_Click

    'Private Sub tsBtnUpdateUser0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsBtnUpdateUser0.Click
    '    tsBtnUpdateUser_Click(sender, e)
    'End Sub          '' tsBtnUpdateUser_Click

    'Private Sub tsBtnDeleteUser0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsBtnDeleteUser0.Click
    '    tsBtnDeleteUser_Click(sender, e)
    'End Sub          '' tsBtnDeleteUser_Click

    Private Sub ToolStripMenuItem82_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenQAWebToolStripMenuItem.Click

        OpenQAWebToolStripMenuItem1_Click_1(sender, e)

    End Sub       '' OpenQAWebToolStripMenuItem1_Click_1
    '''''444444444444444444444444444
    Private Sub ToolStripMenuItem83_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenPRDWebToolStripMenuItem.Click
        OpenPRDWebToolStripMenuItem1_Click_1(sender, e)
    End Sub       '' OpenPRDWebToolStripMenuItem1_Click_1

    Private Sub tsBtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsBtnExit.Click
        Me.Parent.Dispose()
        End
    End Sub         '' ToolStripButton1_Click

    Private Sub ToolStripMenuItem59_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem59.Click
        MonthEndStats_Click(sender, e)
    End Sub       '' MonthEndStats_Click

    Private Sub ToolStripMenuItem60_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem60.Click
        UsersNotOnEstablishmentToolStripMenuItem_Click(sender, e)
    End Sub       '' UsersNotOnEstablishmentToolStripMenuItem_Click

    Private Sub ToolStripMenuItem62_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem62.Click
        QAWebToolStripMenuItem_Click(sender, e)
    End Sub       '' QAWebToolStripMenuItem_Click

    Private Sub ToolStripMenuItem63_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem63.Click
        PRDWebToolStripMenuItem_Click(sender, e)
    End Sub       '' PRDWebToolStripMenuItem_Click

    Private Sub ToolStripMenuItem65_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem65.Click
        ByRequestToolStripMenuItem_Click(sender, e)
    End Sub       '' ByRequestToolStripMenuItem_Click

    Private Sub ToolStripMenuItem66_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem66.Click
        BySurnameToolStripMenuItem_Click(sender, e)
    End Sub       '' BySurnameToolStripMenuItem_Click

    Private Sub ToolStripMenuItem68_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem68.Click
        SendCustomerNotificationMailsToolStripMenuItem_Click(sender, e)
    End Sub       '' SendCustomerNotificationMailsToolStripMenuItem_Click

    Private Sub ToolStripMenuItem69_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem69.Click
        RemoveUserFromNewUserListToolStripMenuItem_Click(sender, e)
    End Sub       '' RemoveUserFromNewUserListToolStripMenuItem_Click

    Private Sub AmendTheVulindlelaExceptionListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AmendTheVulindlelaExceptionListToolStripMenuItem.Click
        frmVulExceptions.ShowDialog()

        If ADAdminDotNet.frmEnvironment.ActiveMdiChild.Text = "Active Directory Console - QA" Then

            My.MySettings.Default("AdsConnectionString") = My.MySettings.Default.Default("ADSQAConnectionString2014")
            frmVulExceptions.Text = "Vulindlela Internal Exception List - QA"
            frmVulExceptions.ShowDialog()
            frmVulExceptions.Focus()

        End If

        If ADAdminDotNet.frmEnvironment.ActiveMdiChild.Text = "Active Directory Console - PRD" Then

            My.MySettings.Default("AdsConnectionString") = My.MySettings.Default.Default("ADSPRDConnectionString2014")
            frmVulExceptions.Text = "Vulindlela Internal Exception List - PRD"
            frmVulExceptions.ShowDialog()
            frmVulExceptions.Focus()

        End If



    End Sub

    Private Sub tsNTFinFunc_Approval_Request_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsNTFinFunc_Approval_Request.Click
        ReferToNTFinancialFunctionsToolStripMenuItem_Click(sender, e)
    End Sub       '' EMailAPPROVALFORMCFOApprovalRequestToolStripMenuItem_Click

    Public Function CheckEstablishment(ByVal sender As System.Object, ByVal e As System.EventArgs) As String

        'Me.Cursor = Cursors.WaitCursor
        Dim s As String = ""
        Dim dt As New DataTable

        If Me.txtPersalNumber.Text = "" Then
        Else
            dt = Me.HR_DataTableAdapter.GetData(Me.txtPersalNumber.Text)
            If dt.Rows.Count > 0 Then
                s = "<table border='1'><tr>"
                s += "<tr><td><font face='Verdana' size='2'>Department : </font></td><td><font face='Verdana' size='2' color='#0000cc'>" & dt.Rows(0).Item("SNAME").ToString.Trim & "</font></td></tr>"
                s += "<tr><td><font face='Verdana' size='2'>Persal No : </font></td><td><font face='Verdana' size='2' color='#0000cc'>" & dt.Rows(0).Item("PERSALNR").ToString.Trim & "</font></td></tr>"
                s += "<tr><td><font face='Verdana' size='2'>Person : </font></td><td><font face='Verdana' size='2' color='#0000cc'>" & dt.Rows(0).Item("SUR_INI").ToString.Trim & "</font></td></tr>"
                s += "<tr><td><font face='Verdana' size='2'>Nat / Prov : </font></td><td><font face='Verdana' size='2' color='#0000cc'>" & dt.Rows(0).Item("PROVDESC").ToString.Trim & "</font></td></tr>"
                s += "<tr><td><font face='Verdana' size='2'>Dept Desc : </font></td><td><font face='Verdana' size='2' color='#0000cc'>" & dt.Rows(0).Item("DEPTDESC").ToString.Trim & "</font></td></tr>"
                s += "<tr><td><font face='Verdana' size='2'>Rank : </font></td><td><font face='Verdana' size='2' color='#0000cc'>" & dt.Rows(0).Item("RANKDESC").ToString.Trim & "</font></td></tr>"
                s += "<tr><td><font face='Verdana' size='2'>Job Title : </font></td><td><font face='Verdana' size='2' color='#0000cc'>" & dt.Rows(0).Item("JOBTITLE").ToString.Trim & "</font></td></tr>"
                s += "<tr><td><font face='Verdana' size='2'>Paypoint : </font></td><td><font face='Verdana' size='2' color='#0000cc'>" & dt.Rows(0).Item("PAYPOINT").ToString.Trim & "</font></td></tr>"
                s += "<tr><td><font face='Verdana' size='2'>District : </font></td><td><font face='Verdana' size='2' color='#0000cc'>" & dt.Rows(0).Item("PAYDIST").ToString.Trim & "</font></td></tr>"
                s += "<tr><td><font face='Verdana' size='2'>Appointment Type : </font></td><td><font face='Verdana' size='2' color='#0000cc'>" & dt.Rows(0).Item("APPTNAT").ToString.Trim & "</font></td></tr>"
                s += "</table>"
            Else
                s = "No record found on Establishment"
            End If

        End If

        Me.Cursor = Cursors.Arrow

        Return s

    End Function

    Public Function IsOnEstablishment(ByVal PersalNumber As String) As Boolean

        Dim dt As New DataTable

        If String.IsNullOrEmpty(PersalNumber) Then
            Return False
        Else
            If (PersalNumber.Length = 8) Then

                dt = Me.HR_DataTableAdapter.GetData(PersalNumber)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            End If
        End If

    End Function

    Private Sub chkEnabled_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'WriteAdminLogEntry("Account Enabled")
        If frmEnvironment.ChildFormPRD.Visible Then
            frmEnvironment.ChildFormPRD.ADCONSOLELOGTableAdapter.InsertIntoADAdminConsoleLog2( _
                    frmEnvironment.ChildFormPRD.tsLabelVulname.Text, Get_ValidPersalNumber( _
                    frmEnvironment.ChildFormPRD.txtPersalNumber.Text.Trim), "Account Enabled", False)
            frmEnvironment.ChildFormPRD.Refresh_Log()
        Else
            frmEnvironment.childformQA.ADCONSOLELOGTableAdapter.InsertIntoADAdminConsoleLog2( _
                    frmEnvironment.childformQA.tsLabelVulname.Text, Get_ValidPersalNumber( _
                    frmEnvironment.childformQA.txtPersalNumber.Text.Trim), "Account Enabled", False)
            frmEnvironment.childformQA.Refresh_Log()
        End If

    End Sub

    Public Sub WriteAdminLogEntry(ByVal EntryString As String)

        'If frmEnvironment.ChildFormPRD.Visible Then
        '    frmEnvironment.ChildFormPRD.ADCONSOLELOGTableAdapter.InsertIntoADAdminConsoleLog2( _
        '            frmEnvironment.ChildFormPRD.tsLabelVulname.Text, Get_ValidPersalNumber( _
        '            frmEnvironment.ChildFormPRD.txtPersalNumber.Text.Trim), EntryString, False)
        '    frmEnvironment.ChildFormPRD.Refresh_Log()
        'Else
        '    frmEnvironment.childformQA.ADCONSOLELOGTableAdapter.e( _
        '            frmEnvironment.childformQA.tsLabelVulname.Text, Get_ValidPersalNumber( _
        '            frmEnvironment.childformQA.txtPersalNumber.Text.Trim), EntryString, False)
        '    frmEnvironment.childformQA.Refresh_Log()
        'End If



        If frmEnvironment.ChildFormPRD.Visible Then
            frmEnvironment.ChildFormPRD.ADCONSOLELOGTableAdapter.InsertIntoADAdminConsoleLog2( _
                    frmEnvironment.ChildFormPRD.tsLabelVulname.Text, Get_ValidPersalNumber( _
                    frmEnvironment.ChildFormPRD.txtPersalNumber.Text.Trim), EntryString, False)
            frmEnvironment.ChildFormPRD.Refresh_Log()
        Else
            frmEnvironment.childformQA.ADCONSOLELOGTableAdapter.InsertIntoADAdminConsoleLog2( _
                    frmEnvironment.childformQA.tsLabelVulname.Text, Get_ValidPersalNumber( _
                    frmEnvironment.childformQA.txtPersalNumber.Text.Trim), EntryString, False)
            frmEnvironment.childformQA.Refresh_Log()
        End If

    End Sub

    Public Sub SendEMailFORMCFOApprovalToolStripMenuItem_Click(ByVal sender As System.Object, _
                                                            ByVal e As System.EventArgs) _
                                                            Handles SendEMailFORMCFOApprovalToolStripMenuItem.Click

        If txtPersalNumber.Text.Trim = "" Then
            MsgBox("Persal Number is empty", MsgBoxStyle.OkOnly, "Missing Information")
            Exit Sub
        End If

        If Me.txtRightsRequested.Text.Trim = "" Then
            MsgBox("Request Information is empty", MsgBoxStyle.OkOnly, "Missing Information")
            Exit Sub
        End If

        Dim i As Integer
        Dim a() As String
        Dim cfo() As String
        Dim tbl1 As DataTable
        Dim subject As String = ""
        Dim accessnow As String = ""
        Dim returnaddress As String = ""
        Dim jobdescription As String = ""
        Dim cfoemail As New Collection
        Dim col As New Microsoft.VisualBasic.Collection
        Dim colTO As New Microsoft.VisualBasic.Collection
        Dim colCC As New Microsoft.VisualBasic.Collection
        Dim n_FIN As String = "", n_HR As String = "", n_LOGIS As String = "", n_PERSALPDF As String = "", n_HR_OVERSIGHT As String = "", n_Level As String = ""

        If chkProfileCategories.CheckedItems.Count > 0 Then

            n_FIN = "" : n_HR = "" : n_LOGIS = "" : n_PERSALPDF = "" : n_HR_OVERSIGHT = ""

            If rbAccountLevel2.Checked Then : n_Level = rbAccountLevel2.Text : End If
            If rbAccountLevel3.Checked Then : n_Level = rbAccountLevel3.Text : End If
            If rbAccountLevel4.Checked Then : n_Level = rbAccountLevel4.Text : End If
            If rbAccountLevel5.Checked Then : n_Level = rbAccountLevel5.Text : End If
            If rbAccountLevel6.Checked Then : n_Level = rbAccountLevel6.Text : End If
            If rbAccountLevel7.Checked Then : n_Level = rbAccountLevel7.Text : End If

            n_HR = "None" : n_FIN = "None" : n_LOGIS = "None" : n_PERSALPDF = "None" : n_HR_OVERSIGHT = "None"

            For i = 0 To chkProfileCategories.CheckedItems.Count - 1

                If chkProfileCategories.CheckedItems(i).Text = "LOGIS" Then : n_LOGIS = n_Level.Trim : End If
                If chkProfileCategories.CheckedItems(i).Text = "FINANCIALS" Then : n_FIN = n_Level.Trim : End If
                If chkProfileCategories.CheckedItems(i).Text = "HR" Then : n_HR = n_Level.Trim : End If
                If chkProfileCategories.CheckedItems(i).Text = "PERSALPDF" Then : n_PERSALPDF = n_Level.Trim : End If
                If chkProfileCategories.CheckedItems(i).Text = "HR_OVERSIGHT" Then : n_HR_OVERSIGHT = n_Level.Trim : End If

            Next

        Else

            n_HR = "None" : n_FIN = "None" : n_LOGIS = "None" : n_PERSALPDF = "None" : n_HR_OVERSIGHT = "None"

        End If



        Me.HRDataSet.Clear()
        Me.HRDataSet.EnforceConstraints = False
        Dim tbl_job As DataTable

        Try
            tbl_job = Me.HR_DataTableAdapter.GetData(Me.txtPersalNumber.Text.Trim)

        Catch ex As Exception

        End Try
        '  sss()


        If tbl_job.Rows.Count > 0 Then
            jobdescription = LTrim(RTrim(tbl_job.Rows(0).Item("RANKDESC").ToString() & "-" & tbl_job.Rows(0).Item("JOBTITLE").ToString() & "(" & tbl_job.Rows(0).Item("APPTNAT").ToString() & ")"))
        Else
            jobdescription = "Not found"
        End If





        accessnow = ""
        accessnow = "<table border='1'>" & _
                             "<tr><td bgcolor='gainsboro'><font face='verdana' size='2' color='black'><b>Application</b></font></td><td bgcolor='gainsboro'><font face='verdana' size='2' color='black'><b>Access currently</font></b></td></tr>" & _
                             "<tr><td><font face='verdana' size='2'>Financial applications</font></td><td><font face='verdana' size='2' color='blue'>" & n_FIN.Trim & "</font></td></tr>" & _
                             "<tr><td><font face='verdana' size='2'>Supply Chain applications</font></td><td><font face='verdana' size='2' color='blue'>" & n_LOGIS.Trim & "</font></td></tr>" & _
                             "<tr><td><font face='verdana' size='2'>Human Resources applications</font></td><td><font face='verdana' size='2' color='blue'>" & n_HR.Trim & "</font></td></tr>" & _
                             "<tr><td><font face='verdana' size='2'>HR Oversight applications</font></td><td><font face='verdana' size='2' color='blue'>" & n_HR_OVERSIGHT.Trim & "</font></td></tr>" & _
                             "<tr><td><font face='verdana' size='2'>Persal PDF applications</font></td><td><font face='verdana' size='2' color='blue'>" & n_PERSALPDF.Trim & "</font></td></tr>" & _
                     "</table></font>"

        tbl1 = Me.ta_Vulindlela_Email.GetData("CFO Approval Request2")

        If tbl1.Rows.Count > 0 Then
            subject = tbl1.Rows(0).Item("SUBJECT").ToString
            returnaddress = tbl1.Rows(0).Item("RETURN_ADDRESS").ToString
            a = Split(returnaddress, ";")
            If a(0) <> "" Then
                For i = 0 To UBound(a)
                    colTO.Add(a(i))
                Next
            End If
        End If
        a = Split(tbl1.Rows(0).Item("CC_ADDRESS").ToString, ";")
        If a(0) <> "" Then
            For i = 0 To UBound(a)
                colCC.Add(a(i))
            Next
        End If

        cfo = Split(look_up_CFO_for_this_person, ",")
        If cfo.Length < 2 Then
            Exit Sub
        End If
        col.Add("persal_no~~" & Me.txtPersalNumber.Text.Trim & "")
        col.Add("title~~" & Me.txtTitleTextBox.Text.Trim & "")
        col.Add("telephone~~" & Me.txtTelephoneTextBox.Text.Trim & "")
        col.Add("cellphone~~" & Me.txtCellphoneTextBox.Text.Trim & "")
        col.Add("firstnames~~" & Me.txtFirst_NameTextBox.Text.Trim & "")
        col.Add("lastname~~" & Me.txtLast_NameTextBox.Text.Trim & "")
        col.Add("deptname~~" & Me.txtDepartment_NameTextBox.Text.Trim & "")
        col.Add("depttype~~" & Me.txtDepartment_TypeTextBox.Text.Trim & "")
        col.Add("rank~~" & Me.txtRankTextBox.Text.Trim & "")
        col.Add("establishment~~" & CheckEstablishment(sender, e))
        col.Add("remedy_req~~" & Me.txtRightsRequested.Text.Trim & "")
        col.Add("requestno~~" & Me.txtRemedyRequestNo.Text.Trim & "")
        col.Add("r~~" & Me.txtRemedyRequestNo.Text.Trim & "")
        col.Add("accessnow~~" & accessnow.Trim & "")
        col.Add("cfoname~~" & ", " & cfo(3).Trim & " " & cfo(2).Trim & " (" & cfo(1).Trim & ")")
        col.Add("u~~" & cfo(1).Trim & "")
        col.Add("p~~" & Replace(Me.txtPersalNumber.Text.Trim.ToUpper, "P", "").Trim)

        ' Enter the CFO persalnumber and the request number into the database to 
        ' ensure that when it is sent back an entry can be found in the table
        ' for control purposes.

        cfoemail.Add(cfo(0))
        Dim requestno As String = ""
        requestno = Me.txtRemedyRequestNo.Text.Trim & ""

        If String.IsNullOrEmpty(requestno) Then
            MsgBox("You are attempting to send a CFO Approval Request BUT" & vbCrLf & _
                   " are attempting to do this from a form other than" & vbCrLf & _
                   " the Open Remedy Request Screen...", MsgBoxStyle.OkOnly, "System Message")
            Exit Sub
        Else
            Insert_Requestno_Into_Rules_Flags(requestno) ' Only Insert the flag so that this entry show in list
            ParseFile_Email("CFO Approval Request2.htt", col, cfoemail, colCC, returnaddress) ' Only Insert the flag so that it show in list
            Update_Rules_Flags_With_CFOID(requestno, cfo(1).Trim & "") ' Only Insert the flag so that it show in list

            If frmEnvironment.ChildFormPRD.Visible Then
                Me.ADCONSOLELOGTableAdapter.InsertIntoADAdminConsoleLog2(frmEnvironment.ChildFormPRD.tsLabelVulname.Text, _
                                                                 Get_ValidPersalNumber(txtPersalNumber.Text.Trim), _
                                                                 "CFO Approval Request2", False)
                frmEnvironment.ChildFormPRD.Refresh_Log()
            Else
                Me.ADCONSOLELOGTableAdapter.InsertIntoADAdminConsoleLog2(frmEnvironment.childformQA.tsLabelVulname.Text, _
                                                                 Get_ValidPersalNumber(txtPersalNumber.Text.Trim), _
                                                               "CFO Approval Request2", False)
                frmEnvironment.childformQA.Refresh_Log()
            End If

            If Not String.IsNullOrEmpty(Me.txtRemedyRequestNo.Text) Then
                Rules_Flags_Valid_Insert_Requestno(Me.txtRemedyRequestNo.Text)
            Else
                MsgBox("SendEMailFORMCFOApprovalToolStripMenuItem_Click", MsgBoxStyle.OkOnly, "Me.txtRemedyRequestNo.Text seems to be empty and will result in a mismatch")
                Exit Sub
            End If

            col = Nothing
            colCC = Nothing
            colTO = Nothing

            Me.Cursor = Cursors.Arrow

            MsgBox("EMail Sent", MsgBoxStyle.OkOnly, "System Message")
        End If

    End Sub  '' ParseFile_Email("CFO Approval Request2.htt"

    Private Sub ReferToNTFinancialFunctionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReferToNTFinancialFunctionsToolStripMenuItem.Click, ReferToNTFinancialFunctionsToolStripMenuItem1.Click

        'Me.Cursor = Cursors.WaitCursor

        If txtPersalNumber.Text.Trim = "" Then
            MsgBox("Persal Number is empty", MsgBoxStyle.OkOnly, "Missing Information")
            Exit Sub
        End If

        If Me.txtRightsRequested.Text.Trim = "" Then
            MsgBox("Request Information is empty", MsgBoxStyle.OkOnly, "Missing Information")
            Exit Sub
        End If

        Dim i As Integer
        Dim a() As String
        Dim subject As String = ""
        Dim tbl1 As DataTable
        Dim returnaddress As String = ""
        Dim col As New Microsoft.VisualBasic.Collection
        Dim colTO As New Microsoft.VisualBasic.Collection
        Dim colCC As New Microsoft.VisualBasic.Collection
        Dim accessnow As String
        Dim jobdescription As String
        Dim n_FIN As String = "", n_HR As String = "", n_LOGIS As String = "", n_PERSALPDF As String = "", n_HR_OVERSIGHT As String = "", n_Level As String = ""

        If chkProfileCategories.CheckedItems.Count > 0 Then

            n_FIN = "" : n_HR = "" : n_LOGIS = "" : n_PERSALPDF = "" : n_HR_OVERSIGHT = ""
            If rbAccountLevel2.Checked Then : n_Level = rbAccountLevel2.Text : End If
            If rbAccountLevel3.Checked Then : n_Level = rbAccountLevel3.Text : End If
            If rbAccountLevel4.Checked Then : n_Level = rbAccountLevel4.Text : End If
            If rbAccountLevel5.Checked Then : n_Level = rbAccountLevel5.Text : End If
            If rbAccountLevel6.Checked Then : n_Level = rbAccountLevel6.Text : End If
            If rbAccountLevel7.Checked Then : n_Level = rbAccountLevel7.Text : End If

            n_FIN = "None" : n_HR = "None" : n_LOGIS = "None" : n_PERSALPDF = "None" : n_HR_OVERSIGHT = "None"
            For i = 0 To chkProfileCategories.CheckedItems.Count - 1
                If chkProfileCategories.CheckedItems(i).Text = "LOGIS" Then : n_LOGIS = n_Level.Trim : End If
                If chkProfileCategories.CheckedItems(i).Text = "FINANCIALS" Then : n_FIN = n_Level.Trim : End If
                If chkProfileCategories.CheckedItems(i).Text = "HR" Then : n_HR = n_Level.Trim : End If
                If chkProfileCategories.CheckedItems(i).Text = "PERSALPDF" Then : n_PERSALPDF = n_Level.Trim : End If
                If chkProfileCategories.CheckedItems(i).Text = "HR_OVERSIGHT" Then : n_HR_OVERSIGHT = n_Level.Trim : End If
            Next

        Else
            n_FIN = "None" : n_HR = "None" : n_LOGIS = "None" : n_PERSALPDF = "None" : n_HR_OVERSIGHT = "None"
        End If

        Dim tbl_job As DataTable = Me.HR_DataTableAdapter.GetDataBy_jobdescription(Me.txtPersalNumber.Text.Trim)

        If MsgBox("Do want to test the NT Approvals Functions?", MsgBoxStyle.YesNo, "Testing Mode") = MsgBoxResult.Yes Then
            If tbl_job.Rows.Count > 0 Then
                jobdescription = tbl_job.Rows(0).Item("jobdescription").ToString()
            Else
                jobdescription = "Not found"
            End If
            accessnow = ""
            accessnow = "<table border='1'>" & _
                                 "<tr><td bgcolor='gainsboro'><font face='verdana' size='2' color='black'><b>Application</b></font></td><td bgcolor='gainsboro'><font face='verdana' size='2' color='black'><b>Access currently</font></b></td></tr>" & _
                                 "<tr><td><font face='verdana' size='2'>Financial applications</font></td><td><font face='verdana' size='2' color='blue'>" & n_FIN.Trim & "</font></td></tr>" & _
                                 "<tr><td><font face='verdana' size='2'>Supply Chain applications</font></td><td><font face='verdana' size='2' color='blue'>" & n_LOGIS.Trim & "</font></td></tr>" & _
                                 "<tr><td><font face='verdana' size='2'>Human Resources applications</font></td><td><font face='verdana' size='2' color='blue'>" & n_HR.Trim & "</font></td></tr>" & _
                                 "<tr><td><font face='verdana' size='2'>HR Oversight applications</font></td><td><font face='verdana' size='2' color='blue'>" & n_HR_OVERSIGHT.Trim & "</font></td></tr>" & _
                                 "<tr><td><font face='verdana' size='2'>Persal PDF applications</font></td><td><font face='verdana' size='2' color='blue'>" & n_PERSALPDF.Trim & "</font></td></tr>" & _
                             "</table></font>"

            tbl1 = Me.ta_Vulindlela_Email.GetData("Refer To NT Financial Functions")

            If tbl1.Rows.Count > 0 Then
                subject = tbl1.Rows(0).Item("SUBJECT").ToString
                returnaddress = tbl1.Rows(0).Item("RETURN_ADDRESS").ToString
                a = Split(returnaddress, ";")
                If a(0) <> "" Then
                    For i = 0 To UBound(a)
                        colTO.Add(a(i))
                    Next
                End If
            End If
            a = Split(tbl1.Rows(0).Item("CC_ADDRESS").ToString, ";")
            If a(0) <> "" Then
                For i = 0 To UBound(a)
                    colCC.Add(a(i))
                Next
            End If

            col.Add("persal_no~~P13038010")
            col.Add("title~~Mr")
            col.Add("telephone~~012-6574316")
            col.Add("cellphone~~082 781 0415")
            col.Add("firstnames~~Johan")
            col.Add("lastname~~Vermeulen")
            col.Add("deptname~~" & Me.txtDepartment_NameTextBox.Text.Trim & "")
            col.Add("depttype~~" & Me.txtDepartment_TypeTextBox.Text.Trim & "")
            col.Add("rank~~Resigned")
            col.Add("establishment~~None")
            col.Add("remedy_req~~testing the new NT Approval Functions" & Me.txtRightsRequested.Text.Trim & "")
            col.Add("requestno~~000986094" & Me.txtRightsRequested.Text.Trim & "")
            col.Add("accessnow~~" & accessnow.Trim & "")

            ParseFile_Email("Refer To NT Financial Functions.htt", col, colTO, colCC, returnaddress)

            WriteAdminLogEntry("Refer To NT Financial Functions")

            col = Nothing

            Me.Cursor = Cursors.Arrow

            MsgBox("EMail Sent", MsgBoxStyle.OkOnly, "System Message")

        Else

            If tbl_job.Rows.Count > 0 Then
                jobdescription = tbl_job.Rows(0).Item("jobdescription").ToString()
            Else
                jobdescription = "Not found"
            End If
            accessnow = ""
            accessnow = "<table border='1'>" & _
                                 "<tr><td bgcolor='gainsboro'><font face='verdana' size='2' color='black'><b>Application</b></font></td><td bgcolor='gainsboro'><font face='verdana' size='2' color='black'><b>Access currently</font></b></td></tr>" & _
                                 "<tr><td><font face='verdana' size='2'>Financial applications</font></td><td><font face='verdana' size='2' color='blue'>" & n_FIN.Trim & "</font></td></tr>" & _
                                 "<tr><td><font face='verdana' size='2'>Supply Chain applications</font></td><td><font face='verdana' size='2' color='blue'>" & n_LOGIS.Trim & "</font></td></tr>" & _
                                 "<tr><td><font face='verdana' size='2'>Human Resources applications</font></td><td><font face='verdana' size='2' color='blue'>" & n_HR.Trim & "</font></td></tr>" & _
                                 "<tr><td><font face='verdana' size='2'>HR Oversight applications</font></td><td><font face='verdana' size='2' color='blue'>" & n_HR_OVERSIGHT.Trim & "</font></td></tr>" & _
                                 "<tr><td><font face='verdana' size='2'>Persal PDF applications</font></td><td><font face='verdana' size='2' color='blue'>" & n_PERSALPDF.Trim & "</font></td></tr>" & _
                             "</table></font>"

            tbl1 = Me.ta_Vulindlela_Email.GetData("Refer To NT Financial Functions")

            If tbl1.Rows.Count > 0 Then
                subject = tbl1.Rows(0).Item("SUBJECT").ToString
                returnaddress = tbl1.Rows(0).Item("RETURN_ADDRESS").ToString
                a = Split(returnaddress, ";")
                If a(0) <> "" Then
                    For i = 0 To UBound(a)
                        colTO.Add(a(i))
                    Next
                End If
            End If
            a = Split(tbl1.Rows(0).Item("CC_ADDRESS").ToString, ";")
            If a(0) <> "" Then
                For i = 0 To UBound(a)
                    colCC.Add(a(i))
                Next
            End If

            col.Add("persal_no~~" & Me.txtPersalNumber.Text.Trim & "")
            col.Add("title~~" & Me.txtTitleTextBox.Text.Trim & "")
            col.Add("telephone~~" & Me.txtTelephoneTextBox.Text.Trim & "")
            col.Add("cellphone~~" & Me.txtCellphoneTextBox.Text.Trim & "")
            col.Add("firstnames~~" & Me.txtFirst_NameTextBox.Text.Trim & "")
            col.Add("lastname~~" & Me.txtLast_NameTextBox.Text.Trim & "")
            col.Add("deptname~~" & Me.txtDepartment_NameTextBox.Text.Trim & "")
            col.Add("depttype~~" & Me.txtDepartment_TypeTextBox.Text.Trim & "")
            col.Add("rank~~" & Me.txtRankTextBox.Text.Trim & "")
            col.Add("establishment~~" & CheckEstablishment(sender, e))
            col.Add("remedy_req~~" & Me.txtRightsRequested.Text.Trim & "")
            col.Add("requestno~~" & Me.txtRightsRequested.Text.Trim & "")
            col.Add("accessnow~~" & accessnow.Trim & "")

            ParseFile_Email("Refer To NT Financial Functions.htt", col, colTO, colCC, returnaddress)

            WriteAdminLogEntry("Refer To NT Financial Functions")

            col = Nothing

            Me.Cursor = Cursors.Arrow

            MsgBox("EMail Sent", MsgBoxStyle.OkOnly, "System Message")

        End If


    End Sub

    Private Sub SendEMailNoCFOLetterReceivedInTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SendEMailNoCFOLetterReceivedInTime.Click
        SendEMailNoCFOLetterReceivedInTimeToolStripMenuItem_Click(sender, e)
    End Sub       '' SendEMailNoCFOLetterReceivedInTimeToolStripMenuItem_Click

    Private Sub SendEMailRequestaCFOLetterFromClient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SendEMailRequestaCFOLetterFromClient.Click
        RequestACFOLetterToolStripMenuItem_Click(sender, e)
        'CFO_letter_received_Click(sender, e)
    End Sub       '' Request A CFO Letter ToolStripMenuItem

    Private Sub databasesCFOList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles databasesCFOList.Click

        If frmEnvironment.ActiveMdiChild.Text.Contains("PRD") Then

            frmCFOTable.CFOListTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
            frmCFOTable.Text = "Chief Financial Officers - PRD"
            frmCFOTable.ShowDialog()
            frmCFOTable.Focus()

        Else

            frmCFOTable.CFOListTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
            MySettings.Default("ARSystemConnectionString") = MySettings.Default("ARSystemConnectionString")
            frmCFOTable.Text = "Chief Financial Officers - QA"
            frmCFOTable.ShowDialog()
            frmCFOTable.Focus()

        End If

    End Sub

    Private Sub databasesVPNAdmins_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles databasesVPNAdmins.Click

        If frmEnvironment.ActiveMdiChild.Text.Contains("PRD") Then
            frmVPNadmins.Text = "VPN Admins - PRD"
            frmVPNadmins.VPN_AdminsTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
            Try
                If frmVPNadmins.Visible Then
                    frmVPNadmins.Focus()
                Else
                    frmVPNadmins.Show()
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly, "System Message")
            End Try
        Else
            frmVPNadmins.Text = "VPN Admins - QA"
            frmVPNadmins.VPN_AdminsTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
            Try
                If frmVPNadmins.Visible Then
                    frmVPNadmins.Focus()
                Else
                    frmVPNadmins.Show()
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly, "System Message")
            End Try
        End If

    End Sub

    Private Sub databasesVulindlelaController_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles databasesVulindlelaController.Click

        If frmEnvironment.ActiveMdiChild.Text.Contains("PRD") Then

            frmControllers.Ta_Vulindlela_Controllers.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
            frmControllers.Text = "Vulindlela  Controllers and CFO's - PRD"


            Try
                If frmControllers.Visible Then
                    frmConfigProblem.Focus()
                Else
                    frmConfigProblem.Show()
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly, "System Message")
            End Try


        Else
            frmControllers.Ta_Vulindlela_Controllers.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
            MySettings.Default("ARSystemConnectionString") = MySettings.Default("ARSystemConnectionString")
            frmControllers.Text = "Vulindlela  Controllers and CFO's - QA"


            Try
                If frmControllers.Visible Then
                    frmControllers.Focus()
                Else
                    frmControllers.Show()
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly, "System Message")
            End Try

        End If


    End Sub

    Private Sub databasesClientsWithConfigProblems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles databasesClientsWithConfigProblems.Click

        If frmEnvironment.ActiveMdiChild.Text.Contains("PRD") Then

            My.MySettings.Default("AdsConnectionString") = My.MySettings.Default.Default("ADSQAConnectionString2014")
            MySettings.Default("ARSystemConnectionString") = MySettings.Default("ARSystemConnectionString")
            frmConfigProblem.Text = "Config Problems Identified - QA"
            Try
                If frmControllers.Visible Then
                    frmConfigProblem.Focus()
                Else
                    frmConfigProblem.Show()
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly, "System Message")
            End Try

        Else

            frmConfigProblem.Config_ProblemTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
            frmConfigProblem.Text = "Config Problems Identified - QA"
            Try
                If frmControllers.Visible Then
                    frmConfigProblem.Focus()
                Else
                    frmConfigProblem.Show()
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly, "System Message")
            End Try

        End If

    End Sub

    Private Sub btnResetPwd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResetPwd.Click

        modADS.Do_EnableAccount(Me.txtPersalNumber.Text)
        modADS.Do_ResetPassword(Me.txtPersalNumber.Text)

        If (Get_IsAccountEnabled(Me.txtPersalNumber.Text) = True) Then
            chkEnabled.Checked = modADS.Get_IsAccountEnabled(Me.txtPersalNumber.Text)
            '  Me.dtpAccountExpireDate.Checked = False
        End If

        timerCOUNTS_Tick(sender, e)


        Dim persalnumber As String = Me.txtPersalNumber.Text

        'If persalnumber.Contains("T") Then
        '    persalnumber = persalnumber
        'Else
        '    persalnumber = ("P" + persalnumber).Trim
        'End If

        With frmEnvironment

            If .ChildFormPRD.Visible Then
                .ChildFormPRD.VIP_USERS_ResetPasswordTableAdapter.UpdateDoneTo2(Get_ValidUsername(persalnumber.Trim))
                .ChildFormPRD.ADCONSOLELOGTableAdapter.InsertIntoADAdminConsoleLog2( _
                .ChildFormPRD.tsLabelVulname.Text, Get_ValidPersalNumber( _
                .ChildFormPRD.txtPersalNumber.Text.Trim), "btnResetPWD_Click", False)
                .ChildFormPRD.Refresh_Log()
                .ChildFormPRD.ADCONSOLELOGDataGridView.Refresh()
            Else
                .childformQA.VIP_USERS_ResetPasswordTableAdapter.UpdateDoneTo2(persalnumber.Trim)
                .childformQA.ADCONSOLELOGTableAdapter.InsertIntoADAdminConsoleLog2( _
                .childformQA.tsLabelVulname.Text, Get_ValidPersalNumber( _
                .childformQA.txtPersalNumber.Text.Trim), "btnResetPWD_Click", False)
                .childformQA.Refresh_Log()
                .childformQA.ADCONSOLELOGDataGridView.Refresh()
            End If

            frmResetPassword.VIP_USERS_ResetPasswordDataGridView.Refresh()

        End With

        'Else
        'MsgBox("Client must log a request on Vulindlela first", MsgBoxStyle.YesNo, "System Message")
        'End If



        Me.Cursor = Cursors.Arrow


    End Sub

    Public Function create_ad_appl_group_collection2() As Microsoft.VisualBasic.Collection
        Dim col As New Microsoft.VisualBasic.Collection
        Dim i As Integer
        For i = 0 To Me.lwApplicationRoles.CheckedItems.Count - 1
            col.Add(Me.lwApplicationRoles.CheckedItems(i).SubItems(1).Text.Trim)
        Next
        Return col
        Me.Cursor = Cursors.Arrow
    End Function

    Private Sub btnExpireAccXdays_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExpireAccXdays.Click
        'Me.Cursor = Cursors.WaitCursor
        Dim i As Integer
        Dim sstr As String
        sstr = InputBox("Enter the number of days from today in which the account must expire!", "Expire Account In [X] Days", "30")
        If sstr <> "" Then
            i = CInt(sstr)

            Do_Expire_Account_In_X_Days(i, txtPersalNumber.Text)




            ' BUG FIX - JOHAN VERMEULEN 25/06/2008
            dtpAccountExpireDate.Value = modADS.Get_AccountExpireDate(Get_ValidUsername(txtPersalNumber.Text))
            If dtpAccountExpireDate.Value < #1/1/1970# Then
                dtpAccountExpireDate.Checked = False
            End If


        Else
        End If
        Me.Cursor = Cursors.Arrow

    End Sub

    Private Sub tsBtnNewUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsBtnNewUser.Click
        'Me.Cursor = Cursors.WaitCursor
        'BUG FIX - JOHAN VERMEULEN - 2008/06/25 Does create a proper profile



        Dim s As String
        Dim dt As New DataTable
        Dim DEPTCODE As String
        Dim Ids As String
        Dim persalnumber As String = Get_ValidUsername(txtPersalNumber.Text.Trim)

        If lwDepartments.CheckedItems.Count = 0 Then
            MsgBox("Please select a department first", MsgBoxStyle.OkOnly, "System Message")
        Else

            If Get_IsValidUser(persalnumber) Then

                Dim userDept As String = modADS.Get_Department(persalnumber)
                If userDept = Nothing Then

                    Do_DeleteUser(persalnumber)
                    ADCONSOLELOGTableAdapter.InsertIntoADAdminConsoleLog2(tsLabelVulname.Text, _
                                                                 Get_ValidPersalNumber(persalnumber), _
                                                                 "Deleted Bad Profile", False)
                    Do_CreateUser(persalnumber, _
                            StrConv(txtFirst_NameTextBox.Text.Trim & "", VbStrConv.ProperCase), _
                            StrConv(txtLast_NameTextBox.Text.Trim & "", VbStrConv.ProperCase), _
                            txtE_MailTextBox.Text.Trim.ToLower & "", _
                            lwDepartments.CheckedItems(0).SubItems(1).Text.Trim & "", _
                            DirectCast(IIf(String.IsNullOrEmpty(txtCellphoneTextBox.Text.ToString.Trim), txtTelephoneTextBox.Text.ToString.Trim & "", txtCellphoneTextBox.Text.ToString.Trim & ""), String), Me.txtCellphoneTextBox.Text, txtRankTextBox.Text.Trim & "")

                    Do_FrmButtons(False, True, True)
                End If
            Else
                '*johan
                Do_CreateUser(persalnumber, _
                        StrConv(txtFirst_NameTextBox.Text.Trim & "", VbStrConv.ProperCase), _
                        StrConv(txtLast_NameTextBox.Text.Trim & "", VbStrConv.ProperCase), _
                        txtE_MailTextBox.Text.Trim.ToLower & "", _
                        lwDepartments.CheckedItems(0).SubItems(1).Text.Trim & "", _
                        DirectCast(IIf(txtCellphoneTextBox.Text.ToString.Trim & "" = "", txtTelephoneTextBox.Text.ToString.Trim & "", txtCellphoneTextBox.Text.ToString.Trim & ""), String), _
                        Me.txtCellphoneTextBox.Text, txtRankTextBox.Text.Trim & "")
                Do_FrmButtons(False, True, True)

            End If
            ' DIS DIE OU GROOT KOKKODOOR DIE
            tsBtnUpdateUser_Click(sender, e)
            Do_ResetPassword(persalnumber)

            frmEnvironment.ChildFormPRD.VIP_USERS_NewUsersTableAdapter.UpdateDoneToCompleted(Get_ValidPersalNumber(persalnumber.Trim))

        End If

        If Not String.IsNullOrEmpty(Me.txtRemedyRequestNo.Text) Then
            Rules_Flags_Valid_Delete_Requestno(Me.txtRemedyRequestNo.Text)
        End If

        Me.Cursor = Cursors.Arrow

    End Sub

#End Region

    Private Sub RefreshCFODatasetMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ''RefreshCFODatasetMenu
    End Sub

    Private Sub GroupBox2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GroupBox2.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            frmAD_create_new_shortcode.Show(Me)
        End If
    End Sub

    ' lwA Add Items Here
    Public Sub load_lv_assigned_departments()
        Dim dt As New DataTable
        Dim row As DataRow
        Dim col As Integer = 0
        'Johan2
        Me.lwA.Items.Clear()
        dt = Me.VIEW_Assigned_DepartmentTableAdapter.GetData
        Dim str(dt.Columns.Count) As String
        For Each row In dt.Rows
            For col = 0 To dt.Columns.Count - 1
                str(col + 1) = row(col).ToString()
            Next
            Dim lv As New ListViewItem(str)
            Me.lwA.Items.Add(lv)
        Next
        Me.Cursor = Cursors.Arrow
    End Sub

    Public Function create_ad_appl_group_collection() As Microsoft.VisualBasic.Collection
        Dim col As New Microsoft.VisualBasic.Collection
        Dim i As Integer

        ' 
        For i = 0 To Me.lwApplicationRoles.CheckedItems.Count - 1
            col.Add(Me.lwApplicationRoles.CheckedItems(i).SubItems(1).Text.Trim)
        Next

        'If Me.lvFlags.CheckedItems.Count > 0 Then
        '    col.Add(Me.lwApplicationRoles.CheckedItems(i).SubItems(1).Text.Trim)
        'End If

        '' 

        Return col
        Me.Cursor = Cursors.Arrow

    End Function

    Private Sub txtPersalNumber_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPersalNumber.DoubleClick
        If Clipboard.ContainsText Then
            Me.txtPersalNumber.Text = Clipboard.GetText
            '
            btnActiveDirectory_Click(sender, e)
            '
        Else
            btnActiveDirectory_Click(sender, e)
        End If
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub btnCFONew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCFONew.Click
        frmTempCFOList.Show()
    End Sub

#Region "Timers"

    Public Sub ButtonsRefreshTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonsRefreshTimer.Tick


        If (Not frmEnvironment.ActiveMdiChild Is Nothing) Then
            '    If frmEnvironment.ActiveMdiChild.Text.Contains("- PRD") Then
            '        frmWebRequest.VIP_USERSTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
            '        Me.GetResetPasswordsTableAdapter1.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
            '        Me.Department_DiffersTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
            '        Me.VIEW_CFO_APPPLICATION_TOOK_TO_LONGTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
            '        ' Me.ta_VIEW_departments1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")
            '        Me.Ta_VIEW_APPLICATION_RIGHTS1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDConnectionString")
            '        Me.Ta_VIEW_Assigned_Departments1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")
            '        Me.Ta_VIEW_GOVERNMENT_STRUCTURE1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")
            '        Me.LOG_IN_Request_TrackingTableAdapter1.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemProdConnectionString")
            '        Me.LOG_DM_Customer_InformationTableAdapter1.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemDevConnectionString")
            '        Me.LOG_DM_PersonnelTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemDevConnectionString")
            '        Me.LOG_IN_Request_TrackingTableAdapter1.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemProdConnectionString")
            '        Me.Ta_Vulindlela_Controllers.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemDevConnectionString")
            '        Me.Ta_VIEW_APPLICATION_RIGHTS1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")
            '        '  Me.Ta_VIEW_Assigned_Departments1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")
            '        '   Me.ta_VIEW_departments1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")
            '        Me.Ta_VIEW_GOVERNMENT_STRUCTURE1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")
            '        Me.CountNewUsersTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
            '        Me.GetResetPasswordsTableAdapter1.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
            '        '    Me.RemedyOpenRequestsTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemDevConnectionString")
            '        Me.Ta_Vulindlela_Controllers.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
            '        Me.RULES_FLAGSTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
            '        Me.Data_PersonnelAndAppointment002TableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
            '        Me.Ta_Estab2.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
            '        Me.LOG_IN_Request_Tracking2TableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemDevConnectionString")
            '        Me.VIP_USERSTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
            '        Me.CountNewUsersTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
            '        Me.HR_DataTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("HR_MISConnectionStringPRD")

            '    Else

            '        Me.GetResetPasswordsTableAdapter1.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
            '        Me.Department_DiffersTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
            '        Me.VIEW_CFO_APPPLICATION_TOOK_TO_LONGTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
            '        Me.Ta_VIEW_APPLICATION_RIGHTS1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")
            '        Me.Ta_VIEW_Assigned_Departments1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")
            '        Me.Ta_VIEW_GOVERNMENT_STRUCTURE1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")
            '        Me.LOG_IN_Request_TrackingTableAdapter1.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemDevConnectionString")
            '        Me.LOG_DM_Customer_InformationTableAdapter1.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemDevConnectionString")
            '        Me.LOG_DM_PersonnelTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemDevConnectionString")
            '        Me.Ta_Vulindlela_Controllers.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemDevConnectionString")
            '        Me.Ta_VIEW_APPLICATION_RIGHTS1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")
            '        ' Me.Ta_VIEW_Assigned_Departments1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")
            '        Me.ta_VIEW_departments1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")
            '        Me.Ta_VIEW_GOVERNMENT_STRUCTURE1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")
            '        Me.CountNewUsersTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
            '        Me.GetResetPasswordsTableAdapter1.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
            '        '  Me.RemedyOpenRequestsTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemDevConnectionString")
            '        Me.Ta_Vulindlela_Controllers.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
            '        Me.RULES_FLAGSTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
            '        Me.Data_PersonnelAndAppointment002TableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
            '        Me.Ta_Estab2.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
            '        Me.LOG_IN_Request_Tracking2TableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemDevConnectionString")
            '        Me.VIP_USERSTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
            '        Me.CountNewUsersTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
            '        Me.HR_DataTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("HR_MISConnectionStringDev")
            '    End If




            If frmEnvironment.ActiveMdiChild.Text.Contains("- PRD") Then

                Me.GetResetPasswordsTableAdapter1.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
                Me.Department_DiffersTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
                Me.VIEW_CFO_APPPLICATION_TOOK_TO_LONGTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
                '     Me.ta_VIEW_departments1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDConnectionString")
                Me.Ta_VIEW_APPLICATION_RIGHTS1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDPRDConnectionString2014")
                Me.Ta_VIEW_Assigned_Departments1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDPRDConnectionString2014")
                Me.Ta_VIEW_GOVERNMENT_STRUCTURE1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDPRDConnectionString2014")
                Me.LOG_IN_Request_TrackingTableAdapter1.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemProdConnectionString")
                Me.LOG_DM_Customer_InformationTableAdapter1.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemProdConnectionString")
                Me.LOG_DM_PersonnelTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemProdConnectionString")
                Me.LOG_IN_Request_TrackingTableAdapter1.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemProdConnectionString")
                Me.Ta_Vulindlela_Controllers.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemProdConnectionString")
                Me.Ta_VIEW_APPLICATION_RIGHTS1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDPRDConnectionString2014")
                Me.Ta_VIEW_Assigned_Departments1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDPRDConnectionString2014")
                '  Me.ta_VIEW_departments1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDConnectionString2008PRD")
                Me.Ta_VIEW_GOVERNMENT_STRUCTURE1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDPRDConnectionString2014")
                Me.CountNewUsersTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("AdsPRDConnectionString2014")
                Me.GetResetPasswordsTableAdapter1.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
                Me.RemedyOpenRequestsTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemProdConnectionString")
                Me.Ta_Vulindlela_Controllers.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
                Me.RULES_FLAGSTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
                Me.Data_PersonnelAndAppointment002TableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
                Me.Ta_Estab2.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
                Me.LOG_IN_Request_Tracking2TableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemProdConnectionString")
                Me.VIP_USERSTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
                Me.ta_KICKOUT.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
                My.MySettings.Default.Default("AdsConnectionString") = My.MySettings.Default.Default("ADSPRDConnectionString2014")
                Me.CountNewUsersTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
                Me.VIP_USERS_ResetPasswordTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
                Me.VIP_USERS_NewUsersTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
                Me.ADCONSOLELOGTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
                Me.HR_DataTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("HR_MISConnectionStringPRD")
                Me.VIEW_Assigned_DepartmentTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("SHARED_TABLESConnectionStringPRD")


                'Me.GetResetPasswordsTableAdapter1.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                'Me.Department_DiffersTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                'Me.VIEW_CFO_APPPLICATION_TOOK_TO_LONGTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                'Me.Ta_VIEW_APPLICATION_RIGHTS1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")
                'Me.Ta_VIEW_Assigned_Departments1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")
                'Me.Ta_VIEW_GOVERNMENT_STRUCTURE1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")
                'Me.LOG_IN_Request_TrackingTableAdapter1.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemDevConnectionString")
                'Me.LOG_DM_Customer_InformationTableAdapter1.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemDevConnectionString")
                'Me.LOG_DM_PersonnelTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemDevConnectionString")
                'Me.Ta_Vulindlela_Controllers.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemDevConnectionString")
                'Me.Ta_VIEW_APPLICATION_RIGHTS1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")
                'Me.Ta_VIEW_Assigned_Departments1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")
                'Me.ta_VIEW_departments1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")
                'Me.Ta_VIEW_GOVERNMENT_STRUCTURE1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")
                'Me.CountNewUsersTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                'Me.GetResetPasswordsTableAdapter1.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                'Me.RemedyOpenRequestsTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemDevConnectionString")
                'Me.Ta_Vulindlela_Controllers.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                'Me.RULES_FLAGSTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                'Me.Data_PersonnelAndAppointment002TableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                'Me.Ta_Estab2.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                'Me.LOG_IN_Request_Tracking2TableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemDevConnectionString")
                'Me.VIP_USERSTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                'Me.RULES_FLAGSTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                'Me.CountNewUsersTableAdapter.Connection.ConnectionString = My.MySettings.Default("ADSQAConnectionString2014")
                ''My.MySettings.Default.Default("AdsConnectionString") = My.MySettings.Default.Default("ADSQAConnectionString2014")
                'Me.ta_KICKOUT.Connection.ConnectionString = My.MySettings.Default("ADSQAConnectionString2014")

                ''My.MySettings.Default("AdsConnectionString") = My.MySettings.Default("ADSQAConnectionString2014")
                ''My.MySettings.Default("ADSPRDConnectionString2014") = My.MySettings.Default("ADSQAConnectionString2014")
                ''My.MySettings.Default.Default("VIP_EXPANDEDConnectionString") = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")

                ''My.MySettings.Default.Default("ARSystemConnectionString") = My.MySettings.Default.Default("ARSystemDevConnectionString")
                ''My.MySettings.Default.Default("ARSystemProdConnectionString") = My.MySettings.Default.Default("ARSystemDevConnectionString")



            Else

                Me.GetResetPasswordsTableAdapter1.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                Me.Department_DiffersTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                Me.VIEW_CFO_APPPLICATION_TOOK_TO_LONGTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                Me.Ta_VIEW_APPLICATION_RIGHTS1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")
                Me.Ta_VIEW_Assigned_Departments1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")
                Me.Ta_VIEW_GOVERNMENT_STRUCTURE1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")
                Me.LOG_IN_Request_TrackingTableAdapter1.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemDevConnectionString")
                Me.LOG_DM_Customer_InformationTableAdapter1.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemDevConnectionString")
                Me.LOG_DM_PersonnelTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemDevConnectionString")
                Me.Ta_Vulindlela_Controllers.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemDevConnectionString")
                Me.Ta_VIEW_APPLICATION_RIGHTS1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")
                Me.Ta_VIEW_Assigned_Departments1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")
                '   Me.ta_VIEW_departments1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")
                Me.Ta_VIEW_GOVERNMENT_STRUCTURE1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")
                Me.CountNewUsersTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                Me.GetResetPasswordsTableAdapter1.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                Me.RemedyOpenRequestsTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemDevConnectionString")
                Me.Ta_Vulindlela_Controllers.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                Me.RULES_FLAGSTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                Me.Data_PersonnelAndAppointment002TableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                Me.Ta_Estab2.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                Me.LOG_IN_Request_Tracking2TableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemDevConnectionString")
                Me.VIP_USERSTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                Me.RULES_FLAGSTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                Me.CountNewUsersTableAdapter.Connection.ConnectionString = My.MySettings.Default("ADSQAConnectionString2014")
                Me.VIP_USERS_ResetPasswordTableAdapter.Connection.ConnectionString = My.MySettings.Default("ADSQAConnectionString2014")
                Me.VIP_USERS_NewUsersTableAdapter.Connection.ConnectionString = My.MySettings.Default("ADSQAConnectionString2014")
                'My.MySettings.Default.Default("AdsConnectionString") = My.MySettings.Default.Default("ADSQAConnectionString2014")
                Me.ta_KICKOUT.Connection.ConnectionString = My.MySettings.Default("ADSQAConnectionString2014")
                Me.ADCONSOLELOGTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                Me.HR_DataTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("HR_MISConnectionStringDev")
                Me.VIEW_Assigned_DepartmentTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("SHARED_TABLESConnectionStringDev")

                'My.MySettings.Default("AdsConnectionString") = My.MySettings.Default("ADSQAConnectionString2014")
                'My.MySettings.Default("ADSPRDConnectionString2014") = My.MySettings.Default("ADSQAConnectionString2014")
                'My.MySettings.Default.Default("VIP_EXPANDEDConnectionString") = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")

                'My.MySettings.Default.Default("ARSystemConnectionString") = My.MySettings.Default.Default("ARSystemDevConnectionString")
                'My.MySettings.Default.Default("ARSystemProdConnectionString") = My.MySettings.Default.Default("ARSystemDevConnectionString")

            End If






            ButtonsRefreshTimer.Stop()
            Dim num As Integer
            num = Does_Account_Exist(Get_ValidPersalNumber(Me.txtPersalNumber.Text))
            If num = 1 And lwAppRoles2.Items.Count > 0 And lwDepartments.CheckedItems.Count > 0 Then        ' User does exist
                Do_FrmButtons(False, True, True)
            ElseIf num = 2 And lwAppRoles2.Items.Count > 0 And lwDepartments.CheckedItems.Count > 0 Then    ' User does not exist
                Do_FrmButtons(True, False, False)
            ElseIf num = 3 Then                                                                             ' Persalnumber is blank
                Do_FrmButtons(False, False, False)
            ElseIf lwAppRoles2.Items.Count < 1 And lwDepartments.CheckedItems.Count < 1 Then
                'Do_FrmButtons(False, False, False)
                rbAccountLevel2.Checked = False
                rbAccountLevel3.Checked = False
                rbAccountLevel4.Checked = False
                rbAccountLevel5.Checked = False
                rbAccountLevel6.Checked = False
                rbAccountLevel7.Checked = False
                chkEnabled.Checked = False
            End If

            'btnNewUsers
            If CInt(Me.CountNewUsersTableAdapter.GetDataCountNewUsers.Rows(0).Item(0).ToString) = 0 Then
                btnNewUsers.Text = CStr(0)
            Else
                btnNewUsers.Text = Me.CountNewUsersTableAdapter.GetDataCountNewUsers.Rows(0).Item(0).ToString()
            End If
            btnNewUsers.Refresh()


            '  btnResetPassword
            If CInt(Me.GetResetPasswordsTableAdapter1.GetData.Rows(0).Item(0).ToString) = 0 Then
                btnResetPassword.Text = CStr(0)
            Else
                btnResetPassword.Text = Me.GetResetPasswordsTableAdapter1.GetData.Rows(0).Item(0).ToString()
            End If

            btnResetPwd.Refresh()
            ButtonsRefreshTimer.Start()
        End If

    End Sub

    Private Sub timerCOUNTS_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerCOUNTS.Tick
        Dim taQueries As Global.ADAdminDotNet.dsARSystemDataSetTableAdapters.QueriesTableAdapter
        taQueries = New ADAdminDotNet.dsARSystemDataSetTableAdapters.QueriesTableAdapter()

        If (Not frmEnvironment.ActiveMdiChild Is Nothing) Then


            If frmEnvironment.ActiveMdiChild.Text.Contains("- PRD") Then

                Me.GetResetPasswordsTableAdapter1.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
                Me.Department_DiffersTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
                Me.VIEW_CFO_APPPLICATION_TOOK_TO_LONGTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
                '     Me.ta_VIEW_departments1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDConnectionString")
                Me.Ta_VIEW_APPLICATION_RIGHTS1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDPRDConnectionString2014")
                Me.Ta_VIEW_Assigned_Departments1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDPRDConnectionString2014")
                Me.Ta_VIEW_GOVERNMENT_STRUCTURE1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDPRDConnectionString2014")
                Me.LOG_IN_Request_TrackingTableAdapter1.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemProdConnectionString")
                Me.LOG_DM_Customer_InformationTableAdapter1.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemProdConnectionString")
                Me.LOG_DM_PersonnelTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemProdConnectionString")
                Me.LOG_IN_Request_TrackingTableAdapter1.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemProdConnectionString")
                Me.Ta_Vulindlela_Controllers.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemProdConnectionString")
                Me.Ta_VIEW_APPLICATION_RIGHTS1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDPRDConnectionString2014")
                Me.Ta_VIEW_Assigned_Departments1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDPRDConnectionString2014")
                '  Me.ta_VIEW_departments1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDConnectionString2008PRD")
                Me.Ta_VIEW_GOVERNMENT_STRUCTURE1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDPRDConnectionString2014")
                Me.CountNewUsersTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("AdsPRDConnectionString2014")
                Me.GetResetPasswordsTableAdapter1.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
                Me.RemedyOpenRequestsTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemProdConnectionString")
                Me.Ta_Vulindlela_Controllers.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
                Me.RULES_FLAGSTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
                Me.Data_PersonnelAndAppointment002TableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
                Me.Ta_Estab2.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
                Me.LOG_IN_Request_Tracking2TableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemProdConnectionString")
                Me.VIP_USERSTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
                Me.ta_KICKOUT.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
                My.MySettings.Default.Default("AdsConnectionString") = My.MySettings.Default.Default("ADSPRDConnectionString2014")
                Me.CountNewUsersTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
                Me.VIP_USERS_ResetPasswordTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
                Me.VIP_USERS_NewUsersTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
                Me.ADCONSOLELOGTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
                Me.HR_DataTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("HR_MISConnectionStringPRD")
                Me.VIEW_Assigned_DepartmentTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("SHARED_TABLESConnectionStringPRD")

      











                'Me.GetResetPasswordsTableAdapter1.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                'Me.Department_DiffersTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                'Me.VIEW_CFO_APPPLICATION_TOOK_TO_LONGTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                'Me.Ta_VIEW_APPLICATION_RIGHTS1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")
                'Me.Ta_VIEW_Assigned_Departments1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")
                'Me.Ta_VIEW_GOVERNMENT_STRUCTURE1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")
                'Me.LOG_IN_Request_TrackingTableAdapter1.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemDevConnectionString")
                'Me.LOG_DM_Customer_InformationTableAdapter1.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemDevConnectionString")
                'Me.LOG_DM_PersonnelTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemDevConnectionString")
                'Me.Ta_Vulindlela_Controllers.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemDevConnectionString")
                'Me.Ta_VIEW_APPLICATION_RIGHTS1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")
                'Me.Ta_VIEW_Assigned_Departments1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")
                'Me.ta_VIEW_departments1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")
                'Me.Ta_VIEW_GOVERNMENT_STRUCTURE1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")
                'Me.CountNewUsersTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                'Me.GetResetPasswordsTableAdapter1.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                'Me.RemedyOpenRequestsTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemDevConnectionString")
                'Me.Ta_Vulindlela_Controllers.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                'Me.RULES_FLAGSTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                'Me.Data_PersonnelAndAppointment002TableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                'Me.Ta_Estab2.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                'Me.LOG_IN_Request_Tracking2TableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemDevConnectionString")
                'Me.VIP_USERSTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                'Me.RULES_FLAGSTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                'Me.CountNewUsersTableAdapter.Connection.ConnectionString = My.MySettings.Default("ADSQAConnectionString2014")
                ''My.MySettings.Default.Default("AdsConnectionString") = My.MySettings.Default.Default("ADSQAConnectionString2014")
                'Me.ta_KICKOUT.Connection.ConnectionString = My.MySettings.Default("ADSQAConnectionString2014")

                ''My.MySettings.Default("AdsConnectionString") = My.MySettings.Default("ADSQAConnectionString2014")
                ''My.MySettings.Default("ADSPRDConnectionString2014") = My.MySettings.Default("ADSQAConnectionString2014")
                ''My.MySettings.Default.Default("VIP_EXPANDEDConnectionString") = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")

                ''My.MySettings.Default.Default("ARSystemConnectionString") = My.MySettings.Default.Default("ARSystemDevConnectionString")
                ''My.MySettings.Default.Default("ARSystemProdConnectionString") = My.MySettings.Default.Default("ARSystemDevConnectionString")



            Else

                Me.GetResetPasswordsTableAdapter1.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                Me.Department_DiffersTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                Me.VIEW_CFO_APPPLICATION_TOOK_TO_LONGTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                Me.Ta_VIEW_APPLICATION_RIGHTS1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")
                Me.Ta_VIEW_Assigned_Departments1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")
                Me.Ta_VIEW_GOVERNMENT_STRUCTURE1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")
                Me.LOG_IN_Request_TrackingTableAdapter1.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemDevConnectionString")
                Me.LOG_DM_Customer_InformationTableAdapter1.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemDevConnectionString")
                Me.LOG_DM_PersonnelTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemDevConnectionString")
                Me.Ta_Vulindlela_Controllers.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemDevConnectionString")
                Me.Ta_VIEW_APPLICATION_RIGHTS1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")
                Me.Ta_VIEW_Assigned_Departments1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")
                '   Me.ta_VIEW_departments1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")
                Me.Ta_VIEW_GOVERNMENT_STRUCTURE1.Connection.ConnectionString = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")
                Me.CountNewUsersTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                Me.GetResetPasswordsTableAdapter1.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                Me.RemedyOpenRequestsTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemDevConnectionString")
                Me.Ta_Vulindlela_Controllers.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                Me.RULES_FLAGSTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                Me.Data_PersonnelAndAppointment002TableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                Me.Ta_Estab2.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                Me.LOG_IN_Request_Tracking2TableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemDevConnectionString")
                Me.VIP_USERSTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                Me.RULES_FLAGSTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                Me.CountNewUsersTableAdapter.Connection.ConnectionString = My.MySettings.Default("ADSQAConnectionString2014")
                Me.VIP_USERS_ResetPasswordTableAdapter.Connection.ConnectionString = My.MySettings.Default("ADSQAConnectionString2014")
                Me.VIP_USERS_NewUsersTableAdapter.Connection.ConnectionString = My.MySettings.Default("ADSQAConnectionString2014")
                'My.MySettings.Default.Default("AdsConnectionString") = My.MySettings.Default.Default("ADSQAConnectionString2014")
                Me.ta_KICKOUT.Connection.ConnectionString = My.MySettings.Default("ADSQAConnectionString2014")
                Me.ADCONSOLELOGTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
                Me.HR_DataTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("HR_MISConnectionStringDev")
                Me.VIEW_Assigned_DepartmentTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("SHARED_TABLESConnectionStringDev")
                'My.MySettings.Default("AdsConnectionString") = My.MySettings.Default("ADSQAConnectionString2014")
                'My.MySettings.Default("ADSPRDConnectionString2014") = My.MySettings.Default("ADSQAConnectionString2014")
                'My.MySettings.Default.Default("VIP_EXPANDEDConnectionString") = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")

                'My.MySettings.Default.Default("ARSystemConnectionString") = My.MySettings.Default.Default("ARSystemDevConnectionString")
                'My.MySettings.Default.Default("ARSystemProdConnectionString") = My.MySettings.Default.Default("ARSystemDevConnectionString")

            End If


            Me.timerCOUNTS.Stop()
            Dim StartKickout As Integer = CInt(ta_KICKOUT.GetDataKickout.Rows(0).Item(0))

            If StartKickout Then
                TimerKickout.Start()
                If frmEnvironment.ChildFormPRD.Visible Then
                    MsgBox("The application will shutdown in 10 seconds", MsgBoxStyle.OkOnly)
                ElseIf frmEnvironment.childformQA.Visible Then
                    MsgBox("The application will shutdown in 10 seconds", MsgBoxStyle.OkOnly)
                End If
                Exit Sub
            End If

            btnDeptDiffers.Text = "0"
            btnOpenRequests.Text = "0"
            btnNewUsers.Text = "0"
            btnCFONew.Text = "0"




            Try

                Me.CountNewUsersTableAdapter.FillCountNewUsers(Me.Ads1.CountNewUsers)
                If Me.CountNewUsersTableAdapter.GetDataCountNewUsers.Rows(0).Item(0) = 0 Then
                    btnNewUsers.Text = CStr(0)
                Else
                    btnNewUsers.Text = CStr(Me.CountNewUsersTableAdapter.GetDataCountNewUsers.Rows(0).Item(0))
                End If
                btnNewUsers.Refresh()

                'btnResetPassword
                If Me.GetResetPasswordsTableAdapter1.GetData.Rows(0).Item(0) = 0 Then
                    btnResetPassword.Text = CStr(0)
                Else
                    btnResetPassword.Text = CStr(Me.GetResetPasswordsTableAdapter1.GetData.Rows(0).Item(0))
                End If
                btnResetPassword.Refresh()

                'btnDeptDiffers
                If Val(Me.Department_DiffersTableAdapter.ScalarQuery.ToString) = 0 Then
                    btnDeptDiffers.Text = CStr(0)
                Else
                    btnDeptDiffers.Text = CStr(Me.Department_DiffersTableAdapter.ScalarQuery.ToString)
                End If


                'To Follow Up
                If Val(Me.LOG_IN_Request_Tracking2TableAdapter.CountInforRequireds.ToString) = 0 Then
                    btnToFollowUp.Text = CStr(0)
                Else
                    btnToFollowUp.Text = CStr(Me.LOG_IN_Request_Tracking2TableAdapter.CountInforRequireds.ToString)
                End If
                btnToFollowUp.Refresh()

                'btnReferrals
                If Val(Me.RULES_FLAGSTableAdapter.CountInactive_Refferals.ToString) = 0 Then
                    btnReferral.Text = CStr(0)
                Else
                    btnReferral.Text = CStr(Me.RULES_FLAGSTableAdapter.CountInactive_Refferals.ToString)
                End If


                btnOpenRequests.Text = CStr(Me.LOG_IN_Request_Tracking2TableAdapter.OpenRemedyRequests.ToString)
                ' btnToFollowUp.Text = CStr(Me.taQueries.CountInfoRequireds.ToString)

                Me.CountNewUsersTableAdapter.FillCountNewUsers(Me.Ads1.CountNewUsers)

                If Val(Me.CountNewUsersTableAdapter.GetDataCountNewUsers.Rows(0).Item(0).ToString) = 0 Then
                    btnCFONew.Text = CStr(0)
                Else
                    btnCFONew.Text = CStr(Me.CountNewUsersTableAdapter.GetDataCountNewUsers.Rows(0).Item(0))
                End If
                btnCFONew.Refresh()

            Catch ex As Exception
                If ex.Message IsNot Nothing Then
                    MsgBox(ex.Message.Trim, MsgBoxStyle.OkOnly, "System Message")
                End If
            End Try
            Me.timerCOUNTS.Start()


            'Me.timerCOUNTS.Stop()
            'Dim StartKickout As Boolean = CBool(ta_KICKOUT.GetDataKickout.Rows(0).Item(0))
            'If StartKickout Then
            '    TimerKickout.Start()
            '    If frmEnvironment.ChildFormPRD.Visible Then
            '        MsgBox("The application will shutdown in 10 seconds", MsgBoxStyle.OkOnly)
            '    ElseIf frmEnvironment.childformQA.Visible Then
            '        MsgBox("The application will shutdown in 10 seconds", MsgBoxStyle.OkOnly)
            '    End If
            '    Exit Sub
            'End If

            'btnDeptDiffers.Text = "0"
            'btnOpenRequests.Text = "0"
            'btnNewUsers.Text = "0"
            'btnCFONew.Text = "0"

            'Try

            '    If Val(Me.CountNewUsersTableAdapter.GetDataCountNewUsers.Rows(0).Item(0).ToString) = 0 Then
            '        btnCFONew.Text = CStr(0)
            '    Else
            '        btnCFONew.Text = CStr(Me.CountNewUsersTableAdapter.GetDataCountNewUsers.Rows(0).Item(0))
            '    End If
            '    btnCFONew.Refresh()

            '    If Val(Me.CountNewUsersTableAdapter.GetDataCountNewUsers.Rows(0).Item(0).ToString) = 0 Then
            '        btnNewUsers.Text = CStr(0)
            '    Else
            '        btnNewUsers.Text = CStr(Me.CountNewUsersTableAdapter.GetDataCountNewUsers.Rows(0).Item(0))
            '    End If
            '    btnNewUsers.Refresh()

            '    'btnDeptDiffers
            '    If Val(Me.Department_DiffersTableAdapter.ScalarQuery.ToString) = 0 Then
            '        btnDeptDiffers.Text = CStr(0)
            '    Else
            '        btnDeptDiffers.Text = CStr(Me.Department_DiffersTableAdapter.ScalarQuery.ToString)
            '    End If

            '    'btnReferrals
            '    If Val(Me.RULES_FLAGSTableAdapter.CountInactive_Refferals.ToString) = 0 Then
            '        btnReferrals.Text = CStr(0)
            '    Else
            '        btnReferrals.Text = CStr(Me.RULES_FLAGSTableAdapter.CountInactive_Refferals.ToString)
            '    End If

            '    btnOpenRequests.Text = CStr(Me.taQueries.OpenRemedyRequests.ToString)
            '    btnToFollowUp.Text = CStr(Me.taQueries.CountInfoRequireds.ToString)

            'Catch ex As Exception
            '    If ex.Message IsNot Nothing Then
            '        MsgBox(ex.Message.Trim, MsgBoxStyle.OkOnly, "System Message")
            '    End If
            'End Try
            'Me.timerCOUNTS.Start()

        End If
    End Sub



    Private Sub TimerKickout_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerKickout.Tick

        Me.tsLabelREMEDY.Text = "The application will shutdown in " & ticks & " seconds"
        If ticks = 0 Then
            End
        End If
        ticks = ticks - 1
    End Sub

#End Region

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

        Dim i As Integer
        If CheckBox1.Checked Then
            For i = 0 To lwA.Items.Count - 1
                lwA.Items(i).Checked = False
            Next
            rbAccountLevel7.Checked = False
        End If

    End Sub

    Public Sub gridRequests_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridRequests.CellContentDoubleClick

        Dim txtRequestNo As String = ""
        Dim ws As New ARSWS.Webpage
        Dim pro As New Process
        Dim Environment As String = Me.Text

        txtRequestNo = Me.gridRequests.CurrentRow.Cells("RequestNoDataGridViewTextBoxColumn").Value
        pro = ws.Open_Request_No(txtRequestNo, Environment)
        Me.Cursor = Cursors.Arrow
        'ws = Nothing

    End Sub

    Private Sub ObtainAListOfOpenRequestsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ObtainAListOfOpenRequestsToolStripMenuItem.Click

        Dim txtPersalNo As String = ""
        Dim ws As New ARSWS.Webpage
        Dim pro As New Process
        Dim Environment As String = Me.Text

        txtPersalNo = Me.VIP_USERSDataGridView.CurrentRow.Cells("DataGridViewTextBoxColumn26").Value
        pro = ws.Open_Request_No(txtPersalNo, Environment)
        Me.Cursor = Cursors.Arrow

    End Sub

    Private Sub CreateNewADObjectsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateNewADObjectsToolStripMenuItem.Click

        Dim mcreate As String = ""

        On Error Resume Next

        If MsgBox("Have you already select the departments you want to create in he Assigned department TAB", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            With lwA

                For Each li As ListViewItem In Me.lwA.CheckedItems

                    mcreate = ""
                    mcreate = InputBox("Specify the deparment you want to create", "Current Missing Department to Create on AD", DirectCast(li.SubItems(1), System.Windows.Forms.ListViewItem.ListViewSubItem).Text)

                    If Not String.IsNullOrEmpty(mcreate) Then
                        modADS.Create_Government_Group(mcreate)
                        modADS.Create_Government_Group("AUDITGENL." & mcreate)
                        modADS.Create_Government_Group("DPSA." & mcreate)
                        modADS.Create_Government_Group("FINANCIALS." & mcreate)
                        modADS.Create_Government_Group("GENERAL_REPORTING." & mcreate)
                        modADS.Create_Government_Group("FTP_ACCESS." & mcreate)
                        modADS.Create_Government_Group("GFS." & mcreate)
                        modADS.Create_Government_Group("HR." & mcreate)
                        modADS.Create_Government_Group("HR_OVERSIGHT." & mcreate)
                        modADS.Create_Government_Group("LOGIS." & mcreate)
                        modADS.Create_Government_Group("PERSALPDF." & mcreate)
                    End If

                Next

            End With
            MsgBox("Task Completed")
        Else
            MsgBox("Task Failed")
            Exit Sub
        End If

    End Sub

    Private Sub TempCFOLIstToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TempCFOLIstToolStripMenuItem.Click

        'Still to work on
        If frmEnvironment.ChildFormPRD.Visible Then

            frmCFOTable.CFOListTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
            frmTempCFOList.Text = "CFO Temp Table - PRD"
            frmTempCFOList.ShowDialog()
            frmTempCFOList.Focus()

        ElseIf frmEnvironment.childformQA.Visible Then

            My.MySettings.Default("AdsConnectionString") = My.MySettings.Default.Default("AdsQAConnectionString2014")
            MySettings.Default("ARSystemConnectionString") = MySettings.Default("ARSystemConnectionString")
            frmTempCFOList.Text = "CFO Temp Table - QA"
            frmTempCFOList.ShowDialog()
            frmCFOTable.Focus()

        End If


    End Sub

    Private Sub DefaultWebBrowserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefaultWebBrowserToolStripMenuItem.Click
        frmOptionsDialog.ShowDialog()
    End Sub

    Private Sub ADCONSOLELOGDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ADCONSOLELOGDataGridView.CellContentClick

    End Sub

    Private Sub gridRequests_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridRequests.CellContentClick

    End Sub

    Private Sub tsRemedy_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles tsRemedy.ItemClicked

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub txtPersalNumber_Click(sender As Object, e As EventArgs) Handles txtPersalNumber.Click

    End Sub

    Private Sub txtRemedyRequestNo_TextChanged(sender As Object, e As EventArgs) Handles txtRemedyRequestNo.TextChanged

    End Sub

    Private Sub txtCellphoneTextBox_TextChanged(sender As Object, e As EventArgs) Handles txtCellphoneTextBox.TextChanged

    End Sub

    Private Sub txtE_MailTextBox_TextChanged(sender As Object, e As EventArgs) Handles txtE_MailTextBox.TextChanged

    End Sub

    Private Sub txtFirst_NameTextBox_TextChanged(sender As Object, e As EventArgs) Handles txtFirst_NameTextBox.TextChanged

    End Sub

    Private Sub txtTelephoneTextBox_TextChanged(sender As Object, e As EventArgs) Handles txtTelephoneTextBox.TextChanged

    End Sub

    Private Sub txtDepartment_TypeTextBox_TextChanged(sender As Object, e As EventArgs) Handles txtDepartment_TypeTextBox.TextChanged

    End Sub

    Private Sub bs_LOGDMCustomeInformation_CurrentChanged(sender As Object, e As EventArgs) Handles bs_LOGDMCustomeInformation.CurrentChanged

    End Sub

    Private Sub lvFlags_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvFlags.SelectedIndexChanged

    End Sub

    Private Sub lwAppRoles2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lwAppRoles2.SelectedIndexChanged

    End Sub

    Private Sub btnReferral_Click(sender As Object, e As EventArgs) Handles btnReferral.Click
        Cleartxt = False
        'frmReferrals.ShowDialog()


        If frmEnvironment.ActiveMdiChild.Text.Contains("PRD") Then

            frmReferrals.Text = "Referred - PRD"
            frmReferrals.CFOApproval_ta.Connection.ConnectionString = My.MySettings.Default.Default("ADSPRDConnectionString2014")
            frmReferrals.LOG_IN_Request_TrackingTableAdapter.Connection.ConnectionString = My.MySettings.Default.Default("ARSystemProdConnectionString")
            frmReferrals.ShowDialog()
            frmReferrals.Focus()

        Else
            frmReferrals.CFOApproval_ta.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")

            frmReferrals.Text = "Referred - QA"
            frmReferrals.CFOApproval_ta.Connection.ConnectionString = My.MySettings.Default.Default("ADSQAConnectionString2014")
            frmReferrals.LOG_IN_Request_TrackingTableAdapter.Connection.ConnectionString = My.MySettings.Default("ARSystemDevConnectionString")

            frmReferrals.ShowDialog()
            ' frmInfoRequired.Focus()
            frmReferrals.Focus()

        End If

        Me.Cursor = Cursors.Arrow

    End Sub

    Private Sub openVIP_Click(sender As Object, e As EventArgs) Handles openVIP.Click

    End Sub

    Private Sub openVIPMenu_Click(sender As Object, e As EventArgs) Handles openVIPMenu.Click

    End Sub

    Private Sub pbMAIN_Click(sender As Object, e As EventArgs) Handles pbMAIN.Click

    End Sub

    Private Sub VIP_USERSDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles VIP_USERSDataGridView.CellContentClick

    End Sub

    Private Sub lwA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lwA.SelectedIndexChanged

    End Sub

    Private Sub Label23_Click(sender As Object, e As EventArgs) Handles Label23.Click

    End Sub

    Private Sub chkEnabled_CheckedChanged_1(sender As Object, e As EventArgs) Handles chkEnabled.CheckedChanged

    End Sub

    Private Sub txtRightsRequested_TextChanged(sender As Object, e As EventArgs) Handles txtRightsRequested.TextChanged

    End Sub

    Private Sub StatusStrip2_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles StatusStrip2.ItemClicked

    End Sub

    Private Sub dtpAccountExpireDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpAccountExpireDate.ValueChanged

    End Sub

    Private Sub chkProfileCategories_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles chkProfileCategories.SelectedIndexChanged

    End Sub

    Private Sub MainMenu_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MainMenu.ItemClicked

    End Sub

    Private Sub ToolStripDropDownButton30_Click(sender As Object, e As EventArgs) Handles ToolStripDropDownButton30.Click

    End Sub

    Private Sub btnEstablishment0_Click(sender As Object, e As EventArgs) Handles btnEstablishment0.Click

    End Sub

    'Private Sub btnReferral_Click(sender As Object, e As EventArgs) Handles btnReferral.Click

    'End Sub

    Private Sub bs_CustomerInfoSave_CurrentChanged(sender As Object, e As EventArgs) Handles bs_CustomerInfoSave.CurrentChanged

    End Sub
End Class
