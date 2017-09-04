Imports System.ComponentModel

Imports System.Xml

Imports System.Xml.Schema

Imports System.Data

Imports System.Runtime.Serialization

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports ADAdminDotNet



'''<summary>
'''This is a test class for dsARSystemDataSetTest and is intended
'''to contain all dsARSystemDataSetTest Unit Tests
'''</summary>
<TestClass()> _
Public Class dsARSystemDataSetTest


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
'''A test for VIEW_CFO_RULES_FLAGS_OUTSTANDING
'''</summary>
<TestMethod()>  _
Public Sub VIEW_CFO_RULES_FLAGS_OUTSTANDINGTest()
Dim target As dsARSystemDataSet = New dsARSystemDataSet ' TODO: Initialize to an appropriate value
    Dim actual As dsARSystemDataSet.VIEW_CFO_RULES_FLAGS_OUTSTANDINGDataTable
    actual = target.VIEW_CFO_RULES_FLAGS_OUTSTANDING
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Tables
'''</summary>
<TestMethod()>  _
Public Sub TablesTest()
Dim target As dsARSystemDataSet = New dsARSystemDataSet ' TODO: Initialize to an appropriate value
    Dim actual As DataTableCollection
    actual = target.Tables
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for SurnamesByPortion
'''</summary>
<TestMethod()>  _
Public Sub SurnamesByPortionTest()
Dim target As dsARSystemDataSet = New dsARSystemDataSet ' TODO: Initialize to an appropriate value
    Dim actual As dsARSystemDataSet.SurnamesByPortionDataTable
    actual = target.SurnamesByPortion
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for SchemaSerializationMode
'''</summary>
<TestMethod()>  _
Public Sub SchemaSerializationModeTest()
Dim target As dsARSystemDataSet = New dsARSystemDataSet ' TODO: Initialize to an appropriate value
Dim expected As SchemaSerializationMode = New SchemaSerializationMode ' TODO: Initialize to an appropriate value
    Dim actual As SchemaSerializationMode
    target.SchemaSerializationMode = expected
    actual = target.SchemaSerializationMode
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for RemedyUsersByFirstLetter
'''</summary>
<TestMethod()>  _
Public Sub RemedyUsersByFirstLetterTest()
Dim target As dsARSystemDataSet = New dsARSystemDataSet ' TODO: Initialize to an appropriate value
    Dim actual As dsARSystemDataSet.RemedyUsersByFirstLetterDataTable
    actual = target.RemedyUsersByFirstLetter
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for RemedyOpenRequests
'''</summary>
<TestMethod()>  _
Public Sub RemedyOpenRequestsTest()
Dim target As dsARSystemDataSet = New dsARSystemDataSet ' TODO: Initialize to an appropriate value
    Dim actual As dsARSystemDataSet.RemedyOpenRequestsDataTable
    actual = target.RemedyOpenRequests
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for RemedyByFirstLetterOfSurname
'''</summary>
<TestMethod()>  _
Public Sub RemedyByFirstLetterOfSurnameTest()
Dim target As dsARSystemDataSet = New dsARSystemDataSet ' TODO: Initialize to an appropriate value
    Dim actual As dsARSystemDataSet.RemedyByFirstLetterOfSurnameDataTable
    actual = target.RemedyByFirstLetterOfSurname
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Relations
'''</summary>
<TestMethod()>  _
Public Sub RelationsTest()
Dim target As dsARSystemDataSet = New dsARSystemDataSet ' TODO: Initialize to an appropriate value
    Dim actual As DataRelationCollection
    actual = target.Relations
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for LOG_IN_Request_Tracking
'''</summary>
<TestMethod()>  _
Public Sub LOG_IN_Request_TrackingTest()
Dim target As dsARSystemDataSet = New dsARSystemDataSet ' TODO: Initialize to an appropriate value
    Dim actual As dsARSystemDataSet.LOG_IN_Request_TrackingDataTable
    actual = target.LOG_IN_Request_Tracking
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for LOG_DM_Personnel
'''</summary>
<TestMethod()>  _
Public Sub LOG_DM_PersonnelTest()
Dim target As dsARSystemDataSet = New dsARSystemDataSet ' TODO: Initialize to an appropriate value
    Dim actual As dsARSystemDataSet.LOG_DM_PersonnelDataTable
    actual = target.LOG_DM_Personnel
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for LOG_DM_Department
'''</summary>
<TestMethod()>  _
Public Sub LOG_DM_DepartmentTest()
Dim target As dsARSystemDataSet = New dsARSystemDataSet ' TODO: Initialize to an appropriate value
    Dim actual As dsARSystemDataSet.LOG_DM_DepartmentDataTable
    actual = target.LOG_DM_Department
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for LOG_DM_Customer_Information1
'''</summary>
<TestMethod()>  _
Public Sub LOG_DM_Customer_Information1Test()
Dim target As dsARSystemDataSet = New dsARSystemDataSet ' TODO: Initialize to an appropriate value
    Dim actual As dsARSystemDataSet.LOG_DM_Customer_Information1DataTable
    actual = target.LOG_DM_Customer_Information1
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for LOG_DM_Customer_Information
'''</summary>
<TestMethod()>  _
Public Sub LOG_DM_Customer_InformationTest()
Dim target As dsARSystemDataSet = New dsARSystemDataSet ' TODO: Initialize to an appropriate value
    Dim actual As dsARSystemDataSet.LOG_DM_Customer_InformationDataTable
    actual = target.LOG_DM_Customer_Information
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for CustNotify
'''</summary>
<TestMethod()>  _
Public Sub CustNotifyTest()
Dim target As dsARSystemDataSet = New dsARSystemDataSet ' TODO: Initialize to an appropriate value
    Dim actual As dsARSystemDataSet.CustNotifyDataTable
    actual = target.CustNotify
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for CFOClosureList
'''</summary>
<TestMethod()>  _
Public Sub CFOClosureListTest()
Dim target As dsARSystemDataSet = New dsARSystemDataSet ' TODO: Initialize to an appropriate value
    Dim actual As dsARSystemDataSet.CFOClosureListDataTable
    actual = target.CFOClosureList
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ShouldSerializeVIEW_CFO_RULES_FLAGS_OUTSTANDING
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ShouldSerializeVIEW_CFO_RULES_FLAGS_OUTSTANDINGTest()
Dim target As dsARSystemDataSet_Accessor = New dsARSystemDataSet_Accessor ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.ShouldSerializeVIEW_CFO_RULES_FLAGS_OUTSTANDING
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ShouldSerializeTables
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ShouldSerializeTablesTest()
Dim target As dsARSystemDataSet_Accessor = New dsARSystemDataSet_Accessor ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.ShouldSerializeTables
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ShouldSerializeSurnamesByPortion
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ShouldSerializeSurnamesByPortionTest()
Dim target As dsARSystemDataSet_Accessor = New dsARSystemDataSet_Accessor ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.ShouldSerializeSurnamesByPortion
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ShouldSerializeRemedyUsersByFirstLetter
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ShouldSerializeRemedyUsersByFirstLetterTest()
Dim target As dsARSystemDataSet_Accessor = New dsARSystemDataSet_Accessor ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.ShouldSerializeRemedyUsersByFirstLetter
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ShouldSerializeRemedyOpenRequests
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ShouldSerializeRemedyOpenRequestsTest()
Dim target As dsARSystemDataSet_Accessor = New dsARSystemDataSet_Accessor ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.ShouldSerializeRemedyOpenRequests
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ShouldSerializeRemedyByFirstLetterOfSurname
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ShouldSerializeRemedyByFirstLetterOfSurnameTest()
Dim target As dsARSystemDataSet_Accessor = New dsARSystemDataSet_Accessor ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.ShouldSerializeRemedyByFirstLetterOfSurname
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ShouldSerializeRelations
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ShouldSerializeRelationsTest()
Dim target As dsARSystemDataSet_Accessor = New dsARSystemDataSet_Accessor ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.ShouldSerializeRelations
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ShouldSerializeLOG_IN_Request_Tracking
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ShouldSerializeLOG_IN_Request_TrackingTest()
Dim target As dsARSystemDataSet_Accessor = New dsARSystemDataSet_Accessor ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.ShouldSerializeLOG_IN_Request_Tracking
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ShouldSerializeLOG_DM_Personnel
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ShouldSerializeLOG_DM_PersonnelTest()
Dim target As dsARSystemDataSet_Accessor = New dsARSystemDataSet_Accessor ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.ShouldSerializeLOG_DM_Personnel
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ShouldSerializeLOG_DM_Department
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ShouldSerializeLOG_DM_DepartmentTest()
Dim target As dsARSystemDataSet_Accessor = New dsARSystemDataSet_Accessor ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.ShouldSerializeLOG_DM_Department
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ShouldSerializeLOG_DM_Customer_Information1
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ShouldSerializeLOG_DM_Customer_Information1Test()
Dim target As dsARSystemDataSet_Accessor = New dsARSystemDataSet_Accessor ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.ShouldSerializeLOG_DM_Customer_Information1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ShouldSerializeLOG_DM_Customer_Information
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ShouldSerializeLOG_DM_Customer_InformationTest()
Dim target As dsARSystemDataSet_Accessor = New dsARSystemDataSet_Accessor ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.ShouldSerializeLOG_DM_Customer_Information
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ShouldSerializeCustNotify
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ShouldSerializeCustNotifyTest()
Dim target As dsARSystemDataSet_Accessor = New dsARSystemDataSet_Accessor ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.ShouldSerializeCustNotify
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ShouldSerializeCFOClosureList
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ShouldSerializeCFOClosureListTest()
Dim target As dsARSystemDataSet_Accessor = New dsARSystemDataSet_Accessor ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.ShouldSerializeCFOClosureList
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for SchemaChanged
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub SchemaChangedTest()
Dim target As dsARSystemDataSet_Accessor = New dsARSystemDataSet_Accessor ' TODO: Initialize to an appropriate value
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
Dim target As dsARSystemDataSet_Accessor = New dsARSystemDataSet_Accessor ' TODO: Initialize to an appropriate value
Dim reader As XmlReader = Nothing ' TODO: Initialize to an appropriate value
    target.ReadXmlSerializable(reader)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for InitVars
'''</summary>
<TestMethod()>  _
Public Sub InitVarsTest1()
Dim target As dsARSystemDataSet = New dsARSystemDataSet ' TODO: Initialize to an appropriate value
    target.InitVars
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for InitVars
'''</summary>
<TestMethod()>  _
Public Sub InitVarsTest()
Dim target As dsARSystemDataSet = New dsARSystemDataSet ' TODO: Initialize to an appropriate value
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
Dim target As dsARSystemDataSet_Accessor = New dsARSystemDataSet_Accessor ' TODO: Initialize to an appropriate value
    target.InitializeDerivedDataSet
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for InitClass
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub InitClassTest()
Dim target As dsARSystemDataSet_Accessor = New dsARSystemDataSet_Accessor ' TODO: Initialize to an appropriate value
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
    actual = dsARSystemDataSet.GetTypedDataSetSchema(xs)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for GetSchemaSerializable
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub GetSchemaSerializableTest()
Dim target As dsARSystemDataSet_Accessor = New dsARSystemDataSet_Accessor ' TODO: Initialize to an appropriate value
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
Dim target As dsARSystemDataSet = New dsARSystemDataSet ' TODO: Initialize to an appropriate value
Dim expected As DataSet = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataSet
    actual = target.Clone
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for dsARSystemDataSet Constructor
'''</summary>
<TestMethod()>  _
Public Sub dsARSystemDataSetConstructorTest1()
    Dim target As dsARSystemDataSet = New dsARSystemDataSet
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub

'''<summary>
'''A test for dsARSystemDataSet Constructor
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub dsARSystemDataSetConstructorTest()
Dim info As SerializationInfo = Nothing ' TODO: Initialize to an appropriate value
Dim context As StreamingContext = New StreamingContext ' TODO: Initialize to an appropriate value
    Dim target As dsARSystemDataSet_Accessor = New dsARSystemDataSet_Accessor(info, context)
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub
End Class
