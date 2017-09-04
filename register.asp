<%
option explicit
Response.Expires = -1000

%>
<!--#include virtual="/includes/common.asp"-->
<html>
<!--
	Modification	: Added the Logistics check box
	Date			: 16 Aug 2005
	Name			: Percival Magobiana	
----------------------------------------------
	Modification	: Implemented new look & feel.
	Date			: 4 October 2005
	Name			: Richard de Breyn
	
----------------------------------------------
	Modification	: Added more descriptive stuff for the combo box cos Users Complained
	Date			: 14 November 2006
	Name			: Stefan Labuschagne	
	
----------------------------------------------
	Modification	: Added better functionality as per spec of Cobus, Wessel and MART van der Westhuizen.
	Date			: 28 November 2007 (PAYDAY!)
	Name			: Stefan Labuschagne	
	
----------------------------------------------
	Modification	: Added second round of improved functionality as per spec of Cobus.
	Date			: 25 Feburary 2008
	Name			: Stefan Labuschagne		
	
----------------------------------------------
	Modification	: Added third round of improved functionality as per spec of Johan Vermeulen.
	Date			: 13 October 2008 (FOK, werk ek nog steeds hier???)
	Name			: Stefan Labuschagne		
	
----------------------------------------------
	Modification	: Rewrittten the entire thing (With an input screen for each type of Person and NO SPECIAL BUSINESS RULES FOR TREASURY DEPARTMENTS) 
	                : cos the client thinks its too complicated.
	Date			: 31 Maart 2009 (JA - Hello Treasury)
	Name			: Stefan Labuschagne	
	
----------------------------------------------
	Modification	: Added Function to read email addresses to CC people as well	                
	Date			: 16 Feb 2012 
	Name			: Stefan Labuschagne		
	
----------------------------------------------
	Modification	: Added Function to Display a different Email Prompt for Ampies and Consultants.
	Date			: 05 April 2012
	Name			: Stefan Labuschagne		
	
-->
<head>
	<meta http-equiv="cache" content="no-store">
	<meta http-equiv="pragma" content="no-store">
	<meta http-equiv="pragma" content="no-cache">
	<meta http-equiv="expires" content="0">
	<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
	<script type="text/javascript" language="JavaScript1.2" src="/scripts/vip_page_script.js"></script>
	<script type="text/javascript" language="JavaScript1.2" src="/scripts/kh_n.js"></script>
	<link href="/styles/style.css" type="text/css" rel="STYLESHEET" id="VIP Base CSS" />
	<link href="/styles/framer.css" type="text/css" rel="STYLESHEET" id="VIP Base CSS" media="screen,print,projection"/>
	<SCRIPT src="/scripts/cb.js" type=text/javascript></SCRIPT>
	<title>New User Applicatin / Registration</title>
    <style type="text/css">
        .style1
        {
            width: 704px;
        }
        .style2
        {
            width: 808px;
        }
        .style3
        {
            width: 770px;
        }
        .style4
        {
            width: 3%;
        }
        .style5
        {
            width: 25%;
        }
    </style>
</head>
<body>
<div class="cbb">
<%	

function GetEmailaddress(DaRecordID)

Dim objRS : Set objRS = Server.CreateObject("ADODB.Recordset")
objRS.ActiveConnection = Application("sConn")
objRS.Source = "Select * from  ads..[Vulindlela_Email] where ID = " & DaRecordID & ""
objRS.CursorType = adOpenForwardOnly
objRS.LockType = adLockReadOnly
objRS.Open

GetEmailaddress = objRS.Fields("TO_ADDRESS").Value & ""

objRS.Close
set objRS = nothing

end function

function GetEmailaddressCC(DaRecordID)

Dim objRS : Set objRS = Server.CreateObject("ADODB.Recordset")
objRS.ActiveConnection = Application("sConn")
objRS.Source = "Select * from  ads..[Vulindlela_Email] where ID = " & DaRecordID & ""
objRS.CursorType = adOpenForwardOnly
objRS.LockType = adLockReadOnly
objRS.Open

GetEmailaddressCC = objRS.Fields("CC_ADDRESS").Value & ""

objRS.Close
set objRS = nothing

end function


Dim objRS: Set objRS = Server.CreateObject("ADODB.Recordset")
	If Request("PAGEPARM") = "ADD" Then
	
	   '' This was added for the validation of ** PERSAL NUMBERS ** for Gov Employees.
	   '' (Not IDENTIFICATION NUMBERS, Not T-NUMBERS)
	   dim GovEmployeeSelected	
	   
	   '' Dit werk 100% !!
	   If CLng(Request("USERTYPE_ID")) = 1 Then   	   
	    GovEmployeeSelected = true
	   else
	    GovEmployeeSelected = false '' Contsultant	   
	   end if
	   	   
	   if GovEmployeeSelected then 	   
    	   
	       Dim objADS
	       Dim DaUserIsValid		   
	       Dim RA
	       	       
	       RA = 0
    	   
    	   '' IEWERS CHECK ONS TEEN 'N DATABSE OM TE VALIDATE!!!!
	        'Set objADS = Server.CreateObject("ADODB.Command") '' New, upgraded version.
	        'objADS.ActiveConnection = Application("sConn")
	        'objADS.CommandType = adCmdText
	        'objADS.CommandText ="Select * from  ads.ADAdmin.[Web Security] where PERSALNR = '" & Request("USERID") & "'"
	        'objADS.Execute RA
	        
	        '' Just for Testing...........
	        'Response.Write RA & "<BR>"
	        'Response.Write objADS.CommandText	        
	        'Response.End
	        
            '' Check if User account is valid		        
            '' (Dit het ek self getoets)
	        if (RA = 0) then
	        
	            '' SL -> Het met Ronel Ilsley gepraat en besluit dat die nommer SLEGS 8 lank moet wees.
	            '' As die Gebruiker se PERSAL NOMMER nie bestaan nie kan hy moontlik op Persal wees en nie op Vulindlela nie.
	            '' En daar is baie sulke gevalle.
	            '' Daarom aanvaar ons die ou maar met die nommer wat hy intik.
	            '' SL 29 April 2009.
	            DaUserIsValid = true
	        else
	            DaUserIsValid = true        
	        end if
		        							
            set objADS = nothing
    	   	   
	       If not(DaUserIsValid) Then
	    	
	    	'' Show Sorry Screen    	    	   
		    Response.Redirect "register.asp?PAGEPARM=DENYACCESS&USERID=" & UCase(Request("USERID"))
		    Response.End	    	    
		    		   	    	    
	       end if
	       
	       
	   else
	    '' Dis 'n Kontrakteur. -> Kan hom nie op sy ID-Number Validate nie,
	    '' Maar hy moet 'n CFO brief he!
	   	       	   
	   end if
	    
	    '' If we got here, Da Stuff is Valid, so save the Application / Registration / Request
	
		With objrs
			.Open "Ads..VIP_USERS", Application("sConn"), 2, 3
			.AddNew
			.Fields("USERID") = TRIM(Request("USERID"))
			.Fields("USERTYPE_ID") = Request("USERTYPE_ID")
			.Fields("RANK") = "" '' Removed as per spec.....  28 April 2009
			.Fields("TITLE") = Request("TITLE")
			.Fields("FIRSTNAME") = Request("FIRSTNAME")
			.Fields("SURNAME") = Request("SURNAME")
			.Fields("BUS_TEL") = Request("BUS_TEL")
			.Fields("FAX_TEL") = Request("FAX_TEL")
			.Fields("CEL_TEL") = Request("CEL_TEL")
			.Fields("RESPONSIBILITY") = Request("RESPONSIBILITY")							
			.Fields("EMAIL") = Request("EMAIL")
			.Fields("PROVINCE") = Request("PROVINCE") & ""              '' Not Required for Consultants !!
			.Fields("DEPARTMENT") = Request("DEPARTMENT") & ""          '' Not Required for Consultants !!
			
			'' Access levelis no Longer Required as the user always gets OWN DEPARTMENT
			'' As per New Spec - SL 27 April 2009
'			If UCase(Request("RESPONSIBILITY")) = "FINANCIALS" Then
'				.Fields("REQ_FINANCIALS") = Request("REQ_LEVEL") 
'			Else
'				.Fields("REQ_FINANCIALS") = 0
'			End If
'			If UCase(Request("RESPONSIBILITY")) = "HUMAN RESOURCE" Then
'				.Fields("REQ_HR") = Request("REQ_LEVEL") 
'			Else
'				.Fields("REQ_HR") = 0
'			End If
'			If UCase(Request("RESPONSIBILITY")) = "SUPPLY CHAIN MANAGEMENT" Then
'				.Fields("REQ_LOGIS") = Request("REQ_LEVEL") 
'			Else
'				.Fields("REQ_LOGIS") = 0
'			End If
									
'			.Fields("REQ_GFS") = 0
'			.Fields("REQ_DPSA") = 0
			
			'' The user specifies EXACTLY what he wants in a note, if it is different from his OWN-DEPARTMENT
			.Fields("NOTES") = Request("NOTES") & "" 
			
'           THIUS IS FOR NEW CR by Mr Jan GILLELAND 08 OCT 1020			
'           Add the xstra data in this fields for capturing the CONSULTANTS APPLICATION
            if not(GovEmployeeSelected) then 
            
                .Fields("NOTES") = .Fields("NOTES")  & vbCrLf & "Consultants Details: "
                .Fields("NOTES") = .Fields("NOTES")  & vbCrLf & "Company: " & Request("CCOMPANY")
                .Fields("NOTES") = .Fields("NOTES")  & vbCrLf & "Department: " & Request("CDEPARTMENT")
                .Fields("NOTES") = .Fields("NOTES")  & vbCrLf & "Province: " & Request("CPROVINCE")
                .Fields("NOTES") = .Fields("NOTES")  & vbCrLf & "Job title: " & Request("CJOBTITLE")
                .Fields("NOTES") = .Fields("NOTES")  & vbCrLf & "Appointment Type: " & Request("CAPPOINTMENTTYPE")
                .Fields("NOTES") = .Fields("NOTES")  & vbCrLf & "Application Access Required: " & Request("CAPPLICATIONS")                
                .Fields("NOTES") = .Fields("NOTES")  & vbCrLf & "Access Motivation: " & Request("CAccessMotivation")                                                
                
                '' AND we need to add it here as per mail form Ronel I.
                '' The more things change the more they stay the same :-)
    			If UCase(Request("CAPPLICATIONS")) = "FINANCIALS" Then
    				.Fields("REQ_FINANCIALS") = 1
    			Else
    				.Fields("REQ_FINANCIALS") = 0
    			End If
    			If UCase(Request("CAPPLICATIONS")) = "HUMAN RESOURCE" Then
    				.Fields("REQ_HR") = 1
    			Else
    				.Fields("REQ_HR") = 0
    			End If
    			If UCase(Request("CAPPLICATIONS")) = "SUPPLY CHAIN MANAGEMENT" Then
    				.Fields("REQ_LOGIS") = 1 
    			Else
    				.Fields("REQ_LOGIS") = 0
    			End If                
                
			    .Fields("REQ_GFS") = 0
			    .Fields("REQ_DPSA") = 0                                                                               
                                           
            end if
									
			.Update
			.Close
		End With
		
		''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
		' As Dit 'n Consultants Request is moet ons 'n e-mail stuur na die Klient, Contact Centre, en ELMARI '
		' Met die nodige details, soos in die form gespesifiseer                                             '
		''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
		
		if len(Request("USERID")&"") = 13 then 
    		
		    Dim objCDOMail
	        Set objCDOMail = Server.CreateObject("CDO.Message")
	        objCDOMail.To = GetEmailaddress(10) & ";" &  Request("EMAIL")  'the destination
	        objCDOMail.From = "vults@treasury.gov.za"   'the sender
	        objCDOMail.cc = GetEmailaddressCC(10)
	        
	        ''objCDOMail.Configuration.
	        
            objCDOMail.Configuration.Fields("http://schemas.microsoft.com/cdo/configuration/smtpserver") = "10.123.45.210" '
            '.Configuration.Fields("http://schemas.microsoft.com/cdo/configuration/smtpserver") = "censg01" ' "10.131.12.118"
            objCDOMail.Configuration.Fields("http://schemas.microsoft.com/cdo/configuration/sendusing") = 2
            objCDOMail.Configuration.Fields.Update
	        
	        '' objCDOMail.h = false

	        Dim txtBody
	        txtBody = txtBody &  "<Font Face='Verdana'>Details of <b>Consultant</b> requesting access to www.vulindlela.gov.za<br><br>"	        
	        txtBody = txtBody & "<table border=1 >"
	        txtBody = txtBody &  "<tr><td>ID Number               : </td><td>" & Request("USERID") &  "</td></tr>"
	        txtBody = txtBody &  "<tr><td>Title                   : </td><td>" & Request("TITLE")& "</td></tr>"	    
	        txtBody = txtBody &  "<tr><td>Firstname               : </td><td>" & Request("FIRSTNAME")& "</td></tr>"
	        txtBody = txtBody &  "<tr><td>Surname                 : </td><td>" & Request("SURNAME")& "</td></tr>"
	        txtBody = txtBody &  "<tr><td>Office Tel Number       : </td><td>" & Request("BUS_TEL")& "</td></tr>"
	        txtBody = txtBody &  "<tr><td>Fax Number              : </td><td>" & Request("FAX_TEL")& "</td></tr>"
	        txtBody = txtBody &  "<tr><td>Cell (Alternate) Number : </td><td>" & Request("CEL_TEL")& "</td></tr>"
	        txtBody = txtBody &  "<tr><td>E-mail Address          : </td><td>" & Request("EMAIL")& "</td></tr>"
''	        txtBody = txtBody &  "<tr><td COLSPAN=2 >Refer to the FAXED LETTER to see requested information and access levels.</td></tr>"

            '' New Stuff Added 07 October 2010
	        txtBody = txtBody &  "<tr><td>Company                 : </td><td>" & Request("CCOMPANY")& "</td></tr>"	    
	        txtBody = txtBody &  "<tr><td>Department              : </td><td>" & Request("CDEPARTMENT")& "</td></tr>"
	        txtBody = txtBody &  "<tr><td>Province                : </td><td>" & Request("CPROVINCE")& "</td></tr>"	        
	        txtBody = txtBody &  "<tr><td>Job Title               : </td><td>" & Request("CJOBTITLE")& "</td></tr>"
	        txtBody = txtBody &  "<tr><td>Appointment Type        : </td><td>" & Request("CAPPOINTMENTTYPE")& "</td></tr>"
	        txtBody = txtBody &  "<tr><td>Applications Access     : </td><td>" & Request("CAPPLICATIONS")& "</td></tr>"	        
	        txtBody = txtBody &  "<tr><td>Access Motivation       : </td><td>" & Request("CAccessMotivation")& "</td></tr>"

    	    txtBody = txtBody & "</table><BR><BR>"	    	    	    
	        objCDOMail.Subject = "Vulindlela - New User (Consultant) Access Application"   'The Subject
	        
	        objCDOMail.HTMLBody = txtBody   'the body
	        objCDOMail.Send   'fire off the email
    	    
	        set objCDOMail = nothing
	    
	    end if

		
		Response.Redirect "register.asp?PAGEPARM=DONE"
		Response.End
		
	ElseIf Request("PAGEPARM") = "DENYACCESS" Then%>
	
		<h5>Registration Request Unsuccesfull</h5>
		<fieldset>
			<table cellspacing="0" cellpadding="2" class="contentTable" ID="Table1">
			    <tr>&nbsp;</tr>
				<tr><td style="padding:5px">'<I><%=Request("USERID")%>'</I> is not recognised as a valid PERSAL NUMBER.<br/><br/><br/>
					Please submit a request for registering a new Vulindlela profile, using a valid PERSAL NUMBER.<br/><br/>
					Regards, <br />
					Vulindlela Team<br />
					<br/>
				</td></tr>
			</table>
		</fieldset>
		</div><%
			
	ElseIf Request("PAGEPARM") = "DONE" Then%>						
	
    <h5>Registration Request Submitted</h5>
    <fieldset>
	    <table cellspacing="0" cellpadding="2" class="contentTable">
		    <tr><td style="padding:5px">Thank you for your interest in Vulindlela. A Vulindlela representative will <nobr>e-mail</nobr> you shortly to complete your request.<br /><br />
			    Regards, <br />
			    Vulindlela Team<br />&nbsp;
		    </td></tr>
	    </table>
    </fieldset>
    </div>
<%	Else

        '' Hierdie moet verwyder word soos wat tyd aanbeweeg.
                
        Dim PROVINCEorDEPARTMENT
        if Request("PROVINCEorDEPARTMENT") = "ND" then 
            PROVINCEorDEPARTMENT = "ND"
        elseif Request("PROVINCEorDEPARTMENT") = "P" then 
            PROVINCEorDEPARTMENT = "P"
        else
            PROVINCEorDEPARTMENT = "ND"	  '' default!!!
        end if

%>
<h5>New User Application / Registration</h5>
<fieldset>
	<table cellspacing="0" cellpadding="2" class="contentTable">
		<tr>
			<td class=infoIcon><img src="/images/information.gif" /></td>
			<td style="padding:5px;color:blue" class="style2"><u><strong>Please note:</strong></u>
				<table style="width: 804px; height: 363px;">

					<tr><td style="text-align:justify!important"><img src="/images/dot_grey.gif"/></td>
                        <td class="style3">In the following situations, approval from the office indicated 
                            below is required:</td></tr>										
					<tr><td style="text-align:justify!important"><img src="/images/dot_grey.gif"/></td>
                        <td class="style3">If you are a Government employee and need:</td></tr>					
					<tr><td style="text-align:justify!important"></td><td class="style3"><Li>access to the entire RSA, you need National Treasury Approval.</td></tr>					
					<tr><td style="text-align:justify!important"></td><td class="style3"><Li>clustered data.(e.g. all Health departments in RSA), 
                        you need National Treasury Approval.</td></tr>					
					<tr><td style="text-align:justify!important"></td><td class="style3"><Li>provincial data of your own province, 
                        you need approval from the applicable Provincial Treasury.</td></tr>						
					<tr><td style="text-align:justify!important"></td><td class="style3"><Li>data of more than one application (HR+Fin+Supply Chain), 
                        you need CFO approval applicable to your department. </td></tr>
					<td style="text-align:justify!important"><img src="/images/dot_grey.gif"/></td>
                        <td class="style3">If you are a consultant to Government</td></tr>					
					<tr><td style="text-align:justify!important"></td><td class="style3"><Li>you need National Treasury approval.</td></tr>
					<tr><td style="text-align:justify!important"><img src="/images/dot_grey.gif"/></td><td class="style3">Please contact 
                        our Call Desk at 012-657 4444 if you need more information in this regard.                
                        </tr>					
					<tr><td style="text-align:justify!important"><img src="/images/dot_grey.gif"/></td><td class="style3">Please fax the letter to 012- 657 4555. For Attention: VULINDLELA CALL CENTRE</tr>					
					<tr><td style="text-align:justify!important"><img src="/images/dot_grey.gif"/></td>
                        <td class="style3">You will be notified via e-mail as soon as the fax or electronic 
                            approval was received and your request has been processed.</td></tr>
				</table>
			</td>
		</tr>
	</table>
</fieldset>
<br /><br />

<form name="frm" method="post" >
	<input name="PAGEPARM" value="" type="hidden" />
	
	<fieldset style="padding:5px">
	
		<!-- Chicken or Beef?? -->
	
	<table id="PurposeTable" cellspacing="0" cellpadding="2" class="contentTable" style="width:100%;display:<%If CLng(Request("USERTYPE_ID")) = 1 or CLng(Request("USERTYPE_ID")) = 2 Then%>Block<%End If%>" >
        <tr class="style1">
			<td valign="top" class="style5">Indicate Your relation to government...</td>
			<td valign="top" class="style4">:</td>
			<td width="50%" class="style1">
				<input <%If CLng(Request("USERTYPE_ID")) = 1 Then%> CHECKED<%End If%> name="USERTYPE_ID" type="radio" value="1" onclick="DisplayAmpieForm();"/> Government Employee<br />
				<input <%If CLng(Request("USERTYPE_ID")) = 2 Then%> CHECKED<%End If%> name="USERTYPE_ID" type="radio" value="2" onclick="DisplayConsultantsForm();" /> Consultant</td>
		</tr>
	</table>

    <H5 id="AmpiesTableHeader" style="display:none">
        <table>
            <tr>
                <td><b>Register a Government Employee on Vulindlela</td>
            </tr>
        </table>
    </H5>
	
    <H5 id="ConsultantsTableHeader" style="display:none">
        <Table>
        <TR><TD><B>Register a Consultant on Vulindlela</TD></TR>
        </Table>        
    </H5>	

	<!-- CHICKEN AND BEEF -->
	<table border="0" id="restTable" cellspacing="0" cellpadding="2" class="contentTable" style="<%If CLng(Request("USERTYPE_ID")) = 0 Then%>display:none<%End If%>"  style="width:900px;"  >
		<tr >
			<td style="" id="PERID" style="width:10px" ><%
		        If CLng(Request("USERTYPE_ID")) = 1 Then
			        Response.Write "Persal&nbsp;Number"
		        ElseIf CLng(Request("USERTYPE_ID")) = 2 Then
			        Response.Write "<nobr>Your&nbsp;ID&nbsp;Number</nobr>"
		        End If%>
		
		    </td><td width="1%">:</td>
			<td width="66%">
			<!-- This is maxlength 13 digits for an ID number, but CAN also be 8 digits for persal number -->
			<input tabindex="1" maxlength="13" id="USERID" name="USERID" type="text" class="text" style="width:60%" value="<%=Replace(Request("USERID"), """", "")%>" onkeyDown="return NumbersOnly(event)" />*</td>
			
		</tr>
		
		<!-- Latest Change Request we must Remove SALARY LEVEl / RANK -->
				
		<tr>
			<td>Title</td>
			<td>:</td>
			<td>
				<Select onkeydown="return HandleKeyDown(event)" name="TITLE" tabindex="2" >
					<option value=""   <% if Replace(Request("TITLE"), """", "")="" then Response.Write "Selected" %>  ></option>
					<option value="Mr" <% if Replace(Request("TITLE"), """", "")="Mr" then Response.Write "Selected" %> >Mr</option>
					<option value="Ms" <% if Replace(Request("TITLE"), """", "")="Ms" then Response.Write "Selected" %> >Ms</option>										
				</Select>*
				<!--
				<input name="TITLE" maxlength=20 type="text" class="text" style="width:60%" value="<%=Replace(Request("TITLE"), """", "")%>" />
				-->
				</td>
				
		</tr>
		<tr class="style1">
			<td>Firstname</td>
			<td>:</td>
			<td><input tabindex="3" name="FIRSTNAME" maxlength=80 type="text" class="text" style="width:60%" onkeydown="return HandleKeyDown(event)" value="<%=Replace(Request("FIRSTNAME"), """", "")%>" />*</td>
		</tr>
		<tr>
			<td>Surname</td>
			<td>:</td>
			<td><input tabindex="4" name="SURNAME" maxlength=80 type="text" class="text" style="width:60%" onkeydown="return HandleKeyDown(event)" value="<%=Replace(Request("SURNAME"), """", "")%>" />*</td>
		</tr>
		<tr class="style1">
			<td>Office Tel. Number</td>
			<td>:</td>
			<td><input tabindex="5" name="BUS_TEL" maxlength=25 type="text" class="text" style="width:60%" onkeydown="return NumbersOnly(event)" value="<%=Replace(Request("BUS_TEL"), """", "")%>"  />*</td>			
		</tr>
		<tr>
			<td>Fax Number</td>
			<td>:</td>
 			<td><input tabindex="6" name="FAX_TEL" maxlength=25 type="text" class="text" style="width:60%" onkeydown="return NumbersOnly(event)" value="<%=Replace(Request("FAX_TEL"), """", "")%>" /></td>
		</tr>
		<tr class="style1">
			<td>Cell / Alternate Contact Number</td>
			<td>:</td>
			<td><input tabindex="7" name="CEL_TEL" maxlength=10 type="text" class="text" style="width:60%" onkeydown="return NumbersOnly(event)" value="<%=Replace(Request("CEL_TEL"), """", "")%>" />*</td>
		</tr>
		
		<!-- Now we need a separate Mail for Gov and Private Sector. SL 5 April 2012 -->						
		<tr>
			<td id="EMAILADDY" >E-Mail Address</td>
			<td>:</td>
			<td><input tabindex="8" name="EMAIL" maxlength=500 type="text" class="text" style="width:60%" onkeydown="return HandleKeyDown(event)" value="<%=Replace(Request("EMAIL"), """", "")%>" />*</td>
		</tr>
		
	
				
	</table>
	
	<!-- CONSULTANTS TABLE ONLY -->
	<!-- 07 October 2010 -->
	<!-- This is according to a new change request by MR Jan GILLELAND Himnself -->
	<!-- He will no longer phone the client to get the info himself -->
	<!-- The client can enter the info and he can just make a decision based on the additional info! -->
		
	<!-- CHICKEN ONLY -->	
	<table id="ConsultantsTable"  cellspacing="0" cellpadding="2"  style="display:none;width:900px" border="0"  class="contentTable">
	
        <tr class="style1">
			<td style="width:10px" >Company</td>
            <td width="1%">:</td>
			<td width="66%"><input tabindex="9" name="CCOMPANY" maxlength=80 type="text" class="text" style="width:60%" onkeydown="return HandleKeyDown(event)" value="<%=Replace(Request("SURNAME"), """", "")%>" />*</td>
		</tr>
		<tr class="style1">
			<td>Department</td>
			<td>:</td>
			<td><input tabindex="10" name="CDEPARTMENT" maxlength=25 type="text" class="text" style="width:60%" onkeydown="return HandleKeyDown(event)" value="<%=Replace(Request("BUS_TEL"), """", "")%>"  />*</td>			
		</tr>
		<tr>
			<td>Province</td>
			<td>:</td>
 			<td><input tabindex="11" name="CPROVINCE" maxlength=25 type="text" class="text" style="width:60%" onkeydown="return HandleKeyDown(event)" value="<%=Replace(Request("FAX_TEL"), """", "")%>" />*</td>
		</tr>
		<tr class="style1">
			<td>Job Title</td>
			<td>:</td>
			<td><input tabindex="12" name="CJOBTITLE" maxlength=25 type="text" class="text" style="width:60%" onkeydown="return HandleKeyDown(event)" value="<%=Replace(Request("CEL_TEL"), """", "")%>" />*</td>
		</tr>						
		<tr>
			<td>Appointment Type<br>(Permanent / Conrtractor / Intern)</td>
			<td>:</td>
			<td><input tabindex="13" name="CAPPOINTMENTTYPE" maxlength=25 type="text" class="text" style="width:60%" onkeydown="return HandleKeyDown(event)" value="<%=Replace(Request("EMAIL"), """", "")%>" />*</td>
		</tr>	
						
		<tr>
			<td>Application Access Required</td>
			<td>:</td>
			<td>
			<select tabindex="13" name="CAPPLICATIONS">
              <option value="Human Resources">Human Resources</option>
              <option value="Financials">Financials</option>
              <option value="Supply Chain Management">Supply Chain Management</option>
            </select>
		</tr>					
		
		<tr>
			<td>Motivation for access</td>
			<td>:</td>
			<td>			
            <textarea tabindex="14" cols="300" name="CAccessMotivation" rows="10" class="text" style="width:60%" onkeydown="return HandleKeyDown(event)" value="<%=Replace(Request("EMAIL"), """", "")%>" ></textarea>*</td>			
			
		</tr>				
		
	</table>
	
	
	
	<!--  BEEF ONLY  -->
	<table id="AmpiesTable" style="display:none;width:900px" border=0 >			
		<tr class="style1">
			<td >Sphere you work for:</td>
			<td width="1%" >:</td>
			<td width="66%% >
				<input type=hidden name= "ClearDepartments" id="ClearDepartments" value="N">
				<INPUT tabindex="9" type="radio"  <%If PROVINCEorDEPARTMENT = "ND" Then%> <%End If%> ID="optNationalDepartment" VALUE="ND" NAME="PROVINCEorDEPARTMENT" onkeydown="return HandleKeyDown(event)" onclick=" LoadNationalDepartments()"  >National Department
				<INPUT tabindex="10" type="radio"  <%If PROVINCEorDEPARTMENT = "P" Then%> <%End If%> ID="optProvince"           VALUE="P"  NAME="PROVINCEorDEPARTMENT" onkeydown="return HandleKeyDown(event)" onclick=" LoadProvioncialDepartments() " >Provincial Department
									
			</td>
		</tr>		
        <tr class="style1">
            <td align="center" valign="top" colspan="3" style="width: 100%"><hr /></td>
        </tr>
        <tr class="style1">
            <td align="center" valign="top" colspan="3" style="width: 100%">If no data is shown in the Dropdowns, please click the link below and follow the instructions...</td>
        </tr>
        <tr class="style1">
            <td align="center" valign="top" colspan="3" style="width: 100%"><a href="/files/Internet_Explorer_9_-_Tabs_Does_Not_Show_-_Compatibility_View.docx">Click here to download...</td>
        </tr>
        <tr class="style1">
            <td align="center" valign="top" colspan="3" style="width: 100%"><hr /></td>
        </tr>
		<tr class="style1">
			<td>Province name</td>
			<td>:</td>
			<td>			
			
			<select tabindex="11" title="Select a Province" name="PROVINCE" class="text" style="width:60%" onchange="LoadComboOptions('DEPARTMENT','P',this.value)" onkeydown="return HandleKeyDown(event)" >			
		    </select>*

		</td>
		
		</tr>
		
		<tr>
			<td>Department name</td>
			<td>:</td>
			<td>
			
                <!-- Stuff Removed Here -->

				<select tabindex="12" title=" Select a National Department" name="DEPARTMENT" class="text" style="width:60%" ID="Select1" onchange="ResetResponsibility()" onkeydown="return HandleKeyDown(event)" >
                </select>*
							
                <!-- Stuff Removed Here TOO -->			

			</td>
		</tr>
		
		<tr class="style1">
			<td>Application (Responsibility) within Department</td>
			<td>:</td>
			<td>
				<select tabindex="13" name="RESPONSIBILITY" id="RESPONSIBILITY" onchange="ModifyBoxes();" style="width:60%" onkeydown="return HandleKeyDown(event)" >
					<option value=""   <% if Replace(Request("Responsibility"), """", "")="" then Response.Write "Selected" %>  ></option>
					<option value="Financials" <% if Replace(Request("Responsibility"), """", "")="Financials" then Response.Write "Selected" %> >Financials</option>
					<option value="Human Resources" <% if Replace(Request("Responsibility"), """", "")="Human Resources" then Response.Write "Selected" %> >Human Resources</option>										
					<option value="Supply Chain Management" <% if Replace(Request("Responsibility"), """", "")="Supply Chain Management" then Response.Write "Selected" %> >Supply Chain Management</option>						
					
                        <!-- Stuff Removed Here TOO -->	
                    														
				</Select>*				
			</td>
		</tr>		
		
        <!-- NEWLY ADDED STUFF!!!!  -->
        
        <!-- Removed as part of the NEW SPEC               
		<tr class="style1">
			<td>Access Level Required for Applications</td>
			<td>:</td>
			<td>
			        <div id="VIEW_LEVEL" >
					    <select tabindex="14" name="REQ_LEVEL" style="width=60%" >					
						    <option value=0 /></option>
						    <%

						     %>						    						    
					    </select>*
					</div>
			</td>
		</tr>					
		-->
							
		<tr class="style1">
			<td valign="top">Special Note or Instruction</td>
			<td valign="top">:</td>
			<td><textarea tabindex="15" name="NOTES" rows="5" style="width:60%" title="Enter a note or a request for special access." ></textarea></td>
		</tr>
		
		<tr><td valign="top">* Required Fields</td></tr>		
	</table>
	
	

    <!-- DONT Always show this buttons... -->	
    <table id="SubmitButtons" style="display:none; width:100%" >			
    
        
        <!-- Stuff Removed Here TOO -->			    

	    <tr><td colspan=3 style="border-top:1px solid gray;text-align:center;padding-top:10px"><input type="button" class="button" value="   Apply  >>  " onclick="return checkIt()" style="display:block" /><br />&nbsp;</td></tr>
		
    		
    </table>
		

</fieldset>
</form>


<script type="text/javascript">

    var _PERID = ""

    function HandleKeyDown(e) {
    
        // Make an Enter a TAB so it go to the next line Automatically
        // alert(event.keyCode);
        
        if (event.keyCode == 13) {
            event.keyCode = 9;
            // alert(event.keyCode);            
        }
    
    }


    function LoadComboOptions(TargetControlName, PROVINCEorDEPARTMENT, PROVINCE) {

        // alert('lco');

        var xmlHttp = new ActiveXObject("MsXml2.XmlHttp");

        // alert('lco');
        
        xmlHttp.open("GET", "/screens/register_getAJAX.asp?PROVINCEorDEPARTMENT=" + PROVINCEorDEPARTMENT + "&PROVINCE=" + PROVINCE, false);

        // DO IT!!!
        xmlHttp.send(null)

        // alert(xmlHttp.responseText);

        // Traverse the options in the XMLDOC and load them in the
        var xmldoc = new ActiveXObject("Msxml2.DOMDocument");
        xmldoc.async = false;
        xmldoc.loadXML(xmlHttp.responseText);
        root = xmldoc.documentElement;
        
//        alert('Here! 5');
//        alert(root);

        oNodeList = root.childNodes;
        
//        alert('Here! 6');
//        alert(oNodeList.length);

        // CLEAR THE COMBO BOX OPTIONS
        var IIndexMax = document.getElementById(TargetControlName).options.length - 1;
        var IIndex = 0;
        for (IIndex = IIndexMax; IIndex >= 0; IIndex--)
            document.getElementById(TargetControlName).options.remove(0);


//        alert('CLEARED!!');
       
        // RE_POPULATE THE COMBOS OPTIONS
        for (var i = 0; i < oNodeList.length; i++) {
        
            Item = oNodeList.item(i);
            // alert(Item.xml);
            //alert(Item.text);
            
            // Hierdie is gevaarlik want Value attribute moet altyd dan in die eertse plek staan.
            //alert(Item.attributes.item(0).text);

            // werk nog hieraan!!!
            var oOption = document.createElement("OPTION");
            oOption.text = Item.text;
            oOption.value = Item.attributes.item(0).text;   // Hierdie is gevaarlik want Value attribute moet altyd dan in die eertse plek staan.
            document.getElementById(TargetControlName).add(oOption);

        }


        //Set focus to the target Control Then
        document.getElementById(TargetControlName).focus();

    }

    function LoadNationalDepartments() {

        // alert('1');

        // LOAD PROVINCE NAME.
        LoadComboOptions('PROVINCE', 'ND', '')

        // Load NATIONAL departments IN DIE Regte Combo.
        LoadComboOptions('DEPARTMENT', 'ND', 'nat')

        // Clear Responsibility
        document.getElementById("Responsibility").selectedIndex = 0;

        // Clear Access Level  REQ_LEVEL
        // document.getElementById("REQ_LEVEL").selectedIndex = 0;

        // Clear Note

        document.getElementById("DEPARTMENT").focus();

    }

    function LoadProvioncialDepartments() {

        // LOAD PROVINCE NAME.
        LoadComboOptions('PROVINCE', 'P', '')

        // CLEAR PROVINCIAL departments IN DIE Regte Combo.
        // CLEAR THE COMBO BOX OPTIONS
        var IIndexMax = document.getElementById('DEPARTMENT').options.length - 1;
        var IIndex = 0;
        for (IIndex = IIndexMax; IIndex >= 0; IIndex--)
            document.getElementById('DEPARTMENT').options.remove(0);

        // Clear Responsibility
        document.getElementById("Responsibility").selectedIndex = 0;

        // Clear Access Level  REQ_LEVEL
        // document.getElementById("REQ_LEVEL").selectedIndex = 0;

        // Clear Note
        document.getElementById("PROVINCE").focus();

    }
    
    

    function DisplayAmpieForm() {

        document.getElementById("PurposeTable").style.display = 'none';   
    
	    _PERID='Persal Number';
	    if (document.getElementById) {
	        document.getElementById('PERID').innerHTML = 'Persal&nbsp;Number';
	        document.getElementById('EMAILADDY').innerHTML = 'Official&nbsp;Government&nbsp;E-mail&nbsp;Address';
	        document.getElementById('restTable').style.display = 'block';
	        document.getElementById('AmpiesTable').style.display = 'block';
	        document.getElementById('ConsultantsTable').style.display = 'none'; // ADDED SL        	        
	        document.getElementById('USERID').maxlength = '8';	        
	        document.getElementById('AmpiesTableHeader').style.display = 'block';
	        document.getElementById('ConsultantsTableHeader').style.display = 'none';
            // Show Apply Button
	        document.getElementById('SubmitButtons').style.display = 'block';

	        document.getElementById('USERID').focus();	        
	        
	    }
    }

    function DisplayConsultantsForm() {

        document.getElementById("PurposeTable").style.display = 'none';       
    
	    _PERID='Your ID Number';
	    if (document.getElementById) {
	        document.getElementById('PERID').innerHTML = 'Your&nbsp;ID&nbsp;Number';
	        document.getElementById('EMAILADDY').innerHTML = 'E-Mail&nbsp;Address';
	        document.getElementById('restTable').style.display = 'block';
	        document.getElementById('AmpiesTable').style.display = 'none';
	        document.getElementById('ConsultantsTable').style.display = 'block'; // ADDED SL 	        
            document.getElementById('USERID').maxlength = '13';		        
	        document.getElementById('AmpiesTableHeader').style.display = 'none';
	        document.getElementById('ConsultantsTableHeader').style.display = 'block';
	        // Show Apply Button
	        document.getElementById('SubmitButtons').style.display = 'block';

	        document.getElementById('USERID').focus();	   	        
	        
	    }
    
    }
	
	function NumbersOnly(e)
    {
        // alert(e.keyCode);
        
        // Thus allows for numbers-only keyboard data entry validation!!!
        
        if ((e.keyCode > 47) & (e.keyCode < 58)) 
        {
            return true;
        }
        
        // Keypad Number Range!!
        else if ((e.keyCode > 95) & (e.keyCode < 106)) 
        {
            return true;
        }
        
        
        else if (e.keyCode == 8)  // BACKSPACE
        {
            return true;
        }

        else if (e.keyCode == 9)  // TAB!
        {
            return true;
        }

        else if (e.keyCode == 13)  // ENTER!
        {
            e.keyCode = 9; // Maak dit 'n TAB
            return true;
        }

        else if ((e.keyCode > 32) & (e.keyCode < 41))  // Pg-up, Pg-dn, Home, End (28 Aril 2009!)
        {
            return true;
        }   
        
        else 
        {
            // alert(e.keyCode);
            return false; // Do not accept the character that was typed!!
        }
    }
	
	function ResetResponsibility()
	{
	    document.getElementById("RESPONSIBILITY").selectedIndex=0;    	
	    
	    // Consider Resetting Applications here as well!
	    
	    // alert('Please select your level of responsibility in this departmnent');    	
	    document.getElementById("RESPONSIBILITY").focus();    	
	    return true;	
	}
	
	
	function ModifyBoxes()
	{

	    if  (document.getElementById("RESPONSIBILITY").value == 'Financials')
	    {	    
            
            // LoadApplications('REQ_LEVEL');
                      	        
	    }
	    
	    else
	    
	    {
    	    
            if  (document.getElementById("RESPONSIBILITY").value == 'Human Resource')
	        {

                //LoadApplications('REQ_LEVEL');                
	            	         
	        }

            if  (document.getElementById("RESPONSIBILITY").value == 'Supply Chain Management')
	        {
	                        
                //LoadApplications('REQ_LEVEL');                
	            
	        }
    	    
            if  (document.getElementById("RESPONSIBILITY").value == 'Other')
	        {

                //LoadApplications('REQ_LEVEL');    
	            
	 //           alert('Please add a Special Note to specify the Applications and Access you require.');
	   //         document.getElementById('NOTES').focus();
	    
	        }	    	    	    
	        
            if  (document.getElementById("RESPONSIBILITY").value == '')
	        {
	        
	            /*

	            // UNCHECK ALL!!!!!!!!       
	            if (document.getElementById('LOGIS').checked == true)
	            {
	                document.getElementById('LOGIS').onclick();
	                document.getElementById('LOGIS').checked = false ;
	            } 
	            	        
	            if (document.getElementById('FINANCIALS').checked == true)
	            {
	                document.getElementById('FINANCIALS').onclick();
	                document.getElementById('FINANCIALS').checked = false ;
	            }	        
    	  	        
	            if (document.getElementById('HR').checked == true)
	            {
	                document.getElementById('HR').onclick();
	                document.getElementById('HR').checked = false ;
	            }	
	            
	            */
	    
	        }


	    }

	    // document.getElementById("REQ_LEVEL").focus();
	    	     	        	        
	}
	
	function switchVis(itm){
		if(document.getElementById('VIEW_' + itm).style.display!="block")
			document.getElementById('VIEW_' + itm).style.display='block'
		else
			document.getElementById('VIEW_' + itm).style.display='none';
	}

	function resetCombos(){
//			document.getElementById('VIEW_FINANCIALS').style.display='none';
//			document.getElementById('VIEW_HR').style.display='none';
//			document.getElementById('VIEW_LOGIS').style.display='none';
			document.getElementById('restTable').style.display='none';
	}
	
	function checkItem(itm, minLength, displayName)
	{	
	    
	    // Trim Leading Spaces if they exist.
	    ItemLength = itm.value.length-1;
        for( i = 1; i<=ItemLength;i++)
        {
            if (itm.value.indexOf(' ') == 0 )
            {
                itm.value = itm.value.substr(1);
            }
        }
	    	    	    
	    // Trim Trailing Spaces
	    ItemLength = itm.value.length-1;
        for( i = 1; i<=ItemLength;i++)
        {
        
            // alert(itm.value.indexOf(' '));
            
            if (itm.value.substr(itm.value.length-1) == ' ' )
            {
                itm.value = itm.value.substr(0,itm.value.length-1);
                // alert(itm.value+'#');                
            }
        }	 
        
        // Do some e-mail specific Checks!
        if (itm.name=='EMAIL')
        {
        
            // alert('Here!');
        
            // Must have a '.' and an '@' sign
            if ((itm.value.split('.').length==1) || (itm.value.split('@').length==1))
            {
            
                // alert(itm.value.split('.').length);
                // alert(itm.value.split('@').length);                
            
			    alert("Please enter valid: " + displayName);
			    itm.focus();
			    return false;             
            }
            
                         
            // No '.' and '@' at the beginning or the end
            if ( (itm.value.substr(itm.value.length-1) == '.' ) 
                || (itm.value.substr(itm.value.length-1) == '@')
                || (itm.value.substr(0) == '.' ) 
                || (itm.value.substr(0) == '@') )
            {
			    alert("Please enter valid: " + displayName);
			    itm.focus();
			    return false;
			}

			// Must Not contain Spaces!!!!!
			if ((itm.value.split(' ').length > 1)) {

			    // alert(itm.value.split('.').length);
			    // alert(itm.value.split('@').length);

			    alert("The e-mail address entered contains an invalid space character.");
			    itm.focus();
			    return false;
			}

			// Must Not contain COMMAS!!!!!
			if ((itm.value.split(',').length > 1)) {

			    // alert(itm.value.split('.').length);
			    // alert(itm.value.split('@').length);                

			    alert("The e-mail address entered contains an invalid comma character.");
			    itm.focus();
			    return false;
			}  			
                    
        }
        
        /* For consultants, we must check a 13 digit RSA IDENTIFICATION NUMBER! */				
        if (itm.name=='USERID')
        {
		    if (aFrm["USERTYPE_ID"][1].checked)
		    {
		        minLength=13;

		    }
		    else
		    {
		        // This is the minimum length of for a PERSAL NUMBER
		        minLength=8;
		    }

		    if (itm.value.length != minLength) {
		        // Check for min Length!!
		        alert("Please enter valid: " + displayName + "\rThe number must be exactly "+minLength+" characters in length.");
		        itm.focus();
		        return false;
		        
		        
		        
		    }

		}


		// Check If mumeric fields are specifically entered as NUMERIC VALUES
		// The users can still copy and paste ALPHANUMERIC values into a NUMERIC-ONLY field.
		// SL 28 May 2009

		if (itm.name == 'USERID' || itm.name == 'BUS_TEL' || itm.name == 'CEL_TEL' || itm.name == 'FAX_TEL') {
		    if (isNaN(itm.value)) {
		        alert("Please enter a valid numeric: " + displayName + "");
		        itm.focus();
		        return false;
		    }
		}
						
	    // Check if it is shorter tham the min length (THIS IS GENERIC CODE)
		if (itm.value.length < minLength)
		{
		    // Check for min Length!!
			alert("Please enter valid: " + displayName);
			itm.focus();
			return false;
		}		
		
		else return true;
	}
	
	
	function LoadApplications(DaApplicationElementID)
	{
	
	        // 
	        if (document.getElementById('DEPARTMENT')==null)
	        {
	            alert('Please Select a Province and Department.');
	            document.getElementById('PROVINCE').focus();
                return false;	            	            
	        }
	
	
	        // Remove All Current Options 
            var IIndexMax = document.getElementById(DaApplicationElementID).options.length-1;
            var IIndex = 0;
            for (IIndex=IIndexMax; IIndex>0; IIndex--)                                            
             document.getElementById(DaApplicationElementID).options.remove(IIndex);  
	
            // NATIONAL TREASURY
            if (document.getElementById('DEPARTMENT').value == "ntrea")  
                {
                    
                    //alert('National Treasury!');
                
                    // LOAD ALL OPTIONS
                    //alert(document.getElementById(DaApplicationElementID).options.length);                                       
                                       
                   // ADD All Ness Options For National Treasury                    
                    var oOption = document.createElement("OPTION");
                    oOption.text=" RSA";
                    oOption.value="1";
                    document.getElementById(DaApplicationElementID).add(oOption);                    

                    var oOption = document.createElement("OPTION");                    
                    oOption.text=" National Only";
                    oOption.value="2";
                    document.getElementById(DaApplicationElementID).add(oOption);                       

                    var oOption = document.createElement("OPTION");                    
                    oOption.text=" Provincial Only";
                    oOption.value="3";
                    document.getElementById(DaApplicationElementID).add(oOption);                     

                    var oOption = document.createElement("OPTION");  
                    oOption.text=" Own Province";
                    oOption.value="4";
                    document.getElementById(DaApplicationElementID).add(oOption); 

                    var oOption = document.createElement("OPTION");  
                    oOption.text=" Own Department";
                    oOption.value="5";
                    document.getElementById(DaApplicationElementID).add(oOption); 
                    
                    var oOption = document.createElement("OPTION");  
                    oOption.text=" Multiple Departments";
                    oOption.value="6";
                    document.getElementById(DaApplicationElementID).add(oOption);                   
                    
                }
                
            // PROVINCIAL TREASURY!!!!
            
            
            if  (document.getElementById('DEPARTMENT').value == "ecp_treas" || document.getElementById('DEPARTMENT').value == "fsp_fin" || document.getElementById('DEPARTMENT').value == "gau_treas" || document.getElementById('DEPARTMENT').value == "kzn_fin" || document.getElementById('DEPARTMENT').value == "nop_treas" || document.getElementById('DEPARTMENT').value == "mpu_fin"  || document.getElementById('DEPARTMENT').value == "nwp_fin" || document.getElementById('DEPARTMENT').value == "ncp_fin"  || document.getElementById('DEPARTMENT').value == "wcp_fin")             
            
                {    
                    // alert('Provincial Treasury!');                
                                                      
                    // LOAD OWN PROVINCE + OWN DEPARTMENT only!!!!

                    var oOption = document.createElement("OPTION");  
                    oOption.text=" Own Province";
                    oOption.value="4";
                    document.getElementById(DaApplicationElementID).add(oOption); 

                    var oOption = document.createElement("OPTION");  
                    oOption.text=" Own Department";
                    oOption.value="5";
                    document.getElementById(DaApplicationElementID).add(oOption);                                           
                                     
                } 	
                                
                // if there is only one option in the box
                // then the default would be "Own Department"                
                
                if (document.getElementById(DaApplicationElementID).options.length == 1)
                {
                    var oOption = document.createElement("OPTION");  
                    oOption.text=" Own Department";
                    oOption.value="5";
                    document.getElementById(DaApplicationElementID).add(oOption);                        
                }
                
                
                // This rule was added 28 Feb 2008
                // Add Access level of 'OTHER', for NATIONAL DEPARTMENTS only!!!
                if (document.getElementById('PROVINCE').options.length == 1)
                {
                
                    // Add Access level of 'OTHER', for NATIONAL DEPARTMENTS - NON GOVEMENT EMPLOYEES only!!!
                    // As per new Spec of (JV) - 20 October 2008
		            if (document["frm"]["USERTYPE_ID"][1].checked)
		            {		
                        var oOption = document.createElement("OPTION");  
                        oOption.text=" Other";
                        oOption.value="7";
                        document.getElementById(DaApplicationElementID).add(oOption);                        
                        
                        // alert('Other Added!');
                        
		            }                
                                    
                }                
                
                
        return true;
                        
	}
	

	function checkIt(){
		aFrm = document["frm"];

		if (aFrm["USERTYPE_ID"][1].checked) {
		    if (!checkItem(aFrm["USERID"], 8, "ID number")) return false;
		}
		if (aFrm["USERTYPE_ID"][0].checked) {
		    if (!checkItem(aFrm["USERID"], 8, "number")) return false;
		}
		
		
		if(!checkItem(aFrm["TITLE"], 2, "Title")) return false;
		if(!checkItem(aFrm["FIRSTNAME"], 2, "Firstname")) return false;
		if(!checkItem(aFrm["SURNAME"], 2, "Surname")) return false;
		if (!checkItem(aFrm["BUS_TEL"], 10, "Office Telephone Number + Dial Code\r(Min 10 Digits)")) return false;
		// THIS WILL NOT CHECK FOR A MIN LENGTH, BUT WILL DO THE CH  VALUES THAT GETS COPIED AND PASTED
		if (!checkItem(aFrm["FAX_TEL"], 0, "Office Faxcimile Number + Dial Code\r(Min 10 Digits)")) return false;		
		if(!checkItem(aFrm["CEL_TEL"], 10, "Cellular Alternate Contact Number\r(Min 10 Digits)")) return false;
		if (!checkItem(aFrm["EMAIL"], 8, "EMail Address\r(Min 8 Characters, with @ and . signs)")) return false;

		// Do the following checks only for CONSULTANTS / CONTRACTORS
		// ADDED Change Request by J Gilleleand. SL 07 October 2010
		if (aFrm["USERTYPE_ID"][1].checked) {


		    if (!checkItem(aFrm["CCOMPANY"], 2, "Company")) return false;
		    if (!checkItem(aFrm["CDEPARTMENT"], 2, "Department")) return false;
		    if (!checkItem(aFrm["CPROVINCE"], 2, "Province")) return false;
		    if (!checkItem(aFrm["CJOBTITLE"], 2, "Job title")) return false;
		    if (!checkItem(aFrm["CAPPOINTMENTTYPE"], 2, "Appointment Type (Permanent / Conrtractor / Intern)")) return false;
		    if (!checkItem(aFrm["CAPPLICATIONS"], 2, "Application Access(Human Resources / Financials / Supply Chain Management)")) return false;
		    if (!checkItem(aFrm["CAccessMotivation"], 20, "Motivation for access. Min 20 characters.")) return false;

		}		
		
				
		// Do the following checks only for goverment employees
		// A Contractor or Consultant must enter up to the email address ONLY!!!!!
		if (aFrm["USERTYPE_ID"][0].checked) {

		    if ((!aFrm["optNationalDepartment"].checked) && (!aFrm["optProvince"].checked)) {

		        alert('Please indicate the sphere you work for:\rEither National or Provincial Department');
		        aFrm["optNationalDepartment"].focus();
		        return false;

		    }				

		    // Provincial Departments
		    if (aFrm["PROVINCE"].selectedIndex < 1) {
		        // tHERE MUST BE MORE THAN 1 PROVINVE IN DA LIST!!  
		        if (aFrm["PROVINCE"].options.length > 1) {
		            alert("Please select the PROVINCE you work for.")
		            aFrm["PROVINCE"].focus();
		            return false;
		        }

		    }

		    /*
		    alert('Here!!');
    		
		    if (isObject(aFrm["DEPARTMENT"])) {
		    alert(isObject(aFrm["DEPARTMENT"]));	    
		    }
		    */

		    if (aFrm["DEPARTMENT"].selectedIndex < 1) {
		        alert("Please select the department you work for.")
		        aFrm["DEPARTMENT"].focus();
		        return false;
		    }

		    if (!checkItem(aFrm["RESPONSIBILITY"], 1, "Responsibility in Department")) return false;
		    if (aFrm["PROVINCE"].selectedIndex < 1) {
		        if (aFrm["PROVINCE"].options.count > 1) {
		            alert("Please select the province you work for.")
		            aFrm["PROVINCE"].focus()
		            return false;
		        }
		    }

            /*
		    if (aFrm["REQ_LEVEL"].selectedIndex < 1) {
		        alert("Please select your preferred access level for applications.")
		        aFrm["REQ_LEVEL"].focus();
		        return false;
		    }
		    */


		    /* 29 Feb 2008 -> For National Departments only
		    If 'Other' was selected for "Access Level Required"
		    on a "NATIONAL DEPARTMENT" Level, then prompt the user to specify the access level required!
		    */
		    
		    
//		    if (aFrm["REQ_LEVEL"].value == '6')	    /*OTHER - Departments MUST leave a NOTE*/
//		    {
//		        if (!checkItem(aFrm["NOTES"], 1, "note or Instruction, to specify the Departments, Applications and Access you require.")) return false;
//		    }
            

//		    if (aFrm["REQ_LEVEL"].value == '7')	    /*OTHER departments for NAT DEPTS MUST leave a NOTE*/
//		    {
//		        if (!checkItem(aFrm["NOTES"], 1, "note or Instruction, to specify the Department access you require.")) return false;
//		    }
		    

		    /* If 'Other' was selected for a resaponsibility in a department, then "Special note for instruction" must be cumpulsory" */

		    if (aFrm["RESPONSIBILITY"].value == 'Other') {
		        if (!checkItem(aFrm["NOTES"], 1, "note or Instruction, to specify the Applications and Access you require.")) return false;
		    }


		    /*  14 October 2008  */
		    /* Notice for consultants! */
		    if (aFrm["USERTYPE_ID"][1].checked) {
		        alert('To complete your registration, please ensure that a motivationial letter from your CFO, is submitted.\rFor a fax number, refer to the instructions at the top of this registration page.');
		    }

		}  // EXTERNAL CONSULTANT X-STRA INFORMATION


		// Change Request number "LOG_IN_Request Tracking #000950033"
		// LASTLY,CHECK THE USER-ID AND LET THE USER CONFIRM THAT HE ENTERED THE CORRECT NUMBER!!

		if (aFrm["USERTYPE_ID"][0].checked) {

		    if (!confirm('Please verify that the Persal number "P' + aFrm["USERID"].value + '" is correct.\rClick OK if correct, or Cancel to retype the number.')) {
		        aFrm["USERID"].focus();
		        return false;
		    }
		}

		if (aFrm["USERTYPE_ID"][1].checked) {

		    if (!confirm('Please verify that the Identification number "' + aFrm["USERID"].value + '" is correct.\rClick OK if correct, or Cancel to retype the number.')) {
		        aFrm["USERID"].focus();
		        return false;
		    }
		}		
		
		
		
		frm['PAGEPARM'].value="ADD"
		frm.submit();
	}
	
	/* This has to be done on load! */
	// ModifyBoxes();
	
</script>
<%	End If%>
</div>
<script language="JavaScript1.2" type="text/javascript">writeFooter();enableFeedback()</script>
</body>
</html>


