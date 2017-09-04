Imports ADAdminDotNet.dsARSystemDataSetTableAdapters

Imports System.Windows.Forms

Imports System

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports ADAdminDotNet



'''<summary>
'''This is a test class for frmRemedyBySurnameTest and is intended
'''to contain all frmRemedyBySurnameTest Unit Tests
'''</summary>
<TestClass()> _
Public Class frmRemedyBySurnameTest


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
'''A test for Z
'''</summary>
<TestMethod()>  _
Public Sub ZTest()
Dim target As frmRemedyBySurname = New frmRemedyBySurname ' TODO: Initialize to an appropriate value
Dim expected As TabPage = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TabPage
    target.Z = expected
    actual = target.Z
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Y
'''</summary>
<TestMethod()>  _
Public Sub YTest()
Dim target As frmRemedyBySurname = New frmRemedyBySurname ' TODO: Initialize to an appropriate value
Dim expected As TabPage = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TabPage
    target.Y = expected
    actual = target.Y
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for X
'''</summary>
<TestMethod()>  _
Public Sub XTest()
Dim target As frmRemedyBySurname = New frmRemedyBySurname ' TODO: Initialize to an appropriate value
Dim expected As TabPage = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TabPage
    target.X = expected
    actual = target.X
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for W
'''</summary>
<TestMethod()>  _
Public Sub WTest()
Dim target As frmRemedyBySurname = New frmRemedyBySurname ' TODO: Initialize to an appropriate value
Dim expected As TabPage = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TabPage
    target.W = expected
    actual = target.W
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for V
'''</summary>
<TestMethod()>  _
Public Sub VTest()
Dim target As frmRemedyBySurname = New frmRemedyBySurname ' TODO: Initialize to an appropriate value
Dim expected As TabPage = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TabPage
    target.V = expected
    actual = target.V
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for U
'''</summary>
<TestMethod()>  _
Public Sub UTest()
Dim target As frmRemedyBySurname = New frmRemedyBySurname ' TODO: Initialize to an appropriate value
Dim expected As TabPage = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TabPage
    target.U = expected
    actual = target.U
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for txtSearch
'''</summary>
<TestMethod()>  _
Public Sub txtSearchTest()
Dim target As frmRemedyBySurname = New frmRemedyBySurname ' TODO: Initialize to an appropriate value
Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TextBox
    target.txtSearch = expected
    actual = target.txtSearch
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem2
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem2Test()
Dim target As frmRemedyBySurname = New frmRemedyBySurname ' TODO: Initialize to an appropriate value
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
Dim target As frmRemedyBySurname = New frmRemedyBySurname ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
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
Dim target As frmRemedyBySurname = New frmRemedyBySurname ' TODO: Initialize to an appropriate value
Dim expected As ToolStripDropDownButton = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripDropDownButton
    target.ToolStripDropDownButton1 = expected
    actual = target.ToolStripDropDownButton1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for TabControl1
'''</summary>
<TestMethod()>  _
Public Sub TabControl1Test()
Dim target As frmRemedyBySurname = New frmRemedyBySurname ' TODO: Initialize to an appropriate value
Dim expected As TabControl = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TabControl
    target.TabControl1 = expected
    actual = target.TabControl1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for T
'''</summary>
<TestMethod()>  _
Public Sub TTest()
Dim target As frmRemedyBySurname = New frmRemedyBySurname ' TODO: Initialize to an appropriate value
Dim expected As TabPage = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TabPage
    target.T = expected
    actual = target.T
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for StatusStrip1
'''</summary>
<TestMethod()>  _
Public Sub StatusStrip1Test()
Dim target As frmRemedyBySurname = New frmRemedyBySurname ' TODO: Initialize to an appropriate value
Dim expected As StatusStrip = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As StatusStrip
    target.StatusStrip1 = expected
    actual = target.StatusStrip1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for S
'''</summary>
<TestMethod()>  _
Public Sub STest()
Dim target As frmRemedyBySurname = New frmRemedyBySurname ' TODO: Initialize to an appropriate value
Dim expected As TabPage = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TabPage
    target.S = expected
    actual = target.S
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for RemedyByFirstLetterOfSurnameTableAdapter
'''</summary>
<TestMethod()>  _
Public Sub RemedyByFirstLetterOfSurnameTableAdapterTest()
Dim target As frmRemedyBySurname = New frmRemedyBySurname ' TODO: Initialize to an appropriate value
Dim expected As RemedyByFirstLetterOfSurnameTableAdapter = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As RemedyByFirstLetterOfSurnameTableAdapter
    target.RemedyByFirstLetterOfSurnameTableAdapter = expected
    actual = target.RemedyByFirstLetterOfSurnameTableAdapter
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for RemedyByFirstLetterOfSurnameDataGridView
'''</summary>
<TestMethod()>  _
Public Sub RemedyByFirstLetterOfSurnameDataGridViewTest()
Dim target As frmRemedyBySurname = New frmRemedyBySurname ' TODO: Initialize to an appropriate value
Dim expected As DataGridView = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridView
    target.RemedyByFirstLetterOfSurnameDataGridView = expected
    actual = target.RemedyByFirstLetterOfSurnameDataGridView
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for RemedyByFirstLetterOfSurnameBindingSource
'''</summary>
<TestMethod()>  _
Public Sub RemedyByFirstLetterOfSurnameBindingSourceTest()
Dim target As frmRemedyBySurname = New frmRemedyBySurname ' TODO: Initialize to an appropriate value
Dim expected As BindingSource = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As BindingSource
    target.RemedyByFirstLetterOfSurnameBindingSource = expected
    actual = target.RemedyByFirstLetterOfSurnameBindingSource
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for RemedyByFirstLetterOfSurnameBindingNavigatorSaveItem
'''</summary>
<TestMethod()>  _
Public Sub RemedyByFirstLetterOfSurnameBindingNavigatorSaveItemTest()
Dim target As frmRemedyBySurname = New frmRemedyBySurname ' TODO: Initialize to an appropriate value
Dim expected As ToolStripButton = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripButton
    target.RemedyByFirstLetterOfSurnameBindingNavigatorSaveItem = expected
    actual = target.RemedyByFirstLetterOfSurnameBindingNavigatorSaveItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for RemedyByFirstLetterOfSurnameBindingNavigator
'''</summary>
<TestMethod()>  _
Public Sub RemedyByFirstLetterOfSurnameBindingNavigatorTest()
Dim target As frmRemedyBySurname = New frmRemedyBySurname ' TODO: Initialize to an appropriate value
Dim expected As BindingNavigator = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As BindingNavigator
    target.RemedyByFirstLetterOfSurnameBindingNavigator = expected
    actual = target.RemedyByFirstLetterOfSurnameBindingNavigator
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for R
'''</summary>
<TestMethod()>  _
Public Sub RTest()
Dim target As frmRemedyBySurname = New frmRemedyBySurname ' TODO: Initialize to an appropriate value
Dim expected As TabPage = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TabPage
    target.R = expected
    actual = target.R
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Q
'''</summary>
<TestMethod()>  _
Public Sub QTest()
Dim target As frmRemedyBySurname = New frmRemedyBySurname ' TODO: Initialize to an appropriate value
Dim expected As TabPage = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TabPage
    target.Q = expected
    actual = target.Q
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for P
'''</summary>
<TestMethod()>  _
Public Sub PTest()
Dim target As frmRemedyBySurname = New frmRemedyBySurname ' TODO: Initialize to an appropriate value
Dim expected As TabPage = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TabPage
    target.P = expected
    actual = target.P
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for O
'''</summary>
<TestMethod()>  _
Public Sub OTest()
Dim target As frmRemedyBySurname = New frmRemedyBySurname ' TODO: Initialize to an appropriate value
Dim expected As TabPage = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TabPage
    target.O = expected
    actual = target.O
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for N
'''</summary>
<TestMethod()>  _
Public Sub NTest()
Dim target As frmRemedyBySurname = New frmRemedyBySurname ' TODO: Initialize to an appropriate value
Dim expected As TabPage = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TabPage
    target.N = expected
    actual = target.N
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for M
'''</summary>
<TestMethod()>  _
Public Sub MTest()
Dim target As frmRemedyBySurname = New frmRemedyBySurname ' TODO: Initialize to an appropriate value
Dim expected As TabPage = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TabPage
    target.M = expected
    actual = target.M
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Label1
'''</summary>
<TestMethod()>  _
Public Sub Label1Test()
Dim target As frmRemedyBySurname = New frmRemedyBySurname ' TODO: Initialize to an appropriate value
Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Label
    target.Label1 = expected
    actual = target.Label1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for L
'''</summary>
<TestMethod()>  _
Public Sub LTest()
Dim target As frmRemedyBySurname = New frmRemedyBySurname ' TODO: Initialize to an appropriate value
Dim expected As TabPage = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TabPage
    target.L = expected
    actual = target.L
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for K
'''</summary>
<TestMethod()>  _
Public Sub KTest()
Dim target As frmRemedyBySurname = New frmRemedyBySurname ' TODO: Initialize to an appropriate value
Dim expected As TabPage = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TabPage
    target.K = expected
    actual = target.K
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for J
'''</summary>
<TestMethod()>  _
Public Sub JTest()
Dim target As frmRemedyBySurname = New frmRemedyBySurname ' TODO: Initialize to an appropriate value
Dim expected As TabPage = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TabPage
    target.J = expected
    actual = target.J
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for I
'''</summary>
<TestMethod()>  _
Public Sub ITest()
Dim target As frmRemedyBySurname = New frmRemedyBySurname ' TODO: Initialize to an appropriate value
Dim expected As TabPage = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TabPage
    target.I = expected
    actual = target.I
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for H
'''</summary>
<TestMethod()>  _
Public Sub HTest()
Dim target As frmRemedyBySurname = New frmRemedyBySurname ' TODO: Initialize to an appropriate value
Dim expected As TabPage = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TabPage
    target.H = expected
    actual = target.H
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for G
'''</summary>
<TestMethod()>  _
Public Sub GTest()
Dim target As frmRemedyBySurname = New frmRemedyBySurname ' TODO: Initialize to an appropriate value
Dim expected As TabPage = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TabPage
    target.G = expected
    actual = target.G
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for F
'''</summary>
<TestMethod()>  _
Public Sub FTest()
Dim target As frmRemedyBySurname = New frmRemedyBySurname ' TODO: Initialize to an appropriate value
Dim expected As TabPage = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TabPage
    target.F = expected
    actual = target.F
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ExportSelectedTabToCSVToolStripMenuItem
'''</summary>
<TestMethod()>  _
Public Sub ExportSelectedTabToCSVToolStripMenuItemTest()
Dim target As frmRemedyBySurname = New frmRemedyBySurname ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ExportSelectedTabToCSVToolStripMenuItem = expected
    actual = target.ExportSelectedTabToCSVToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for E
'''</summary>
<TestMethod()>  _
Public Sub ETest()
Dim target As frmRemedyBySurname = New frmRemedyBySurname ' TODO: Initialize to an appropriate value
Dim expected As TabPage = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TabPage
    target.E = expected
    actual = target.E
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DataGridViewTextBoxColumn9
'''</summary>
<TestMethod()>  _
Public Sub DataGridViewTextBoxColumn9Test()
Dim target As frmRemedyBySurname = New frmRemedyBySurname ' TODO: Initialize to an appropriate value
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
Dim target As frmRemedyBySurname = New frmRemedyBySurname ' TODO: Initialize to an appropriate value
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
Dim target As frmRemedyBySurname = New frmRemedyBySurname ' TODO: Initialize to an appropriate value
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
Dim target As frmRemedyBySurname = New frmRemedyBySurname ' TODO: Initialize to an appropriate value
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
Dim target As frmRemedyBySurname = New frmRemedyBySurname ' TODO: Initialize to an appropriate value
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
Dim target As frmRemedyBySurname = New frmRemedyBySurname ' TODO: Initialize to an appropriate value
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
Dim target As frmRemedyBySurname = New frmRemedyBySurname ' TODO: Initialize to an appropriate value
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
Dim target As frmRemedyBySurname = New frmRemedyBySurname ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.DataGridViewTextBoxColumn2 = expected
    actual = target.DataGridViewTextBoxColumn2
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DataGridViewTextBoxColumn16
'''</summary>
<TestMethod()>  _
Public Sub DataGridViewTextBoxColumn16Test()
Dim target As frmRemedyBySurname = New frmRemedyBySurname ' TODO: Initialize to an appropriate value
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
Dim target As frmRemedyBySurname = New frmRemedyBySurname ' TODO: Initialize to an appropriate value
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
Dim target As frmRemedyBySurname = New frmRemedyBySurname ' TODO: Initialize to an appropriate value
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
Dim target As frmRemedyBySurname = New frmRemedyBySurname ' TODO: Initialize to an appropriate value
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
Dim target As frmRemedyBySurname = New frmRemedyBySurname ' TODO: Initialize to an appropriate value
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
Dim target As frmRemedyBySurname = New frmRemedyBySurname ' TODO: Initialize to an appropriate value
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
Dim target As frmRemedyBySurname = New frmRemedyBySurname ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.DataGridViewTextBoxColumn10 = expected
    actual = target.DataGridViewTextBoxColumn10
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for D
'''</summary>
<TestMethod()>  _
Public Sub DTest()
Dim target As frmRemedyBySurname = New frmRemedyBySurname ' TODO: Initialize to an appropriate value
Dim expected As TabPage = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TabPage
    target.D = expected
    actual = target.D
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for C
'''</summary>
<TestMethod()>  _
Public Sub CTest()
Dim target As frmRemedyBySurname = New frmRemedyBySurname ' TODO: Initialize to an appropriate value
Dim expected As TabPage = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TabPage
    target.C = expected
    actual = target.C
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for BindingNavigatorSeparator2
'''</summary>
<TestMethod()>  _
Public Sub BindingNavigatorSeparator2Test()
Dim target As frmRemedyBySurname = New frmRemedyBySurname ' TODO: Initialize to an appropriate value
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
Dim target As frmRemedyBySurname = New frmRemedyBySurname ' TODO: Initialize to an appropriate value
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
Dim target As frmRemedyBySurname = New frmRemedyBySurname ' TODO: Initialize to an appropriate value
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
Dim target As frmRemedyBySurname = New frmRemedyBySurname ' TODO: Initialize to an appropriate value
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
Dim target As frmRemedyBySurname = New frmRemedyBySurname ' TODO: Initialize to an appropriate value
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
Dim target As frmRemedyBySurname = New frmRemedyBySurname ' TODO: Initialize to an appropriate value
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
Dim target As frmRemedyBySurname = New frmRemedyBySurname ' TODO: Initialize to an appropriate value
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
Dim target As frmRemedyBySurname = New frmRemedyBySurname ' TODO: Initialize to an appropriate value
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
Dim target As frmRemedyBySurname = New frmRemedyBySurname ' TODO: Initialize to an appropriate value
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
Dim target As frmRemedyBySurname = New frmRemedyBySurname ' TODO: Initialize to an appropriate value
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
Dim target As frmRemedyBySurname = New frmRemedyBySurname ' TODO: Initialize to an appropriate value
Dim expected As ToolStripButton = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripButton
    target.BindingNavigatorAddNewItem = expected
    actual = target.BindingNavigatorAddNewItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for B
'''</summary>
<TestMethod()>  _
Public Sub BTest()
Dim target As frmRemedyBySurname = New frmRemedyBySurname ' TODO: Initialize to an appropriate value
Dim expected As TabPage = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TabPage
    target.B = expected
    actual = target.B
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ARSystemDataSet
'''</summary>
<TestMethod()>  _
Public Sub ARSystemDataSetTest()
Dim target As frmRemedyBySurname = New frmRemedyBySurname ' TODO: Initialize to an appropriate value
Dim expected As dsARSystemDataSet = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As dsARSystemDataSet
    target.ARSystemDataSet = expected
    actual = target.ARSystemDataSet
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for A
'''</summary>
<TestMethod()>  _
Public Sub ATest()
Dim target As frmRemedyBySurname = New frmRemedyBySurname ' TODO: Initialize to an appropriate value
Dim expected As TabPage = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TabPage
    target.A = expected
    actual = target.A
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for txtSearch_TextChanged
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub txtSearch_TextChangedTest()
Dim target As frmRemedyBySurname_Accessor = New frmRemedyBySurname_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.txtSearch_TextChanged(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem1_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ToolStripMenuItem1_ClickTest()
Dim target As frmRemedyBySurname_Accessor = New frmRemedyBySurname_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.ToolStripMenuItem1_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for TabControl1_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub TabControl1_ClickTest()
Dim target As frmRemedyBySurname_Accessor = New frmRemedyBySurname_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.TabControl1_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for RemedyByFirstLetterOfSurnameDataGridView_keypress
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub RemedyByFirstLetterOfSurnameDataGridView_keypressTest()
Dim target As frmRemedyBySurname_Accessor = New frmRemedyBySurname_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As KeyPressEventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.RemedyByFirstLetterOfSurnameDataGridView_keypress(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for RemedyByFirstLetterOfSurnameDataGridView_CellContentDoubleClick
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub RemedyByFirstLetterOfSurnameDataGridView_CellContentDoubleClickTest()
Dim target As frmRemedyBySurname_Accessor = New frmRemedyBySurname_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As DataGridViewCellEventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.RemedyByFirstLetterOfSurnameDataGridView_CellContentDoubleClick(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for InitializeComponent
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub InitializeComponentTest()
Dim target As frmRemedyBySurname_Accessor = New frmRemedyBySurname_Accessor ' TODO: Initialize to an appropriate value
    target.InitializeComponent
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for frmRemedyBySurname_ResizeEnd
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub frmRemedyBySurname_ResizeEndTest()
Dim target As frmRemedyBySurname_Accessor = New frmRemedyBySurname_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.frmRemedyBySurname_ResizeEnd(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for frmRemedyBySurname_Load
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub frmRemedyBySurname_LoadTest()
Dim target As frmRemedyBySurname_Accessor = New frmRemedyBySurname_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.frmRemedyBySurname_Load(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for frmRemedyBySurname_KeyPress
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub frmRemedyBySurname_KeyPressTest()
Dim target As frmRemedyBySurname_Accessor = New frmRemedyBySurname_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As KeyPressEventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.frmRemedyBySurname_KeyPress(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for ExportSelectedTabToCSVToolStripMenuItem_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ExportSelectedTabToCSVToolStripMenuItem_ClickTest()
Dim target As frmRemedyBySurname_Accessor = New frmRemedyBySurname_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.ExportSelectedTabToCSVToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for Dispose
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub DisposeTest()
Dim target As frmRemedyBySurname_Accessor = New frmRemedyBySurname_Accessor ' TODO: Initialize to an appropriate value
Dim disposing As Boolean = false ' TODO: Initialize to an appropriate value
    target.Dispose(disposing)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for frmRemedyBySurname Constructor
'''</summary>
<TestMethod()>  _
Public Sub frmRemedyBySurnameConstructorTest()
    Dim target As frmRemedyBySurname = New frmRemedyBySurname
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub
End Class
