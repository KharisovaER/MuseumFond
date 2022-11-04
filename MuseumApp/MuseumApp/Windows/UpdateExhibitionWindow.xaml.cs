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

namespace MuseumApp.Windows
{
    /// <summary>
    /// Логика взаимодействия для UpdateExhibitionWindow.xaml
    /// </summary>
    public partial class UpdateExhibitionWindow : Window
    {
        private Models.Exhibition _ex;
        public UpdateExhibitionWindow(object SelectedItem)
        {
            InitializeComponent();
            _ex = SelectedItem as Models.Exhibition;
            textbox_2.Text = _ex.ExhibitionName;
            textbox_3.Text = _ex.ExhibitionAdress;
            textbox_4.Text = _ex.StartDate.ToString();
            textbox_5.Text = _ex.ToString();
            textbox_6.Text = _ex.OrganizationId.ToString();
        }
        private void upd_exh_button_Click(object sender, RoutedEventArgs e)
        {
            int a;
            bool n2 = Int32.TryParse(textbox_6.Text, out a);
            if (n2)
            {
                using (Models.MuseumDataBaseEntities db = new Models.MuseumDataBaseEntities())
                {

                    Models.Exhibition ex = new Models.Exhibition();

                    if (ex != null)
                    {

                        ex.ExhibitionName = textbox_2.Text;
                        ex.ExhibitionAdress = textbox_3.Text;
                        ex.StartDate = Convert.ToDateTime(textbox_4.Text);
                        ex.EndDate = Convert.ToDateTime(textbox_5.Text);
                        ex.OrganizationId = int.Parse(textbox_6.Text);
                        db.SaveChanges();
                    }
                }
            }
            else { MessageBox.Show($"Неправильный формат"); }
            this.Close();
        }
    }
}
