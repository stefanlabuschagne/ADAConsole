Imports System.IO
Imports System.Security.AccessControl

Module modAccessControl

    Function AddSecurityAccessRule() As DirectorySecurity

        Dim securityRules As DirectorySecurity = New DirectorySecurity()
        securityRules.AddAccessRule(New FileSystemAccessRule(GetDomainame().Trim & "\" & GetUsername().Trim, FileSystemRights.FullControl, AccessControlType.Allow))
        Return securityRules

    End Function

    Function GetDomainame() As String

        Dim strDomain As String
        strDomain = System.Security.Principal.WindowsIdentity.GetCurrent.Name
        strDomain = Mid(strDomain, 1, InStr(strDomain, "\") - 1)
        Return strDomain

    End Function

    Function GetUsername() As String
        Return (System.Environment.UserName)
    End Function

End Module
