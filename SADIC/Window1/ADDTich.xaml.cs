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
    /// Логика взаимодействия для ADDTich.xaml
    /// </summary>
    public partial class ADDTich : Window
    {
        private Tich _currentPost = new Tich();
        private int num = 0;
        public ADDTich(Tich Se2Wq, int k)
        {
            InitializeComponent();
            gr.ItemsSource = EWnter.Qwer().Group.ToList();
            mer.ItemsSource = EWnter.Qwer().Event.ToList();
            za.ItemsSource = EWnter.Qwer().Zanztia.ToList();
            re.ItemsSource = EWnter.Qwer().Roul.ToList();
            if (Se2Wq != null)
            {
                _currentPost = Se2Wq;
                num = k;
            }
            DataContext = _currentPost;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                StringBuilder Error = new StringBuilder();
                if (ff.Text.Length == 0)
                    Error.Append("Введите ФИО \n");
                if (tt.Text.Length == 0)
                    Error.Append("Введите телефон \n");
                if (gr.Text.Length == 0)
                    Error.Append("Выберите группу \n");
                if (ll.Text.Length == 0)
                    Error.Append("Введите логин \n");
                if (pp.Text.Length == 0)
                    Error.Append("Введите пароль \n");
                if (Error.Length == 0)
                {
                    if (num == 0)
                        EWnter.Qwer().Tich.Add(_currentPost);
                    EWnter.Qwer().SaveChanges();
                    MessageBox.Show("Запись сохранена!");
                    Close();
                }
                else { MessageBox.Show(Error.ToString()); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString()," Ошибка ");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
       
    }
}
