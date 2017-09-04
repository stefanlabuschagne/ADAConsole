Imports System.IO
Imports System.Text.RegularExpressions

Public Class clsMxLookup

    Public Shared Function LookupDomainMX(ByVal DomainName As String) As String

        Dim objInfoProc As New ProcessStartInfo
        Dim objProc As Process
        Dim objStdOut As StreamReader
        Dim reg As Regex
        Dim mailserver As String
        Dim response As String = ""
        Dim amatch As Match
        Dim strDom As String()
        Dim blnDomTrouv As Boolean = False

        
        strDom = DomainName.Split("@"c)
        objInfoProc.UseShellExecute = False
        objInfoProc.RedirectStandardInput = True
        objInfoProc.RedirectStandardOutput = True
        objInfoProc.FileName = "nslookup"
        objInfoProc.Arguments = "-type=MX " + strDom(1).ToUpper.Trim
        objInfoProc.CreateNoWindow = True
        objProc = Process.Start(objInfoProc)

        objStdOut = objProc.StandardOutput
        reg = New Regex("mail exchanger = (?<server>[^\\\s]+)")

        Do While (objStdOut.Peek() > -1)
            response = objStdOut.ReadLine()
            amatch = reg.Match(response)
            If (amatch.Success) Then
                mailserver = amatch.Groups("server").Value
                blnDomTrouv = True
                Exit Do
            End If
        Loop
        Return blnDomTrouv

    End Function

    Function IsEmailAddressValid(ByVal emailAddress As String) As Boolean
        Dim valid As Boolean = True
        Try
            Dim a = New System.Net.Mail.MailAddress(emailAddress)
        Catch ex As FormatException
            valid = False
        End Try
        Return valid
    End Function



End Class
