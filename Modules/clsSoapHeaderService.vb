Imports System
Imports System.Web
Imports System.Data
Imports System.Diagnostics
Imports System.Collections
Imports System.Web.Services
Imports System.ComponentModel
Imports System.Web.Services.Protocols

Namespace AuthForWebServices
    ''' <summary>
    ''' Summary description for WebService.
    ''' </summary>
    Public Class WebService
        Inherits System.Web.Services.WebService
        Public Authentication As AuthHeader

        Public Sub New()
            'CODEGEN: This call is required by the ASP.NET Web Services Designer
            InitializeComponent()
        End Sub

#Region "Component Designer generated code"

        'Required by the Web Services Designer 
        Private components As IContainer = Nothing

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
        End Sub

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#End Region

        <SoapHeader("Authentication", Required:=True)> _
        <WebMethod(Description:="Returns some sample data")> _
        Public Function SensitiveData() As DataSet

            Dim data As New DataSet()

            'Do our authentication - this can be via a database or whatever
            If Authentication.Username = "test" AndAlso Authentication.Password = "test" Then
                'they are allowed access to our sensitive data - just create some dummy data
                Dim dtTable1 As New DataTable()
                Dim drCol1 As New DataColumn("Data", System.Type.[GetType]("System.String"))
                dtTable1.Columns.Add(drCol1)

                Dim drRow As DataRow = dtTable1.NewRow()
                drRow("Data") = "Sensitive Data"
                dtTable1.Rows.Add(drRow)
                dtTable1.AcceptChanges()
                data.Tables.Add(dtTable1)
            Else
                data = Nothing
            End If

            Return data

        End Function

    End Class

    Public Class AuthHeader

        Inherits SoapHeader
        Public Username As String
        Public Password As String

    End Class

End Namespace

<WebService([Namespace]:="http://tempuri.org/")> _
<WebServiceBinding(Name:="TestService", ConformsTo:=WsiProfiles.BasicProfile1_1)> _
Public Class SOAPHeaderService
    Inherits System.Web.Services.WebService
    Public Sub New()
        'Uncomment the following line if using designed components 
        'InitializeComponent()
    End Sub

    ' Visual studio will append a "UserCredentialsValue" property to the proxy class
    Public consumer As UserCredentials
    <WebMethod()> _
    <SoapDocumentMethod(Binding:="TestService")> _
    <SoapHeader("consumer", Required:=True)> _
    Public Function GetBalance() As String
        If checkConsumer() Then
            Return consumer.userName & " had 10000000 credit"
        Else
            Return "Error in authentication"
        End If
    End Function

    Private Function checkConsumer() As Boolean
        ' In this method you can check the username and password 
        ' with your database or something
        ' You could also encrypt the password for more security
        If consumer IsNot Nothing Then
            If consumer.userName = "Ahmed" AndAlso consumer.password = "1234" Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function
End Class

Public Class UserCredentials
    Inherits SoapHeader
    Public userName As String
    Public password As String
End Class

