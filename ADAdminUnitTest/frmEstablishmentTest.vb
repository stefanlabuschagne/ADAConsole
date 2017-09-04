Imports ADAdminDotNet.dsADSTableAdapters

Imports System

Imports System.Windows.Forms

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports ADAdminDotNet



'''<summary>
'''This is a test class for frmEstablishmentTest and is intended
'''to contain all frmEstablishmentTest Unit Tests
'''</summary>
<TestClass()> _
Public Class frmEstablishmentTest


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
'''A test for txtSCODE
'''</summary>
<TestMethod()>  _
Public Sub txtSCODETest()
Dim target As frmEstablishment = New frmEstablishment ' TODO: Initialize to an appropriate value
Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TextBox
    target.txtSCODE = expected
    actual = target.txtSCODE
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for txtNAME
'''</summary>
<TestMethod()>  _
Public Sub txtNAMETest()
Dim target As frmEstablishment = New frmEstablishment ' TODO: Initialize to an appropriate value
Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TextBox
    target.txtNAME = expected
    actual = target.txtNAME
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for txtJOBTITLE
'''</summary>
<TestMethod()>  _
Public Sub txtJOBTITLETest()
Dim target As frmEstablishment = New frmEstablishment ' TODO: Initialize to an appropriate value
Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TextBox
    target.txtJOBTITLE = expected
    actual = target.txtJOBTITLE
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripDropDownButton1
'''</summary>
<TestMethod()>  _
Public Sub ToolStripDropDownButton1Test()
Dim target As frmEstablishment = New frmEstablishment ' TODO: Initialize to an appropriate value
Dim expected As ToolStripDropDownButton = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripDropDownButton
    target.ToolStripDropDownButton1 = expected
    actual = target.ToolStripDropDownButton1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Ta_Establishment
'''</summary>
<TestMethod()>  _
Public Sub Ta_EstablishmentTest()
Dim target As frmEstablishment = New frmEstablishment ' TODO: Initialize to an appropriate value
Dim expected As ta_Establishment = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ta_Establishment
    target.Ta_Establishment = expected
    actual = target.Ta_Establishment
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for StatusStrip1
'''</summary>
<TestMethod()>  _
Public Sub StatusStrip1Test()
Dim target As frmEstablishment = New frmEstablishment ' TODO: Initialize to an appropriate value
Dim expected As StatusStrip = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As StatusStrip
    target.StatusStrip1 = expected
    actual = target.StatusStrip1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Label3
'''</summary>
<TestMethod()>  _
Public Sub Label3Test()
Dim target As frmEstablishment = New frmEstablishment ' TODO: Initialize to an appropriate value
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
Dim target As frmEstablishment = New frmEstablishment ' TODO: Initialize to an appropriate value
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
Dim target As frmEstablishment = New frmEstablishment ' TODO: Initialize to an appropriate value
Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Label
    target.Label1 = expected
    actual = target.Label1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ExportAllToCSVToolStripMenuItem
'''</summary>
<TestMethod()>  _
Public Sub ExportAllToCSVToolStripMenuItemTest()
Dim target As frmEstablishment = New frmEstablishment ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ExportAllToCSVToolStripMenuItem = expected
    actual = target.ExportAllToCSVToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for EstablishmentDataGridView
'''</summary>
<TestMethod()>  _
Public Sub EstablishmentDataGridViewTest()
Dim target As frmEstablishment = New frmEstablishment ' TODO: Initialize to an appropriate value
Dim expected As DataGridView = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridView
    target.EstablishmentDataGridView = expected
    actual = target.EstablishmentDataGridView
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for EstablishmentBindingSource
'''</summary>
<TestMethod()>  _
Public Sub EstablishmentBindingSourceTest()
Dim target As frmEstablishment = New frmEstablishment ' TODO: Initialize to an appropriate value
Dim expected As BindingSource = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As BindingSource
    target.EstablishmentBindingSource = expected
    actual = target.EstablishmentBindingSource
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for EstablishmentBindingNavigator
'''</summary>
<TestMethod()>  _
Public Sub EstablishmentBindingNavigatorTest()
Dim target As frmEstablishment = New frmEstablishment ' TODO: Initialize to an appropriate value
Dim expected As BindingNavigator = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As BindingNavigator
    target.EstablishmentBindingNavigator = expected
    actual = target.EstablishmentBindingNavigator
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DataGridViewTextBoxColumn9
'''</summary>
<TestMethod()>  _
Public Sub DataGridViewTextBoxColumn9Test()
Dim target As frmEstablishment = New frmEstablishment ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.DataGridViewTextBoxColumn9 = expected
    actual = target.DataGridViewTextBoxColumn9
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DataGridViewTextBoxColumn8
'''</summary>
<TestMethod()>  _
Public Sub DataGridViewTextBoxColumn8Test()
Dim target As frmEstablishment = New frmEstablishment ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.DataGridViewTextBoxColumn8 = expected
    actual = target.DataGridViewTextBoxColumn8
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DataGridViewTextBoxColumn7
'''</summary>
<TestMethod()>  _
Public Sub DataGridViewTextBoxColumn7Test()
Dim target As frmEstablishment = New frmEstablishment ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.DataGridViewTextBoxColumn7 = expected
    actual = target.DataGridViewTextBoxColumn7
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DataGridViewTextBoxColumn6
'''</summary>
<TestMethod()>  _
Public Sub DataGridViewTextBoxColumn6Test()
Dim target As frmEstablishment = New frmEstablishment ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.DataGridViewTextBoxColumn6 = expected
    actual = target.DataGridViewTextBoxColumn6
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DataGridViewTextBoxColumn5
'''</summary>
<TestMethod()>  _
Public Sub DataGridViewTextBoxColumn5Test()
Dim target As frmEstablishment = New frmEstablishment ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.DataGridViewTextBoxColumn5 = expected
    actual = target.DataGridViewTextBoxColumn5
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DataGridViewTextBoxColumn4
'''</summary>
<TestMethod()>  _
Public Sub DataGridViewTextBoxColumn4Test()
Dim target As frmEstablishment = New frmEstablishment ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.DataGridViewTextBoxColumn4 = expected
    actual = target.DataGridViewTextBoxColumn4
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DataGridViewTextBoxColumn3
'''</summary>
<TestMethod()>  _
Public Sub DataGridViewTextBoxColumn3Test()
Dim target As frmEstablishment = New frmEstablishment ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.DataGridViewTextBoxColumn3 = expected
    actual = target.DataGridViewTextBoxColumn3
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DataGridViewTextBoxColumn2
'''</summary>
<TestMethod()>  _
Public Sub DataGridViewTextBoxColumn2Test()
Dim target As frmEstablishment = New frmEstablishment ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.DataGridViewTextBoxColumn2 = expected
    actual = target.DataGridViewTextBoxColumn2
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DataGridViewTextBoxColumn10
'''</summary>
<TestMethod()>  _
Public Sub DataGridViewTextBoxColumn10Test()
Dim target As frmEstablishment = New frmEstablishment ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.DataGridViewTextBoxColumn10 = expected
    actual = target.DataGridViewTextBoxColumn10
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DataGridViewTextBoxColumn1
'''</summary>
<TestMethod()>  _
Public Sub DataGridViewTextBoxColumn1Test()
Dim target As frmEstablishment = New frmEstablishment ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.DataGridViewTextBoxColumn1 = expected
    actual = target.DataGridViewTextBoxColumn1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for BindingNavigatorSeparator2
'''</summary>
<TestMethod()>  _
Public Sub BindingNavigatorSeparator2Test()
Dim target As frmEstablishment = New frmEstablishment ' TODO: Initialize to an appropriate value
Dim expected As ToolStripSeparator = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripSeparator
    target.BindingNavigatorSeparator2 = expected
    actual = target.BindingNavigatorSeparator2
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for BindingNavigatorSeparator1
'''</summary>
<TestMethod()>  _
Public Sub BindingNavigatorSeparator1Test()
Dim target As frmEstablishment = New frmEstablishment ' TODO: Initialize to an appropriate value
Dim expected As ToolStripSeparator = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripSeparator
    target.BindingNavigatorSeparator1 = expected
    actual = target.BindingNavigatorSeparator1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for BindingNavigatorSeparator
'''</summary>
<TestMethod()>  _
Public Sub BindingNavigatorSeparatorTest()
Dim target As frmEstablishment = New frmEstablishment ' TODO: Initialize to an appropriate value
Dim expected As ToolStripSeparator = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripSeparator
    target.BindingNavigatorSeparator = expected
    actual = target.BindingNavigatorSeparator
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for BindingNavigatorPositionItem
'''</summary>
<TestMethod()>  _
Public Sub BindingNavigatorPositionItemTest()
Dim target As frmEstablishment = New frmEstablishment ' TODO: Initialize to an appropriate value
Dim expected As ToolStripTextBox = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripTextBox
    target.BindingNavigatorPositionItem = expected
    actual = target.BindingNavigatorPositionItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for BindingNavigatorMovePreviousItem
'''</summary>
<TestMethod()>  _
Public Sub BindingNavigatorMovePreviousItemTest()
Dim target As frmEstablishment = New frmEstablishment ' TODO: Initialize to an appropriate value
Dim expected As ToolStripButton = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripButton
    target.BindingNavigatorMovePreviousItem = expected
    actual = target.BindingNavigatorMovePreviousItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for BindingNavigatorMoveNextItem
'''</summary>
<TestMethod()>  _
Public Sub BindingNavigatorMoveNextItemTest()
Dim target As frmEstablishment = New frmEstablishment ' TODO: Initialize to an appropriate value
Dim expected As ToolStripButton = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripButton
    target.BindingNavigatorMoveNextItem = expected
    actual = target.BindingNavigatorMoveNextItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for BindingNavigatorMoveLastItem
'''</summary>
<TestMethod()>  _
Public Sub BindingNavigatorMoveLastItemTest()
Dim target As frmEstablishment = New frmEstablishment ' TODO: Initialize to an appropriate value
Dim expected As ToolStripButton = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripButton
    target.BindingNavigatorMoveLastItem = expected
    actual = target.BindingNavigatorMoveLastItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for BindingNavigatorMoveFirstItem
'''</summary>
<TestMethod()>  _
Public Sub BindingNavigatorMoveFirstItemTest()
Dim target As frmEstablishment = New frmEstablishment ' TODO: Initialize to an appropriate value
Dim expected As ToolStripButton = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripButton
    target.BindingNavigatorMoveFirstItem = expected
    actual = target.BindingNavigatorMoveFirstItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for BindingNavigatorCountItem
'''</summary>
<TestMethod()>  _
Public Sub BindingNavigatorCountItemTest()
Dim target As frmEstablishment = New frmEstablishment ' TODO: Initialize to an appropriate value
Dim expected As ToolStripLabel = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripLabel
    target.BindingNavigatorCountItem = expected
    actual = target.BindingNavigatorCountItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Ads
'''</summary>
<TestMethod()>  _
Public Sub AdsTest()
Dim target As frmEstablishment = New frmEstablishment ' TODO: Initialize to an appropriate value
Dim expected As dsADS = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As dsADS
    target.Ads = expected
    actual = target.Ads
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for txtSCODE_TextChanged
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub txtSCODE_TextChangedTest()
Dim target As frmEstablishment_Accessor = New frmEstablishment_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.txtSCODE_TextChanged(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for txtNAME_TextChanged_1
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub txtNAME_TextChanged_1Test()
Dim target As frmEstablishment_Accessor = New frmEstablishment_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.txtNAME_TextChanged_1(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for txtJOBTITLE_TextChanged
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub txtJOBTITLE_TextChangedTest()
Dim target As frmEstablishment_Accessor = New frmEstablishment_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.txtJOBTITLE_TextChanged(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for InitializeComponent
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub InitializeComponentTest()
Dim target As frmEstablishment_Accessor = New frmEstablishment_Accessor ' TODO: Initialize to an appropriate value
    target.InitializeComponent
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for frmEstablishment_KeyPress
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub frmEstablishment_KeyPressTest()
Dim target As frmEstablishment_Accessor = New frmEstablishment_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As KeyPressEventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.frmEstablishment_KeyPress(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for ExportAllToCSVToolStripMenuItem_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ExportAllToCSVToolStripMenuItem_ClickTest()
Dim target As frmEstablishment_Accessor = New frmEstablishment_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.ExportAllToCSVToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for EstablishmentDataGridView_KeyUp
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub EstablishmentDataGridView_KeyUpTest()
Dim target As frmEstablishment_Accessor = New frmEstablishment_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As KeyEventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.EstablishmentDataGridView_KeyUp(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for EstablishmentDataGridView_CellContentClick
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub EstablishmentDataGridView_CellContentClickTest()
Dim target As frmEstablishment_Accessor = New frmEstablishment_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As DataGridViewCellEventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.EstablishmentDataGridView_CellContentClick(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for Dispose
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub DisposeTest()
Dim target As frmEstablishment_Accessor = New frmEstablishment_Accessor ' TODO: Initialize to an appropriate value
Dim disposing As Boolean = false ' TODO: Initialize to an appropriate value
    target.Dispose(disposing)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for frmEstablishment Constructor
'''</summary>
<TestMethod()>  _
Public Sub frmEstablishmentConstructorTest()
    Dim target As frmEstablishment = New frmEstablishment
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub
End Class
