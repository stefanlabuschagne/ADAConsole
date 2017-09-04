Imports System
Imports System.IO
Imports System.Reflection
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Text
Imports System.Xml
Imports System.Xml.Serialization

Namespace Westwind.Utilities
	Friend Module SerializationUtils
		Public Function SerializeObject(instance As Object, fileName As String, binarySerialization As Boolean) As Boolean
			Dim result As Boolean = True
			If Not binarySerialization Then
				Dim xmlTextWriter As XmlTextWriter = Nothing
				Try
					Try
						Dim xmlSerializer As XmlSerializer = New XmlSerializer(instance.[GetType]())
						Dim w As Stream = New FileStream(fileName, FileMode.Create)
						xmlTextWriter = New XmlTextWriter(w, New UTF8Encoding())
						xmlTextWriter.Formatting = Formatting.Indented
						xmlTextWriter.IndentChar = " "
						xmlTextWriter.Indentation = 3
						xmlSerializer.Serialize(xmlTextWriter, instance)
					Catch ex_47 As Exception
						result = False
					End Try
					Return result
				Finally
					If xmlTextWriter IsNot Nothing Then
						xmlTextWriter.Close()
					End If
				End Try
			End If
			Dim stream As Stream = Nothing
			Try
				Dim binaryFormatter As BinaryFormatter = New BinaryFormatter()
				stream = New FileStream(fileName, FileMode.Create)
				binaryFormatter.Serialize(stream, instance)
			Catch ex_77 As Object
				result = False
			Finally
				If stream IsNot Nothing Then
					stream.Close()
				End If
			End Try
			Return result
		End Function

		Public Function SerializeObject(instance As Object, writer As XmlTextWriter, throwExceptions As Boolean) As Boolean
			Dim result As Boolean = True
			Try
				Dim xmlSerializer As XmlSerializer = New XmlSerializer(instance.[GetType]())
				writer.Formatting = Formatting.Indented
				writer.IndentChar = " "
				writer.Indentation = 3
				xmlSerializer.Serialize(writer, instance)
			Catch ex_2E As Exception
				If throwExceptions Then
					Throw
				End If
				result = False
			End Try
			Return result
		End Function

		Public Function SerializeObject(instance As Object, <Out()> ByRef xmlResultString As String) As Boolean
			Return SerializationUtils.SerializeObject(instance, xmlResultString, False)
		End Function

		Public Function SerializeObject(instance As Object, <Out()> ByRef xmlResultString As String, throwExceptions As Boolean) As Boolean
			xmlResultString = String.Empty
			Dim memoryStream As MemoryStream = New MemoryStream()
			Dim xmlTextWriter As XmlTextWriter = New XmlTextWriter(memoryStream, New UTF8Encoding())
			If Not SerializationUtils.SerializeObject(instance, xmlTextWriter, throwExceptions) Then
				memoryStream.Close()
				Return False
			End If
			xmlResultString = Encoding.UTF8.GetString(memoryStream.ToArray(), 0, CInt(memoryStream.Length))
			memoryStream.Close()
			xmlTextWriter.Close()
			Return True
		End Function

		Public Function SerializeObject(instance As Object, <Out()> ByRef resultBuffer As Byte(), Optional throwExceptions As Boolean=False) As Boolean
			Dim result As Boolean = True
			Dim memoryStream As MemoryStream = Nothing
			Try
				Dim binaryFormatter As BinaryFormatter = New BinaryFormatter()
				memoryStream = New MemoryStream()
				binaryFormatter.Serialize(memoryStream, instance)
			Catch ex_1A As Exception
				result = False
				If throwExceptions Then
					Throw
				End If
			Finally
				If memoryStream IsNot Nothing Then
					memoryStream.Close()
				End If
			End Try
			resultBuffer = memoryStream.ToArray()
			Return result
		End Function

		Public Function SerializeObjectToString(instance As Object, Optional throwExceptions As Boolean=False) As String
			Dim empty As String = String.Empty
			If Not SerializationUtils.SerializeObject(instance, empty, throwExceptions) Then
				Return Nothing
			End If
			Return empty
		End Function

		Public Function SerializeObjectToByteArray(instance As Object, Optional throwExceptions As Boolean=False) As Byte()
			Dim result As Byte() = Nothing
			If Not SerializationUtils.SerializeObject(instance, result, False) Then
				Return Nothing
			End If
			Return result
		End Function

		Public Function DeSerializeObject(fileName As String, objectType As Type, binarySerialization As Boolean) As Object
			Return SerializationUtils.DeSerializeObject(fileName, objectType, binarySerialization, False)
		End Function

		Public Function DeSerializeObject(fileName As String, objectType As Type, binarySerialization As Boolean, throwExceptions As Boolean) As Object
			Dim result As Object = Nothing
			If Not binarySerialization Then
				Dim xmlReader As XmlReader = Nothing
				Dim fileStream As FileStream = Nothing
				Try
					Try
						Dim xmlSerializer As XmlSerializer = New XmlSerializer(objectType)
						fileStream = New FileStream(fileName, FileMode.Open, FileAccess.Read)
						xmlReader = New XmlTextReader(fileStream)
						result = xmlSerializer.Deserialize(xmlReader)
					Catch ex As Exception
						If throwExceptions Then
							Throw
						End If
						Dim arg_3A_0 As String = ex.Message
						Dim result2 As Object = Nothing
						Return result2
					End Try
					Return result
				Finally
					If fileStream IsNot Nothing Then
						fileStream.Close()
					End If
					If xmlReader IsNot Nothing Then
						xmlReader.Close()
					End If
				End Try
			End If
			Dim fileStream2 As FileStream = Nothing
			Try
				Dim binaryFormatter As BinaryFormatter = New BinaryFormatter()
				fileStream2 = New FileStream(fileName, FileMode.Open, FileAccess.Read)
				result = binaryFormatter.Deserialize(fileStream2)
			Catch ex_78 As Object
				Dim result2 As Object = Nothing
				Return result2
			Finally
				If fileStream2 IsNot Nothing Then
					fileStream2.Close()
				End If
			End Try
			Return result
		End Function

		Public Function DeSerializeObject(reader As XmlReader, objectType As Type) As Object
			Dim xmlSerializer As XmlSerializer = New XmlSerializer(objectType)
			Dim result As Object = xmlSerializer.Deserialize(reader)
			reader.Close()
			Return result
		End Function

		Public Function DeSerializeObject(xml As String, objectType As Type) As Object
			Dim reader As XmlTextReader = New XmlTextReader(xml, XmlNodeType.Document, Nothing)
			Return SerializationUtils.DeSerializeObject(reader, objectType)
		End Function

		Public Function DeSerializeObject(buffer As Byte(), objectType As Type, Optional throwExceptions As Boolean=False) As Object
			Dim memoryStream As MemoryStream = Nothing
			Dim result As Object = Nothing
			Try
				Dim binaryFormatter As BinaryFormatter = New BinaryFormatter()
				memoryStream = New MemoryStream(buffer)
				result = binaryFormatter.Deserialize(memoryStream)
			Catch ex_1D As Object
				If throwExceptions Then
					Throw
				End If
				Return Nothing
			Finally
				If memoryStream IsNot Nothing Then
					memoryStream.Close()
				End If
			End Try
			Return result
		End Function

		Public Function ObjectToString(instanc As Object, separator As String, type As ObjectToStringTypes) As String
			Dim fields As FieldInfo() = instanc.[GetType]().GetFields()
			Dim text As String = String.Empty
			If type = ObjectToStringTypes.Properties OrElse type = ObjectToStringTypes.PropertiesAndFields Then
				Dim properties As PropertyInfo() = instanc.[GetType]().GetProperties()
				For i As Integer = 0 To properties.Length - 1
					Dim propertyInfo As PropertyInfo = properties(i)
					Try
						Dim text2 As String = text
						text = String.Concat(New String()() = { text2, propertyInfo.Name, ":", propertyInfo.GetValue(instanc, Nothing).ToString(), separator })
					Catch ex_78 As Object
						text = text + propertyInfo.Name + ": n/a" + separator
					End Try
				Next
			End If
			If type = ObjectToStringTypes.Fields OrElse type = ObjectToStringTypes.PropertiesAndFields Then
				Dim array As FieldInfo() = fields
				For j As Integer = 0 To array.Length - 1
					Dim fieldInfo As FieldInfo = array(j)
					Try
						text = String.Concat(New String()() = { text, fieldInfo.Name, ": ", fieldInfo.GetValue(instanc).ToString(), separator })
					Catch ex_F1 As Object
						text = text + fieldInfo.Name + ": n/a" + separator
					End Try
				Next
			End If
			Return text
		End Function
	End Module
End Namespace
