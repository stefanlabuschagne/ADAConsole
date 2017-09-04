Imports System.Linq
Imports System.Collections.Generic
Imports LibFTPServ.FTP
Imports System.Text

Namespace VFS
	Friend Class VFSDirectory
		Inherits VFSVirtualItem
		Private _subdirs As List(Of VFSDirectory)
		Private _files As List(Of VFSVirtualItem)
		'private string _name;
		'private DateTime _date;

		Private Function GetFileName(path As String) As String
			Dim parts As String() = path.Split("/"C)
			Return parts(parts.Length - 1)
		End Function

		Public Sub New()
			MyBase.New(Nothing)
			_subdirs = New List(Of VFSDirectory)()
			_files = New List(Of VFSVirtualItem)()
			MyBase.Size = -1
		End Sub

		Public Sub New(name As String)
			MyBase.New(name.ToLower())
			If String.IsNullOrEmpty(name) Then
				Throw New ArgumentException("Name can't be null or empty")
			End If
			_subdirs = New List(Of VFSDirectory)()
			_files = New List(Of VFSVirtualItem)()
			MyBase.Size = -1
		End Sub

		Public Sub New(name As String, [date] As DateTime)
			MyBase.New(name.ToLower(), [date], -1)
			If String.IsNullOrEmpty(name) Then
				Throw New ArgumentException("Name can't be null or empty")
			End If
			_subdirs = New List(Of VFSDirectory)()
			_files = New List(Of VFSVirtualItem)()
		End Sub

		Public Function ContainsDir(dirname As String) As Boolean
            Dim q = From dir In _subdirs Where dir.Name = dirname.ToLower() 'dir
			Return q.ToList().Count > 0
		End Function

		Public Function GetSubdirByName(name As String) As VFSDirectory
            Dim q = From dir In _subdirs Where dir.Name = name.ToLower() 'dir
			Return q.FirstOrDefault()
		End Function

		Public Function ListDirectory() As List(Of FTPListItem)
			Dim ret As New List(Of FTPListItem)()
			Dim tmp As FTPListItem

			For Each dir As VFSDirectory In Subdirs
				tmp = New FTPListItem()
				tmp.Name = dir.Name
				tmp.IsDir = True
				tmp.[Date] = dir.[Date]
				ret.Add(tmp)
			Next

			For Each itm As VFSVirtualItem In Files
				tmp = New FTPListItem()
				tmp.Name = GetFileName(itm.Name)
				tmp.[Date] = itm.[Date]
				tmp.IsDir = False
				tmp.Size = itm.Size
				ret.Add(tmp)
			Next

			Return ret
		End Function

		Public ReadOnly Property Subdirs() As List(Of VFSDirectory)
			Get
				Return _subdirs
			End Get
		End Property

		Public ReadOnly Property Files() As List(Of VFSVirtualItem)
			Get
				Return _files
			End Get
		End Property
	End Class
End Namespace
