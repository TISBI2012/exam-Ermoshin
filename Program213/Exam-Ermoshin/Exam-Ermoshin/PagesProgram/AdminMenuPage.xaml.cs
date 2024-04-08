﻿using System;
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
    /// Логика взаимодействия для AdminMenuPage.xaml
    /// </summary>
    public partial class AdminMenuPage : Page
    {
        public AdminMenuPage()
        {
            InitializeComponent();
        }

        private void BtnAddSotrudnik_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddSotrudnikPage(new Models.Rabotniki()));
        }

        private void BtnDeleteSotrudnik_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void RedaktirovanieSotrudnik_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
