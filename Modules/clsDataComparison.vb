Imports System
Imports System.Linq

Public NotInheritable Class PublicationFactory

    Private Sub New()
    End Sub

    ''' <summary>
    ''' Create a diffgram from two datasets
    ''' diffgram contains the list of row to create, update and delete to pass from old to new step
    ''' old and new datasets must have the same schema
    ''' the old dataset give the list of table to compute
    ''' Is supposed that all data have a ToString() method wich render a representative value of the data
    ''' Is supposed that a column named "PK" got a unique string identifier
    ''' </summary>
    ''' <param name="oldDataSet">Old step</param>
    ''' <param name="newDataSet">Current step</param>
    ''' <returns>diffgram as dataset</returns>
    Public Shared Function DeltaMaker(ByVal oldDataSet As DataSet, ByVal newDataSet As DataSet) As DataSet
        Dim datasetdiff As DataSet
        Dim tempRow As DataRow
        Dim tempTable As DataTable
        Dim tempTableName As String
        datasetdiff = New DataSet()

        ' concat all data of each field, in order to compare content
        TTSDataHelper.BeginSerializeHelper(oldDataSet)
        TTSDataHelper.BeginSerializeHelper(newDataSet)

        For i As Integer = 0 To oldDataSet.Tables.Count - 1
            tempTableName = oldDataSet.Tables(i).TableName
            Dim orig As IEnumerable(Of DataRow) = oldDataSet.Tables(tempTableName).AsEnumerable()
            Dim updated As IEnumerable(Of DataRow) = newDataSet.Tables(tempTableName).AsEnumerable()

            ' in updated, wich don't exist in origin
            Dim Added As IEnumerable(Of DataRow) = From u In updated _
             Where Not (From o In orig _
              Select o.Field(Of String)("PK")).Contains(u.Field(Of String)("PK")) _
             Select u
            '  in updated, data different from origin
            ' ignore just added
            Dim Modif As IEnumerable(Of DataRow) = From u In updated _
             Where Not (From o In orig _
              Select o.Field(Of String)("SERIALIZED")).Contains(u.Field(Of String)("SERIALIZED")) AndAlso Not (From a In Added _
              Select a.Field(Of String)("PK")).Contains(u.Field(Of String)("PK")) _
             Select u
            ' in origin, non existing in updated
            Dim Deleted As IEnumerable(Of DataRow) = From o In orig _
             Where Not (From u In updated _
              Select u.Field(Of String)("PK")).Contains(o.Field(Of String)("PK")) _
             Select o

            datasetdiff.Tables.Add(oldDataSet.Tables(tempTableName).Clone())
            tempTable = datasetdiff.Tables(tempTableName)
            tempTable.BeginLoadData()

            ' Create, accept then delete
            For Each row As DataRow In Deleted
                tempRow = tempTable.Rows.Add(row.ItemArray)
                tempRow.AcceptChanges()
                tempRow.Delete()
            Next

            ' Create added
            For Each row As DataRow In Added
                tempRow = tempTable.Rows.Add(row.ItemArray)
                tempRow.AcceptChanges()
                tempRow.SetAdded()
            Next
            ' Create modified
            For Each row As DataRow In Modif
                tempRow = tempTable.Rows.Add(row.ItemArray)
                tempRow.AcceptChanges()
                tempRow.SetModified()
            Next
            tempTable.EndLoadData()

            tempTable.Columns.Remove("SERIALIZED")
        Next

        'remove data comparison helper
        TTSDataHelper.EndSerializeHelper(oldDataSet)
        TTSDataHelper.EndSerializeHelper(newDataSet)

        Return datasetdiff
    End Function
End Class

Friend NotInheritable Class TTSDataHelper
    Private Sub New()
    End Sub

    Public Shared separator As Char = "§"c

    Public Shared Sub BeginSerializeHelper(ByVal dataset As DataSet)
        Dim serialized As String
        For Each table As DataTable In dataset.Tables
            table.Columns.Add("SERIALIZED", GetType(String))
            For Each row As DataRow In table.Rows
                serialized = String.Empty
                For i As Integer = 0 To table.Columns.Count - 3
                    serialized += row(i).ToString() + separator
                Next
                row("SERIALIZED") = serialized
            Next
        Next
    End Sub

    Public Shared Sub EndSerializeHelper(ByVal dataSet As DataSet)
        For Each table As DataTable In dataSet.Tables
            table.Columns.Remove("SERIALIZED")
        Next
    End Sub

End Class
