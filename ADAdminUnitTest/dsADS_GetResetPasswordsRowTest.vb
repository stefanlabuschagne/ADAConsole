Imports System.Data

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports ADAdminDotNet



'''<summary>
'''This is a test class for dsADS_GetResetPasswordsRowTest and is intended
'''to contain all dsADS_GetResetPasswordsRowTest Unit Tests
'''</summary>
<TestClass()> _
Public Class dsADS_GetResetPasswordsRowTest


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
'''A test for Expr1
'''</summary>
<TestMethod()>  _
Public Sub Expr1Test()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.GetResetPasswordsRow = New dsADS.GetResetPasswordsRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Integer = 0 ' TODO: Initialize to an appropriate value
    Dim actual As Integer
    target.Expr1 = expected
    actual = target.Expr1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for SetExpr1Null
'''</summary>
<TestMethod()>  _
Public Sub SetExpr1NullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.GetResetPasswordsRow = New dsADS.GetResetPasswordsRow(rb) ' TODO: Initialize to an appropriate value
    target.SetExpr1Null
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for IsExpr1Null
'''</summary>
<TestMethod()>  _
Public Sub IsExpr1NullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.GetResetPasswordsRow = New dsADS.GetResetPasswordsRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsExpr1Null
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for GetResetPasswordsRow Constructor
'''</summary>
<TestMethod()>  _
Public Sub dsADS_GetResetPasswordsRowConstructorTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
    Dim target As dsADS.GetResetPasswordsRow = New dsADS.GetResetPasswordsRow(rb)
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub
End Class
