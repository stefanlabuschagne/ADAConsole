Imports System.Data

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports ADAdminDotNet



'''<summary>
'''This is a test class for dsADS_AD_SNAPSHOT_ALLRowTest and is intended
'''to contain all dsADS_AD_SNAPSHOT_ALLRowTest Unit Tests
'''</summary>
<TestClass()> _
Public Class dsADS_AD_SNAPSHOT_ALLRowTest


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
'''A test for Vote
'''</summary>
<TestMethod()>  _
Public Sub VoteTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.AD_SNAPSHOT_ALLRow = New dsADS.AD_SNAPSHOT_ALLRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.Vote = expected
    actual = target.Vote
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Phone
'''</summary>
<TestMethod()>  _
Public Sub PhoneTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.AD_SNAPSHOT_ALLRow = New dsADS.AD_SNAPSHOT_ALLRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.Phone = expected
    actual = target.Phone
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for NatProv
'''</summary>
<TestMethod()>  _
Public Sub NatProvTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.AD_SNAPSHOT_ALLRow = New dsADS.AD_SNAPSHOT_ALLRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.NatProv = expected
    actual = target.NatProv
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for LOGIS
'''</summary>
<TestMethod()>  _
Public Sub LOGISTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.AD_SNAPSHOT_ALLRow = New dsADS.AD_SNAPSHOT_ALLRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Short = 0 ' TODO: Initialize to an appropriate value
    Dim actual As Short
    target.LOGIS = expected
    actual = target.LOGIS
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Lastname
'''</summary>
<TestMethod()>  _
Public Sub LastnameTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.AD_SNAPSHOT_ALLRow = New dsADS.AD_SNAPSHOT_ALLRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.Lastname = expected
    actual = target.Lastname
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ID
'''</summary>
<TestMethod()>  _
Public Sub IDTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.AD_SNAPSHOT_ALLRow = New dsADS.AD_SNAPSHOT_ALLRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Long = 0 ' TODO: Initialize to an appropriate value
    Dim actual As Long
    target.ID = expected
    actual = target.ID
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for HR
'''</summary>
<TestMethod()>  _
Public Sub HRTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.AD_SNAPSHOT_ALLRow = New dsADS.AD_SNAPSHOT_ALLRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Short = 0 ' TODO: Initialize to an appropriate value
    Dim actual As Short
    target.HR = expected
    actual = target.HR
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for GFS
'''</summary>
<TestMethod()>  _
Public Sub GFSTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.AD_SNAPSHOT_ALLRow = New dsADS.AD_SNAPSHOT_ALLRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Short = 0 ' TODO: Initialize to an appropriate value
    Dim actual As Short
    target.GFS = expected
    actual = target.GFS
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for FirstName
'''</summary>
<TestMethod()>  _
Public Sub FirstNameTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.AD_SNAPSHOT_ALLRow = New dsADS.AD_SNAPSHOT_ALLRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.FirstName = expected
    actual = target.FirstName
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for FINANCIALS
'''</summary>
<TestMethod()>  _
Public Sub FINANCIALSTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.AD_SNAPSHOT_ALLRow = New dsADS.AD_SNAPSHOT_ALLRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Short = 0 ' TODO: Initialize to an appropriate value
    Dim actual As Short
    target.FINANCIALS = expected
    actual = target.FINANCIALS
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for EMail
'''</summary>
<TestMethod()>  _
Public Sub EMailTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.AD_SNAPSHOT_ALLRow = New dsADS.AD_SNAPSHOT_ALLRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.EMail = expected
    actual = target.EMail
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DPSA
'''</summary>
<TestMethod()>  _
Public Sub DPSATest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.AD_SNAPSHOT_ALLRow = New dsADS.AD_SNAPSHOT_ALLRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Short = 0 ' TODO: Initialize to an appropriate value
    Dim actual As Short
    target.DPSA = expected
    actual = target.DPSA
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DeptMember
'''</summary>
<TestMethod()>  _
Public Sub DeptMemberTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.AD_SNAPSHOT_ALLRow = New dsADS.AD_SNAPSHOT_ALLRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.DeptMember = expected
    actual = target.DeptMember
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DeptCode
'''</summary>
<TestMethod()>  _
Public Sub DeptCodeTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.AD_SNAPSHOT_ALLRow = New dsADS.AD_SNAPSHOT_ALLRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.DeptCode = expected
    actual = target.DeptCode
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Department
'''</summary>
<TestMethod()>  _
Public Sub DepartmentTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.AD_SNAPSHOT_ALLRow = New dsADS.AD_SNAPSHOT_ALLRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.Department = expected
    actual = target.Department
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Cell
'''</summary>
<TestMethod()>  _
Public Sub CellTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.AD_SNAPSHOT_ALLRow = New dsADS.AD_SNAPSHOT_ALLRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.Cell = expected
    actual = target.Cell
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ApplMember
'''</summary>
<TestMethod()>  _
Public Sub ApplMemberTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.AD_SNAPSHOT_ALLRow = New dsADS.AD_SNAPSHOT_ALLRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.ApplMember = expected
    actual = target.ApplMember
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for AccountNr
'''</summary>
<TestMethod()>  _
Public Sub AccountNrTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.AD_SNAPSHOT_ALLRow = New dsADS.AD_SNAPSHOT_ALLRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.AccountNr = expected
    actual = target.AccountNr
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for AccountDisabled
'''</summary>
<TestMethod()>  _
Public Sub AccountDisabledTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.AD_SNAPSHOT_ALLRow = New dsADS.AD_SNAPSHOT_ALLRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Short = 0 ' TODO: Initialize to an appropriate value
    Dim actual As Short
    target.AccountDisabled = expected
    actual = target.AccountDisabled
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for AD_SNAPSHOT_ALLRow Constructor
'''</summary>
<TestMethod()>  _
Public Sub dsADS_AD_SNAPSHOT_ALLRowConstructorTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
    Dim target As dsADS.AD_SNAPSHOT_ALLRow = New dsADS.AD_SNAPSHOT_ALLRow(rb)
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub
End Class
