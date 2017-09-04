Imports System

Namespace Westwind.Utilities.Configuration
	Public Class JsonFileConfigurationProvider
		Inherits ConfigurationProviderBase(Of TAppConfiguration)

		Private _JsonConfigurationFile As String = String.Empty

		Public Property JsonConfigurationFile() As String
			Get
				Return Me._JsonConfigurationFile
			End Get
			Set(value As String)
				Me._JsonConfigurationFile = value
			End Set
		End Property

		Public Override Function Read(config As AppConfiguration) As Boolean
			Dim tAppConfiguration As TAppConfiguration = TryCast(JsonSerializationUtils.DeserializeFromFile(Me.JsonConfigurationFile, GetType(TAppConfiguration), False), TAppConfiguration)
			If tAppConfiguration Is Nothing Then
				Return Me.Write(config)
			End If
			Me.DecryptFields(tAppConfiguration)
			DataUtils.CopyObjectData(tAppConfiguration, config, "Provider,ErrorMessage")
			Return True
		End Function

		Public Override Function Read(Of TAppConfig)() As TAppConfig
			Dim tAppConfig As TAppConfig = TryCast(JsonSerializationUtils.DeserializeFromFile(Me.JsonConfigurationFile, GetType(TAppConfig), False), TAppConfig)
			If tAppConfig IsNot Nothing Then
				Me.DecryptFields(tAppConfig)
			End If
			Return tAppConfig
		End Function

		Public Override Function Write(config As AppConfiguration) As Boolean
			Me.EncryptFields(config)
			Dim result As Boolean = JsonSerializationUtils.SerializeToFile(config, Me.JsonConfigurationFile, False, True)
			Me.DecryptFields(config)
			Return result
		End Function
	End Class
End Namespace
