using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
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
    /// Логика взаимодействия для NextMen.xaml
    /// </summary>
    public partial class NextMen : Window
    {
        public NextMen()
        {
            InitializeComponent();
            Im.Content =$" Здравствуйте {Static.Name}";
            data111.Content = $" Сегодня: {DateTime.Now.ToLongDateString()}";
            if(int.Parse(Static.Rol) == 1)
            {
                Im.Content = "Претствуем Вас студент!";
                chiq.Visibility = Visibility.Hidden;
                rod.Visibility = Visibility.Hidden;
                grou_Copy.Visibility = Visibility.Hidden;
            }
            if (int.Parse(Static.Rol) >= 2)
            {
                Thread fd = new Thread(new ThreadStart(ToMail));
                fd.Start();
               grou_Copy.Visibility = Visibility.Visible;
            }
            Thread.Sleep(10);
            WhoID();
        }

        private void chiq_Click(object sender, RoutedEventArgs e)
        {
            Chi ww = new Chi();
            ww.Show();
        }

        private void rod_Click(object sender, RoutedEventArgs e)
        {
            Rod ww = new Rod();
            ww.Show();
        }

        private void grou_Click(object sender, RoutedEventArgs e)
        {
            Gru ww = new Gru();
            ww.Show();
        }

        private void ys_Click(object sender, RoutedEventArgs e)
        {
            ychi ww = new ychi();
            ww.Show();
        }

        private void kry_Click(object sender, RoutedEventArgs e)
        {
            Kruj ww = new Kruj();
            ww.Show();
        }

        private void mer_Click(object sender, RoutedEventArgs e)
        {
            Mero ww = new Mero();
            ww.Show();
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                MainWindow ww = new MainWindow();
                ww.Show();
                this.Close();
            }
        }
        public void ToMail()
        {
            var a = EWnter.Qwer().Event.ToList();
            DateTime b = DateTime.Now;
            DateTime h = DateTime.Now.AddDays(3);
            var d = a.Where(p => p.Date >= b).Where(p => p.Date <= h);
            SmtpClient Smtp = new SmtpClient("smtp.mail.ru");
            Smtp.UseDefaultCredentials = true;
            Smtp.EnableSsl = true;
            Smtp.Credentials = new NetworkCredential("adsad.adad.2021@mail.ru", "xU2-ZpM-i3u-QWW");
            //Smtp.Port = 465;
            MailMessage Message = new MailMessage();
            Message.From = new MailAddress("adsad.adad.2021@mail.ru");
            Message.To.Add(new MailAddress("hersenfrigon@gmail.com"));
            Message.Subject = "Мероприятие уже скоро!";
            StringBuilder g = new StringBuilder();
            foreach (var s in d)
            {
                DateTime m = (DateTime)s.Date;
                g.Append($"Не забудьте мероприятие: {s.Name} будет {m.ToString("d")}\n");
                Task.WaitAll();
            }
            Message.Body = g.ToString();
            Smtp.Send(Message);
        }

        private void grou_Copy_Click(object sender, RoutedEventArgs e)
        {
            PariForTT ww = new PariForTT();
            ww.Show();
        }

        public void WhoID()
        {
            
                var a = EWnter.Qwer().Tich.ToList();
                var b = a.Where(p => p.FIOTic.Contains(Static.Name));
                foreach (var d in b)
                {
                    Static.IDTic = d.ID_Tich;
                }
            
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            GC.Collect();
        }
    }
}
