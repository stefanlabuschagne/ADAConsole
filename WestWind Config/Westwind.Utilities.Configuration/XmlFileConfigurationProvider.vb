Imports System

Namespace Westwind.Utilities.Configuration
	Public Class XmlFileConfigurationProvider
		Inherits ConfigurationProviderBase(Of TAppConfiguration)

		Private _XmlConfigurationFile As String = String.Empty

		Private _UseBinarySerialization As Boolean

		Public Property XmlConfigurationFile() As String
			Get
				Return Me._XmlConfigurationFile
			End Get
			Set(value As String)
				Me._XmlConfigurationFile = value
			End Set
		End Property

		Public Property UseBinarySerialization() As Boolean
			Get
				Return Me._UseBinarySerialization
			End Get
			Set(value As Boolean)
				Me._UseBinarySerialization = value
			End Set
		End Property

		Public Override Function Read(config As AppConfiguration) As Boolean
			Dim tAppConfiguration As TAppConfiguration = TryCast(SerializationUtils.DeSerializeObject(Me.XmlConfigurationFile, GetType(TAppConfiguration), Me.UseBinarySerialization), TAppConfiguration)
			If tAppConfiguration Is Nothing Then
				Return Me.Write(config)
			End If
			Me.DecryptFields(tAppConfiguration)
			DataUtils.CopyObjectData(tAppConfiguration, config, "Provider,ErrorMessage")
			Return True
		End Function

		Public Override Function Read(Of TAppConfig)() As TAppConfig
			Dim tAppConfig As TAppConfig = TryCast(SerializationUtils.DeSerializeObject(Me.XmlConfigurationFile, GetType(TAppConfig), Me.UseBinarySerialization), TAppConfig)
			If tAppConfig IsNot Nothing Then
				Me.DecryptFields(tAppConfig)
			End If
			Return tAppConfig
		End Function

		Public Override Function Write(config As AppConfiguration) As Boolean
			Me.EncryptFields(config)
			Dim result As Boolean = SerializationUtils.SerializeObject(config, Me.XmlConfigurationFile, Me.UseBinarySerialization)
			Me.DecryptFields(config)
			Return result
		End Function
	End Class
End Namespace
