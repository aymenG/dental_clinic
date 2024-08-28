using System.Windows;
using System.Windows.Input;

namespace DentalClinic
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Image_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Close();

        }

        private void LoginBtn(object sender, RoutedEventArgs e)
        {
            Dashboard dashboard = new();
            dashboard.Show();



        }



        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

       

        private void btnClose(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnMinimize(object sender, MouseButtonEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
    }
}

