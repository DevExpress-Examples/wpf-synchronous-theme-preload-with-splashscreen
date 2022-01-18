Imports DevExpress.Xpf.Core

Namespace ThemePreloadwithSplashscreen

    ''' <summary>
    ''' Interaction logic for RichWindow.xaml
    ''' </summary>
    Public Partial Class ComplexWindow
        Inherits ThemedWindow

        Public Sub New()
            Me.InitializeComponent()
            DataContext = New EmployeeViewModel()
        End Sub
    End Class
End Namespace
