Imports System
Imports System.IO
Imports System.Net
Imports ADAdminDotNet

Module ARWebservices

    Dim ARUser As String = "T0005221"
    Dim ARPassword As String = "logik007"
    Dim strFirstName As String = String.Empty
    Dim strLastName As String = String.Empty
    Dim strSQL As String = String.Empty

    'Sub Main()

    '    Dim ErrMsg As String = String.Empty
    '    Dim strFirstName As String = String.Empty
    '    Dim strLastName As String = String.Empty
    '    Dim ARUser As String = String.Empty
    '    Dim ARPassword As String = String.Empty
    '    Dim strSQL As String = String.Empty
    '    'Dim AuthenticationInfo As New LOG_IN_Request_Tracking_BasicWS.AuthenticationInfo
    '    'Dim strSubmitIncidentID As String = String.Empty
    '    'Dim AuthenticationInfo_Query As New LOG_IN_Request_Tracking_BasicWS.AuthenticationInfo
    '    'Dim HelpDesk_Submit_Service As New LOG_IN_Request_Tracking_BasicWS.CreateRequest()

    '    ' // Holds the returned values of the Query to the Help Desk form. 
    '    ' Dim Query_OutputMap() As LOG_IN_Request_Tracking_BasicWS.OutputMapping5GetListValues

    '    Try
    '        ' // Define Authentication Parameters for Submit and Query/Modify WS
    '        'LOG_IN_Request_Tracking_BasicWS.AuthenticationInfo = AuthenticationInfo
    '        AuthenticationInfo.userName = ARUser
    '        AuthenticationInfo.password = ARPassword
    '        AuthenticationInfo_Query.userName = ARUser
    '        AuthenticationInfo_Query.password = ARPassword

    '        ' // Pass Authentication Info into Header in WS Submit Call

    '        ' LOG_IN_Request_Tracking_BasicWS.AuthenticationInfoValue = AuthenticationInfo

    '        ' // Pass Authentication Info into Header in WS Query/Modify Call
    '        'LOG_IN_Request_Tracking_BasicWS.AuthenticationInfoValue = AuthenticationInfo_Query

    '        ' // Webservices Submit Call for ARS 7.0.3
    '        'strSubmitIncidentID = HelpDesk_Submit_Service.(Assigned_Group:="", Assigned_Group_Shift_Name:="", Assigned_Support_Company:="", _
    '        '                                                                Assigned_Support_Organization:="", Assignee:="", Categorization_Tier_1:="", Categorization_Tier_2:="", _
    '        '                                                                Categorization_Tier_3:="", CI_Name:="", Closure_Manufacturer:="", Closure_Product_Category_Tier1:="", _
    '        '                                                                Closure_Product_Category_Tier2:="", Closure_Product_Category_Tier3:="", Closure_Product_Model_Version:="", _
    '        '                                                                Closure_Product_Name:="", Department:="", First_Name:=strFirstName, Impact:=LOG_IN_Request_Tracking_BasicWS.ImpactType.Item4MinorLocalized, _
    '        '                                                                Last_Name:=strLastName, Lookup_Keyword:="", Manufacturer:="", Product_Categorization_Tier_1:="", Product_Categorization_Tier_2:="", _
    '        '                                                                Product_Categorization_Tier_3:="", Product_Model_Version:="", Product_Name:="", Reported_Source:=LOG_IN_Request_Tracking_BasicWS.Reported_SourceType.Other, _
    '        '                                                                Resolution:="", Resolution_Category_Tier_1:="", Resolution_Category_Tier_2:="", Resolution_Category_Tier_3:="", _
    '        '                                                                Service_Type:=LOG_IN_Request_Tracking_BasicWS.Service_TypeType.InfrastructureEvent, Status:=LOG_IN_Request_Tracking_BasicWS.StatusType.New, Action:="CREATE", _
    '        '                                                                Create_Request:=LOG_IN_Request_Tracking_BasicWS.Create_RequestType.No, Summary:="Test  Ticket - Web Services", Notes:="", _
    '        '                                                                Urgency:=LOG_IN_Request_Tracking_BasicWS.UrgencyType.Item4Low, Work_Info_Summary:="Created From Web Interface", Work_Info_Notes:="", _
    '        '                                                                Work_Info_Type:=LOG_IN_Request_Tracking_BasicWS.Work_Info_TypeType.General, Work_Info_Date:=Nothing, _
    '        '                                                                Work_Info_Source:=LOG_IN_Request_Tracking_BasicWS.Work_Info_SourceType.Other, _
    '        '                                                                Work_Info_Locked:=LOG_IN_Request_Tracking_BasicWS.Create_RequestType.No, _
    '        '                                                                Work_Info_View_Access:=LOG_IN_Request_Tracking_BasicWS.Work_Info_View_AccessType.Internal, Middle_Initial:="")

    '        ' // Webservices Submit Call for 7.0.1 ARS 7.1 no Patch - No Work Info (as appears to have issues on this version) or Middle Initial 
    '        'strSubmitIncidentID = HelpDesk_Submit_Service.HelpDesk_Submit_Service(Assigned_Group:="", Assigned_Group_Shift_Name:="", Assigned_Support_Company:="", _
    '        '                                                                Assigned_Support_Organization:="", Assignee:="", Categorization_Tier_1:="", Categorization_Tier_2:="", _
    '        '                                                                Categorization_Tier_3:="", CI_Name:="", Closure_Manufacturer:="", Closure_Product_Category_Tier1:="", _
    '        '                                                                Closure_Product_Category_Tier2:="", Closure_Product_Category_Tier3:="", Closure_Product_Model_Version:="", _
    '        '                                                                Closure_Product_Name:="", Department:="", First_Name:=strFirstName, Impact:=HPD_IncidentInterface_Create.ImpactType.Item4MinorLocalized, _
    '        '                                                                Last_Name:=strLastName, Lookup_Keyword:="", Manufacturer:="", Product_Categorization_Tier_1:="", Product_Categorization_Tier_2:="", _
    '        '                                                                Product_Categorization_Tier_3:="", Product_Model_Version:="", Product_Name:="", Reported_Source:=HPD_IncidentInterface_Create.Reported_SourceType.Other, _
    '        '                                                                Resolution:="", Resolution_Category_Tier_1:="", Resolution_Category_Tier_2:="", Resolution_Category_Tier_3:="", _
    '        '                                                                Service_Type:=HPD_IncidentInterface_Create.Service_TypeType.InfrastructureEvent, Status:=HPD_IncidentInterface_Create.StatusType.Closed, Action:="CREATE", _
    '        '                                                                Create_Request:=HPD_IncidentInterface_Create.Create_RequestType.No, Summary:="Sentinel Test Ticket Web Services", Notes:="", _
    '        '                                                                Urgency:=HPD_IncidentInterface_Create.UrgencyType.Item4Low, Work_Info_Summary:="", _
    '        '                                                                Work_Info_Notes:="", Work_Info_Type:=HPD_IncidentInterface_Create.Work_Info_TypeType.General, Work_Info_Date:=Nothing, _
    '        '                                                                Work_Info_Source:=HPD_IncidentInterface_Create.Work_Info_SourceType.Other, _
    '        '                                                                Work_Info_Locked:=HPD_IncidentInterface_Create.Create_RequestType.No, _
    '        '                                                                Work_Info_View_Access:=HPD_IncidentInterface_Create.Work_Info_View_AccessType.Internal)

    '        Console.WriteLine(strSubmitIncidentID)


    '        ' // NOTE: Query required for HPD:IncidentInterface differs from above as we are specifying a particular field by name
    '        ' // Example SQL Query ** Note: Inverted Commas Needed or SQL Will Fail**
    '        ' // strSQL = "'Incident Number' = ""INC000000000093"""
    '        ' // e.g. 'Incident Number' LIKE "INC___________7" - This only works with last number, does not like the full ID.

    '        'strIncidentID = strSubmitIncidentID
    '        'strSQL = "'Incident Number' LIKE """ + strIncidentID + """"
    '        strSQL = "'First Name' = " + """Bob"""
    '        'strSQL = "'7' = " + """Closed"""


    '        ' // Initate the WS Query using above qualification to generate a time.
    '        'Query_OutputMap = HelpDesk_Modify_Query_Service.HelpDesk_QueryList_Service(strSQL, 10, 100)

    '        ' // Cannot retrieve the values as it executing but returing an empty (nothing) variable so For/Next generates and error.
    '        'For Each getListValues In Query_OutputMap
    '        ' Console.WriteLine(getListValues.Incident_Number)
    '        'Next


    '        ' // Pause for 10 seconds to allow Auto Assignment to occur
    '        Console.WriteLine("Pausing for 10 seconds to allow Auto Assignment to occur")
    '        System.Threading.Thread.Sleep(10000)


    '        ' // Close out the Request
    '        'HelpDesk_Modify_Query_Service.HelpDesk_Modify_Service(Categorization_Tier_1:="", Categorization_Tier_2:="", Categorization_Tier_3:="", Closure_Manufacturer:="", Closure_Product_Category_Tier1:="", _
    '        '                                                                      Closure_Product_Category_Tier2:="", Closure_Product_Category_Tier3:="", Closure_Product_Model_Version:="", Closure_Product_Name:="", _
    '        '                                                                      Company:="Calbro Financial Services", Summary:="Test Ticket - Web Services", Notes:="", Impact:=LOG_IN_Request_Tracking_BasicWS.ImpactType.Item4MinorLocalized, _
    '        '                                                                      Manufacturer:="", Product_Categorization_Tier_1:="", Product_Categorization_Tier_2:="", Product_Categorization_Tier_3:="", Product_Model_Version:="", _
    '        '                                                                      Product_Name:="", Reported_Source:=LOG_IN_Request_Tracking_BasicWS.Reported_SourceType.Other, Resolution:="Automatic Closure From WS", _
    '        '                                                                      Resolution_Category:="", Resolution_Category_Tier_2:="", Resolution_Category_Tier_3:="", Resolution_Method:="", Service_Type:=HPD_IncidentInterface_WS.Service_TypeType.InfrastructureEvent, _
    '        '                                                                      Status:=LOG_IN_Request_Tracking_BasicWS.StatusType.Closed, Urgency:=LOG_IN_Request_Tracking_BasicWS.UrgencyType.Item4Low, Action:="MODIFY", Work_Info_Summary:="", Work_Info_Notes:="", Work_Info_Type:=Nothing, _
    '        '                                                                      Work_Info_Date:=Nothing, Work_Info_Source:=Nothing, Work_Info_Locked:=Nothing, Work_Info_View_Access:=Nothing, Incident_Number:=strSubmitIncidentID)


    '        'strIncidentID = HelpDesk_Modify_Query_Service.HelpDesk_Query_Service(Incident_Number:="INC000000000001", Assigned_Group_Shift_Name:="", Assigned_Support_Company:="", _
    '        '                                                                    Assigned_Support_Organization:="", Assignee:="", Categorization_Tier_1:="", Categorization_Tier_2:="", Categorization_Tier_3:="", _
    '        '                                                                    City:="", Closure_Manufacturer:="", Closure_Product_Category_Tier1:="", Closure_Product_Category_Tier2:="", _
    '        '                                                                    Closure_Product_Category_Tier3:="", Closure_Product_Model_Version:="", Closure_Product_Name:="", Company:="", _
    '        '                                                                    Contact_Company:="", Contact_Sensitivity:=Nothing, Country:="", Department:="", First_Name:="", Impact:=Nothing, Last_Name:="", _
    '        '                                                                    Manufacturer:="", Middle_Initial:="", Notes:="", Organization:="", Phone_Number:="", Priority:=Nothing, Priority_Weight:=Nothing, _
    '        '                                                                    Product_Categorization_Tier_1:="", Product_Categorization_Tier_2:="", Product_Categorization_Tier_3:="", Product_Model_Version:="", _
    '        '                                                                    Product_Name:="", Region:="", Reported_Source:=Nothing, Resolution:="", Resolution_Category:="", Resolution_Category_Tier_2:="", _
    '        '                                                                    Resolution_Category_Tier_3:="", Service_Type:=Nothing, Site:="", Site_Group:="", Status:=Nothing, Status_Reason:=Nothing, Summary:="", Urgency:=Nothing, VIP:=Nothing)


    '    Catch ex As Exception
    '        'Throw New System.Exception(ex.Message, ex.InnerException)
    '        Console.WriteLine(ex.Message, ex.InnerException)
    '    End Try

    'End Sub

    Function GetArgValue(ByRef ArgArray() As String, ByVal SwitchValue As String, ByRef ErrMsg As String) As String
        ' // Return switch values from command line.
        ' // Switches and values must only come in pairs, ie. -u User -p Password -s Server
        Try
            For i As Integer = 0 To UBound(ArgArray) Step 2
                If ArgArray(i) = SwitchValue Then
                    Return ArgArray(i + 1)
                End If
            Next
        Catch ex As Exception
            ErrMsg = ex.Message
        End Try
        Return String.Empty
    End Function

    'Public Sub populate_req()

    '    Dim cb As System.AsyncCallback
    '    Dim state As New Object
    '    Dim b() As Byte

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

    'End Sub

End Module
