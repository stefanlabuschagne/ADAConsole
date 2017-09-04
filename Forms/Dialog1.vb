Imports ADAdminDotNet
'Imports ADAdminDotNet.LOG_IN_Request_Tracking_BasicWS


Public Class Dialog1

    Dim cb As System.AsyncCallback
    Dim state As New Object
    '  Dim bmc As New BMC8.LOG_DM_Customer_Information_BasicWS__cService


    'Dim b() As Byte



    '#Region "LOG_IN_Request_Tracking_BasicWS.GetResponse"

    '    Dim r As New LOG_IN_Request_Tracking_BasicWS.GetResponse("001303023", "Submitter", Today.Date, "Koos", _
    '                          "18807381", Today.Date, StatusType.Assigned, "18807381", "wHATEVER", "Telephone", _
    '                          "Department_Name", "Role", _
    '                          "Request_Type", _
    '                          "Priority", _
    '                          "Updated_By", _
    '                          "Long_Description", _
    '                          "Project", _
    '                          "Solution", _
    '                          "Johan Vermeulen", _
    '                         DateAdd(DateInterval.Day, 10, Today.Date), _
    '                          Today.Date, _
    '                          "FAQ_Number", _
    '                          Remote_Access_AvailabilityType.Inactive, _
    '                          "Group", _
    '                          "Requst_Log", _
    '                          "Request_History", _
    '                          "Category_1", _
    '                          "Category_2", _
    '                          Today.Date, _
    '                          "zDispClose", _
    '                          Today.Date, _
    '                          "SCC_Number", _
    '                          Today.Date, _
    '                          Remote_Access_UsageType.No, _
    '                          "Category_3", _
    '                          "Store_Number", _
    '                          "zDispCheckLog", _
    '                           Remote_Access_UsageType.No, _
    '                          "System_Group", _
    '                          "Functional_Area", _
    '                          "Request_Category", _
    '                          "Root_Cause", _
    '                          0, _
    '                          "Month_End", _
    '                          1, _
    '                          Remote_Access_UsageType.No, _
    '                          Remote_Access_UsageType.No, _
    '                          StatusType.Logged, _
    '                          Remote_Access_UsageType.No, _
    '                          Remote_Access_UsageType.No, _
    '                          Remote_Access_UsageType.No, _
    '                          "zDispCharDueDate", _
    '                          1, _
    '                          "001402401", _
    '                          "Billing_Code", _
    '                          Remote_Access_UsageType.No, _
    '                          Remote_Access_UsageType.No, _
    '                          "Keyword", _
    '                          "zDispFAQTable", _
    '                          Remote_Access_UsageType.No, _
    '                          "zDispCheckLoCB", _
    '                          "johan.vermeulen@treasury.gov.za", _
    '                          zDispInt_Type.No, _
    '                          "Request_Source", _
    '                          "zTrReqExists", _
    '                          "zDispWebId", _
    '                          "johan.vermeulen@treasury.gov.za", _
    '                          "WIP_Change_Status", _
    '                          "Attachment_Field_attachmentName", _
    '                           "", _
    '                           0, _
    '                           "", _
    '                          "", b, _
    '                            "", _
    '                           "", _
    '                            b, _
    '                            "", _
    '                           "", _
    '                            b, _
    '                            "", _
    '                           "", _
    '                             b, _
    '                            "EMail_Comment", _
    '                            zDispInt_Type.No, _
    '                              b, _
    '                             "Keyword1", _
    '                             "Keyword2", _
    '                             "zDispLenKey", _
    '                             "Telephone3", _
    '                             "johan.vermeulen@treasury.gov.za", _
    '                             "Role3", _
    '                             "Rank3", _
    '                             "Cellphone3", _
    '                             "Extension3", _
    '                             "Fax_Number3", _
    '                             "Last_Name3", _
    '                             "Name", _
    '                             "Initials", _
    '                             "Department_Type3", _
    '                            "Department_Name3", _
    '                             "Root_Cause2", _
    '                             "johan.vermeulen@treasury.gov.za", _
    '                             "Attachment_Field6_attachmentName", _
    '                             "", _
    '                             0, _
    '                              "", _
    '                             0, _
    '                             b, _
    '                             0, _
    '                             "", _
    '                             0, _
    '                             "")


    '    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        '  Me.RemedyOpenRequestsTableAdapter.Fill(Me.ARSystemDataSet.RemedyOpenRequests)    
    '        '  Dim r As New RemedyBMC.HPD

    '        'Dim r As New ADAdminDotNet.LOG_IN_Request_Tracking.New_Set_Operation_0Request
    '        'r.Assigned_to()

    '        '        Dim ch As ADAdminDotNet.LOG_IN_Request_Tracking.New_Port_0PortTypeChannel
    '        ' ch.BeginNew_Set_Operation_0(req, System.AsyncCallback, ActiveForm)
    '        '
    '        'Dim a As New ADAdminDotNet.LOG_IN_Request_Tracking.AuthenticationInfo
    '        'a.password = "logik007"
    '        'a.userName = "T0005221"

    '        'Dim tip As ADAdminDotNet.LOG_IN_Request_Tracking.New_Port_0PortType
    '        'Dim cl As New ADAdminDotNet.LOG_IN_Request_Tracking.New_Set_Operation_0Request.New_Port_0PortTypeClient
    '        'aor.Request_No = "001370925"

    '        'Dim ar As New ADAdminDotNet.LOG_IN_Request_Tracking.New_Set_Operation_0Request

    '        'With ar

    '        '    .ReOpened = LOG_IN_Request_Tracking.Remote_Access_UsageType.Yes
    '        '    .Store_Number = "VULINLELA"
    '        '    .Functional_Area = "Technical"
    '        '    .Assigned_to = "Johan Vermeulen"
    '        '    .Assignee_Group = "Technical3"
    '        '    .Updated_By = "Johan Vermeulen3"
    '        '    .Due_Date = Today.Date
    '        '    .EMail = "johan.vermeulen@treasury.gov.za"
    '        '    .Title = "Mr"
    '        '    .First_Name = "Johan"
    '        '    .Submitter_EMail = "johan.vermeulen@treasury.gov.za"
    '        '    .Persal_Number = "T0005221"
    '        '    .Initials = "JJ"
    '        '    .Request_No = "001370925"
    '        '    .Solution = "No solution yet"
    '        'End With
    '        'ar.Solution = "I WILL LET ALL KNOW - TEST TEST "

    '        'Dim res As ADAdminDotNet.LOG_IN_Request_Tracking.New_Set_Operation_0Response







    '        'k.AllowInitializationUI = True
    '        'Dim ch As New KeyedByTypeCollection(Of.

    '        'a.
    '        'Dim r As New ADAdminDotNet.LOG_IN_Request_Tracking.New_Port_0PortTypeClient
    '        'Dim r1 As ADAdminDotNet.LOG_IN_Request_Tracking.New_Set_Operation_0Request

    '        'Dim r2 As ADAdminDotNet.LOG_IN_Request_Tracking.New_Set_Operation_0Response

    '        'Dim b() As Byte = Nothing


    '        'r.Open()
    '        'RemedyBMC.ARSInitialise.Login.Login("prodlgremv1", "T0005221", "logik007", "", 8080)
    '        'Dim frm As String = "LOG_DM_Customer_Information"
    '        'Dim m As String = ""
    '        'Dim lst As New ArrayList

    '        'Dim l As New RemedyBMC.ARSInitialise
    '        'l.Login.CreateForm(1)
    '        'Me.DialogResult = System.Windows.Forms.DialogResult.OK
    '        'Me.Close()
    '    End Sub

    '    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    '        Me.Close()
    '    End Sub

    '    Private Sub Dialog1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    End Sub

    '#End Region

#Region "Customer INfo"

    'Dim r As New LOG_IN_Request_Tracking_BasicWS.GetResponse("001303023", "Submitter", "Johan Vermeulen", StatusType.Incomplete, _
    '                          "18807381", "Technical", "Title", "First_Name", "Last_Name", "Telephone", _
    '                          "Department_Name", "Role", _
    '                          "Request_Type", _
    '                          "Priority", _
    '                          "Updated_By", _
    '                          "Long_Description", _
    '                          "Project", _
    '                          "Solution", _
    '                          "Johan Vermeulen", _
    '                         DateAdd(DateInterval.Day, 10, Today.Date), _
    '                          Today.Date, _
    '                          "FAQ_Number", _
    '                          Remote_Access_AvailabilityType.Inactive, _
    '                          "Group", _
    '                          "Requst_Log", _
    '                          "Request_History", _
    '                          "Category_1", _
    '                          "Category_2", _
    '                          Today.Date, _
    '                          "zDispClose", _
    '                          Today.Date, _
    '                          "SCC_Number", _
    '                          Remote_Access_AvailabilityType.Inactive, _
    '                          Remote_Access_UsageType.No, _
    '                          "Category_3", _
    '                          "Store_Number", _
    '                          "zDispCheckLog", _
    '                          Today.Date, _
    '                          "System_Group", _
    '                          "Functional_Area", _
    '                          "Request_Category", _
    '                          "Root_Cause", _
    '                          0, _
    '                          "Month_End", _
    '                          1, _
    '                          Remote_Access_UsageType.No, _
    '                          Remote_Access_UsageType.No, _
    '                          StatusType.Logged, _
    '                          Remote_Access_UsageType.No, _
    '                          Remote_Access_UsageType.No, _
    '                          Remote_Access_UsageType.No, _
    '                          "zDispCharDueDate", _
    '                          1, _
    '                          "001402401", _
    '                          "Billing_Code", _
    '                          Remote_Access_UsageType.No, _
    '                          Remote_Access_UsageType.No, _
    '                          "Keyword", _
    '                          "zDispFAQTable", _
    '                          Today.Date, _
    '                          "zDispCheckLoCB", _
    '                          "johan.vermeulen@treasury.gov.za", _
    '                          zDispInt_Type.No, _
    '                          "Request_Source", _
    '                          "zTrReqExists", _
    '                          "zDispWebId", _
    '                          "johan.vermeulen@treasury.gov.za", _
    '                          "WIP_Change_Status", _
    '                          "Attachment_Field_attachmentName", _
    '                           b, _
    '                           0, _
    '                           "", _
    '                           b, 0, _
    '                            "", _
    '                           b, _
    '                            0, _
    '                            "", _
    '                            b, _
    '                            0, _
    '                            "", _
    '                            b, _
    '                            0, _
    '                            "EMail_Comment", _
    '                            zDispInt_Type.No, _
    '                            "zDispGroup", _
    '                             "Keyword1", _
    '                             "Keyword2", _
    '                             "zDispLenKey", _
    '                             "Telephone3", _
    '                             "johan.vermeulen@treasury.gov.za", _
    '                             "Role3", _
    '                             "Rank3", _
    '                             "Cellphone3", _
    '                             "Extension3", _
    '                             "Fax_Number3", _
    '                             "Last_Name3", _
    '                             "Name", _
    '                             "Initials", _
    '                             "Department_Type3", _
    '                            "Department_Name3", _
    '                             "Root_Cause2", _
    '                             "johan.vermeulen@treasury.gov.za", _
    '                             "Attachment_Field6_attachmentName", _
    '                             b(), _
    '                             0, _
    '                             "johan.vermeulen@treasury.gov.za", _
    '                             "johan.vermeulen@treasury.gov.za", _
    '                             "johan.vermeulen@treasury.gov.za", _
    '                             "001303023")
#End Region

    Private Sub Dialog1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Dim a As ADAdminDotNet.LOG_DM_Customer_Information_BasicWS__c.Record_StatusType
        'Dim b As ADAdminDotNet.LOG_DM_Customer_Information_BasicWS__c.Remote_Access_AvailabilityType
        'Dim c As ADAdminDotNet.LOG_DM_Customer_Information_BasicWS__c.zDispInternal_Type
        'MsgBox(a.Complete.GetType.ToString)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim argUserName As String = "T0005221"
        Dim argPassword As String = "logik007"
        Dim argRequestno As String = "001180191"
        Dim p As New ProcessStartInfo
        p.FileName = "C:\a_Source\ADAdminDotNET\ADAdmin.NET3.5\_ WinAutomation\" & "LOG_IN_Request_Tracking_Search.exe"
        p.Arguments = Chr(34) & argUserName & Chr(34) & " " & Chr(34) & argPassword & Chr(34) & """ """ & Chr(34) & argRequestno & Chr(34)
        p.WindowStyle = ProcessWindowStyle.Normal
        Process.Start(p)
    End Sub

End Class

