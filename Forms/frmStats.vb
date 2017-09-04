Imports Microsoft.VisualBasic

''' <summary>
''' 
''' </summary>
Public Class frmStats

    ''' <summary>
    ''' Handles the KeyPress event of the frmStats control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.Windows.Forms.KeyPressEventArgs" /> instance containing the event data.</param>
    Private Sub frmStats_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(27) Then
            Me.Close()
        End If
    End Sub

    ''' <summary>
    ''' Handles the Click event of the btnCalculate control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click

        Dim mStart As String
        Dim mEnding As String

        Hourglass(True)

        mStart = Microsoft.VisualBasic.Strings.Left(Me.dtp_Period_Starting.Value.ToString, 10)
        mEnding = Microsoft.VisualBasic.Strings.Left(Me.dtp_Period_Ending.Value.ToString, 10)

        Me.txtResetPasswords.Text = AdconsolelogTableAdapter1.CountResetPasswords(mStart, mEnding)

        'Total number of [users on Vulindlela] (ViewJJ_Max_User_COunt)
        If AD_SNAPSHOT_USER_COUNTTableAdapter.GetData(mStart).Rows.Count > 0 And _
            AD_SNAPSHOT_USER_COUNTTableAdapter.GetData(mEnding).Rows.Count > 0 Then
            Me.txt_New_Users_Created_in_This_Month.Text = _
                    AD_SNAPSHOT_USER_COUNTTableAdapter.GetData(mEnding).Rows(0).Item(2).ToString - _
                    AD_SNAPSHOT_USER_COUNTTableAdapter.GetData(mStart).Rows(0).Item(2).ToString
        Else
            Me.txt_New_Users_Created_in_This_Month.Text = "N/A"
        End If

        'Total number of [active users on Vulindlela] (ViewJJ_Max_User_COunt)
        If AD_SNAPSHOT_USER_COUNTTableAdapter.GetData(mStart).Rows.Count > 0 And _
           AD_SNAPSHOT_USER_COUNTTableAdapter.GetData(mEnding).Rows.Count > 0 Then
            Me.txt_Users_Active_This_Month.Text = _
               AD_SNAPSHOT_USER_COUNTTableAdapter.GetData(mEnding).Rows(0).Item(4).ToString
        Else
            Me.txt_Users_Active_This_Month.Text = "N/A"
        End If

        'Users disabled this month
        If AD_Disabled_UsersTableAdapter.GetData(mStart, mEnding).Rows.Count > 0 Then
            'And _         AD_Disabled_UsersTableAdapter.GetData(mEnding).Rows.Count > 0
            Me.txt_Users_Disabled_This_Month.Text = AD_Disabled_UsersTableAdapter.GetData(mStart, mEnding).Rows(0).Item(0).ToString()
            '            (AD_SNAPSHOT_USER_COUNTTableAdapter.GetData(mStart).Rows(0).Item(0).ToString() - _
            '            AD_SNAPSHOT_USER_COUNTTableAdapter.GetData(mStart).Rows(0).Item(0).ToString())

        Else
            Me.txt_Users_Disabled_This_Month.Text = "N/A"
        End If

        'CFO approvals requested this month
        Dim yeardate As String
        yeardate = Microsoft.VisualBasic.Strings.Left(Me.dtp_Period_Starting.Value.ToString, 7)
        yeardate = Replace(yeardate, "/", "")
        Try
            Me.txt_CFO_Approval_Requested.Text = CFO_Letters_YearMonthTableAdapter.CFOLetterRequested(yeardate)
        Catch ex As Exception
            Me.txt_CFO_Approval_Requested.Text = "N/A"
        End Try

        'Total users registered on Vulindlela

        If AD_SNAPSHOT_USER_COUNTTableAdapter.GetData(mStart).Rows.Count > 0 And _
                AD_SNAPSHOT_USER_COUNTTableAdapter.GetData(mEnding).Rows.Count > 0 Then
            Me.txtTotal_users_registered_on_Vulindlela.Text = _
                    AD_SNAPSHOT_USER_COUNTTableAdapter.GetData(mEnding).Rows(0).Item(2).ToString
        Else
            Me.txtTotal_users_registered_on_Vulindlela.Text = "N/A"
        End If

        Hourglass(False)

    End Sub

    ''' <summary>
    ''' Export to Excel
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Export to Excel")
    End Sub

    ''' <summary>
    ''' Handles the Load event of the frmStats control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
    Private Sub frmStats_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'Ads.Not_On_Estab_Thismonth_Count' table. You can move, or remove it, as needed.
        '      Me.Not_On_Estab_Thismonth_CountTableAdapter.Fill(Me.Ads.Not_On_Estab_Thismonth_Count)

        Dim dToday As Date
        Dim dPeriod_Ending As Date = Me.dtp_Period_Starting.Value
        Dim dPeriod_Starting As Date = Me.dtp_Period_Starting.Value

        Me.ViewJJ_Max_User_COuntTableAdapter.Fill(Me.Ads.ViewJJ_Max_User_COunt)

        dToday = Now
        dtp_Period_Starting.Value = dToday.AddMonths(-1)
        dtp_Period_Ending.Value = dToday

    End Sub

    ''' <summary>
    ''' Handles the Click event of the AD_SNAPSHOT_USER_COUNTBindingNavigatorSaveItem control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
    Private Sub AD_SNAPSHOT_USER_COUNTBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.AD_SNAPSHOT_USER_COUNTBindingSource.EndEdit()
        'Me.AD_SNAPSHOT_USER_COUNTTableAdapter.Update(Me.Ads.AD_SNAPSHOT_USER_COUNT)
    End Sub

    ''' <summary>
    ''' Handles the ValueChanged event of the dtp_Period_Ending control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
    Private Sub dtp_Period_Ending_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Period_Ending.ValueChanged
        dtp_Period_Starting.Value = dtp_Period_Ending.Value.AddMonths(-1)
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