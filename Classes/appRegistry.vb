Imports Microsoft.Win32
Imports System
Imports System.Runtime.CompilerServices

Namespace ADAdminDotNet
	Public Class appRegistry
		Public Enum RegRoots
			HKEY_CURRENT_USER = 1
			HKEY_LOCAL_MACHINE
		End Enum

		Public Function ResolveRegRootsName(regroot As appRegistry.RegRoots) As String
			Return "HKEY_CURRENT_USER"
		End Function

		Public Function SetRegKeyValue(regRootHive As appRegistry.RegRoots, regSubKey As String, regKeyName As String, regValType As RegistryValueKind, regKeyVal As Object) As Object
			Dim keyName As String = Me.ResolveRegRootsName(regRootHive) + "\" + regSubKey
			Registry.SetValue(keyName, regKeyName, RuntimeHelpers.GetObjectValue(regKeyVal))
			Dim result As Object
			Return result
		End Function

		Public Function GetRegKeyValue(regRootHive As appRegistry.RegRoots, regSubKey As String, regKeyName As String) As Object
			Return Registry.GetValue(Me.ResolveRegRootsName(regRootHive) + "\" + regSubKey, regKeyName, "")
		End Function

		Public Function DelRegKey(regRootHive As appRegistry.RegRoots, regSubKey As String, regKeyName As String) As Object
			Registry.GetValue(Me.ResolveRegRootsName(regRootHive) + "\" + regSubKey, regKeyName, Nothing)
			Dim result As Object
			Return result
		End Function
	End Class
End Namespace
