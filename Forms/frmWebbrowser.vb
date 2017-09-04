Imports System.IO
Imports System.IO.StreamWriter

Public Class frmWebBrowser

    Private colValues As Microsoft.VisualBasic.Collection

    Public Sub frmWebBrowser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        colValues = frmNewUsers.colVals
    End Sub

    Public Function Get_NatProvLongName(ByVal shortcode As String) As String

        Dim b() As String
        Dim i As Integer
        Dim deptlong As String = ""
        Dim dept As String = To_LowerCase(colValues(11))
        Dim DeptDescPair As String = My.Settings.DeptDescPair.ToString
        Dim arrDeptDescPair() As String = Split(DeptDescPair, ",")

        If shortcode.Contains("_") Then
            For i = 0 To 7
                If arrDeptDescPair(i) = shortcode Then
                    b = Microsoft.VisualBasic.Split(arrDeptDescPair(i), "|")
                    Return b(1)
                End If
            Next
        Else
            Return "National"
        End If

    End Function

    Public Function Get_CleanEMailString(ByVal strEmailAddress As String) As String

        strEmailAddress = strEmailAddress.Replace(" ", "")
        Return strEmailAddress

    End Function

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        With Me.WebBrowser1.Document.DomDocument
            .GetElementById("arid_WIN_0_8").value = colValues(1)                                                 ' arid_Persal_Number
            .GetElementById("arid_WIN_0_4").value = To_ProperCase(colValues(2))                                  ' arid_Department_Name
            .GetElementById("arid_WIN_0_536870926").value = To_ProperCase(colValues(3))                          ' arid_Title
            .GetElementById("arid_WIN_0_536870917").value = To_ProperCase(colValues(4))                          ' arid_First_Name
            .GetElementById("arid_WIN_0_536870918").value = To_ProperCase(colValues(5))                          ' arid_Last_Name 
            .GetElementById("arid_WIN_0_536870937").value = To_ProperCase(colValues(6))                          ' arid_Rank
            .GetElementById("arid_WIN_0_536870923").value = To_ProperCase(colValues(7))                          ' arid_Telephone
            .GetElementById("arid_WIN_0_536870979").value = To_ProperCase(colValues(8))                          ' arid_Cellphone
            .GetElementById("arid_WIN_0_536870925").value = Me.Get_CleanEMailString(To_LowerCase(colValues(9)))  ' arid_E_Mail
            .GetElementById("arid_WIN_0_536870931").value = To_UpperCase(colValues(10))                          ' arid_Comments
            .GetElementById("arid_WIN_0_536870928").value = Me.Get_NatProvLongName(To_LowerCase(colValues(11)))  ' arid_Department_Type"
            .GetElementById("arid_WIN_0_536870930").value = To_UpperCase(colValues(12))                          ' arid_Initial"
        End With

        Me.Focus()

    End Sub

    Private Sub tsbtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnClear.Click

        With Me.WebBrowser1.Document.DomDocument
            .GetElementById("arid_WIN_0_8").value = ""           ' arid_Persal_Number
            .GetElementById("arid_WIN_0_4").value = ""           ' arid_Department_Name"
            .GetElementById("arid_WIN_0_536870926").value = ""   ' arid_Title
            .GetElementById("arid_WIN_0_536870917").value = ""   ' arid_First_Name
            .GetElementById("arid_WIN_0_536870918").value = ""   ' arid_Last_Name 
            .GetElementById("arid_WIN_0_536870937").value = ""   ' arid_Rank
            .GetElementById("arid_WIN_0_536870923").value = ""   ' arid_Telephone
            .GetElementById("arid_WIN_0_536870979").value = ""   ' arid_Cellphone
            .GetElementById("arid_WIN_0_536870925").value = ""   ' arid_E_Mail
            .GetElementById("arid_WIN_0_536870931").value = ""   ' arid_Comments
            .GetElementById("arid_WIN_0_536870928").value = ""   ' arid_Department_Type"
            .GetElementById("arid_WIN_0_536870930").value = ""   ' arid_Initial"
        End With

        Me.Focus()

    End Sub

End Class
