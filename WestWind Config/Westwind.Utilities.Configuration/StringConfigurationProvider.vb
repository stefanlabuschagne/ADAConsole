Imports System

Namespace Westwind.Utilities.Configuration
	Public Class StringConfigurationProvider
		Inherits ConfigurationProviderBase(Of TAppConfiguration)

		Public Property InitialStringData() As String

		Public Override Function Read(Of T)() As T
			Return Me.Read(Of T)(Me.InitialStringData)
		End Function

		Public Override Function Read(config As AppConfiguration) As Boolean
			Return Me.Read(config, Me.InitialStringData)
		End Function

		Public Override Function Write(config As AppConfiguration) As Boolean
			Throw New NotImplementedException()
		End Function
	End Class
End Namespace
