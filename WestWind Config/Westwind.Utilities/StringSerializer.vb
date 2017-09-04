Imports System
Imports System.Collections.Generic
Imports System.Reflection

Namespace Westwind.Utilities
	Public Module StringSerializer
		Private Const Seperator_Replace_String As String = "-@-"

		Public Function SerializeObject(objectToSerialize As Object, Optional separator As String=Nothing) As String
			If separator Is Nothing Then
				separator = "|"
			End If
			If objectToSerialize Is Nothing Then
				Return"null"
			End If
			Dim properties As PropertyInfo() = objectToSerialize.[GetType]().GetProperties(BindingFlags.Instance Or BindingFlags.[Public])
			Dim list As List(Of String) = New List(Of String)()
			For i As Integer = 0 To properties.Length - 1
				Dim propertyInfo As PropertyInfo = properties(i)
				If propertyInfo.CanRead OrElse propertyInfo.CanWrite Then
					Dim value As Object = propertyInfo.GetValue(objectToSerialize, Nothing)
					Dim text As String = "null"
					If value IsNot Nothing Then
						If TypeOf value Is String Then
							text = CStr(value)
							If text.Contains(separator) Then
								text = text.Replace(separator, "-@-")
							End If
						Else
							text = ReflectionUtils.TypedValueToString(value, Nothing, "null")
						End If
					End If
					list.Add(text)
				End If
			Next
			If list.Count < 0 Then
				Return String.Empty
			End If
			Return String.Join(separator, list.ToArray())
		End Function

		Public Function DeserializeObject(serialized As String, type As Type, Optional separator As String=Nothing) As Object
			If serialized = "null" Then
				Return Nothing
			End If
			If separator Is Nothing Then
				separator = "|"
			End If
			Dim obj As Object = ReflectionUtils.CreateInstanceFromType(type, New Object(0))
			Dim properties As PropertyInfo() = obj.[GetType]().GetProperties(BindingFlags.Instance Or BindingFlags.[Public])
			Dim array As String() = serialized.Split(New String()() = { separator }, StringSplitOptions.None)
			If array Is Nothing OrElse array.Length < 1 Then
				Return Nothing
			End If
			For i As Integer = 0 To properties.Length - 1
				Dim text As String = array(i)
				Dim propertyInfo As PropertyInfo = properties(i)
				If propertyInfo.CanRead OrElse propertyInfo.CanWrite Then
					text = text.Replace("-@-", separator)
					Dim value As Object = Nothing
					If text IsNot Nothing Then
						Try
							value = ReflectionUtils.StringToTypedValue(text, propertyInfo.PropertyType, Nothing)
						Catch ex_9F As InvalidCastException
						End Try
					End If
					propertyInfo.SetValue(obj, value, Nothing)
				End If
			Next
			Return obj
		End Function

		Public Function Deserialize(Of T As{Class, New})(serialized As String, Optional separator As String=Nothing) As T
			Return TryCast(StringSerializer.DeserializeObject(serialized, GetType(T), separator), T)
		End Function
	End Module
End Namespace
