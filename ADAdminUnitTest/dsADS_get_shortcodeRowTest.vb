﻿Imports System.Data

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports ADAdminDotNet



'''<summary>
'''This is a test class for dsADS_get_shortcodeRowTest and is intended
'''to contain all dsADS_get_shortcodeRowTest Unit Tests
'''</summary>
<TestClass()> _
Public Class dsADS_get_shortcodeRowTest


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
'''A test for SNAME
'''</summary>
<TestMethod()>  _
Public Sub SNAMETest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.get_shortcodeRow = New dsADS.get_shortcodeRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.SNAME = expected
    actual = target.SNAME
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for SetSNAMENull
'''</summary>
<TestMethod()>  _
Public Sub SetSNAMENullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.get_shortcodeRow = New dsADS.get_shortcodeRow(rb) ' TODO: Initialize to an appropriate value
    target.SetSNAMENull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for IsSNAMENull
'''</summary>
<TestMethod()>  _
Public Sub IsSNAMENullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.get_shortcodeRow = New dsADS.get_shortcodeRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsSNAMENull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for get_shortcodeRow Constructor
'''</summary>
<TestMethod()>  _
Public Sub dsADS_get_shortcodeRowConstructorTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
    Dim target As dsADS.get_shortcodeRow = New dsADS.get_shortcodeRow(rb)
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub
End Class
