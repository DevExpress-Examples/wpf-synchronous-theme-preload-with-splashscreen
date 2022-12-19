Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.Grid
Imports DevExpress.Xpf.LayoutControl
Imports System
Imports System.Windows

Namespace ThemePreloadwithSplashscreen

    Public Partial Class App
        Inherits Application

        Private Shared types As Type()

        Shared Sub New()
            types = New Type() {GetType(GridControl), GetType(LayoutControl)}
            Call SplashScreenManager.CreateThemed().ShowOnStartup()
            ThemeManager.PreloadThemeResource("Office2019Colorful")
        End Sub
    End Class
End Namespace
