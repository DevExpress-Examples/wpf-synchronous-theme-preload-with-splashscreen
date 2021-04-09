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
            ContentRendered += MainWindow_ContentRendered;
        }

        private void MainWindow_ContentRendered(object sender, EventArgs e)
        {
            App.stopwatch.Stop();
            stopwatch.Stop();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App.stopwatch.Start();
            var richWindow = new RichWindow();
            //App.Current.MainWindow = richWindow;
            richWindow.Show();
            //Close();
        }
    }
}
