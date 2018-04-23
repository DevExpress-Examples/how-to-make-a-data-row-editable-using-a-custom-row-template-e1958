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
Imports DevExpress.Wpf.Utils.Themes
Imports DevExpress.Wpf.Grid
Imports DevExpress.Wpf.Core
Imports System.Collections
Imports System.Windows.Threading

Namespace DXGridTest
	''' <summary>
	''' Interaction logic for Window1.xaml
	''' </summary>
	Public Partial Class Window1
		Inherits Window
		Public Sub New()
			InitializeComponent()

			Dim list As List(Of TestData) = New List(Of TestData)()
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
        Private _Number As Integer
        Public Property Number() As Integer
            Get
                Return _Number
            End Get
            Set(ByVal Value As Integer)
                _Number = Value
            End Set
        End Property
        Private _text As String
        Public Property Text() As String
            Get
                Return _text
            End Get
            Set(ByVal Value As String)
                _text = Value
            End Set
        End Property
        Private _Group As Integer
        Public Property Group() As Integer
            Get
                Return _Group
            End Get
            Set(ByVal Value As Integer)
                _Group = Value
            End Set
        End Property
    End Class
End Namespace

