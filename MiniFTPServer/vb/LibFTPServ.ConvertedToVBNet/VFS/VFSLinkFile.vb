Imports System.IO

Namespace VFS
	Class VFSLinkFile
		Inherits VFSVirtualFile
		Private _source As String

		Public Sub New(Name As String, source As String)
			MyBase.New(Name)
			If Not File.Exists(source) Then
				Throw New ArgumentException("source file must exist")
			End If
			_source = source
			Dim fi As New FileInfo(source)
			MyBase.[Date] = fi.LastWriteTime
			MyBase.Size = fi.Length
			fi = Nothing
		End Sub

		Public Overrides Function RenderContents() As Stream
			Return File.OpenRead(_source)
		End Function
	End Class
End Namespace
