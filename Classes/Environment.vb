Namespace RemedyEnvironment

    Public Class Environment

        'Instance
        Public Function CreateInstance(ByVal environment As String) As Object

            Dim servername As String
            If (environment.Contains("- QA")) Then

                Dim ARSCustomerInfo As New devlgremv1.CustomerInformationWebServiceService
                Dim AI1 As New devlgremv1.AuthenticationInfo
                Return ARSCustomerInfo

            ElseIf (environment.Contains("- PRD")) Then

                Dim ARSCustomerInfo As New WS_CI__c1.WS_CI__c1Service
                Dim AI As New WS_CI__c1.AuthenticationInfo
                Return ARSCustomerInfo
            End If
        End Function

        'Getlist Operation
        Public Function getListOp(ByVal environment As String) As Object


            If (environment.Contains("- QA")) Then


                Dim Query_OutputMap As OutputMapping5GetListValues
                Query_OutputMap = New OutputMapping5GetListValues()
                Return Query_OutputMap

            ElseIf (environment.Contains("- PRD")) Then

                Dim Query_OutputMap As WS_CI__c1.OutputMapping5GetListValues
                Return Query_OutputMap

            End If

        End Function

        'Authentication
        Public Function GetAuthenticationInfo(ByVal environment As String) As Object


            If (environment.Contains("- QA")) Then

                Dim AI As New devlgremv1.AuthenticationInfo
                Return AI
            ElseIf (environment.Contains("- PRD")) Then


                Dim AI As New WS_CI__c1.AuthenticationInfo
                Return AI

            End If


        End Function

        'Public Function changeConnectionString()

        '    If frmEnvironment.ActiveMdiChild.Text.Contains("PRD") Then

        '        My.MySettings.Default("AdsConnectionString") = My.MySettings.Default("AdsPRDConnectionString")
        '        My.MySettings.Default("AdsConnectionString") = My.MySettings.Default("AdsConnectionString")
        '        My.MySettings.Default("ARSystemConnectionStringDev") = My.MySettings.Default("ARSystemConnectionStringPROD")
        '        My.MySettings.Default("VIP_EXPANDEDConnectionString2008QA") = My.MySettings.Default("VIP_EXPANDEDConnectionString2008PRD")


        '    Else
        '        My.MySettings.Default("AdsConnectionString") = My.MySettings.Default("AdsQAConnectionString")
        '        My.MySettings.Default("AdsConnectionString") = My.MySettings.Default("AdsQAConnectionString")
        '        My.MySettings.Default("ARSystemConnectionStringPROD") = My.MySettings.Default("ARSystemConnectionStringDev")
        '        My.MySettings.Default("VIP_EXPANDEDConnectionString2008PRD") = My.MySettings.Default("VIP_EXPANDEDConnectionString2008QA")

        '    End If
        'End Function




    End Class

End Namespace


