Imports System
Imports System.ComponentModel
Imports System.Collections

Namespace DotBits.Configuration
	''' <summary>
	''' Modified class from the CustomClass originally created by Venu Madhav.
	''' Venu's DataTable and DataColumn objects have been removed and variables and
	''' class names have been renamed. The derived DynamicProperty class below now contains 
	''' the property data. This is a simpler implementation becuase the backing store for 
	''' the property data is the XML Config file - no need for another set of objects to hold 
	''' the data before it gets written back to the config file (although actually holding the
	''' property data in the PropertyDescriptor class is probably a little unorthodox).
	''' CustomClass implements ICustomTypeDescriptor and derives ExpandableObjectConverter.
	''' This class can be instantiated and properties to this class can
	''' be added dynamically using AddProperty(string propName, object propValue, string propDesc, 
	''' string propCat,  System.Type propType, bool isReadOnly, bool isExpandable). 
	''' </summary>

	<TypeConverter(GetType(ExpandableObjectConverter))> _
	Public Class CustomClass
		Inherits Component
		Implements ICustomTypeDescriptor

		'Private members
		Private propertyCollection As PropertyDescriptorCollection
		'Max length will be used help control the layout of the Windows Form and PropertyGrid
		'or the table of controls in an ASP.Net page. The Form or Webpage layout will be adjusted
		'dynamically depending on length of these values.
		Private _maxLength As Integer
		Public Property MaxLength() As Integer
			Get
				Return _maxLength
			End Get
			Set
				If value > _maxLength Then
					_maxLength = value
				End If
			End Set
		End Property

		''' <summary>
		''' Constructor of CustomClass which initializes the new PropertyDescriptorCollection.
		''' </summary>
		Public Sub New()
			propertyCollection = New PropertyDescriptorCollection(New PropertyDescriptor() {})
		End Sub


		''' <summary>
		''' Adds a property into the CustomClass.
		''' </summary>
		''' <param name="propName">Name of the property that needs to be added.</param>
		''' <param name="propValue">Value of the property that needs to be added.</param>
		''' <param name="propDesc">Description of the property that needs to be added.</param>
		''' <param name="propCat">The category to display this property in.</param>
		''' <param name="isReadOnly">Sets the property value to readonly in the property grid.</param>
		''' <param name="isExpandable">Tells the property grid that this property is expandable.</param>
		''' <param name="propType">DataType of the property that needs to be added.</param>
		Public Sub AddProperty(ByVal propName As String, ByVal propValue As Object, ByVal propDesc As String, ByVal propCat As String, ByVal propType As System.Type, ByVal isReadOnly As Boolean, _
			ByVal isExpandable As Boolean)
			Dim p As New DynamicProperty(propName, propValue, propDesc, propCat, propType, isReadOnly, _
				isExpandable)
			propertyCollection.Add(p)
			'Set our layout helper value.
			Me.MaxLength = propName.Length
			Me.MaxLength = propValue.ToString().Length
		End Sub

		'Indexer for this class - returns a DynamicProperty by index position.
		Public Default ReadOnly Property Item(ByVal index As Integer) As DynamicProperty
			Get
				Return DirectCast(propertyCollection(index), DynamicProperty)
			End Get
		End Property

		'Overloaded Indexer for this class - returns a DynamicProperty by name.
		Public Default ReadOnly Property Item(ByVal name As String) As DynamicProperty
			Get
				Return DirectCast(propertyCollection(name), DynamicProperty)
			End Get
		End Property

		''' <summary>
		'''
		''' </summary>
		''' <returns></returns>
		Public Function GetClassName() As String
			Return (TypeDescriptor.GetClassName(Me, True))
		End Function

		''' <summary>
		'''
		''' </summary>
		''' <returns></returns>
		Public Function GetAttributes() As AttributeCollection
			Return (TypeDescriptor.GetAttributes(Me, True))
		End Function

		''' <summary>
		'''
		''' </summary>
		''' <returns></returns>
		Public Function GetComponentName() As String
			Return (TypeDescriptor.GetComponentName(Me, True))
		End Function

		''' <summary>
		'''
		''' </summary>
		''' <returns></returns>
		Public Function GetConverter() As TypeConverter
			Return (TypeDescriptor.GetConverter(Me, True))
		End Function

		''' <summary>
		'''
		''' </summary>
		''' <returns></returns>
		Public Function GetDefaultEvent() As EventDescriptor
			Return (TypeDescriptor.GetDefaultEvent(Me, True))
		End Function

		''' <summary>
		'''
		''' </summary>
		''' <returns></returns>
		Public Function GetDefaultProperty() As PropertyDescriptor
			Dim props As PropertyDescriptorCollection = GetAllProperties()

			If props.Count > 0 Then
				Return (props(0))
			Else
				Return (Nothing)
			End If
		End Function

		''' <summary>
		'''
		''' </summary>
		''' <param name="editorBaseType"></param>
		''' <returns></returns>
		Public Function GetEditor(ByVal editorBaseType As Type) As Object
			Return (TypeDescriptor.GetEditor(Me, editorBaseType, True))
		End Function

		''' <summary>
		'''
		''' </summary>
		''' <param name="attributes"></param>
		''' <returns></returns>
		Public Function GetEvents(ByVal attributes As Attribute()) As EventDescriptorCollection
			Return (TypeDescriptor.GetEvents(Me, attributes, True))
		End Function

		''' <summary>
		'''
		''' </summary>
		''' <returns></returns>
		Public Function GetEvents() As EventDescriptorCollection
			Return (TypeDescriptor.GetEvents(Me, True))
		End Function

		''' <summary>
		'''
		''' </summary>
		''' <param name="attributes"></param>
		''' <returns></returns>
		Public Function GetProperties(ByVal attributes As Attribute()) As PropertyDescriptorCollection
			Return (GetAllProperties())
		End Function

		''' <summary>
		'''
		''' </summary>
		''' <returns></returns>
		Public Function GetProperties() As PropertyDescriptorCollection
			Return (GetAllProperties())
		End Function

		''' <summary>
		'''
		''' </summary>
		''' <param name="pd"></param>
		''' <returns></returns>
		Public Function GetPropertyOwner(ByVal pd As PropertyDescriptor) As Object
			Return (Me)
		End Function


		''' <summary>
		'''	Helper method to return the PropertyDescriptorCollection or our Dynamic Properties
		''' </summary>
		''' <param name="pd"></param>
		''' <returns></returns>
		Private Function GetAllProperties() As PropertyDescriptorCollection
			Return propertyCollection
		End Function



		''' <summary>
		'''	This is the Property class this will be dynamically added to the class at runtime.
		'''	These classes are returned in the PropertyDescriptorCollection of the GetAllProperties
		'''	method of the custom class.
		''' </summary>
		''' <param name="pd"></param>
		''' <returns></returns>
		Public Class DynamicProperty
			Inherits PropertyDescriptor
			Private propName As String
			Private propValue As Object
			Private propDescription As String
			Private propCategory As String
			Private propType As Type
			Private m_isReadOnly As Boolean
			Private isExpandable As Boolean

			Public Sub New(ByVal pName As String, ByVal pValue As Object, ByVal pDesc As String, ByVal pCat As String, ByVal pType As Type, ByVal [readOnly] As Boolean, _
				ByVal expandable As Boolean)
				MyBase.New(pName, New Attribute() {})
				propName = pName
				propValue = pValue
				propDescription = pDesc
				propCategory = pCat
				propType = pType
				m_isReadOnly = [readOnly]
				isExpandable = expandable
			End Sub

			Public Overloads Overrides ReadOnly Property ComponentType() As System.Type
				Get
					Return Nothing
				End Get
			End Property

			Public Overloads Overrides ReadOnly Property Category() As String
				Get
					Return propCategory
				End Get
			End Property

			Public Overloads Overrides ReadOnly Property IsReadOnly() As Boolean
				Get
					Return m_isReadOnly
				End Get
			End Property

			Public Overloads Overrides ReadOnly Property PropertyType() As System.Type
				Get
					Return propType
				End Get
			End Property

			Public Overloads Overrides Function CanResetValue(ByVal component As Object) As Boolean
				Return True
			End Function

			Public Overloads Overrides Function GetValue(ByVal component As Object) As Object
				Return propValue
			End Function

			Public Overloads Overrides Sub SetValue(ByVal component As Object, ByVal value As Object)
				propValue = value
			End Sub

			Public Overloads Overrides Sub ResetValue(ByVal component As Object)
				propValue = Nothing
			End Sub

			Public Overloads Overrides Function ShouldSerializeValue(ByVal component As Object) As Boolean
				Return False
			End Function

			Public Overloads Overrides ReadOnly Property Description() As String
				Get
					Return propDescription
				End Get
			End Property
		End Class
	End Class
End Namespace
