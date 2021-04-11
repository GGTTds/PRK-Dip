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
    /// Логика взаимодействия для Rigist.xaml
    /// </summary>
    public partial class Rigist : Window
    {
        public Rigist()
        {
            InitializeComponent();
        }

        private void VX_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void RG_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                System.Data.Entity.Core.Objects.ObjectParameter @VX;
                VX = new System.Data.Entity.Core.Objects.ObjectParameter("V", typeof(int));
                var s = EWnter.Qwer().Reg(fio.Text, tell.Text, log.Text, pas.Password, VX);
                if (int.Parse(VX.Value.ToString()) == 1)
                {
                    this.Close();
                    MessageBox.Show(" Вы успешно зарегестрировались", "Уведомление");
                }
                else { MessageBox.Show("Такой логин уже существует", "Ошибка"); }
            }
            catch { }
        }
    }
}
