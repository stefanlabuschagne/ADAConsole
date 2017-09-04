Imports System.IO

Public Class frmReferrals

    'Private cellX As Integer = 0
    'Private cellY As Integer = 0
    'Private grvScreenLocation As Point = CFOApprovalDataGridView.PointToScreen(CFOApprovalDataGridView.Location)
    'Private tempX As Integer = DataGridView.MousePosition.X - grvScreenLocation.X + CFOApprovalDataGridView.Left
    'Private tempY As Integer = DataGridView.MousePosition.Y - grvScreenLocation.Y + CFOApprovalDataGridView.Top
    'Private hit As DataGridView.HitTestInfo = CFOApprovalDataGridView.HitTest(tempX, tempY)

    Private Sub frmReferrals_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Me.CFOApproval_ta.FillBy(Me.DsADS.CFOApproval)
        Me.LOG_IN_Request_TrackingTableAdapter.FillByRefer2Client(Me.DsARSystemDataSet.LOG_IN_Request_Tracking)
        Me.CFOApprovalDataGridView.Refresh()

    End Sub

    Private Sub ExportToExcelToolStripMenuItem_Click(ByVal sender As System.Object, _
                                                     ByVal e As System.EventArgs) Handles ExportToExcelToolStripMenuItem.Click

        Dim mstr As String
        Dim table As DataTable
        table = Me.CFOApproval_ta.GetCFOApproval
        If File.Exists(AppPath() & "Referred_for_CFO_Approval.csv") Then
            If MsgBox("File exists. Do you want to delete the current file?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                File.Delete(AppPath() & "Referred_for_CFO_Approval.csv")
            End If
        End If
        ExportCSV(table, AppPath() & "Referred_for_CFO_Approval.csv")
        mstr = AppPath() & "Referred_for_CFO_Approval.csv"
        If File.Exists(mstr) Then
            Process.Start(mstr)
        End If

    End Sub

    Private Sub MarkThisEntryAsPROFILEDToolStripMenuItem_Click(ByVal sender As System.Object, _
                                                              ByVal e As System.EventArgs) Handles MarkThisEntryAsPROFILEDToolStripMenuItem.Click

        Dim requestno As String
        requestno = CFOApprovalDataGridView.CurrentRow.Cells.Item("RequestNo").Value.ToString
        Me.RULES_FLAGSTableAdapter.Profiling_Completed(requestno.Trim)
        Me.CFOApprovalDataGridView.Refresh()
        If My.MySettings.Default.PropertyValues("Close_Pick_Forms").PropertyValue = True Then
            Me.Close()
        End If
    End Sub

    Private Sub CFOApprovalDataGridView_CellContentDoubleClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles CFOApprovalDataGridView.CellContentDoubleClick

        Dim PersNum As String = ""
        Dim RequestNumber As String = Me.CFOApprovalDataGridView.SelectedRows(0).Cells("RequestNo").Value.ToString()
        Dim txtRequestNo As String = RequestNumber
        Dim Environment As String = Me.Text

        PersNum = LOG_IN_Request_TrackingTableAdapter.GetPersalFromRequestNO(RequestNumber).DefaultView(0).DataView.Item(0).Item(1)

        Dim ws As New ARSWS.Webpage
        ws.Open_Request_No(RequestNumber, Environment)
        ws = Nothing

        If ADAdminDotNet.frmEnvironment.ActiveMdiChild.Text = "Active Directory Console - PRD" Then
            ADAdminDotNet.frmEnvironment.ChildFormPRD.txtPersalNumber.Text = PersNum.Trim
            ADAdminDotNet.frmEnvironment.ChildFormPRD.btnActiveDirectory_Click(sender, e)
            ADAdminDotNet.frmEnvironment.ChildFormPRD.txtRemedyRequestNo.Text = RequestNumber.ToString.Trim
            ADAdminDotNet.frmEnvironment.ChildFormPRD.txtRemedyNo.Text = RequestNumber.ToString.Trim
            ADAdminDotNet.frmEnvironment.ChildFormPRD.txtRightsRequested.Text = "REQUEST : " & RequestNumber.ToString.Trim
        ElseIf ADAdminDotNet.frmEnvironment.ActiveMdiChild.Text = "Active Directory Console - QA" Then
            ADAdminDotNet.frmEnvironment.childformQA.txtPersalNumber.Text = PersNum
            ADAdminDotNet.frmEnvironment.childformQA.btnActiveDirectory_Click(sender, e)
            ADAdminDotNet.frmEnvironment.childformQA.txtRemedyRequestNo.Text = RequestNumber.ToString.Trim
            ADAdminDotNet.frmEnvironment.childformQA.txtRemedyNo.Text = RequestNumber.ToString.Trim
            ADAdminDotNet.frmEnvironment.childformQA.txtRightsRequested.Text = "REQUEST : " & RequestNumber.ToString.Trim
        End If

        If My.MySettings.Default.PropertyValues("Close_Pick_Forms").PropertyValue = True Then
            Me.Close()
        End If

    End Sub

    Private Sub CFOApprovalDataGridView_CellMouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles CFOApprovalDataGridView.CellMouseMove
        CFOApprovalDataGridView_SelectionChanged(sender, e)
    End Sub

    Private Sub CFOApprovalDataGridView_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CFOApprovalDataGridView.KeyUp

        If e.KeyValue = 27 Then
            Me.Close()
        End If

    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click

        'Me.LOG_IN_Request_TrackingTableAdapter.FillByRefer2Client(Me.DsARSystemDataSet.LOG_IN_Request_Tracking)
        'Me.CFOApproval_ta.FillBy(Me.DsADS.CFOApproval)
        'Dim s As String
        's = CFOApprovalDataGridView.Rows(0).Cells(0).Value.ToString

    End Sub

    Private Sub AddAVulindlelaCommentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddAVulindlelaCommentToolStripMenuItem.Click
        Dim mcomment As String
        Dim requestno As String
        requestno = CFOApprovalDataGridView.CurrentRow.Cells.Item("RequestNo").Value.ToString
        mcomment = InputBox("Insert a Vulindlela comment!", "System Message", "").Trim
        If mcomment.Trim.Length > 0 Then
            Me.RULES_FLAGSTableAdapter.Rules_Flags_Add_Vulcomment(requestno, mcomment)
            Me.CFOApprovalDataGridView.Refresh()
        End If
        btnRefresh_Click(sender, e)
    End Sub

    Private Sub RollbackClosedReferralToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RollbackClosedReferralToolStripMenuItem.Click
        Dim requestnumber As String
        requestnumber = InputBox("Enter the Remedy RequestNo to Roll Back", "System Message", "").ToString
        If requestnumber.Trim.Length > 0 Then
            Me.RULES_FLAGSTableAdapter.Flag_RollBack(requestnumber)
            Me.CFOApprovalDataGridView.Refresh()
        End If
        'btnRefresh_Click(sender, e)
    End Sub

    Private Sub CFOApprovalDataGridView_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CFOApprovalDataGridView.SelectionChanged

        Dim requestno As String = ""
        Dim persalno As String = ""
        Dim s As String = ""
        Dim tt As String = ""

        Dim ta As Global.ADAdminDotNet.dsARSystemDataSetTableAdapters.LOG_IN_Request_TrackingTableAdapter 'ADAdminDotNet.dsARSystemDataSet.dsARSystemDataSetTableAdapters.LOG_IN_Request_Tracking1TableAdapter
        ta = New ADAdminDotNet.dsARSystemDataSetTableAdapters.LOG_IN_Request_TrackingTableAdapter
        ta.ClearBeforeFill = True

        Dim ta_capproved As Global.ADAdminDotNet.dsADSTableAdapters.CFOApproval_ta
        ta_capproved = New ADAdminDotNet.dsADSTableAdapters.CFOApproval_ta
        ta_capproved.ClearBeforeFill = True


        Dim dt As DataTable
        Dim ta_cfo As Global.ADAdminDotNet.dsADSTableAdapters.CFOListTableAdapter
        ta_cfo = New ADAdminDotNet.dsADSTableAdapters.CFOListTableAdapter
        ta_cfo.ClearBeforeFill = True
        dt = DsADS.CFOList


        If CFOApprovalDataGridView.SelectedRows.Count > 0 And Me.Visible Then



            Dim tbl As DataTable = Me.DsARSystemDataSet.LOG_IN_Request_Tracking

            requestno = CFOApprovalDataGridView.CurrentRow.Cells.Item("RequestNo").Value.ToString


            ta.FillByRefer2Client(tbl)
            '  persalno = ta_capproved.GetPersalNo(requestno)
            ta_cfo.FillByPersalNo(dt, persalno)

            If tbl.Rows.Count > 0 Then
                For Each row As DataRow In tbl.Rows
                    Try
                        s = "Request # : " & requestno.ToString & " | " & _
                                                "CFO is Persal # : " & persalno.ToString & " - " & dt.Rows(0).Item("FullNames").ToString & " " & dt.Rows(0).Item("Surname").ToString

                        tt = s.Replace(" | ", vbCrLf)
                        CFOApprovalDataGridView.CurrentRow.Cells(0).ToolTipText = tt
                        CFOApprovalDataGridView.CurrentRow.Cells(1).ToolTipText = tt
                        CFOApprovalDataGridView.CurrentRow.Cells(2).ToolTipText = tt
                        Me.tsLblReferredPerson.Text = s
                    Catch ex As Exception

                    End Try



                Next
            Else
                tt = "No Information"
                CFOApprovalDataGridView.CurrentRow.Cells(0).ToolTipText = tt
                CFOApprovalDataGridView.CurrentRow.Cells(1).ToolTipText = tt
                CFOApprovalDataGridView.CurrentRow.Cells(2).ToolTipText = tt
                Me.tsLblReferredPerson.Text = tt
            End If

        End If

        requestno = Nothing
        persalno = Nothing
        s = Nothing


    End Sub

    Private Sub CFOApprovalDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CFOApprovalDataGridView.CellContentClick

    End Sub
End Class