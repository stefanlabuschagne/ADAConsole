Imports System

Imports System.ComponentModel

Imports System.Data

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports ADAdminDotNet



'''<summary>
'''This is a test class for JoinViewRowTest and is intended
'''to contain all JoinViewRowTest Unit Tests
'''</summary>
<TestClass()> _
Public Class JoinViewRowTest


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
'''A test for Item
'''</summary>
<TestMethod()>  _
Public Sub ItemTest()
Dim JoinView As modJoinView = Nothing ' TODO: Initialize to an appropriate value
Dim Record As DataRow = Nothing ' TODO: Initialize to an appropriate value
Dim target As JoinViewRow = New JoinViewRow(JoinView, Record) ' TODO: Initialize to an appropriate value
Dim columnIndex As Integer = 0 ' TODO: Initialize to an appropriate value
Dim expected As Object = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Object
    target.Item(columnIndex) = expected
    actual = target.Item(columnIndex)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for GetPropertyOwner
'''</summary>
<TestMethod()>  _
Public Sub GetPropertyOwnerTest()
Dim JoinView As modJoinView = Nothing ' TODO: Initialize to an appropriate value
Dim Record As DataRow = Nothing ' TODO: Initialize to an appropriate value
Dim target As ICustomTypeDescriptor = New JoinViewRow(JoinView, Record) ' TODO: Initialize to an appropriate value
Dim pd As PropertyDescriptor = Nothing ' TODO: Initialize to an appropriate value
Dim expected As Object = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Object
    actual = target.GetPropertyOwner(pd)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for GetProperties2
'''</summary>
<TestMethod()>  _
Public Sub GetPropertiesTest1()
Dim JoinView As modJoinView = Nothing ' TODO: Initialize to an appropriate value
Dim Record As DataRow = Nothing ' TODO: Initialize to an appropriate value
Dim target As ICustomTypeDescriptor = New JoinViewRow(JoinView, Record) ' TODO: Initialize to an appropriate value
Dim expected As PropertyDescriptorCollection = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As PropertyDescriptorCollection
    actual = target.GetProperties
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for GetProperties
'''</summary>
<TestMethod()>  _
Public Sub GetPropertiesTest()
Dim JoinView As modJoinView = Nothing ' TODO: Initialize to an appropriate value
Dim Record As DataRow = Nothing ' TODO: Initialize to an appropriate value
Dim target As ICustomTypeDescriptor = New JoinViewRow(JoinView, Record) ' TODO: Initialize to an appropriate value
Dim attributes() As Attribute = Nothing ' TODO: Initialize to an appropriate value
Dim expected As PropertyDescriptorCollection = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As PropertyDescriptorCollection
    actual = target.GetProperties(attributes)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for GetEvents2
'''</summary>
<TestMethod()>  _
Public Sub GetEventsTest1()
Dim JoinView As modJoinView = Nothing ' TODO: Initialize to an appropriate value
Dim Record As DataRow = Nothing ' TODO: Initialize to an appropriate value
Dim target As ICustomTypeDescriptor = New JoinViewRow(JoinView, Record) ' TODO: Initialize to an appropriate value
Dim expected As EventDescriptorCollection = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As EventDescriptorCollection
    actual = target.GetEvents
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for GetEvents
'''</summary>
<TestMethod()>  _
Public Sub GetEventsTest()
Dim JoinView As modJoinView = Nothing ' TODO: Initialize to an appropriate value
Dim Record As DataRow = Nothing ' TODO: Initialize to an appropriate value
Dim target As ICustomTypeDescriptor = New JoinViewRow(JoinView, Record) ' TODO: Initialize to an appropriate value
Dim attributes() As Attribute = Nothing ' TODO: Initialize to an appropriate value
Dim expected As EventDescriptorCollection = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As EventDescriptorCollection
    actual = target.GetEvents(attributes)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for GetEditor
'''</summary>
<TestMethod()>  _
Public Sub GetEditorTest()
Dim JoinView As modJoinView = Nothing ' TODO: Initialize to an appropriate value
Dim Record As DataRow = Nothing ' TODO: Initialize to an appropriate value
Dim target As ICustomTypeDescriptor = New JoinViewRow(JoinView, Record) ' TODO: Initialize to an appropriate value
Dim editorBaseType As Type = Nothing ' TODO: Initialize to an appropriate value
Dim expected As Object = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Object
    actual = target.GetEditor(editorBaseType)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for GetDefaultProperty
'''</summary>
<TestMethod()>  _
Public Sub GetDefaultPropertyTest()
Dim JoinView As modJoinView = Nothing ' TODO: Initialize to an appropriate value
Dim Record As DataRow = Nothing ' TODO: Initialize to an appropriate value
Dim target As ICustomTypeDescriptor = New JoinViewRow(JoinView, Record) ' TODO: Initialize to an appropriate value
Dim expected As PropertyDescriptor = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As PropertyDescriptor
    actual = target.GetDefaultProperty
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for GetDefaultEvent
'''</summary>
<TestMethod()>  _
Public Sub GetDefaultEventTest()
Dim JoinView As modJoinView = Nothing ' TODO: Initialize to an appropriate value
Dim Record As DataRow = Nothing ' TODO: Initialize to an appropriate value
Dim target As ICustomTypeDescriptor = New JoinViewRow(JoinView, Record) ' TODO: Initialize to an appropriate value
Dim expected As EventDescriptor = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As EventDescriptor
    actual = target.GetDefaultEvent
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for GetConverter
'''</summary>
<TestMethod()>  _
Public Sub GetConverterTest()
Dim JoinView As modJoinView = Nothing ' TODO: Initialize to an appropriate value
Dim Record As DataRow = Nothing ' TODO: Initialize to an appropriate value
Dim target As ICustomTypeDescriptor = New JoinViewRow(JoinView, Record) ' TODO: Initialize to an appropriate value
Dim expected As TypeConverter = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TypeConverter
    actual = target.GetConverter
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for GetComponentName
'''</summary>
<TestMethod()>  _
Public Sub GetComponentNameTest()
Dim JoinView As modJoinView = Nothing ' TODO: Initialize to an appropriate value
Dim Record As DataRow = Nothing ' TODO: Initialize to an appropriate value
Dim target As ICustomTypeDescriptor = New JoinViewRow(JoinView, Record) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    actual = target.GetComponentName
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for GetClassName
'''</summary>
<TestMethod()>  _
Public Sub GetClassNameTest()
Dim JoinView As modJoinView = Nothing ' TODO: Initialize to an appropriate value
Dim Record As DataRow = Nothing ' TODO: Initialize to an appropriate value
Dim target As ICustomTypeDescriptor = New JoinViewRow(JoinView, Record) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    actual = target.GetClassName
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for GetAttributes
'''</summary>
<TestMethod()>  _
Public Sub GetAttributesTest()
Dim JoinView As modJoinView = Nothing ' TODO: Initialize to an appropriate value
Dim Record As DataRow = Nothing ' TODO: Initialize to an appropriate value
Dim target As ICustomTypeDescriptor = New JoinViewRow(JoinView, Record) ' TODO: Initialize to an appropriate value
Dim expected As AttributeCollection = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As AttributeCollection
    actual = target.GetAttributes
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for EndEdit
'''</summary>
<TestMethod()>  _
Public Sub EndEditTest()
Dim JoinView As modJoinView = Nothing ' TODO: Initialize to an appropriate value
Dim Record As DataRow = Nothing ' TODO: Initialize to an appropriate value
Dim target As IEditableObject = New JoinViewRow(JoinView, Record) ' TODO: Initialize to an appropriate value
    target.EndEdit
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for Delete
'''</summary>
<TestMethod()>  _
Public Sub DeleteTest()
Dim JoinView As modJoinView = Nothing ' TODO: Initialize to an appropriate value
Dim Record As DataRow = Nothing ' TODO: Initialize to an appropriate value
Dim target As JoinViewRow = New JoinViewRow(JoinView, Record) ' TODO: Initialize to an appropriate value
    target.Delete
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for CancelEdit
'''</summary>
<TestMethod()>  _
Public Sub CancelEditTest()
Dim JoinView As modJoinView = Nothing ' TODO: Initialize to an appropriate value
Dim Record As DataRow = Nothing ' TODO: Initialize to an appropriate value
Dim target As IEditableObject = New JoinViewRow(JoinView, Record) ' TODO: Initialize to an appropriate value
    target.CancelEdit
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for BeginEdit
'''</summary>
<TestMethod()>  _
Public Sub BeginEditTest()
Dim JoinView As modJoinView = Nothing ' TODO: Initialize to an appropriate value
Dim Record As DataRow = Nothing ' TODO: Initialize to an appropriate value
Dim target As IEditableObject = New JoinViewRow(JoinView, Record) ' TODO: Initialize to an appropriate value
    target.BeginEdit
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for JoinViewRow Constructor
'''</summary>
<TestMethod()>  _
Public Sub JoinViewRowConstructorTest()
Dim JoinView As modJoinView = Nothing ' TODO: Initialize to an appropriate value
Dim Record As DataRow = Nothing ' TODO: Initialize to an appropriate value
    Dim target As JoinViewRow = New JoinViewRow(JoinView, Record)
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub
End Class
