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
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Page
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void btRegistration_Click(object sender, RoutedEventArgs e)
        {
            string authorName = tbName.Text;
            string login = tbCreateLogin.Text;
            string password = psbCreatePassword.Password;
            string passwordAgain = psbPasswordAgain.Password;
            DateTime? dateOfBiirth = dpBirthday.SelectedDate;
            string exp = tbWorkExp.Text;
            string email = tbEmail.Text;
            string phoneNum = tbPhoneNum.Text;

            if (string.IsNullOrWhiteSpace(authorName) || string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(passwordAgain) || !dateOfBiirth.HasValue || string.IsNullOrWhiteSpace(exp) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(phoneNum))
            { 
                MessageBox.Show("Please enter all fields", "Warning", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if(password != passwordAgain)
            {
                MessageBox.Show("Passwords are different", " (ㆆ _ ㆆ) ", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if(AppFrame.AppConnect.Model.Authors.Count(x => x.Login == tbCreateLogin.Text)>0)
            {
                MessageBox.Show("User with that login already exist", "Warning", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            try
            {
                Authors userObj = new Authors
                {
                    AuthorName = authorName,
                    Login = login,
                    Password = password,
                    Birthday = dateOfBiirth.Value,
                    WorkExpirience = exp,
                    Email = email,
                    PhoneNum = phoneNum
                };
                AppConnect.Model.Authors.Add(userObj);
                AppConnect.Model.SaveChanges();
                MessageBox.Show("Data added, all okey", "Information", MessageBoxButton.OK, MessageBoxImage.Information );
                tbName.Clear();
                tbCreateLogin.Clear();
                psbCreatePassword.Clear();
                psbPasswordAgain.Clear();
                dpBirthday.SelectedDate = null;
                tbWorkExp.Clear();
                tbEmail.Clear();
                tbPhoneNum.Clear();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Program RIP, try later " + ex.Message, "RIP", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btGoBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Authorization());
        }
    }
}
