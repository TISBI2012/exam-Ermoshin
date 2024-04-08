using Exam_Ermoshin.Models;
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
    /// Логика взаимодействия для AddSotrudnikPage.xaml
    /// </summary>
    public partial class AddSotrudnikPage : Page
    {
        Rabotniki contextRabotniki;
        public AddSotrudnikPage(Rabotniki rabotniki)
        {
            InitializeComponent();
            CBDeatelnost.ItemsSource = App.DB.Role.ToList();
            contextRabotniki = rabotniki;
            DataContext = contextRabotniki;
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if(contextRabotniki.id == 0)
            {
                App.DB.Rabotniki.Add(contextRabotniki);
                //App.DB.Role.Add(contextRabotniki);
                App.DB.SaveChanges();
                NavigationService.GoBack();
            }
        }
    }
}
