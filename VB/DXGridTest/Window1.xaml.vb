Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports DevExpress.Xpf.Utils.Themes
Imports DevExpress.Xpf.Grid
Imports DevExpress.Xpf.Core
Imports System.Collections
Imports System.Windows.Threading

Namespace DXGridTest
	''' <summary>
	''' Interaction logic for Window1.xaml
	''' </summary>
	Partial Public Class Window1
		Inherits Window
		Public Sub New()
			InitializeComponent()

			Dim list As New List(Of TestData)()
			For i As Integer = 0 To 99
				list.Add(New TestData() With {.Text = "Row" & i, .Number = i, .Group = i Mod 3})
			Next i
			grid.DataSource = list
		End Sub
	End Class

	Public Class MyTableView
		Inherits TableView
		Protected Overrides Sub OnKeyUp(ByVal e As KeyEventArgs)
		End Sub
		Protected Overrides Sub OnKeyDown(ByVal e As KeyEventArgs)
			If e.Key = Key.Tab Then
				Return
			End If
			MyBase.OnKeyDown(e)
		End Sub
	End Class

	Public Class TestData
		Private privateText As String
		Public Property Text() As String
			Get
				Return privateText
			End Get
			Set(ByVal value As String)
				privateText = value
			End Set
		End Property
		Private privateNumber As Integer
		Public Property Number() As Integer
			Get
				Return privateNumber
			End Get
			Set(ByVal value As Integer)
				privateNumber = value
			End Set
		End Property
		Private privateGroup As Integer
		Public Property Group() As Integer
			Get
				Return privateGroup
			End Get
			Set(ByVal value As Integer)
				privateGroup = value
			End Set
		End Property
	End Class
End Namespace
