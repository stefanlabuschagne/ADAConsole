Imports ADAdminDotNet.dsADSTableAdapters

Imports System.Windows.Forms

Imports System

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports ADAdminDotNet



'''<summary>
'''This is a test class for frmStatsTest and is intended
'''to contain all frmStatsTest Unit Tests
'''</summary>
<TestClass()> _
Public Class frmStatsTest


    Private testContextInstance As TestContext

    '''<summary>
    '''Gets or sets the test context which provides
    '''information about and functionality for the current test run.
    '''</summary>
    Public Property TestContext() As TestContext
        Get
            Return testContextInstance
        End Get
        Set(ByVal value As TestContext)
            testContextInstance = Value
        End Set
    End Property

#Region "Additional test attributes"
    '
    'You can use the following additional attributes as you write your tests:
    '
    'Use ClassInitialize to run code before running the first test in the class
    '<ClassInitialize()>  _
    'Public Shared Sub MyClassInitialize(ByVal testContext As TestContext)
    'End Sub
    '
    'Use ClassCleanup to run code after all tests in a class have run
    '<ClassCleanup()>  _
    'Public Shared Sub MyClassCleanup()
    'End Sub
    '
    'Use TestInitialize to run code before running each test
    '<TestInitialize()>  _
    'Public Sub MyTestInitialize()
    'End Sub
    '
    'Use TestCleanup to run code after each test has run
    '<TestCleanup()>  _
    'Public Sub MyTestCleanup()
    'End Sub
    '
#End Region


'''<summary>
'''A test for ViewJJ_Max_User_COuntTableAdapter
'''</summary>
<TestMethod()>  _
Public Sub ViewJJ_Max_User_COuntTableAdapterTest()
Dim target As frmStats = New frmStats ' TODO: Initialize to an appropriate value
Dim expected As ViewJJ_Max_User_COuntTableAdapter = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ViewJJ_Max_User_COuntTableAdapter
    target.ViewJJ_Max_User_COuntTableAdapter = expected
    actual = target.ViewJJ_Max_User_COuntTableAdapter
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ViewJJ_Max_User_COuntBindingSource
'''</summary>
<TestMethod()>  _
Public Sub ViewJJ_Max_User_COuntBindingSourceTest()
Dim target As frmStats = New frmStats ' TODO: Initialize to an appropriate value
Dim expected As BindingSource = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As BindingSource
    target.ViewJJ_Max_User_COuntBindingSource = expected
    actual = target.ViewJJ_Max_User_COuntBindingSource
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for txtTotal_users_registered_on_Vulindlela
'''</summary>
<TestMethod()>  _
Public Sub txtTotal_users_registered_on_VulindlelaTest()
Dim target As frmStats = New frmStats ' TODO: Initialize to an appropriate value
Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TextBox
    target.txtTotal_users_registered_on_Vulindlela = expected
    actual = target.txtTotal_users_registered_on_Vulindlela
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for txtResetPasswords
'''</summary>
<TestMethod()>  _
Public Sub txtResetPasswordsTest()
Dim target As frmStats = New frmStats ' TODO: Initialize to an appropriate value
Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TextBox
    target.txtResetPasswords = expected
    actual = target.txtResetPasswords
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for txt_Users_Disabled_This_Month
'''</summary>
<TestMethod()>  _
Public Sub txt_Users_Disabled_This_MonthTest()
Dim target As frmStats = New frmStats ' TODO: Initialize to an appropriate value
Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TextBox
    target.txt_Users_Disabled_This_Month = expected
    actual = target.txt_Users_Disabled_This_Month
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for txt_Users_Active_This_Month
'''</summary>
<TestMethod()>  _
Public Sub txt_Users_Active_This_MonthTest()
Dim target As frmStats = New frmStats ' TODO: Initialize to an appropriate value
Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TextBox
    target.txt_Users_Active_This_Month = expected
    actual = target.txt_Users_Active_This_Month
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for txt_New_Users_Created_in_This_Month
'''</summary>
<TestMethod()>  _
Public Sub txt_New_Users_Created_in_This_MonthTest()
Dim target As frmStats = New frmStats ' TODO: Initialize to an appropriate value
Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TextBox
    target.txt_New_Users_Created_in_This_Month = expected
    actual = target.txt_New_Users_Created_in_This_Month
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for txt_CFO_Approval_Requested
'''</summary>
<TestMethod()>  _
Public Sub txt_CFO_Approval_RequestedTest()
Dim target As frmStats = New frmStats ' TODO: Initialize to an appropriate value
Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TextBox
    target.txt_CFO_Approval_Requested = expected
    actual = target.txt_CFO_Approval_Requested
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolTip1
'''</summary>
<TestMethod()>  _
Public Sub ToolTip1Test()
Dim target As frmStats = New frmStats ' TODO: Initialize to an appropriate value
Dim expected As ToolTip = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolTip
    target.ToolTip1 = expected
    actual = target.ToolTip1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for TextBox5
'''</summary>
<TestMethod()>  _
Public Sub TextBox5Test()
Dim target As frmStats = New frmStats ' TODO: Initialize to an appropriate value
Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TextBox
    target.TextBox5 = expected
    actual = target.TextBox5
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for TabPage1
'''</summary>
<TestMethod()>  _
Public Sub TabPage1Test()
Dim target As frmStats = New frmStats ' TODO: Initialize to an appropriate value
Dim expected As TabPage = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TabPage
    target.TabPage1 = expected
    actual = target.TabPage1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for TabControl1
'''</summary>
<TestMethod()>  _
Public Sub TabControl1Test()
Dim target As frmStats = New frmStats ' TODO: Initialize to an appropriate value
Dim expected As TabControl = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TabControl
    target.TabControl1 = expected
    actual = target.TabControl1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Label9
'''</summary>
<TestMethod()>  _
Public Sub Label9Test()
Dim target As frmStats = New frmStats ' TODO: Initialize to an appropriate value
Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Label
    target.Label9 = expected
    actual = target.Label9
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Label8
'''</summary>
<TestMethod()>  _
Public Sub Label8Test()
Dim target As frmStats = New frmStats ' TODO: Initialize to an appropriate value
Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Label
    target.Label8 = expected
    actual = target.Label8
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Label7
'''</summary>
<TestMethod()>  _
Public Sub Label7Test()
Dim target As frmStats = New frmStats ' TODO: Initialize to an appropriate value
Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Label
    target.Label7 = expected
    actual = target.Label7
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Label6
'''</summary>
<TestMethod()>  _
Public Sub Label6Test()
Dim target As frmStats = New frmStats ' TODO: Initialize to an appropriate value
Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Label
    target.Label6 = expected
    actual = target.Label6
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Label5
'''</summary>
<TestMethod()>  _
Public Sub Label5Test()
Dim target As frmStats = New frmStats ' TODO: Initialize to an appropriate value
Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Label
    target.Label5 = expected
    actual = target.Label5
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Label4
'''</summary>
<TestMethod()>  _
Public Sub Label4Test()
Dim target As frmStats = New frmStats ' TODO: Initialize to an appropriate value
Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Label
    target.Label4 = expected
    actual = target.Label4
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Label3
'''</summary>
<TestMethod()>  _
Public Sub Label3Test()
Dim target As frmStats = New frmStats ' TODO: Initialize to an appropriate value
Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Label
    target.Label3 = expected
    actual = target.Label3
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Label2
'''</summary>
<TestMethod()>  _
Public Sub Label2Test()
Dim target As frmStats = New frmStats ' TODO: Initialize to an appropriate value
Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Label
    target.Label2 = expected
    actual = target.Label2
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Label1
'''</summary>
<TestMethod()>  _
Public Sub Label1Test()
Dim target As frmStats = New frmStats ' TODO: Initialize to an appropriate value
Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Label
    target.Label1 = expected
    actual = target.Label1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ImageList1
'''</summary>
<TestMethod()>  _
Public Sub ImageList1Test()
Dim target As frmStats = New frmStats ' TODO: Initialize to an appropriate value
Dim expected As ImageList = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ImageList
    target.ImageList1 = expected
    actual = target.ImageList1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for dtp_Period_Starting
'''</summary>
<TestMethod()>  _
Public Sub dtp_Period_StartingTest()
Dim target As frmStats = New frmStats ' TODO: Initialize to an appropriate value
Dim expected As DateTimePicker = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DateTimePicker
    target.dtp_Period_Starting = expected
    actual = target.dtp_Period_Starting
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for dtp_Period_Ending
'''</summary>
<TestMethod()>  _
Public Sub dtp_Period_EndingTest()
Dim target As frmStats = New frmStats ' TODO: Initialize to an appropriate value
Dim expected As DateTimePicker = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DateTimePicker
    target.dtp_Period_Ending = expected
    actual = target.dtp_Period_Ending
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for CFO_Letters_YearMonthTableAdapter
'''</summary>
<TestMethod()>  _
Public Sub CFO_Letters_YearMonthTableAdapterTest()
Dim target As frmStats = New frmStats ' TODO: Initialize to an appropriate value
Dim expected As CFO_Letters_YearMonthTableAdapter = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As CFO_Letters_YearMonthTableAdapter
    target.CFO_Letters_YearMonthTableAdapter = expected
    actual = target.CFO_Letters_YearMonthTableAdapter
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for CFO_Letters_YearMonthBindingSource
'''</summary>
<TestMethod()>  _
Public Sub CFO_Letters_YearMonthBindingSourceTest()
Dim target As frmStats = New frmStats ' TODO: Initialize to an appropriate value
Dim expected As BindingSource = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As BindingSource
    target.CFO_Letters_YearMonthBindingSource = expected
    actual = target.CFO_Letters_YearMonthBindingSource
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Button9
'''</summary>
<TestMethod()>  _
Public Sub Button9Test()
Dim target As frmStats = New frmStats ' TODO: Initialize to an appropriate value
Dim expected As Button = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Button
    target.Button9 = expected
    actual = target.Button9
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Button7
'''</summary>
<TestMethod()>  _
Public Sub Button7Test()
Dim target As frmStats = New frmStats ' TODO: Initialize to an appropriate value
Dim expected As Button = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Button
    target.Button7 = expected
    actual = target.Button7
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Button6
'''</summary>
<TestMethod()>  _
Public Sub Button6Test()
Dim target As frmStats = New frmStats ' TODO: Initialize to an appropriate value
Dim expected As Button = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Button
    target.Button6 = expected
    actual = target.Button6
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Button5
'''</summary>
<TestMethod()>  _
Public Sub Button5Test()
Dim target As frmStats = New frmStats ' TODO: Initialize to an appropriate value
Dim expected As Button = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Button
    target.Button5 = expected
    actual = target.Button5
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Button4
'''</summary>
<TestMethod()>  _
Public Sub Button4Test()
Dim target As frmStats = New frmStats ' TODO: Initialize to an appropriate value
Dim expected As Button = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Button
    target.Button4 = expected
    actual = target.Button4
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Button3
'''</summary>
<TestMethod()>  _
Public Sub Button3Test()
Dim target As frmStats = New frmStats ' TODO: Initialize to an appropriate value
Dim expected As Button = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Button
    target.Button3 = expected
    actual = target.Button3
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for btnResetPasswords
'''</summary>
<TestMethod()>  _
Public Sub btnResetPasswordsTest()
Dim target As frmStats = New frmStats ' TODO: Initialize to an appropriate value
Dim expected As Button = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Button
    target.btnResetPasswords = expected
    actual = target.btnResetPasswords
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for btnCalculate
'''</summary>
<TestMethod()>  _
Public Sub btnCalculateTest()
Dim target As frmStats = New frmStats ' TODO: Initialize to an appropriate value
Dim expected As Button = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Button
    target.btnCalculate = expected
    actual = target.btnCalculate
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Ads
'''</summary>
<TestMethod()>  _
Public Sub AdsTest()
Dim target As frmStats = New frmStats ' TODO: Initialize to an appropriate value
Dim expected As dsADS = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As dsADS
    target.Ads = expected
    actual = target.Ads
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for AdconsolelogTableAdapter1
'''</summary>
<TestMethod()>  _
Public Sub AdconsolelogTableAdapter1Test()
Dim target As frmStats = New frmStats ' TODO: Initialize to an appropriate value
Dim expected As ADCONSOLELOGTableAdapter = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ADCONSOLELOGTableAdapter
    target.AdconsolelogTableAdapter1 = expected
    actual = target.AdconsolelogTableAdapter1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for AD_SNAPSHOT_USER_COUNTTableAdapter
'''</summary>
<TestMethod()>  _
Public Sub AD_SNAPSHOT_USER_COUNTTableAdapterTest()
Dim target As frmStats = New frmStats ' TODO: Initialize to an appropriate value
Dim expected As AD_SNAPSHOT_USER_COUNTTableAdapter = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As AD_SNAPSHOT_USER_COUNTTableAdapter
    target.AD_SNAPSHOT_USER_COUNTTableAdapter = expected
    actual = target.AD_SNAPSHOT_USER_COUNTTableAdapter
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for AD_SNAPSHOT_USER_COUNTBindingSource
'''</summary>
<TestMethod()>  _
Public Sub AD_SNAPSHOT_USER_COUNTBindingSourceTest()
Dim target As frmStats = New frmStats ' TODO: Initialize to an appropriate value
Dim expected As BindingSource = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As BindingSource
    target.AD_SNAPSHOT_USER_COUNTBindingSource = expected
    actual = target.AD_SNAPSHOT_USER_COUNTBindingSource
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for AD_Disabled_UsersTableAdapter
'''</summary>
<TestMethod()>  _
Public Sub AD_Disabled_UsersTableAdapterTest()
Dim target As frmStats = New frmStats ' TODO: Initialize to an appropriate value
Dim expected As AD_Disabled_UsersTableAdapter = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As AD_Disabled_UsersTableAdapter
    target.AD_Disabled_UsersTableAdapter = expected
    actual = target.AD_Disabled_UsersTableAdapter
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for AD_Disabled_UsersBindingSource
'''</summary>
<TestMethod()>  _
Public Sub AD_Disabled_UsersBindingSourceTest()
Dim target As frmStats = New frmStats ' TODO: Initialize to an appropriate value
Dim expected As BindingSource = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As BindingSource
    target.AD_Disabled_UsersBindingSource = expected
    actual = target.AD_Disabled_UsersBindingSource
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for InitializeComponent
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub InitializeComponentTest()
Dim target As frmStats_Accessor = New frmStats_Accessor ' TODO: Initialize to an appropriate value
    target.InitializeComponent
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for Hourglass
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub HourglassTest()
Dim target As frmStats_Accessor = New frmStats_Accessor ' TODO: Initialize to an appropriate value
Dim Show As Boolean = false ' TODO: Initialize to an appropriate value
    target.Hourglass(Show)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for frmStats_Load
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub frmStats_LoadTest()
Dim target As frmStats_Accessor = New frmStats_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.frmStats_Load(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for frmStats_KeyPress
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub frmStats_KeyPressTest()
Dim target As frmStats_Accessor = New frmStats_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As KeyPressEventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.frmStats_KeyPress(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for dtp_Period_Ending_ValueChanged
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub dtp_Period_Ending_ValueChangedTest()
Dim target As frmStats_Accessor = New frmStats_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.dtp_Period_Ending_ValueChanged(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for Dispose
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub DisposeTest()
Dim target As frmStats_Accessor = New frmStats_Accessor ' TODO: Initialize to an appropriate value
Dim disposing As Boolean = false ' TODO: Initialize to an appropriate value
    target.Dispose(disposing)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for Button1_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub Button1_ClickTest()
Dim target As frmStats_Accessor = New frmStats_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.Button1_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for btnCalculate_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub btnCalculate_ClickTest()
Dim target As frmStats_Accessor = New frmStats_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.btnCalculate_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for AD_SNAPSHOT_USER_COUNTBindingNavigatorSaveItem_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub AD_SNAPSHOT_USER_COUNTBindingNavigatorSaveItem_ClickTest()
Dim target As frmStats_Accessor = New frmStats_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.AD_SNAPSHOT_USER_COUNTBindingNavigatorSaveItem_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for frmStats Constructor
'''</summary>
<TestMethod()>  _
Public Sub frmStatsConstructorTest()
    Dim target As frmStats = New frmStats
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub
End Class
