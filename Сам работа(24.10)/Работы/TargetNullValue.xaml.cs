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
    /// Логика взаимодействия для TargetNullValue.xaml
    /// </summary>
    public partial class TargetNullValue : Page
    {
        public TargetNullValue()
        {
            InitializeComponent();
        }

        private void Value_MyText_Click(object sender, RoutedEventArgs e)
        {
            TargetLabel.DataContext = "Мой текст";
        }

        private void Value_Null_Click(object sender, RoutedEventArgs e)
        {
            TargetLabel.DataContext = null;
        }

        private void Value_123_Click(object sender, RoutedEventArgs e)
        {
            TargetLabel.DataContext = 505;
        }
    }
}
