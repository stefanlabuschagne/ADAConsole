Imports System
Imports System.Xml.Serialization

Namespace Westwind.Utilities.Configuration
	Public MustInherit Class AppConfiguration
		<XmlIgnore()>
		<NonSerialized()>
		Public Provider As IConfigurationProvider

		<XmlIgnore()>
		<NonSerialized()>
		Public ErrorMessage As String = String.Empty

		Protected InitializeCalled As Boolean

		Public Sub New()
		End Sub

		Public Sub Initialize(Optional provider As IConfigurationProvider=Nothing, Optional sectionName As String=Nothing, Optional configData As Object=Nothing)
			If Me.InitializeCalled Then
				Return
			End If
			Me.InitializeCalled = True
			If String.IsNullOrEmpty(sectionName) Then
				sectionName = MyBase.[GetType]().Name
			End If
			Me.OnInitialize(provider, sectionName, configData)
		End Sub

		Protected Overridable Sub OnInitialize(provider As IConfigurationProvider, sectionName As String, configData As Object)
			If provider Is Nothing Then
				provider = Me.OnCreateDefaultProvider(sectionName, configData)
			End If
			Me.Provider = provider
			If Not Me.Provider.Read(Me) Then
				Throw New InvalidOperationException(Me.Provider.ErrorMessage)
			End If
		End Sub

		Protected Overridable Function OnCreateDefaultProvider(sectionName As String, configData As Object) As IConfigurationProvider
			Dim typeFromHandle As Type = GetType(ConfigurationFileConfigurationProvider(Of ))
			Dim type As Type = MyBase.[GetType]()
			Dim type2 As Type = typeFromHandle.MakeGenericType(New Type()() = { type })
			Dim configurationProvider As IConfigurationProvider = TryCast(Activator.CreateInstance(type2), IConfigurationProvider)
			If Not String.IsNullOrEmpty(sectionName) Then
				configurationProvider.ConfigurationSection = sectionName
			End If
			Return configurationProvider
		End Function

		Public Overridable Function Write() As Boolean
			Me.Initialize(Nothing, Nothing, Nothing)
			If Not Me.Provider.Write(Me) Then
				Me.ErrorMessage = Me.Provider.ErrorMessage
				Return False
			End If
			Return True
		End Function

		Public Overridable Function WriteAsString() As String
			Me.Initialize(Nothing, Nothing, Nothing)
			Dim empty As String = String.Empty
			Me.Provider.EncryptFields(Me)
			SerializationUtils.SerializeObject(Me, empty)
			If Not String.IsNullOrEmpty(empty) Then
				Me.Provider.DecryptFields(Me)
			End If
			Return empty
		End Function

		Public Overridable Function Read(Of T As{AppConfiguration, New})() As T
			Me.Initialize(Nothing, Nothing, Nothing)
			Dim t As T = Me.Provider.Read(Of T)()
			If t Is Nothing Then
				Me.ErrorMessage = Me.Provider.ErrorMessage
				Return Nothing
			End If
			Return t
		End Function

		Public Overridable Function Read() As Boolean
			Me.Initialize(Nothing, Nothing, Nothing)
			If Not Me.Provider.Read(Me) Then
				Me.ErrorMessage = Me.Provider.ErrorMessage
				Return False
			End If
			Return True
		End Function

		Public Overridable Function Read(xml As String) As Boolean
			Me.Initialize(Nothing, Nothing, Nothing)
			Dim obj As Object = SerializationUtils.DeSerializeObject(xml, MyBase.[GetType]())
			DataUtils.CopyObjectData(obj, Me, "Provider,Errormessage")
			If obj IsNot Nothing Then
				Me.Provider.DecryptFields(Me)
			End If
			Return True
		End Function

		Public Shared Function Read(Of T As{AppConfiguration, New})(provider As IConfigurationProvider) As T
			Return provider.Read(Of T)()
		End Function

		Public Shared Function Read(Of T As{AppConfiguration, New})(xml As String, provider As IConfigurationProvider) As T
			Dim t As T = TryCast(SerializationUtils.DeSerializeObject(xml, GetType(T)), T)
			If t IsNot Nothing AndAlso provider IsNot Nothing Then
				provider.DecryptFields(t)
			End If
			Return t
		End Function

		Public Shared Function Read(Of T As{AppConfiguration, New})(xml As String) As T
			Return AppConfiguration.Read(Of T)(xml, Nothing)
		End Function
	End Class
End Namespace
