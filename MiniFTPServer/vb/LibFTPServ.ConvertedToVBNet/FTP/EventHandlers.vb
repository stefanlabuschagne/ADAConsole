
Namespace FTP
	''' <summary>
	''' Event Type Enumeration
	''' </summary>
	Public Enum FTPLogEventType
		''' <summary>
		''' Occures when a user trys to connect to the server
		''' </summary>
		UserConnect

		''' <summary>
		''' Occures when a user disconects from the server
		''' </summary>
		UserDisconnect

		''' <summary>
		''' Occures when a cwd command recived
		''' </summary>
		ChangeWorkDir

		''' <summary>
		''' Occures when a dele command recived
		''' </summary>
		DeleteFile

		''' <summary>
		''' Occures when a list command is recived
		''' </summary>
		ListDirectory

		''' <summary>
		''' Occures when a mkd command is recived
		''' </summary>
		MakeDirectory

		''' <summary>
		''' Occures when a nlst command is recived
		''' </summary>
		ListFileNames

		''' <summary>
		''' Occures when a pasv command is recived
		''' </summary>
		PassiveMode

		''' <summary>
		''' Occures when a port command is recived
		''' </summary>
		PortCommand

		''' <summary>
		''' Occures when a retr command is recived
		''' </summary>
		DownloadFile

		''' <summary>
		''' Occures when a rmd command is recived
		''' </summary>
		DeleteDirectory

		''' <summary>
		''' Occures when a rnfr and rnto command pair is recived
		''' </summary>
		Rename

		''' <summary>
		''' Occures wehen a stor coomand is recived
		''' </summary>
		UploadFile

		''' <summary>
		''' Occures when a type command is recived
		''' </summary>
		ChangeType

		''' <summary>
		''' Occures when an appe command is recived
		''' </summary>
		AppendFile


		''' <summary>
		''' Occures when a size command is recived
		''' </summary>
		FileSize

		''' <summary>
		''' Occures when a mtdm command is recived
		''' </summary>
		FileModificationDate

		''' <summary>
		''' Occures when an opts command is recived
		''' </summary>
		OptionReceived

		''' <summary>
		''' Occures when a rein command is recived
		''' </summary>
		ConnectionReinitialize

		''' <summary>
		''' Occures when an abor commnad is recived
		''' </summary>
		Abort

		''' <summary>
		''' Occures when a feat command is recived
		''' </summary>
		FeatureList

		''' <summary>
		''' Occures when an unknown command is recived
		''' </summary>
		UnknownCommand
	End Enum

	''' <summary>
	''' Log Event args
	''' </summary>
	Public Class FTPLogEventArgs
		Inherits EventArgs
		Private _date As DateTime
		Private _type As FTPLogEventType
		Private _eventsucces As Boolean
		Private _arguments As String()
		Private _responsecode As Integer
		Private _user As String

		''' <summary>
		''' Creates a new instance of LogEventArgs
		''' </summary>
		''' <param name="EventType">The Type of the event</param>
		''' <param name="User">Current FTP User</param>
		''' <param name="Succes">Completed succesfully or not</param>
		''' <param name="Response">Server Response code</param>
		''' <param name="arguments">Event specific arguments</param>
		Public Sub New(EventType As FTPLogEventType, User As String, Succes As Boolean, Response As Integer, ParamArray arguments As String())
			_date = DateTime.Now
			_type = EventType
			_eventsucces = Succes
			_arguments = arguments
			_responsecode = Response
			_user = User
		End Sub

		''' <summary>
		''' The Date and Time of the event
		''' </summary>
		Public ReadOnly Property EventDate() As DateTime
			Get
				Return _date
			End Get
		End Property

		''' <summary>
		''' Gets if the Event raising command completed succesfully or not
		''' </summary>
		Public ReadOnly Property Succes() As Boolean
			Get
				Return _eventsucces
			End Get
		End Property

		''' <summary>
		''' Gets the user associated to the event
		''' </summary>
		Public ReadOnly Property User() As String
			Get
				Return _user
			End Get
		End Property

		''' <summary>
		''' Event type
		''' </summary>
		Public ReadOnly Property EventType() As FTPLogEventType
			Get
				Return _type
			End Get
		End Property

		''' <summary>
		''' Event Arguments related to the event type
		''' </summary>
		Public ReadOnly Property arguments() As String()
			Get
				Return _arguments
			End Get
		End Property

		''' <summary>
		''' Gets the server Response code for the event
		''' </summary>
		Public ReadOnly Property Response() As Integer
			Get
				Return _responsecode
			End Get
		End Property

		''' <summary>
		''' Gets a specific event argument
		''' </summary>
		''' <param name="index">the index of the event argument to get</param>
		''' <returns>The the specific event argument</returns>
		Public Default ReadOnly Property Item(index As Integer) As String
			Get
				Return _arguments(index)
			End Get
		End Property

		''' <summary>
		''' Gets the count of the event arguments
		''' </summary>
		Public ReadOnly Property Length() As Integer
			Get
				Return _arguments.Length
			End Get
		End Property
	End Class

	Public Delegate Sub FTPLogEventHandler(sender As Object, e As FTPLogEventArgs)
End Namespace
