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
    /// Логика взаимодействия для ToMENU.xaml
    /// </summary>
    public partial class ToMENU : Window
    {
        public ToMENU()
        {
            InitializeComponent();
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
           if( e.Key == Key.Enter)
            {
                if (ps1.Password == "123456")
                {
                    Rigist ww = new Rigist();
                    ww.Show();
                    if (e.Key == Key.Escape)
                    {

                        this.Close();

                    }
                }
            }
            if (e.Key == Key.Escape)
            {
                
                    this.Close();
                
            }
        }

        private void Nex_Click(object sender, RoutedEventArgs e)
        {
            if (ps1.Password == "123456")
            {
                Rigist ww = new Rigist();
                ww.Show();
                this.Close();
            }
        }

        private void Nex_Copy_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
