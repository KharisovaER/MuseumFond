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
    /// Логика взаимодействия для AddExhibitionWindow.xaml
    /// </summary>
    public partial class AddExhibitionWindow : Window
    {
        public AddExhibitionWindow()
        {
            InitializeComponent();
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
                    ex.ExhibitionName = textbox_2.Text;
                    ex.ExhibitionAdress = textbox_3.Text;
                    ex.StartDate = Convert.ToDateTime(textbox_4.Text);
                    ex.EndDate = Convert.ToDateTime(textbox_5.Text);
                    ex.OrganizationId = int.Parse(textbox_6.Text);
                    db.Exhibition.Add(ex);
                    db.SaveChanges();
                }
            }
            else { MessageBox.Show("Ошибка ввода"); }
            this.Close();
        }
    }
}
