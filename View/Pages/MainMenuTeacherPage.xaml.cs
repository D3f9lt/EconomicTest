using EconomicTest.AppData;
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
    /// Логика взаимодействия для MainMenuTeacherPage.xaml
    /// </summary>
    public partial class MainMenuTeacherPage : Page
    {
        public MainMenuTeacherPage()
        {
            InitializeComponent();
        }

        private void AddStudent_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.mainFrame.Navigate(new AddStudentPage());
        }

        private void AddGroup_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.mainFrame.Navigate(new AddGroupPage());
        }

        private void ListStudent_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.mainFrame.Navigate(new StudentListPage());
        }

        private void DeleteStudent_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.mainFrame.Navigate(new StudentDeletePage());
        }

        private void Out_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.mainFrame.Navigate(new MainMenuTeacherPage());
        }
    }
}
