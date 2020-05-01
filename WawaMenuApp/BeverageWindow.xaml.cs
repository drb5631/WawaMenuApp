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

namespace WawaMenuApp
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class BeverageWindow : Window
    {
        public BeverageWindow()
        {
            InitializeComponent();
            var w = Application.Current.MainWindow;
        }
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            App.Current.MainWindow.Show();
            this.Hide();
           
        }
        private void ClearOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            orderBox.Items.Clear();
        }
        
        private void ColdbrewButton(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).orderBox.Items.Add("Cold Brew/Iced Coffee    $2.26");
            ((BreakfastWindow)Application.Current.Windows[1]).orderBox.Items.Add("Cold Brew/Iced Coffee    $2.26");
            ((LunchandDinner)Application.Current.Windows[2]).orderBox.Items.Add("Cold Brew/Iced Coffee    $2.26");
            ((BeverageWindow)Application.Current.Windows[3]).orderBox.Items.Add("Cold Brew/Iced Coffee    $2.26");
        }

        private void Fruitsmoothie_Click(object sender, RoutedEventArgs e)
        {

            orderBox.Items.Add("Fruit Smoothies               $4.53");
        }
        private void Chaitea_Click(object sender, RoutedEventArgs e)
        {

            orderBox.Items.Add("Chai Tea                           $3.79");
        }

        private void Lattes_Click(object sender, RoutedEventArgs e)
        {

            orderBox.Items.Add("Lattes                               $3.69");
        }
    }
}
