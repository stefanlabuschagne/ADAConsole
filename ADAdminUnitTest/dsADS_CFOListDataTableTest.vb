Imports System.Xml.Schema

Imports System

Imports System.Data

Imports System.Runtime.Serialization

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports ADAdminDotNet



'''<summary>
'''This is a test class for dsADS_CFOListDataTableTest and is intended
'''to contain all dsADS_CFOListDataTableTest Unit Tests
'''</summary>
<TestClass()> _
Public Class dsADS_CFOListDataTableTest


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
'''A test for TelColumn
'''</summary>
<TestMethod()>  _
Public Sub TelColumnTest()
Dim target As dsADS.CFOListDataTable = New dsADS.CFOListDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.TelColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for SurnameColumn
'''</summary>
<TestMethod()>  _
Public Sub SurnameColumnTest()
Dim target As dsADS.CFOListDataTable = New dsADS.CFOListDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.SurnameColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ProvinceColumn
'''</summary>
<TestMethod()>  _
Public Sub ProvinceColumnTest()
Dim target As dsADS.CFOListDataTable = New dsADS.CFOListDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.ProvinceColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for PersalNoColumn
'''</summary>
<TestMethod()>  _
Public Sub PersalNoColumnTest()
Dim target As dsADS.CFOListDataTable = New dsADS.CFOListDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.PersalNoColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Item
'''</summary>
<TestMethod()>  _
Public Sub ItemTest()
Dim target As dsADS.CFOListDataTable = New dsADS.CFOListDataTable ' TODO: Initialize to an appropriate value
Dim index As Integer = 0 ' TODO: Initialize to an appropriate value
    Dim actual As dsADS.CFOListRow
    actual = target(index)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IDColumn
'''</summary>
<TestMethod()>  _
Public Sub IDColumnTest()
Dim target As dsADS.CFOListDataTable = New dsADS.CFOListDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.IDColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for GenderColumn
'''</summary>
<TestMethod()>  _
Public Sub GenderColumnTest()
Dim target As dsADS.CFOListDataTable = New dsADS.CFOListDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.GenderColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for FullNamesColumn
'''</summary>
<TestMethod()>  _
Public Sub FullNamesColumnTest()
Dim target As dsADS.CFOListDataTable = New dsADS.CFOListDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.FullNamesColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for FaxColumn
'''</summary>
<TestMethod()>  _
Public Sub FaxColumnTest()
Dim target As dsADS.CFOListDataTable = New dsADS.CFOListDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.FaxColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for EmailColumn
'''</summary>
<TestMethod()>  _
Public Sub EmailColumnTest()
Dim target As dsADS.CFOListDataTable = New dsADS.CFOListDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.EmailColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DesignationColumn
'''</summary>
<TestMethod()>  _
Public Sub DesignationColumnTest()
Dim target As dsADS.CFOListDataTable = New dsADS.CFOListDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.DesignationColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DeptCodeColumn
'''</summary>
<TestMethod()>  _
Public Sub DeptCodeColumnTest()
Dim target As dsADS.CFOListDataTable = New dsADS.CFOListDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.DeptCodeColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DepartmentColumn
'''</summary>
<TestMethod()>  _
Public Sub DepartmentColumnTest()
Dim target As dsADS.CFOListDataTable = New dsADS.CFOListDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.DepartmentColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Count
'''</summary>
<TestMethod()>  _
Public Sub CountTest()
Dim target As dsADS.CFOListDataTable = New dsADS.CFOListDataTable ' TODO: Initialize to an appropriate value
    Dim actual As Integer
    actual = target.Count
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for CellColumn
'''</summary>
<TestMethod()>  _
Public Sub CellColumnTest()
Dim target As dsADS.CFOListDataTable = New dsADS.CFOListDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.CellColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for RemoveCFOListRow
'''</summary>
<TestMethod()>  _
Public Sub RemoveCFOListRowTest()
Dim target As dsADS.CFOListDataTable = New dsADS.CFOListDataTable ' TODO: Initialize to an appropriate value
Dim row As dsADS.CFOListRow = Nothing ' TODO: Initialize to an appropriate value
    target.RemoveCFOListRow(row)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for OnRowDeleting
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub OnRowDeletingTest()
Dim target As dsADS_Accessor.CFOListDataTable = New dsADS_Accessor.CFOListDataTable ' TODO: Initialize to an appropriate value
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
Dim target As dsADS_Accessor.CFOListDataTable = New dsADS_Accessor.CFOListDataTable ' TODO: Initialize to an appropriate value
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
Dim target As dsADS_Accessor.CFOListDataTable = New dsADS_Accessor.CFOListDataTable ' TODO: Initialize to an appropriate value
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
Dim target As dsADS_Accessor.CFOListDataTable = New dsADS_Accessor.CFOListDataTable ' TODO: Initialize to an appropriate value
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
Dim target As dsADS_Accessor.CFOListDataTable = New dsADS_Accessor.CFOListDataTable ' TODO: Initialize to an appropriate value
Dim builder As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim expected As DataRow = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataRow
    actual = target.NewRowFromBuilder(builder)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for NewCFOListRow
'''</summary>
<TestMethod()>  _
Public Sub NewCFOListRowTest()
Dim target As dsADS.CFOListDataTable = New dsADS.CFOListDataTable ' TODO: Initialize to an appropriate value
Dim expected As dsADS.CFOListRow = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As dsADS.CFOListRow
    actual = target.NewCFOListRow
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for InitVars
'''</summary>
<TestMethod()>  _
Public Sub InitVarsTest()
Dim target As dsADS.CFOListDataTable = New dsADS.CFOListDataTable ' TODO: Initialize to an appropriate value
    target.InitVars
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for InitClass
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub InitClassTest()
Dim target As dsADS_Accessor.CFOListDataTable = New dsADS_Accessor.CFOListDataTable ' TODO: Initialize to an appropriate value
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
    actual = dsADS.CFOListDataTable.GetTypedTableSchema(xs)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for GetRowType
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub GetRowTypeTest()
Dim target As dsADS_Accessor.CFOListDataTable = New dsADS_Accessor.CFOListDataTable ' TODO: Initialize to an appropriate value
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
Dim target As dsADS.CFOListDataTable = New dsADS.CFOListDataTable ' TODO: Initialize to an appropriate value
Dim ID As Long = 0 ' TODO: Initialize to an appropriate value
Dim expected As dsADS.CFOListRow = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As dsADS.CFOListRow
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
Dim target As dsADS_Accessor.CFOListDataTable = New dsADS_Accessor.CFOListDataTable ' TODO: Initialize to an appropriate value
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
Dim target As dsADS.CFOListDataTable = New dsADS.CFOListDataTable ' TODO: Initialize to an appropriate value
Dim expected As DataTable = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataTable
    actual = target.Clone
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for AddCFOListRow
'''</summary>
<TestMethod()>  _
Public Sub AddCFOListRowTest1()
Dim target As dsADS.CFOListDataTable = New dsADS.CFOListDataTable ' TODO: Initialize to an appropriate value
Dim row As dsADS.CFOListRow = Nothing ' TODO: Initialize to an appropriate value
    target.AddCFOListRow(row)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for AddCFOListRow
'''</summary>
<TestMethod()>  _
Public Sub AddCFOListRowTest()
Dim target As dsADS.CFOListDataTable = New dsADS.CFOListDataTable ' TODO: Initialize to an appropriate value
Dim DeptCode As String = String.Empty ' TODO: Initialize to an appropriate value
Dim PersalNo As String = String.Empty ' TODO: Initialize to an appropriate value
Dim Surname As String = String.Empty ' TODO: Initialize to an appropriate value
Dim FullNames As String = String.Empty ' TODO: Initialize to an appropriate value
Dim Fax As String = String.Empty ' TODO: Initialize to an appropriate value
Dim Tel As String = String.Empty ' TODO: Initialize to an appropriate value
Dim Cell As String = String.Empty ' TODO: Initialize to an appropriate value
Dim Email As String = String.Empty ' TODO: Initialize to an appropriate value
Dim Designation As String = String.Empty ' TODO: Initialize to an appropriate value
Dim Department As String = String.Empty ' TODO: Initialize to an appropriate value
Dim Province As String = String.Empty ' TODO: Initialize to an appropriate value
Dim Gender As String = String.Empty ' TODO: Initialize to an appropriate value
Dim expected As dsADS.CFOListRow = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As dsADS.CFOListRow
    actual = target.AddCFOListRow(DeptCode, PersalNo, Surname, FullNames, Fax, Tel, Cell, Email, Designation, Department, Province, Gender)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for CFOListDataTable Constructor
'''</summary>
<TestMethod()>  _
Public Sub dsADS_CFOListDataTableConstructorTest2()
    Dim target As dsADS.CFOListDataTable = New dsADS.CFOListDataTable
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub

'''<summary>
'''A test for CFOListDataTable Constructor
'''</summary>
<TestMethod()>  _
Public Sub dsADS_CFOListDataTableConstructorTest1()
Dim table As DataTable = Nothing ' TODO: Initialize to an appropriate value
    Dim target As dsADS.CFOListDataTable = New dsADS.CFOListDataTable(table)
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub

'''<summary>
'''A test for CFOListDataTable Constructor
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub dsADS_CFOListDataTableConstructorTest()
Dim info As SerializationInfo = Nothing ' TODO: Initialize to an appropriate value
Dim context As StreamingContext = New StreamingContext ' TODO: Initialize to an appropriate value
    Dim target As dsADS_Accessor.CFOListDataTable = New dsADS_Accessor.CFOListDataTable(info, context)
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub
End Class
