Imports System.Collections.Generic
Imports System.Net
Imports System.Net.Sockets
Imports System.Timers
Imports LibFTPServ.VFS

Namespace FTP
	''' <summary>
	''' FTP server class
	''' </summary>
	Public Class FTPServer
		Private FTPListener As TcpListener
		Private _port As Integer, _pass_min As Integer, _pass_max As Integer
		Private _startdir As String
		Private _banlist As List(Of IPAddress)
		Private _acceptlist As List(Of IPAddress)
		Private FTPClients As List(Of FTPSession)
		Private _userlist As UserManager
		Private _maxInactiveTime As Integer
		Private DisconectInactive As Timer
		Private _VFS As VFSManager
		Private _dlLimit As Integer, _ulLumit As Integer

		''' <summary>
		''' Creates a new Instance of FTPServer
		''' </summary>
		Public Sub New()
			FTPClients = New List(Of FTPSession)()
			_pass_min = 20000
			_pass_max = 40000
			_dlLimit = -1
			_ulLumit = -1
			_banlist = New List(Of IPAddress)()
			_acceptlist = New List(Of IPAddress)()
			_userlist = New UserManager()
			_port = 21
			_maxInactiveTime = 30
			_VFS = New VFSManager()
			DisconectInactive = New Timer(_maxInactiveTime * 1000)
			AddHandler DisconectInactive.Elapsed, New ElapsedEventHandler(AddressOf DisconectInactive_Elapsed)
		End Sub

		Private Sub DisconectInactive_Elapsed(sender As Object, e As ElapsedEventArgs)
			Dim ts As TimeSpan
			Dim remove As New List(Of FTPSession)()
			For Each s As FTPSession In FTPClients
				ts = DateTime.Now - s.LastCommandTime
				If ts.TotalSeconds > _maxInactiveTime Then
					remove.Add(s)
				End If
			Next

			For Each rs As FTPSession In remove
				rs.Disconnect()
				FTPClients.Remove(rs)
			Next
		End Sub


		Friend Sub RemoveClient(s As FTPSession)
			Me.FTPClients.Remove(s)
		End Sub

		#Region "Properties"
		Friend ReadOnly Property Status() As String
			Get
				If FTPListener Is Nothing Then
					Return "value=""0"""
				Else
					Return "value=""1"" checked"
				End If
			End Get
		End Property

		Public Property InactiveClientTimeOut() As Integer
			Get
				Return _maxInactiveTime
			End Get
			Set
				_maxInactiveTime = value
				DisconectInactive.Interval = 1000 * _maxInactiveTime
			End Set
		End Property

		Friend ReadOnly Property IsRunning() As Boolean
			Get
				Return FTPListener IsNot Nothing
			End Get
		End Property

		''' <summary>
		''' Gets or sets the ftp default port
		''' </summary>
		Public Property Port() As Integer
			Get
				Return _port
			End Get
			Set
				If IsRunning Then
					Throw New InvalidOperationException("Port can only be changed when server is not running")
				End If
				_port = value
			End Set
		End Property

		''' <summary>
		''' Gets or sets the minumum passive port number
		''' </summary>
		Public Property PassivePortMinimum() As Integer
			Get
				Return _pass_min
			End Get
			Set
				If IsRunning Then
					Throw New InvalidOperationException("PassivePortMinum can only be changed when server is not running")
				End If
				_pass_min = value
			End Set
		End Property

		''' <summary>
		''' Gets or sets the maximum passive port number
		''' </summary>
		Public Property PassivePortMaximum() As Integer
			Get
				Return _pass_max
			End Get
			Set
				If IsRunning Then
					Throw New InvalidOperationException("PassivePortMaximum can only be changed when server is not running")
				End If
				_pass_max = value
			End Set
		End Property

		''' <summary>
		''' Gets or sets the global startup directory
		''' </summary>
		Public Property StartupDir() As String
			Get
				Return _startdir
			End Get
			Set
				If IsRunning Then
					Throw New InvalidOperationException("Start dir can only be changed when server is not running")
				End If
				_startdir = value
			End Set
		End Property

		''' <summary>
		''' Gets the List of Banned Adresses on the server
		''' </summary>
		Public ReadOnly Property BannedAdresses() As List(Of IPAddress)
			Get
				Return _banlist
			End Get
		End Property

		''' <summary>
		''' Gets the always accepted list of Adresses on the server
		''' </summary>
		Public ReadOnly Property AcceptedAdresses() As List(Of IPAddress)
			Get
				Return _acceptlist
			End Get
		End Property

		''' <summary>
		''' Gets the user manager associated to this server
		''' </summary>
		Public ReadOnly Property Users() As UserManager
			Get
				Return _userlist
			End Get
		End Property


		''' <summary>
		''' Gets or sets the Server downlaod speed limit in Bytes/second. -1 is disabled
		''' </summary>
		Public Property DownloadSpeedLimit() As Integer
			Get
				Return _dlLimit
			End Get
			Set
				_dlLimit = value
			End Set
		End Property

		''' <summary>
		''' Gets or sets the Server upload speed limit in Bytes/second. -1 disabled
		''' </summary>
		Public Property UploadSpeedLimit() As Integer
			Get
				Return _ulLumit
			End Get
			Set
				_ulLumit = value
			End Set
		End Property

		Public Property VFS() As VFSManager
			Get
				Return _VFS
			End Get
			Set
				If IsRunning Then
					Throw New InvalidOperationException("VFS can only be changed when server is not running")
				End If
				_VFS = value
			End Set
		End Property

		#End Region

		''' <summary>
		''' Starts the server
		''' </summary>
		Public Sub Start()
			[Stop]()

			FTPListener = New TcpListener(IPAddress.Any, _port)
			FTPListener.Start(20)
			'DisconectInactive.Start();
			' Start accepting the incoming clients.
			FTPListener.BeginAcceptSocket(New AsyncCallback(AddressOf NewFTPClientArrived), Nothing)
		End Sub

		''' <summary>
		''' Stops the server
		''' </summary>
		Public Sub [Stop]()
			If FTPListener IsNot Nothing Then
				FTPListener.[Stop]()
				DisconectInactive.[Stop]()
				FTPListener = Nothing
			End If
		End Sub

		Private Sub NewFTPClientArrived(arg As IAsyncResult)
			Try
				FTPClients.Add(New FTPSession(FTPListener.EndAcceptSocket(arg), Me, _startdir))
				FTPListener.BeginAcceptSocket(New AsyncCallback(AddressOf NewFTPClientArrived), Nothing)
			Catch
			End Try
		End Sub

		#Region "Events"

		''' <summary>
		''' Event occures when a Logable event occures.
		''' </summary>
		Public Event OnLogEvent As FTPLogEventHandler

		Friend Overridable Sub Call_Log(e As FTPLogEventArgs)
			RaiseEvent OnLogEvent(Me, e)
		End Sub

		#End Region
	End Class
End Namespace
