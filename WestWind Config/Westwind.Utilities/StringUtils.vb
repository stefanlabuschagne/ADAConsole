Imports System
Imports System.Globalization
Imports System.IO
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Threading

Namespace Westwind.Utilities
	Friend Module StringUtils
		Private base36CharArray As Char() = "0123456789abcdefghijklmnopqrstuvwxyz".ToCharArray()

		Private base36Chars As String = "0123456789abcdefghijklmnopqrstuvwxyz"

		Public Function FixHTMLForDisplay(html As String) As String
			html = html.Replace("<", "&lt;")
			html = html.Replace(">", "&gt;")
			html = html.Replace("""", "&quot;")
			Return html
		End Function

		Public Function StripHtml(html As String) As String
			html = Regex.Replace(html, "<(.|\n)*?>", String.Empty)
			html = html.Replace(vbTab, " ")
			html = html.Replace(vbCrLf, String.Empty)
			html = html.Replace("   ", " ")
			Return html.Replace("  ", " ")
		End Function

		Public Function DisplayMemo(htmlText As String) As String
			If htmlText Is Nothing Then
				Return String.Empty
			End If
			htmlText = htmlText.Replace(vbCrLf, vbCr)
			htmlText = htmlText.Replace(vbLf, vbCr)
			htmlText = htmlText.Replace(vbCr, "<br />")
			Return htmlText
		End Function

		Public Function DisplayMemoEncoded(text As String) As String
			If text Is Nothing Then
				Return String.Empty
			End If
			Dim flag As Boolean = False
			If text.Contains("<pre>") Then
				text = text.Replace("<pre>", "__pre__")
				text = text.Replace("</pre>", "__/pre__")
				flag = True
			End If
			text = StringUtils.DisplayMemo(StringUtils.HtmlEncode(text))
			If flag Then
				text = text.Replace("__pre__", "<pre>")
				text = text.Replace("__/pre__", "</pre>")
			End If
			Return text
		End Function

		Public Function HtmlEncode(text As String) As String
			If text Is Nothing Then
				Return String.Empty
			End If
			Dim stringBuilder As StringBuilder = New StringBuilder(text.Length)
			Dim length As Integer = text.Length
			For i As Integer = 0 To length - 1
				Dim c As Char = text(i)
				If c <> """" Then
					If c <> "&" Then
						Select Case c
							Case "<"
								stringBuilder.Append("&lt;")
								GoTo IL_D6
							Case ">"
								stringBuilder.Append("&gt;")
								GoTo IL_D6
						End Select
						If text(i) > "" Then
							stringBuilder.Append("&#")
							stringBuilder.Append((CInt(text(i))).ToString(CultureInfo.InvariantCulture))
							stringBuilder.Append(";")
						Else
							stringBuilder.Append(text(i))
						End If
					Else
						stringBuilder.Append("&amp;")
					End If
				Else
					stringBuilder.Append("&quot;")
				End If
				IL_D6:
			Next
			Return stringBuilder.ToString()
		End Function

		Public Function ExtractString(source As String, beginDelim As String, endDelim As String, Optional caseSensitive As Boolean=False, Optional allowMissingEndDelimiter As Boolean=False, Optional returnDelimiters As Boolean=False) As String
			If String.IsNullOrEmpty(source) Then
				Return String.Empty
			End If
			Dim num As Integer
			Dim num2 As Integer
			If caseSensitive Then
				num = source.IndexOf(beginDelim)
				If num = -1 Then
					Return String.Empty
				End If
				If Not returnDelimiters Then
					num2 = source.IndexOf(endDelim, num + beginDelim.Length)
				Else
					num2 = source.IndexOf(endDelim, num)
				End If
			Else
				num = source.IndexOf(beginDelim, 0, source.Length, StringComparison.OrdinalIgnoreCase)
				If num = -1 Then
					Return String.Empty
				End If
				If Not returnDelimiters Then
					num2 = source.IndexOf(endDelim, num + beginDelim.Length, StringComparison.OrdinalIgnoreCase)
				Else
					num2 = source.IndexOf(endDelim, num, StringComparison.OrdinalIgnoreCase)
				End If
			End If
			If allowMissingEndDelimiter AndAlso num2 = -1 Then
				Return source.Substring(num + beginDelim.Length)
			End If
			If num <= -1 OrElse num2 <= 1 Then
				Return String.Empty
			End If
			If Not returnDelimiters Then
				Return source.Substring(num + beginDelim.Length, num2 - num - beginDelim.Length)
			End If
			Return source.Substring(num, num2 - num + endDelim.Length)
		End Function

		Public Function ExtractString(source As String, beginDelim As String, endDelim As String, caseSensitive As Boolean) As String
			Return StringUtils.ExtractString(source, beginDelim, endDelim, caseSensitive, False, False)
		End Function

		Public Function ExtractString(source As String, beginDelim As String, endDelim As String) As String
			Return StringUtils.ExtractString(source, beginDelim, endDelim, False, False, False)
		End Function

		Public Function ReplaceStringInstance(origString As String, findString As String, replaceWith As String, instance As Integer, caseInsensitive As Boolean) As String
			If instance = -1 Then
				Return StringUtils.ReplaceString(origString, findString, replaceWith, caseInsensitive)
			End If
			Dim num As Integer = 0
			For i As Integer = 0 To instance - 1
				If caseInsensitive Then
					num = origString.IndexOf(findString, num, origString.Length - num, StringComparison.OrdinalIgnoreCase)
				Else
					num = origString.IndexOf(findString, num)
				End If
				If num = -1 Then
					Return origString
				End If
				If i < instance - 1 Then
					num += findString.Length
				End If
			Next
			Return origString.Substring(0, num) + replaceWith + origString.Substring(num + findString.Length)
		End Function

		Public Function ReplaceString(origString As String, findString As String, replaceString As String, caseInsensitive As Boolean) As String
			Dim num As Integer = 0
			While True
				If caseInsensitive Then
					num = origString.IndexOf(findString, num, origString.Length - num, StringComparison.OrdinalIgnoreCase)
				Else
					num = origString.IndexOf(findString, num)
				End If
				If num = -1 Then
					Exit While
				End If
				origString = origString.Substring(0, num) + replaceString + origString.Substring(num + findString.Length)
				num += replaceString.Length
			End While
			Return origString
		End Function

		Public Function Empty(text As String) As Boolean
			Return text Is Nothing OrElse text.Trim().Length = 0
		End Function

		Public Function Empty(text As Object) As Boolean
			Return StringUtils.Empty(TryCast(text, String))
		End Function

		Public Function TrimStart(text As String, textToTrim As String, caseInsensitive As Boolean) As String
			While True
				Dim text2 As String = text.Substring(0, textToTrim.Length)
				If Not(text2 = textToTrim) AndAlso (Not caseInsensitive OrElse Not(text2.ToLower() = textToTrim.ToLower())) Then
					Exit While
				End If
				If text.Length <= text2.Length Then
					text = ""
				Else
					text = text.Substring(textToTrim.Length)
				End If
			End While
			Return text
		End Function

		Public Function Replicate(input As String, charCount As Integer) As String
			Return New StringBuilder().Insert(0, "input", charCount).ToString()
		End Function

		Public Function Replicate(character As Char, charCount As Integer) As String
			Return New String(character, charCount)
		End Function

		Public Function ProperCase(Input As String) As String
			Return Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(Input)
		End Function

		Public Function ToCamelCase(phrase As String) As String
			If phrase Is Nothing Then
				Return String.Empty
			End If
			Dim stringBuilder As StringBuilder = New StringBuilder(phrase.Length)
			Dim flag As Boolean = True
			For i As Integer = 0 To phrase.Length - 1
				Dim c As Char = phrase(i)
				If Char.IsWhiteSpace(c) OrElse Char.IsPunctuation(c) OrElse Char.IsSeparator(c) Then
					flag = True
				Else
					If flag Then
						stringBuilder.Append(Char.ToUpper(c))
					Else
						stringBuilder.Append(Char.ToLower(c))
					End If
					flag = False
				End If
			Next
			Return stringBuilder.ToString()
		End Function

		Public Function FromCamelCase(camelCase As String) As String
			If camelCase Is Nothing Then
				Throw New ArgumentException("Null is not allowed for StringUtils.FromCamelCase")
			End If
			Dim stringBuilder As StringBuilder = New StringBuilder(camelCase.Length + 10)
			Dim flag As Boolean = True
			Dim c As Char = vbNullChar
			For i As Integer = 0 To camelCase.Length - 1
				Dim c2 As Char = camelCase(i)
				If Not flag AndAlso (Char.IsUpper(c2) OrElse (Char.IsDigit(c2) AndAlso Not Char.IsDigit(c))) Then
					stringBuilder.Append(" ")
				End If
				stringBuilder.Append(c2)
				flag = False
				c = c2
			Next
			Return stringBuilder.ToString()
		End Function

		Public Function TerminateString(value As String, terminator As String) As String
			If String.IsNullOrEmpty(value) OrElse value.EndsWith(terminator) Then
				Return value
			End If
			Return value + terminator
		End Function

		Public Function TrimTo(value As String, charCount As Integer) As String
			If value Is Nothing Then
				Return String.Empty
			End If
			If value.Length > charCount Then
				Return value.Substring(0, charCount)
			End If
			Return value
		End Function

		Public Function NormalizeIndentation(code As String) As String
			Dim text As String = code.Replace(vbTab, "   ")
			Dim array As String() = text.Split(New String()() = { vbCrLf, vbCr, vbLf }, StringSplitOptions.None)
			Dim num As Integer = 1000
			Dim array2 As String() = array
			For i As Integer = 0 To array2.Length - 1
				Dim text2 As String = array2(i)
				If text2.Length <> 0 Then
					Dim num2 As Integer = 0
					Dim text3 As String = text2
					For j As Integer = 0 To text3.Length - 1
						Dim c As Char = text3(j)
						If c <> " " OrElse num2 >= num Then
							Exit For
						End If
						num2 += 1
					Next
					If num2 = 0 Then
						Return code
					End If
					num = num2
				End If
			Next
			Dim findString As String = New String(" ", num)
			Dim stringBuilder As StringBuilder = New StringBuilder()
			Dim array3 As String() = array
			For k As Integer = 0 To array3.Length - 1
				Dim origString As String = array3(k)
				stringBuilder.AppendLine(StringUtils.ReplaceStringInstance(origString, findString, "", 1, False))
			Next
			Return stringBuilder.ToString()
		End Function

		Public Function TextAbstract(text As String, length As Integer) As String
			If text Is Nothing Then
				Return String.Empty
			End If
			If text.Length <= length Then
				Return text
			End If
			text = text.Substring(0, length)
			text = text.Substring(0, text.LastIndexOf(" "))
			Return text + "..."
		End Function

		Public Function HtmlAbstract(html As String, length As Integer) As String
			Return StringUtils.TextAbstract(StringUtils.StripHtml(html), length)
		End Function

		Public Sub LogString(output As String, filename As String)
			Dim streamWriter As StreamWriter = New StreamWriter(filename, True)
			streamWriter.WriteLine(DateTime.Now.ToString() + " - " + output)
			streamWriter.Close()
		End Sub

		Public Function NewStringId() As String
			Return Guid.NewGuid().ToString().GetHashCode().ToString("x")
		End Function

		Public Function ParseInt(input As String, defaultValue As Integer, numberFormat As IFormatProvider) As Integer
			Dim result As Integer = defaultValue
			Integer.TryParse(input, NumberStyles.Any, numberFormat, result)
			Return result
		End Function

		Public Function ParseInt(input As String, defaultValue As Integer) As Integer
			Return StringUtils.ParseInt(input, defaultValue, CultureInfo.CurrentCulture.NumberFormat)
		End Function

		Public Function ParseDecimal(input As String, defaultValue As Decimal, numberFormat As IFormatProvider) As Decimal
			Dim result As Decimal = defaultValue
			Decimal.TryParse(input, NumberStyles.Any, numberFormat, result)
			Return result
		End Function

		Public Function StripNonNumber(input As String) As String
			Dim array As Char() = input.ToCharArray()
			Dim stringBuilder As StringBuilder = New StringBuilder()
			Dim array2 As Char() = array
			For i As Integer = 0 To array2.Length - 1
				Dim c As Char = array2(i)
				If Char.IsNumber(c) OrElse Char.IsSeparator(c) Then
					stringBuilder.Append(c)
				End If
			Next
			Return stringBuilder.ToString()
		End Function

		Public Function StringToStream(text As String, encoding As Encoding) As Stream
			Dim memoryStream As MemoryStream = New MemoryStream(text.Length * 2)
			Dim bytes As Byte() = encoding.GetBytes(text)
			memoryStream.Write(bytes, 0, bytes.Length)
			memoryStream.Position = 0L
			Return memoryStream
		End Function

		Public Function StringToStream(text As String) As Stream
			Return StringUtils.StringToStream(text, Encoding.[Default])
		End Function

		Public Function GetProperty(propertyString As String, key As String) As String
			Return StringUtils.ExtractString(propertyString, "<" + key + ">", "</" + key + ">")
		End Function

		Public Function SetProperty(propertyString As String, key As String, value As String) As String
			Dim text As String = StringUtils.ExtractString(propertyString, "<" + key + ">", "</" + key + ">")
			If String.IsNullOrEmpty(value) AndAlso text <> String.Empty Then
				Return propertyString.Replace(text, "")
			End If
			Dim text2 As String = String.Concat(New String()() = { "<", key, ">", value, "</", key, ">" })
			If text <> String.Empty Then
				Return propertyString.Replace(text, text2)
			End If
			Return propertyString + text2 + vbCrLf
		End Function

		Public Function UrlEncode(text As String) As String
			If String.IsNullOrEmpty(text) Then
				Return String.Empty
			End If
			Return Uri.EscapeDataString(text)
		End Function

		Public Function UrlDecode(text As String) As String
			text = text.Replace("+", " ")
			Return Uri.UnescapeDataString(text)
		End Function

		Public Function GetUrlEncodedKey(urlEncoded As String, key As String) As String
			urlEncoded = "&" + urlEncoded + "&"
			Dim num As Integer = urlEncoded.IndexOf("&" + key + "=", StringComparison.OrdinalIgnoreCase)
			If num < 0 Then
				Return String.Empty
			End If
			Dim num2 As Integer = num + 2 + key.Length
			Dim num3 As Integer = urlEncoded.IndexOf("&", num2)
			If num3 < 0 Then
				Return String.Empty
			End If
			Return StringUtils.UrlDecode(urlEncoded.Substring(num2, num3 - num2))
		End Function

		Public Function SetUrlEncodedKey(urlEncoded As String, key As String, value As String) As String
			If Not urlEncoded.EndsWith("?") AndAlso Not urlEncoded.EndsWith("&") Then
				urlEncoded += "&"
			End If
			Dim match As Match = Regex.Match(urlEncoded, "[?|&]" + key + "=.*?&")
			If match Is Nothing OrElse String.IsNullOrEmpty(match.Value) Then
				urlEncoded = String.Concat(New String()() = { urlEncoded, key, "=", StringUtils.UrlEncode(value), "&" })
			Else
				urlEncoded = urlEncoded.Replace(match.Value, String.Concat(New String()() = { match.Value.Substring(0, 1), key, "=", StringUtils.UrlEncode(value), "&" }))
			End If
			Return urlEncoded.TrimEnd(New Char()() = { "&" })
		End Function

		Public Function Base36Encode(value As Long) As String
			Dim text As String = ""
			Dim flag As Boolean = value < 0L
			If flag Then
				value *= -1L
			End If
			Do
				' The following expression was wrapped in a checked-expression
				' The following expression was wrapped in a unchecked-expression
				text = StringUtils.base36CharArray(CInt(CType((value Mod CLng(StringUtils.base36CharArray.Length)), IntPtr))) + text
				value /= 36L
			Loop While value <> 0L
			If Not flag Then
				Return text
			End If
			Return text + "-"
		End Function

		Public Function Base36Decode(input As String) As Long
			Dim flag As Boolean = False
			If input.EndsWith("-") Then
				flag = True
				input = input.Substring(0, input.Length - 1)
			End If
			Dim array As Char() = input.ToCharArray()
			Array.Reverse(array)
			Dim num As Long = 0L
			For num2 As Long = 0L To CLng(array.Length) - 1
				' The following expression was wrapped in a checked-expression
				Dim num3 As Long = CLng(StringUtils.base36Chars.IndexOf(array(CInt(CType(num2, IntPtr)))))
				num += Convert.ToInt64(CDec(num3) * Math.Pow(36.0, CDec(num2)))
			Next
			If Not flag Then
				Return num
			End If
			Return num * -1L
		End Function
	End Module
End Namespace
