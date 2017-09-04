Imports System.Collections.Generic
Imports System.Linq
Imports System.IO
Imports System.Xml.Serialization

Namespace FTP
	''' <summary>
	''' A User management class
	''' </summary>
	Public Class UserManager
		Private _users As List(Of FTPUser)

		''' <summary>
		''' Creates a new instance of UserManager
		''' </summary>
		Public Sub New()
			_users = New List(Of FTPUser)()
		End Sub

		''' <summary>
		''' Adds a user to the management system
		''' </summary>
		''' <param name="user">The user to be added</param>
		Public Sub AddUser(user As FTPUser)
			_users.Add(user)
		End Sub

		''' <summary>
		''' Removes a user from the management system
		''' </summary>
		''' <param name="user">The user to be removed</param>
		Public Sub RemoveUser(user As FTPUser)
			_users.Remove(user)
		End Sub

		''' <summary>
		''' Removes a user from the management system by the user's name
		''' </summary>
		''' <param name="name">The name of the user to be removed</param>
		Public Sub RemoveUserbyName(name As String)
            Dim q = (From user In _users Where user.Name = name Select user).ToList()
			For Each u As FTPUser In q
				_users.Remove(u)
			Next
		End Sub

		''' <summary>
		''' Returns a user based on it's name
		''' </summary>
		''' <param name="name">The name of the user to get</param>
		''' <returns></returns>
		Public Default ReadOnly Property Item(name As String) As FTPUser
			Get
                Dim q = From user In _users Where user.Name = name Select user
				Return q.FirstOrDefault()
			End Get
		End Property

		''' <summary>
		''' Gets the permissions associated to the user by the user's name
		''' </summary>
		''' <param name="name">the name of the user</param>
		''' <returns></returns>
		Public Function GetPermissions(name As String) As FTPUserPermission
            Dim q = From user In _users Where user.Name = name Select user.Permissions
			Return q.FirstOrDefault()
		End Function

		''' <summary>
		''' Gets the number of users in the management system
		''' </summary>
		Public ReadOnly Property Count() As Integer
			Get
				Return _users.Count
			End Get
		End Property

		''' <summary>
		''' serializes users to stream
		''' </summary>
		''' <param name="Target"></param>
		Public Sub Serialize(Target As Stream)
			Dim xs As New XmlSerializer(GetType(FTPUser()))
			xs.Serialize(Target, _users.ToArray())
		End Sub

		''' <summary>
		''' Deserializes users from stream
		''' </summary>
		''' <param name="Source"></param>
		Public Sub Deserialize(Source As Stream)
			Dim xs As New XmlSerializer(GetType(FTPUser()))
			_users.AddRange(DirectCast(xs.Deserialize(Source), FTPUser()))
		End Sub

		''' <summary>
		''' gets the user names
		''' </summary>
		Public ReadOnly Property UserNames() As String()
			Get
                Return (From user In _users Select user.Name).ToArray()
			End Get
		End Property
	End Class
End Namespace
