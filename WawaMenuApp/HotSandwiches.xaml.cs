﻿using System;
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
using System.Windows.Shapes;

namespace WawaMenuApp
{
    /// <summary>
    /// Interaction logic for SecondLunchandDinner.xaml
    /// </summary>
    public partial class HotSandwiches : Window
    {
        public object NavigationService { get; private set; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void hotSandwichesBackBtn_Click(object sender, RoutedEventArgs e)
        {
            App.Current.MainWindow.Show();
        }

        private void Chickensandwiches_Click(object sender, RoutedEventArgs e)
        {
            orderBox.Items.Add("Chicken Sandwich    $2.26");
        }

        private void Meatballsub_Click(object sender, RoutedEventArgs e)
        {
            orderBox.Items.Add("Meatball Sandwich    $2.26");
        }

        private void Flatbreads_Click(object sender, RoutedEventArgs e)
        {
            orderBox.Items.Add("Flatbread    $2.26");
        }
    }
}
