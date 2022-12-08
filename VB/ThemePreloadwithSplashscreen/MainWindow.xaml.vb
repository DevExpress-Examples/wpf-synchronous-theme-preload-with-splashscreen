Imports System.Windows

Namespace ThemePreloadwithSplashscreen

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim complexWindow = New ComplexWindow()
            complexWindow.Show()
        End Sub
    End Class
End Namespace
