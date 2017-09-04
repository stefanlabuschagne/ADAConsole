Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.IO
Imports System.Windows.Forms
Imports LibFTPServ.FTP

Friend Class Helpers
	Public Shared ReadOnly Property AppDir() As String
		Get
			Dim r As String = Path.GetDirectoryName(Application.ExecutablePath)
			Return r
		End Get
	End Property

	Public Shared Function BoolConvert(value As Boolean) As String
		If value Then
			Return "Yes"
		Else
			Return "No"
		End If
	End Function

	Public Shared Function FtpEventToString(t As FTPLogEventType) As String
		Select Case t
			Case FTPLogEventType.Abort
				Return "Transfer abort"
			Case FTPLogEventType.AppendFile
				Return "Append file"
			Case FTPLogEventType.ChangeType
				Return "Transfer type change"
			Case FTPLogEventType.ChangeWorkDir
				Return "Work dir change"
			Case FTPLogEventType.ConnectionReinitialize
				Return "Connection reinitialization"
			Case FTPLogEventType.DeleteDirectory
				Return "Directory delete"
			Case FTPLogEventType.DeleteFile
				Return "File delete"
			Case FTPLogEventType.DownloadFile
				Return "File download"
			Case FTPLogEventType.FeatureList
				Return "Feature list query"
			Case FTPLogEventType.FileModificationDate
				Return "File modification date query"
			Case FTPLogEventType.FileSize
				Return "File size query"
			Case FTPLogEventType.ListDirectory
				Return "Directory list"
			Case FTPLogEventType.ListFileNames
				Return "Filenames list"
			Case FTPLogEventType.MakeDirectory
				Return "Direcory create"
			Case FTPLogEventType.OptionReceived
				Return "Options change"
			Case FTPLogEventType.PassiveMode
				Return "Passive mode for data transfer"
			Case FTPLogEventType.PortCommand
				Return "Data port change"
			Case FTPLogEventType.Rename
				Return "Rename"
			Case FTPLogEventType.UploadFile
				Return "File upload"
			Case FTPLogEventType.UserConnect
				Return "User connected"
			Case FTPLogEventType.UserDisconnect
				Return "User disconnect"
			Case Else
				Return "Unknown event"
		End Select
	End Function


End Class
