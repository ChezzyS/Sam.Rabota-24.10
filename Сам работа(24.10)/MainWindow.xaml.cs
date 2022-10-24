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

namespace Сам_работа_24._10_
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int _index = 0;
        private List<Page> _pages = new List<Page>()
        {
            new Работы.Converter(),
            new Работы.DataContext(),
            new Работы.Delay(),
            new Работы.ElementName(),
            new Работы.FallBackValue(),
            new Работы.IsAsync(),
            new Работы.Mode(),
            new Работы.Path(),
            new Работы.Source(),
            new Работы.StringFormat(),
            new Работы.TargetNullValue(),
            new Работы.UpdateSourceTrigger()
        };
        public MainWindow()
        {
            InitializeComponent();
            PageViewer.Content = _pages[_index];
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            _index++;
            _index = _index >= _pages.Count ? 0 : _index;
            PageViewer.Content = _pages[_index];
        }

        private void Prev_Click(object sender, RoutedEventArgs e)
        {
            _index--;
            _index = _index < 0 ? _pages.Count - 1 : _index;
            PageViewer.Content = _pages[_index];
        }
    }

   
}
