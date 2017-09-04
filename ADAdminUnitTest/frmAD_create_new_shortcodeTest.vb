Imports System.Windows.Forms

Imports System

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports ADAdminDotNet



'''<summary>
'''This is a test class for frmAD_create_new_shortcodeTest and is intended
'''to contain all frmAD_create_new_shortcodeTest Unit Tests
'''</summary>
<TestClass()> _
Public Class frmAD_create_new_shortcodeTest


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
'''A test for txtShortCode
'''</summary>
<TestMethod()>  _
Public Sub txtShortCodeTest()
Dim target As frmAD_create_new_shortcode = New frmAD_create_new_shortcode ' TODO: Initialize to an appropriate value
Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TextBox
    target.txtShortCode = expected
    actual = target.txtShortCode
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Label1
'''</summary>
<TestMethod()>  _
Public Sub Label1Test()
Dim target As frmAD_create_new_shortcode = New frmAD_create_new_shortcode ' TODO: Initialize to an appropriate value
Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Label
    target.Label1 = expected
    actual = target.Label1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Button1
'''</summary>
<TestMethod()>  _
Public Sub Button1Test()
Dim target As frmAD_create_new_shortcode = New frmAD_create_new_shortcode ' TODO: Initialize to an appropriate value
Dim expected As Button = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Button
    target.Button1 = expected
    actual = target.Button1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for InitializeComponent
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub InitializeComponentTest()
Dim target As frmAD_create_new_shortcode_Accessor = New frmAD_create_new_shortcode_Accessor ' TODO: Initialize to an appropriate value
    target.InitializeComponent
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for Dispose
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub DisposeTest()
Dim target As frmAD_create_new_shortcode_Accessor = New frmAD_create_new_shortcode_Accessor ' TODO: Initialize to an appropriate value
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
Dim target As frmAD_create_new_shortcode_Accessor = New frmAD_create_new_shortcode_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.Button1_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for frmAD_create_new_shortcode Constructor
'''</summary>
<TestMethod()>  _
Public Sub frmAD_create_new_shortcodeConstructorTest()
    Dim target As frmAD_create_new_shortcode = New frmAD_create_new_shortcode
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub
End Class
