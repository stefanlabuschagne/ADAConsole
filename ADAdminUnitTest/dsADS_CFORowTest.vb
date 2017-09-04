Imports System.Data

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports ADAdminDotNet



'''<summary>
'''This is a test class for dsADS_CFORowTest and is intended
'''to contain all dsADS_CFORowTest Unit Tests
'''</summary>
<TestClass()> _
Public Class dsADS_CFORowTest


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
'''A test for VoteID
'''</summary>
<TestMethod()>  _
Public Sub VoteIDTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.CFORow = New dsADS.CFORow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Long = 0 ' TODO: Initialize to an appropriate value
    Dim actual As Long
    target.VoteID = expected
    actual = target.VoteID
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for NAT_PROV_ID
'''</summary>
<TestMethod()>  _
Public Sub NAT_PROV_IDTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.CFORow = New dsADS.CFORow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Long = 0 ' TODO: Initialize to an appropriate value
    Dim actual As Long
    target.NAT_PROV_ID = expected
    actual = target.NAT_PROV_ID
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for LastName
'''</summary>
<TestMethod()>  _
Public Sub LastNameTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.CFORow = New dsADS.CFORow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.LastName = expected
    actual = target.LastName
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for JobTitle
'''</summary>
<TestMethod()>  _
Public Sub JobTitleTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.CFORow = New dsADS.CFORow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.JobTitle = expected
    actual = target.JobTitle
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Initials
'''</summary>
<TestMethod()>  _
Public Sub InitialsTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.CFORow = New dsADS.CFORow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.Initials = expected
    actual = target.Initials
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ID
'''</summary>
<TestMethod()>  _
Public Sub IDTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.CFORow = New dsADS.CFORow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Long = 0 ' TODO: Initialize to an appropriate value
    Dim actual As Long
    target.ID = expected
    actual = target.ID
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Gender
'''</summary>
<TestMethod()>  _
Public Sub GenderTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.CFORow = New dsADS.CFORow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.Gender = expected
    actual = target.Gender
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Fullname
'''</summary>
<TestMethod()>  _
Public Sub FullnameTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.CFORow = New dsADS.CFORow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.Fullname = expected
    actual = target.Fullname
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for FirstName
'''</summary>
<TestMethod()>  _
Public Sub FirstNameTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.CFORow = New dsADS.CFORow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.FirstName = expected
    actual = target.FirstName
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Email1Address
'''</summary>
<TestMethod()>  _
Public Sub Email1AddressTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.CFORow = New dsADS.CFORow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.Email1Address = expected
    actual = target.Email1Address
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Dept_Code
'''</summary>
<TestMethod()>  _
Public Sub Dept_CodeTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.CFORow = New dsADS.CFORow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.Dept_Code = expected
    actual = target.Dept_Code
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for CompanyName
'''</summary>
<TestMethod()>  _
Public Sub CompanyNameTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.CFORow = New dsADS.CFORow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.CompanyName = expected
    actual = target.CompanyName
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for BusinessTelephoneNumber
'''</summary>
<TestMethod()>  _
Public Sub BusinessTelephoneNumberTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.CFORow = New dsADS.CFORow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.BusinessTelephoneNumber = expected
    actual = target.BusinessTelephoneNumber
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for BusinessFaxNumber
'''</summary>
<TestMethod()>  _
Public Sub BusinessFaxNumberTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.CFORow = New dsADS.CFORow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.BusinessFaxNumber = expected
    actual = target.BusinessFaxNumber
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for BusinessAddress
'''</summary>
<TestMethod()>  _
Public Sub BusinessAddressTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.CFORow = New dsADS.CFORow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.BusinessAddress = expected
    actual = target.BusinessAddress
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for CFORow Constructor
'''</summary>
<TestMethod()>  _
Public Sub dsADS_CFORowConstructorTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
    Dim target As dsADS.CFORow = New dsADS.CFORow(rb)
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub
End Class
