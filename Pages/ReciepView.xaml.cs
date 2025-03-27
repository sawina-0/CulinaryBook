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
        private List<Recipes> allRecipes;
        public ReciepView()
        {
            InitializeComponent();
            //ComboFilter.ItemsSource = AppConnect.Model.Categories;
            //ListProducts.ItemsSource = AppConnect.Model.Recipes.ToList();
            allRecipes = AppConnect.Model.Recipes.ToList();
            ListProducts.ItemsSource = allRecipes;

        }

        private void ComboFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboSort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(ComboSort.SelectedItem is ComboBoxItem selectedItem)
            {
                string sortBy = selectedItem.Content.ToString();
                List<Recipes> sortedResipes;
                switch(sortBy)
                {
                    case "Sort by name":
                        sortedResipes = allRecipes.OrderBy(recipe => recipe.RecipeName).ToList();
                        break;
                    case "Sort by time":
                        sortedResipes = allRecipes.OrderBy(recipe => recipe.CookingTime).ToList();
                        break;
                    default:
                        sortedResipes = allRecipes;
                        break;
                }
                ListProducts.ItemsSource = sortedResipes;
            }
        }

        private void TextSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchText = TextSearch.Text.ToLower();
            var filteredRecipes = allRecipes.Where(recipe => recipe.RecipeName.ToLower().Contains(searchText)).ToList();
            ListProducts.ItemsSource = filteredRecipes;
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

        private void btAdd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddRecipe());
        }
    }
}
