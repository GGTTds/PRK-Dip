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
    /// Логика взаимодействия для ADEv.xaml
    /// </summary>
    public partial class ADEv : Window
    {
        private Event _currentPost = new Event();
        private int num = 0;
        public ADEv(Event Se2Wq, int k)
        {
            InitializeComponent();
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
                _currentPost.Date = eeq.SelectedDate;
                StringBuilder Error = new StringBuilder();
                if (nn.Text.Length == 0)
                    Error.Append("Введите наименование \n");
                if (eeq.Text.Length == 0)
                    Error.Append("Введите дату \n");
                if (Error.Length == 0)
                {
                    if (num == 0)
                        EWnter.Qwer().Event.Add(_currentPost);
                    EWnter.Qwer().SaveChanges();
                    MessageBox.Show("Запись сохранена!");
                    Close();
                }
                else { MessageBox.Show(Error.ToString()); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
