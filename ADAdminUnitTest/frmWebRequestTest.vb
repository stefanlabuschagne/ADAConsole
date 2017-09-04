Imports ADAdminDotNet.dsADSTableAdapters

Imports System

Imports System.Windows.Forms

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports ADAdminDotNet



'''<summary>
'''This is a test class for frmWebRequestTest and is intended
'''to contain all frmWebRequestTest Unit Tests
'''</summary>
<TestClass()> _
Public Class frmWebRequestTest


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
'''A test for VIP_USERSTableAdapter
'''</summary>
<TestMethod()>  _
Public Sub VIP_USERSTableAdapterTest()
Dim target As frmWebRequest = New frmWebRequest ' TODO: Initialize to an appropriate value
Dim expected As VIP_USERSTableAdapter = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As VIP_USERSTableAdapter
    target.VIP_USERSTableAdapter = expected
    actual = target.VIP_USERSTableAdapter
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for VIP_USERSBindingSource1
'''</summary>
<TestMethod()>  _
Public Sub VIP_USERSBindingSource1Test()
Dim target As frmWebRequest = New frmWebRequest ' TODO: Initialize to an appropriate value
Dim expected As BindingSource = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As BindingSource
    target.VIP_USERSBindingSource1 = expected
    actual = target.VIP_USERSBindingSource1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for USERIDTextBox
'''</summary>
<TestMethod()>  _
Public Sub USERIDTextBoxTest()
Dim target As frmWebRequest = New frmWebRequest ' TODO: Initialize to an appropriate value
Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TextBox
    target.USERIDTextBox = expected
    actual = target.USERIDTextBox
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for TITLETextBox
'''</summary>
<TestMethod()>  _
Public Sub TITLETextBoxTest()
Dim target As frmWebRequest = New frmWebRequest ' TODO: Initialize to an appropriate value
Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TextBox
    target.TITLETextBox = expected
    actual = target.TITLETextBox
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for SURNAMETextBox
'''</summary>
<TestMethod()>  _
Public Sub SURNAMETextBoxTest()
Dim target As frmWebRequest = New frmWebRequest ' TODO: Initialize to an appropriate value
Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TextBox
    target.SURNAMETextBox = expected
    actual = target.SURNAMETextBox
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for RESPONSIBILITYTextBox
'''</summary>
<TestMethod()>  _
Public Sub RESPONSIBILITYTextBoxTest()
Dim target As frmWebRequest = New frmWebRequest ' TODO: Initialize to an appropriate value
Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TextBox
    target.RESPONSIBILITYTextBox = expected
    actual = target.RESPONSIBILITYTextBox
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for RESET_PASSWORDCheckBox
'''</summary>
<TestMethod()>  _
Public Sub RESET_PASSWORDCheckBoxTest()
Dim target As frmWebRequest = New frmWebRequest ' TODO: Initialize to an appropriate value
Dim expected As CheckBox = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As CheckBox
    target.RESET_PASSWORDCheckBox = expected
    actual = target.RESET_PASSWORDCheckBox
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for REQ_LOGISTextBox
'''</summary>
<TestMethod()>  _
Public Sub REQ_LOGISTextBoxTest()
Dim target As frmWebRequest = New frmWebRequest ' TODO: Initialize to an appropriate value
Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TextBox
    target.REQ_LOGISTextBox = expected
    actual = target.REQ_LOGISTextBox
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for REQ_HRTextBox
'''</summary>
<TestMethod()>  _
Public Sub REQ_HRTextBoxTest()
Dim target As frmWebRequest = New frmWebRequest ' TODO: Initialize to an appropriate value
Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TextBox
    target.REQ_HRTextBox = expected
    actual = target.REQ_HRTextBox
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for REQ_GFSTextBox
'''</summary>
<TestMethod()>  _
Public Sub REQ_GFSTextBoxTest()
Dim target As frmWebRequest = New frmWebRequest ' TODO: Initialize to an appropriate value
Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TextBox
    target.REQ_GFSTextBox = expected
    actual = target.REQ_GFSTextBox
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for REQ_FINANCIALSTextBox
'''</summary>
<TestMethod()>  _
Public Sub REQ_FINANCIALSTextBoxTest()
Dim target As frmWebRequest = New frmWebRequest ' TODO: Initialize to an appropriate value
Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TextBox
    target.REQ_FINANCIALSTextBox = expected
    actual = target.REQ_FINANCIALSTextBox
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for REQ_DPSATextBox
'''</summary>
<TestMethod()>  _
Public Sub REQ_DPSATextBoxTest()
Dim target As frmWebRequest = New frmWebRequest ' TODO: Initialize to an appropriate value
Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TextBox
    target.REQ_DPSATextBox = expected
    actual = target.REQ_DPSATextBox
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for RANKTextBox
'''</summary>
<TestMethod()>  _
Public Sub RANKTextBoxTest()
Dim target As frmWebRequest = New frmWebRequest ' TODO: Initialize to an appropriate value
Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TextBox
    target.RANKTextBox = expected
    actual = target.RANKTextBox
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for NOTESTextBox
'''</summary>
<TestMethod()>  _
Public Sub NOTESTextBoxTest()
Dim target As frmWebRequest = New frmWebRequest ' TODO: Initialize to an appropriate value
Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TextBox
    target.NOTESTextBox = expected
    actual = target.NOTESTextBox
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IdToolStripTextBox
'''</summary>
<TestMethod()>  _
Public Sub IdToolStripTextBoxTest()
Dim target As frmWebRequest = New frmWebRequest ' TODO: Initialize to an appropriate value
Dim expected As ToolStripTextBox = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripTextBox
    target.IdToolStripTextBox = expected
    actual = target.IdToolStripTextBox
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IdToolStripLabel
'''</summary>
<TestMethod()>  _
Public Sub IdToolStripLabelTest()
Dim target As frmWebRequest = New frmWebRequest ' TODO: Initialize to an appropriate value
Dim expected As ToolStripLabel = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripLabel
    target.IdToolStripLabel = expected
    actual = target.IdToolStripLabel
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IDTextBox
'''</summary>
<TestMethod()>  _
Public Sub IDTextBoxTest()
Dim target As frmWebRequest = New frmWebRequest ' TODO: Initialize to an appropriate value
Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TextBox
    target.IDTextBox = expected
    actual = target.IDTextBox
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for GroupBox3
'''</summary>
<TestMethod()>  _
Public Sub GroupBox3Test()
Dim target As frmWebRequest = New frmWebRequest ' TODO: Initialize to an appropriate value
Dim expected As GroupBox = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As GroupBox
    target.GroupBox3 = expected
    actual = target.GroupBox3
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for GroupBox2
'''</summary>
<TestMethod()>  _
Public Sub GroupBox2Test()
Dim target As frmWebRequest = New frmWebRequest ' TODO: Initialize to an appropriate value
Dim expected As GroupBox = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As GroupBox
    target.GroupBox2 = expected
    actual = target.GroupBox2
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for GroupBox1
'''</summary>
<TestMethod()>  _
Public Sub GroupBox1Test()
Dim target As frmWebRequest = New frmWebRequest ' TODO: Initialize to an appropriate value
Dim expected As GroupBox = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As GroupBox
    target.GroupBox1 = expected
    actual = target.GroupBox1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for GetByID1ToolStripButton
'''</summary>
<TestMethod()>  _
Public Sub GetByID1ToolStripButtonTest()
Dim target As frmWebRequest = New frmWebRequest ' TODO: Initialize to an appropriate value
Dim expected As ToolStripButton = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripButton
    target.GetByID1ToolStripButton = expected
    actual = target.GetByID1ToolStripButton
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for GetByID1ToolStrip
'''</summary>
<TestMethod()>  _
Public Sub GetByID1ToolStripTest()
Dim target As frmWebRequest = New frmWebRequest ' TODO: Initialize to an appropriate value
Dim expected As ToolStrip = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStrip
    target.GetByID1ToolStrip = expected
    actual = target.GetByID1ToolStrip
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for FIRSTNAMETextBox
'''</summary>
<TestMethod()>  _
Public Sub FIRSTNAMETextBoxTest()
Dim target As frmWebRequest = New frmWebRequest ' TODO: Initialize to an appropriate value
Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TextBox
    target.FIRSTNAMETextBox = expected
    actual = target.FIRSTNAMETextBox
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for FAX_TELTextBox
'''</summary>
<TestMethod()>  _
Public Sub FAX_TELTextBoxTest()
Dim target As frmWebRequest = New frmWebRequest ' TODO: Initialize to an appropriate value
Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TextBox
    target.FAX_TELTextBox = expected
    actual = target.FAX_TELTextBox
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for EXPORTEDDateTimePicker
'''</summary>
<TestMethod()>  _
Public Sub EXPORTEDDateTimePickerTest()
Dim target As frmWebRequest = New frmWebRequest ' TODO: Initialize to an appropriate value
Dim expected As DateTimePicker = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DateTimePicker
    target.EXPORTEDDateTimePicker = expected
    actual = target.EXPORTEDDateTimePicker
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for EMAILTextBox
'''</summary>
<TestMethod()>  _
Public Sub EMAILTextBoxTest()
Dim target As frmWebRequest = New frmWebRequest ' TODO: Initialize to an appropriate value
Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TextBox
    target.EMAILTextBox = expected
    actual = target.EMAILTextBox
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DOWNLOADEDBYTextBox
'''</summary>
<TestMethod()>  _
Public Sub DOWNLOADEDBYTextBoxTest()
Dim target As frmWebRequest = New frmWebRequest ' TODO: Initialize to an appropriate value
Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TextBox
    target.DOWNLOADEDBYTextBox = expected
    actual = target.DOWNLOADEDBYTextBox
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for CREATEDDateTimePicker
'''</summary>
<TestMethod()>  _
Public Sub CREATEDDateTimePickerTest()
Dim target As frmWebRequest = New frmWebRequest ' TODO: Initialize to an appropriate value
Dim expected As DateTimePicker = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DateTimePicker
    target.CREATEDDateTimePicker = expected
    actual = target.CREATEDDateTimePicker
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for CEL_TELTextBox
'''</summary>
<TestMethod()>  _
Public Sub CEL_TELTextBoxTest()
Dim target As frmWebRequest = New frmWebRequest ' TODO: Initialize to an appropriate value
Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TextBox
    target.CEL_TELTextBox = expected
    actual = target.CEL_TELTextBox
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for BUS_TELTextBox
'''</summary>
<TestMethod()>  _
Public Sub BUS_TELTextBoxTest()
Dim target As frmWebRequest = New frmWebRequest ' TODO: Initialize to an appropriate value
Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TextBox
    target.BUS_TELTextBox = expected
    actual = target.BUS_TELTextBox
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Ads
'''</summary>
<TestMethod()>  _
Public Sub AdsTest()
Dim target As frmWebRequest = New frmWebRequest ' TODO: Initialize to an appropriate value
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
Dim target As frmWebRequest_Accessor = New frmWebRequest_Accessor ' TODO: Initialize to an appropriate value
    target.InitializeComponent
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for GetByID1ToolStripButton_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub GetByID1ToolStripButton_ClickTest()
Dim target As frmWebRequest_Accessor = New frmWebRequest_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.GetByID1ToolStripButton_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for frmWebRequest_Load
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub frmWebRequest_LoadTest()
Dim target As frmWebRequest_Accessor = New frmWebRequest_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.frmWebRequest_Load(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for frmWebRequest_KeyPress
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub frmWebRequest_KeyPressTest()
Dim target As frmWebRequest_Accessor = New frmWebRequest_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As KeyPressEventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.frmWebRequest_KeyPress(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for Finalize
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub FinalizeTest()
Dim target As frmWebRequest_Accessor = New frmWebRequest_Accessor ' TODO: Initialize to an appropriate value
    target.Finalize
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for Dispose
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub DisposeTest()
Dim target As frmWebRequest_Accessor = New frmWebRequest_Accessor ' TODO: Initialize to an appropriate value
Dim disposing As Boolean = false ' TODO: Initialize to an appropriate value
    target.Dispose(disposing)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for frmWebRequest Constructor
'''</summary>
<TestMethod()>  _
Public Sub frmWebRequestConstructorTest()
    Dim target As frmWebRequest = New frmWebRequest
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub
End Class
