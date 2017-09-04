Partial Class dsADS
    Partial Class EstablishmentDataTable

        Private Sub EstablishmentDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.PAYPOINTColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

        Private Sub EstablishmentDataTable_EstablishmentRowChanging(sender As Object, e As EstablishmentRowChangeEvent) Handles Me.EstablishmentRowChanging

        End Sub

    End Class

    Partial Class CFO_Letters_YearMonthDataTable

        Private Sub CFO_Letters_YearMonthDataTable_CFO_Letters_YearMonthRowChanging(ByVal sender As System.Object, ByVal e As CFO_Letters_YearMonthRowChangeEvent) Handles Me.CFO_Letters_YearMonthRowChanging

        End Sub

    End Class

    Partial Class VIP_USERS_ResetPasswordDataTable

        Private Sub VIP_USERS_ResetPasswordDataTable_VIP_USERS_ResetPasswordRowChanging(ByVal sender As System.Object, ByVal e As VIP_USERS_ResetPasswordRowChangeEvent) Handles Me.VIP_USERS_ResetPasswordRowChanging

        End Sub

    End Class

    'Shared Function CFOListDataTable() As CFOListDataTable
    '    Throw New NotImplementedException
    'End Function

End Class

Namespace dsADSTableAdapters

    Partial Class get_shortcodeTableAdapter

    End Class

    Partial Class VIP_USERSTableAdapter

    End Class

    Partial Class CFOListTableAdapter

    End Class

    Partial Class CFOTableAdapter

    End Class

    Partial Class CFO_Letters_YearMonthTableAdapter

    End Class

    Partial Class VIP_USERS_ResetPasswordTableAdapter

        'Function GetDataByPersal(p1 As String) As DataTable
        '    Throw New NotImplementedException
        'End Function

    End Class

    Partial Class VIP_USERS_NewUsersTableAdapter

    End Class

    Partial Public Class ADCONSOLELOGTableAdapter
    End Class

End Namespace

Namespace dsADSTableAdapters

    Partial Class CountNewUsersTableAdapter

    End Class

    Partial Class VIP_USERS_NewUsersTableAdapter

    End Class

    Partial Class ta_Establishment

    End Class

    Partial Class VIP_USERS_ResetPasswordTableAdapter

    End Class

    Partial Class ADCONSOLELOGTableAdapter

    End Class

    Partial Class VIP_USERSTableAdapter

    End Class

    Partial Public Class KICKOUTTableAdapter

    End Class
End Namespace

Namespace dsADSTableAdapters

    Partial Public Class AD_SNAPSHOT_USER_COUNTTableAdapter

    End Class
End Namespace

Namespace dsADSTableAdapters

    Partial Public Class Not_On_Estab_Thismonth_CountTableAdapter
    End Class
End Namespace

Namespace dsADSTableAdapters

    Partial Public Class AD_Disabled_UsersTableAdapter
    End Class
End Namespace

Namespace dsADSTableAdapters

    Partial Public Class CFOTableAdapter
    End Class
End Namespace

Namespace dsADSTableAdapters

    Partial Public Class Department_DiffersTableAdapter
    End Class
End Namespace

Namespace dsADSTableAdapters

    Partial Public Class CFOApproval_ta
    End Class
End Namespace

Namespace dsADSTableAdapters

    Partial Public Class CFOListTableAdapter
    End Class
End Namespace

Namespace dsADSTableAdapters

    Partial Public Class RULES_FLAGSTableAdapter
    End Class
End Namespace

Namespace dsADSTableAdapters

    Partial Public Class EXCLUSIONSTableAdapter
    End Class
End Namespace

Namespace dsADSTableAdapters

    Partial Public Class GetResetPasswordsTableAdapter
    End Class
End Namespace

Namespace dsADSTableAdapters

    Partial Public Class ta_Vulindlela_Controllers
    End Class
End Namespace

Namespace dsADSTableAdapters

    Partial Public Class Config_ProblemTableAdapter
    End Class
End Namespace

Partial Class dsADS
End Class

Partial Class dsADS
End Class

Namespace dsADSTableAdapters

    Partial Public Class VIP_USERS_ResetPasswordTableAdapter
    End Class
End Namespace

Namespace dsADSTableAdapters

    Partial Public Class VPN_AdminsTableAdapter
    End Class
End Namespace

Namespace dsADSTableAdapters

    Partial Public Class VIP_USERSTableAdapter
    End Class
End Namespace

Namespace dsADSTableAdapters

    Partial Public Class VIP_USERSTableAdapter
    End Class
End Namespace
