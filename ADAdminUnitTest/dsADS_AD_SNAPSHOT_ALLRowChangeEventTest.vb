﻿Imports System.Data

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports ADAdminDotNet



'''<summary>
'''This is a test class for dsADS_AD_SNAPSHOT_ALLRowChangeEventTest and is intended
'''to contain all dsADS_AD_SNAPSHOT_ALLRowChangeEventTest Unit Tests
'''</summary>
<TestClass()> _
Public Class dsADS_AD_SNAPSHOT_ALLRowChangeEventTest


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
'''A test for Row
'''</summary>
<TestMethod()>  _
Public Sub RowTest()
Dim row As dsADS.AD_SNAPSHOT_ALLRow = Nothing ' TODO: Initialize to an appropriate value
Dim action As DataRowAction = New DataRowAction ' TODO: Initialize to an appropriate value
Dim target As dsADS.AD_SNAPSHOT_ALLRowChangeEvent = New dsADS.AD_SNAPSHOT_ALLRowChangeEvent(row, action) ' TODO: Initialize to an appropriate value
    Dim actual As dsADS.AD_SNAPSHOT_ALLRow
    actual = target.Row
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Action
'''</summary>
<TestMethod()>  _
Public Sub ActionTest()
Dim row As dsADS.AD_SNAPSHOT_ALLRow = Nothing ' TODO: Initialize to an appropriate value
Dim action As DataRowAction = New DataRowAction ' TODO: Initialize to an appropriate value
Dim target As dsADS.AD_SNAPSHOT_ALLRowChangeEvent = New dsADS.AD_SNAPSHOT_ALLRowChangeEvent(row, action) ' TODO: Initialize to an appropriate value
    Dim actual As DataRowAction
    actual = target.Action
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for AD_SNAPSHOT_ALLRowChangeEvent Constructor
'''</summary>
<TestMethod()>  _
Public Sub dsADS_AD_SNAPSHOT_ALLRowChangeEventConstructorTest()
Dim row As dsADS.AD_SNAPSHOT_ALLRow = Nothing ' TODO: Initialize to an appropriate value
Dim action As DataRowAction = New DataRowAction ' TODO: Initialize to an appropriate value
    Dim target As dsADS.AD_SNAPSHOT_ALLRowChangeEvent = New dsADS.AD_SNAPSHOT_ALLRowChangeEvent(row, action)
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub
End Class
