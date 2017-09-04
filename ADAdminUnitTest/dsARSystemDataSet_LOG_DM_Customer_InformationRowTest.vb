Imports System.Data

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports ADAdminDotNet



'''<summary>
'''This is a test class for dsARSystemDataSet_LOG_DM_Customer_InformationRowTest and is intended
'''to contain all dsARSystemDataSet_LOG_DM_Customer_InformationRowTest Unit Tests
'''</summary>
<TestClass()> _
Public Class dsARSystemDataSet_LOG_DM_Customer_InformationRowTest


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
'''A test for VULINDLELA_Role
'''</summary>
<TestMethod()>  _
Public Sub VULINDLELA_RoleTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.VULINDLELA_Role = expected
    actual = target.VULINDLELA_Role
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for VULIN_Store_Number
'''</summary>
<TestMethod()>  _
Public Sub VULIN_Store_NumberTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.VULIN_Store_Number = expected
    actual = target.VULIN_Store_Number
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Title
'''</summary>
<TestMethod()>  _
Public Sub TitleTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.Title = expected
    actual = target.Title
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Temp_Postal_Code
'''</summary>
<TestMethod()>  _
Public Sub Temp_Postal_CodeTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.Temp_Postal_Code = expected
    actual = target.Temp_Postal_Code
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Temp_Postal_Address
'''</summary>
<TestMethod()>  _
Public Sub Temp_Postal_AddressTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.Temp_Postal_Address = expected
    actual = target.Temp_Postal_Address
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Telephone
'''</summary>
<TestMethod()>  _
Public Sub TelephoneTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.Telephone = expected
    actual = target.Telephone
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Submitter
'''</summary>
<TestMethod()>  _
Public Sub SubmitterTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.Submitter = expected
    actual = target.Submitter
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Remote_Access_Availability
'''</summary>
<TestMethod()>  _
Public Sub Remote_Access_AvailabilityTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Integer = 0 ' TODO: Initialize to an appropriate value
    Dim actual As Integer
    target.Remote_Access_Availability = expected
    actual = target.Remote_Access_Availability
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Record_Status
'''</summary>
<TestMethod()>  _
Public Sub Record_StatusTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Integer = 0 ' TODO: Initialize to an appropriate value
    Dim actual As Integer
    target.Record_Status = expected
    actual = target.Record_Status
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Rank
'''</summary>
<TestMethod()>  _
Public Sub RankTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.Rank = expected
    actual = target.Rank
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for PERSAL_Store_Number
'''</summary>
<TestMethod()>  _
Public Sub PERSAL_Store_NumberTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.PERSAL_Store_Number = expected
    actual = target.PERSAL_Store_Number
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for PERSAL_Role
'''</summary>
<TestMethod()>  _
Public Sub PERSAL_RoleTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.PERSAL_Role = expected
    actual = target.PERSAL_Role
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Persal_Number
'''</summary>
<TestMethod()>  _
Public Sub Persal_NumberTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.Persal_Number = expected
    actual = target.Persal_Number
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Nickname
'''</summary>
<TestMethod()>  _
Public Sub NicknameTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.Nickname = expected
    actual = target.Nickname
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Modified_Date
'''</summary>
<TestMethod()>  _
Public Sub Modified_DateTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Integer = 0 ' TODO: Initialize to an appropriate value
    Dim actual As Integer
    target.Modified_Date = expected
    actual = target.Modified_Date
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for LOGIS_Store_Number
'''</summary>
<TestMethod()>  _
Public Sub LOGIS_Store_NumberTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.LOGIS_Store_Number = expected
    actual = target.LOGIS_Store_Number
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for LOGIS_Role
'''</summary>
<TestMethod()>  _
Public Sub LOGIS_RoleTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.LOGIS_Role = expected
    actual = target.LOGIS_Role
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Last_Name
'''</summary>
<TestMethod()>  _
Public Sub Last_NameTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.Last_Name = expected
    actual = target.Last_Name
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Last_Modified_By
'''</summary>
<TestMethod()>  _
Public Sub Last_Modified_ByTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.Last_Modified_By = expected
    actual = target.Last_Modified_By
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Initial
'''</summary>
<TestMethod()>  _
Public Sub InitialTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.Initial = expected
    actual = target.Initial
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for FMS_Store_Number
'''</summary>
<TestMethod()>  _
Public Sub FMS_Store_NumberTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.FMS_Store_Number = expected
    actual = target.FMS_Store_Number
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for FMS_Role
'''</summary>
<TestMethod()>  _
Public Sub FMS_RoleTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.FMS_Role = expected
    actual = target.FMS_Role
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for First_Name
'''</summary>
<TestMethod()>  _
Public Sub First_NameTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.First_Name = expected
    actual = target.First_Name
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Fax_Number
'''</summary>
<TestMethod()>  _
Public Sub Fax_NumberTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.Fax_Number = expected
    actual = target.Fax_Number
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Extension
'''</summary>
<TestMethod()>  _
Public Sub ExtensionTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.Extension = expected
    actual = target.Extension
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Entry_ID
'''</summary>
<TestMethod()>  _
Public Sub Entry_IDTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.Entry_ID = expected
    actual = target.Entry_ID
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for E_Mail
'''</summary>
<TestMethod()>  _
Public Sub E_MailTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.E_Mail = expected
    actual = target.E_Mail
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Department_Type
'''</summary>
<TestMethod()>  _
Public Sub Department_TypeTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
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
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.Department_Name = expected
    actual = target.Department_Name
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Create_Date
'''</summary>
<TestMethod()>  _
Public Sub Create_DateTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Integer = 0 ' TODO: Initialize to an appropriate value
    Dim actual As Integer
    target.Create_Date = expected
    actual = target.Create_Date
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Comments
'''</summary>
<TestMethod()>  _
Public Sub CommentsTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.Comments = expected
    actual = target.Comments
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Character_Field
'''</summary>
<TestMethod()>  _
Public Sub Character_FieldTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.Character_Field = expected
    actual = target.Character_Field
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Cellphone
'''</summary>
<TestMethod()>  _
Public Sub CellphoneTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.Cellphone = expected
    actual = target.Cellphone
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for BAS_Store_Number
'''</summary>
<TestMethod()>  _
Public Sub BAS_Store_NumberTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.BAS_Store_Number = expected
    actual = target.BAS_Store_Number
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for BAS_Role
'''</summary>
<TestMethod()>  _
Public Sub BAS_RoleTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.BAS_Role = expected
    actual = target.BAS_Role
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for SetVULINDLELA_RoleNull
'''</summary>
<TestMethod()>  _
Public Sub SetVULINDLELA_RoleNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
    target.SetVULINDLELA_RoleNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for SetVULIN_Store_NumberNull
'''</summary>
<TestMethod()>  _
Public Sub SetVULIN_Store_NumberNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
    target.SetVULIN_Store_NumberNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for SetTitleNull
'''</summary>
<TestMethod()>  _
Public Sub SetTitleNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
    target.SetTitleNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for SetTemp_Postal_CodeNull
'''</summary>
<TestMethod()>  _
Public Sub SetTemp_Postal_CodeNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
    target.SetTemp_Postal_CodeNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for SetTemp_Postal_AddressNull
'''</summary>
<TestMethod()>  _
Public Sub SetTemp_Postal_AddressNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
    target.SetTemp_Postal_AddressNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for SetTelephoneNull
'''</summary>
<TestMethod()>  _
Public Sub SetTelephoneNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
    target.SetTelephoneNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for SetSubmitterNull
'''</summary>
<TestMethod()>  _
Public Sub SetSubmitterNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
    target.SetSubmitterNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for SetRemote_Access_AvailabilityNull
'''</summary>
<TestMethod()>  _
Public Sub SetRemote_Access_AvailabilityNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
    target.SetRemote_Access_AvailabilityNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for SetRankNull
'''</summary>
<TestMethod()>  _
Public Sub SetRankNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
    target.SetRankNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for SetPERSAL_Store_NumberNull
'''</summary>
<TestMethod()>  _
Public Sub SetPERSAL_Store_NumberNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
    target.SetPERSAL_Store_NumberNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for SetPERSAL_RoleNull
'''</summary>
<TestMethod()>  _
Public Sub SetPERSAL_RoleNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
    target.SetPERSAL_RoleNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for SetNicknameNull
'''</summary>
<TestMethod()>  _
Public Sub SetNicknameNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
    target.SetNicknameNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for SetLOGIS_Store_NumberNull
'''</summary>
<TestMethod()>  _
Public Sub SetLOGIS_Store_NumberNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
    target.SetLOGIS_Store_NumberNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for SetLOGIS_RoleNull
'''</summary>
<TestMethod()>  _
Public Sub SetLOGIS_RoleNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
    target.SetLOGIS_RoleNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for SetLast_NameNull
'''</summary>
<TestMethod()>  _
Public Sub SetLast_NameNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
    target.SetLast_NameNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for SetInitialNull
'''</summary>
<TestMethod()>  _
Public Sub SetInitialNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
    target.SetInitialNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for SetFMS_Store_NumberNull
'''</summary>
<TestMethod()>  _
Public Sub SetFMS_Store_NumberNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
    target.SetFMS_Store_NumberNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for SetFMS_RoleNull
'''</summary>
<TestMethod()>  _
Public Sub SetFMS_RoleNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
    target.SetFMS_RoleNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for SetFirst_NameNull
'''</summary>
<TestMethod()>  _
Public Sub SetFirst_NameNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
    target.SetFirst_NameNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for SetFax_NumberNull
'''</summary>
<TestMethod()>  _
Public Sub SetFax_NumberNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
    target.SetFax_NumberNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for SetExtensionNull
'''</summary>
<TestMethod()>  _
Public Sub SetExtensionNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
    target.SetExtensionNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for SetE_MailNull
'''</summary>
<TestMethod()>  _
Public Sub SetE_MailNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
    target.SetE_MailNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for SetDepartment_TypeNull
'''</summary>
<TestMethod()>  _
Public Sub SetDepartment_TypeNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
    target.SetDepartment_TypeNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for SetDepartment_NameNull
'''</summary>
<TestMethod()>  _
Public Sub SetDepartment_NameNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
    target.SetDepartment_NameNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for SetCommentsNull
'''</summary>
<TestMethod()>  _
Public Sub SetCommentsNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
    target.SetCommentsNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for SetCharacter_FieldNull
'''</summary>
<TestMethod()>  _
Public Sub SetCharacter_FieldNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
    target.SetCharacter_FieldNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for SetCellphoneNull
'''</summary>
<TestMethod()>  _
Public Sub SetCellphoneNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
    target.SetCellphoneNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for SetBAS_Store_NumberNull
'''</summary>
<TestMethod()>  _
Public Sub SetBAS_Store_NumberNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
    target.SetBAS_Store_NumberNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for SetBAS_RoleNull
'''</summary>
<TestMethod()>  _
Public Sub SetBAS_RoleNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
    target.SetBAS_RoleNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for IsVULINDLELA_RoleNull
'''</summary>
<TestMethod()>  _
Public Sub IsVULINDLELA_RoleNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsVULINDLELA_RoleNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IsVULIN_Store_NumberNull
'''</summary>
<TestMethod()>  _
Public Sub IsVULIN_Store_NumberNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsVULIN_Store_NumberNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IsTitleNull
'''</summary>
<TestMethod()>  _
Public Sub IsTitleNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsTitleNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IsTemp_Postal_CodeNull
'''</summary>
<TestMethod()>  _
Public Sub IsTemp_Postal_CodeNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsTemp_Postal_CodeNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IsTemp_Postal_AddressNull
'''</summary>
<TestMethod()>  _
Public Sub IsTemp_Postal_AddressNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsTemp_Postal_AddressNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IsTelephoneNull
'''</summary>
<TestMethod()>  _
Public Sub IsTelephoneNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsTelephoneNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IsSubmitterNull
'''</summary>
<TestMethod()>  _
Public Sub IsSubmitterNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsSubmitterNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IsRemote_Access_AvailabilityNull
'''</summary>
<TestMethod()>  _
Public Sub IsRemote_Access_AvailabilityNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsRemote_Access_AvailabilityNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IsRankNull
'''</summary>
<TestMethod()>  _
Public Sub IsRankNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsRankNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IsPERSAL_Store_NumberNull
'''</summary>
<TestMethod()>  _
Public Sub IsPERSAL_Store_NumberNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsPERSAL_Store_NumberNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IsPERSAL_RoleNull
'''</summary>
<TestMethod()>  _
Public Sub IsPERSAL_RoleNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsPERSAL_RoleNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IsNicknameNull
'''</summary>
<TestMethod()>  _
Public Sub IsNicknameNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsNicknameNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IsLOGIS_Store_NumberNull
'''</summary>
<TestMethod()>  _
Public Sub IsLOGIS_Store_NumberNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsLOGIS_Store_NumberNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IsLOGIS_RoleNull
'''</summary>
<TestMethod()>  _
Public Sub IsLOGIS_RoleNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsLOGIS_RoleNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IsLast_NameNull
'''</summary>
<TestMethod()>  _
Public Sub IsLast_NameNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsLast_NameNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IsInitialNull
'''</summary>
<TestMethod()>  _
Public Sub IsInitialNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsInitialNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IsFMS_Store_NumberNull
'''</summary>
<TestMethod()>  _
Public Sub IsFMS_Store_NumberNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsFMS_Store_NumberNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IsFMS_RoleNull
'''</summary>
<TestMethod()>  _
Public Sub IsFMS_RoleNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsFMS_RoleNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IsFirst_NameNull
'''</summary>
<TestMethod()>  _
Public Sub IsFirst_NameNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsFirst_NameNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IsFax_NumberNull
'''</summary>
<TestMethod()>  _
Public Sub IsFax_NumberNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsFax_NumberNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IsExtensionNull
'''</summary>
<TestMethod()>  _
Public Sub IsExtensionNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsExtensionNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IsE_MailNull
'''</summary>
<TestMethod()>  _
Public Sub IsE_MailNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsE_MailNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IsDepartment_TypeNull
'''</summary>
<TestMethod()>  _
Public Sub IsDepartment_TypeNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsDepartment_TypeNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IsDepartment_NameNull
'''</summary>
<TestMethod()>  _
Public Sub IsDepartment_NameNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsDepartment_NameNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IsCommentsNull
'''</summary>
<TestMethod()>  _
Public Sub IsCommentsNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsCommentsNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IsCharacter_FieldNull
'''</summary>
<TestMethod()>  _
Public Sub IsCharacter_FieldNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsCharacter_FieldNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IsCellphoneNull
'''</summary>
<TestMethod()>  _
Public Sub IsCellphoneNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsCellphoneNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IsBAS_Store_NumberNull
'''</summary>
<TestMethod()>  _
Public Sub IsBAS_Store_NumberNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsBAS_Store_NumberNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IsBAS_RoleNull
'''</summary>
<TestMethod()>  _
Public Sub IsBAS_RoleNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsBAS_RoleNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for LOG_DM_Customer_InformationRow Constructor
'''</summary>
<TestMethod()>  _
Public Sub dsARSystemDataSet_LOG_DM_Customer_InformationRowConstructorTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
    Dim target As dsARSystemDataSet.LOG_DM_Customer_InformationRow = New dsARSystemDataSet.LOG_DM_Customer_InformationRow(rb)
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub
End Class
