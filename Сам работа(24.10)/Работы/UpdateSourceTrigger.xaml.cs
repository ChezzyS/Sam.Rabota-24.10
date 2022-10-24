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
    /// Логика взаимодействия для UpdateSourceTrigger.xaml
    /// </summary>
    public partial class UpdateSourceTrigger : Page
    {
        public UpdateSourceTrigger()
        {
            InitializeComponent();
        }

        private void Update_Clicked(object sender, RoutedEventArgs e)
        {
            BindingExpression expression = Target3.GetBindingExpression(TextBox.TextProperty);
            expression.UpdateSource();
        }
    }
}
