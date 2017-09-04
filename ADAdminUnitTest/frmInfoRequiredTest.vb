Imports ADAdminDotNet.dsADSTableAdapters

Imports ADAdminDotNet.dsARSystemDataSetTableAdapters

Imports System.Windows.Forms

Imports System

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports ADAdminDotNet



'''<summary>
'''This is a test class for frmInfoRequiredTest and is intended
'''to contain all frmInfoRequiredTest Unit Tests
'''</summary>
<TestClass()> _
Public Class frmInfoRequiredTest


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
'''A test for VIEW_CFO_RULES_FLAGS_OUTSTANDINGTableAdapter
'''</summary>
<TestMethod()>  _
Public Sub VIEW_CFO_RULES_FLAGS_OUTSTANDINGTableAdapterTest()
Dim target As frmInfoRequired = New frmInfoRequired ' TODO: Initialize to an appropriate value
Dim expected As VIEW_CFO_RULES_FLAGS_OUTSTANDINGTableAdapter = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As VIEW_CFO_RULES_FLAGS_OUTSTANDINGTableAdapter
    target.VIEW_CFO_RULES_FLAGS_OUTSTANDINGTableAdapter = expected
    actual = target.VIEW_CFO_RULES_FLAGS_OUTSTANDINGTableAdapter
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for VIEW_CFO_RULES_FLAGS_OUTSTANDINGBindingSource
'''</summary>
<TestMethod()>  _
Public Sub VIEW_CFO_RULES_FLAGS_OUTSTANDINGBindingSourceTest()
Dim target As frmInfoRequired = New frmInfoRequired ' TODO: Initialize to an appropriate value
Dim expected As BindingSource = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As BindingSource
    target.VIEW_CFO_RULES_FLAGS_OUTSTANDINGBindingSource = expected
    actual = target.VIEW_CFO_RULES_FLAGS_OUTSTANDINGBindingSource
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripSeparator1
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator1Test()
Dim target As frmInfoRequired = New frmInfoRequired ' TODO: Initialize to an appropriate value
Dim expected As ToolStripSeparator = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator1 = expected
    actual = target.ToolStripSeparator1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem3
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem3Test()
Dim target As frmInfoRequired = New frmInfoRequired ' TODO: Initialize to an appropriate value
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
Dim target As frmInfoRequired = New frmInfoRequired ' TODO: Initialize to an appropriate value
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
Dim target As frmInfoRequired = New frmInfoRequired ' TODO: Initialize to an appropriate value
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
Dim target As frmInfoRequired = New frmInfoRequired ' TODO: Initialize to an appropriate value
Dim expected As ToolStripDropDownButton = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripDropDownButton
    target.ToolStripDropDownButton1 = expected
    actual = target.ToolStripDropDownButton1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripButton1
'''</summary>
<TestMethod()>  _
Public Sub ToolStripButton1Test()
Dim target As frmInfoRequired = New frmInfoRequired ' TODO: Initialize to an appropriate value
Dim expected As ToolStripButton = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripButton
    target.ToolStripButton1 = expected
    actual = target.ToolStripButton1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Ta_Establishment
'''</summary>
<TestMethod()>  _
Public Sub Ta_EstablishmentTest()
Dim target As frmInfoRequired = New frmInfoRequired ' TODO: Initialize to an appropriate value
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
Dim target As frmInfoRequired = New frmInfoRequired ' TODO: Initialize to an appropriate value
Dim expected As StatusStrip = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As StatusStrip
    target.StatusStrip1 = expected
    actual = target.StatusStrip1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Solution
'''</summary>
<TestMethod()>  _
Public Sub SolutionTest()
Dim target As frmInfoRequired = New frmInfoRequired ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.Solution = expected
    actual = target.Solution
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Request_No
'''</summary>
<TestMethod()>  _
Public Sub Request_NoTest()
Dim target As frmInfoRequired = New frmInfoRequired ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.Request_No = expected
    actual = target.Request_No
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Persal_Number
'''</summary>
<TestMethod()>  _
Public Sub Persal_NumberTest()
Dim target As frmInfoRequired = New frmInfoRequired ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.Persal_Number = expected
    actual = target.Persal_Number
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for NoCFOLetterReceivedInTimeToolStripMenuItem
'''</summary>
<TestMethod()>  _
Public Sub NoCFOLetterReceivedInTimeToolStripMenuItemTest()
Dim target As frmInfoRequired = New frmInfoRequired ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.NoCFOLetterReceivedInTimeToolStripMenuItem = expected
    actual = target.NoCFOLetterReceivedInTimeToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Long_Description
'''</summary>
<TestMethod()>  _
Public Sub Long_DescriptionTest()
Dim target As frmInfoRequired = New frmInfoRequired ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.Long_Description = expected
    actual = target.Long_Description
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for LOG_IN_Request_TrackingTableAdapter
'''</summary>
<TestMethod()>  _
Public Sub LOG_IN_Request_TrackingTableAdapterTest()
Dim target As frmInfoRequired = New frmInfoRequired ' TODO: Initialize to an appropriate value
Dim expected As LOG_IN_Request_TrackingTableAdapter = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As LOG_IN_Request_TrackingTableAdapter
    target.LOG_IN_Request_TrackingTableAdapter = expected
    actual = target.LOG_IN_Request_TrackingTableAdapter
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for LOG_IN_Request_TrackingDataGridView
'''</summary>
<TestMethod()>  _
Public Sub LOG_IN_Request_TrackingDataGridViewTest()
Dim target As frmInfoRequired = New frmInfoRequired ' TODO: Initialize to an appropriate value
Dim expected As DataGridView = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridView
    target.LOG_IN_Request_TrackingDataGridView = expected
    actual = target.LOG_IN_Request_TrackingDataGridView
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for LOG_IN_Request_TrackingBindingSource
'''</summary>
<TestMethod()>  _
Public Sub LOG_IN_Request_TrackingBindingSourceTest()
Dim target As frmInfoRequired = New frmInfoRequired ' TODO: Initialize to an appropriate value
Dim expected As BindingSource = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As BindingSource
    target.LOG_IN_Request_TrackingBindingSource = expected
    actual = target.LOG_IN_Request_TrackingBindingSource
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for LOG_IN_Request_TrackingBindingNavigator
'''</summary>
<TestMethod()>  _
Public Sub LOG_IN_Request_TrackingBindingNavigatorTest()
Dim target As frmInfoRequired = New frmInfoRequired ' TODO: Initialize to an appropriate value
Dim expected As BindingNavigator = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As BindingNavigator
    target.LOG_IN_Request_TrackingBindingNavigator = expected
    actual = target.LOG_IN_Request_TrackingBindingNavigator
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Last_Name
'''</summary>
<TestMethod()>  _
Public Sub Last_NameTest()
Dim target As frmInfoRequired = New frmInfoRequired ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.Last_Name = expected
    actual = target.Last_Name
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for InfoReqMenu
'''</summary>
<TestMethod()>  _
Public Sub InfoReqMenuTest()
Dim target As frmInfoRequired = New frmInfoRequired ' TODO: Initialize to an appropriate value
Dim expected As ContextMenuStrip = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ContextMenuStrip
    target.InfoReqMenu = expected
    actual = target.InfoReqMenu
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Group_x
'''</summary>
<TestMethod()>  _
Public Sub Group_xTest()
Dim target As frmInfoRequired = New frmInfoRequired ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.Group_x = expected
    actual = target.Group_x
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for First_Name
'''</summary>
<TestMethod()>  _
Public Sub First_NameTest()
Dim target As frmInfoRequired = New frmInfoRequired ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.First_Name = expected
    actual = target.First_Name
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ExportToExcelToolStripMenuItem
'''</summary>
<TestMethod()>  _
Public Sub ExportToExcelToolStripMenuItemTest()
Dim target As frmInfoRequired = New frmInfoRequired ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ExportToExcelToolStripMenuItem = expected
    actual = target.ExportToExcelToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ExportEstablishementxlsToolStripMenuItem
'''</summary>
<TestMethod()>  _
Public Sub ExportEstablishementxlsToolStripMenuItemTest()
Dim target As frmInfoRequired = New frmInfoRequired ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ExportEstablishementxlsToolStripMenuItem = expected
    actual = target.ExportEstablishementxlsToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ExportCFOApprovalsOutstandingToolStripMenuItem
'''</summary>
<TestMethod()>  _
Public Sub ExportCFOApprovalsOutstandingToolStripMenuItemTest()
Dim target As frmInfoRequired = New frmInfoRequired ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ExportCFOApprovalsOutstandingToolStripMenuItem = expected
    actual = target.ExportCFOApprovalsOutstandingToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for EstablishmentBindingSource
'''</summary>
<TestMethod()>  _
Public Sub EstablishmentBindingSourceTest()
Dim target As frmInfoRequired = New frmInfoRequired ' TODO: Initialize to an appropriate value
Dim expected As BindingSource = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As BindingSource
    target.EstablishmentBindingSource = expected
    actual = target.EstablishmentBindingSource
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Due
'''</summary>
<TestMethod()>  _
Public Sub DueTest()
Dim target As frmInfoRequired = New frmInfoRequired ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.Due = expected
    actual = target.Due
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Department_Name
'''</summary>
<TestMethod()>  _
Public Sub Department_NameTest()
Dim target As frmInfoRequired = New frmInfoRequired ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.Department_Name = expected
    actual = target.Department_Name
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DataGridViewTextBoxColumn9
'''</summary>
<TestMethod()>  _
Public Sub DataGridViewTextBoxColumn9Test()
Dim target As frmInfoRequired = New frmInfoRequired ' TODO: Initialize to an appropriate value
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
Dim target As frmInfoRequired = New frmInfoRequired ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.DataGridViewTextBoxColumn8 = expected
    actual = target.DataGridViewTextBoxColumn8
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DataGridViewTextBoxColumn6
'''</summary>
<TestMethod()>  _
Public Sub DataGridViewTextBoxColumn6Test()
Dim target As frmInfoRequired = New frmInfoRequired ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.DataGridViewTextBoxColumn6 = expected
    actual = target.DataGridViewTextBoxColumn6
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DataGridViewTextBoxColumn3
'''</summary>
<TestMethod()>  _
Public Sub DataGridViewTextBoxColumn3Test()
Dim target As frmInfoRequired = New frmInfoRequired ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.DataGridViewTextBoxColumn3 = expected
    actual = target.DataGridViewTextBoxColumn3
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DataGridViewTextBoxColumn20
'''</summary>
<TestMethod()>  _
Public Sub DataGridViewTextBoxColumn20Test()
Dim target As frmInfoRequired = New frmInfoRequired ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.DataGridViewTextBoxColumn20 = expected
    actual = target.DataGridViewTextBoxColumn20
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DataGridViewTextBoxColumn2
'''</summary>
<TestMethod()>  _
Public Sub DataGridViewTextBoxColumn2Test()
Dim target As frmInfoRequired = New frmInfoRequired ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.DataGridViewTextBoxColumn2 = expected
    actual = target.DataGridViewTextBoxColumn2
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DataGridViewTextBoxColumn18
'''</summary>
<TestMethod()>  _
Public Sub DataGridViewTextBoxColumn18Test()
Dim target As frmInfoRequired = New frmInfoRequired ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.DataGridViewTextBoxColumn18 = expected
    actual = target.DataGridViewTextBoxColumn18
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DataGridViewTextBoxColumn17
'''</summary>
<TestMethod()>  _
Public Sub DataGridViewTextBoxColumn17Test()
Dim target As frmInfoRequired = New frmInfoRequired ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.DataGridViewTextBoxColumn17 = expected
    actual = target.DataGridViewTextBoxColumn17
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DataGridViewTextBoxColumn16
'''</summary>
<TestMethod()>  _
Public Sub DataGridViewTextBoxColumn16Test()
Dim target As frmInfoRequired = New frmInfoRequired ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.DataGridViewTextBoxColumn16 = expected
    actual = target.DataGridViewTextBoxColumn16
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DataGridViewTextBoxColumn15
'''</summary>
<TestMethod()>  _
Public Sub DataGridViewTextBoxColumn15Test()
Dim target As frmInfoRequired = New frmInfoRequired ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.DataGridViewTextBoxColumn15 = expected
    actual = target.DataGridViewTextBoxColumn15
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DataGridViewTextBoxColumn14
'''</summary>
<TestMethod()>  _
Public Sub DataGridViewTextBoxColumn14Test()
Dim target As frmInfoRequired = New frmInfoRequired ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.DataGridViewTextBoxColumn14 = expected
    actual = target.DataGridViewTextBoxColumn14
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DataGridViewTextBoxColumn13
'''</summary>
<TestMethod()>  _
Public Sub DataGridViewTextBoxColumn13Test()
Dim target As frmInfoRequired = New frmInfoRequired ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.DataGridViewTextBoxColumn13 = expected
    actual = target.DataGridViewTextBoxColumn13
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DataGridViewTextBoxColumn12
'''</summary>
<TestMethod()>  _
Public Sub DataGridViewTextBoxColumn12Test()
Dim target As frmInfoRequired = New frmInfoRequired ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.DataGridViewTextBoxColumn12 = expected
    actual = target.DataGridViewTextBoxColumn12
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DataGridViewTextBoxColumn11
'''</summary>
<TestMethod()>  _
Public Sub DataGridViewTextBoxColumn11Test()
Dim target As frmInfoRequired = New frmInfoRequired ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.DataGridViewTextBoxColumn11 = expected
    actual = target.DataGridViewTextBoxColumn11
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DataGridViewTextBoxColumn10
'''</summary>
<TestMethod()>  _
Public Sub DataGridViewTextBoxColumn10Test()
Dim target As frmInfoRequired = New frmInfoRequired ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.DataGridViewTextBoxColumn10 = expected
    actual = target.DataGridViewTextBoxColumn10
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for CLoseThisRemedyRequestToolStripMenuItem
'''</summary>
<TestMethod()>  _
Public Sub CLoseThisRemedyRequestToolStripMenuItemTest()
Dim target As frmInfoRequired = New frmInfoRequired ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.CLoseThisRemedyRequestToolStripMenuItem = expected
    actual = target.CLoseThisRemedyRequestToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Captured
'''</summary>
<TestMethod()>  _
Public Sub CapturedTest()
Dim target As frmInfoRequired = New frmInfoRequired ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.Captured = expected
    actual = target.Captured
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for BindingNavigatorSeparator1
'''</summary>
<TestMethod()>  _
Public Sub BindingNavigatorSeparator1Test()
Dim target As frmInfoRequired = New frmInfoRequired ' TODO: Initialize to an appropriate value
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
Dim target As frmInfoRequired = New frmInfoRequired ' TODO: Initialize to an appropriate value
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
Dim target As frmInfoRequired = New frmInfoRequired ' TODO: Initialize to an appropriate value
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
Dim target As frmInfoRequired = New frmInfoRequired ' TODO: Initialize to an appropriate value
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
Dim target As frmInfoRequired = New frmInfoRequired ' TODO: Initialize to an appropriate value
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
Dim target As frmInfoRequired = New frmInfoRequired ' TODO: Initialize to an appropriate value
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
Dim target As frmInfoRequired = New frmInfoRequired ' TODO: Initialize to an appropriate value
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
Dim target As frmInfoRequired = New frmInfoRequired ' TODO: Initialize to an appropriate value
Dim expected As ToolStripLabel = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripLabel
    target.BindingNavigatorCountItem = expected
    actual = target.BindingNavigatorCountItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ARSystemDataSet
'''</summary>
<TestMethod()>  _
Public Sub ARSystemDataSetTest()
Dim target As frmInfoRequired = New frmInfoRequired ' TODO: Initialize to an appropriate value
Dim expected As dsARSystemDataSet = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As dsARSystemDataSet
    target.ARSystemDataSet = expected
    actual = target.ARSystemDataSet
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Ads
'''</summary>
<TestMethod()>  _
Public Sub AdsTest()
Dim target As frmInfoRequired = New frmInfoRequired ' TODO: Initialize to an appropriate value
Dim expected As dsADS = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As dsADS
    target.Ads = expected
    actual = target.Ads
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripButton1_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ToolStripButton1_ClickTest()
Dim target As frmInfoRequired_Accessor = New frmInfoRequired_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.ToolStripButton1_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for NoCFOLetterReceivedInTimeToolStripMenuItem_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub NoCFOLetterReceivedInTimeToolStripMenuItem_ClickTest()
Dim target As frmInfoRequired_Accessor = New frmInfoRequired_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.NoCFOLetterReceivedInTimeToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for LOG_IN_Request_TrackingDataGridView_KeyUp
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub LOG_IN_Request_TrackingDataGridView_KeyUpTest()
Dim target As frmInfoRequired_Accessor = New frmInfoRequired_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As KeyEventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.LOG_IN_Request_TrackingDataGridView_KeyUp(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for LOG_IN_Request_TrackingDataGridView_CellContentDoubleClick
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub LOG_IN_Request_TrackingDataGridView_CellContentDoubleClickTest()
Dim target As frmInfoRequired_Accessor = New frmInfoRequired_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As DataGridViewCellEventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.LOG_IN_Request_TrackingDataGridView_CellContentDoubleClick(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for InitializeComponent
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub InitializeComponentTest()
Dim target As frmInfoRequired_Accessor = New frmInfoRequired_Accessor ' TODO: Initialize to an appropriate value
    target.InitializeComponent
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for frmInfoRequired_ResizeEnd
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub frmInfoRequired_ResizeEndTest()
Dim target As frmInfoRequired_Accessor = New frmInfoRequired_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.frmInfoRequired_ResizeEnd(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for frmInfoRequired_Resize
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub frmInfoRequired_ResizeTest()
Dim target As frmInfoRequired_Accessor = New frmInfoRequired_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.frmInfoRequired_Resize(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for frmInfoRequired_Load
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub frmInfoRequired_LoadTest()
Dim target As frmInfoRequired_Accessor = New frmInfoRequired_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.frmInfoRequired_Load(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for frmInfoRequired_KeyPress
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub frmInfoRequired_KeyPressTest()
Dim target As frmInfoRequired_Accessor = New frmInfoRequired_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As KeyPressEventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.frmInfoRequired_KeyPress(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for FillToolStripButton_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub FillToolStripButton_ClickTest()
Dim target As frmInfoRequired_Accessor = New frmInfoRequired_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.FillToolStripButton_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for ExportToExcelToolStripMenuItem_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ExportToExcelToolStripMenuItem_ClickTest()
Dim target As frmInfoRequired_Accessor = New frmInfoRequired_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.ExportToExcelToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for ExportEstablishementxlsToolStripMenuItem_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ExportEstablishementxlsToolStripMenuItem_ClickTest()
Dim target As frmInfoRequired_Accessor = New frmInfoRequired_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.ExportEstablishementxlsToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for ExportCFOApprovalsOutstandingToolStripMenuItem_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ExportCFOApprovalsOutstandingToolStripMenuItem_ClickTest()
Dim target As frmInfoRequired_Accessor = New frmInfoRequired_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.ExportCFOApprovalsOutstandingToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for Dispose
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub DisposeTest()
Dim target As frmInfoRequired_Accessor = New frmInfoRequired_Accessor ' TODO: Initialize to an appropriate value
Dim disposing As Boolean = false ' TODO: Initialize to an appropriate value
    target.Dispose(disposing)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for CLoseThisRemedyRequestToolStripMenuItem_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub CLoseThisRemedyRequestToolStripMenuItem_ClickTest()
Dim target As frmInfoRequired_Accessor = New frmInfoRequired_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As MouseEventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.CLoseThisRemedyRequestToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for ARSystemDataSet_Initialized
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ARSystemDataSet_InitializedTest()
Dim target As frmInfoRequired_Accessor = New frmInfoRequired_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.ARSystemDataSet_Initialized(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for frmInfoRequired Constructor
'''</summary>
<TestMethod()>  _
Public Sub frmInfoRequiredConstructorTest()
    Dim target As frmInfoRequired = New frmInfoRequired
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub
End Class
