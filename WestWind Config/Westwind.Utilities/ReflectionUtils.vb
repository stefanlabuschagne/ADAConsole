Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Globalization
Imports System.Reflection
Imports Westwind.Utilities.Configuration.Properties

Namespace Westwind.Utilities
	Friend Module ReflectionUtils
		Public Const MemberAccess As BindingFlags = BindingFlags.IgnoreCase Or BindingFlags.Instance Or BindingFlags.[Static] Or BindingFlags.[Public] Or BindingFlags.NonPublic

		Public Function GetProperty(instance As Object, [property] As String) As Object
			Return instance.[GetType]().GetProperty([property], BindingFlags.IgnoreCase Or BindingFlags.Instance Or BindingFlags.[Static] Or BindingFlags.[Public] Or BindingFlags.NonPublic).GetValue(instance, Nothing)
		End Function

		Public Function GetField([Object] As Object, [Property] As String) As Object
			Return [Object].[GetType]().GetField([Property], BindingFlags.IgnoreCase Or BindingFlags.Instance Or BindingFlags.[Static] Or BindingFlags.[Public] Or BindingFlags.NonPublic).GetValue([Object])
		End Function

		Private Function GetPropertyInternal(Parent As Object, [Property] As String) As Object
			If [Property] = "this" OrElse [Property] = "me" Then
				Return Parent
			End If
			Dim name As String = [Property]
			Dim text As String = Nothing
			Dim flag As Boolean = False
			If [Property].IndexOf("[") > -1 Then
				name = [Property].Substring(0, [Property].IndexOf("["))
				text = [Property].Substring([Property].IndexOf("["))
				flag = True
			End If
			Dim memberInfo As MemberInfo = Parent.[GetType]().GetMember(name, BindingFlags.IgnoreCase Or BindingFlags.Instance Or BindingFlags.[Static] Or BindingFlags.[Public] Or BindingFlags.NonPublic)(0)
			Dim obj As Object
			If memberInfo.MemberType = MemberTypes.[Property] Then
				obj = (CType(memberInfo, PropertyInfo)).GetValue(Parent, Nothing)
			Else
				obj = (CType(memberInfo, FieldInfo)).GetValue(Parent)
			End If
			If flag Then
				text = text.Replace("[", String.Empty).Replace("]", String.Empty)
				If TypeOf obj Is Array Then
					Dim num As Integer = -1
					Integer.TryParse(text, num)
					obj = ReflectionUtils.CallMethod(obj, "GetValue", New Object()() = { num })
				Else
					If TypeOf obj Is ICollection Then
						If text.StartsWith("""") Then
							text = text.Trim(New Char()() = { """" })
							obj = ReflectionUtils.CallMethod(obj, "get_Item", New Object()() = { text })
						Else
							Dim num2 As Integer = -1
							Integer.TryParse(text, num2)
							obj = ReflectionUtils.CallMethod(obj, "get_Item", New Object()() = { num2 })
						End If
					End If
				End If
			End If
			Return obj
		End Function

		Private Function SetPropertyInternal(Parent As Object, [Property] As String, Value As Object) As Object
			If [Property] = "this" OrElse [Property] = "me" Then
				Return Parent
			End If
			Dim name As String = [Property]
			Dim text As String = Nothing
			Dim flag As Boolean = False
			If [Property].IndexOf("[") > -1 Then
				name = [Property].Substring(0, [Property].IndexOf("["))
				text = [Property].Substring([Property].IndexOf("["))
				flag = True
			End If
			If Not flag Then
				Dim memberInfo As MemberInfo = Parent.[GetType]().GetMember(name, BindingFlags.IgnoreCase Or BindingFlags.Instance Or BindingFlags.[Static] Or BindingFlags.[Public] Or BindingFlags.NonPublic)(0)
				If memberInfo.MemberType = MemberTypes.[Property] Then
					(CType(memberInfo, PropertyInfo)).SetValue(Parent, Value, Nothing)
				Else
					(CType(memberInfo, FieldInfo)).SetValue(Parent, Value)
				End If
				Return Nothing
			End If
			Dim memberInfo2 As MemberInfo = Parent.[GetType]().GetMember(name, BindingFlags.IgnoreCase Or BindingFlags.Instance Or BindingFlags.[Static] Or BindingFlags.[Public] Or BindingFlags.NonPublic)(0)
			Dim obj As Object
			If memberInfo2.MemberType = MemberTypes.[Property] Then
				obj = (CType(memberInfo2, PropertyInfo)).GetValue(Parent, Nothing)
			Else
				obj = (CType(memberInfo2, FieldInfo)).GetValue(Parent)
			End If
			If flag Then
				text = text.Replace("[", String.Empty).Replace("]", String.Empty)
				If TypeOf obj Is Array Then
					Dim num As Integer = -1
					Integer.TryParse(text, num)
					obj = ReflectionUtils.CallMethod(obj, "SetValue", New Object()() = { Value, num })
				Else
					If TypeOf obj Is ICollection Then
						If text.StartsWith("""") Then
							text = text.Trim(New Char()() = { """" })
							obj = ReflectionUtils.CallMethod(obj, "set_Item", New Object()() = { text, Value })
						Else
							Dim num2 As Integer = -1
							Integer.TryParse(text, num2)
							obj = ReflectionUtils.CallMethod(obj, "set_Item", New Object()() = { num2, Value })
						End If
					End If
				End If
			End If
			Return obj
		End Function

		Public Function GetPropertyEx(Parent As Object, [Property] As String) As Object
			Parent.[GetType]()
			Dim num As Integer = [Property].IndexOf(".")
			If num < 0 Then
				Return ReflectionUtils.GetPropertyInternal(Parent, [Property])
			End If
			Dim [property] As String = [Property].Substring(0, num)
			Dim property2 As String = [Property].Substring(num + 1)
			Dim propertyInternal As Object = ReflectionUtils.GetPropertyInternal(Parent, [property])
			Return ReflectionUtils.GetPropertyEx(propertyInternal, property2)
		End Function

		Public Function GetPropertyInfoEx(Parent As Object, [Property] As String) As PropertyInfo
			Parent.[GetType]()
			Dim num As Integer = [Property].IndexOf(".")
			If num < 0 Then
				Return ReflectionUtils.GetPropertyInfoInternal(Parent, [Property])
			End If
			Dim [property] As String = [Property].Substring(0, num)
			Dim property2 As String = [Property].Substring(num + 1)
			Dim propertyInternal As Object = ReflectionUtils.GetPropertyInternal(Parent, [property])
			Return ReflectionUtils.GetPropertyInfoEx(propertyInternal, property2)
		End Function

		Public Function GetPropertyInfoInternal(Parent As Object, [Property] As String) As PropertyInfo
			If [Property] = "this" OrElse [Property] = "me" Then
				Return Nothing
			End If
			Dim name As String = [Property]
			If [Property].IndexOf("[") > -1 Then
				name = [Property].Substring(0, [Property].IndexOf("["))
			End If
			Return Parent.[GetType]().GetProperty(name, BindingFlags.IgnoreCase Or BindingFlags.Instance Or BindingFlags.[Static] Or BindingFlags.[Public] Or BindingFlags.NonPublic)
		End Function

		Public Sub SetProperty(obj As Object, [property] As String, value As Object)
			obj.[GetType]().GetProperty([property], BindingFlags.IgnoreCase Or BindingFlags.Instance Or BindingFlags.[Static] Or BindingFlags.[Public] Or BindingFlags.NonPublic).SetValue(obj, value, Nothing)
		End Sub

		Public Sub SetField(obj As Object, [property] As String, value As Object)
			obj.[GetType]().GetField([property], BindingFlags.IgnoreCase Or BindingFlags.Instance Or BindingFlags.[Static] Or BindingFlags.[Public] Or BindingFlags.NonPublic).SetValue(obj, value)
		End Sub

		Public Function SetPropertyEx(parent As Object, [property] As String, value As Object) As Object
			parent.[GetType]()
			Dim num As Integer = [property].IndexOf(".")
			If num < 0 Then
				ReflectionUtils.SetPropertyInternal(parent, [property], value)
				Return Nothing
			End If
			Dim property2 As String = [property].Substring(0, num)
			Dim property3 As String = [property].Substring(num + 1)
			Dim propertyInternal As Object = ReflectionUtils.GetPropertyInternal(parent, property2)
			ReflectionUtils.SetPropertyEx(propertyInternal, property3, value)
			Return Nothing
		End Function

		Public Function CallMethod(instance As Object, method As String, parameterTypes As Type(), <Out()> ParamArray parms As Object()) As Object
			If parameterTypes Is Nothing AndAlso parms.Length > 0 Then
				Return instance.[GetType]().GetMethod(method, BindingFlags.IgnoreCase Or BindingFlags.Instance Or BindingFlags.[Static] Or BindingFlags.[Public] Or BindingFlags.NonPublic Or BindingFlags.InvokeMethod).Invoke(instance, parms)
			End If
			Return instance.[GetType]().GetMethod(method, BindingFlags.IgnoreCase Or BindingFlags.Instance Or BindingFlags.[Static] Or BindingFlags.[Public] Or BindingFlags.NonPublic Or BindingFlags.InvokeMethod, Nothing, parameterTypes, Nothing).Invoke(instance, parms)
		End Function

		Public Function CallMethod(instance As Object, method As String, <Out()> ParamArray parms As Object()) As Object
			Dim array As Type() = Nothing
			If parms IsNot Nothing Then
				array = New Type(parms.Length)
				For i As Integer = 0 To parms.Length - 1
					If parms(i) Is Nothing Then
						array = Nothing
						Exit For
					End If
					array(i) = parms(i).[GetType]()
				Next
			End If
			Return ReflectionUtils.CallMethod(instance, method, array, parms)
		End Function

		Public Function CallMethodEx(parent As Object, method As String, <Out()> ParamArray parms As Object()) As Object
			parent.[GetType]()
			Dim num As Integer = method.IndexOf(".")
			If num < 0 Then
				Return ReflectionUtils.CallMethod(parent, method, parms)
			End If
			Dim [property] As String = method.Substring(0, num)
			Dim method2 As String = method.Substring(num + 1)
			Dim propertyInternal As Object = ReflectionUtils.GetPropertyInternal(parent, [property])
			Return ReflectionUtils.CallMethodEx(propertyInternal, method2, parms)
		End Function

		Public Function CreateInstanceFromType(typeToCreate As Type, <Out()> ParamArray args As Object()) As Object
			If args Is Nothing Then
				Dim emptyTypes As Type() = Type.EmptyTypes
				Return typeToCreate.GetConstructor(emptyTypes).Invoke(Nothing)
			End If
			Return Activator.CreateInstance(typeToCreate, args)
		End Function

		Public Function CreateInstanceFromString(typeName As String, <Out()> ParamArray args As Object()) As Object
			Dim result As Object = Nothing
			Try
				Dim typeFromName As Type = ReflectionUtils.GetTypeFromName(typeName)
				If typeFromName Is Nothing Then
					Dim result2 As Object = Nothing
					Return result2
				End If
				result = Activator.CreateInstance(typeFromName, args)
			Catch ex_22 As Object
				Dim result2 As Object = Nothing
				Return result2
			End Try
			Return result
		End Function

		Public Function GetTypeFromName(typeName As String) As Type
			Dim type As Type = Type.[GetType](typeName, False)
			If type IsNot Nothing Then
				Return type
			End If
			Dim assemblies As Assembly() = AppDomain.CurrentDomain.GetAssemblies()
			Dim array As Assembly() = assemblies
			For i As Integer = 0 To array.Length - 1
				Dim assembly As Assembly = array(i)
				type = assembly.[GetType](typeName, False)
				If type IsNot Nothing Then
					Exit For
				End If
			Next
			Return type
		End Function

		Public Function CreateComInstance(progId As String) As Object
			Dim typeFromProgID As Type = Type.GetTypeFromProgID(progId)
			If typeFromProgID Is Nothing Then
				Return Nothing
			End If
			Return Activator.CreateInstance(typeFromProgID)
		End Function

		Public Function TypedValueToString(rawValue As Object, Optional culture As CultureInfo=Nothing, Optional unsupportedReturn As String=Nothing) As String
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
							If type Is GetType(Guid?) Then
								If rawValue IsNot Nothing Then
									Return rawValue.ToString()
								End If
								result = String.Empty
							Else
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
			Return result
		End Function

		Public Function StringToTypedValue(sourceString As String, targetType As Type, Optional culture As CultureInfo=Nothing) As Object
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
																result = Nothing
															Else
																If targetType.Name.StartsWith("Nullable`") Then
																	If sourceString.ToLower() = "null" OrElse sourceString = String.Empty Then
																		result = Nothing
																	Else
																		targetType = Nullable.GetUnderlyingType(targetType)
																		result = ReflectionUtils.StringToTypedValue(sourceString, targetType, Nothing)
																	End If
																Else
																	Dim converter As TypeConverter = TypeDescriptor.GetConverter(targetType)
																	If converter Is Nothing OrElse Not converter.CanConvertFrom(GetType(String)) Then
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

		Public Function StringToTypedValue(Of T)(sourceString As String, Optional culture As CultureInfo=Nothing) As T
			Return CType((CObj(ReflectionUtils.StringToTypedValue(sourceString, GetType(T), culture))), T)
		End Function

		Public Function GetEnumList(enumType As Type, Optional valueAsFieldValueNumber As Boolean=False) As List(Of KeyValuePair(Of String, String))
			Dim values As Array = [Enum].GetValues(enumType)
			Dim list As List(Of KeyValuePair(Of String, String)) = New List(Of KeyValuePair(Of String, String))()
			For Each current As Object In values
				Dim camelCase As String = current.ToString()
				If Not valueAsFieldValueNumber Then
					list.Add(New KeyValuePair(Of String, String)(current.ToString(), StringUtils.FromCamelCase(camelCase)))
				Else
					list.Add(New KeyValuePair(Of String, String)((CInt(current)).ToString(), StringUtils.FromCamelCase(camelCase)))
				End If
			Next
			Return list
		End Function

		Public Function GetStaticProperty(typeName As String, [property] As String) As Object
			Dim typeFromName As Type = ReflectionUtils.GetTypeFromName(typeName)
			If typeFromName Is Nothing Then
				Return Nothing
			End If
			Return ReflectionUtils.GetStaticProperty(typeFromName, [property])
		End Function

		Public Function GetStaticProperty(type As Type, [property] As String) As Object
			Dim result As Object = Nothing
			Try
				result = type.InvokeMember([property], BindingFlags.[Static] Or BindingFlags.[Public] Or BindingFlags.GetField Or BindingFlags.GetProperty, Nothing, type, Nothing)
			Catch ex_14 As Object
				Return Nothing
			End Try
			Return result
		End Function
	End Module
End Namespace
