using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject
{
    public partial class UserKitapAraPanel : Form
    {
        List<Kitap> books = new List<Kitap>();
        public UserKitapAraPanel()
        {
            InitializeComponent();
        }

        private void KitapAra(bool isbuttonclicked = false)
        {

            if (string.IsNullOrEmpty(kitapaditextBox.Text) && string.IsNullOrEmpty(yazaraditextBox.Text))
            {
                MessageBox.Show("Lütfen en az 1 alanı doldurunuz.");
                return;
            }

            books = Helper.GetBookList(kitapaditextBox.Text, yazaraditextBox.Text);
            listView1.Items.Clear();

            if (books == null)
            {
                if (isbuttonclicked) MessageBox.Show("Kitap bulunamadı.");
                return;
            }

            foreach (Kitap book in books)
            {
                ListViewItem item = new ListViewItem(book.id);

                item.SubItems.Add(book.isim);
                item.SubItems.Add(book.yazar);
                item.SubItems.Add(book.tur);
                item.SubItems.Add(book.basimyili);
                item.SubItems.Add(book.sayfasayisi.ToString());
                item.SubItems.Add(book.kopyasayisi);

                listView1.Items.Add(item);
            }

        }

        private void listelebutton_Click(object sender, EventArgs e)
        {
            KitapAra(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserMenuPanel menu = new UserMenuPanel();
            menu.Show();
        }
    }
}
