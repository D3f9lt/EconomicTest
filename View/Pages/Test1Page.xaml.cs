using EconomicTest.Model;
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
            if (TextBox2.Text == "3")
            {
                MessageBox.Show("Правильно");
                b = b + 1;
            }
            else
            {
                MessageBox.Show("Неправильно");
                p4.Visibility = Visibility.Collapsed;
                products.SelectedItem = v5;
            }
        }

        private void p5_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox3.Text == "2")
            {
                MessageBox.Show("Правильно");
                b = b + 1;
            }
            else
            {
                MessageBox.Show("Неправильно");
                p5.Visibility = Visibility.Collapsed;
                products.SelectedItem = v6;
            }
        }

        private void p6_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox4.Text == "4")
            {
                MessageBox.Show("Правильно");
                b = b + 1;
            }
            else
            {
                MessageBox.Show("Неправильно");
                p6.Visibility = Visibility.Collapsed;
                products.SelectedItem = v7;
            }
        }

        private void p7_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox5.Text == "1")
            {
                MessageBox.Show("Правильно");
                b = b + 1;
            }
            else
            {
                MessageBox.Show("Неправильно");
                p7.Visibility = Visibility.Collapsed;
                products.SelectedItem = v8;
            }
        }

        private void p8_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox6.Text == "2")
            {
                MessageBox.Show("Правильно");
                b = b + 1;
            }
            else
            {
                MessageBox.Show("Неправильно");
                p8.Visibility = Visibility.Collapsed;
                products.SelectedItem = v9;
            }
        }

        private void p9_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox7.Text == "3")
            {
                MessageBox.Show("Правильно");
                b = b + 1;
            }
            else
            {
                MessageBox.Show("Неправильно");
                p9.Visibility = Visibility.Collapsed;
                products.SelectedItem = v10;
            }
        }

        private void p10_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox8.Text == "2")
            {
                MessageBox.Show("Правильно");
                b = b + 1;
            }
            else
            {
                MessageBox.Show("Неправильно");
                p10.Visibility = Visibility.Collapsed;
                products.SelectedItem = v11;
            }
        }

        private void p11_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox9.Text == "4")
            {
                MessageBox.Show("Правильно");
                b = b + 1;
            }
            else
            {
                MessageBox.Show("Неправильно");
                p11.Visibility = Visibility.Collapsed;
                products.SelectedItem = v12;
            }
        }

        private void p12_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox10.Text == "1")
            {
                MessageBox.Show("Правильно");
                b = b + 1;
            }
            else
            {
                MessageBox.Show("Неправильно");
                p12.Visibility = Visibility.Collapsed;
                products.SelectedItem = v13;
            }
        }

        private void p13_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox9.Text == "1")
            {
                MessageBox.Show("Правильно");
                b = b + 1;
            }
            else
            {
                MessageBox.Show("Неправильно");
                p13.Visibility = Visibility.Collapsed;
                products.SelectedItem = v14;
            }
        }

        private void p14_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox10.Text == "2")
            {
                MessageBox.Show("Правильно");
                b = b + 1;
            }
            else
            {
                MessageBox.Show("Неправильно");
                p14.Visibility = Visibility.Collapsed;
                products.SelectedItem = v15;
            }
        }

        private void p15_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox11.Text == "1")
            {
                MessageBox.Show("Правильно");
                b = b + 1;
            }
            else
            {
                MessageBox.Show("Неправильно");
                p15.Visibility = Visibility.Collapsed;
                products.SelectedItem = v16;
            }
        }

        private void p16_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox12.Text == "4")
            {
                MessageBox.Show("Правильно");
                b = b + 1;
            }
            else
            {
                MessageBox.Show("Неправильно");
                p16.Visibility = Visibility.Collapsed;
                products.SelectedItem = v17;
            }
        }

        private void p17_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox13.Text == "3")
            {
                MessageBox.Show("Правильно");
                b = b + 1;
            }
            else
            {
                MessageBox.Show("Неправильно");
                p17.Visibility = Visibility.Collapsed;
                products.SelectedItem = v18;
            }
        }

        private void p18_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox14.Text == "1")
            {
                MessageBox.Show("Правильно");
                b = b + 1;
            }
            else
            {
                MessageBox.Show("Неправильно");
                p18.Visibility = Visibility.Collapsed;
                products.SelectedItem = v19;
            }
        }

        private void p19_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox15.Text == "1")
            {
                MessageBox.Show("Правильно");
                b = b + 1;
            }
            else
            {
                MessageBox.Show("Неправильно");
                p19.Visibility = Visibility.Collapsed;
                products.SelectedItem = v20;
            }
        }

        private void p20_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox16.Text == "3")
            {
                MessageBox.Show("Правильно");
                b = b + 1;
            }
            else
            {
                MessageBox.Show("Неправильно");
                p20.Visibility = Visibility.Collapsed;
                products.SelectedItem = v21;
            }
        }

        private void p21_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox17.Text == "4")
            {
                MessageBox.Show("Правильно");
                b = b + 1;
            }
            else
            {
                MessageBox.Show("Неправильно");
                p21.Visibility = Visibility.Collapsed;
                products.SelectedItem = v22;
            }
        }

        private void p22_Click(object sender, RoutedEventArgs e)
        {
            CorrectAnswersCount.Text = b.ToString();
            GradeValue.Text = CalculatGrade(b).ToString();

        }

        private void CalculatGrade()
        {
            int totalQuestions = 21;
            c = (int)Math.Round((double) / totalQuestions * 5);
        }

        private void p23_Click(object sender, RoutedEventArgs e)
        {
            Journal journal = new Journal()
            {
                DateTest = DateTime.Now,
                Mark = 
            }
        }
    }
}
