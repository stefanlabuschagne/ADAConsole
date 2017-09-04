Imports System

Imports System.Data

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports ADAdminDotNet



'''<summary>
'''This is a test class for dsARSystemDataSet_CustNotifyRowTest and is intended
'''to contain all dsARSystemDataSet_CustNotifyRowTest Unit Tests
'''</summary>
<TestClass()> _
Public Class dsARSystemDataSet_CustNotifyRowTest


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
'''A test for Solution
'''</summary>
<TestMethod()>  _
Public Sub SolutionTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.CustNotifyRow = New dsARSystemDataSet.CustNotifyRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.Solution = expected
    actual = target.Solution
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Request_No
'''</summary>
<TestMethod()>  _
Public Sub Request_NoTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.CustNotifyRow = New dsARSystemDataSet.CustNotifyRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.Request_No = expected
    actual = target.Request_No
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Persal_Number
'''</summary>
<TestMethod()>  _
Public Sub Persal_NumberTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.CustNotifyRow = New dsARSystemDataSet.CustNotifyRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.Persal_Number = expected
    actual = target.Persal_Number
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Long_Description
'''</summary>
<TestMethod()>  _
Public Sub Long_DescriptionTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.CustNotifyRow = New dsARSystemDataSet.CustNotifyRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.Long_Description = expected
    actual = target.Long_Description
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for First_Name
'''</summary>
<TestMethod()>  _
Public Sub First_NameTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.CustNotifyRow = New dsARSystemDataSet.CustNotifyRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.First_Name = expected
    actual = target.First_Name
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Entry_Date
'''</summary>
<TestMethod()>  _
Public Sub Entry_DateTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.CustNotifyRow = New dsARSystemDataSet.CustNotifyRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As DateTime = New DateTime ' TODO: Initialize to an appropriate value
    Dim actual As DateTime
    target.Entry_Date = expected
    actual = target.Entry_Date
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for E_Mail
'''</summary>
<TestMethod()>  _
Public Sub E_MailTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.CustNotifyRow = New dsARSystemDataSet.CustNotifyRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.E_Mail = expected
    actual = target.E_Mail
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for SetSolutionNull
'''</summary>
<TestMethod()>  _
Public Sub SetSolutionNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.CustNotifyRow = New dsARSystemDataSet.CustNotifyRow(rb) ' TODO: Initialize to an appropriate value
    target.SetSolutionNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for SetPersal_NumberNull
'''</summary>
<TestMethod()>  _
Public Sub SetPersal_NumberNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.CustNotifyRow = New dsARSystemDataSet.CustNotifyRow(rb) ' TODO: Initialize to an appropriate value
    target.SetPersal_NumberNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for SetLong_DescriptionNull
'''</summary>
<TestMethod()>  _
Public Sub SetLong_DescriptionNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.CustNotifyRow = New dsARSystemDataSet.CustNotifyRow(rb) ' TODO: Initialize to an appropriate value
    target.SetLong_DescriptionNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for SetFirst_NameNull
'''</summary>
<TestMethod()>  _
Public Sub SetFirst_NameNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.CustNotifyRow = New dsARSystemDataSet.CustNotifyRow(rb) ' TODO: Initialize to an appropriate value
    target.SetFirst_NameNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for SetEntry_DateNull
'''</summary>
<TestMethod()>  _
Public Sub SetEntry_DateNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.CustNotifyRow = New dsARSystemDataSet.CustNotifyRow(rb) ' TODO: Initialize to an appropriate value
    target.SetEntry_DateNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for SetE_MailNull
'''</summary>
<TestMethod()>  _
Public Sub SetE_MailNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.CustNotifyRow = New dsARSystemDataSet.CustNotifyRow(rb) ' TODO: Initialize to an appropriate value
    target.SetE_MailNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for IsSolutionNull
'''</summary>
<TestMethod()>  _
Public Sub IsSolutionNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.CustNotifyRow = New dsARSystemDataSet.CustNotifyRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsSolutionNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IsPersal_NumberNull
'''</summary>
<TestMethod()>  _
Public Sub IsPersal_NumberNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.CustNotifyRow = New dsARSystemDataSet.CustNotifyRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsPersal_NumberNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IsLong_DescriptionNull
'''</summary>
<TestMethod()>  _
Public Sub IsLong_DescriptionNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.CustNotifyRow = New dsARSystemDataSet.CustNotifyRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsLong_DescriptionNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IsFirst_NameNull
'''</summary>
<TestMethod()>  _
Public Sub IsFirst_NameNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.CustNotifyRow = New dsARSystemDataSet.CustNotifyRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsFirst_NameNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IsEntry_DateNull
'''</summary>
<TestMethod()>  _
Public Sub IsEntry_DateNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.CustNotifyRow = New dsARSystemDataSet.CustNotifyRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsEntry_DateNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IsE_MailNull
'''</summary>
<TestMethod()>  _
Public Sub IsE_MailNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.CustNotifyRow = New dsARSystemDataSet.CustNotifyRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsE_MailNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for CustNotifyRow Constructor
'''</summary>
<TestMethod()>  _
Public Sub dsARSystemDataSet_CustNotifyRowConstructorTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
    Dim target As dsARSystemDataSet.CustNotifyRow = New dsARSystemDataSet.CustNotifyRow(rb)
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub
End Class
