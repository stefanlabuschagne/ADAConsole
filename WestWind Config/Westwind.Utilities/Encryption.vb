Imports System
Imports System.IO
Imports System.IO.Compression
Imports System.Security.Cryptography
Imports System.Text

Namespace Westwind.Utilities
	Friend Class Encryption
		Public Shared Key As String = "0a1f131c"

		Public Shared Function EncryptBytes(InputString As Byte(), EncryptionKey As String) As Byte()
			If EncryptionKey Is Nothing Then
				EncryptionKey = Encryption.Key
			End If
			Dim tripleDESCryptoServiceProvider As TripleDESCryptoServiceProvider = New TripleDESCryptoServiceProvider()
			Dim mD5CryptoServiceProvider As MD5CryptoServiceProvider = New MD5CryptoServiceProvider()
			tripleDESCryptoServiceProvider.Key = mD5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(EncryptionKey))
			tripleDESCryptoServiceProvider.Mode = CipherMode.ECB
			Dim cryptoTransform As ICryptoTransform = tripleDESCryptoServiceProvider.CreateEncryptor()
			Return cryptoTransform.TransformFinalBlock(InputString, 0, InputString.Length)
		End Function

		Public Shared Function EncryptBytes(DecryptString As String, EncryptionKey As String) As Byte()
			Return Encryption.EncryptBytes(Encoding.ASCII.GetBytes(DecryptString), EncryptionKey)
		End Function

		Public Shared Function EncryptString(InputString As String, EncryptionKey As String) As String
			Return Convert.ToBase64String(Encryption.EncryptBytes(Encoding.ASCII.GetBytes(InputString), EncryptionKey))
		End Function

		Public Shared Function DecryptBytes(DecryptBuffer As Byte(), EncryptionKey As String) As Byte()
			If DecryptBuffer Is Nothing OrElse DecryptBuffer.Length = 0 Then
				Return Nothing
			End If
			If EncryptionKey Is Nothing Then
				EncryptionKey = Encryption.Key
			End If
			Dim tripleDESCryptoServiceProvider As TripleDESCryptoServiceProvider = New TripleDESCryptoServiceProvider()
			Dim mD5CryptoServiceProvider As MD5CryptoServiceProvider = New MD5CryptoServiceProvider()
			tripleDESCryptoServiceProvider.Key = mD5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(EncryptionKey))
			tripleDESCryptoServiceProvider.Mode = CipherMode.ECB
			Dim cryptoTransform As ICryptoTransform = tripleDESCryptoServiceProvider.CreateDecryptor()
			Return cryptoTransform.TransformFinalBlock(DecryptBuffer, 0, DecryptBuffer.Length)
		End Function

		Public Shared Function DecryptBytes(DecryptString As String, EncryptionKey As String) As Byte()
			Return Encryption.DecryptBytes(Convert.FromBase64String(DecryptString), EncryptionKey)
		End Function

		Public Shared Function DecryptString(DecryptString As String, EncryptionKey As String) As String
			Dim result As String
			Try
				result = Encoding.ASCII.GetString(Encryption.DecryptBytes(Convert.FromBase64String(DecryptString), EncryptionKey))
			Catch ex_19 As Object
				result = String.Empty
			End Try
			Return result
		End Function

		Public Shared Function ComputeHash(plainText As String, hashAlgorithm As String, saltBytes As Byte()) As String
			If plainText Is Nothing Then
				Return Nothing
			End If
			If saltBytes Is Nothing Then
				Dim minValue As Integer = 4
				Dim maxValue As Integer = 8
				Dim random As Random = New Random()
				Dim num As Integer = random.[Next](minValue, maxValue)
				saltBytes = New Byte(num)
				Dim rNGCryptoServiceProvider As RNGCryptoServiceProvider = New RNGCryptoServiceProvider()
				rNGCryptoServiceProvider.GetNonZeroBytes(saltBytes)
			End If
			Dim bytes As Byte() = Encoding.UTF8.GetBytes(plainText)
			Dim array As Byte() = New Byte(bytes.Length + saltBytes.Length)
			For i As Integer = 0 To bytes.Length - 1
				array(i) = bytes(i)
			Next
			For j As Integer = 0 To saltBytes.Length - 1
				array(bytes.Length + j) = saltBytes(j)
			Next
			If hashAlgorithm Is Nothing Then
				hashAlgorithm = ""
			End If
			Dim a As String
			Dim hashAlgorithm2 As HashAlgorithm
			If(a = hashAlgorithm.ToUpper()) IsNot Nothing Then
				If a = "SHA1" Then
					hashAlgorithm2 = New SHA1Managed()
					GoTo IL_105
				End If
				If a = "SHA256" Then
					hashAlgorithm2 = New SHA256Managed()
					GoTo IL_105
				End If
				If a = "SHA384" Then
					hashAlgorithm2 = New SHA384Managed()
					GoTo IL_105
				End If
				If a = "SHA512" Then
					hashAlgorithm2 = New SHA512Managed()
					GoTo IL_105
				End If
			End If
			hashAlgorithm2 = New MD5CryptoServiceProvider()
			IL_105:
			Dim array2 As Byte() = hashAlgorithm2.ComputeHash(array)
			Dim array3 As Byte() = New Byte(array2.Length + saltBytes.Length)
			For k As Integer = 0 To array2.Length - 1
				array3(k) = array2(k)
			Next
			For l As Integer = 0 To saltBytes.Length - 1
				array3(array2.Length + l) = saltBytes(l)
			Next
			Return Convert.ToBase64String(array3)
		End Function

		Public Shared Function GZipMemory(Buffer As Byte()) As Byte()
			Dim memoryStream As MemoryStream = New MemoryStream()
			Dim gZipStream As GZipStream = New GZipStream(memoryStream, CompressionMode.Compress)
			gZipStream.Write(Buffer, 0, Buffer.Length)
			gZipStream.Close()
			Dim result As Byte() = memoryStream.ToArray()
			memoryStream.Close()
			Return result
		End Function

		Public Shared Function GZipMemory(Input As String) As Byte()
			Return Encryption.GZipMemory(Encoding.ASCII.GetBytes(Input))
		End Function

		Public Shared Function GZipMemory(Filename As String, IsFile As Boolean) As Byte()
			Dim buffer As Byte() = File.ReadAllBytes(Filename)
			Return Encryption.GZipMemory(buffer)
		End Function

		Public Shared Function GZipFile(Filename As String, OutputFile As String) As Boolean
			Dim array As Byte() = File.ReadAllBytes(Filename)
			Dim fileStream As FileStream = New FileStream(OutputFile, FileMode.OpenOrCreate, FileAccess.Write)
			Dim gZipStream As GZipStream = New GZipStream(fileStream, CompressionMode.Compress)
			gZipStream.Write(array, 0, array.Length)
			gZipStream.Close()
			fileStream.Close()
			Return True
		End Function
	End Class
End Namespace
