Imports System.Xml.Schema

Imports System

Imports System.Data

Imports System.Runtime.Serialization

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports ADAdminDotNet



'''<summary>
'''This is a test class for dsARSystemDataSet_CFOClosureListDataTableTest and is intended
'''to contain all dsARSystemDataSet_CFOClosureListDataTableTest Unit Tests
'''</summary>
<TestClass()> _
Public Class dsARSystemDataSet_CFOClosureListDataTableTest


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
'''A test for TITLEColumn
'''</summary>
<TestMethod()>  _
Public Sub TITLEColumnTest()
Dim target As dsARSystemDataSet.CFOClosureListDataTable = New dsARSystemDataSet.CFOClosureListDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.TITLEColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for SURNAMEColumn
'''</summary>
<TestMethod()>  _
Public Sub SURNAMEColumnTest()
Dim target As dsARSystemDataSet.CFOClosureListDataTable = New dsARSystemDataSet.CFOClosureListDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.SURNAMEColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for RESPONSIBILITYColumn
'''</summary>
<TestMethod()>  _
Public Sub RESPONSIBILITYColumnTest()
Dim target As dsARSystemDataSet.CFOClosureListDataTable = New dsARSystemDataSet.CFOClosureListDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.RESPONSIBILITYColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for REQ_LOGISColumn
'''</summary>
<TestMethod()>  _
Public Sub REQ_LOGISColumnTest()
Dim target As dsARSystemDataSet.CFOClosureListDataTable = New dsARSystemDataSet.CFOClosureListDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.REQ_LOGISColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for REQ_HRColumn
'''</summary>
<TestMethod()>  _
Public Sub REQ_HRColumnTest()
Dim target As dsARSystemDataSet.CFOClosureListDataTable = New dsARSystemDataSet.CFOClosureListDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.REQ_HRColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for REQ_FINANCIALSColumn
'''</summary>
<TestMethod()>  _
Public Sub REQ_FINANCIALSColumnTest()
Dim target As dsARSystemDataSet.CFOClosureListDataTable = New dsARSystemDataSet.CFOClosureListDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.REQ_FINANCIALSColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for RANKColumn
'''</summary>
<TestMethod()>  _
Public Sub RANKColumnTest()
Dim target As dsARSystemDataSet.CFOClosureListDataTable = New dsARSystemDataSet.CFOClosureListDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.RANKColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for NOTESColumn
'''</summary>
<TestMethod()>  _
Public Sub NOTESColumnTest()
Dim target As dsARSystemDataSet.CFOClosureListDataTable = New dsARSystemDataSet.CFOClosureListDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.NOTESColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Item
'''</summary>
<TestMethod()>  _
Public Sub ItemTest()
Dim target As dsARSystemDataSet.CFOClosureListDataTable = New dsARSystemDataSet.CFOClosureListDataTable ' TODO: Initialize to an appropriate value
Dim index As Integer = 0 ' TODO: Initialize to an appropriate value
    Dim actual As dsARSystemDataSet.CFOClosureListRow
    actual = target(index)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for FIRSTNAMEColumn
'''</summary>
<TestMethod()>  _
Public Sub FIRSTNAMEColumnTest()
Dim target As dsARSystemDataSet.CFOClosureListDataTable = New dsARSystemDataSet.CFOClosureListDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.FIRSTNAMEColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for FAX_TELColumn
'''</summary>
<TestMethod()>  _
Public Sub FAX_TELColumnTest()
Dim target As dsARSystemDataSet.CFOClosureListDataTable = New dsARSystemDataSet.CFOClosureListDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.FAX_TELColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for EMAILColumn
'''</summary>
<TestMethod()>  _
Public Sub EMAILColumnTest()
Dim target As dsARSystemDataSet.CFOClosureListDataTable = New dsARSystemDataSet.CFOClosureListDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.EMAILColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DONEColumn
'''</summary>
<TestMethod()>  _
Public Sub DONEColumnTest()
Dim target As dsARSystemDataSet.CFOClosureListDataTable = New dsARSystemDataSet.CFOClosureListDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.DONEColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DATETIMEColumn
'''</summary>
<TestMethod()>  _
Public Sub DATETIMEColumnTest()
Dim target As dsARSystemDataSet.CFOClosureListDataTable = New dsARSystemDataSet.CFOClosureListDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.DATETIMEColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for CREATEDColumn
'''</summary>
<TestMethod()>  _
Public Sub CREATEDColumnTest()
Dim target As dsARSystemDataSet.CFOClosureListDataTable = New dsARSystemDataSet.CFOClosureListDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.CREATEDColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Count
'''</summary>
<TestMethod()>  _
Public Sub CountTest()
Dim target As dsARSystemDataSet.CFOClosureListDataTable = New dsARSystemDataSet.CFOClosureListDataTable ' TODO: Initialize to an appropriate value
    Dim actual As Integer
    actual = target.Count
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for CLIENTNUMBERColumn
'''</summary>
<TestMethod()>  _
Public Sub CLIENTNUMBERColumnTest()
Dim target As dsARSystemDataSet.CFOClosureListDataTable = New dsARSystemDataSet.CFOClosureListDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.CLIENTNUMBERColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for CEL_TELColumn
'''</summary>
<TestMethod()>  _
Public Sub CEL_TELColumnTest()
Dim target As dsARSystemDataSet.CFOClosureListDataTable = New dsARSystemDataSet.CFOClosureListDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.CEL_TELColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for BUS_TELColumn
'''</summary>
<TestMethod()>  _
Public Sub BUS_TELColumnTest()
Dim target As dsARSystemDataSet.CFOClosureListDataTable = New dsARSystemDataSet.CFOClosureListDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.BUS_TELColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ACTIVITYColumn
'''</summary>
<TestMethod()>  _
Public Sub ACTIVITYColumnTest()
Dim target As dsARSystemDataSet.CFOClosureListDataTable = New dsARSystemDataSet.CFOClosureListDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.ACTIVITYColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for RemoveCFOClosureListRow
'''</summary>
<TestMethod()>  _
Public Sub RemoveCFOClosureListRowTest()
Dim target As dsARSystemDataSet.CFOClosureListDataTable = New dsARSystemDataSet.CFOClosureListDataTable ' TODO: Initialize to an appropriate value
Dim row As dsARSystemDataSet.CFOClosureListRow = Nothing ' TODO: Initialize to an appropriate value
    target.RemoveCFOClosureListRow(row)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for OnRowDeleting
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub OnRowDeletingTest()
Dim target As dsARSystemDataSet_Accessor.CFOClosureListDataTable = New dsARSystemDataSet_Accessor.CFOClosureListDataTable ' TODO: Initialize to an appropriate value
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
Dim target As dsARSystemDataSet_Accessor.CFOClosureListDataTable = New dsARSystemDataSet_Accessor.CFOClosureListDataTable ' TODO: Initialize to an appropriate value
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
Dim target As dsARSystemDataSet_Accessor.CFOClosureListDataTable = New dsARSystemDataSet_Accessor.CFOClosureListDataTable ' TODO: Initialize to an appropriate value
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
Dim target As dsARSystemDataSet_Accessor.CFOClosureListDataTable = New dsARSystemDataSet_Accessor.CFOClosureListDataTable ' TODO: Initialize to an appropriate value
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
Dim target As dsARSystemDataSet_Accessor.CFOClosureListDataTable = New dsARSystemDataSet_Accessor.CFOClosureListDataTable ' TODO: Initialize to an appropriate value
Dim builder As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim expected As DataRow = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataRow
    actual = target.NewRowFromBuilder(builder)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for NewCFOClosureListRow
'''</summary>
<TestMethod()>  _
Public Sub NewCFOClosureListRowTest()
Dim target As dsARSystemDataSet.CFOClosureListDataTable = New dsARSystemDataSet.CFOClosureListDataTable ' TODO: Initialize to an appropriate value
Dim expected As dsARSystemDataSet.CFOClosureListRow = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As dsARSystemDataSet.CFOClosureListRow
    actual = target.NewCFOClosureListRow
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for InitVars
'''</summary>
<TestMethod()>  _
Public Sub InitVarsTest()
Dim target As dsARSystemDataSet.CFOClosureListDataTable = New dsARSystemDataSet.CFOClosureListDataTable ' TODO: Initialize to an appropriate value
    target.InitVars
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for InitClass
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub InitClassTest()
Dim target As dsARSystemDataSet_Accessor.CFOClosureListDataTable = New dsARSystemDataSet_Accessor.CFOClosureListDataTable ' TODO: Initialize to an appropriate value
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
    actual = dsARSystemDataSet.CFOClosureListDataTable.GetTypedTableSchema(xs)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for GetRowType
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub GetRowTypeTest()
Dim target As dsARSystemDataSet_Accessor.CFOClosureListDataTable = New dsARSystemDataSet_Accessor.CFOClosureListDataTable ' TODO: Initialize to an appropriate value
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
Dim target As dsARSystemDataSet_Accessor.CFOClosureListDataTable = New dsARSystemDataSet_Accessor.CFOClosureListDataTable ' TODO: Initialize to an appropriate value
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
Dim target As dsARSystemDataSet.CFOClosureListDataTable = New dsARSystemDataSet.CFOClosureListDataTable ' TODO: Initialize to an appropriate value
Dim expected As DataTable = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataTable
    actual = target.Clone
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for CFOClosureListDataTable_CFOClosureListRowChanging
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub CFOClosureListDataTable_CFOClosureListRowChangingTest()
Dim target As dsARSystemDataSet_Accessor.CFOClosureListDataTable = New dsARSystemDataSet_Accessor.CFOClosureListDataTable ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As dsARSystemDataSet.CFOClosureListRowChangeEvent = Nothing ' TODO: Initialize to an appropriate value
    target.CFOClosureListDataTable_CFOClosureListRowChanging(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for AddCFOClosureListRow
'''</summary>
<TestMethod()>  _
Public Sub AddCFOClosureListRowTest1()
Dim target As dsARSystemDataSet.CFOClosureListDataTable = New dsARSystemDataSet.CFOClosureListDataTable ' TODO: Initialize to an appropriate value
Dim row As dsARSystemDataSet.CFOClosureListRow = Nothing ' TODO: Initialize to an appropriate value
    target.AddCFOClosureListRow(row)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for AddCFOClosureListRow
'''</summary>
<TestMethod()>  _
Public Sub AddCFOClosureListRowTest()
Dim target As dsARSystemDataSet.CFOClosureListDataTable = New dsARSystemDataSet.CFOClosureListDataTable ' TODO: Initialize to an appropriate value
Dim CLIENTNUMBER As String = String.Empty ' TODO: Initialize to an appropriate value
Dim TITLE As String = String.Empty ' TODO: Initialize to an appropriate value
Dim FIRSTNAME As String = String.Empty ' TODO: Initialize to an appropriate value
Dim SURNAME As String = String.Empty ' TODO: Initialize to an appropriate value
Dim RESPONSIBILITY As String = String.Empty ' TODO: Initialize to an appropriate value
Dim RANK As String = String.Empty ' TODO: Initialize to an appropriate value
Dim BUS_TEL As String = String.Empty ' TODO: Initialize to an appropriate value
Dim FAX_TEL As String = String.Empty ' TODO: Initialize to an appropriate value
Dim CEL_TEL As String = String.Empty ' TODO: Initialize to an appropriate value
Dim EMAIL As String = String.Empty ' TODO: Initialize to an appropriate value
Dim REQ_HR As Short = 0 ' TODO: Initialize to an appropriate value
Dim REQ_FINANCIALS As Short = 0 ' TODO: Initialize to an appropriate value
Dim REQ_LOGIS As Short = 0 ' TODO: Initialize to an appropriate value
Dim NOTES As String = String.Empty ' TODO: Initialize to an appropriate value
Dim DONE As Integer = 0 ' TODO: Initialize to an appropriate value
Dim CREATED As DateTime = New DateTime ' TODO: Initialize to an appropriate value
Dim DATETIME As DateTime = New DateTime ' TODO: Initialize to an appropriate value
Dim ACTIVITY As String = String.Empty ' TODO: Initialize to an appropriate value
Dim expected As dsARSystemDataSet.CFOClosureListRow = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As dsARSystemDataSet.CFOClosureListRow
    actual = target.AddCFOClosureListRow(CLIENTNUMBER, TITLE, FIRSTNAME, SURNAME, RESPONSIBILITY, RANK, BUS_TEL, FAX_TEL, CEL_TEL, EMAIL, REQ_HR, REQ_FINANCIALS, REQ_LOGIS, NOTES, DONE, CREATED, DATETIME, ACTIVITY)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for CFOClosureListDataTable Constructor
'''</summary>
<TestMethod()>  _
Public Sub dsARSystemDataSet_CFOClosureListDataTableConstructorTest2()
    Dim target As dsARSystemDataSet.CFOClosureListDataTable = New dsARSystemDataSet.CFOClosureListDataTable
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub

'''<summary>
'''A test for CFOClosureListDataTable Constructor
'''</summary>
<TestMethod()>  _
Public Sub dsARSystemDataSet_CFOClosureListDataTableConstructorTest1()
Dim table As DataTable = Nothing ' TODO: Initialize to an appropriate value
    Dim target As dsARSystemDataSet.CFOClosureListDataTable = New dsARSystemDataSet.CFOClosureListDataTable(table)
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub

'''<summary>
'''A test for CFOClosureListDataTable Constructor
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub dsARSystemDataSet_CFOClosureListDataTableConstructorTest()
Dim info As SerializationInfo = Nothing ' TODO: Initialize to an appropriate value
Dim context As StreamingContext = New StreamingContext ' TODO: Initialize to an appropriate value
    Dim target As dsARSystemDataSet_Accessor.CFOClosureListDataTable = New dsARSystemDataSet_Accessor.CFOClosureListDataTable(info, context)
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub
End Class
