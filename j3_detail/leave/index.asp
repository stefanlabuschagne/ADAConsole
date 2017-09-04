<%@ Language=VBScript%>
<%	Option Explicit
	Const REPORT_TITLE = "Leave - Downloads"
	Const REPORT_SECURITY = "HR"%>
<!--#include virtual="/includes/downloadAppHeader.asp"-->
<%	Dim head: Set head = New PageHelp
	head.addItem "To expand or collapse a calendar year, click on the name of the financial year."
	head.addItem "These reports are in Excel 97-2000 format. The revelant report(s) can be downloaded to your PC by clicking on the name of the department / entity you wish to access."
	head.writeHelp
	Set head = Nothing
%>
<a href="index.asp">{ <%=Session(REPORT_SECURITY & "_USER_TYPE")%> }</a>
<div class="aTreeContent">
<%	Dim fs: Set fs = Server.CreateObject("fileSearch.clsFileSearch")
	If Session(REPORT_SECURITY & "_USER_TYPE") = 1 Then
		fs.getSearch APPLICATION_DOWNLOAD_DIRECTORY, "\\Leave\^|date$"
	ElseIf Session(REPORT_SECURITY & "_USER_TYPE") = 2 Then
		fs.getSearch APPLICATION_DOWNLOAD_DIRECTORY, "\^Nat|date$"
	ElseIf Session(REPORT_SECURITY & "_USER_TYPE") = 3 Then
		fs.getSearch APPLICATION_DOWNLOAD_DIRECTORY, "\^(...)\^\1|date$"
	ElseIf Session(REPORT_SECURITY & "_USER_TYPE") = 4 Then
		fs.getSearch APPLICATION_DOWNLOAD_DIRECTORY, "\^" & Session("USER_PROVINCE_SHORT_NAME") & "\^|date$"
	ElseIf Session(REPORT_SECURITY & "_USER_TYPE") = 5 Then
		fs.getSearch APPLICATION_DOWNLOAD_DIRECTORY, "\^" & Session("USER_DEPARTMENT_SHORT_NAME") & "\^|date$"
	ElseIf Session(REPORT_SECURITY & "_USER_TYPE") = 6 Then
		fs.getSearch APPLICATION_DOWNLOAD_DIRECTORY, "THISISJUSTTOSTOPNONASSIGNMENTS|date$|" & Replace(Replace(Session(REPORT_SECURITY & "_EXTEND_DEPTS"), ",", "|"), "'", "\^")
	End If
	Dim x1, _
		aSplit1, _
		aSplit2, _
		aSplit3, _
		xmlFile, _
		xmlRoot, _
		xmlTopRoot, _
		xmlYear, _
		currentYear, _
		currentQuarter, _
		currentProvince, _
		currentDept, _
		xmlCurrDept, _
		xmlQuarter, _
		xmlNat, _
		xmlProv, _
		xmlCurrProv, _
		xmlDept, _
		finSeperator, _
		xOrig, _
		arr1, _
		HTTPFileName

	currentYear = ""
	Dim retArr: Set retArr = fs.colFilesFound
	Set xmlFile = Server.createobject("Msxml2.DOMDocument.6.0")
	Set xmlTopRoot = xmlFile.createElement("menu")
	Set xmlRoot = xmlFile.createElement("menuItem")
	xmlTopRoot.AppendChild xmlRoot
	Call xmlRoot.SetAttribute("icon", "file.png")
	Call xmlRoot.SetAttribute("caption", "Calendar Years")  '' Not Financial Year
	Call xmlRoot.SetAttribute("opened", "true")
	Call xmlRoot.SetAttribute("number_of_files", retArr.Count)

	For each xOrig in retarr

		'' Response.Write xOrig & "<BR><BR>"

		arr1 = Split(xOrig, "|")
		x1 = arr1(0) '' Filename

		If Right(x1, 1) <> "\" And Right(x1, 5) <> "\date" Then

			aSplit1 = Split(x1, "\")  '' Split Filename on \
			aSplit2 = Split(x1, "^")  '' Splitr Filename on ^
			aSplit3 = Split(aSplit2(UBound(aSplit2)), " - ")

			If currentYear <> aSplit1(5) Then

				'' Do the clear empties for the Previous Set Of Objects
				If (currentYear <> "") Then
					'' clearEmpties
				end if

				Set xmlYear = xmlFile.createElement("menuItem")
				Call xmlYear.SetAttribute("caption", "Calendar Year: " & aSplit1(5))
				If CLng(aSplit1(5)) = getFinYear() Then Call xmlYear.SetAttribute("opened", "true")
				xmlRoot.appendChild xmlYear  '' Add the new year to the ROOT
				currentYear = aSplit1(5)
				currentProvince = ""
				currentDept = ""

			End If

			If currentQuarter <> aSplit1(6) Then

				'' Check if the Prevoius Quater Has empty National Departments
				'' Check if the Prevoius Quater Has empty Provinces
				If currentQuarter <> "" Then
					clearEmpties "N"
					clearEmpties "P"
				end if

				Set xmlQuarter = xmlFile.createElement("menuItem")
				Call xmlQuarter.SetAttribute("caption", aSplit1(6))
				xmlYear.appendChild xmlQuarter '' Append quarter to year

				Set xmlNat = xmlFile.createElement("menuItem")
				Call xmlNat.SetAttribute("caption", "National Departments")
				xmlQuarter.appendChild xmlNat '' Append "National Departments" to new Quarter

				Set xmlProv = xmlFile.createElement("menuItem")
				Call xmlProv.SetAttribute("caption", "Provinces")
				xmlQuarter.appendChild xmlProv '' Append "Provinces" to new Quarter

				currentQuarter = aSplit1(6)
				currentProvince = ""
			End If

			If currentProvince <> aSplit2(1) And _
				aSplit2(2) <> "" Then

				'' Check The *Previous* Department Referenced Variable for Single Childs
				'' Before we destroy the Variable
				resetSingleChild xmlCurrDept

				Set xmlCurrDept = xmlFile.CreateElement("menuItem")
				Call xmlCurrDept.SetAttribute("caption", aSplit3(1))
				If LCase(aSplit2(1)) <> "nat" Then
					'' Append To the Province
					Set xmlCurrProv = xmlFile.CreateElement("menuItem")
					Call xmlCurrProv.SetAttribute("caption", aSplit3(0))
					xmlProv.appendChild xmlCurrProv
					xmlCurrProv.appendChild xmlCurrDept  '' APPEND DEPARTMENT TO PROVINCE
				Else
					'' Append to the Nationals
					xmlNat.appendChild xmlCurrDept
				End If
				currentProvince = aSplit2(1)
				currentDept = aSplit2(2)
			End If

			If currentDept <> aSplit2(2) Then

				'' Check the PREVIOUSLY Created Department for a Single Child.
				If isObject(xmlCurrDept) Then resetSingleChild xmlCurrDept

				Set xmlCurrDept = xmlFile.CreateElement("menuItem")
				Call xmlCurrDept.SetAttribute("caption", aSplit3(1))
				If LCase(aSplit2(1)) <> "nat" Then
					'' Append DEPARTMENT to Province
					xmlCurrProv.appendChild xmlCurrDept

				Else
					'' Append DEPARTMENT to Nationals
					xmlNat.appendChild xmlCurrDept

				End If
				currentDept = aSplit2(2)

			End If

			HTTPFileName = formatFileNameForDownload(aSplit2(UBound(aSplit2)))

			Set xmlDept = xmlFile.CreateElement("menuItem")
			Call xmlDept.SetAttribute("icon", EXTENSION(x1) & ".jpg")
			Call xmlDept.SetAttribute("action", "return dwlX2('HTTPName=" & HTTPFileName & "&f=" & formatFileNameForDownload(x1) & "')")
			Call xmlDept.SetAttribute("caption", RemoveExt(aSplit3(2)) & " ( Creation date: " & arr1(1) & ", Size: " & arr1(2) & ")")
			xmlCurrDept.appendChild xmlDept

		ElseIf Right(x1, 5) = "\date" Then

			If isObject(xmlQuarter) Then Call xmlQuarter.setAttribute("caption", xmlQuarter.getAttribute("caption") & " ( Last updated: " & getDateFileValue(x1) & " )")
			If retArr.Count = 1 Then retArr.Remove 1

		End If

	Next

	'' Check The LAST added Department for single Files linked to it
	resetSingleChild xmlCurrDept    '' Referenced in COMMON.ASP

	'' Check if the Last Quater Has empty National Departments
	'' Check if the Last Quater Has empty Provinces
	clearEmpties "N"
	clearEmpties "P"

	'' Make A Menu in HTML
	applyExplorerXSLTo(xmlTopRoot)

	'' KLAAR

	Sub clearEmpties(TheItem)

	'	On Error Resume Next

		select case ucase(TheItem)

			case "N"  '' NATIONAL DEPARTMENTS

				If Not xmlNat.hasChildNodes Then
					xmlQuarter.removeChild xmlNat
					'Response.Write "Nat Removed"  & "" & xmlQuarter.text
				else
					'Response.Write "NOT Removed<BR>"
				end if

			case "P"

				If Not xmlProv.hasChildNodes Then
					xmlQuarter.removeChild xmlProv
					'Response.Write "Prov Removed<BR>"
				end if

			case "Q"

				If Not xmlQuarter.hasChildNodes Then
					xmlYear.removeChild xmlQuarter
					'Response.Write "Quater Removed<BR>"
				end if

			case "Y"

				If Not xmlYear.hasChildNodes Then
					xmlRoot.removeChild xmlYear
					'Response.Write "Year Removed<BR>"
				end if

			case "R"

				If Not xmlRoot.hasChildNodes Then
					xmlTopRoot.removeChild xmlRoot
					Do Until retArr.Count = 0
						retArr.Remove 1
					Loop
				End If

		end select

	'	Err.Clear
	'	On Error GoTo 0

	End Sub

%>
</div>
</div>
<script language="JavaScript1.2" type="text/javascript">writeFooter();enableFeedback();</script>
</body>
</html>