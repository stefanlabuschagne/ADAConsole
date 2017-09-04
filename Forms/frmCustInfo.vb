Imports System
Imports System.IO
Imports System.Net
Imports System.Windows.Forms
Imports ADAdminDotNet.LOG_IN_Request_Tracking_BasicWS

Public Class frmCustInfo

    'Dim t As Integer = StatusType.Closed + _
    '                   StatusType.Closed + _
    '                   StatusType.CustomerApproval + _
    '                   StatusType.CustomerNotification + _
    '                   StatusType.InfoRequired + _
    '                   StatusType.Logged + _
    '                   StatusType.ReferToClient + _
    '                   StatusType.WorkInProgress
    'Dim aa As Remote_Access_UsageType = Remote_Access_UsageType.No + Remote_Access_UsageType.Yes
    'Dim AuthenticationInfo_Query As New LOG_IN_Request_Tracking_BasicWS.AuthenticationInfo

#Region "Create Request"

    Sub koos()




        Dim AuthenticationInfo As New LOG_IN_Request_Tracking_BasicWS.AuthenticationInfo
        AuthenticationInfo.password = "T0005221"
        AuthenticationInfo.userName = "logik007"

        Dim req As New LOG_IN_Request_Tracking_BasicWS.CreateRequest(AuthenticationInfo, _
                                                                      "Johan Vermeulen", _
                                                                      "Anton Martin", _
                                                                      StatusType.InfoRequired, _
                                                                      "T0005221", _
                                                                      "Technical", _
                                                                      "MR", _
                                                                      "JOHAN", _
                                                                      "VERMEULEN", _
                                                                      "012-6574316", _
                                                                      "Vulndlela Project", _
                                                                      "Financials", _
                                                                      "Problem", _
                                                                      "High", _
                                                                      "Updated By", _
                                                                      "Whatever long description", _
                                                                      "Vulidnlela", _
                                                                      "NO DOSOLUTION YET", _
                                                                      "Johan Vermeulen", _
                                                                      Today.Date, _
                                                                      Today.Date, _
                                                                      "FAQ_Number", _
                                                                      Remote_Access_AvailabilityType.Active, _
                                                                      "Group", _
                                                                      "Request Log", _
                                                                      "REquest_History", _
                                                                      "CAtegory", _
                                                                      "Category2", _
                                                                      Today.Date, _
                                                                      "zDispClose", _
                                                                      DateAdd(DateInterval.Day, -20, Today.Date), _
                                                                      "SCC_Number", _
                                                                      Remote_Access_UsageType.No, _
                                                                      Remote_Access_UsageType.No, _
                                                                      "Category3", _
                                                                      "V000000133", _
                                                                      "", _
                                                                      DateAdd(DateInterval.Day, -3, Today.Date), _
                                                                      "VULINDLELA", _
                                                                      "Technical", _
                                                                      "Request Cataegory", _
                                                                      String.Empty, _
                                                                      0, _
                                                                      "March", _
                                                                      0, _
                                                                      Remote_Access_UsageType.No, _
                                                                      Remote_Access_UsageType.No, _
                                                                      StatusType.CustomerNotification, _
                                                                      Remote_Access_UsageType.No, _
                                                                      Remote_Access_UsageType.No, _
                                                                      Remote_Access_UsageType.No, _
                                                                      "zDisplCharDueDate", _
                                                                      0, _
                                                                      "001303023", _
                                                                      "Billing_Code", _
                                                                      Remote_Access_UsageType.No, _
                                                                      Remote_Access_UsageType.No, _
                                                                      "Keyword", _
                                                                      "zDisFAQTabel", _
                                                                      DateAdd(DateInterval.Day, 2, Today.Date), _
                                                                      "zDispCheckLogCB", _
                                                                      "zDispEmail@treasury.gov.za", _
                                                                      zDispInt_Type.No, _
                                                                      "Request_Source", _
                                                                      "zTrReqExists", _
                                                                      "DispWebID", _
                                                                      "DisWebEmail@treasury.gov.za", _
                                                                      "WIP_Change_Status", _
                                                                      String.Empty, _
                                                                      Nothing, _
                                                                      0, _
                                                                      String.Empty, _
                                                                      Nothing, _
                                                                      0, _
                                                                      String.Empty, _
                                                                      Nothing, _
                                                                      0, _
                                                                      String.Empty, _
                                                                      Nothing, _
                                                                      "", _
                                                                      "", _
                                                                      Nothing, _
                                                                      0, _
                                                                      "Email_comment", _
                                                                      zDispInt_Type.No, _
                                                                      "zDispGroup", _
                                                                      "Keyword1", _
                                                                      "Keyword2", _
                                                                      "zDisplenkey", _
                                                                      "Tel3", _
                                                                      "email3@treasury.gov.za", _
                                                                      "Role3", _
                                                                      "Rank3", _
                                                                      "Cell3", _
                                                                      "Ext3", _
                                                                      "Fax3", _
                                                                      "Lastname3", _
                                                                      "Name", _
                                                                      "Init", _
                                                                      "Department_Type", _
                                                                      "Deptartmentname3", _
                                                                      "Root_Cause2", _
                                                                      "johan.vermeulen@treasury.gov.za", _
                                                                      Nothing, _
                                                                      Nothing, _
                                                                      0, _
                                                                      "johan.vermeulen@treasury.gov.za", _
                                                                      "johan.vermeulen@treasury.gov.za", _
                                                                      "johan.vermeulen@treasury.gov.za")
    End Sub

#End Region

#Region "GetRequest"

    Public Sub GetRequest(ByVal requestno As String)

        Dim AuthenticationInfo As New LOG_IN_Request_Tracking_BasicWS.AuthenticationInfo

        AuthenticationInfo.password = "T0005221"
        AuthenticationInfo.userName = "logik007"

        Dim req As New LOG_IN_Request_Tracking_BasicWS.GetRequest(AuthenticationInfo, "001303023")

    End Sub

#End Region

#Region "SetRequest"

    Public Sub koos2()

        Dim AuthenticationInfo As New LOG_IN_Request_Tracking_BasicWS.AuthenticationInfo
        AuthenticationInfo.password = "T0005221"
        AuthenticationInfo.userName = "logik007"

        Dim req2 As New LOG_IN_Request_Tracking_BasicWS.SetRequest(AuthenticationInfo, _
                                                                      "Johan Vermeulen", _
                                                                      "Anton Martin", _
                                                                      StatusType.InfoRequired, _
                                                                      "T0005221", _
                                                                      "Technical", _
                                                                      "MR", _
                                                                      "JOHAN", _
                                                                      "VERMEULEN", _
                                                                      "012-6574316", _
                                                                      "Vulndlela Project", _
                                                                      "Financials", _
                                                                      "Problem", _
                                                                      "High", _
                                                                      "Updated By", _
                                                                      "Whatever long description", _
                                                                      "Vulidnlela", _
                                                                      "NO DOSOLUTION YET", _
                                                                      "Johan Vermeulen", _
                                                                      Today.Date, _
                                                                      Today.Date, _
                                                                      "FAQ_Number", _
                                                                      Remote_Access_AvailabilityType.Active, _
                                                                      "Group", _
                                                                      "Request Log", _
                                                                      "REquest_History", _
                                                                      "CAtegory", _
                                                                      "Category2", _
                                                                      Today.Date, _
                                                                      "zDispClose", _
                                                                      DateAdd(DateInterval.Day, -20, Today.Date), _
                                                                      "SCC_Number", _
                                                                      Remote_Access_UsageType.No, _
                                                                      Remote_Access_UsageType.No, _
                                                                      "Category3", _
                                                                      "V000000133", _
                                                                      "", _
                                                                      DateAdd(DateInterval.Day, -3, Today.Date), _
                                                                      "VULINDLELA", _
                                                                      "Technical", _
                                                                      "Request Cataegory", _
                                                                      String.Empty, _
                                                                      0, _
                                                                      "March", _
                                                                      0, _
                                                                      Remote_Access_UsageType.No, _
                                                                      Remote_Access_UsageType.No, _
                                                                      StatusType.CustomerNotification, _
                                                                      Remote_Access_UsageType.No, _
                                                                      Remote_Access_UsageType.No, _
                                                                      Remote_Access_UsageType.No, _
                                                                      "zDisplCharDueDate", _
                                                                      0, _
                                                                      "001303023", _
                                                                      "Billing_Code", _
                                                                      Remote_Access_UsageType.No, _
                                                                      Remote_Access_UsageType.No, _
                                                                      "Keyword", _
                                                                      "zDisFAQTabel", _
                                                                      DateAdd(DateInterval.Day, 2, Today.Date), _
                                                                      "zDispCheckLogCB", _
                                                                      "zDispEmail@treasury.gov.za", _
                                                                      zDispInt_Type.No, _
                                                                      "Request_Source", _
                                                                      "zTrReqExists", _
                                                                      "DispWebID", _
                                                                      "DisWebEmail@treasury.gov.za", _
                                                                      "WIP_Change_Status", _
                                                                      String.Empty, _
                                                                      Nothing, _
                                                                      0, _
                                                                      String.Empty, _
                                                                      Nothing, _
                                                                      0, _
                                                                      String.Empty, _
                                                                      Nothing, _
                                                                      0, _
                                                                      String.Empty, _
                                                                      Nothing, _
                                                                      "", _
                                                                      "", _
                                                                      Nothing, _
                                                                      0, _
                                                                      "Email_comment", _
                                                                      zDispInt_Type.No, _
                                                                      "zDispGroup", _
                                                                      "Keyword1", _
                                                                      "Keyword2", _
                                                                      "zDisplenkey", _
                                                                      "Tel3", _
                                                                      "email3@treasury.gov.za", _
                                                                      "Role3", _
                                                                      "Rank3", _
                                                                      "Cell3", _
                                                                      "Ext3", _
                                                                      "Fax3", _
                                                                      "Lastname3", _
                                                                      "Name", _
                                                                      "Init", _
                                                                      "Department_Type", _
                                                                      "Deptartmentname3", _
                                                                      "Root_Cause2", _
                                                                      "johan.vermeulen@treasury.gov.za", _
                                                                      Nothing, _
                                                                      Nothing, _
                                                                      0, _
                                                                      "johan.vermeulen@treasury.gov.za", _
                                                                      "johan.vermeulen@treasury.gov.za", _
                                                                      "johan.vermeulen@treasury.gov.za")
    End Sub

#End Region

    Private Sub btnGetrequest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetrequest.Click

    End Sub
End Class
