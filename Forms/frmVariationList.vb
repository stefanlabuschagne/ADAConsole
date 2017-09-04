Imports System.IO

Public Class frmVariationList

    Private Sub AD_SNAPSHOT_EXCEPTIONSBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AD_SNAPSHOT_EXCEPTIONSBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AD_SNAPSHOT_EXCEPTIONSBindingSource.EndEdit()
        Me.AD_SNAPSHOT_EXCEPTIONSTableAdapter.Update(Me.DsADS.AD_SNAPSHOT_EXCEPTIONS)
    End Sub

    Private Sub frmVariationList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsADS.AD_SNAPSHOT_EXCEPTIONS' table. You can move, or remove it, as needed.
        Me.AD_SNAPSHOT_EXCEPTIONSTableAdapter.Fill(Me.DsADS.AD_SNAPSHOT_EXCEPTIONS)

    End Sub

    Private Sub frmVariationList_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(27) Then
            Me.Close()
        End If
    End Sub

    Private Sub AD_SNAPSHOT_EXCEPTIONSDataGridView_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles AD_SNAPSHOT_EXCEPTIONSDataGridView.KeyUp
        If e.KeyValue = 27 Then
            Me.Close()
        End If
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click

        Dim newRow As dsADS.AD_SNAPSHOT_EXCEPTIONSRow = DsADS.AD_SNAPSHOT_EXCEPTIONS.NewAD_SNAPSHOT_EXCEPTIONSRow

        If ADAdminDotNet.frmEnvironment.ActiveMdiChild.Text = "Active Directory Console - PRD" Then
            If Not String.IsNullOrEmpty(ADAdminDotNet.frmEnvironment.ChildFormPRD.txtPersalNumber.Text & "") Then
                newRow.AccountNr = ADAdminDotNet.frmEnvironment.ChildFormPRD.txtPersalNumber.Text & "" 'Account Number
                newRow.FirstName = ADAdminDotNet.frmEnvironment.ChildFormPRD.txtFirst_NameTextBox.Text & "" 'First Name
                newRow.Lastname = ADAdminDotNet.frmEnvironment.ChildFormPRD.txtLast_NameTextBox.Text & "" 'Account Number
                DsADS.AD_SNAPSHOT_EXCEPTIONS.Rows.Add(newRow)
            Else
                MsgBox("This is not a User", MsgBoxStyle.Exclamation, "System Message")
            End If
        ElseIf ADAdminDotNet.frmEnvironment.ActiveMdiChild.Text = "Active Directory Console - QA" Then
            If Not String.IsNullOrEmpty(ADAdminDotNet.frmEnvironment.childformQA.txtPersalNumber.Text & "") Then
                newRow.AccountNr = ADAdminDotNet.frmEnvironment.childformQA.txtPersalNumber.Text & "" 'Account Number
                newRow.FirstName = ADAdminDotNet.frmEnvironment.childformQA.txtFirst_NameTextBox.Text & "" 'First Name
                newRow.Lastname = ADAdminDotNet.frmEnvironment.childformQA.txtLast_NameTextBox.Text & "" 'Account Number
                DsADS.AD_SNAPSHOT_EXCEPTIONS.Rows.Add(newRow)
            Else
                MsgBox("This is not a User", MsgBoxStyle.Exclamation, "System Message")
            End If
        End If

        AD_SNAPSHOT_EXCEPTIONSBindingNavigatorSaveItem_Click(sender, e)

    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click

        Dim strAccountNr As String
        strAccountNr = Me.AD_SNAPSHOT_EXCEPTIONSDataGridView.CurrentRow.Cells(1).Value.ToString
        Me.AD_SNAPSHOT_EXCEPTIONSTableAdapter.Delete_Exception_Entry(strAccountNr)

    End Sub

    Public Shared Function ConvertoDate(ByVal dateString As String, ByRef result As DateTime) As Boolean
        Try
            Dim supportedFormats() As String = New String() {"MM/dd/yyyy", "MM/dd/yy", "ddMMMyyyy", "dMMMyyyy"}
            result = DateTime.ParseExact(dateString, supportedFormats, System.Globalization.CultureInfo.CurrentCulture, System.Globalization.DateTimeStyles.None)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub ExportToCSVToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExportToCSVToolStripMenuItem.Click
        ExportCSV(Me.AD_SNAPSHOT_EXCEPTIONSTableAdapter.GetData, AppPath() & "Profiling_Variation_List.csv")
        If File.Exists(AppPath() & "Profiling_Variation_List.csv") Then
            Process.Start(AppPath() & "Profiling_Variation_List.csv")
        End If
    End Sub
End Class