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
    /// Логика взаимодействия для StudentListPage.xaml
    /// </summary>
    public partial class StudentListPage : Page
    {
        public StudentListPage()
        {
            InitializeComponent();

            GroupCMB.SelectedValuePath = "ID";
            GroupCMB.DisplayMemberPath = "Name";
            GroupCMB.ItemsSource = App.context.Group.ToList();

            StudentCMB.SelectedValuePath = "ID";
            StudentCMB.DisplayMemberPath = "Name";
            StudentCMB.ItemsSource = App.context.Student.ToList();
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.mainFrame.Navigate(new MainMenuTeacherPage());
        }

        private void PrintBTN_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();

            if (printDialog.ShowDialog() == true)
            {
                printDialog.PrintVisual(StudentList, "Оценки");
            }
        }

        private void StudentList_Loaded(object sender, RoutedEventArgs e)
        {
            StudentList.ItemsSource = App.context.Journal.ToList();
        }

        private void StudentCMB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void GroupCMB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
