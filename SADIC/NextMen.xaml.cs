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
using System.Windows.Shapes;

namespace SADIC
{
    /// <summary>
    /// Логика взаимодействия для NextMen.xaml
    /// </summary>
    public partial class NextMen : Window
    {
        public NextMen()
        {
            InitializeComponent();
            Im.Content =$" Здравствуйте {Static.Name}";
            data111.Content = $" Сегодня: {DateTime.Now.ToLongDateString()}"; 
            if(int.Parse(Static.Rol) == 1)
            {
                Im.Content = "";
                chiq.Visibility = Visibility.Hidden;
                rod.Visibility = Visibility.Hidden;
            }
        }

        private void chiq_Click(object sender, RoutedEventArgs e)
        {
            Chi ww = new Chi();
            ww.Show();
        }

        private void rod_Click(object sender, RoutedEventArgs e)
        {
            Rod ww = new Rod();
            ww.Show();
        }

        private void grou_Click(object sender, RoutedEventArgs e)
        {
            Gru ww = new Gru();
            ww.Show();
        }

        private void ys_Click(object sender, RoutedEventArgs e)
        {
            ychi ww = new ychi();
            ww.Show();
        }

        private void kry_Click(object sender, RoutedEventArgs e)
        {
            Kruj ww = new Kruj();
            ww.Show();
        }

        private void mer_Click(object sender, RoutedEventArgs e)
        {
            Mero ww = new Mero();
            ww.Show();
        }
    }
}
