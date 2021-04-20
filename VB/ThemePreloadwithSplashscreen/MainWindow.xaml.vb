Imports System
Imports System.Diagnostics
Imports System.Windows

Namespace ThemePreloadwithSplashscreen
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window

		Friend Shared stopwatch As New Stopwatch()
		Public Sub New()
			InitializeComponent()
			AddHandler Me.ContentRendered, AddressOf MainWindow_ContentRendered
		End Sub

		Private Sub MainWindow_ContentRendered(ByVal sender As Object, ByVal e As EventArgs)
			stopwatch.Stop()
			stopwatch.Stop()
		End Sub

		Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			stopwatch.Start()
			Dim richWindow As New RichWindow()
			'App.Current.MainWindow = richWindow;
			richWindow.Show()
			'Close();
		End Sub
	End Class
End Namespace
