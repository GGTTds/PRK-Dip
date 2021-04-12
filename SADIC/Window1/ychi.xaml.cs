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
    /// Логика взаимодействия для ychi.xaml
    /// </summary>
    public partial class ychi : Window
    {
        public ychi()
        {
            InitializeComponent();
            DataTour.ItemsSource = EWnter.Qwer().Tich.ToList();
            if (int.Parse(Static.Rol) == 1)
            {
                Bis();
            }
            else
            {
                DataTour.Columns[7].Visibility = Visibility.Visible;
                DataTour.Columns[8].Visibility = Visibility.Visible;
            }
        }

        private void toFio_TextChanged(object sender, TextChangedEventArgs e)
        {
            var s = EWnter.Qwer().Tich.ToList();
            if (toFio.Text.Length != 0)
            {
                s = s.Where(p => p.FIOTic.ToLower().Contains(toFio.Text.ToLower())).ToList();
               
            }
            else { EWnter.Qwer().Tich.ToList(); }
            DataTour.ItemsSource = s;
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            EWnter.Qwer().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            EWnter.Qwer().Tich.ToList();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            ADDTich ww = new ADDTich((sender as Button).DataContext as Tich, 1);
            ww.Show();
        }

        private void del_Click(object sender, RoutedEventArgs e)
        {
            var DEle =
          DataTour.SelectedItems.Cast<Tich>().ToList();
            var countRow = DEle.Count();
            var res = MessageBox.Show($"Вы точно хотите удалить {countRow} записей?",
           "Внимание!",
            MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (res == MessageBoxResult.Yes)
            {
                try //команды могут выдавать ошибку, поэтому используем try catch
                {
                    EWnter.Qwer().Tich.RemoveRange(DEle);
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
            ADDTich ww = new ADDTich((sender as Button).DataContext as Tich, 1);
            ww.Show();
        }
        public void Bis()
        {
            DataTour.Columns[0].Visibility = Visibility.Hidden;
            add.Visibility = Visibility.Hidden;
            del.Visibility = Visibility.Hidden;
        }
    }
}
