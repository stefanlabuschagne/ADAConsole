Imports System.Xml.Schema

Imports System

Imports System.Data

Imports System.Runtime.Serialization

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports ADAdminDotNet



'''<summary>
'''This is a test class for dsADS_EstablishmentDataTableTest and is intended
'''to contain all dsADS_EstablishmentDataTableTest Unit Tests
'''</summary>
<TestClass()> _
Public Class dsADS_EstablishmentDataTableTest


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
'''A test for SUR_INIColumn
'''</summary>
<TestMethod()>  _
Public Sub SUR_INIColumnTest()
Dim target As dsADS.EstablishmentDataTable = New dsADS.EstablishmentDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.SUR_INIColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for SNAMEColumn
'''</summary>
<TestMethod()>  _
Public Sub SNAMEColumnTest()
Dim target As dsADS.EstablishmentDataTable = New dsADS.EstablishmentDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.SNAMEColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for RANKDESCColumn
'''</summary>
<TestMethod()>  _
Public Sub RANKDESCColumnTest()
Dim target As dsADS.EstablishmentDataTable = New dsADS.EstablishmentDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.RANKDESCColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for PROVDESCColumn
'''</summary>
<TestMethod()>  _
Public Sub PROVDESCColumnTest()
Dim target As dsADS.EstablishmentDataTable = New dsADS.EstablishmentDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.PROVDESCColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for PERSALNRColumn
'''</summary>
<TestMethod()>  _
Public Sub PERSALNRColumnTest()
Dim target As dsADS.EstablishmentDataTable = New dsADS.EstablishmentDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.PERSALNRColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for PAYPOINTColumn
'''</summary>
<TestMethod()>  _
Public Sub PAYPOINTColumnTest()
Dim target As dsADS.EstablishmentDataTable = New dsADS.EstablishmentDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.PAYPOINTColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for PAYDISTColumn
'''</summary>
<TestMethod()>  _
Public Sub PAYDISTColumnTest()
Dim target As dsADS.EstablishmentDataTable = New dsADS.EstablishmentDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.PAYDISTColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for JOBTITLEColumn
'''</summary>
<TestMethod()>  _
Public Sub JOBTITLEColumnTest()
Dim target As dsADS.EstablishmentDataTable = New dsADS.EstablishmentDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.JOBTITLEColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Item
'''</summary>
<TestMethod()>  _
Public Sub ItemTest()
Dim target As dsADS.EstablishmentDataTable = New dsADS.EstablishmentDataTable ' TODO: Initialize to an appropriate value
Dim index As Integer = 0 ' TODO: Initialize to an appropriate value
    Dim actual As dsADS.EstablishmentRow
    actual = target(index)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DEPTDESCColumn
'''</summary>
<TestMethod()>  _
Public Sub DEPTDESCColumnTest()
Dim target As dsADS.EstablishmentDataTable = New dsADS.EstablishmentDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.DEPTDESCColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Count
'''</summary>
<TestMethod()>  _
Public Sub CountTest()
Dim target As dsADS.EstablishmentDataTable = New dsADS.EstablishmentDataTable ' TODO: Initialize to an appropriate value
    Dim actual As Integer
    actual = target.Count
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for APPTNATColumn
'''</summary>
<TestMethod()>  _
Public Sub APPTNATColumnTest()
Dim target As dsADS.EstablishmentDataTable = New dsADS.EstablishmentDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.APPTNATColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for RemoveEstablishmentRow
'''</summary>
<TestMethod()>  _
Public Sub RemoveEstablishmentRowTest()
Dim target As dsADS.EstablishmentDataTable = New dsADS.EstablishmentDataTable ' TODO: Initialize to an appropriate value
Dim row As dsADS.EstablishmentRow = Nothing ' TODO: Initialize to an appropriate value
    target.RemoveEstablishmentRow(row)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for OnRowDeleting
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub OnRowDeletingTest()
Dim target As dsADS_Accessor.EstablishmentDataTable = New dsADS_Accessor.EstablishmentDataTable ' TODO: Initialize to an appropriate value
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
Dim target As dsADS_Accessor.EstablishmentDataTable = New dsADS_Accessor.EstablishmentDataTable ' TODO: Initialize to an appropriate value
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
Dim target As dsADS_Accessor.EstablishmentDataTable = New dsADS_Accessor.EstablishmentDataTable ' TODO: Initialize to an appropriate value
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
Dim target As dsADS_Accessor.EstablishmentDataTable = New dsADS_Accessor.EstablishmentDataTable ' TODO: Initialize to an appropriate value
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
Dim target As dsADS_Accessor.EstablishmentDataTable = New dsADS_Accessor.EstablishmentDataTable ' TODO: Initialize to an appropriate value
Dim builder As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim expected As DataRow = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataRow
    actual = target.NewRowFromBuilder(builder)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for NewEstablishmentRow
'''</summary>
<TestMethod()>  _
Public Sub NewEstablishmentRowTest()
Dim target As dsADS.EstablishmentDataTable = New dsADS.EstablishmentDataTable ' TODO: Initialize to an appropriate value
Dim expected As dsADS.EstablishmentRow = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As dsADS.EstablishmentRow
    actual = target.NewEstablishmentRow
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for InitVars
'''</summary>
<TestMethod()>  _
Public Sub InitVarsTest()
Dim target As dsADS.EstablishmentDataTable = New dsADS.EstablishmentDataTable ' TODO: Initialize to an appropriate value
    target.InitVars
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for InitClass
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub InitClassTest()
Dim target As dsADS_Accessor.EstablishmentDataTable = New dsADS_Accessor.EstablishmentDataTable ' TODO: Initialize to an appropriate value
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
    actual = dsADS.EstablishmentDataTable.GetTypedTableSchema(xs)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for GetRowType
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub GetRowTypeTest()
Dim target As dsADS_Accessor.EstablishmentDataTable = New dsADS_Accessor.EstablishmentDataTable ' TODO: Initialize to an appropriate value
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
Dim target As dsADS_Accessor.EstablishmentDataTable = New dsADS_Accessor.EstablishmentDataTable ' TODO: Initialize to an appropriate value
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
Dim target As dsADS.EstablishmentDataTable = New dsADS.EstablishmentDataTable ' TODO: Initialize to an appropriate value
Dim expected As DataTable = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataTable
    actual = target.Clone
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for AddEstablishmentRow
'''</summary>
<TestMethod()>  _
Public Sub AddEstablishmentRowTest1()
Dim target As dsADS.EstablishmentDataTable = New dsADS.EstablishmentDataTable ' TODO: Initialize to an appropriate value
Dim row As dsADS.EstablishmentRow = Nothing ' TODO: Initialize to an appropriate value
    target.AddEstablishmentRow(row)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for AddEstablishmentRow
'''</summary>
<TestMethod()>  _
Public Sub AddEstablishmentRowTest()
Dim target As dsADS.EstablishmentDataTable = New dsADS.EstablishmentDataTable ' TODO: Initialize to an appropriate value
Dim SNAME As String = String.Empty ' TODO: Initialize to an appropriate value
Dim PERSALNR As String = String.Empty ' TODO: Initialize to an appropriate value
Dim SUR_INI As String = String.Empty ' TODO: Initialize to an appropriate value
Dim PROVDESC As String = String.Empty ' TODO: Initialize to an appropriate value
Dim DEPTDESC As String = String.Empty ' TODO: Initialize to an appropriate value
Dim RANKDESC As String = String.Empty ' TODO: Initialize to an appropriate value
Dim JOBTITLE As String = String.Empty ' TODO: Initialize to an appropriate value
Dim PAYDIST As String = String.Empty ' TODO: Initialize to an appropriate value
Dim PAYPOINT As String = String.Empty ' TODO: Initialize to an appropriate value
Dim APPTNAT As String = String.Empty ' TODO: Initialize to an appropriate value
Dim expected As dsADS.EstablishmentRow = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As dsADS.EstablishmentRow
    actual = target.AddEstablishmentRow(SNAME, PERSALNR, SUR_INI, PROVDESC, DEPTDESC, RANKDESC, JOBTITLE, PAYDIST, PAYPOINT, APPTNAT)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for EstablishmentDataTable Constructor
'''</summary>
<TestMethod()>  _
Public Sub dsADS_EstablishmentDataTableConstructorTest2()
    Dim target As dsADS.EstablishmentDataTable = New dsADS.EstablishmentDataTable
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub

'''<summary>
'''A test for EstablishmentDataTable Constructor
'''</summary>
<TestMethod()>  _
Public Sub dsADS_EstablishmentDataTableConstructorTest1()
Dim table As DataTable = Nothing ' TODO: Initialize to an appropriate value
    Dim target As dsADS.EstablishmentDataTable = New dsADS.EstablishmentDataTable(table)
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub

'''<summary>
'''A test for EstablishmentDataTable Constructor
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub dsADS_EstablishmentDataTableConstructorTest()
Dim info As SerializationInfo = Nothing ' TODO: Initialize to an appropriate value
Dim context As StreamingContext = New StreamingContext ' TODO: Initialize to an appropriate value
    Dim target As dsADS_Accessor.EstablishmentDataTable = New dsADS_Accessor.EstablishmentDataTable(info, context)
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub
End Class
