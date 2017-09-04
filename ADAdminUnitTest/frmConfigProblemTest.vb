Imports ADAdminDotNet.dsADSTableAdapters

Imports System.Windows.Forms

Imports System

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports ADAdminDotNet



'''<summary>
'''This is a test class for frmConfigProblemTest and is intended
'''to contain all frmConfigProblemTest Unit Tests
'''</summary>
<TestClass()> _
Public Class frmConfigProblemTest


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
'''A test for VpN_Admin_CategoriesTableAdapter1
'''</summary>
<TestMethod()>  _
Public Sub VpN_Admin_CategoriesTableAdapter1Test()
Dim target As frmConfigProblem = New frmConfigProblem ' TODO: Initialize to an appropriate value
Dim expected As VPN_Admin_CategoriesTableAdapter = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As VPN_Admin_CategoriesTableAdapter
    target.VpN_Admin_CategoriesTableAdapter1 = expected
    actual = target.VpN_Admin_CategoriesTableAdapter1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for txtVPNAdminsID
'''</summary>
<TestMethod()>  _
Public Sub txtVPNAdminsIDTest()
Dim target As frmConfigProblem = New frmConfigProblem ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.txtVPNAdminsID = expected
    actual = target.txtVPNAdminsID
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for txtSurname
'''</summary>
<TestMethod()>  _
Public Sub txtSurnameTest()
Dim target As frmConfigProblem = New frmConfigProblem ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.txtSurname = expected
    actual = target.txtSurname
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for txtProblem
'''</summary>
<TestMethod()>  _
Public Sub txtProblemTest()
Dim target As frmConfigProblem = New frmConfigProblem ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.txtProblem = expected
    actual = target.txtProblem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for txtPersalno
'''</summary>
<TestMethod()>  _
Public Sub txtPersalnoTest()
Dim target As frmConfigProblem = New frmConfigProblem ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.txtPersalno = expected
    actual = target.txtPersalno
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for txtName
'''</summary>
<TestMethod()>  _
Public Sub txtNameTest()
Dim target As frmConfigProblem = New frmConfigProblem ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.txtName = expected
    actual = target.txtName
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for txtDeptCode
'''</summary>
<TestMethod()>  _
Public Sub txtDeptCodeTest()
Dim target As frmConfigProblem = New frmConfigProblem ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.txtDeptCode = expected
    actual = target.txtDeptCode
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for txtDatetime
'''</summary>
<TestMethod()>  _
Public Sub txtDatetimeTest()
Dim target As frmConfigProblem = New frmConfigProblem ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.txtDatetime = expected
    actual = target.txtDatetime
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for tsIncident
'''</summary>
<TestMethod()>  _
Public Sub tsIncidentTest()
Dim target As frmConfigProblem = New frmConfigProblem ' TODO: Initialize to an appropriate value
Dim expected As ToolStripButton = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripButton
    target.tsIncident = expected
    actual = target.tsIncident
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripStatusLabel1
'''</summary>
<TestMethod()>  _
Public Sub ToolStripStatusLabel1Test()
Dim target As frmConfigProblem = New frmConfigProblem ' TODO: Initialize to an appropriate value
Dim expected As ToolStripSplitButton = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripSplitButton
    target.ToolStripStatusLabel1 = expected
    actual = target.ToolStripStatusLabel1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripSeparator1
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator1Test()
Dim target As frmConfigProblem = New frmConfigProblem ' TODO: Initialize to an appropriate value
Dim expected As ToolStripSeparator = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator1 = expected
    actual = target.ToolStripSeparator1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem1
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem1Test()
Dim target As frmConfigProblem = New frmConfigProblem ' TODO: Initialize to an appropriate value
Dim expected As ToolStripSeparator = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripSeparator
    target.ToolStripMenuItem1 = expected
    actual = target.ToolStripMenuItem1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for StatusStrip1
'''</summary>
<TestMethod()>  _
Public Sub StatusStrip1Test()
Dim target As frmConfigProblem = New frmConfigProblem ' TODO: Initialize to an appropriate value
Dim expected As StatusStrip = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As StatusStrip
    target.StatusStrip1 = expected
    actual = target.StatusStrip1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ExportToProlemxlsToolStripMenuItem
'''</summary>
<TestMethod()>  _
Public Sub ExportToProlemxlsToolStripMenuItemTest()
Dim target As frmConfigProblem = New frmConfigProblem ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ExportToProlemxlsToolStripMenuItem = expected
    actual = target.ExportToProlemxlsToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DsADS
'''</summary>
<TestMethod()>  _
Public Sub DsADSTest()
Dim target As frmConfigProblem = New frmConfigProblem ' TODO: Initialize to an appropriate value
Dim expected As dsADS = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As dsADS
    target.DsADS = expected
    actual = target.DsADS
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DataGridViewTextBoxColumn2
'''</summary>
<TestMethod()>  _
Public Sub DataGridViewTextBoxColumn2Test()
Dim target As frmConfigProblem = New frmConfigProblem ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.DataGridViewTextBoxColumn2 = expected
    actual = target.DataGridViewTextBoxColumn2
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Config_ProblemTableAdapter
'''</summary>
<TestMethod()>  _
Public Sub Config_ProblemTableAdapterTest()
Dim target As frmConfigProblem = New frmConfigProblem ' TODO: Initialize to an appropriate value
Dim expected As Config_ProblemTableAdapter = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Config_ProblemTableAdapter
    target.Config_ProblemTableAdapter = expected
    actual = target.Config_ProblemTableAdapter
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Config_ProblemDataGridView
'''</summary>
<TestMethod()>  _
Public Sub Config_ProblemDataGridViewTest()
Dim target As frmConfigProblem = New frmConfigProblem ' TODO: Initialize to an appropriate value
Dim expected As DataGridView = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridView
    target.Config_ProblemDataGridView = expected
    actual = target.Config_ProblemDataGridView
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Config_ProblemBindingSource
'''</summary>
<TestMethod()>  _
Public Sub Config_ProblemBindingSourceTest()
Dim target As frmConfigProblem = New frmConfigProblem ' TODO: Initialize to an appropriate value
Dim expected As BindingSource = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As BindingSource
    target.Config_ProblemBindingSource = expected
    actual = target.Config_ProblemBindingSource
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Config_ProblemBindingNavigatorSaveItem
'''</summary>
<TestMethod()>  _
Public Sub Config_ProblemBindingNavigatorSaveItemTest()
Dim target As frmConfigProblem = New frmConfigProblem ' TODO: Initialize to an appropriate value
Dim expected As ToolStripButton = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripButton
    target.Config_ProblemBindingNavigatorSaveItem = expected
    actual = target.Config_ProblemBindingNavigatorSaveItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Config_ProblemBindingNavigator
'''</summary>
<TestMethod()>  _
Public Sub Config_ProblemBindingNavigatorTest()
Dim target As frmConfigProblem = New frmConfigProblem ' TODO: Initialize to an appropriate value
Dim expected As BindingNavigator = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As BindingNavigator
    target.Config_ProblemBindingNavigator = expected
    actual = target.Config_ProblemBindingNavigator
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for chkVPNProblem
'''</summary>
<TestMethod()>  _
Public Sub chkVPNProblemTest()
Dim target As frmConfigProblem = New frmConfigProblem ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewCheckBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewCheckBoxColumn
    target.chkVPNProblem = expected
    actual = target.chkVPNProblem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for chkProblemSolved
'''</summary>
<TestMethod()>  _
Public Sub chkProblemSolvedTest()
Dim target As frmConfigProblem = New frmConfigProblem ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewCheckBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewCheckBoxColumn
    target.chkProblemSolved = expected
    actual = target.chkProblemSolved
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for chkPolicyProblem
'''</summary>
<TestMethod()>  _
Public Sub chkPolicyProblemTest()
Dim target As frmConfigProblem = New frmConfigProblem ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewCheckBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewCheckBoxColumn
    target.chkPolicyProblem = expected
    actual = target.chkPolicyProblem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for CalncelToolStripMenuItem
'''</summary>
<TestMethod()>  _
Public Sub CalncelToolStripMenuItemTest()
Dim target As frmConfigProblem = New frmConfigProblem ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.CalncelToolStripMenuItem = expected
    actual = target.CalncelToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for BindingNavigatorSeparator2
'''</summary>
<TestMethod()>  _
Public Sub BindingNavigatorSeparator2Test()
Dim target As frmConfigProblem = New frmConfigProblem ' TODO: Initialize to an appropriate value
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
Dim target As frmConfigProblem = New frmConfigProblem ' TODO: Initialize to an appropriate value
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
Dim target As frmConfigProblem = New frmConfigProblem ' TODO: Initialize to an appropriate value
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
Dim target As frmConfigProblem = New frmConfigProblem ' TODO: Initialize to an appropriate value
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
Dim target As frmConfigProblem = New frmConfigProblem ' TODO: Initialize to an appropriate value
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
Dim target As frmConfigProblem = New frmConfigProblem ' TODO: Initialize to an appropriate value
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
Dim target As frmConfigProblem = New frmConfigProblem ' TODO: Initialize to an appropriate value
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
Dim target As frmConfigProblem = New frmConfigProblem ' TODO: Initialize to an appropriate value
Dim expected As ToolStripButton = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripButton
    target.BindingNavigatorMoveFirstItem = expected
    actual = target.BindingNavigatorMoveFirstItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for BindingNavigatorDeleteItem
'''</summary>
<TestMethod()>  _
Public Sub BindingNavigatorDeleteItemTest()
Dim target As frmConfigProblem = New frmConfigProblem ' TODO: Initialize to an appropriate value
Dim expected As ToolStripButton = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripButton
    target.BindingNavigatorDeleteItem = expected
    actual = target.BindingNavigatorDeleteItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for BindingNavigatorCountItem
'''</summary>
<TestMethod()>  _
Public Sub BindingNavigatorCountItemTest()
Dim target As frmConfigProblem = New frmConfigProblem ' TODO: Initialize to an appropriate value
Dim expected As ToolStripLabel = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripLabel
    target.BindingNavigatorCountItem = expected
    actual = target.BindingNavigatorCountItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for BindingNavigatorAddNewItem
'''</summary>
<TestMethod()>  _
Public Sub BindingNavigatorAddNewItemTest()
Dim target As frmConfigProblem = New frmConfigProblem ' TODO: Initialize to an appropriate value
Dim expected As ToolStripButton = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripButton
    target.BindingNavigatorAddNewItem = expected
    actual = target.BindingNavigatorAddNewItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for tsLogIncident_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub tsLogIncident_ClickTest()
Dim target As frmConfigProblem_Accessor = New frmConfigProblem_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.tsLogIncident_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for tsIncident_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub tsIncident_ClickTest()
Dim target As frmConfigProblem_Accessor = New frmConfigProblem_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.tsIncident_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for InitializeComponent
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub InitializeComponentTest()
Dim target As frmConfigProblem_Accessor = New frmConfigProblem_Accessor ' TODO: Initialize to an appropriate value
    target.InitializeComponent
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for frmConfigProblems_KeyPress
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub frmConfigProblems_KeyPressTest()
Dim target As frmConfigProblem_Accessor = New frmConfigProblem_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As KeyPressEventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.frmConfigProblems_KeyPress(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for frmConfigProblem_Load
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub frmConfigProblem_LoadTest()
Dim target As frmConfigProblem_Accessor = New frmConfigProblem_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.frmConfigProblem_Load(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for Dispose
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub DisposeTest()
Dim target As frmConfigProblem_Accessor = New frmConfigProblem_Accessor ' TODO: Initialize to an appropriate value
Dim disposing As Boolean = false ' TODO: Initialize to an appropriate value
    target.Dispose(disposing)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for Config_ProblemDataGridView_KeyUp
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub Config_ProblemDataGridView_KeyUpTest()
Dim target As frmConfigProblem_Accessor = New frmConfigProblem_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As KeyEventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.Config_ProblemDataGridView_KeyUp(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for Config_ProblemDataGridView_CellContentDoubleClick
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub Config_ProblemDataGridView_CellContentDoubleClickTest()
Dim target As frmConfigProblem_Accessor = New frmConfigProblem_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As DataGridViewCellEventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.Config_ProblemDataGridView_CellContentDoubleClick(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for Config_ProblemBindingNavigatorSaveItem_Click_1
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub Config_ProblemBindingNavigatorSaveItem_Click_1Test()
Dim target As frmConfigProblem_Accessor = New frmConfigProblem_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.Config_ProblemBindingNavigatorSaveItem_Click_1(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for Config_ProblemBindingNavigatorSaveItem_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub Config_ProblemBindingNavigatorSaveItem_ClickTest()
Dim target As frmConfigProblem_Accessor = New frmConfigProblem_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.Config_ProblemBindingNavigatorSaveItem_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for frmConfigProblem Constructor
'''</summary>
<TestMethod()>  _
Public Sub frmConfigProblemConstructorTest()
    Dim target As frmConfigProblem = New frmConfigProblem
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub
End Class
