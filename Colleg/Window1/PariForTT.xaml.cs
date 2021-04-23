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
    /// Логика взаимодействия для PariForTT.xaml
    /// </summary>
    public partial class PariForTT : Window
    {
        public PariForTT()
        {
            InitializeComponent();
            WhoTic();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            ADDParTic ww = new ADDParTic((sender as Button).DataContext as Zanat, 1);
            ww.Show();
        }

        private void del_Click(object sender, RoutedEventArgs e)
        {
            var DEle =
         DataTour.SelectedItems.Cast<Zanat>().ToList();
            var countRow = DEle.Count();
            var res = MessageBox.Show($"Вы точно хотите удалить {countRow} записей?",
           "Внимание!",
            MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (res == MessageBoxResult.Yes)
            {
                try //команды могут выдавать ошибку, поэтому используем try catch
                {
                    EWnter.Qwer().Zanat.RemoveRange(DEle);
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
            ADDParTic ww = new ADDParTic((sender as Button).DataContext as Zanat, 1);
            ww.Show();
        }

        public void WhoTic()
        {
            var a = EWnter.Qwer().Zanat.ToList();
            var g = a.Where(p => p.NomerUch.Equals(Static.IDTic));
            DataTour.ItemsSource = g.ToList();
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            EWnter.Qwer().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            WhoTic();
        }
    }
}
