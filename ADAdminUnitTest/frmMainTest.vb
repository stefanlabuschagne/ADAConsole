Imports ADAdminDotNet.dsVIP_EXPANDEDTableAdapters

Imports ADAdminDotNet.dsARSystemDataSetTableAdapters

Imports ADAdminDotNet.dsADSTableAdapters

Imports System.Windows.Forms

Imports Microsoft.VisualBasic

Imports System

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports ADAdminDotNet



'''<summary>
'''This is a test class for frmMainTest and is intended
'''to contain all frmMainTest Unit Tests
'''</summary>
<TestClass()> _
Public Class frmMainTest


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
'''A test for WebRequestMenu
'''</summary>
<TestMethod()>  _
Public Sub WebRequestMenuTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ContextMenuStrip = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ContextMenuStrip
    target.WebRequestMenu = expected
    actual = target.WebRequestMenu
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for VulindlelaControllerToolStripMenuItem
'''</summary>
<TestMethod()>  _
Public Sub VulindlelaControllerToolStripMenuItemTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.VulindlelaControllerToolStripMenuItem = expected
    actual = target.VulindlelaControllerToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for VPNAdminsToolStripMenuItem
'''</summary>
<TestMethod()>  _
Public Sub VPNAdminsToolStripMenuItemTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.VPNAdminsToolStripMenuItem = expected
    actual = target.VPNAdminsToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for VIP_USERSTableAdapter
'''</summary>
<TestMethod()>  _
Public Sub VIP_USERSTableAdapterTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As VIP_USERSTableAdapter = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As VIP_USERSTableAdapter
    target.VIP_USERSTableAdapter = expected
    actual = target.VIP_USERSTableAdapter
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for VIP_USERSDataGridView
'''</summary>
<TestMethod()>  _
Public Sub VIP_USERSDataGridViewTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As DataGridView = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridView
    target.VIP_USERSDataGridView = expected
    actual = target.VIP_USERSDataGridView
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for VIP_USERS1TableAdapter
'''</summary>
<TestMethod()>  _
Public Sub VIP_USERS1TableAdapterTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As VIP_USERS1TableAdapter = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As VIP_USERS1TableAdapter
    target.VIP_USERS1TableAdapter = expected
    actual = target.VIP_USERS1TableAdapter
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for VIP_USERS1BindingSource
'''</summary>
<TestMethod()>  _
Public Sub VIP_USERS1BindingSourceTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As BindingSource = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As BindingSource
    target.VIP_USERS1BindingSource = expected
    actual = target.VIP_USERS1BindingSource
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for VIP_USERS_ResetPasswordTableAdapter
'''</summary>
<TestMethod()>  _
Public Sub VIP_USERS_ResetPasswordTableAdapterTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As VIP_USERS_ResetPasswordTableAdapter = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As VIP_USERS_ResetPasswordTableAdapter
    target.VIP_USERS_ResetPasswordTableAdapter = expected
    actual = target.VIP_USERS_ResetPasswordTableAdapter
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for VIP_USERS_ResetPasswordBindingSource
'''</summary>
<TestMethod()>  _
Public Sub VIP_USERS_ResetPasswordBindingSourceTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As BindingSource = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As BindingSource
    target.VIP_USERS_ResetPasswordBindingSource = expected
    actual = target.VIP_USERS_ResetPasswordBindingSource
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for VIP_EXPANDED
'''</summary>
<TestMethod()>  _
Public Sub VIP_EXPANDEDTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As dsVIP_EXPANDED = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As dsVIP_EXPANDED
    target.VIP_EXPANDED = expected
    actual = target.VIP_EXPANDED
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for VIEW_GOVERNMENT_STRUCTURETableAdapter
'''</summary>
<TestMethod()>  _
Public Sub VIEW_GOVERNMENT_STRUCTURETableAdapterTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ta_VIEW_GOVERNMENT_STRUCTURE = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ta_VIEW_GOVERNMENT_STRUCTURE
    target.VIEW_GOVERNMENT_STRUCTURETableAdapter = expected
    actual = target.VIEW_GOVERNMENT_STRUCTURETableAdapter
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for VieW_departmentsTableAdapter1
'''</summary>
<TestMethod()>  _
Public Sub VieW_departmentsTableAdapter1Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As VIEW_departmentsTableAdapter = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As VIEW_departmentsTableAdapter
    target.VieW_departmentsTableAdapter1 = expected
    actual = target.VieW_departmentsTableAdapter1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for VIEW_CFO_APPPLICATION_TOOK_TO_LONGTableAdapter
'''</summary>
<TestMethod()>  _
Public Sub VIEW_CFO_APPPLICATION_TOOK_TO_LONGTableAdapterTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As VIEW_CFO_APPPLICATION_TOOK_TO_LONGTableAdapter = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As VIEW_CFO_APPPLICATION_TOOK_TO_LONGTableAdapter
    target.VIEW_CFO_APPPLICATION_TOOK_TO_LONGTableAdapter = expected
    actual = target.VIEW_CFO_APPPLICATION_TOOK_TO_LONGTableAdapter
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for VIEW_CFO_APPPLICATION_TOOK_TO_LONGBindingSource
'''</summary>
<TestMethod()>  _
Public Sub VIEW_CFO_APPPLICATION_TOOK_TO_LONGBindingSourceTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As BindingSource = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As BindingSource
    target.VIEW_CFO_APPPLICATION_TOOK_TO_LONGBindingSource = expected
    actual = target.VIEW_CFO_APPPLICATION_TOOK_TO_LONGBindingSource
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for VIEW_Assigned_DepartmentsBindingSource
'''</summary>
<TestMethod()>  _
Public Sub VIEW_Assigned_DepartmentsBindingSourceTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As BindingSource = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As BindingSource
    target.VIEW_Assigned_DepartmentsBindingSource = expected
    actual = target.VIEW_Assigned_DepartmentsBindingSource
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for UsersNotOnEstablishmentToolStripMenuItem
'''</summary>
<TestMethod()>  _
Public Sub UsersNotOnEstablishmentToolStripMenuItemTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.UsersNotOnEstablishmentToolStripMenuItem = expected
    actual = target.UsersNotOnEstablishmentToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for UpdateCFOListToolStripMenuItem
'''</summary>
<TestMethod()>  _
Public Sub UpdateCFOListToolStripMenuItemTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.UpdateCFOListToolStripMenuItem = expected
    actual = target.UpdateCFOListToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for txtTitleTextBox
'''</summary>
<TestMethod()>  _
Public Sub txtTitleTextBoxTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TextBox
    target.txtTitleTextBox = expected
    actual = target.txtTitleTextBox
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for txtTelephoneTextBox
'''</summary>
<TestMethod()>  _
Public Sub txtTelephoneTextBoxTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TextBox
    target.txtTelephoneTextBox = expected
    actual = target.txtTelephoneTextBox
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for txtRightsRequested
'''</summary>
<TestMethod()>  _
Public Sub txtRightsRequestedTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TextBox
    target.txtRightsRequested = expected
    actual = target.txtRightsRequested
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for txtRemedyRequestNo
'''</summary>
<TestMethod()>  _
Public Sub txtRemedyRequestNoTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TextBox
    target.txtRemedyRequestNo = expected
    actual = target.txtRemedyRequestNo
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for txtRemedyNo
'''</summary>
<TestMethod()>  _
Public Sub txtRemedyNoTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TextBox
    target.txtRemedyNo = expected
    actual = target.txtRemedyNo
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for txtRankTextBox
'''</summary>
<TestMethod()>  _
Public Sub txtRankTextBoxTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TextBox
    target.txtRankTextBox = expected
    actual = target.txtRankTextBox
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for txtPersalNumber
'''</summary>
<TestMethod()>  _
Public Sub txtPersalNumberTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripTextBox = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripTextBox
    target.txtPersalNumber = expected
    actual = target.txtPersalNumber
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for txtLast_NameTextBox
'''</summary>
<TestMethod()>  _
Public Sub txtLast_NameTextBoxTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TextBox
    target.txtLast_NameTextBox = expected
    actual = target.txtLast_NameTextBox
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for txtFirst_NameTextBox
'''</summary>
<TestMethod()>  _
Public Sub txtFirst_NameTextBoxTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TextBox
    target.txtFirst_NameTextBox = expected
    actual = target.txtFirst_NameTextBox
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for txtFax_NumberTextBox
'''</summary>
<TestMethod()>  _
Public Sub txtFax_NumberTextBoxTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TextBox
    target.txtFax_NumberTextBox = expected
    actual = target.txtFax_NumberTextBox
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for txtE_MailTextBox
'''</summary>
<TestMethod()>  _
Public Sub txtE_MailTextBoxTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TextBox
    target.txtE_MailTextBox = expected
    actual = target.txtE_MailTextBox
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for txtDepartment_TypeTextBox
'''</summary>
<TestMethod()>  _
Public Sub txtDepartment_TypeTextBoxTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TextBox
    target.txtDepartment_TypeTextBox = expected
    actual = target.txtDepartment_TypeTextBox
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for txtDepartment_NameTextBox
'''</summary>
<TestMethod()>  _
Public Sub txtDepartment_NameTextBoxTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TextBox
    target.txtDepartment_NameTextBox = expected
    actual = target.txtDepartment_NameTextBox
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for txtCellphoneTextBox
'''</summary>
<TestMethod()>  _
Public Sub txtCellphoneTextBoxTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TextBox
    target.txtCellphoneTextBox = expected
    actual = target.txtCellphoneTextBox
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for tsUsername
'''</summary>
<TestMethod()>  _
Public Sub tsUsernameTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripStatusLabel = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripStatusLabel
    target.tsUsername = expected
    actual = target.tsUsername
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for tsStatus
'''</summary>
<TestMethod()>  _
Public Sub tsStatusTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripStatusLabel = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripStatusLabel
    target.tsStatus = expected
    actual = target.tsStatus
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for tsSendEMailFORMBOApprovalToolStripMenuItem
'''</summary>
<TestMethod()>  _
Public Sub tsSendEMailFORMBOApprovalToolStripMenuItemTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.tsSendEMailFORMBOApprovalToolStripMenuItem = expected
    actual = target.tsSendEMailFORMBOApprovalToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for tsRemedy
'''</summary>
<TestMethod()>  _
Public Sub tsRemedyTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStrip = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStrip
    target.tsRemedy = expected
    actual = target.tsRemedy
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for tsNTFinFunc_Approval_Request
'''</summary>
<TestMethod()>  _
Public Sub tsNTFinFunc_Approval_RequestTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.tsNTFinFunc_Approval_Request = expected
    actual = target.tsNTFinFunc_Approval_Request
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for tsMachineName
'''</summary>
<TestMethod()>  _
Public Sub tsMachineNameTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripStatusLabel = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripStatusLabel
    target.tsMachineName = expected
    actual = target.tsMachineName
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for tsLoggedOnUser
'''</summary>
<TestMethod()>  _
Public Sub tsLoggedOnUserTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripStatusLabel = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripStatusLabel
    target.tsLoggedOnUser = expected
    actual = target.tsLoggedOnUser
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for tsLastLogon
'''</summary>
<TestMethod()>  _
Public Sub tsLastLogonTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripStatusLabel = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripStatusLabel
    target.tsLastLogon = expected
    actual = target.tsLastLogon
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for tsLabelVulname
'''</summary>
<TestMethod()>  _
Public Sub tsLabelVulnameTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripStatusLabel = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripStatusLabel
    target.tsLabelVulname = expected
    actual = target.tsLabelVulname
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for tsLabelUserName
'''</summary>
<TestMethod()>  _
Public Sub tsLabelUserNameTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripStatusLabel = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripStatusLabel
    target.tsLabelUserName = expected
    actual = target.tsLabelUserName
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for tsLabelREMEDY
'''</summary>
<TestMethod()>  _
Public Sub tsLabelREMEDYTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripStatusLabel = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripStatusLabel
    target.tsLabelREMEDY = expected
    actual = target.tsLabelREMEDY
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for tsLabelProfileCreated
'''</summary>
<TestMethod()>  _
Public Sub tsLabelProfileCreatedTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripStatusLabel = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripStatusLabel
    target.tsLabelProfileCreated = expected
    actual = target.tsLabelProfileCreated
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for tsDeptDiffers0
'''</summary>
<TestMethod()>  _
Public Sub tsDeptDiffers0Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripButton = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripButton
    target.tsDeptDiffers0 = expected
    actual = target.tsDeptDiffers0
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for tsDeptDiffers
'''</summary>
<TestMethod()>  _
Public Sub tsDeptDiffersTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripButton = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripButton
    target.tsDeptDiffers = expected
    actual = target.tsDeptDiffers
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for tsCreatedDate
'''</summary>
<TestMethod()>  _
Public Sub tsCreatedDateTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripStatusLabel = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripStatusLabel
    target.tsCreatedDate = expected
    actual = target.tsCreatedDate
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for tsCFO_Approval_Request
'''</summary>
<TestMethod()>  _
Public Sub tsCFO_Approval_RequestTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.tsCFO_Approval_Request = expected
    actual = target.tsCFO_Approval_Request
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for tsBtnUpdateUser0
'''</summary>
<TestMethod()>  _
Public Sub tsBtnUpdateUser0Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripButton = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripButton
    target.tsBtnUpdateUser0 = expected
    actual = target.tsBtnUpdateUser0
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for tsBtnUpdateUser
'''</summary>
<TestMethod()>  _
Public Sub tsBtnUpdateUserTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripButton = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripButton
    target.tsBtnUpdateUser = expected
    actual = target.tsBtnUpdateUser
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for tsBtnNewUser0
'''</summary>
<TestMethod()>  _
Public Sub tsBtnNewUser0Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripButton = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripButton
    target.tsBtnNewUser0 = expected
    actual = target.tsBtnNewUser0
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for tsBtnNewUser
'''</summary>
<TestMethod()>  _
Public Sub tsBtnNewUserTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripButton = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripButton
    target.tsBtnNewUser = expected
    actual = target.tsBtnNewUser
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for tsBtnDeleteUser0
'''</summary>
<TestMethod()>  _
Public Sub tsBtnDeleteUser0Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripButton = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripButton
    target.tsBtnDeleteUser0 = expected
    actual = target.tsBtnDeleteUser0
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for tsBtnDeleteUser
'''</summary>
<TestMethod()>  _
Public Sub tsBtnDeleteUserTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripButton = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripButton
    target.tsBtnDeleteUser = expected
    actual = target.tsBtnDeleteUser
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for tsADPosition
'''</summary>
<TestMethod()>  _
Public Sub tsADPositionTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripStatusLabel = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripStatusLabel
    target.tsADPosition = expected
    actual = target.tsADPosition
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for TopToolStripPanel
'''</summary>
<TestMethod()>  _
Public Sub TopToolStripPanelTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripPanel = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripPanel
    target.TopToolStripPanel = expected
    actual = target.TopToolStripPanel
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripTextBox1
'''</summary>
<TestMethod()>  _
Public Sub ToolStripTextBox1Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripTextBox = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripTextBox
    target.ToolStripTextBox1 = expected
    actual = target.ToolStripTextBox1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripSplitButton1
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSplitButton1Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripDropDownButton = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripDropDownButton
    target.ToolStripSplitButton1 = expected
    actual = target.ToolStripSplitButton1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripSeparator9
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator9Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripSeparator = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator9 = expected
    actual = target.ToolStripSeparator9
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripSeparator8
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator8Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripSeparator = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator8 = expected
    actual = target.ToolStripSeparator8
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripSeparator7
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator7Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripSeparator = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator7 = expected
    actual = target.ToolStripSeparator7
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripSeparator6
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator6Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripSeparator = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator6 = expected
    actual = target.ToolStripSeparator6
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripSeparator5
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator5Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripSeparator = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator5 = expected
    actual = target.ToolStripSeparator5
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripSeparator44
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator44Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripSeparator = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator44 = expected
    actual = target.ToolStripSeparator44
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripSeparator43
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator43Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripSeparator = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator43 = expected
    actual = target.ToolStripSeparator43
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripSeparator42
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator42Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripSeparator = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator42 = expected
    actual = target.ToolStripSeparator42
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripSeparator4
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator4Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripSeparator = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator4 = expected
    actual = target.ToolStripSeparator4
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripSeparator39
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator39Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripSeparator = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator39 = expected
    actual = target.ToolStripSeparator39
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripSeparator38
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator38Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripSeparator = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator38 = expected
    actual = target.ToolStripSeparator38
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripSeparator37
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator37Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripSeparator = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator37 = expected
    actual = target.ToolStripSeparator37
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripSeparator36
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator36Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripSeparator = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator36 = expected
    actual = target.ToolStripSeparator36
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripSeparator35
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator35Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripSeparator = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator35 = expected
    actual = target.ToolStripSeparator35
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripSeparator34
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator34Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripSeparator = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator34 = expected
    actual = target.ToolStripSeparator34
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripSeparator33
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator33Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripSeparator = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator33 = expected
    actual = target.ToolStripSeparator33
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripSeparator32
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator32Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripSeparator = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator32 = expected
    actual = target.ToolStripSeparator32
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripSeparator31
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator31Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripSeparator = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator31 = expected
    actual = target.ToolStripSeparator31
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripSeparator30
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator30Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripSeparator = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator30 = expected
    actual = target.ToolStripSeparator30
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripSeparator3
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator3Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripSeparator = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator3 = expected
    actual = target.ToolStripSeparator3
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripSeparator29
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator29Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripSeparator = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator29 = expected
    actual = target.ToolStripSeparator29
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripSeparator28
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator28Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripSeparator = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator28 = expected
    actual = target.ToolStripSeparator28
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripSeparator27
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator27Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripSeparator = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator27 = expected
    actual = target.ToolStripSeparator27
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripSeparator26
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator26Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripSeparator = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator26 = expected
    actual = target.ToolStripSeparator26
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripSeparator25
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator25Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripSeparator = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator25 = expected
    actual = target.ToolStripSeparator25
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripSeparator24
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator24Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripSeparator = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator24 = expected
    actual = target.ToolStripSeparator24
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripSeparator23
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator23Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripSeparator = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator23 = expected
    actual = target.ToolStripSeparator23
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripSeparator22
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator22Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripSeparator = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator22 = expected
    actual = target.ToolStripSeparator22
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripSeparator21
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator21Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripSeparator = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator21 = expected
    actual = target.ToolStripSeparator21
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripSeparator20
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator20Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripSeparator = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator20 = expected
    actual = target.ToolStripSeparator20
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripSeparator2
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator2Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripSeparator = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator2 = expected
    actual = target.ToolStripSeparator2
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripSeparator19
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator19Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripSeparator = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator19 = expected
    actual = target.ToolStripSeparator19
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripSeparator18
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator18Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripSeparator = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator18 = expected
    actual = target.ToolStripSeparator18
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripSeparator17
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator17Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripSeparator = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator17 = expected
    actual = target.ToolStripSeparator17
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripSeparator16
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator16Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripSeparator = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator16 = expected
    actual = target.ToolStripSeparator16
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripSeparator15
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator15Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripSeparator = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator15 = expected
    actual = target.ToolStripSeparator15
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripSeparator14
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator14Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripSeparator = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator14 = expected
    actual = target.ToolStripSeparator14
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripSeparator13
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator13Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripSeparator = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator13 = expected
    actual = target.ToolStripSeparator13
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripSeparator12
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator12Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripSeparator = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator12 = expected
    actual = target.ToolStripSeparator12
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripSeparator11
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator11Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripSeparator = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator11 = expected
    actual = target.ToolStripSeparator11
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripSeparator10
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator10Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripSeparator = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator10 = expected
    actual = target.ToolStripSeparator10
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripSeparator1
'''</summary>
<TestMethod()>  _
Public Sub ToolStripSeparator1Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripSeparator = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripSeparator
    target.ToolStripSeparator1 = expected
    actual = target.ToolStripSeparator1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem9
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem9Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripSeparator = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripSeparator
    target.ToolStripMenuItem9 = expected
    actual = target.ToolStripMenuItem9
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem83
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem83Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ToolStripMenuItem83 = expected
    actual = target.ToolStripMenuItem83
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem82
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem82Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ToolStripMenuItem82 = expected
    actual = target.ToolStripMenuItem82
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem8
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem8Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripSeparator = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripSeparator
    target.ToolStripMenuItem8 = expected
    actual = target.ToolStripMenuItem8
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem75
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem75Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripSeparator = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripSeparator
    target.ToolStripMenuItem75 = expected
    actual = target.ToolStripMenuItem75
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem74
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem74Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ToolStripMenuItem74 = expected
    actual = target.ToolStripMenuItem74
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem73
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem73Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ToolStripMenuItem73 = expected
    actual = target.ToolStripMenuItem73
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem72
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem72Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ToolStripMenuItem72 = expected
    actual = target.ToolStripMenuItem72
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem71
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem71Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ToolStripMenuItem71 = expected
    actual = target.ToolStripMenuItem71
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem70
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem70Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ToolStripMenuItem70 = expected
    actual = target.ToolStripMenuItem70
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem7
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem7Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripSeparator = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripSeparator
    target.ToolStripMenuItem7 = expected
    actual = target.ToolStripMenuItem7
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem69
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem69Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ToolStripMenuItem69 = expected
    actual = target.ToolStripMenuItem69
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem68
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem68Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ToolStripMenuItem68 = expected
    actual = target.ToolStripMenuItem68
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem67
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem67Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ToolStripMenuItem67 = expected
    actual = target.ToolStripMenuItem67
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem66
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem66Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ToolStripMenuItem66 = expected
    actual = target.ToolStripMenuItem66
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem65
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem65Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ToolStripMenuItem65 = expected
    actual = target.ToolStripMenuItem65
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem64
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem64Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ToolStripMenuItem64 = expected
    actual = target.ToolStripMenuItem64
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem63
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem63Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ToolStripMenuItem63 = expected
    actual = target.ToolStripMenuItem63
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem62
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem62Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ToolStripMenuItem62 = expected
    actual = target.ToolStripMenuItem62
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem61
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem61Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ToolStripMenuItem61 = expected
    actual = target.ToolStripMenuItem61
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem60
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem60Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ToolStripMenuItem60 = expected
    actual = target.ToolStripMenuItem60
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem6
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem6Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripSeparator = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripSeparator
    target.ToolStripMenuItem6 = expected
    actual = target.ToolStripMenuItem6
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem59
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem59Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ToolStripMenuItem59 = expected
    actual = target.ToolStripMenuItem59
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem58
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem58Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ToolStripMenuItem58 = expected
    actual = target.ToolStripMenuItem58
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem57
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem57Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripSeparator = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripSeparator
    target.ToolStripMenuItem57 = expected
    actual = target.ToolStripMenuItem57
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem56
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem56Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ToolStripMenuItem56 = expected
    actual = target.ToolStripMenuItem56
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem55
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem55Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripSeparator = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripSeparator
    target.ToolStripMenuItem55 = expected
    actual = target.ToolStripMenuItem55
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem54
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem54Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ToolStripMenuItem54 = expected
    actual = target.ToolStripMenuItem54
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem53
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem53Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ToolStripMenuItem53 = expected
    actual = target.ToolStripMenuItem53
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem52
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem52Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ToolStripMenuItem52 = expected
    actual = target.ToolStripMenuItem52
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem51
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem51Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ToolStripMenuItem51 = expected
    actual = target.ToolStripMenuItem51
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem50
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem50Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ToolStripMenuItem50 = expected
    actual = target.ToolStripMenuItem50
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem5
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem5Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripSeparator = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripSeparator
    target.ToolStripMenuItem5 = expected
    actual = target.ToolStripMenuItem5
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem49
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem49Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ToolStripMenuItem49 = expected
    actual = target.ToolStripMenuItem49
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem48
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem48Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ToolStripMenuItem48 = expected
    actual = target.ToolStripMenuItem48
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem47
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem47Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ToolStripMenuItem47 = expected
    actual = target.ToolStripMenuItem47
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem46
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem46Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ToolStripMenuItem46 = expected
    actual = target.ToolStripMenuItem46
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem45
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem45Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ToolStripMenuItem45 = expected
    actual = target.ToolStripMenuItem45
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem44
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem44Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ToolStripMenuItem44 = expected
    actual = target.ToolStripMenuItem44
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem43
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem43Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ToolStripMenuItem43 = expected
    actual = target.ToolStripMenuItem43
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem42
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem42Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ToolStripMenuItem42 = expected
    actual = target.ToolStripMenuItem42
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem41
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem41Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ToolStripMenuItem41 = expected
    actual = target.ToolStripMenuItem41
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem40
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem40Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ToolStripMenuItem40 = expected
    actual = target.ToolStripMenuItem40
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem4
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem4Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripSeparator = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripSeparator
    target.ToolStripMenuItem4 = expected
    actual = target.ToolStripMenuItem4
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem39
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem39Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ToolStripMenuItem39 = expected
    actual = target.ToolStripMenuItem39
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem38
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem38Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ToolStripMenuItem38 = expected
    actual = target.ToolStripMenuItem38
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem37
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem37Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ToolStripMenuItem37 = expected
    actual = target.ToolStripMenuItem37
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem36
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem36Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ToolStripMenuItem36 = expected
    actual = target.ToolStripMenuItem36
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem35
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem35Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ToolStripMenuItem35 = expected
    actual = target.ToolStripMenuItem35
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem34
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem34Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ToolStripMenuItem34 = expected
    actual = target.ToolStripMenuItem34
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem33
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem33Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ToolStripMenuItem33 = expected
    actual = target.ToolStripMenuItem33
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem32
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem32Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ToolStripMenuItem32 = expected
    actual = target.ToolStripMenuItem32
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem31
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem31Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ToolStripMenuItem31 = expected
    actual = target.ToolStripMenuItem31
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem30
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem30Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ToolStripMenuItem30 = expected
    actual = target.ToolStripMenuItem30
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem3
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem3Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripSeparator = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripSeparator
    target.ToolStripMenuItem3 = expected
    actual = target.ToolStripMenuItem3
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem29
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem29Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ToolStripMenuItem29 = expected
    actual = target.ToolStripMenuItem29
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem28
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem28Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ToolStripMenuItem28 = expected
    actual = target.ToolStripMenuItem28
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem27
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem27Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ToolStripMenuItem27 = expected
    actual = target.ToolStripMenuItem27
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem26
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem26Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ToolStripMenuItem26 = expected
    actual = target.ToolStripMenuItem26
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem25
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem25Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ToolStripMenuItem25 = expected
    actual = target.ToolStripMenuItem25
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem24
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem24Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ToolStripMenuItem24 = expected
    actual = target.ToolStripMenuItem24
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem23
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem23Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ToolStripMenuItem23 = expected
    actual = target.ToolStripMenuItem23
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem22
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem22Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ToolStripMenuItem22 = expected
    actual = target.ToolStripMenuItem22
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem21
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem21Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ToolStripMenuItem21 = expected
    actual = target.ToolStripMenuItem21
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem20
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem20Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ToolStripMenuItem20 = expected
    actual = target.ToolStripMenuItem20
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem2
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem2Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripSeparator = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripSeparator
    target.ToolStripMenuItem2 = expected
    actual = target.ToolStripMenuItem2
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem19
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem19Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ToolStripMenuItem19 = expected
    actual = target.ToolStripMenuItem19
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem18
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem18Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ToolStripMenuItem18 = expected
    actual = target.ToolStripMenuItem18
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem17
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem17Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ToolStripMenuItem17 = expected
    actual = target.ToolStripMenuItem17
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem16
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem16Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ToolStripMenuItem16 = expected
    actual = target.ToolStripMenuItem16
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem15
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem15Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ToolStripMenuItem15 = expected
    actual = target.ToolStripMenuItem15
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem14
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem14Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripSeparator = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripSeparator
    target.ToolStripMenuItem14 = expected
    actual = target.ToolStripMenuItem14
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem13
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem13Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripSeparator = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripSeparator
    target.ToolStripMenuItem13 = expected
    actual = target.ToolStripMenuItem13
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem12
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem12Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ToolStripMenuItem12 = expected
    actual = target.ToolStripMenuItem12
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem11
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem11Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripSeparator = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripSeparator
    target.ToolStripMenuItem11 = expected
    actual = target.ToolStripMenuItem11
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem10
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem10Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripSeparator = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripSeparator
    target.ToolStripMenuItem10 = expected
    actual = target.ToolStripMenuItem10
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem1
'''</summary>
<TestMethod()>  _
Public Sub ToolStripMenuItem1Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripSeparator = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripSeparator
    target.ToolStripMenuItem1 = expected
    actual = target.ToolStripMenuItem1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripDropDownButton5
'''</summary>
<TestMethod()>  _
Public Sub ToolStripDropDownButton5Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripDropDownButton = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripDropDownButton
    target.ToolStripDropDownButton5 = expected
    actual = target.ToolStripDropDownButton5
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripDropDownButton4
'''</summary>
<TestMethod()>  _
Public Sub ToolStripDropDownButton4Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripDropDownButton = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripDropDownButton
    target.ToolStripDropDownButton4 = expected
    actual = target.ToolStripDropDownButton4
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripDropDownButton30
'''</summary>
<TestMethod()>  _
Public Sub ToolStripDropDownButton30Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripDropDownButton = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripDropDownButton
    target.ToolStripDropDownButton30 = expected
    actual = target.ToolStripDropDownButton30
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripDropDownButton3
'''</summary>
<TestMethod()>  _
Public Sub ToolStripDropDownButton3Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripDropDownButton = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripDropDownButton
    target.ToolStripDropDownButton3 = expected
    actual = target.ToolStripDropDownButton3
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripDropDownButton2
'''</summary>
<TestMethod()>  _
Public Sub ToolStripDropDownButton2Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripDropDownButton = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripDropDownButton
    target.ToolStripDropDownButton2 = expected
    actual = target.ToolStripDropDownButton2
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripDropDownButton10
'''</summary>
<TestMethod()>  _
Public Sub ToolStripDropDownButton10Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripDropDownButton = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripDropDownButton
    target.ToolStripDropDownButton10 = expected
    actual = target.ToolStripDropDownButton10
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripDropDownButton1
'''</summary>
<TestMethod()>  _
Public Sub ToolStripDropDownButton1Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripDropDownButton = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripDropDownButton
    target.ToolStripDropDownButton1 = expected
    actual = target.ToolStripDropDownButton1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripContainer1
'''</summary>
<TestMethod()>  _
Public Sub ToolStripContainer1Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripContainer = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripContainer
    target.ToolStripContainer1 = expected
    actual = target.ToolStripContainer1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripButton8
'''</summary>
<TestMethod()>  _
Public Sub ToolStripButton8Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripButton = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripButton
    target.ToolStripButton8 = expected
    actual = target.ToolStripButton8
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripButton7
'''</summary>
<TestMethod()>  _
Public Sub ToolStripButton7Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripButton = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripButton
    target.ToolStripButton7 = expected
    actual = target.ToolStripButton7
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripButton6
'''</summary>
<TestMethod()>  _
Public Sub ToolStripButton6Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripButton = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripButton
    target.ToolStripButton6 = expected
    actual = target.ToolStripButton6
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripButton5
'''</summary>
<TestMethod()>  _
Public Sub ToolStripButton5Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripButton = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripButton
    target.ToolStripButton5 = expected
    actual = target.ToolStripButton5
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripButton4
'''</summary>
<TestMethod()>  _
Public Sub ToolStripButton4Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripButton = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripButton
    target.ToolStripButton4 = expected
    actual = target.ToolStripButton4
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripButton3
'''</summary>
<TestMethod()>  _
Public Sub ToolStripButton3Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripButton = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripButton
    target.ToolStripButton3 = expected
    actual = target.ToolStripButton3
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripButton2
'''</summary>
<TestMethod()>  _
Public Sub ToolStripButton2Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripButton = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripButton
    target.ToolStripButton2 = expected
    actual = target.ToolStripButton2
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripButton10
'''</summary>
<TestMethod()>  _
Public Sub ToolStripButton10Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripButton = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripButton
    target.ToolStripButton10 = expected
    actual = target.ToolStripButton10
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ToolStripButton1
'''</summary>
<TestMethod()>  _
Public Sub ToolStripButton1Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripButton = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripButton
    target.ToolStripButton1 = expected
    actual = target.ToolStripButton1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for tmrPersalNumber
'''</summary>
<TestMethod()>  _
Public Sub tmrPersalNumberTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As Timer = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Timer
    target.tmrPersalNumber = expected
    actual = target.tmrPersalNumber
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for TimerKickout
'''</summary>
<TestMethod()>  _
Public Sub TimerKickoutTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As Timer = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Timer
    target.TimerKickout = expected
    actual = target.TimerKickout
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for timerCOUNTS
'''</summary>
<TestMethod()>  _
Public Sub timerCOUNTSTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As Timer = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Timer
    target.timerCOUNTS = expected
    actual = target.timerCOUNTS
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for TextBox1
'''</summary>
<TestMethod()>  _
Public Sub TextBox1Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TextBox
    target.TextBox1 = expected
    actual = target.TextBox1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for taQueries
'''</summary>
<TestMethod()>  _
Public Sub taQueriesTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As QueriesTableAdapter = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As QueriesTableAdapter
    target.taQueries = expected
    actual = target.taQueries
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for TableAdapterManager
'''</summary>
<TestMethod()>  _
Public Sub TableAdapterManagerTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As TableAdapterManager = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TableAdapterManager
    target.TableAdapterManager = expected
    actual = target.TableAdapterManager
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for TabControl1
'''</summary>
<TestMethod()>  _
Public Sub TabControl1Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As TabControl = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TabControl
    target.TabControl1 = expected
    actual = target.TabControl1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for tab_Web
'''</summary>
<TestMethod()>  _
Public Sub tab_WebTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As TabPage = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TabPage
    target.tab_Web = expected
    actual = target.tab_Web
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for tab_Requests
'''</summary>
<TestMethod()>  _
Public Sub tab_RequestsTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As TabPage = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TabPage
    target.tab_Requests = expected
    actual = target.tab_Requests
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for tab_ProvDept
'''</summary>
<TestMethod()>  _
Public Sub tab_ProvDeptTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As TabPage = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TabPage
    target.tab_ProvDept = expected
    actual = target.tab_ProvDept
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for tab_Flagged
'''</summary>
<TestMethod()>  _
Public Sub tab_FlaggedTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As TabPage = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TabPage
    target.tab_Flagged = expected
    actual = target.tab_Flagged
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for tab_Assigned
'''</summary>
<TestMethod()>  _
Public Sub tab_AssignedTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As TabPage = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TabPage
    target.tab_Assigned = expected
    actual = target.tab_Assigned
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for tab_Admin
'''</summary>
<TestMethod()>  _
Public Sub tab_AdminTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As TabPage = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As TabPage
    target.tab_Admin = expected
    actual = target.tab_Admin
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ta_Vulindlela_Email
'''</summary>
<TestMethod()>  _
Public Sub ta_Vulindlela_EmailTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As Vulindlela_EmailTableAdapter = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Vulindlela_EmailTableAdapter
    target.ta_Vulindlela_Email = expected
    actual = target.ta_Vulindlela_Email
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Ta_Vulindlela_Controllers
'''</summary>
<TestMethod()>  _
Public Sub Ta_Vulindlela_ControllersTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ta_Vulindlela_Controllers = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ta_Vulindlela_Controllers
    target.Ta_Vulindlela_Controllers = expected
    actual = target.Ta_Vulindlela_Controllers
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Ta_VIEW_GOVERNMENT_STRUCTURE1
'''</summary>
<TestMethod()>  _
Public Sub Ta_VIEW_GOVERNMENT_STRUCTURE1Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ta_VIEW_GOVERNMENT_STRUCTURE = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ta_VIEW_GOVERNMENT_STRUCTURE
    target.Ta_VIEW_GOVERNMENT_STRUCTURE1 = expected
    actual = target.Ta_VIEW_GOVERNMENT_STRUCTURE1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Ta_VIEW_GOVERNMENT_STRUCTURE
'''</summary>
<TestMethod()>  _
Public Sub Ta_VIEW_GOVERNMENT_STRUCTURETest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ta_VIEW_GOVERNMENT_STRUCTURE = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ta_VIEW_GOVERNMENT_STRUCTURE
    target.Ta_VIEW_GOVERNMENT_STRUCTURE = expected
    actual = target.Ta_VIEW_GOVERNMENT_STRUCTURE
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ta_VIEW_departments1
'''</summary>
<TestMethod()>  _
Public Sub ta_VIEW_departments1Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As VIEW_departmentsTableAdapter = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As VIEW_departmentsTableAdapter
    target.ta_VIEW_departments1 = expected
    actual = target.ta_VIEW_departments1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ta_VIEW_departments
'''</summary>
<TestMethod()>  _
Public Sub ta_VIEW_departmentsTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As VIEW_departmentsTableAdapter = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As VIEW_departmentsTableAdapter
    target.ta_VIEW_departments = expected
    actual = target.ta_VIEW_departments
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Ta_VIEW_Assigned_Departments1
'''</summary>
<TestMethod()>  _
Public Sub Ta_VIEW_Assigned_Departments1Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ta_VIEW_Assigned_Departments = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ta_VIEW_Assigned_Departments
    target.Ta_VIEW_Assigned_Departments1 = expected
    actual = target.Ta_VIEW_Assigned_Departments1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Ta_VIEW_Assigned_Departments
'''</summary>
<TestMethod()>  _
Public Sub Ta_VIEW_Assigned_DepartmentsTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ta_VIEW_Assigned_Departments = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ta_VIEW_Assigned_Departments
    target.Ta_VIEW_Assigned_Departments = expected
    actual = target.Ta_VIEW_Assigned_Departments
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Ta_VIEW_APPLICATION_RIGHTS1
'''</summary>
<TestMethod()>  _
Public Sub Ta_VIEW_APPLICATION_RIGHTS1Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ta_VIEW_APPLICATION_RIGHTS = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ta_VIEW_APPLICATION_RIGHTS
    target.Ta_VIEW_APPLICATION_RIGHTS1 = expected
    actual = target.Ta_VIEW_APPLICATION_RIGHTS1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Ta_VIEW_APPLICATION_RIGHTS
'''</summary>
<TestMethod()>  _
Public Sub Ta_VIEW_APPLICATION_RIGHTSTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ta_VIEW_APPLICATION_RIGHTS = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ta_VIEW_APPLICATION_RIGHTS
    target.Ta_VIEW_APPLICATION_RIGHTS = expected
    actual = target.Ta_VIEW_APPLICATION_RIGHTS
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ta_KICKOUT
'''</summary>
<TestMethod()>  _
Public Sub ta_KICKOUTTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As KICKOUTTableAdapter = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As KICKOUTTableAdapter
    target.ta_KICKOUT = expected
    actual = target.ta_KICKOUT
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Ta_GetLastLoggedOnForPersalNumber1
'''</summary>
<TestMethod()>  _
Public Sub Ta_GetLastLoggedOnForPersalNumber1Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ta_GetLastLoggedOnForPersalNumber = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ta_GetLastLoggedOnForPersalNumber
    target.Ta_GetLastLoggedOnForPersalNumber1 = expected
    actual = target.Ta_GetLastLoggedOnForPersalNumber1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Ta_GetLastLoggedOnForPersalNumber
'''</summary>
<TestMethod()>  _
Public Sub Ta_GetLastLoggedOnForPersalNumberTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ta_GetLastLoggedOnForPersalNumber = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ta_GetLastLoggedOnForPersalNumber
    target.Ta_GetLastLoggedOnForPersalNumber = expected
    actual = target.Ta_GetLastLoggedOnForPersalNumber
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Ta_Establishment
'''</summary>
<TestMethod()>  _
Public Sub Ta_EstablishmentTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ta_Establishment = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ta_Establishment
    target.Ta_Establishment = expected
    actual = target.Ta_Establishment
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Ta_Estab2
'''</summary>
<TestMethod()>  _
Public Sub Ta_Estab2Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ta_Estab2 = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ta_Estab2
    target.Ta_Estab2 = expected
    actual = target.Ta_Estab2
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Ta_CustomerInfo
'''</summary>
<TestMethod()>  _
Public Sub Ta_CustomerInfoTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ta_CustomerInfo = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ta_CustomerInfo
    target.Ta_CustomerInfo = expected
    actual = target.Ta_CustomerInfo
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Ta_CustNotify
'''</summary>
<TestMethod()>  _
Public Sub Ta_CustNotifyTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ta_CustNotify = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ta_CustNotify
    target.Ta_CustNotify = expected
    actual = target.Ta_CustNotify
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for SystemGroupDataGridViewTextBoxColumn
'''</summary>
<TestMethod()>  _
Public Sub SystemGroupDataGridViewTextBoxColumnTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.SystemGroupDataGridViewTextBoxColumn = expected
    actual = target.SystemGroupDataGridViewTextBoxColumn
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for StatusStrip2
'''</summary>
<TestMethod()>  _
Public Sub StatusStrip2Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As StatusStrip = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As StatusStrip
    target.StatusStrip2 = expected
    actual = target.StatusStrip2
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for StatusDataGridViewTextBoxColumn
'''</summary>
<TestMethod()>  _
Public Sub StatusDataGridViewTextBoxColumnTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.StatusDataGridViewTextBoxColumn = expected
    actual = target.StatusDataGridViewTextBoxColumn
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for SolutionDataGridViewTextBoxColumn
'''</summary>
<TestMethod()>  _
Public Sub SolutionDataGridViewTextBoxColumnTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.SolutionDataGridViewTextBoxColumn = expected
    actual = target.SolutionDataGridViewTextBoxColumn
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for SendEMailNoCFOLetterReceivedInTimeToolStripMenuItem
'''</summary>
<TestMethod()>  _
Public Sub SendEMailNoCFOLetterReceivedInTimeToolStripMenuItemTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.SendEMailNoCFOLetterReceivedInTimeToolStripMenuItem = expected
    actual = target.SendEMailNoCFOLetterReceivedInTimeToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for SendEMailFORMCFOApprovalToolStripMenuItem
'''</summary>
<TestMethod()>  _
Public Sub SendEMailFORMCFOApprovalToolStripMenuItemTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.SendEMailFORMCFOApprovalToolStripMenuItem = expected
    actual = target.SendEMailFORMCFOApprovalToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for SendCustomerNotificationMailsToolStripMenuItem
'''</summary>
<TestMethod()>  _
Public Sub SendCustomerNotificationMailsToolStripMenuItemTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.SendCustomerNotificationMailsToolStripMenuItem = expected
    actual = target.SendCustomerNotificationMailsToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for SelectAllCheckbox
'''</summary>
<TestMethod()>  _
Public Sub SelectAllCheckboxTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As CheckBox = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As CheckBox
    target.SelectAllCheckbox = expected
    actual = target.SelectAllCheckbox
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for RULES_FLOWSEQUENCETableAdapter
'''</summary>
<TestMethod()>  _
Public Sub RULES_FLOWSEQUENCETableAdapterTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As RULES_FLOWSEQUENCETableAdapter = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As RULES_FLOWSEQUENCETableAdapter
    target.RULES_FLOWSEQUENCETableAdapter = expected
    actual = target.RULES_FLOWSEQUENCETableAdapter
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for RULES_FLOWSEQUENCEBindingSource
'''</summary>
<TestMethod()>  _
Public Sub RULES_FLOWSEQUENCEBindingSourceTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As BindingSource = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As BindingSource
    target.RULES_FLOWSEQUENCEBindingSource = expected
    actual = target.RULES_FLOWSEQUENCEBindingSource
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for RULES_FLAGSTableAdapter
'''</summary>
<TestMethod()>  _
Public Sub RULES_FLAGSTableAdapterTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As RULES_FLAGSTableAdapter = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As RULES_FLAGSTableAdapter
    target.RULES_FLAGSTableAdapter = expected
    actual = target.RULES_FLAGSTableAdapter
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for RULES_FLAGSBindingSource
'''</summary>
<TestMethod()>  _
Public Sub RULES_FLAGSBindingSourceTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As BindingSource = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As BindingSource
    target.RULES_FLAGSBindingSource = expected
    actual = target.RULES_FLAGSBindingSource
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for RULES_FLAGS_VALIDTableAdapter
'''</summary>
<TestMethod()>  _
Public Sub RULES_FLAGS_VALIDTableAdapterTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As RULES_FLAGS_VALIDTableAdapter = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As RULES_FLAGS_VALIDTableAdapter
    target.RULES_FLAGS_VALIDTableAdapter = expected
    actual = target.RULES_FLAGS_VALIDTableAdapter
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for RULES_FLAGS_VALIDBindingSource
'''</summary>
<TestMethod()>  _
Public Sub RULES_FLAGS_VALIDBindingSourceTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As BindingSource = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As BindingSource
    target.RULES_FLAGS_VALIDBindingSource = expected
    actual = target.RULES_FLAGS_VALIDBindingSource
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for RightToolStripPanel
'''</summary>
<TestMethod()>  _
Public Sub RightToolStripPanelTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripPanel = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripPanel
    target.RightToolStripPanel = expected
    actual = target.RightToolStripPanel
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for RESPONSIBILITY
'''</summary>
<TestMethod()>  _
Public Sub RESPONSIBILITYTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.RESPONSIBILITY = expected
    actual = target.RESPONSIBILITY
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for RequestNoDataGridViewTextBoxColumn
'''</summary>
<TestMethod()>  _
Public Sub RequestNoDataGridViewTextBoxColumnTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.RequestNoDataGridViewTextBoxColumn = expected
    actual = target.RequestNoDataGridViewTextBoxColumn
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for RequestLogDataGridViewTextBoxColumn
'''</summary>
<TestMethod()>  _
Public Sub RequestLogDataGridViewTextBoxColumnTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.RequestLogDataGridViewTextBoxColumn = expected
    actual = target.RequestLogDataGridViewTextBoxColumn
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for RequestHistoryDataGridViewTextBoxColumn
'''</summary>
<TestMethod()>  _
Public Sub RequestHistoryDataGridViewTextBoxColumnTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.RequestHistoryDataGridViewTextBoxColumn = expected
    actual = target.RequestHistoryDataGridViewTextBoxColumn
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for RequestACFOLetterToolStripMenuItem
'''</summary>
<TestMethod()>  _
Public Sub RequestACFOLetterToolStripMenuItemTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.RequestACFOLetterToolStripMenuItem = expected
    actual = target.RequestACFOLetterToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for RequestACFOLetterFromClientToolStripMenuItem
'''</summary>
<TestMethod()>  _
Public Sub RequestACFOLetterFromClientToolStripMenuItemTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.RequestACFOLetterFromClientToolStripMenuItem = expected
    actual = target.RequestACFOLetterFromClientToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for REQ_PERSALPDF
'''</summary>
<TestMethod()>  _
Public Sub REQ_PERSALPDFTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.REQ_PERSALPDF = expected
    actual = target.REQ_PERSALPDF
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for REQ_LOGIS
'''</summary>
<TestMethod()>  _
Public Sub REQ_LOGISTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.REQ_LOGIS = expected
    actual = target.REQ_LOGIS
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for REQ_HR_OVERSIGHT
'''</summary>
<TestMethod()>  _
Public Sub REQ_HR_OVERSIGHTTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.REQ_HR_OVERSIGHT = expected
    actual = target.REQ_HR_OVERSIGHT
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for REQ_HR
'''</summary>
<TestMethod()>  _
Public Sub REQ_HRTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.REQ_HR = expected
    actual = target.REQ_HR
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for REQ_GFS
'''</summary>
<TestMethod()>  _
Public Sub REQ_GFSTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.REQ_GFS = expected
    actual = target.REQ_GFS
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for REQ_FINANCIALS
'''</summary>
<TestMethod()>  _
Public Sub REQ_FINANCIALSTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.REQ_FINANCIALS = expected
    actual = target.REQ_FINANCIALS
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for REQ_DPSA
'''</summary>
<TestMethod()>  _
Public Sub REQ_DPSATest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.REQ_DPSA = expected
    actual = target.REQ_DPSA
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for RemoveUserFromNewUserListToolStripMenuItem
'''</summary>
<TestMethod()>  _
Public Sub RemoveUserFromNewUserListToolStripMenuItemTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.RemoveUserFromNewUserListToolStripMenuItem = expected
    actual = target.RemoveUserFromNewUserListToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ReferToNTFinancialFunctionsToolStripMenuItem1
'''</summary>
<TestMethod()>  _
Public Sub ReferToNTFinancialFunctionsToolStripMenuItem1Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ReferToNTFinancialFunctionsToolStripMenuItem1 = expected
    actual = target.ReferToNTFinancialFunctionsToolStripMenuItem1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ReferToNTFinancialFunctionsToolStripMenuItem
'''</summary>
<TestMethod()>  _
Public Sub ReferToNTFinancialFunctionsToolStripMenuItemTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ReferToNTFinancialFunctionsToolStripMenuItem = expected
    actual = target.ReferToNTFinancialFunctionsToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for rbServerEnvironment
'''</summary>
<TestMethod()>  _
Public Sub rbServerEnvironmentTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As GroupBox = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As GroupBox
    target.rbServerEnvironment = expected
    actual = target.rbServerEnvironment
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for rbQA
'''</summary>
<TestMethod()>  _
Public Sub rbQATest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As RadioButton = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As RadioButton
    target.rbQA = expected
    actual = target.rbQA
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for rbPRD
'''</summary>
<TestMethod()>  _
Public Sub rbPRDTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As RadioButton = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As RadioButton
    target.rbPRD = expected
    actual = target.rbPRD
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for rbAccountLevel7
'''</summary>
<TestMethod()>  _
Public Sub rbAccountLevel7Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As RadioButton = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As RadioButton
    target.rbAccountLevel7 = expected
    actual = target.rbAccountLevel7
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for rbAccountLevel6
'''</summary>
<TestMethod()>  _
Public Sub rbAccountLevel6Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As RadioButton = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As RadioButton
    target.rbAccountLevel6 = expected
    actual = target.rbAccountLevel6
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for rbAccountLevel5
'''</summary>
<TestMethod()>  _
Public Sub rbAccountLevel5Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As RadioButton = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As RadioButton
    target.rbAccountLevel5 = expected
    actual = target.rbAccountLevel5
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for rbAccountLevel4
'''</summary>
<TestMethod()>  _
Public Sub rbAccountLevel4Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As RadioButton = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As RadioButton
    target.rbAccountLevel4 = expected
    actual = target.rbAccountLevel4
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for rbAccountLevel3
'''</summary>
<TestMethod()>  _
Public Sub rbAccountLevel3Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As RadioButton = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As RadioButton
    target.rbAccountLevel3 = expected
    actual = target.rbAccountLevel3
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for rbAccountLevel2
'''</summary>
<TestMethod()>  _
Public Sub rbAccountLevel2Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As RadioButton = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As RadioButton
    target.rbAccountLevel2 = expected
    actual = target.rbAccountLevel2
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for RadioButton6
'''</summary>
<TestMethod()>  _
Public Sub RadioButton6Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As RadioButton = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As RadioButton
    target.RadioButton6 = expected
    actual = target.RadioButton6
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for RadioButton5
'''</summary>
<TestMethod()>  _
Public Sub RadioButton5Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As RadioButton = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As RadioButton
    target.RadioButton5 = expected
    actual = target.RadioButton5
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for RadioButton4
'''</summary>
<TestMethod()>  _
Public Sub RadioButton4Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As RadioButton = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As RadioButton
    target.RadioButton4 = expected
    actual = target.RadioButton4
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for RadioButton3
'''</summary>
<TestMethod()>  _
Public Sub RadioButton3Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As RadioButton = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As RadioButton
    target.RadioButton3 = expected
    actual = target.RadioButton3
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for RadioButton2
'''</summary>
<TestMethod()>  _
Public Sub RadioButton2Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As RadioButton = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As RadioButton
    target.RadioButton2 = expected
    actual = target.RadioButton2
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for RadioButton1
'''</summary>
<TestMethod()>  _
Public Sub RadioButton1Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As RadioButton = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As RadioButton
    target.RadioButton1 = expected
    actual = target.RadioButton1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for QAWebToolStripMenuItem
'''</summary>
<TestMethod()>  _
Public Sub QAWebToolStripMenuItemTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.QAWebToolStripMenuItem = expected
    actual = target.QAWebToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for PRDWebToolStripMenuItem
'''</summary>
<TestMethod()>  _
Public Sub PRDWebToolStripMenuItemTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.PRDWebToolStripMenuItem = expected
    actual = target.PRDWebToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for PersalNumberDataGridViewTextBoxColumn
'''</summary>
<TestMethod()>  _
Public Sub PersalNumberDataGridViewTextBoxColumnTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.PersalNumberDataGridViewTextBoxColumn = expected
    actual = target.PersalNumberDataGridViewTextBoxColumn
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for pbMAIN
'''</summary>
<TestMethod()>  _
Public Sub pbMAINTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ProgressBar = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ProgressBar
    target.pbMAIN = expected
    actual = target.pbMAIN
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Panel1
'''</summary>
<TestMethod()>  _
Public Sub Panel1Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As Panel = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Panel
    target.Panel1 = expected
    actual = target.Panel1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for OwnerDataGridViewTextBoxColumn
'''</summary>
<TestMethod()>  _
Public Sub OwnerDataGridViewTextBoxColumnTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.OwnerDataGridViewTextBoxColumn = expected
    actual = target.OwnerDataGridViewTextBoxColumn
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for OriginalDueDateDataGridViewTextBoxColumn
'''</summary>
<TestMethod()>  _
Public Sub OriginalDueDateDataGridViewTextBoxColumnTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.OriginalDueDateDataGridViewTextBoxColumn = expected
    actual = target.OriginalDueDateDataGridViewTextBoxColumn
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for OpenVIPToolStripMenuItem
'''</summary>
<TestMethod()>  _
Public Sub OpenVIPToolStripMenuItemTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.OpenVIPToolStripMenuItem = expected
    actual = target.OpenVIPToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for OpenQAWebToolStripMenuItem1
'''</summary>
<TestMethod()>  _
Public Sub OpenQAWebToolStripMenuItem1Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.OpenQAWebToolStripMenuItem1 = expected
    actual = target.OpenQAWebToolStripMenuItem1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for OpenPRDWebToolStripMenuItem1
'''</summary>
<TestMethod()>  _
Public Sub OpenPRDWebToolStripMenuItem1Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.OpenPRDWebToolStripMenuItem1 = expected
    actual = target.OpenPRDWebToolStripMenuItem1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for NotifyUserToolStripMenuItem
'''</summary>
<TestMethod()>  _
Public Sub NotifyUserToolStripMenuItemTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.NotifyUserToolStripMenuItem = expected
    actual = target.NotifyUserToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for NotifyUserRequestRemovedOffQueueToolStripMenuItem1
'''</summary>
<TestMethod()>  _
Public Sub NotifyUserRequestRemovedOffQueueToolStripMenuItem1Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.NotifyUserRequestRemovedOffQueueToolStripMenuItem1 = expected
    actual = target.NotifyUserRequestRemovedOffQueueToolStripMenuItem1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for NotifyUserRequestRemovedOffQueueToolStripMenuItem
'''</summary>
<TestMethod()>  _
Public Sub NotifyUserRequestRemovedOffQueueToolStripMenuItemTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.NotifyUserRequestRemovedOffQueueToolStripMenuItem = expected
    actual = target.NotifyUserRequestRemovedOffQueueToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for NotifyUserAccountUpdatedToolStripMenuItem3
'''</summary>
<TestMethod()>  _
Public Sub NotifyUserAccountUpdatedToolStripMenuItem3Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.NotifyUserAccountUpdatedToolStripMenuItem3 = expected
    actual = target.NotifyUserAccountUpdatedToolStripMenuItem3
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for NotifyUserAccountUpdatedToolStripMenuItem2
'''</summary>
<TestMethod()>  _
Public Sub NotifyUserAccountUpdatedToolStripMenuItem2Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.NotifyUserAccountUpdatedToolStripMenuItem2 = expected
    actual = target.NotifyUserAccountUpdatedToolStripMenuItem2
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for NotifyUserAccountUpdatedToolStripMenuItem1
'''</summary>
<TestMethod()>  _
Public Sub NotifyUserAccountUpdatedToolStripMenuItem1Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.NotifyUserAccountUpdatedToolStripMenuItem1 = expected
    actual = target.NotifyUserAccountUpdatedToolStripMenuItem1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for NotifyUserAccountUpdatedToolStripMenuItem
'''</summary>
<TestMethod()>  _
Public Sub NotifyUserAccountUpdatedToolStripMenuItemTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.NotifyUserAccountUpdatedToolStripMenuItem = expected
    actual = target.NotifyUserAccountUpdatedToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for NotifyUserAccountResetToolStripMenuItem
'''</summary>
<TestMethod()>  _
Public Sub NotifyUserAccountResetToolStripMenuItemTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.NotifyUserAccountResetToolStripMenuItem = expected
    actual = target.NotifyUserAccountResetToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for NOTES
'''</summary>
<TestMethod()>  _
Public Sub NOTESTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.NOTES = expected
    actual = target.NOTES
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for NO_cfo_letter_received
'''</summary>
<TestMethod()>  _
Public Sub NO_cfo_letter_receivedTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.NO_cfo_letter_received = expected
    actual = target.NO_cfo_letter_received
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for NameDataGridViewTextBoxColumn
'''</summary>
<TestMethod()>  _
Public Sub NameDataGridViewTextBoxColumnTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.NameDataGridViewTextBoxColumn = expected
    actual = target.NameDataGridViewTextBoxColumn
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for MonthEndStats
'''</summary>
<TestMethod()>  _
Public Sub MonthEndStatsTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.MonthEndStats = expected
    actual = target.MonthEndStats
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for MenuStrip1
'''</summary>
<TestMethod()>  _
Public Sub MenuStrip1Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As MenuStrip = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As MenuStrip
    target.MenuStrip1 = expected
    actual = target.MenuStrip1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for lwDepartments
'''</summary>
<TestMethod()>  _
Public Sub lwDepartmentsTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ListView = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ListView
    target.lwDepartments = expected
    actual = target.lwDepartments
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for lwAppRoles2
'''</summary>
<TestMethod()>  _
Public Sub lwAppRoles2Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ListView = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ListView
    target.lwAppRoles2 = expected
    actual = target.lwAppRoles2
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for lwApplicationRoles
'''</summary>
<TestMethod()>  _
Public Sub lwApplicationRolesTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ListView = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ListView
    target.lwApplicationRoles = expected
    actual = target.lwApplicationRoles
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for lwA
'''</summary>
<TestMethod()>  _
Public Sub lwATest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ListView = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ListView
    target.lwA = expected
    actual = target.lwA
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for LongDescriptionDataGridViewTextBoxColumn
'''</summary>
<TestMethod()>  _
Public Sub LongDescriptionDataGridViewTextBoxColumnTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.LongDescriptionDataGridViewTextBoxColumn = expected
    actual = target.LongDescriptionDataGridViewTextBoxColumn
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for LOG_IN_Request_TrackingTableAdapter1
'''</summary>
<TestMethod()>  _
Public Sub LOG_IN_Request_TrackingTableAdapter1Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As LOG_IN_Request_TrackingTableAdapter = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As LOG_IN_Request_TrackingTableAdapter
    target.LOG_IN_Request_TrackingTableAdapter1 = expected
    actual = target.LOG_IN_Request_TrackingTableAdapter1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for LOG_IN_Request_TrackingTableAdapter
'''</summary>
<TestMethod()>  _
Public Sub LOG_IN_Request_TrackingTableAdapterTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As LOG_IN_Request_TrackingTableAdapter = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As LOG_IN_Request_TrackingTableAdapter
    target.LOG_IN_Request_TrackingTableAdapter = expected
    actual = target.LOG_IN_Request_TrackingTableAdapter
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for LOG_DM_PersonnelTableAdapter
'''</summary>
<TestMethod()>  _
Public Sub LOG_DM_PersonnelTableAdapterTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As LOG_DM_PersonnelTableAdapter = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As LOG_DM_PersonnelTableAdapter
    target.LOG_DM_PersonnelTableAdapter = expected
    actual = target.LOG_DM_PersonnelTableAdapter
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for LOG_DM_Customer_InformationTableAdapter1
'''</summary>
<TestMethod()>  _
Public Sub LOG_DM_Customer_InformationTableAdapter1Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As LOG_DM_Customer_InformationTableAdapter = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As LOG_DM_Customer_InformationTableAdapter
    target.LOG_DM_Customer_InformationTableAdapter1 = expected
    actual = target.LOG_DM_Customer_InformationTableAdapter1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for LOG_DM_Customer_InformationTableAdapter
'''</summary>
<TestMethod()>  _
Public Sub LOG_DM_Customer_InformationTableAdapterTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As LOG_DM_Customer_InformationTableAdapter = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As LOG_DM_Customer_InformationTableAdapter
    target.LOG_DM_Customer_InformationTableAdapter = expected
    actual = target.LOG_DM_Customer_InformationTableAdapter
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for LeftToolStripPanel
'''</summary>
<TestMethod()>  _
Public Sub LeftToolStripPanelTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripPanel = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripPanel
    target.LeftToolStripPanel = expected
    actual = target.LeftToolStripPanel
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for lblReferred
'''</summary>
<TestMethod()>  _
Public Sub lblReferredTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Label
    target.lblReferred = expected
    actual = target.lblReferred
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for lblDeptDiffer
'''</summary>
<TestMethod()>  _
Public Sub lblDeptDifferTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Label
    target.lblDeptDiffer = expected
    actual = target.lblDeptDiffer
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for lblCount
'''</summary>
<TestMethod()>  _
Public Sub lblCountTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Label
    target.lblCount = expected
    actual = target.lblCount
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Label8
'''</summary>
<TestMethod()>  _
Public Sub Label8Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Label
    target.Label8 = expected
    actual = target.Label8
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Label7
'''</summary>
<TestMethod()>  _
Public Sub Label7Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Label
    target.Label7 = expected
    actual = target.Label7
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Label6
'''</summary>
<TestMethod()>  _
Public Sub Label6Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Label
    target.Label6 = expected
    actual = target.Label6
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Label5
'''</summary>
<TestMethod()>  _
Public Sub Label5Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Label
    target.Label5 = expected
    actual = target.Label5
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Label4
'''</summary>
<TestMethod()>  _
Public Sub Label4Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Label
    target.Label4 = expected
    actual = target.Label4
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Label3
'''</summary>
<TestMethod()>  _
Public Sub Label3Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Label
    target.Label3 = expected
    actual = target.Label3
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Label2
'''</summary>
<TestMethod()>  _
Public Sub Label2Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Label
    target.Label2 = expected
    actual = target.Label2
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Label19
'''</summary>
<TestMethod()>  _
Public Sub Label19Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Label
    target.Label19 = expected
    actual = target.Label19
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Label18
'''</summary>
<TestMethod()>  _
Public Sub Label18Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Label
    target.Label18 = expected
    actual = target.Label18
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Label17
'''</summary>
<TestMethod()>  _
Public Sub Label17Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Label
    target.Label17 = expected
    actual = target.Label17
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Label15
'''</summary>
<TestMethod()>  _
Public Sub Label15Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Label
    target.Label15 = expected
    actual = target.Label15
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Label14
'''</summary>
<TestMethod()>  _
Public Sub Label14Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Label
    target.Label14 = expected
    actual = target.Label14
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Label13
'''</summary>
<TestMethod()>  _
Public Sub Label13Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Label
    target.Label13 = expected
    actual = target.Label13
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Label12
'''</summary>
<TestMethod()>  _
Public Sub Label12Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Label
    target.Label12 = expected
    actual = target.Label12
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Label11
'''</summary>
<TestMethod()>  _
Public Sub Label11Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Label
    target.Label11 = expected
    actual = target.Label11
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Label10
'''</summary>
<TestMethod()>  _
Public Sub Label10Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Label
    target.Label10 = expected
    actual = target.Label10
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Label1
'''</summary>
<TestMethod()>  _
Public Sub Label1Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Label
    target.Label1 = expected
    actual = target.Label1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for InitialsDataGridViewTextBoxColumn
'''</summary>
<TestMethod()>  _
Public Sub InitialsDataGridViewTextBoxColumnTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.InitialsDataGridViewTextBoxColumn = expected
    actual = target.InitialsDataGridViewTextBoxColumn
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ImageList1
'''</summary>
<TestMethod()>  _
Public Sub ImageList1Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ImageList = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ImageList
    target.ImageList1 = expected
    actual = target.ImageList1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ID
'''</summary>
<TestMethod()>  _
Public Sub IDTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.ID = expected
    actual = target.ID
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for GroupxDataGridViewTextBoxColumn
'''</summary>
<TestMethod()>  _
Public Sub GroupxDataGridViewTextBoxColumnTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.GroupxDataGridViewTextBoxColumn = expected
    actual = target.GroupxDataGridViewTextBoxColumn
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for GroupBox3
'''</summary>
<TestMethod()>  _
Public Sub GroupBox3Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As GroupBox = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As GroupBox
    target.GroupBox3 = expected
    actual = target.GroupBox3
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for GroupBox2
'''</summary>
<TestMethod()>  _
Public Sub GroupBox2Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As GroupBox = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As GroupBox
    target.GroupBox2 = expected
    actual = target.GroupBox2
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for GroupBox1
'''</summary>
<TestMethod()>  _
Public Sub GroupBox1Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As GroupBox = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As GroupBox
    target.GroupBox1 = expected
    actual = target.GroupBox1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for gridRequests
'''</summary>
<TestMethod()>  _
Public Sub gridRequestsTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As DataGridView = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridView
    target.gridRequests = expected
    actual = target.gridRequests
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for GetResetPasswordsTableAdapter1
'''</summary>
<TestMethod()>  _
Public Sub GetResetPasswordsTableAdapter1Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As GetResetPasswordsTableAdapter = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As GetResetPasswordsTableAdapter
    target.GetResetPasswordsTableAdapter1 = expected
    actual = target.GetResetPasswordsTableAdapter1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Get_shortcodeTableAdapter
'''</summary>
<TestMethod()>  _
Public Sub Get_shortcodeTableAdapterTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As get_shortcodeTableAdapter = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As get_shortcodeTableAdapter
    target.Get_shortcodeTableAdapter = expected
    actual = target.Get_shortcodeTableAdapter
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for gbExpiryDate
'''</summary>
<TestMethod()>  _
Public Sub gbExpiryDateTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As GroupBox = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As GroupBox
    target.gbExpiryDate = expected
    actual = target.gbExpiryDate
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for FunctionalAreaDataGridViewTextBoxColumn
'''</summary>
<TestMethod()>  _
Public Sub FunctionalAreaDataGridViewTextBoxColumnTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.FunctionalAreaDataGridViewTextBoxColumn = expected
    actual = target.FunctionalAreaDataGridViewTextBoxColumn
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for FileToolStripMenuItem
'''</summary>
<TestMethod()>  _
Public Sub FileToolStripMenuItemTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.FileToolStripMenuItem = expected
    actual = target.FileToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ExportActiveDirectoryDatabaseToolStripMenuItem
'''</summary>
<TestMethod()>  _
Public Sub ExportActiveDirectoryDatabaseToolStripMenuItemTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ExportActiveDirectoryDatabaseToolStripMenuItem = expected
    actual = target.ExportActiveDirectoryDatabaseToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ExitToolStripMenuItem
'''</summary>
<TestMethod()>  _
Public Sub ExitToolStripMenuItemTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ExitToolStripMenuItem = expected
    actual = target.ExitToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for EstablishmentToolStripMenuItem
'''</summary>
<TestMethod()>  _
Public Sub EstablishmentToolStripMenuItemTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.EstablishmentToolStripMenuItem = expected
    actual = target.EstablishmentToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Estab2BindingSource
'''</summary>
<TestMethod()>  _
Public Sub Estab2BindingSourceTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As BindingSource = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As BindingSource
    target.Estab2BindingSource = expected
    actual = target.Estab2BindingSource
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for EntryDateDataGridViewTextBoxColumn
'''</summary>
<TestMethod()>  _
Public Sub EntryDateDataGridViewTextBoxColumnTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.EntryDateDataGridViewTextBoxColumn = expected
    actual = target.EntryDateDataGridViewTextBoxColumn
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for EMailToVerifyAgainstEstablishmentToolStripMenuItem1
'''</summary>
<TestMethod()>  _
Public Sub EMailToVerifyAgainstEstablishmentToolStripMenuItem1Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.EMailToVerifyAgainstEstablishmentToolStripMenuItem1 = expected
    actual = target.EMailToVerifyAgainstEstablishmentToolStripMenuItem1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for EMailToVerifyAgainstEstablishmentToolStripMenuItem
'''</summary>
<TestMethod()>  _
Public Sub EMailToVerifyAgainstEstablishmentToolStripMenuItemTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.EMailToVerifyAgainstEstablishmentToolStripMenuItem = expected
    actual = target.EMailToVerifyAgainstEstablishmentToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for EMailToolStripMenuItem
'''</summary>
<TestMethod()>  _
Public Sub EMailToolStripMenuItemTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.EMailToolStripMenuItem = expected
    actual = target.EMailToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for EMailAPPROVALFORMCFOApprovalRequestToolStripMenuItem
'''</summary>
<TestMethod()>  _
Public Sub EMailAPPROVALFORMCFOApprovalRequestToolStripMenuItemTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.EMailAPPROVALFORMCFOApprovalRequestToolStripMenuItem = expected
    actual = target.EMailAPPROVALFORMCFOApprovalRequestToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for EditToolStripMenuItem
'''</summary>
<TestMethod()>  _
Public Sub EditToolStripMenuItemTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.EditToolStripMenuItem = expected
    actual = target.EditToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DueDateDataGridViewTextBoxColumn
'''</summary>
<TestMethod()>  _
Public Sub DueDateDataGridViewTextBoxColumnTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.DueDateDataGridViewTextBoxColumn = expected
    actual = target.DueDateDataGridViewTextBoxColumn
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for dtpAccountExpireDate
'''</summary>
<TestMethod()>  _
Public Sub dtpAccountExpireDateTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As DateTimePicker = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DateTimePicker
    target.dtpAccountExpireDate = expected
    actual = target.dtpAccountExpireDate
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DsADS1
'''</summary>
<TestMethod()>  _
Public Sub DsADS1Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As dsADS = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As dsADS
    target.DsADS1 = expected
    actual = target.DsADS1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DepartmentDiffersToolStripMenuItem
'''</summary>
<TestMethod()>  _
Public Sub DepartmentDiffersToolStripMenuItemTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.DepartmentDiffersToolStripMenuItem = expected
    actual = target.DepartmentDiffersToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Department_DiffersTableAdapter
'''</summary>
<TestMethod()>  _
Public Sub Department_DiffersTableAdapterTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As Department_DiffersTableAdapter = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Department_DiffersTableAdapter
    target.Department_DiffersTableAdapter = expected
    actual = target.Department_DiffersTableAdapter
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Department_DiffersBindingSource
'''</summary>
<TestMethod()>  _
Public Sub Department_DiffersBindingSourceTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As BindingSource = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As BindingSource
    target.Department_DiffersBindingSource = expected
    actual = target.Department_DiffersBindingSource
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Department
'''</summary>
<TestMethod()>  _
Public Sub DepartmentTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ColumnHeader = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ColumnHeader
    target.Department = expected
    actual = target.Department
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DataGridViewTextBoxColumn9
'''</summary>
<TestMethod()>  _
Public Sub DataGridViewTextBoxColumn9Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.DataGridViewTextBoxColumn9 = expected
    actual = target.DataGridViewTextBoxColumn9
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DataGridViewTextBoxColumn8
'''</summary>
<TestMethod()>  _
Public Sub DataGridViewTextBoxColumn8Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.DataGridViewTextBoxColumn8 = expected
    actual = target.DataGridViewTextBoxColumn8
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DataGridViewTextBoxColumn7
'''</summary>
<TestMethod()>  _
Public Sub DataGridViewTextBoxColumn7Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.DataGridViewTextBoxColumn7 = expected
    actual = target.DataGridViewTextBoxColumn7
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DataGridViewTextBoxColumn6
'''</summary>
<TestMethod()>  _
Public Sub DataGridViewTextBoxColumn6Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.DataGridViewTextBoxColumn6 = expected
    actual = target.DataGridViewTextBoxColumn6
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DataGridViewTextBoxColumn5
'''</summary>
<TestMethod()>  _
Public Sub DataGridViewTextBoxColumn5Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.DataGridViewTextBoxColumn5 = expected
    actual = target.DataGridViewTextBoxColumn5
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DataGridViewTextBoxColumn4
'''</summary>
<TestMethod()>  _
Public Sub DataGridViewTextBoxColumn4Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.DataGridViewTextBoxColumn4 = expected
    actual = target.DataGridViewTextBoxColumn4
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DataGridViewTextBoxColumn35
'''</summary>
<TestMethod()>  _
Public Sub DataGridViewTextBoxColumn35Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.DataGridViewTextBoxColumn35 = expected
    actual = target.DataGridViewTextBoxColumn35
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DataGridViewTextBoxColumn34
'''</summary>
<TestMethod()>  _
Public Sub DataGridViewTextBoxColumn34Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.DataGridViewTextBoxColumn34 = expected
    actual = target.DataGridViewTextBoxColumn34
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DataGridViewTextBoxColumn33
'''</summary>
<TestMethod()>  _
Public Sub DataGridViewTextBoxColumn33Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.DataGridViewTextBoxColumn33 = expected
    actual = target.DataGridViewTextBoxColumn33
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DataGridViewTextBoxColumn32
'''</summary>
<TestMethod()>  _
Public Sub DataGridViewTextBoxColumn32Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.DataGridViewTextBoxColumn32 = expected
    actual = target.DataGridViewTextBoxColumn32
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DataGridViewTextBoxColumn31
'''</summary>
<TestMethod()>  _
Public Sub DataGridViewTextBoxColumn31Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.DataGridViewTextBoxColumn31 = expected
    actual = target.DataGridViewTextBoxColumn31
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DataGridViewTextBoxColumn30
'''</summary>
<TestMethod()>  _
Public Sub DataGridViewTextBoxColumn30Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.DataGridViewTextBoxColumn30 = expected
    actual = target.DataGridViewTextBoxColumn30
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DataGridViewTextBoxColumn3
'''</summary>
<TestMethod()>  _
Public Sub DataGridViewTextBoxColumn3Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.DataGridViewTextBoxColumn3 = expected
    actual = target.DataGridViewTextBoxColumn3
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DataGridViewTextBoxColumn29
'''</summary>
<TestMethod()>  _
Public Sub DataGridViewTextBoxColumn29Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.DataGridViewTextBoxColumn29 = expected
    actual = target.DataGridViewTextBoxColumn29
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DataGridViewTextBoxColumn28
'''</summary>
<TestMethod()>  _
Public Sub DataGridViewTextBoxColumn28Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.DataGridViewTextBoxColumn28 = expected
    actual = target.DataGridViewTextBoxColumn28
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DataGridViewTextBoxColumn27
'''</summary>
<TestMethod()>  _
Public Sub DataGridViewTextBoxColumn27Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.DataGridViewTextBoxColumn27 = expected
    actual = target.DataGridViewTextBoxColumn27
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DataGridViewTextBoxColumn26
'''</summary>
<TestMethod()>  _
Public Sub DataGridViewTextBoxColumn26Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.DataGridViewTextBoxColumn26 = expected
    actual = target.DataGridViewTextBoxColumn26
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DataGridViewTextBoxColumn25
'''</summary>
<TestMethod()>  _
Public Sub DataGridViewTextBoxColumn25Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.DataGridViewTextBoxColumn25 = expected
    actual = target.DataGridViewTextBoxColumn25
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DataGridViewTextBoxColumn24
'''</summary>
<TestMethod()>  _
Public Sub DataGridViewTextBoxColumn24Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.DataGridViewTextBoxColumn24 = expected
    actual = target.DataGridViewTextBoxColumn24
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DataGridViewTextBoxColumn23
'''</summary>
<TestMethod()>  _
Public Sub DataGridViewTextBoxColumn23Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.DataGridViewTextBoxColumn23 = expected
    actual = target.DataGridViewTextBoxColumn23
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DataGridViewTextBoxColumn22
'''</summary>
<TestMethod()>  _
Public Sub DataGridViewTextBoxColumn22Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.DataGridViewTextBoxColumn22 = expected
    actual = target.DataGridViewTextBoxColumn22
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DataGridViewTextBoxColumn21
'''</summary>
<TestMethod()>  _
Public Sub DataGridViewTextBoxColumn21Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.DataGridViewTextBoxColumn21 = expected
    actual = target.DataGridViewTextBoxColumn21
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DataGridViewTextBoxColumn20
'''</summary>
<TestMethod()>  _
Public Sub DataGridViewTextBoxColumn20Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.DataGridViewTextBoxColumn20 = expected
    actual = target.DataGridViewTextBoxColumn20
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DataGridViewTextBoxColumn2
'''</summary>
<TestMethod()>  _
Public Sub DataGridViewTextBoxColumn2Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.DataGridViewTextBoxColumn2 = expected
    actual = target.DataGridViewTextBoxColumn2
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DataGridViewTextBoxColumn19
'''</summary>
<TestMethod()>  _
Public Sub DataGridViewTextBoxColumn19Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.DataGridViewTextBoxColumn19 = expected
    actual = target.DataGridViewTextBoxColumn19
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DataGridViewTextBoxColumn18
'''</summary>
<TestMethod()>  _
Public Sub DataGridViewTextBoxColumn18Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.DataGridViewTextBoxColumn18 = expected
    actual = target.DataGridViewTextBoxColumn18
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DataGridViewTextBoxColumn17
'''</summary>
<TestMethod()>  _
Public Sub DataGridViewTextBoxColumn17Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.DataGridViewTextBoxColumn17 = expected
    actual = target.DataGridViewTextBoxColumn17
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DataGridViewTextBoxColumn16
'''</summary>
<TestMethod()>  _
Public Sub DataGridViewTextBoxColumn16Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.DataGridViewTextBoxColumn16 = expected
    actual = target.DataGridViewTextBoxColumn16
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DataGridViewTextBoxColumn15
'''</summary>
<TestMethod()>  _
Public Sub DataGridViewTextBoxColumn15Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.DataGridViewTextBoxColumn15 = expected
    actual = target.DataGridViewTextBoxColumn15
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DataGridViewTextBoxColumn14
'''</summary>
<TestMethod()>  _
Public Sub DataGridViewTextBoxColumn14Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.DataGridViewTextBoxColumn14 = expected
    actual = target.DataGridViewTextBoxColumn14
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DataGridViewTextBoxColumn13
'''</summary>
<TestMethod()>  _
Public Sub DataGridViewTextBoxColumn13Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.DataGridViewTextBoxColumn13 = expected
    actual = target.DataGridViewTextBoxColumn13
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DataGridViewTextBoxColumn12
'''</summary>
<TestMethod()>  _
Public Sub DataGridViewTextBoxColumn12Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.DataGridViewTextBoxColumn12 = expected
    actual = target.DataGridViewTextBoxColumn12
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DataGridViewTextBoxColumn11
'''</summary>
<TestMethod()>  _
Public Sub DataGridViewTextBoxColumn11Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.DataGridViewTextBoxColumn11 = expected
    actual = target.DataGridViewTextBoxColumn11
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DataGridViewTextBoxColumn10
'''</summary>
<TestMethod()>  _
Public Sub DataGridViewTextBoxColumn10Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.DataGridViewTextBoxColumn10 = expected
    actual = target.DataGridViewTextBoxColumn10
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DataGridViewTextBoxColumn1
'''</summary>
<TestMethod()>  _
Public Sub DataGridViewTextBoxColumn1Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.DataGridViewTextBoxColumn1 = expected
    actual = target.DataGridViewTextBoxColumn1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DataGridViewCheckBoxColumn1
'''</summary>
<TestMethod()>  _
Public Sub DataGridViewCheckBoxColumn1Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewCheckBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewCheckBoxColumn
    target.DataGridViewCheckBoxColumn1 = expected
    actual = target.DataGridViewCheckBoxColumn1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DataGridView2
'''</summary>
<TestMethod()>  _
Public Sub DataGridView2Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As DataGridView = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridView
    target.DataGridView2 = expected
    actual = target.DataGridView2
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DataGridView1
'''</summary>
<TestMethod()>  _
Public Sub DataGridView1Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As DataGridView = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridView
    target.DataGridView1 = expected
    actual = target.DataGridView1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for DataGrid1
'''</summary>
<TestMethod()>  _
Public Sub DataGrid1Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As DataGridView = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridView
    target.DataGrid1 = expected
    actual = target.DataGrid1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for CustomerInfoTableAdapter
'''</summary>
<TestMethod()>  _
Public Sub CustomerInfoTableAdapterTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As CustomerInfoTableAdapter = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As CustomerInfoTableAdapter
    target.CustomerInfoTableAdapter = expected
    actual = target.CustomerInfoTableAdapter
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for CreatedDate
'''</summary>
<TestMethod()>  _
Public Sub CreatedDateTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.CreatedDate = expected
    actual = target.CreatedDate
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for CountNewUsersTableAdapter
'''</summary>
<TestMethod()>  _
Public Sub CountNewUsersTableAdapterTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As CountNewUsersTableAdapter = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As CountNewUsersTableAdapter
    target.CountNewUsersTableAdapter = expected
    actual = target.CountNewUsersTableAdapter
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ContentPanel
'''</summary>
<TestMethod()>  _
Public Sub ContentPanelTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripContentPanel = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripContentPanel
    target.ContentPanel = expected
    actual = target.ContentPanel
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ColumnHeader9
'''</summary>
<TestMethod()>  _
Public Sub ColumnHeader9Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ColumnHeader = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ColumnHeader
    target.ColumnHeader9 = expected
    actual = target.ColumnHeader9
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ColumnHeader8
'''</summary>
<TestMethod()>  _
Public Sub ColumnHeader8Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ColumnHeader = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ColumnHeader
    target.ColumnHeader8 = expected
    actual = target.ColumnHeader8
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ColumnHeader7
'''</summary>
<TestMethod()>  _
Public Sub ColumnHeader7Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ColumnHeader = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ColumnHeader
    target.ColumnHeader7 = expected
    actual = target.ColumnHeader7
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ColumnHeader6
'''</summary>
<TestMethod()>  _
Public Sub ColumnHeader6Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ColumnHeader = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ColumnHeader
    target.ColumnHeader6 = expected
    actual = target.ColumnHeader6
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ColumnHeader5
'''</summary>
<TestMethod()>  _
Public Sub ColumnHeader5Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ColumnHeader = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ColumnHeader
    target.ColumnHeader5 = expected
    actual = target.ColumnHeader5
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ColumnHeader4
'''</summary>
<TestMethod()>  _
Public Sub ColumnHeader4Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ColumnHeader = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ColumnHeader
    target.ColumnHeader4 = expected
    actual = target.ColumnHeader4
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ColumnHeader3
'''</summary>
<TestMethod()>  _
Public Sub ColumnHeader3Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ColumnHeader = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ColumnHeader
    target.ColumnHeader3 = expected
    actual = target.ColumnHeader3
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ColumnHeader2
'''</summary>
<TestMethod()>  _
Public Sub ColumnHeader2Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ColumnHeader = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ColumnHeader
    target.ColumnHeader2 = expected
    actual = target.ColumnHeader2
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ColumnHeader10
'''</summary>
<TestMethod()>  _
Public Sub ColumnHeader10Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ColumnHeader = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ColumnHeader
    target.ColumnHeader10 = expected
    actual = target.ColumnHeader10
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ColumnHeader1
'''</summary>
<TestMethod()>  _
Public Sub ColumnHeader1Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ColumnHeader = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ColumnHeader
    target.ColumnHeader1 = expected
    actual = target.ColumnHeader1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Column1
'''</summary>
<TestMethod()>  _
Public Sub Column1Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.Column1 = expected
    actual = target.Column1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for colGroupName
'''</summary>
<TestMethod()>  _
Public Sub colGroupNameTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ColumnHeader = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ColumnHeader
    target.colGroupName = expected
    actual = target.colGroupName
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for colDescription
'''</summary>
<TestMethod()>  _
Public Sub colDescriptionTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ColumnHeader = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ColumnHeader
    target.colDescription = expected
    actual = target.colDescription
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for col1
'''</summary>
<TestMethod()>  _
Public Sub col1Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ColumnHeader = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ColumnHeader
    target.col1 = expected
    actual = target.col1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Code
'''</summary>
<TestMethod()>  _
Public Sub CodeTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ColumnHeader = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ColumnHeader
    target.Code = expected
    actual = target.Code
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ClosedDateDataGridViewTextBoxColumn
'''</summary>
<TestMethod()>  _
Public Sub ClosedDateDataGridViewTextBoxColumnTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.ClosedDateDataGridViewTextBoxColumn = expected
    actual = target.ClosedDateDataGridViewTextBoxColumn
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ClientsWithConfigProblemsToolStripMenuItem
'''</summary>
<TestMethod()>  _
Public Sub ClientsWithConfigProblemsToolStripMenuItemTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ClientsWithConfigProblemsToolStripMenuItem = expected
    actual = target.ClientsWithConfigProblemsToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for chkProfileCategories
'''</summary>
<TestMethod()>  _
Public Sub chkProfileCategoriesTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ListView = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ListView
    target.chkProfileCategories = expected
    actual = target.chkProfileCategories
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for chkLocked
'''</summary>
<TestMethod()>  _
Public Sub chkLockedTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As CheckBox = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As CheckBox
    target.chkLocked = expected
    actual = target.chkLocked
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for chkEnabled
'''</summary>
<TestMethod()>  _
Public Sub chkEnabledTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As CheckBox = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As CheckBox
    target.chkEnabled = expected
    actual = target.chkEnabled
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for checkbox
'''</summary>
<TestMethod()>  _
Public Sub checkboxTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ColumnHeader = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ColumnHeader
    target.checkbox = expected
    actual = target.checkbox
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for CFOListToolStripMenuItem
'''</summary>
<TestMethod()>  _
Public Sub CFOListToolStripMenuItemTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.CFOListToolStripMenuItem = expected
    actual = target.CFOListToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for CFOListTableAdapter
'''</summary>
<TestMethod()>  _
Public Sub CFOListTableAdapterTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As CFOListTableAdapter = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As CFOListTableAdapter
    target.CFOListTableAdapter = expected
    actual = target.CFOListTableAdapter
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for CFOListBindingSource
'''</summary>
<TestMethod()>  _
Public Sub CFOListBindingSourceTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As BindingSource = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As BindingSource
    target.CFOListBindingSource = expected
    actual = target.CFOListBindingSource
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for CFOApprovalBindingSource
'''</summary>
<TestMethod()>  _
Public Sub CFOApprovalBindingSourceTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As BindingSource = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As BindingSource
    target.CFOApprovalBindingSource = expected
    actual = target.CFOApprovalBindingSource
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for cfo_letter_received
'''</summary>
<TestMethod()>  _
Public Sub cfo_letter_receivedTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.cfo_letter_received = expected
    actual = target.cfo_letter_received
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for CEL_TEL
'''</summary>
<TestMethod()>  _
Public Sub CEL_TELTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.CEL_TEL = expected
    actual = target.CEL_TEL
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for cboNatProv
'''</summary>
<TestMethod()>  _
Public Sub cboNatProvTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ComboBox = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ComboBox
    target.cboNatProv = expected
    actual = target.cboNatProv
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for cboAssDepts
'''</summary>
<TestMethod()>  _
Public Sub cboAssDeptsTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ComboBox = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ComboBox
    target.cboAssDepts = expected
    actual = target.cboAssDepts
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Captured
'''</summary>
<TestMethod()>  _
Public Sub CapturedTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.Captured = expected
    actual = target.Captured
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for CancelToolStripMenuItem
'''</summary>
<TestMethod()>  _
Public Sub CancelToolStripMenuItemTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.CancelToolStripMenuItem = expected
    actual = target.CancelToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for CallCentreToolStripMenuItem
'''</summary>
<TestMethod()>  _
Public Sub CallCentreToolStripMenuItemTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.CallCentreToolStripMenuItem = expected
    actual = target.CallCentreToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for BySurnameToolStripMenuItem1
'''</summary>
<TestMethod()>  _
Public Sub BySurnameToolStripMenuItem1Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.BySurnameToolStripMenuItem1 = expected
    actual = target.BySurnameToolStripMenuItem1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for BySurnameToolStripMenuItem
'''</summary>
<TestMethod()>  _
Public Sub BySurnameToolStripMenuItemTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.BySurnameToolStripMenuItem = expected
    actual = target.BySurnameToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ByRequestToolStripMenuItem1
'''</summary>
<TestMethod()>  _
Public Sub ByRequestToolStripMenuItem1Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ByRequestToolStripMenuItem1 = expected
    actual = target.ByRequestToolStripMenuItem1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ByRequestToolStripMenuItem
'''</summary>
<TestMethod()>  _
Public Sub ByRequestToolStripMenuItemTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ByRequestToolStripMenuItem = expected
    actual = target.ByRequestToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ByEstablishmentToolStripMenuItem
'''</summary>
<TestMethod()>  _
Public Sub ByEstablishmentToolStripMenuItemTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.ByEstablishmentToolStripMenuItem = expected
    actual = target.ByEstablishmentToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Button3
'''</summary>
<TestMethod()>  _
Public Sub Button3Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As Button = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Button
    target.Button3 = expected
    actual = target.Button3
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Button2
'''</summary>
<TestMethod()>  _
Public Sub Button2Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As Button = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Button
    target.Button2 = expected
    actual = target.Button2
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Button1
'''</summary>
<TestMethod()>  _
Public Sub Button1Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As Button = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Button
    target.Button1 = expected
    actual = target.Button1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for BUS_TEL
'''</summary>
<TestMethod()>  _
Public Sub BUS_TELTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.BUS_TEL = expected
    actual = target.BUS_TEL
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for btnVariationList0
'''</summary>
<TestMethod()>  _
Public Sub btnVariationList0Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripButton = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripButton
    target.btnVariationList0 = expected
    actual = target.btnVariationList0
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for btnVariationList
'''</summary>
<TestMethod()>  _
Public Sub btnVariationListTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripButton = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripButton
    target.btnVariationList = expected
    actual = target.btnVariationList
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for btnToFollowUp
'''</summary>
<TestMethod()>  _
Public Sub btnToFollowUpTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As Button = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Button
    target.btnToFollowUp = expected
    actual = target.btnToFollowUp
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for btnResetPwd
'''</summary>
<TestMethod()>  _
Public Sub btnResetPwdTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As Button = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Button
    target.btnResetPwd = expected
    actual = target.btnResetPwd
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for btnResetPassword
'''</summary>
<TestMethod()>  _
Public Sub btnResetPasswordTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As Button = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Button
    target.btnResetPassword = expected
    actual = target.btnResetPassword
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for btnReferrals
'''</summary>
<TestMethod()>  _
Public Sub btnReferralsTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As Button = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Button
    target.btnReferrals = expected
    actual = target.btnReferrals
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for btnOpenRequests
'''</summary>
<TestMethod()>  _
Public Sub btnOpenRequestsTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As Button = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Button
    target.btnOpenRequests = expected
    actual = target.btnOpenRequests
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for btnNewUsers
'''</summary>
<TestMethod()>  _
Public Sub btnNewUsersTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As Button = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Button
    target.btnNewUsers = expected
    actual = target.btnNewUsers
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for btnKodeer
'''</summary>
<TestMethod()>  _
Public Sub btnKodeerTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As Button = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Button
    target.btnKodeer = expected
    actual = target.btnKodeer
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for btnExpirePassword
'''</summary>
<TestMethod()>  _
Public Sub btnExpirePasswordTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As Button = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Button
    target.btnExpirePassword = expected
    actual = target.btnExpirePassword
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for btnExpireAccXdays
'''</summary>
<TestMethod()>  _
Public Sub btnExpireAccXdaysTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As Button = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Button
    target.btnExpireAccXdays = expected
    actual = target.btnExpireAccXdays
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for btnEstablishment0
'''</summary>
<TestMethod()>  _
Public Sub btnEstablishment0Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripDropDownButton = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripDropDownButton
    target.btnEstablishment0 = expected
    actual = target.btnEstablishment0
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for btnEstablishment
'''</summary>
<TestMethod()>  _
Public Sub btnEstablishmentTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripDropDownButton = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripDropDownButton
    target.btnEstablishment = expected
    actual = target.btnEstablishment
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for btnDeptDiffers
'''</summary>
<TestMethod()>  _
Public Sub btnDeptDiffersTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As Button = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Button
    target.btnDeptDiffers = expected
    actual = target.btnDeptDiffers
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for btnActiveDirectory
'''</summary>
<TestMethod()>  _
Public Sub btnActiveDirectoryTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.btnActiveDirectory = expected
    actual = target.btnActiveDirectory
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for bsCust
'''</summary>
<TestMethod()>  _
Public Sub bsCustTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As BindingSource = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As BindingSource
    target.bsCust = expected
    actual = target.bsCust
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for bs_Vulindlela_EMail
'''</summary>
<TestMethod()>  _
Public Sub bs_Vulindlela_EMailTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As BindingSource = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As BindingSource
    target.bs_Vulindlela_EMail = expected
    actual = target.bs_Vulindlela_EMail
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for bs_Vulindlela_Controllers
'''</summary>
<TestMethod()>  _
Public Sub bs_Vulindlela_ControllersTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As BindingSource = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As BindingSource
    target.bs_Vulindlela_Controllers = expected
    actual = target.bs_Vulindlela_Controllers
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for bs_VIP_USERS
'''</summary>
<TestMethod()>  _
Public Sub bs_VIP_USERSTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As BindingSource = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As BindingSource
    target.bs_VIP_USERS = expected
    actual = target.bs_VIP_USERS
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for bs_VIP_Expanded
'''</summary>
<TestMethod()>  _
Public Sub bs_VIP_ExpandedTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As BindingSource = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As BindingSource
    target.bs_VIP_Expanded = expected
    actual = target.bs_VIP_Expanded
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for bs_VIEWdepartments
'''</summary>
<TestMethod()>  _
Public Sub bs_VIEWdepartmentsTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As BindingSource = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As BindingSource
    target.bs_VIEWdepartments = expected
    actual = target.bs_VIEWdepartments
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for bs_VIEW_APPLICATION_RIGHTS
'''</summary>
<TestMethod()>  _
Public Sub bs_VIEW_APPLICATION_RIGHTSTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As BindingSource = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As BindingSource
    target.bs_VIEW_APPLICATION_RIGHTS = expected
    actual = target.bs_VIEW_APPLICATION_RIGHTS
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for bs_LOGINRequestTracking
'''</summary>
<TestMethod()>  _
Public Sub bs_LOGINRequestTrackingTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As BindingSource = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As BindingSource
    target.bs_LOGINRequestTracking = expected
    actual = target.bs_LOGINRequestTracking
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for bs_LoggedOnCount
'''</summary>
<TestMethod()>  _
Public Sub bs_LoggedOnCountTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As BindingSource = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As BindingSource
    target.bs_LoggedOnCount = expected
    actual = target.bs_LoggedOnCount
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for bs_LOGDMCustomeInformation
'''</summary>
<TestMethod()>  _
Public Sub bs_LOGDMCustomeInformationTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As BindingSource = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As BindingSource
    target.bs_LOGDMCustomeInformation = expected
    actual = target.bs_LOGDMCustomeInformation
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for bs_LOG_DM_Personnel
'''</summary>
<TestMethod()>  _
Public Sub bs_LOG_DM_PersonnelTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As BindingSource = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As BindingSource
    target.bs_LOG_DM_Personnel = expected
    actual = target.bs_LOG_DM_Personnel
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for bs_Kickout
'''</summary>
<TestMethod()>  _
Public Sub bs_KickoutTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As BindingSource = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As BindingSource
    target.bs_Kickout = expected
    actual = target.bs_Kickout
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for bs_GetResetPasswords
'''</summary>
<TestMethod()>  _
Public Sub bs_GetResetPasswordsTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As BindingSource = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As BindingSource
    target.bs_GetResetPasswords = expected
    actual = target.bs_GetResetPasswords
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for bs_Get_shortcode
'''</summary>
<TestMethod()>  _
Public Sub bs_Get_shortcodeTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As BindingSource = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As BindingSource
    target.bs_Get_shortcode = expected
    actual = target.bs_Get_shortcode
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for bs_Establishment
'''</summary>
<TestMethod()>  _
Public Sub bs_EstablishmentTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As BindingSource = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As BindingSource
    target.bs_Establishment = expected
    actual = target.bs_Establishment
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for bs_CustomerNotofication
'''</summary>
<TestMethod()>  _
Public Sub bs_CustomerNotoficationTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As BindingSource = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As BindingSource
    target.bs_CustomerNotofication = expected
    actual = target.bs_CustomerNotofication
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for bs_CustomerInfoSave
'''</summary>
<TestMethod()>  _
Public Sub bs_CustomerInfoSaveTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As BindingSource = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As BindingSource
    target.bs_CustomerInfoSave = expected
    actual = target.bs_CustomerInfoSave
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for bs_CustomerInfo
'''</summary>
<TestMethod()>  _
Public Sub bs_CustomerInfoTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As BindingSource = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As BindingSource
    target.bs_CustomerInfo = expected
    actual = target.bs_CustomerInfo
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for bs_CountNewUsers
'''</summary>
<TestMethod()>  _
Public Sub bs_CountNewUsersTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As BindingSource = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As BindingSource
    target.bs_CountNewUsers = expected
    actual = target.bs_CountNewUsers
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for bs_ADCONSOLELOG
'''</summary>
<TestMethod()>  _
Public Sub bs_ADCONSOLELOGTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As BindingSource = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As BindingSource
    target.bs_ADCONSOLELOG = expected
    actual = target.bs_ADCONSOLELOG
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for BottomToolStripPanel
'''</summary>
<TestMethod()>  _
Public Sub BottomToolStripPanelTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripPanel = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripPanel
    target.BottomToolStripPanel = expected
    actual = target.BottomToolStripPanel
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for AssignedtoDataGridViewTextBoxColumn
'''</summary>
<TestMethod()>  _
Public Sub AssignedtoDataGridViewTextBoxColumnTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As DataGridViewTextBoxColumn = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridViewTextBoxColumn
    target.AssignedtoDataGridViewTextBoxColumn = expected
    actual = target.AssignedtoDataGridViewTextBoxColumn
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ARSystemDataSet1
'''</summary>
<TestMethod()>  _
Public Sub ARSystemDataSet1Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As dsARSystemDataSet = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As dsARSystemDataSet
    target.ARSystemDataSet1 = expected
    actual = target.ARSystemDataSet1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ARSystemDataSet
'''</summary>
<TestMethod()>  _
Public Sub ARSystemDataSetTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As dsARSystemDataSet = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As dsARSystemDataSet
    target.ARSystemDataSet = expected
    actual = target.ARSystemDataSet
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Applications
'''</summary>
<TestMethod()>  _
Public Sub ApplicationsTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As GroupBox = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As GroupBox
    target.Applications = expected
    actual = target.Applications
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for AmmendVulindlelaExclusionListToolStripMenuItem
'''</summary>
<TestMethod()>  _
Public Sub AmmendVulindlelaExclusionListToolStripMenuItemTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.AmmendVulindlelaExclusionListToolStripMenuItem = expected
    actual = target.AmmendVulindlelaExclusionListToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for AmendTheVulindlelaExceptionListToolStripMenuItem
'''</summary>
<TestMethod()>  _
Public Sub AmendTheVulindlelaExceptionListToolStripMenuItemTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.AmendTheVulindlelaExceptionListToolStripMenuItem = expected
    actual = target.AmendTheVulindlelaExceptionListToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Ads1
'''</summary>
<TestMethod()>  _
Public Sub Ads1Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As dsADS = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As dsADS
    target.Ads1 = expected
    actual = target.Ads1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for AdminToolStripMenuItem
'''</summary>
<TestMethod()>  _
Public Sub AdminToolStripMenuItemTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ToolStripMenuItem = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ToolStripMenuItem
    target.AdminToolStripMenuItem = expected
    actual = target.AdminToolStripMenuItem
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ADCONSOLELOGTableAdapter
'''</summary>
<TestMethod()>  _
Public Sub ADCONSOLELOGTableAdapterTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As ADCONSOLELOGTableAdapter = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As ADCONSOLELOGTableAdapter
    target.ADCONSOLELOGTableAdapter = expected
    actual = target.ADCONSOLELOGTableAdapter
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ADCONSOLELOGDataGridView
'''</summary>
<TestMethod()>  _
Public Sub ADCONSOLELOGDataGridViewTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As DataGridView = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As DataGridView
    target.ADCONSOLELOGDataGridView = expected
    actual = target.ADCONSOLELOGDataGridView
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for AD_SNAPSHOT_ALLTableAdapter1
'''</summary>
<TestMethod()>  _
Public Sub AD_SNAPSHOT_ALLTableAdapter1Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As AD_SNAPSHOT_ALLTableAdapter = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As AD_SNAPSHOT_ALLTableAdapter
    target.AD_SNAPSHOT_ALLTableAdapter1 = expected
    actual = target.AD_SNAPSHOT_ALLTableAdapter1
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for AD_SNAPSHOT_ALLTableAdapter
'''</summary>
<TestMethod()>  _
Public Sub AD_SNAPSHOT_ALLTableAdapterTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As AD_SNAPSHOT_ALLTableAdapter = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As AD_SNAPSHOT_ALLTableAdapter
    target.AD_SNAPSHOT_ALLTableAdapter = expected
    actual = target.AD_SNAPSHOT_ALLTableAdapter
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for AD_SNAPSHOT_ALLBindingSource
'''</summary>
<TestMethod()>  _
Public Sub AD_SNAPSHOT_ALLBindingSourceTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As BindingSource = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As BindingSource
    target.AD_SNAPSHOT_ALLBindingSource = expected
    actual = target.AD_SNAPSHOT_ALLBindingSource
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for AccountLevel
'''</summary>
<TestMethod()>  _
Public Sub AccountLevelTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As GroupBox = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As GroupBox
    target.AccountLevel = expected
    actual = target.AccountLevel
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for WriteAdminLogEntry
'''</summary>
<TestMethod()>  _
Public Sub WriteAdminLogEntryTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim EntryString As String = String.Empty ' TODO: Initialize to an appropriate value
    target.WriteAdminLogEntry(EntryString)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for VulindlelaControllerToolStripMenuItem_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub VulindlelaControllerToolStripMenuItem_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.VulindlelaControllerToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for VPNAdminsToolStripMenuItem_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub VPNAdminsToolStripMenuItem_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.VPNAdminsToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for VIP_USERSDataGridView_CellContentDoubleClick
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub VIP_USERSDataGridView_CellContentDoubleClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As DataGridViewCellEventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.VIP_USERSDataGridView_CellContentDoubleClick(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for UsersNotOnEstablishmentToolStripMenuItem_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub UsersNotOnEstablishmentToolStripMenuItem_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.UsersNotOnEstablishmentToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for Update_Rules_Flags_With_CFOID
'''</summary>
<TestMethod()>  _
Public Sub Update_Rules_Flags_With_CFOIDTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim requestno As String = String.Empty ' TODO: Initialize to an appropriate value
Dim cfoid As String = String.Empty ' TODO: Initialize to an appropriate value
Dim expected As Object = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Object
    actual = target.Update_Rules_Flags_With_CFOID(requestno, cfoid)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for uncheck_chkProfileCategories_all
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub uncheck_chkProfileCategories_allTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.uncheck_chkProfileCategories_all(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for txtPersalNumberKeyPress
'''</summary>
<TestMethod()>  _
Public Sub txtPersalNumberKeyPressTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
    target.txtPersalNumberKeyPress
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for txtPersalNumber_KeyPress
'''</summary>
<TestMethod()>  _
Public Sub txtPersalNumber_KeyPressTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As KeyPressEventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.txtPersalNumber_KeyPress(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for txtPersalNumber_DoubleClick
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub txtPersalNumber_DoubleClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.txtPersalNumber_DoubleClick(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for tsSendEMailFORMBOApprovalToolStripMenuItem_Click
'''</summary>
<TestMethod()>  _
Public Sub tsSendEMailFORMBOApprovalToolStripMenuItem_ClickTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.tsSendEMailFORMBOApprovalToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for tsNTFinFunc_Approval_Request_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub tsNTFinFunc_Approval_Request_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.tsNTFinFunc_Approval_Request_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for tsDeptDiffers0_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub tsDeptDiffers0_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.tsDeptDiffers0_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for tsDeptDiffers_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub tsDeptDiffers_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.tsDeptDiffers_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for tsCFO_Approval_Request_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub tsCFO_Approval_Request_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.tsCFO_Approval_Request_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for tsBtnUpdateUser0_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub tsBtnUpdateUser0_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.tsBtnUpdateUser0_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for tsBtnUpdateUser_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub tsBtnUpdateUser_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.tsBtnUpdateUser_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for tsBtnNewUser0_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub tsBtnNewUser0_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.tsBtnNewUser0_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for tsBtnNewUser_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub tsBtnNewUser_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.tsBtnNewUser_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for tsBtnDeleteUser0_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub tsBtnDeleteUser0_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.tsBtnDeleteUser0_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for tsBtnDeleteUser_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub tsBtnDeleteUser_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.tsBtnDeleteUser_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for ToolStripTextBox2_KeyPress
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ToolStripTextBox2_KeyPressTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As KeyPressEventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.ToolStripTextBox2_KeyPress(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for ToolStripTextBox2_DoubleClick
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ToolStripTextBox2_DoubleClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.ToolStripTextBox2_DoubleClick(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem83_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ToolStripMenuItem83_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.ToolStripMenuItem83_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem82_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ToolStripMenuItem82_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.ToolStripMenuItem82_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem74_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ToolStripMenuItem74_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.ToolStripMenuItem74_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem73_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ToolStripMenuItem73_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.ToolStripMenuItem73_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem72_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ToolStripMenuItem72_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.ToolStripMenuItem72_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem71_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ToolStripMenuItem71_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.ToolStripMenuItem71_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem70_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ToolStripMenuItem70_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.ToolStripMenuItem70_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem69_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ToolStripMenuItem69_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.ToolStripMenuItem69_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem68_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ToolStripMenuItem68_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.ToolStripMenuItem68_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem66_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ToolStripMenuItem66_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.ToolStripMenuItem66_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem65_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ToolStripMenuItem65_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.ToolStripMenuItem65_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem63_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ToolStripMenuItem63_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.ToolStripMenuItem63_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem62_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ToolStripMenuItem62_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.ToolStripMenuItem62_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem60_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ToolStripMenuItem60_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.ToolStripMenuItem60_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem59_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ToolStripMenuItem59_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.ToolStripMenuItem59_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem56_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ToolStripMenuItem56_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.ToolStripMenuItem56_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem54_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ToolStripMenuItem54_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.ToolStripMenuItem54_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem53_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ToolStripMenuItem53_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.ToolStripMenuItem53_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem52_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ToolStripMenuItem52_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.ToolStripMenuItem52_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem51_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ToolStripMenuItem51_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.ToolStripMenuItem51_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem50_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ToolStripMenuItem50_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.ToolStripMenuItem50_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem49_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ToolStripMenuItem49_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.ToolStripMenuItem49_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem48_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ToolStripMenuItem48_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.ToolStripMenuItem48_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem46_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ToolStripMenuItem46_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.ToolStripMenuItem46_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for ToolStripMenuItem45_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ToolStripMenuItem45_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.ToolStripMenuItem45_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for ToolStripButton10_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ToolStripButton10_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.ToolStripButton10_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for ToolStripButton1_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ToolStripButton1_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.ToolStripButton1_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for TitleLabel_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub TitleLabel_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.TitleLabel_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for TimerKickout_Tick
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub TimerKickout_TickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.TimerKickout_Tick(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for timerCOUNTS_Tick
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub timerCOUNTS_TickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.timerCOUNTS_Tick(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for set_departments
'''</summary>
<TestMethod()>  _
Public Sub set_departmentsTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim DEPTCODE As String = String.Empty ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.set_departments(DEPTCODE, sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for SendEMailNoCFOLetterReceivedInTimeToolStripMenuItem_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub SendEMailNoCFOLetterReceivedInTimeToolStripMenuItem_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.SendEMailNoCFOLetterReceivedInTimeToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for SendEMailFORMCFOApprovalToolStripMenuItem_Click
'''</summary>
<TestMethod()>  _
Public Sub SendEMailFORMCFOApprovalToolStripMenuItem_ClickTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.SendEMailFORMCFOApprovalToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for SendCustomerNotificationMailsToolStripMenuItem_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub SendCustomerNotificationMailsToolStripMenuItem_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.SendCustomerNotificationMailsToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for send_CFO_noreply_email
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub send_CFO_noreply_emailTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
    target.send_CFO_noreply_email
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for SelectAllCheckbox_CheckedChanged
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub SelectAllCheckbox_CheckedChangedTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.SelectAllCheckbox_CheckedChanged(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for Rules_Flags_Valid_Insert_Requestno
'''</summary>
<TestMethod()>  _
Public Sub Rules_Flags_Valid_Insert_RequestnoTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim requestno As String = String.Empty ' TODO: Initialize to an appropriate value
Dim expected As Object = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Object
    actual = target.Rules_Flags_Valid_Insert_Requestno(requestno)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Rules_Flags_Valid_Delete_Requestno
'''</summary>
<TestMethod()>  _
Public Sub Rules_Flags_Valid_Delete_RequestnoTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim requestno As String = String.Empty ' TODO: Initialize to an appropriate value
Dim expected As Object = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Object
    actual = target.Rules_Flags_Valid_Delete_Requestno(requestno)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for resolve_user_department
'''</summary>
<TestMethod()>  _
Public Sub resolve_user_departmentTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim userid As String = String.Empty ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    actual = target.resolve_user_department(userid)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for resolve_user_against_VIP_USERS
'''</summary>
<TestMethod()>  _
Public Sub resolve_user_against_VIP_USERSTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim userid As String = String.Empty ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    actual = target.resolve_user_against_VIP_USERS(userid)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for resolve_dept_against_ESTAB
'''</summary>
<TestMethod()>  _
Public Sub resolve_dept_against_ESTABTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim userid As String = String.Empty ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    actual = target.resolve_dept_against_ESTAB(userid)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for resolve_dept_against_AD
'''</summary>
<TestMethod()>  _
Public Sub resolve_dept_against_ADTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim userid As String = String.Empty ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    actual = target.resolve_dept_against_AD(userid)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for resolve_app_level
'''</summary>
<TestMethod()>  _
Public Sub resolve_app_levelTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim code As Integer = 0 ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    actual = target.resolve_app_level(code)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Resetfields_not_persalnumber
'''</summary>
<TestMethod()>  _
Public Sub Resetfields_not_persalnumberTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.Resetfields_not_persalnumber(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for reset_all_listviews
'''</summary>
<TestMethod()>  _
Public Sub reset_all_listviewsTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
    target.reset_all_listviews
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for RequestACFOLetterToolStripMenuItem_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub RequestACFOLetterToolStripMenuItem_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.RequestACFOLetterToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for RemoveUserFromNewUserListToolStripMenuItem_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub RemoveUserFromNewUserListToolStripMenuItem_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.RemoveUserFromNewUserListToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for remedy_fill
'''</summary>
<TestMethod()>  _
Public Sub remedy_fillTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.remedy_fill(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for Refresh_Log
'''</summary>
<TestMethod()>  _
Public Sub Refresh_LogTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
    target.Refresh_Log
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for ReferToNTFinancialFunctionsToolStripMenuItem_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ReferToNTFinancialFunctionsToolStripMenuItem_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.ReferToNTFinancialFunctionsToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for rbServerEnvironment_MouseDown
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub rbServerEnvironment_MouseDownTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As MouseEventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.rbServerEnvironment_MouseDown(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for rbAccountLevel7_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub rbAccountLevel7_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.rbAccountLevel7_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for rbAccountLevel7_CheckedChanged
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub rbAccountLevel7_CheckedChangedTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.rbAccountLevel7_CheckedChanged(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for rbAccountLevel6_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub rbAccountLevel6_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.rbAccountLevel6_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for rbAccountLevel6_CheckedChanged
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub rbAccountLevel6_CheckedChangedTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.rbAccountLevel6_CheckedChanged(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for rbAccountLevel5_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub rbAccountLevel5_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.rbAccountLevel5_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for rbAccountLevel5_CheckedChanged
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub rbAccountLevel5_CheckedChangedTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.rbAccountLevel5_CheckedChanged(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for rbAccountLevel4_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub rbAccountLevel4_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.rbAccountLevel4_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for rbAccountLevel4_CheckedChanged
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub rbAccountLevel4_CheckedChangedTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.rbAccountLevel4_CheckedChanged(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for rbAccountLevel3_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub rbAccountLevel3_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.rbAccountLevel3_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for rbAccountLevel3_CheckedChanged
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub rbAccountLevel3_CheckedChangedTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.rbAccountLevel3_CheckedChanged(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for rbAccountLevel2_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub rbAccountLevel2_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.rbAccountLevel2_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for rbAccountLevel2_CheckedChanged
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub rbAccountLevel2_CheckedChangedTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.rbAccountLevel2_CheckedChanged(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for QAWebToolStripMenuItem_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub QAWebToolStripMenuItem_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.QAWebToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for PRDWebToolStripMenuItem_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub PRDWebToolStripMenuItem_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.PRDWebToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for OpenQAWebToolStripMenuItem1_Click_1
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub OpenQAWebToolStripMenuItem1_Click_1Test()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.OpenQAWebToolStripMenuItem1_Click_1(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for OpenQAWebToolStripMenuItem1_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub OpenQAWebToolStripMenuItem1_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.OpenQAWebToolStripMenuItem1_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for OpenPRDWebToolStripMenuItem1_Click_1
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub OpenPRDWebToolStripMenuItem1_Click_1Test()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.OpenPRDWebToolStripMenuItem1_Click_1(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for OpenPRDWebToolStripMenuItem1_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub OpenPRDWebToolStripMenuItem1_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.OpenPRDWebToolStripMenuItem1_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for NotifyUserRequestRemovedOffQueueToolStripMenuItem_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub NotifyUserRequestRemovedOffQueueToolStripMenuItem_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.NotifyUserRequestRemovedOffQueueToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for NotifyUserAccountUpdatedToolStripMenuItem_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub NotifyUserAccountUpdatedToolStripMenuItem_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.NotifyUserAccountUpdatedToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for NotifyUserAccountResetToolStripMenuItem_Click
'''</summary>
<TestMethod()>  _
Public Sub NotifyUserAccountResetToolStripMenuItem_ClickTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.NotifyUserAccountResetToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for NO_CFO_letter_received_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub NO_CFO_letter_received_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.NO_CFO_letter_received_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for MonthEndStats_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub MonthEndStats_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.MonthEndStats_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for lwDepartments_SelectedIndexChanged
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub lwDepartments_SelectedIndexChangedTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.lwDepartments_SelectedIndexChanged(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for lwDepartments_ItemCheck
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub lwDepartments_ItemCheckTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As ItemCheckEventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.lwDepartments_ItemCheck(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for lwAssignedDepartments_SelectedIndexChanged
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub lwAssignedDepartments_SelectedIndexChangedTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.lwAssignedDepartments_SelectedIndexChanged(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for lwApplicationRoles_ItemChecked
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub lwApplicationRoles_ItemCheckedTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As ItemCheckedEventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.lwApplicationRoles_ItemChecked(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for lwApplicationRoles_ColumnClick
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub lwApplicationRoles_ColumnClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As ColumnClickEventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.lwApplicationRoles_ColumnClick(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for lwA_ItemChecked
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub lwA_ItemCheckedTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As ItemCheckedEventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.lwA_ItemChecked(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for look_up_CFO_for_this_person
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub look_up_CFO_for_this_personTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    actual = target.look_up_CFO_for_this_person
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for load_lv_maindepartment
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub load_lv_maindepartmentTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim persalnumber As String = String.Empty ' TODO: Initialize to an appropriate value
    target.load_lv_maindepartment(persalnumber)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for load_lv_assigned_departments
'''</summary>
<TestMethod()>  _
Public Sub load_lv_assigned_departmentsTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
    target.load_lv_assigned_departments
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for load_lv_assigned_department_rights
'''</summary>
<TestMethod()>  _
Public Sub load_lv_assigned_department_rightsTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
    target.load_lv_assigned_department_rights
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for load_lv_application_rights
'''</summary>
<TestMethod()>  _
Public Sub load_lv_application_rightsTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
    target.load_lv_application_rights
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for Label17_DoubleClick
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub Label17_DoubleClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.Label17_DoubleClick(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for Label13_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub Label13_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.Label13_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for IsOnEstablishment
'''</summary>
<TestMethod()>  _
Public Sub IsOnEstablishmentTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim PersalNumber As String = String.Empty ' TODO: Initialize to an appropriate value
Dim expected As Boolean = false ' TODO: Initialize to an appropriate value
    Dim actual As Boolean
    actual = target.IsOnEstablishment(PersalNumber)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for InsertCFO_Record
'''</summary>
<TestMethod()>  _
Public Sub InsertCFO_RecordTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim Dept_Code As String = String.Empty ' TODO: Initialize to an appropriate value
Dim Fullname As String = String.Empty ' TODO: Initialize to an appropriate value
Dim CompanyName As String = String.Empty ' TODO: Initialize to an appropriate value
Dim Email1Address As String = String.Empty ' TODO: Initialize to an appropriate value
Dim NAT_PROV_ID As String = String.Empty ' TODO: Initialize to an appropriate value
Dim VoteID As String = String.Empty ' TODO: Initialize to an appropriate value
Dim FirstName As String = String.Empty ' TODO: Initialize to an appropriate value
Dim Gender As String = String.Empty ' TODO: Initialize to an appropriate value
Dim Initials As String = String.Empty ' TODO: Initialize to an appropriate value
Dim Lastname As String = String.Empty ' TODO: Initialize to an appropriate value
Dim BusinessAddress As String = String.Empty ' TODO: Initialize to an appropriate value
Dim BusinessFaxNumber As String = String.Empty ' TODO: Initialize to an appropriate value
    target.InsertCFO_Record(Dept_Code, Fullname, CompanyName, Email1Address, NAT_PROV_ID, VoteID, FirstName, Gender, Initials, Lastname, BusinessAddress, BusinessFaxNumber)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for Insert_Requestno_Into_Rules_Flags
'''</summary>
<TestMethod()>  _
Public Sub Insert_Requestno_Into_Rules_FlagsTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim requestno As String = String.Empty ' TODO: Initialize to an appropriate value
Dim expected As Object = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Object
    actual = target.Insert_Requestno_Into_Rules_Flags(requestno)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for InitializeComponent
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub InitializeComponentTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
    target.InitializeComponent
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for Hourglass
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub HourglassTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim Show As Boolean = false ' TODO: Initialize to an appropriate value
    target.Hourglass(Show)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for gridRequests_CellContentDoubleClick
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub gridRequests_CellContentDoubleClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As DataGridViewCellEventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.gridRequests_CellContentDoubleClick(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for GetUserName
'''</summary>
<TestMethod()>  _
Public Sub GetUserNameTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim strLoginName As String = String.Empty ' TODO: Initialize to an appropriate value
Dim strDomainName As String = String.Empty ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    actual = target.GetUserName(strLoginName, strDomainName)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for GetUserLastName
'''</summary>
<TestMethod()>  _
Public Sub GetUserLastNameTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim strFullName As String = String.Empty ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    actual = target.GetUserLastName(strFullName)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for GetUserFirstName
'''</summary>
<TestMethod()>  _
Public Sub GetUserFirstNameTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim strFullName As String = String.Empty ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    actual = target.GetUserFirstName(strFullName)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for GetLoginName
'''</summary>
<TestMethod()>  _
Public Sub GetLoginNameTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    actual = target.GetLoginName
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for GetDomainName
'''</summary>
<TestMethod()>  _
Public Sub GetDomainNameTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    actual = target.GetDomainName
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for GetComputerName
'''</summary>
<TestMethod()>  _
Public Sub GetComputerNameTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    actual = target.GetComputerName
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Get_Vulindlela_ProvController
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub Get_Vulindlela_ProvControllerTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim SCode As String = String.Empty ' TODO: Initialize to an appropriate value
Dim expected As Collection = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Collection
    actual = target.Get_Vulindlela_ProvController(SCode)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Get_User_Modified_Date
'''</summary>
<TestMethod()>  _
Public Sub Get_User_Modified_DateTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim username As String = String.Empty ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    actual = target.Get_User_Modified_Date(username)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Get_User_LogonCount
'''</summary>
<TestMethod()>  _
Public Sub Get_User_LogonCountTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim username As String = String.Empty ' TODO: Initialize to an appropriate value
Dim expected As Long = 0 ' TODO: Initialize to an appropriate value
    Dim actual As Long
    actual = target.Get_User_LogonCount(username)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Get_User_Creation_Date
'''</summary>
<TestMethod()>  _
Public Sub Get_User_Creation_DateTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim username As String = String.Empty ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    actual = target.Get_User_Creation_Date(username)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for Get_User_BadLogons
'''</summary>
<TestMethod()>  _
Public Sub Get_User_BadLogonsTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim username As String = String.Empty ' TODO: Initialize to an appropriate value
Dim expected As Long = 0 ' TODO: Initialize to an appropriate value
    Dim actual As Long
    actual = target.Get_User_BadLogons(username)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for get_ad_info
'''</summary>
<TestMethod()>  _
Public Sub get_ad_infoTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.get_ad_info(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for frmMain_Shown
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub frmMain_ShownTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.frmMain_Shown(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for frmMain_Load
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub frmMain_LoadTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.frmMain_Load(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for frmMain_KeyPress
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub frmMain_KeyPressTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As KeyPressEventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.frmMain_KeyPress(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for frmMain_FormClosing
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub frmMain_FormClosingTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As FormClosingEventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.frmMain_FormClosing(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for Finalize
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub FinalizeTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
    target.Finalize
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for FillToolStripButton_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub FillToolStripButton_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.FillToolStripButton_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for FillBy1ToolStripButton_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub FillBy1ToolStripButton_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.FillBy1ToolStripButton_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for ExportActiveDirectoryDatabaseToolStripMenuItem_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ExportActiveDirectoryDatabaseToolStripMenuItem_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.ExportActiveDirectoryDatabaseToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for ExitToolStripMenuItem_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ExitToolStripMenuItem_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.ExitToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for EstablishmentToolStripMenuItem_Click
'''</summary>
<TestMethod()>  _
Public Sub EstablishmentToolStripMenuItem_ClickTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.EstablishmentToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for EMailToVerifyAgainstEstablishmentToolStripMenuItem1_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub EMailToVerifyAgainstEstablishmentToolStripMenuItem1_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.EMailToVerifyAgainstEstablishmentToolStripMenuItem1_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for EMailAPPROVALFORMCFOApprovalRequestToolStripMenuItem_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub EMailAPPROVALFORMCFOApprovalRequestToolStripMenuItem_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.EMailAPPROVALFORMCFOApprovalRequestToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for EMailAPPROVALFORMBudgetOfficerToolStripMenuItem_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub EMailAPPROVALFORMBudgetOfficerToolStripMenuItem_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.EMailAPPROVALFORMBudgetOfficerToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for dtpAccountExpireDate_MouseUp
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub dtpAccountExpireDate_MouseUpTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As MouseEventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.dtpAccountExpireDate_MouseUp(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for dtpAccountExpireDate_CloseUp
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub dtpAccountExpireDate_CloseUpTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.dtpAccountExpireDate_CloseUp(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for Do_FrmLists
'''</summary>
<TestMethod()>  _
Public Sub Do_FrmListsTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
    target.Do_FrmLists
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for Do_FrmButtons
'''</summary>
<TestMethod()>  _
Public Sub Do_FrmButtonsTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim btnNew As Boolean = false ' TODO: Initialize to an appropriate value
Dim btnUpdate As Boolean = false ' TODO: Initialize to an appropriate value
Dim btnDelete As Boolean = false ' TODO: Initialize to an appropriate value
    target.Do_FrmButtons(btnNew, btnUpdate, btnDelete)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for Dispose
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub DisposeTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim disposing As Boolean = false ' TODO: Initialize to an appropriate value
    target.Dispose(disposing)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for Delete_CFO_Records
'''</summary>
<TestMethod()>  _
Public Sub Delete_CFO_RecordsTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
    target.Delete_CFO_Records
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for createOU
'''</summary>
<TestMethod()>  _
Public Sub createOUTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim _siteName As String = String.Empty ' TODO: Initialize to an appropriate value
Dim _domainPath As String = String.Empty ' TODO: Initialize to an appropriate value
    target.createOU(_siteName, _domainPath)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for CreateFreshADSnapshotToolStripMenuItem_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub CreateFreshADSnapshotToolStripMenuItem_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.CreateFreshADSnapshotToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for create_dept_ad
'''</summary>
<TestMethod()>  _
Public Sub create_dept_adTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim deptname As String = String.Empty ' TODO: Initialize to an appropriate value
    target.create_dept_ad(deptname)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for Create_CFO_List
'''</summary>
<TestMethod()>  _
Public Sub Create_CFO_ListTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As DataGridViewCellEventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.Create_CFO_List(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for create_ad_applevel_collection
'''</summary>
<TestMethod()>  _
Public Sub create_ad_applevel_collectionTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As Collection = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Collection
    actual = target.create_ad_applevel_collection
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for create_ad_appl_group_collection
'''</summary>
<TestMethod()>  _
Public Sub create_ad_appl_group_collectionTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As Collection = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Collection
    actual = target.create_ad_appl_group_collection
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for ClientsWithConfigProblemsToolStripMenuItem_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ClientsWithConfigProblemsToolStripMenuItem_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.ClientsWithConfigProblemsToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for Clear_Textboxes_Values
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub Clear_Textboxes_ValuesTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.Clear_Textboxes_Values(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for chkProfileCategories_SelectedValueChanged
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub chkProfileCategories_SelectedValueChangedTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.chkProfileCategories_SelectedValueChanged(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for chkProfileCategories_SelectedIndexChanged
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub chkProfileCategories_SelectedIndexChangedTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.chkProfileCategories_SelectedIndexChanged(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for chkProfileCategories_ItemChecked
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub chkProfileCategories_ItemCheckedTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.chkProfileCategories_ItemChecked(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for chkLocked_CheckedChanged
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub chkLocked_CheckedChangedTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.chkLocked_CheckedChanged(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for chkEnabled_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub chkEnabled_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.chkEnabled_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for chkEnabled_CheckedChanged
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub chkEnabled_CheckedChangedTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.chkEnabled_CheckedChanged(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for chkAccountStatus_ItemCheck
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub chkAccountStatus_ItemCheckTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As ItemCheckEventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.chkAccountStatus_ItemCheck(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for CheckEstablishment
'''</summary>
<TestMethod()>  _
Public Sub CheckEstablishmentTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    actual = target.CheckEstablishment(sender, e)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for CFOListToolStripMenuItem_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub CFOListToolStripMenuItem_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.CFOListToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for CFO_letter_received_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub CFO_letter_received_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.CFO_letter_received_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for cboNatProv_SelectedIndexChanged
'''</summary>
<TestMethod()>  _
Public Sub cboNatProv_SelectedIndexChangedTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.cboNatProv_SelectedIndexChanged(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for c_u_c
'''</summary>
<TestMethod()>  _
Public Sub c_u_cTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim cString As Object = Nothing ' TODO: Initialize to an appropriate value
Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
    Dim actual As String
    actual = target.c_u_c(cString)
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for BySurnameToolStripMenuItem2_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub BySurnameToolStripMenuItem2_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.BySurnameToolStripMenuItem2_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for BySurnameToolStripMenuItem1_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub BySurnameToolStripMenuItem1_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.BySurnameToolStripMenuItem1_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for BySurnameToolStripMenuItem_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub BySurnameToolStripMenuItem_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.BySurnameToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for ByRequestToolStripMenuItem2_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ByRequestToolStripMenuItem2_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.ByRequestToolStripMenuItem2_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for ByRequestToolStripMenuItem1_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ByRequestToolStripMenuItem1_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.ByRequestToolStripMenuItem1_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for ByRequestToolStripMenuItem_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ByRequestToolStripMenuItem_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.ByRequestToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for ByEstablishmentToolStripMenuItem_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub ByEstablishmentToolStripMenuItem_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.ByEstablishmentToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for Button2_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub Button2_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.Button2_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for build_chkProfileCategories_col
'''</summary>
<TestMethod()>  _
Public Sub build_chkProfileCategories_colTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim expected As Collection = Nothing ' TODO: Initialize to an appropriate value
    Dim actual As Collection
    actual = target.build_chkProfileCategories_col
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for btnVariationList0_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub btnVariationList0_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.btnVariationList0_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for btnVariationList_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub btnVariationList_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.btnVariationList_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for btnToFollowUp_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub btnToFollowUp_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.btnToFollowUp_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for btnResetPwd_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub btnResetPwd_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.btnResetPwd_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for btnResetPassword_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub btnResetPassword_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.btnResetPassword_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for btnReferrals_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub btnReferrals_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.btnReferrals_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for btnOpenRequests_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub btnOpenRequests_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.btnOpenRequests_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for btnNewUsers_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub btnNewUsers_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.btnNewUsers_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for btnKodeer_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub btnKodeer_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.btnKodeer_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for btnExpirePassword_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub btnExpirePassword_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.btnExpirePassword_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for btnExpireAccXdays_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub btnExpireAccXdays_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.btnExpireAccXdays_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for btnDeptDiffers_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub btnDeptDiffers_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.btnDeptDiffers_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for btnActiveDirectory_Click
'''</summary>
<TestMethod()>  _
Public Sub btnActiveDirectory_ClickTest()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.btnActiveDirectory_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for AmmendVulindlelaExclusionListToolStripMenuItem_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub AmmendVulindlelaExclusionListToolStripMenuItem_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.AmmendVulindlelaExclusionListToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for AmendTheVulindlelaExceptionListToolStripMenuItem_Click
'''</summary>
<TestMethod(),  _
 DeploymentItem("ADAdminDotNet.exe")>  _
Public Sub AmendTheVulindlelaExceptionListToolStripMenuItem_ClickTest()
Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
    target.AmendTheVulindlelaExceptionListToolStripMenuItem_Click(sender, e)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for _9
'''</summary>
<TestMethod()>  _
Public Sub _9Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim strArgs As String = String.Empty ' TODO: Initialize to an appropriate value
    target._9(strArgs)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for _8
'''</summary>
<TestMethod()>  _
Public Sub _8Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim strArgs As String = String.Empty ' TODO: Initialize to an appropriate value
    target._8(strArgs)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for _7
'''</summary>
<TestMethod()>  _
Public Sub _7Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim strArgs As String = String.Empty ' TODO: Initialize to an appropriate value
    target._7(strArgs)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for _26
'''</summary>
<TestMethod()>  _
Public Sub _26Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim strArgs As String = String.Empty ' TODO: Initialize to an appropriate value
    target._26(strArgs)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for _20
'''</summary>
<TestMethod()>  _
Public Sub _20Test()
Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
Dim strArgs As String = String.Empty ' TODO: Initialize to an appropriate value
    target._20(strArgs)
    Assert.Inconclusive("A method that does not return a value cannot be verified.")
End Sub

'''<summary>
'''A test for frmMain Constructor
'''</summary>
<TestMethod()>  _
Public Sub frmMainConstructorTest()
    Dim target As frmMain = New frmMain
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub
End Class
