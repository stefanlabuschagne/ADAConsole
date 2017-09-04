Imports System

Imports System.Data

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports ADAdminDotNet



'''<summary>
'''This is a test class for dsADS_CustomerInfoRowTest and is intended
'''to contain all dsADS_CustomerInfoRowTest Unit Tests
'''</summary>
<TestClass()> _
Public Class dsADS_CustomerInfoRowTest


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
'''A test for Time_Date
'''</summary>
<TestMethod()>  _
Public Sub Time_DateTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.CustomerInfoRow = New dsADS.CustomerInfoRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As DateTime = New DateTime ' TODO: Initialize to an appropriate value
    Dim actual As DateTime
    target.Time_Date = expected
    actual = target.Time_Date
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ReqNo
'''</summary>
<TestMethod()>  _
Public Sub ReqNoTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.CustomerInfoRow = New dsADS.CustomerInfoRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.ReqNo = expected
    actual = target.ReqNo
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ID
'''</summary>
<TestMethod()>  _
Public Sub IDTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.CustomerInfoRow = New dsADS.CustomerInfoRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Long = 0 ' TODO: Initialize to an appropriate value
    Dim actual As Long
    target.ID = expected
    actual = target.ID
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for e_mail
'''</summary>
<TestMethod()>  _
Public Sub e_mailTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.CustomerInfoRow = New dsADS.CustomerInfoRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.e_mail = expected
    actual = target.e_mail
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for CustomerInfoRow Constructor
'''</summary>
<TestMethod()>  _
Public Sub dsADS_CustomerInfoRowConstructorTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
    Dim target As dsADS.CustomerInfoRow = New dsADS.CustomerInfoRow(rb)
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub
End Class
