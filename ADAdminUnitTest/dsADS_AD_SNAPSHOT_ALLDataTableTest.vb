Imports System.Xml.Schema

Imports System

Imports System.Data

Imports System.Runtime.Serialization

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports ADAdminDotNet



'''<summary>
'''This is a test class for dsADS_AD_SNAPSHOT_ALLDataTableTest and is intended
'''to contain all dsADS_AD_SNAPSHOT_ALLDataTableTest Unit Tests
'''</summary>
<TestClass()> _
Public Class dsADS_AD_SNAPSHOT_ALLDataTableTest


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
'''A test for VoteColumn
'''</summary>
<TestMethod()>  _
Public Sub VoteColumnTest()
Dim target As dsADS.AD_SNAPSHOT_ALLDataTable = New dsADS.AD_SNAPSHOT_ALLDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.VoteColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for PhoneColumn
'''</summary>
<TestMethod()>  _
Public Sub PhoneColumnTest()
Dim target As dsADS.AD_SNAPSHOT_ALLDataTable = New dsADS.AD_SNAPSHOT_ALLDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.PhoneColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for NatProvColumn
'''</summary>
<TestMethod()>  _
Public Sub NatProvColumnTest()
Dim target As dsADS.AD_SNAPSHOT_ALLDataTable = New dsADS.AD_SNAPSHOT_ALLDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.NatProvColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for LOGISColumn
'''</summary>
<TestMethod()>  _
Public Sub LOGISColumnTest()
Dim target As dsADS.AD_SNAPSHOT_ALLDataTable = New dsADS.AD_SNAPSHOT_ALLDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.LOGISColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for LastnameColumn
'''</summary>
<TestMethod()>  _
Public Sub LastnameColumnTest()
Dim target As dsADS.AD_SNAPSHOT_ALLDataTable = New dsADS.AD_SNAPSHOT_ALLDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.LastnameColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Item
'''</summary>
<TestMethod()>  _
Public Sub ItemTest()
Dim target As dsADS.AD_SNAPSHOT_ALLDataTable = New dsADS.AD_SNAPSHOT_ALLDataTable ' TODO: Initialize to an appropriate value
Dim index As Integer = 0 ' TODO: Initialize to an appropriate value
    Dim actual As dsADS.AD_SNAPSHOT_ALLRow
    actual = target(index)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IDColumn
'''</summary>
<TestMethod()>  _
Public Sub IDColumnTest()
Dim target As dsADS.AD_SNAPSHOT_ALLDataTable = New dsADS.AD_SNAPSHOT_ALLDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.IDColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for HRColumn
'''</summary>
<TestMethod()>  _
Public Sub HRColumnTest()
Dim target As dsADS.AD_SNAPSHOT_ALLDataTable = New dsADS.AD_SNAPSHOT_ALLDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.HRColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for GFSColumn
'''</summary>
<TestMethod()>  _
Public Sub GFSColumnTest()
Dim target As dsADS.AD_SNAPSHOT_ALLDataTable = New dsADS.AD_SNAPSHOT_ALLDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.GFSColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for FirstNameColumn
'''</summary>
<TestMethod()>  _
Public Sub FirstNameColumnTest()
Dim target As dsADS.AD_SNAPSHOT_ALLDataTable = New dsADS.AD_SNAPSHOT_ALLDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.FirstNameColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for FINANCIALSColumn
'''</summary>
<TestMethod()>  _
Public Sub FINANCIALSColumnTest()
Dim target As dsADS.AD_SNAPSHOT_ALLDataTable = New dsADS.AD_SNAPSHOT_ALLDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.FINANCIALSColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for EMailColumn
'''</summary>
<TestMethod()>  _
Public Sub EMailColumnTest()
Dim target As dsADS.AD_SNAPSHOT_ALLDataTable = New dsADS.AD_SNAPSHOT_ALLDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.EMailColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DPSAColumn
'''</summary>
<TestMethod()>  _
Public Sub DPSAColumnTest()
Dim target As dsADS.AD_SNAPSHOT_ALLDataTable = New dsADS.AD_SNAPSHOT_ALLDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.DPSAColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DeptMemberColumn
'''</summary>
<TestMethod()>  _
Public Sub DeptMemberColumnTest()
Dim target As dsADS.AD_SNAPSHOT_ALLDataTable = New dsADS.AD_SNAPSHOT_ALLDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.DeptMemberColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DeptCodeColumn
'''</summary>
<TestMethod()>  _
Public Sub DeptCodeColumnTest()
Dim target As dsADS.AD_SNAPSHOT_ALLDataTable = New dsADS.AD_SNAPSHOT_ALLDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.DeptCodeColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DepartmentColumn
'''</summary>
<TestMethod()>  _
Public Sub DepartmentColumnTest()
Dim target As dsADS.AD_SNAPSHOT_ALLDataTable = New dsADS.AD_SNAPSHOT_ALLDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.DepartmentColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Count
'''</summary>
<TestMethod()>  _
Public Sub CountTest()
Dim target As dsADS.AD_SNAPSHOT_ALLDataTable = New dsADS.AD_SNAPSHOT_ALLDataTable ' TODO: Initialize to an appropriate value
    Dim actual As Integer
    actual = target.Count
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for CellColumn
'''</summary>
<TestMethod()>  _
Public Sub CellColumnTest()
Dim target As dsADS.AD_SNAPSHOT_ALLDataTable = New dsADS.AD_SNAPSHOT_ALLDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.CellColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ApplMemberColumn
'''</summary>
<TestMethod()>  _
Public Sub ApplMemberColumnTest()
Dim target As dsADS.AD_SNAPSHOT_ALLDataTable = New dsADS.AD_SNAPSHOT_ALLDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.ApplMemberColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for AccountNrColumn
'''</summary>
<TestMethod()>  _
Public Sub AccountNrColumnTest()
Dim target As dsADS.AD_SNAPSHOT_ALLDataTable = New dsADS.AD_SNAPSHOT_ALLDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.AccountNrColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for AccountDisabledColumn
'''</summary>
<TestMethod()>  _
Public Sub AccountDisabledColumnTest()
Dim target As dsADS.AD_SNAPSHOT_ALLDataTable = New dsADS.AD_SNAPSHOT_ALLDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.AccountDisabledColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for RemoveAD_SNAPSHOT_ALLRow
'''</summary>
<TestMethod()>  _
Public Sub RemoveAD_SNAPSHOT_ALLRowTest()
Dim target As dsADS.AD_SNAPSHOT_ALLDataTable = New dsADS.AD_SNAPSHOT_ALLDataTable ' TODO: Initialize to an appropriate value
Dim row As dsADS.AD_SNAPSHOT_ALLRow = Nothing ' TODO: Initialize to an appropriate value
    target.RemoveAD_SNAPSHOT_ALLRow(row)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for OnRowDeleting
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub OnRowDeletingTest()
Dim target As dsADS_Accessor.AD_SNAPSHOT_ALLDataTable = New dsADS_Accessor.AD_SNAPSHOT_ALLDataTable ' TODO: Initialize to an appropriate value
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
Dim target As dsADS_Accessor.AD_SNAPSHOT_ALLDataTable = New dsADS_Accessor.AD_SNAPSHOT_ALLDataTable ' TODO: Initialize to an appropriate value
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
Dim target As dsADS_Accessor.AD_SNAPSHOT_ALLDataTable = New dsADS_Accessor.AD_SNAPSHOT_ALLDataTable ' TODO: Initialize to an appropriate value
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
Dim target As dsADS_Accessor.AD_SNAPSHOT_ALLDataTable = New dsADS_Accessor.AD_SNAPSHOT_ALLDataTable ' TODO: Initialize to an appropriate value
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
Dim target As dsADS_Accessor.AD_SNAPSHOT_ALLDataTable = New dsADS_Accessor.AD_SNAPSHOT_ALLDataTable ' TODO: Initialize to an appropriate value
Dim builder As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim expected As DataRow = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataRow
    actual = target.NewRowFromBuilder(builder)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for NewAD_SNAPSHOT_ALLRow
'''</summary>
<TestMethod()>  _
Public Sub NewAD_SNAPSHOT_ALLRowTest()
Dim target As dsADS.AD_SNAPSHOT_ALLDataTable = New dsADS.AD_SNAPSHOT_ALLDataTable ' TODO: Initialize to an appropriate value
Dim expected As dsADS.AD_SNAPSHOT_ALLRow = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As dsADS.AD_SNAPSHOT_ALLRow
    actual = target.NewAD_SNAPSHOT_ALLRow
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for InitVars
'''</summary>
<TestMethod()>  _
Public Sub InitVarsTest()
Dim target As dsADS.AD_SNAPSHOT_ALLDataTable = New dsADS.AD_SNAPSHOT_ALLDataTable ' TODO: Initialize to an appropriate value
    target.InitVars
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for InitClass
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub InitClassTest()
Dim target As dsADS_Accessor.AD_SNAPSHOT_ALLDataTable = New dsADS_Accessor.AD_SNAPSHOT_ALLDataTable ' TODO: Initialize to an appropriate value
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
    actual = dsADS.AD_SNAPSHOT_ALLDataTable.GetTypedTableSchema(xs)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for GetRowType
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub GetRowTypeTest()
Dim target As dsADS_Accessor.AD_SNAPSHOT_ALLDataTable = New dsADS_Accessor.AD_SNAPSHOT_ALLDataTable ' TODO: Initialize to an appropriate value
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
Dim target As dsADS.AD_SNAPSHOT_ALLDataTable = New dsADS.AD_SNAPSHOT_ALLDataTable ' TODO: Initialize to an appropriate value
Dim ID As Long = 0 ' TODO: Initialize to an appropriate value
Dim expected As dsADS.AD_SNAPSHOT_ALLRow = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As dsADS.AD_SNAPSHOT_ALLRow
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
Dim target As dsADS_Accessor.AD_SNAPSHOT_ALLDataTable = New dsADS_Accessor.AD_SNAPSHOT_ALLDataTable ' TODO: Initialize to an appropriate value
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
Dim target As dsADS.AD_SNAPSHOT_ALLDataTable = New dsADS.AD_SNAPSHOT_ALLDataTable ' TODO: Initialize to an appropriate value
Dim expected As DataTable = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataTable
    actual = target.Clone
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for AddAD_SNAPSHOT_ALLRow
'''</summary>
<TestMethod()>  _
Public Sub AddAD_SNAPSHOT_ALLRowTest1()
Dim target As dsADS.AD_SNAPSHOT_ALLDataTable = New dsADS.AD_SNAPSHOT_ALLDataTable ' TODO: Initialize to an appropriate value
Dim row As dsADS.AD_SNAPSHOT_ALLRow = Nothing ' TODO: Initialize to an appropriate value
    target.AddAD_SNAPSHOT_ALLRow(row)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for AddAD_SNAPSHOT_ALLRow
'''</summary>
<TestMethod()>  _
Public Sub AddAD_SNAPSHOT_ALLRowTest()
Dim target As dsADS.AD_SNAPSHOT_ALLDataTable = New dsADS.AD_SNAPSHOT_ALLDataTable ' TODO: Initialize to an appropriate value
Dim ID As Long = 0 ' TODO: Initialize to an appropriate value
Dim AccountNr As String = String.Empty ' TODO: Initialize to an appropriate value
Dim NatProv As String = String.Empty ' TODO: Initialize to an appropriate value
Dim Vote As String = String.Empty ' TODO: Initialize to an appropriate value
Dim DeptCode As String = String.Empty ' TODO: Initialize to an appropriate value
Dim EMail As String = String.Empty ' TODO: Initialize to an appropriate value
Dim Cell As String = String.Empty ' TODO: Initialize to an appropriate value
Dim Phone As String = String.Empty ' TODO: Initialize to an appropriate value
Dim FirstName As String = String.Empty ' TODO: Initialize to an appropriate value
Dim Lastname As String = String.Empty ' TODO: Initialize to an appropriate value
Dim ApplMember As String = String.Empty ' TODO: Initialize to an appropriate value
Dim DeptMember As String = String.Empty ' TODO: Initialize to an appropriate value
Dim Department As String = String.Empty ' TODO: Initialize to an appropriate value
Dim AccountDisabled As Short = 0 ' TODO: Initialize to an appropriate value
Dim LOGIS As Short = 0 ' TODO: Initialize to an appropriate value
Dim HR As Short = 0 ' TODO: Initialize to an appropriate value
Dim FINANCIALS As Short = 0 ' TODO: Initialize to an appropriate value
Dim GFS As Short = 0 ' TODO: Initialize to an appropriate value
Dim DPSA As Short = 0 ' TODO: Initialize to an appropriate value
Dim expected As dsADS.AD_SNAPSHOT_ALLRow = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As dsADS.AD_SNAPSHOT_ALLRow
    actual = target.AddAD_SNAPSHOT_ALLRow(ID, AccountNr, NatProv, Vote, DeptCode, EMail, Cell, Phone, FirstName, Lastname, ApplMember, DeptMember, Department, AccountDisabled, LOGIS, HR, FINANCIALS, GFS, DPSA)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for AD_SNAPSHOT_ALLDataTable Constructor
'''</summary>
<TestMethod()>  _
Public Sub dsADS_AD_SNAPSHOT_ALLDataTableConstructorTest2()
    Dim target As dsADS.AD_SNAPSHOT_ALLDataTable = New dsADS.AD_SNAPSHOT_ALLDataTable
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub

'''<summary>
'''A test for AD_SNAPSHOT_ALLDataTable Constructor
'''</summary>
<TestMethod()>  _
Public Sub dsADS_AD_SNAPSHOT_ALLDataTableConstructorTest1()
Dim table As DataTable = Nothing ' TODO: Initialize to an appropriate value
    Dim target As dsADS.AD_SNAPSHOT_ALLDataTable = New dsADS.AD_SNAPSHOT_ALLDataTable(table)
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub

'''<summary>
'''A test for AD_SNAPSHOT_ALLDataTable Constructor
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub dsADS_AD_SNAPSHOT_ALLDataTableConstructorTest()
Dim info As SerializationInfo = Nothing ' TODO: Initialize to an appropriate value
Dim context As StreamingContext = New StreamingContext ' TODO: Initialize to an appropriate value
    Dim target As dsADS_Accessor.AD_SNAPSHOT_ALLDataTable = New dsADS_Accessor.AD_SNAPSHOT_ALLDataTable(info, context)
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub
End Class
