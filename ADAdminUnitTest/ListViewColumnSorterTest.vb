Imports System.Windows.Forms

Imports System.Collections

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports ADAdminDotNet



'''<summary>
'''This is a test class for ListViewColumnSorterTest and is intended
'''to contain all ListViewColumnSorterTest Unit Tests
'''</summary>
<TestClass()> _
Public Class ListViewColumnSorterTest


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
'''A test for SortColumn
'''</summary>
<TestMethod()>  _
Public Sub SortColumnTest()
Dim target As ListViewColumnSorter = New ListViewColumnSorter ' TODO: Initialize to an appropriate value
Dim expected As Integer = 0 ' TODO: Initialize to an appropriate value
    Dim actual As Integer
    target.SortColumn = expected
    actual = target.SortColumn
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Order
'''</summary>
<TestMethod()>  _
Public Sub OrderTest()
Dim target As ListViewColumnSorter = New ListViewColumnSorter ' TODO: Initialize to an appropriate value
Dim expected As SortOrder = New SortOrder ' TODO: Initialize to an appropriate value
    Dim actual As SortOrder
    target.Order = expected
    actual = target.Order
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Compare
'''</summary>
<TestMethod()>  _
Public Sub CompareTest()
Dim target As IComparer = New ListViewColumnSorter ' TODO: Initialize to an appropriate value
Dim x As Object = Nothing ' TODO: Initialize to an appropriate value
Dim y As Object = Nothing ' TODO: Initialize to an appropriate value
Dim expected As Integer = 0 ' TODO: Initialize to an appropriate value
    Dim actual As Integer
    actual = target.Compare(x, y)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ListViewColumnSorter Constructor
'''</summary>
<TestMethod()>  _
Public Sub ListViewColumnSorterConstructorTest()
    Dim target As ListViewColumnSorter = New ListViewColumnSorter
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub
End Class
