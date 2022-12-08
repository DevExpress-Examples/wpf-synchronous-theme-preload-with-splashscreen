using DevExpress.Xpf.Core;

namespace ThemePreloadwithSplashscreen {
    public partial class ComplexWindow : ThemedWindow {
        public ComplexWindow() {
            InitializeComponent();
            DataContext = new EmployeeViewModel();
        }
    }
}
