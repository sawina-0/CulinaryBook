﻿using CulinaryBook.AppFrame;
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
            DataContext = AppConnect.Model.Recipes;
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
    }
}
