Imports System
Imports System.Windows.Forms.WebBrowser
Imports mshtml
Imports System.Collections.Generic
Imports ADAdminDotNet.My
Imports System.Configuration
Imports System.Text
Imports System.IO
Imports System.Text.RegularExpressions

Module modFunctions
    ' Dim userid As String
    'Dim pwd As String
    ' Dim wrong_department As String

    Class EventHandlers
        Public Sub OnBeforeNavigate2(ByVal sender As Object, ByRef URL As Object, ByRef Flags As Object, ByRef Target As Object, ByRef PostData As Object, ByRef Headers As Object, _
         ByRef Cancel As Boolean)
            Console.WriteLine("BeforeNavigate2 fired!")
        End Sub
    End Class

    Public Function AppPath() As String
        AppPath = ExePath() & "\"
    End Function

    Public Function ExePath() As String
        ExePath = System.IO.Path.GetFullPath(".")
    End Function

    Public Function file2str(ByVal PathAndFilename As String) As String

        file2str = ""
        Try
            ' Create an instance of StreamReader to read from a file.
            Using sr As StreamReader = New StreamReader(PathAndFilename)

                ' Read in the entire file
                file2str = sr.ReadToEnd()
                sr.Close()
            End Using
        Catch E As Exception
            file2str = ""
        End Try

    End Function

    Public Function file2stream(ByVal PathAndFilename As String) As StreamReader

        Try
            Dim sr As StreamReader = New StreamReader(PathAndFilename)
            file2stream = sr
            sr.Close()
        Catch E As Exception
            file2stream = Nothing
        End Try

    End Function

    Public Function IsValidEmail(ByVal strIn As String) As Boolean
        ' Return true if strIn is in valid e-mail format.
        Return Regex.IsMatch(strIn, _
               "^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))" + _
               "(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$")
    End Function

    Public Function To_UpperCase(ByVal str As String) As String
        Return StrConv(str, VbStrConv.Uppercase)
    End Function

    Public Function To_ProperCase(ByVal str As String) As String
        Return StrConv(str, VbStrConv.ProperCase)
    End Function

    Public Function To_LowerCase(ByVal str As String) As String
        Return StrConv(str, VbStrConv.Lowercase)
    End Function


    
#Region "Deprecated Remedy Code"
    ' Public Sub OpenRemedyCustomer(ByRef TheGrid As DataGridView, ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs, ByVal eOpenMode As ARUSER.OpenMode, ByVal frmFrom As String)

    '    'System.Windows.Forms.DataGridViewCellEventArgs

    '    Dim i As Integer
    '    Dim MyEntryID As String
    '    Dim a As ARUSER.COMAppObj
    '    Dim RemedyProcess As Process
    '    Dim SessionID As VariantType
    '    Dim RemedyForm As ARUSER.ICOMFormWnd
    '    Dim MyResultForm As ARUSER.COMQueryResult
    '    Dim RemedyQueryObject As ARUSER.ICOMQueryResultSet
    '    Dim RemedyProcesses() As Process = Process.GetProcessesByName("ARUSER")

    '    wrong_department = ""

    '    If frmEnvironment.ChildFormPRD.Visible Then
    '        frmEnvironment.ChildFormPRD.timerCOUNTS.Stop()
    '    Else
    '        frmEnvironment.childformQA.timerCOUNTS.Stop()
    '    End If

    '    a = New ARUSER.COMAppObj

    '    Try
    '        RemedyForm = DirectCast(a.OpenForm(0, My.Settings.RemedyServerName.Trim, "LOG_DM_Customer Information", ARUSER.OpenMode.ARQuery, 0), ARUSER.ICOMFormWnd)
    '    Catch ex As Exception
    '        If Err.Number = -2147216284 Then
    '            For Each RemedyProcess In RemedyProcesses
    '                RemedyProcess.Kill()
    '            Next
    '        End If
    '        If Err.Number = -2147216287 Or Err.Number = -2147023174 Then
    '            For i = 1 To 3
    '                userid = InputBox("Please enter your Remedy User ID Please?", "System Message", ADAdminDotNet.My.MySettings.Default.ARUser)
    '                pwd = InputBox("Enter your password please", "System Message", "logik007")
    '                If userid = "" Or pwd = "" Then
    '                    MsgBox("You did not enter valid values", MsgBoxStyle.OkOnly)
    '                    If frmEnvironment.ChildFormPRD.Visible Then
    '                        frmEnvironment.ChildFormPRD.timerCOUNTS.Start()
    '                    Else
    '                        frmEnvironment.childformQA.timerCOUNTS.Start()
    '                    End If
    '                    Exit Sub
    '                End If
    '                SessionID = DirectCast(a.Login(userid.ToString, pwd, 0), VariantType)
    '                If Err.Number = -2147467259 Then
    '                    MsgBox(Err.Description)
    '                    a.Logout(0)
    '                    a = Nothing
    '                Else
    '                    Exit For
    '                End If
    '            Next
    '        End If
    '    End Try

    '    Dim persalnumber As String
    '    persalnumber = Replace(TheGrid.Item("PersalNrDataGridViewTextBoxColumn", e.RowIndex).Value.ToString.ToUpper, "P", "")
    '    persalnumber = Replace(persalnumber, "p", "")
    '    If String.IsNullOrEmpty(Clipboard.GetText & "") Then
    '        Clipboard.Clear()
    '        Clipboard.SetText(persalnumber)
    '    End If
    '    Try
    '        RemedyForm = DirectCast(a.OpenForm(0, My.Settings.RemedyServerName.Trim, "LOG_DM_Customer Information", ARUSER.OpenMode.ARQuery, 0), ARUSER.ICOMFormWnd)
    '        RemedyForm.GetField("Persal Number").Value = persalnumber.Trim
    '        RemedyQueryObject = DirectCast(RemedyForm.Query(""), ARUSER.ICOMQueryResultSet)
    '        If RemedyQueryObject.Count > 0 Then
    '            MyResultForm = DirectCast(RemedyQueryObject.Item(1), ARUSER.COMQueryResult)
    '            MyEntryID = MyResultForm.entryId
    '            RemedyForm = DirectCast(a.LoadForm(0, My.Settings.RemedyServerName.Trim, "LOG_DM_Customer Information", MyEntryID, eOpenMode, 1), ARUSER.ICOMFormWnd)
    '            If eOpenMode = ARUSER.OpenMode.ARModify Then
    '                RemedyForm.GetField("Last Name").Value = StrConv(TheGrid.Item("SurnameDataGridViewTextBoxColumn", e.RowIndex).Value.ToString, VbStrConv.ProperCase)
    '                RemedyForm.GetField("First Name").Value = StrConv(TheGrid.Item("FirstnameDataGridViewTextBoxColumn", e.RowIndex).Value.ToString, VbStrConv.ProperCase)
    '                RemedyForm.GetField("E-Mail").Value = TheGrid.Item("EMailDataGridViewTextBoxColumn", e.RowIndex).Value.ToString.ToLower
    '                RemedyForm.GetField("Cellphone").Value = TheGrid.Item("CellDataGridViewTextBoxColumn", e.RowIndex).Value.ToString.ToUpper
    '                RemedyForm.GetField("Fax Number").Value = TheGrid.Item("FaxDataGridViewTextBoxColumn", e.RowIndex).Value.ToString.ToUpper
    '                RemedyForm.GetField("Telephone").Value = TheGrid.Item("TelBDataGridViewTextBoxColumn", e.RowIndex).Value.ToString.ToUpper
    '                RemedyForm.GetField("Rank").Value = TheGrid.Item("RankDataGridViewTextBoxColumn", e.RowIndex).Value.ToString.ToUpper
    '                RemedyForm.GetField("VULINDLELA Role").Value = TheGrid.Item("ResponsibilityDataGridViewTextBoxColumn", e.RowIndex).Value.ToString
    '                If frmFrom = "frmResetPassword" Then
    '                ElseIf frmFrom = "frmNewUsers" Then
    '                    If TheGrid.Item("DeptDataGridViewTextBoxColumn", e.RowIndex).Value.ToString.ToUpper.Trim <> "" Then
    '                        RemedyForm.GetField("Department Name").Value = TheGrid.Item("DeptDataGridViewTextBoxColumn", e.RowIndex).Value.ToString.ToUpper
    '                        RemedyForm.GetField("Department Type").Value = "" 'TheGrid.Item(9, e.RowIndex).Value.ToString.ToUpper
    '                    Else
    '                        wrong_department = TheGrid.Item("DeptDataGridViewTextBoxColumn", e.RowIndex).Value.ToString.ToLower
    '                        RemedyForm.GetField("Department Name").Value = TheGrid.Item("DeptDataGridViewTextBoxColumn", e.RowIndex).Value.ToString.ToLower
    '                        RemedyForm.GetField("Department Type").Value = ""
    '                    End If
    '                End If
    '            End If

    '        Else
    '            If MsgBox("User Not Found! Do you want to populate the values into Remedy?", MsgBoxStyle.YesNo, "System Message") = MsgBoxResult.Yes Then
    '                RemedyForm = DirectCast(a.OpenForm(0, My.Settings.RemedyServerName.Trim, "LOG_DM_Customer Information", ARUSER.OpenMode.ARSubmit, 1), ARUSER.ICOMFormWnd)
    '                If TheGrid.Item("PersalNrDataGridViewTextBoxColumn", e.RowIndex).Value.ToString.ToUpper.Trim.Length = 8 Then
    '                    RemedyForm.GetField("Persal Number").Value = TheGrid.Item("PersalNrDataGridViewTextBoxColumn", e.RowIndex).Value.ToString.ToUpper
    '                End If
    '                RemedyForm.GetField("Last Name").Value = StrConv(TheGrid.Item("SurnameDataGridViewTextBoxColumn", e.RowIndex).Value.ToString, VbStrConv.ProperCase)
    '                RemedyForm.GetField("First Name").Value = StrConv(TheGrid.Item("FirstnameDataGridViewTextBoxColumn", e.RowIndex).Value.ToString, VbStrConv.ProperCase)
    '                RemedyForm.GetField("E-Mail").Value = TheGrid.Item("EMailDataGridViewTextBoxColumn", e.RowIndex).Value.ToString.ToLower
    '                RemedyForm.GetField("Cellphone").Value = TheGrid.Item("CellDataGridViewTextBoxColumn", e.RowIndex).Value.ToString.ToUpper
    '                RemedyForm.GetField("Fax Number").Value = TheGrid.Item("FaxDataGridViewTextBoxColumn", e.RowIndex).Value.ToString.ToUpper
    '                RemedyForm.GetField("Telephone").Value = TheGrid.Item("TelBDataGridViewTextBoxColumn", e.RowIndex).Value.ToString.ToUpper
    '                RemedyForm.GetField("Rank").Value = TheGrid.Item("RankDataGridViewTextBoxColumn", e.RowIndex).Value.ToString.ToUpper
    '                RemedyForm.GetField("VULINDLELA Role").Value = TheGrid.Item("ResponsibilityDataGridViewTextBoxColumn", e.RowIndex).Value.ToString()
    '                RemedyForm.GetField("Title").Value = TheGrid.Item("TitleDataGridViewTextBoxColumn", e.RowIndex).Value.ToString.ToUpper
    '                If frmFrom = "frmResetPassword" Then
    '                ElseIf frmFrom = "frmNewUsers" Then
    '                    If TheGrid.Item("DeptDataGridViewTextBoxColumn", e.RowIndex).Value.ToString.ToUpper.Trim <> "" Then
    '                        RemedyForm.GetField("Department Name").Value = TheGrid.Item("DeptDataGridViewTextBoxColumn", e.RowIndex).Value.ToString.ToUpper
    '                        RemedyForm.GetField("Department Type").Value = "" 'TheGrid.Item(9, e.RowIndex).Value.ToString.ToUpper
    '                    Else
    '                        wrong_department = TheGrid.Item("DeptDataGridViewTextBoxColumn", e.RowIndex).Value.ToString.ToLower
    '                        RemedyForm.GetField("Department Name").Value = TheGrid.Item("DeptDataGridViewTextBoxColumn", e.RowIndex).Value.ToString.ToLower
    '                        RemedyForm.GetField("Department Type").Value = ""
    '                    End If
    '                End If
    '                RemedyForm = a.LoadForm(SessionID, My.Settings.RemedyServerName.Trim, "LOG_DM_Customer Information", MyEntryID, ARUSER.OpenMode.ARDisplay, True)
    '            End If
    '        End If
    '        If persalnumber.ToString.Trim.Length = 13 Then
    '            Tnumber = InputBox("Please supply the newly created temporary Remedy persal number", "Input Required", "").ToUpper
    '            persalnumber = Tnumber
    '        End If

    '        If frmEnvironment.ChildFormPRD.Visible Then
    '            With frmEnvironment.ChildFormPRD
    '                .txtPersalNumber.Text = persalnumber
    '                .btnActiveDirectory_Click(sender, e)
    '                .txtPersalNumber.Focus()
    '                .txtPersalNumber.SelectAll()
    '                .timerCOUNTS.Start()
    '            End With
    '        Else
    '            With frmEnvironment.childformQA
    '                .txtPersalNumber.Text = persalnumber
    '                .btnActiveDirectory_Click(sender, e)
    '                .txtPersalNumber.Focus()
    '                .txtPersalNumber.SelectAll()
    '                .timerCOUNTS.Start()
    '            End With
    '        End If

    '    Catch ex As Exception
    '        If Err.Number = -2147216287 Then
    '            MsgBox("An internal error occured plese try again", MsgBoxStyle.Critical)
    '            If frmEnvironment.ChildFormPRD.Visible Then
    '                frmEnvironment.ChildFormPRD.timerCOUNTS.Start()
    '            Else
    '                frmEnvironment.childformQA.timerCOUNTS.Start()
    '            End If
    '            Exit Sub
    '        End If
    '    End Try
    '    If frmEnvironment.ChildFormPRD.Visible Then
    '        frmEnvironment.ChildFormPRD.timerCOUNTS.Start()
    '    Else
    '        frmEnvironment.childformQA.timerCOUNTS.Start()
    '    End If
    '    frmEnvironment.WindowState = FormWindowState.Minimized
    ' End Sub


    ' Public Sub OpenRemedyCustomerOLD2(ByRef TheGrid As DataGridView, ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs, ByVal rowindexnew As Integer, ByVal eOpenMode As ARUSER.OpenMode, ByVal frmFrom As String)

    '    Dim i As Integer
    '    Dim MyEntryID As String
    '    Dim persalnumber As String = Replace(TheGrid.Item("Persalnr", rowindexnew).Value.ToString.ToUpper, "P", "")
    '    persalnumber = Replace(persalnumber, "p", "")

    '    'System.Windows.Forms.DataGridViewCellEventArgs
    '    Dim a As ARUSER.COMAppObj
    '    Dim RemedyProcess As Process
    '    Dim SessionID As VariantType
    '    Dim RemedyForm As ARUSER.ICOMFormWnd
    '    Dim MyResultForm As ARUSER.COMQueryResult
    '    Dim RemedyQueryObject As ARUSER.ICOMQueryResultSet
    '    Dim RemedyProcesses() As Process = Process.GetProcessesByName("ARUSER")

    '    wrong_department = ""

    '    If frmEnvironment.ChildFormPRD.Visible Then
    '        frmEnvironment.ChildFormPRD.timerCOUNTS.Stop()
    '    Else
    '        frmEnvironment.childformQA.timerCOUNTS.Stop()
    '    End If
    '    a = New ARUSER.COMAppObj

    '    Try
    '        RemedyForm = DirectCast(a.OpenForm(0, My.Settings.RemedyServerName.Trim, "LOG_DM_Customer Information", ARUSER.OpenMode.ARQuery, 0), ARUSER.ICOMFormWnd)
    '    Catch ex1 As Exception
    '        If Err.Number = -2147216284 Then
    '            For Each RemedyProcess In RemedyProcesses
    '                RemedyProcess.Kill()
    '            Next
    '        End If
    '        If Err.Number = -2147216287 Or Err.Number = -2147023174 Then
    '            For i = 1 To 3
    '                userid = InputBox("Please enter your Remedy User ID Please?", "System Message", "T0005221")
    '                'userid = InputBox("Please enter your Remedy User ID Please?", "System Message", "Ronel.Ilsley")
    '                pwd = InputBox("Enter your password please", "System Message", "logik007")
    '                'pwd = InputBox("Enter your password please", "System Message", "        ")
    '                If userid = "" Or pwd = "" Then
    '                    MsgBox("You did not enter valid values", MsgBoxStyle.OkOnly)
    '                    If frmEnvironment.ChildFormPRD.Visible Then
    '                        frmEnvironment.ChildFormPRD.timerCOUNTS.Start()
    '                    Else
    '                        frmEnvironment.childformQA.timerCOUNTS.Start()
    '                    End If
    '                    Exit Sub
    '                End If
    '                SessionID = DirectCast(a.Login(userid.ToString, pwd, 0), Microsoft.VisualBasic.VariantType)
    '                If Err.Number = -2147467259 Then
    '                    a.Logout(0)
    '                    a = Nothing
    '                    MsgBox(Err.Description)
    '                Else
    '                    Exit For
    '                End If
    '            Next
    '        End If
    '    End Try

    '    persalnumber = Replace(TheGrid.Item("Persalnr", e.RowIndex).Value.ToString.ToUpper, "P", "")
    '    persalnumber = Replace(persalnumber, "p", "")

    '    Try
    '        RemedyForm = DirectCast(a.OpenForm(0, My.Settings.RemedyServerName.Trim, "LOG_DM_Customer Information", ARUSER.OpenMode.ARQuery, 0), ARUSER.ICOMFormWnd)
    '        RemedyForm.GetField("Persal Number").Value = persalnumber.Trim
    '        RemedyQueryObject = DirectCast(RemedyForm.Query(""), ARUSER.ICOMQueryResultSet)
    '        If RemedyQueryObject.Count > 0 Then
    '            MyResultForm = DirectCast(RemedyQueryObject.Item(1), ARUSER.COMQueryResult)
    '            MyEntryID = MyResultForm.entryId
    '            RemedyForm = DirectCast(a.LoadForm(0, My.Settings.RemedyServerName.Trim, "LOG_DM_Customer Information", MyEntryID, eOpenMode, 1), ARUSER.ICOMFormWnd)

    '            If eOpenMode = ARUSER.OpenMode.ARModify Then
    '                RemedyForm.GetField("Last Name").Value = StrConv(TheGrid.Item("Surname", e.RowIndex).Value.ToString, VbStrConv.ProperCase)
    '                RemedyForm.GetField("First Name").Value = StrConv(TheGrid.Item("Firstname", e.RowIndex).Value.ToString, VbStrConv.ProperCase)
    '                RemedyForm.GetField("E-Mail").Value = TheGrid.Item("EMail", e.RowIndex).Value.ToString.ToLower
    '                RemedyForm.GetField("Cellphone").Value = TheGrid.Item("Cell", e.RowIndex).Value.ToString.ToUpper
    '                RemedyForm.GetField("Fax Number").Value = TheGrid.Item("Fax", e.RowIndex).Value.ToString.ToUpper
    '                RemedyForm.GetField("Telephone").Value = TheGrid.Item("TelB", e.RowIndex).Value.ToString.ToUpper
    '                RemedyForm.GetField("Rank").Value = TheGrid.Item("Rank", e.RowIndex).Value.ToString.ToUpper
    '                RemedyForm.GetField("VULINDLELA Role").Value = TheGrid.Item("Responsibility", e.RowIndex).Value.ToString()

    '                If TheGrid.Item("Dept", e.RowIndex).Value.ToString.ToUpper.Trim <> "" Then
    '                    RemedyForm.GetField("Department Name").Value = TheGrid.Item("Dept", e.RowIndex).Value.ToString.ToUpper
    '                    RemedyForm.GetField("Department Type").Value = TheGrid.Item("Province", e.RowIndex).Value.ToString.ToUpper
    '                Else
    '                    wrong_department = TheGrid.Item("DEPARTMENT", e.RowIndex).Value.ToString.ToLower
    '                    RemedyForm.GetField("Department Name").Value = TheGrid.Item("DEPARTMENT", e.RowIndex).Value.ToString.ToLower
    '                    RemedyForm.GetField("Department Type").Value = ""
    '                End If

    '            End If

    '        Else

    '            If MsgBox("User Not Found! Do you want to populate the values into Remedy?", _
    '                     MsgBoxStyle.YesNo, _
    '                      "System Message") = MsgBoxResult.Yes Then

    '                RemedyForm = DirectCast(a.OpenForm(0, My.Settings.RemedyServerName.Trim, "LOG_DM_Customer Information", ARUSER.OpenMode.ARSubmit, 1), ARUSER.ICOMFormWnd)

    '                If TheGrid.Item("Persalnr", e.RowIndex).Value.ToString.ToUpper.Trim.Length = 8 Then
    '                    RemedyForm.GetField("Persal Number").Value = TheGrid.Item("Persalnr", e.RowIndex).Value.ToString.ToUpper
    '                End If

    '                RemedyForm.GetField("Last Name").Value = StrConv(TheGrid.Item("Surname", e.RowIndex).Value.ToString, VbStrConv.ProperCase)
    '                RemedyForm.GetField("First Name").Value = StrConv(TheGrid.Item("Firstname", e.RowIndex).Value.ToString, VbStrConv.ProperCase)
    '                RemedyForm.GetField("E-Mail").Value = TheGrid.Item("EMail", e.RowIndex).Value.ToString.ToLower
    '                RemedyForm.GetField("Cellphone").Value = TheGrid.Item("Cell", e.RowIndex).Value.ToString.ToUpper
    '                RemedyForm.GetField("Fax Number").Value = TheGrid.Item("Fax", e.RowIndex).Value.ToString.ToUpper
    '                RemedyForm.GetField("Telephone").Value = TheGrid.Item("TelB", e.RowIndex).Value.ToString.ToUpper
    '                RemedyForm.GetField("Rank").Value = TheGrid.Item("Rank", e.RowIndex).Value.ToString.ToUpper
    '                RemedyForm.GetField("VULINDLELA Role").Value = TheGrid.Item("Responsibility", e.RowIndex).Value.ToString()
    '                RemedyForm.GetField("Title").Value = TheGrid.Item("Title", e.RowIndex).Value.ToString.ToUpper

    '                If frmFrom = "frmResetPassword" Then
    '                ElseIf frmFrom = "frmNewUsers" Then
    '                    If TheGrid.Item("Dept", e.RowIndex).Value.ToString.ToUpper.Trim <> "" Then
    '                        RemedyForm.GetField("Department Name").Value = TheGrid.Item("Dept", e.RowIndex).Value.ToString.ToUpper
    '                        RemedyForm.GetField("Department Type").Value = TheGrid.Item("Province", e.RowIndex).Value.ToString.ToUpper
    '                    Else
    '                        wrong_department = TheGrid.Item("DEPARTMENT", e.RowIndex).Value.ToString.ToLower
    '                        RemedyForm.GetField("Department Name").Value = TheGrid.Item("DEPARTMENT", e.RowIndex).Value.ToString.ToLower
    '                        RemedyForm.GetField("Department Type").Value = ""
    '                    End If
    '                End If
    '            End If
    '        End If

    '        If persalnumber.ToString.Trim.Length = 13 Then
    '            Tnumber = InputBox("Please supply the newly created temporary Remedy persal number", "Input Required", "").ToUpper
    '            persalnumber = Tnumber
    '        End If

    '        If frmEnvironment.ChildFormPRD.Visible Then
    '            With frmEnvironment.ChildFormPRD
    '                .txtPersalNumber.Text = persalnumber
    '                .btnActiveDirectory_Click(sender, e)
    '                .txtPersalNumber.Focus()
    '                .txtPersalNumber.SelectAll()
    '                .timerCOUNTS.Start()
    '            End With
    '            'Else
    '            With frmEnvironment.childformQA
    '                .txtPersalNumber.Text = persalnumber
    '                .btnActiveDirectory_Click(sender, e)
    '                .txtPersalNumber.Focus()
    '                .txtPersalNumber.SelectAll()
    '                .timerCOUNTS.Start()
    '            End With
    '        End If

    '    Catch ex As Exception
    '        If Err.Number = -2147216287 Then
    '            MsgBox("An internal error occured please try again", MsgBoxStyle.Critical)
    '            If frmEnvironment.ChildFormPRD.Visible Then
    '                frmEnvironment.ChildFormPRD.timerCOUNTS.Start()
    '            Else
    '                frmEnvironment.childformQA.timerCOUNTS.Start()
    '            End If
    '            Exit Sub
    '        Else
    '            'MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.RetryCancel, "Remedy System Message")
    '            Exit Sub
    '        End If
    '    End Try
    '    If frmEnvironment.ChildFormPRD.Visible Then
    '        frmEnvironment.ChildFormPRD.timerCOUNTS.Start()
    '    Else
    '        frmEnvironment.childformQA.timerCOUNTS.Start()
    '    End If
    '    frmEnvironment.WindowState = FormWindowState.Minimized
    'End Sub
#End Region

End Module