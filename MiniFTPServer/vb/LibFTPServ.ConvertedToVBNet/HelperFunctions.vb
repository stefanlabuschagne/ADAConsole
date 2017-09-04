Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Security.Cryptography

Friend NotInheritable Class HelperFunctions
	Private Sub New()
	End Sub
	Public Shared Function FixPath(path As String) As String
		Dim sb As New StringBuilder()
		sb.Append("/")
		Dim p As String() = path.Split("/"C)
		For i As Integer = 0 To p.Length - 1
			If Not String.IsNullOrEmpty(p(i)) Then
				sb.Append(p(i))
				If i <> p.Length - 1 Then
					sb.Append("/")
				End If
			End If
		Next
		Return sb.ToString()

	End Function

	Public Shared Function SHA1Hash(source As String) As String
		Dim sha1 As New SHA1CryptoServiceProvider()
		Dim data As Byte() = Encoding.UTF8.GetBytes(source)
		Dim hash As Byte() = sha1.ComputeHash(data)
		Dim sb As New StringBuilder(50)
		For i As Integer = 0 To hash.Length - 1
			sb.Append(hash(i).ToString("x2").ToLower())
		Next
		Return sb.ToString()
		

	End Function

	Public Shared Function GenerateUniqueFileName() As String
		Dim rgn As New RNGCryptoServiceProvider()
		Dim data As Byte() = New Byte(15) {}
		rgn.GetBytes(data)
		Dim name As New Guid(data)
		Return name.ToString()
	End Function
End Class
