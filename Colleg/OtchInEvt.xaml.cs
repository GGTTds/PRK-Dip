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
using Excel = Microsoft.Office.Interop.Excel;

namespace SADIC
{
    /// <summary>
    /// Логика взаимодействия для OtchInEvt.xaml
    /// </summary>
    public partial class OtchInEvt : Window
    {
        public OtchInEvt()
        {
            InitializeComponent();
            //MessageBox.Show(b);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // неделя
            var a = EWnter.Qwer().Event.ToList();
            DateTime b = DateTime.Now;
            DateTime v = DateTime.Now.AddDays(7);
            var d = a.Where(p => p.Date >= b);
            var s = d.Where(p => p.Date <= v);
            var app = new Excel.Application();
            var ork = app.Workbooks.Add();
            Excel.Worksheet worksheet = app.Worksheets.Add();
            worksheet.Name = "Отчет на неделю";
            int Qwe = 1;
            Excel.Range M = worksheet.Range[worksheet.Cells[1][Qwe], worksheet.Cells[6][Qwe]];
            M.Merge();
            worksheet.Cells[1][Qwe].Formula = $" Список мероприятий на неделю: {DateTime.Now.ToString("d")} - {DateTime.Now.AddDays(7).ToString("d")}";
            Qwe += 1;
            worksheet.Cells[1][Qwe] = " Наименование";
            worksheet.Cells[2][Qwe] = " Дата";
            foreach ( var t in s )
            {
                Qwe += 1;
                worksheet.Cells[1][Qwe] = t.Name;
                worksheet.Cells[2][Qwe] = t.Date;
                
            }
            Excel.Range RR2 = worksheet.Range[worksheet.Cells[3][2], worksheet.Cells[6][Qwe]];
            RR2.Merge();
            Excel.Range RR1 = worksheet.Range[worksheet.Cells[1][1], worksheet.Cells[6][Qwe]];
            RR1.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle =
                            RR1.Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle =
                            RR1.Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle =
                            RR1.Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle =
                            RR1.Borders[Excel.XlBordersIndex.xlInsideHorizontal].LineStyle =
                            RR1.Borders[Excel.XlBordersIndex.xlInsideVertical].LineStyle = Excel.XlLineStyle.xlContinuous;
            worksheet.Columns.AutoFit();
            app.Visible = true;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // месяц
            var a = EWnter.Qwer().Event.ToList();
            DateTime b = DateTime.Now;
            DateTime v = DateTime.Now.AddMonths(1);
            var d = a.Where(p => p.Date >= b).Where(p => p.Date <= v);
            var app = new Excel.Application();
            var ork = app.Workbooks.Add();
            Excel.Worksheet worksheet = app.Worksheets.Add();
            worksheet.Name = "Отчет на месяц";
            int Qwe = 1;
            Excel.Range M = worksheet.Range[worksheet.Cells[1][Qwe], worksheet.Cells[6][Qwe]];
            M.Merge();
            worksheet.Cells[1][Qwe].Formula = $" Список мероприятий на месяц: {DateTime.Now.ToString("d")} - {DateTime.Now.AddMonths(1).ToString("d")}";
            Qwe += 1;
            worksheet.Cells[1][Qwe] = " Наименование";
            worksheet.Cells[2][Qwe] = " Дата";
            foreach (var t in d)
            {
                Qwe += 1;
                worksheet.Cells[1][Qwe] = t.Name;
                worksheet.Cells[2][Qwe] = t.Date;

            }
            Excel.Range RR2 = worksheet.Range[worksheet.Cells[3][2], worksheet.Cells[6][Qwe]];
            RR2.Merge();
            Excel.Range RR1 = worksheet.Range[worksheet.Cells[1][1], worksheet.Cells[6][Qwe]];
            RR1.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle =
                            RR1.Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle =
                            RR1.Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle =
                            RR1.Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle =
                            RR1.Borders[Excel.XlBordersIndex.xlInsideHorizontal].LineStyle =
                            RR1.Borders[Excel.XlBordersIndex.xlInsideVertical].LineStyle = Excel.XlLineStyle.xlContinuous;
            worksheet.Columns.AutoFit();
            app.Visible = true;
        }
    }
}
