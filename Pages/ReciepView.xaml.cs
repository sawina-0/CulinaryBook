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
    /// Логика взаимодействия для ReciepView.xaml
    /// </summary>
    public partial class ReciepView : Page
    {
        public ReciepView()
        {
            InitializeComponent();
            //ComboFilter.ItemsSource = AppConnect.Model.Categories;
            ListProducts.ItemsSource = AppConnect.Model.Recipes.ToList();
        }

        private void ComboFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboSort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextSearch_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btChangeRecipe_Click(object sender, RoutedEventArgs e)
        {
            if (ListProducts.SelectedItem is Recipes selectedRecipe)
            {
                NavigationService.Navigate(new AddRecipe(selectedRecipe));
                ListProducts.Items.Refresh();
            }
            else
            {
                MessageBox.Show("Выделите рецепт");
            }
        }
    }
}
