Imports ADAdminDotNet.dsADSTableAdapters

Imports System.Windows.Forms

Imports System

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports ADAdminDotNet



'''<summary>
'''This is a test class for frmUsersNotOnEstabTest and is intended
'''to contain all frmUsersNotOnEstabTest Unit Tests
'''</summary>
<TestClass()> _
Public Class frmUsersNotOnEstabTest


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
'''A test for txt_Not_On_Estab_Thismonth
'''</summary>
<TestMethod()>  _
Public Sub txt_Not_On_Estab_ThismonthTest()
Dim target As frmUsersNotOnEstab = New frmUsersNotOnEstab ' TODO: Initialize to an appropriate value
Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TextBox
    target.txt_Not_On_Estab_Thismonth = expected
    actual = target.txt_Not_On_Estab_Thismonth
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for TabPage1
'''</summary>
<TestMethod()>  _
Public Sub TabPage1Test()
Dim target As frmUsersNotOnEstab = New frmUsersNotOnEstab ' TODO: Initialize to an appropriate value
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
Dim target As frmUsersNotOnEstab = New frmUsersNotOnEstab ' TODO: Initialize to an appropriate value
Dim expected As TabControl = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TabControl
    target.TabControl1 = expected
    actual = target.TabControl1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Not_On_Estab_Thismonth_CountTableAdapter
'''</summary>
<TestMethod()>  _
Public Sub Not_On_Estab_Thismonth_CountTableAdapterTest()
Dim target As frmUsersNotOnEstab = New frmUsersNotOnEstab ' TODO: Initialize to an appropriate value
Dim expected As Not_On_Estab_Thismonth_CountTableAdapter = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Not_On_Estab_Thismonth_CountTableAdapter
    target.Not_On_Estab_Thismonth_CountTableAdapter = expected
    actual = target.Not_On_Estab_Thismonth_CountTableAdapter
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Not_On_Estab_Thismonth_CountBindingSource
'''</summary>
<TestMethod()>  _
Public Sub Not_On_Estab_Thismonth_CountBindingSourceTest()
Dim target As frmUsersNotOnEstab = New frmUsersNotOnEstab ' TODO: Initialize to an appropriate value
Dim expected As BindingSource = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As BindingSource
    target.Not_On_Estab_Thismonth_CountBindingSource = expected
    actual = target.Not_On_Estab_Thismonth_CountBindingSource
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Label3
'''</summary>
<TestMethod()>  _
Public Sub Label3Test()
Dim target As frmUsersNotOnEstab = New frmUsersNotOnEstab ' TODO: Initialize to an appropriate value
Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Label
    target.Label3 = expected
    actual = target.Label3
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Button5
'''</summary>
<TestMethod()>  _
Public Sub Button5Test()
Dim target As frmUsersNotOnEstab = New frmUsersNotOnEstab ' TODO: Initialize to an appropriate value
Dim expected As Button = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Button
    target.Button5 = expected
    actual = target.Button5
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Button2
'''</summary>
<TestMethod()>  _
Public Sub Button2Test()
Dim target As frmUsersNotOnEstab = New frmUsersNotOnEstab ' TODO: Initialize to an appropriate value
Dim expected As Button = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Button
    target.Button2 = expected
    actual = target.Button2
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Button1
'''</summary>
<TestMethod()>  _
Public Sub Button1Test()
Dim target As frmUsersNotOnEstab = New frmUsersNotOnEstab ' TODO: Initialize to an appropriate value
Dim expected As Button = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Button
    target.Button1 = expected
    actual = target.Button1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Ads
'''</summary>
<TestMethod()>  _
Public Sub AdsTest()
Dim target As frmUsersNotOnEstab = New frmUsersNotOnEstab ' TODO: Initialize to an appropriate value
Dim expected As dsADS = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As dsADS
    target.Ads = expected
    actual = target.Ads
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for InitializeComponent
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub InitializeComponentTest()
Dim target As frmUsersNotOnEstab_Accessor = New frmUsersNotOnEstab_Accessor ' TODO: Initialize to an appropriate value
    target.InitializeComponent
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for Hourglass
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub HourglassTest()
Dim target As frmUsersNotOnEstab_Accessor = New frmUsersNotOnEstab_Accessor ' TODO: Initialize to an appropriate value
Dim Show As Boolean = false ' TODO: Initialize to an appropriate value
    target.Hourglass(Show)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for frmUsersNotOnEstab_KeyPress
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub frmUsersNotOnEstab_KeyPressTest()
Dim target As frmUsersNotOnEstab_Accessor = New frmUsersNotOnEstab_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As KeyPressEventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.frmUsersNotOnEstab_KeyPress(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for Dispose
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub DisposeTest()
Dim target As frmUsersNotOnEstab_Accessor = New frmUsersNotOnEstab_Accessor ' TODO: Initialize to an appropriate value
Dim disposing As Boolean = false ' TODO: Initialize to an appropriate value
    target.Dispose(disposing)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for Button2_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub Button2_ClickTest()
Dim target As frmUsersNotOnEstab_Accessor = New frmUsersNotOnEstab_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.Button2_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for frmUsersNotOnEstab Constructor
'''</summary>
<TestMethod()>  _
Public Sub frmUsersNotOnEstabConstructorTest()
    Dim target As frmUsersNotOnEstab = New frmUsersNotOnEstab
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub
End Class
