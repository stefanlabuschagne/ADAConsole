Imports System.ComponentModel

Imports System.Xml

Imports System.Xml.Schema

Imports System.Data

Imports System.Runtime.Serialization

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports ADAdminDotNet



'''<summary>
'''This is a test class for dsADSTest and is intended
'''to contain all dsADSTest Unit Tests
'''</summary>
<TestClass()> _
Public Class dsADSTest


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
'''A test for Vulindlela_Email
'''</summary>
<TestMethod()>  _
Public Sub Vulindlela_EmailTest()
Dim target As dsADS = New dsADS ' TODO: Initialize to an appropriate value
    Dim actual As dsADS.Vulindlela_EmailDataTable
    actual = target.Vulindlela_Email
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Vulindlela_Controllers
'''</summary>
<TestMethod()>  _
Public Sub Vulindlela_ControllersTest()
Dim target As dsADS = New dsADS ' TODO: Initialize to an appropriate value
    Dim actual As dsADS.Vulindlela_ControllersDataTable
    actual = target.Vulindlela_Controllers
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for VPN_Admins
'''</summary>
<TestMethod()>  _
Public Sub VPN_AdminsTest()
Dim target As dsADS = New dsADS ' TODO: Initialize to an appropriate value
    Dim actual As dsADS.VPN_AdminsDataTable
    actual = target.VPN_Admins
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for VPN_Admin_Categories
'''</summary>
<TestMethod()>  _
Public Sub VPN_Admin_CategoriesTest()
Dim target As dsADS = New dsADS ' TODO: Initialize to an appropriate value
    Dim actual As dsADS.VPN_Admin_CategoriesDataTable
    actual = target.VPN_Admin_Categories
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for VIP_USERS1
'''</summary>
<TestMethod()>  _
Public Sub VIP_USERS1Test()
Dim target As dsADS = New dsADS ' TODO: Initialize to an appropriate value
    Dim actual As dsADS.VIP_USERS1DataTable
    actual = target.VIP_USERS1
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for VIP_USERS_ResetPassword
'''</summary>
<TestMethod()>  _
Public Sub VIP_USERS_ResetPasswordTest()
Dim target As dsADS = New dsADS ' TODO: Initialize to an appropriate value
    Dim actual As dsADS.VIP_USERS_ResetPasswordDataTable
    actual = target.VIP_USERS_ResetPassword
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for VIP_USERS_NewUsers
'''</summary>
<TestMethod()>  _
Public Sub VIP_USERS_NewUsersTest()
Dim target As dsADS = New dsADS ' TODO: Initialize to an appropriate value
    Dim actual As dsADS.VIP_USERS_NewUsersDataTable
    actual = target.VIP_USERS_NewUsers
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for VIP_USERS
'''</summary>
<TestMethod()>  _
Public Sub VIP_USERSTest()
Dim target As dsADS = New dsADS ' TODO: Initialize to an appropriate value
    Dim actual As dsADS.VIP_USERSDataTable
    actual = target.VIP_USERS
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ViewJJ_Max_User_COunt
'''</summary>
<TestMethod()>  _
Public Sub ViewJJ_Max_User_COuntTest()
Dim target As dsADS = New dsADS ' TODO: Initialize to an appropriate value
    Dim actual As dsADS.ViewJJ_Max_User_COuntDataTable
    actual = target.ViewJJ_Max_User_COunt
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for VIEW_CFO_APPPLICATION_TOOK_TO_LONG
'''</summary>
<TestMethod()>  _
Public Sub VIEW_CFO_APPPLICATION_TOOK_TO_LONGTest()
Dim target As dsADS = New dsADS ' TODO: Initialize to an appropriate value
    Dim actual As dsADS.VIEW_CFO_APPPLICATION_TOOK_TO_LONGDataTable
    actual = target.VIEW_CFO_APPPLICATION_TOOK_TO_LONG
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Tables
'''</summary>
<TestMethod()>  _
Public Sub TablesTest()
Dim target As dsADS = New dsADS ' TODO: Initialize to an appropriate value
    Dim actual As DataTableCollection
    actual = target.Tables
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for SchemaSerializationMode
'''</summary>
<TestMethod()>  _
Public Sub SchemaSerializationModeTest()
Dim target As dsADS = New dsADS ' TODO: Initialize to an appropriate value
Dim expected As SchemaSerializationMode = New SchemaSerializationMode ' TODO: Initialize to an appropriate value
    Dim actual As SchemaSerializationMode
    target.SchemaSerializationMode = expected
    actual = target.SchemaSerializationMode
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for RULES_FLOWSEQUENCE
'''</summary>
<TestMethod()>  _
Public Sub RULES_FLOWSEQUENCETest()
Dim target As dsADS = New dsADS ' TODO: Initialize to an appropriate value
    Dim actual As dsADS.RULES_FLOWSEQUENCEDataTable
    actual = target.RULES_FLOWSEQUENCE
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for RULES_FLAGS2
'''</summary>
<TestMethod()>  _
Public Sub RULES_FLAGS2Test()
Dim target As dsADS = New dsADS ' TODO: Initialize to an appropriate value
    Dim actual As dsADS.RULES_FLAGS2DataTable
    actual = target.RULES_FLAGS2
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for RULES_FLAGS1
'''</summary>
<TestMethod()>  _
Public Sub RULES_FLAGS1Test()
Dim target As dsADS = New dsADS ' TODO: Initialize to an appropriate value
    Dim actual As dsADS.RULES_FLAGS1DataTable
    actual = target.RULES_FLAGS1
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for RULES_FLAGS_VALID
'''</summary>
<TestMethod()>  _
Public Sub RULES_FLAGS_VALIDTest()
Dim target As dsADS = New dsADS ' TODO: Initialize to an appropriate value
    Dim actual As dsADS.RULES_FLAGS_VALIDDataTable
    actual = target.RULES_FLAGS_VALID
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for RULES_FLAGS
'''</summary>
<TestMethod()>  _
Public Sub RULES_FLAGSTest()
Dim target As dsADS = New dsADS ' TODO: Initialize to an appropriate value
    Dim actual As dsADS.RULES_FLAGSDataTable
    actual = target.RULES_FLAGS
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Relations
'''</summary>
<TestMethod()>  _
Public Sub RelationsTest()
Dim target As dsADS = New dsADS ' TODO: Initialize to an appropriate value
    Dim actual As DataRelationCollection
    actual = target.Relations
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Not_On_Estab_Thismonth_Count
'''</summary>
<TestMethod()>  _
Public Sub Not_On_Estab_Thismonth_CountTest()
Dim target As dsADS = New dsADS ' TODO: Initialize to an appropriate value
    Dim actual As dsADS.Not_On_Estab_Thismonth_CountDataTable
    actual = target.Not_On_Estab_Thismonth_Count
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for KICKOUT
'''</summary>
<TestMethod()>  _
Public Sub KICKOUTTest()
Dim target As dsADS = New dsADS ' TODO: Initialize to an appropriate value
    Dim actual As dsADS.KICKOUTDataTable
    actual = target.KICKOUT
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for GetResetPasswords
'''</summary>
<TestMethod()>  _
Public Sub GetResetPasswordsTest()
Dim target As dsADS = New dsADS ' TODO: Initialize to an appropriate value
    Dim actual As dsADS.GetResetPasswordsDataTable
    actual = target.GetResetPasswords
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for get_shortcode
'''</summary>
<TestMethod()>  _
Public Sub get_shortcodeTest()
Dim target As dsADS = New dsADS ' TODO: Initialize to an appropriate value
    Dim actual As dsADS.get_shortcodeDataTable
    actual = target.get_shortcode
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for EXCLUSIONS
'''</summary>
<TestMethod()>  _
Public Sub EXCLUSIONSTest()
Dim target As dsADS = New dsADS ' TODO: Initialize to an appropriate value
    Dim actual As dsADS.EXCLUSIONSDataTable
    actual = target.EXCLUSIONS
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Establishment
'''</summary>
<TestMethod()>  _
Public Sub EstablishmentTest()
Dim target As dsADS = New dsADS ' TODO: Initialize to an appropriate value
    Dim actual As dsADS.EstablishmentDataTable
    actual = target.Establishment
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Estab2
'''</summary>
<TestMethod()>  _
Public Sub Estab2Test()
Dim target As dsADS = New dsADS ' TODO: Initialize to an appropriate value
    Dim actual As dsADS.Estab2DataTable
    actual = target.Estab2
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Department_Differs
'''</summary>
<TestMethod()>  _
Public Sub Department_DiffersTest()
Dim target As dsADS = New dsADS ' TODO: Initialize to an appropriate value
    Dim actual As dsADS.Department_DiffersDataTable
    actual = target.Department_Differs
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for CustomerInfo
'''</summary>
<TestMethod()>  _
Public Sub CustomerInfoTest()
Dim target As dsADS = New dsADS ' TODO: Initialize to an appropriate value
    Dim actual As dsADS.CustomerInfoDataTable
    actual = target.CustomerInfo
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for CountNewUsers
'''</summary>
<TestMethod()>  _
Public Sub CountNewUsersTest()
Dim target As dsADS = New dsADS ' TODO: Initialize to an appropriate value
    Dim actual As dsADS.CountNewUsersDataTable
    actual = target.CountNewUsers
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Config_Problem
'''</summary>
<TestMethod()>  _
Public Sub Config_ProblemTest()
Dim target As dsADS = New dsADS ' TODO: Initialize to an appropriate value
    Dim actual As dsADS.Config_ProblemDataTable
    actual = target.Config_Problem
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for CFOList
'''</summary>
<TestMethod()>  _
Public Sub CFOListTest()
Dim target As dsADS = New dsADS ' TODO: Initialize to an appropriate value
    Dim actual As dsADS.CFOListDataTable
    actual = target.CFOList
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for CFOApproval
'''</summary>
<TestMethod()>  _
Public Sub CFOApprovalTest()
Dim target As dsADS = New dsADS ' TODO: Initialize to an appropriate value
    Dim actual As dsADS.CFOApprovalDataTable
    actual = target.CFOApproval
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for CFO_Letters_YearMonth
'''</summary>
<TestMethod()>  _
Public Sub CFO_Letters_YearMonthTest()
Dim target As dsADS = New dsADS ' TODO: Initialize to an appropriate value
    Dim actual As dsADS.CFO_Letters_YearMonthDataTable
    actual = target.CFO_Letters_YearMonth
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for CFO
'''</summary>
<TestMethod()>  _
Public Sub CFOTest()
Dim target As dsADS = New dsADS ' TODO: Initialize to an appropriate value
    Dim actual As dsADS.CFODataTable
    actual = target.CFO
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ADCONSOLELOG
'''</summary>
<TestMethod()>  _
Public Sub ADCONSOLELOGTest()
Dim target As dsADS = New dsADS ' TODO: Initialize to an appropriate value
    Dim actual As dsADS.ADCONSOLELOGDataTable
    actual = target.ADCONSOLELOG
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for AD_SNAPSHOT_USER_COUNT
'''</summary>
<TestMethod()>  _
Public Sub AD_SNAPSHOT_USER_COUNTTest()
Dim target As dsADS = New dsADS ' TODO: Initialize to an appropriate value
    Dim actual As dsADS.AD_SNAPSHOT_USER_COUNTDataTable
    actual = target.AD_SNAPSHOT_USER_COUNT
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for AD_SNAPSHOT_EXCEPTIONS
'''</summary>
<TestMethod()>  _
Public Sub AD_SNAPSHOT_EXCEPTIONSTest()
Dim target As dsADS = New dsADS ' TODO: Initialize to an appropriate value
    Dim actual As dsADS.AD_SNAPSHOT_EXCEPTIONSDataTable
    actual = target.AD_SNAPSHOT_EXCEPTIONS
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for AD_SNAPSHOT_ALL
'''</summary>
<TestMethod()>  _
Public Sub AD_SNAPSHOT_ALLTest()
Dim target As dsADS = New dsADS ' TODO: Initialize to an appropriate value
    Dim actual As dsADS.AD_SNAPSHOT_ALLDataTable
    actual = target.AD_SNAPSHOT_ALL
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for AD_Disabled_Users
'''</summary>
<TestMethod()>  _
Public Sub AD_Disabled_UsersTest()
Dim target As dsADS = New dsADS ' TODO: Initialize to an appropriate value
    Dim actual As dsADS.AD_Disabled_UsersDataTable
    actual = target.AD_Disabled_Users
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ShouldSerializeVulindlela_Email
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ShouldSerializeVulindlela_EmailTest()
Dim target As dsADS_Accessor = New dsADS_Accessor ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.ShouldSerializeVulindlela_Email
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ShouldSerializeVulindlela_Controllers
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ShouldSerializeVulindlela_ControllersTest()
Dim target As dsADS_Accessor = New dsADS_Accessor ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.ShouldSerializeVulindlela_Controllers
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ShouldSerializeVPN_Admins
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ShouldSerializeVPN_AdminsTest()
Dim target As dsADS_Accessor = New dsADS_Accessor ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.ShouldSerializeVPN_Admins
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ShouldSerializeVPN_Admin_Categories
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ShouldSerializeVPN_Admin_CategoriesTest()
Dim target As dsADS_Accessor = New dsADS_Accessor ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.ShouldSerializeVPN_Admin_Categories
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ShouldSerializeVIP_USERS1
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ShouldSerializeVIP_USERS1Test()
Dim target As dsADS_Accessor = New dsADS_Accessor ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.ShouldSerializeVIP_USERS1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ShouldSerializeVIP_USERS_ResetPassword
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ShouldSerializeVIP_USERS_ResetPasswordTest()
Dim target As dsADS_Accessor = New dsADS_Accessor ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.ShouldSerializeVIP_USERS_ResetPassword
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ShouldSerializeVIP_USERS_NewUsers
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ShouldSerializeVIP_USERS_NewUsersTest()
Dim target As dsADS_Accessor = New dsADS_Accessor ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.ShouldSerializeVIP_USERS_NewUsers
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ShouldSerializeVIP_USERS
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ShouldSerializeVIP_USERSTest()
Dim target As dsADS_Accessor = New dsADS_Accessor ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.ShouldSerializeVIP_USERS
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ShouldSerializeViewJJ_Max_User_COunt
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ShouldSerializeViewJJ_Max_User_COuntTest()
Dim target As dsADS_Accessor = New dsADS_Accessor ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.ShouldSerializeViewJJ_Max_User_COunt
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ShouldSerializeVIEW_CFO_APPPLICATION_TOOK_TO_LONG
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ShouldSerializeVIEW_CFO_APPPLICATION_TOOK_TO_LONGTest()
Dim target As dsADS_Accessor = New dsADS_Accessor ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.ShouldSerializeVIEW_CFO_APPPLICATION_TOOK_TO_LONG
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ShouldSerializeTables
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ShouldSerializeTablesTest()
Dim target As dsADS_Accessor = New dsADS_Accessor ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.ShouldSerializeTables
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ShouldSerializeRULES_FLOWSEQUENCE
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ShouldSerializeRULES_FLOWSEQUENCETest()
Dim target As dsADS_Accessor = New dsADS_Accessor ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.ShouldSerializeRULES_FLOWSEQUENCE
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ShouldSerializeRULES_FLAGS2
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ShouldSerializeRULES_FLAGS2Test()
Dim target As dsADS_Accessor = New dsADS_Accessor ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.ShouldSerializeRULES_FLAGS2
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ShouldSerializeRULES_FLAGS1
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ShouldSerializeRULES_FLAGS1Test()
Dim target As dsADS_Accessor = New dsADS_Accessor ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.ShouldSerializeRULES_FLAGS1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ShouldSerializeRULES_FLAGS_VALID
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ShouldSerializeRULES_FLAGS_VALIDTest()
Dim target As dsADS_Accessor = New dsADS_Accessor ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.ShouldSerializeRULES_FLAGS_VALID
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ShouldSerializeRULES_FLAGS
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ShouldSerializeRULES_FLAGSTest()
Dim target As dsADS_Accessor = New dsADS_Accessor ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.ShouldSerializeRULES_FLAGS
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ShouldSerializeRelations
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ShouldSerializeRelationsTest()
Dim target As dsADS_Accessor = New dsADS_Accessor ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.ShouldSerializeRelations
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ShouldSerializeNot_On_Estab_Thismonth_Count
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ShouldSerializeNot_On_Estab_Thismonth_CountTest()
Dim target As dsADS_Accessor = New dsADS_Accessor ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.ShouldSerializeNot_On_Estab_Thismonth_Count
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ShouldSerializeKICKOUT
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ShouldSerializeKICKOUTTest()
Dim target As dsADS_Accessor = New dsADS_Accessor ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.ShouldSerializeKICKOUT
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ShouldSerializeGetResetPasswords
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ShouldSerializeGetResetPasswordsTest()
Dim target As dsADS_Accessor = New dsADS_Accessor ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.ShouldSerializeGetResetPasswords
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ShouldSerializeget_shortcode
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ShouldSerializeget_shortcodeTest()
Dim target As dsADS_Accessor = New dsADS_Accessor ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.ShouldSerializeget_shortcode
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ShouldSerializeEXCLUSIONS
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ShouldSerializeEXCLUSIONSTest()
Dim target As dsADS_Accessor = New dsADS_Accessor ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.ShouldSerializeEXCLUSIONS
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ShouldSerializeEstablishment
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ShouldSerializeEstablishmentTest()
Dim target As dsADS_Accessor = New dsADS_Accessor ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.ShouldSerializeEstablishment
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ShouldSerializeEstab2
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ShouldSerializeEstab2Test()
Dim target As dsADS_Accessor = New dsADS_Accessor ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.ShouldSerializeEstab2
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ShouldSerializeDepartment_Differs
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ShouldSerializeDepartment_DiffersTest()
Dim target As dsADS_Accessor = New dsADS_Accessor ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.ShouldSerializeDepartment_Differs
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ShouldSerializeCustomerInfo
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ShouldSerializeCustomerInfoTest()
Dim target As dsADS_Accessor = New dsADS_Accessor ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.ShouldSerializeCustomerInfo
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ShouldSerializeCountNewUsers
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ShouldSerializeCountNewUsersTest()
Dim target As dsADS_Accessor = New dsADS_Accessor ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.ShouldSerializeCountNewUsers
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ShouldSerializeConfig_Problem
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ShouldSerializeConfig_ProblemTest()
Dim target As dsADS_Accessor = New dsADS_Accessor ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.ShouldSerializeConfig_Problem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ShouldSerializeCFOList
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ShouldSerializeCFOListTest()
Dim target As dsADS_Accessor = New dsADS_Accessor ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.ShouldSerializeCFOList
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ShouldSerializeCFOApproval
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ShouldSerializeCFOApprovalTest()
Dim target As dsADS_Accessor = New dsADS_Accessor ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.ShouldSerializeCFOApproval
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ShouldSerializeCFO_Letters_YearMonth
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ShouldSerializeCFO_Letters_YearMonthTest()
Dim target As dsADS_Accessor = New dsADS_Accessor ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.ShouldSerializeCFO_Letters_YearMonth
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ShouldSerializeCFO
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ShouldSerializeCFOTest()
Dim target As dsADS_Accessor = New dsADS_Accessor ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.ShouldSerializeCFO
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ShouldSerializeADCONSOLELOG
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ShouldSerializeADCONSOLELOGTest()
Dim target As dsADS_Accessor = New dsADS_Accessor ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.ShouldSerializeADCONSOLELOG
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ShouldSerializeAD_SNAPSHOT_USER_COUNT
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ShouldSerializeAD_SNAPSHOT_USER_COUNTTest()
Dim target As dsADS_Accessor = New dsADS_Accessor ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.ShouldSerializeAD_SNAPSHOT_USER_COUNT
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ShouldSerializeAD_SNAPSHOT_EXCEPTIONS
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ShouldSerializeAD_SNAPSHOT_EXCEPTIONSTest()
Dim target As dsADS_Accessor = New dsADS_Accessor ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.ShouldSerializeAD_SNAPSHOT_EXCEPTIONS
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ShouldSerializeAD_SNAPSHOT_ALL
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ShouldSerializeAD_SNAPSHOT_ALLTest()
Dim target As dsADS_Accessor = New dsADS_Accessor ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.ShouldSerializeAD_SNAPSHOT_ALL
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ShouldSerializeAD_Disabled_Users
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ShouldSerializeAD_Disabled_UsersTest()
Dim target As dsADS_Accessor = New dsADS_Accessor ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.ShouldSerializeAD_Disabled_Users
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for SchemaChanged
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub SchemaChangedTest()
Dim target As dsADS_Accessor = New dsADS_Accessor ' TODO: Initialize to an appropriate value
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
Dim target As dsADS_Accessor = New dsADS_Accessor ' TODO: Initialize to an appropriate value
Dim reader As XmlReader = Nothing ' TODO: Initialize to an appropriate value
    target.ReadXmlSerializable(reader)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for InitVars
'''</summary>
<TestMethod()>  _
Public Sub InitVarsTest1()
Dim target As dsADS = New dsADS ' TODO: Initialize to an appropriate value
Dim initTable As Boolean = false ' TODO: Initialize to an appropriate value
    target.InitVars(initTable)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for InitVars
'''</summary>
<TestMethod()>  _
Public Sub InitVarsTest()
Dim target As dsADS = New dsADS ' TODO: Initialize to an appropriate value
    target.InitVars
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for InitializeDerivedDataSet
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub InitializeDerivedDataSetTest()
Dim target As dsADS_Accessor = New dsADS_Accessor ' TODO: Initialize to an appropriate value
    target.InitializeDerivedDataSet
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for InitClass
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub InitClassTest()
Dim target As dsADS_Accessor = New dsADS_Accessor ' TODO: Initialize to an appropriate value
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
    actual = dsADS.GetTypedDataSetSchema(xs)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for GetSchemaSerializable
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub GetSchemaSerializableTest()
Dim target As dsADS_Accessor = New dsADS_Accessor ' TODO: Initialize to an appropriate value
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
Dim target As dsADS = New dsADS ' TODO: Initialize to an appropriate value
Dim expected As DataSet = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataSet
    actual = target.Clone
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for dsADS Constructor
'''</summary>
<TestMethod()>  _
Public Sub dsADSConstructorTest1()
    Dim target As dsADS = New dsADS
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub

'''<summary>
'''A test for dsADS Constructor
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub dsADSConstructorTest()
Dim info As SerializationInfo = Nothing ' TODO: Initialize to an appropriate value
Dim context As StreamingContext = New StreamingContext ' TODO: Initialize to an appropriate value
    Dim target As dsADS_Accessor = New dsADS_Accessor(info, context)
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub
End Class
