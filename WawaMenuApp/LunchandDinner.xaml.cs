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
    /// Interaction logic for LunchandDinner.xaml
    /// </summary>
    public partial class LunchandDinner : Window
    {
        //HotSandwiches hs = new HotSandwiches();

        public LunchandDinner()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            App.Current.MainWindow.Show();
            this.Hide();
        }

        private void HotSandwiches_Click(object sender, RoutedEventArgs e) 
        {
            //hs.Show();
            this.Hide();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void ClearOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            orderBox.Items.Clear();
        }
    }
}
