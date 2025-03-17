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
    /// Логика взаимодействия для StudentDeletePage.xaml
    /// </summary>
    public partial class StudentDeletePage : Page
    {
        List<Student> student = App.context.Student.ToList();
        public StudentDeletePage()
        {
            InitializeComponent();

            StudentDG.ItemsSource = App.context.Student.ToList();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.mainFrame.Navigate(new MainMenuTeacherPage());
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            var selectedStudent = (Student)StudentDG.SelectedItem;

            if (selectedStudent != null)
            {
                var result = MessageBox.Show("Вы уверены, что хотите удалить студента?", "Подтверждение удаления", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    // // Удаление связанных записей из Group
                    var relatedGroups = App.context.Group.Where(gr => gr.ID == selectedStudent.ID).ToList();
                    foreach (var group in relatedGroups)
                    {
                        App.context.Group.Remove(group);
                    }

                    // Удаление связанных записей из Journal
                    var relatedJournal = App.context.Journal.Where(j => j.ID == selectedStudent.ID).ToList();
                    foreach (var journal in relatedJournal)
                    {
                        App.context.Journal.Remove(journal);
                    }

                    // Теперь можно удалить книгу
                    App.context.Student.Remove(selectedStudent);
                    App.context.SaveChanges();

                    // Обновляем список отображаемых книг
                    StudentDG.ItemsSource = App.context.Student.ToList();
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите студента для удаления.");
            }
        }
    }
}
