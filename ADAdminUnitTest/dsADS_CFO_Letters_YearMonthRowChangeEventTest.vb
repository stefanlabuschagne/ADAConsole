﻿Imports System.Data

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports ADAdminDotNet



'''<summary>
'''This is a test class for dsADS_CFO_Letters_YearMonthRowChangeEventTest and is intended
'''to contain all dsADS_CFO_Letters_YearMonthRowChangeEventTest Unit Tests
'''</summary>
<TestClass()> _
Public Class dsADS_CFO_Letters_YearMonthRowChangeEventTest


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
Dim row As dsADS.CFO_Letters_YearMonthRow = Nothing ' TODO: Initialize to an appropriate value
Dim action As DataRowAction = New DataRowAction ' TODO: Initialize to an appropriate value
Dim target As dsADS.CFO_Letters_YearMonthRowChangeEvent = New dsADS.CFO_Letters_YearMonthRowChangeEvent(row, action) ' TODO: Initialize to an appropriate value
    Dim actual As dsADS.CFO_Letters_YearMonthRow
    actual = target.Row
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Action
'''</summary>
<TestMethod()>  _
Public Sub ActionTest()
Dim row As dsADS.CFO_Letters_YearMonthRow = Nothing ' TODO: Initialize to an appropriate value
Dim action As DataRowAction = New DataRowAction ' TODO: Initialize to an appropriate value
Dim target As dsADS.CFO_Letters_YearMonthRowChangeEvent = New dsADS.CFO_Letters_YearMonthRowChangeEvent(row, action) ' TODO: Initialize to an appropriate value
    Dim actual As DataRowAction
    actual = target.Action
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for CFO_Letters_YearMonthRowChangeEvent Constructor
'''</summary>
<TestMethod()>  _
Public Sub dsADS_CFO_Letters_YearMonthRowChangeEventConstructorTest()
Dim row As dsADS.CFO_Letters_YearMonthRow = Nothing ' TODO: Initialize to an appropriate value
Dim action As DataRowAction = New DataRowAction ' TODO: Initialize to an appropriate value
    Dim target As dsADS.CFO_Letters_YearMonthRowChangeEvent = New dsADS.CFO_Letters_YearMonthRowChangeEvent(row, action)
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub
End Class
