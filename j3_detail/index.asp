<%@ Language=VBScript%>
<%	Option Explicit
	Const REPORT_TITLE = "HR Oversight Detail Data"
	Const APP_ID = 27
	Const REPORT_SECURITY = "HR_OVERSIGHT"%>
<!--#include virtual="/includes/downloadAppHeader.asp"-->
<%	Dim head: Set head = New PageHelp
	head.addItem "To expand or collapse a financial year, click on the name of the financial year."
	head.addItem "These reports are in Excel 97-2000 format. The revelant report(s) can be downloaded to your PC by clicking on the name of the department / entity you wish to access."
	head.writeHelp
	Set head = Nothing
%>
<!--
<a href="index.asp">{ <%=Session(REPORT_SECURITY & "_USER_TYPE")%> }</a>
-->

<div class="aTreeContent">
<%	Dim fs: Set fs = Server.CreateObject("fileSearch.clsFileSearch")
	If Session(REPORT_SECURITY & "_USER_TYPE") = 1 Then
		fs.getSearch APPLICATION_DOWNLOAD_DIRECTORY, "\\HRO|date$"
	ElseIf Session(REPORT_SECURITY & "_USER_TYPE") = 2 Then
		fs.getSearch APPLICATION_DOWNLOAD_DIRECTORY, "\^nat|\^\^|date$"
	ElseIf Session(REPORT_SECURITY & "_USER_TYPE") = 3 Then
		fs.getSearch APPLICATION_DOWNLOAD_DIRECTORY, "\^(...)\^\1|\^\^|date$"
	ElseIf Session(REPORT_SECURITY & "_USER_TYPE") = 4 Then
		fs.getSearch APPLICATION_DOWNLOAD_DIRECTORY, "\^" & Session("USER_PROVINCE_SHORT_NAME") & "\^|\^\^|date$"
	ElseIf Session(REPORT_SECURITY & "_USER_TYPE") = 5 Then
		fs.getSearch APPLICATION_DOWNLOAD_DIRECTORY, "\^" & Session("USER_DEPARTMENT_SHORT_NAME") & "|\^\^|date$"
	ElseIf Session(REPORT_SECURITY & "_USER_TYPE") = 6 Then
		fs.getSearch APPLICATION_DOWNLOAD_DIRECTORY, "THISISJUSTTOSTOPNONASSIGNMENTS|" & Replace(Replace(Session(REPORT_SECURITY & "_EXTEND_DEPTS"), ",", "|"), "'", "\^") & "|\^\^|date$"
	End If
	Dim x1, _
		aSplit1, _
		aSplit2, _
		aSplit3, _
		currentYear, _
		currentQuarter, _
		currentProvince, _
		currentProvDpt, _		
		currentDepartment,_
		xmlFile, _
		xmlRoot, _
		xmlTopRoot, _
		xmlYear, _
		xmlQuarter, _
		xmlNat, _
		xmlProv, _
		xmlSummary, _
		xmlClusters, _
		xmlNatProv, _
		xmlRSA, _
		xmlCurrProv, _
		xmlCurrentProvDpt, _
		xmlCurrDpt, _		
		xmlDept, _
		xmlFileItem, _
		xOrig, _
		arr1, _
		HTTPFileName
	Dim retArr: Set retArr = fs.colFilesFound
	xmlQuarter = 0

	Set xmlFile = Server.createobject("Msxml2.DOMDocument.6.0")
	Set xmlTopRoot = xmlFile.createElement("menu")
	Set xmlRoot = xmlFile.createElement("menuItem")
	xmlTopRoot.AppendChild xmlRoot
	Call xmlRoot.SetAttribute("icon", "file.png")
	Call xmlRoot.SetAttribute("caption", "Financial Years")
	Call xmlRoot.SetAttribute("opened", "true")
	Call xmlRoot.SetAttribute("number_of_files", retArr.Count)

	Sub clearEmpties01()
		On Error Resume Next
		If Not xmlNat.hasChildNodes Then xmlQuarter.removeChild xmlNat
		If Not xmlProv.hasChildNodes Then xmlQuarter.removeChild( xmlProv)
		Err.Clear
		On Error GoTo 0
	End Sub

	For each xOrig in retarr
	
		'' Response.Write xOrig & "<BR><BR>"
	
		arr1 = Split(xOrig, "|")
		x1 = arr1(0)
		If Right(x1, 1) <> "\" And Right(x1, 4) <> "date" Then
			aSplit1 = Split(x1, "\")
			aSplit2 = Split(x1, "^")
			aSplit3 = Split(aSplit2(UBound(aSplit2)), " - ")
			
			'' Response.Write aSplit3(1)			
			
			If currentYear <> aSplit1(5) Then
				If currentQuarter <> "" Then
					If Not xmlQuarter.hasChildNodes Then xmlQuarter.removeChild xmlQuarter
					If Not xmlNat.hasChildNodes Then xmlQuarter.removeChild xmlNat
					If Not xmlProv.hasChildNodes Then xmlQuarter.removeChild( xmlProv)
				End If
				Set xmlYear = xmlFile.createElement("menuItem")
				Call xmlYear.SetAttribute("caption", "Financial Year: " & aSplit1(5) & "/" & (CLng(aSplit1(5)) + 1))
				If CLng(aSplit1(5)) = getFinYear() Then Call xmlYear.SetAttribute("opened", "true")
				xmlRoot.appendChild xmlYear
				currentYear = aSplit1(5)
				currentQuarter = ""
				currentProvince = ""
				currentProvDpt = ""
				currentDepartment = ""
			End If
						
			'' New Quarter so set all the defaul stuff HERE!!!
			If currentQuarter <> aSplit1(6) Then
			
				clearEmpties01
				Set xmlQuarter = xmlFile.createElement("menuItem")
				Call xmlQuarter.SetAttribute("caption", aSplit1(6))
				xmlYear.appendChild xmlQuarter
				
				Set xmlNat = xmlFile.createElement("menuItem")
				Call xmlNat.SetAttribute("caption", "National Departments")
				xmlQuarter.appendChild xmlNat
				
				Set xmlProv = xmlFile.createElement("menuItem")
				Call xmlProv.SetAttribute("caption", "Provinces")
				xmlQuarter.appendChild xmlProv
				

				Set xmlSummary = xmlFile.createElement("menuItem")
				Call xmlSummary.SetAttribute("caption", "Summary")
				
				Set xmlClusters = xmlFile.createElement("menuItem")				
				Call xmlClusters.SetAttribute("caption", "Clusters")
				
				Set xmlNatProv = xmlFile.createElement("menuItem")
				Call xmlNatProv.SetAttribute("caption", "National & Provincial")
				
				Set xmlRsa = xmlFile.createElement("menuItem")
				Call xmlRsa.SetAttribute("caption", "RSA")


				'''''''''''''''''''''''''''''''''''''''''''''''''''''''''
				' Summary Stuff                                         '
				'                                                       '
				' This is not needed anymore - Mart's Email 25 May 2006 '
				'''''''''''''''''''''''''''''''''''''''''''''''''''''''''				
				'xmlQuarter.appendChild xmlSummary
				'xmlSummary.appendChild xmlClusters
				'xmlSummary.appendChild xmlNatProv
				'xmlSummary.appendChild xmlRSA
				
				'' Reset all the Shit
				
				currentQuarter = aSplit1(6)
				currentProvince = ""
				currentDepartment = ""
				
			End If
			
			If LCase(aSplit2(1)) <> "nat" Then
			
			
			
			
			else
			
			
			
			
			
			end if 
			

			''Adding a New Province Item to the Provinces list
			If currentProvince <> aSplit2(1) And _
				aSplit2(2) <> "" Then
				If LCase(aSplit2(1)) <> "nat" Then
					Set xmlCurrProv = xmlFile.CreateElement("menuItem")
					Call xmlCurrProv.SetAttribute("caption", aSplit3(0))
					xmlProv.appendChild xmlCurrProv
				End If
				currentProvince = aSplit2(1)
				currentProvDpt = ""
				currentDepartment = ""
			End If
			
			'' Add a Department-Group beneath the Provinsies 			
			If currentProvDpt <> aSplit2(2) Then
				If LCase(aSplit2(1)) <> "nat" Then
					Set xmlCurrentProvDpt = xmlFile.CreateElement("menuItem")
					Call xmlCurrentProvDpt.SetAttribute("caption", aSplit3(1))
					xmlCurrProv.appendChild xmlCurrentProvDpt
				End If
				currentProvDpt = aSplit2(2)
			End If				
						
			''Adding a National Department Item ("Current Service Commision")
			If currentDepartment <> aSplit3(1) then
				If LCase(aSplit2(1)) = "nat" Then
					Set xmlCurrDpt = xmlFile.CreateElement("menuItem")
					Call xmlCurrDpt.SetAttribute("caption", aSplit3(1))
					xmlNat.appendChild xmlCurrDpt					
					currentDepartment = aSplit3(1)					
				End If
			End If			
			
		
			
			
			
			
												
			HTTPFileName = formatFileNameForDownload(aSplit2(UBound(aSplit2)))
			
'			Response.Write HTTPFileName & "<BR><BR>"
			
			'' This is the lowest Denominator
			Set xmlFileItem = xmlFile.CreateElement("menuItem")
			Call xmlFileItem.SetAttribute("icon", EXTENSION(x1) & ".jpg")
			Call xmlFileItem.SetAttribute("action", "return dwlX2('HTTPName=" & HTTPFileName & "&f=" & formatFileNameForDownload(x1) & "')")
			
			If LCase(aSplit2(1)) = "nat" Then

				Call xmlFileItem.SetAttribute("caption", RemoveExt(aSplit3(2)) & " (Creation date: " & arr1(1) & ", Size: " & arr1(2) & ")")		
				
				If aSplit2(2) = "" Then
					xmlNatProv.AppendChild xmlFileItem
				Else
					xmlCurrDpt.appendChild xmlFileItem
				End If
				
			ElseIf aSplit2(2) <> "" And _			
			
				aSplit2(1) <> "" Then							
				Call xmlFileItem.SetAttribute("caption", RemoveExt(aSplit3(2)) & " (Creation date: " & arr1(1) & ", Size: " & arr1(2) & ")")		
				xmlCurrentProvDpt.appendChild xmlFileItem
				
			ElseIf LCase(aSplit2(2)) = "rsa" Then
			'	Response.Write "3" & "<BR>"
				'xmlRSA.appendChild xmlFileItem				
				'Call xmlFileItem.SetAttribute("caption", "RSA "& " (Creation date: " & arr1(1) & ", Size: " & arr1(2) & ")")		
				
			ElseIf aSplit2(0)<> "" And _
				aSplit2(1) <> "" Then
			'	Response.Write "4" & "<BR>"				
				'Call xmlFileItem.SetAttribute("caption", RemoveExt(aSplit2(UBound(aSplit2))) & " (Creation date: " & arr1(1) & ", Size: " & arr1(2) & ")")		
				'xmlNatProv.appendChild xmlFileItem
				
			Else
			'	Response.Write "5" & "<BR>"
				'Call xmlFileItem.SetAttribute("caption", RemoveExt(aSplit2(UBound(aSplit2))) & " (Creation date: " & arr1(1) & ", Size: " & arr1(2) & ")")		
				'xmlClusters.appendChild xmlFileItem
				
			End If
									
		ElseIf Right(x1, 5) = "\date" Then
			If isObject(xmlQuarter) Then Call xmlQuarter.setAttribute("caption", xmlQuarter.getAttribute("caption") & " ( Last updated: " & getDateFileValue(x1) & " )")
			If retArr.Count = 1 Then retArr.Remove 1
		End If
		
	Next

    '' This was added by SL 9 Des 2008 for the "provinces" empties to be taken away.
	clearEmpties01

	applyExplorerXSLTo(xmlTopRoot)
	
%>
</div>
</div>
<script language="JavaScript1.2" type="text/javascript">writeFooter();enableFeedback();</script>
</body>
</html>
