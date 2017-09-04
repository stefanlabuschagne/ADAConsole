Imports ADAdminDotNet.dsADSTableAdapters

Imports System.Windows.Forms

Imports System

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports ADAdminDotNet



'''<summary>
'''This is a test class for frmResetPasswordTest and is intended
'''to contain all frmResetPasswordTest Unit Tests
'''</summary>
<TestClass()> _
Public Class frmResetPasswordTest


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
'''A test for VIP_USERS_ResetPasswordTableAdapter
'''</summary>
<TestMethod()>  _
Public Sub VIP_USERS_ResetPasswordTableAdapterTest()
Dim target As frmResetPassword = New frmResetPassword ' TODO: Initialize to an appropriate value
Dim expected As VIP_USERS_ResetPasswordTableAdapter = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As VIP_USERS_ResetPasswordTableAdapter
    target.VIP_USERS_ResetPasswordTableAdapter = expected
    actual = target.VIP_USERS_ResetPasswordTableAdapter
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for VIP_USERS_ResetPasswordDataGridView
'''</summary>
<TestMethod()>  _
Public Sub VIP_USERS_ResetPasswordDataGridViewTest()
Dim target As frmResetPassword = New frmResetPassword ' TODO: Initialize to an appropriate value
Dim expected As DataGridView = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridView
    target.VIP_USERS_ResetPasswordDataGridView = expected
    actual = target.VIP_USERS_ResetPasswordDataGridView
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for VIP_USERS_ResetPasswordBindingSource
'''</summary>
<TestMethod()>  _
Public Sub VIP_USERS_ResetPasswordBindingSourceTest()
Dim target As frmResetPassword = New frmResetPassword ' TODO: Initialize to an appropriate value
Dim expected As BindingSource = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As BindingSource
    target.VIP_USERS_ResetPasswordBindingSource = expected
    actual = target.VIP_USERS_ResetPasswordBindingSource
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for VIP_USERS_ResetPasswordBindingNavigatorSaveItem
'''</summary>
<TestMethod()>  _
Public Sub VIP_USERS_ResetPasswordBindingNavigatorSaveItemTest()
Dim target As frmResetPassword = New frmResetPassword ' TODO: Initialize to an appropriate value
Dim expected As ToolStripButton = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripButton
    target.VIP_USERS_ResetPasswordBindingNavigatorSaveItem = expected
    actual = target.VIP_USERS_ResetPasswordBindingNavigatorSaveItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for VIP_USERS_ResetPasswordBindingNavigator
'''</summary>
<TestMethod()>  _
Public Sub VIP_USERS_ResetPasswordBindingNavigatorTest()
Dim target As frmResetPassword = New frmResetPassword ' TODO: Initialize to an appropriate value
Dim expected As BindingNavigator = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As BindingNavigator
    target.VIP_USERS_ResetPasswordBindingNavigator = expected
    actual = target.VIP_USERS_ResetPasswordBindingNavigator
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem2
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem2Test()
Dim target As frmResetPassword = New frmResetPassword ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
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
Dim target As frmResetPassword = New frmResetPassword ' TODO: Initialize to an appropriate value
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
Dim target As frmResetPassword = New frmResetPassword ' TODO: Initialize to an appropriate value
Dim expected As ToolStripDropDownButton = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripDropDownButton
    target.ToolStripDropDownButton1 = expected
    actual = target.ToolStripDropDownButton1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripContainer1
'''</summary>
<TestMethod()>  _
Public Sub ToolStripContainer1Test()
Dim target As frmResetPassword = New frmResetPassword ' TODO: Initialize to an appropriate value
Dim expected As ToolStripContainer = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripContainer
    target.ToolStripContainer1 = expected
    actual = target.ToolStripContainer1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for TitleDataGridViewTextBoxColumn
'''</summary>
<TestMethod()>  _
Public Sub TitleDataGridViewTextBoxColumnTest()
Dim target As frmResetPassword = New frmResetPassword ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.TitleDataGridViewTextBoxColumn = expected
    actual = target.TitleDataGridViewTextBoxColumn
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for TelBDataGridViewTextBoxColumn
'''</summary>
<TestMethod()>  _
Public Sub TelBDataGridViewTextBoxColumnTest()
Dim target As frmResetPassword = New frmResetPassword ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.TelBDataGridViewTextBoxColumn = expected
    actual = target.TelBDataGridViewTextBoxColumn
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for SurnameDataGridViewTextBoxColumn
'''</summary>
<TestMethod()>  _
Public Sub SurnameDataGridViewTextBoxColumnTest()
Dim target As frmResetPassword = New frmResetPassword ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.SurnameDataGridViewTextBoxColumn = expected
    actual = target.SurnameDataGridViewTextBoxColumn
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for StatusStrip1
'''</summary>
<TestMethod()>  _
Public Sub StatusStrip1Test()
Dim target As frmResetPassword = New frmResetPassword ' TODO: Initialize to an appropriate value
Dim expected As StatusStrip = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As StatusStrip
    target.StatusStrip1 = expected
    actual = target.StatusStrip1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ResponsibilityDataGridViewTextBoxColumn
'''</summary>
<TestMethod()>  _
Public Sub ResponsibilityDataGridViewTextBoxColumnTest()
Dim target As frmResetPassword = New frmResetPassword ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.ResponsibilityDataGridViewTextBoxColumn = expected
    actual = target.ResponsibilityDataGridViewTextBoxColumn
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ResetDataGridViewCheckBoxColumn
'''</summary>
<TestMethod()>  _
Public Sub ResetDataGridViewCheckBoxColumnTest()
Dim target As frmResetPassword = New frmResetPassword ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewCheckBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewCheckBoxColumn
    target.ResetDataGridViewCheckBoxColumn = expected
    actual = target.ResetDataGridViewCheckBoxColumn
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for RankDataGridViewTextBoxColumn
'''</summary>
<TestMethod()>  _
Public Sub RankDataGridViewTextBoxColumnTest()
Dim target As frmResetPassword = New frmResetPassword ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.RankDataGridViewTextBoxColumn = expected
    actual = target.RankDataGridViewTextBoxColumn
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ProvinceDataGridViewTextBoxColumn
'''</summary>
<TestMethod()>  _
Public Sub ProvinceDataGridViewTextBoxColumnTest()
Dim target As frmResetPassword = New frmResetPassword ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.ProvinceDataGridViewTextBoxColumn = expected
    actual = target.ProvinceDataGridViewTextBoxColumn
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for PersalNrDataGridViewTextBoxColumn
'''</summary>
<TestMethod()>  _
Public Sub PersalNrDataGridViewTextBoxColumnTest()
Dim target As frmResetPassword = New frmResetPassword ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.PersalNrDataGridViewTextBoxColumn = expected
    actual = target.PersalNrDataGridViewTextBoxColumn
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for NotesDataGridViewTextBoxColumn
'''</summary>
<TestMethod()>  _
Public Sub NotesDataGridViewTextBoxColumnTest()
Dim target As frmResetPassword = New frmResetPassword ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.NotesDataGridViewTextBoxColumn = expected
    actual = target.NotesDataGridViewTextBoxColumn
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for LOGISDataGridViewTextBoxColumn
'''</summary>
<TestMethod()>  _
Public Sub LOGISDataGridViewTextBoxColumnTest()
Dim target As frmResetPassword = New frmResetPassword ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.LOGISDataGridViewTextBoxColumn = expected
    actual = target.LOGISDataGridViewTextBoxColumn
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IDDataGridViewTextBoxColumn
'''</summary>
<TestMethod()>  _
Public Sub IDDataGridViewTextBoxColumnTest()
Dim target As frmResetPassword = New frmResetPassword ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.IDDataGridViewTextBoxColumn = expected
    actual = target.IDDataGridViewTextBoxColumn
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for HRDataGridViewTextBoxColumn
'''</summary>
<TestMethod()>  _
Public Sub HRDataGridViewTextBoxColumnTest()
Dim target As frmResetPassword = New frmResetPassword ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.HRDataGridViewTextBoxColumn = expected
    actual = target.HRDataGridViewTextBoxColumn
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for GFSDataGridViewTextBoxColumn
'''</summary>
<TestMethod()>  _
Public Sub GFSDataGridViewTextBoxColumnTest()
Dim target As frmResetPassword = New frmResetPassword ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.GFSDataGridViewTextBoxColumn = expected
    actual = target.GFSDataGridViewTextBoxColumn
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for FlagSuspiciousRemoveToolStripMenuItem
'''</summary>
<TestMethod()>  _
Public Sub FlagSuspiciousRemoveToolStripMenuItemTest()
Dim target As frmResetPassword = New frmResetPassword ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.FlagSuspiciousRemoveToolStripMenuItem = expected
    actual = target.FlagSuspiciousRemoveToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for FirstnameDataGridViewTextBoxColumn
'''</summary>
<TestMethod()>  _
Public Sub FirstnameDataGridViewTextBoxColumnTest()
Dim target As frmResetPassword = New frmResetPassword ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.FirstnameDataGridViewTextBoxColumn = expected
    actual = target.FirstnameDataGridViewTextBoxColumn
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for FINDataGridViewTextBoxColumn
'''</summary>
<TestMethod()>  _
Public Sub FINDataGridViewTextBoxColumnTest()
Dim target As frmResetPassword = New frmResetPassword ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.FINDataGridViewTextBoxColumn = expected
    actual = target.FINDataGridViewTextBoxColumn
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for FaxDataGridViewTextBoxColumn
'''</summary>
<TestMethod()>  _
Public Sub FaxDataGridViewTextBoxColumnTest()
Dim target As frmResetPassword = New frmResetPassword ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.FaxDataGridViewTextBoxColumn = expected
    actual = target.FaxDataGridViewTextBoxColumn
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ExportToExcelOpenToolStripMenuItem
'''</summary>
<TestMethod()>  _
Public Sub ExportToExcelOpenToolStripMenuItemTest()
Dim target As frmResetPassword = New frmResetPassword ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ExportToExcelOpenToolStripMenuItem = expected
    actual = target.ExportToExcelOpenToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ExportFlagged3ToCSVToolStripMenuItem
'''</summary>
<TestMethod()>  _
Public Sub ExportFlagged3ToCSVToolStripMenuItemTest()
Dim target As frmResetPassword = New frmResetPassword ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ExportFlagged3ToCSVToolStripMenuItem = expected
    actual = target.ExportFlagged3ToCSVToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ExportedDataGridViewTextBoxColumn
'''</summary>
<TestMethod()>  _
Public Sub ExportedDataGridViewTextBoxColumnTest()
Dim target As frmResetPassword = New frmResetPassword ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.ExportedDataGridViewTextBoxColumn = expected
    actual = target.ExportedDataGridViewTextBoxColumn
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for EMailDataGridViewTextBoxColumn
'''</summary>
<TestMethod()>  _
Public Sub EMailDataGridViewTextBoxColumnTest()
Dim target As frmResetPassword = New frmResetPassword ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.EMailDataGridViewTextBoxColumn = expected
    actual = target.EMailDataGridViewTextBoxColumn
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DPSADataGridViewTextBoxColumn
'''</summary>
<TestMethod()>  _
Public Sub DPSADataGridViewTextBoxColumnTest()
Dim target As frmResetPassword = New frmResetPassword ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.DPSADataGridViewTextBoxColumn = expected
    actual = target.DPSADataGridViewTextBoxColumn
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DownloadedByDataGridViewTextBoxColumn
'''</summary>
<TestMethod()>  _
Public Sub DownloadedByDataGridViewTextBoxColumnTest()
Dim target As frmResetPassword = New frmResetPassword ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.DownloadedByDataGridViewTextBoxColumn = expected
    actual = target.DownloadedByDataGridViewTextBoxColumn
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DoneDataGridViewTextBoxColumn
'''</summary>
<TestMethod()>  _
Public Sub DoneDataGridViewTextBoxColumnTest()
Dim target As frmResetPassword = New frmResetPassword ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.DoneDataGridViewTextBoxColumn = expected
    actual = target.DoneDataGridViewTextBoxColumn
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DeptDataGridViewTextBoxColumn
'''</summary>
<TestMethod()>  _
Public Sub DeptDataGridViewTextBoxColumnTest()
Dim target As frmResetPassword = New frmResetPassword ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.DeptDataGridViewTextBoxColumn = expected
    actual = target.DeptDataGridViewTextBoxColumn
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for CreatedDataGridViewTextBoxColumn
'''</summary>
<TestMethod()>  _
Public Sub CreatedDataGridViewTextBoxColumnTest()
Dim target As frmResetPassword = New frmResetPassword ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.CreatedDataGridViewTextBoxColumn = expected
    actual = target.CreatedDataGridViewTextBoxColumn
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ContextMenuStrip1
'''</summary>
<TestMethod()>  _
Public Sub ContextMenuStrip1Test()
Dim target As frmResetPassword = New frmResetPassword ' TODO: Initialize to an appropriate value
Dim expected As ContextMenuStrip = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ContextMenuStrip
    target.ContextMenuStrip1 = expected
    actual = target.ContextMenuStrip1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for CellDataGridViewTextBoxColumn
'''</summary>
<TestMethod()>  _
Public Sub CellDataGridViewTextBoxColumnTest()
Dim target As frmResetPassword = New frmResetPassword ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.CellDataGridViewTextBoxColumn = expected
    actual = target.CellDataGridViewTextBoxColumn
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for CancelToolStripMenuItem
'''</summary>
<TestMethod()>  _
Public Sub CancelToolStripMenuItemTest()
Dim target As frmResetPassword = New frmResetPassword ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.CancelToolStripMenuItem = expected
    actual = target.CancelToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for BindingNavigatorSeparator2
'''</summary>
<TestMethod()>  _
Public Sub BindingNavigatorSeparator2Test()
Dim target As frmResetPassword = New frmResetPassword ' TODO: Initialize to an appropriate value
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
Dim target As frmResetPassword = New frmResetPassword ' TODO: Initialize to an appropriate value
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
Dim target As frmResetPassword = New frmResetPassword ' TODO: Initialize to an appropriate value
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
Dim target As frmResetPassword = New frmResetPassword ' TODO: Initialize to an appropriate value
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
Dim target As frmResetPassword = New frmResetPassword ' TODO: Initialize to an appropriate value
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
Dim target As frmResetPassword = New frmResetPassword ' TODO: Initialize to an appropriate value
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
Dim target As frmResetPassword = New frmResetPassword ' TODO: Initialize to an appropriate value
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
Dim target As frmResetPassword = New frmResetPassword ' TODO: Initialize to an appropriate value
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
Dim target As frmResetPassword = New frmResetPassword ' TODO: Initialize to an appropriate value
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
Dim target As frmResetPassword = New frmResetPassword ' TODO: Initialize to an appropriate value
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
Dim target As frmResetPassword = New frmResetPassword ' TODO: Initialize to an appropriate value
Dim expected As ToolStripButton = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripButton
    target.BindingNavigatorAddNewItem = expected
    actual = target.BindingNavigatorAddNewItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Ads
'''</summary>
<TestMethod()>  _
Public Sub AdsTest()
Dim target As frmResetPassword = New frmResetPassword ' TODO: Initialize to an appropriate value
Dim expected As dsADS = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As dsADS
    target.Ads = expected
    actual = target.Ads
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for VIP_USERS_ResetPasswordDataGridView_CellContentDoubleClick
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub VIP_USERS_ResetPasswordDataGridView_CellContentDoubleClickTest()
Dim target As frmResetPassword_Accessor = New frmResetPassword_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.VIP_USERS_ResetPasswordDataGridView_CellContentDoubleClick(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for InitializeComponent
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub InitializeComponentTest()
Dim target As frmResetPassword_Accessor = New frmResetPassword_Accessor ' TODO: Initialize to an appropriate value
    target.InitializeComponent
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for frmResetPassword_Load
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub frmResetPassword_LoadTest()
Dim target As frmResetPassword_Accessor = New frmResetPassword_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.frmResetPassword_Load(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for frmResetPassword_KeyPress
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub frmResetPassword_KeyPressTest()
Dim target As frmResetPassword_Accessor = New frmResetPassword_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As KeyPressEventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.frmResetPassword_KeyPress(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for FlagSuspiciousRemoveToolStripMenuItem_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub FlagSuspiciousRemoveToolStripMenuItem_ClickTest()
Dim target As frmResetPassword_Accessor = New frmResetPassword_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.FlagSuspiciousRemoveToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for ExportFlagged3ToCSVToolStripMenuItem_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ExportFlagged3ToCSVToolStripMenuItem_ClickTest()
Dim target As frmResetPassword_Accessor = New frmResetPassword_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.ExportFlagged3ToCSVToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for Dispose
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub DisposeTest()
Dim target As frmResetPassword_Accessor = New frmResetPassword_Accessor ' TODO: Initialize to an appropriate value
Dim disposing As Boolean = false ' TODO: Initialize to an appropriate value
    target.Dispose(disposing)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for frmResetPassword Constructor
'''</summary>
<TestMethod()>  _
Public Sub frmResetPasswordConstructorTest()
    Dim target As frmResetPassword = New frmResetPassword
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub
End Class
