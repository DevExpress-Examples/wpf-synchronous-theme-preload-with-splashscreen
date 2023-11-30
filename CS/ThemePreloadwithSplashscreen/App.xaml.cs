using DevExpress.Xpf.Core;
using System.Runtime.CompilerServices;
using System.Windows;

namespace ThemePreloadwithSplashscreen {
    public partial class App : Application {
        static App() {
            PreloadThemes();
        }
        [MethodImpl(MethodImplOptions.NoInlining)]
        static void PreloadThemes() {
            SplashScreenManager.CreateThemed().ShowOnStartup();
            ApplicationThemeHelper.Preload(PreloadCategories.Grid, PreloadCategories.LayoutControl);
        }
    }
}
