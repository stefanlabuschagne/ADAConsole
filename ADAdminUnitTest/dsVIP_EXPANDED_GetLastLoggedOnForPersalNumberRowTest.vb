Imports System

Imports System.Data

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports ADAdminDotNet



'''<summary>
'''This is a test class for dsVIP_EXPANDED_GetLastLoggedOnForPersalNumberRowTest and is intended
'''to contain all dsVIP_EXPANDED_GetLastLoggedOnForPersalNumberRowTest Unit Tests
'''</summary>
<TestClass()> _
Public Class dsVIP_EXPANDED_GetLastLoggedOnForPersalNumberRowTest


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
'''A test for date_stamp
'''</summary>
<TestMethod()>  _
Public Sub date_stampTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsVIP_EXPANDED.GetLastLoggedOnForPersalNumberRow = New dsVIP_EXPANDED.GetLastLoggedOnForPersalNumberRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As DateTime = New DateTime ' TODO: Initialize to an appropriate value
    Dim actual As DateTime
    target.date_stamp = expected
    actual = target.date_stamp
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Setdate_stampNull
'''</summary>
<TestMethod()>  _
Public Sub Setdate_stampNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsVIP_EXPANDED.GetLastLoggedOnForPersalNumberRow = New dsVIP_EXPANDED.GetLastLoggedOnForPersalNumberRow(rb) ' TODO: Initialize to an appropriate value
    target.Setdate_stampNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for Isdate_stampNull
'''</summary>
<TestMethod()>  _
Public Sub Isdate_stampNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsVIP_EXPANDED.GetLastLoggedOnForPersalNumberRow = New dsVIP_EXPANDED.GetLastLoggedOnForPersalNumberRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.Isdate_stampNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for GetLastLoggedOnForPersalNumberRow Constructor
'''</summary>
<TestMethod()>  _
Public Sub dsVIP_EXPANDED_GetLastLoggedOnForPersalNumberRowConstructorTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
    Dim target As dsVIP_EXPANDED.GetLastLoggedOnForPersalNumberRow = New dsVIP_EXPANDED.GetLastLoggedOnForPersalNumberRow(rb)
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub
End Class
