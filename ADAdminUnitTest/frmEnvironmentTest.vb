Imports ADAdminDotNet.dsADSTableAdapters

Imports System.Windows.Forms

Imports System

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports ADAdminDotNet



'''<summary>
'''This is a test class for frmEnvironmentTest and is intended
'''to contain all frmEnvironmentTest Unit Tests
'''</summary>
<TestClass()> _
Public Class frmEnvironmentTest


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
'''A test for ToolStripSeparator2
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator2Test()
Dim target As frmEnvironment = New frmEnvironment ' TODO: Initialize to an appropriate value
Dim expected As ToolStripSeparator = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator2 = expected
    actual = target.ToolStripSeparator2
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStrip
'''</summary>
<TestMethod()>  _
Public Sub ToolStripTest()
Dim target As frmEnvironment = New frmEnvironment ' TODO: Initialize to an appropriate value
Dim expected As ToolStrip = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStrip
    target.ToolStrip = expected
    actual = target.ToolStrip
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Timer1
'''</summary>
<TestMethod()>  _
Public Sub Timer1Test()
Dim target As frmEnvironment = New frmEnvironment ' TODO: Initialize to an appropriate value
Dim expected As Timer = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Timer
    target.Timer1 = expected
    actual = target.Timer1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for KICKOUTTableAdapter
'''</summary>
<TestMethod()>  _
Public Sub KICKOUTTableAdapterTest()
Dim target As frmEnvironment = New frmEnvironment ' TODO: Initialize to an appropriate value
Dim expected As KICKOUTTableAdapter = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As KICKOUTTableAdapter
    target.KICKOUTTableAdapter = expected
    actual = target.KICKOUTTableAdapter
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for KICKOUTBindingSource
'''</summary>
<TestMethod()>  _
Public Sub KICKOUTBindingSourceTest()
Dim target As frmEnvironment = New frmEnvironment ' TODO: Initialize to an appropriate value
Dim expected As BindingSource = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As BindingSource
    target.KICKOUTBindingSource = expected
    actual = target.KICKOUTBindingSource
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for btnQa
'''</summary>
<TestMethod()>  _
Public Sub btnQaTest()
Dim target As frmEnvironment = New frmEnvironment ' TODO: Initialize to an appropriate value
Dim expected As ToolStripButton = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripButton
    target.btnQa = expected
    actual = target.btnQa
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for btnPRD
'''</summary>
<TestMethod()>  _
Public Sub btnPRDTest()
Dim target As frmEnvironment = New frmEnvironment ' TODO: Initialize to an appropriate value
Dim expected As ToolStripButton = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripButton
    target.btnPRD = expected
    actual = target.btnPRD
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for AutomationTimer
'''</summary>
<TestMethod()>  _
Public Sub AutomationTimerTest()
Dim target As frmEnvironment = New frmEnvironment ' TODO: Initialize to an appropriate value
Dim expected As Timer = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Timer
    target.AutomationTimer = expected
    actual = target.AutomationTimer
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Ads
'''</summary>
<TestMethod()>  _
Public Sub AdsTest()
Dim target As frmEnvironment = New frmEnvironment ' TODO: Initialize to an appropriate value
Dim expected As dsADS = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As dsADS
    target.Ads = expected
    actual = target.Ads
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for KICKOUTBindingNavigatorSaveItem_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub KICKOUTBindingNavigatorSaveItem_ClickTest()
Dim target As frmEnvironment_Accessor = New frmEnvironment_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.KICKOUTBindingNavigatorSaveItem_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for InitializeComponent
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub InitializeComponentTest()
Dim target As frmEnvironment_Accessor = New frmEnvironment_Accessor ' TODO: Initialize to an appropriate value
    target.InitializeComponent
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for frmEnvironment_Load
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub frmEnvironment_LoadTest()
Dim target As frmEnvironment_Accessor = New frmEnvironment_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.frmEnvironment_Load(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for frmEnvironment_FormClosing
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub frmEnvironment_FormClosingTest()
Dim target As frmEnvironment_Accessor = New frmEnvironment_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As FormClosingEventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.frmEnvironment_FormClosing(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for Environment
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub EnvironmentTest()
Dim target As frmEnvironment_Accessor = New frmEnvironment_Accessor ' TODO: Initialize to an appropriate value
Dim btnName As String = String.Empty ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.Environment(btnName, sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for Dispose
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub DisposeTest()
Dim target As frmEnvironment_Accessor = New frmEnvironment_Accessor ' TODO: Initialize to an appropriate value
Dim disposing As Boolean = false ' TODO: Initialize to an appropriate value
    target.Dispose(disposing)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for btnQA_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub btnQA_ClickTest()
Dim target As frmEnvironment_Accessor = New frmEnvironment_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.btnQA_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for btnPRD_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub btnPRD_ClickTest()
Dim target As frmEnvironment_Accessor = New frmEnvironment_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.btnPRD_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for AutomationTimer_Tick
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub AutomationTimer_TickTest()
Dim target As frmEnvironment_Accessor = New frmEnvironment_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.AutomationTimer_Tick(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for frmEnvironment Constructor
'''</summary>
<TestMethod()>  _
Public Sub frmEnvironmentConstructorTest()
    Dim target As frmEnvironment = New frmEnvironment
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub
End Class
