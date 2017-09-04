Imports System
Imports System.IO
Imports System.Net

Module ARWebservices

    Sub Main()

	Dim ErrMsg As String = String.Empty
        Dim strFirstName As String = String.Empty
        Dim strLastName As String = String.Empty
        Dim ARUser As String = String.Empty
        Dim ARPassword As String = String.Empty

        Dim strSQL As String = String.Empty

        ' Declare variables for the HPD_IncidentInterface_Create_WS
        Dim AuthenticationInfo As New HPD_IncidentInterface_Create.AuthenticationInfo
        Dim HelpDesk_Submit_Service As New HPD_IncidentInterface_Create.HPD_IncidentInterface_Create_WSService
        Dim strSubmitIncidentID As String = String.Empty

        ' Declare variables for the HPD_IncidentInterface_WS
        Dim AuthenticationInfo_Query As New HPD_IncidentInterface_WS.AuthenticationInfo
        Dim HelpDesk_Modify_Query_Service As New HPD_IncidentInterface_WS.HPD_IncidentInterface_WSService

        ' // Holds the returned values of the Query to the Help Desk form. 
        Dim Query_OutputMap() As HPD_IncidentInterface_WS.GetListOutputMapGetListValues

        Try
            ' // Define Authentication Parameters for Submit and Query/Modify WS
            AuthenticationInfo.userName = ARUser
            AuthenticationInfo.password = ARPassword
            AuthenticationInfo_Query.userName = ARUser
            AuthenticationInfo_Query.password = ARPassword

            ' // Pass Authentication Info into Header in WS Submit Call
            HelpDesk_Submit_Service.AuthenticationInfoValue = AuthenticationInfo

            ' // Pass Authentication Info into Header in WS Query/Modify Call
            HelpDesk_Modify_Query_Service.AuthenticationInfoValue = AuthenticationInfo_Query

            ' // Webservices Submit Call for ARS 7.0.3
            strSubmitIncidentID = HelpDesk_Submit_Service.HelpDesk_Submit_Service(Assigned_Group:="", Assigned_Group_Shift_Name:="", Assigned_Support_Company:="", _
                                                                            Assigned_Support_Organization:="", Assignee:="", Categorization_Tier_1:="", Categorization_Tier_2:="", _
                                                                            Categorization_Tier_3:="", CI_Name:="", Closure_Manufacturer:="", Closure_Product_Category_Tier1:="", _
                                                                            Closure_Product_Category_Tier2:="", Closure_Product_Category_Tier3:="", Closure_Product_Model_Version:="", _
                                                                            Closure_Product_Name:="", Department:="", First_Name:=strFirstName, Impact:=HPD_IncidentInterface_Create.ImpactType.Item4MinorLocalized, _
                                                                            Last_Name:=strLastName, Lookup_Keyword:="", Manufacturer:="", Product_Categorization_Tier_1:="", Product_Categorization_Tier_2:="", _
                                                                            Product_Categorization_Tier_3:="", Product_Model_Version:="", Product_Name:="", Reported_Source:=HPD_IncidentInterface_Create.Reported_SourceType.Other, _
                                                                            Resolution:="", Resolution_Category_Tier_1:="", Resolution_Category_Tier_2:="", Resolution_Category_Tier_3:="", _
                                                                            Service_Type:=HPD_IncidentInterface_Create.Service_TypeType.InfrastructureEvent, Status:=HPD_IncidentInterface_Create.StatusType.New, Action:="CREATE", _
                                                                            Create_Request:=HPD_IncidentInterface_Create.Create_RequestType.No, Summary:="Test  Ticket - Web Services", Notes:="", _
                                                                            Urgency:=HPD_IncidentInterface_Create.UrgencyType.Item4Low, Work_Info_Summary:="Created From Web Interface", Work_Info_Notes:="", _
                                                                            Work_Info_Type:=HPD_IncidentInterface_Create.Work_Info_TypeType.General, Work_Info_Date:=Nothing, _
                                                                            Work_Info_Source:=HPD_IncidentInterface_Create.Work_Info_SourceType.Other, _
                                                                            Work_Info_Locked:=HPD_IncidentInterface_Create.Create_RequestType.No, _
                                                                            Work_Info_View_Access:=HPD_IncidentInterface_Create.Work_Info_View_AccessType.Internal, Middle_Initial:="")

            Console.WriteLine(strSubmitIncidentID)
            'strSQL = "'Incident Number' LIKE """ + strIncidentID + """"
            strSQL = "'First Name' = " + """Bob"""
            'strSQL = "'7' = " + """Closed"""

            ' // Initate the WS Query using above qualification to generate a time.
            Query_OutputMap = HelpDesk_Modify_Query_Service.HelpDesk_QueryList_Service(strSQL, 10, 100)


            ' // Close out the Request
            HelpDesk_Modify_Query_Service.HelpDesk_Modify_Service(Categorization_Tier_1:="", Categorization_Tier_2:="", Categorization_Tier_3:="", Closure_Manufacturer:="", Closure_Product_Category_Tier1:="", _
                                                                                  Closure_Product_Category_Tier2:="", Closure_Product_Category_Tier3:="", Closure_Product_Model_Version:="", Closure_Product_Name:="", _
                                                                                  Company:="Calbro Financial Services", Summary:="Test Ticket - Web Services", Notes:="", Impact:=HPD_IncidentInterface_WS.ImpactType.Item4MinorLocalized, _
                                                                                  Manufacturer:="", Product_Categorization_Tier_1:="", Product_Categorization_Tier_2:="", Product_Categorization_Tier_3:="", Product_Model_Version:="", _
                                                                                  Product_Name:="", Reported_Source:=HPD_IncidentInterface_WS.Reported_SourceType.Other, Resolution:="Automatic Closure From WS", _
                                                                                  Resolution_Category:="", Resolution_Category_Tier_2:="", Resolution_Category_Tier_3:="", Resolution_Method:="", Service_Type:=HPD_IncidentInterface_WS.Service_TypeType.InfrastructureEvent, _
                                                                                  Status:=HPD_IncidentInterface_WS.StatusType.Closed, Urgency:=HPD_IncidentInterface_WS.UrgencyType.Item4Low, Action:="MODIFY", Work_Info_Summary:="", Work_Info_Notes:="", Work_Info_Type:=Nothing, _
                                                                                  Work_Info_Date:=Nothing, Work_Info_Source:=Nothing, Work_Info_Locked:=Nothing, Work_Info_View_Access:=Nothing, Incident_Number:=strSubmitIncidentID)


            'strIncidentID = HelpDesk_Modify_Query_Service.HelpDesk_Query_Service(Incident_Number:="INC000000000001", Assigned_Group_Shift_Name:="", Assigned_Support_Company:="", _
            '                                                                    Assigned_Support_Organization:="", Assignee:="", Categorization_Tier_1:="", Categorization_Tier_2:="", Categorization_Tier_3:="", _
            '                                                                    City:="", Closure_Manufacturer:="", Closure_Product_Category_Tier1:="", Closure_Product_Category_Tier2:="", _
            '                                                                    Closure_Product_Category_Tier3:="", Closure_Product_Model_Version:="", Closure_Product_Name:="", Company:="", _
            '                                                                    Contact_Company:="", Contact_Sensitivity:=Nothing, Country:="", Department:="", First_Name:="", Impact:=Nothing, Last_Name:="", _
            '                                                                    Manufacturer:="", Middle_Initial:="", Notes:="", Organization:="", Phone_Number:="", Priority:=Nothing, Priority_Weight:=Nothing, _
            '                                                                    Product_Categorization_Tier_1:="", Product_Categorization_Tier_2:="", Product_Categorization_Tier_3:="", Product_Model_Version:="", _
            '                                                                    Product_Name:="", Region:="", Reported_Source:=Nothing, Resolution:="", Resolution_Category:="", Resolution_Category_Tier_2:="", _
            '                                                                    Resolution_Category_Tier_3:="", Service_Type:=Nothing, Site:="", Site_Group:="", Status:=Nothing, Status_Reason:=Nothing, Summary:="", Urgency:=Nothing, VIP:=Nothing)


        Catch ex As Exception
            'Throw New System.Exception(ex.Message, ex.InnerException)
            Console.WriteLine(ex.Message, ex.InnerException)
        End Try

    End Sub

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


End Module


  
Figure 1.

 
