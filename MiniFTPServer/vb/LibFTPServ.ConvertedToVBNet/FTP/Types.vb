Imports System.Globalization

Namespace FTP
	''' <summary>
	''' An FTP User management class
	''' </summary>
	<Serializable> _
	Public Class FTPUser
		''' <summary>
		''' The Name of the user
		''' </summary>
		Public Name As String

		''' <summary>
		''' The SHA1 hash of the user's password
		''' </summary>
		Public SHA1Password As String

		''' <summary>
		''' The home directory of the userr
		''' </summary>
		Public Startupdir As String

		''' <summary>
		''' The Permissions associated to the user
		''' </summary>
		Public Permissions As FTPUserPermission


		''' <summary>
		''' Creates a new instance of FTPUser
		''' </summary>
		Public Sub New()
			Permissions = New FTPUserPermission()
			Startupdir = "/"
		End Sub

		''' <summary>
		''' Creates a new instance of FTPUser
		''' </summary>
		''' <param name="name">The name of the user</param>
		''' <param name="pass">The desired password for the user</param>
		Public Sub New(name__1 As String, pass As String)
			Permissions = New FTPUserPermission()
			Name = name__1
			Startupdir = "/"
			SHA1Password = HelperFunctions.SHA1Hash(pass)
		End Sub

		Public Sub SetPassword(pass As String)
			SHA1Password = HelperFunctions.SHA1Hash(pass)
		End Sub

		''' <summary>
		''' Creates a new instance of FTPUser
		''' </summary>
		''' <param name="name">The name of the user</param>
		''' <param name="pass">The desired password for the user</param>
		''' <param name="dir">The startup directory of the user</param>
		Public Sub New(name As String, pass As String, dir As String)
			Me.New(name, pass)
			Startupdir = dir
		End Sub

		''' <summary>
		''' Returns a new Anonymus user
		''' </summary>
		Public Shared ReadOnly Property Anonymus() As FTPUser
			Get
				Return New FTPUser("Anonymus", "")
			End Get
		End Property
	End Class

	Friend Class FTPListItem
		Public Name As String
		Public IsDir As Boolean
		Public Size As Long
		Public [Date] As DateTime

		Public Sub New()
			Name = ""
			IsDir = True
			Size = 0
			[Date] = DateTime.Now
		End Sub

		Public Sub New(name__1 As String)
			Me.New()
			Name = name__1
		End Sub

		Public Overrides Function ToString() As String
			Dim datestr As String = [Date].ToString("MM-dd-yy hh:mmtt", New CultureInfo("en-US"))
			If IsDir Then
				Return datestr & " <DIR> " & Name.Substring(Name.Replace("\"C, "/"C).LastIndexOf("/"C) + 1) & vbCr & vbLf
			Else
				Return datestr & " " & Size.ToString() & " " & Name.Substring(Name.Replace("\"C, "/"C).LastIndexOf("/"C) + 1) & vbCr & vbLf
			End If
		End Function
	End Class


	''' <summary>
	''' FTP User Permission management class
	''' </summary>
	<Serializable> _
	Public Class FTPUserPermission
		''' <summary>
		''' The User can upload
		''' </summary>
		Public Upload As Boolean

		''' <summary>
		''' The user can delete files
		''' </summary>
		Public Delete As Boolean

		''' <summary>
		''' The user can rename files
		''' </summary>
		Public Rename As Boolean

		''' <summary>
		''' The user can see hidden files on directory and name list
		''' </summary>
		Public ListHidden As Boolean

		''' <summary>
		''' Resets the current users permissions to default
		''' </summary>
		Public Sub Reset()
			Upload = False
			Delete = False
			Rename = False
			ListHidden = False
		End Sub
	End Class
End Namespace
