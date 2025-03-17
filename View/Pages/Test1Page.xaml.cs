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

namespace EconomicTest.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для Test1Page.xaml
    /// </summary>
    public partial class Test1Page : Page
    {
        int b = 0;
        int c = 0;
        public Test1Page()
        {
            InitializeComponent();
        }

        private void p1_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox1.Text == "5")
            {
                MessageBox.Show("Правильно");
                b = b + 1;
            }
            else
            {
                MessageBox.Show("Неправильно");
                p1.Visibility = Visibility.Collapsed;
                products.SelectedItem = v2;
            }
        }

        private void p2_Click(object sender, RoutedEventArgs e)
        {
            if (RB2.IsChecked == true)
            {
                MessageBox.Show("Правильно");
                b = b + 1;
            }
            else
            {
                MessageBox.Show("Неправильно");
                p2.Visibility = Visibility.Collapsed;
                products.SelectedItem = v3;
            }
        }

        private void p3_Click(object sender, RoutedEventArgs e)
        {
            if (CHB1.IsChecked == false && CHB2.IsChecked == false && CHB3.IsChecked == false && CHB4.IsChecked == false && CHB5.IsChecked == true)
            {
                MessageBox.Show("Правильно");
                b = b + 1;
            }
            else
            {
                MessageBox.Show("Неправильно");
                p3.Visibility = Visibility.Collapsed;
                products.SelectedItem = v4;
            }
        }

        private void p4_Click(object sender, RoutedEventArgs e)
        {

        }

        private void p5_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
