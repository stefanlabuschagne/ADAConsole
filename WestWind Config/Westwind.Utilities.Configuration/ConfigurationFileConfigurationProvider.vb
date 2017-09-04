Imports System
Imports System.Collections
Imports System.Collections.Specialized
Imports System.ComponentModel
Imports System.Configuration
Imports System.Globalization
Imports System.Reflection
Imports System.Xml
Imports Westwind.Utilities.Configuration.Properties

Namespace Westwind.Utilities.Configuration
	Public Class ConfigurationFileConfigurationProvider
		Inherits ConfigurationProviderBase(Of TAppConfiguration)

		Private syncWriteLock As Object = New Object()

		Private XmlNamespaces As XmlNamespaceManager

		Private XmlNamespacePrefix As String = "ww:"

		Public Property ConfigurationFile() As String

		Public Override Function Read(Of TAppConfig)() As TAppConfig
			Dim tAppConfig As TAppConfig = TryCast(Activator.CreateInstance(GetType(TAppConfig), True), TAppConfig)
			If Not Me.Read(tAppConfig) Then
				Return Nothing
			End If
			Return tAppConfig
		End Function

		Public Override Function Read(config As AppConfiguration) As Boolean
			If Not String.IsNullOrEmpty(Me.ConfigurationFile) Then
				Return Me.Read(config, Me.ConfigurationFile)
			End If
			Dim type As Type = config.[GetType]()
			Dim members As MemberInfo() = type.GetMembers(BindingFlags.Instance Or BindingFlags.[Public] Or BindingFlags.GetField Or BindingFlags.GetProperty)
			Dim flag As Boolean = False
			Dim text As String = "," + Me.PropertiesToEncrypt.ToLower() + ","
			If String.IsNullOrEmpty(MyBase.ConfigurationSection) Then
				ConfigurationManager.RefreshSection("appSettings")
			Else
				ConfigurationManager.RefreshSection(MyBase.ConfigurationSection)
			End If
			Dim nameValueCollection As NameValueCollection = If(String.IsNullOrEmpty(MyBase.ConfigurationSection), ConfigurationManager.AppSettings, (TryCast(ConfigurationManager.GetSection(MyBase.ConfigurationSection), NameValueCollection)))
			If nameValueCollection Is Nothing Then
				Me.Write(config)
				Return True
			End If
			Dim array As MemberInfo() = members
			Dim i As Integer = 0
			While i < array.Length
				Dim memberInfo As MemberInfo = array(i)
				If memberInfo.MemberType = MemberTypes.Field Then
					Dim fieldInfo As FieldInfo = CType(memberInfo, FieldInfo)
					Dim type2 As Type = fieldInfo.FieldType
					GoTo IL_FC
				End If
				If memberInfo.MemberType = MemberTypes.[Property] Then
					Dim propertyInfo As PropertyInfo = CType(memberInfo, PropertyInfo)
					Dim type2 As Type = propertyInfo.PropertyType
					GoTo IL_FC
				End If
				IL_241:
				i += 1
				Continue While
				IL_FC:
				Dim text2 As String = memberInfo.Name.ToLower()
				If Not(text2 = "errormessage") AndAlso Not(text2 = "provider") Then
					Dim type2 As Type
					If Not Me.IsIList(type2) Then
						Dim text3 As String = nameValueCollection(text2)
						If text3 Is Nothing Then
							flag = True
							GoTo IL_241
						End If
						If text3 <> String.Empty AndAlso text.IndexOf("," + text2 + ",") > -1 Then
							text3 = Encryption.DecryptString(text3, Me.EncryptionKey)
						End If
						Try
							ReflectionUtils.SetPropertyEx(config, memberInfo.Name, ConfigurationFileConfigurationProvider(Of TAppConfiguration).StringToTypedValue(text3, type2, CultureInfo.InvariantCulture))
							GoTo IL_241
						Catch ex_1A4 As Object
							GoTo IL_241
						End Try
					End If
					Dim list As IList = TryCast(Activator.CreateInstance(type2), IList)
					Dim type3 As Type = type2.GetElementType()
					If type3 Is Nothing Then
						Dim genericArguments As Type() = type2.GetGenericArguments()
						If genericArguments IsNot Nothing AndAlso genericArguments.Length > 0 Then
							type3 = genericArguments(0)
						End If
					End If
					Dim num As Integer = 1
					Dim text4 As String = String.Empty
					While text4 IsNot Nothing
						text4 = nameValueCollection(text2 + num)
						If text4 Is Nothing Then
							Exit While
						End If
						list.Add(ConfigurationFileConfigurationProvider(Of TAppConfiguration).StringToTypedValue(text4, type3, CultureInfo.InvariantCulture))
						num += 1
					End While
					Try
						ReflectionUtils.SetPropertyEx(config, memberInfo.Name, list)
					Catch ex_23E As Object
					End Try
					GoTo IL_241
				End If
				GoTo IL_241
			End While
			If flag Then
				Me.Write(config)
			End If
			Return True
		End Function

		Private Function IsIList(type As Type) As Boolean
			Return Not(type Is GetType(String)) AndAlso Not(type Is GetType(Byte())) AndAlso type.GetInterface("IList") IsNot Nothing
		End Function

		Public Override Function Read(config As AppConfiguration, filename As String) As Boolean
			Dim type As Type = config.[GetType]()
			Dim members As MemberInfo() = type.GetMembers(BindingFlags.Instance Or BindingFlags.[Public])
			Dim flag As Boolean = False
			Dim xmlDocument As XmlDocument = New XmlDocument()
			Try
				xmlDocument.Load(filename)
			Catch ex_21 As Object
				If Not Me.Write(config) Then
					Return False
				End If
				xmlDocument.Load(filename)
			End Try
			Me.GetXmlNamespaceInfo(xmlDocument)
			Dim text As String = MyBase.ConfigurationSection
			If text = String.Empty Then
				text = "appSettings"
			End If
			Dim text2 As String = "," + Me.PropertiesToEncrypt.ToLower() + ","
			Dim array As MemberInfo() = members
			Dim i As Integer = 0
			While i < array.Length
				Dim memberInfo As MemberInfo = array(i)
				Dim targetType As Type
				If memberInfo.MemberType = MemberTypes.Field Then
					Dim fieldInfo As FieldInfo = CType(memberInfo, FieldInfo)
					targetType = fieldInfo.FieldType
					fieldInfo.FieldType.Name.ToLower()
					GoTo IL_F9
				End If
				If memberInfo.MemberType = MemberTypes.[Property] Then
					Dim propertyInfo As PropertyInfo = CType(memberInfo, PropertyInfo)
					targetType = propertyInfo.PropertyType
					propertyInfo.PropertyType.Name.ToLower()
					GoTo IL_F9
				End If
				IL_1D2:
				i += 1
				Continue While
				IL_F9:
				Dim text3 As String = memberInfo.Name
				If text3 = "Provider" OrElse text3 = "ErrorMessage" Then
					GoTo IL_1D2
				End If
				If xmlDocument.DocumentElement.SelectSingleNode(Me.XmlNamespacePrefix + text, Me.XmlNamespaces) Is Nothing Then
					Dim newChild As XmlNode = Me.CreateConfigSection(xmlDocument, MyBase.ConfigurationSection)
					xmlDocument.DocumentElement.AppendChild(newChild)
				End If
				Dim text4 As String = Me.GetNamedValueFromXml(xmlDocument, text3, text)
				If text4 Is Nothing Then
					flag = True
					GoTo IL_1D2
				End If
				text3 = text3.ToLower()
				If text4 <> String.Empty AndAlso text2.IndexOf("," + text3 + ",") > -1 Then
					text4 = Encryption.DecryptString(text4, Me.EncryptionKey)
				End If
				ReflectionUtils.SetPropertyEx(config, text3, ConfigurationFileConfigurationProvider(Of TAppConfiguration).StringToTypedValue(text4, targetType, CultureInfo.InvariantCulture))
				GoTo IL_1D2
			End While
			If flag Then
				Me.Write(config)
			End If
			Return True
		End Function

		Public Override Function Write(config As AppConfiguration) As Boolean
			SyncLock Me.syncWriteLock
				Dim xmlDocument As XmlDocument = New XmlDocument()
				Dim configurationFile As String = Me.ConfigurationFile
				If String.IsNullOrEmpty(configurationFile) Then
					configurationFile = AppDomain.CurrentDomain.SetupInformation.ConfigurationFile
				End If
				Try
					xmlDocument.Load(configurationFile)
				Catch ex_41 As Object
					Dim xml As String = "<?xml version='1.0'?>" & vbLf & vbTab & vbTab & "<configuration>" & vbLf & vbTab & vbTab & "</configuration>"
					xmlDocument.LoadXml(xml)
				End Try
				Me.GetXmlNamespaceInfo(xmlDocument)
				Dim type As Type = config.[GetType]()
				Dim members As MemberInfo() = type.GetMembers(BindingFlags.Instance Or BindingFlags.[Public] Or BindingFlags.GetField Or BindingFlags.GetProperty)
				Dim text As String = "appSettings"
				If Not String.IsNullOrEmpty(MyBase.ConfigurationSection) Then
					text = MyBase.ConfigurationSection
				End If
				ConfigurationManager.RefreshSection(text)
				Dim array As MemberInfo() = members
				For i As Integer = 0 To array.Length - 1
					Dim memberInfo As MemberInfo = array(i)
					If Not(memberInfo.Name = "ErrorMessage") AndAlso Not(memberInfo.Name = "Provider") Then
						Dim value As Object
						If memberInfo.MemberType = MemberTypes.Field Then
							value = (CType(memberInfo, FieldInfo)).GetValue(config)
						Else
							If memberInfo.MemberType <> MemberTypes.[Property] Then
								GoTo IL_1AB
							End If
							value = (CType(memberInfo, PropertyInfo)).GetValue(config, Nothing)
						End If
						Dim text2 As String = ConfigurationFileConfigurationProvider(Of TAppConfiguration).TypedValueToString(value, CultureInfo.InvariantCulture, Nothing)
						If text2 = "ILIST_TYPE" Then
							Dim num As Integer = 0
							Dim enumerator As IEnumerator = (TryCast(value, IList)).GetEnumerator()
							Try
								While enumerator.MoveNext()
									Dim current As Object = enumerator.Current
									text2 = ConfigurationFileConfigurationProvider(Of TAppConfiguration).TypedValueToString(current, CultureInfo.InvariantCulture, Nothing)
									Me.WriteConfigurationValue(memberInfo.Name + (num += 1), text2, memberInfo, xmlDocument, text)
								End While
								GoTo IL_1AB
							Finally
								Dim disposable As IDisposable = TryCast(enumerator, IDisposable)
								If disposable IsNot Nothing Then
									disposable.Dispose()
								End If
							End Try
						End If
						Me.WriteConfigurationValue(memberInfo.Name, text2, memberInfo, xmlDocument, text)
					End If
					IL_1AB:
				Next
				Try
					xmlDocument.Save(configurationFile)
					ConfigurationManager.RefreshSection(text)
				Catch ex_1CC As Object
					Return False
				End Try
			End SyncLock
			Return True
		End Function

		Private Sub WriteConfigurationValue(keyName As String, Value As String, Field As MemberInfo, Dom As XmlDocument, ConfigSection As String)
			Dim text As String = "," + Me.PropertiesToEncrypt.ToLower() + ","
			If text.IndexOf("," + Field.Name.ToLower() + ",") > -1 Then
				Value = Encryption.EncryptString(Value, Me.EncryptionKey)
			End If
			Dim xmlNode As XmlNode = Dom.DocumentElement.SelectSingleNode(String.Concat(New String()() = { Me.XmlNamespacePrefix, ConfigSection, "/", Me.XmlNamespacePrefix, "add[@key='", keyName, "']" }), Me.XmlNamespaces)
			If xmlNode Is Nothing Then
				xmlNode = Dom.CreateNode(XmlNodeType.Element, "add", Dom.DocumentElement.NamespaceURI)
				Dim xmlAttribute As XmlAttribute = Dom.CreateAttribute("key")
				xmlAttribute.Value = keyName
				Dim xmlAttribute2 As XmlAttribute = Dom.CreateAttribute("value")
				xmlAttribute2.Value = Value
				xmlNode.Attributes.Append(xmlAttribute)
				xmlNode.Attributes.Append(xmlAttribute2)
				Dim xmlNode2 As XmlNode = Dom.DocumentElement.SelectSingleNode(Me.XmlNamespacePrefix + ConfigSection, Me.XmlNamespaces)
				If xmlNode2 Is Nothing Then
					xmlNode2 = Me.CreateConfigSection(Dom, ConfigSection)
				End If
				xmlNode2.AppendChild(xmlNode)
				Return
			End If
			xmlNode.Attributes.GetNamedItem("value").Value = Value
		End Sub

		Protected Function GetNamedValueFromXml(Dom As XmlDocument, Key As String, ConfigSection As String) As String
			Dim xmlNode As XmlNode = Dom.DocumentElement.SelectSingleNode(String.Concat(New String()() = { Me.XmlNamespacePrefix, ConfigSection, "/", Me.XmlNamespacePrefix, "add[@key='", Key, "']" }), Me.XmlNamespaces)
			If xmlNode Is Nothing Then
				Return Nothing
			End If
			Return xmlNode.Attributes("value").Value
		End Function

		Protected Sub GetXmlNamespaceInfo(Dom As XmlDocument)
			If Dom.DocumentElement.NamespaceURI Is Nothing OrElse Dom.DocumentElement.NamespaceURI = String.Empty Then
				Me.XmlNamespaces = Nothing
				Me.XmlNamespacePrefix = String.Empty
				Return
			End If
			If Dom.DocumentElement.Prefix Is Nothing OrElse Dom.DocumentElement.Prefix = String.Empty Then
				Me.XmlNamespacePrefix = "ww"
			Else
				Me.XmlNamespacePrefix = Dom.DocumentElement.Prefix
			End If
			Me.XmlNamespaces = New XmlNamespaceManager(Dom.NameTable)
			Me.XmlNamespaces.AddNamespace(Me.XmlNamespacePrefix, Dom.DocumentElement.NamespaceURI)
			Me.XmlNamespacePrefix += ":"
		End Sub

		Private Function CreateConfigSection(dom As XmlDocument, configSection As String) As XmlNode
			Dim newChild As XmlNode = dom.CreateNode(XmlNodeType.Element, configSection, dom.DocumentElement.NamespaceURI)
			Dim result As XmlNode = dom.DocumentElement.AppendChild(newChild)
			If configSection <> "appSettings" Then
				Dim xmlNode As XmlNode = dom.DocumentElement.SelectSingleNode(Me.XmlNamespacePrefix + "configSections", Me.XmlNamespaces)
				If xmlNode Is Nothing Then
					Dim newChild2 As XmlNode = dom.CreateNode(XmlNodeType.Element, "configSections", dom.DocumentElement.NamespaceURI)
					xmlNode = dom.DocumentElement.InsertBefore(newChild2, dom.DocumentElement.ChildNodes(0))
				End If
				If xmlNode.SelectSingleNode(Me.XmlNamespacePrefix + "section[@name='" + configSection + "']", Me.XmlNamespaces) Is Nothing Then
					Dim xmlNode2 As XmlNode = dom.CreateNode(XmlNodeType.Element, "section", Nothing)
					Dim xmlAttribute As XmlAttribute = dom.CreateAttribute("name")
					xmlAttribute.Value = configSection
					Dim xmlAttribute2 As XmlAttribute = dom.CreateAttribute("type")
					xmlAttribute2.Value = "System.Configuration.NameValueSectionHandler,System,Version=1.0.3300.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"
					Dim xmlAttribute3 As XmlAttribute = dom.CreateAttribute("requirePermission")
					xmlAttribute3.Value = "false"
					xmlNode2.Attributes.Append(xmlAttribute)
					xmlNode2.Attributes.Append(xmlAttribute3)
					xmlNode2.Attributes.Append(xmlAttribute2)
					xmlNode.AppendChild(xmlNode2)
				End If
			End If
			Return result
		End Function

		Private Shared Function TypedValueToString(rawValue As Object, Optional culture As CultureInfo=Nothing, Optional unsupportedReturn As String=Nothing) As String
			If rawValue Is Nothing Then
				Return String.Empty
			End If
			If culture Is Nothing Then
				culture = CultureInfo.CurrentCulture
			End If
			Dim type As Type = rawValue.[GetType]()
			Dim result As String
			If type Is GetType(String) Then
				result = (TryCast(rawValue, String))
			Else
				If type Is GetType(Integer) OrElse type Is GetType(Decimal) OrElse type Is GetType(Double) OrElse type Is GetType(Single) OrElse type Is GetType(Single) Then
					result = String.Format(culture.NumberFormat, "{0}", New Object()() = { rawValue })
				Else
					If type Is GetType(DateTime) Then
						result = String.Format(culture.DateTimeFormat, "{0}", New Object()() = { rawValue })
					Else
						If type Is GetType(Boolean) OrElse type Is GetType(Byte) OrElse type.IsEnum Then
							result = rawValue.ToString()
						Else
							If type Is GetType(Byte()) Then
								result = Convert.ToBase64String(TryCast(rawValue, Byte()))
							Else
								If type Is GetType(Guid?) Then
									If rawValue IsNot Nothing Then
										Return rawValue.ToString()
									End If
									result = String.Empty
								Else
									If TypeOf rawValue Is IList Then
										Return"ILIST_TYPE"
									End If
									Dim converter As TypeConverter = TypeDescriptor.GetConverter(type)
									If converter IsNot Nothing AndAlso converter.CanConvertTo(GetType(String)) AndAlso converter.CanConvertFrom(GetType(String)) Then
										result = converter.ConvertToString(Nothing, culture, rawValue)
									Else
										If Not String.IsNullOrEmpty(unsupportedReturn) Then
											result = unsupportedReturn
										Else
											result = rawValue.ToString()
										End If
									End If
								End If
							End If
						End If
					End If
				End If
			End If
			Return result
		End Function

		Private Shared Function StringToTypedValue(sourceString As String, targetType As Type, Optional culture As CultureInfo=Nothing) As Object
			Dim flag As Boolean = String.IsNullOrEmpty(sourceString)
			If culture Is Nothing Then
				culture = CultureInfo.CurrentCulture
			End If
			Dim result As Object
			If targetType Is GetType(String) Then
				result = sourceString
			Else
				If targetType Is GetType(Integer) OrElse targetType Is GetType(Integer) Then
					If flag Then
						result = 0
					Else
						result = Integer.Parse(sourceString, NumberStyles.Any, culture.NumberFormat)
					End If
				Else
					If targetType Is GetType(Long) Then
						If flag Then
							result = 0L
						Else
							result = Long.Parse(sourceString, NumberStyles.Any, culture.NumberFormat)
						End If
					Else
						If targetType Is GetType(Short) Then
							If flag Then
								result = 0
							Else
								result = Short.Parse(sourceString, NumberStyles.Any, culture.NumberFormat)
							End If
						Else
							If targetType Is GetType(Decimal) Then
								If flag Then
									result = 0D
								Else
									result = Decimal.Parse(sourceString, NumberStyles.Any, culture.NumberFormat)
								End If
							Else
								If targetType Is GetType(DateTime) Then
									If flag Then
										result = DateTime.MinValue
									Else
										result = Convert.ToDateTime(sourceString, culture.DateTimeFormat)
									End If
								Else
									If targetType Is GetType(Byte) Then
										If flag Then
											result = 0
										Else
											result = Convert.ToByte(sourceString)
										End If
									Else
										If targetType Is GetType(Double) Then
											If flag Then
												result = 0F
											Else
												result = Double.Parse(sourceString, NumberStyles.Any, culture.NumberFormat)
											End If
										Else
											If targetType Is GetType(Single) Then
												If flag Then
													result = 0F
												Else
													result = Single.Parse(sourceString, NumberStyles.Any, culture.NumberFormat)
												End If
											Else
												If targetType Is GetType(Boolean) Then
													If(Not flag AndAlso sourceString.ToLower() = "true") OrElse sourceString.ToLower() = "on" OrElse sourceString = "1" Then
														result = True
													Else
														result = False
													End If
												Else
													If targetType Is GetType(Guid) Then
														If flag Then
															result = Guid.Empty
														Else
															result = New Guid(sourceString)
														End If
													Else
														If targetType.IsEnum Then
															result = [Enum].Parse(targetType, sourceString)
														Else
															If targetType Is GetType(Byte()) Then
																result = Convert.FromBase64String(sourceString)
															Else
																If targetType.Name.StartsWith("Nullable`") Then
																	If sourceString.ToLower() = "null" OrElse sourceString = String.Empty Then
																		result = Nothing
																	Else
																		targetType = Nullable.GetUnderlyingType(targetType)
																		result = ConfigurationFileConfigurationProvider(Of TAppConfiguration).StringToTypedValue(sourceString, targetType, Nothing)
																	End If
																Else
																	Dim converter As TypeConverter = TypeDescriptor.GetConverter(targetType)
																	If converter Is Nothing OrElse Not converter.CanConvertFrom(GetType(String)) Then
																		Try
																			Dim method As MethodInfo = targetType.GetMethod("FromString")
																			If method IsNot Nothing Then
																				Return method.Invoke(Nothing, New Object()() = { sourceString })
																			End If
																		Catch ex_393 As Object
																		End Try
																		Throw New InvalidCastException(Resources.StringToTypedValueValueTypeConversionFailed + targetType.Name)
																	End If
																	result = converter.ConvertFromString(Nothing, culture, sourceString)
																End If
															End If
														End If
													End If
												End If
											End If
										End If
									End If
								End If
							End If
						End If
					End If
				End If
			End If
			Return result
		End Function
	End Class
End Namespace
