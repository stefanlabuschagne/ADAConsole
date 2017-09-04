Imports System.Xml.Schema

Imports System

Imports System.Data

Imports System.Runtime.Serialization

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports ADAdminDotNet



'''<summary>
'''This is a test class for dsADS_CFODataTableTest and is intended
'''to contain all dsADS_CFODataTableTest Unit Tests
'''</summary>
<TestClass()> _
Public Class dsADS_CFODataTableTest


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
'''A test for VoteIDColumn
'''</summary>
<TestMethod()>  _
Public Sub VoteIDColumnTest()
Dim target As dsADS.CFODataTable = New dsADS.CFODataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.VoteIDColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for NAT_PROV_IDColumn
'''</summary>
<TestMethod()>  _
Public Sub NAT_PROV_IDColumnTest()
Dim target As dsADS.CFODataTable = New dsADS.CFODataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.NAT_PROV_IDColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for LastNameColumn
'''</summary>
<TestMethod()>  _
Public Sub LastNameColumnTest()
Dim target As dsADS.CFODataTable = New dsADS.CFODataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.LastNameColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for JobTitleColumn
'''</summary>
<TestMethod()>  _
Public Sub JobTitleColumnTest()
Dim target As dsADS.CFODataTable = New dsADS.CFODataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.JobTitleColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Item
'''</summary>
<TestMethod()>  _
Public Sub ItemTest()
Dim target As dsADS.CFODataTable = New dsADS.CFODataTable ' TODO: Initialize to an appropriate value
Dim index As Integer = 0 ' TODO: Initialize to an appropriate value
    Dim actual As dsADS.CFORow
    actual = target(index)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for InitialsColumn
'''</summary>
<TestMethod()>  _
Public Sub InitialsColumnTest()
Dim target As dsADS.CFODataTable = New dsADS.CFODataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.InitialsColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IDColumn
'''</summary>
<TestMethod()>  _
Public Sub IDColumnTest()
Dim target As dsADS.CFODataTable = New dsADS.CFODataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.IDColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for GenderColumn
'''</summary>
<TestMethod()>  _
Public Sub GenderColumnTest()
Dim target As dsADS.CFODataTable = New dsADS.CFODataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.GenderColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for FullnameColumn
'''</summary>
<TestMethod()>  _
Public Sub FullnameColumnTest()
Dim target As dsADS.CFODataTable = New dsADS.CFODataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.FullnameColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for FirstNameColumn
'''</summary>
<TestMethod()>  _
Public Sub FirstNameColumnTest()
Dim target As dsADS.CFODataTable = New dsADS.CFODataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.FirstNameColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Email1AddressColumn
'''</summary>
<TestMethod()>  _
Public Sub Email1AddressColumnTest()
Dim target As dsADS.CFODataTable = New dsADS.CFODataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.Email1AddressColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Dept_CodeColumn
'''</summary>
<TestMethod()>  _
Public Sub Dept_CodeColumnTest()
Dim target As dsADS.CFODataTable = New dsADS.CFODataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.Dept_CodeColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Count
'''</summary>
<TestMethod()>  _
Public Sub CountTest()
Dim target As dsADS.CFODataTable = New dsADS.CFODataTable ' TODO: Initialize to an appropriate value
    Dim actual As Integer
    actual = target.Count
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for CompanyNameColumn
'''</summary>
<TestMethod()>  _
Public Sub CompanyNameColumnTest()
Dim target As dsADS.CFODataTable = New dsADS.CFODataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.CompanyNameColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for BusinessTelephoneNumberColumn
'''</summary>
<TestMethod()>  _
Public Sub BusinessTelephoneNumberColumnTest()
Dim target As dsADS.CFODataTable = New dsADS.CFODataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.BusinessTelephoneNumberColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for BusinessFaxNumberColumn
'''</summary>
<TestMethod()>  _
Public Sub BusinessFaxNumberColumnTest()
Dim target As dsADS.CFODataTable = New dsADS.CFODataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.BusinessFaxNumberColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for BusinessAddressColumn
'''</summary>
<TestMethod()>  _
Public Sub BusinessAddressColumnTest()
Dim target As dsADS.CFODataTable = New dsADS.CFODataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.BusinessAddressColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for RemoveCFORow
'''</summary>
<TestMethod()>  _
Public Sub RemoveCFORowTest()
Dim target As dsADS.CFODataTable = New dsADS.CFODataTable ' TODO: Initialize to an appropriate value
Dim row As dsADS.CFORow = Nothing ' TODO: Initialize to an appropriate value
    target.RemoveCFORow(row)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for OnRowDeleting
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub OnRowDeletingTest()
Dim target As dsADS_Accessor.CFODataTable = New dsADS_Accessor.CFODataTable ' TODO: Initialize to an appropriate value
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
Dim target As dsADS_Accessor.CFODataTable = New dsADS_Accessor.CFODataTable ' TODO: Initialize to an appropriate value
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
Dim target As dsADS_Accessor.CFODataTable = New dsADS_Accessor.CFODataTable ' TODO: Initialize to an appropriate value
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
Dim target As dsADS_Accessor.CFODataTable = New dsADS_Accessor.CFODataTable ' TODO: Initialize to an appropriate value
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
Dim target As dsADS_Accessor.CFODataTable = New dsADS_Accessor.CFODataTable ' TODO: Initialize to an appropriate value
Dim builder As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim expected As DataRow = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataRow
    actual = target.NewRowFromBuilder(builder)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for NewCFORow
'''</summary>
<TestMethod()>  _
Public Sub NewCFORowTest()
Dim target As dsADS.CFODataTable = New dsADS.CFODataTable ' TODO: Initialize to an appropriate value
Dim expected As dsADS.CFORow = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As dsADS.CFORow
    actual = target.NewCFORow
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for InitVars
'''</summary>
<TestMethod()>  _
Public Sub InitVarsTest()
Dim target As dsADS.CFODataTable = New dsADS.CFODataTable ' TODO: Initialize to an appropriate value
    target.InitVars
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for InitClass
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub InitClassTest()
Dim target As dsADS_Accessor.CFODataTable = New dsADS_Accessor.CFODataTable ' TODO: Initialize to an appropriate value
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
    actual = dsADS.CFODataTable.GetTypedTableSchema(xs)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for GetRowType
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub GetRowTypeTest()
Dim target As dsADS_Accessor.CFODataTable = New dsADS_Accessor.CFODataTable ' TODO: Initialize to an appropriate value
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
Dim target As dsADS.CFODataTable = New dsADS.CFODataTable ' TODO: Initialize to an appropriate value
Dim ID As Long = 0 ' TODO: Initialize to an appropriate value
Dim expected As dsADS.CFORow = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As dsADS.CFORow
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
Dim target As dsADS_Accessor.CFODataTable = New dsADS_Accessor.CFODataTable ' TODO: Initialize to an appropriate value
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
Dim target As dsADS.CFODataTable = New dsADS.CFODataTable ' TODO: Initialize to an appropriate value
Dim expected As DataTable = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataTable
    actual = target.Clone
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for AddCFORow
'''</summary>
<TestMethod()>  _
Public Sub AddCFORowTest1()
Dim target As dsADS.CFODataTable = New dsADS.CFODataTable ' TODO: Initialize to an appropriate value
Dim row As dsADS.CFORow = Nothing ' TODO: Initialize to an appropriate value
    target.AddCFORow(row)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for AddCFORow
'''</summary>
<TestMethod()>  _
Public Sub AddCFORowTest()
Dim target As dsADS.CFODataTable = New dsADS.CFODataTable ' TODO: Initialize to an appropriate value
Dim Dept_Code As String = String.Empty ' TODO: Initialize to an appropriate value
Dim Fullname As String = String.Empty ' TODO: Initialize to an appropriate value
Dim CompanyName As String = String.Empty ' TODO: Initialize to an appropriate value
Dim Email1Address As String = String.Empty ' TODO: Initialize to an appropriate value
Dim NAT_PROV_ID As Long = 0 ' TODO: Initialize to an appropriate value
Dim VoteID As Long = 0 ' TODO: Initialize to an appropriate value
Dim FirstName As String = String.Empty ' TODO: Initialize to an appropriate value
Dim BusinessTelephoneNumber As String = String.Empty ' TODO: Initialize to an appropriate value
Dim Gender As String = String.Empty ' TODO: Initialize to an appropriate value
Dim Initials As String = String.Empty ' TODO: Initialize to an appropriate value
Dim BusinessAddress As String = String.Empty ' TODO: Initialize to an appropriate value
Dim BusinessFaxNumber As String = String.Empty ' TODO: Initialize to an appropriate value
Dim JobTitle As String = String.Empty ' TODO: Initialize to an appropriate value
Dim LastName As String = String.Empty ' TODO: Initialize to an appropriate value
Dim expected As dsADS.CFORow = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As dsADS.CFORow
    actual = target.AddCFORow(Dept_Code, Fullname, CompanyName, Email1Address, NAT_PROV_ID, VoteID, FirstName, BusinessTelephoneNumber, Gender, Initials, BusinessAddress, BusinessFaxNumber, JobTitle, LastName)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for CFODataTable Constructor
'''</summary>
<TestMethod()>  _
Public Sub dsADS_CFODataTableConstructorTest2()
    Dim target As dsADS.CFODataTable = New dsADS.CFODataTable
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub

'''<summary>
'''A test for CFODataTable Constructor
'''</summary>
<TestMethod()>  _
Public Sub dsADS_CFODataTableConstructorTest1()
Dim table As DataTable = Nothing ' TODO: Initialize to an appropriate value
    Dim target As dsADS.CFODataTable = New dsADS.CFODataTable(table)
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub

'''<summary>
'''A test for CFODataTable Constructor
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub dsADS_CFODataTableConstructorTest()
Dim info As SerializationInfo = Nothing ' TODO: Initialize to an appropriate value
Dim context As StreamingContext = New StreamingContext ' TODO: Initialize to an appropriate value
    Dim target As dsADS_Accessor.CFODataTable = New dsADS_Accessor.CFODataTable(info, context)
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub
End Class
