using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyfirstApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(txtEmail.Text) && !String.IsNullOrEmpty(txtPassword.Password))
            {
                MessageBox.Show("Successfully Signed In");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }

        }

        private void textEmail_MouseDown(object sender, RoutedEventArgs e)
        {
            txtEmail.Focus();
        }
        private void txtEmail_TextChanged(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(txtEmail.Text) && txtEmail.Text.Length > 0)
            {

                textEmail.Visibility = Visibility.Collapsed;

            }
            else
            {

                textEmail.Visibility = Visibility.Visible;


            }

        }
        private void textPassword_MouseDown(object sender, RoutedEventArgs e)
        {
            txtPassword.Focus();
        }
        private void txtPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(txtEmail.Text) && txtEmail.Text.Length > 0)
            {

                txtPassword.Visibility = Visibility.Collapsed;

            }
            else
            {

                txtPassword.Visibility = Visibility.Visible;


            }

        }

        private void Image_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();

        }
    }
}

