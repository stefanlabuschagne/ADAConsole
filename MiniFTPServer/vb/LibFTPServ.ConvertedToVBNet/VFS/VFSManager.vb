Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports LibFTPServ.FTP
Imports System.Text

Namespace VFS
	Public Class VFSManager
		Private _rootdir As VFSDirectory
		Private _items As List(Of VFSVirtualItem)
		Private _virtualpaths As List(Of String)

		Public Sub New()
			_rootdir = New VFSDirectory("/")
			_items = New List(Of VFSVirtualItem)()
			_virtualpaths = New List(Of String)()
		End Sub

		Private Sub RebuildTree()
			Dim path As String()
			_rootdir = Nothing
			_virtualpaths.Clear()
			GC.Collect()
			_rootdir = New VFSDirectory("/")
			Dim currdir As VFSDirectory = _rootdir
			For Each item As VFSVirtualItem In _items
				path = item.Name.Split("/"C)
				For i As Integer = 0 To path.Length - 1
					If i <> path.Length - 1 Then
						'directory
						If Not String.IsNullOrEmpty(path(i)) Then
							If Not currdir.ContainsDir(path(i)) Then
								currdir.Subdirs.Add(New VFSDirectory(path(i)))
							End If
							currdir = currdir.GetSubdirByName(path(i))
						End If
					Else
						currdir.Files.Add(item)
					End If
				Next
			Next

			For Each item As VFSVirtualItem In _items
				_virtualpaths.Add(getPath(item.Name))
			Next
			_virtualpaths = _virtualpaths.Distinct().ToList()
		End Sub

		Private Function getPath(p As String) As String
			Dim parts As String() = p.Split("/"C)
			Dim sb As New StringBuilder(p.Length)
			sb.Append("/")
			For i As Integer = 1 To parts.Length - 2
				sb.Append(parts(i))
				If i <> parts.Length - 2 Then
					sb.Append("/")
				End If
			Next
			Return sb.ToString()
		End Function

		Friend Function GetDirectory(path As String) As VFSDirectory
			If path = "/" Then
				Return _rootdir
			End If
			Dim currdir As VFSDirectory = _rootdir
			Dim parts As String() = path.Split("/"C)
			Dim ok As Boolean = True
			For i As Integer = 1 To parts.Length - 1

				If currdir.ContainsDir(parts(i)) Then
					currdir = currdir.GetSubdirByName(parts(i))
				Else
					Exit For
				End If
			Next
			If Not ok Then
				Return Nothing
			Else
				Return currdir
			End If
		End Function

		Friend Function IsVirtualFile(path As String) As Boolean
            Dim q = From file In _items Where file.Name.ToLower() = path.ToLower() '.file
			Return q.ToList().Count > 0
		End Function

		Friend Function GetFileContents(path As String) As Stream
            Dim q = From file In _items Where file.Name.ToLower() = path.ToLower() '.file
			Return DirectCast(q.FirstOrDefault(), VFSVirtualFile).RenderContents()
		End Function

		Friend Function PathExists(path As String) As Boolean
			Dim fix As String = HelperFunctions.FixPath(path)
			Return _virtualpaths.Contains(fix)
		End Function

		Public Sub AddItem(item As VFSVirtualItem)
			_items.Add(item)
			RebuildTree()
		End Sub

		Private Sub RemoveItem(item As VFSVirtualItem)
			_items.Remove(item)
			RebuildTree()
		End Sub
	End Class
End Namespace
