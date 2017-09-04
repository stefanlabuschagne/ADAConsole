Imports System.IO
Public Class frmVPNadmins

    Private Sub VPNAdminsDataGridView_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles VPNAdminsDataGridView.KeyUp
        If e.KeyValue = 27 Then
            Me.Close()
        End If
    End Sub

    Private Sub frmVPNadmins_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(27) Then
            Me.Close()
        End If
    End Sub

    Private Sub frmVPNadmins_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.VPN_AdminsTableAdapter.Fill(Me.DsADS.VPN_Admins)
        Me.VPN_Admin_CategoriesTableAdapter.Fill(Me.DsADS.VPN_Admin_Categories)
    End Sub

    Private Sub VPN_AdminsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VPN_Admin_CategoriesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.VPN_AdminsBindingSource.EndEdit()
        Me.VPN_AdminsTableAdapter.Update(Me.DsADS.VPN_Admins)
    End Sub

    Private Sub frmVPNadmins_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If Me.Visible Then
            With Me.VPNAdminsDataGridView
                .Left = 0
                .Top = 28
                .Width = Me.VPNAdminsDataGridView.Parent.Width
                .Height = Me.VPNAdminsDataGridView.Parent.Height
            End With
        End If
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        Me.Validate()
        Me.VPN_AdminsBindingSource.EndEdit()
        Me.VPN_AdminsTableAdapter.Update(Me.DsADS.VPN_Admins)

    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        Me.Validate()
        Me.VPN_AdminsBindingSource.EndEdit()
        Me.VPN_AdminsTableAdapter.Update(Me.DsADS.VPN_Admins)
    End Sub

    Private Sub tsName_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tsName.KeyUp
        Me.VPN_AdminsTableAdapter.FillByAdminName(Me.DsADS.VPN_Admins, "%" & Me.tsName.Text.Trim & "%")
        If e.KeyValue = 27 Then
            Me.Close()
        End If
    End Sub

    Private Sub tsDept_Click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tsDept.KeyUp
        Me.VPN_AdminsTableAdapter.FillByAdminsDept(Me.DsADS.VPN_Admins, "%" & Me.tsDept.Text.Trim & "%")
        If e.KeyValue = 27 Then
            Me.Close()
        End If
    End Sub

    Private Sub tsSurname_Click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tsSurname.KeyUp
        Me.VPN_AdminsTableAdapter.FillByAdminSurname(Me.DsADS.VPN_Admins, "%" & Me.tsSurname.Text.Trim & "%")
        If e.KeyValue = 27 Then
            Me.Close()
        End If
    End Sub

    Private Sub ExportToCSVToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportToCSVToolStripMenuItem.Click
        Dim mstr As String
        ExportCSV(Me.VPN_AdminsTableAdapter.GetData(), AppPath() & "VPN_Administrators.csv")
        mstr = AppPath() & "VPN_Administrators.csv"
        If File.Exists(mstr) Then
            Process.Start(mstr)
        End If
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        If MsgBox("Do you want to log the current user as ONE with a Problem", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Create an Incident for the current user") = MsgBoxResult.Yes Then
            Try
                If frmConfigProblem.Visible Then
                    frmConfigProblem.Focus()
                Else
                    frmConfigProblem.Show(Me)
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly, "System Message")
            End Try
        End If
    End Sub
End Class
