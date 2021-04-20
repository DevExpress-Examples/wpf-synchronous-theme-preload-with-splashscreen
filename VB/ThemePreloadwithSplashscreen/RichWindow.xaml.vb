Imports DevExpress.Xpf.Core
Imports System
Imports System.Windows

Namespace ThemePreloadwithSplashscreen
	''' <summary>
	''' Interaction logic for RichWindow.xaml
	''' </summary>
	Partial Public Class RichWindow
		Inherits ThemedWindow

		Public Sub New()
			InitializeComponent()
			DataContext = New EmployeeViewModel()
		End Sub
	End Class
End Namespace
