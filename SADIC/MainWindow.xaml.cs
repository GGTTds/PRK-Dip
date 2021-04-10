using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SADIC
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void VX_Click(object sender, RoutedEventArgs e)
        {
            NextMen ww = new NextMen()
                ; ww.Show(); this.Close();
        }

        private void RG_Click(object sender, RoutedEventArgs e)
        {
            Rigist ww = new Rigist()
               ; ww.Show(); 
        }
    }
}
