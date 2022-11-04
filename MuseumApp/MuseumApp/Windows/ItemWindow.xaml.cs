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
    /// Логика взаимодействия для ItemWindow.xaml
    /// </summary>
    public partial class ItemWindow : Window
    {
        public ItemWindow()
        {
            InitializeComponent();
            cancel_b.IsEnabled = false;
            id_l.IsEnabled = false;
            id_tb.IsEnabled = false;
            item_dell.IsEnabled = false;
            Models.MuseumDataBaseEntities m = new Models.MuseumDataBaseEntities();
            var q = from Item in m.Item select Item;
            ;
            Item_table.ItemsSource = q.ToList();
        }
        private void upd_table_Click(object sender, RoutedEventArgs e)
        {
            Models.MuseumDataBaseEntities m = new Models.MuseumDataBaseEntities();
            var q = from Item in m.Item
                    select new
                    { Item.ItemId, Item.ItemName, Item.CreateDate, Item.DateTypeId, Item.AuthorId };
            Item_table.ItemsSource = q.ToList();
        }

        private void item_add_Click(object sender, RoutedEventArgs e)
        {
            Windows.AddItemWindow a = new Windows.AddItemWindow();
            a.Show();
        }

        private void item_upd_Click(object sender, RoutedEventArgs e)
        {
            if (Item_table.SelectedItem != null)
            {
                Windows.UpdateItemWindow u = new Windows.UpdateItemWindow(Item_table.SelectedItem);
                u.Show();
            }
            else { MessageBox.Show("Выберите строку"); }
        }

        private void item_del_Click(object sender, RoutedEventArgs e)
        {
            cancel_b.IsEnabled = true;
            id_l.IsEnabled = true;
            id_tb.IsEnabled = true;
            item_upd.IsEnabled = false;
            item_add.IsEnabled = false;
            item_dell.IsEnabled = true;
        }

        private void cancel_b_Click(object sender, RoutedEventArgs e)
        {
            cancel_b.IsEnabled = false;
            id_l.IsEnabled = false;
            id_tb.IsEnabled = false;
            item_upd.IsEnabled = true;
            item_add.IsEnabled = true;

        }

        private void item_dell_Click(object sender, RoutedEventArgs e)
        {
            int b;
            Models.MuseumDataBaseEntities m = new Models.MuseumDataBaseEntities();
            Models.Item i = new Models.Item();
            bool n1 = Int32.TryParse(id_tb.Text, out b);
            if (n1)
            {
                i = m.Item.Find(int.Parse(id_tb.Text));
                if (i != null)
                {
                    m.Item.Remove(i);
                    m.SaveChanges();
                    cancel_b.IsEnabled = false;
                    id_l.IsEnabled = false;
                    id_tb.IsEnabled = false;
                    item_upd.IsEnabled = false;
                    item_add.IsEnabled = true;

                    MessageBox.Show("Обьект удален");
                    id_tb.Text = "";
                }
                else { MessageBox.Show("Ошибка"); }
            }
            cancel_b.IsEnabled = false;
            id_l.IsEnabled = false;
            id_tb.IsEnabled = false;
            item_upd.IsEnabled = true;
            item_add.IsEnabled = true;
            item_dell.IsEnabled = false;
        }
    }
}
