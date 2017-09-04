Public Class frmUsersNotOnEstab

    Private Sub frmUsersNotOnEstab_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(27) Then
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Hourglass(True)
        Me.txt_Not_On_Estab_Thismonth.Text = Not_On_Estab_Thismonth_CountTableAdapter.Not_On_Estab_Thismonth_Count.ToString()
        Hourglass(false)
    End Sub

    Private Sub Hourglass(ByVal Show As Boolean)

        If Show = True Then
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Else
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End If
        Return

    End Sub

End Class