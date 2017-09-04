Imports System

Namespace Westwind.Utilities.Configuration
	Public Interface IConfigurationProvider
		Property ErrorMessage() As String

		Property PropertiesToEncrypt() As String

		Property EncryptionKey() As String

		Property ConfigurationSection() As String

		Function Read(Of T As{AppConfiguration, New})() As T

		Function Read(config As AppConfiguration) As Boolean

		Function Read(Of T As{AppConfiguration, New})(xml As String) As T

		Function Read(config As AppConfiguration, xml As String) As Boolean

		Function Write(config As AppConfiguration) As Boolean

		Function WriteAsString(config As AppConfiguration) As String

		Sub EncryptFields(config As AppConfiguration)

		Sub DecryptFields(config As AppConfiguration)
	End Interface
End Namespace
