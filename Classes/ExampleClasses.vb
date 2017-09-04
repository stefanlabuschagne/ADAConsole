Imports System
Imports System.ComponentModel
Imports System.Drawing.Design
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

''' <summary>
''' A Simple Enum to test DropDown choices
''' </summary>
''' <remarks></remarks>
Public Enum MyEnum
    FirstEntry
    SecondEntry
    ThirdEntry
End Enum

''' <summary>
''' A Simple Class to test BrowsableAttribute usage
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class MyOwnClass
    Private iValue As Integer = 0
    Private sText As String
    Public Sub New()

    End Sub
    Public Sub New(ByVal Text As String, ByVal Value As Integer)
        sText = Text
        iValue = Value
    End Sub
    Public Property Value() As Integer
        Get
            Return iValue
        End Get
        Set(ByVal value As Integer)
            iValue = value
        End Set
    End Property
    Public Property Text() As String
        Get
            Return sText
        End Get
        Set(ByVal value As String)
            sText = value
        End Set
    End Property
End Class

''' <summary>
''' A custom TypeConverter
''' </summary>
''' <remarks></remarks>
Public Class MyStringConverter
    Inherits MultilineStringConverter
    Public Overrides Function ConvertTo(ByVal context As System.ComponentModel.ITypeDescriptorContext, ByVal culture As System.Globalization.CultureInfo, ByVal value As Object, ByVal destinationType As System.Type) As Object
        Return "(My multiline string editor)"
    End Function
End Class

''' <summary>
''' A custom UITypeEditor
''' </summary>
''' <remarks></remarks>
Public Class MyEditor
    Inherits System.Drawing.Design.UITypeEditor

    Public Overloads Overrides Function GetEditStyle(ByVal context As  _
                    ITypeDescriptorContext) As UITypeEditorEditStyle
        If Not context Is Nothing AndAlso Not context.Instance Is Nothing Then
            If Not context.PropertyDescriptor.IsReadOnly Then
                Return UITypeEditorEditStyle.Modal
            End If
        End If
        Return UITypeEditorEditStyle.None
    End Function

    <RefreshProperties(RefreshProperties.All)> _
    Public Overloads Overrides Function EditValue( _
                ByVal context As ITypeDescriptorContext, _
                ByVal provider As System.IServiceProvider, _
                ByVal value As [Object]) As [Object]
        If context Is Nothing OrElse provider Is Nothing _
                OrElse context.Instance Is Nothing Then
            Return MyBase.EditValue(provider, value)
        End If
        If MsgBox("Please answer me", MsgBoxStyle.Information Or MsgBoxStyle.YesNo, "Question") = MsgBoxResult.Yes Then
            value = True
        Else
            value = False
        End If
        Return value
    End Function
End Class

''' <summary>
''' A TypeConverter that shows a custom message
''' </summary>
''' <remarks>UNDONE:Write with Component Services controlled dialog</remarks>
Public Class MyTypeConverter
    Inherits Int32Converter
    Private bMsgboxIsVisible As Boolean = False
    Public Overrides Function ConvertFrom(ByVal context As System.ComponentModel.ITypeDescriptorContext, ByVal culture As System.Globalization.CultureInfo, ByVal value As Object) As Object
        Try
            Return MyBase.ConvertFrom(context, culture, value)
        Catch ex As Exception
            If Not bMsgboxIsVisible Then
                bMsgboxIsVisible = True
                MsgBox("Custom Message: " & ex.Message, MsgBoxStyle.Exclamation, "Custom message")
            End If
            bMsgboxIsVisible = False
            Return context.PropertyDescriptor.GetValue(Me)
        End Try
    End Function
End Class
