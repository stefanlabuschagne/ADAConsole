
Public Class frmAD_create_new_shortcode

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        'On Error Resume Next
        'modADS.Create_Government_Group(txtShortCode.Text.ToLower.Trim)
        'modADS.Create_Government_Group("AUDITGENL." & txtShortCode.Text.ToLower.Trim)
        'modADS.Create_Government_Group("DPSA." & txtShortCode.Text.ToLower.Trim)
        'modADS.Create_Government_Group("FINANCIALS." & txtShortCode.Text.ToLower.Trim)
        'modADS.Create_Government_Group("GENERAL_REPORTING." & txtShortCode.Text.ToLower.Trim)
        'modADS.Create_Government_Group("FTP_ACCESS." & txtShortCode.Text.ToLower.Trim)
        'modADS.Create_Government_Group("GFS." & txtShortCode.Text.ToLower.Trim)
        'modADS.Create_Government_Group("HR." & txtShortCode.Text.ToLower.Trim)
        'modADS.Create_Government_Group("HR_OVERSIGHT." & txtShortCode.Text.ToLower.Trim)
        'modADS.Create_Government_Group("LOGIS." & txtShortCode.Text.ToLower.Trim)
        'modADS.Create_Government_Group("PERSALPDF." & txtShortCode.Text.ToLower.Trim)
        'MsgBox("Done")

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Dim AdForm As New ADAdminDotNet.frmEnvironment
        'Dim col As New Collection
        'col = AdForm.ChildFormPRD.lwA.CheckedItems.AsQueryable
        'For i = 0 To col.Count - 1
        '    Debug.Print(col.Item(i))
        '    'If MsgBox("Do you wanna create the objects for " &  & " ?", MsgBoxStyle.OkCancel + MsgBoxStyle.Exclamation, "System Message") Then
        '    '    Me.txtShortCode.Text = New adform.ChildFormPRD.lwA.CheckedItems(1).Text
        '    'End If
        'Next
    End Sub

    Private Sub frmAD_create_new_shortcode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class