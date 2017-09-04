Public Class frmKodeer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim c As New clsCrypto
        Me.TextBox2.Text = c.kodeer128(Me.TextBox1.Text)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim c As New clsCrypto
        Me.TextBox1.Text = c.Dekodeer128(Me.TextBox2.Text)
    End Sub
End Class