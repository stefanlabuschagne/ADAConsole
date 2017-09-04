Imports System

Imports System.Data

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports ADAdminDotNet



'''<summary>
'''This is a test class for dsADS_AD_SNAPSHOT_USER_COUNTRowTest and is intended
'''to contain all dsADS_AD_SNAPSHOT_USER_COUNTRowTest Unit Tests
'''</summary>
<TestClass()> _
Public Class dsADS_AD_SNAPSHOT_USER_COUNTRowTest


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
'''A test for User_Count_Enabled
'''</summary>
<TestMethod()>  _
Public Sub User_Count_EnabledTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.AD_SNAPSHOT_USER_COUNTRow = New dsADS.AD_SNAPSHOT_USER_COUNTRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Integer = 0 ' TODO: Initialize to an appropriate value
    Dim actual As Integer
    target.User_Count_Enabled = expected
    actual = target.User_Count_Enabled
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for User_Count_Disabled
'''</summary>
<TestMethod()>  _
Public Sub User_Count_DisabledTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.AD_SNAPSHOT_USER_COUNTRow = New dsADS.AD_SNAPSHOT_USER_COUNTRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Integer = 0 ' TODO: Initialize to an appropriate value
    Dim actual As Integer
    target.User_Count_Disabled = expected
    actual = target.User_Count_Disabled
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for User_Count
'''</summary>
<TestMethod()>  _
Public Sub User_CountTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.AD_SNAPSHOT_USER_COUNTRow = New dsADS.AD_SNAPSHOT_USER_COUNTRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Integer = 0 ' TODO: Initialize to an appropriate value
    Dim actual As Integer
    target.User_Count = expected
    actual = target.User_Count
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for UCount_Date
'''</summary>
<TestMethod()>  _
Public Sub UCount_DateTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.AD_SNAPSHOT_USER_COUNTRow = New dsADS.AD_SNAPSHOT_USER_COUNTRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As DateTime = New DateTime ' TODO: Initialize to an appropriate value
    Dim actual As DateTime
    target.UCount_Date = expected
    actual = target.UCount_Date
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ID
'''</summary>
<TestMethod()>  _
Public Sub IDTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.AD_SNAPSHOT_USER_COUNTRow = New dsADS.AD_SNAPSHOT_USER_COUNTRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Long = 0 ' TODO: Initialize to an appropriate value
    Dim actual As Long
    target.ID = expected
    actual = target.ID
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for AD_SNAPSHOT_USER_COUNTRow Constructor
'''</summary>
<TestMethod()>  _
Public Sub dsADS_AD_SNAPSHOT_USER_COUNTRowConstructorTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
    Dim target As dsADS.AD_SNAPSHOT_USER_COUNTRow = New dsADS.AD_SNAPSHOT_USER_COUNTRow(rb)
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub
End Class
