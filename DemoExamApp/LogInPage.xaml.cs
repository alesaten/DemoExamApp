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

namespace DemoExamApp
{
    /// <summary>
    /// Логика взаимодействия для LogInPage.xaml
    /// </summary>
    public partial class LogInPage : Page
    {
        public LogInPage()
        {
            InitializeComponent();
        }

        private void LogInButton_Click(object sender, RoutedEventArgs e)
        {
            ActionsPage ActPage = new ActionsPage();
            NavigationService.Navigate(ActPage);
        }

        private void SignInButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ShowPassword_button_Click(object sender, RoutedEventArgs e)
        {
            if (Password_textBox.Visibility == Visibility.Hidden)
            {
                ShowPassword_button.Content = "Скрыть";
                Password_textBox.Text = Password_passwordBox.Password.ToString();
                Password_textBox.Visibility = Visibility.Visible;
                Password_passwordBox.Visibility = Visibility.Hidden;
            }
            else
            {
                ShowPassword_button.Content = "Показать";
                Password_passwordBox.Password = Password_textBox.Text.ToString();
                Password_textBox.Visibility = Visibility.Hidden;
                Password_passwordBox.Visibility = Visibility.Visible;
            }
        }
    }
}
