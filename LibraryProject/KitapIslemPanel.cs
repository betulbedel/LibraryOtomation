using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject
{
    public partial class KitapIslemPanel : Form
    {
        List<Kitap> books = new List<Kitap>();

        List<string> Turler = new List<string>()
        {
            "Macera",
            "Korku",
            "Psikoloji",
            "Romantik",
            "Tarih",
            "Edebiyat"
        };

        public KitapIslemPanel()
        {
            InitializeComponent();
            comboBox1.DataSource = Turler;
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

        private void guncellebutton_Click(object sender, EventArgs e)
        {
            string id = listView1.SelectedItems[0].SubItems[0].Text; //seçilen kişinin idsi alınır.

            foreach (Kitap book in books)
            {
                if (book.id == id) //idler eşit mi diye kontrol edilir
                {
                    book.isim = isimtextBox.Text;
                    book.yazar = yazartextBox.Text;
                    book.tur = comboBox1.SelectedItem.ToString();
                    book.sayfasayisi = Convert.ToInt32( sayfasayisitextBox.Text);
                    book.kopyasayisi = kopyasayisitextBox.Text;
                    book.basimyili = dateTimePicker2.Value.Year.ToString();

                    Helper.UpdateBook(book);
                    MessageBox.Show("Kitap güncellendi.");
                    KitapAra();
                    return;
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;

            ListViewItem selecteditem = listView1.SelectedItems[0]; //bir tane seçilir.

            isimtextBox.Text = selecteditem.SubItems[1].Text; // seçilen kitabın ismini designdaki isim kısmına doldurur.
            yazartextBox.Text = selecteditem.SubItems[2].Text;
            comboBox1.Text = selecteditem.SubItems[3].Text;
            dateTimePicker2.Value =DateTime.ParseExact( selecteditem.SubItems[4].Text,"yyyy",CultureInfo.InvariantCulture);
            sayfasayisitextBox.Text = selecteditem.SubItems[5].Text;
            kopyasayisitextBox.Text = selecteditem.SubItems[6].Text;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = listView1.SelectedItems[0].SubItems[0].Text; //seçilen kişinin idsi alınır.

            foreach (Kitap book in books)
            {
                if (book.id == id) //idler eşit mi diye kontrol edilir
                {
                   
                    Helper.DeleteBook(book);
                    MessageBox.Show("Kitap silindi..");
                    KitapAra();
                    return;
                }
            }
        }
    }
}
