using DevExpress.Xpf.Core;
using System;
using System.Windows;

namespace ThemePreloadwithSplashscreen
{
    /// <summary>
    /// Interaction logic for RichWindow.xaml
    /// </summary>
    public partial class RichWindow : ThemedWindow
    {
        public RichWindow()
        {
            InitializeComponent();
            DataContext = new EmployeeViewModel();
        }
    }
}
