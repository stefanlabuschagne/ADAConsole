Imports System
Imports Microsoft.Win32

Public Class appRegistry

    Public Enum RegRoots As Integer
        HKEY_CURRENT_USER = 1
        HKEY_LOCAL_MACHINE = 2
    End Enum

    '"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Internet Settings"
    'ProxyEnable 'RegistryValueKind.DWord '1 
    'ProxyServer 'RegistryValueKind.String '"proxy.pwv.gov.za:3128" 
    'ProxyOverride 'RegistryValueKind.String '"10.131.*;10.123.45.*;*.treasury.gov.za;*.logis.gov.za" 

    Public Function ResolveRegRootsName(ByVal regroot As RegRoots) As String
        If regroot.HKEY_CURRENT_USER Then
            Return "HKEY_CURRENT_USER"
        ElseIf regroot.HKEY_LOCAL_MACHINE Then
            Return "HKEY_LOCAL_MACHINE"
        End If
    End Function

    Public Function SetRegKeyValue( _
                         ByVal regRootHive As RegRoots, _
                         ByVal regSubKey As String, _
                         ByVal regKeyName As String, _
                         ByVal regValType As RegistryValueKind, _
                         ByVal regKeyVal As Object)

        Dim myKey As String = ResolveRegRootsName(regRootHive) & "\" & regSubKey

        Registry.SetValue(myKey, regKeyName, regKeyVal)

    End Function

    Public Function GetRegKeyValue(ByVal regRootHive As RegRoots, _
                                   ByVal regSubKey As String, _
                                   ByVal regKeyName As String) As Object

        Return Registry.GetValue(ResolveRegRootsName(regRootHive) & "\" & regSubKey, regKeyName, "")

    End Function

    Public Function DelRegKey(ByVal regRootHive As RegRoots, _
                              ByVal regSubKey As String, _
                              ByVal regKeyName As String)

        Registry.GetValue(ResolveRegRootsName(regRootHive) & "\" & regSubKey, regKeyName, Nothing)

    End Function

End Class
