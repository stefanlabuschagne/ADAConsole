Imports System.Xml.Schema

Imports System

Imports System.Data

Imports System.Runtime.Serialization

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports ADAdminDotNet



'''<summary>
'''This is a test class for dsADS_Config_ProblemDataTableTest and is intended
'''to contain all dsADS_Config_ProblemDataTableTest Unit Tests
'''</summary>
<TestClass()> _
Public Class dsADS_Config_ProblemDataTableTest


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
'''A test for VPNProblemColumn
'''</summary>
<TestMethod()>  _
Public Sub VPNProblemColumnTest()
Dim target As dsADS.Config_ProblemDataTable = New dsADS.Config_ProblemDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.VPNProblemColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for VPNAdminsIDColumn
'''</summary>
<TestMethod()>  _
Public Sub VPNAdminsIDColumnTest()
Dim target As dsADS.Config_ProblemDataTable = New dsADS.Config_ProblemDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.VPNAdminsIDColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for SurnameColumn
'''</summary>
<TestMethod()>  _
Public Sub SurnameColumnTest()
Dim target As dsADS.Config_ProblemDataTable = New dsADS.Config_ProblemDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.SurnameColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ProblemSolvedColumn
'''</summary>
<TestMethod()>  _
Public Sub ProblemSolvedColumnTest()
Dim target As dsADS.Config_ProblemDataTable = New dsADS.Config_ProblemDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.ProblemSolvedColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ProblemColumn
'''</summary>
<TestMethod()>  _
Public Sub ProblemColumnTest()
Dim target As dsADS.Config_ProblemDataTable = New dsADS.Config_ProblemDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.ProblemColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for PolicyProblemColumn
'''</summary>
<TestMethod()>  _
Public Sub PolicyProblemColumnTest()
Dim target As dsADS.Config_ProblemDataTable = New dsADS.Config_ProblemDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.PolicyProblemColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for PersalnoColumn
'''</summary>
<TestMethod()>  _
Public Sub PersalnoColumnTest()
Dim target As dsADS.Config_ProblemDataTable = New dsADS.Config_ProblemDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.PersalnoColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for NameColumn
'''</summary>
<TestMethod()>  _
Public Sub NameColumnTest()
Dim target As dsADS.Config_ProblemDataTable = New dsADS.Config_ProblemDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.NameColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Item
'''</summary>
<TestMethod()>  _
Public Sub ItemTest()
Dim target As dsADS.Config_ProblemDataTable = New dsADS.Config_ProblemDataTable ' TODO: Initialize to an appropriate value
Dim index As Integer = 0 ' TODO: Initialize to an appropriate value
    Dim actual As dsADS.Config_ProblemRow
    actual = target(index)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IDColumn
'''</summary>
<TestMethod()>  _
Public Sub IDColumnTest()
Dim target As dsADS.Config_ProblemDataTable = New dsADS.Config_ProblemDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.IDColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DeptCodeColumn
'''</summary>
<TestMethod()>  _
Public Sub DeptCodeColumnTest()
Dim target As dsADS.Config_ProblemDataTable = New dsADS.Config_ProblemDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.DeptCodeColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DatetimeColumn
'''</summary>
<TestMethod()>  _
Public Sub DatetimeColumnTest()
Dim target As dsADS.Config_ProblemDataTable = New dsADS.Config_ProblemDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.DatetimeColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Count
'''</summary>
<TestMethod()>  _
Public Sub CountTest()
Dim target As dsADS.Config_ProblemDataTable = New dsADS.Config_ProblemDataTable ' TODO: Initialize to an appropriate value
    Dim actual As Integer
    actual = target.Count
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for RemoveConfig_ProblemRow
'''</summary>
<TestMethod()>  _
Public Sub RemoveConfig_ProblemRowTest()
Dim target As dsADS.Config_ProblemDataTable = New dsADS.Config_ProblemDataTable ' TODO: Initialize to an appropriate value
Dim row As dsADS.Config_ProblemRow = Nothing ' TODO: Initialize to an appropriate value
    target.RemoveConfig_ProblemRow(row)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for OnRowDeleting
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub OnRowDeletingTest()
Dim target As dsADS_Accessor.Config_ProblemDataTable = New dsADS_Accessor.Config_ProblemDataTable ' TODO: Initialize to an appropriate value
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
Dim target As dsADS_Accessor.Config_ProblemDataTable = New dsADS_Accessor.Config_ProblemDataTable ' TODO: Initialize to an appropriate value
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
Dim target As dsADS_Accessor.Config_ProblemDataTable = New dsADS_Accessor.Config_ProblemDataTable ' TODO: Initialize to an appropriate value
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
Dim target As dsADS_Accessor.Config_ProblemDataTable = New dsADS_Accessor.Config_ProblemDataTable ' TODO: Initialize to an appropriate value
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
Dim target As dsADS_Accessor.Config_ProblemDataTable = New dsADS_Accessor.Config_ProblemDataTable ' TODO: Initialize to an appropriate value
Dim builder As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim expected As DataRow = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataRow
    actual = target.NewRowFromBuilder(builder)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for NewConfig_ProblemRow
'''</summary>
<TestMethod()>  _
Public Sub NewConfig_ProblemRowTest()
Dim target As dsADS.Config_ProblemDataTable = New dsADS.Config_ProblemDataTable ' TODO: Initialize to an appropriate value
Dim expected As dsADS.Config_ProblemRow = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As dsADS.Config_ProblemRow
    actual = target.NewConfig_ProblemRow
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for InitVars
'''</summary>
<TestMethod()>  _
Public Sub InitVarsTest()
Dim target As dsADS.Config_ProblemDataTable = New dsADS.Config_ProblemDataTable ' TODO: Initialize to an appropriate value
    target.InitVars
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for InitClass
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub InitClassTest()
Dim target As dsADS_Accessor.Config_ProblemDataTable = New dsADS_Accessor.Config_ProblemDataTable ' TODO: Initialize to an appropriate value
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
    actual = dsADS.Config_ProblemDataTable.GetTypedTableSchema(xs)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for GetRowType
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub GetRowTypeTest()
Dim target As dsADS_Accessor.Config_ProblemDataTable = New dsADS_Accessor.Config_ProblemDataTable ' TODO: Initialize to an appropriate value
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
Dim target As dsADS_Accessor.Config_ProblemDataTable = New dsADS_Accessor.Config_ProblemDataTable ' TODO: Initialize to an appropriate value
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
Dim target As dsADS.Config_ProblemDataTable = New dsADS.Config_ProblemDataTable ' TODO: Initialize to an appropriate value
Dim expected As DataTable = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataTable
    actual = target.Clone
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for AddConfig_ProblemRow
'''</summary>
<TestMethod()>  _
Public Sub AddConfig_ProblemRowTest1()
Dim target As dsADS.Config_ProblemDataTable = New dsADS.Config_ProblemDataTable ' TODO: Initialize to an appropriate value
Dim row As dsADS.Config_ProblemRow = Nothing ' TODO: Initialize to an appropriate value
    target.AddConfig_ProblemRow(row)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for AddConfig_ProblemRow
'''</summary>
<TestMethod()>  _
Public Sub AddConfig_ProblemRowTest()
Dim target As dsADS.Config_ProblemDataTable = New dsADS.Config_ProblemDataTable ' TODO: Initialize to an appropriate value
Dim VPNAdminsID As Long = 0 ' TODO: Initialize to an appropriate value
Dim Persalno As String = String.Empty ' TODO: Initialize to an appropriate value
Dim Name As String = String.Empty ' TODO: Initialize to an appropriate value
Dim Surname As String = String.Empty ' TODO: Initialize to an appropriate value
Dim Datetime As DateTime = New DateTime ' TODO: Initialize to an appropriate value
Dim Problem As String = String.Empty ' TODO: Initialize to an appropriate value
Dim DeptCode As String = String.Empty ' TODO: Initialize to an appropriate value
Dim ProblemSolved As Boolean = false ' TODO: Initialize to an appropriate value
Dim VPNProblem As Boolean = false ' TODO: Initialize to an appropriate value
Dim PolicyProblem As Boolean = false ' TODO: Initialize to an appropriate value
Dim expected As dsADS.Config_ProblemRow = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As dsADS.Config_ProblemRow
    actual = target.AddConfig_ProblemRow(VPNAdminsID, Persalno, Name, Surname, Datetime, Problem, DeptCode, ProblemSolved, VPNProblem, PolicyProblem)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Config_ProblemDataTable Constructor
'''</summary>
<TestMethod()>  _
Public Sub dsADS_Config_ProblemDataTableConstructorTest2()
    Dim target As dsADS.Config_ProblemDataTable = New dsADS.Config_ProblemDataTable
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub

'''<summary>
'''A test for Config_ProblemDataTable Constructor
'''</summary>
<TestMethod()>  _
Public Sub dsADS_Config_ProblemDataTableConstructorTest1()
Dim table As DataTable = Nothing ' TODO: Initialize to an appropriate value
    Dim target As dsADS.Config_ProblemDataTable = New dsADS.Config_ProblemDataTable(table)
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub

'''<summary>
'''A test for Config_ProblemDataTable Constructor
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub dsADS_Config_ProblemDataTableConstructorTest()
Dim info As SerializationInfo = Nothing ' TODO: Initialize to an appropriate value
Dim context As StreamingContext = New StreamingContext ' TODO: Initialize to an appropriate value
    Dim target As dsADS_Accessor.Config_ProblemDataTable = New dsADS_Accessor.Config_ProblemDataTable(info, context)
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub
End Class
