Imports System
Imports System.Collections.Generic
Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Imports System.Linq
Imports System.Reflection
Imports System.Text
Imports Westwind.Utilities.Configuration.Properties

Namespace Westwind.Utilities
	Friend Module DataUtils
		Public Const MemberAccess As BindingFlags = BindingFlags.IgnoreCase Or BindingFlags.Instance Or BindingFlags.[Static] Or BindingFlags.[Public] Or BindingFlags.NonPublic

		Public Const MemberPublicInstanceAccess As BindingFlags = BindingFlags.IgnoreCase Or BindingFlags.Instance Or BindingFlags.[Public]

		Public MinimumSqlDate As DateTime = DateTime.Parse("01/01/1900")

		Public Function GenerateUniqueId(Optional stringSize As Integer=8) As String
			Dim text As String = "abcdefghijkmnopqrstuvwxyz1234567890"
			Dim stringBuilder As StringBuilder = New StringBuilder(stringSize)
			Dim num As Integer = 0
			Dim array As Byte() = Guid.NewGuid().ToByteArray()
			For i As Integer = 0 To array.Length - 1
				Dim b As Byte = array(i)
				stringBuilder.Append(text(CInt(b) Mod (text.Length - 1)))
				num += 1
				If num >= stringSize Then
					Return stringBuilder.ToString()
				End If
			Next
			Return stringBuilder.ToString()
		End Function

		Public Function GenerateUniqueNumericId() As Long
			Dim value As Byte() = Guid.NewGuid().ToByteArray()
			Return BitConverter.ToInt64(value, 0)
		End Function

		Public Function CopyDataRow(source As DataRow, target As DataRow) As Boolean
			Dim columns As DataColumnCollection = target.Table.Columns
			For i As Integer = 0 To columns.Count - 1
				Dim columnName As String = columns(i).ColumnName
				Try
					target(i) = source(columnName)
				Catch ex_2D As Object
				End Try
			Next
			Return True
		End Function

		Public Sub CopyObjectFromDataRow(row As DataRow, targetObject As Object)
			Dim array As MemberInfo() = targetObject.[GetType]().FindMembers(MemberTypes.Field Or MemberTypes.[Property], BindingFlags.IgnoreCase Or BindingFlags.Instance Or BindingFlags.[Static] Or BindingFlags.[Public] Or BindingFlags.NonPublic, Nothing, Nothing)
			Dim array2 As MemberInfo() = array
			For i As Integer = 0 To array2.Length - 1
				Dim memberInfo As MemberInfo = array2(i)
				Dim name As String = memberInfo.Name
				If row.Table.Columns.Contains(name) Then
					If memberInfo.MemberType = MemberTypes.Field Then
						(CType(memberInfo, FieldInfo)).SetValue(targetObject, row(name))
					Else
						If memberInfo.MemberType = MemberTypes.[Property] Then
							(CType(memberInfo, PropertyInfo)).SetValue(targetObject, row(name), Nothing)
						End If
					End If
				End If
			Next
		End Sub

		Public Function CopyObjectToDataRow(row As DataRow, target As Object) As Boolean
			Dim result As Boolean = True
			Dim array As MemberInfo() = target.[GetType]().FindMembers(MemberTypes.Field Or MemberTypes.[Property], BindingFlags.IgnoreCase Or BindingFlags.Instance Or BindingFlags.[Static] Or BindingFlags.[Public] Or BindingFlags.NonPublic, Nothing, Nothing)
			Dim array2 As MemberInfo() = array
			For i As Integer = 0 To array2.Length - 1
				Dim memberInfo As MemberInfo = array2(i)
				Dim name As String = memberInfo.Name
				If row.Table.Columns.Contains(name) Then
					Try
						If memberInfo.MemberType = MemberTypes.Field Then
							row(name) = (CType(memberInfo, FieldInfo)).GetValue(target)
						Else
							If memberInfo.MemberType = MemberTypes.[Property] Then
								row(name) = (CType(memberInfo, PropertyInfo)).GetValue(target, Nothing)
							End If
						End If
					Catch ex_7A As Object
						result = False
					End Try
				End If
			Next
			Return result
		End Function

		Public Sub CopyObjectData(source As Object, target As Object)
			DataUtils.CopyObjectData(source, target, BindingFlags.IgnoreCase Or BindingFlags.Instance Or BindingFlags.[Static] Or BindingFlags.[Public] Or BindingFlags.NonPublic)
		End Sub

		Public Sub CopyObjectData(source As Object, target As Object, memberAccess As BindingFlags)
			DataUtils.CopyObjectData(source, target, Nothing, memberAccess)
		End Sub

		Public Sub CopyObjectData(source As Object, target As Object, excludedProperties As String)
			DataUtils.CopyObjectData(source, target, excludedProperties, BindingFlags.IgnoreCase Or BindingFlags.Instance Or BindingFlags.[Static] Or BindingFlags.[Public] Or BindingFlags.NonPublic)
		End Sub

		Public Sub CopyObjectData(source As Object, target As Object, excludedProperties As String, memberAccess As BindingFlags)
			Dim source2 As String() = Nothing
			If Not String.IsNullOrEmpty(excludedProperties) Then
				source2 = excludedProperties.Split(New Char()() = { "," }, StringSplitOptions.RemoveEmptyEntries)
			End If
			Dim members As MemberInfo() = target.[GetType]().GetMembers(memberAccess)
			Dim array As MemberInfo() = members
			For i As Integer = 0 To array.Length - 1
				Dim memberInfo As MemberInfo = array(i)
				Dim name As String = memberInfo.Name
				If String.IsNullOrEmpty(excludedProperties) OrElse Not source2.Contains(name) Then
					If memberInfo.MemberType = MemberTypes.Field Then
						Dim field As FieldInfo = source.[GetType]().GetField(name)
						If Not(field Is Nothing) Then
							Dim value As Object = field.GetValue(source)
							(CType(memberInfo, FieldInfo)).SetValue(target, value)
						End If
					Else
						If memberInfo.MemberType = MemberTypes.[Property] Then
							Dim propertyInfo As PropertyInfo = TryCast(memberInfo, PropertyInfo)
							Dim [property] As PropertyInfo = source.[GetType]().GetProperty(name, memberAccess)
							If Not([property] Is Nothing) AndAlso propertyInfo.CanWrite AndAlso [property].CanRead Then
								Dim value2 As Object = [property].GetValue(source, Nothing)
								propertyInfo.SetValue(target, value2, Nothing)
							End If
						End If
					End If
				End If
			Next
		End Sub

		Public Function DataReaderToObjectList(Of TType As New)(reader As IDataReader, Optional fieldsToSkip As String=Nothing, Optional piList As Dictionary(Of String, PropertyInfo)=Nothing) As List(Of TType)
			If reader Is Nothing Then
				Return Nothing
			End If
			Dim list As List(Of TType) = New List(Of TType)()
			If piList Is Nothing Then
				piList = New Dictionary(Of String, PropertyInfo)()
				Dim properties As PropertyInfo() = GetType(TType).GetProperties(BindingFlags.Instance Or BindingFlags.[Public])
				Dim array As PropertyInfo() = properties
				For i As Integer = 0 To array.Length - 1
					Dim propertyInfo As PropertyInfo = array(i)
					piList.Add(propertyInfo.Name.ToLower(), propertyInfo)
				Next
			End If
			While reader.Read()
				Dim tType As TType = If((Nothing Is Nothing), Activator.CreateInstance(Of TType)(), Nothing)
				DataUtils.DataReaderToObject(reader, tType, fieldsToSkip, piList)
				list.Add(tType)
			End While
			Return list
		End Function

		Public Sub DataReaderToObject(reader As IDataReader, instance As Object, Optional fieldsToSkip As String=Nothing, Optional piList As Dictionary(Of String, PropertyInfo)=Nothing)
			If reader.IsClosed Then
				Throw New InvalidOperationException(Resources.DataReaderPassedToDataReaderToObjectCannot)
			End If
			If String.IsNullOrEmpty(fieldsToSkip) Then
				fieldsToSkip = String.Empty
			Else
				fieldsToSkip = "," + fieldsToSkip + ","
			End If
			fieldsToSkip = fieldsToSkip.ToLower()
			If piList Is Nothing OrElse piList.Count < 1 Then
				If piList Is Nothing Then
					piList = New Dictionary(Of String, PropertyInfo)()
				End If
				Dim properties As PropertyInfo() = instance.[GetType]().GetProperties(BindingFlags.Instance Or BindingFlags.[Public])
				Dim array As PropertyInfo() = properties
				For i As Integer = 0 To array.Length - 1
					Dim propertyInfo As PropertyInfo = array(i)
					piList.Add(propertyInfo.Name.ToLower(), propertyInfo)
				Next
			End If
			For j As Integer = 0 To reader.FieldCount - 1
				Dim text As String = reader.GetName(j).ToLower()
				If piList.ContainsKey(text) Then
					Dim propertyInfo2 As PropertyInfo = piList(text)
					If Not fieldsToSkip.Contains("," + text + ",") AndAlso propertyInfo2 IsNot Nothing AndAlso propertyInfo2.CanWrite Then
						Dim value As Object = reader.GetValue(j)
						propertyInfo2.SetValue(instance, If((value Is DBNull.Value), Nothing, value), Nothing)
					End If
				End If
			Next
		End Sub

		Public Sub InitializeDataRowWithBlanks(row As DataRow)
			Dim columns As DataColumnCollection = row.Table.Columns
			For i As Integer = 0 To columns.Count - 1
				If row.IsNull(i) Then
					Dim name As String = columns(i).DataType.Name
					If name = "String" Then
						row(i) = String.Empty
					Else
						If name.StartsWith("Int") Then
							row(i) = 0
						Else
							If name = "Byte" Then
								row(i) = 0
							Else
								If name = "Decimal" Then
									row(i) = 0.00D
								Else
									If name = "Double" Then
										row(i) = 0.0
									Else
										If name = "Boolean" Then
											row(i) = False
										Else
											If name = "DateTime" Then
												row(i) = DataUtils.MinimumSqlDate
											End If
										End If
									End If
								End If
							End If
						End If
					End If
				End If
			Next
		End Sub

		Public Function SqlTypeToDotNetType(sqlType As SqlDbType) As Type
			If sqlType = SqlDbType.NText OrElse sqlType = SqlDbType.Text OrElse sqlType = SqlDbType.VarChar OrElse sqlType = SqlDbType.NVarChar Then
				Return GetType(String)
			End If
			If sqlType = SqlDbType.Int Then
				Return GetType(Integer)
			End If
			If sqlType = SqlDbType.[Decimal] OrElse sqlType = SqlDbType.Money Then
				Return GetType(Decimal)
			End If
			If sqlType = SqlDbType.Bit Then
				Return GetType(Boolean)
			End If
			If sqlType = SqlDbType.DateTime OrElse sqlType = SqlDbType.DateTime2 Then
				Return GetType(DateTime)
			End If
			If sqlType = SqlDbType.Char OrElse sqlType = SqlDbType.NChar Then
				Return GetType(Char)
			End If
			If sqlType = SqlDbType.Float Then
				Return GetType(Single)
			End If
			If sqlType = SqlDbType.Real Then
				Return GetType(Double)
			End If
			If sqlType = SqlDbType.BigInt Then
				Return GetType(Long)
			End If
			If sqlType = SqlDbType.Image Then
				Return GetType(Byte())
			End If
			If sqlType = SqlDbType.SmallInt Then
				Return GetType(Byte)
			End If
			Throw New InvalidCastException("Unable to convert " + sqlType.ToString() + " to .NET type.")
		End Function

		Public Function DbTypeToDotNetType(sqlType As DbType) As Type
			If sqlType = DbType.[String] OrElse sqlType = DbType.StringFixedLength OrElse sqlType = DbType.AnsiString Then
				Return GetType(String)
			End If
			If sqlType = DbType.Int16 OrElse sqlType = DbType.Int32 Then
				Return GetType(Integer)
			End If
			If sqlType = DbType.Int64 Then
				Return GetType(Long)
			End If
			If sqlType = DbType.[Decimal] OrElse sqlType = DbType.Currency Then
				Return GetType(Decimal)
			End If
			If sqlType = DbType.[Boolean] Then
				Return GetType(Boolean)
			End If
			If sqlType = DbType.DateTime OrElse sqlType = DbType.DateTime2 OrElse sqlType = DbType.[Date] Then
				Return GetType(DateTime)
			End If
			If sqlType = DbType.[Single] Then
				Return GetType(Single)
			End If
			If sqlType = DbType.[Double] Then
				Return GetType(Double)
			End If
			If sqlType = DbType.Binary Then
				Return GetType(Byte())
			End If
			If sqlType = DbType.[SByte] OrElse sqlType = DbType.[Byte] Then
				Return GetType(Byte)
			End If
			If sqlType = DbType.Guid Then
				Return GetType(Guid)
			End If
			Throw New InvalidCastException("Unable to convert " + sqlType.ToString() + " to .NET type.")
		End Function

		Public Function DotNetTypeToDbType(type As Type) As DbType
			If type Is GetType(String) Then
				Return DbType.[String]
			End If
			If type Is GetType(Integer) Then
				Return DbType.Int32
			End If
			If type Is GetType(Short) Then
				Return DbType.Int16
			End If
			If type Is GetType(Long) Then
				Return DbType.Int64
			End If
			If type Is GetType(Guid) Then
				Return DbType.Guid
			End If
			If type Is GetType(Decimal) Then
				Return DbType.[Decimal]
			End If
			If type Is GetType(Double) OrElse type Is GetType(Single) Then
				Return DbType.[Double]
			End If
			If type Is GetType(Single) Then
				Return DbType.[Single]
			End If
			If type Is GetType(Boolean) OrElse type Is GetType(Boolean) Then
				Return DbType.[Boolean]
			End If
			If type Is GetType(DateTime) Then
				Return DbType.DateTime
			End If
			If type Is GetType(DateTimeOffset) Then
				Return DbType.DateTimeOffset
			End If
			If type Is GetType(Byte) Then
				Return DbType.[Byte]
			End If
			If type Is GetType(Byte()) Then
				Return DbType.[Object]
			End If
			Throw New InvalidCastException(String.Format("Unable to cast {0} to a DbType", type.Name))
		End Function

		Public Function DotNetTypeToSqlType(type As Type) As SqlDbType
			If type Is GetType(String) Then
				Return SqlDbType.NVarChar
			End If
			If type Is GetType(Integer) Then
				Return SqlDbType.Int
			End If
			If type Is GetType(Short) Then
				Return SqlDbType.SmallInt
			End If
			If type Is GetType(Long) Then
				Return SqlDbType.BigInt
			End If
			If type Is GetType(Guid) Then
				Return SqlDbType.UniqueIdentifier
			End If
			If type Is GetType(Decimal) Then
				Return SqlDbType.[Decimal]
			End If
			If type Is GetType(Double) OrElse type Is GetType(Single) Then
				Return SqlDbType.Float
			End If
			If type Is GetType(Single) Then
				Return SqlDbType.Float
			End If
			If type Is GetType(Boolean) OrElse type Is GetType(Boolean) Then
				Return SqlDbType.Bit
			End If
			If type Is GetType(DateTime) Then
				Return SqlDbType.DateTime
			End If
			If type Is GetType(DateTimeOffset) Then
				Return SqlDbType.DateTimeOffset
			End If
			If type Is GetType(Byte) Then
				Return SqlDbType.SmallInt
			End If
			If type Is GetType(Byte()) Then
				Return SqlDbType.Image
			End If
			Throw New InvalidCastException(String.Format("Unable to cast {0} to a DbType", type.Name))
		End Function

		Public Function GetSqlCommand(ConnectionString As String, Sql As String, <Out()> ParamArray Parameters As SqlParameter()) As SqlCommand
			Dim sqlCommand As SqlCommand = New SqlCommand()
			sqlCommand.CommandText = Sql
			Try
				If Not ConnectionString.Contains(";") Then
					ConnectionString = ConfigurationManager.ConnectionStrings(ConnectionString).ConnectionString
				End If
				sqlCommand.Connection = New SqlConnection(ConnectionString)
				sqlCommand.Connection.Open()
			Catch ex_42 As Object
				Return Nothing
			End Try
			If Parameters IsNot Nothing Then
				For i As Integer = 0 To Parameters.Length - 1
					Dim value As SqlParameter = Parameters(i)
					sqlCommand.Parameters.Add(value)
				Next
			End If
			Return sqlCommand
		End Function

		Public Function GetSqlDataReader(ConnectionString As String, Sql As String, <Out()> ParamArray Parameters As SqlParameter()) As SqlDataReader
			Dim sqlCommand As SqlCommand = DataUtils.GetSqlCommand(ConnectionString, Sql, Parameters)
			If sqlCommand Is Nothing Then
				Return Nothing
			End If
			Dim result As SqlDataReader = Nothing
			Try
				result = sqlCommand.ExecuteReader()
			Catch ex_19 As Object
				DataUtils.CloseConnection(sqlCommand)
				Return Nothing
			End Try
			Return result
		End Function

		Public Function GetDataTable(Tablename As String, ConnectionString As String, Sql As String, <Out()> ParamArray Parameters As SqlParameter()) As DataTable
			Dim sqlCommand As SqlCommand = DataUtils.GetSqlCommand(ConnectionString, Sql, Parameters)
			If sqlCommand Is Nothing Then
				Return Nothing
			End If
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(sqlCommand)
			Dim dataTable As DataTable = New DataTable(Tablename)
			Try
				sqlDataAdapter.Fill(dataTable)
			Catch ex_26 As Object
				Return Nothing
			Finally
				DataUtils.CloseConnection(sqlCommand)
			End Try
			Return dataTable
		End Function

		Public Sub CloseConnection(Command As SqlCommand)
			If Command.Connection IsNot Nothing AndAlso Command.Connection.State = ConnectionState.Open Then
				Command.Connection.Close()
			End If
		End Sub
	End Module
End Namespace
