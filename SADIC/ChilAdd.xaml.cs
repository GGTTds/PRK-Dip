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
    /// Логика взаимодействия для ChilAdd.xaml
    /// </summary>
    public partial class ChilAdd : Window
    {
        private Child _currentPost = new Child();
        private int num = 0;
        public ChilAdd(Child Se2Wq, int k)
        {
            InitializeComponent();
            ew.Text = DateTime.Now.ToString();
            wq1_Copy.ItemsSource = EWnter.Qwer().Group.ToList();
            wq.ItemsSource = EWnter.Qwer().Zanztia.ToList();
            wq1.ItemsSource = EWnter.Qwer().Event.ToList();
            wq3.ItemsSource = EWnter.Qwer().Parents.ToList();
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
                    EWnter.Qwer().Child.Add(_currentPost);
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
