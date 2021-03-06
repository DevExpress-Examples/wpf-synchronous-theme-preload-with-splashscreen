Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.Grid
Imports DevExpress.Xpf.LayoutControl
Imports System
Imports System.Diagnostics
Imports System.Windows

Namespace ThemePreloadwithSplashscreen

    ''' <summary>
    ''' Interaction logic for App.xaml
    ''' </summary>
    Public Partial Class App
        Inherits Application

        Private Shared types As Type()

        Shared Sub New()
            types = New Type() {GetType(GridControl), GetType(LayoutControl)}
            Call SplashScreenManager.CreateThemed().ShowOnStartup()
            Call ThemeManager.PreloadThemeResourceAsync("Office2019Colorful", runTypeInitializers:=False).Wait()
        End Sub
    End Class
End Namespace
