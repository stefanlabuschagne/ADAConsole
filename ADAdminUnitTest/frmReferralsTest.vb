Imports ADAdminDotNet.dsARSystemDataSetTableAdapters

Imports ADAdminDotNet.dsADSTableAdapters

Imports System.Windows.Forms

Imports System

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports ADAdminDotNet



'''<summary>
'''This is a test class for frmReferralsTest and is intended
'''to contain all frmReferralsTest Unit Tests
'''</summary>
<TestClass()> _
Public Class frmReferralsTest


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
'''A test for ToolStripMenuItem4
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem4Test()
Dim target As frmReferrals = New frmReferrals ' TODO: Initialize to an appropriate value
Dim expected As ToolStripSeparator = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripSeparator
    target.ToolStripMenuItem4 = expected
    actual = target.ToolStripMenuItem4
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem3
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem3Test()
Dim target As frmReferrals = New frmReferrals ' TODO: Initialize to an appropriate value
Dim expected As ToolStripSeparator = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripSeparator
    target.ToolStripMenuItem3 = expected
    actual = target.ToolStripMenuItem3
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem2
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem2Test()
Dim target As frmReferrals = New frmReferrals ' TODO: Initialize to an appropriate value
Dim expected As ToolStripSeparator = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripSeparator
    target.ToolStripMenuItem2 = expected
    actual = target.ToolStripMenuItem2
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem1
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem1Test()
Dim target As frmReferrals = New frmReferrals ' TODO: Initialize to an appropriate value
Dim expected As ToolStripSeparator = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripSeparator
    target.ToolStripMenuItem1 = expected
    actual = target.ToolStripMenuItem1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripDropDownButton1
'''</summary>
<TestMethod()>  _
Public Sub ToolStripDropDownButton1Test()
Dim target As frmReferrals = New frmReferrals ' TODO: Initialize to an appropriate value
Dim expected As ToolStripDropDownButton = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripDropDownButton
    target.ToolStripDropDownButton1 = expected
    actual = target.ToolStripDropDownButton1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for StatusStrip1
'''</summary>
<TestMethod()>  _
Public Sub StatusStrip1Test()
Dim target As frmReferrals = New frmReferrals ' TODO: Initialize to an appropriate value
Dim expected As StatusStrip = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As StatusStrip
    target.StatusStrip1 = expected
    actual = target.StatusStrip1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for RULES_FLAGSTableAdapter
'''</summary>
<TestMethod()>  _
Public Sub RULES_FLAGSTableAdapterTest()
Dim target As frmReferrals = New frmReferrals ' TODO: Initialize to an appropriate value
Dim expected As RULES_FLAGSTableAdapter = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As RULES_FLAGSTableAdapter
    target.RULES_FLAGSTableAdapter = expected
    actual = target.RULES_FLAGSTableAdapter
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for RULES_FLAGSBindingSource
'''</summary>
<TestMethod()>  _
Public Sub RULES_FLAGSBindingSourceTest()
Dim target As frmReferrals = New frmReferrals ' TODO: Initialize to an appropriate value
Dim expected As BindingSource = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As BindingSource
    target.RULES_FLAGSBindingSource = expected
    actual = target.RULES_FLAGSBindingSource
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for RollbackClosedReferralToolStripMenuItem
'''</summary>
<TestMethod()>  _
Public Sub RollbackClosedReferralToolStripMenuItemTest()
Dim target As frmReferrals = New frmReferrals ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.RollbackClosedReferralToolStripMenuItem = expected
    actual = target.RollbackClosedReferralToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for RequestNo
'''</summary>
<TestMethod()>  _
Public Sub RequestNoTest()
Dim target As frmReferrals = New frmReferrals ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.RequestNo = expected
    actual = target.RequestNo
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for MarkThisEntryAsPROFILEDToolStripMenuItem
'''</summary>
<TestMethod()>  _
Public Sub MarkThisEntryAsPROFILEDToolStripMenuItemTest()
Dim target As frmReferrals = New frmReferrals ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.MarkThisEntryAsPROFILEDToolStripMenuItem = expected
    actual = target.MarkThisEntryAsPROFILEDToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for LOG_IN_Request_TrackingTableAdapter
'''</summary>
<TestMethod()>  _
Public Sub LOG_IN_Request_TrackingTableAdapterTest()
Dim target As frmReferrals = New frmReferrals ' TODO: Initialize to an appropriate value
Dim expected As LOG_IN_Request_TrackingTableAdapter = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As LOG_IN_Request_TrackingTableAdapter
    target.LOG_IN_Request_TrackingTableAdapter = expected
    actual = target.LOG_IN_Request_TrackingTableAdapter
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for LOG_IN_Request_TrackingBindingSource
'''</summary>
<TestMethod()>  _
Public Sub LOG_IN_Request_TrackingBindingSourceTest()
Dim target As frmReferrals = New frmReferrals ' TODO: Initialize to an appropriate value
Dim expected As BindingSource = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As BindingSource
    target.LOG_IN_Request_TrackingBindingSource = expected
    actual = target.LOG_IN_Request_TrackingBindingSource
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ExportToolStripMenuItem
'''</summary>
<TestMethod()>  _
Public Sub ExportToolStripMenuItemTest()
Dim target As frmReferrals = New frmReferrals ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ExportToolStripMenuItem = expected
    actual = target.ExportToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ExportToExcelToolStripMenuItem
'''</summary>
<TestMethod()>  _
Public Sub ExportToExcelToolStripMenuItemTest()
Dim target As frmReferrals = New frmReferrals ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ExportToExcelToolStripMenuItem = expected
    actual = target.ExportToExcelToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DsARSystemDataSet
'''</summary>
<TestMethod()>  _
Public Sub DsARSystemDataSetTest()
Dim target As frmReferrals = New frmReferrals ' TODO: Initialize to an appropriate value
Dim expected As dsARSystemDataSet = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As dsARSystemDataSet
    target.DsARSystemDataSet = expected
    actual = target.DsARSystemDataSet
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DsADS
'''</summary>
<TestMethod()>  _
Public Sub DsADSTest()
Dim target As frmReferrals = New frmReferrals ' TODO: Initialize to an appropriate value
Dim expected As dsADS = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As dsADS
    target.DsADS = expected
    actual = target.DsADS
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DataGridViewTextBoxColumn8
'''</summary>
<TestMethod()>  _
Public Sub DataGridViewTextBoxColumn8Test()
Dim target As frmReferrals = New frmReferrals ' TODO: Initialize to an appropriate value
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
Dim target As frmReferrals = New frmReferrals ' TODO: Initialize to an appropriate value
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
Dim target As frmReferrals = New frmReferrals ' TODO: Initialize to an appropriate value
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
Dim target As frmReferrals = New frmReferrals ' TODO: Initialize to an appropriate value
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
Dim target As frmReferrals = New frmReferrals ' TODO: Initialize to an appropriate value
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
Dim target As frmReferrals = New frmReferrals ' TODO: Initialize to an appropriate value
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
Dim target As frmReferrals = New frmReferrals ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.DataGridViewTextBoxColumn2 = expected
    actual = target.DataGridViewTextBoxColumn2
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DataGridViewCheckBoxColumn2
'''</summary>
<TestMethod()>  _
Public Sub DataGridViewCheckBoxColumn2Test()
Dim target As frmReferrals = New frmReferrals ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewCheckBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewCheckBoxColumn
    target.DataGridViewCheckBoxColumn2 = expected
    actual = target.DataGridViewCheckBoxColumn2
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DataGridViewCheckBoxColumn1
'''</summary>
<TestMethod()>  _
Public Sub DataGridViewCheckBoxColumn1Test()
Dim target As frmReferrals = New frmReferrals ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewCheckBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewCheckBoxColumn
    target.DataGridViewCheckBoxColumn1 = expected
    actual = target.DataGridViewCheckBoxColumn1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ContextMenuStrip1
'''</summary>
<TestMethod()>  _
Public Sub ContextMenuStrip1Test()
Dim target As frmReferrals = New frmReferrals ' TODO: Initialize to an appropriate value
Dim expected As ContextMenuStrip = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ContextMenuStrip
    target.ContextMenuStrip1 = expected
    actual = target.ContextMenuStrip1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for CFOApprovalDataGridView
'''</summary>
<TestMethod()>  _
Public Sub CFOApprovalDataGridViewTest()
Dim target As frmReferrals = New frmReferrals ' TODO: Initialize to an appropriate value
Dim expected As DataGridView = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridView
    target.CFOApprovalDataGridView = expected
    actual = target.CFOApprovalDataGridView
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for CFOApprovalBindingSource
'''</summary>
<TestMethod()>  _
Public Sub CFOApprovalBindingSourceTest()
Dim target As frmReferrals = New frmReferrals ' TODO: Initialize to an appropriate value
Dim expected As BindingSource = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As BindingSource
    target.CFOApprovalBindingSource = expected
    actual = target.CFOApprovalBindingSource
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for CFOApprovalBindingNavigatorSaveItem
'''</summary>
<TestMethod()>  _
Public Sub CFOApprovalBindingNavigatorSaveItemTest()
Dim target As frmReferrals = New frmReferrals ' TODO: Initialize to an appropriate value
Dim expected As ToolStripButton = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripButton
    target.CFOApprovalBindingNavigatorSaveItem = expected
    actual = target.CFOApprovalBindingNavigatorSaveItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for CFOApprovalBindingNavigator
'''</summary>
<TestMethod()>  _
Public Sub CFOApprovalBindingNavigatorTest()
Dim target As frmReferrals = New frmReferrals ' TODO: Initialize to an appropriate value
Dim expected As BindingNavigator = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As BindingNavigator
    target.CFOApprovalBindingNavigator = expected
    actual = target.CFOApprovalBindingNavigator
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for CFOApproval_ta
'''</summary>
<TestMethod()>  _
Public Sub CFOApproval_taTest()
Dim target As frmReferrals = New frmReferrals ' TODO: Initialize to an appropriate value
Dim expected As CFOApproval_ta = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As CFOApproval_ta
    target.CFOApproval_ta = expected
    actual = target.CFOApproval_ta
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for CancelToolStripMenuItem
'''</summary>
<TestMethod()>  _
Public Sub CancelToolStripMenuItemTest()
Dim target As frmReferrals = New frmReferrals ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.CancelToolStripMenuItem = expected
    actual = target.CancelToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for btnRefresh
'''</summary>
<TestMethod()>  _
Public Sub btnRefreshTest()
Dim target As frmReferrals = New frmReferrals ' TODO: Initialize to an appropriate value
Dim expected As ToolStripButton = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripButton
    target.btnRefresh = expected
    actual = target.btnRefresh
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for BindingNavigatorSeparator2
'''</summary>
<TestMethod()>  _
Public Sub BindingNavigatorSeparator2Test()
Dim target As frmReferrals = New frmReferrals ' TODO: Initialize to an appropriate value
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
Dim target As frmReferrals = New frmReferrals ' TODO: Initialize to an appropriate value
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
Dim target As frmReferrals = New frmReferrals ' TODO: Initialize to an appropriate value
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
Dim target As frmReferrals = New frmReferrals ' TODO: Initialize to an appropriate value
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
Dim target As frmReferrals = New frmReferrals ' TODO: Initialize to an appropriate value
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
Dim target As frmReferrals = New frmReferrals ' TODO: Initialize to an appropriate value
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
Dim target As frmReferrals = New frmReferrals ' TODO: Initialize to an appropriate value
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
Dim target As frmReferrals = New frmReferrals ' TODO: Initialize to an appropriate value
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
Dim target As frmReferrals = New frmReferrals ' TODO: Initialize to an appropriate value
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
Dim target As frmReferrals = New frmReferrals ' TODO: Initialize to an appropriate value
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
Dim target As frmReferrals = New frmReferrals ' TODO: Initialize to an appropriate value
Dim expected As ToolStripButton = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripButton
    target.BindingNavigatorAddNewItem = expected
    actual = target.BindingNavigatorAddNewItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for AddAVulindlelaCommentToolStripMenuItem
'''</summary>
<TestMethod()>  _
Public Sub AddAVulindlelaCommentToolStripMenuItemTest()
Dim target As frmReferrals = New frmReferrals ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.AddAVulindlelaCommentToolStripMenuItem = expected
    actual = target.AddAVulindlelaCommentToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for RollbackClosedReferralToolStripMenuItem_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub RollbackClosedReferralToolStripMenuItem_ClickTest()
Dim target As frmReferrals_Accessor = New frmReferrals_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.RollbackClosedReferralToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for MarkThisEntryAsPROFILEDToolStripMenuItem_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub MarkThisEntryAsPROFILEDToolStripMenuItem_ClickTest()
Dim target As frmReferrals_Accessor = New frmReferrals_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.MarkThisEntryAsPROFILEDToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for InitializeComponent
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub InitializeComponentTest()
Dim target As frmReferrals_Accessor = New frmReferrals_Accessor ' TODO: Initialize to an appropriate value
    target.InitializeComponent
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for frmReferrals_Load
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub frmReferrals_LoadTest()
Dim target As frmReferrals_Accessor = New frmReferrals_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.frmReferrals_Load(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for ExportToExcelToolStripMenuItem_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ExportToExcelToolStripMenuItem_ClickTest()
Dim target As frmReferrals_Accessor = New frmReferrals_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.ExportToExcelToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for Dispose
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub DisposeTest()
Dim target As frmReferrals_Accessor = New frmReferrals_Accessor ' TODO: Initialize to an appropriate value
Dim disposing As Boolean = false ' TODO: Initialize to an appropriate value
    target.Dispose(disposing)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for CFOApprovalDataGridView_KeyUp
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub CFOApprovalDataGridView_KeyUpTest()
Dim target As frmReferrals_Accessor = New frmReferrals_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As KeyEventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.CFOApprovalDataGridView_KeyUp(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for CFOApprovalDataGridView_CellContentDoubleClick1
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub CFOApprovalDataGridView_CellContentDoubleClick1Test()
Dim target As frmReferrals_Accessor = New frmReferrals_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As DataGridViewCellEventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.CFOApprovalDataGridView_CellContentDoubleClick1(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for btnRefresh_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub btnRefresh_ClickTest()
Dim target As frmReferrals_Accessor = New frmReferrals_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.btnRefresh_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for AddAVulindlelaCommentToolStripMenuItem_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub AddAVulindlelaCommentToolStripMenuItem_ClickTest()
Dim target As frmReferrals_Accessor = New frmReferrals_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.AddAVulindlelaCommentToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for frmReferrals Constructor
'''</summary>
<TestMethod()>  _
Public Sub frmReferralsConstructorTest()
    Dim target As frmReferrals = New frmReferrals
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub
End Class
