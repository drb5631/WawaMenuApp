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
        public HotSandwiches()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void SecondBreakfastBackBtn_Click(object sender, RoutedEventArgs e)
        {
            LunchandDinner bf = new LunchandDinner();
            bf.Show();
            this.Close();
        }

        private void flatbread_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Out of Stock!");
        }

        private void chickensandwiches_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Out of Stock!");
        }

        private void meatballsub_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Out of Stock!");
        }
    }
}
