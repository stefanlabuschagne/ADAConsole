'Imports System
'Imports System.Text
'Imports System.IO
'Imports System.Net.Sockets
'Imports System.Net

'Namespace System.Web.Mail2
'    Public Class SmtpMail_NOCDO
'        Public Shared SmtpServer As String
'        Private Enum SMTP_Responses As Integer
'            CONNECT_SUCCESS = 220
'            GENERIC_SUCCESS = 250
'            DATA_SUCCESS = 354
'            QUIT_SUCCESS = 221

'        End Enum

'        Public Shared Function Send(ByVal message As MailMessage) As Boolean
'            Dim lipa As IPHostEntry = Dns.Resolve(SmtpServer)
'            Dim target As New IPEndPoint(lipa.AddressList(0), 25)
'            Dim s As New Socket(target.AddressFamily, SocketType.Stream, ProtocolType.Tcp)
'            s.Connect(target)

'            If Not Check_Response(s, SMTP_Responses.CONNECT_SUCCESS) Then
'                Console.WriteLine("Server didn't respond.")
'                s.Close()
'                Return False
'            End If

'            Senddata(s, String.Format("HELO {0}" & Chr(13) & "" & Chr(10) & "", Dns.GetHostName()))
'            If Not Check_Response(s, SMTP_Responses.GENERIC_SUCCESS) Then
'                Console.WriteLine("Helo Failed!.")
'                s.Close()
'                Return False
'            End If

'            Senddata(s, String.Format("MAIL From: {0}" & Chr(13) & "" & Chr(10) & "", AddressOf message.From))
'            If Not Check_Response(s, SMTP_Responses.GENERIC_SUCCESS) Then
'                Console.WriteLine("Mail command Failed!.")
'                s.Close()
'                Return False
'            End If

'            Dim _To As String = AddressOf message.[To]
'            Dim Tos As String() = _To.Split(New Char() {";"c})
'            For Each [To] As String In Tos
'                Senddata(s, String.Format("RCPT TO: {0}" & Chr(13) & "" & Chr(10) & "", [To]))
'                If Not Check_Response(s, SMTP_Responses.GENERIC_SUCCESS) Then
'                    Console.WriteLine("RCPT command Failed ({0})!.", [To])
'                    s.Close()
'                    Return False
'                End If
'            Next

'            If AddressOf message.Cc IsNot Nothing Then
'                Tos = AddressOf message.Cc.Split(New Char() {";"c})
'                For Each [To] As String In Tos
'                    Senddata(s, String.Format("RCPT TO: {0}" & Chr(13) & "" & Chr(10) & "", [To]))
'                    If Not Check_Response(s, SMTP_Responses.GENERIC_SUCCESS) Then
'                        Console.WriteLine("RCPT command Failed ({0})!.", [To])
'                        s.Close()
'                        Return False
'                    End If
'                Next
'            End If
'            Dim Header As New StringBuilder()
'            Header.Append("From: " & AddressOf message.From & "" & Chr(13) & "" & Chr(10) & "")
'            Tos = AddressOf message.[To].Split(New Char() {";"c})
'            Header.Append("To: ")
'            For i As Integer = 0 To Tos.Length - 1
'                Header.Append(If(i > 0, ",", ""))
'                Header.Append(Tos(i))
'            Next
'            Header.Append("" & Chr(13) & "" & Chr(10) & "")
'            If AddressOf message.Cc IsNot Nothing Then
'                Tos = AddressOf message.Cc.Split(New Char() {";"c})
'                Header.Append("Cc: ")
'                For i As Integer = 0 To Tos.Length - 1
'                    Header.Append(If(i > 0, ",", ""))
'                    Header.Append(Tos(i))
'                Next
'                Header.Append("" & Chr(13) & "" & Chr(10) & "")
'            End If
'            Header.Append("Date: ")
'            Header.Append(DateTime.Now.ToString("ddd, d M y H:m:s z"))
'            Header.Append("" & Chr(13) & "" & Chr(10) & "")
'            Header.Append("Subject: " & AddressOf message.Subject & "" & Chr(13) & "" & Chr(10) & "")
'            Header.Append("X-Mailer: Narayan EMail v2" & Chr(13) & "" & Chr(10) & "")

'            Dim MsgBody As String = AddressOf message.Body
'            If Not MsgBody.EndsWith("" & Chr(13) & "" & Chr(10) & "") Then
'                MsgBody += "" & Chr(13) & "" & Chr(10) & ""
'            End If
'            If AddressOf message.Attachments.Count > 0 Then
'                Header.Append("MIME-Version: 1.0" & Chr(13) & "" & Chr(10) & "")
'                Header.Append("Content-Type: multipart/mixed; boundary=unique-boundary-1" & Chr(13) & "" & Chr(10) & "")
'                Header.Append("" & Chr(13) & "" & Chr(10) & "")
'                Header.Append("This is a multi-part message in MIME format." & Chr(13) & "" & Chr(10) & "")
'                Dim sb As New StringBuilder()
'                sb.Append("--unique-boundary-1" & Chr(13) & "" & Chr(10) & "")
'                sb.Append("Content-Type: text/plain" & Chr(13) & "" & Chr(10) & "")
'                sb.Append("Content-Transfer-Encoding: 7Bit" & Chr(13) & "" & Chr(10) & "")
'                sb.Append("" & Chr(13) & "" & Chr(10) & "")
'                sb.Append(MsgBody & "" & Chr(13) & "" & Chr(10) & "")
'                sb.Append("" & Chr(13) & "" & Chr(10) & "")

'                For Each o As Object In AddressOf message.Attachments
'                    Dim a As MailAttachment = TryCast(o, MailAttachment)
'                    Dim binaryData As Byte()
'                    If a IsNot Nothing Then
'                        Dim f As New FileInfo(a.Filename)
'                        sb.Append("--unique-boundary-1" & Chr(13) & "" & Chr(10) & "")
'                        sb.Append("Content-Type: application/octet-stream; file=" & f.Name & "" & Chr(13) & "" & Chr(10) & "")
'                        sb.Append("Content-Transfer-Encoding: base64" & Chr(13) & "" & Chr(10) & "")
'                        sb.Append("Content-Disposition: attachment; filename=" & f.Name & "" & Chr(13) & "" & Chr(10) & "")
'                        sb.Append("" & Chr(13) & "" & Chr(10) & "")
'                        Dim fs As FileStream = f.OpenRead()
'                        binaryData = New Byte(fs.Length - 1) {}
'                        Dim bytesRead As Long = fs.Read(binaryData, 0, CInt(fs.Length))
'                        fs.Close()
'                        Dim base64String As String = System.Convert.ToBase64String(binaryData, 0, binaryData.Length)

'                        Dim i As Integer = 0
'                        While i < base64String.Length
'                            Dim nextchunk As Integer = 100
'                            If base64String.Length - (i + nextchunk) < 0 Then
'                                nextchunk = base64String.Length - i
'                            End If
'                            sb.Append(base64String.Substring(i, nextchunk))
'                            sb.Append("" & Chr(13) & "" & Chr(10) & "")

'                            i += nextchunk
'                        End While

'                        sb.Append("" & Chr(13) & "" & Chr(10) & "")
'                    End If
'                Next
'                MsgBody = sb.ToString()
'            End If

'            Senddata(s, ("DATA" & Chr(13) & "" & Chr(10) & ""))
'            If Not Check_Response(s, SMTP_Responses.DATA_SUCCESS) Then
'                Console.WriteLine("Data command Failed!.")
'                s.Close()
'                Return False
'            End If
'            Header.Append("" & Chr(13) & "" & Chr(10) & "")
'            Header.Append(MsgBody)
'            Header.Append("." & Chr(13) & "" & Chr(10) & "")
'            Header.Append("" & Chr(13) & "" & Chr(10) & "")
'            Header.Append("" & Chr(13) & "" & Chr(10) & "")
'            Senddata(s, Header.ToString())
'            If Not Check_Response(s, SMTP_Responses.GENERIC_SUCCESS) Then
'                Console.WriteLine("Data command Failed!.")
'                s.Close()
'                Return False
'            End If
'            Senddata(s, "QUIT" & Chr(13) & "" & Chr(10) & "")
'            Check_Response(s, SMTP_Responses.QUIT_SUCCESS)
'            s.Close()
'            Return True
'        End Function
'        Private Shared Sub Senddata(ByVal s As Socket, ByVal msg As String)
'            '			StreamWriter sw= new FileInfo("send
'            '     .txt").AppendText();
'            '			sw.WriteLine(msg);
'            '			sw.Close();
'            '			sw=null;
'            '			GC.Collect();
'            Dim _msg As Byte() = Encoding.ASCII.GetBytes(msg)
'            s.Send(_msg, 0, _msg.Length, SocketFlags.None)
'        End Sub
'        Private Shared Function Check_Response(ByVal s As Socket, ByVal response_expected As SMTP_Responses) As Boolean
'            Dim sResponse As String
'            Dim response As Integer
'            Dim bytes As Byte() = New Byte(1023) {}
'            '			Console.WriteLine("Waiting for {0}"
'            '     , response_expected);
'            While s.Available = 0
'                System.Threading.Thread.Sleep(100)
'            End While

'            s.Receive(bytes, 0, s.Available, SocketFlags.None)
'            sResponse = Encoding.ASCII.GetString(bytes)
'            'Console.WriteLine(sResponse);
'            response = Convert.ToInt32(sResponse.Substring(0, 3))
'            If response <> CInt(response_expected) Then
'                Return False
'            End If
'            Return True
'        End Function
'    End Class
'End Namespace

