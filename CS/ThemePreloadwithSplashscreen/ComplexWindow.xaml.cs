using DevExpress.Xpf.Core;
using System;
using System.Windows;

namespace ThemePreloadwithSplashscreen
{
    /// <summary>
    /// Interaction logic for RichWindow.xaml
    /// </summary>
    public partial class ComplexWindow : ThemedWindow
    {
        public ComplexWindow()
        {
            InitializeComponent();
            DataContext = new EmployeeViewModel();
        }
    }
}
