Imports System.Data

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports ADAdminDotNet



'''<summary>
'''This is a test class for dsARSystemDataSet_LOG_DM_DepartmentRowTest and is intended
'''to contain all dsARSystemDataSet_LOG_DM_DepartmentRowTest Unit Tests
'''</summary>
<TestClass()> _
Public Class dsARSystemDataSet_LOG_DM_DepartmentRowTest


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
'''A test for User_Code
'''</summary>
<TestMethod()>  _
Public Sub User_CodeTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_DepartmentRow = New dsARSystemDataSet.LOG_DM_DepartmentRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.User_Code = expected
    actual = target.User_Code
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for System_Group
'''</summary>
<TestMethod()>  _
Public Sub System_GroupTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_DepartmentRow = New dsARSystemDataSet.LOG_DM_DepartmentRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.System_Group = expected
    actual = target.System_Group
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Submitter
'''</summary>
<TestMethod()>  _
Public Sub SubmitterTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_DepartmentRow = New dsARSystemDataSet.LOG_DM_DepartmentRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.Submitter = expected
    actual = target.Submitter
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Store_Number
'''</summary>
<TestMethod()>  _
Public Sub Store_NumberTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_DepartmentRow = New dsARSystemDataSet.LOG_DM_DepartmentRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.Store_Number = expected
    actual = target.Store_Number
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Status
'''</summary>
<TestMethod()>  _
Public Sub StatusTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_DepartmentRow = New dsARSystemDataSet.LOG_DM_DepartmentRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Integer = 0 ' TODO: Initialize to an appropriate value
    Dim actual As Integer
    target.Status = expected
    actual = target.Status
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Province
'''</summary>
<TestMethod()>  _
Public Sub ProvinceTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_DepartmentRow = New dsARSystemDataSet.LOG_DM_DepartmentRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.Province = expected
    actual = target.Province
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Pre_PER
'''</summary>
<TestMethod()>  _
Public Sub Pre_PERTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_DepartmentRow = New dsARSystemDataSet.LOG_DM_DepartmentRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.Pre_PER = expected
    actual = target.Pre_PER
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Pre_FMS
'''</summary>
<TestMethod()>  _
Public Sub Pre_FMSTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_DepartmentRow = New dsARSystemDataSet.LOG_DM_DepartmentRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.Pre_FMS = expected
    actual = target.Pre_FMS
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Pre_EFT
'''</summary>
<TestMethod()>  _
Public Sub Pre_EFTTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_DepartmentRow = New dsARSystemDataSet.LOG_DM_DepartmentRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.Pre_EFT = expected
    actual = target.Pre_EFT
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Postal_Code
'''</summary>
<TestMethod()>  _
Public Sub Postal_CodeTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_DepartmentRow = New dsARSystemDataSet.LOG_DM_DepartmentRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.Postal_Code = expected
    actual = target.Postal_Code
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Postal_Address
'''</summary>
<TestMethod()>  _
Public Sub Postal_AddressTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_DepartmentRow = New dsARSystemDataSet.LOG_DM_DepartmentRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.Postal_Address = expected
    actual = target.Postal_Address
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Modified_Date
'''</summary>
<TestMethod()>  _
Public Sub Modified_DateTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_DepartmentRow = New dsARSystemDataSet.LOG_DM_DepartmentRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Integer = 0 ' TODO: Initialize to an appropriate value
    Dim actual As Integer
    target.Modified_Date = expected
    actual = target.Modified_Date
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Last_Modified_By
'''</summary>
<TestMethod()>  _
Public Sub Last_Modified_ByTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_DepartmentRow = New dsARSystemDataSet.LOG_DM_DepartmentRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.Last_Modified_By = expected
    actual = target.Last_Modified_By
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Implementation_Date
'''</summary>
<TestMethod()>  _
Public Sub Implementation_DateTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_DepartmentRow = New dsARSystemDataSet.LOG_DM_DepartmentRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Integer = 0 ' TODO: Initialize to an appropriate value
    Dim actual As Integer
    target.Implementation_Date = expected
    actual = target.Implementation_Date
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Dept_ID
'''</summary>
<TestMethod()>  _
Public Sub Dept_IDTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_DepartmentRow = New dsARSystemDataSet.LOG_DM_DepartmentRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.Dept_ID = expected
    actual = target.Dept_ID
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Department_Type
'''</summary>
<TestMethod()>  _
Public Sub Department_TypeTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_DepartmentRow = New dsARSystemDataSet.LOG_DM_DepartmentRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.Department_Type = expected
    actual = target.Department_Type
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Department_Name
'''</summary>
<TestMethod()>  _
Public Sub Department_NameTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_DepartmentRow = New dsARSystemDataSet.LOG_DM_DepartmentRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.Department_Name = expected
    actual = target.Department_Name
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Database_x
'''</summary>
<TestMethod()>  _
Public Sub Database_xTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_DepartmentRow = New dsARSystemDataSet.LOG_DM_DepartmentRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.Database_x = expected
    actual = target.Database_x
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Data_Fix_Counter
'''</summary>
<TestMethod()>  _
Public Sub Data_Fix_CounterTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_DepartmentRow = New dsARSystemDataSet.LOG_DM_DepartmentRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Integer = 0 ' TODO: Initialize to an appropriate value
    Dim actual As Integer
    target.Data_Fix_Counter = expected
    actual = target.Data_Fix_Counter
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Create_Date
'''</summary>
<TestMethod()>  _
Public Sub Create_DateTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_DepartmentRow = New dsARSystemDataSet.LOG_DM_DepartmentRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Integer = 0 ' TODO: Initialize to an appropriate value
    Dim actual As Integer
    target.Create_Date = expected
    actual = target.Create_Date
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for City
'''</summary>
<TestMethod()>  _
Public Sub CityTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_DepartmentRow = New dsARSystemDataSet.LOG_DM_DepartmentRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.City = expected
    actual = target.City
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Billing_Code
'''</summary>
<TestMethod()>  _
Public Sub Billing_CodeTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_DepartmentRow = New dsARSystemDataSet.LOG_DM_DepartmentRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.Billing_Code = expected
    actual = target.Billing_Code
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for _Region
'''</summary>
<TestMethod()>  _
Public Sub _RegionTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_DepartmentRow = New dsARSystemDataSet.LOG_DM_DepartmentRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target._Region = expected
    actual = target._Region
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for SetUser_CodeNull
'''</summary>
<TestMethod()>  _
Public Sub SetUser_CodeNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_DepartmentRow = New dsARSystemDataSet.LOG_DM_DepartmentRow(rb) ' TODO: Initialize to an appropriate value
    target.SetUser_CodeNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for SetSystem_GroupNull
'''</summary>
<TestMethod()>  _
Public Sub SetSystem_GroupNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_DepartmentRow = New dsARSystemDataSet.LOG_DM_DepartmentRow(rb) ' TODO: Initialize to an appropriate value
    target.SetSystem_GroupNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for SetSubmitterNull
'''</summary>
<TestMethod()>  _
Public Sub SetSubmitterNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_DepartmentRow = New dsARSystemDataSet.LOG_DM_DepartmentRow(rb) ' TODO: Initialize to an appropriate value
    target.SetSubmitterNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for SetStore_NumberNull
'''</summary>
<TestMethod()>  _
Public Sub SetStore_NumberNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_DepartmentRow = New dsARSystemDataSet.LOG_DM_DepartmentRow(rb) ' TODO: Initialize to an appropriate value
    target.SetStore_NumberNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for SetProvinceNull
'''</summary>
<TestMethod()>  _
Public Sub SetProvinceNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_DepartmentRow = New dsARSystemDataSet.LOG_DM_DepartmentRow(rb) ' TODO: Initialize to an appropriate value
    target.SetProvinceNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for SetPre_PERNull
'''</summary>
<TestMethod()>  _
Public Sub SetPre_PERNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_DepartmentRow = New dsARSystemDataSet.LOG_DM_DepartmentRow(rb) ' TODO: Initialize to an appropriate value
    target.SetPre_PERNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for SetPre_FMSNull
'''</summary>
<TestMethod()>  _
Public Sub SetPre_FMSNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_DepartmentRow = New dsARSystemDataSet.LOG_DM_DepartmentRow(rb) ' TODO: Initialize to an appropriate value
    target.SetPre_FMSNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for SetPre_EFTNull
'''</summary>
<TestMethod()>  _
Public Sub SetPre_EFTNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_DepartmentRow = New dsARSystemDataSet.LOG_DM_DepartmentRow(rb) ' TODO: Initialize to an appropriate value
    target.SetPre_EFTNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for SetPostal_CodeNull
'''</summary>
<TestMethod()>  _
Public Sub SetPostal_CodeNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_DepartmentRow = New dsARSystemDataSet.LOG_DM_DepartmentRow(rb) ' TODO: Initialize to an appropriate value
    target.SetPostal_CodeNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for SetPostal_AddressNull
'''</summary>
<TestMethod()>  _
Public Sub SetPostal_AddressNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_DepartmentRow = New dsARSystemDataSet.LOG_DM_DepartmentRow(rb) ' TODO: Initialize to an appropriate value
    target.SetPostal_AddressNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for SetImplementation_DateNull
'''</summary>
<TestMethod()>  _
Public Sub SetImplementation_DateNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_DepartmentRow = New dsARSystemDataSet.LOG_DM_DepartmentRow(rb) ' TODO: Initialize to an appropriate value
    target.SetImplementation_DateNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for SetDepartment_TypeNull
'''</summary>
<TestMethod()>  _
Public Sub SetDepartment_TypeNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_DepartmentRow = New dsARSystemDataSet.LOG_DM_DepartmentRow(rb) ' TODO: Initialize to an appropriate value
    target.SetDepartment_TypeNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for SetDatabase_xNull
'''</summary>
<TestMethod()>  _
Public Sub SetDatabase_xNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_DepartmentRow = New dsARSystemDataSet.LOG_DM_DepartmentRow(rb) ' TODO: Initialize to an appropriate value
    target.SetDatabase_xNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for SetData_Fix_CounterNull
'''</summary>
<TestMethod()>  _
Public Sub SetData_Fix_CounterNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_DepartmentRow = New dsARSystemDataSet.LOG_DM_DepartmentRow(rb) ' TODO: Initialize to an appropriate value
    target.SetData_Fix_CounterNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for SetCityNull
'''</summary>
<TestMethod()>  _
Public Sub SetCityNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_DepartmentRow = New dsARSystemDataSet.LOG_DM_DepartmentRow(rb) ' TODO: Initialize to an appropriate value
    target.SetCityNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for SetBilling_CodeNull
'''</summary>
<TestMethod()>  _
Public Sub SetBilling_CodeNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_DepartmentRow = New dsARSystemDataSet.LOG_DM_DepartmentRow(rb) ' TODO: Initialize to an appropriate value
    target.SetBilling_CodeNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for Set_RegionNull
'''</summary>
<TestMethod()>  _
Public Sub Set_RegionNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_DepartmentRow = New dsARSystemDataSet.LOG_DM_DepartmentRow(rb) ' TODO: Initialize to an appropriate value
    target.Set_RegionNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for IsUser_CodeNull
'''</summary>
<TestMethod()>  _
Public Sub IsUser_CodeNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_DepartmentRow = New dsARSystemDataSet.LOG_DM_DepartmentRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsUser_CodeNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IsSystem_GroupNull
'''</summary>
<TestMethod()>  _
Public Sub IsSystem_GroupNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_DepartmentRow = New dsARSystemDataSet.LOG_DM_DepartmentRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsSystem_GroupNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IsSubmitterNull
'''</summary>
<TestMethod()>  _
Public Sub IsSubmitterNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_DepartmentRow = New dsARSystemDataSet.LOG_DM_DepartmentRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsSubmitterNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IsStore_NumberNull
'''</summary>
<TestMethod()>  _
Public Sub IsStore_NumberNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_DepartmentRow = New dsARSystemDataSet.LOG_DM_DepartmentRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsStore_NumberNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IsProvinceNull
'''</summary>
<TestMethod()>  _
Public Sub IsProvinceNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_DepartmentRow = New dsARSystemDataSet.LOG_DM_DepartmentRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsProvinceNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IsPre_PERNull
'''</summary>
<TestMethod()>  _
Public Sub IsPre_PERNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_DepartmentRow = New dsARSystemDataSet.LOG_DM_DepartmentRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsPre_PERNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IsPre_FMSNull
'''</summary>
<TestMethod()>  _
Public Sub IsPre_FMSNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_DepartmentRow = New dsARSystemDataSet.LOG_DM_DepartmentRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsPre_FMSNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IsPre_EFTNull
'''</summary>
<TestMethod()>  _
Public Sub IsPre_EFTNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_DepartmentRow = New dsARSystemDataSet.LOG_DM_DepartmentRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsPre_EFTNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IsPostal_CodeNull
'''</summary>
<TestMethod()>  _
Public Sub IsPostal_CodeNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_DepartmentRow = New dsARSystemDataSet.LOG_DM_DepartmentRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsPostal_CodeNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IsPostal_AddressNull
'''</summary>
<TestMethod()>  _
Public Sub IsPostal_AddressNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_DepartmentRow = New dsARSystemDataSet.LOG_DM_DepartmentRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsPostal_AddressNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IsImplementation_DateNull
'''</summary>
<TestMethod()>  _
Public Sub IsImplementation_DateNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_DepartmentRow = New dsARSystemDataSet.LOG_DM_DepartmentRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsImplementation_DateNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IsDepartment_TypeNull
'''</summary>
<TestMethod()>  _
Public Sub IsDepartment_TypeNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_DepartmentRow = New dsARSystemDataSet.LOG_DM_DepartmentRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsDepartment_TypeNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IsDatabase_xNull
'''</summary>
<TestMethod()>  _
Public Sub IsDatabase_xNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_DepartmentRow = New dsARSystemDataSet.LOG_DM_DepartmentRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsDatabase_xNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IsData_Fix_CounterNull
'''</summary>
<TestMethod()>  _
Public Sub IsData_Fix_CounterNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_DepartmentRow = New dsARSystemDataSet.LOG_DM_DepartmentRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsData_Fix_CounterNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IsCityNull
'''</summary>
<TestMethod()>  _
Public Sub IsCityNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_DepartmentRow = New dsARSystemDataSet.LOG_DM_DepartmentRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsCityNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IsBilling_CodeNull
'''</summary>
<TestMethod()>  _
Public Sub IsBilling_CodeNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_DepartmentRow = New dsARSystemDataSet.LOG_DM_DepartmentRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsBilling_CodeNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Is_RegionNull
'''</summary>
<TestMethod()>  _
Public Sub Is_RegionNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_DepartmentRow = New dsARSystemDataSet.LOG_DM_DepartmentRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.Is_RegionNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for LOG_DM_DepartmentRow Constructor
'''</summary>
<TestMethod()>  _
Public Sub dsARSystemDataSet_LOG_DM_DepartmentRowConstructorTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
    Dim target As dsARSystemDataSet.LOG_DM_DepartmentRow = New dsARSystemDataSet.LOG_DM_DepartmentRow(rb)
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub
End Class
