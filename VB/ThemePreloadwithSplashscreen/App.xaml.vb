Imports DevExpress.Xpf.Core
Imports System.Runtime.CompilerServices
Imports System.Windows

Namespace ThemePreloadwithSplashscreen

    Public Partial Class App
        Inherits Application

        Shared Sub New()
            Call PreloadThemes()
        End Sub

        <MethodImpl(MethodImplOptions.NoInlining)>
        Private Shared Sub PreloadThemes()
            Call SplashScreenManager.CreateThemed().ShowOnStartup()
            Call ApplicationThemeHelper.Preload(PreloadCategories.Grid, PreloadCategories.LayoutControl)
        End Sub
    End Class
End Namespace
