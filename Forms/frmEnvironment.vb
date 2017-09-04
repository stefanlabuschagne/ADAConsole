Imports System.Windows.Forms
Imports ADAdminDotNet.My
Imports System.Data.SqlClient

Public Class frmEnvironment

    Public childformQA As New frmMain
    Public ChildFormPRD As New frmMain

    Public wrong_department As String

    Private Sub btnPRD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPRD.Click
        If (QaDBConnectionStatus()) Then
            Environment(btnPRD.Name, sender, e)

        Else
            MessageBox.Show("PRD is Currently offline ", "Warning!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        End If


    End Sub


    ''' <summary>
    ''' Handles the Click event of the btnQA control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
    Private Sub btnQA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQa.Click
        If (QaDBConnectionStatus()) Then

            Environment(btnQa.Name, sender, e)

        Else

            If MessageBox.Show("QA is Currently offline, Do you want to continue on PRD", "Warning!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = System.Windows.Forms.DialogResult.Yes Then
                Environment(btnPRD.Name, sender, e)

            Else
                Me.Close()
            End If


        End If

    End Sub

    ''' <summary>
    ''' Handles the FormClosing event of the frmEnvironment control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.Windows.Forms.FormClosingEventArgs" /> instance containing the event data.</param>
    ''' 

    Private Sub frmEnvironment_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        End
    End Sub

    ''' <summary>
    ''' Handles the Load event of the frmEnvironment control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
    ''' 

    Private Sub frmEnvironment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If (QaDBConnectionStatus()) Then
            If (PrdDBConnectionStatus()) Then

                Me.loadQA()
                Me.loadPRD()

                childformQA.Visible = False

            Else
                If MessageBox.Show("PRD is Currently offline, Do you want to continue on QA", "Warning!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = System.Windows.Forms.DialogResult.Yes Then

                    If (QaDBConnectionStatus()) Then
                        Me.loadQA()
                    Else
                        MessageBox.Show("Both PRD/QA are Currently offline", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Me.Close()
                    End If
                Else
                    Me.Close()
                End If

            End If
        Else
            If MessageBox.Show("QA is Currently offline, Do you want to continue on PRD", "Warning!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = System.Windows.Forms.DialogResult.Yes Then

                If (PrdDBConnectionStatus()) Then
                    Me.loadPRD()
                Else
                    MessageBox.Show("Both PRD/QA are Currently offline", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Me.Close()
                End If
            Else
                Close()
            End If

        End If
    End Sub

    Private Sub loadPRD()
        If MySettings.Default("Active_PRD") = True Then

            btnPRD.Enabled = True
            ChildFormPRD.MdiParent = Me
            My.MySettings.Default("AdsConnectionString") = My.MySettings.Default("ADSPRDConnectionString2014")
            My.MySettings.Default("HR_MISConnectionString") = My.MySettings.Default("HR_MISConnectionStringPRD")
            My.MySettings.Default("SHARED_TABLESConnectionString") = My.MySettings.Default("SHARED_TABLESConnectionStringPRD")

            '   My.MySettings.Default("ADSQAConnectionString2014") = My.MySettings.Default("ADSPRDConnectionString2014")
            My.MySettings.Default.Default("VIP_EXPANDEDConnectionString") = My.MySettings.Default.Default("VIP_EXPANDEDConnectionString")
            My.MySettings.Default.Default("ARSystemConnectionString") = My.MySettings.Default.Default("ARSystemProdConnectionString")
            'My.MySettings.Default.Default("ARSystemConnectionString") = My.MySettings.Default.Default("ARSystemDevConnectionString")
            'My.MySettings.Default.Default("ARSystemProdConnectionString") = My.MySettings.Default.Default("ARSystemDevConnectionString")
            My.MySettings.Default.Default("SHARED_TABLESConnectionString") = My.MySettings.Default.Default("SHARED_TABLESConnectionStringPRD")

            Me.Text = "Active Directory Console - PRD"
            With ChildFormPRD
                .Text = "Active Directory Console - PRD"
                .rbPRD.Visible = True
                .rbPRD.Checked = True
                .rbQA.Visible = False
                .Show()
            End With
        End If
    End Sub


    Private Sub loadQA()
        If MySettings.Default("Active_QA") = True Then

            btnQa.Enabled = True
            childformQA.MdiParent = Me
            My.MySettings.Default("AdsConnectionString") = My.MySettings.Default("ADSQAConnectionString2014")
            My.MySettings.Default("SHARED_TABLESConnectionString") = My.MySettings.Default("SHARED_TABLESConnectionStringDev")
            'SHARED_TABLESConnectionStringDev
            My.MySettings.Default("HR_MISConnectionString") = My.MySettings.Default("HR_MISConnectionStringDev")
            'My.MySettings.Default("ADSPRDConnectionString2014") = My.MySettings.Default("ADSQAConnectionString2014")
            My.MySettings.Default.Default("VIP_EXPANDEDConnectionString") = My.MySettings.Default.Default("VIP_EXPANDEDQAConnectionString2014")

            'My.MySettings.Default.Default("ARSystemConnectionString") = My.MySettings.Default.Default("ARSystemDevConnectionString")
            My.MySettings.Default.Default("ARSystemConnectionString") = My.MySettings.Default.Default("ARSystemDevConnectionString")

            My.MySettings.Default.Default("SHARED_TABLESConnectionString") = My.MySettings.Default.Default("SHARED_TABLESConnectionStringDev")

            Me.Text = "Active Directory Console - QA"
            With childformQA
                .Text = "Active Directory Console - QA"
                .rbQA.Visible = True
                .rbQA.Checked = True
                .rbPRD.Visible = False
                .Show()

            End With
        End If
    End Sub

    Private Function QaDBConnectionStatus() As Boolean
        Try
            Using sqlConn As New SqlConnection(My.MySettings.Default("ADSQAConnectionString2014"))
                sqlConn.Open()
                'Return (sqlConn.State = ConnectionState.Open)
            End Using

            Using ARsqlConn As New SqlConnection(My.MySettings.Default("ARSystemDevConnectionString"))
                ARsqlConn.Open()
                '  Return (ARsqlConn.State = ConnectionState.Open)
            End Using


            Using HRsqlConn As New SqlConnection(My.MySettings.Default("HR_MISConnectionStringDev"))
                HRsqlConn.Open()
                '  Return (ARsqlConn.State = ConnectionState.Open)
            End Using

            Using SharedsqlConn As New SqlConnection(My.MySettings.Default("SHARED_TABLESConnectionStringDev"))
                SharedsqlConn.Open()
                '  Return (ARsqlConn.State = ConnectionState.Open)
            End Using


        Catch ex As SqlException
            Return False
        End Try
        Return True
    End Function

    Private Function PrdDBConnectionStatus() As Boolean
        Try

            Using sqlConn As New SqlConnection(My.MySettings.Default("AdsPRDConnectionString2014"))
                sqlConn.Open()
            End Using

            Using ARsqlConn As New SqlConnection(My.MySettings.Default("ARSystemProdConnectionString"))
                ' Using ARsqlConn As New SqlConnection(My.MySettings.Default("ARSystemDevConnectionString"))
                ARsqlConn.Open()
            End Using


            Using HRsqlConn As New SqlConnection(My.MySettings.Default("HR_MISConnectionStringPRD"))
                HRsqlConn.Open()
                '  Return (ARsqlConn.State = ConnectionState.Open)
            End Using


            Using SharedsqlConn As New SqlConnection(My.MySettings.Default("SHARED_TABLESConnectionStringPRD"))
                SharedsqlConn.Open()
                '  Return (ARsqlConn.State = ConnectionState.Open)
            End Using

        Catch ex As SqlException
            Return False
        End Try

        Return True
    End Function

    Private Sub Environment(ByVal btnName As String, ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim persalnumber As String = ""

        If btnName = "btnPRD" Then
            '  My.MySettings.Default("ADSPRDConnectionString2014") = My.MySettings.Default("ADSQAConnectionString2014")
            If childformQA.Visible Then
                persalnumber = childformQA.txtPersalNumber.Text
            End If
            If persalnumber.Length > 0 Then
                ChildFormPRD.txtPersalNumber.Text = persalnumber
            End If
            ChildFormPRD.Visible = True
            ChildFormPRD.rbPRD.Checked = True
            ChildFormPRD.btnActiveDirectory_Click(sender, e)
            childformQA.Visible = False
            Me.Text = "Active Directory Console - PRD"

        End If



        If btnName = "btnQa" Then
            ' My.MySettings.Default("ADSQAConnectionString2014") = My.MySettings.Default("ADSPRDConnectionString2014")
            If ChildFormPRD.Visible Then
                persalnumber = ChildFormPRD.txtPersalNumber.Text

            End If
            If persalnumber.Length > 0 Then
                childformQA.txtPersalNumber.Text = persalnumber
            End If
            childformQA.Visible = True
            childformQA.rbQA.Checked = True
            childformQA.btnActiveDirectory_Click(sender, e)
            ChildFormPRD.Visible = False
            Me.Text = "Active Directory Console - QA"


        End If

    End Sub

    Private Sub KICKOUTBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.Validate()
        Me.KICKOUTBindingSource.EndEdit()
        Me.KICKOUTTableAdapter.Update(Me.Ads1.KICKOUT)

    End Sub

    Public Sub New()


        InitializeComponent()


    End Sub

    Private Sub AutomationTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AutomationTimer.Tick


    End Sub

End Class


