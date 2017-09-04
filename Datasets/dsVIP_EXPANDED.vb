Partial Public Class dsVIP_EXPANDED
    Partial Class VIEW_departmentsDataTable

        Private Sub VIEW_departmentsDataTable_VIEW_departmentsRowChanging(sender As Object, e As VIEW_departmentsRowChangeEvent) Handles Me.VIEW_departmentsRowChanging

        End Sub

        Private Sub VIEW_departmentsDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.DEPT_DESCRIPTIONColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class
Partial Public Class VIEW_departmentsTableAdapter
End Class
Partial Public Class ta_VIEW_GOVERNMENT_STRUCTURE
End Class


Namespace dsVIP_EXPANDEDTableAdapters
    
    Partial Class VUL_REM_DEPT_MAPTableAdapter

    End Class

    Partial Public Class ta_VIEW_APPLICATION_RIGHTS
    End Class
End Namespace
