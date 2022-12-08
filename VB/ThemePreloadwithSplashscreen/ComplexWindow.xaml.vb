Imports DevExpress.Xpf.Core

Namespace ThemePreloadwithSplashscreen

    Public Partial Class ComplexWindow
        Inherits ThemedWindow

        Public Sub New()
            Me.InitializeComponent()
            DataContext = New EmployeeViewModel()
        End Sub
    End Class
End Namespace
