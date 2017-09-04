
Partial Public Class dsARSystemDataSet

    Partial Class CustNotifyDataTable

        Private Sub CustNotifyDataTable_CustNotifyRowChanging(sender As Object, e As CustNotifyRowChangeEvent) Handles Me.CustNotifyRowChanging

        End Sub

    End Class

    Partial Class LOG_DM_Customer_InformationDataTable

        Private Sub LOG_DM_Customer_InformationDataTable_LOG_DM_Customer_InformationRowChanging(sender As Object, e As LOG_DM_Customer_InformationRowChangeEvent) Handles Me.LOG_DM_Customer_InformationRowChanging

        End Sub

    End Class

    Partial Public Class VIEW_CFO_RULES_FLAGS_OUTSTANDINGDataTable
        Private Sub VIEW_CFO_RULES_FLAGS_OUTSTANDINGDataTable_VIEW_CFO_RULES_FLAGS_OUTSTANDINGRowChanging(ByVal sender As System.Object, ByVal e As VIEW_CFO_RULES_FLAGS_OUTSTANDINGRowChangeEvent) Handles Me.VIEW_CFO_RULES_FLAGS_OUTSTANDINGRowChanging
        End Sub
    End Class

    Partial Public Class CFOClosureListDataTable
        Private Sub CFOClosureListDataTable_CFOClosureListRowChanging(ByVal sender As System.Object, ByVal e As CFOClosureListRowChangeEvent) Handles Me.CFOClosureListRowChanging
        End Sub
    End Class

    Partial Public Class RemedyUsersByFirstLetterDataTable
        Private Sub RemedyUsersByFirstLetterDataTable_RemedyUsersByFirstLetterRowChanging(ByVal sender As System.Object, ByVal e As RemedyUsersByFirstLetterRowChangeEvent) Handles Me.RemedyUsersByFirstLetterRowChanging
        End Sub
    End Class

    Partial Public Class LOG_IN_Request_TrackingDataTable
        Private Sub LOG_IN_Request_TrackingDataTable_LOG_IN_Request_TrackingRowChanging(ByVal sender As System.Object, ByVal e As LOG_IN_Request_TrackingRowChangeEvent) Handles Me.LOG_IN_Request_TrackingRowChanging
        End Sub
    End Class

    Partial Public Class RemedyOpenRequestsDataTable
        Private Sub RemedyOpenRequestsDataTable_RemedyOpenRequestsRowChanging(ByVal sender As System.Object, ByVal e As RemedyOpenRequestsRowChangeEvent) Handles Me.RemedyOpenRequestsRowChanging
        End Sub
    End Class

End Class

Namespace dsARSystemDataSetTableAdapters

    Partial Class LOG_IN_Request_TrackingTableAdapter

    End Class

    Partial Class LOG_DM_DepartmentTableAdapter

    End Class

    Partial Class RemedyOpenRequestsTableAdapter
    End Class

    Partial Class ta_CustomerInfo
    End Class

    Partial Class ta_CustNotify
    End Class

    
    Partial Class QueriesTableAdapter

        'Function connection() As Object
        '    Throw New NotImplementedException
        'End Function

    End Class
    Partial Class RemedyByFirstLetterOfSurnameTableAdapter

    End Class

    Partial Public Class ta_RemedyUsersByFirstLetter

    End Class

    Partial Public Class CopyOfta_RemedyUsersByFirstLetter

    End Class

    Partial Public Class VIEW_CFO_RULES_FLAGS_OUTSTANDINGTableAdapter

    End Class

    Partial Public Class LOG_DM_Customer_InformationTableAdapter

    End Class

End Namespace


