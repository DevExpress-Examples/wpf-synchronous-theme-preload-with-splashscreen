using DevExpress.Xpf.Core;
using DevExpress.Xpf.Grid;
using DevExpress.Xpf.LayoutControl;
using System;
using System.Diagnostics;
using System.Windows;

namespace ThemePreloadwithSplashscreen
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        static Type[] types;
        static App()
        {
            types = new Type[] { typeof(GridControl), typeof(LayoutControl) };
            SplashScreenManager.CreateThemed().ShowOnStartup();
            ThemeManager.PreloadThemeResourceAsync("Office2019Colorful", runTypeInitializers: false).Wait();
        }
    }
}
