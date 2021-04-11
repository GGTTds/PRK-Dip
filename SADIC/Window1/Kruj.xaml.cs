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
    /// Логика взаимодействия для Kruj.xaml
    /// </summary>
    public partial class Kruj : Window
    {
        public Kruj()
        {
            InitializeComponent();
            DataTour.ItemsSource = EWnter.Qwer().Zanztia.ToList();
        }

        private void del_Click(object sender, RoutedEventArgs e)
        {
            var DEle =
          DataTour.SelectedItems.Cast<Zanztia>().ToList();
            var countRow = DEle.Count();
            var res = MessageBox.Show($"Вы точно хотите удалить {countRow} записей?",
           "Внимание!",
            MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (res == MessageBoxResult.Yes)
            {
                try //команды могут выдавать ошибку, поэтому используем try catch
                {
                    EWnter.Qwer().Zanztia.RemoveRange(DEle);
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

        private void add_Click(object sender, RoutedEventArgs e)
        {
            adZAna Win = new adZAna((sender as Button).DataContext as Zanztia, 1);
            Win.Show();
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            adZAna Win = new adZAna((sender as Button).DataContext as Zanztia, 1);
            Win.Show();
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            DataTour.ItemsSource = EWnter.Qwer().Zanztia.ToList();
        }
    }
}
