Public Class Form1

    Private Sub WebBrowser1_DocumentCompleted(sender As System.Object, e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        '
        RichTextBox1.Text = WebBrowser1.DocumentText.ToString 'Gets the source of the current website loaded
        '
        For Each ele As HtmlElement In WebBrowser1.Document.Links
            Dim eletarget As String = ele.GetAttribute("href")
            ListBox1.Items.Add(eletarget) 'Adds the Links to the ListBox
        Next
        '
        For Each ele As HtmlElement In WebBrowser1.Document.All
            '
            If ele.GetAttribute("src").ToLower.Contains(".jpg") Then
                Dim imgsrc As String = ele.GetAttribute("src")
                ListBox2.Items.Add(imgsrc) 'Adds all .jpg images to the ListBox
            End If
            '
            If ele.GetAttribute("src").ToLower.Contains(".png") Then
                Dim imgsrc As String = ele.GetAttribute("src")
                ListBox2.Items.Add(imgsrc) 'Adds all .png images to the ListBox
            End If
            '
            If ele.GetAttribute("src").ToLower.Contains(".gif") Then
                Dim imgsrc As String = ele.GetAttribute("src")
                ListBox2.Items.Add(imgsrc) 'Adds all .gif images to the ListBox
            End If
            '
            If ele.GetAttribute("src").ToLower.Contains(".bmp") Then
                Dim imgsrc As String = ele.GetAttribute("src")
                ListBox2.Items.Add(imgsrc) 'Adds all .bmp images to the ListBox
            End If
            '
        Next
        '
    End Sub

    Private Sub ListBox2_Click(sender As Object, e As System.EventArgs) Handles ListBox2.Click
        '
        PictureBox1.ImageLocation = ListBox2.SelectedItem.ToString 'Gets the selected image in the ListBox and previews it in the PictureBox
        '
    End Sub

    Private Sub ListBox2_DoubleClick(sender As Object, e As System.EventArgs) Handles ListBox2.DoubleClick
        '
        WebBrowser1.Navigate(ListBox2.SelectedItem.ToString) 'Selected Image in ListBox navigates to the Image URL in the WebBrowser
        '
    End Sub

    Private Sub ListBox1_DoubleClick(sender As Object, e As System.EventArgs) Handles ListBox1.DoubleClick
        '
        WebBrowser1.Navigate(ListBox1.SelectedItem.ToString) 'Selected Link in ListBox navigates to the link in the WebBrowser
        '
    End Sub
End Class
