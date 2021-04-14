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
    /// Логика взаимодействия для Gru.xaml
    /// </summary>
    public partial class Gru : Window
    {
        public Gru()
        {
            InitializeComponent();
            DataTour.ItemsSource = EWnter.Qwer().Group.ToList();
            if (int.Parse(Static.Rol) == 1)
            {
                Bis();
            }
           
        }
        public void Bis()
        {
            DataTour.Columns[0].Visibility = Visibility.Hidden;
            add.Visibility = Visibility.Hidden;
            del.Visibility = Visibility.Hidden;
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            adGrup Win = new adGrup((sender as Button).DataContext as Group, 1);
            Win.Show();
        }

        private void del_Click(object sender, RoutedEventArgs e)
        {
            var DEle =
         DataTour.SelectedItems.Cast<Group>().ToList();
            var countRow = DEle.Count();
            var res = MessageBox.Show($"Вы точно хотите удалить {countRow} записей?",
           "Внимание!",
            MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (res == MessageBoxResult.Yes)
            {
                try //команды могут выдавать ошибку, поэтому используем try catch
                {
                    EWnter.Qwer().Group.RemoveRange(DEle);
                    //БД обновляем
                    EWnter.Qwer().SaveChanges();
                    MessageBox.Show("Записи удалены!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            adGrup Win = new adGrup((sender as Button).DataContext as Group, 1);
            Win.Show();
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            EWnter.Qwer().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            DataTour.ItemsSource = EWnter.Qwer().Group.ToList();
        }
    }
}
