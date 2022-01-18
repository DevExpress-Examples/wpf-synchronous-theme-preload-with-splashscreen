Imports System.Diagnostics
Imports System.Windows

Namespace ThemePreloadwithSplashscreen

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Friend Shared stopwatch As Stopwatch = New Stopwatch()

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim complexWindow = New ComplexWindow()
            complexWindow.Show()
        End Sub
    End Class
End Namespace
