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
    /// Логика взаимодействия для PariForTT.xaml
    /// </summary>
    public partial class PariForTT : Window
    {
        public PariForTT()
        {
            InitializeComponent();
            WhoTic();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {

        }

        private void del_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        public void WhoTic()
        {
            var a = EWnter.Qwer().Zanat.ToList();
            var g = a.Where(p => p.NomerUch.Equals(Static.IDTic));
            DataTour.ItemsSource = g.ToList();
        }
    }
}
