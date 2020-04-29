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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        BreakfastWindow bw = new BreakfastWindow();
        SecondBreafastWindow sbw = new SecondBreafastWindow();
        LunchandDinner ld = new LunchandDinner();
        BeverageWindow bevW = new BeverageWindow();

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnBreakfast_Click(object sender, RoutedEventArgs e)
        {
            bw.Show();
            this.Hide();
        }

        private void BeverageButton(object sender, RoutedEventArgs e)
        {
            bevW.Show();
            this.Hide();
        }

        private void LunchDinerButton_Click(object sender, RoutedEventArgs e)
        {
            ld.Show();
            this.Hide();
        }

        private void CompleteOrder_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            int orderNumber = random.Next(1, 101);
            MessageBox.Show("Your order is being made. Please pay at the register before picking up. \nThank you for choosing Wawa!\nOrder Number: " + orderNumber);
        }
    }
}
