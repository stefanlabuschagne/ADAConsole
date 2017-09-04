Public NotInheritable Class SplashScreen

    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).

    Private i As Integer
    Private atu As Boolean = True
    Private atd As Boolean = False

    Private Sub SplashScreen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Set up the dialog text at runtime according to the application's assembly information.  

        'TODO: Customize the application's assembly information in the "Application" pane of the project 
        '  properties dialog (under the "Project" menu).

        'Application title
        If My.Application.Info.Title <> "" Then
            ApplicationTitle.Text = My.Application.Info.Title
        Else
            'If the application title is missing, use the application name, without the extension
            ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If

        'Format the version information using the text set into the Version control at design time as the
        '  formatting string.  This allows for effective localization if desired.
        '  Build and revision information could be included by using the following code and changing the 
        '  Version control's designtime text to "Version {0}.{1:00}.{2}.{3}" or something similar.  See
        '  String.Format() in Help for more information.
        '
        'TextBox1.Text = System.String.Format(TextBox1.Text, My.Application.Info.Version.Major, My.Application.Info.Version.MajorRevision.ToString, My.Application.Info.Version.Build.ToString().PadLeft(2, "0"))

        Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build.ToString().PadLeft(2, "0"), My.Application.Info.Version.Revision)

        'Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.ToString).ToString() ', My.Application.Info.Version.Minor, My.Application.Info.Version.Build).PadLeft("0")

        'Copyright info
        Copyright.Text = My.Application.Info.Copyright

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If i < 101 And atu Then
            i += 1
            If i = 100 Then
                atd = True
                atu = False
            End If
        End If
        Me.ProgressBar1.Value = i
    End Sub

    Private Sub Timer2_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If i = 100 And atd Then
            i -= 1
            If i = 0 Then
                atd = False
                atu = True
            End If
        End If
        Me.ProgressBar1.Value = i
    End Sub

    Private Sub MainLayoutPanel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MainLayoutPanel.Paint

    End Sub

    Private Sub ApplicationTitle_Click(sender As Object, e As EventArgs) Handles ApplicationTitle.Click

    End Sub

    Private Sub Copyright_Click(sender As Object, e As EventArgs) Handles Copyright.Click

    End Sub

    Private Sub Version_Click(sender As Object, e As EventArgs) Handles Version.Click

    End Sub
End Class
