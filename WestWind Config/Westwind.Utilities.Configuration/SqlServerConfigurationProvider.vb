Imports System
Imports System.Data.Common
Imports System.Data.SqlClient
Imports Westwind.Utilities.Data

Namespace Westwind.Utilities.Configuration
	Public Class SqlServerConfigurationProvider
		Inherits ConfigurationProviderBase(Of TAppConfiguration)

		Private _ConnectionString As String = String.Empty

		Private _ProviderName As String = "System.Data.SqlClient"

		Private _Tablename As String = "ConfigurationSettings"

		Private _Key As Integer = 1

		Public Property ConnectionString() As String
			Get
				Return Me._ConnectionString
			End Get
			Set(value As String)
				Me._ConnectionString = value
			End Set
		End Property

		Public Property ProviderName() As String
			Get
				Return Me._ProviderName
			End Get
			Set(value As String)
				Me._ProviderName = value
			End Set
		End Property

		Public Property Tablename() As String
			Get
				Return Me._Tablename
			End Get
			Set(value As String)
				Me._Tablename = value
			End Set
		End Property

		Public Property Key() As Integer
			Get
				Return Me._Key
			End Get
			Set(value As Integer)
				Me._Key = value
			End Set
		End Property

		Public Override Function Read(Of T)() As T
			Dim result As T
			Using Dim sqlDataAccess As SqlDataAccess = New SqlDataAccess(Me.ConnectionString, Me.ProviderName)
				Dim sql As String = "select * from [" + Me.Tablename + "] where id=" + Me.Key.ToString()
				Dim dbDataReader As DbDataReader = Nothing
				Try
					Dim dbCommand As DbCommand = sqlDataAccess.CreateCommand(sql, New DbParameter(0))
					If dbCommand Is Nothing Then
						Me.SetError(sqlDataAccess.ErrorMessage)
						result = Nothing
						Return result
					End If
					dbDataReader = dbCommand.ExecuteReader()
					If dbDataReader Is Nothing Then
						Me.SetError(sqlDataAccess.ErrorMessage)
						result = Nothing
						Return result
					End If
				Catch ex As SqlException
					If ex.Number = 208 Then
						sql = "CREATE TABLE [" + Me.Tablename + "]  " & vbLf & "( [id] [int] , [ConfigData] [ntext] COLLATE SQL_Latin1_General_CP1_CI_AS)"
						Try
							sqlDataAccess.ExecuteNonQuery(sql, New DbParameter(0))
						Catch ex_C9 As Object
							result = Nothing
							Return result
						End Try
						result = Me.Read(Of T)()
						Return result
					End If
				Catch ex2 As DbException
					If ex2.ErrorCode = -2147467259 Then
						sql = String.Format("CREATE TABLE [{0}] ( [id] [int] , [ConfigData] [ntext] )", Me.Tablename)
						Try
							sqlDataAccess.ExecuteNonQuery(sql, New DbParameter(0))
						Catch ex_11E As Object
							result = Nothing
							Return result
						End Try
						Dim t As T = Me.Read(Of T)()
						Me.Write(t)
						result = t
						Return result
					End If
					result = Nothing
					Return result
				Catch [error] As Exception
					Me.SetError([error])
					If dbDataReader IsNot Nothing Then
						dbDataReader.Close()
					End If
					sqlDataAccess.CloseConnection()
					result = Nothing
					Return result
				End Try
				Dim text As String = Nothing
				If dbDataReader.Read() Then
					text = CStr(dbDataReader("ConfigData"))
				End If
				dbDataReader.Close()
				sqlDataAccess.CloseConnection()
				If String.IsNullOrEmpty(text) Then
					Dim t2 As T = Activator.CreateInstance(Of T)()
					t2.Provider = Me
					result = t2
				Else
					Dim t3 As T = Me.Read(Of T)(text)
					result = t3
				End If
			End Using
			Return result
		End Function

		Public Override Function Read(config As AppConfiguration) As Boolean
			Dim tAppConfiguration As TAppConfiguration = Me.Read(Of TAppConfiguration)()
			If tAppConfiguration Is Nothing Then
				Return False
			End If
			DataUtils.CopyObjectData(tAppConfiguration, config, "Provider,ErrorMessage")
			Return True
		End Function

		Public Override Function Write(config As AppConfiguration) As Boolean
			Dim sqlDataAccess As SqlDataAccess = New SqlDataAccess(Me.ConnectionString, Me.ProviderName)
			Dim sql As String = String.Format("Update [{0}] set ConfigData=@ConfigData where id={1}", Me.Tablename, Me.Key)
			Dim value As String = Me.WriteAsString(config)
			Dim num As Integer = 0
			Try
				num = sqlDataAccess.ExecuteNonQuery(sql, New DbParameter()() = { sqlDataAccess.CreateParameter("@ConfigData", value) })
			Catch ex_5C As Object
				num = -1
			End Try
			If num = -1 Then
				sql = String.Format("CREATE TABLE [{0}] ( [id] [int] , [ConfigData] [ntext] )", Me.Tablename)
				Try
					num = sqlDataAccess.ExecuteNonQuery(sql, New DbParameter(0))
					If num > -1 Then
						num = 0
					End If
				Catch [error] As Exception
					Me.SetError([error])
					Dim result As Boolean = False
					Return result
				End Try
			End If
			If num = 0 Then
				sql = String.Concat(New String()() = { "Insert [", Me.Tablename, "] (id,configdata) values (", Me.Key.ToString(), ",@ConfigData)" })
				Try
					num = sqlDataAccess.ExecuteNonQuery(sql, New DbParameter()() = { sqlDataAccess.CreateParameter("@ConfigData", value) })
				Catch error2 As Exception
					Me.SetError(error2)
					Dim result As Boolean = False
					Return result
				End Try
				If num = 0 Then
					Return False
				End If
			End If
			Return num >= 0
		End Function
	End Class
End Namespace
