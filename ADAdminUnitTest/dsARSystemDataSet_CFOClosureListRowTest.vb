Imports System

Imports System.Data

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports ADAdminDotNet



'''<summary>
'''This is a test class for dsARSystemDataSet_CFOClosureListRowTest and is intended
'''to contain all dsARSystemDataSet_CFOClosureListRowTest Unit Tests
'''</summary>
<TestClass()> _
Public Class dsARSystemDataSet_CFOClosureListRowTest


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
'''A test for TITLE
'''</summary>
<TestMethod()>  _
Public Sub TITLETest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.CFOClosureListRow = New dsARSystemDataSet.CFOClosureListRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.TITLE = expected
    actual = target.TITLE
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for SURNAME
'''</summary>
<TestMethod()>  _
Public Sub SURNAMETest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.CFOClosureListRow = New dsARSystemDataSet.CFOClosureListRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.SURNAME = expected
    actual = target.SURNAME
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for RESPONSIBILITY
'''</summary>
<TestMethod()>  _
Public Sub RESPONSIBILITYTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.CFOClosureListRow = New dsARSystemDataSet.CFOClosureListRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.RESPONSIBILITY = expected
    actual = target.RESPONSIBILITY
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for REQ_LOGIS
'''</summary>
<TestMethod()>  _
Public Sub REQ_LOGISTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.CFOClosureListRow = New dsARSystemDataSet.CFOClosureListRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Short = 0 ' TODO: Initialize to an appropriate value
    Dim actual As Short
    target.REQ_LOGIS = expected
    actual = target.REQ_LOGIS
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for REQ_HR
'''</summary>
<TestMethod()>  _
Public Sub REQ_HRTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.CFOClosureListRow = New dsARSystemDataSet.CFOClosureListRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Short = 0 ' TODO: Initialize to an appropriate value
    Dim actual As Short
    target.REQ_HR = expected
    actual = target.REQ_HR
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for REQ_FINANCIALS
'''</summary>
<TestMethod()>  _
Public Sub REQ_FINANCIALSTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.CFOClosureListRow = New dsARSystemDataSet.CFOClosureListRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Short = 0 ' TODO: Initialize to an appropriate value
    Dim actual As Short
    target.REQ_FINANCIALS = expected
    actual = target.REQ_FINANCIALS
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for RANK
'''</summary>
<TestMethod()>  _
Public Sub RANKTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.CFOClosureListRow = New dsARSystemDataSet.CFOClosureListRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.RANK = expected
    actual = target.RANK
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for NOTES
'''</summary>
<TestMethod()>  _
Public Sub NOTESTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.CFOClosureListRow = New dsARSystemDataSet.CFOClosureListRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.NOTES = expected
    actual = target.NOTES
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for FIRSTNAME
'''</summary>
<TestMethod()>  _
Public Sub FIRSTNAMETest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.CFOClosureListRow = New dsARSystemDataSet.CFOClosureListRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.FIRSTNAME = expected
    actual = target.FIRSTNAME
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for FAX_TEL
'''</summary>
<TestMethod()>  _
Public Sub FAX_TELTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.CFOClosureListRow = New dsARSystemDataSet.CFOClosureListRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.FAX_TEL = expected
    actual = target.FAX_TEL
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for EMAIL
'''</summary>
<TestMethod()>  _
Public Sub EMAILTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.CFOClosureListRow = New dsARSystemDataSet.CFOClosureListRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.EMAIL = expected
    actual = target.EMAIL
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DONE
'''</summary>
<TestMethod()>  _
Public Sub DONETest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.CFOClosureListRow = New dsARSystemDataSet.CFOClosureListRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Integer = 0 ' TODO: Initialize to an appropriate value
    Dim actual As Integer
    target.DONE = expected
    actual = target.DONE
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DATETIME
'''</summary>
<TestMethod()>  _
Public Sub DATETIMETest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.CFOClosureListRow = New dsARSystemDataSet.CFOClosureListRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As DateTime = New DateTime ' TODO: Initialize to an appropriate value
    Dim actual As DateTime
    target.DATETIME = expected
    actual = target.DATETIME
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for CREATED
'''</summary>
<TestMethod()>  _
Public Sub CREATEDTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.CFOClosureListRow = New dsARSystemDataSet.CFOClosureListRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As DateTime = New DateTime ' TODO: Initialize to an appropriate value
    Dim actual As DateTime
    target.CREATED = expected
    actual = target.CREATED
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for CLIENTNUMBER
'''</summary>
<TestMethod()>  _
Public Sub CLIENTNUMBERTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.CFOClosureListRow = New dsARSystemDataSet.CFOClosureListRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.CLIENTNUMBER = expected
    actual = target.CLIENTNUMBER
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for CEL_TEL
'''</summary>
<TestMethod()>  _
Public Sub CEL_TELTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.CFOClosureListRow = New dsARSystemDataSet.CFOClosureListRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.CEL_TEL = expected
    actual = target.CEL_TEL
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for BUS_TEL
'''</summary>
<TestMethod()>  _
Public Sub BUS_TELTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.CFOClosureListRow = New dsARSystemDataSet.CFOClosureListRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.BUS_TEL = expected
    actual = target.BUS_TEL
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ACTIVITY
'''</summary>
<TestMethod()>  _
Public Sub ACTIVITYTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.CFOClosureListRow = New dsARSystemDataSet.CFOClosureListRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.ACTIVITY = expected
    actual = target.ACTIVITY
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for SetNOTESNull
'''</summary>
<TestMethod()>  _
Public Sub SetNOTESNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.CFOClosureListRow = New dsARSystemDataSet.CFOClosureListRow(rb) ' TODO: Initialize to an appropriate value
    target.SetNOTESNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for IsNOTESNull
'''</summary>
<TestMethod()>  _
Public Sub IsNOTESNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.CFOClosureListRow = New dsARSystemDataSet.CFOClosureListRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsNOTESNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for CFOClosureListRow Constructor
'''</summary>
<TestMethod()>  _
Public Sub dsARSystemDataSet_CFOClosureListRowConstructorTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
    Dim target As dsARSystemDataSet.CFOClosureListRow = New dsARSystemDataSet.CFOClosureListRow(rb)
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub
End Class
