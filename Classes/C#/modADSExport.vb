Option Strict Off
Option Explicit On

Imports System.Data.SqlClient

Module modADSExport

    Public Sub Create_Snapshot()

        Dim authenticate As Object
        Dim mvarsError As Object
        Dim memberOF As Object
        Dim mstr As Object
        Dim f As Object 'oCont)
        Dim appstr As String
        Dim govstr As String
        Dim strc As String
        Dim strDepartment As String
        Dim oUser As ActiveDs.IADsUser
        Dim oContainer As ActiveDs.IADsContainer
        Dim dso As ActiveDs.IADsOpenDSObject
        Dim xas As String
        Dim appl As String
        Dim a() As String
        Dim temparray() As String
        Dim tempstr As String
        Dim aGovernment() As String
        Dim entry As Object
        Dim temporaryDate2 As Integer
        Dim date2 As Integer
        Dim i, y, mcount As Integer
        Dim mmax As Object
        Dim strApps As String
        Dim strGovt As String
        Dim UCount As Integer = 0
        Dim colGovernment As New Microsoft.VisualBasic.Collection
        Dim colApplications As New Microsoft.VisualBasic.Collection
        Dim memberOFS As String = ""
        Dim cnVIP_EXP As New SqlConnection

        cnVIP_EXP.ConnectionString = My.Settings.VIP_EXPANDEDConnectionString

        Dim cnADS2 As New SqlConnection
        Dim cnADS As New SqlConnection

        cnADS.ConnectionString = My.Settings.AdsConnectionString
        cnADS2.ConnectionString = My.Settings.AdsConnectionString

        Dim cmdADS2 As New SqlCommand("AD_SNAPSHOT_ALL_INSERT", cnADS)
        Dim cmdADS3 As New SqlCommand("AD_SNAPSHOT_ALL_DELETE_ALL", cnADS)
        Dim cmdADS4 As New SqlCommand("GetPROVDescription", cnADS2)
        Dim cmdADS5 As New SqlCommand("GetSNAMEDept", cnADS2)

        cmdADS2.CommandType = CommandType.StoredProcedure
        cmdADS3.CommandType = CommandType.StoredProcedure
        cmdADS4.CommandType = CommandType.StoredProcedure
        cmdADS5.CommandType = CommandType.StoredProcedure

        Dim pUCount As New SqlParameter("@UCount", SqlDbType.BigInt)
        Dim pPersalnr As New SqlParameter("@PersalNr", SqlDbType.VarChar, 8)
        Dim pAccountNr As New SqlParameter("@AccountNr", SqlDbType.VarChar, 9)
        Dim pNatProv As New SqlParameter("@NatProv ", SqlDbType.VarChar, 20)
        Dim pVote As New SqlParameter("@Vote", SqlDbType.VarChar, 55)
        Dim pDeptCode As New SqlParameter("@DeptCode", SqlDbType.VarChar, 9)
        Dim pEMail As New SqlParameter("@EMail", SqlDbType.VarChar, 150)
        Dim pCell As New SqlParameter("@Cell", SqlDbType.VarChar, 20)
        Dim pPhone As New SqlParameter("@Phone", SqlDbType.VarChar, 20)
        Dim pFirstName As New SqlParameter("@FirstName", SqlDbType.VarChar, 20)
        Dim pLastname As New SqlParameter("@Lastname", SqlDbType.VarChar, 40)
        Dim pApplMember As New SqlParameter("@ApplMember", SqlDbType.VarChar, 500)
        Dim pDeptMember As New SqlParameter("@DeptMember", SqlDbType.VarChar, 4000)
        Dim pDepartment As New SqlParameter("@Department", SqlDbType.VarChar, 10)
        Dim pAccountDisabled As New SqlParameter("@AccountDisabled", SqlDbType.SmallInt)
        Dim pLOGIS As New SqlParameter("@LOGIS", SqlDbType.SmallInt)
        Dim pHR As New SqlParameter("@HR", SqlDbType.SmallInt)
        Dim pFINANCIALS As New SqlParameter("@FINANCIALS", SqlDbType.SmallInt)
        Dim pGFS As New SqlParameter("@GFS", SqlDbType.SmallInt)
        Dim pDPSA As New SqlParameter("@DPSA", SqlDbType.SmallInt)
        Dim pSNAME As New SqlParameter("@SNAME", SqlDbType.VarChar, 9)

        Dim enc As New ClsCrypto

        dso = GetObject("LDAP:")
        oContainer = dso.OpenDSObject("LDAP://" & My.Settings.IP_ADDRESS_PRD & "/" & My.Settings.AD_USERS_PRD, My.Settings.ADSMasterUsername_PRD, enc.Dekodeer128(My.Settings.ADSMasterPassword_PRD.ToString), 0)
        cnADS.Open()
        cmdADS3.ExecuteNonQuery()

        For Each oUser In oContainer
            UCount += 1
            pUCount.Value = UCount
            mcount = mcount + 1
            Select Case LCase(oUser.Class)

                Case "user"

                    If Not IsNothing(Trim(oUser.SAMaccountname)) Then
                        frmMain.tsADPosition.Text = oUser.samaccountname
                        pSNAME.Value = oUser.Department.ToLower.ToString.Trim & ""
                        cmdADS5.Parameters.Add(pSNAME)
                        cnADS2.Open()
                        pVote.Value = cmdADS5.ExecuteScalar.ToString & ""
                        cnADS2.Close()
                        cmdADS5.Parameters.Remove(pSNAME)

                        On Error Resume Next
                        pAccountNr.Value = oUser.SAMaccountname.ToString.Trim & ""
                        cmdADS4.Parameters.Add(pSNAME)
                        cnADS2.Open()
                        pNatProv.Value = cmdADS4.ExecuteScalar.ToString & ""
                        cnADS2.Close()
                        cmdADS4.Parameters.Remove(pSNAME)

                        pDeptCode.Value = pSNAME.Value & ""

                        If IsDBNull(Trim(oUser.EmailAddress)) Then
                            pEMail.Value = "No Email"
                        Else
                            pEMail.Value = oUser.EmailAddress.ToLower.Trim & ""
                        End If

                        If IsDBNull(CStr(oUser.TelephoneMobile)) Or IsNothing(oUser.TelephoneMobile) Then
                            pCell.Value = "No Mobile"
                        Else
                            pCell.Value = Replace(Replace(CStr(oUser.TelephoneMobile), "(", ""), ")", "")
                        End If

                        If IsDBNull(CStr(oUser.TelephoneNumber)) Then
                            pPhone.Value = "No TelephoneNumber"
                        Else
                            pPhone.Value = Replace(Replace(oUser.TelephoneNumber.ToString, "(", ""), ")", "") & ""
                        End If

                        If IsDBNull(oUser.FirstName) Then
                            pFirstName.Value = "No Firstname"
                        Else
                            pFirstName.Value = oUser.FirstName.Trim & ""
                        End If

                        If IsDBNull(oUser.LastName) Then
                            pLastname.Value = "No LastName"
                        Else
                            pLastname.Value = oUser.LastName.Trim & ""
                        End If

                        memberOF = oUser.GetEx("MemberOf")

                        If Err.Number = -2147463155 Then
                            colApplications.Add("INVALID USER")
                            colGovernment.Add("INVALID USER")
                            pLOGIS.Value = 0
                            pDPSA.Value = 0
                            pGFS.Value = 0
                            pHR.Value = 0
                            pFINANCIALS.Value = 0
                        Else
                            ' Start with the new structure.
                            memberOFS = ""
                            For Each entry In memberOF

                                'Clear collections
                                If (InStr(1, UCase(entry), "GOVERNMENT") > 0 Or _
                                    InStr(1, UCase(entry), "VUL TS USERS") > 0 Or _
                                    InStr(1, UCase(entry), "APPLICATION") > 0) And _
                                    InStr(1, UCase(entry), "CN=") > 0 Then

                                    entry = Replace(Replace(entry, "OU=", ""), "CN=", "")

                                    temparray = Split(entry, ",")
                                    tempstr = Replace(temparray(0), "_ACCESS_ALL", "")
                                    tempstr = Replace(tempstr, "_ALL_ACCESS", "")
                                    tempstr = Replace(tempstr, "_SEC32", "")

                                    If InStr(1, UCase(entry), "GOVERNMENT") > 0 Then
                                        colGovernment.Add(tempstr)
                                    ElseIf InStr(1, UCase(entry), "APPLICATION") > 0 Or InStr(1, UCase(entry), "VUL TS USERS") > 0 Then
                                        memberOFS = memberOFS & " " & tempstr & ""
                                        colApplications.Add(tempstr)
                                    End If

                                End If

                            Next entry

                            pLOGIS.Value = IIf(InStr(1, memberOFS, "LOGIS.") > 0, 1, 0)
                            pDPSA.Value = IIf(InStr(1, memberOFS, "DPSA.") > 0, 1, 0)
                            pGFS.Value = IIf(InStr(1, memberOFS, "GFS.") > 0, 1, 0)
                            pHR.Value = IIf(InStr(1, memberOFS, "HR.") > 0, 1, 0)
                            pFINANCIALS.Value = IIf(InStr(1, memberOFS, "FINANCIALS.") > 0, 1, 0)

                        End If

                        strApps = ""
                        For y = 1 To colApplications.Count()
                            If Len(strApps) = 0 Then
                                strApps = colApplications.Item(y)
                            Else
                                strApps = strApps & "," & colApplications.Item(y) & ""
                            End If
                        Next y

                        If Len(Trim(strApps)) = 0 Then
                            strApps = "INVALID USER"
                        End If
                        pApplMember.Value = strApps

                        strGovt = ""
                        For y = 1 To colGovernment.Count()
                            If Len(strGovt) = 0 Then
                                strGovt = colGovernment.Item(y)
                            Else
                                strGovt = strGovt & "," & colGovernment.Item(y) & ""
                            End If
                        Next y
                        pDeptMember.Value = strGovt
                        strDepartment = ""
                        strDepartment = oUser.Department & ""
                        If Len(Trim(strDepartment)) = 0 Then
                            pDepartment.Value = "No Department"
                        Else
                            pDepartment.Value = oUser.Department & ""
                        End If
                        If (CStr(oUser.AccountDisabled)).ToUpper.Trim = "TRUE" Then
                            pAccountDisabled.Value = 1
                        Else
                            pAccountDisabled.Value = 0
                        End If
                        'pAccountDisabled.Value = CStr(oUser.AccountDisabled)

                        cmdADS2.Parameters.Add(pAccountNr)
                        cmdADS2.Parameters.Add(pNatProv)
                        cmdADS2.Parameters.Add(pVote)
                        cmdADS2.Parameters.Add(pDeptCode)
                        cmdADS2.Parameters.Add(pEMail)
                        cmdADS2.Parameters.Add(pCell)
                        cmdADS2.Parameters.Add(pPhone)
                        cmdADS2.Parameters.Add(pFirstName)
                        cmdADS2.Parameters.Add(pLastname)
                        cmdADS2.Parameters.Add(pApplMember)
                        cmdADS2.Parameters.Add(pDeptMember)
                        cmdADS2.Parameters.Add(pDepartment)
                        cmdADS2.Parameters.Add(pAccountDisabled)
                        cmdADS2.Parameters.Add(pLOGIS)
                        cmdADS2.Parameters.Add(pHR)
                        cmdADS2.Parameters.Add(pFINANCIALS)
                        cmdADS2.Parameters.Add(pGFS)
                        cmdADS2.Parameters.Add(pDPSA)
                        cmdADS2.Parameters.Add(pUCount)
                        'cmdADS2.Parameters.Add(pAccCreated)
                        'cmdADS2.Parameters.Add(pAccModified)


                        '**************************    

                        cmdADS2.ExecuteNonQuery()

                        '**************************    
                        cmdADS2.Parameters.Remove(pAccountNr)
                        cmdADS2.Parameters.Remove(pNatProv)
                        cmdADS2.Parameters.Remove(pVote)
                        cmdADS2.Parameters.Remove(pDeptCode)
                        cmdADS2.Parameters.Remove(pEMail)
                        cmdADS2.Parameters.Remove(pCell)
                        cmdADS2.Parameters.Remove(pPhone)
                        cmdADS2.Parameters.Remove(pFirstName)
                        cmdADS2.Parameters.Remove(pLastname)
                        cmdADS2.Parameters.Remove(pApplMember)
                        cmdADS2.Parameters.Remove(pDeptMember)
                        cmdADS2.Parameters.Remove(pDepartment)
                        cmdADS2.Parameters.Remove(pAccountDisabled)
                        cmdADS2.Parameters.Remove(pLOGIS)
                        cmdADS2.Parameters.Remove(pHR)
                        cmdADS2.Parameters.Remove(pFINANCIALS)
                        cmdADS2.Parameters.Remove(pGFS)
                        cmdADS2.Parameters.Remove(pDPSA)

                        colGovernment.Clear()
                        colApplications.Clear()

                    End If

            End Select

            Err.Clear()

        Next oUser

        frmMain.tsADPosition.Text = ""

CloseMe:
        GoTo cleanup

err_handler:
        mvarsError = "{ADS4.authenticate} authenticate: (" & Err.Number & ") " & Err.Description
        Err.Clear()
        authenticate = False

cleanup:
        oUser = Nothing
        memberOF = Nothing
        oContainer = Nothing
        oUser = Nothing
        dso = Nothing
        colGovernment = Nothing
        colApplications = Nothing
        cnADS.Close()
        cnADS = Nothing

    End Sub

End Module