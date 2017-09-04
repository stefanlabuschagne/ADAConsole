Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.IO
Imports System.Diagnostics
Imports LibFTPServ.VFS

Namespace VFS
	''' <summary>
	''' stores the dynamic script parser paths
	''' </summary>
	Public NotInheritable Class ParserPaths
		Private Sub New()
		End Sub
		''' <summary>
		''' The full Path to php.exe 
		''' </summary>
		Public Shared PhpPath As String = ""

		''' <summary>
		''' The full path to python.exe
		''' </summary>
		Public Shared PythonPath As String = ""

		''' <summary>
		''' the full path to ruby.exe
		''' </summary>
		Public Shared RubyPath As String = ""
	End Class

	''' <summary>
	''' Script type enumeration
	''' </summary>
	Public Enum ScriptType
		''' <summary>
		''' PHP Script
		''' </summary>
		Php

		''' <summary>
		''' Python script
		''' </summary>
		Python

		''' <summary>
		''' Ruby script
		''' </summary>
		Ruby

		''' <summary>
		''' Standalone program which doesn't need an interpreter
		''' </summary>
		Standalone
	End Enum
End Namespace
