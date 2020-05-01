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
using System.Windows.Shapes;

namespace WawaMenuApp
{
    /// <summary>
    /// Interaction logic for BreakfastWindow.xaml
    /// </summary>
    public partial class BreakfastWindow : Window
    {
        //SecondBreafastWindow sbw = new SecondBreafastWindow();

        public BreakfastWindow()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            
            App.Current.MainWindow.Show();
            this.Hide();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
      
        }

        private void SandwichesClick_Click(object sender, RoutedEventArgs e)
        {
            //sbw.Show();
            this.Hide();
        }

        private void ClearOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            orderBox.Items.Clear();
        }

        private void OrderBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
