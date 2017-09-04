Imports PropertyGridEx
Imports System.Drawing
Imports System.Xml
Imports System.IO
Imports System

Public Class frmMain

    Protected document As XmlDataDocument = Nothing
    Protected iSelectedRow As Integer = 0
    Protected iCountRow As Integer = 0

    Public Enum FilterPropertyType
        None
        FilterXmlSerializer
        FilterBinaryFormatter
    End Enum

#Region "Form Events"
    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Remove the Property Pages button
        Properties.ToolStrip.Items.RemoveAt(4)

        ' Run the first example
        ButtonExample1_Click(Me, Nothing)
    End Sub

    Private Sub frmMain_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        ' Apply style to DocComment object
        Properties.SetComment("Single Properties", "This example demonstrate how to apply to a single property, custom type editor and custom type converter.")
        ApplyCommentsStyle()
    End Sub
#End Region

#Region "Private Methods"

    Private Sub ApplyCommentsStyle()
        ' Apply new style to DocComment
        With Properties.DocCommentTitle
            .Font = New Font("Tahoma", 14, FontStyle.Bold)
        End With
        With Properties.DocCommentDescription
            .Location = New Point(3, (3 + Properties.DocCommentTitle.Font.Height))
        End With
    End Sub

    Private Sub ButtonSelection(ByVal iState As Integer)

        ' This routine plays with the Toolbar of the PropertyGrid
        Select Case iState
            Case 1              ' Single property Page
                ButtonExample1.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
                Properties.ContextMenuStrip = Nothing
                With ButtonExample2
                    .DisplayStyle = ToolStripItemDisplayStyle.Image
                    .Checked = False
                End With
                With ButtonExample3
                    .DisplayStyle = ToolStripItemDisplayStyle.Image
                    .Checked = False
                End With
                With ButtonXML
                    .DisplayStyle = ToolStripItemDisplayStyle.Image
                    ToolStripSeparator1.Visible = False
                    ButtonNext.Visible = False
                    ButtonPrevious.Visible = False
                End With
                With ButtonSerialize
                    .DisplayStyle = ToolStripItemDisplayStyle.Image
                End With

            Case 2              ' Multi object property Page                
                ButtonExample2.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
                Properties.ContextMenuStrip = Nothing
                With ButtonExample1
                    .DisplayStyle = ToolStripItemDisplayStyle.Image
                    .Checked = False
                End With
                With ButtonExample3
                    .DisplayStyle = ToolStripItemDisplayStyle.Image
                    .Checked = False
                End With
                With ButtonXML
                    .DisplayStyle = ToolStripItemDisplayStyle.Image
                    ToolStripSeparator1.Visible = False
                    ButtonNext.Visible = False
                    ButtonPrevious.Visible = False
                End With
                With ButtonSerialize
                    .DisplayStyle = ToolStripItemDisplayStyle.Image
                End With


            Case 3              ' Databinding
                ButtonExample3.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
                Properties.ContextMenuStrip = Nothing
                With ButtonExample1
                    .DisplayStyle = ToolStripItemDisplayStyle.Image
                    .Checked = False
                End With
                With ButtonExample2
                    .DisplayStyle = ToolStripItemDisplayStyle.Image
                    .Checked = False
                End With
                With ButtonXML
                    .DisplayStyle = ToolStripItemDisplayStyle.Image
                    ToolStripSeparator1.Visible = False
                    ButtonNext.Visible = False
                    ButtonPrevious.Visible = False
                End With
                With ButtonSerialize
                    .DisplayStyle = ToolStripItemDisplayStyle.Image
                End With


            Case 4              ' XML Sample
                Dim IsDataTableSample As Boolean = IIf(ButtonXML.Text = btnDatatableSample.Text, True, False)
                ButtonXML.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
                ToolStripSeparator1.Visible = IsDataTableSample
                ButtonNext.Visible = IsDataTableSample
                ButtonPrevious.Visible = IsDataTableSample
                ButtonPrevious.Enabled = False
                ButtonNext.Enabled = True
                Properties.ContextMenuStrip = ContextMenuSaveBooks

                With ButtonExample1
                    .DisplayStyle = ToolStripItemDisplayStyle.Image
                    .Checked = False
                End With
                With ButtonExample2
                    .DisplayStyle = ToolStripItemDisplayStyle.Image
                    .Checked = False
                End With
                With ButtonExample3
                    .DisplayStyle = ToolStripItemDisplayStyle.Image
                    .Checked = False
                End With
                With ButtonSerialize
                    .DisplayStyle = ToolStripItemDisplayStyle.Image
                End With

            Case 5              ' Serialization sample
                ButtonSerialize.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
                Properties.ContextMenuStrip = ContextMenuSaveItems
                With ButtonExample1
                    .DisplayStyle = ToolStripItemDisplayStyle.Image
                    .Checked = False
                End With
                With ButtonExample2
                    .DisplayStyle = ToolStripItemDisplayStyle.Image
                    .Checked = False
                End With
                With ButtonExample3
                    .DisplayStyle = ToolStripItemDisplayStyle.Image
                    .Checked = False
                End With
                With ButtonXML
                    .DisplayStyle = ToolStripItemDisplayStyle.Image
                    ToolStripSeparator1.Visible = False
                    ButtonNext.Visible = False
                    ButtonPrevious.Visible = False
                End With
        End Select
    End Sub

    Private Sub ParseSchema(ByRef document As XmlDataDocument, ByVal schema As String)
        Dim myStreamReader As StreamReader = Nothing
        Try
            myStreamReader = New StreamReader(schema)
            document.DataSet.ReadXmlSchema(myStreamReader)
        Catch e As Exception
            Console.WriteLine("Exception during XSD Parsing: " & e.Message())
        Finally
            If Not myStreamReader Is Nothing Then
                myStreamReader.Close()
            End If
        End Try
    End Sub

    Private Sub FillPropertyGrid1(Optional ByVal filter As FilterPropertyType = FilterPropertyType.None)
        Dim Languages As String() = New String() {"English", "Italian", "Spanish", "Dutch"}
        Dim ListValues() As MyOwnClass = New MyOwnClass() {New MyOwnClass("English", 0), _
                                                           New MyOwnClass("Italian", 1), _
                                                           New MyOwnClass("Spanish", 2), _
                                                           New MyOwnClass("Dutch", 3)}
        Dim Values As Integer() = New Integer() {1, 2, 3, 4}
        Dim oInstance As New MyOwnClass("String value", 0)

        ' The variable filter is used in the "Serialization Example"
        ' The filter remove from the grid the properties not correctly supported
        ' or not supported at all.

        With Properties
            .ShowCustomProperties = True
            .Item.Clear()

            ' Simple properties
            .Item.Add("My Integer", 100, False, "Simple properties", "This is an integer", True)
            .Item.Add("My Double", 10.4, False, "Simple properties", "This is a double", True)

            If filter <> FilterPropertyType.FilterXmlSerializer Then
                .Item.Add("My Font", New Font("Arial", 9), False, "Simple properties", "This is a font class", True)
                .Item.Add("My Color", New Color(), False, "Simple properties", "This is a color class", True)
                .Item.Add("My Point", New Point(10, 10), False, "Simple properties", "This is point class", True)
                .Item.Add("My Enum", MyEnum.FirstEntry, False, "Simple properties", "Work with Enum too!")

                .Item.Add("My Array", Languages, False, "Simple properties", "Work with Enum too!")
            End If

            .Item.Add("My Date", New Date(Today.Ticks), False, "Simple properties", "This is point class", True)

            ' IsPassword attribute
            .Item.Add("My Password", "password", False, ".NET v2.0 only", "This is a masked string." & vbCrLf & "(This feature is available only under .NET v2.0)", True)
            .Item(.Item.Count - 1).IsPassword = True

            ' Filename editor
            .Item.Add("Filename", "", False, "Properties with custom UITypeEditor", "This property is a filename path. It define a custom UITypeConverter that show a OpenFileDialog or a SaveFileDialog when the user press the 3 dots button to edit the value.", True)
            .Item(.Item.Count - 1).UseFileNameEditor = True
            .Item(.Item.Count - 1).FileNameDialogType = UIFilenameEditor.FileDialogType.LoadFileDialog
            .Item(.Item.Count - 1).FileNameFilter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"

            ' Custom Editor
            If filter <> FilterPropertyType.FilterBinaryFormatter And _
               filter <> FilterPropertyType.FilterXmlSerializer Then

                .Item.Add("My Custom Event", "Click me", False, "Properties with custom UITypeEditor", "The component accept custom event handler.", True)
                .Item(.Item.Count - 1).OnClick = AddressOf Me.CustomEventItem_OnClick

                .Item.Add("My Custom Editor", True, False, "Properties with custom UITypeEditor", "The component accept custom UITypeEditor.", True)
                .Item(.Item.Count - 1).CustomEditor = New MyEditor

                ' Custom TypeConverter
                .Item.Add("Integer", 1, False, "Properties with custom TypeConverter", "This property have a custom type converter that show a custom error message.", True)
                .Item(.Item.Count - 1).CustomTypeConverter = New MyTypeConverter
            End If

            ' Custom Choices Type Converter
            .Item.Add("Language", "", False, "Properties with custom TypeConverter", "This property uses a TypeConverter to dropdown a list of values.")
            .Item(.Item.Count - 1).Choices = New CustomChoices(Languages, True)

            .Item.Add("Values", 1, False, "Properties with custom TypeConverter", "This property uses a TypeConverter to dropdown a list of values.")
            .Item(.Item.Count - 1).Choices = New CustomChoices(Values, False)

            ' Expandable Type Converter
            If filter <> FilterPropertyType.FilterBinaryFormatter And _
               filter <> FilterPropertyType.FilterXmlSerializer Then
                .Item.Add("My settings", My.MySettings.Default, False, "Properties with custom TypeConverter", "This property make the Application Settings collection browsable ;)")
                .Item(.Item.Count - 1).IsBrowsable = True
                .Item(.Item.Count - 1).BrowsableLabelStyle = _
                    BrowsableTypeConverter.LabelStyle.lsEllipsis
            End If

            If filter <> FilterPropertyType.FilterXmlSerializer Then
                .Item.Add("My object", oInstance, False, "Properties with custom TypeConverter", "This property make a 'MyOwnClass' instance browsable.")
                .Item(.Item.Count - 1).IsBrowsable = True
                .Item(.Item.Count - 1).BrowsableLabelStyle = _
                    BrowsableTypeConverter.LabelStyle.lsEllipsis
            End If

            ' Dynamic properties
            If filter <> FilterPropertyType.FilterBinaryFormatter And _
               filter <> FilterPropertyType.FilterXmlSerializer Then

                .Item.Add("Autosize properties", Properties, "AutoSizeProperties", False, "Dynamic Properties", "This is a dynamic bound property. It changes the autosize property of this grid. Try it!", True)

                .Item.Add("Draw flat toolbar", Properties, "DrawFlatToolbar", False, "Dynamic Properties", "This is a dynamic bound property. It changes the DrawFlatToolbar property of this grid. Try it!", True)

                .Item.Add("Form opacity", Me, "Opacity", False, "Dynamic Properties", "This is a dynamic bound property. It changes the Opacity property of this form. Try it!", True)
                .Item(.Item.Count - 1).IsPercentage = True

                ' PropertyGridEx
                .Item.Add("Item", Properties, "Item", False, "PropertyGridEx", "Represent the PropertyGridEx Item collection.")
                .Item(.Item.Count - 1).Parenthesize = True

                .Item.Add("DocComment", Properties, "DocComment", False, "PropertyGridEx", "Represent the DocComment usercontrol of the PropertyGrid.")
                .Item(.Item.Count - 1).IsBrowsable = True

                .Item.Add("Image", Properties, "DocCommentImage", False, "PropertyGridEx", "Represent the DocComment usercontrol of the PropertyGrid.")
                .Item(.Item.Count - 1).DefaultValue = Nothing
                .Item(.Item.Count - 1).DefaultType = GetType(Image)

                .Item.Add("Toolstrip", Properties, "Toolstrip", False, "PropertyGridEx", "Represent the toolstrip of the PropertyGrid.")
                .Item(.Item.Count - 1).IsBrowsable = True

                .Item.Add("Colors", New CustomColorScheme(), False, "PropertyGridEx", "Represent the toolstrip of the PropertyGrid.")
                .Item(.Item.Count - 1).IsBrowsable = True

            End If

            If filter = FilterPropertyType.FilterBinaryFormatter Then

                ' Databinding works with serialization
                .Item.Add("Array of objects", ListValues(2).Text, True, "Databinding", "This is a UITypeEditor that implement a listbox", True)
                .Item(.Item.Count - 1).ValueMember = "Value"
                .Item(.Item.Count - 1).DisplayMember = "Text"
                .Item(.Item.Count - 1).Datasource = ListValues
                .Item(.Item.Count - 1).IsDropdownResizable = True

            End If

            .Refresh()

        End With
    End Sub

    Private Function CustomEventItem_OnClick(ByVal sender As Object, ByVal e As EventArgs) As Object
        MsgBox("You clicked on property '" & sender.CustomProperty.Name & "'", MsgBoxStyle.Information, "Custom Events as UITypeEditor")
        Return "Click me again"
    End Function

    Private Sub FillPropertyGrid2()

        With Properties
            .ShowCustomPropertiesSet = True
            .ItemSet.Clear()

            .ItemSet.Add()
            .ItemSet(0).Add("My Point", New Point(10, 10), False, "Appearance", "This is a font class", True)
            .ItemSet(0).Add("My Date", New Date(2006, 1, 1), False, "Appearance", "This is a datetime", True)

            .ItemSet.Add()
            .ItemSet(1).Add("My Point", New Point(10, 10), False, "Appearance", "This is a font class", True)
            .ItemSet(1).Add("My Date", New Date(2007, 1, 1), False, "Appearance", "This is a datetime", True)
            .ItemSet(1).Add("My Color", New Color(), False, "Appearance", "This is a color class", True)

            .Refresh()
        End With
    End Sub

    Private Sub FillPropertyGrid3()
        Dim Languages As String() = New String() {"English", "Italian", "Spanish", "Dutch"}
        Dim ListValues() As MyOwnClass = New MyOwnClass() {New MyOwnClass("English", 0), _
                                                           New MyOwnClass("Italian", 1), _
                                                           New MyOwnClass("Spanish", 2), _
                                                           New MyOwnClass("Dutch", 3)}
        Dim LookupTable As DataTable = Nothing
        Dim IsXmlSampleLoaded As Boolean = False
        document = New XmlDataDocument

        ' Load a DataTable from XML
        ParseSchema(document, My.Application.Info.DirectoryPath & "\books.xsd")
        Try
            With document
                .Load(My.Application.Info.DirectoryPath & "\books.xml")
                If .DataSet IsNot Nothing Then
                    LookupTable = .DataSet.Tables(1)
                End If
            End With
            If LookupTable IsNot Nothing Then
                IsXmlSampleLoaded = True
                iCountRow = LookupTable.Rows.Count
            End If
        Catch ex As Exception
            Console.WriteLine("Exception during XML Load: " & ex.Message())
            IsXmlSampleLoaded = False
        End Try

        With Properties
            .ShowCustomProperties = True
            .Item.Clear()

            ' If the XML Samples was loaded
            If IsXmlSampleLoaded Then

                ' Bind a property to a DataTable
                .Item.Add("Datatable", "", False, "Databinding", "This is a UITypeEditor that implement a listbox", True)
                .Item(.Item.Count - 1).ValueMember = "book_Id"
                .Item(.Item.Count - 1).DisplayMember = "title"
                .Item(.Item.Count - 1).Datasource = LookupTable

            End If

            ' Databinding to an array of objects with DisplayMember and ValueMember
            .Item.Add("Array of objects", ListValues(2).Text, False, "Databinding", "This is a UITypeEditor that implement a listbox", True)
            .Item(.Item.Count - 1).ValueMember = "Value"
            .Item(.Item.Count - 1).DisplayMember = "Text"
            .Item(.Item.Count - 1).Datasource = ListValues
            .Item(.Item.Count - 1).IsDropdownResizable = False

            ' Databinding to an array of strings
            .Item.Add("Array of strings", Languages(1), False, "Databinding", "This is a UITypeEditor that implement a listbox", True)
            .Item(.Item.Count - 1).Datasource = Languages
            .Item(.Item.Count - 1).IsDropdownResizable = True

            .MoveSplitterTo(120)
            .Refresh()
        End With
    End Sub

    Private Sub FillPropertyGrid4()
        Dim LookupTable As DataTable = Nothing
        Dim Column As DataColumn = Nothing
        Dim Row As DataRow = Nothing
        Dim IsXmlSampleLoaded As Boolean = False
        document = New XmlDataDocument

        ' Load a DataTable from XML
        ParseSchema(document, My.Application.Info.DirectoryPath & "\books.xsd")
        Try
            With document
                .Load(My.Application.Info.DirectoryPath & "\books.xml")
                If .DataSet IsNot Nothing Then
                    LookupTable = .DataSet.Tables(1)
                End If
            End With
            If LookupTable IsNot Nothing Then
                IsXmlSampleLoaded = True
                iCountRow = LookupTable.Rows.Count
            End If

        Catch ex As Exception
            Console.WriteLine("Exception during XML Load: " & ex.Message())
            IsXmlSampleLoaded = False
        End Try

        With Properties
            .ShowCustomProperties = True
            .Item.Clear()

            ' If the XML Samples was loaded
            If IsXmlSampleLoaded Then

                ' Get a row for demo purposes
                Row = LookupTable.Rows(iSelectedRow)

                ' Bind the row to the grid (create a property for each column)
                For Each Column In LookupTable.Columns
                    .Item.Add(Column.ColumnName.ToString, Row, Column.ColumnName.ToString, False, "Dynamic view of a DataTable")
                Next

            End If
            .MoveSplitterTo(120)
            .Refresh()
        End With

    End Sub

    Public Sub LoadXML()
        Dim IsXmlSampleLoaded As Boolean = False

        Dim doc As XmlDocument = New XmlDocument()
        Dim nsMgr As XmlNamespaceManager = Nothing
        Dim name As String = "", version As String = "", xmlns As String = "", xmlxsi As String = ""
        Dim root As XmlNode = Nothing
        Dim result As New CustomPropertyCollection

        ' Load XML
        Try
            With doc
                .Load(My.Application.Info.DirectoryPath & "\books.xml")
                name = .DocumentElement.Name
                version = .DocumentElement.GetAttribute("version")
                xmlns = .DocumentElement.GetAttribute("xmlns")
                xmlxsi = .DocumentElement.GetAttribute("xmlns:xsi")
                root = .DocumentElement
                nsMgr = New XmlNamespaceManager(.NameTable)
                nsMgr.AddNamespace("def", xmlns)
                nsMgr.AddNamespace("xsi", xmlxsi)
            End With
            IsXmlSampleLoaded = True

        Catch ex As Exception
            Console.WriteLine("Exception during XML Load: " & ex.Message())
            IsXmlSampleLoaded = False
        End Try

        With Properties
            .ShowCustomProperties = True
            .AutoSizeProperties = False
            .Item.Clear()
            If IsXmlSampleLoaded AndAlso root IsNot Nothing Then
                result = CustomProperty.LoadXmlNode(root, nsMgr)
                .Item.Add(name, result, False)
                .Item(.Item.Count - 1).IsBrowsable = True
                If version.Length > 0 Then .Item(.Item.Count - 1).BrowsableText = String.Format("{0}={1}", "version", version)
                AddHandler .Item(0).OnBubbleEvent, AddressOf OnCollectionChange
            End If
            .Refresh()
            .MoveSplitterTo(120)
        End With

    End Sub

#End Region

#Region "PropertyGrid ToolStrip Events"

    Private Sub ButtonExample1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonExample1.Click
        Try
            ' Select the first example page
            ButtonSelection(1)

            ' Load the propertygrid
            FillPropertyGrid1()

            Properties.SetComment("Single Properties", "This example demonstrate how to apply to a single property, custom type editor and custom type converter.")

            ' Update the status bar
            StatusLabel.Text = ButtonExample1.Text & " [ OK ]"
        Catch ex As Exception
            StatusLabel.Image = SystemIcons.Error.ToBitmap
            StatusLabel.Text = ButtonExample1.Text & " [ FAILED ]"
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub ButtonExample2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonExample2.Click
        Try
            ' Select the second example page
            ButtonSelection(2)

            ' Load the propertygrid
            FillPropertyGrid2()

            Properties.SetComment("Multiple Properties", "This example demonstrate how to edit multiple properties.")

            ' Update the status bar
            StatusLabel.Text = ButtonExample2.Text & " [ OK ]"
        Catch ex As Exception
            StatusLabel.Image = SystemIcons.Error.ToBitmap
            StatusLabel.Text = ButtonExample2.Text & " [ FAILED ]"
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub ButtonExample3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonExample3.Click
        Try
            ' Select the third example page
            ButtonSelection(3)

            ' Load the propertygrid
            FillPropertyGrid3()

            Properties.SetComment("Databinding Properties", "This example demonstrate how bind a single property to a datasource.")

            ' Update the status bar
            StatusLabel.Text = ButtonExample3.Text & " [ OK ]"
        Catch ex As Exception
            StatusLabel.Image = SystemIcons.Error.ToBitmap
            StatusLabel.Text = ButtonExample3.Text & " [ FAILED ]"
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub ButtonSerialize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSerialize.Click
        ButtonSerialize.ShowDropDown()
    End Sub

    Private Sub UsingXmlSerializerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsingXmlSerializerToolStripMenuItem.Click
        Try
            Dim filename As String = My.Application.Info.DirectoryPath & "\Items.xml"

            ' Select the third example page
            ButtonSerialize.Text = UsingXmlSerializerToolStripMenuItem.Text
            ButtonSelection(5)

            With Properties
                .Item.Clear()
                If Not .Item.LoadXml(filename, True) Then
                    FillPropertyGrid1(FilterPropertyType.FilterXmlSerializer)
                    .Item.SaveXml(filename)
                End If
                .Refresh()
            End With

            Properties.SetComment("Serialization sample", "This sample demonstrate how serialize the items of the propertygrid.")

            ' Update the status bar
            StatusLabel.Text = "Load Items " & ButtonSerialize.Text & " [ OK ]"
        Catch ex As Exception
            StatusLabel.Image = SystemIcons.Error.ToBitmap
            StatusLabel.Text = "Load Items " & ButtonSerialize.Text & " [ FAILED ]"
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub UsingBinaryFormatterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsingBinaryFormatterToolStripMenuItem.Click
        Try
            Dim filename As String = My.Application.Info.DirectoryPath & "\Items.dat"

            ' Select the third example page
            ButtonSerialize.Text = UsingBinaryFormatterToolStripMenuItem.Text
            ButtonSelection(5)

            ' Load the propertygrid
            With Properties
                .Item.Clear()
                If Not .Item.LoadBinary(filename) Then
                    FillPropertyGrid1(FilterPropertyType.FilterBinaryFormatter)
                    .Item.SaveBinary(filename)
                End If
                .Refresh()
            End With

            Properties.SetComment("Serialization sample", "This sample demonstrate how serialize the items of the propertygrid.")

            ' Update the status bar
            StatusLabel.Text = "Load Items " & ButtonSerialize.Text & " [ OK ]"
        Catch ex As Exception
            StatusLabel.Image = SystemIcons.Error.ToBitmap
            StatusLabel.Text = "Load Items " & ButtonSerialize.Text & " [ FAILED ]"
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub ButtonXML_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonXML.Click
        ButtonXML.ShowDropDown()
    End Sub

    Private Sub DatatableSample_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDatatableSample.Click
        Try
            ' Select the third example page
            ButtonXML.Text = btnDatatableSample.Text
            ButtonSelection(4)

            ' Load the propertygrid
            iSelectedRow = 0
            FillPropertyGrid4()

            Properties.SetComment("Datatable sample", "This sample demonstrate how bind a an entire datatable to the propertygrid. Please notice the contextual menu to serialize the data.")

            ' Update the status bar
            StatusLabel.Text = btnDatatableSample.Text & " [ OK ]"
        Catch ex As Exception
            StatusLabel.Image = SystemIcons.Error.ToBitmap
            StatusLabel.Text = btnDatatableSample.Text & " [ FAILED ]"
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub XMLEditorSample_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXMLEditorSample.Click
        Try
            ' Select the third example page
            ButtonXML.Text = btnXMLEditorSample.Text
            ButtonSelection(4)

            ' Load the propertygrid
            iSelectedRow = 0
            LoadXML()

            Properties.SetComment("XML Editor", "This sample demonstrate how bind a xml file to the propertygrid. Please notice the contextual menu to serialize the data.")

            ' Update the status bar
            StatusLabel.Text = btnXMLEditorSample.Text & " [ OK ]"
        Catch ex As Exception
            StatusLabel.Image = SystemIcons.Error.ToBitmap
            StatusLabel.Text = btnXMLEditorSample.Text & " [ FAILED ]"
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub ButtonNext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonNext.Click

        Dim Row As DataRow = Nothing
        Dim Column As DataColumn = Nothing

        If document IsNot Nothing Then
            Dim CustomProp As CustomProperty
            Dim Rows As DataRowCollection
            Rows = document.DataSet.Tables(1).Rows

            iSelectedRow = iSelectedRow + 1
            If iSelectedRow = Rows.Count - 1 Then
                ButtonNext.Enabled = False
            End If
            If ButtonPrevious.Enabled = False Then ButtonPrevious.Enabled = True

            Row = Rows(iSelectedRow)

            For Each CustomProp In New ArrayList(Properties.Item)
                If CustomProp.Category = "Dynamic view of a DataTable" Then Properties.Item.Remove(CustomProp.Name)
            Next

            For Each Column In document.DataSet.Tables(1).Columns
                Properties.Item.Add(Column.ColumnName.ToString, Row, Column.ColumnName.ToString, False, "Dynamic view of a DataTable")
            Next
            Properties.Refresh()
        End If

    End Sub

    Private Sub ButtonPrevious_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonPrevious.Click

        Dim Row As DataRow = Nothing
        Dim Column As DataColumn = Nothing

        If document IsNot Nothing Then
            Dim CustomProp As CustomProperty
            Dim Rows As DataRowCollection
            Rows = document.DataSet.Tables(1).Rows
            iSelectedRow = iSelectedRow - 1
            If iSelectedRow = 0 Then
                ButtonPrevious.Enabled = False
            End If
            If ButtonNext.Enabled = False Then ButtonNext.Enabled = True

            Row = Rows(iSelectedRow)

            For Each CustomProp In New ArrayList(Properties.Item)
                If CustomProp.Category = "Dynamic view of a DataTable" Then Properties.Item.Remove(CustomProp.Name)
            Next

            For Each Column In document.DataSet.Tables(1).Columns
                Properties.Item.Add(Column.ColumnName.ToString, Row, Column.ColumnName.ToString, False, "Dynamic view of a DataTable")
            Next
            Properties.Refresh()
        End If

    End Sub

#End Region

#Region "PropertyGrid Events"

    Private Sub OnCollectionChange(ByVal index As Integer, ByVal value As Object)
        Properties.Refresh()
    End Sub

    Private Sub Properties_PropertyValueChanged(ByVal s As System.Object, ByVal e As System.Windows.Forms.PropertyValueChangedEventArgs) Handles Properties.PropertyValueChanged

        Dim message As String
        StatusLabel.Image = SystemIcons.Information.ToBitmap

        Select Case e.ChangedItem.PropertyDescriptor.GetType.Name

            Case "CustomPropertyDescriptor"
                Dim cpd As CustomProperty.CustomPropertyDescriptor = TryCast(e.ChangedItem.PropertyDescriptor, CustomProperty.CustomPropertyDescriptor)
                If cpd IsNot Nothing Then
                    Dim cp As CustomProperty = cpd.CustomProperty
                    If cp Is Nothing Then Return
                    If cp.Value IsNot Nothing Then
                        message = " Value: " & cp.Value.ToString
                        If e.OldValue IsNot Nothing Then message = message & "; Previous: " & e.OldValue.ToString
                        If cp.SelectedItem IsNot Nothing Then message = message & "; SelectedItem: " & cp.SelectedItem.ToString
                        If cp.SelectedValue IsNot Nothing Then message = message & "; SelectedValue: " & cp.SelectedValue.ToString
                        StatusLabel.Text = message
                    End If
                End If

            Case "MergePropertyDescriptor"

                message = " {MultiProperty [" & e.ChangedItem.Label & "]} " & e.ChangedItem.Value.ToString
                If e.OldValue Is Nothing Then
                    message = message & "; Nothing"
                Else : message = message & "; " & e.OldValue.ToString
                End If
                StatusLabel.Text = message

            Case "ReflectPropertyDescriptor"

                message = " {NestedProperty [" & e.ChangedItem.Label & "]} " & e.ChangedItem.Value.ToString
                If e.OldValue Is Nothing Then
                    message = message & "; Nothing"
                Else : message = message & "; " & e.OldValue.ToString
                End If
                StatusLabel.Text = message

            Case Else
                StatusLabel.Image = SystemIcons.Error.ToBitmap
                StatusLabel.Text = " {Unknown PropertyDescriptor: " & e.ChangedItem.PropertyDescriptor.GetType.Name & "}"
        End Select
    End Sub
#End Region

#Region "ContextMenu Events"
    Private Sub SaveBooksXml_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveBooksXml.Click
        Dim IsDataTableSample As Boolean = IIf(ButtonXML.Text = btnDatatableSample.Text, True, False)
        If IsDataTableSample Then
            document.Save(My.Application.Info.DirectoryPath & "\books.xml")
        Else
            Dim doc As XmlDocument = New XmlDocument()
            Dim writer As New XmlTextWriter(My.Application.Info.DirectoryPath & "\books.xml", Nothing)
            Dim result As String = Properties.Item(0).ToXml
            doc.LoadXml(result)
            writer.Formatting = Formatting.Indented
            doc.Save(writer)
            writer.Close()
        End If
        Properties.Refresh()
    End Sub

    Private Sub SaveItems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveItems.Click
        Select Case ButtonSerialize.Text
            Case UsingBinaryFormatterToolStripMenuItem.Text
                Dim filename As String = My.Application.Info.DirectoryPath & "\Items.dat"
                Properties.Item.SaveBinary(filename)
            Case UsingXmlSerializerToolStripMenuItem.Text
                Dim filename As String = My.Application.Info.DirectoryPath & "\Items.xml"
                Properties.Item.SaveXml(filename)
        End Select
    End Sub
#End Region

End Class
