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

namespace Exam_Ermoshin.PagesProgram
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            var user = App.DB.User.FirstOrDefault(x => x.Login == TBLogin.Text && x.Password == TBPassword.Text && x.Name ==TBSekret.Text);
            if(user == null)
            {
                MessageBox.Show("Пароль или логин не верный");
            }
            else
            {
                MessageBox.Show("Вы успешно авторизировались");
            }

            if(user.RoleId == 1)
            {
                NavigationService.Navigate(new RabotnikPage());
            }
            if(user.RoleId == 2)
            {
                NavigationService.Navigate(new ZakazkhikMenuPage());
            }
            if(user.RoleId == 3)
            {
                NavigationService.Navigate(new AdminMenuPage());
            }
        }
    }
}
