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
    /// Interaction logic for SecondLunchandDinner.xaml
    /// </summary>
    public partial class HotSandwiches : Window
    {
        public HotSandwiches(string[] lstData)
        {
           InitializeComponent();
            int totalItems = lstData.Length;
            for (int i = 0; i < totalItems; i++)
            {
                orderBox.Items.Add(lstData[i]);
            }
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void hotSandwichesBackBtn_Click(object sender, RoutedEventArgs e)
        {
            LunchandDinner bf = new LunchandDinner();
            bf.Show();
            this.Close();
        }

        private void Chickensandwiches_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Out of Stock!");
        }

        private void Meatballsub_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Out of Stock!");
        }

        private void Flatbreads_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Out of Stock!");
        }
    }
}
