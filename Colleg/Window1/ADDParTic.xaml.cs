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
    /// Логика взаимодействия для ADDParTic.xaml
    /// </summary>
    public partial class ADDParTic : Window
    {
        private Zanat _currentZan = new Zanat();
        public int ss = 0;
        public ADDParTic(Zanat r, int k)
        {
            InitializeComponent();
            if(r != null)
            {
                _currentZan = r;
                ss = k;
            }
            DataContext = _currentZan;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _currentZan.DenNed = wwd.Text;
                _currentZan.NomerUch = Static.IDTic;
                if (ss == 0)
                {
                    EWnter.Qwer().Zanat.Add(_currentZan);
                }
                EWnter.Qwer().SaveChanges();
                MessageBox.Show(" Запись сохранена");
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
