using EconomicTest.AppData;
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
    /// Логика взаимодействия для AddStudentPage.xaml
    /// </summary>
    public partial class AddStudentPage : Page
    {
        public AddStudentPage()
        {
            InitializeComponent();

            GroupCMB.SelectedValuePath = "ID";
            GroupCMB.DisplayMemberPath = "Name";
            GroupCMB.ItemsSource = App.context.Group.ToList();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrWhiteSpace(FioTB.Text))
            {
                mes += "Введите ФИО\n";
            }
            if (string.IsNullOrWhiteSpace(GroupCMB.Text))
            {
                mes += "Выберите группу\n";
            }
            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }

            Group selectedGroup = GroupCMB.SelectedItem as Group;
            if (selectedGroup == null)
            {
                MessageBox.Show("Ошибка выбора группы");
                return;
            }

            Student student = new Student()
            {
                Name = FioTB.Text,
                IdGroup = selectedGroup.ID
            };
            App.context.Student.Add(student);
            App.context.SaveChanges();
            MessageBox.Show("Студент добавлен");

            FioTB.Text = "";
            GroupCMB.Text = "";
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.mainFrame.Navigate(new MainMenuTeacherPage());
        }
    }
}
