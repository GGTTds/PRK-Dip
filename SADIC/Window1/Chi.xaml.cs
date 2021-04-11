using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SADIC
{
    /// <summary>
    /// Логика взаимодействия для Chi.xaml
    /// </summary>
    public partial class Chi : Window
    {
        public Chi()
        {
            InitializeComponent();
            DataTour.ItemsSource = EWnter.Qwer().Child.ToList();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            ChilAdd Win = new ChilAdd((sender as Button).DataContext as Child, 1);
            Win.Show();
        }
        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            ChilAdd DDW = new ChilAdd((sender as Button).DataContext as Child, 1);
            DDW.Show();
        }

        private void del_Click(object sender, RoutedEventArgs e)
        {
            var DEle =
           DataTour.SelectedItems.Cast<Child>().ToList();
            var countRow = DEle.Count();
            var res = MessageBox.Show($"Вы точно хотите удалить {countRow} записей?",
           "Внимание!",
            MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (res == MessageBoxResult.Yes)
            {
                try //команды могут выдавать ошибку, поэтому используем try catch
                {
                    EWnter.Qwer().Child.RemoveRange(DEle);
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

        private void toFio_TextChanged(object sender, TextChangedEventArgs e)
        {
            var ss = EWnter.Qwer().Child.ToList();
            if(toFio.Text.Length !=0)
            {
                ss = ss.Where(p => p.FIO.ToLower().Contains(toFio.Text.ToLower().ToString())).ToList();
            }
            else
            { DataTour.ItemsSource = EWnter.Qwer().Child.ToList(); }
            DataTour.ItemsSource = ss;
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            EWnter.Qwer().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            DataTour.ItemsSource = EWnter.Qwer().Child.ToList();
        }
    }
}
