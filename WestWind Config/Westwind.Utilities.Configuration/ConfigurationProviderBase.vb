Imports System
Imports System.Reflection
Imports Westwind.Utilities.Configuration.Properties

Namespace Westwind.Utilities.Configuration
	Public MustInherit Class ConfigurationProviderBase
		Implements IConfigurationProvider

		Private _ErrorMessage As String = String.Empty

		Private _PropertiesToEncrypt As String = String.Empty

		Private _EncryptionKey As String = "x@3|zg?4%ui*"

		Public Overridable Property ErrorMessage() As String
			Get
				Return Me._ErrorMessage
			End Get
			Set(value As String)
				Me._ErrorMessage = value
			End Set
		End Property

		Public Overridable Property PropertiesToEncrypt() As String
			Get
				Return Me._PropertiesToEncrypt
			End Get
			Set(value As String)
				Me._PropertiesToEncrypt = value
			End Set
		End Property

		Public Overridable Property EncryptionKey() As String
			Get
				Return Me._EncryptionKey
			End Get
			Set(value As String)
				Me._EncryptionKey = value
			End Set
		End Property

		Public Property ConfigurationSection() As String

		Public MustOverride Function Read(Of T As{AppConfiguration, New})() As T

		Public MustOverride Function Read(config As AppConfiguration) As Boolean

		Public MustOverride Function Write(config As AppConfiguration) As Boolean

		Public Overridable Function Read(Of T As{AppConfiguration, New})(xml As String) As T
			If String.IsNullOrEmpty(xml) Then
				Return Nothing
			End If
			Dim t As T
			Try
				t = (TryCast(SerializationUtils.DeSerializeObject(xml, GetType(T)), T))
			Catch [error] As Exception
				Me.SetError([error])
				Return Nothing
			End Try
			If t IsNot Nothing Then
				Me.DecryptFields(t)
			End If
			Return t
		End Function

		Public Overridable Function Read(config As AppConfiguration, xml As String) As Boolean
			Dim tAppConfiguration As TAppConfiguration = Nothing
			If String.IsNullOrEmpty(xml) Then
				Return True
			End If
			Try
				tAppConfiguration = (TryCast(SerializationUtils.DeSerializeObject(xml, config.[GetType]()), TAppConfiguration))
				If tAppConfiguration Is Nothing Then
					Me.SetError(Resources.ObjectCouldNotBeDeserializedFromXml)
					Dim result As Boolean = False
					Return result
				End If
			Catch [error] As Exception
				Me.SetError([error])
				Dim result As Boolean = False
				Return result
			End Try
			If tAppConfiguration IsNot Nothing Then
				Me.DecryptFields(tAppConfiguration)
				DataUtils.CopyObjectData(tAppConfiguration, config, "Provider,ErrorMessage")
				Return True
			End If
			Return False
		End Function

		Public Overridable Function WriteAsString(config As AppConfiguration) As String
			Dim empty As String = String.Empty
			Me.EncryptFields(config)
			Try
				SerializationUtils.SerializeObject(config, empty, True)
			Catch [error] As Exception
				Me.SetError([error])
				Return String.Empty
			Finally
				Me.DecryptFields(config)
			End Try
			Return empty
		End Function

		Public Overridable Sub EncryptFields(config As AppConfiguration)
			If String.IsNullOrEmpty(Me.PropertiesToEncrypt) Then
				Return
			End If
			Dim array As MemberInfo() = config.[GetType]().FindMembers(MemberTypes.Field Or MemberTypes.[Property], BindingFlags.IgnoreCase Or BindingFlags.Instance Or BindingFlags.[Static] Or BindingFlags.[Public] Or BindingFlags.NonPublic, Nothing, Nothing)
			Dim text As String = "," + Me.PropertiesToEncrypt.ToLower() + ","
			Dim array2 As MemberInfo() = array
			For i As Integer = 0 To array2.Length - 1
				Dim memberInfo As MemberInfo = array2(i)
				Dim str As String = memberInfo.Name.ToLower()
				If text.Contains("," + str + ",") Then
					Dim obj As Object = String.Empty
					If memberInfo.MemberType = MemberTypes.Field Then
						obj = (CType(memberInfo, FieldInfo)).GetValue(config)
					Else
						obj = (CType(memberInfo, PropertyInfo)).GetValue(config, Nothing)
					End If
					If obj IsNot Nothing AndAlso TypeOf obj Is String Then
						Dim text2 As String = TryCast(obj, String)
						If Not String.IsNullOrEmpty(text2) Then
							obj = Encryption.EncryptString(text2, Me.EncryptionKey)
							If memberInfo.MemberType = MemberTypes.Field Then
								(CType(memberInfo, FieldInfo)).SetValue(config, obj)
							Else
								(CType(memberInfo, PropertyInfo)).SetValue(config, obj, Nothing)
							End If
						End If
					End If
				End If
			Next
		End Sub

		Public Overridable Sub DecryptFields(config As AppConfiguration)
			If String.IsNullOrEmpty(Me.PropertiesToEncrypt) Then
				Return
			End If
			Dim array As MemberInfo() = config.[GetType]().FindMembers(MemberTypes.Field Or MemberTypes.[Property], BindingFlags.IgnoreCase Or BindingFlags.Instance Or BindingFlags.[Static] Or BindingFlags.[Public] Or BindingFlags.NonPublic, Nothing, Nothing)
			Dim text As String = "," + Me.PropertiesToEncrypt.ToLower() + ","
			Dim array2 As MemberInfo() = array
			For i As Integer = 0 To array2.Length - 1
				Dim memberInfo As MemberInfo = array2(i)
				Dim str As String = memberInfo.Name.ToLower()
				If text.IndexOf("," + str + ",") > -1 Then
					Dim obj As Object = String.Empty
					If memberInfo.MemberType = MemberTypes.Field Then
						obj = (CType(memberInfo, FieldInfo)).GetValue(config)
					Else
						obj = (CType(memberInfo, PropertyInfo)).GetValue(config, Nothing)
					End If
					obj = Encryption.DecryptString(CStr(obj), Me.EncryptionKey)
					If memberInfo.MemberType = MemberTypes.Field Then
						(CType(memberInfo, FieldInfo)).SetValue(config, obj)
					Else
						(CType(memberInfo, PropertyInfo)).SetValue(config, obj, Nothing)
					End If
				End If
			Next
		End Sub

		Protected Overridable Sub SetError(message As String)
			If String.IsNullOrEmpty(message) Then
				Me.ErrorMessage = String.Empty
				Return
			End If
			Me.ErrorMessage = message
		End Sub

		Protected Overridable Sub SetError(ex As Exception)
			Dim text As String = ex.Message
			If ex.InnerException IsNot Nothing Then
				text = text + " " + ex.InnerException.Message
			End If
			Me.SetError(text)
		End Sub

		Protected Function CreateConfigurationInstance() As TAppConfiguration
			Return TryCast(Activator.CreateInstance(GetType(TAppConfiguration)), TAppConfiguration)
		End Function
	End Class
End Namespace
