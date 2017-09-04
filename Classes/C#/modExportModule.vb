Module modExportModule

    Private Function OS(ByVal Word As String) As String
        Dim i As Integer = Word.IndexOf(".")
        While i > -1
            Word = Word.Remove(i, 1)
            i = Word.IndexOf(".")
        End While
        Return Word
    End Function

    Public Sub ExportExcel(ByVal Table As DataTable, ByVal Location As String)
        If My.Computer.FileSystem.FileExists(Location) Then My.Computer.FileSystem.DeleteFile(Location)
        Dim CreateString As String = ""
        Dim Columns As String = ""
        Dim Mark As String = ""
        Using Connection As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Location & ";Extended Properties=""Excel 8.0;HDR=YES""")
            Connection.Open()
            CreateString = "CREATE TABLE [" & Table.TableName & "] ("
            Columns = "("
            Mark = "("
            For Each Column As DataColumn In Table.Columns
                CreateString &= OS(Column.ColumnName)
                Select Case Column.DataType.Name
                    Case "SByte", "Byte", "Int16", "Int32", "Int64", "Decimal", "Double", "Single"
                        CreateString &= " Number, "
                    Case "Boolean"
                        CreateString &= " Bit, "
                    Case "Char", "String"
                        CreateString &= " Memo, "
                    Case "DateTime"
                        CreateString &= " DateTime, "
                    Case Else
                        CreateString &= " Text, "
                End Select
                Columns &= OS(Column.ColumnName) & ", "
                Mark &= "?,"
            Next
            CreateString = CreateString.Remove(CreateString.Length - 2, 2)
            CreateString &= ")"
            Columns = Columns.Remove(Columns.Length - 2, 2)
            Columns &= ")"
            Mark = Mark.Remove(Mark.Length - 1, 1)
            Mark &= ")"
            Using Command As New OleDb.OleDbCommand(CreateString.ToString, Connection)
                Command.ExecuteNonQuery()
            End Using
            Using Adapter As New OleDb.OleDbDataAdapter("SELECT * FROM [" & Table.TableName & "$]", Connection)
                Using ExcelDataset As New DataSet
                    Adapter.Fill(ExcelDataset, Table.TableName)
                    Adapter.InsertCommand = New OleDb.OleDbCommand("INSERT INTO [" & Table.TableName & "] " & Columns.ToString & " VALUES " & Mark.ToString, Connection)
                    For Each Column As DataColumn In Table.Columns
                        Select Case Column.DataType.Name
                            Case "SByte", "Byte", "Int16", "Int32", "Int64", "Decimal", "Double", "Single"
                                Adapter.InsertCommand.Parameters.Add("@" & OS(Column.ColumnName), OleDb.OleDbType.Numeric, 100, OS(Column.ColumnName))
                            Case "Boolean"
                                Adapter.InsertCommand.Parameters.Add("@" & OS(Column.ColumnName), OleDb.OleDbType.Boolean, 100, OS(Column.ColumnName))
                            Case "Char", "String"
                                Adapter.InsertCommand.Parameters.Add("@" & OS(Column.ColumnName), OleDb.OleDbType.Char, 65536, OS(Column.ColumnName))
                            Case "DateTime"
                                Adapter.InsertCommand.Parameters.Add("@" & OS(Column.ColumnName), OleDb.OleDbType.DBTimeStamp, 100, OS(Column.ColumnName))
                            Case Else
                                Adapter.InsertCommand.Parameters.Add("@" & OS(Column.ColumnName), OleDb.OleDbType.Char, 65536, OS(Column.ColumnName))
                        End Select
                    Next
                    For Each Row As DataRow In Table.Rows
                        If Row.RowState <> DataRowState.Deleted Then
                            Dim ExcelRow As DataRow = ExcelDataset.Tables(Table.TableName).NewRow
                            For i As Integer = 0 To Table.Columns.Count - 1
                                ExcelRow.Item(i) = Row.Item(i)
                            Next
                            ExcelDataset.Tables(Table.TableName).Rows.Add(ExcelRow)
                        End If
                    Next
                    Adapter.Update(ExcelDataset, Table.TableName)
                End Using
            End Using
        End Using
    End Sub

    Public Sub ExportXML(ByVal Table As DataTable, ByVal Location As String)
        Using Writer As New System.Xml.XmlTextWriter(Location, System.Text.Encoding.UTF8)
            Writer.WriteStartDocument()
            Table.WriteXml(Writer, XmlWriteMode.WriteSchema)
            Writer.WriteEndDocument()
            Writer.Close()
        End Using
    End Sub

    Public Sub ExportHTML(ByVal Table As DataTable, ByVal Location As String)
        Using Writer As New System.IO.StreamWriter(Location)
            Writer.WriteLine("<HTML>")
            Writer.WriteLine(" <HEAD>")
            Writer.WriteLine("  <meta http-equiv='Content-Type' content='text/html; charset=utf-8'>")
            Writer.WriteLine(" </HEAD>")
            Writer.WriteLine(" <BODY>")
            Writer.WriteLine("<TABLE border='1'>")
            Writer.WriteLine(" <TR>")
            For Each Column As DataColumn In Table.Columns
                Writer.WriteLine("  <TD>" & Column.ColumnName & "</td>")
            Next
            Writer.WriteLine(" </TR>")
            For Each Row As DataRow In Table.Rows
                Writer.WriteLine(" <TR>")
                For Each Column As DataColumn In Table.Columns
                    Writer.WriteLine("  <TD>" & Row.Item(Column).ToString & "</TD>")
                Next
                Writer.WriteLine(" </TR>")
            Next
            Writer.WriteLine("</TABLE>")
            Writer.WriteLine(" </BODY>")
            Writer.WriteLine("</HTML>")
        End Using
    End Sub

    Public Sub ExportText(ByVal Table As DataTable, ByVal Location As String)
        Using Writer As New System.IO.StreamWriter(Location)
            Writer.WriteLine("Executed: " + DateTime.Now.ToString)
            For i As Integer = 0 To 99
                Writer.Write("*")
            Next
            Writer.WriteLine("")
            For Each Column As DataColumn In Table.Columns
                Writer.WriteLine("")
                Writer.WriteLine(Column.ColumnName)
                For i As Integer = 0 To 99
                    Writer.Write("-")
                Next
                Writer.WriteLine("")
                For Each Row As DataRow In Table.Rows
                    Writer.WriteLine(Row(Column).ToString)
                Next
            Next
            For i As Integer = 0 To 99
                Writer.Write("*")
            Next
            Writer.Close()
        End Using
    End Sub

    Public Sub ExportCSV(ByVal Table As DataTable, ByVal Location As String)

        Using Writer As New System.IO.StreamWriter(Location)
            For Each Row As DataRow In Table.Rows
                For Each Column As DataColumn In Table.Columns
                    Dim Value As String = Row.Item(Column).ToString
                    If Value.Contains(Chr(13)) Then
                        Writer.Write(Chr(34) & Column.ColumnName & Chr(34))
                    Else
                        Writer.Write(Chr(34) & Column.ColumnName & Chr(34))
                    End If
                    If Column.Ordinal + 1 < Table.Columns.Count Then Writer.Write(",")
                Next
                Writer.WriteLine()
                Exit For
            Next
            For Each Row As DataRow In Table.Rows
                For Each Column As DataColumn In Table.Columns
                    If Row.Item(Column).GetType Is GetType(DateTime) Then
                        Writer.Write(CType(Row.Item(Column), DateTime).ToString(My.Computer.Info.InstalledUICulture.DateTimeFormat.SortableDateTimePattern))
                    ElseIf Microsoft.VisualBasic.Left(Row.Item(Column).ToString, 1) = "0" And _
                             Len(Row.Item(Column).ToString) > 7 Then
                        Dim newstr As String = ""
                        Dim leftpart As String = ""
                        Dim rightpart As String = ""
                        leftpart = Microsoft.VisualBasic.Left(Row.Item(Column).ToString, 3).Trim
                        rightpart = Mid(Row.Item(Column).ToString, 4).Trim
                        newstr = "(" & leftpart & ") " & rightpart
                        newstr = Replace(newstr, "-", "")
                        newstr = Replace(newstr, " ", "")
                        newstr = Replace(newstr, ")", ") ")
                        Writer.Write(Chr(34) & newstr & Chr(34))
                    ElseIf Row.Item(Column).GetType Is GetType(Short) And _
                             (Row.Item(Column).ToString = "1" Or Row.Item(Column).ToString = "0") Then
                        Dim newstr As String = ""
                        If Row.Item(Column).ToString = "1" Then
                            newstr = "Yes"
                        ElseIf Row.Item(Column).ToString = "0" Then
                            newstr = "No"
                        End If
                        Writer.Write(Chr(34) & newstr & Chr(34))
                    Else
                        Dim Value As String = Row.Item(Column).ToString
                        If Value.Contains(Chr(13)) Then
                            Writer.Write(Chr(34) & Row.Item(Column).ToString & Chr(34))
                        Else
                            Writer.Write(Chr(34) & Row.Item(Column).ToString & Chr(34))
                        End If
                    End If
                    If Column.Ordinal + 1 < Table.Columns.Count Then Writer.Write(",")
                Next
                Writer.WriteLine()
            Next
            Writer.Close()
        End Using
    End Sub
End Module