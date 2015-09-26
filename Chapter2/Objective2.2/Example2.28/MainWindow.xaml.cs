using System.Collections.Generic;
using System.Windows;

namespace Example2._28
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DisplayInExcel(IEnumerable<dynamic> entities)
        {
            var excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelApp.Visible = true;

            excelApp.Workbooks.Add();

            dynamic workSheet = excelApp.ActiveSheet;

            workSheet.Cells[1, "A"] = "Header A";
            workSheet.Cells[1, "B"] = "Header B";

            var row = 1;
            foreach (var entity in entities)
            {
                row++;
                workSheet.Cells[row, "A"] = entity.ColumnA;
                workSheet.Cells[row, "B"] = entity.ColumnB;
            }

            workSheet.Columns[1].AutoFit();
            workSheet.Columns[2].AutoFit();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var entities = new List<dynamic> 
            {
                new 
                {
                    ColumnA = 1,
                    ColumnB = "Foo"
                },
                new 
                {
                    ColumnA = 2,
                    ColumnB = "Bar"
                },
            };
            this.DisplayInExcel(entities);
        }
    }
}
