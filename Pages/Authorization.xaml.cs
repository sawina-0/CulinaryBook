using CulinaryBook.AppFrame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CulinaryBook.Pages
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Page
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void btAuthorisation_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var user = AppConnect.Model.Authors.FirstOrDefault(u => u.Login == txbLogin.Text && u.Password == psbPassword.Password);
                if (user != null)
                {
                    MessageBox.Show($"Dobry den, {user.AuthorName}!");
                    AppFrame.MainFrame.FrameMain.Navigate(new ReciepView());
                }
                else
                {
                    MessageBox.Show("Login is not found or password incorrect", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch 
            {
                MessageBox.Show("Programm RIP, try later");
            }
        }

        private void btRegistration_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.MainFrame.FrameMain.Navigate(new Registration());
        }
    }
}
