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
    /// Логика взаимодействия для ADPred.xaml
    /// </summary>
    public partial class ADPred : Window
    {
        private Parents _currentPost = new Parents();
        private int num = 0;
        public ADPred(Parents Se2Wq, int k)
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
                StringBuilder Error = new StringBuilder();
                if (mat.Text.Length == 0)
                    Error.Append("Введите ФИО матери \n");
                if (mat1.Text.Length == 0)
                    Error.Append("Введите номер телефона матери \n");
                if (Error.Length == 0)
                {
                    if (num == 0)
                        EWnter.Qwer().Parents.Add(_currentPost);
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
