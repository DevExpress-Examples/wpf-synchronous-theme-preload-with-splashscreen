using System.Windows;

namespace ThemePreloadwithSplashscreen {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e) {
            var complexWindow = new ComplexWindow();
            complexWindow.Show();
        }
    }
}
