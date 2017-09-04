VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "ThisOutlookSession"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Public Sub ReadMails()

Dim fso As New Scripting.FileSystemObject
Dim t As texstream
Set t = fso.CreateTextFile(Path & "\mail_extract.csv", True, True)
  If ComboBox1.SelText <> "" Then
    Dim objOutlook As New Outlook.Application
    Dim objNameSpace As Outlook.NameSpace
    Dim objInbox As MAPIFolder
    Dim objMail As MailItem

    ' Get the MAPI reference
    Set objNameSpace = objOutlook.GetNamespace("MAPI")

    ' Pick up the Inbox
    Set objInbox = objNameSpace.GetDefaultFolder(olFolderInbox)
    For Each objFolder In objInbox.Folders
       If (objFolder.Name = ComboBox1.SelText) Then
          Set objInbox = objFolder
       End If
    Next objFolder

    ' Loop through the items in the Inbox
    Dim count As Integer
    count = 1

    For Each objMail In objInbox.Items
       lblStatus.Caption = "Count: " + CStr(count)
       If (CheckBox1.Value = False Or objMail.UnRead = True) Then
          ProcessMailItem (objMail.Body)
          count = count + 1
          objMail.UnRead = False
       End If
    Next objMail
  End If
End Sub

Public Sub ProcessMailItem(strBody As String)
   Open "C:\file.txt" For Append As 1

   Dim strTmp As String
   strTmp = Replace(strBody, vbNewLine, " ")
   strTmp = Replace(strTmp, vbCrLf, " ")
   strTmp = Replace(strTmp, Chr(13) & Chr(10), " ")
   strTmp = Replace(strTmp, ",", "_")

   ' Extra Processing went here (Deleted for brevity)
   Print #1, strTmp
   Close #1

End Sub

Public Function Strip(strStart As String, strEnd As String, strBody As String) As String
   Dim iStart As Integer
   Dim iEnd As Integer

   iStart = InStr(strBody, strStart) + Len(strStart)
   If (strEnd = "xxx") Then
      iEnd = Len(strBody)
   Else
      iEnd = InStr(strBody, strEnd) - 1
   End If

   Strip = LTrim(RTrim(Mid(strBody, iStart, iEnd - iStart)))
End Function

Public Sub UserForm_Initialize()
  Dim objOutlook As New Outlook.Application
  Dim objNameSpace As Outlook.NameSpace
  Dim objInbox As MAPIFolder
  Dim objFolder As MAPIFolder

  ' Get the MAPI reference
  Set objNameSpace = objOutlook.GetNamespace("MAPI")

  ' Pick up the Inbox
  Set objInbox = objNameSpace.GetDefaultFolder(olFolderInbox)

  ' Loop through the folders under the Inbox
  For Each objFolder In objInbox.Folders
    ComboBox1.AddItem objFolder.Name
  Next objFolder
End Sub
 


