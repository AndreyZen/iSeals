﻿using Design.Classes;
using Design.Pages;
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

namespace Design.UserControls
{
    /// <summary>
    /// Interaction logic for SearchResponse.xaml
    /// </summary>
    public partial class SearchResponse : UserControl
    {
        public SearchResponse(List<Supplier> suppliers)
        {
            InitializeComponent();
            LvItems.ItemsSource = suppliers;
        }
        private void Lv_Selected(object sender, RoutedEventArgs e)
        {
            var sup = LvItems.SelectedItem as Supplier;
            if (sup != null)
                AppData.MainFrame.Navigate(new DetailPage(sup));
            LvItems.SelectedItem = null;
        }
    }
}
