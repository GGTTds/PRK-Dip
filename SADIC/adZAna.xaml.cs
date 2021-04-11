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
    /// Логика взаимодействия для adZAna.xaml
    /// </summary>
    public partial class adZAna : Window
    {
        private Zanztia _currentPost = new Zanztia();
        private int num = 0;
        public adZAna(Zanztia Se2Wq, int k)
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
                if (num == 0)
                    EWnter.Qwer().Zanztia.Add(_currentPost);
                EWnter.Qwer().SaveChanges();
                MessageBox.Show("Запись сохранена!");
                Close();
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
