' See "Implementing a TypeConverter" by Paul Kimmel.
' http://www.codeguru.com/columns/VB/article.php/c6529/.

Imports System.ComponentModel

Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents PropertyGrid1 As System.Windows.Forms.PropertyGrid
    Friend WithEvents PropertyGrid2 As System.Windows.Forms.PropertyGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.PropertyGrid1 = New System.Windows.Forms.PropertyGrid
        Me.PropertyGrid2 = New System.Windows.Forms.PropertyGrid
        Me.SuspendLayout()
        '
        'PropertyGrid1
        '
        Me.PropertyGrid1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PropertyGrid1.CommandsVisibleIfAvailable = True
        Me.PropertyGrid1.LargeButtons = False
        Me.PropertyGrid1.LineColor = System.Drawing.SystemColors.ScrollBar
        Me.PropertyGrid1.Location = New System.Drawing.Point(0, 0)
        Me.PropertyGrid1.Name = "PropertyGrid1"
        Me.PropertyGrid1.Size = New System.Drawing.Size(360, 314)
        Me.PropertyGrid1.TabIndex = 0
        Me.PropertyGrid1.Text = "PropertyGrid1"
        Me.PropertyGrid1.ViewBackColor = System.Drawing.SystemColors.Window
        Me.PropertyGrid1.ViewForeColor = System.Drawing.SystemColors.WindowText
        '
        'PropertyGrid2
        '
        Me.PropertyGrid2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PropertyGrid2.CommandsVisibleIfAvailable = True
        Me.PropertyGrid2.LargeButtons = False
        Me.PropertyGrid2.LineColor = System.Drawing.SystemColors.ScrollBar
        Me.PropertyGrid2.Location = New System.Drawing.Point(368, 0)
        Me.PropertyGrid2.Name = "PropertyGrid2"
        Me.PropertyGrid2.Size = New System.Drawing.Size(360, 314)
        Me.PropertyGrid2.TabIndex = 1
        Me.PropertyGrid2.Text = "PropertyGrid2"
        Me.PropertyGrid2.ViewBackColor = System.Drawing.SystemColors.Window
        Me.PropertyGrid2.ViewForeColor = System.Drawing.SystemColors.WindowText
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(736, 317)
        Me.Controls.Add(Me.PropertyGrid2)
        Me.Controls.Add(Me.PropertyGrid1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim per As New Person
        per.FirstName = "Helen"
        per.LastName = "Hacker"
        per.Location = New Point(10, 20)
        per.Address.Street = "1234 Leet Street"
        per.Address.City = "Bugsville"
        per.Address.State = "AZ"
        PropertyGrid1.SelectedObject = per

        Dim per2 As New Person2
        per2.FirstName = "Helen"
        per2.LastName = "Hacker"
        per2.Location = New Point(10, 20)
        per2.Address.Street = "1234 Leet Street"
        per2.Address.City = "Bugsville"
        per2.Address.State = "AZ"
        PropertyGrid2.SelectedObject = per2
    End Sub
End Class

<TypeConverter(GetType(StreetAddressConverter))> _
Public Class StreetAddress
    Public Sub New()
    End Sub
    Public Sub New(ByVal new_street As String, ByVal new_city As String, ByVal new_state As String)
        m_Street = new_street
        m_City = new_city
        m_State = new_state
    End Sub

    Public Overrides Function ToString() As String
        Return m_Street & "," & m_City & "," & State
    End Function

    Private m_Street As String
    Public Property Street() As String
        Get
            Return m_Street
        End Get
        Set(ByVal Value As String)
            m_Street = Value
        End Set
    End Property

    Private m_City As String
    Public Property City() As String
        Get
            Return m_City
        End Get
        Set(ByVal Value As String)
            m_City = Value
        End Set
    End Property

    Private m_State As String
    Public Property State() As String
        Get
            Return m_State
        End Get
        Set(ByVal Value As String)
            m_State = Value
        End Set
    End Property
End Class

Public Class StreetAddress2
    Public Sub New()
    End Sub
    Public Sub New(ByVal new_street As String, ByVal new_city As String, ByVal new_state As String)
        m_Street = new_street
        m_City = new_city
        m_State = new_state
    End Sub

    Public Overrides Function ToString() As String
        Return m_Street & "," & m_City & "," & State
    End Function

    Private m_Street As String
    Public Property Street() As String
        Get
            Return m_Street
        End Get
        Set(ByVal Value As String)
            m_Street = Value
        End Set
    End Property

    Private m_City As String
    Public Property City() As String
        Get
            Return m_City
        End Get
        Set(ByVal Value As String)
            m_City = Value
        End Set
    End Property

    Private m_State As String
    Public Property State() As String
        Get
            Return m_State
        End Get
        Set(ByVal Value As String)
            m_State = Value
        End Set
    End Property
End Class

Public Class Person
    Public Sub New()
        m_Address = New StreetAddress
    End Sub

    Private m_Point As Point
    Public Property Location() As Point
        Get
            Return m_Point
        End Get
        Set(ByVal Value As Point)
            m_Point = Value
        End Set
    End Property

    Private m_FirstName As String
    Public Property FirstName() As String
        Get
            Return (m_FirstName)
        End Get
        Set(ByVal Value As String)
            m_FirstName = Value
        End Set
    End Property

    Private m_LastName As String
    Public Property LastName() As String
        Get
            Return (m_LastName)
        End Get
        Set(ByVal Value As String)
            m_LastName = Value
        End Set
    End Property

    Private m_Address As StreetAddress
    Public Property Address() As StreetAddress
        Get
            Return (m_Address)
        End Get
        Set(ByVal Value As StreetAddress)
            m_Address = Value
        End Set
    End Property
End Class

Public Class Person2
    Public Sub New()
        m_Address = New StreetAddress2
    End Sub

    Private m_Point As Point
    Public Property Location() As Point
        Get
            Return m_Point
        End Get
        Set(ByVal Value As Point)
            m_Point = Value
        End Set
    End Property

    Private m_FirstName As String
    Public Property FirstName() As String
        Get
            Return (m_FirstName)
        End Get
        Set(ByVal Value As String)
            m_FirstName = Value
        End Set
    End Property

    Private m_LastName As String
    Public Property LastName() As String
        Get
            Return (m_LastName)
        End Get
        Set(ByVal Value As String)
            m_LastName = Value
        End Set
    End Property

    Private m_Address As StreetAddress2
    Public Property Address() As StreetAddress2
        Get
            Return (m_Address)
        End Get
        Set(ByVal Value As StreetAddress2)
            m_Address = Value
        End Set
    End Property
End Class

Public Class StreetAddressConverter
    Inherits TypeConverter

    Public Overloads Overrides Function CanConvertFrom(ByVal context As System.ComponentModel.ITypeDescriptorContext, ByVal sourceType As System.Type) As Boolean
        If (sourceType.Equals(GetType(String))) Then
            Return True
        Else
            Return MyBase.CanConvertFrom(context, sourceType)
        End If
    End Function

    Public Overloads Overrides Function CanConvertTo(ByVal context As System.ComponentModel.ITypeDescriptorContext, ByVal destinationType As System.Type) As Boolean
        If (destinationType.Equals(GetType(String))) Then
            Return True
        Else
            Return MyBase.CanConvertTo(context, destinationType)
        End If
    End Function

    Public Overloads Overrides Function ConvertFrom(ByVal context As System.ComponentModel.ITypeDescriptorContext, ByVal culture As System.Globalization.CultureInfo, ByVal value As Object) As Object
        If (TypeOf value Is String) Then
            Dim txt As String = CType(value, String)
            Dim fields() As String = txt.Split(New Char() {","})

            Try
                Return New StreetAddress(fields(0), fields(1), fields(2))
            Catch
                Throw New InvalidCastException(value)
            End Try
        Else
            Return MyBase.ConvertFrom(context, culture, value)
        End If
    End Function

    Public Overloads Overrides Function ConvertTo(ByVal context As System.ComponentModel.ITypeDescriptorContext, ByVal culture As System.Globalization.CultureInfo, ByVal value As Object, ByVal destinationType As System.Type) As Object
        If (destinationType.Equals(GetType(String))) Then
            Return value.ToString()
        Else
            Return MyBase.ConvertTo(context, culture, value, destinationType)
        End If
    End Function

    Public Overloads Overrides Function GetPropertiesSupported(ByVal context As ITypeDescriptorContext) As Boolean
        Return True
    End Function

    Public Overloads Overrides Function GetProperties(ByVal context As ITypeDescriptorContext, ByVal value As Object, ByVal Attribute() As Attribute) As PropertyDescriptorCollection
        Return TypeDescriptor.GetProperties(value)
    End Function
End Class