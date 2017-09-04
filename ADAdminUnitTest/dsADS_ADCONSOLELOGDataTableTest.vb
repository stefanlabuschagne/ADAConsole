Imports System.Xml.Schema

Imports System

Imports System.Data

Imports System.Runtime.Serialization

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports ADAdminDotNet



'''<summary>
'''This is a test class for dsADS_ADCONSOLELOGDataTableTest and is intended
'''to contain all dsADS_ADCONSOLELOGDataTableTest Unit Tests
'''</summary>
<TestClass()> _
Public Class dsADS_ADCONSOLELOGDataTableTest


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
'''A test for USERNAMEColumn
'''</summary>
<TestMethod()>  _
Public Sub USERNAMEColumnTest()
Dim target As dsADS.ADCONSOLELOGDataTable = New dsADS.ADCONSOLELOGDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.USERNAMEColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Item
'''</summary>
<TestMethod()>  _
Public Sub ItemTest()
Dim target As dsADS.ADCONSOLELOGDataTable = New dsADS.ADCONSOLELOGDataTable ' TODO: Initialize to an appropriate value
Dim index As Integer = 0 ' TODO: Initialize to an appropriate value
    Dim actual As dsADS.ADCONSOLELOGRow
    actual = target(index)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DATETIMEColumn
'''</summary>
<TestMethod()>  _
Public Sub DATETIMEColumnTest()
Dim target As dsADS.ADCONSOLELOGDataTable = New dsADS.ADCONSOLELOGDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.DATETIMEColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Count
'''</summary>
<TestMethod()>  _
Public Sub CountTest()
Dim target As dsADS.ADCONSOLELOGDataTable = New dsADS.ADCONSOLELOGDataTable ' TODO: Initialize to an appropriate value
    Dim actual As Integer
    actual = target.Count
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ACTIVITYColumn
'''</summary>
<TestMethod()>  _
Public Sub ACTIVITYColumnTest()
Dim target As dsADS.ADCONSOLELOGDataTable = New dsADS.ADCONSOLELOGDataTable ' TODO: Initialize to an appropriate value
    Dim actual As DataColumn
    actual = target.ACTIVITYColumn
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for RemoveADCONSOLELOGRow
'''</summary>
<TestMethod()>  _
Public Sub RemoveADCONSOLELOGRowTest()
Dim target As dsADS.ADCONSOLELOGDataTable = New dsADS.ADCONSOLELOGDataTable ' TODO: Initialize to an appropriate value
Dim row As dsADS.ADCONSOLELOGRow = Nothing ' TODO: Initialize to an appropriate value
    target.RemoveADCONSOLELOGRow(row)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for OnRowDeleting
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub OnRowDeletingTest()
Dim target As dsADS_Accessor.ADCONSOLELOGDataTable = New dsADS_Accessor.ADCONSOLELOGDataTable ' TODO: Initialize to an appropriate value
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
Dim target As dsADS_Accessor.ADCONSOLELOGDataTable = New dsADS_Accessor.ADCONSOLELOGDataTable ' TODO: Initialize to an appropriate value
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
Dim target As dsADS_Accessor.ADCONSOLELOGDataTable = New dsADS_Accessor.ADCONSOLELOGDataTable ' TODO: Initialize to an appropriate value
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
Dim target As dsADS_Accessor.ADCONSOLELOGDataTable = New dsADS_Accessor.ADCONSOLELOGDataTable ' TODO: Initialize to an appropriate value
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
Dim target As dsADS_Accessor.ADCONSOLELOGDataTable = New dsADS_Accessor.ADCONSOLELOGDataTable ' TODO: Initialize to an appropriate value
Dim builder As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim expected As DataRow = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataRow
    actual = target.NewRowFromBuilder(builder)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for NewADCONSOLELOGRow
'''</summary>
<TestMethod()>  _
Public Sub NewADCONSOLELOGRowTest()
Dim target As dsADS.ADCONSOLELOGDataTable = New dsADS.ADCONSOLELOGDataTable ' TODO: Initialize to an appropriate value
Dim expected As dsADS.ADCONSOLELOGRow = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As dsADS.ADCONSOLELOGRow
    actual = target.NewADCONSOLELOGRow
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for InitVars
'''</summary>
<TestMethod()>  _
Public Sub InitVarsTest()
Dim target As dsADS.ADCONSOLELOGDataTable = New dsADS.ADCONSOLELOGDataTable ' TODO: Initialize to an appropriate value
    target.InitVars
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for InitClass
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub InitClassTest()
Dim target As dsADS_Accessor.ADCONSOLELOGDataTable = New dsADS_Accessor.ADCONSOLELOGDataTable ' TODO: Initialize to an appropriate value
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
    actual = dsADS.ADCONSOLELOGDataTable.GetTypedTableSchema(xs)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for GetRowType
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub GetRowTypeTest()
Dim target As dsADS_Accessor.ADCONSOLELOGDataTable = New dsADS_Accessor.ADCONSOLELOGDataTable ' TODO: Initialize to an appropriate value
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
Dim target As dsADS_Accessor.ADCONSOLELOGDataTable = New dsADS_Accessor.ADCONSOLELOGDataTable ' TODO: Initialize to an appropriate value
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
Dim target As dsADS.ADCONSOLELOGDataTable = New dsADS.ADCONSOLELOGDataTable ' TODO: Initialize to an appropriate value
Dim expected As DataTable = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataTable
    actual = target.Clone
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for AddADCONSOLELOGRow
'''</summary>
<TestMethod()>  _
Public Sub AddADCONSOLELOGRowTest1()
Dim target As dsADS.ADCONSOLELOGDataTable = New dsADS.ADCONSOLELOGDataTable ' TODO: Initialize to an appropriate value
Dim row As dsADS.ADCONSOLELOGRow = Nothing ' TODO: Initialize to an appropriate value
    target.AddADCONSOLELOGRow(row)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for AddADCONSOLELOGRow
'''</summary>
<TestMethod()>  _
Public Sub AddADCONSOLELOGRowTest()
Dim target As dsADS.ADCONSOLELOGDataTable = New dsADS.ADCONSOLELOGDataTable ' TODO: Initialize to an appropriate value
Dim DATETIME As DateTime = New DateTime ' TODO: Initialize to an appropriate value
Dim ACTIVITY As String = String.Empty ' TODO: Initialize to an appropriate value
Dim USERNAME As String = String.Empty ' TODO: Initialize to an appropriate value
Dim expected As dsADS.ADCONSOLELOGRow = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As dsADS.ADCONSOLELOGRow
    actual = target.AddADCONSOLELOGRow(DATETIME, ACTIVITY, USERNAME)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ADCONSOLELOGDataTable Constructor
'''</summary>
<TestMethod()>  _
Public Sub dsADS_ADCONSOLELOGDataTableConstructorTest2()
    Dim target As dsADS.ADCONSOLELOGDataTable = New dsADS.ADCONSOLELOGDataTable
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub

'''<summary>
'''A test for ADCONSOLELOGDataTable Constructor
'''</summary>
<TestMethod()>  _
Public Sub dsADS_ADCONSOLELOGDataTableConstructorTest1()
Dim table As DataTable = Nothing ' TODO: Initialize to an appropriate value
    Dim target As dsADS.ADCONSOLELOGDataTable = New dsADS.ADCONSOLELOGDataTable(table)
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub

'''<summary>
'''A test for ADCONSOLELOGDataTable Constructor
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub dsADS_ADCONSOLELOGDataTableConstructorTest()
Dim info As SerializationInfo = Nothing ' TODO: Initialize to an appropriate value
Dim context As StreamingContext = New StreamingContext ' TODO: Initialize to an appropriate value
    Dim target As dsADS_Accessor.ADCONSOLELOGDataTable = New dsADS_Accessor.ADCONSOLELOGDataTable(info, context)
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub
End Class
