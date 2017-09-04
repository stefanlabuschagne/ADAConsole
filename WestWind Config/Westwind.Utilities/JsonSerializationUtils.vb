Imports Microsoft.CSharp.RuntimeBinder
Imports System
Imports System.IO
Imports System.Linq.Expressions
Imports System.Runtime.CompilerServices
Imports System.Text

Namespace Westwind.Utilities
	Friend Module JsonSerializationUtils
		<CompilerGenerated()>
		Private Module <Serialize>o__SiteContainer0
			Public <>p__Site1 As CallSite(Of Func(Of CallSite, Object, Object, Object))

			Public <>p__Site2 As CallSite(Of Func(Of CallSite, Object, Char, Object))

			Public <>p__Site3 As CallSite(Of Action(Of CallSite, Object, Object, Object))

			Public <>p__Site4 As CallSite(Of Action(Of CallSite, Object))

			Public <>p__Site5 As CallSite(Of Func(Of CallSite, Object, Boolean))

			Public <>p__Site6 As CallSite(Of Func(Of CallSite, Object, Object, Object))

			Public <>p__Site7 As CallSite(Of Action(Of CallSite, Object))
		End Module

		<CompilerGenerated()>
		Private Module <SerializeToFile>o__SiteContainer8
			Public <>p__Site9 As CallSite(Of Func(Of CallSite, Object, Boolean))

			Public <>p__Sitea As CallSite(Of Func(Of CallSite, Object, Object, Object))

			Public <>p__Siteb As CallSite(Of Func(Of CallSite, Object, Object, Object))

			Public <>p__Sitec As CallSite(Of Func(Of CallSite, Object, Char, Object))

			Public <>p__Sited As CallSite(Of Action(Of CallSite, Object, Object, Object))

			Public <>p__Sitee As CallSite(Of Func(Of CallSite, Object, Boolean))

			Public <>p__Sitef As CallSite(Of Func(Of CallSite, Object, Object, Object))

			Public <>p__Site10 As CallSite(Of Action(Of CallSite, Object))
		End Module

		<CompilerGenerated()>
		Private Module <Deserialize>o__SiteContainer11
			Public <>p__Site12 As CallSite(Of Func(Of CallSite, Object, Boolean))

			Public <>p__Site13 As CallSite(Of Func(Of CallSite, Object, Object, Object))

			Public <>p__Site14 As CallSite(Of Func(Of CallSite, Object, Object, Type, Object))

			Public <>p__Site15 As CallSite(Of Action(Of CallSite, Object))

			Public <>p__Site16 As CallSite(Of Func(Of CallSite, Object, Boolean))

			Public <>p__Site17 As CallSite(Of Func(Of CallSite, Object, Object, Object))

			Public <>p__Site18 As CallSite(Of Action(Of CallSite, Object))
		End Module

		<CompilerGenerated()>
		Private Module <DeserializeFromFile>o__SiteContainer19
			Public <>p__Site1a As CallSite(Of Func(Of CallSite, Object, Boolean))

			Public <>p__Site1b As CallSite(Of Func(Of CallSite, Object, Object, Object))

			Public <>p__Site1c As CallSite(Of Func(Of CallSite, Object, Object, Type, Object))

			Public <>p__Site1d As CallSite(Of Action(Of CallSite, Object))

			Public <>p__Site1e As CallSite(Of Func(Of CallSite, Object, Boolean))

			Public <>p__Site1f As CallSite(Of Func(Of CallSite, Object, Object, Object))

			Public <>p__Site20 As CallSite(Of Action(Of CallSite, Object))
		End Module

		<CompilerGenerated()>
		Private Module <CreateJsonNet>o__SiteContainer22
			Public <>p__Site23 As CallSite(Of Func(Of CallSite, Object, Boolean))

			Public <>p__Site24 As CallSite(Of Func(Of CallSite, Object, Object, Object))

			Public <>p__Site25 As CallSite(Of Func(Of CallSite, Object, Boolean))

			Public <>p__Site26 As CallSite(Of Func(Of CallSite, Object, Object, Object))

			Public <>p__Site27 As CallSite(Of Func(Of CallSite, Object, Boolean))

			Public <>p__Site28 As CallSite(Of Func(Of CallSite, Object, Object, Object))

			Public <>p__Site29 As CallSite(Of Func(Of CallSite, Object, Boolean))

			Public <>p__Site2a As CallSite(Of Func(Of CallSite, Object, Object, Object))

			Public <>p__Site2b As CallSite(Of Func(Of CallSite, Object, Object, Object))

			Public <>p__Site2c As CallSite(Of Action(Of CallSite, Object, Object))

			Public <>p__Site2d As CallSite(Of Func(Of CallSite, Object, Object))
		End Module

		<Dynamic()>
		Private JsonNet As unknown = Nothing

		Private [SyncLock] As Object = New Object()

		Private FormattingType As Type = Nothing

		Private JsonTextReaderType As Type = Nothing

		Private JsonTextWriterType As Type = Nothing

		Public Function Serialize(value As Object, Optional throwExceptions As Boolean=False, Optional formatJsonOutput As Boolean=False) As String
			Dim result As String = Nothing
			value.[GetType]()
			Dim obj As Object = Nothing
			Try
				Dim arg As Object = JsonSerializationUtils.CreateJsonNet(throwExceptions)
				Dim stringWriter As StringWriter = New StringWriter()
				obj = Activator.CreateInstance(JsonSerializationUtils.JsonTextWriterType, New Object()() = { stringWriter })
				If formatJsonOutput Then
					If JsonSerializationUtils.<Serialize>o__SiteContainer0.<>p__Site1 Is Nothing Then
						JsonSerializationUtils.<Serialize>o__SiteContainer0.<>p__Site1 = CallSite(Of Func(Of CallSite, Object, Object, Object)).Create(Binder.SetMember(CSharpBinderFlags.None, "Formatting", GetType(JsonSerializationUtils), New CSharpArgumentInfo()() = { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, Nothing), CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, Nothing) }))
					End If
					JsonSerializationUtils.<Serialize>o__SiteContainer0.<>p__Site1.Target(JsonSerializationUtils.<Serialize>o__SiteContainer0.<>p__Site1, obj, [Enum].Parse(JsonSerializationUtils.FormattingType, "Indented"))
				End If
				If JsonSerializationUtils.<Serialize>o__SiteContainer0.<>p__Site2 Is Nothing Then
					JsonSerializationUtils.<Serialize>o__SiteContainer0.<>p__Site2 = CallSite(Of Func(Of CallSite, Object, Char, Object)).Create(Binder.SetMember(CSharpBinderFlags.None, "QuoteChar", GetType(JsonSerializationUtils), New CSharpArgumentInfo()() = { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, Nothing), CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType Or CSharpArgumentInfoFlags.Constant, Nothing) }))
				End If
				JsonSerializationUtils.<Serialize>o__SiteContainer0.<>p__Site2.Target(JsonSerializationUtils.<Serialize>o__SiteContainer0.<>p__Site2, obj, """")
				If JsonSerializationUtils.<Serialize>o__SiteContainer0.<>p__Site3 Is Nothing Then
					JsonSerializationUtils.<Serialize>o__SiteContainer0.<>p__Site3 = CallSite(Of Action(Of CallSite, Object, Object, Object)).Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "Serialize", Nothing, GetType(JsonSerializationUtils), New CSharpArgumentInfo()() = { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, Nothing), CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, Nothing), CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, Nothing) }))
				End If
				JsonSerializationUtils.<Serialize>o__SiteContainer0.<>p__Site3.Target(JsonSerializationUtils.<Serialize>o__SiteContainer0.<>p__Site3, arg, obj, value)
				result = stringWriter.ToString()
				If JsonSerializationUtils.<Serialize>o__SiteContainer0.<>p__Site4 Is Nothing Then
					JsonSerializationUtils.<Serialize>o__SiteContainer0.<>p__Site4 = CallSite(Of Action(Of CallSite, Object)).Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "Close", Nothing, GetType(JsonSerializationUtils), New CSharpArgumentInfo()() = { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, Nothing) }))
				End If
				JsonSerializationUtils.<Serialize>o__SiteContainer0.<>p__Site4.Target(JsonSerializationUtils.<Serialize>o__SiteContainer0.<>p__Site4, obj)
			Catch ex As Exception
				If throwExceptions Then
					Throw ex
				End If
				result = Nothing
			Finally
				If JsonSerializationUtils.<Serialize>o__SiteContainer0.<>p__Site5 Is Nothing Then
					JsonSerializationUtils.<Serialize>o__SiteContainer0.<>p__Site5 = CallSite(Of Func(Of CallSite, Object, Boolean)).Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, GetType(JsonSerializationUtils), New CSharpArgumentInfo()() = { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, Nothing) }))
				End If
				Dim arg_27A_0 As Func(Of CallSite, Object, Boolean) = JsonSerializationUtils.<Serialize>o__SiteContainer0.<>p__Site5.Target
				Dim arg_27A_1 As CallSite = JsonSerializationUtils.<Serialize>o__SiteContainer0.<>p__Site5
				If JsonSerializationUtils.<Serialize>o__SiteContainer0.<>p__Site6 Is Nothing Then
					JsonSerializationUtils.<Serialize>o__SiteContainer0.<>p__Site6 = CallSite(Of Func(Of CallSite, Object, Object, Object)).Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.NotEqual, GetType(JsonSerializationUtils), New CSharpArgumentInfo()() = { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, Nothing), CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.Constant, Nothing) }))
				End If
				If arg_27A_0(arg_27A_1, JsonSerializationUtils.<Serialize>o__SiteContainer0.<>p__Site6.Target(JsonSerializationUtils.<Serialize>o__SiteContainer0.<>p__Site6, obj, Nothing)) Then
					If JsonSerializationUtils.<Serialize>o__SiteContainer0.<>p__Site7 Is Nothing Then
						JsonSerializationUtils.<Serialize>o__SiteContainer0.<>p__Site7 = CallSite(Of Action(Of CallSite, Object)).Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "Close", Nothing, GetType(JsonSerializationUtils), New CSharpArgumentInfo()() = { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, Nothing) }))
					End If
					JsonSerializationUtils.<Serialize>o__SiteContainer0.<>p__Site7.Target(JsonSerializationUtils.<Serialize>o__SiteContainer0.<>p__Site7, obj)
				End If
			End Try
			Return result
		End Function

		Public Function SerializeToFile(value As Object, fileName As String, Optional throwExceptions As Boolean=False, Optional formatJsonOutput As Boolean=False) As Boolean
			Dim obj As Object = Nothing
			Dim fileStream As FileStream = Nothing
			Try
				value.[GetType]()
				Dim arg As Object = JsonSerializationUtils.CreateJsonNet(throwExceptions)
				If JsonSerializationUtils.<SerializeToFile>o__SiteContainer8.<>p__Site9 Is Nothing Then
					JsonSerializationUtils.<SerializeToFile>o__SiteContainer8.<>p__Site9 = CallSite(Of Func(Of CallSite, Object, Boolean)).Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, GetType(JsonSerializationUtils), New CSharpArgumentInfo()() = { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, Nothing) }))
				End If
				Dim arg_B2_0 As Func(Of CallSite, Object, Boolean) = JsonSerializationUtils.<SerializeToFile>o__SiteContainer8.<>p__Site9.Target
				Dim arg_B2_1 As CallSite = JsonSerializationUtils.<SerializeToFile>o__SiteContainer8.<>p__Site9
				If JsonSerializationUtils.<SerializeToFile>o__SiteContainer8.<>p__Sitea Is Nothing Then
					JsonSerializationUtils.<SerializeToFile>o__SiteContainer8.<>p__Sitea = CallSite(Of Func(Of CallSite, Object, Object, Object)).Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, GetType(JsonSerializationUtils), New CSharpArgumentInfo()() = { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, Nothing), CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.Constant, Nothing) }))
				End If
				If arg_B2_0(arg_B2_1, JsonSerializationUtils.<SerializeToFile>o__SiteContainer8.<>p__Sitea.Target(JsonSerializationUtils.<SerializeToFile>o__SiteContainer8.<>p__Sitea, arg, Nothing)) Then
					Dim result As Boolean = False
					Return result
				End If
				fileStream = New FileStream(fileName, FileMode.Create)
				Dim streamWriter As StreamWriter = New StreamWriter(fileStream, Encoding.UTF8)
				obj = Activator.CreateInstance(JsonSerializationUtils.JsonTextWriterType, New Object()() = { streamWriter })
				If formatJsonOutput Then
					If JsonSerializationUtils.<SerializeToFile>o__SiteContainer8.<>p__Siteb Is Nothing Then
						JsonSerializationUtils.<SerializeToFile>o__SiteContainer8.<>p__Siteb = CallSite(Of Func(Of CallSite, Object, Object, Object)).Create(Binder.SetMember(CSharpBinderFlags.None, "Formatting", GetType(JsonSerializationUtils), New CSharpArgumentInfo()() = { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, Nothing), CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, Nothing) }))
					End If
					JsonSerializationUtils.<SerializeToFile>o__SiteContainer8.<>p__Siteb.Target(JsonSerializationUtils.<SerializeToFile>o__SiteContainer8.<>p__Siteb, obj, [Enum].Parse(JsonSerializationUtils.FormattingType, "Indented"))
				End If
				If JsonSerializationUtils.<SerializeToFile>o__SiteContainer8.<>p__Sitec Is Nothing Then
					JsonSerializationUtils.<SerializeToFile>o__SiteContainer8.<>p__Sitec = CallSite(Of Func(Of CallSite, Object, Char, Object)).Create(Binder.SetMember(CSharpBinderFlags.None, "QuoteChar", GetType(JsonSerializationUtils), New CSharpArgumentInfo()() = { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, Nothing), CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType Or CSharpArgumentInfoFlags.Constant, Nothing) }))
				End If
				JsonSerializationUtils.<SerializeToFile>o__SiteContainer8.<>p__Sitec.Target(JsonSerializationUtils.<SerializeToFile>o__SiteContainer8.<>p__Sitec, obj, """")
				If JsonSerializationUtils.<SerializeToFile>o__SiteContainer8.<>p__Sited Is Nothing Then
					JsonSerializationUtils.<SerializeToFile>o__SiteContainer8.<>p__Sited = CallSite(Of Action(Of CallSite, Object, Object, Object)).Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "Serialize", Nothing, GetType(JsonSerializationUtils), New CSharpArgumentInfo()() = { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, Nothing), CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, Nothing), CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, Nothing) }))
				End If
				JsonSerializationUtils.<SerializeToFile>o__SiteContainer8.<>p__Sited.Target(JsonSerializationUtils.<SerializeToFile>o__SiteContainer8.<>p__Sited, arg, obj, value)
			Catch ex_22A As Exception
				If throwExceptions Then
					Throw
				End If
				Dim result As Boolean = False
				Return result
			Finally
				If JsonSerializationUtils.<SerializeToFile>o__SiteContainer8.<>p__Sitee Is Nothing Then
					JsonSerializationUtils.<SerializeToFile>o__SiteContainer8.<>p__Sitee = CallSite(Of Func(Of CallSite, Object, Boolean)).Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, GetType(JsonSerializationUtils), New CSharpArgumentInfo()() = { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, Nothing) }))
				End If
				Dim arg_2DD_0 As Func(Of CallSite, Object, Boolean) = JsonSerializationUtils.<SerializeToFile>o__SiteContainer8.<>p__Sitee.Target
				Dim arg_2DD_1 As CallSite = JsonSerializationUtils.<SerializeToFile>o__SiteContainer8.<>p__Sitee
				If JsonSerializationUtils.<SerializeToFile>o__SiteContainer8.<>p__Sitef Is Nothing Then
					JsonSerializationUtils.<SerializeToFile>o__SiteContainer8.<>p__Sitef = CallSite(Of Func(Of CallSite, Object, Object, Object)).Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.NotEqual, GetType(JsonSerializationUtils), New CSharpArgumentInfo()() = { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, Nothing), CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.Constant, Nothing) }))
				End If
				If arg_2DD_0(arg_2DD_1, JsonSerializationUtils.<SerializeToFile>o__SiteContainer8.<>p__Sitef.Target(JsonSerializationUtils.<SerializeToFile>o__SiteContainer8.<>p__Sitef, obj, Nothing)) Then
					If JsonSerializationUtils.<SerializeToFile>o__SiteContainer8.<>p__Site10 Is Nothing Then
						JsonSerializationUtils.<SerializeToFile>o__SiteContainer8.<>p__Site10 = CallSite(Of Action(Of CallSite, Object)).Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "Close", Nothing, GetType(JsonSerializationUtils), New CSharpArgumentInfo()() = { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, Nothing) }))
					End If
					JsonSerializationUtils.<SerializeToFile>o__SiteContainer8.<>p__Site10.Target(JsonSerializationUtils.<SerializeToFile>o__SiteContainer8.<>p__Site10, obj)
				End If
				If fileStream IsNot Nothing Then
					fileStream.Close()
				End If
			End Try
			Return True
		End Function

		Public Function Deserialize(jsonText As String, type As Type, Optional throwExceptions As Boolean=False) As Object
			Dim arg As Object = JsonSerializationUtils.CreateJsonNet(throwExceptions)
			If JsonSerializationUtils.<Deserialize>o__SiteContainer11.<>p__Site12 Is Nothing Then
				JsonSerializationUtils.<Deserialize>o__SiteContainer11.<>p__Site12 = CallSite(Of Func(Of CallSite, Object, Boolean)).Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, GetType(JsonSerializationUtils), New CSharpArgumentInfo()() = { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, Nothing) }))
			End If
			Dim arg_A7_0 As Func(Of CallSite, Object, Boolean) = JsonSerializationUtils.<Deserialize>o__SiteContainer11.<>p__Site12.Target
			Dim arg_A7_1 As CallSite = JsonSerializationUtils.<Deserialize>o__SiteContainer11.<>p__Site12
			If JsonSerializationUtils.<Deserialize>o__SiteContainer11.<>p__Site13 Is Nothing Then
				JsonSerializationUtils.<Deserialize>o__SiteContainer11.<>p__Site13 = CallSite(Of Func(Of CallSite, Object, Object, Object)).Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, GetType(JsonSerializationUtils), New CSharpArgumentInfo()() = { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, Nothing), CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.Constant, Nothing) }))
			End If
			If arg_A7_0(arg_A7_1, JsonSerializationUtils.<Deserialize>o__SiteContainer11.<>p__Site13.Target(JsonSerializationUtils.<Deserialize>o__SiteContainer11.<>p__Site13, arg, Nothing)) Then
				Return Nothing
			End If
			Dim result As Object = Nothing
			Dim obj As Object = Nothing
			Try
				Dim stringReader As StringReader = New StringReader(jsonText)
				obj = Activator.CreateInstance(JsonSerializationUtils.JsonTextReaderType, New Object()() = { stringReader })
				If JsonSerializationUtils.<Deserialize>o__SiteContainer11.<>p__Site14 Is Nothing Then
					JsonSerializationUtils.<Deserialize>o__SiteContainer11.<>p__Site14 = CallSite(Of Func(Of CallSite, Object, Object, Type, Object)).Create(Binder.InvokeMember(CSharpBinderFlags.None, "Deserialize", Nothing, GetType(JsonSerializationUtils), New CSharpArgumentInfo()() = { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, Nothing), CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, Nothing), CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, Nothing) }))
				End If
				result = JsonSerializationUtils.<Deserialize>o__SiteContainer11.<>p__Site14.Target(JsonSerializationUtils.<Deserialize>o__SiteContainer11.<>p__Site14, arg, obj, type)
				If JsonSerializationUtils.<Deserialize>o__SiteContainer11.<>p__Site15 Is Nothing Then
					JsonSerializationUtils.<Deserialize>o__SiteContainer11.<>p__Site15 = CallSite(Of Action(Of CallSite, Object)).Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "Close", Nothing, GetType(JsonSerializationUtils), New CSharpArgumentInfo()() = { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, Nothing) }))
				End If
				JsonSerializationUtils.<Deserialize>o__SiteContainer11.<>p__Site15.Target(JsonSerializationUtils.<Deserialize>o__SiteContainer11.<>p__Site15, obj)
			Catch ex_196 As Exception
				If throwExceptions Then
					Throw
				End If
				Return Nothing
			Finally
				If JsonSerializationUtils.<Deserialize>o__SiteContainer11.<>p__Site16 Is Nothing Then
					JsonSerializationUtils.<Deserialize>o__SiteContainer11.<>p__Site16 = CallSite(Of Func(Of CallSite, Object, Boolean)).Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, GetType(JsonSerializationUtils), New CSharpArgumentInfo()() = { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, Nothing) }))
				End If
				Dim arg_249_0 As Func(Of CallSite, Object, Boolean) = JsonSerializationUtils.<Deserialize>o__SiteContainer11.<>p__Site16.Target
				Dim arg_249_1 As CallSite = JsonSerializationUtils.<Deserialize>o__SiteContainer11.<>p__Site16
				If JsonSerializationUtils.<Deserialize>o__SiteContainer11.<>p__Site17 Is Nothing Then
					JsonSerializationUtils.<Deserialize>o__SiteContainer11.<>p__Site17 = CallSite(Of Func(Of CallSite, Object, Object, Object)).Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.NotEqual, GetType(JsonSerializationUtils), New CSharpArgumentInfo()() = { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, Nothing), CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.Constant, Nothing) }))
				End If
				If arg_249_0(arg_249_1, JsonSerializationUtils.<Deserialize>o__SiteContainer11.<>p__Site17.Target(JsonSerializationUtils.<Deserialize>o__SiteContainer11.<>p__Site17, obj, Nothing)) Then
					If JsonSerializationUtils.<Deserialize>o__SiteContainer11.<>p__Site18 Is Nothing Then
						JsonSerializationUtils.<Deserialize>o__SiteContainer11.<>p__Site18 = CallSite(Of Action(Of CallSite, Object)).Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "Close", Nothing, GetType(JsonSerializationUtils), New CSharpArgumentInfo()() = { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, Nothing) }))
					End If
					JsonSerializationUtils.<Deserialize>o__SiteContainer11.<>p__Site18.Target(JsonSerializationUtils.<Deserialize>o__SiteContainer11.<>p__Site18, obj)
				End If
			End Try
			Return result
		End Function

		Public Function DeserializeFromFile(fileName As String, objectType As Type, Optional throwExceptions As Boolean=False) As Object
			Dim arg As Object = JsonSerializationUtils.CreateJsonNet(throwExceptions)
			If JsonSerializationUtils.<DeserializeFromFile>o__SiteContainer19.<>p__Site1a Is Nothing Then
				JsonSerializationUtils.<DeserializeFromFile>o__SiteContainer19.<>p__Site1a = CallSite(Of Func(Of CallSite, Object, Boolean)).Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, GetType(JsonSerializationUtils), New CSharpArgumentInfo()() = { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, Nothing) }))
			End If
			Dim arg_A7_0 As Func(Of CallSite, Object, Boolean) = JsonSerializationUtils.<DeserializeFromFile>o__SiteContainer19.<>p__Site1a.Target
			Dim arg_A7_1 As CallSite = JsonSerializationUtils.<DeserializeFromFile>o__SiteContainer19.<>p__Site1a
			If JsonSerializationUtils.<DeserializeFromFile>o__SiteContainer19.<>p__Site1b Is Nothing Then
				JsonSerializationUtils.<DeserializeFromFile>o__SiteContainer19.<>p__Site1b = CallSite(Of Func(Of CallSite, Object, Object, Object)).Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, GetType(JsonSerializationUtils), New CSharpArgumentInfo()() = { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, Nothing), CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.Constant, Nothing) }))
			End If
			If arg_A7_0(arg_A7_1, JsonSerializationUtils.<DeserializeFromFile>o__SiteContainer19.<>p__Site1b.Target(JsonSerializationUtils.<DeserializeFromFile>o__SiteContainer19.<>p__Site1b, arg, Nothing)) Then
				Return Nothing
			End If
			Dim result As Object = Nothing
			Dim obj As Object = Nothing
			Dim fileStream As FileStream = Nothing
			Try
				fileStream = New FileStream(fileName, FileMode.Open, FileAccess.Read)
				Dim streamReader As StreamReader = New StreamReader(fileStream, Encoding.UTF8)
				obj = Activator.CreateInstance(JsonSerializationUtils.JsonTextReaderType, New Object()() = { streamReader })
				If JsonSerializationUtils.<DeserializeFromFile>o__SiteContainer19.<>p__Site1c Is Nothing Then
					JsonSerializationUtils.<DeserializeFromFile>o__SiteContainer19.<>p__Site1c = CallSite(Of Func(Of CallSite, Object, Object, Type, Object)).Create(Binder.InvokeMember(CSharpBinderFlags.None, "Deserialize", Nothing, GetType(JsonSerializationUtils), New CSharpArgumentInfo()() = { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, Nothing), CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, Nothing), CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, Nothing) }))
				End If
				result = JsonSerializationUtils.<DeserializeFromFile>o__SiteContainer19.<>p__Site1c.Target(JsonSerializationUtils.<DeserializeFromFile>o__SiteContainer19.<>p__Site1c, arg, obj, objectType)
				If JsonSerializationUtils.<DeserializeFromFile>o__SiteContainer19.<>p__Site1d Is Nothing Then
					JsonSerializationUtils.<DeserializeFromFile>o__SiteContainer19.<>p__Site1d = CallSite(Of Action(Of CallSite, Object)).Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "Close", Nothing, GetType(JsonSerializationUtils), New CSharpArgumentInfo()() = { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, Nothing) }))
				End If
				JsonSerializationUtils.<DeserializeFromFile>o__SiteContainer19.<>p__Site1d.Target(JsonSerializationUtils.<DeserializeFromFile>o__SiteContainer19.<>p__Site1d, obj)
			Catch ex_1A8 As Exception
				If throwExceptions Then
					Throw
				End If
				Return Nothing
			Finally
				If JsonSerializationUtils.<DeserializeFromFile>o__SiteContainer19.<>p__Site1e Is Nothing Then
					JsonSerializationUtils.<DeserializeFromFile>o__SiteContainer19.<>p__Site1e = CallSite(Of Func(Of CallSite, Object, Boolean)).Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, GetType(JsonSerializationUtils), New CSharpArgumentInfo()() = { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, Nothing) }))
				End If
				Dim arg_25B_0 As Func(Of CallSite, Object, Boolean) = JsonSerializationUtils.<DeserializeFromFile>o__SiteContainer19.<>p__Site1e.Target
				Dim arg_25B_1 As CallSite = JsonSerializationUtils.<DeserializeFromFile>o__SiteContainer19.<>p__Site1e
				If JsonSerializationUtils.<DeserializeFromFile>o__SiteContainer19.<>p__Site1f Is Nothing Then
					JsonSerializationUtils.<DeserializeFromFile>o__SiteContainer19.<>p__Site1f = CallSite(Of Func(Of CallSite, Object, Object, Object)).Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.NotEqual, GetType(JsonSerializationUtils), New CSharpArgumentInfo()() = { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, Nothing), CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.Constant, Nothing) }))
				End If
				If arg_25B_0(arg_25B_1, JsonSerializationUtils.<DeserializeFromFile>o__SiteContainer19.<>p__Site1f.Target(JsonSerializationUtils.<DeserializeFromFile>o__SiteContainer19.<>p__Site1f, obj, Nothing)) Then
					If JsonSerializationUtils.<DeserializeFromFile>o__SiteContainer19.<>p__Site20 Is Nothing Then
						JsonSerializationUtils.<DeserializeFromFile>o__SiteContainer19.<>p__Site20 = CallSite(Of Action(Of CallSite, Object)).Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "Close", Nothing, GetType(JsonSerializationUtils), New CSharpArgumentInfo()() = { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, Nothing) }))
					End If
					JsonSerializationUtils.<DeserializeFromFile>o__SiteContainer19.<>p__Site20.Target(JsonSerializationUtils.<DeserializeFromFile>o__SiteContainer19.<>p__Site20, obj)
				End If
				If fileStream IsNot Nothing Then
					fileStream.Close()
				End If
			End Try
			Return result
		End Function

		Public Function CreateJsonNet(Optional throwExceptions As Boolean=True) As<Dynamic()>
		unknown
			If JsonSerializationUtils.<CreateJsonNet>o__SiteContainer22.<>p__Site23 Is Nothing Then
				JsonSerializationUtils.<CreateJsonNet>o__SiteContainer22.<>p__Site23 = CallSite(Of Func(Of CallSite, Object, Boolean)).Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, GetType(JsonSerializationUtils), New CSharpArgumentInfo()() = { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, Nothing) }))
			End If
			Dim arg_A4_0 As Func(Of CallSite, Object, Boolean) = JsonSerializationUtils.<CreateJsonNet>o__SiteContainer22.<>p__Site23.Target
			Dim arg_A4_1 As CallSite = JsonSerializationUtils.<CreateJsonNet>o__SiteContainer22.<>p__Site23
			If JsonSerializationUtils.<CreateJsonNet>o__SiteContainer22.<>p__Site24 Is Nothing Then
				JsonSerializationUtils.<CreateJsonNet>o__SiteContainer22.<>p__Site24 = CallSite(Of Func(Of CallSite, Object, Object, Object)).Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.NotEqual, GetType(JsonSerializationUtils), New CSharpArgumentInfo()() = { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, Nothing), CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.Constant, Nothing) }))
			End If
			If arg_A4_0(arg_A4_1, JsonSerializationUtils.<CreateJsonNet>o__SiteContainer22.<>p__Site24.Target(JsonSerializationUtils.<CreateJsonNet>o__SiteContainer22.<>p__Site24, JsonSerializationUtils.JsonNet, Nothing)) Then
				Return JsonSerializationUtils.JsonNet
			End If
			SyncLock JsonSerializationUtils.[SyncLock]
				If JsonSerializationUtils.<CreateJsonNet>o__SiteContainer22.<>p__Site25 Is Nothing Then
					JsonSerializationUtils.<CreateJsonNet>o__SiteContainer22.<>p__Site25 = CallSite(Of Func(Of CallSite, Object, Boolean)).Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, GetType(JsonSerializationUtils), New CSharpArgumentInfo()() = { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, Nothing) }))
				End If
				Dim arg_166_0 As Func(Of CallSite, Object, Boolean) = JsonSerializationUtils.<CreateJsonNet>o__SiteContainer22.<>p__Site25.Target
				Dim arg_166_1 As CallSite = JsonSerializationUtils.<CreateJsonNet>o__SiteContainer22.<>p__Site25
				If JsonSerializationUtils.<CreateJsonNet>o__SiteContainer22.<>p__Site26 Is Nothing Then
					JsonSerializationUtils.<CreateJsonNet>o__SiteContainer22.<>p__Site26 = CallSite(Of Func(Of CallSite, Object, Object, Object)).Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.NotEqual, GetType(JsonSerializationUtils), New CSharpArgumentInfo()() = { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, Nothing), CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.Constant, Nothing) }))
				End If
				If arg_166_0(arg_166_1, JsonSerializationUtils.<CreateJsonNet>o__SiteContainer22.<>p__Site26.Target(JsonSerializationUtils.<CreateJsonNet>o__SiteContainer22.<>p__Site26, JsonSerializationUtils.JsonNet, Nothing)) Then
					Dim result As Object = JsonSerializationUtils.JsonNet
					Return result
				End If
				Dim obj As Object = ReflectionUtils.CreateInstanceFromString("Newtonsoft.Json.JsonSerializer", New Object(0))
				If JsonSerializationUtils.<CreateJsonNet>o__SiteContainer22.<>p__Site27 Is Nothing Then
					JsonSerializationUtils.<CreateJsonNet>o__SiteContainer22.<>p__Site27 = CallSite(Of Func(Of CallSite, Object, Boolean)).Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, GetType(JsonSerializationUtils), New CSharpArgumentInfo()() = { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, Nothing) }))
				End If
				Dim arg_229_0 As Func(Of CallSite, Object, Boolean) = JsonSerializationUtils.<CreateJsonNet>o__SiteContainer22.<>p__Site27.Target
				Dim arg_229_1 As CallSite = JsonSerializationUtils.<CreateJsonNet>o__SiteContainer22.<>p__Site27
				If JsonSerializationUtils.<CreateJsonNet>o__SiteContainer22.<>p__Site28 Is Nothing Then
					JsonSerializationUtils.<CreateJsonNet>o__SiteContainer22.<>p__Site28 = CallSite(Of Func(Of CallSite, Object, Object, Object)).Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, GetType(JsonSerializationUtils), New CSharpArgumentInfo()() = { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, Nothing), CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.Constant, Nothing) }))
				End If
				If arg_229_0(arg_229_1, JsonSerializationUtils.<CreateJsonNet>o__SiteContainer22.<>p__Site28.Target(JsonSerializationUtils.<CreateJsonNet>o__SiteContainer22.<>p__Site28, obj, Nothing)) Then
					Try
						AppDomain.CurrentDomain.Load("Newtonsoft.Json")
						obj = ReflectionUtils.CreateInstanceFromString("Newtonsoft.Json.JsonSerializer", New Object(0))
					Catch ex_253 As Exception
						If throwExceptions Then
							Throw
						End If
						Dim result As Object = Nothing
						Return result
					End Try
				End If
				If JsonSerializationUtils.<CreateJsonNet>o__SiteContainer22.<>p__Site29 Is Nothing Then
					JsonSerializationUtils.<CreateJsonNet>o__SiteContainer22.<>p__Site29 = CallSite(Of Func(Of CallSite, Object, Boolean)).Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, GetType(JsonSerializationUtils), New CSharpArgumentInfo()() = { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, Nothing) }))
				End If
				Dim arg_300_0 As Func(Of CallSite, Object, Boolean) = JsonSerializationUtils.<CreateJsonNet>o__SiteContainer22.<>p__Site29.Target
				Dim arg_300_1 As CallSite = JsonSerializationUtils.<CreateJsonNet>o__SiteContainer22.<>p__Site29
				If JsonSerializationUtils.<CreateJsonNet>o__SiteContainer22.<>p__Site2a Is Nothing Then
					JsonSerializationUtils.<CreateJsonNet>o__SiteContainer22.<>p__Site2a = CallSite(Of Func(Of CallSite, Object, Object, Object)).Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, GetType(JsonSerializationUtils), New CSharpArgumentInfo()() = { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, Nothing), CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.Constant, Nothing) }))
				End If
				If arg_300_0(arg_300_1, JsonSerializationUtils.<CreateJsonNet>o__SiteContainer22.<>p__Site2a.Target(JsonSerializationUtils.<CreateJsonNet>o__SiteContainer22.<>p__Site2a, obj, Nothing)) Then
					Dim result As Object = Nothing
					Return result
				End If
				JsonSerializationUtils.FormattingType = ReflectionUtils.GetTypeFromName("Newtonsoft.Json.Formatting")
				JsonSerializationUtils.JsonTextReaderType = ReflectionUtils.GetTypeFromName("Newtonsoft.Json.JsonTextReader")
				JsonSerializationUtils.JsonTextWriterType = ReflectionUtils.GetTypeFromName("Newtonsoft.Json.JsonTextWriter")
				If JsonSerializationUtils.<CreateJsonNet>o__SiteContainer22.<>p__Site2b Is Nothing Then
					JsonSerializationUtils.<CreateJsonNet>o__SiteContainer22.<>p__Site2b = CallSite(Of Func(Of CallSite, Object, Object, Object)).Create(Binder.SetMember(CSharpBinderFlags.None, "ReferenceLoopHandling", GetType(JsonSerializationUtils), New CSharpArgumentInfo()() = { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, Nothing), CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, Nothing) }))
				End If
				JsonSerializationUtils.<CreateJsonNet>o__SiteContainer22.<>p__Site2b.Target(JsonSerializationUtils.<CreateJsonNet>o__SiteContainer22.<>p__Site2b, obj, ReflectionUtils.GetStaticProperty("Newtonsoft.Json.ReferenceLoopHandling", "Ignore"))
				Dim arg As Object = ReflectionUtils.CreateInstanceFromString("Newtonsoft.Json.Converters.StringEnumConverter", New Object(0))
				If JsonSerializationUtils.<CreateJsonNet>o__SiteContainer22.<>p__Site2c Is Nothing Then
					JsonSerializationUtils.<CreateJsonNet>o__SiteContainer22.<>p__Site2c = CallSite(Of Action(Of CallSite, Object, Object)).Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "Add", Nothing, GetType(JsonSerializationUtils), New CSharpArgumentInfo()() = { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, Nothing), CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, Nothing) }))
				End If
				Dim arg_462_0 As Action(Of CallSite, Object, Object) = JsonSerializationUtils.<CreateJsonNet>o__SiteContainer22.<>p__Site2c.Target
				Dim arg_462_1 As CallSite = JsonSerializationUtils.<CreateJsonNet>o__SiteContainer22.<>p__Site2c
				If JsonSerializationUtils.<CreateJsonNet>o__SiteContainer22.<>p__Site2d Is Nothing Then
					JsonSerializationUtils.<CreateJsonNet>o__SiteContainer22.<>p__Site2d = CallSite(Of Func(Of CallSite, Object, Object)).Create(Binder.GetMember(CSharpBinderFlags.None, "Converters", GetType(JsonSerializationUtils), New CSharpArgumentInfo()() = { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, Nothing) }))
				End If
				arg_462_0(arg_462_1, JsonSerializationUtils.<CreateJsonNet>o__SiteContainer22.<>p__Site2d.Target(JsonSerializationUtils.<CreateJsonNet>o__SiteContainer22.<>p__Site2d, obj), arg)
				JsonSerializationUtils.JsonNet = obj
			End SyncLock
			Return JsonSerializationUtils.JsonNet
		End Function
	End Module
End Namespace
