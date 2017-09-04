Imports System

Imports System.Data

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports ADAdminDotNet



'''<summary>
'''This is a test class for dsADS_CFOApprovalRowTest and is intended
'''to contain all dsADS_CFOApprovalRowTest Unit Tests
'''</summary>
<TestClass()> _
Public Class dsADS_CFOApprovalRowTest


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
'''A test for VulCompleted
'''</summary>
<TestMethod()>  _
Public Sub VulCompletedTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.CFOApprovalRow = New dsADS.CFOApprovalRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As DateTime = New DateTime ' TODO: Initialize to an appropriate value
    Dim actual As DateTime
    target.VulCompleted = expected
    actual = target.VulCompleted
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for VULComments
'''</summary>
<TestMethod()>  _
Public Sub VULCommentsTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.CFOApprovalRow = New dsADS.CFOApprovalRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.VULComments = expected
    actual = target.VULComments
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for RequestNo
'''</summary>
<TestMethod()>  _
Public Sub RequestNoTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.CFOApprovalRow = New dsADS.CFOApprovalRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.RequestNo = expected
    actual = target.RequestNo
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for NTDate
'''</summary>
<TestMethod()>  _
Public Sub NTDateTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.CFOApprovalRow = New dsADS.CFOApprovalRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As DateTime = New DateTime ' TODO: Initialize to an appropriate value
    Dim actual As DateTime
    target.NTDate = expected
    actual = target.NTDate
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for NTComments
'''</summary>
<TestMethod()>  _
Public Sub NTCommentsTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.CFOApprovalRow = New dsADS.CFOApprovalRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.NTComments = expected
    actual = target.NTComments
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Isrunning
'''</summary>
<TestMethod()>  _
Public Sub IsrunningTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.CFOApprovalRow = New dsADS.CFOApprovalRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    target.Isrunning = expected
    actual = target.Isrunning
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for FlowDescription
'''</summary>
<TestMethod()>  _
Public Sub FlowDescriptionTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.CFOApprovalRow = New dsADS.CFOApprovalRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.FlowDescription = expected
    actual = target.FlowDescription
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for CFODate
'''</summary>
<TestMethod()>  _
Public Sub CFODateTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.CFOApprovalRow = New dsADS.CFOApprovalRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As DateTime = New DateTime ' TODO: Initialize to an appropriate value
    Dim actual As DateTime
    target.CFODate = expected
    actual = target.CFODate
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for CFOComments
'''</summary>
<TestMethod()>  _
Public Sub CFOCommentsTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.CFOApprovalRow = New dsADS.CFOApprovalRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.CFOComments = expected
    actual = target.CFOComments
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Active
'''</summary>
<TestMethod()>  _
Public Sub ActiveTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.CFOApprovalRow = New dsADS.CFOApprovalRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    target.Active = expected
    actual = target.Active
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for SetVulCompletedNull
'''</summary>
<TestMethod()>  _
Public Sub SetVulCompletedNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.CFOApprovalRow = New dsADS.CFOApprovalRow(rb) ' TODO: Initialize to an appropriate value
    target.SetVulCompletedNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for SetNTDateNull
'''</summary>
<TestMethod()>  _
Public Sub SetNTDateNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.CFOApprovalRow = New dsADS.CFOApprovalRow(rb) ' TODO: Initialize to an appropriate value
    target.SetNTDateNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for SetFlowDescriptionNull
'''</summary>
<TestMethod()>  _
Public Sub SetFlowDescriptionNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.CFOApprovalRow = New dsADS.CFOApprovalRow(rb) ' TODO: Initialize to an appropriate value
    target.SetFlowDescriptionNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for SetCFODateNull
'''</summary>
<TestMethod()>  _
Public Sub SetCFODateNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.CFOApprovalRow = New dsADS.CFOApprovalRow(rb) ' TODO: Initialize to an appropriate value
    target.SetCFODateNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for IsVulCompletedNull
'''</summary>
<TestMethod()>  _
Public Sub IsVulCompletedNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.CFOApprovalRow = New dsADS.CFOApprovalRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsVulCompletedNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IsNTDateNull
'''</summary>
<TestMethod()>  _
Public Sub IsNTDateNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.CFOApprovalRow = New dsADS.CFOApprovalRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsNTDateNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IsFlowDescriptionNull
'''</summary>
<TestMethod()>  _
Public Sub IsFlowDescriptionNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.CFOApprovalRow = New dsADS.CFOApprovalRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsFlowDescriptionNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IsCFODateNull
'''</summary>
<TestMethod()>  _
Public Sub IsCFODateNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.CFOApprovalRow = New dsADS.CFOApprovalRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsCFODateNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for CFOApprovalRow Constructor
'''</summary>
<TestMethod()>  _
Public Sub dsADS_CFOApprovalRowConstructorTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
    Dim target As dsADS.CFOApprovalRow = New dsADS.CFOApprovalRow(rb)
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub
End Class
