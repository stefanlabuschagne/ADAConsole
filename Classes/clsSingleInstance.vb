Imports System
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Diagnostics
Imports System.Threading
Imports System.Reflection
Imports System.IO

Namespace SingleInstance
    ''' <summary>
    ''' Summary description for SingleApp.
    ''' </summary>
    Public Class SingleApplication

        Public Sub New()
        End Sub
        ''' <summary>
        ''' Imports 
        ''' </summary>

        <DllImport("user32.dll")> _
        Private Shared Function ShowWindow(ByVal hWnd As IntPtr, ByVal nCmdShow As Integer) As Integer
        End Function

        <DllImport("user32.dll")> _
        Private Shared Function SetForegroundWindow(ByVal hWnd As IntPtr) As Integer
        End Function

        <DllImport("user32.dll")> _
        Private Shared Function IsIconic(ByVal hWnd As IntPtr) As Integer
        End Function

        ''' <summary>
        ''' GetCurrentInstanceWindowHandle
        ''' </summary>
        ''' <returns></returns>
        Private Shared Function GetCurrentInstanceWindowHandle() As IntPtr
            Dim hWnd As IntPtr = IntPtr.Zero
            Dim process__1 As Process = Process.GetCurrentProcess()
            Dim processes As Process() = Process.GetProcessesByName(process__1.ProcessName)
            For Each _process As Process In processes
                ' Get the first instance that is not this instance, has the
                ' same process name and was started from the same file name
                ' and location. Also check that the process has a valid
                ' window handle in this session to filter out other user's
                ' processes.
                If _process.Id <> process__1.Id AndAlso _process.MainModule.FileName = process__1.MainModule.FileName AndAlso _process.MainWindowHandle <> IntPtr.Zero Then
                    hWnd = _process.MainWindowHandle
                    Exit For
                End If
            Next
            Return hWnd
        End Function
        ''' <summary>
        ''' SwitchToCurrentInstance
        ''' </summary>
        Private Shared Sub SwitchToCurrentInstance()
            Dim hWnd As IntPtr = GetCurrentInstanceWindowHandle()
            If hWnd <> IntPtr.Zero Then
                ' Restore window if minimised. Do not restore if already in
                ' normal or maximised window state, since we don't want to
                ' change the current state of the window.
                If IsIconic(hWnd) <> 0 Then
                    ShowWindow(hWnd, SW_RESTORE)
                End If

                ' Set foreground window.
                SetForegroundWindow(hWnd)
            End If
        End Sub

        ''' <summary>
        ''' Execute a form base application if another instance already running on
        ''' the system activate previous one
        ''' </summary>
        ''' <param name="frmMain">main form</param>
        ''' <returns>true if no previous instance is running</returns>
        Public Shared Function Run(ByVal frmMain As System.Windows.Forms.Form) As Boolean
            If IsAlreadyRunning() Then
                'set focus on previously running app
                SwitchToCurrentInstance()
                Return False
            End If
            Application.Run(frmMain)
            Return True
        End Function

        ''' <summary>
        ''' for console base application
        ''' </summary>
        ''' <returns></returns>
        Public Shared Function Run() As Boolean
            If IsAlreadyRunning() Then
                Return False
            End If
            Return True
        End Function

        ''' <summary>
        ''' check if given exe alread running or not
        ''' </summary>
        ''' <returns>returns true if already running</returns>
        Private Shared Function IsAlreadyRunning() As Boolean
            Dim strLoc As String = Assembly.GetExecutingAssembly().Location
            Dim fileInfo As FileSystemInfo = New FileInfo(strLoc)
            Dim sExeName As String = fileInfo.Name
            Dim bCreatedNew As Boolean

            mutex = New Mutex(True, "Global\" & sExeName, bCreatedNew)
            If bCreatedNew Then
                mutex.ReleaseMutex()
            End If

            Return Not bCreatedNew
        End Function

        Shared mutex As Mutex
        Const SW_RESTORE As Integer = 9
    End Class
End Namespace
