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
    /// Логика взаимодействия для TeacherSignInPage.xaml
    /// </summary>
    public partial class TeacherSignInPage : Page
    {
        private const string Password = "123";
        public TeacherSignInPage()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            if (PasswordTeacherPB.Password == Password)
            {
                MessageBox.Show("Пароль верный. Добро пожаловать!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                ClassFrame.mainFrame.Navigate(new MainMenuTeacherPage());
            }
            else
            {
                MessageBox.Show("Неверный пароль! Попробуй снова.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                ClassFrame.mainFrame.Navigate(new MainMenuPage());
            }
            
        }
    }
}
