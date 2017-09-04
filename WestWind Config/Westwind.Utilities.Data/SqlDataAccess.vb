Imports System
Imports System.Configuration
Imports System.Data
Imports System.Data.Common
Imports System.Data.SqlClient
Imports Westwind.Utilities.Configuration.Properties

Namespace Westwind.Utilities.Data
	Friend Class SqlDataAccess
		Inherits DataAccessBase
		Implements IDisposable

		Public Sub New()
			Me.dbProvider = DbProviderFactories.GetFactory("System.Data.SqlClient")
		End Sub

		Public Sub New(connectionString As String)
			If String.IsNullOrEmpty(connectionString) Then
				Throw New InvalidOperationException(Resources.AConnectionStringMustBePassedToTheConstructor)
			End If
			If Not connectionString.Contains("=") Then
				Dim connectionStringSettings As ConnectionStringSettings = ConfigurationManager.ConnectionStrings(connectionString)
				If connectionStringSettings Is Nothing Then
					Throw New InvalidOperationException(Resources.InvalidConnectionStringName)
				End If
				If Not String.IsNullOrEmpty(connectionStringSettings.ProviderName) Then
					Me.dbProvider = DbProviderFactories.GetFactory(connectionStringSettings.ProviderName)
				Else
					Me.dbProvider = DbProviderFactories.GetFactory("System.Data.SqlClient")
				End If
				connectionString = connectionStringSettings.ConnectionString
			Else
				Me.dbProvider = DbProviderFactories.GetFactory("System.Data.SqlClient")
			End If
			Me.ConnectionString = connectionString
		End Sub

		Public Sub New(connectionString As String, providerName As String)
			Me.dbProvider = DbProviderFactories.GetFactory(providerName)
			Me.ConnectionString = connectionString
		End Sub

		Public Override Function OpenConnection() As Boolean
			Try
				If Me._Connection Is Nothing Then
					If Me.ConnectionString.Contains("=") Then
						Me._Connection = Me.dbProvider.CreateConnection()
						Me._Connection.ConnectionString = Me.ConnectionString
					Else
						Me._Connection = Me.dbProvider.CreateConnection()
						Me._Connection.ConnectionString = ConfigurationManager.ConnectionStrings(Me.ConnectionString).ConnectionString
					End If
				End If
				If Me._Connection.State <> ConnectionState.Open Then
					Me._Connection.Open()
				End If
			Catch ex As DbException
				Me.SetError(ex.Message, ex.ErrorCode)
				Dim result As Boolean = False
				Return result
			Catch ex2 As Exception
				Me.SetError(ex2.GetBaseException().Message)
				Dim result As Boolean = False
				Return result
			End Try
			Return True
		End Function

		Public Override Function CreateCommand(sql As String, commandType As CommandType, <Out()> ParamArray parameters As DbParameter()) As DbCommand
			Me.SetError()
			Dim dbCommand As DbCommand = Me.dbProvider.CreateCommand()
			dbCommand.CommandType = CommandType.Text
			dbCommand.CommandText = sql
			Try
				If Me.Transaction IsNot Nothing Then
					dbCommand.Transaction = Me.Transaction
					dbCommand.Connection = Me.Transaction.Connection
				Else
					If Not Me.OpenConnection() Then
						Dim result As DbCommand = Nothing
						Return result
					End If
					dbCommand.Connection = Me._Connection
				End If
			Catch ex As DbException
				Me.SetError(ex.Message, ex.ErrorCode)
				Dim result As DbCommand = Nothing
				Return result
			Catch ex2 As Exception
				Me.SetError(ex2.GetBaseException().Message)
				Dim result As DbCommand = Nothing
				Return result
			End Try
			If parameters IsNot Nothing Then
				For i As Integer = 0 To parameters.Length - 1
					Dim value As DbParameter = parameters(i)
					dbCommand.Parameters.Add(value)
				Next
			End If
			Return dbCommand
		End Function

		Public Override Function CreateParameter(parameterName As String, value As Object) As DbParameter
			Dim dbParameter As DbParameter = Me.dbProvider.CreateParameter()
			dbParameter.ParameterName = parameterName
			If value Is Nothing Then
				value = DBNull.Value
			End If
			dbParameter.Value = value
			Return dbParameter
		End Function

		Public Override Function ExecuteNonQuery(Command As DbCommand, <Out()> ParamArray Parameters As DbParameter()) As Integer
			Me.SetError()
			Dim num As Integer = 0
			For i As Integer = 0 To Parameters.Length - 1
				Dim value As DbParameter = Parameters(i)
				Command.Parameters.Add(value)
			Next
			Try
				num = Command.ExecuteNonQuery()
				If num = -1 Then
					num = 0
				End If
			Catch [error] As DbException
				num = -1
				Me.SetError([error])
			Catch error2 As Exception
				num = -1
				Me.SetError(error2)
			Finally
				Me.CloseConnection()
			End Try
			Return num
		End Function

		Public Override Function ExecuteReader(Command As DbCommand, <Out()> ParamArray Parameters As DbParameter()) As DbDataReader
			Me.SetError()
			If Command.Connection Is Nothing OrElse Command.Connection.State <> ConnectionState.Open Then
				If Not Me.OpenConnection() Then
					Return Nothing
				End If
				Command.Connection = Me._Connection
			End If
			For i As Integer = 0 To Parameters.Length - 1
				Dim value As DbParameter = Parameters(i)
				Command.Parameters.Add(value)
			Next
			Dim result As DbDataReader = Nothing
			Try
				result = Command.ExecuteReader()
			Catch ex As SqlException
				Me.SetError(ex.Message, ex.Number)
				Me.CloseConnection(Command)
				Return Nothing
			End Try
			Return result
		End Function

		Public Override Function ExecuteTable(Tablename As String, Command As DbCommand, <Out()> ParamArray Parameters As DbParameter()) As DataTable
			Me.SetError()
			For i As Integer = 0 To Parameters.Length - 1
				Dim value As DbParameter = Parameters(i)
				Command.Parameters.Add(value)
			Next
			Dim dbDataAdapter As DbDataAdapter = Me.dbProvider.CreateDataAdapter()
			dbDataAdapter.SelectCommand = Command
			Dim dataTable As DataTable = New DataTable(Tablename)
			Try
				dbDataAdapter.Fill(dataTable)
			Catch ex As Exception
				Me.SetError(ex.Message)
				Return Nothing
			Finally
				Me.CloseConnection(Command)
			End Try
			Return dataTable
		End Function

		Public Override Function ExecuteDataSet(dataSet As DataSet, Tablename As String, Command As DbCommand, <Out()> ParamArray Parameters As DbParameter()) As DataSet
			Me.SetError()
			If dataSet Is Nothing Then
				dataSet = New DataSet()
			End If
			Dim dbDataAdapter As DbDataAdapter = Me.dbProvider.CreateDataAdapter()
			dbDataAdapter.SelectCommand = Command
			If Me.ExecuteWithSchema Then
				dbDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
			End If
			For i As Integer = 0 To Parameters.Length - 1
				Dim value As DbParameter = Parameters(i)
				Command.Parameters.Add(value)
			Next
			New DataTable(Tablename)
			If dataSet.Tables.Contains(Tablename) Then
				dataSet.Tables.Remove(Tablename)
			End If
			Try
				dbDataAdapter.Fill(dataSet, Tablename)
			Catch ex As Exception
				Me.SetError(ex.Message)
				Return Nothing
			Finally
				Me.CloseConnection(Command)
			End Try
			Return dataSet
		End Function

		Public Override Function ExecuteDataSet(Tablename As String, Command As DbCommand, <Out()> ParamArray Parameters As DbParameter()) As DataSet
			Return Me.ExecuteDataSet(Nothing, Tablename, Command, Parameters)
		End Function

		Public Override Function ExecuteScalar(Command As DbCommand, <Out()> ParamArray Parameters As DbParameter()) As Object
			Me.SetError()
			For i As Integer = 0 To Parameters.Length - 1
				Dim value As DbParameter = Parameters(i)
				Command.Parameters.Add(value)
			Next
			Dim result As Object = Nothing
			Try
				result = Command.ExecuteScalar()
			Catch ex As SqlException
				Me.SetError(ex.Message, ex.Number)
			Finally
				Me.CloseConnection()
			End Try
			Return result
		End Function

		Public Override Function ExecuteScalar(Sql As String, <Out()> ParamArray Parameters As DbParameter()) As Object
			Me.SetError()
			Dim dbCommand As DbCommand = Me.CreateCommand(Sql, Parameters)
			If dbCommand Is Nothing Then
				Return Nothing
			End If
			Return Me.ExecuteScalar(dbCommand, New DbParameter(0))
		End Function

		Public Override Sub CloseConnection(Command As DbCommand)
			If Me.Transaction IsNot Nothing Then
				Return
			End If
			If Command.Connection IsNot Nothing AndAlso Command.Connection.State = ConnectionState.Open Then
				Command.Connection.Close()
			End If
			Me._Connection = Nothing
		End Sub

		Public Override Sub CloseConnection()
			If Me.Transaction IsNot Nothing Then
				Return
			End If
			If Me._Connection IsNot Nothing AndAlso Me._Connection.State = ConnectionState.Open Then
				Me._Connection.Close()
			End If
			Me._Connection = Nothing
		End Sub

		Public Override Function CreatePagingCommand(sql As String, pageSize As Integer, page As Integer, sortOrderFields As String, <Out()> ParamArray Parameters As DbParameter()) As DbCommand
			Dim num As Integer = sql.IndexOf("select ", 0, StringComparison.OrdinalIgnoreCase)
			If num = -1 Then
				Me.SetError("Invalid Command for paging. Must start with select and followed by field list")
				Return Nothing
			End If
			sql = StringUtils.ReplaceStringInstance(sql, "select", String.Empty, 1, True)
			Dim sql2 As String = String.Format(vbCrLf & "select * FROM " & vbCrLf & "   (SELECT ROW_NUMBER() OVER (ORDER BY @OrderByFields) as __No,{0}) __TQuery" & vbCrLf & "where __No > (@Page-1) * @PageSize and __No < (@Page * @PageSize + 1)" & vbCrLf, sql)
			Return Me.CreateCommand(sql2, New DbParameter()() = { Me.CreateParameter("@PageSize", pageSize), Me.CreateParameter("@Page", page), Me.CreateParameter("@OrderByFields", sortOrderFields) })
		End Function
	End Class
End Namespace
