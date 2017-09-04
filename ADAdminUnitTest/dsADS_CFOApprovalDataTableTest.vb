Imports System.Xml.Schema

Imports System

Imports System.Data

Imports System.Runtime.Serialization

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports ADAdminDotNet



'''<summary>
'''This is a test class for dsADS_CFOApprovalDataTableTest and is intended
'''to contain all dsADS_CFOApprovalDataTableTest Unit Tests
'''</summary>
<TestClass()> _
Public Class dsADS_CFOApprovalDataTableTest


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
'''A test for VulCompletedColumn
'''</summary>
<TestMethod()>  _
Public Sub VulCompletedColumnTest()
Dim target As dsADS.CFOApprovalDataTable = New dsADS.CFOApprovalDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.VulCompletedColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for VULCommentsColumn
'''</summary>
<TestMethod()>  _
Public Sub VULCommentsColumnTest()
Dim target As dsADS.CFOApprovalDataTable = New dsADS.CFOApprovalDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.VULCommentsColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for RequestNoColumn
'''</summary>
<TestMethod()>  _
Public Sub RequestNoColumnTest()
Dim target As dsADS.CFOApprovalDataTable = New dsADS.CFOApprovalDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.RequestNoColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for NTDateColumn
'''</summary>
<TestMethod()>  _
Public Sub NTDateColumnTest()
Dim target As dsADS.CFOApprovalDataTable = New dsADS.CFOApprovalDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.NTDateColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for NTCommentsColumn
'''</summary>
<TestMethod()>  _
Public Sub NTCommentsColumnTest()
Dim target As dsADS.CFOApprovalDataTable = New dsADS.CFOApprovalDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.NTCommentsColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Item
'''</summary>
<TestMethod()>  _
Public Sub ItemTest()
Dim target As dsADS.CFOApprovalDataTable = New dsADS.CFOApprovalDataTable ' TODO: Initialize to an appropriate value
Dim index As Integer = 0 ' TODO: Initialize to an appropriate value
    Dim actual As dsADS.CFOApprovalRow
    actual = target(index)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IsrunningColumn
'''</summary>
<TestMethod()>  _
Public Sub IsrunningColumnTest()
Dim target As dsADS.CFOApprovalDataTable = New dsADS.CFOApprovalDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.IsrunningColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for FlowDescriptionColumn
'''</summary>
<TestMethod()>  _
Public Sub FlowDescriptionColumnTest()
Dim target As dsADS.CFOApprovalDataTable = New dsADS.CFOApprovalDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.FlowDescriptionColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Count
'''</summary>
<TestMethod()>  _
Public Sub CountTest()
Dim target As dsADS.CFOApprovalDataTable = New dsADS.CFOApprovalDataTable ' TODO: Initialize to an appropriate value
    Dim actual As Integer
    actual = target.Count
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for CFODateColumn
'''</summary>
<TestMethod()>  _
Public Sub CFODateColumnTest()
Dim target As dsADS.CFOApprovalDataTable = New dsADS.CFOApprovalDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.CFODateColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for CFOCommentsColumn
'''</summary>
<TestMethod()>  _
Public Sub CFOCommentsColumnTest()
Dim target As dsADS.CFOApprovalDataTable = New dsADS.CFOApprovalDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.CFOCommentsColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ActiveColumn
'''</summary>
<TestMethod()>  _
Public Sub ActiveColumnTest()
Dim target As dsADS.CFOApprovalDataTable = New dsADS.CFOApprovalDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.ActiveColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for RemoveCFOApprovalRow
'''</summary>
<TestMethod()>  _
Public Sub RemoveCFOApprovalRowTest()
Dim target As dsADS.CFOApprovalDataTable = New dsADS.CFOApprovalDataTable ' TODO: Initialize to an appropriate value
Dim row As dsADS.CFOApprovalRow = Nothing ' TODO: Initialize to an appropriate value
    target.RemoveCFOApprovalRow(row)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for OnRowDeleting
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub OnRowDeletingTest()
Dim target As dsADS_Accessor.CFOApprovalDataTable = New dsADS_Accessor.CFOApprovalDataTable ' TODO: Initialize to an appropriate value
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
Dim target As dsADS_Accessor.CFOApprovalDataTable = New dsADS_Accessor.CFOApprovalDataTable ' TODO: Initialize to an appropriate value
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
Dim target As dsADS_Accessor.CFOApprovalDataTable = New dsADS_Accessor.CFOApprovalDataTable ' TODO: Initialize to an appropriate value
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
Dim target As dsADS_Accessor.CFOApprovalDataTable = New dsADS_Accessor.CFOApprovalDataTable ' TODO: Initialize to an appropriate value
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
Dim target As dsADS_Accessor.CFOApprovalDataTable = New dsADS_Accessor.CFOApprovalDataTable ' TODO: Initialize to an appropriate value
Dim builder As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim expected As DataRow = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataRow
    actual = target.NewRowFromBuilder(builder)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for NewCFOApprovalRow
'''</summary>
<TestMethod()>  _
Public Sub NewCFOApprovalRowTest()
Dim target As dsADS.CFOApprovalDataTable = New dsADS.CFOApprovalDataTable ' TODO: Initialize to an appropriate value
Dim expected As dsADS.CFOApprovalRow = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As dsADS.CFOApprovalRow
    actual = target.NewCFOApprovalRow
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for InitVars
'''</summary>
<TestMethod()>  _
Public Sub InitVarsTest()
Dim target As dsADS.CFOApprovalDataTable = New dsADS.CFOApprovalDataTable ' TODO: Initialize to an appropriate value
    target.InitVars
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for InitClass
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub InitClassTest()
Dim target As dsADS_Accessor.CFOApprovalDataTable = New dsADS_Accessor.CFOApprovalDataTable ' TODO: Initialize to an appropriate value
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
    actual = dsADS.CFOApprovalDataTable.GetTypedTableSchema(xs)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for GetRowType
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub GetRowTypeTest()
Dim target As dsADS_Accessor.CFOApprovalDataTable = New dsADS_Accessor.CFOApprovalDataTable ' TODO: Initialize to an appropriate value
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
Dim target As dsADS_Accessor.CFOApprovalDataTable = New dsADS_Accessor.CFOApprovalDataTable ' TODO: Initialize to an appropriate value
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
Dim target As dsADS.CFOApprovalDataTable = New dsADS.CFOApprovalDataTable ' TODO: Initialize to an appropriate value
Dim expected As DataTable = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataTable
    actual = target.Clone
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for AddCFOApprovalRow
'''</summary>
<TestMethod()>  _
Public Sub AddCFOApprovalRowTest1()
Dim target As dsADS.CFOApprovalDataTable = New dsADS.CFOApprovalDataTable ' TODO: Initialize to an appropriate value
Dim row As dsADS.CFOApprovalRow = Nothing ' TODO: Initialize to an appropriate value
    target.AddCFOApprovalRow(row)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for AddCFOApprovalRow
'''</summary>
<TestMethod()>  _
Public Sub AddCFOApprovalRowTest()
Dim target As dsADS.CFOApprovalDataTable = New dsADS.CFOApprovalDataTable ' TODO: Initialize to an appropriate value
Dim RequestNo As String = String.Empty ' TODO: Initialize to an appropriate value
Dim FlowDescription As String = String.Empty ' TODO: Initialize to an appropriate value
Dim CFODate As DateTime = New DateTime ' TODO: Initialize to an appropriate value
Dim CFOComments As String = String.Empty ' TODO: Initialize to an appropriate value
Dim NTDate As DateTime = New DateTime ' TODO: Initialize to an appropriate value
Dim NTComments As String = String.Empty ' TODO: Initialize to an appropriate value
Dim VulCompleted As DateTime = New DateTime ' TODO: Initialize to an appropriate value
Dim VULComments As String = String.Empty ' TODO: Initialize to an appropriate value
Dim Isrunning As Boolean = false ' TODO: Initialize to an appropriate value
Dim Active As Boolean = false ' TODO: Initialize to an appropriate value
Dim expected As dsADS.CFOApprovalRow = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As dsADS.CFOApprovalRow
    actual = target.AddCFOApprovalRow(RequestNo, FlowDescription, CFODate, CFOComments, NTDate, NTComments, VulCompleted, VULComments, Isrunning, Active)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for CFOApprovalDataTable Constructor
'''</summary>
<TestMethod()>  _
Public Sub dsADS_CFOApprovalDataTableConstructorTest2()
    Dim target As dsADS.CFOApprovalDataTable = New dsADS.CFOApprovalDataTable
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub

'''<summary>
'''A test for CFOApprovalDataTable Constructor
'''</summary>
<TestMethod()>  _
Public Sub dsADS_CFOApprovalDataTableConstructorTest1()
Dim table As DataTable = Nothing ' TODO: Initialize to an appropriate value
    Dim target As dsADS.CFOApprovalDataTable = New dsADS.CFOApprovalDataTable(table)
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub

'''<summary>
'''A test for CFOApprovalDataTable Constructor
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub dsADS_CFOApprovalDataTableConstructorTest()
Dim info As SerializationInfo = Nothing ' TODO: Initialize to an appropriate value
Dim context As StreamingContext = New StreamingContext ' TODO: Initialize to an appropriate value
    Dim target As dsADS_Accessor.CFOApprovalDataTable = New dsADS_Accessor.CFOApprovalDataTable(info, context)
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub
End Class
