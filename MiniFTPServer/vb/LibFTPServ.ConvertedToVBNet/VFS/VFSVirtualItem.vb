Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace VFS
	''' <summary>
	''' Base class of VFS virtual items
	''' </summary>
	Public MustInherit Class VFSVirtualItem
		Private _name As String
		Private _size As Long
		Private _date As DateTime

		''' <summary>
		''' The full path of the item in the VFS. 
		''' </summary>
		Public Property Name() As String
			Get
				Return _name
			End Get
			Set
				_name = value
			End Set
		End Property

		''' <summary>
		''' The size of the item in the VFS
		''' </summary>
		Public Property Size() As Long
			Get
				Return _size
			End Get
			Set
				_size = value
			End Set
		End Property

		''' <summary>
		''' Item date in the VFS
		''' </summary>
		Public Property [Date]() As DateTime
			Get
				Return _date
			End Get
			Set
				_date = value
			End Set
		End Property

		''' <summary>
		''' Creates a new instance of VFSVirtualItem
		''' </summary>
		''' <param name="name">The full path of the item in the VFS. </param>
		Public Sub New(name As String)
			_name = name
			_date = DateTime.Now
			_size = 0
		End Sub

		''' <summary>
		''' Creates a new instance of VFSVirtualItem
		''' </summary>
		''' <param name="name">The full path of the item in the VFS. </param>
		''' <param name="date">Item date in the VFS</param>
		''' <param name="size">The size of the item in the VFS</param>
		Public Sub New(name As String, [date] As DateTime, size As Long)
			_name = name
			_date = [date]
			_size = size
		End Sub
	End Class
End Namespace
