Imports System
Imports System.IO
Imports System.Web
Imports System.Data
Imports System.Net.Mail
Imports System.Configuration
Imports System.Data.SqlClient

Partial Class ASPXParser
    Inherits System.Web.UI.Page

    Protected Sub SubmitButton_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles SubmitButton.Click

        Dim colFields As New Microsoft.VisualBasic.Collection
        Dim NextSeminarDate As String = ConfigurationSettings.AppSettings("NextSeminarDate")
        Try
            If Not String.IsNullOrEmpty(Me.tToEmail1.Text) Then
                colFields.Add("RefererEmail~~" & tRefererEmail.Text.Trim)
                colFields.Add("RefererName~~" & tRefererName.Text.Trim)
                colFields.Add("ToName~~" & tToName1.Text.Trim)
                colFields.Add("ToEmail~~" & tToEmail1.Text.Trim)
                colFields.Add("ToPhone~~" & tToPhone1.Text.Trim)
                colFields.Add("NextSeminarDate~~" & NextSeminarDate.Trim)

                insert_Refer2Friend(Me.tRefererEmail.Text & "", _
                         Me.tRefererName.Text & "", _
                         Me.tToName1.Text & "", _
                         Me.tToEmail1.Text & "", _
                         Me.tToPhone1.Text & "")
                EmailFriend(Me.tRefererEmail.Text & "", _
                         Me.tRefererName.Text & "", _
                         Me.tToName1.Text & "", _
                         Me.tToEmail1.Text & "", _
                         colFields)
            End If

            If Not String.IsNullOrEmpty(Me.tToEmail2.Text) Then

                colFields.Clear()
                colFields.Add("RefererEmail~~" & tRefererEmail.Text.Trim)
                colFields.Add("RefererName~~" & tRefererName.Text.Trim)
                colFields.Add("ToName~~" & tToName2.Text.Trim)
                colFields.Add("ToEmail~~" & tToEmail2.Text.Trim)
                colFields.Add("ToPhone~~" & tToPhone2.Text.Trim)
                colFields.Add("NextSeminarDate~~" & NextSeminarDate.Trim)

                insert_Refer2Friend(Me.tRefererEmail.Text & "", _
                             Me.tRefererName.Text & "", _
                             Me.tToName2.Text & "", _
                             Me.tToEmail2.Text & "", _
                             Me.tToPhone2.Text & "")
                EmailFriend(Me.tRefererEmail.Text & "", _
                         Me.tRefererName.Text & "", _
                         Me.tToName2.Text & "", _
                         Me.tToEmail2.Text & "", _
                         colFields)
            End If
            If Not String.IsNullOrEmpty(Me.tToEmail3.Text) Then
                colFields.Clear()
                colFields.Add("RefererEmail~~" & tRefererEmail.Text.Trim)
                colFields.Add("RefererName~~" & tRefererName.Text.Trim)
                colFields.Add("ToName~~" & tToName3.Text.Trim)
                colFields.Add("ToEmail~~" & tToEmail3.Text.Trim)
                colFields.Add("ToPhone~~" & tToPhone3.Text.Trim)
                colFields.Add("NextSeminarDate~~" & NextSeminarDate.Trim)
                insert_Refer2Friend(Me.tRefererEmail.Text & "", _
                         Me.tRefererName.Text & "", _
                         Me.tToName3.Text & "", _
                         Me.tToEmail3.Text & "", _
                         Me.tToPhone3.Text & "")
                EmailFriend(Me.tRefererEmail.Text & "", _
                         Me.tRefererName.Text & "", _
                         Me.tToName3.Text & "", _
                         Me.tToEmail3.Text & "", _
                         colFields)
            End If
            If Not String.IsNullOrEmpty(Me.tToEmail4.Text) Then
                colFields.Clear()
                colFields.Add("RefererEmail~~" & tRefererEmail.Text.Trim)
                colFields.Add("RefererName~~" & tRefererName.Text.Trim)
                colFields.Add("ToName~~" & tToName4.Text.Trim)
                colFields.Add("ToEmail~~" & tToEmail4.Text.Trim)
                colFields.Add("ToPhone~~" & tToPhone4.Text.Trim)
                colFields.Add("NextSeminarDate~~" & NextSeminarDate.Trim)
                insert_Refer2Friend(Me.tRefererEmail.Text & "", _
                         Me.tRefererName.Text & "", _
                         Me.tToName4.Text & "", _
                         Me.tToEmail4.Text & "", _
                         Me.tToPhone4.Text & "")
                EmailFriend(Me.tRefererEmail.Text & "", _
                         Me.tRefererName.Text & "", _
                         Me.tToName4.Text & "", _
                         Me.tToEmail4.Text & "", _
                         colFields)
            End If
            If Not String.IsNullOrEmpty(Me.tToEmail5.Text) Then
                colFields.Clear()
                colFields.Add("RefererEmail~~" & tRefererEmail.Text.Trim)
                colFields.Add("RefererName~~" & tRefererName.Text.Trim)
                colFields.Add("ToName~~" & tToName5.Text.Trim)
                colFields.Add("ToEmail~~" & tToEmail5.Text.Trim)
                colFields.Add("ToPhone~~" & tToPhone5.Text.Trim)
                colFields.Add("NextSeminarDate~~" & NextSeminarDate.Trim)
                insert_Refer2Friend(Me.tRefererEmail.Text & "", _
                         Me.tRefererName.Text & "", _
                         Me.tToName5.Text & "", _
                         Me.tToEmail5.Text & "", _
                         Me.tToPhone5.Text & "")
                EmailFriend(Me.tRefererEmail.Text & "", _
                         Me.tRefererName.Text & "", _
                         Me.tToName5.Text & "", _
                         Me.tToEmail5.Text & "", _
                         colFields)
            End If
        Catch ex As Exception
            Server.Transfer("Oopsiedaizy.aspx", True)
        End Try
        colFields = Nothing
        Server.Transfer("ThanksReferral.aspx", True)
    End Sub
    Protected Sub EmailFriend(ByVal RefererEmail As String, _
                              ByVal RefererName As String, _
                              ByVal ToName As String, _
                              ByVal ToEmail As String, _
                              ByVal colFields As Microsoft.VisualBasic.Collection)

        'Die EMail waarsku die nuwe prospek
        ParseFile_Email(Server.MapPath("email_before_booking_referafriend.asp"), _
                        colFields, _
                        ToEmail.Trim, _
                        RefererEmail.Trim, _
                        ToName.Trim & ", Important")

        ' Die mail is vir myself om die lead bekend te maak
        ParseFile_Email(Server.MapPath("email_after_booking_referafriend.asp"), _
                        colFields, _
                        ConfigurationSettings.AppSettings("HostEmailAddress"), _
                        ConfigurationSettings.AppSettings("HostEmailAddress"), _
                        "Referralshelp - Lead")

    End Sub
    Protected Sub ParseFile_Email(ByVal TemplateFilePath As String, _
                           ByVal colFieldAndValues As Collection, _
                           ByVal strTO As String, _
                           ByVal returnaddress As String, _
                           ByVal subject As String)

        Dim objEmail As MailMessage

        Dim SMTP As New SmtpClient(ConfigurationSettings.AppSettings("MailServerAddress"))
        Dim basicAuthenticationInfo As New System.Net.NetworkCredential(ConfigurationSettings.AppSettings("PostMasterAddress"), ConfigurationSettings.AppSettings("PostMasterPassword"))
        SMTP.Host = ConfigurationSettings.AppSettings("MailServerAddress")
        SMTP.UseDefaultCredentials = False
        SMTP.Credentials = basicAuthenticationInfo

        objEmail = New MailMessage
        objEmail.Priority = MailPriority.High
        objEmail.IsBodyHtml = True

        Dim t As TextReader
        Dim thisusername As String
        Dim i As Integer, j As Integer, a() As String, fil As String

        thisusername = ""
        t = New StreamReader(TemplateFilePath)
        fil = t.ReadToEnd
        t.Close()
        t.Dispose()
        For i = 1 To colFieldAndValues.Count
            a = Split(colFieldAndValues.Item(i), "~~")
            For j = 0 To UBound(a)
                If j Mod 2 = 0 Then
                    fil = Replace(fil, "[[" & a(j) & "]]", a(j + 1))
                End If
            Next
        Next i
        objEmail.Priority = MailPriority.High
        objEmail.IsBodyHtml = True
        objEmail.To.Add(strTO.Trim)
        objEmail.From = New MailAddress(returnaddress)
        objEmail.Subject = subject
        objEmail.Body = fil
        Try
            SMTP.Send(objEmail)
        Catch ex As Exception
        End Try
        objEmail = Nothing
        SMTP = Nothing
        t = Nothing
    End Sub
    Protected Sub insert_Refer2Friend(ByVal RefererEmail As String, _
                                   ByVal RefererName As String, _
                                   ByVal ToName As String, _
                                   ByVal ToEmail As String, _
                                   ByVal ToPhone As String)

        Dim cn As New SqlConnection(ConfigurationSettings.AppSettings("connectionString"))
        Dim cmd As New SqlCommand("insert_Refer2Friend", cn)

        cmd.CommandType = CommandType.StoredProcedure

        Dim pRefererEmail As New SqlParameter("@RefererEmail", SqlDbType.VarChar, 150)
        pRefererEmail.Value = RefererEmail
        cmd.Parameters.Add(pRefererEmail)

        Dim pRefererName As New SqlParameter("@RefererName", SqlDbType.VarChar, 50)
        pRefererName.Value = RefererName
        cmd.Parameters.Add(pRefererName)

        Dim pToName As New SqlParameter("@ToName", SqlDbType.VarChar, 50)
        pToName.Value = ToName
        cmd.Parameters.Add(pToName)

        Dim pToEmail As New SqlParameter("@ToEmail", SqlDbType.VarChar, 150)
        pToEmail.Value = ToEmail
        cmd.Parameters.Add(pToEmail)

        Dim pToPhone As New SqlParameter("@ToPhone", SqlDbType.VarChar, 50)
        pToPhone.Value = ToPhone
        cmd.Parameters.Add(pToPhone)

        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()

    End Sub

End Class
