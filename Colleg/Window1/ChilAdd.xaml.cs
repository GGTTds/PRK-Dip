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
            wqw.SelectedDate = _currentPost.DataBir;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

          
            try
            {
                _currentPost.DataBir = wqw.SelectedDate;
                _currentPost.budjet = form.Text;
                _currentPost.Jelih = mest.Text.ToString();
                _currentPost.Propis = pro.Text.ToString();
                StringBuilder Error = new StringBuilder();
                if (im.Text.Length == 0)
                    Error.Append("Введите ФИО ребенка \n");
                if (wq3.Text.Length == 0)
                    Error.Append("Выберите родителей из списка \n");
                if (wq1_Copy.Text.Length == 0)
                    Error.Append("Выберите группу \n");
                if (wqw.Text.Length == 0)
                    Error.Append("Выберите дату рождения \n");
                if (ade.Text.Length == 0)
                    Error.Append("Введите адрес проживания ребенка \n");
                if (Error.Length == 0)
                {
                   
                    if (num == 0)
                        EWnter.Qwer().Child.Add(_currentPost);
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
