'Imports System
'Imports System.Data
'Imports System.Data.OleDb
'Imports System.Data.SqlCliente
'Imports System.Windows.Forms.DataGridView

Public Class frmTempCFOList
    Dim ctr As Integer = 0
    Dim DataGridView1 As Object

    Private Sub CFOListTempBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.CFOListTempBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ADSDataSet)
    End Sub

    Private Sub frmTempCFOList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.CFOListTempTableAdapter.Fill(Me.ADSDataSet.CFOListTemp)

        Dim i As Integer = CFOListTempDataGridView.CurrentCell.RowIndex
        Dim DeptCode As String = CFOListTempDataGridView.Rows(i).Cells(10).Value
        Dim _PersalNo As String = CFOListTempDataGridView.Rows(i).Cells(1).Value

        Me.CFOListTableAdapter.Fill(Me.ADSDataSet.CFOList, DeptCode)
        Me.CFOListTempDataGridView.Refresh()

    End Sub

    Private Sub CFOListTempBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.CFOListTempBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ADSDataSet)
    End Sub

    Private Sub CFOListTempBindingNavigatorSaveItem_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.CFOListTempBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ADSDataSet)

    End Sub

    Private Sub CFOListBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.CFOListTempBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ADSDataSet)

    End Sub

    Private Sub FillToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            ' Me.CFOListTableAdapter.Fill(Me.ADSDataSet.CFOList)
            Me.CFOListTempTableAdapter.Fill(Me.ADSDataSet.CFOListTemp)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.CFOListTempTableAdapter.Fill(Me.ADSDataSet.CFOListTemp)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CFOListTempBindingNavigatorSaveItem_Click_3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.CFOListTempBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ADSDataSet)
    End Sub

    Private Sub PosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PosToolStripMenuItem.Click

        '' Add to CFOLIST-TableAdapter

        Dim mm As String = ""
        Dim counter As Integer
        Dim rownumber As Integer
        Dim i As Integer
        Dim DeptCode As String = "" 'CFOListTempDataGridView.Rows(i).Cells(10).Value
        Dim _PersalNo As String = "" 'CFOListTempDataGridView.Rows(i).Cells(1).Value
        Dim ta As Global.ADAdminDotNet.ADSDataSetTableAdapters.CFOListTableAdapter
        ta = New ADAdminDotNet.ADSDataSetTableAdapters.CFOListTableAdapter
        rownumber = 0


        For counter = 0 To (CFOListTempDataGridView.SelectedRows.Count - 1)
            'If CFOListTempDataGridView.CurrentRow.Index > 0 Then
            Dim value As String = Nothing
            rownumber = CFOListTempDataGridView.CurrentCell.RowIndex
            mm += "PersalNo = " & CFOListTempDataGridView.Rows(rownumber).Cells(1).Value.ToString.Trim & vbCrLf
            mm += "Fullname = " & CFOListTempDataGridView.Rows(rownumber).Cells(2).Value.ToString.Trim & vbCrLf
            mm += "Surname = " & CFOListTempDataGridView.Rows(rownumber).Cells(3).Value.ToString.Trim & vbCrLf
            mm += "Tel = " & CFOListTempDataGridView.Rows(rownumber).Cells(4).Value.ToString.Trim & vbCrLf
            mm += "Fax = " & CFOListTempDataGridView.Rows(rownumber).Cells(5).Value.ToString.Trim & vbCrLf
            mm += "Cell = " & CFOListTempDataGridView.Rows(rownumber).Cells(6).Value.ToString.Trim & vbCrLf
            ' End If
        Next

        '  Dim strname As String = CFOlist(CFOListTempDataGridView.Rows(rownumber).Cells(1).Value.ToString.Trim


        MsgBox(mm, MsgBoxStyle.Exclamation, "ADDING THE FOLLOWING TO THE CFOLIST")

        '' CFOListDataGridView.Rows

        '' Add Some Code here to Directly Transfer ADD to the CFO Table on PRD.

        DeptCode = CFOListTempDataGridView.Rows(rownumber).Cells(10).Value
        _PersalNo = CFOListTempDataGridView.Rows(rownumber).Cells(1).Value
        If IsCFOExist(_PersalNo, DeptCode) Then
            MessageBox.Show("This CFO already Exist in the CFO list")
        Else
            '  CFOList_outTableAdapter.Insert(CFOListTempDataGridView.Rows(rownumber).Cells(1).Value.ToString.Trim,
            '  CFOListTempDataGridView.Rows(rownumber).Cells(2).Value.ToString.Trim,
            ' CFOListTempDataGridView.Rows(rownumber).Cells(3).Value.ToString.Trim,
            'CFOListTempDataGridView.Rows(rownumber).Cells(4).Value.ToString.Trim,
            'CFOListTempDataGridView.Rows(rownumber).Cells(5).Value.ToString.Trim,
            'CFOListTempDataGridView.Rows(rownumber).Cells(6).Value.ToString.Trim,
            'CFOListTempDataGridView.Rows(rownumber).Cells(7).Value.ToString.Trim,
            'CFOListTempDataGridView.Rows(rownumber).Cells(8).Value.ToString.Trim,
            'CFOListTempDataGridView.Rows(rownumber).Cells(9).Value.ToString.Trim,
            'CFOListTempDataGridView.Rows(rownumber).Cells(10).Value.ToString.Trim,
            'CFOListTempDataGridView.Rows(rownumber).Cells(11).Value.ToString.Trim)





            'ta.Insert(CFOListTempDataGridView.Rows(rownumber).Cells(1).Value.ToString.Trim,
            '                      CFOListTempDataGridView.Rows(rownumber).Cells(2).Value.ToString.Trim,
            '                      CFOListTempDataGridView.Rows(rownumber).Cells(3).Value.ToString.Trim,
            '                      CFOListTempDataGridView.Rows(rownumber).Cells(4).Value.ToString.Trim,
            '                      CFOListTempDataGridView.Rows(rownumber).Cells(5).Value.ToString.Trim,
            '                      CFOListTempDataGridView.Rows(rownumber).Cells(6).Value.ToString.Trim,
            '                      CFOListTempDataGridView.Rows(rownumber).Cells(7).Value.ToString.Trim,
            '                      CFOListTempDataGridView.Rows(rownumber).Cells(8).Value.ToString.Trim,
            '                      CFOListTempDataGridView.Rows(rownumber).Cells(9).Value.ToString.Trim,
            '                      CFOListTempDataGridView.Rows(rownumber).Cells(10).Value.ToString.Trim,
            '                      CFOListTempDataGridView.Rows(rownumber).Cells(11).Value.ToString.Trim,
            '                      CFOListTempDataGridView.Rows(rownumber).Cells(12).Value.ToString.Trim)


            '' Reloads the CFO List
            'CFOListTableAdapter1.
            Me.CFOListTableAdapter.InsertIntoCFO(_PersalNo, DeptCode)
            Me.CFOListTableAdapter.Fill(ADSDataSet.CFOList, DeptCode)

            '' REFRESH THE *target* DATAGRID SOMWEHOW
            '' CFOListDataGridView.Refresh()
        End If


    End Sub



    Private Sub DeleteFromTempTableToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DeleteFromTempTableToolStripMenuItem.Click

        '' DELETE FROM CFO LIVE

        Dim a2 As Integer = CFOListTempDataGridView.SelectedRows.Item(0).Cells(0).Value
        Dim mm As String
        Dim DeptCode As String = "" 'CFOListTempDataGridView.Rows(i).Cells(10).Value
        Dim _PersalNo As String = "" 'CFOListTempDataGridView.Rows(i).Cells(1).Value

        Dim rownumber As Integer = CFOListTempDataGridView.CurrentCell.RowIndex
        mm += "PersalNo = " & CFOListTempDataGridView.Rows(rownumber).Cells(1).Value.ToString.Trim & vbCrLf
        mm += "Fullname = " & CFOListTempDataGridView.Rows(rownumber).Cells(2).Value.ToString.Trim & vbCrLf
        mm += "Surname = " & CFOListTempDataGridView.Rows(rownumber).Cells(3).Value.ToString.Trim & vbCrLf
        mm += "Tel = " & CFOListTempDataGridView.Rows(rownumber).Cells(4).Value.ToString.Trim & vbCrLf
        mm += "Fax = " & CFOListTempDataGridView.Rows(rownumber).Cells(5).Value.ToString.Trim & vbCrLf
        mm += "Cell = " & CFOListTempDataGridView.Rows(rownumber).Cells(6).Value.ToString.Trim & vbCrLf

        If (MessageBox.Show("Please confirm that you would like to remove the Selected CFO from the CFOList Table from PRD" & vbCrLf & mm, "Delete CFO on PRD", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = vbYes) Then

            DeptCode = CFOListTempDataGridView.Rows(rownumber).Cells(10).Value.ToString.Trim 'CFOListTempDataGridView.Rows(rownumber).Cells(10).Value
            _PersalNo = CFOListTempDataGridView.Rows(rownumber).Cells(1).Value.ToString.Trim

            Me.CFOListTempTableAdapter.DeleteTempCFO(_PersalNo,DeptCode)
            Me.CFOListTempTableAdapter.Fill(ADSDataSet.CFOListTemp)

        End If

    End Sub



    Public Function IsCFOExist(ByVal _persalnumber As String, ByVal DepartmentCode As String) As Boolean

        '   Dim ta_CFO As Global.ADAdminDotNet.ADSDataSetTableAdapters.CFOListTableAdapter
        ' ta_CFO = New ADAdminDotNet.CFODataSetTableAdapters.CFOListTableAdapter()
        'Dim persalnumber As String = ta_CFO.GetDataByPersalNo(_persalnumber, DepartmentCode)

        
        Dim persalnumber As String = Me.CFOListTableAdapter.GetPersalNo(DepartmentCode, _persalnumber) '.ToString()


        Try

            If (persalnumber Is Nothing) Then
                Return False
            Else
                Return True

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function


    
    Private Sub CFOListTempDataGridView_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CFOListTempDataGridView.SelectionChanged


        If IsNothing(Me.CFOListTempDataGridView.CurrentRow) Then
            'No row selected
            Exit Sub
        Else
            'Row selected
            Dim i As Integer = CFOListTempDataGridView.CurrentCell.RowIndex
            Dim DeptCode As String = CFOListTempDataGridView.Rows(i).Cells(10).Value.ToString().Trim()
            Dim _PersalNo As String = CFOListTempDataGridView.Rows(i).Cells(1).Value.ToString().Trim()
            Me.CFOListTableAdapter.Fill(Me.ADSDataSet.CFOList, DeptCode)
        End If

    End Sub

    Private Sub CFOListTempDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub CFOListTempBindingNavigatorSaveItem_Click_4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.CFOListTempBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ADSDataSet)
    End Sub

    Private Sub CFOListTempBindingNavigatorSaveItem_Click_5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.CFOListTempBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ADSDataSet)
    End Sub

    Private Sub CFOListBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.CFOListBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ADSDataSet)
    End Sub

    Private Sub CFOListBindingNavigatorSaveItem_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim i As Integer = 2
        Me.Validate()

        Me.CFOListDataGridView.SelectedRows(0).Selected = True
        If Me.CFOListDataGridView.DataBindings.Item(0).IsBinding() Then
            MsgBox(Me.CFOListDataGridView.DataBindings.Item(0).ToString())
        End If
        Me.CFOListDataGridView.Rows.Add(Me.CFOListTempDataGridView.SelectedRows(0))

        Me.CFOListTempBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ADSDataSet)
    End Sub

    Private Sub StatusStrip1_ItemClicked(sender As System.Object, e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles StatusStrip1.ItemClicked

    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

    Private Sub CFOListTempDataGridView_CellContentClick_1(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub CFOListBindingNavigator_RefreshItems(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub CFOListTempDataGridView_CellContentClick_2(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles CFOListTempDataGridView.CellContentClick

    End Sub

    'Private Sub DeleteFromTempTableToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DeleteFromTempTableToolStripMenuItem.Click

    '    Dim a As Integer

    '    a = MessageBox.Show("Delete from Temp table", "Delete TEMP CFO From PRD", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)

    '    If (a = DialogResult.OK) Then

    '        '' MessageBox.Show("Please confirm that you would like to remove the Selected CFO from the TMP Table from PRD", "Delete TEMP CFO From PRD", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)

    '        Dim a2 As Integer = CFOListTempDataGridView.SelectedRows.Item(0).Cells(0).Value

    '        '' This Deletes it from the Table DATABASE
    '        '' The TableAdapter needs o be configured with the Delete Command

    '        CFOListTempTableAdapter.Delete(a2)

    '        CFOListTempTableAdapter.Fill(Me.ADSDataSet.CFOListTemp)


    '        '' Removes the current 1 from the bindingsource
    '        '' CFOListBindingSource.RemoveCurrent()

    '    Else


    '    End If


    'End Sub






    Private Sub CFOListDataGridView_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles CFOListDataGridView.CellContentClick

    End Sub

    'Private Sub DeleteFromCFOLIVEToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DeleteFromCFOLIVEToolStripMenuItem.Click

    '    '' DELETE FROM CFO LIVE

    '    Dim a2 As Integer = CFOListDataGridView.SelectedRows.Item(0).Cells(0).Value
    '    Dim mm As String

    '    Dim rownumber = CFOListDataGridView.CurrentRow.Index
    '    mm += "PersalNo = " & CFOListDataGridView.Rows(rownumber).Cells(1).Value.ToString.Trim & vbCrLf
    '    mm += "Fullname = " & CFOListDataGridView.Rows(rownumber).Cells(2).Value.ToString.Trim & vbCrLf
    '    mm += "Surname = " & CFOListDataGridView.Rows(rownumber).Cells(3).Value.ToString.Trim & vbCrLf
    '    mm += "Tel = " & CFOListDataGridView.Rows(rownumber).Cells(4).Value.ToString.Trim & vbCrLf
    '    mm += "Fax = " & CFOListDataGridView.Rows(rownumber).Cells(5).Value.ToString.Trim & vbCrLf
    '    mm += "Cell = " & CFOListDataGridView.Rows(rownumber).Cells(6).Value.ToString.Trim & vbCrLf

    '    If (MessageBox.Show("Please confirm that you would like to remove the Selected CFO from the CFOList Table from PRD" & vbCrLf & mm, "Delete CFO on PRD", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = vbYes) Then

    '        '' Delete this from the live CFO-List Table.
    '        '   CFOListTableAdapter.Delete(a2)

    '        '' Reloads the CFO List
    '        CFOListTableAdapter.Fill(Me.ADSDataSet.CFOList)

    '    End If

    'End Sub


    Private Sub DeleteFromCFOLIVEToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DeleteFromCFOLIVEToolStripMenuItem.Click

        '' DELETE FROM CFO LIVE

        Dim a2 As Integer = CFOListDataGridView.SelectedRows.Item(0).Cells(0).Value
        Dim mm As String
        Dim DeptCode As String = ""
        Dim _PersalNo As String = ""

        Dim rownumber As Integer = CFOListDataGridView.CurrentCell.RowIndex
        mm += "PersalNo = " & CFOListDataGridView.Rows(rownumber).Cells(1).Value.ToString.Trim & vbCrLf
        mm += "Fullname = " & CFOListDataGridView.Rows(rownumber).Cells(2).Value.ToString.Trim & vbCrLf
        mm += "Surname = " & CFOListDataGridView.Rows(rownumber).Cells(3).Value.ToString.Trim & vbCrLf
        mm += "Tel = " & CFOListDataGridView.Rows(rownumber).Cells(4).Value.ToString.Trim & vbCrLf
        mm += "Fax = " & CFOListDataGridView.Rows(rownumber).Cells(5).Value.ToString.Trim & vbCrLf
        mm += "Cell = " & CFOListDataGridView.Rows(rownumber).Cells(6).Value.ToString.Trim & vbCrLf

        If (MessageBox.Show("Please confirm that you would like to remove the Selected CFO from the CFOList Table from PRD" & vbCrLf & mm, "Delete CFO on PRD", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = vbYes) Then

            DeptCode = CFOListDataGridView.Rows(rownumber).Cells(10).Value.ToString.Trim 'CFOListTempDataGridView.Rows(rownumber).Cells(10).Value
            _PersalNo = CFOListDataGridView.Rows(rownumber).Cells(1).Value.ToString.Trim

            Me.CFOListTableAdapter.DeleteCFOlist(_PersalNo, DeptCode)
            Me.CFOListTableAdapter.Fill(ADSDataSet.CFOList, DeptCode)

        End If

    End Sub

    Private Sub ContextMenuStrip2_Opening(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip2.Opening

    End Sub

    Private Sub CFOListDataGridView_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles CFOListDataGridView.CellClick

    End Sub


    

    Private Sub CFOListDataGridView_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
End Class

