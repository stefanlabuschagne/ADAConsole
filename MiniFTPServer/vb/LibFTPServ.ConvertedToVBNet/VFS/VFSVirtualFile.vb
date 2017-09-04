Imports System.IO

Namespace VFS
	''' <summary>
	''' A VFS Virtual File structure
	''' </summary>
	Public MustInherit Class VFSVirtualFile
		Inherits VFSVirtualItem
		''' <summary>
		''' Creates a new instance of VFSVirtualFile
		''' </summary>
		''' <param name="name">The full path of the file in the VFS</param>
		Public Sub New(name As String)
			MyBase.New(name)
		End Sub

		''' <summary>
		''' Creates a new instance of VFSVirtualFile
		''' </summary>
		''' <param name="name">The full path of the file in the VFS</param>
		''' <param name="time">File last modification date</param>
		''' <param name="size">File size</param>
		Public Sub New(name As String, time As DateTime, size As Long)
			MyBase.New(name, time, size)
		End Sub


		''' <summary>
		''' Renders the contents of the file
		''' </summary>
		''' <returns>The rendered content as a stream</returns>
		Public MustOverride Function RenderContents() As Stream
	End Class
End Namespace
