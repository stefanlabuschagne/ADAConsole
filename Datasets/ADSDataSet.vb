Partial Class ADSDataSet
    Partial Class CFOListDataTable

        Private Sub CFOListDataTable_CFOListRowChanging(sender As Object, e As CFOListRowChangeEvent) Handles Me.CFOListRowChanging

        End Sub

    End Class

    Partial Class CFOListTempDataTable

        Private Sub CFOListTempDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.IDColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

        Private Sub CFOListTempDataTable_CFOListTempRowChanging(sender As Object, e As CFOListTempRowChangeEvent) Handles Me.CFOListTempRowChanging

        End Sub

    End Class

End Class

Namespace ADSDataSetTableAdapters
    
    Partial Class CFOListTableAdapter

    End Class

    Partial Public Class CFOListTempTableAdapter

    End Class
End Namespace

Namespace ADSDataSetTableAdapters

    Partial Public Class CFOListTableAdapter
    End Class
End Namespace
