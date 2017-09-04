Imports System
Imports System.Web
Imports System.Configuration

Partial Class ASPXParser
    Inherits System.Web.UI.Page
    Protected Function SeminarTitle() As String
        Return ConfigurationSettings.AppSettings("SeminarTitle")
    End Function
    Protected Function BusinesName() As String
        Return ConfigurationSettings.AppSettings("BusinesName")
    End Function
    Protected Function WebsiteURL() As String
        Return ConfigurationSettings.AppSettings("WebsiteURL")
    End Function
    Protected Function Mp3Path() As String
        Return ConfigurationSettings.AppSettings("Mp3Path")
    End Function
    Protected Function VideoPath() As String
        Return ConfigurationSettings.AppSettings("VideoPath")
    End Function
    Protected Function PodCastPath() As String
        Return ConfigurationSettings.AppSettings("PodCastPath")
    End Function
    Protected Function NextSeminarDate() As String
        Return ConfigurationSettings.AppSettings("NextSeminarDate")
    End Function
    Protected Function SeminarPrice() As String
        Return ConfigurationSettings.AppSettings("SeminarPrice")
    End Function
    Protected Function FaxNumber() As String
        Return ConfigurationSettings.AppSettings("FaxNumber")
    End Function
    Protected Function SeatsLeftMessage() As String
        Return ConfigurationSettings.AppSettings("SeatsLeftMessage")
    End Function

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    End Sub
End Class
