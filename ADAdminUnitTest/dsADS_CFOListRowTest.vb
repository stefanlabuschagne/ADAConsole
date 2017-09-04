Imports System.Data

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports ADAdminDotNet



'''<summary>
'''This is a test class for dsADS_CFOListRowTest and is intended
'''to contain all dsADS_CFOListRowTest Unit Tests
'''</summary>
<TestClass()> _
Public Class dsADS_CFOListRowTest


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
'''A test for Tel
'''</summary>
<TestMethod()>  _
Public Sub TelTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.CFOListRow = New dsADS.CFOListRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.Tel = expected
    actual = target.Tel
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Surname
'''</summary>
<TestMethod()>  _
Public Sub SurnameTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.CFOListRow = New dsADS.CFOListRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.Surname = expected
    actual = target.Surname
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Province
'''</summary>
<TestMethod()>  _
Public Sub ProvinceTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.CFOListRow = New dsADS.CFOListRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.Province = expected
    actual = target.Province
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for PersalNo
'''</summary>
<TestMethod()>  _
Public Sub PersalNoTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.CFOListRow = New dsADS.CFOListRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.PersalNo = expected
    actual = target.PersalNo
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ID
'''</summary>
<TestMethod()>  _
Public Sub IDTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.CFOListRow = New dsADS.CFOListRow(rb) ' TODO: Initialize to an appropriate value
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
Dim target As dsADS.CFOListRow = New dsADS.CFOListRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.Gender = expected
    actual = target.Gender
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for FullNames
'''</summary>
<TestMethod()>  _
Public Sub FullNamesTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.CFOListRow = New dsADS.CFOListRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.FullNames = expected
    actual = target.FullNames
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Fax
'''</summary>
<TestMethod()>  _
Public Sub FaxTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.CFOListRow = New dsADS.CFOListRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.Fax = expected
    actual = target.Fax
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Email
'''</summary>
<TestMethod()>  _
Public Sub EmailTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.CFOListRow = New dsADS.CFOListRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.Email = expected
    actual = target.Email
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Designation
'''</summary>
<TestMethod()>  _
Public Sub DesignationTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.CFOListRow = New dsADS.CFOListRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.Designation = expected
    actual = target.Designation
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DeptCode
'''</summary>
<TestMethod()>  _
Public Sub DeptCodeTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.CFOListRow = New dsADS.CFOListRow(rb) ' TODO: Initialize to an appropriate value
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
Dim target As dsADS.CFOListRow = New dsADS.CFOListRow(rb) ' TODO: Initialize to an appropriate value
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
Dim target As dsADS.CFOListRow = New dsADS.CFOListRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.Cell = expected
    actual = target.Cell
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for SetTelNull
'''</summary>
<TestMethod()>  _
Public Sub SetTelNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.CFOListRow = New dsADS.CFOListRow(rb) ' TODO: Initialize to an appropriate value
    target.SetTelNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for SetSurnameNull
'''</summary>
<TestMethod()>  _
Public Sub SetSurnameNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.CFOListRow = New dsADS.CFOListRow(rb) ' TODO: Initialize to an appropriate value
    target.SetSurnameNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for SetProvinceNull
'''</summary>
<TestMethod()>  _
Public Sub SetProvinceNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.CFOListRow = New dsADS.CFOListRow(rb) ' TODO: Initialize to an appropriate value
    target.SetProvinceNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for SetFullNamesNull
'''</summary>
<TestMethod()>  _
Public Sub SetFullNamesNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.CFOListRow = New dsADS.CFOListRow(rb) ' TODO: Initialize to an appropriate value
    target.SetFullNamesNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for SetFaxNull
'''</summary>
<TestMethod()>  _
Public Sub SetFaxNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.CFOListRow = New dsADS.CFOListRow(rb) ' TODO: Initialize to an appropriate value
    target.SetFaxNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for SetEmailNull
'''</summary>
<TestMethod()>  _
Public Sub SetEmailNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.CFOListRow = New dsADS.CFOListRow(rb) ' TODO: Initialize to an appropriate value
    target.SetEmailNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for SetDesignationNull
'''</summary>
<TestMethod()>  _
Public Sub SetDesignationNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.CFOListRow = New dsADS.CFOListRow(rb) ' TODO: Initialize to an appropriate value
    target.SetDesignationNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for SetDeptCodeNull
'''</summary>
<TestMethod()>  _
Public Sub SetDeptCodeNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.CFOListRow = New dsADS.CFOListRow(rb) ' TODO: Initialize to an appropriate value
    target.SetDeptCodeNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for SetDepartmentNull
'''</summary>
<TestMethod()>  _
Public Sub SetDepartmentNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.CFOListRow = New dsADS.CFOListRow(rb) ' TODO: Initialize to an appropriate value
    target.SetDepartmentNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for SetCellNull
'''</summary>
<TestMethod()>  _
Public Sub SetCellNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.CFOListRow = New dsADS.CFOListRow(rb) ' TODO: Initialize to an appropriate value
    target.SetCellNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for IsTelNull
'''</summary>
<TestMethod()>  _
Public Sub IsTelNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.CFOListRow = New dsADS.CFOListRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsTelNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IsSurnameNull
'''</summary>
<TestMethod()>  _
Public Sub IsSurnameNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.CFOListRow = New dsADS.CFOListRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsSurnameNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IsProvinceNull
'''</summary>
<TestMethod()>  _
Public Sub IsProvinceNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.CFOListRow = New dsADS.CFOListRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsProvinceNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IsFullNamesNull
'''</summary>
<TestMethod()>  _
Public Sub IsFullNamesNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.CFOListRow = New dsADS.CFOListRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsFullNamesNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IsFaxNull
'''</summary>
<TestMethod()>  _
Public Sub IsFaxNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.CFOListRow = New dsADS.CFOListRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsFaxNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IsEmailNull
'''</summary>
<TestMethod()>  _
Public Sub IsEmailNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.CFOListRow = New dsADS.CFOListRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsEmailNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IsDesignationNull
'''</summary>
<TestMethod()>  _
Public Sub IsDesignationNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.CFOListRow = New dsADS.CFOListRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsDesignationNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IsDeptCodeNull
'''</summary>
<TestMethod()>  _
Public Sub IsDeptCodeNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.CFOListRow = New dsADS.CFOListRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsDeptCodeNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IsDepartmentNull
'''</summary>
<TestMethod()>  _
Public Sub IsDepartmentNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.CFOListRow = New dsADS.CFOListRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsDepartmentNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IsCellNull
'''</summary>
<TestMethod()>  _
Public Sub IsCellNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.CFOListRow = New dsADS.CFOListRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsCellNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for CFOListRow Constructor
'''</summary>
<TestMethod()>  _
Public Sub dsADS_CFOListRowConstructorTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
    Dim target As dsADS.CFOListRow = New dsADS.CFOListRow(rb)
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub
End Class
