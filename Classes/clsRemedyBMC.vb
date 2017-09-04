Imports ARNetToC
Imports ATL
Imports BMC
Imports System

Namespace RemedyBMC

    Public Class HPD

        Const ARSServerPort As String = "8080"

        Public ARSServer As BMC.ARSystem.Server

        Public Sub IncidentInterface_Create()

            Dim ARServerName As String = My.MySettings.Default.ARSServerName
            Dim ARUser As String = My.MySettings.Default.ARUser
            Dim ARPassword As String = My.MySettings.Default.ARPassword
            Dim ARServerPort As String = My.MySettings.Default.ARServerPort
            Dim strFirstName As String = "Johan"
            Dim strLastName As String = "Vermeulen"
            Dim ErrMsg As String = String.Empty
            Dim ARForm As String = "HPD:IncidentInterface_Create"
            Dim IntInterfaceEntryID As String
            Dim strIncidentID As String
            Dim strEntryID As String
            Dim strSQL As String
            Dim FieldList As New BMC.ARSystem.FieldValueList
            Dim EntryFieldList = New BMC.ARSystem.EntryListFieldList
            Dim ThisEntryFieldValueList = New BMC.ARSystem.EntryFieldValueList

            Try
                FieldList.Add(1000000076, "CREATE")                                     ' // Keyword Triggers the Create
                FieldList.Add(1000000018, strLastName)                                  ' // Last_Name
                FieldList.Add(1000000019, strFirstName)                                 ' // First_Name
                FieldList.Add(7, 1)                                                     ' // Status
                FieldList.Add(1000000099, 3)                                            ' // Service_Type
                FieldList.Add(1000000163, 4000)                                         ' // Impact
                FieldList.Add(1000000162, 4000)                                         ' // Urgency
                FieldList.Add(1000000000, "Remedy Test Ticket From API")                ' // Description
                FieldList.Add(1000000215, 10000)                                        ' // Reported Source
                'FieldList.Add(301674600, "Yes")                                        '// Flag_Create_Request - Required to create SRM Request Entry

                ARSServer = ARSInitialise.Login
                IntInterfaceEntryID = ARSServer.CreateEntry(ARForm, FieldList)

                strSQL = "'1' = " & IntInterfaceEntryID
                EntryFieldList.AddField(1000000161) '//Incident Number
                'EntryFieldList.AddField(1000000560) '//Reported Date*
                'EntryFieldList.AddField(301572100)  '//SRID
                'EntryFieldList.AddField(1000000082) '//Contact Company*
                'EntryFieldList.AddField(1000000164) '//Priority

                ' // ** Return the Incident ID* from the call
                ThisEntryFieldValueList = ARSServer.GetListEntryWithFields("HPD:IncidentInterface_Create", strSQL, EntryFieldList, u0, u50)
                strIncidentID = ""

                ' // If returning more than one entry, use a for loop
                For Each entryFieldValue In ThisEntryFieldValueList
                    strIncidentID = entryFieldValue.FieldValues(1000000161)
                    Console.Write("Incident ID* = ")
                    Console.WriteLine(entryFieldValue.FieldValues(1000000161))
                Next

                ' // NOTE: Query required for HPD:IncidentInterface differs from above as we are specifying a particular field by name
                ' // Example SQL Query ** Note: Inverted Commas Needed or SQL Will Fail**
                ' // strSQL = "'Incident Number' = ""INC000000000093"""
                strSQL = "'Incident Number' = """ + strIncidentID + """"

                ' // Retrieve Required Entry ID from HPD:IncidentInterface for Modify (Close) Action
                EntryFieldList.Clear()
                EntryFieldList.AddField(1)          '//Entry ID

                ThisEntryFieldValueList = ARSServer.GetListEntryWithFields("HPD:Help Desk", strSQL, EntryFieldList, u0, u1)
                strEntryID = ""

                For Each entryFieldValue In EntryFieldValueList
                    strEntryID = entryFieldValue.FieldValues(1)
                    Console.Write("EntryID = ")
                    Console.WriteLine(entryFieldValue.FieldValues(1))
                Next


                ' // Close Out the Incident by supplying Resolution, Status, Status Reason and Assignee information
                ' // Assignee information is required on different setups, so best to include it for safety
                FieldList.Clear()
                FieldList.Add(1000000076, "MODIFY")                                     ' // Keyword Triggers the Modify
                FieldList.Add(1000000156, "API Automatic Resolution")                   ' // Resolution
                FieldList.Add(1000000150, "No Further Action Required")                 ' // Status Reason
                FieldList.Add(7, "Closed")                                              ' // Status
                FieldList.Add(1000000218, (strFirstName & " " & strLastName))           ' // Asignee
                FieldList.Add(4, ARUser)                                                ' // Login ID of Assignee
                strSQL = strEntryID                                                     ' // Entry ID of HPD:IncidentInterface


                ARSServer.SetEntry("HPD:IncidentInterface", strSQL, FieldList)          ' // Close Incident

            Catch ex As BMC.ARSystem.ARException

                Throw New System.Exception(ex.Message, ex.InnerException)
                Exit Sub

            Catch ir As Exception

                Throw New System.Exception(ir.Message, ir.InnerException)

            End Try
        End Sub

        ' // Function to return values from command line.
        Function GetArgValue(ByRef ArgArray() As String, ByVal SwitchValue As String, ByRef ErrMsg As String) As String
            ' Return switch values from command line.
            ' Switches and values must only come in pairs, ie. -u User -p Password -s Server
            Try
                For i As Integer = 0 To UBound(ArgArray) Step 2
                    If ArgArray(i) = SwitchValue Then
                        Return ArgArray(i + 1)
                    End If
                Next
            Catch ex As Exception
                ErrMsg = ex.Message
            End Try
            Return String.Empty
        End Function

    End Class
    ' // Class To Log Into ARServer 

    Public Class ARSInitialise

        Public Shared Function Login() As ARSystem.Server

            Dim ARServerName As String = My.MySettings.Default.ARSServerName
            Dim ARUser As String = My.MySettings.Default.ARUser
            Dim ARPassword As String = My.MySettings.Default.ARPassword
            Dim ARServerPort As Integer = My.MySettings.Default.ARServerPort

            Try
                Dim RemedyServer As New ARSystem.Server
                RemedyServer.Login(ARServerName, ARUser, ARPassword)
                RemedyServer.SetServerPort(ARServerPort, 0)
                Dim UserInfo() As ARSystem.UserInfo = RemedyServer.GetListUser(ARSystem.Server.UserListType.Myself, New Date(2000, 1, 1))
                Return RemedyServer
            Catch ex As Exception
                Throw New System.Exception(ex.Message, ex.InnerException)
                Exit Function
            End Try
        End Function
    End Class

End Namespace