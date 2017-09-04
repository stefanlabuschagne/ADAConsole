Imports System.Data

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports ADAdminDotNet



'''<summary>
'''This is a test class for dsADS_EstablishmentRowTest and is intended
'''to contain all dsADS_EstablishmentRowTest Unit Tests
'''</summary>
<TestClass()> _
Public Class dsADS_EstablishmentRowTest


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
'''A test for SUR_INI
'''</summary>
<TestMethod()>  _
Public Sub SUR_INITest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.EstablishmentRow = New dsADS.EstablishmentRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.SUR_INI = expected
    actual = target.SUR_INI
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for SNAME
'''</summary>
<TestMethod()>  _
Public Sub SNAMETest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.EstablishmentRow = New dsADS.EstablishmentRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.SNAME = expected
    actual = target.SNAME
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for RANKDESC
'''</summary>
<TestMethod()>  _
Public Sub RANKDESCTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.EstablishmentRow = New dsADS.EstablishmentRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.RANKDESC = expected
    actual = target.RANKDESC
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for PROVDESC
'''</summary>
<TestMethod()>  _
Public Sub PROVDESCTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.EstablishmentRow = New dsADS.EstablishmentRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.PROVDESC = expected
    actual = target.PROVDESC
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for PERSALNR
'''</summary>
<TestMethod()>  _
Public Sub PERSALNRTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.EstablishmentRow = New dsADS.EstablishmentRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.PERSALNR = expected
    actual = target.PERSALNR
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for PAYPOINT
'''</summary>
<TestMethod()>  _
Public Sub PAYPOINTTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.EstablishmentRow = New dsADS.EstablishmentRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.PAYPOINT = expected
    actual = target.PAYPOINT
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for PAYDIST
'''</summary>
<TestMethod()>  _
Public Sub PAYDISTTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.EstablishmentRow = New dsADS.EstablishmentRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.PAYDIST = expected
    actual = target.PAYDIST
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for JOBTITLE
'''</summary>
<TestMethod()>  _
Public Sub JOBTITLETest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.EstablishmentRow = New dsADS.EstablishmentRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.JOBTITLE = expected
    actual = target.JOBTITLE
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DEPTDESC
'''</summary>
<TestMethod()>  _
Public Sub DEPTDESCTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.EstablishmentRow = New dsADS.EstablishmentRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.DEPTDESC = expected
    actual = target.DEPTDESC
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for APPTNAT
'''</summary>
<TestMethod()>  _
Public Sub APPTNATTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.EstablishmentRow = New dsADS.EstablishmentRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.APPTNAT = expected
    actual = target.APPTNAT
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for SetSUR_ININull
'''</summary>
<TestMethod()>  _
Public Sub SetSUR_ININullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.EstablishmentRow = New dsADS.EstablishmentRow(rb) ' TODO: Initialize to an appropriate value
    target.SetSUR_ININull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for SetSNAMENull
'''</summary>
<TestMethod()>  _
Public Sub SetSNAMENullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.EstablishmentRow = New dsADS.EstablishmentRow(rb) ' TODO: Initialize to an appropriate value
    target.SetSNAMENull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for SetRANKDESCNull
'''</summary>
<TestMethod()>  _
Public Sub SetRANKDESCNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.EstablishmentRow = New dsADS.EstablishmentRow(rb) ' TODO: Initialize to an appropriate value
    target.SetRANKDESCNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for SetPROVDESCNull
'''</summary>
<TestMethod()>  _
Public Sub SetPROVDESCNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.EstablishmentRow = New dsADS.EstablishmentRow(rb) ' TODO: Initialize to an appropriate value
    target.SetPROVDESCNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for SetPAYPOINTNull
'''</summary>
<TestMethod()>  _
Public Sub SetPAYPOINTNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.EstablishmentRow = New dsADS.EstablishmentRow(rb) ' TODO: Initialize to an appropriate value
    target.SetPAYPOINTNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for SetPAYDISTNull
'''</summary>
<TestMethod()>  _
Public Sub SetPAYDISTNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.EstablishmentRow = New dsADS.EstablishmentRow(rb) ' TODO: Initialize to an appropriate value
    target.SetPAYDISTNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for SetJOBTITLENull
'''</summary>
<TestMethod()>  _
Public Sub SetJOBTITLENullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.EstablishmentRow = New dsADS.EstablishmentRow(rb) ' TODO: Initialize to an appropriate value
    target.SetJOBTITLENull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for SetDEPTDESCNull
'''</summary>
<TestMethod()>  _
Public Sub SetDEPTDESCNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.EstablishmentRow = New dsADS.EstablishmentRow(rb) ' TODO: Initialize to an appropriate value
    target.SetDEPTDESCNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for SetAPPTNATNull
'''</summary>
<TestMethod()>  _
Public Sub SetAPPTNATNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.EstablishmentRow = New dsADS.EstablishmentRow(rb) ' TODO: Initialize to an appropriate value
    target.SetAPPTNATNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for IsSUR_ININull
'''</summary>
<TestMethod()>  _
Public Sub IsSUR_ININullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.EstablishmentRow = New dsADS.EstablishmentRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsSUR_ININull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IsSNAMENull
'''</summary>
<TestMethod()>  _
Public Sub IsSNAMENullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.EstablishmentRow = New dsADS.EstablishmentRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsSNAMENull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IsRANKDESCNull
'''</summary>
<TestMethod()>  _
Public Sub IsRANKDESCNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.EstablishmentRow = New dsADS.EstablishmentRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsRANKDESCNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IsPROVDESCNull
'''</summary>
<TestMethod()>  _
Public Sub IsPROVDESCNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.EstablishmentRow = New dsADS.EstablishmentRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsPROVDESCNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IsPAYPOINTNull
'''</summary>
<TestMethod()>  _
Public Sub IsPAYPOINTNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.EstablishmentRow = New dsADS.EstablishmentRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsPAYPOINTNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IsPAYDISTNull
'''</summary>
<TestMethod()>  _
Public Sub IsPAYDISTNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.EstablishmentRow = New dsADS.EstablishmentRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsPAYDISTNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IsJOBTITLENull
'''</summary>
<TestMethod()>  _
Public Sub IsJOBTITLENullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.EstablishmentRow = New dsADS.EstablishmentRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsJOBTITLENull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IsDEPTDESCNull
'''</summary>
<TestMethod()>  _
Public Sub IsDEPTDESCNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.EstablishmentRow = New dsADS.EstablishmentRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsDEPTDESCNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IsAPPTNATNull
'''</summary>
<TestMethod()>  _
Public Sub IsAPPTNATNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.EstablishmentRow = New dsADS.EstablishmentRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsAPPTNATNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for EstablishmentRow Constructor
'''</summary>
<TestMethod()>  _
Public Sub dsADS_EstablishmentRowConstructorTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
    Dim target As dsADS.EstablishmentRow = New dsADS.EstablishmentRow(rb)
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub
End Class
