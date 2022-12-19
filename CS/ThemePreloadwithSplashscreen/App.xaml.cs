using DevExpress.Xpf.Core;
using DevExpress.Xpf.Grid;
using DevExpress.Xpf.LayoutControl;
using System;
using System.Windows;

namespace ThemePreloadwithSplashscreen {
    public partial class App : Application {

        static Type[] types;
        static App() {
            types = new Type[] { typeof(GridControl), typeof(LayoutControl) };
            SplashScreenManager.CreateThemed().ShowOnStartup();
            ThemeManager.PreloadThemeResource("Office2019Colorful");
        }
    }
}
