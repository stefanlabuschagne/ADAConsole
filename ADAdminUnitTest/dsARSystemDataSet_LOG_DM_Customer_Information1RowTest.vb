Imports System.Data

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports ADAdminDotNet



'''<summary>
'''This is a test class for dsARSystemDataSet_LOG_DM_Customer_Information1RowTest and is intended
'''to contain all dsARSystemDataSet_LOG_DM_Customer_Information1RowTest Unit Tests
'''</summary>
<TestClass()> _
Public Class dsARSystemDataSet_LOG_DM_Customer_Information1RowTest


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
'''A test for Department_Name
'''</summary>
<TestMethod()>  _
Public Sub Department_NameTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_Information1Row = New dsARSystemDataSet.LOG_DM_Customer_Information1Row(rb) ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    target.Department_Name = expected
    actual = target.Department_Name
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for SetDepartment_NameNull
'''</summary>
<TestMethod()>  _
Public Sub SetDepartment_NameNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_Information1Row = New dsARSystemDataSet.LOG_DM_Customer_Information1Row(rb) ' TODO: Initialize to an appropriate value
    target.SetDepartment_NameNull
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for IsDepartment_NameNull
'''</summary>
<TestMethod()>  _
Public Sub IsDepartment_NameNullTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsARSystemDataSet.LOG_DM_Customer_Information1Row = New dsARSystemDataSet.LOG_DM_Customer_Information1Row(rb) ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsDepartment_NameNull
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for LOG_DM_Customer_Information1Row Constructor
'''</summary>
<TestMethod()>  _
Public Sub dsARSystemDataSet_LOG_DM_Customer_Information1RowConstructorTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
    Dim target As dsARSystemDataSet.LOG_DM_Customer_Information1Row = New dsARSystemDataSet.LOG_DM_Customer_Information1Row(rb)
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub
End Class
