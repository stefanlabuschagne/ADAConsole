Imports System
Imports System.IO
Imports System.Net.Mail
Imports Microsoft.VisualBasic

Module modMailMerge

    Public Function ParseFile_Email_Batch(ByVal TemplateFilePath As String, _
                      ByVal FieldAndValues As Collection, ByVal colTO As Collection, _
                      ByVal colCC As Collection, _
                      ByVal returnaddress As String, ByVal persalnumber As String, Optional ByVal subject As String = "") As String

        Dim t As TextReader
        Dim i As Integer, j As Integer, a() As String, fil As String
        Dim EmailMessage As MailMessage = New MailMessage
        Dim thisusername As String
        thisusername = Get_ValidUsername(persalnumber)

        t = New StreamReader(AppPath() & TemplateFilePath)
        fil = t.ReadToEnd
        t.Close()
        t.Dispose()

        For i = 1 To FieldAndValues.Count
            a = Split(FieldAndValues.Item(i), "~~")
            For j = 0 To UBound(a)
                If j Mod 2 = 0 Then
                    fil = Replace(fil, "[[" & a(j) & "]]", a(j + 1))
                End If
            Next
        Next i

        If colTO.Count > 0 Then
            For i = 1 To colTO.Count
                EmailMessage.To.Add(colTO(i).ToString.Trim)
            Next
        End If
        If colCC.Count > 0 Then
            For i = 1 To colCC.Count
                EmailMessage.CC.Add(colCC(i).ToString.Trim)
            Next
        End If

        EmailMessage.From = New MailAddress(returnaddress)
        If subject.Trim = "" Then
            EmailMessage.Subject = Replace(TemplateFilePath, ".htt", "") & " : " & thisusername.Trim
        Else
            EmailMessage.Subject = subject
        End If
        EmailMessage.Body = fil
        EmailMessage.Priority = MailPriority.High
        EmailMessage.IsBodyHtml = True

        Dim smtp As New SmtpClient(My.Settings.SMPTServerIPAddress.Trim)
        smtp.Send(EmailMessage)
        smtp = Nothing


    End Function

    Public Function ParseFile_Email(ByVal TemplateFilePath As String, _
                          ByVal FieldAndValues As Collection, ByVal colTO As Collection, _
                          ByVal colCC As Collection, _
                          ByVal returnaddress As String, Optional ByVal subject As String = "") As String

        Dim t As TextReader
        Dim i As Integer, j As Integer, a() As String, fil As String
        Dim EmailMessage As MailMessage = New MailMessage
        Dim thisusername As String
        Dim apppath As String
        If frmEnvironment.ChildFormPRD.Visible Then
            thisusername = Get_ValidUsername(frmEnvironment.ChildFormPRD.txtPersalNumber.Text.Trim.ToUpper)
        Else
            thisusername = Get_ValidUsername(frmEnvironment.childformQA.txtPersalNumber.Text.Trim.ToUpper)
        End If

        t = New StreamReader(apppath & TemplateFilePath)
        fil = t.ReadToEnd
        t.Close()
        t.Dispose()

        For i = 1 To FieldAndValues.Count
            a = Split(FieldAndValues.Item(i), "~~")
            For j = 0 To UBound(a)
                If j Mod 2 = 0 Then
                    fil = Replace(fil, "[[" & a(j) & "]]", a(j + 1))
                End If
            Next
        Next i

        If colTO.Count > 0 Then
            For i = 1 To colTO.Count
                EmailMessage.To.Add(colTO(i).ToString.Trim)
            Next
        End If

        If colCC.Count > 0 Then
            For i = 1 To colCC.Count
                EmailMessage.CC.Add(colCC(i).ToString.Trim)
            Next
        End If

        EmailMessage.From = New MailAddress(returnaddress)
        If subject.Trim = "" Then
            EmailMessage.Subject = Replace(TemplateFilePath, ".htt", "") & " : " & thisusername.Trim
        Else
            EmailMessage.Subject = subject
        End If
        EmailMessage.Body = fil
        EmailMessage.Priority = MailPriority.High
        EmailMessage.IsBodyHtml = True
        'Dim htmlView As AlternateView = AlternateView.CreateAlternateViewFromString("<img src=cid:ntlogo>", Nothing, "text/html")
        Dim htmlView As AlternateView = AlternateView.CreateAlternateViewFromString(EmailMessage.Body, Nothing, "text/html")
        AppPath = System.AppDomain.CurrentDomain.BaseDirectory
        Dim logo As New LinkedResource(apppath & "NTlogo.jpg")
        Dim explain As New LinkedResource(apppath & "ResetPassAnnotate.jpg")
        logo.ContentId = "ntlogo"
        explain.ContentId = "ntexplain"
        htmlView.LinkedResources.Add(logo)
        htmlView.LinkedResources.Add(explain)
        EmailMessage.AlternateViews.Add(htmlView)

        Dim smtp As New SmtpClient(My.Settings.SMPTServerIPAddress.Trim)
        smtp.Send(EmailMessage)

        smtp = Nothing
        logo = Nothing
        explain = Nothing

    End Function

    Public Sub EmbedImages()
        'create the mail message
        Dim mail As New MailMessage()

        'set the addresses
        mail.From = New MailAddress("me@mycompany.com")
        mail.To.Add("you@yourcompany.com")

        'set the content
        mail.Subject = "This is an email"

        'first we create the Plain Text part
        Dim plainView As AlternateView = AlternateView.CreateAlternateViewFromString("This is my plain text content, viewable by those clients that don't support html", Nothing, "text/plain")

        'then we create the Html part
        'to embed images, we need to use the prefix 'cid' in the img src value
        'the cid value will map to the Content-Id of a Linked resource.
        'thus <img src='cid:companylogo'> will map to a LinkedResource with a ContentId of 'companylogo'
        Dim htmlView As AlternateView = AlternateView.CreateAlternateViewFromString("Here is an embedded image.<img src=cid:companylogo>", Nothing, "text/html")

        'create the LinkedResource (embedded image)
        Dim logo As New LinkedResource("c:\temp\logo.gif")
        logo.ContentId = "companylogo"
        'add the LinkedResource to the appropriate view
        htmlView.LinkedResources.Add(logo)

        'add the views
        mail.AlternateViews.Add(plainView)
        mail.AlternateViews.Add(htmlView)


        'send the message
        Dim smtp As New SmtpClient("127.0.0.1") 'specify the mail server address
        smtp.Send(mail)
    End Sub 'EmbedImages

    Public Function ParseFile_EMail_To_Verify_Against_Establishment(ByVal TemplateFilePath As String, _
                          ByVal FieldAndValues As Collection) As String

        Dim t As TextReader
        Dim i As Integer, j As Integer, a() As String, fil As String
        Dim EmailMessage As MailMessage = New MailMessage
        Dim thisusername As String
        If frmEnvironment.ChildFormPRD.Visible Then
            thisusername = Get_ValidUsername(frmEnvironment.ChildFormPRD.txtPersalNumber.Text.Trim.ToUpper)
        Else
            thisusername = Get_ValidUsername(frmEnvironment.childformQA.txtPersalNumber.Text.Trim.ToUpper)
        End If

        ' This portion is used to merge the HTT file into HTML format
        t = New StreamReader(TemplateFilePath)
        fil = t.ReadToEnd
        t.Close()
        t.Dispose()

        For i = 1 To FieldAndValues.Count
            a = Split(FieldAndValues.Item(i), "=")
            For j = 0 To UBound(a)
                If j Mod 2 = 0 Then
                    fil = Replace(fil, "[[" & a(j) & "]]", a(j + 1))
                End If
            Next
        Next i

        ' This portion is used to merge the [1.email.addresses] file 
        ' to be used in a collection for the addresses
        Dim k As TextReader = New StreamReader(AppPath() & "EMail To Verify Against Establishment.email.addresses")

        'b1 - Posistion the pointer after the first line in the file
        Dim b1() As String
        b1 = Split(k.ReadLine, ";")
        For i = 0 To UBound(b1)
            EmailMessage.To.Add(b1(i))
        Next

        'b2 - Carbon Copy 
        Dim b2() As String
        b2 = Split(k.ReadLine, ";")
        For i = 0 To UBound(b2)
            EmailMessage.CC.Add(b2(i))
        Next

        'b3 - ReturnMailAddress 
        Dim b3 As String
        b3 = k.ReadLine
        EmailMessage.From = New MailAddress(b3)

        'b4 - Subject line
        Dim b4 As String
        b4 = k.ReadLine
        EmailMessage.Subject = b4 & " : " & thisusername.Trim
        EmailMessage.Body = fil
        EmailMessage.Priority = MailPriority.High
        EmailMessage.IsBodyHtml = True
        Dim smtp As New SmtpClient(My.Settings.SMPTServerIPAddress.Trim)
        smtp.Send(EmailMessage)
        smtp = Nothing
        k.Dispose()

    End Function

    Public Function ParseFile_Vulindlela_User_Account_Reset(ByVal TemplateFilePath As String, _
                              ByVal FieldAndValues As Collection) As String

        Dim t As TextReader
        Dim i As Integer, j As Integer, a() As String, fil As String
        Dim EmailMessage As MailMessage = New MailMessage
        Dim thisusername As String
        If frmEnvironment.ChildFormPRD.Visible Then
            thisusername = Get_ValidUsername(frmEnvironment.ChildFormPRD.txtPersalNumber.Text.Trim.ToUpper)
        Else
            thisusername = Get_ValidUsername(frmEnvironment.childformQA.txtPersalNumber.Text.Trim.ToUpper)
        End If

        ' This portion is used to merge the HTT file into HTML format
        t = New StreamReader(TemplateFilePath)
        fil = t.ReadToEnd
        t.Close()
        t.Dispose()

        For i = 1 To FieldAndValues.Count
            a = Split(FieldAndValues.Item(i), "=")
            For j = 0 To UBound(a)
                If j Mod 2 = 0 Then
                    fil = Replace(fil, "[[" & a(j) & "]]", a(j + 1))
                End If
            Next
        Next i

        ' This portion is used to merge the [1.email.addresses] file 
        ' to be used in a collection for the addresses
        Dim k As TextReader = New StreamReader(AppPath() & "Vulindlela User Account Reset.email.addresses")

        'Posistion the pointer after the first line in the file
        k.ReadLine()
        ' Gets the value from FieldAndValues that gets passed here
        EmailMessage.To.Add(Replace(FieldAndValues(3), "EMail_Address=", ""))

        'b2 is the Carbon Copy 
        Dim b2() As String
        b2 = Split(k.ReadLine, ";")
        For i = 0 To UBound(b2)
            EmailMessage.CC.Add(b2(i))
        Next

        'b3 ReturnMailAddress 
        Dim b3 As String
        b3 = k.ReadLine
        EmailMessage.From = New MailAddress(b3)

        'b4 is the Subject line
        Dim b4 As String
        b4 = k.ReadLine
        EmailMessage.Subject = b4 & " : " & thisusername.Trim
        EmailMessage.Body = fil
        EmailMessage.Priority = MailPriority.High
        EmailMessage.IsBodyHtml = True
        Dim smtp As New SmtpClient(My.Settings.SMPTServerIPAddress.Trim)
        If MsgBox("Force a Password change as well?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "System Message") = MsgBoxResult.Yes Then
            Do_ExpirePasswordNow(thisusername)
        End If
        smtp.Send(EmailMessage)
        smtp = Nothing
        k.Dispose()

    End Function

    Public Function ParseFileAspTags(ByVal TemplateFilePath As String, _
                             ByVal FieldAndValues As Collection) As String

        Dim t As TextReader
        Dim i As Integer, j As Integer, a() As String, fil As String
        Dim EmailMessage As MailMessage = New MailMessage
        Dim fc As New Microsoft.VisualBasic.Collection
        Dim thisusername As String
        If frmEnvironment.ChildFormPRD.Visible Then
            thisusername = Get_ValidUsername(frmEnvironment.ChildFormPRD.txtPersalNumber.Text.Trim.ToUpper)
        Else
            thisusername = Get_ValidUsername(frmEnvironment.childformQA.txtPersalNumber.Text.Trim.ToUpper)
        End If

        ' This portion is used to merge the HTT file into HTML format
        t = New StreamReader(TemplateFilePath)
        fil = t.ReadToEnd
        t.Close()
        t.Dispose()

        For i = 1 To FieldAndValues.Count
            a = Split(FieldAndValues.Item(i), "=")
            For j = 0 To UBound(a)
                If j Mod 2 = 0 Then
                    fil = Replace(fil, "<%" & a(j) & "%>", a(j + 1))
                End If
            Next
        Next i

        ' This portion is used to merge the [1.email.addresses] file 
        ' to be used in a collection for the addresses
        Dim k As TextReader = New StreamReader(AppPath() & "Vulindlela User Account Reset.email.addresses")

        'Posistion the pointer after the first line in the file
        k.ReadLine()
        ' Gets the value from FieldAndValues that gets passed here
        EmailMessage.To.Add(Replace(FieldAndValues(3), "EMail_Address=", ""))

        'b2 is the Carbon Copy 
        Dim b2() As String
        b2 = Split(k.ReadLine, ";")
        For i = 0 To UBound(b2)
            EmailMessage.CC.Add(b2(i))
        Next

        'b3 ReturnMailAddress 
        Dim b3 As String
        b3 = k.ReadLine
        EmailMessage.From = New MailAddress(b3)

        'b4 is the Subject line
        Dim b4 As String
        b4 = k.ReadLine
        EmailMessage.Subject = b4 & " : " & thisusername.Trim
        EmailMessage.Body = fil
        EmailMessage.Priority = MailPriority.High
        EmailMessage.IsBodyHtml = True
        Dim smtp As New SmtpClient(My.Settings.SMPTServerIPAddress.Trim)
        If MsgBox("Force a Password change as well?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "System Message") = MsgBoxResult.Yes Then
            Do_ExpirePasswordNow(thisusername)
        End If
        smtp.Send(EmailMessage)
        smtp = Nothing
        k.Dispose()

    End Function

End Module
