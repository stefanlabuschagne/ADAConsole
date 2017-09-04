Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Common
Imports System.Diagnostics
Imports System.IO
Imports System.Reflection
Imports System.Text
Imports System.Text.RegularExpressions

Namespace Westwind.Utilities.Data
	<DebuggerDisplay("{ErrorMessage}")>
	Friend MustInherit Class DataAccessBase
		Implements IDisposable

		Public dbProvider As DbProviderFactory

		Private _ErrorMessage As String = String.Empty

		Private _ErrorNumber As Integer

		Private _ConnectionString As String = String.Empty

		Private _Transaction As DbTransaction

		Protected _Connection As DbConnection

		Private _ExecuteWithSchema As Boolean

		Public Overridable Property ErrorMessage() As String
			Get
				Return Me._ErrorMessage
			End Get
			Set(value As String)
				Me._ErrorMessage = value
			End Set
		End Property

		Public Property ErrorNumber() As Integer
			Get
				Return Me._ErrorNumber
			End Get
			Set(value As Integer)
				Me._ErrorNumber = value
			End Set
		End Property

		Public Overridable Property ConnectionString() As String
			Get
				Return Me._ConnectionString
			End Get
			Set(value As String)
				Me._ConnectionString = value
			End Set
		End Property

		Public Overridable Property Transaction() As DbTransaction
			Get
				Return Me._Transaction
			End Get
			Set(value As DbTransaction)
				Me._Transaction = value
			End Set
		End Property

		Public Overridable Property Connection() As DbConnection
			Get
				Return Me._Connection
			End Get
			Set(value As DbConnection)
				Me._Connection = value
			End Set
		End Property

		Public Overridable Property ExecuteWithSchema() As Boolean
			Get
				Return Me._ExecuteWithSchema
			End Get
			Set(value As Boolean)
				Me._ExecuteWithSchema = value
			End Set
		End Property

		Public MustOverride Function OpenConnection() As Boolean

		Public MustOverride Function CreateCommand(sql As String, commandType As CommandType, <Out()> ParamArray parameters As DbParameter()) As DbCommand

		Public Overridable Function CreateCommand(sql As String, <Out()> ParamArray parameters As DbParameter()) As DbCommand
			Return Me.CreateCommand(sql, CommandType.Text, parameters)
		End Function

		Public MustOverride Function CreateParameter(parameterName As String, value As Object) As DbParameter

		Public Overridable Function CreateParameter(parameterName As String, value As Object, parameterDirection As ParameterDirection) As DbParameter
			Dim dbParameter As DbParameter = Me.CreateParameter(parameterName, value)
			dbParameter.Direction = parameterDirection
			Return dbParameter
		End Function

		Public Overridable Function CreateParameter(parameterName As String, value As Object, size As Integer) As DbParameter
			Dim dbParameter As DbParameter = Me.CreateParameter(parameterName, value)
			dbParameter.Size = size
			Return dbParameter
		End Function

		Public Overridable Function CreateParameter(parameterName As String, value As Object, type As DbType) As DbParameter
			Dim dbParameter As DbParameter = Me.CreateParameter(parameterName, value)
			dbParameter.DbType = type
			Return dbParameter
		End Function

		Public Overridable Function CreateParameter(parameterName As String, value As Object, type As DbType, size As Integer) As DbParameter
			Dim dbParameter As DbParameter = Me.CreateParameter(parameterName, value)
			dbParameter.DbType = type
			dbParameter.Size = size
			Return dbParameter
		End Function

		Public MustOverride Function ExecuteNonQuery(Command As DbCommand, <Out()> ParamArray Parameters As DbParameter()) As Integer

		Public Overridable Function ExecuteNonQuery(sql As String, <Out()> ParamArray parameters As DbParameter()) As Integer
			Dim dbCommand As DbCommand = Me.CreateCommand(sql, New DbParameter(0))
			If dbCommand Is Nothing Then
				Return-1
			End If
			Return Me.ExecuteNonQuery(dbCommand, parameters)
		End Function

		Public MustOverride Function ExecuteReader(Command As DbCommand, <Out()> ParamArray Parameters As DbParameter()) As DbDataReader

		Public Overridable Function ExecuteReader(sql As String, <Out()> ParamArray parameters As DbParameter()) As DbDataReader
			Dim dbCommand As DbCommand = Me.CreateCommand(sql, parameters)
			If dbCommand Is Nothing Then
				Return Nothing
			End If
			Return Me.ExecuteReader(dbCommand, New DbParameter(0))
		End Function

		Public Overridable Function ExecuteReader(Of T As{Class, New})(sql As String, <Out()> ParamArray parameters As DbParameter()) As List(Of T)
			Dim dbDataReader As DbDataReader = Me.ExecuteReader(sql, parameters)
			If dbDataReader Is Nothing Then
				Return Nothing
			End If
			Dim result As List(Of T) = DataUtils.DataReaderToObjectList(Of T)(dbDataReader, Nothing, Nothing)
			dbDataReader.Close()
			Return result
		End Function

		Public Overridable Function ExecuteReader(Of T As{Class, New})(sql As String, propertiesToExclude As String, <Out()> ParamArray parameters As DbParameter()) As List(Of T)
			Dim dbDataReader As DbDataReader = Me.ExecuteReader(sql, parameters)
			If dbDataReader Is Nothing Then
				Return Nothing
			End If
			Dim result As List(Of T) = DataUtils.DataReaderToObjectList(Of T)(dbDataReader, propertiesToExclude, Nothing)
			dbDataReader.Close()
			Return result
		End Function

		Public Overridable Function ExecuteReader(Of T As{Class, New})(sqlCommand As DbCommand, <Out()> ParamArray parameters As DbParameter()) As List(Of T)
			Dim reader As DbDataReader = Me.ExecuteReader(sqlCommand, parameters)
			Return DataUtils.DataReaderToObjectList(Of T)(reader, Nothing, Nothing)
		End Function

		Public MustOverride Function ExecuteTable(Tablename As String, Command As DbCommand, <Out()> ParamArray Parameters As DbParameter()) As DataTable

		Public Overridable Function ExecuteTable(Tablename As String, Sql As String, <Out()> ParamArray Parameters As DbParameter()) As DataTable
			Me.SetError()
			Dim dbCommand As DbCommand = Me.CreateCommand(Sql, Parameters)
			If dbCommand Is Nothing Then
				Return Nothing
			End If
			Return Me.ExecuteTable(Tablename, dbCommand, New DbParameter(0))
		End Function

		Public MustOverride Function ExecuteDataSet(tablename As String, command As DbCommand, <Out()> ParamArray parameters As DbParameter()) As DataSet

		Public Overridable Function ExecuteDataSet(tablename As String, sql As String, <Out()> ParamArray parameters As DbParameter()) As DataSet
			Return Me.ExecuteDataSet(tablename, Me.CreateCommand(sql, New DbParameter(0)), parameters)
		End Function

		Public MustOverride Function ExecuteDataSet(dataSet As DataSet, Tablename As String, Command As DbCommand, <Out()> ParamArray Parameters As DbParameter()) As DataSet

		Public Overridable Function ExecuteDataSet(dataSet As DataSet, tablename As String, sql As String, <Out()> ParamArray parameters As DbParameter()) As DataSet
			Dim dbCommand As DbCommand = Me.CreateCommand(sql, parameters)
			If dbCommand Is Nothing Then
				Return Nothing
			End If
			Return Me.ExecuteDataSet(dataSet, tablename, dbCommand, New DbParameter(0))
		End Function

		Public MustOverride Function ExecuteScalar(Command As DbCommand, <Out()> ParamArray Parameters As DbParameter()) As Object

		Public Overridable Function ExecuteScalar(sql As String, <Out()> ParamArray parameters As DbParameter()) As Object
			Dim dbCommand As DbCommand = Me.CreateCommand(sql, parameters)
			If dbCommand Is Nothing Then
				Return Nothing
			End If
			Return Me.ExecuteScalar(dbCommand, Nothing)
		End Function

		Public MustOverride Sub CloseConnection(Command As DbCommand)

		Public MustOverride Sub CloseConnection()

		Public Overridable Function CreatePagingCommand(sql As String, pageSize As Integer, page As Integer, sortOrderFields As String, <Out()> ParamArray Parameters As DbParameter()) As DbCommand
			Dim num As Integer = sql.IndexOf("select ", 0, StringComparison.OrdinalIgnoreCase)
			If num = -1 Then
				Me.SetError("Invalid Command for paging. Must start with select and followed by field list")
				Return Nothing
			End If
			sql = StringUtils.ReplaceStringInstance(sql, "select", String.Empty, 1, True)
			Dim sql2 As String = String.Format(vbCrLf & "select * FROM " & vbCrLf & "   (SELECT ROW_NUMBER() OVER (ORDER BY @OrderByFields) as __No,{0}) __TQuery" & vbCrLf & "where __No > (@Page-1) * @PageSize and __No < (@Page * @PageSize + 1)" & vbCrLf, sql)
			Return Me.CreateCommand(sql2, New DbParameter()() = { Me.CreateParameter("@PageSize", pageSize), Me.CreateParameter("@Page", page), Me.CreateParameter("@OrderByFields", sortOrderFields) })
		End Function

		Public Function RunSqlScript(Script As String, ContinueOnError As Boolean, ScriptIsFile As Boolean) As Boolean
			Me.SetError()
			If ScriptIsFile Then
				Try
					Script = File.ReadAllText(Script)
				Catch ex As Exception
					Me.SetError(ex.Message)
					Dim result As Boolean = False
					Return result
				End Try
			End If
			Dim array As String() = Regex.Split(Script + vbCrLf, "GO" & vbCrLf)
			Dim text As String = ""
			If Not ContinueOnError Then
				Me.BeginTransaction()
			End If
			Dim array2 As String() = array
			For i As Integer = 0 To array2.Length - 1
				Dim text2 As String = array2(i)
				If Not String.IsNullOrEmpty(text2.TrimEnd(New Char(0))) AndAlso Me.ExecuteNonQuery(text2, New DbParameter(0)) = -1 Then
					text = Me.ErrorMessage + vbCrLf
					If Not ContinueOnError Then
						Me.RollbackTransaction()
						Dim result As Boolean = False
						Return result
					End If
				End If
			Next
			If Not ContinueOnError Then
				Me.CommitTransaction()
			End If
			If String.IsNullOrEmpty(text) Then
				Return True
			End If
			Me.ErrorMessage = text
			Return False
		End Function

		Public Overridable Function GetEntity(entity As Object, command As DbCommand, fieldsToSkip As String) As Boolean
			Me.SetError()
			If String.IsNullOrEmpty(fieldsToSkip) Then
				fieldsToSkip = String.Empty
			End If
			Dim dbDataReader As DbDataReader = Me.ExecuteReader(command, New DbParameter(0))
			If dbDataReader Is Nothing Then
				Return False
			End If
			If Not dbDataReader.Read() Then
				dbDataReader.Close()
				Me.CloseConnection(command)
				Return False
			End If
			Dim type As Type = entity.[GetType]()
			Dim properties As PropertyInfo() = type.GetProperties(BindingFlags.Instance Or BindingFlags.[Public])
			Dim array As PropertyInfo() = properties
			For i As Integer = 0 To array.Length - 1
				Dim propertyInfo As PropertyInfo = array(i)
				If propertyInfo.CanRead AndAlso propertyInfo.CanWrite Then
					Dim name As String = propertyInfo.Name
					If fieldsToSkip.IndexOf("," + name.ToLower() + ",") <= -1 Then
						Dim obj As Object = Nothing
						Try
							obj = dbDataReader(name)
							If TypeOf obj Is DBNull Then
								obj = Nothing
							End If
						Catch ex_AF As Object
							GoTo IL_BC
						End Try
						propertyInfo.SetValue(entity, obj, Nothing)
					End If
				End If
				IL_BC:
			Next
			dbDataReader.Close()
			Me.CloseConnection()
			Return True
		End Function

		Public Overridable Function GetEntity(Entity As Object, Table As String, KeyField As String, KeyValue As Object, FieldsToSkip As String) As Boolean
			Me.SetError()
			Dim dbCommand As DbCommand = Me.CreateCommand(String.Concat(New String()() = { "select * from ", Table, " where [", KeyField, "]=@Key" }), New DbParameter()() = { Me.CreateParameter("@Key", KeyValue) })
			Return dbCommand IsNot Nothing AndAlso Me.GetEntity(Entity, dbCommand, FieldsToSkip)
		End Function

		Public Overridable Function UpdateEntity(entity As Object, table As String, keyField As String, Optional fieldsToSkip As String=Nothing) As Boolean
			Me.SetError()
			If String.IsNullOrEmpty(fieldsToSkip) Then
				fieldsToSkip = String.Empty
			Else
				fieldsToSkip = "," + fieldsToSkip.ToLower() + ","
			End If
			Dim dbCommand As DbCommand = Me.CreateCommand(String.Empty, New DbParameter(0))
			Dim type As Type = entity.[GetType]()
			Dim stringBuilder As StringBuilder = New StringBuilder()
			stringBuilder.Append("update " + table + " set ")
			Dim properties As PropertyInfo() = type.GetProperties(BindingFlags.Instance Or BindingFlags.[Public])
			Dim array As PropertyInfo() = properties
			For i As Integer = 0 To array.Length - 1
				Dim propertyInfo As PropertyInfo = array(i)
				If propertyInfo.CanRead Then
					Dim name As String = propertyInfo.Name
					If fieldsToSkip.IndexOf("," + name.ToLower() + ",") <= -1 Then
						Dim value As Object = propertyInfo.GetValue(entity, Nothing)
						stringBuilder.Append(String.Concat(New String()() = { " [", name, "]=@", name, "," }))
						dbCommand.Parameters.Add(Me.CreateParameter("@" + name, value))
					End If
				End If
			Next
			Dim [property] As Object = ReflectionUtils.GetProperty(entity, keyField)
			Dim commandText As String = stringBuilder.ToString().TrimEnd(New Char()() = { "," }) + " where " + keyField + "=@__PK"
			dbCommand.Parameters.Add(Me.CreateParameter("@__PK", [property]))
			dbCommand.CommandText = commandText
			Dim result As Boolean = Me.ExecuteNonQuery(dbCommand, New DbParameter(0)) > -1
			Me.CloseConnection(dbCommand)
			Return result
		End Function

		Public Overridable Function UpdateEntity(Entity As Object, Table As String, KeyField As String, FieldsToSkip As String, FieldsToUpdate As String) As Boolean
			Me.SetError()
			If FieldsToSkip Is Nothing Then
				FieldsToSkip = String.Empty
			Else
				FieldsToSkip = "," + FieldsToSkip.ToLower() + ","
			End If
			Dim dbCommand As DbCommand = Me.CreateCommand(String.Empty, New DbParameter(0))
			Dim type As Type = Entity.[GetType]()
			Dim stringBuilder As StringBuilder = New StringBuilder()
			stringBuilder.Append("update " + Table + " set ")
			Dim array As String() = FieldsToUpdate.Split(New Char()() = { "," })
			Dim array2 As String() = array
			For i As Integer = 0 To array2.Length - 1
				Dim text As String = array2(i)
				If FieldsToSkip.IndexOf("," + text.ToLower() + ",") <= -1 Then
					Dim [property] As PropertyInfo = type.GetProperty(text)
					If Not([property] Is Nothing) Then
						Dim value As Object = [property].GetValue(Entity, Nothing)
						stringBuilder.Append(String.Concat(New String()() = { " [", text, "]=@", text, "," }))
						dbCommand.Parameters.Add(Me.CreateParameter("@" + text, value))
					End If
				End If
			Next
			Dim property2 As Object = ReflectionUtils.GetProperty(Entity, KeyField)
			Dim commandText As String = stringBuilder.ToString().TrimEnd(New Char()() = { "," }) + " where " + KeyField + "=@__PK"
			dbCommand.Parameters.Add(Me.CreateParameter("@__PK", property2))
			dbCommand.CommandText = commandText
			Dim result As Boolean = Me.ExecuteNonQuery(dbCommand, New DbParameter(0)) > -1
			Me.CloseConnection(dbCommand)
			Return result
		End Function

		Public Function InsertEntity(entity As Object, table As String, Optional fieldsToSkip As String=Nothing) As Object
			Me.SetError()
			If String.IsNullOrEmpty(fieldsToSkip) Then
				fieldsToSkip = String.Empty
			Else
				fieldsToSkip = "," + fieldsToSkip.ToLower() + ","
			End If
			Dim dbCommand As DbCommand = Me.CreateCommand(String.Empty, New DbParameter(0))
			Dim type As Type = entity.[GetType]()
			Dim stringBuilder As StringBuilder = New StringBuilder()
			Dim stringBuilder2 As StringBuilder = New StringBuilder()
			stringBuilder.Append("insert " + table + " (")
			stringBuilder2.Append(" values (")
			Dim properties As PropertyInfo() = type.GetProperties(BindingFlags.Instance Or BindingFlags.[Public])
			Dim array As PropertyInfo() = properties
			For i As Integer = 0 To array.Length - 1
				Dim propertyInfo As PropertyInfo = array(i)
				If propertyInfo.CanRead Then
					Dim name As String = propertyInfo.Name
					If fieldsToSkip.IndexOf("," + name.ToLower() + ",") <= -1 Then
						Dim value As Object = propertyInfo.GetValue(entity, Nothing)
						stringBuilder.Append("[" + name + "],")
						stringBuilder2.Append("@" + name + ",")
						dbCommand.Parameters.Add(Me.CreateParameter("@" + name, If((value Is Nothing), DBNull.Value, value)))
					End If
				End If
			Next
			dbCommand.CommandText = stringBuilder.ToString().TrimEnd(New Char()() = { "," }) + ") " + stringBuilder2.ToString().TrimEnd(New Char()() = { "," }) + ");select SCOPE_IDENTITY()"
			Dim result As Object = Me.ExecuteScalar(dbCommand, New DbParameter(0))
			Me.CloseConnection()
			Return result
		End Function

		Public Overridable Function SaveEntity(entity As Object, table As String, keyField As String, Optional fieldsToSkip As String=Nothing) As Boolean
			Dim [property] As Object = ReflectionUtils.GetProperty(entity, keyField)
			Dim obj As Object = Nothing
			If [property] IsNot Nothing Then
				obj = Me.ExecuteScalar(String.Concat(New String()() = { "select [", keyField, "] from [", table, "] where [", keyField, "]=@id" }), New DbParameter()() = { Me.CreateParameter("@id", [property]) })
			End If
			If obj Is Nothing Then
				Me.InsertEntity(entity, table, fieldsToSkip)
				Return String.IsNullOrEmpty(Me.ErrorMessage)
			End If
			Return Me.UpdateEntity(entity, table, keyField, fieldsToSkip)
		End Function

		Public Overridable Function BeginTransaction() As Boolean
			If Me._Connection Is Nothing AndAlso Not Me.OpenConnection() Then
				Return False
			End If
			Me.Transaction = Me._Connection.BeginTransaction()
			Return Me.Transaction IsNot Nothing
		End Function

		Public Overridable Function CommitTransaction() As Boolean
			If Me.Transaction Is Nothing Then
				Me.SetError("No active Transaction to commit.")
				Return False
			End If
			Me.Transaction.Commit()
			Me.Transaction = Nothing
			Me.CloseConnection()
			Return True
		End Function

		Public Overridable Function RollbackTransaction() As Boolean
			If Me.Transaction Is Nothing Then
				Return True
			End If
			Me.Transaction.Rollback()
			Me.Transaction = Nothing
			Me.CloseConnection()
			Return True
		End Function

		Protected Overridable Sub SetError(Message As String, errorNumber As Integer)
			If String.IsNullOrEmpty(Message) Then
				Me.ErrorMessage = String.Empty
				Me.ErrorNumber = 0
				Return
			End If
			Me.ErrorMessage = Message
			Me.ErrorNumber = errorNumber
		End Sub

		Protected Overridable Sub SetError(message As String)
			Me.SetError(message, 0)
		End Sub

		Protected Overridable Sub SetError(ex As DbException)
			Me.SetError(ex.Message, ex.ErrorCode)
		End Sub

		Protected Overridable Sub SetError(ex As Exception)
			Me.SetError(ex.Message, 0)
		End Sub

		Protected Overridable Sub SetError()
			Me.SetError(Nothing, 0)
		End Sub

		Public Sub Dispose()
			If Me._Connection IsNot Nothing Then
				Me.CloseConnection()
			End If
		End Sub
	End Class
End Namespace
