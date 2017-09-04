Imports System.Xml.Schema

Imports System

Imports System.Data

Imports System.Runtime.Serialization

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports ADAdminDotNet



'''<summary>
'''This is a test class for dsARSystemDataSet_CustNotifyDataTableTest and is intended
'''to contain all dsARSystemDataSet_CustNotifyDataTableTest Unit Tests
'''</summary>
<TestClass()> _
Public Class dsARSystemDataSet_CustNotifyDataTableTest


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
'''A test for SolutionColumn
'''</summary>
<TestMethod()>  _
Public Sub SolutionColumnTest()
Dim target As dsARSystemDataSet.CustNotifyDataTable = New dsARSystemDataSet.CustNotifyDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.SolutionColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Request_NoColumn
'''</summary>
<TestMethod()>  _
Public Sub Request_NoColumnTest()
Dim target As dsARSystemDataSet.CustNotifyDataTable = New dsARSystemDataSet.CustNotifyDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.Request_NoColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Persal_NumberColumn
'''</summary>
<TestMethod()>  _
Public Sub Persal_NumberColumnTest()
Dim target As dsARSystemDataSet.CustNotifyDataTable = New dsARSystemDataSet.CustNotifyDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.Persal_NumberColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Long_DescriptionColumn
'''</summary>
<TestMethod()>  _
Public Sub Long_DescriptionColumnTest()
Dim target As dsARSystemDataSet.CustNotifyDataTable = New dsARSystemDataSet.CustNotifyDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.Long_DescriptionColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Item
'''</summary>
<TestMethod()>  _
Public Sub ItemTest()
Dim target As dsARSystemDataSet.CustNotifyDataTable = New dsARSystemDataSet.CustNotifyDataTable ' TODO: Initialize to an appropriate value
Dim index As Integer = 0 ' TODO: Initialize to an appropriate value
    Dim actual As dsARSystemDataSet.CustNotifyRow
    actual = target(index)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for First_NameColumn
'''</summary>
<TestMethod()>  _
Public Sub First_NameColumnTest()
Dim target As dsARSystemDataSet.CustNotifyDataTable = New dsARSystemDataSet.CustNotifyDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.First_NameColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Entry_DateColumn
'''</summary>
<TestMethod()>  _
Public Sub Entry_DateColumnTest()
Dim target As dsARSystemDataSet.CustNotifyDataTable = New dsARSystemDataSet.CustNotifyDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.Entry_DateColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for E_MailColumn
'''</summary>
<TestMethod()>  _
Public Sub E_MailColumnTest()
Dim target As dsARSystemDataSet.CustNotifyDataTable = New dsARSystemDataSet.CustNotifyDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.E_MailColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Count
'''</summary>
<TestMethod()>  _
Public Sub CountTest()
Dim target As dsARSystemDataSet.CustNotifyDataTable = New dsARSystemDataSet.CustNotifyDataTable ' TODO: Initialize to an appropriate value
    Dim actual As Integer
    actual = target.Count
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for RemoveCustNotifyRow
'''</summary>
<TestMethod()>  _
Public Sub RemoveCustNotifyRowTest()
Dim target As dsARSystemDataSet.CustNotifyDataTable = New dsARSystemDataSet.CustNotifyDataTable ' TODO: Initialize to an appropriate value
Dim row As dsARSystemDataSet.CustNotifyRow = Nothing ' TODO: Initialize to an appropriate value
    target.RemoveCustNotifyRow(row)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for OnRowDeleting
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub OnRowDeletingTest()
Dim target As dsARSystemDataSet_Accessor.CustNotifyDataTable = New dsARSystemDataSet_Accessor.CustNotifyDataTable ' TODO: Initialize to an appropriate value
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
Dim target As dsARSystemDataSet_Accessor.CustNotifyDataTable = New dsARSystemDataSet_Accessor.CustNotifyDataTable ' TODO: Initialize to an appropriate value
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
Dim target As dsARSystemDataSet_Accessor.CustNotifyDataTable = New dsARSystemDataSet_Accessor.CustNotifyDataTable ' TODO: Initialize to an appropriate value
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
Dim target As dsARSystemDataSet_Accessor.CustNotifyDataTable = New dsARSystemDataSet_Accessor.CustNotifyDataTable ' TODO: Initialize to an appropriate value
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
Dim target As dsARSystemDataSet_Accessor.CustNotifyDataTable = New dsARSystemDataSet_Accessor.CustNotifyDataTable ' TODO: Initialize to an appropriate value
Dim builder As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim expected As DataRow = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataRow
    actual = target.NewRowFromBuilder(builder)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for NewCustNotifyRow
'''</summary>
<TestMethod()>  _
Public Sub NewCustNotifyRowTest()
Dim target As dsARSystemDataSet.CustNotifyDataTable = New dsARSystemDataSet.CustNotifyDataTable ' TODO: Initialize to an appropriate value
Dim expected As dsARSystemDataSet.CustNotifyRow = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As dsARSystemDataSet.CustNotifyRow
    actual = target.NewCustNotifyRow
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for InitVars
'''</summary>
<TestMethod()>  _
Public Sub InitVarsTest()
Dim target As dsARSystemDataSet.CustNotifyDataTable = New dsARSystemDataSet.CustNotifyDataTable ' TODO: Initialize to an appropriate value
    target.InitVars
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for InitClass
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub InitClassTest()
Dim target As dsARSystemDataSet_Accessor.CustNotifyDataTable = New dsARSystemDataSet_Accessor.CustNotifyDataTable ' TODO: Initialize to an appropriate value
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
    actual = dsARSystemDataSet.CustNotifyDataTable.GetTypedTableSchema(xs)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for GetRowType
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub GetRowTypeTest()
Dim target As dsARSystemDataSet_Accessor.CustNotifyDataTable = New dsARSystemDataSet_Accessor.CustNotifyDataTable ' TODO: Initialize to an appropriate value
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
Dim target As dsARSystemDataSet_Accessor.CustNotifyDataTable = New dsARSystemDataSet_Accessor.CustNotifyDataTable ' TODO: Initialize to an appropriate value
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
Dim target As dsARSystemDataSet.CustNotifyDataTable = New dsARSystemDataSet.CustNotifyDataTable ' TODO: Initialize to an appropriate value
Dim expected As DataTable = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataTable
    actual = target.Clone
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for AddCustNotifyRow
'''</summary>
<TestMethod()>  _
Public Sub AddCustNotifyRowTest1()
Dim target As dsARSystemDataSet.CustNotifyDataTable = New dsARSystemDataSet.CustNotifyDataTable ' TODO: Initialize to an appropriate value
Dim row As dsARSystemDataSet.CustNotifyRow = Nothing ' TODO: Initialize to an appropriate value
    target.AddCustNotifyRow(row)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for AddCustNotifyRow
'''</summary>
<TestMethod()>  _
Public Sub AddCustNotifyRowTest()
Dim target As dsARSystemDataSet.CustNotifyDataTable = New dsARSystemDataSet.CustNotifyDataTable ' TODO: Initialize to an appropriate value
Dim Request_No As String = String.Empty ' TODO: Initialize to an appropriate value
Dim Long_Description As String = String.Empty ' TODO: Initialize to an appropriate value
Dim Solution As String = String.Empty ' TODO: Initialize to an appropriate value
Dim First_Name As String = String.Empty ' TODO: Initialize to an appropriate value
Dim Entry_Date As DateTime = New DateTime ' TODO: Initialize to an appropriate value
Dim E_Mail As String = String.Empty ' TODO: Initialize to an appropriate value
Dim Persal_Number As String = String.Empty ' TODO: Initialize to an appropriate value
Dim expected As dsARSystemDataSet.CustNotifyRow = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As dsARSystemDataSet.CustNotifyRow
    actual = target.AddCustNotifyRow(Request_No, Long_Description, Solution, First_Name, Entry_Date, E_Mail, Persal_Number)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for CustNotifyDataTable Constructor
'''</summary>
<TestMethod()>  _
Public Sub dsARSystemDataSet_CustNotifyDataTableConstructorTest2()
    Dim target As dsARSystemDataSet.CustNotifyDataTable = New dsARSystemDataSet.CustNotifyDataTable
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub

'''<summary>
'''A test for CustNotifyDataTable Constructor
'''</summary>
<TestMethod()>  _
Public Sub dsARSystemDataSet_CustNotifyDataTableConstructorTest1()
Dim table As DataTable = Nothing ' TODO: Initialize to an appropriate value
    Dim target As dsARSystemDataSet.CustNotifyDataTable = New dsARSystemDataSet.CustNotifyDataTable(table)
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub

'''<summary>
'''A test for CustNotifyDataTable Constructor
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub dsARSystemDataSet_CustNotifyDataTableConstructorTest()
Dim info As SerializationInfo = Nothing ' TODO: Initialize to an appropriate value
Dim context As StreamingContext = New StreamingContext ' TODO: Initialize to an appropriate value
    Dim target As dsARSystemDataSet_Accessor.CustNotifyDataTable = New dsARSystemDataSet_Accessor.CustNotifyDataTable(info, context)
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub
End Class
