Imports System

Imports System.Data

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports ADAdminDotNet



'''<summary>
'''This is a test class for dsADS_Config_ProblemRowTest and is intended
'''to contain all dsADS_Config_ProblemRowTest Unit Tests
'''</summary>
<TestClass()> _
Public Class dsADS_Config_ProblemRowTest


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
'''A test for VPNProblem
'''</summary>
<TestMethod()>  _
Public Sub VPNProblemTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.Config_ProblemRow = New dsADS.Config_ProblemRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    target.VPNProblem = expected
    actual = target.VPNProblem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for VPNAdminsID
'''</summary>
<TestMethod()>  _
Public Sub VPNAdminsIDTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.Config_ProblemRow = New dsADS.Config_ProblemRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Long = 0 ' TODO: Initialize to an appropriate value
    Dim actual As Long
    target.VPNAdminsID = expected
    actual = target.VPNAdminsID
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Surname
'''</summary>
<TestMethod()>  _
Public Sub SurnameTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.Config_ProblemRow = New dsADS.Config_ProblemRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.Surname = expected
    actual = target.Surname
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ProblemSolved
'''</summary>
<TestMethod()>  _
Public Sub ProblemSolvedTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.Config_ProblemRow = New dsADS.Config_ProblemRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    target.ProblemSolved = expected
    actual = target.ProblemSolved
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Problem
'''</summary>
<TestMethod()>  _
Public Sub ProblemTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.Config_ProblemRow = New dsADS.Config_ProblemRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.Problem = expected
    actual = target.Problem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for PolicyProblem
'''</summary>
<TestMethod()>  _
Public Sub PolicyProblemTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.Config_ProblemRow = New dsADS.Config_ProblemRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    target.PolicyProblem = expected
    actual = target.PolicyProblem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Persalno
'''</summary>
<TestMethod()>  _
Public Sub PersalnoTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.Config_ProblemRow = New dsADS.Config_ProblemRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.Persalno = expected
    actual = target.Persalno
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Name
'''</summary>
<TestMethod()>  _
Public Sub NameTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.Config_ProblemRow = New dsADS.Config_ProblemRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.Name = expected
    actual = target.Name
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ID
'''</summary>
<TestMethod()>  _
Public Sub IDTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.Config_ProblemRow = New dsADS.Config_ProblemRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Long = 0 ' TODO: Initialize to an appropriate value
    Dim actual As Long
    target.ID = expected
    actual = target.ID
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DeptCode
'''</summary>
<TestMethod()>  _
Public Sub DeptCodeTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.Config_ProblemRow = New dsADS.Config_ProblemRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.DeptCode = expected
    actual = target.DeptCode
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Datetime
'''</summary>
<TestMethod()>  _
Public Sub DatetimeTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.Config_ProblemRow = New dsADS.Config_ProblemRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As DateTime = New DateTime ' TODO: Initialize to an appropriate value
    Dim actual As DateTime
    target.Datetime = expected
    actual = target.Datetime
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for SetVPNProblemNull
'''</summary>
<TestMethod()>  _
Public Sub SetVPNProblemNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.Config_ProblemRow = New dsADS.Config_ProblemRow(rb) ' TODO: Initialize to an appropriate value
    target.SetVPNProblemNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for SetVPNAdminsIDNull
'''</summary>
<TestMethod()>  _
Public Sub SetVPNAdminsIDNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.Config_ProblemRow = New dsADS.Config_ProblemRow(rb) ' TODO: Initialize to an appropriate value
    target.SetVPNAdminsIDNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for SetProblemSolvedNull
'''</summary>
<TestMethod()>  _
Public Sub SetProblemSolvedNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.Config_ProblemRow = New dsADS.Config_ProblemRow(rb) ' TODO: Initialize to an appropriate value
    target.SetProblemSolvedNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for SetPolicyProblemNull
'''</summary>
<TestMethod()>  _
Public Sub SetPolicyProblemNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.Config_ProblemRow = New dsADS.Config_ProblemRow(rb) ' TODO: Initialize to an appropriate value
    target.SetPolicyProblemNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for IsVPNProblemNull
'''</summary>
<TestMethod()>  _
Public Sub IsVPNProblemNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.Config_ProblemRow = New dsADS.Config_ProblemRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsVPNProblemNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IsVPNAdminsIDNull
'''</summary>
<TestMethod()>  _
Public Sub IsVPNAdminsIDNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.Config_ProblemRow = New dsADS.Config_ProblemRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsVPNAdminsIDNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IsProblemSolvedNull
'''</summary>
<TestMethod()>  _
Public Sub IsProblemSolvedNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.Config_ProblemRow = New dsADS.Config_ProblemRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsProblemSolvedNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IsPolicyProblemNull
'''</summary>
<TestMethod()>  _
Public Sub IsPolicyProblemNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.Config_ProblemRow = New dsADS.Config_ProblemRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsPolicyProblemNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Config_ProblemRow Constructor
'''</summary>
<TestMethod()>  _
Public Sub dsADS_Config_ProblemRowConstructorTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
    Dim target As dsADS.Config_ProblemRow = New dsADS.Config_ProblemRow(rb)
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub
End Class
