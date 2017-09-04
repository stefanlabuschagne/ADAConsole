Imports System

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports ADAdminDotNet



'''<summary>
'''This is a test class for JoinViewRowPropertyDescriptorTest and is intended
'''to contain all JoinViewRowPropertyDescriptorTest Unit Tests
'''</summary>
<TestClass()> _
Public Class JoinViewRowPropertyDescriptorTest


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
'''A test for PropertyType
'''</summary>
<TestMethod()>  _
Public Sub PropertyTypeTest()
Dim ColumnName As String = String.Empty ' TODO: Initialize to an appropriate value
Dim ColumnIndex As Integer = 0 ' TODO: Initialize to an appropriate value
Dim ColumnType As Type = Nothing ' TODO: Initialize to an appropriate value
Dim ColumnIsReadOnly As Boolean = false ' TODO: Initialize to an appropriate value
Dim target As JoinViewRowPropertyDescriptor = New JoinViewRowPropertyDescriptor(ColumnName, ColumnIndex, ColumnType, ColumnIsReadOnly) ' TODO: Initialize to an appropriate value
    Dim actual As Type
    actual = target.PropertyType
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for IsReadOnly
'''</summary>
<TestMethod()>  _
Public Sub IsReadOnlyTest()
Dim ColumnName As String = String.Empty ' TODO: Initialize to an appropriate value
Dim ColumnIndex As Integer = 0 ' TODO: Initialize to an appropriate value
Dim ColumnType As Type = Nothing ' TODO: Initialize to an appropriate value
Dim ColumnIsReadOnly As Boolean = false ' TODO: Initialize to an appropriate value
Dim target As JoinViewRowPropertyDescriptor = New JoinViewRowPropertyDescriptor(ColumnName, ColumnIndex, ColumnType, ColumnIsReadOnly) ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsReadOnly
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ComponentType
'''</summary>
<TestMethod()>  _
Public Sub ComponentTypeTest()
Dim ColumnName As String = String.Empty ' TODO: Initialize to an appropriate value
Dim ColumnIndex As Integer = 0 ' TODO: Initialize to an appropriate value
Dim ColumnType As Type = Nothing ' TODO: Initialize to an appropriate value
Dim ColumnIsReadOnly As Boolean = false ' TODO: Initialize to an appropriate value
Dim target As JoinViewRowPropertyDescriptor = New JoinViewRowPropertyDescriptor(ColumnName, ColumnIndex, ColumnType, ColumnIsReadOnly) ' TODO: Initialize to an appropriate value
    Dim actual As Type
    actual = target.ComponentType
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ShouldSerializeValue
'''</summary>
<TestMethod()>  _
Public Sub ShouldSerializeValueTest()
Dim ColumnName As String = String.Empty ' TODO: Initialize to an appropriate value
Dim ColumnIndex As Integer = 0 ' TODO: Initialize to an appropriate value
Dim ColumnType As Type = Nothing ' TODO: Initialize to an appropriate value
Dim ColumnIsReadOnly As Boolean = false ' TODO: Initialize to an appropriate value
Dim target As JoinViewRowPropertyDescriptor = New JoinViewRowPropertyDescriptor(ColumnName, ColumnIndex, ColumnType, ColumnIsReadOnly) ' TODO: Initialize to an appropriate value
Dim component As Object = Nothing ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.ShouldSerializeValue(component)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for SetValue
'''</summary>
<TestMethod()>  _
Public Sub SetValueTest()
Dim ColumnName As String = String.Empty ' TODO: Initialize to an appropriate value
Dim ColumnIndex As Integer = 0 ' TODO: Initialize to an appropriate value
Dim ColumnType As Type = Nothing ' TODO: Initialize to an appropriate value
Dim ColumnIsReadOnly As Boolean = false ' TODO: Initialize to an appropriate value
Dim target As JoinViewRowPropertyDescriptor = New JoinViewRowPropertyDescriptor(ColumnName, ColumnIndex, ColumnType, ColumnIsReadOnly) ' TODO: Initialize to an appropriate value
Dim component As Object = Nothing ' TODO: Initialize to an appropriate value
Dim value As Object = Nothing ' TODO: Initialize to an appropriate value
    target.SetValue(component, value)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for ResetValue
'''</summary>
<TestMethod()>  _
Public Sub ResetValueTest()
Dim ColumnName As String = String.Empty ' TODO: Initialize to an appropriate value
Dim ColumnIndex As Integer = 0 ' TODO: Initialize to an appropriate value
Dim ColumnType As Type = Nothing ' TODO: Initialize to an appropriate value
Dim ColumnIsReadOnly As Boolean = false ' TODO: Initialize to an appropriate value
Dim target As JoinViewRowPropertyDescriptor = New JoinViewRowPropertyDescriptor(ColumnName, ColumnIndex, ColumnType, ColumnIsReadOnly) ' TODO: Initialize to an appropriate value
Dim component As Object = Nothing ' TODO: Initialize to an appropriate value
    target.ResetValue(component)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for GetValue
'''</summary>
<TestMethod()>  _
Public Sub GetValueTest()
Dim ColumnName As String = String.Empty ' TODO: Initialize to an appropriate value
Dim ColumnIndex As Integer = 0 ' TODO: Initialize to an appropriate value
Dim ColumnType As Type = Nothing ' TODO: Initialize to an appropriate value
Dim ColumnIsReadOnly As Boolean = false ' TODO: Initialize to an appropriate value
Dim target As JoinViewRowPropertyDescriptor = New JoinViewRowPropertyDescriptor(ColumnName, ColumnIndex, ColumnType, ColumnIsReadOnly) ' TODO: Initialize to an appropriate value
Dim component As Object = Nothing ' TODO: Initialize to an appropriate value
Dim expected As Object = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Object
    actual = target.GetValue(component)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for CanResetValue
'''</summary>
<TestMethod()>  _
Public Sub CanResetValueTest()
Dim ColumnName As String = String.Empty ' TODO: Initialize to an appropriate value
Dim ColumnIndex As Integer = 0 ' TODO: Initialize to an appropriate value
Dim ColumnType As Type = Nothing ' TODO: Initialize to an appropriate value
Dim ColumnIsReadOnly As Boolean = false ' TODO: Initialize to an appropriate value
Dim target As JoinViewRowPropertyDescriptor = New JoinViewRowPropertyDescriptor(ColumnName, ColumnIndex, ColumnType, ColumnIsReadOnly) ' TODO: Initialize to an appropriate value
Dim component As Object = Nothing ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.CanResetValue(component)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for JoinViewRowPropertyDescriptor Constructor
'''</summary>
<TestMethod()>  _
Public Sub JoinViewRowPropertyDescriptorConstructorTest()
Dim ColumnName As String = String.Empty ' TODO: Initialize to an appropriate value
Dim ColumnIndex As Integer = 0 ' TODO: Initialize to an appropriate value
Dim ColumnType As Type = Nothing ' TODO: Initialize to an appropriate value
Dim ColumnIsReadOnly As Boolean = false ' TODO: Initialize to an appropriate value
    Dim target As JoinViewRowPropertyDescriptor = New JoinViewRowPropertyDescriptor(ColumnName, ColumnIndex, ColumnType, ColumnIsReadOnly)
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub
End Class
