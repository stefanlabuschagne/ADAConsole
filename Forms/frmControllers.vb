Imports System.IO
Public Class frmControllers

    Private Sub Vulindlela_ControllersBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Vulindlela_ControllersBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.Vulindlela_ControllersBindingSource.EndEdit()
            Me.Ta_Vulindlela_Controllers.Update(Me.DsADS.Vulindlela_Controllers)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmControllers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsADS.Vulindlela_Controllers' table. You can move, or remove it, as needed.
        Me.Ta_Vulindlela_Controllers.Fill(Me.DsADS.Vulindlela_Controllers)

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub ExportToExcelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportToExcelToolStripMenuItem.Click
        Dim mstr As String
        Dim table As DataTable
        table = Me.Ta_Vulindlela_Controllers.GetData()
        ExportCSV(table, AppPath() & "Vulindlela_User_Distributionlist.csv")
        mstr = AppPath() & "Vulindlela_User_Distributionlist.csv"
        If File.Exists(mstr) Then
            Process.Start(mstr)
        End If
    End Sub

    Private Sub Vulindlela_ControllersBindingNavigator_ItemAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripItemEventArgs) Handles Vulindlela_ControllersBindingNavigator.ItemAdded
        Try
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Vulindlela_ControllersBindingNavigator_ItemRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripItemEventArgs) Handles Vulindlela_ControllersBindingNavigator.ItemRemoved
        Try
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Vulindlela_ControllersBindingNavigator_RefreshItems(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Vulindlela_ControllersBindingNavigator.RefreshItems
        Try
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        Try
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        Try
            With Me.DsADS.Vulindlela_Controllers
                .CFOColumn.DefaultValue = ""
                .EMailColumn.DefaultValue = ""
                .Controller_RSAColumn.DefaultValue = -1
                .Controller_DeptColumn.DefaultValue = -1
                .Controller_NATColumn.DefaultValue = -1
                .Controller_ProvColumn.DefaultValue = -1
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BindingNavigatorMoveNextItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorMoveNextItem.Click
        Try
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BindingNavigatorMoveLastItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorMoveLastItem.Click
        Try
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BindingNavigatorMovePreviousItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorMovePreviousItem.Click
        Try
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BindingNavigatorMoveFirstItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorMoveFirstItem.Click
        Try
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Vulindlela_ControllersDataGridView_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Vulindlela_ControllersDataGridView.KeyUp
        If e.KeyValue = 27 Then
            Me.Close()
        End If
    End Sub

    Private Sub frmControllers_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(27) Then
            Me.Close()
        End If
    End Sub

    Private Sub Vulindlela_ControllersDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Vulindlela_ControllersDataGridView.CellContentClick

    End Sub
End Class
