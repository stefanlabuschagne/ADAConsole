' Using BMC ITSM OOB Web Services
'
' The BMC Remedy ITSM Suite is shipped with a number of OOB Web Services that can be used to Create, Query and Modify requests (see Figure 1. at end of document).  
' The most common integration is with the Incident Module, although the other Web Services are also frequently used and follow the same principles.
' More information on the content of these, please refer to the (White Paper) BMC Remedy IT Service Management 7.x Integrations guide.
'
' Incident Management Web Services
'
' There are 2 associated Web Services with IM.  These are: 
'
' HPD_IncidentInterface_Create_WS 
' HPD_IncidentInterface _WS 
'
' They can be accessed from the following links:
'
' http://<midtier_server>/arsys/WSDL/public/<servername>/HPD_IncidentInterface_Create_WS
' http://<midtier_server>/arsys/WSDL/public/<servername>/HPD_IncidentInterface _WS
'
' Each Web Service contains one or more functions.  These are:
'
' HPD_IncidentInterface_Create_WS 
'
'	HelpDesk_Submit_Service	- Submit a request into Incident Management
'
' HPD_IncidentInterface _WS 
'
'	HelpDesk_Modify_Service	- Modify a request in Incident Management
'	HelpDesk_Query_Service	- Query a request in Incident Management
'	HelpDesk_QueryList_Service	- Query and return a list of requests in Incident Management
'
' Table 1-1: Web service function mapping
'
' Web service name Functions within the web service
'
' HPD_IncidentInterface_Create_WS	HelpDesk_Submit_Service
' HPD_IncidentInterface_WS			HelpDesk_Modify_Service
'									HelpDesk_Query_Service
'									HelpDesk_QueryList_Service
' CHG_ChangeInterface_Create_WS		Change_Submit_Service
'
' CHG_ChangeInterface_WS			Change_Modify_Service
'									Change_Query_Service
'									Change_QueryList_Service
' PBM_ProblemInterface_Create_ WS	Problem_Submit_Service
'									KnownError_Submit_Service
'									Solution_Submit_Service
' PBM_ProblemInterface_WS			Problem_Modify_Service
'									Problem_Query_Service
'									Problem_QueryList_Service
' PBM_KnownErrorInterface_WS		KnownError_Modify_Service
'									KnownError_Query_Service
'									KnownError_QueryList_Service
' PBM_SolutionInterfaceWS			Solution_Modify_Service
'									Solution_Query_Service
'									Solution_QueryList_Service
'									Solution_AddKeyword_Service
' AST_PurchaseOrder_WS				Update_PO_Confirmation
'									Get_Specific_PO
'									Get_List_Of_New_Pos

' Common integrations to these Web Services are from third party applications that can consume these Web Services and functions to create, query and modify requests.  Interfaces can be written in a number of languages, such as Java, ASP, C, .NET, etc to interact with these Web Services.
'
' There are a few things to remember when using these Web Services.  Some follow the normal integration form rules:
'
' 1.	When creating a request, ALL the fields that are mapped into the WSDL need to be provided even if they are NULL.  These are expected in the SOAP request and therefore all the fields need to be provided.
' 2.	The required fields, along with Authentication Information, must be provided as a minimum, these are:
'
' Field			Field Value		Notes
' 
' Action			CREATE	Keyword triggers workflow that initiates the submit operation.
' Last_Name					Used to populate the customer information section on the HPD:Help Desk form.
' First_Name
' Status
' Service_Type
' Impact
' Urgency
' Summary					Maps to Summary on the HPD:Help Desk form.
' Reported_Source
'  
' 3.	Auto Assignment needs to be configured.  
'       If there is no Auto Assignment rule (this rule can be offline), 
'       or no Assignment values provided, the request creation will fail.  
'       This is because workflow uses the Auto Assignment record to retrieve the Assignment Group ID - this is not documented 
'       and you can modify the default workflow to look up the correct form if needed.
' 4.	Date values are XML based format > YYYY-MM-DDThh:mmTZD (e.g. 1997-07-16T19:20+01:00)
'
' Testing Web Services
' --------------------
' One of the most common ways to test Web Services is to use a free tool call “SoapUI”.  This allows you to consume the Web Services and test the associated functionality.
'
' Using soapUI 
'
' Creating a Request
'
' 1.	Open a new project in soapUI.  Provide a project name and paste the URL of the Web Service into the “Initial WSDL/WADL:” field.  
'       This will search for the Web Service and return a list of functions on the left.
' 2.	Expand out the tree under the Web Service to expose the functions
' 3.	Double Click on the “Request 1” (SOAP Definition) under the HelpDesk_Submit_Service function.  This will open the SOAP Envelope in the right hand window.
' 4.	You will notice that soapUI puts the value “?” where it is expecting an input.  ** NOTE: These will be transmitted when submitting the request if not removed.  This will also cause errors back from Remedy due to incorrect data types, etc **
' 5.	Enter in the AuthenticationInfo.  You need to provide a valid Remedy Username and Password with appropriate permissions for the module.
' 6.	Provide values for the minimum fields and submit the request by pressing the green play button (top left).'
'
' Any errors relating to values, etc, will be displayed in the far right hand window.  If successful, you will be provided with an Incident number.
'
' ** NOTE: Although you may have been supplied an Incident Number, this number comes from the HPD:IncidentInterface_Create form workflow and may not be valid if the request was not successful in some of the field validations ... **
'

' Querying a Request (It is assumed that you have loaded in the correct Web Service > HPD_IncidentInterface _WS)
'
' 1.	Double Click on the “Request 1” (SOAP Definition) under the HelpDesk_Query_Service function.  This will open the SOAP Envelope in the right hand window.
' 2.	Enter in the AuthenticationInfo.  You need to provide a valid Remedy Username and Password with appropriate permissions for the module.
' 3.	Enter in a valid Incident Number and submit the request by pressing the green play button (top left).
' 4.	A response will be shown in the far right hand window. 

' Interfacing Example
' -------------------
' The following shows a typical Web Services call from VB.NET listing all the required values and showing an example of what is required in the Web Service call.  
' This will return the Incident ID where successful.  
' In Visual Studio, make a reference to the Web Service that you are attempting to consume. 
'
' !!! Note: As mentioned, all the fields need to be included in the Web Service request **
'
' Add a Web Reference via Project > Add Web Reference to the Remedy Web Services
' As the WS Reference is set to dynamic, include the .config file with .exe and update the reference to point to the correct path
' Note: You need to have visibility/connection to the WS as it is set to dynamic 
'
Imports System
Imports System.IO
Imports System.Net

Module modBMC_Webservices

    Sub Main()
        ' This program will perform the following:
        ' 1. Create a new Incident Request via the HPD:IncidentInteface_Create_WS form
        ' 2. Query the HPD:IncidentInteface_Create_WS form for Incident Number
        ' 3. Query the HPD:IncidentInteface_WS form for Entry ID for use with the modify function (Not Returning Values)
        ' 4. Send a Modify command and parameters the HPD:IncidentInteface_WS form to Close the Incident Request
        ' ** Password cannot be blank **
        ' The Create Uses Auto Assignment.  Fill in the required fields to use manual Assignment along with an Auto Assignment rule (can be offline).  
        ' Extra cmd line Parameters will be needed for Company, Org, Support Group if manual assignment required.
        ' ARUser must be someone with Incident Modify permission (e.g. Incident Master) and be in the same Support Group as Assignment.
        '
        ' Input Parameters

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

        ' Holds the returned values of the Query to the Help Desk form. 
        Dim Query_OutputMap() As HPD_IncidentInterface_WS.GetListOutputMapGetListValues

        Try
            ' Define Authentication Parameters for Submit and Query/Modify WS
            AuthenticationInfo.userName = "T0005221"
            AuthenticationInfo.password = "logik007"
            AuthenticationInfo_Query.userName = "T0005221"
            AuthenticationInfo_Query.password = "logik007"

            ' Pass Authentication Info into Header in WS Submit Call
            HelpDesk_Submit_Service.AuthenticationInfoValue = AuthenticationInfo

            ' Pass Authentication Info into Header in WS Query/Modify Call
            HelpDesk_Modify_Query_Service.AuthenticationInfoValue = AuthenticationInfo_Query

            ' Webservices Submit Call for ARS 7.0.3
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
                                                                            Work_Info_View_Access:=HP	D_IncidentInterface_Create.Work_Info_View_AccessType.Internal, Middle_Initial:="")

            ' // Webservices Submit Call for 7.0.1 ARS 7.1 no Patch - No Work Info (as appears to have issues on this version) or Middle Initial 
            'strSubmitIncidentID = HelpDesk_Submit_Service.HelpDesk_Submit_Service(Assigned_Group:="", Assigned_Group_Shift_Name:="", Assigned_Support_Company:="", _
            '                                                                Assigned_Support_Organization:="", Assignee:="", Categorization_Tier_1:="", Categorization_Tier_2:="", _
            '                                                                Categorization_Tier_3:="", CI_Name:="", Closure_Manufacturer:="", Closure_Product_Category_Tier1:="", _
            '                                                                Closure_Product_Category_Tier2:="", Closure_Product_Category_Tier3:="", Closure_Product_Model_Version:="", _
            '                                                                Closure_Product_Name:="", Department:="", First_Name:=strFirstName, Impact:=HPD_IncidentInterface_Create.ImpactType.Item4MinorLocalized, _
            '                                                                Last_Name:=strLastName, Lookup_Keyword:="", Manufacturer:="", Product_Categorization_Tier_1:="", Product_Categorization_Tier_2:="", _
            '                                                                Product_Categorization_Tier_3:="", Product_Model_Version:="", Product_Name:="", Reported_Source:=HPD_IncidentInterface_Create.Reported_SourceType.Other, _
            '                                                                Resolution:="", Resolution_Category_Tier_1:="", Resolution_Category_Tier_2:="", Resolution_Category_Tier_3:="", _
            '                                                                Service_Type:=HPD_IncidentInterface_Create.Service_TypeType.InfrastructureEvent, Status:=HPD_IncidentInterface_Create.StatusType.Closed, Action:="CREATE", _
            '                                                                Create_Request:=HPD_IncidentInterface_Create.Create_RequestType.No, Summary:="Sentinel Test Ticket Web Services", Notes:="", _
            '                                                                Urgency:=HPD_IncidentInterface_Create.UrgencyType.Item4Low, Work_Info_Summary:="", _
            '                                                                Work_Info_Notes:="", Work_Info_Type:=HPD_IncidentInterface_Create.Work_Info_TypeType.General, Work_Info_Date:=Nothing, _
            '                                                                Work_Info_Source:=HPD_IncidentInterface_Create.Work_Info_SourceType.Other, _
            '                                                                Work_Info_Locked:=HPD_IncidentInterface_Create.Create_RequestType.No, _
            '                                                                Work_Info_View_Access:=HPD_IncidentInterface_Create.Work_Info_View_AccessType.Internal)

            Console.WriteLine(strSubmitIncidentID)


            ' NOTE: Query required for HPD:IncidentInterface differs from above as we are specifying a particular field by name
            ' Example SQL Query ** Note: Inverted Commas Needed or SQL Will Fail**
            ' strSQL = "'Incident Number' = ""INC000000000093"""
            ' e.g. 'Incident Number' LIKE "INC___________7" - This only works with last number, does not like the full ID.

            'strIncidentID = strSubmitIncidentID
            'strSQL = "'Incident Number' LIKE """ + strIncidentID + """"
            strSQL = "'First Name' = " + """Bob"""
            'strSQL = "'7' = " + """Closed"""


            ' Initate the WS Query using above qualification to generate a time.
            Query_OutputMap = HelpDesk_Modify_Query_Service.HelpDesk_QueryList_Service(strSQL, 10, 100)

            ' Cannot retrieve the values as it executing but returing an empty (nothing) variable so For/Next generates and error.
            'For Each getListValues In Query_OutputMap
            ' Console.WriteLine(getListValues.Incident_Number)
            'Next


            ' Pause for 10 seconds to allow Auto Assignment to occur
            Console.WriteLine("Pausing for 10 seconds to allow Auto Assignment to occur")
            System.Threading.Thread.Sleep(10000)


            ' Close out the Request
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

End Module