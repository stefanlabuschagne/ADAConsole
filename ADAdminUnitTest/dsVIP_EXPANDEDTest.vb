Imports System.ComponentModel

Imports System.Xml

Imports System.Xml.Schema

Imports System.Data

Imports System.Runtime.Serialization

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports ADAdminDotNet



'''<summary>
'''This is a test class for dsVIP_EXPANDEDTest and is intended
'''to contain all dsVIP_EXPANDEDTest Unit Tests
'''</summary>
<TestClass()> _
Public Class dsVIP_EXPANDEDTest


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
'''A test for VIEW_GOVERNMENT_STRUCTURE
'''</summary>
<TestMethod()>  _
Public Sub VIEW_GOVERNMENT_STRUCTURETest()
Dim target As dsVIP_EXPANDED = New dsVIP_EXPANDED ' TODO: Initialize to an appropriate value
    Dim actual As dsVIP_EXPANDED.VIEW_GOVERNMENT_STRUCTUREDataTable
    actual = target.VIEW_GOVERNMENT_STRUCTURE
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for VIEW_departments
'''</summary>
<TestMethod()>  _
Public Sub VIEW_departmentsTest()
Dim target As dsVIP_EXPANDED = New dsVIP_EXPANDED ' TODO: Initialize to an appropriate value
    Dim actual As dsVIP_EXPANDED.VIEW_departmentsDataTable
    actual = target.VIEW_departments
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for VIEW_Assigned_Departments
'''</summary>
<TestMethod()>  _
Public Sub VIEW_Assigned_DepartmentsTest()
Dim target As dsVIP_EXPANDED = New dsVIP_EXPANDED ' TODO: Initialize to an appropriate value
    Dim actual As dsVIP_EXPANDED.VIEW_Assigned_DepartmentsDataTable
    actual = target.VIEW_Assigned_Departments
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for VIEW_APPLICATION_RIGHTS
'''</summary>
<TestMethod()>  _
Public Sub VIEW_APPLICATION_RIGHTSTest()
Dim target As dsVIP_EXPANDED = New dsVIP_EXPANDED ' TODO: Initialize to an appropriate value
    Dim actual As dsVIP_EXPANDED.VIEW_APPLICATION_RIGHTSDataTable
    actual = target.VIEW_APPLICATION_RIGHTS
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Tables
'''</summary>
<TestMethod()>  _
Public Sub TablesTest()
Dim target As dsVIP_EXPANDED = New dsVIP_EXPANDED ' TODO: Initialize to an appropriate value
    Dim actual As DataTableCollection
    actual = target.Tables
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for SchemaSerializationMode
'''</summary>
<TestMethod()>  _
Public Sub SchemaSerializationModeTest()
Dim target As dsVIP_EXPANDED = New dsVIP_EXPANDED ' TODO: Initialize to an appropriate value
Dim expected As SchemaSerializationMode = New SchemaSerializationMode ' TODO: Initialize to an appropriate value
    Dim actual As SchemaSerializationMode
    target.SchemaSerializationMode = expected
    actual = target.SchemaSerializationMode
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Relations
'''</summary>
<TestMethod()>  _
Public Sub RelationsTest()
Dim target As dsVIP_EXPANDED = New dsVIP_EXPANDED ' TODO: Initialize to an appropriate value
    Dim actual As DataRelationCollection
    actual = target.Relations
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for GetLastLoggedOnForPersalNumber
'''</summary>
<TestMethod()>  _
Public Sub GetLastLoggedOnForPersalNumberTest()
Dim target As dsVIP_EXPANDED = New dsVIP_EXPANDED ' TODO: Initialize to an appropriate value
    Dim actual As dsVIP_EXPANDED.GetLastLoggedOnForPersalNumberDataTable
    actual = target.GetLastLoggedOnForPersalNumber
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ShouldSerializeVIEW_GOVERNMENT_STRUCTURE
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ShouldSerializeVIEW_GOVERNMENT_STRUCTURETest()
Dim target As dsVIP_EXPANDED_Accessor = New dsVIP_EXPANDED_Accessor ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.ShouldSerializeVIEW_GOVERNMENT_STRUCTURE
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ShouldSerializeVIEW_departments
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ShouldSerializeVIEW_departmentsTest()
Dim target As dsVIP_EXPANDED_Accessor = New dsVIP_EXPANDED_Accessor ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.ShouldSerializeVIEW_departments
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ShouldSerializeVIEW_Assigned_Departments
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ShouldSerializeVIEW_Assigned_DepartmentsTest()
Dim target As dsVIP_EXPANDED_Accessor = New dsVIP_EXPANDED_Accessor ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.ShouldSerializeVIEW_Assigned_Departments
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ShouldSerializeVIEW_APPLICATION_RIGHTS
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ShouldSerializeVIEW_APPLICATION_RIGHTSTest()
Dim target As dsVIP_EXPANDED_Accessor = New dsVIP_EXPANDED_Accessor ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.ShouldSerializeVIEW_APPLICATION_RIGHTS
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ShouldSerializeTables
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ShouldSerializeTablesTest()
Dim target As dsVIP_EXPANDED_Accessor = New dsVIP_EXPANDED_Accessor ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.ShouldSerializeTables
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ShouldSerializeRelations
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ShouldSerializeRelationsTest()
Dim target As dsVIP_EXPANDED_Accessor = New dsVIP_EXPANDED_Accessor ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.ShouldSerializeRelations
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ShouldSerializeGetLastLoggedOnForPersalNumber
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ShouldSerializeGetLastLoggedOnForPersalNumberTest()
Dim target As dsVIP_EXPANDED_Accessor = New dsVIP_EXPANDED_Accessor ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.ShouldSerializeGetLastLoggedOnForPersalNumber
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for SchemaChanged
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub SchemaChangedTest()
Dim target As dsVIP_EXPANDED_Accessor = New dsVIP_EXPANDED_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As CollectionChangeEventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.SchemaChanged(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for ReadXmlSerializable
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ReadXmlSerializableTest()
Dim target As dsVIP_EXPANDED_Accessor = New dsVIP_EXPANDED_Accessor ' TODO: Initialize to an appropriate value
Dim reader As XmlReader = Nothing ' TODO: Initialize to an appropriate value
    target.ReadXmlSerializable(reader)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for InitVars
'''</summary>
<TestMethod()>  _
Public Sub InitVarsTest1()
Dim target As dsVIP_EXPANDED = New dsVIP_EXPANDED ' TODO: Initialize to an appropriate value
    target.InitVars
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for InitVars
'''</summary>
<TestMethod()>  _
Public Sub InitVarsTest()
Dim target As dsVIP_EXPANDED = New dsVIP_EXPANDED ' TODO: Initialize to an appropriate value
Dim initTable As Boolean = false ' TODO: Initialize to an appropriate value
    target.InitVars(initTable)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for InitializeDerivedDataSet
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub InitializeDerivedDataSetTest()
Dim target As dsVIP_EXPANDED_Accessor = New dsVIP_EXPANDED_Accessor ' TODO: Initialize to an appropriate value
    target.InitializeDerivedDataSet
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for InitClass
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub InitClassTest()
Dim target As dsVIP_EXPANDED_Accessor = New dsVIP_EXPANDED_Accessor ' TODO: Initialize to an appropriate value
    target.InitClass
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for GetTypedDataSetSchema
'''</summary>
<TestMethod()>  _
Public Sub GetTypedDataSetSchemaTest()
Dim xs As XmlSchemaSet = Nothing ' TODO: Initialize to an appropriate value
Dim expected As XmlSchemaComplexType = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As XmlSchemaComplexType
    actual = dsVIP_EXPANDED.GetTypedDataSetSchema(xs)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for GetSchemaSerializable
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub GetSchemaSerializableTest()
Dim target As dsVIP_EXPANDED_Accessor = New dsVIP_EXPANDED_Accessor ' TODO: Initialize to an appropriate value
Dim expected As XmlSchema = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As XmlSchema
    actual = target.GetSchemaSerializable
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Clone
'''</summary>
<TestMethod()>  _
Public Sub CloneTest()
Dim target As dsVIP_EXPANDED = New dsVIP_EXPANDED ' TODO: Initialize to an appropriate value
Dim expected As DataSet = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataSet
    actual = target.Clone
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for dsVIP_EXPANDED Constructor
'''</summary>
<TestMethod()>  _
Public Sub dsVIP_EXPANDEDConstructorTest1()
    Dim target As dsVIP_EXPANDED = New dsVIP_EXPANDED
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub

'''<summary>
'''A test for dsVIP_EXPANDED Constructor
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub dsVIP_EXPANDEDConstructorTest()
Dim info As SerializationInfo = Nothing ' TODO: Initialize to an appropriate value
Dim context As StreamingContext = New StreamingContext ' TODO: Initialize to an appropriate value
    Dim target As dsVIP_EXPANDED_Accessor = New dsVIP_EXPANDED_Accessor(info, context)
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub
End Class
