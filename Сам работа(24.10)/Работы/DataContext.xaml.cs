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

namespace Сам_работа_24._10_.Работы
{
    /// <summary>
    /// Логика взаимодействия для DataContext.xaml
    /// </summary>
    public partial class DataContext : Page
    {
        private Random _random = new Random();
        public DataContext()
        {
            InitializeComponent();
        }

        private void Rnd_Click(object sender, RoutedEventArgs e)
        {
            Data data = new Data() { RandomValue = _random.Next(1000000) };
            DataContext = data;
        }
        class Data
        {
            public int RandomValue { get; set; }
        }
    }
}
