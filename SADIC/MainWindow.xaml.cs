using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SADIC
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void VX_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                System.Data.Entity.Core.Objects.ObjectParameter VX;
                VX = new System.Data.Entity.Core.Objects.ObjectParameter("Vix", typeof(int));
                var w = EWnter.Qwer().Vxod(loggg.Text, passs.Password, VX);
                if (int.Parse(VX.Value.ToString()) == 1)
                {
                    System.Data.Entity.Core.Objects.ObjectParameter VX1;
                    VX1 = new System.Data.Entity.Core.Objects.ObjectParameter("Ima", typeof(string));
                    var s = EWnter.Qwer().FIO(loggg.Text, VX1);
                    Static.Name = VX1.Value.ToString();
                    System.Data.Entity.Core.Objects.ObjectParameter VX2;
                    VX2 = new System.Data.Entity.Core.Objects.ObjectParameter("V", typeof(int));
                    var g = EWnter.Qwer().Rol(loggg.Text, VX2);
                    Static.Rol = VX2.Value.ToString();

                    NextMen ww = new NextMen()
                        ; ww.Show(); this.Close();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль", "Ошибка");
                }
            }
            catch { }
        }

        private void RG_Click(object sender, RoutedEventArgs e)
        {
            ToMENU ww = new ToMENU();
            ww.Show();
        }

        private void RG_Copy_Click(object sender, RoutedEventArgs e)
        {
            Static.Rol = "1";
            NextMen ww = new NextMen()
                       ; ww.Show(); this.Close();
        }
    }
}
