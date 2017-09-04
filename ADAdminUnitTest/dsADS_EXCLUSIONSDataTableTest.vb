Imports System.Xml.Schema

Imports System

Imports System.Data

Imports System.Runtime.Serialization

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports ADAdminDotNet



'''<summary>
'''This is a test class for dsADS_EXCLUSIONSDataTableTest and is intended
'''to contain all dsADS_EXCLUSIONSDataTableTest Unit Tests
'''</summary>
<TestClass()> _
Public Class dsADS_EXCLUSIONSDataTableTest


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
'''A test for SURNAMEColumn
'''</summary>
<TestMethod()>  _
Public Sub SURNAMEColumnTest()
Dim target As dsADS.EXCLUSIONSDataTable = New dsADS.EXCLUSIONSDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.SURNAMEColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for PHONEColumn
'''</summary>
<TestMethod()>  _
Public Sub PHONEColumnTest()
Dim target As dsADS.EXCLUSIONSDataTable = New dsADS.EXCLUSIONSDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.PHONEColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for NAMEColumn
'''</summary>
<TestMethod()>  _
Public Sub NAMEColumnTest()
Dim target As dsADS.EXCLUSIONSDataTable = New dsADS.EXCLUSIONSDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.NAMEColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Item
'''</summary>
<TestMethod()>  _
Public Sub ItemTest()
Dim target As dsADS.EXCLUSIONSDataTable = New dsADS.EXCLUSIONSDataTable ' TODO: Initialize to an appropriate value
Dim index As Integer = 0 ' TODO: Initialize to an appropriate value
    Dim actual As dsADS.EXCLUSIONSRow
    actual = target(index)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IDColumn
'''</summary>
<TestMethod()>  _
Public Sub IDColumnTest()
Dim target As dsADS.EXCLUSIONSDataTable = New dsADS.EXCLUSIONSDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.IDColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for EMAILColumn
'''</summary>
<TestMethod()>  _
Public Sub EMAILColumnTest()
Dim target As dsADS.EXCLUSIONSDataTable = New dsADS.EXCLUSIONSDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.EMAILColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Count
'''</summary>
<TestMethod()>  _
Public Sub CountTest()
Dim target As dsADS.EXCLUSIONSDataTable = New dsADS.EXCLUSIONSDataTable ' TODO: Initialize to an appropriate value
    Dim actual As Integer
    actual = target.Count
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for CONSULTANTColumn
'''</summary>
<TestMethod()>  _
Public Sub CONSULTANTColumnTest()
Dim target As dsADS.EXCLUSIONSDataTable = New dsADS.EXCLUSIONSDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.CONSULTANTColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for RemoveEXCLUSIONSRow
'''</summary>
<TestMethod()>  _
Public Sub RemoveEXCLUSIONSRowTest()
Dim target As dsADS.EXCLUSIONSDataTable = New dsADS.EXCLUSIONSDataTable ' TODO: Initialize to an appropriate value
Dim row As dsADS.EXCLUSIONSRow = Nothing ' TODO: Initialize to an appropriate value
    target.RemoveEXCLUSIONSRow(row)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for OnRowDeleting
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub OnRowDeletingTest()
Dim target As dsADS_Accessor.EXCLUSIONSDataTable = New dsADS_Accessor.EXCLUSIONSDataTable ' TODO: Initialize to an appropriate value
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
Dim target As dsADS_Accessor.EXCLUSIONSDataTable = New dsADS_Accessor.EXCLUSIONSDataTable ' TODO: Initialize to an appropriate value
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
Dim target As dsADS_Accessor.EXCLUSIONSDataTable = New dsADS_Accessor.EXCLUSIONSDataTable ' TODO: Initialize to an appropriate value
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
Dim target As dsADS_Accessor.EXCLUSIONSDataTable = New dsADS_Accessor.EXCLUSIONSDataTable ' TODO: Initialize to an appropriate value
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
Dim target As dsADS_Accessor.EXCLUSIONSDataTable = New dsADS_Accessor.EXCLUSIONSDataTable ' TODO: Initialize to an appropriate value
Dim builder As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim expected As DataRow = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataRow
    actual = target.NewRowFromBuilder(builder)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for NewEXCLUSIONSRow
'''</summary>
<TestMethod()>  _
Public Sub NewEXCLUSIONSRowTest()
Dim target As dsADS.EXCLUSIONSDataTable = New dsADS.EXCLUSIONSDataTable ' TODO: Initialize to an appropriate value
Dim expected As dsADS.EXCLUSIONSRow = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As dsADS.EXCLUSIONSRow
    actual = target.NewEXCLUSIONSRow
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for InitVars
'''</summary>
<TestMethod()>  _
Public Sub InitVarsTest()
Dim target As dsADS.EXCLUSIONSDataTable = New dsADS.EXCLUSIONSDataTable ' TODO: Initialize to an appropriate value
    target.InitVars
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for InitClass
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub InitClassTest()
Dim target As dsADS_Accessor.EXCLUSIONSDataTable = New dsADS_Accessor.EXCLUSIONSDataTable ' TODO: Initialize to an appropriate value
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
    actual = dsADS.EXCLUSIONSDataTable.GetTypedTableSchema(xs)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for GetRowType
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub GetRowTypeTest()
Dim target As dsADS_Accessor.EXCLUSIONSDataTable = New dsADS_Accessor.EXCLUSIONSDataTable ' TODO: Initialize to an appropriate value
Dim expected As Type = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Type
    actual = target.GetRowType
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for FindByID
'''</summary>
<TestMethod()>  _
Public Sub FindByIDTest()
Dim target As dsADS.EXCLUSIONSDataTable = New dsADS.EXCLUSIONSDataTable ' TODO: Initialize to an appropriate value
Dim ID As Long = 0 ' TODO: Initialize to an appropriate value
Dim expected As dsADS.EXCLUSIONSRow = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As dsADS.EXCLUSIONSRow
    actual = target.FindByID(ID)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for CreateInstance
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub CreateInstanceTest()
Dim target As dsADS_Accessor.EXCLUSIONSDataTable = New dsADS_Accessor.EXCLUSIONSDataTable ' TODO: Initialize to an appropriate value
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
Dim target As dsADS.EXCLUSIONSDataTable = New dsADS.EXCLUSIONSDataTable ' TODO: Initialize to an appropriate value
Dim expected As DataTable = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataTable
    actual = target.Clone
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for AddEXCLUSIONSRow
'''</summary>
<TestMethod()>  _
Public Sub AddEXCLUSIONSRowTest1()
Dim target As dsADS.EXCLUSIONSDataTable = New dsADS.EXCLUSIONSDataTable ' TODO: Initialize to an appropriate value
Dim row As dsADS.EXCLUSIONSRow = Nothing ' TODO: Initialize to an appropriate value
    target.AddEXCLUSIONSRow(row)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for AddEXCLUSIONSRow
'''</summary>
<TestMethod()>  _
Public Sub AddEXCLUSIONSRowTest()
Dim target As dsADS.EXCLUSIONSDataTable = New dsADS.EXCLUSIONSDataTable ' TODO: Initialize to an appropriate value
Dim CONSULTANT As String = String.Empty ' TODO: Initialize to an appropriate value
Dim NAME As String = String.Empty ' TODO: Initialize to an appropriate value
Dim SURNAME As String = String.Empty ' TODO: Initialize to an appropriate value
Dim EMAIL As String = String.Empty ' TODO: Initialize to an appropriate value
Dim PHONE As String = String.Empty ' TODO: Initialize to an appropriate value
Dim expected As dsADS.EXCLUSIONSRow = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As dsADS.EXCLUSIONSRow
    actual = target.AddEXCLUSIONSRow(CONSULTANT, NAME, SURNAME, EMAIL, PHONE)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for EXCLUSIONSDataTable Constructor
'''</summary>
<TestMethod()>  _
Public Sub dsADS_EXCLUSIONSDataTableConstructorTest2()
    Dim target As dsADS.EXCLUSIONSDataTable = New dsADS.EXCLUSIONSDataTable
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub

'''<summary>
'''A test for EXCLUSIONSDataTable Constructor
'''</summary>
<TestMethod()>  _
Public Sub dsADS_EXCLUSIONSDataTableConstructorTest1()
Dim table As DataTable = Nothing ' TODO: Initialize to an appropriate value
    Dim target As dsADS.EXCLUSIONSDataTable = New dsADS.EXCLUSIONSDataTable(table)
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub

'''<summary>
'''A test for EXCLUSIONSDataTable Constructor
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub dsADS_EXCLUSIONSDataTableConstructorTest()
Dim info As SerializationInfo = Nothing ' TODO: Initialize to an appropriate value
Dim context As StreamingContext = New StreamingContext ' TODO: Initialize to an appropriate value
    Dim target As dsADS_Accessor.EXCLUSIONSDataTable = New dsADS_Accessor.EXCLUSIONSDataTable(info, context)
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub
End Class
