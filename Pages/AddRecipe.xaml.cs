using CulinaryBook.AppFrame;
using Microsoft.Win32;
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
    /// Логика взаимодействия для AddRecipe.xaml
    /// </summary>
    public partial class AddRecipe : Page
    {
        public Recipes recipes = new Recipes();
        public AddRecipe(Recipes recipe)
        {
            InitializeComponent();
            if (recipe != null)
            {
                recipes = recipe;
            }
            var categ = AppConnect.Model.Categories;
            cbCategory.Items.Add("Категория");
            foreach (var category in categ)
            {
                cbCategory.Items.Add(category.CategoryName);
            }

            var author = AppConnect.Model.Authors;
            cbAuthor.Items.Add("Автор");
            foreach (var AName  in author)
            {
                cbAuthor.Items.Add(AName.AuthorName);
            }
            DataContext = recipes;
        }

        private void btSaveRecipe_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                AppConnect.Model.SaveChanges();
                MessageBox.Show("Данные изменены!");
                AppFrame.MainFrame.FrameMain.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Program RIP, try later " + ex.Message, "RIP", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btLoadImage_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var dialog = new OpenFileDialog();
                dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif|All Files|*.*";
                dialog.Title = "Выберите изображение";
                if(dialog.ShowDialog()==true)
                {
                    string photoName = System.IO.Path.GetFileName(dialog.FileName);
                    AppConnect.Model.RecipeImages.Add(new RecipeImages { RecipeID = recipes.RecipeID, ImagePath = photoName }); 
                    //recipes.RecipeImages.Add(photoName;
                    MessageBox.Show("Изображение загружено: " + photoName, "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                    tbRecipeImage.Text = photoName;

                }
                else
                {
                    MessageBox.Show("Picture is not select", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Program RIP, try later " + ex.Message, "RIP", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
