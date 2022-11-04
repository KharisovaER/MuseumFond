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
using Word = Microsoft.Office.Interop.Word;


namespace MuseumApp.Windows
{
    /// <summary>
    /// Логика взаимодействия для ExhibitionWindow.xaml
    /// </summary>
    public partial class ExhibitionWindow : Window
    {
        public ExhibitionWindow()
        {
            InitializeComponent();
            cancel_b.IsEnabled = false;
            id_l.IsEnabled = false;
            id_tb.IsEnabled = false;
            item_dell.IsEnabled = false;
            Models.MuseumDataBaseEntities m = new Models.MuseumDataBaseEntities();
            var q =
            from Exhibition in m.Exhibition
            select Exhibition;
            Exhib_table.ItemsSource = q.ToList();
        }
        private void upd_table_Click(object sender, RoutedEventArgs e)
        {
            Models.MuseumDataBaseEntities m = new Models.MuseumDataBaseEntities();
            var q =
            from Exhibition in m.Exhibition select Exhibition;
            Exhib_table.ItemsSource = q.ToList();

        }

        private void ex_upd_Click(object sender, RoutedEventArgs e)
        {
            if (Exhib_table.SelectedItem != null)
            {
                Windows.UpdateExhibitionWindow u = new Windows.UpdateExhibitionWindow(Exhib_table.SelectedItem);
                u.Show();
            }
            else { MessageBox.Show("Выберите стрчоку"); }
        }

        private void ex_add_Click(object sender, RoutedEventArgs e)
        {
            Windows.AddExhibitionWindow u = new Windows.AddExhibitionWindow();
            u.Show();
        }
        private void cancel_b_Click(object sender, RoutedEventArgs e)
        {
            cancel_b.IsEnabled = false;
            id_l.IsEnabled = false;
            id_tb.IsEnabled = false;
            ex_upd.IsEnabled = true;
            ex_add.IsEnabled = true;

        }

        private void item_dell_Click(object sender, RoutedEventArgs e)
        {
            int b;
            Models.MuseumDataBaseEntities m = new Models.MuseumDataBaseEntities();
            Models.Exhibition ex = new Models.Exhibition();
            bool n1 = Int32.TryParse(id_tb.Text, out b);
            if (n1)
            {
                ex = m.Exhibition.Find(int.Parse(id_tb.Text));
                if (ex != null)
                {
                    m.Exhibition.Remove(ex);
                    m.SaveChanges();
                    cancel_b.IsEnabled = false;
                    id_l.IsEnabled = false;
                    id_tb.IsEnabled = false;
                    ex_upd.IsEnabled = false;
                    ex_add.IsEnabled = true;

                    MessageBox.Show("Обьект удален");
                    id_tb.Text = "";
                }
                else { MessageBox.Show("Ошибка"); }
            }
            cancel_b.IsEnabled = false;
            id_l.IsEnabled = false;
            id_tb.IsEnabled = false;
            ex_upd.IsEnabled = true;
            ex_add.IsEnabled = true;
            item_dell.IsEnabled = false;
        }

        private void ex_del_Click(object sender, RoutedEventArgs e)
        {
            cancel_b.IsEnabled = true;
            id_l.IsEnabled = true;
            id_tb.IsEnabled = true;
            ex_upd.IsEnabled = false;
            ex_add.IsEnabled = false;
            item_dell.IsEnabled = true;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<Models.Exhibition> exhibitions;

            using (Models.MuseumDataBaseEntities usersEntities = new Models.MuseumDataBaseEntities())
            {
                exhibitions = usersEntities.Exhibition.ToList().OrderBy(s => s.ExhibitionId).ToList();
                var app = new Word.Application();
                Word.Document document = app.Documents.Add();

                Word.Paragraph paragraph =
                document.Paragraphs.Add();
                Word.Range range = paragraph.Range;
                range.Text = "";
                paragraph.set_Style("Заголовок 1");
                range.InsertParagraphAfter();
                Word.Paragraph tableParagraph = document.Paragraphs.Add();
                Word.Range tableRange = tableParagraph.Range;
                Word.Table studentsTable =
                document.Tables.Add(tableRange, exhibitions.Count() + 1, 6);
                studentsTable.Borders.InsideLineStyle =
                studentsTable.Borders.OutsideLineStyle =
                Word.WdLineStyle.wdLineStyleSingle;
                studentsTable.Range.Cells.VerticalAlignment =
                Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                Word.Range cellRange;
                cellRange = studentsTable.Cell(1, 1).Range;
                cellRange.Text = "ID";
                cellRange = studentsTable.Cell(1, 2).Range;
                cellRange.Text = "Название";
                cellRange = studentsTable.Cell(1, 3).Range;
                cellRange.Text = "Адрес";
                cellRange = studentsTable.Cell(1, 4).Range;
                cellRange.Text = "Дата начала выставки";
                cellRange = studentsTable.Cell(1, 5).Range;
                cellRange.Text = "Дата окончания выставки";
                cellRange = studentsTable.Cell(1, 6).Range;
                cellRange.Text = "ID Организатора";

                studentsTable.Rows[1].Range.Bold = 1;
                studentsTable.Rows[1].Range.ParagraphFormat.Alignment =
                Word.WdParagraphAlignment.wdAlignParagraphCenter;
                int i = 1;
                foreach (var currentrep in exhibitions)
                {
                    cellRange = studentsTable.Cell(i + 1, 1).Range;
                    cellRange.Text = currentrep.ExhibitionId.ToString();
                    cellRange.ParagraphFormat.Alignment =
                    Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    cellRange = studentsTable.Cell(i + 1, 2).Range;
                    cellRange.Text = currentrep.ExhibitionName.ToString();
                    cellRange.ParagraphFormat.Alignment =
                    Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    cellRange = studentsTable.Cell(i + 1, 3).Range;
                    cellRange.Text = currentrep.ExhibitionAdress.ToString();
                    cellRange.ParagraphFormat.Alignment =
                     Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    cellRange = studentsTable.Cell(i + 1, 4).Range;
                    cellRange.Text = currentrep.StartDate.ToString();
                    cellRange.ParagraphFormat.Alignment =
                    Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    cellRange = studentsTable.Cell(i + 1, 5).Range;
                    cellRange.Text = currentrep.EndDate.ToString();
                    cellRange = studentsTable.Cell(i + 1, 6).Range;
                    cellRange.Text = currentrep.OrganizationId.ToString();
                    cellRange.ParagraphFormat.Alignment =
                    Word.WdParagraphAlignment.wdAlignParagraphCenter;

                    i++;
                }
                Word.Paragraph countStudentsParagraph = document.Paragraphs.Add();
                Word.Range countStudentsRange =
                countStudentsParagraph.Range;
                countStudentsRange.Text = $"Количество выставок -{exhibitions.Count()}";
                countStudentsRange.Font.Color = Word.WdColor.wdColorDarkRed;
                countStudentsRange.InsertParagraphAfter();
                document.Words.Last.InsertBreak(Word.WdBreakType.wdPageBreak);

                app.Visible = true;
                document.SaveAs2(@"D:\outputFileWord.docx");
                document.SaveAs2(@"D:\ExhFile.pdf",
                Word.WdExportFormat.wdExportFormatPDF);
            }
        }
    
    }
}
