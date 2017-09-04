Imports System
Imports ARUser
Imports System.IO
Imports System.Text.RegularExpressions

Module modFunctions
    Dim userid As String
    Dim pwd As String

    Public Sub OpenRemedyCustomer1(ByRef TheGrid As DataGridView, ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs, ByVal eOpenMode As ARUSER.OpenMode, ByVal frmFrom As String)

        'System.Windows.Forms.DataGridViewCellEventArgs

        Dim i As Integer
        Dim MyEntryID As String
        Dim a As ARUSER.COMAppObj
        Dim RemedyProcess As Process
        Dim SessionID As VariantType
        Dim RemedyForm As ARUSER.ICOMFormWnd
        Dim MyResultForm As ARUSER.COMQueryResult
        Dim RemedyQueryObject As ARUSER.ICOMQueryResultSet
        Dim RemedyProcesses() As Process = Process.GetProcessesByName("ARUSER")

        wrong_department = ""

        If frmEnvironment.ChildFormPRD.Visible Then
            frmEnvironment.ChildFormPRD.timerCOUNTS.Stop()
        Else
            frmEnvironment.childformQA.timerCOUNTS.Stop()
        End If
        a = New ARUSER.COMAppObj

        Try
            RemedyForm = a.OpenForm(0, My.Settings.RemedyServerName.Trim, "LOG_DM_Customer Information", ARUSER.OpenMode.ARQuery, False)
        Catch ex As Exception
            If Err.Number = -2147216284 Then
                For Each RemedyProcess In RemedyProcesses
                    RemedyProcess.Kill()
                Next
            End If
            If Err.Number = -2147216287 Or Err.Number = -2147023174 Then
                For i = 1 To 3
                    userid = InputBox("Please enter your Remedy User ID Please?", "System Message", "T0005630")
                    pwd = InputBox("Enter your password please", "System Message", "logik007")
                    If userid = "" Or pwd = "" Then
                        MsgBox("You did not enter valid values", MsgBoxStyle.OkOnly)
                        If frmEnvironment.ChildFormPRD.Visible Then
                            frmEnvironment.ChildFormPRD.timerCOUNTS.Start()
                        Else
                            frmEnvironment.childformQA.timerCOUNTS.Start()
                        End If
                        Exit Sub
                    End If
                    SessionID = a.Login(userid.ToString, pwd, False)
                    If Err.Number = -2147467259 Then
                        MsgBox(Err.Description)
                        a.Logout(0)
                        a = Nothing
                    Else
                        Exit For
                    End If
                Next
            End If
        End Try

        Dim persalnumber As String
        ' frmResetPassword
        persalnumber = Replace(TheGrid.Item("PersalNrDataGridViewTextBoxColumn", e.RowIndex).Value.ToString.ToUpper, "P", "")
        persalnumber = Replace(persalnumber, "p", "")

        Try
            RemedyForm = a.OpenForm(0, My.Settings.RemedyServerName.Trim, "LOG_DM_Customer Information", ARUSER.OpenMode.ARQuery, False)
            RemedyForm.GetField("Persal Number").Value = persalnumber.Trim
            RemedyQueryObject = RemedyForm.Query("")
            If RemedyQueryObject.Count > 0 Then
                MyResultForm = RemedyQueryObject.Item(1)
                MyEntryID = MyResultForm.entryId
                RemedyForm = a.LoadForm(0, My.Settings.RemedyServerName.Trim, "LOG_DM_Customer Information", MyEntryID, eOpenMode, True)
                If eOpenMode = ARUSER.OpenMode.ARModify Then
                    RemedyForm.GetField("Last Name").Value = StrConv(TheGrid.Item("SurnameDataGridViewTextBoxColumn", e.RowIndex).Value.ToString, VbStrConv.ProperCase)
                    RemedyForm.GetField("First Name").Value = StrConv(TheGrid.Item("FirstnameDataGridViewTextBoxColumn", e.RowIndex).Value.ToString, VbStrConv.ProperCase)
                    RemedyForm.GetField("E-Mail").Value = TheGrid.Item("EMailDataGridViewTextBoxColumn", e.RowIndex).Value.ToString.ToLower
                    RemedyForm.GetField("Cellphone").Value = TheGrid.Item("CellDataGridViewTextBoxColumn", e.RowIndex).Value.ToString.ToUpper
                    RemedyForm.GetField("Fax Number").Value = TheGrid.Item("FaxDataGridViewTextBoxColumn", e.RowIndex).Value.ToString.ToUpper
                    RemedyForm.GetField("Telephone").Value = TheGrid.Item("TelBDataGridViewTextBoxColumn", e.RowIndex).Value.ToString.ToUpper
                    RemedyForm.GetField("Rank").Value = TheGrid.Item("RankDataGridViewTextBoxColumn", e.RowIndex).Value.ToString.ToUpper
                    RemedyForm.GetField("VULINDLELA Role").Value = TheGrid.Item("ResponsibilityDataGridViewTextBoxColumn", e.RowIndex).Value.ToString()
                    If frmFrom = "frmResetPassword" Then
                    ElseIf frmFrom = "frmNewUsers" Then
                        If TheGrid.Item("DeptDataGridViewTextBoxColumn", e.RowIndex).Value.ToString.ToUpper.Trim <> "" Then
                            RemedyForm.GetField("Department Name").Value = TheGrid.Item("DeptDataGridViewTextBoxColumn", e.RowIndex).Value.ToString.ToUpper
                            RemedyForm.GetField("Department Type").Value = "" 'TheGrid.Item(9, e.RowIndex).Value.ToString.ToUpper
                        Else
                            wrong_department = TheGrid.Item("DeptDataGridViewTextBoxColumn", e.RowIndex).Value.ToString.ToLower
                            RemedyForm.GetField("Department Name").Value = TheGrid.Item("DeptDataGridViewTextBoxColumn", e.RowIndex).Value.ToString.ToLower
                            RemedyForm.GetField("Department Type").Value = ""
                        End If
                    End If
                End If

            Else
                If MsgBox("User Not Found! Do you want to populate the values into Remedy?", MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "System Message") = MsgBoxResult.Yes Then
                    RemedyForm = a.OpenForm(0, My.Settings.RemedyServerName.Trim, "LOG_DM_Customer Information", ARUSER.OpenMode.ARSubmit, 1)
                    If TheGrid.Item("PersalNrDataGridViewTextBoxColumn", e.RowIndex).Value.ToString.ToUpper.Trim.Length = 8 Then
                        RemedyForm.GetField("Persal Number").Value = TheGrid.Item("PersalNrDataGridViewTextBoxColumn", e.RowIndex).Value.ToString.ToUpper
                    End If
                    RemedyForm.GetField("Last Name").Value = StrConv(TheGrid.Item("SurnameDataGridViewTextBoxColumn", e.RowIndex).Value.ToString, VbStrConv.ProperCase)
                    RemedyForm.GetField("First Name").Value = StrConv(TheGrid.Item("FirstnameDataGridViewTextBoxColumn", e.RowIndex).Value.ToString, VbStrConv.ProperCase)
                    RemedyForm.GetField("E-Mail").Value = TheGrid.Item("EMailDataGridViewTextBoxColumn", e.RowIndex).Value.ToString.ToLower
                    RemedyForm.GetField("Cellphone").Value = TheGrid.Item("CellDataGridViewTextBoxColumn", e.RowIndex).Value.ToString.ToUpper
                    RemedyForm.GetField("Fax Number").Value = TheGrid.Item("FaxDataGridViewTextBoxColumn", e.RowIndex).Value.ToString.ToUpper
                    RemedyForm.GetField("Telephone").Value = TheGrid.Item("TelBDataGridViewTextBoxColumn", e.RowIndex).Value.ToString.ToUpper
                    RemedyForm.GetField("Rank").Value = TheGrid.Item("RankDataGridViewTextBoxColumn", e.RowIndex).Value.ToString.ToUpper
                    RemedyForm.GetField("VULINDLELA Role").Value = TheGrid.Item("ResponsibilityDataGridViewTextBoxColumn", e.RowIndex).Value.ToString()
                    RemedyForm.GetField("Title").Value = TheGrid.Item("TitleDataGridViewTextBoxColumn", e.RowIndex).Value.ToString.ToUpper
                    If frmFrom = "frmResetPassword" Then
                    ElseIf frmFrom = "frmNewUsers" Then
                        If TheGrid.Item("DeptDataGridViewTextBoxColumn", e.RowIndex).Value.ToString.ToUpper.Trim <> "" Then
                            RemedyForm.GetField("Department Name").Value = TheGrid.Item("DeptDataGridViewTextBoxColumn", e.RowIndex).Value.ToString.ToUpper
                            RemedyForm.GetField("Department Type").Value = "" 'TheGrid.Item(9, e.RowIndex).Value.ToString.ToUpper
                        Else
                            wrong_department = TheGrid.Item("DeptDataGridViewTextBoxColumn", e.RowIndex).Value.ToString.ToLower
                            RemedyForm.GetField("Department Name").Value = TheGrid.Item("DeptDataGridViewTextBoxColumn", e.RowIndex).Value.ToString.ToLower
                            RemedyForm.GetField("Department Type").Value = ""
                        End If
                    End If
                    'RemedyForm = a.LoadForm(SessionID, My.Settings.RemedyServerName.Trim, "LOG_DM_Customer Information", MyEntryID, ARUSER.OpenMode.ARDisplay, True)
                End If
            End If
            If persalnumber.ToString.Trim.Length = 13 Then
                Tnumber = InputBox("Please supply the newly created temporary Remedy persal number", "Input Required", "").ToUpper
                persalnumber = Tnumber
            End If

            If frmEnvironment.ChildFormPRD.Visible Then
                With frmEnvironment.ChildFormPRD
                    .txtPersalNumber.Text = persalnumber
                    .btnActiveDirectory_Click(sender, e)
                    .txtPersalNumber.Focus()
                    .txtPersalNumber.SelectAll()
                    .timerCOUNTS.Start()
                End With
            Else
                With frmEnvironment.childformQA
                    .txtPersalNumber.Text = persalnumber
                    .btnActiveDirectory_Click(sender, e)
                    .txtPersalNumber.Focus()
                    .txtPersalNumber.SelectAll()
                    .timerCOUNTS.Start()
                End With
            End If

        Catch ex As Exception
            If Err.Number = -2147216287 Then
                MsgBox("An internal error occured plese try again", MsgBoxStyle.Critical)
                If frmEnvironment.ChildFormPRD.Visible Then
                    frmEnvironment.ChildFormPRD.timerCOUNTS.Start()
                Else
                    frmEnvironment.childformQA.timerCOUNTS.Start()
                End If
                Exit Sub
            End If
        End Try
        If frmEnvironment.ChildFormPRD.Visible Then
            frmEnvironment.ChildFormPRD.timerCOUNTS.Start()
        Else
            frmEnvironment.childformQA.timerCOUNTS.Start()
        End If
        frmEnvironment.WindowState = FormWindowState.Minimized
    End Sub

    ''' <summary>
    ''' Open a form in an already running BMC Remedy Windows Administrator Tool
    ''' </summary>
    ''' <param name="sessionId">Name of the server</param>
    ''' <param name="server">The name of the server on which to open the form.</param>
    ''' <param name="form">The name of the form to open</param>
    ''' <param name="mode">Name of the server</param>
    ''' <param name="visible">object to open</param>

    Public Sub OpenRemedyCustomer2(ByRef TheGrid As DataGridView, ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs, ByVal eOpenMode As ARUSER.OpenMode, ByVal frmFrom As String)

        'System.Windows.Forms.DataGridViewCellEventArgs

        Dim i As Integer
        Dim MyEntryID As String
        Dim a As ARUSER.COMAppObj
        Dim RemedyProcess As Process
        Dim SessionID As VariantType
        Dim RemedyForm As ARUSER.ICOMFormWnd
        Dim MyResultForm As ARUSER.COMQueryResult
        Dim RemedyQueryObject As ARUSER.ICOMQueryResultSet
        Dim RemedyProcesses() As Process = Process.GetProcessesByName("ARUSER")

        wrong_department = ""

        If frmEnvironment.ChildFormPRD.Visible Then
            frmEnvironment.ChildFormPRD.timerCOUNTS.Stop()
        Else
            frmEnvironment.childformQA.timerCOUNTS.Stop()
        End If
        a = New ARUSER.COMAppObj

        Try
            RemedyForm = a.OpenForm(0, My.Settings.RemedyServerName.Trim, "LOG_DM_Customer Information", ARUSER.OpenMode.ARQuery, False)
        Catch ex1 As Exception
            If Err.Number = -2147216284 Then
                For Each RemedyProcess In RemedyProcesses
                    RemedyProcess.Kill()
                Next
            End If
            If Err.Number = -2147216287 Or Err.Number = -2147023174 Then
                For i = 1 To 3
                    userid = InputBox("Please enter your Remedy User ID Please?", "System Message", "T0005221")
                    'userid = InputBox("Please enter your Remedy User ID Please?", "System Message", "Ronel.Ilsley")
                    pwd = InputBox("Enter your password please", "System Message", "logik007")
                    'pwd = InputBox("Enter your password please", "System Message", "        ")
                    If userid = "" Or pwd = "" Then
                        MsgBox("You did not enter valid values", MsgBoxStyle.OkOnly)
                        If frmEnvironment.ChildFormPRD.Visible Then
                            frmEnvironment.ChildFormPRD.timerCOUNTS.Start()
                        Else
                            frmEnvironment.childformQA.timerCOUNTS.Start()
                        End If
                        Exit Sub
                    End If
                    SessionID = a.Login(userid.ToString, pwd, False)
                    If Err.Number = -2147467259 Then
                        a.Logout(0)
                        a = Nothing
                        MsgBox(Err.Description)
                    Else
                        Exit For
                    End If
                Next
            End If
        End Try

        Dim persalnumber As String
        persalnumber = Replace(TheGrid.Item("Persalnr", e.RowIndex).Value.ToString.ToUpper, "P", "")
        persalnumber = Replace(persalnumber, "p", "")

        Try
            RemedyForm = a.OpenForm(0, My.Settings.RemedyServerName.Trim, "LOG_DM_Customer Information", ARUSER.OpenMode.ARQuery, False)
            RemedyForm.GetField("Persal Number").Value = persalnumber.Trim
            RemedyQueryObject = RemedyForm.Query("")
            If RemedyQueryObject.Count > 0 Then
                MyResultForm = RemedyQueryObject.Item(1)
                MyEntryID = MyResultForm.entryId
                RemedyForm = a.LoadForm(0, My.Settings.RemedyServerName.Trim, "LOG_DM_Customer Information", MyEntryID, eOpenMode, True)

                If eOpenMode = ARUSER.OpenMode.ARModify Then
                    RemedyForm.GetField("Last Name").Value = StrConv(TheGrid.Item("Surname", e.RowIndex).Value.ToString, VbStrConv.ProperCase)
                    RemedyForm.GetField("First Name").Value = StrConv(TheGrid.Item("Firstname", e.RowIndex).Value.ToString, VbStrConv.ProperCase)
                    RemedyForm.GetField("E-Mail").Value = TheGrid.Item("EMail", e.RowIndex).Value.ToString.ToLower
                    RemedyForm.GetField("Cellphone").Value = TheGrid.Item("Cell", e.RowIndex).Value.ToString.ToUpper
                    RemedyForm.GetField("Fax Number").Value = TheGrid.Item("Fax", e.RowIndex).Value.ToString.ToUpper
                    RemedyForm.GetField("Telephone").Value = TheGrid.Item("TelB", e.RowIndex).Value.ToString.ToUpper
                    RemedyForm.GetField("Rank").Value = TheGrid.Item("Rank", e.RowIndex).Value.ToString.ToUpper
                    RemedyForm.GetField("VULINDLELA Role").Value = TheGrid.Item("Responsibility", e.RowIndex).Value.ToString()

                    If TheGrid.Item("Dept", e.RowIndex).Value.ToString.ToUpper.Trim <> "" Then
                        RemedyForm.GetField("Department Name").Value = TheGrid.Item("Dept", e.RowIndex).Value.ToString.ToUpper
                        RemedyForm.GetField("Department Type").Value = TheGrid.Item("Province", e.RowIndex).Value.ToString.ToUpper
                    Else
                        wrong_department = TheGrid.Item("DEPARTMENT", e.RowIndex).Value.ToString.ToLower
                        RemedyForm.GetField("Department Name").Value = TheGrid.Item("DEPARTMENT", e.RowIndex).Value.ToString.ToLower
                        RemedyForm.GetField("Department Type").Value = ""
                    End If

                End If

            Else

                If MsgBox("User Not Found! Do you want to populate the values into Remedy?", _
                          MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, _
                          "System Message") = MsgBoxResult.Yes Then

                    RemedyForm = a.OpenForm(0, My.Settings.RemedyServerName.Trim, "LOG_DM_Customer Information", ARUSER.OpenMode.ARSubmit, 1)

                    If TheGrid.Item("Persalnr", e.RowIndex).Value.ToString.ToUpper.Trim.Length = 8 Then
                        RemedyForm.GetField("Persal Number").Value = TheGrid.Item("Persalnr", e.RowIndex).Value.ToString.ToUpper
                    End If

                    RemedyForm.GetField("Last Name").Value = StrConv(TheGrid.Item("Surname", e.RowIndex).Value.ToString, VbStrConv.ProperCase)
                    RemedyForm.GetField("First Name").Value = StrConv(TheGrid.Item("Firstname", e.RowIndex).Value.ToString, VbStrConv.ProperCase)
                    RemedyForm.GetField("E-Mail").Value = TheGrid.Item("EMail", e.RowIndex).Value.ToString.ToLower
                    RemedyForm.GetField("Cellphone").Value = TheGrid.Item("Cell", e.RowIndex).Value.ToString.ToUpper
                    RemedyForm.GetField("Fax Number").Value = TheGrid.Item("Fax", e.RowIndex).Value.ToString.ToUpper
                    RemedyForm.GetField("Telephone").Value = TheGrid.Item("TelB", e.RowIndex).Value.ToString.ToUpper
                    RemedyForm.GetField("Rank").Value = TheGrid.Item("Rank", e.RowIndex).Value.ToString.ToUpper
                    RemedyForm.GetField("VULINDLELA Role").Value = TheGrid.Item("Responsibility", e.RowIndex).Value.ToString()
                    RemedyForm.GetField("Title").Value = TheGrid.Item("Title", e.RowIndex).Value.ToString.ToUpper

                    If frmFrom = "frmResetPassword" Then
                    ElseIf frmFrom = "frmNewUsers" Then
                        If TheGrid.Item("Dept", e.RowIndex).Value.ToString.ToUpper.Trim <> "" Then
                            RemedyForm.GetField("Department Name").Value = TheGrid.Item("Dept", e.RowIndex).Value.ToString.ToUpper
                            RemedyForm.GetField("Department Type").Value = TheGrid.Item("Province", e.RowIndex).Value.ToString.ToUpper
                        Else
                            wrong_department = TheGrid.Item("DEPARTMENT", e.RowIndex).Value.ToString.ToLower
                            RemedyForm.GetField("Department Name").Value = TheGrid.Item("DEPARTMENT", e.RowIndex).Value.ToString.ToLower
                            RemedyForm.GetField("Department Type").Value = ""
                        End If
                    End If
                End If
            End If

            If persalnumber.ToString.Trim.Length = 13 Then
                Tnumber = InputBox("Please supply the newly created temporary Remedy persal number", "Input Required", "").ToUpper
                persalnumber = Tnumber
            End If

            If frmEnvironment.ChildFormPRD.Visible Then
                With frmEnvironment.ChildFormPRD
                    .txtPersalNumber.Text = persalnumber
                    .btnActiveDirectory_Click(sender, e)
                    .txtPersalNumber.Focus()
                    .txtPersalNumber.SelectAll()
                    .timerCOUNTS.Start()
                End With
                'Else
                With frmEnvironment.childformQA
                    .txtPersalNumber.Text = persalnumber
                    .btnActiveDirectory_Click(sender, e)
                    .txtPersalNumber.Focus()
                    .txtPersalNumber.SelectAll()
                    .timerCOUNTS.Start()
                End With
            End If

        Catch ex As Exception
            If Err.Number = -2147216287 Then
                MsgBox("An internal error occured please try again", MsgBoxStyle.Critical)
                If frmEnvironment.ChildFormPRD.Visible Then
                    frmEnvironment.ChildFormPRD.timerCOUNTS.Start()
                Else
                    frmEnvironment.childformQA.timerCOUNTS.Start()
                End If
                Exit Sub
            Else
                'MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.RetryCancel, "Remedy System Message")
                Exit Sub
            End If
        End Try
        If frmEnvironment.ChildFormPRD.Visible Then
            frmEnvironment.ChildFormPRD.timerCOUNTS.Start()
        Else
            frmEnvironment.childformQA.timerCOUNTS.Start()
        End If
        frmEnvironment.WindowState = FormWindowState.Minimized
    End Sub

    'Public Sub ChangeRemedyRequestStatus(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs, ByVal eOpenMode As ARUSER.OpenMode, ByVal frmFrom As String)
    'End Sub

    Public Function AppPath() As String
        'AppPath = System.IO.Path.GetFullPath("..\")
        ' Dis nou 'n baie elegante luigat manier om dit te doen
        AppPath = ExePath() & "\"
    End Function

    Public Function ExePath() As String
        ExePath = System.IO.Path.GetFullPath(".")
    End Function

    Public Function file2str(ByVal PathAndFilename As String) As String

        Try
            ' Create an instance of StreamReader to read from a file.
            Using sr As StreamReader = New StreamReader(PathAndFilename)

                ' Read in the entire file
                file2str = sr.ReadToEnd()
                sr.Close()
            End Using
        Catch E As Exception
            ' Do nothing in case of an error
        End Try

    End Function

    Public Function file2stream(ByVal PathAndFilename As String) As StreamReader

        Try
            Dim sr As StreamReader = New StreamReader(PathAndFilename)
            ' Create an instance of StreamReader to read from a file.
            'Using sr As StreamReader = New StreamReader(PathAndFilename)

            ' Read in the entire file
            file2stream = sr
            sr.Close()
            'End Using
        Catch E As Exception
            ' Do nothing in case of an error
        End Try

    End Function

    Public Function IsValidEmail(ByVal strIn As String) As Boolean
        ' Return true if strIn is in valid e-mail format.
        Return Regex.IsMatch(strIn, _
               "^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))" + _
               "(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$")
    End Function

End Module
