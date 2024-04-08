using Exam_Ermoshin.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Exam_Ermoshin
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static EtoKonechErmoshinEntities DB = new EtoKonechErmoshinEntities(); 
    }
}
