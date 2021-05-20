using System;
using System.Diagnostics;
using System.Windows;

namespace ThemePreloadwithSplashscreen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        internal static Stopwatch stopwatch = new Stopwatch();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var complexWindow = new ComplexWindow();
            complexWindow.Show();
        }
    }
}
