Imports System.Collections.Generic
Imports System.Globalization
Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.Linq
Imports System.Threading

Namespace FTP
	Class FTPSession
		Private _lastcmdtime As DateTime, _conntime As DateTime
		Private _server As FTPServer
		Private _currentDir As String, _localpath As String
		Private _clientSocket As Socket, _datasocket As Socket
		Private _connuser As String
		Private _isAuthenticated As Boolean
		Private DataTransferEnabled As Boolean = False
		Private DataListener As TcpListener = Nothing
		Private _renamefrom As String
		Private _portBuffer As Byte() = New Byte(499) {}
		Private _utf8 As Boolean, _activecommand As Boolean
		' Used inside PORT method
		Private ClientEndPoints As IPEndPoint()
		Private _currentperms As FTPUserPermission

		Friend ReadOnly Property SessionID() As String
			Get
				Return _conntime.Ticks.ToString()
			End Get
		End Property

		Friend ReadOnly Property EndPoint() As String
			Get
				Return _clientSocket.RemoteEndPoint.ToString()
			End Get
		End Property

		Friend ReadOnly Property IsConnected() As Boolean
			Get
				If _clientSocket Is Nothing OrElse Not _clientSocket.Connected OrElse _conntime.ToString("HH:mm:ss") = _lastcmdtime.ToString("HH:mm:ss") Then
					Disconnect()
					Return False
				End If
				Return True
			End Get
		End Property

		Friend ReadOnly Property LastCommandTime() As DateTime
			Get
				Return _lastcmdtime
			End Get
		End Property

		Friend Sub New(ClientSocket As Socket, serv As FTPServer, startdir As String)
			Dim p As IPEndPoint = DirectCast(ClientSocket.LocalEndPoint, IPEndPoint)
			If serv.BannedAdresses.Contains(p.Address) AndAlso Not serv.AcceptedAdresses.Contains(p.Address) Then
				Disconnect()
			Else
				Me._clientSocket = ClientSocket
				ClientSocket.NoDelay = False
				_conntime = DateTime.Now
				_server = serv
				_currentDir = startdir
				SendMessage("220 FTP Ready")

				' Wait for the command to be sent by the client
				ClientSocket.BeginReceive(_portBuffer, 0, _portBuffer.Length, SocketFlags.None, New AsyncCallback(AddressOf CommandReceived), Nothing)
			End If
		End Sub

		Friend Sub Disconnect()
			If _clientSocket IsNot Nothing AndAlso _clientSocket.Connected Then
				_clientSocket.Close()
			End If
			_clientSocket = Nothing
			If DataListener IsNot Nothing Then
				DataListener.[Stop]()
			End If
			DataListener = Nothing
			If _datasocket IsNot Nothing AndAlso _datasocket.Connected Then
				_datasocket.Close()
			End If
			_datasocket = Nothing
			_connuser = Nothing
			ClientEndPoints = Nothing
			_server.RemoveClient(Me)
			_portBuffer = Nothing
			_renamefrom = Nothing
			GC.Collect()
		End Sub

		Private Sub CommandReceived(arg As IAsyncResult)
			_activecommand = False
			Dim CommandSize As Integer = 0
			Try
				CommandSize = _clientSocket.EndReceive(arg)
			Catch
			End Try
			If CommandSize = 0 Then
					'return;
				Disconnect()
			End If

			' Wait for the next command to be sent by the client
			Try
				_clientSocket.BeginReceive(_portBuffer, 0, _portBuffer.Length, SocketFlags.None, New AsyncCallback(AddressOf CommandReceived), Nothing)
			Catch
				Disconnect()
				Return
			End Try

			_lastcmdtime = DateTime.Now
			Dim CommandText As String
			If _utf8 Then
				CommandText = Encoding.UTF8.GetString(_portBuffer, 0, CommandSize).TrimStart(" "C)
			Else
				CommandText = Encoding.ASCII.GetString(_portBuffer, 0, CommandSize).TrimStart(" "C)
			End If
			Dim CmdArguments As String = Nothing, Command As String = Nothing
			Dim [End] As Integer = 0
			If (InlineAssignHelper([End], CommandText.IndexOf(" "C))) = -1 Then
				[End] = (InlineAssignHelper(CommandText, CommandText.Trim())).Length
			Else
				CmdArguments = CommandText.Substring([End]).TrimStart(" "C)
			End If
			Command = CommandText.Substring(0, [End]).ToUpper()

			If CmdArguments IsNot Nothing AndAlso CmdArguments.EndsWith(vbCr & vbLf) Then
				CmdArguments = CmdArguments.Substring(0, CmdArguments.Length - 2)
			End If
			Dim CommandExecued As Boolean = False
			Select Case Command
				Case "USER"
					_activecommand = True
					If CmdArguments IsNot Nothing AndAlso CmdArguments.Length > 0 Then
						SendMessage("331 Password required!")
						_connuser = CmdArguments
					End If
					CommandExecued = True
					Exit Select
				Case "PASS"
					_activecommand = True
					If _connuser = "" Then
						SendMessage("503 Invalid User Name")
						Return
					End If
					If _server.Users(_connuser) IsNot Nothing Then
						If _server.Users(_connuser).SHA1Password = HelperFunctions.SHA1Hash(CmdArguments) Then
							_isAuthenticated = True
							_currentDir = "/"
							_currentperms = _server.Users.GetPermissions(_connuser)
							If String.IsNullOrEmpty(_server.Users(_connuser).Startupdir) OrElse _server.Users(_connuser).Startupdir = "/" Then
								_localpath = _server.StartupDir
							Else
								_localpath = _server.Users(_connuser).Startupdir
							End If
							_server.Call_Log(New FTPLogEventArgs(FTPLogEventType.UserConnect, _connuser, True, 230, "none"))
							SendMessage("230 Authentication Successful")
						Else
							SendMessage("530 Authentication Failed!")
							_server.Call_Log(New FTPLogEventArgs(FTPLogEventType.UserConnect, _connuser, False, 530, "none"))
						End If
					Else
						SendMessage("530 Authentication Failed!")
						_server.Call_Log(New FTPLogEventArgs(FTPLogEventType.UserConnect, _connuser, False, 530, "none"))
					End If
					CommandExecued = True
					Exit Select
			End Select
			If Not CommandExecued Then
				If Not _isAuthenticated Then
					SendMessage("530 Access Denied! Authenticate first")
					Return
				End If
				Select Case Command.ToUpper()
					Case "CWD"
						_activecommand = True
						CWD(CmdArguments)
						Exit Select

					Case "CDUP"
						_activecommand = True
						Dim pathParts As String() = _currentDir.Split("/"C)
						If pathParts.Length > 1 Then
							_currentDir = ""
							For i As Integer = 0 To (pathParts.Length - 2) - 1
								_currentDir += pathParts(i) & "/"
							Next
							If _currentDir.Length = 0 Then
								_currentDir = "/"
							End If
						End If
						SendMessage("250 CDUP command successful.")
						Exit Select

					Case "QUIT"
						_activecommand = True
						SendMessage("221 FTP server signing off")
						Disconnect()
						Exit Select

					Case "PWD"
						_activecommand = True
						SendMessage("257 """ & _currentDir & """")
						Exit Select

					Case "PORT"
						_activecommand = True
						PORT(CmdArguments)
						'done
						Exit Select

					Case "PASV"
						_activecommand = True
						PASV(CmdArguments)
						'done
						Exit Select

					Case "TYPE"
						_activecommand = True
						TYPE(CmdArguments)
						'done
						Exit Select

					Case "SYST"
						_activecommand = True
						SendMessage("215 Windows_NT")
						Exit Select

					Case "NOOP"
						_activecommand = True
						SendMessage("200 OK")
						Exit Select

					Case "RETR"
						_activecommand = True
						RETR(CmdArguments)
						Exit Select

					Case "STOR"
						_activecommand = True
						STOR(CmdArguments, False)
						Exit Select

					Case "APPE"
						_activecommand = True
						APPE(CmdArguments)
						Exit Select

					Case "RNFR"
						_activecommand = True
						RNFR(CmdArguments)
						Exit Select

					Case "RNTO"
						_activecommand = True
						RNTO(CmdArguments)
						Exit Select
					Case "DELE"
						_activecommand = True
						DELE(CmdArguments)
						Exit Select

					Case "RMD"
						_activecommand = True
						RMD(CmdArguments)
						Exit Select

					Case "MKD"
						_activecommand = True
						MKD(CmdArguments)
						Exit Select

					Case "LIST"
						_activecommand = True
						LIST(_currentDir)
						Exit Select

					Case "NLST"
						_activecommand = True
						NLST(CmdArguments)
						Exit Select

					'case "CLNT":
'                        break;

					Case "MDTM"
						_activecommand = True
						MDTM(CmdArguments)
						Exit Select

					Case "SIZE"
						_activecommand = True
						SIZE(CmdArguments)
						Exit Select

					Case "OPTS"
						_activecommand = True
						OPTS(CmdArguments)
						Exit Select

					Case "REIN"
						_activecommand = True
						REIN(CmdArguments)
						Exit Select

					Case "STOU"
						_activecommand = True
						STOR(CmdArguments, True)
						Exit Select

					Case "ABOR", "SHUTDOWN"
						If _datasocket IsNot Nothing AndAlso _datasocket.Connected Then
							_datasocket.Close()
						End If
						_datasocket = Nothing
						GC.Collect()
						SendMessage("200 Data transfer aborted")
						_server.Call_Log(New FTPLogEventArgs(FTPLogEventType.Abort, _connuser, True, 200))
						Exit Select

					Case "FEAT"
						SendMessage("  SIZE")
						SendMessage("  MTDM")
						SendMessage("211 Feature list end")
						_server.Call_Log(New FTPLogEventArgs(FTPLogEventType.FeatureList, _connuser, True, 211))
						Exit Select
					Case Else

						SendMessage("500 Unknown Command.")
						_server.Call_Log(New FTPLogEventArgs(FTPLogEventType.UnknownCommand, _connuser, True, 500, Command, CmdArguments))
						Exit Select

					'	case "STAT":
					'		break;

					'	case "HELP":
					'		break;

					'	case "REST":
					'		break;
				End Select
			End If
		End Sub

		#Region "CWD"
		Private Sub CWD(CmdArguments As String)
			Dim navpath As String
			Dim full As Boolean = Fullpath(CmdArguments)
			If full Then
				navpath = CmdArguments
			Else
				navpath = _currentDir & "/" & CmdArguments
			End If

			If navpath.Contains("..") Then
				Dim parts As String() = _currentDir.Split("/"C)
				Dim sb As New StringBuilder()
				sb.Append("/"C)
				For i As Integer = 0 To parts.Length - 2
					sb.Append(parts(i))
					sb.Append("/"C)
				Next
				_currentDir = sb.ToString()
				_currentDir = HelperFunctions.FixPath(_currentDir)
				SendMessage("250 CWD command successful.")
				_server.Call_Log(New FTPLogEventArgs(FTPLogEventType.ChangeWorkDir, _connuser, True, 250, _currentDir))
			Else
				If DirectoryExists(navpath) OrElse _server.VFS.PathExists(navpath) Then
					If full Then
						_currentDir = navpath
					Else
						_currentDir += "/" & CmdArguments
						_currentDir = HelperFunctions.FixPath(_currentDir)
					End If
					SendMessage("250 CWD command successful.")
					_server.Call_Log(New FTPLogEventArgs(FTPLogEventType.ChangeWorkDir, _connuser, True, 250, _currentDir))
				Else
					SendMessage("550 System can't find directory.")
					_server.Call_Log(New FTPLogEventArgs(FTPLogEventType.ChangeWorkDir, _connuser, False, 250, _currentDir))

				End If
			End If

		End Sub
		#End Region

		#Region "Type"
		Private Sub TYPE(CmdArguments As String)
			If (InlineAssignHelper(CmdArguments, CmdArguments.Trim().ToUpper())) = "A" OrElse CmdArguments = "I" Then
				SendMessage("200 Type " & CmdArguments & " Accepted.")
				_server.Call_Log(New FTPLogEventArgs(FTPLogEventType.ChangeType, _connuser, True, 200, CmdArguments))
			Else
				SendMessage("500 Unknown Type.")
				_server.Call_Log(New FTPLogEventArgs(FTPLogEventType.ChangeType, _connuser, False, 200, CmdArguments))
			End If
		End Sub
		#End Region

		#Region "PORT"
		Private Sub PORT(CmdArguments As String)
			Dim IP_Parts As String() = CmdArguments.Split(","C)
			If IP_Parts.Length <> 6 Then
				SendMessage("550 Invalid arguments.")
				_server.Call_Log(New FTPLogEventArgs(FTPLogEventType.PortCommand, _connuser, False, 550, "Invalid arguments", CmdArguments))
				Return
			End If

			Dim ClientIP As String = IP_Parts(0) & "." & IP_Parts(1) & "." & IP_Parts(2) & "." & IP_Parts(3)
			Dim tmpPort As Integer = (Convert.ToInt32(IP_Parts(4)) << 8) Or Convert.ToInt32(IP_Parts(5))

			Dim client As IPAddress() = Dns.GetHostEntry(ClientIP).AddressList
			ClientEndPoints = New IPEndPoint(client.Length - 1) {}
			For i As Integer = 0 To client.Length - 1
				ClientEndPoints(i) = New IPEndPoint(client(i), tmpPort)
			Next
			DataTransferEnabled = False

			SendMessage("200 Ready to connect to " & ClientIP & "")
			_server.Call_Log(New FTPLogEventArgs(FTPLogEventType.PortCommand, _connuser, True, 200, CmdArguments))
		End Sub
		#End Region

		#Region "PASV"
		Private Sub PASV(CmdArguments As String)
			' Open listener within the specified port range
			Dim tmpPort As Integer = _server.PassivePortMinimum
			StartListener:
			If DataListener IsNot Nothing Then
				DataListener.[Stop]()
				DataListener = Nothing
			End If
			Try
				DataListener = New TcpListener(IPAddress.Any, tmpPort)
				DataListener.Start()
			Catch
				If tmpPort < _server.PassivePortMaximum Then
					tmpPort += 1
					GoTo StartListener
				Else
					SendMessage("500 Action Failed Retry")
					_server.Call_Log(New FTPLogEventArgs(FTPLogEventType.PassiveMode, _connuser, False, 500))
					Return
				End If
			End Try

			'string tmpEndPoint = DataListener.LocalEndpoint.ToString();
			'tmpPort = Convert.ToInt32(tmpEndPoint.Substring(tmpEndPoint.IndexOf(':') + 1));

			Dim SocketEndPoint As String = _clientSocket.LocalEndPoint.ToString()

			SocketEndPoint = SocketEndPoint.Substring(0, SocketEndPoint.IndexOf(":")).Replace(".", ",") & "," & (tmpPort >> 8) & "," & (tmpPort And 255)
			DataTransferEnabled = True

			SendMessage("227 Entering Passive Mode (" & SocketEndPoint & ").")
			_server.Call_Log(New FTPLogEventArgs(FTPLogEventType.PassiveMode, _connuser, True, 500, SocketEndPoint))
		End Sub
		#End Region

		#Region "RETR"
		Private Sub RETR(CmdArguments As String)

			Dim fileStream As Stream = Nothing
			Dim navpath As String
			Dim full As Boolean = Fullpath(CmdArguments)
			If full Then
				navpath = CmdArguments
			Else
				navpath = _currentDir & "/" & CmdArguments
			End If


			Dim file__1 As String = GetExactPath(navpath)
			Try
				If _server.VFS.IsVirtualFile(navpath) Then
					fileStream = _server.VFS.GetFileContents(navpath)
				Else
					fileStream = File.OpenRead(file__1)
				End If
			Catch
				SendMessage("550 Access denied or directory dosen't exist !")
				_server.Call_Log(New FTPLogEventArgs(FTPLogEventType.DownloadFile, _connuser, False, 550, file__1, "Access denied or directory dosen't exist"))
				Return
			End Try

			_datasocket = Me.GetDataSocket()
			If _datasocket Is Nothing Then
				Return
			End If

			Try
				If fileStream IsNot Nothing Then
					SendMessage("250 Transfer started")
					' ToDo: bandwidth limiting here
					Dim readed As Integer = 1
					Dim cnt As Integer = 0

					If _server.DownloadSpeedLimit > 0 Then
						While readed > 0
							Dim data As Byte() = New Byte(9999) {}
							readed = fileStream.Read(data, 0, data.Length)
							cnt += readed
							_datasocket.Send(data, readed, SocketFlags.None)
							If cnt >= _server.DownloadSpeedLimit Then
								Thread.Sleep(1000)
								cnt = 0
							End If
						End While
					Else
						While readed > 0
							Dim data As Byte() = New Byte(9999) {}
							readed = fileStream.Read(data, 0, data.Length)
							cnt += readed
							_datasocket.Send(data, readed, SocketFlags.None)
						End While
					End If
				End If

				_datasocket.Shutdown(SocketShutdown.Both)
				_datasocket.Close()
				_datasocket = Nothing
				GC.Collect()

				SendMessage("226 Transfer Complete.")
				_server.Call_Log(New FTPLogEventArgs(FTPLogEventType.DownloadFile, _connuser, True, 226, file__1))
			Catch
				SendMessage("426 Connection closed; transfer aborted.")
				_server.Call_Log(New FTPLogEventArgs(FTPLogEventType.DownloadFile, _connuser, False, 426, file__1, "Transfer aborted"))
			End Try

			fileStream.Close()
		End Sub
		#End Region

		#Region "STOR"
		Private Sub STOR(CmdArguments As String, unique As Boolean)
			If _currentperms.Upload Then
				Dim fileStream As Stream = Nothing
				Dim file__1 As String = Nothing, name As String = Nothing
				Try
					If unique Then
						name = HelperFunctions.GenerateUniqueFileName()
						file__1 = GetExactPath(_currentDir & "/" & name)
					Else
						name = CmdArguments
						file__1 = GetExactPath(_currentDir & "/" & name)
					End If

					If File.Exists(file__1) Then
						File.Delete(file__1)
					End If
					fileStream = File.OpenWrite(file__1)
					If unique Then
						SendMessage("250 " & name)
					Else
						SendMessage("250 Transfer started")
					End If
				Catch
					SendMessage("550 Access denied or directory dosen't exist !")
					_server.Call_Log(New FTPLogEventArgs(FTPLogEventType.UploadFile, _connuser, False, 550, file__1, "Access denied or directory dosen't exist"))
					Return
				End Try

				_datasocket = GetDataSocket()
				If _datasocket Is Nothing Then
					Return
				End If
				Try
					If fileStream IsNot Nothing Then
						' ToDo: bandwidth limiting here

						Dim readed As Integer = 1
						Dim cnt As Integer = 0

						If _server.UploadSpeedLimit > 0 Then

							While readed > 0
								Dim data As Byte() = New Byte(9999) {}
								readed = _datasocket.Receive(data)
								cnt += readed
								fileStream.Write(data, 0, readed)
								If cnt > _server.UploadSpeedLimit Then
									Thread.Sleep(1000)
									cnt = 0
								End If
							End While
						Else
							While readed > 0
								Dim data As Byte() = New Byte(9999) {}
								readed = _datasocket.Receive(data)
								fileStream.Write(data, 0, readed)
							End While
						End If
					End If

					_datasocket.Shutdown(SocketShutdown.Both)
					_datasocket.Close()
					_datasocket = Nothing
					GC.Collect()
					SendMessage("226 Transfer Complete.")
					_server.Call_Log(New FTPLogEventArgs(FTPLogEventType.UploadFile, _connuser, True, 226, file__1))
				Catch
					SendMessage("426 Connection closed; transfer aborted.")
					_server.Call_Log(New FTPLogEventArgs(FTPLogEventType.UploadFile, _connuser, False, 426, file__1, "Transfer aborted"))
				End Try

				fileStream.Close()
			Else
				SendMessage("550 Access denied")
				_server.Call_Log(New FTPLogEventArgs(FTPLogEventType.UploadFile, _connuser, False, 550, "Acces Denied"))
			End If
		End Sub
		#End Region

		#Region "DELE"
		Private Sub DELE(CmdArguments As String)
			If _currentperms.Delete Then
				Dim navpath As String
				Dim full As Boolean = Fullpath(CmdArguments)
				If full Then
					navpath = CmdArguments
				Else
					navpath = _currentDir & "/" & CmdArguments
				End If

				Dim file__1 As String = GetExactPath(navpath)

				Try
					File.Delete(file__1)
					SendMessage("250 file deleted.")
					_server.Call_Log(New FTPLogEventArgs(FTPLogEventType.DeleteFile, _connuser, True, 250, file__1))
				Catch
					SendMessage("550 file delete failed")
					_server.Call_Log(New FTPLogEventArgs(FTPLogEventType.DeleteFile, _connuser, False, 550, file__1, "Delete failed"))
				End Try
			Else
				SendMessage("550 Acces Denied")
				_server.Call_Log(New FTPLogEventArgs(FTPLogEventType.DeleteFile, _connuser, False, 550, "Acces Denied"))
			End If
		End Sub
		#End Region

		#Region "APPE"
		Private Sub APPE(CmdArguments As String)
			Dim fileStream As Stream = Nothing
			Dim navpath As String
			Dim full As Boolean = Fullpath(CmdArguments)
			If full Then
				navpath = CmdArguments
			Else
				navpath = _currentDir & "/" & CmdArguments
			End If

			Dim file__1 As String = GetExactPath(navpath)
			If _currentperms.Upload Then
				Try
					fileStream = File.Open(file__1, FileMode.Append)
				Catch
					SendMessage("550 File Upload error")
					_server.Call_Log(New FTPLogEventArgs(FTPLogEventType.AppendFile, _connuser, False, 550, file__1, "File Upload error"))
					Return
				End Try

				_datasocket = GetDataSocket()
				If _datasocket Is Nothing Then
					Return
				End If
				Try
					If fileStream IsNot Nothing Then
						' ToDo: bandwidth limiting here

						Dim readed As Integer = 1
						While readed > 0
							Dim data As Byte() = New Byte(9999) {}
							readed = _datasocket.Receive(data)
							fileStream.Write(data, 0, readed)
						End While
					End If

					_datasocket.Shutdown(SocketShutdown.Both)
					_datasocket.Close()
					_datasocket = Nothing
					GC.Collect()
					SendMessage("226 Transfer Complete.")
					_server.Call_Log(New FTPLogEventArgs(FTPLogEventType.AppendFile, _connuser, True, 226, file__1))
				Catch
					SendMessage("426 Connection closed; transfer aborted.")
					_server.Call_Log(New FTPLogEventArgs(FTPLogEventType.AppendFile, _connuser, False, 426, file__1, "Transfer aborted"))
				End Try


				fileStream.Close()
			Else
				SendMessage("550 Access denied")
				_server.Call_Log(New FTPLogEventArgs(FTPLogEventType.AppendFile, _connuser, False, 550, "Access denied"))
			End If

		End Sub
		#End Region

		#Region "RNFR"
		Private Sub RNFR(CmdArguments As String)
			Dim navpath As String
			Dim full As Boolean = Fullpath(CmdArguments)
			If full Then
				navpath = CmdArguments
			Else
				navpath = _currentDir & "/" & CmdArguments
			End If

			Dim dir As String = GetExactPath(navpath)
			If DirectoryExists(dir) OrElse FileExists(dir) Then
				SendMessage("350 Please specify destination name.")
				_renamefrom = dir
			Else
				SendMessage("550 File or directory doesn't exist.")
			End If
		End Sub
		#End Region

		#Region "RNTO"
		Private Sub RNTO(CmdArguments As String)
			If _currentperms.Rename Then
				Dim navpath As String
				Dim full As Boolean = Fullpath(CmdArguments)
				If full Then
					navpath = CmdArguments
				Else
					navpath = _currentDir & "/" & CmdArguments
				End If

				If String.IsNullOrEmpty(_renamefrom) Then
					SendMessage("503 Bad sequence of commands.")
					Return
				End If
				Dim dir As String = GetExactPath(navpath)

				Try
					If File.Exists(_renamefrom) Then
						File.Move(_renamefrom, dir)
						SendMessage("250 File renamed")

						_server.Call_Log(New FTPLogEventArgs(FTPLogEventType.Rename, _connuser, True, 250, _renamefrom, dir))
					ElseIf Directory.Exists(_renamefrom) Then
						Directory.Move(_renamefrom, dir)
						SendMessage("250 Directory renamed")
						_server.Call_Log(New FTPLogEventArgs(FTPLogEventType.Rename, _connuser, True, 250, _renamefrom, dir))
					Else
						SendMessage("550 Error renaming file or directory")
						_server.Call_Log(New FTPLogEventArgs(FTPLogEventType.Rename, _connuser, False, 550, _renamefrom, dir))
					End If
				Catch
					SendMessage("550 Error renaming file or directory")
					_server.Call_Log(New FTPLogEventArgs(FTPLogEventType.Rename, _connuser, False, 550, _renamefrom, dir))
				End Try
			Else
				SendMessage("550 Acces denied")
				_server.Call_Log(New FTPLogEventArgs(FTPLogEventType.Rename, _connuser, False, 550, "Acces denied"))
			End If

		End Sub
		#End Region

		#Region "RMD"
		Private Sub RMD(CmdArguments As String)
			If _currentperms.Delete Then
				Dim navpath As String
				Dim full As Boolean = Fullpath(CmdArguments)
				If full Then
					navpath = CmdArguments
				Else
					navpath = _currentDir & "/" & CmdArguments
				End If

				Dim dir As String = GetExactPath(navpath)
				Try
					If DirectoryExists(CmdArguments) Then
						Directory.Delete(dir)
						SendMessage("250 """ & dir & """ directory deleted")
						_server.Call_Log(New FTPLogEventArgs(FTPLogEventType.DeleteDirectory, _connuser, True, 250, dir))
					Else
						SendMessage("550 Directory deletion failed.")
						_server.Call_Log(New FTPLogEventArgs(FTPLogEventType.DeleteDirectory, _connuser, False, 550, dir))
					End If
				Catch
					SendMessage("550 Directory deletion failed.")
					_server.Call_Log(New FTPLogEventArgs(FTPLogEventType.DeleteDirectory, _connuser, False, 550, dir))
				End Try
			Else
				SendMessage("550 Acces denied")
				_server.Call_Log(New FTPLogEventArgs(FTPLogEventType.DeleteDirectory, _connuser, False, 550, "Acces denied"))
			End If
		End Sub
		#End Region

		#Region "MKD"
		Private Sub MKD(CmdArguments As String)
			If _currentperms.Upload Then
				Dim navpath As String
				Dim full As Boolean = Fullpath(CmdArguments)
				If full Then
					navpath = CmdArguments
				Else
					navpath = _currentDir & "/" & CmdArguments
				End If

				Dim dir As String = GetExactPath(navpath)

				Try
					Directory.CreateDirectory(dir)
					SendMessage("257 """ & dir & """ directory created.")
					_server.Call_Log(New FTPLogEventArgs(FTPLogEventType.MakeDirectory, _connuser, True, 257, dir))
				Catch
					SendMessage("550 Directory creation failed.")
					_server.Call_Log(New FTPLogEventArgs(FTPLogEventType.MakeDirectory, _connuser, False, 550, dir))
				End Try
			Else
				SendMessage("550 Acces denied")
				_server.Call_Log(New FTPLogEventArgs(FTPLogEventType.MakeDirectory, _connuser, False, 550, "Acces denied"))
			End If
		End Sub
		#End Region

		#Region "LIST"
		Private Sub LIST(CmdArguments As String)
			Dim items As List(Of FTPListItem) = ListDir(CmdArguments)
			_datasocket = GetDataSocket()
			If _datasocket Is Nothing Then
				Return
			End If

			Try
				Dim sb As New StringBuilder()
				For Each itm As FTPListItem In items

					sb.Append(itm.ToString())
				Next
				If _utf8 Then
					_datasocket.Send(System.Text.Encoding.UTF8.GetBytes(sb.ToString()))
				Else
					_datasocket.Send(System.Text.Encoding.ASCII.GetBytes(sb.ToString()))
				End If
				SendMessage("226 Transfer Complete.")
				_server.Call_Log(New FTPLogEventArgs(FTPLogEventType.ListDirectory, _connuser, True, 226, _currentDir))
				_datasocket.Shutdown(SocketShutdown.Both)
				_datasocket.Close()
				_datasocket = Nothing
				GC.Collect()
			Catch
				SendMessage("426 Connection closed; transfer aborted.")
				_server.Call_Log(New FTPLogEventArgs(FTPLogEventType.ListDirectory, _connuser, False, 426, _currentDir, "Transfer aborted"))
			End Try
		End Sub
		#End Region

		#Region "NLST"
		Private Sub NLST(CmdArguments As String)
			Dim items As List(Of FTPListItem) = ListDir(GetExactPath(CmdArguments))
			_datasocket = GetDataSocket()
			If _datasocket Is Nothing Then
				Return
			End If

			Try

				For Each itm As FTPListItem In items
					If _utf8 Then
						_datasocket.Send(System.Text.Encoding.UTF8.GetBytes(itm.Name.ToString()))
					Else
						_datasocket.Send(System.Text.Encoding.ASCII.GetBytes(itm.Name.ToString()))
					End If
				Next
				_datasocket.Shutdown(SocketShutdown.Both)
				_datasocket.Close()
				_datasocket = Nothing
				GC.Collect()

				SendMessage("226 Transfer Complete.")
				_server.Call_Log(New FTPLogEventArgs(FTPLogEventType.ListFileNames, _connuser, True, 226, _currentDir))
			Catch
				SendMessage("426 Connection closed; transfer aborted.")
				_server.Call_Log(New FTPLogEventArgs(FTPLogEventType.ListFileNames, _connuser, False, 426, _currentDir, "Transfer aborted"))
			End Try
		End Sub
		#End Region

		#Region "SIZE"
		Private Sub SIZE(CmdArguments As String)
			Dim navpath As String
			Dim full As Boolean = Fullpath(CmdArguments)
			If full Then
				navpath = CmdArguments
			Else
				navpath = _currentDir & "/" & CmdArguments
			End If

			Try
				Dim fi As New FileInfo(GetExactPath(_currentDir & "/" & CmdArguments))
				Dim resp As String = fi.Length.ToString()
				SendMessage("250 " & resp)
				_server.Call_Log(New FTPLogEventArgs(FTPLogEventType.FileSize, _connuser, True, 250, navpath))
			Catch
				SendMessage("550 File not found")
				_server.Call_Log(New FTPLogEventArgs(FTPLogEventType.FileSize, _connuser, False, 550, navpath))
			End Try
		End Sub
		#End Region

		#Region "MTDM"
		Private Sub MDTM(CmdArguments As String)
			Dim navpath As String
			Dim full As Boolean = Fullpath(CmdArguments)
			If full Then
				navpath = CmdArguments
			Else
				navpath = _currentDir & "/" & CmdArguments
			End If

			Try
				Dim fi As New FileInfo(GetExactPath(navpath))
				Dim resp As String = fi.LastWriteTime.ToString("yyyyMMddHHmmss", New CultureInfo("en-US"))
				SendMessage("250 " & resp)
				_server.Call_Log(New FTPLogEventArgs(FTPLogEventType.FileModificationDate, _connuser, True, 250, navpath))
			Catch
				SendMessage("550 File not found")
				_server.Call_Log(New FTPLogEventArgs(FTPLogEventType.FileModificationDate, _connuser, False, 550, navpath))
			End Try
		End Sub
		#End Region

		#Region "OPTS"
		Private Sub OPTS(CmdArguments As String)
			Dim [option] As String = CmdArguments.ToUpper()
			Select Case [option]
				Case "UTF8 ON"
					_utf8 = True
					SendMessage("200 UTF-8 Enabled")
					_server.Call_Log(New FTPLogEventArgs(FTPLogEventType.OptionReceived, _connuser, True, 200, [option]))
					Exit Select
				Case "UTF8 OFF"
					_utf8 = False
					SendMessage("200 UTF-8 Disabled")
					_server.Call_Log(New FTPLogEventArgs(FTPLogEventType.OptionReceived, _connuser, True, 200, [option]))
					Exit Select
				Case Else
					SendMessage("504 Unrecognised option")
					_server.Call_Log(New FTPLogEventArgs(FTPLogEventType.OptionReceived, _connuser, False, 200, [option]))
					Exit Select
			End Select
		End Sub
		#End Region

		#Region "REIN"
		Private Sub REIN(CmdArguments As String)
			_connuser = Nothing
			_isAuthenticated = False
			_currentperms.Reset()
			SendMessage("200 Connection reinitialized")
			_server.Call_Log(New FTPLogEventArgs(FTPLogEventType.ConnectionReinitialize, _connuser, True, 200))
		End Sub
		#End Region

		#Region "Helper Functions"
		Private Function GetExactPath(path As String) As String
			If path Is Nothing Then
				path = ""
			End If
			If Not path.StartsWith("/") Then
				path = "/" & path
			End If
			Dim local As String = _localpath & path.Replace("/", "\")
			local = local.Replace("\\", "\")
			Return local
		End Function

		Private Sub SendMessage(Data As String)
			If Data Is Nothing OrElse Data = String.Empty Then
				Return
			End If
			Try
				If Not Data.EndsWith(vbCr & vbLf) Then
					Data += vbCr & vbLf
				End If
				Dim rawdata As Byte() = If(_utf8, Encoding.UTF8.GetBytes(Data), Encoding.ASCII.GetBytes(Data))
				_clientSocket.Send(rawdata)
			Catch
				Disconnect()
			End Try
		End Sub

		Private Function DirectoryExists(path As String) As Boolean
			Return Directory.Exists(GetExactPath(path))
		End Function

		Private Function FileExists(path As String) As Boolean
			Return File.Exists(GetExactPath(path))
		End Function

		Private Function GetDataSocket() As Socket
			Dim DataSocket As Socket = Nothing
			Try
				If DataTransferEnabled Then
					Dim Count As Integer = 0
					While Not DataListener.Pending()
						Thread.Sleep(1000)
						Count += 1
						' Time out after 30 seconds
						If Count > 29 Then
							SendMessage("425 Data Connection Timed out")
							Return Nothing
						End If
					End While

					DataSocket = DataListener.AcceptSocket()
					SendMessage("125 Connected, Starting Data Transfer.")
				Else
					SendMessage("150 Connecting." & vbCr & vbLf)
					DataSocket = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
					Dim suces As Boolean = False
					For i As Integer = 0 To ClientEndPoints.Length - 1
						Try
							DataSocket.Connect(ClientEndPoints(i))
							suces = True
							SendMessage("125 Connected, Starting Data Transfer.")
							Exit Try
						Catch
						End Try
					Next
					If Not suces Then
						Throw New Exception()
					End If
				End If
			Catch
				SendMessage("425 Can't open data connection.")
				Return Nothing
			Finally
				If DataListener IsNot Nothing Then
					DataListener.[Stop]()
					DataListener = Nothing
					GC.Collect()
				End If
			End Try

			DataTransferEnabled = False

			Return DataSocket
		End Function

		Private Function ListDir(path As String) As List(Of FTPListItem)
			Dim ret As New List(Of FTPListItem)()
			If Not _server.VFS.PathExists(path) Then
				Dim dirs As String() = Directory.GetDirectories(GetExactPath(path))
				Dim files As String() = Directory.GetFiles(GetExactPath(path))
				Dim tmp As FTPListItem
				Dim di As DirectoryInfo
				Dim fi As FileInfo

				For Each dir As String In dirs
					di = New DirectoryInfo(dir)
					If (((di.Attributes And FileAttributes.Hidden) = FileAttributes.Hidden) OrElse ((di.Attributes And FileAttributes.System) = FileAttributes.System)) AndAlso Not _currentperms.ListHidden Then
						Continue For
					Else
						tmp = New FTPListItem(dir)
						tmp.IsDir = True
						tmp.[Date] = di.LastWriteTime
						ret.Add(tmp)
					End If
				Next

				For Each file As String In files
					fi = New FileInfo(file)
					If (((fi.Attributes And FileAttributes.Hidden) = FileAttributes.Hidden) OrElse ((fi.Attributes And FileAttributes.System) = FileAttributes.System)) AndAlso Not _currentperms.ListHidden Then
						Continue For
					Else
						tmp = New FTPListItem(file)
						tmp.IsDir = False
						tmp.[Date] = fi.LastWriteTime
						tmp.Size = fi.Length
						ret.Add(tmp)
					End If
				Next
			End If

			Dim vdir As VFS.VFSDirectory = _server.VFS.GetDirectory(path)
			If vdir IsNot Nothing Then
				ret.AddRange(vdir.ListDirectory())
			End If
			'ret.AddRange(_server.VFS.GetFilesOfDir(path));

			Return ret
		End Function

		Private Function Fullpath(path As String) As Boolean
			If path.Split("/"C).Length > 1 Then
				Return True
			Else
				Return False
			End If
		End Function
		Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, value As T) As T
			target = value
			Return value
		End Function
		#End Region
	End Class
End Namespace
