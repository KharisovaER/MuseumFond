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
    /// Логика взаимодействия для UpdateItemWindow.xaml
    /// </summary>
    public partial class UpdateItemWindow : Window
    {
        private Models.Item _i;
        public UpdateItemWindow(object selecteditem)
        {
            InitializeComponent();
            _i = selecteditem as Models.Item;
            textbox_1.Text = _i.ItemName;
            textbox_2.Text = _i.CreateDate.ToString();
            textbox_3.Text = _i.DateTypeId.ToString();
            textbox_4.Text = _i.AuthorId.ToString();
        }
        private void add_item_button_Click(object sender, RoutedEventArgs e)
        {
            int a;


            bool n3 = Int32.TryParse(textbox_3.Text, out a);

            bool n2 = Int32.TryParse(textbox_4.Text, out a);
            if (n3 && n2)
            {
                using (Models.MuseumDataBaseEntities db = new Models.MuseumDataBaseEntities())
                {

                    Models.Item i = new Models.Item();

                    if (i != null)
                    {

                        i.ItemName = textbox_1.Text;
                        i.CreateDate = Convert.ToDateTime(textbox_2.Text);
                        i.DateTypeId = int.Parse(textbox_3.Text);
                        i.AuthorId = int.Parse(textbox_4.Text);
                        db.SaveChanges();

                    }
                }
            }
            else { MessageBox.Show($"Неправильный формат"); }
            this.Close();
        }
    }
}
