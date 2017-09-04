Imports System.Xml.Schema

Imports System

Imports System.Data

Imports System.Runtime.Serialization

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports ADAdminDotNet



'''<summary>
'''This is a test class for dsARSystemDataSet_LOG_DM_PersonnelDataTableTest and is intended
'''to contain all dsARSystemDataSet_LOG_DM_PersonnelDataTableTest Unit Tests
'''</summary>
<TestClass()> _
Public Class dsARSystemDataSet_LOG_DM_PersonnelDataTableTest


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
'''A test for UsernameColumn
'''</summary>
<TestMethod()>  _
Public Sub UsernameColumnTest()
Dim target As dsARSystemDataSet.LOG_DM_PersonnelDataTable = New dsARSystemDataSet.LOG_DM_PersonnelDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.UsernameColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for TierColumn
'''</summary>
<TestMethod()>  _
Public Sub TierColumnTest()
Dim target As dsARSystemDataSet.LOG_DM_PersonnelDataTable = New dsARSystemDataSet.LOG_DM_PersonnelDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.TierColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for TelephoneColumn
'''</summary>
<TestMethod()>  _
Public Sub TelephoneColumnTest()
Dim target As dsARSystemDataSet.LOG_DM_PersonnelDataTable = New dsARSystemDataSet.LOG_DM_PersonnelDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.TelephoneColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for System_GroupColumn
'''</summary>
<TestMethod()>  _
Public Sub System_GroupColumnTest()
Dim target As dsARSystemDataSet.LOG_DM_PersonnelDataTable = New dsARSystemDataSet.LOG_DM_PersonnelDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.System_GroupColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for SubmitterColumn
'''</summary>
<TestMethod()>  _
Public Sub SubmitterColumnTest()
Dim target As dsARSystemDataSet.LOG_DM_PersonnelDataTable = New dsARSystemDataSet.LOG_DM_PersonnelDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.SubmitterColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for StatusColumn
'''</summary>
<TestMethod()>  _
Public Sub StatusColumnTest()
Dim target As dsARSystemDataSet.LOG_DM_PersonnelDataTable = New dsARSystemDataSet.LOG_DM_PersonnelDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.StatusColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Persal_NumberColumn
'''</summary>
<TestMethod()>  _
Public Sub Persal_NumberColumnTest()
Dim target As dsARSystemDataSet.LOG_DM_PersonnelDataTable = New dsARSystemDataSet.LOG_DM_PersonnelDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.Persal_NumberColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Modified_DateColumn
'''</summary>
<TestMethod()>  _
Public Sub Modified_DateColumnTest()
Dim target As dsARSystemDataSet.LOG_DM_PersonnelDataTable = New dsARSystemDataSet.LOG_DM_PersonnelDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.Modified_DateColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Last_Modified_ByColumn
'''</summary>
<TestMethod()>  _
Public Sub Last_Modified_ByColumnTest()
Dim target As dsARSystemDataSet.LOG_DM_PersonnelDataTable = New dsARSystemDataSet.LOG_DM_PersonnelDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.Last_Modified_ByColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Item
'''</summary>
<TestMethod()>  _
Public Sub ItemTest()
Dim target As dsARSystemDataSet.LOG_DM_PersonnelDataTable = New dsARSystemDataSet.LOG_DM_PersonnelDataTable ' TODO: Initialize to an appropriate value
Dim index As Integer = 0 ' TODO: Initialize to an appropriate value
    Dim actual As dsARSystemDataSet.LOG_DM_PersonnelRow
    actual = target(index)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Internal_Column
'''</summary>
<TestMethod()>  _
Public Sub Internal_ColumnTest()
Dim target As dsARSystemDataSet.LOG_DM_PersonnelDataTable = New dsARSystemDataSet.LOG_DM_PersonnelDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.Internal_Column
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Group_xColumn
'''</summary>
<TestMethod()>  _
Public Sub Group_xColumnTest()
Dim target As dsARSystemDataSet.LOG_DM_PersonnelDataTable = New dsARSystemDataSet.LOG_DM_PersonnelDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.Group_xColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for EmailColumn
'''</summary>
<TestMethod()>  _
Public Sub EmailColumnTest()
Dim target As dsARSystemDataSet.LOG_DM_PersonnelDataTable = New dsARSystemDataSet.LOG_DM_PersonnelDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.EmailColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Create_DateColumn
'''</summary>
<TestMethod()>  _
Public Sub Create_DateColumnTest()
Dim target As dsARSystemDataSet.LOG_DM_PersonnelDataTable = New dsARSystemDataSet.LOG_DM_PersonnelDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.Create_DateColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Count
'''</summary>
<TestMethod()>  _
Public Sub CountTest()
Dim target As dsARSystemDataSet.LOG_DM_PersonnelDataTable = New dsARSystemDataSet.LOG_DM_PersonnelDataTable ' TODO: Initialize to an appropriate value
    Dim actual As Integer
    actual = target.Count
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Comments_about_TrainerColumn
'''</summary>
<TestMethod()>  _
Public Sub Comments_about_TrainerColumnTest()
Dim target As dsARSystemDataSet.LOG_DM_PersonnelDataTable = New dsARSystemDataSet.LOG_DM_PersonnelDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.Comments_about_TrainerColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Cell_PhoneColumn
'''</summary>
<TestMethod()>  _
Public Sub Cell_PhoneColumnTest()
Dim target As dsARSystemDataSet.LOG_DM_PersonnelDataTable = New dsARSystemDataSet.LOG_DM_PersonnelDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.Cell_PhoneColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Assignee_GroupColumn
'''</summary>
<TestMethod()>  _
Public Sub Assignee_GroupColumnTest()
Dim target As dsARSystemDataSet.LOG_DM_PersonnelDataTable = New dsARSystemDataSet.LOG_DM_PersonnelDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.Assignee_GroupColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Agent_NameColumn
'''</summary>
<TestMethod()>  _
Public Sub Agent_NameColumnTest()
Dim target As dsARSystemDataSet.LOG_DM_PersonnelDataTable = New dsARSystemDataSet.LOG_DM_PersonnelDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.Agent_NameColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Agent_IDColumn
'''</summary>
<TestMethod()>  _
Public Sub Agent_IDColumnTest()
Dim target As dsARSystemDataSet.LOG_DM_PersonnelDataTable = New dsARSystemDataSet.LOG_DM_PersonnelDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.Agent_IDColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for RemoveLOG_DM_PersonnelRow
'''</summary>
<TestMethod()>  _
Public Sub RemoveLOG_DM_PersonnelRowTest()
Dim target As dsARSystemDataSet.LOG_DM_PersonnelDataTable = New dsARSystemDataSet.LOG_DM_PersonnelDataTable ' TODO: Initialize to an appropriate value
Dim row As dsARSystemDataSet.LOG_DM_PersonnelRow = Nothing ' TODO: Initialize to an appropriate value
    target.RemoveLOG_DM_PersonnelRow(row)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for OnRowDeleting
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub OnRowDeletingTest()
Dim target As dsARSystemDataSet_Accessor.LOG_DM_PersonnelDataTable = New dsARSystemDataSet_Accessor.LOG_DM_PersonnelDataTable ' TODO: Initialize to an appropriate value
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
Dim target As dsARSystemDataSet_Accessor.LOG_DM_PersonnelDataTable = New dsARSystemDataSet_Accessor.LOG_DM_PersonnelDataTable ' TODO: Initialize to an appropriate value
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
Dim target As dsARSystemDataSet_Accessor.LOG_DM_PersonnelDataTable = New dsARSystemDataSet_Accessor.LOG_DM_PersonnelDataTable ' TODO: Initialize to an appropriate value
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
Dim target As dsARSystemDataSet_Accessor.LOG_DM_PersonnelDataTable = New dsARSystemDataSet_Accessor.LOG_DM_PersonnelDataTable ' TODO: Initialize to an appropriate value
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
Dim target As dsARSystemDataSet_Accessor.LOG_DM_PersonnelDataTable = New dsARSystemDataSet_Accessor.LOG_DM_PersonnelDataTable ' TODO: Initialize to an appropriate value
Dim builder As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim expected As DataRow = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataRow
    actual = target.NewRowFromBuilder(builder)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for NewLOG_DM_PersonnelRow
'''</summary>
<TestMethod()>  _
Public Sub NewLOG_DM_PersonnelRowTest()
Dim target As dsARSystemDataSet.LOG_DM_PersonnelDataTable = New dsARSystemDataSet.LOG_DM_PersonnelDataTable ' TODO: Initialize to an appropriate value
Dim expected As dsARSystemDataSet.LOG_DM_PersonnelRow = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As dsARSystemDataSet.LOG_DM_PersonnelRow
    actual = target.NewLOG_DM_PersonnelRow
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for InitVars
'''</summary>
<TestMethod()>  _
Public Sub InitVarsTest()
Dim target As dsARSystemDataSet.LOG_DM_PersonnelDataTable = New dsARSystemDataSet.LOG_DM_PersonnelDataTable ' TODO: Initialize to an appropriate value
    target.InitVars
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for InitClass
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub InitClassTest()
Dim target As dsARSystemDataSet_Accessor.LOG_DM_PersonnelDataTable = New dsARSystemDataSet_Accessor.LOG_DM_PersonnelDataTable ' TODO: Initialize to an appropriate value
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
    actual = dsARSystemDataSet.LOG_DM_PersonnelDataTable.GetTypedTableSchema(xs)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for GetRowType
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub GetRowTypeTest()
Dim target As dsARSystemDataSet_Accessor.LOG_DM_PersonnelDataTable = New dsARSystemDataSet_Accessor.LOG_DM_PersonnelDataTable ' TODO: Initialize to an appropriate value
Dim expected As Type = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Type
    actual = target.GetRowType
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for FindByAgent_ID
'''</summary>
<TestMethod()>  _
Public Sub FindByAgent_IDTest()
Dim target As dsARSystemDataSet.LOG_DM_PersonnelDataTable = New dsARSystemDataSet.LOG_DM_PersonnelDataTable ' TODO: Initialize to an appropriate value
Dim Agent_ID As String = String.Empty ' TODO: Initialize to an appropriate value
Dim expected As dsARSystemDataSet.LOG_DM_PersonnelRow = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As dsARSystemDataSet.LOG_DM_PersonnelRow
    actual = target.FindByAgent_ID(Agent_ID)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for CreateInstance
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub CreateInstanceTest()
Dim target As dsARSystemDataSet_Accessor.LOG_DM_PersonnelDataTable = New dsARSystemDataSet_Accessor.LOG_DM_PersonnelDataTable ' TODO: Initialize to an appropriate value
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
Dim target As dsARSystemDataSet.LOG_DM_PersonnelDataTable = New dsARSystemDataSet.LOG_DM_PersonnelDataTable ' TODO: Initialize to an appropriate value
Dim expected As DataTable = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataTable
    actual = target.Clone
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for AddLOG_DM_PersonnelRow
'''</summary>
<TestMethod()>  _
Public Sub AddLOG_DM_PersonnelRowTest1()
Dim target As dsARSystemDataSet.LOG_DM_PersonnelDataTable = New dsARSystemDataSet.LOG_DM_PersonnelDataTable ' TODO: Initialize to an appropriate value
Dim row As dsARSystemDataSet.LOG_DM_PersonnelRow = Nothing ' TODO: Initialize to an appropriate value
    target.AddLOG_DM_PersonnelRow(row)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for AddLOG_DM_PersonnelRow
'''</summary>
<TestMethod()>  _
Public Sub AddLOG_DM_PersonnelRowTest()
Dim target As dsARSystemDataSet.LOG_DM_PersonnelDataTable = New dsARSystemDataSet.LOG_DM_PersonnelDataTable ' TODO: Initialize to an appropriate value
Dim Agent_ID As String = String.Empty ' TODO: Initialize to an appropriate value
Dim Submitter As String = String.Empty ' TODO: Initialize to an appropriate value
Dim Create_Date As Integer = 0 ' TODO: Initialize to an appropriate value
Dim Username As String = String.Empty ' TODO: Initialize to an appropriate value
Dim Last_Modified_By As String = String.Empty ' TODO: Initialize to an appropriate value
Dim Modified_Date As Integer = 0 ' TODO: Initialize to an appropriate value
Dim Status As Integer = 0 ' TODO: Initialize to an appropriate value
Dim Agent_Name As String = String.Empty ' TODO: Initialize to an appropriate value
Dim Assignee_Group As String = String.Empty ' TODO: Initialize to an appropriate value
Dim Group_x As String = String.Empty ' TODO: Initialize to an appropriate value
Dim Tier As String = String.Empty ' TODO: Initialize to an appropriate value
Dim System_Group As String = String.Empty ' TODO: Initialize to an appropriate value
Dim Email As String = String.Empty ' TODO: Initialize to an appropriate value
Dim Internal_ As Integer = 0 ' TODO: Initialize to an appropriate value
Dim Telephone As String = String.Empty ' TODO: Initialize to an appropriate value
Dim Cell_Phone As String = String.Empty ' TODO: Initialize to an appropriate value
Dim Persal_Number As String = String.Empty ' TODO: Initialize to an appropriate value
Dim Comments_about_Trainer As String = String.Empty ' TODO: Initialize to an appropriate value
Dim expected As dsARSystemDataSet.LOG_DM_PersonnelRow = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As dsARSystemDataSet.LOG_DM_PersonnelRow
    actual = target.AddLOG_DM_PersonnelRow(Agent_ID, Submitter, Create_Date, Username, Last_Modified_By, Modified_Date, Status, Agent_Name, Assignee_Group, Group_x, Tier, System_Group, Email, Internal_, Telephone, Cell_Phone, Persal_Number, Comments_about_Trainer)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for LOG_DM_PersonnelDataTable Constructor
'''</summary>
<TestMethod()>  _
Public Sub dsARSystemDataSet_LOG_DM_PersonnelDataTableConstructorTest2()
    Dim target As dsARSystemDataSet.LOG_DM_PersonnelDataTable = New dsARSystemDataSet.LOG_DM_PersonnelDataTable
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub

'''<summary>
'''A test for LOG_DM_PersonnelDataTable Constructor
'''</summary>
<TestMethod()>  _
Public Sub dsARSystemDataSet_LOG_DM_PersonnelDataTableConstructorTest1()
Dim table As DataTable = Nothing ' TODO: Initialize to an appropriate value
    Dim target As dsARSystemDataSet.LOG_DM_PersonnelDataTable = New dsARSystemDataSet.LOG_DM_PersonnelDataTable(table)
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub

'''<summary>
'''A test for LOG_DM_PersonnelDataTable Constructor
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub dsARSystemDataSet_LOG_DM_PersonnelDataTableConstructorTest()
Dim info As SerializationInfo = Nothing ' TODO: Initialize to an appropriate value
Dim context As StreamingContext = New StreamingContext ' TODO: Initialize to an appropriate value
    Dim target As dsARSystemDataSet_Accessor.LOG_DM_PersonnelDataTable = New dsARSystemDataSet_Accessor.LOG_DM_PersonnelDataTable(info, context)
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub
End Class
