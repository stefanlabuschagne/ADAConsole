Imports System.Xml.Schema

Imports System

Imports System.Data

Imports System.Runtime.Serialization

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports ADAdminDotNet



'''<summary>
'''This is a test class for dsADS_AD_SNAPSHOT_EXCEPTIONSDataTableTest and is intended
'''to contain all dsADS_AD_SNAPSHOT_EXCEPTIONSDataTableTest Unit Tests
'''</summary>
<TestClass()> _
Public Class dsADS_AD_SNAPSHOT_EXCEPTIONSDataTableTest


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
'''A test for LastnameColumn
'''</summary>
<TestMethod()>  _
Public Sub LastnameColumnTest()
Dim target As dsADS.AD_SNAPSHOT_EXCEPTIONSDataTable = New dsADS.AD_SNAPSHOT_EXCEPTIONSDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.LastnameColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Item
'''</summary>
<TestMethod()>  _
Public Sub ItemTest()
Dim target As dsADS.AD_SNAPSHOT_EXCEPTIONSDataTable = New dsADS.AD_SNAPSHOT_EXCEPTIONSDataTable ' TODO: Initialize to an appropriate value
Dim index As Integer = 0 ' TODO: Initialize to an appropriate value
    Dim actual As dsADS.AD_SNAPSHOT_EXCEPTIONSRow
    actual = target(index)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IDColumn
'''</summary>
<TestMethod()>  _
Public Sub IDColumnTest()
Dim target As dsADS.AD_SNAPSHOT_EXCEPTIONSDataTable = New dsADS.AD_SNAPSHOT_EXCEPTIONSDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.IDColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for FirstNameColumn
'''</summary>
<TestMethod()>  _
Public Sub FirstNameColumnTest()
Dim target As dsADS.AD_SNAPSHOT_EXCEPTIONSDataTable = New dsADS.AD_SNAPSHOT_EXCEPTIONSDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.FirstNameColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ExpiryDateColumn
'''</summary>
<TestMethod()>  _
Public Sub ExpiryDateColumnTest()
Dim target As dsADS.AD_SNAPSHOT_EXCEPTIONSDataTable = New dsADS.AD_SNAPSHOT_EXCEPTIONSDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.ExpiryDateColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Count
'''</summary>
<TestMethod()>  _
Public Sub CountTest()
Dim target As dsADS.AD_SNAPSHOT_EXCEPTIONSDataTable = New dsADS.AD_SNAPSHOT_EXCEPTIONSDataTable ' TODO: Initialize to an appropriate value
    Dim actual As Integer
    actual = target.Count
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for AccountNrColumn
'''</summary>
<TestMethod()>  _
Public Sub AccountNrColumnTest()
Dim target As dsADS.AD_SNAPSHOT_EXCEPTIONSDataTable = New dsADS.AD_SNAPSHOT_EXCEPTIONSDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.AccountNrColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for RemoveAD_SNAPSHOT_EXCEPTIONSRow
'''</summary>
<TestMethod()>  _
Public Sub RemoveAD_SNAPSHOT_EXCEPTIONSRowTest()
Dim target As dsADS.AD_SNAPSHOT_EXCEPTIONSDataTable = New dsADS.AD_SNAPSHOT_EXCEPTIONSDataTable ' TODO: Initialize to an appropriate value
Dim row As dsADS.AD_SNAPSHOT_EXCEPTIONSRow = Nothing ' TODO: Initialize to an appropriate value
    target.RemoveAD_SNAPSHOT_EXCEPTIONSRow(row)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for OnRowDeleting
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub OnRowDeletingTest()
Dim target As dsADS_Accessor.AD_SNAPSHOT_EXCEPTIONSDataTable = New dsADS_Accessor.AD_SNAPSHOT_EXCEPTIONSDataTable ' TODO: Initialize to an appropriate value
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
Dim target As dsADS_Accessor.AD_SNAPSHOT_EXCEPTIONSDataTable = New dsADS_Accessor.AD_SNAPSHOT_EXCEPTIONSDataTable ' TODO: Initialize to an appropriate value
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
Dim target As dsADS_Accessor.AD_SNAPSHOT_EXCEPTIONSDataTable = New dsADS_Accessor.AD_SNAPSHOT_EXCEPTIONSDataTable ' TODO: Initialize to an appropriate value
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
Dim target As dsADS_Accessor.AD_SNAPSHOT_EXCEPTIONSDataTable = New dsADS_Accessor.AD_SNAPSHOT_EXCEPTIONSDataTable ' TODO: Initialize to an appropriate value
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
Dim target As dsADS_Accessor.AD_SNAPSHOT_EXCEPTIONSDataTable = New dsADS_Accessor.AD_SNAPSHOT_EXCEPTIONSDataTable ' TODO: Initialize to an appropriate value
Dim builder As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim expected As DataRow = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataRow
    actual = target.NewRowFromBuilder(builder)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for NewAD_SNAPSHOT_EXCEPTIONSRow
'''</summary>
<TestMethod()>  _
Public Sub NewAD_SNAPSHOT_EXCEPTIONSRowTest()
Dim target As dsADS.AD_SNAPSHOT_EXCEPTIONSDataTable = New dsADS.AD_SNAPSHOT_EXCEPTIONSDataTable ' TODO: Initialize to an appropriate value
Dim expected As dsADS.AD_SNAPSHOT_EXCEPTIONSRow = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As dsADS.AD_SNAPSHOT_EXCEPTIONSRow
    actual = target.NewAD_SNAPSHOT_EXCEPTIONSRow
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for InitVars
'''</summary>
<TestMethod()>  _
Public Sub InitVarsTest()
Dim target As dsADS.AD_SNAPSHOT_EXCEPTIONSDataTable = New dsADS.AD_SNAPSHOT_EXCEPTIONSDataTable ' TODO: Initialize to an appropriate value
    target.InitVars
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for InitClass
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub InitClassTest()
Dim target As dsADS_Accessor.AD_SNAPSHOT_EXCEPTIONSDataTable = New dsADS_Accessor.AD_SNAPSHOT_EXCEPTIONSDataTable ' TODO: Initialize to an appropriate value
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
    actual = dsADS.AD_SNAPSHOT_EXCEPTIONSDataTable.GetTypedTableSchema(xs)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for GetRowType
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub GetRowTypeTest()
Dim target As dsADS_Accessor.AD_SNAPSHOT_EXCEPTIONSDataTable = New dsADS_Accessor.AD_SNAPSHOT_EXCEPTIONSDataTable ' TODO: Initialize to an appropriate value
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
Dim target As dsADS.AD_SNAPSHOT_EXCEPTIONSDataTable = New dsADS.AD_SNAPSHOT_EXCEPTIONSDataTable ' TODO: Initialize to an appropriate value
Dim ID As Long = 0 ' TODO: Initialize to an appropriate value
Dim expected As dsADS.AD_SNAPSHOT_EXCEPTIONSRow = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As dsADS.AD_SNAPSHOT_EXCEPTIONSRow
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
Dim target As dsADS_Accessor.AD_SNAPSHOT_EXCEPTIONSDataTable = New dsADS_Accessor.AD_SNAPSHOT_EXCEPTIONSDataTable ' TODO: Initialize to an appropriate value
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
Dim target As dsADS.AD_SNAPSHOT_EXCEPTIONSDataTable = New dsADS.AD_SNAPSHOT_EXCEPTIONSDataTable ' TODO: Initialize to an appropriate value
Dim expected As DataTable = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataTable
    actual = target.Clone
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for AddAD_SNAPSHOT_EXCEPTIONSRow
'''</summary>
<TestMethod()>  _
Public Sub AddAD_SNAPSHOT_EXCEPTIONSRowTest1()
Dim target As dsADS.AD_SNAPSHOT_EXCEPTIONSDataTable = New dsADS.AD_SNAPSHOT_EXCEPTIONSDataTable ' TODO: Initialize to an appropriate value
Dim row As dsADS.AD_SNAPSHOT_EXCEPTIONSRow = Nothing ' TODO: Initialize to an appropriate value
    target.AddAD_SNAPSHOT_EXCEPTIONSRow(row)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for AddAD_SNAPSHOT_EXCEPTIONSRow
'''</summary>
<TestMethod()>  _
Public Sub AddAD_SNAPSHOT_EXCEPTIONSRowTest()
Dim target As dsADS.AD_SNAPSHOT_EXCEPTIONSDataTable = New dsADS.AD_SNAPSHOT_EXCEPTIONSDataTable ' TODO: Initialize to an appropriate value
Dim AccountNr As String = String.Empty ' TODO: Initialize to an appropriate value
Dim FirstName As String = String.Empty ' TODO: Initialize to an appropriate value
Dim Lastname As String = String.Empty ' TODO: Initialize to an appropriate value
Dim ExpiryDate As DateTime = New DateTime ' TODO: Initialize to an appropriate value
Dim expected As dsADS.AD_SNAPSHOT_EXCEPTIONSRow = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As dsADS.AD_SNAPSHOT_EXCEPTIONSRow
    actual = target.AddAD_SNAPSHOT_EXCEPTIONSRow(AccountNr, FirstName, Lastname, ExpiryDate)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for AD_SNAPSHOT_EXCEPTIONSDataTable Constructor
'''</summary>
<TestMethod()>  _
Public Sub dsADS_AD_SNAPSHOT_EXCEPTIONSDataTableConstructorTest2()
    Dim target As dsADS.AD_SNAPSHOT_EXCEPTIONSDataTable = New dsADS.AD_SNAPSHOT_EXCEPTIONSDataTable
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub

'''<summary>
'''A test for AD_SNAPSHOT_EXCEPTIONSDataTable Constructor
'''</summary>
<TestMethod()>  _
Public Sub dsADS_AD_SNAPSHOT_EXCEPTIONSDataTableConstructorTest1()
Dim table As DataTable = Nothing ' TODO: Initialize to an appropriate value
    Dim target As dsADS.AD_SNAPSHOT_EXCEPTIONSDataTable = New dsADS.AD_SNAPSHOT_EXCEPTIONSDataTable(table)
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub

'''<summary>
'''A test for AD_SNAPSHOT_EXCEPTIONSDataTable Constructor
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub dsADS_AD_SNAPSHOT_EXCEPTIONSDataTableConstructorTest()
Dim info As SerializationInfo = Nothing ' TODO: Initialize to an appropriate value
Dim context As StreamingContext = New StreamingContext ' TODO: Initialize to an appropriate value
    Dim target As dsADS_Accessor.AD_SNAPSHOT_EXCEPTIONSDataTable = New dsADS_Accessor.AD_SNAPSHOT_EXCEPTIONSDataTable(info, context)
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub
End Class
