Imports System

Namespace Westwind.Utilities.Configuration
	Friend Class MyAppConfiguration
		Inherits AppConfiguration

		Public Property MyProperty() As String

		Public Property MaxPageListItems() As Integer

		Public Property ApplicationTitle() As String

		Public Sub New()
			Me.MyProperty = "My default property value"
			Me.MaxPageListItems = 15
			Me.ApplicationTitle = "My great application!"
		End Sub

		Protected Override Function OnCreateDefaultProvider(sectionName As String, configData As Object) As IConfigurationProvider
			Return MyBase.OnCreateDefaultProvider(sectionName, configData)
		End Function
	End Class
End Namespace
