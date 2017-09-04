Imports System
Imports System.Collections
Imports System.Text.RegularExpressions
Imports System.Windows.Forms

Namespace ListViewSorter
	''' <summary>
	''' This class is an implementation of the 'IComparer' interface.
	''' </summary>
	Public Class ListViewColumnSorter
		Implements IComparer
		''' <summary>
		''' Specifies the column to be sorted
		''' </summary>
		Private ColumnToSort As Integer
		''' <summary>
		''' Specifies the order in which to sort (i.e. 'Ascending').
		''' </summary>
		Private OrderOfSort As SortOrder

		'private CaseInsensitiveComparer ObjectCompare;
		Private ObjectCompare As NumberCaseInsensitiveComparer
		Private FirstObjectCompare As ImageTextComparer

		''' <summary>
		''' Class constructor.  Initializes various elements
		''' </summary>
		Public Sub New()
			' Initialize the column to '0'
			ColumnToSort = 0

			' Initialize the sort order to 'none'
			'OrderOfSort = SortOrder.None;
			OrderOfSort = SortOrder.Ascending

			' Initialize the CaseInsensitiveComparer object
			ObjectCompare = New NumberCaseInsensitiveComparer()
			'CaseInsensitiveComparer();
			FirstObjectCompare = New ImageTextComparer()
		End Sub

		''' <summary>
		''' This method is inherited from the IComparer interface.  It compares the two objects passed using a case insensitive comparison.
		''' </summary>
		''' <param name="x">First object to be compared</param>
		''' <param name="y">Second object to be compared</param>
		''' <returns>The result of the comparison. "0" if equal, negative if 'x' is less than 'y' and positive if 'x' is greater than 'y'</returns>
		Public Function Compare(x As Object, y As Object) As Integer Implements IComparer.Compare
			Dim compareResult As Integer
			Dim listviewX As ListViewItem, listviewY As ListViewItem

			' Cast the objects to be compared to ListViewItem objects
			listviewX = DirectCast(x, ListViewItem)
			listviewY = DirectCast(y, ListViewItem)

			If ColumnToSort = 0 Then
				compareResult = FirstObjectCompare.Compare(x, y)
			Else
				' Compare the two items
				compareResult = ObjectCompare.Compare(listviewX.SubItems(ColumnToSort).Text, listviewY.SubItems(ColumnToSort).Text)
			End If

			' Calculate correct return value based on object comparison
			If OrderOfSort = SortOrder.Ascending Then
				' Ascending sort is selected, return normal result of compare operation
				Return compareResult
			ElseIf OrderOfSort = SortOrder.Descending Then
				' Descending sort is selected, return negative result of compare operation
				Return (-compareResult)
			Else
				' Return '0' to indicate they are equal
				Return 0
			End If
		End Function

		''' <summary>
		''' Gets or sets the number of the column to which to apply the sorting operation (Defaults to '0').
		''' </summary>
		Public Property SortColumn() As Integer
			Get
				Return ColumnToSort
			End Get
			Set
				ColumnToSort = value
			End Set
		End Property

		''' <summary>
		''' Gets or sets the order of sorting to apply (for example, 'Ascending' or 'Descending').
		''' </summary>
		Public Property Order() As SortOrder
			Get
				Return OrderOfSort
			End Get
			Set
				OrderOfSort = value
			End Set
		End Property

	End Class

	Public Class ImageTextComparer
		Implements IComparer
		'private CaseInsensitiveComparer ObjectCompare;
		Private ObjectCompare As NumberCaseInsensitiveComparer

		Public Sub New()
			' Initialize the CaseInsensitiveComparer object
				'CaseInsensitiveComparer();
			ObjectCompare = New NumberCaseInsensitiveComparer()
		End Sub

		Public Function Compare(x As Object, y As Object) As Integer Implements IComparer.Compare
			'int compareResult;
			Dim image1 As Integer, image2 As Integer
			Dim listviewX As ListViewItem, listviewY As ListViewItem

			' Cast the objects to be compared to ListViewItem objects
			listviewX = DirectCast(x, ListViewItem)
			image1 = listviewX.ImageIndex
			listviewY = DirectCast(y, ListViewItem)
			image2 = listviewY.ImageIndex

			If image1 < image2 Then
				Return -1
			ElseIf image1 = image2 Then
				Return ObjectCompare.Compare(listviewX.Text, listviewY.Text)
			Else
				Return 1
			End If
		End Function
	End Class

	Public Class NumberCaseInsensitiveComparer
		Inherits CaseInsensitiveComparer

		Public Sub New()
		End Sub

		Public Shadows Function Compare(x As Object, y As Object) As Integer
			If (TypeOf x Is System.String) AndAlso IsWholeNumber(DirectCast(x, String)) AndAlso (TypeOf y Is System.String) AndAlso IsWholeNumber(DirectCast(y, String)) Then
				Return MyBase.Compare(System.Convert.ToInt32(x), System.Convert.ToInt32(y))
			Else
				Return MyBase.Compare(x, y)
			End If
		End Function

		Private Function IsWholeNumber(strNumber As String) As Boolean
			Dim objNotWholePattern As New Regex("[^0-9]")
			Return Not objNotWholePattern.IsMatch(strNumber)
		End Function
	End Class

End Namespace
