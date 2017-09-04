Imports System
Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Globalization
Imports System.Resources
Imports System.Runtime.CompilerServices

Namespace Westwind.Utilities.Configuration.Properties
	<GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"), DebuggerNonUserCode(), CompilerGenerated()>
	Public Class Resources
		Private Shared resourceMan As ResourceManager

		Private Shared resourceCulture As CultureInfo

		<EditorBrowsable(EditorBrowsableState.Advanced)>
		Public Shared ReadOnly Property ResourceManager() As ResourceManager
			Get
				If Object.ReferenceEquals(Resources.resourceMan, Nothing) Then
					Dim resourceManager As ResourceManager = New ResourceManager("Westwind.Utilities.Configuration.Properties.Resources", GetType(Resources).Assembly)
					Resources.resourceMan = resourceManager
				End If
				Return Resources.resourceMan
			End Get
		End Property

		<EditorBrowsable(EditorBrowsableState.Advanced)>
		Public Shared Property Culture() As CultureInfo
			Get
				Return Resources.resourceCulture
			End Get
			Set(value As CultureInfo)
				Resources.resourceCulture = value
			End Set
		End Property

		Public Shared ReadOnly Property AConnectionStringMustBePassedToTheConstructor() As String
			Get
				Return Resources.ResourceManager.GetString("AConnectionStringMustBePassedToTheConstructor", Resources.resourceCulture)
			End Get
		End Property

		Public Shared ReadOnly Property ByteValueGreaterThan20megsAreNotSupported() As String
			Get
				Return Resources.ResourceManager.GetString("ByteValueGreaterThan20megsAreNotSupported", Resources.resourceCulture)
			End Get
		End Property

		Public Shared ReadOnly Property ConfigurationMethodNoLongerSupported() As String
			Get
				Return Resources.ResourceManager.GetString("ConfigurationMethodNoLongerSupported", Resources.resourceCulture)
			End Get
		End Property

		Public Shared ReadOnly Property DataReaderPassedToDataReaderToObjectCannot() As String
			Get
				Return Resources.ResourceManager.GetString("DataReaderPassedToDataReaderToObjectCannot", Resources.resourceCulture)
			End Get
		End Property

		Public Shared ReadOnly Property InvalidConnectionStringName() As String
			Get
				Return Resources.ResourceManager.GetString("InvalidConnectionStringName", Resources.resourceCulture)
			End Get
		End Property

		Public Shared ReadOnly Property InvalidTypeForXmlTypeToNETTypeConversion() As String
			Get
				Return Resources.ResourceManager.GetString("InvalidTypeForXmlTypeToNETTypeConversion", Resources.resourceCulture)
			End Get
		End Property

		Public Shared ReadOnly Property ObjectCouldNotBeDeserializedFromXml() As String
			Get
				Return Resources.ResourceManager.GetString("ObjectCouldNotBeDeserializedFromXml", Resources.resourceCulture)
			End Get
		End Property

		Public Shared ReadOnly Property StringToTypedValueValueTypeConversionFailed() As String
			Get
				Return Resources.ResourceManager.GetString("StringToTypedValueValueTypeConversionFailed", Resources.resourceCulture)
			End Get
		End Property

		Public Shared ReadOnly Property UnableToExtractKeys() As String
			Get
				Return Resources.ResourceManager.GetString("UnableToExtractKeys", Resources.resourceCulture)
			End Get
		End Property

		Public Shared ReadOnly Property UnableToReadConfigDataFromString() As String
			Get
				Return Resources.ResourceManager.GetString("UnableToReadConfigDataFromString", Resources.resourceCulture)
			End Get
		End Property

		Friend Sub New()
		End Sub
	End Class
End Namespace
