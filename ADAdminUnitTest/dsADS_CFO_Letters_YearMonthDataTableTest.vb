Imports System.Xml.Schema

Imports System

Imports System.Data

Imports System.Runtime.Serialization

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports ADAdminDotNet



'''<summary>
'''This is a test class for dsADS_CFO_Letters_YearMonthDataTableTest and is intended
'''to contain all dsADS_CFO_Letters_YearMonthDataTableTest Unit Tests
'''</summary>
<TestClass()> _
Public Class dsADS_CFO_Letters_YearMonthDataTableTest


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
'''A test for YearDateColumn
'''</summary>
<TestMethod()>  _
Public Sub YearDateColumnTest()
Dim target As dsADS.CFO_Letters_YearMonthDataTable = New dsADS.CFO_Letters_YearMonthDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.YearDateColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Item
'''</summary>
<TestMethod()>  _
Public Sub ItemTest()
Dim target As dsADS.CFO_Letters_YearMonthDataTable = New dsADS.CFO_Letters_YearMonthDataTable ' TODO: Initialize to an appropriate value
Dim index As Integer = 0 ' TODO: Initialize to an appropriate value
    Dim actual As dsADS.CFO_Letters_YearMonthRow
    actual = target(index)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Count
'''</summary>
<TestMethod()>  _
Public Sub CountTest()
Dim target As dsADS.CFO_Letters_YearMonthDataTable = New dsADS.CFO_Letters_YearMonthDataTable ' TODO: Initialize to an appropriate value
    Dim actual As Integer
    actual = target.Count
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for CFO_Letters_SentColumn
'''</summary>
<TestMethod()>  _
Public Sub CFO_Letters_SentColumnTest()
Dim target As dsADS.CFO_Letters_YearMonthDataTable = New dsADS.CFO_Letters_YearMonthDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.CFO_Letters_SentColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for RemoveCFO_Letters_YearMonthRow
'''</summary>
<TestMethod()>  _
Public Sub RemoveCFO_Letters_YearMonthRowTest()
Dim target As dsADS.CFO_Letters_YearMonthDataTable = New dsADS.CFO_Letters_YearMonthDataTable ' TODO: Initialize to an appropriate value
Dim row As dsADS.CFO_Letters_YearMonthRow = Nothing ' TODO: Initialize to an appropriate value
    target.RemoveCFO_Letters_YearMonthRow(row)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for OnRowDeleting
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub OnRowDeletingTest()
Dim target As dsADS_Accessor.CFO_Letters_YearMonthDataTable = New dsADS_Accessor.CFO_Letters_YearMonthDataTable ' TODO: Initialize to an appropriate value
Dim e As DataRowChangeEventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.OnRowDeleting(e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for OnRowDeleted
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub OnRowDeletedTest()
Dim target As dsADS_Accessor.CFO_Letters_YearMonthDataTable = New dsADS_Accessor.CFO_Letters_YearMonthDataTable ' TODO: Initialize to an appropriate value
Dim e As DataRowChangeEventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.OnRowDeleted(e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for OnRowChanging
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub OnRowChangingTest()
Dim target As dsADS_Accessor.CFO_Letters_YearMonthDataTable = New dsADS_Accessor.CFO_Letters_YearMonthDataTable ' TODO: Initialize to an appropriate value
Dim e As DataRowChangeEventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.OnRowChanging(e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for OnRowChanged
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub OnRowChangedTest()
Dim target As dsADS_Accessor.CFO_Letters_YearMonthDataTable = New dsADS_Accessor.CFO_Letters_YearMonthDataTable ' TODO: Initialize to an appropriate value
Dim e As DataRowChangeEventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.OnRowChanged(e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for NewRowFromBuilder
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub NewRowFromBuilderTest()
Dim target As dsADS_Accessor.CFO_Letters_YearMonthDataTable = New dsADS_Accessor.CFO_Letters_YearMonthDataTable ' TODO: Initialize to an appropriate value
Dim builder As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim expected As DataRow = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataRow
    actual = target.NewRowFromBuilder(builder)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for NewCFO_Letters_YearMonthRow
'''</summary>
<TestMethod()>  _
Public Sub NewCFO_Letters_YearMonthRowTest()
Dim target As dsADS.CFO_Letters_YearMonthDataTable = New dsADS.CFO_Letters_YearMonthDataTable ' TODO: Initialize to an appropriate value
Dim expected As dsADS.CFO_Letters_YearMonthRow = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As dsADS.CFO_Letters_YearMonthRow
    actual = target.NewCFO_Letters_YearMonthRow
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for InitVars
'''</summary>
<TestMethod()>  _
Public Sub InitVarsTest()
Dim target As dsADS.CFO_Letters_YearMonthDataTable = New dsADS.CFO_Letters_YearMonthDataTable ' TODO: Initialize to an appropriate value
    target.InitVars
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for InitClass
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub InitClassTest()
Dim target As dsADS_Accessor.CFO_Letters_YearMonthDataTable = New dsADS_Accessor.CFO_Letters_YearMonthDataTable ' TODO: Initialize to an appropriate value
    target.InitClass
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for GetTypedTableSchema
'''</summary>
<TestMethod()>  _
Public Sub GetTypedTableSchemaTest()
Dim xs As XmlSchemaSet = Nothing ' TODO: Initialize to an appropriate value
Dim expected As XmlSchemaComplexType = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As XmlSchemaComplexType
    actual = dsADS.CFO_Letters_YearMonthDataTable.GetTypedTableSchema(xs)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for GetRowType
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub GetRowTypeTest()
Dim target As dsADS_Accessor.CFO_Letters_YearMonthDataTable = New dsADS_Accessor.CFO_Letters_YearMonthDataTable ' TODO: Initialize to an appropriate value
Dim expected As Type = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Type
    actual = target.GetRowType
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for CreateInstance
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub CreateInstanceTest()
Dim target As dsADS_Accessor.CFO_Letters_YearMonthDataTable = New dsADS_Accessor.CFO_Letters_YearMonthDataTable ' TODO: Initialize to an appropriate value
Dim expected As DataTable = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataTable
    actual = target.CreateInstance
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Clone
'''</summary>
<TestMethod()>  _
Public Sub CloneTest()
Dim target As dsADS.CFO_Letters_YearMonthDataTable = New dsADS.CFO_Letters_YearMonthDataTable ' TODO: Initialize to an appropriate value
Dim expected As DataTable = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataTable
    actual = target.Clone
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for AddCFO_Letters_YearMonthRow
'''</summary>
<TestMethod()>  _
Public Sub AddCFO_Letters_YearMonthRowTest1()
Dim target As dsADS.CFO_Letters_YearMonthDataTable = New dsADS.CFO_Letters_YearMonthDataTable ' TODO: Initialize to an appropriate value
Dim row As dsADS.CFO_Letters_YearMonthRow = Nothing ' TODO: Initialize to an appropriate value
    target.AddCFO_Letters_YearMonthRow(row)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for AddCFO_Letters_YearMonthRow
'''</summary>
<TestMethod()>  _
Public Sub AddCFO_Letters_YearMonthRowTest()
Dim target As dsADS.CFO_Letters_YearMonthDataTable = New dsADS.CFO_Letters_YearMonthDataTable ' TODO: Initialize to an appropriate value
Dim YearDate As String = String.Empty ' TODO: Initialize to an appropriate value
Dim CFO_Letters_Sent As Integer = 0 ' TODO: Initialize to an appropriate value
Dim expected As dsADS.CFO_Letters_YearMonthRow = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As dsADS.CFO_Letters_YearMonthRow
    actual = target.AddCFO_Letters_YearMonthRow(YearDate, CFO_Letters_Sent)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for CFO_Letters_YearMonthDataTable Constructor
'''</summary>
<TestMethod()>  _
Public Sub dsADS_CFO_Letters_YearMonthDataTableConstructorTest2()
    Dim target As dsADS.CFO_Letters_YearMonthDataTable = New dsADS.CFO_Letters_YearMonthDataTable
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub

'''<summary>
'''A test for CFO_Letters_YearMonthDataTable Constructor
'''</summary>
<TestMethod()>  _
Public Sub dsADS_CFO_Letters_YearMonthDataTableConstructorTest1()
Dim table As DataTable = Nothing ' TODO: Initialize to an appropriate value
    Dim target As dsADS.CFO_Letters_YearMonthDataTable = New dsADS.CFO_Letters_YearMonthDataTable(table)
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub

'''<summary>
'''A test for CFO_Letters_YearMonthDataTable Constructor
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub dsADS_CFO_Letters_YearMonthDataTableConstructorTest()
Dim info As SerializationInfo = Nothing ' TODO: Initialize to an appropriate value
Dim context As StreamingContext = New StreamingContext ' TODO: Initialize to an appropriate value
    Dim target As dsADS_Accessor.CFO_Letters_YearMonthDataTable = New dsADS_Accessor.CFO_Letters_YearMonthDataTable(info, context)
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub
End Class
