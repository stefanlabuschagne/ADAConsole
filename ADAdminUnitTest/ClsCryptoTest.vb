Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports ADAdminDotNet

'''<summary>
'''This is a test class for ClsCryptoTest and is intended
'''to contain all ClsCryptoTest Unit Tests
'''</summary>
<TestClass()> _
Public Class ClsCryptoTest

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
            testContextInstance = value
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
    '''A test for VerifyHash
    '''</summary>
    <TestMethod()> _
    Public Sub VerifyHashTest()
        Dim target As ClsCrypto = New ClsCrypto ' TODO: Initialize to an appropriate value
        Dim strPlainText As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim strHashValue As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim expected As Boolean = False ' TODO: Initialize to an appropriate value
        Dim actual As Boolean
        actual = target.VerifyHash(strPlainText, strHashValue)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for kodeer128
    '''</summary>
    <TestMethod()> _
    Public Sub kodeer128Test()
        Dim target As ClsCrypto = New ClsCrypto ' TODO: Initialize to an appropriate value
        Dim strPlainText As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim actual As String
        actual = target.kodeer128(strPlainText)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for Dekodeer128
    '''</summary>
    <TestMethod()> _
    Public Sub Dekodeer128Test()
        Dim target As ClsCrypto = New ClsCrypto ' TODO: Initialize to an appropriate value
        Dim strCryptText As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim actual As String
        actual = target.Dekodeer128(strCryptText)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for ConvertKeyToBytes
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ADAdminDotNet.exe")> _
    Public Sub ConvertKeyToBytesTest()
        Dim target As ClsCrypto_Accessor = New ClsCrypto_Accessor ' TODO: Initialize to an appropriate value
        Dim strKey As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim expected() As Byte = Nothing ' TODO: Initialize to an appropriate value
        Dim actual() As Byte
        actual = target.ConvertKeyToBytes(strKey)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for ConcatBytes
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ADAdminDotNet.exe")> _
    Public Sub ConcatBytesTest()
        Dim target As ClsCrypto_Accessor = New ClsCrypto_Accessor ' TODO: Initialize to an appropriate value
        Dim bytA() As Byte = Nothing ' TODO: Initialize to an appropriate value
        Dim bytB() As Byte = Nothing ' TODO: Initialize to an appropriate value
        Dim expected() As Byte = Nothing ' TODO: Initialize to an appropriate value
        Dim actual() As Byte
        actual = target.ConcatBytes(bytA, bytB)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for ComputeMD5Hash
    '''</summary>
    <TestMethod()> _
    Public Sub ComputeMD5HashTest()
        Dim target As ClsCrypto = New ClsCrypto ' TODO: Initialize to an appropriate value
        Dim strPlainText As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim bytSalt() As Byte = Nothing ' TODO: Initialize to an appropriate value
        Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim actual As String
        actual = target.ComputeMD5Hash(strPlainText, bytSalt)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for ClsCrypto Constructor
    '''</summary>
    <TestMethod()> _
    Public Sub ClsCryptoConstructorTest()
        Dim target As ClsCrypto = New ClsCrypto
        Assert.Inconclusive("TODO: Implement code to verify target")
    End Sub
End Class
