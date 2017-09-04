Imports System.Data

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports ADAdminDotNet



'''<summary>
'''This is a test class for dsADS_CFO_Letters_YearMonthRowTest and is intended
'''to contain all dsADS_CFO_Letters_YearMonthRowTest Unit Tests
'''</summary>
<TestClass()> _
Public Class dsADS_CFO_Letters_YearMonthRowTest


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
'''A test for YearDate
'''</summary>
<TestMethod()>  _
Public Sub YearDateTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.CFO_Letters_YearMonthRow = New dsADS.CFO_Letters_YearMonthRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.YearDate = expected
    actual = target.YearDate
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for CFO_Letters_Sent
'''</summary>
<TestMethod()>  _
Public Sub CFO_Letters_SentTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.CFO_Letters_YearMonthRow = New dsADS.CFO_Letters_YearMonthRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Integer = 0 ' TODO: Initialize to an appropriate value
    Dim actual As Integer
    target.CFO_Letters_Sent = expected
    actual = target.CFO_Letters_Sent
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for SetYearDateNull
'''</summary>
<TestMethod()>  _
Public Sub SetYearDateNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.CFO_Letters_YearMonthRow = New dsADS.CFO_Letters_YearMonthRow(rb) ' TODO: Initialize to an appropriate value
    target.SetYearDateNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for SetCFO_Letters_SentNull
'''</summary>
<TestMethod()>  _
Public Sub SetCFO_Letters_SentNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.CFO_Letters_YearMonthRow = New dsADS.CFO_Letters_YearMonthRow(rb) ' TODO: Initialize to an appropriate value
    target.SetCFO_Letters_SentNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for IsYearDateNull
'''</summary>
<TestMethod()>  _
Public Sub IsYearDateNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.CFO_Letters_YearMonthRow = New dsADS.CFO_Letters_YearMonthRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsYearDateNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IsCFO_Letters_SentNull
'''</summary>
<TestMethod()>  _
Public Sub IsCFO_Letters_SentNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.CFO_Letters_YearMonthRow = New dsADS.CFO_Letters_YearMonthRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsCFO_Letters_SentNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for CFO_Letters_YearMonthRow Constructor
'''</summary>
<TestMethod()>  _
Public Sub dsADS_CFO_Letters_YearMonthRowConstructorTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
    Dim target As dsADS.CFO_Letters_YearMonthRow = New dsADS.CFO_Letters_YearMonthRow(rb)
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub
End Class
