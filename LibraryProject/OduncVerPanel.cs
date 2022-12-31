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
    public partial class OduncVerPanel : Form
    {
        List<Kitap> kitaplar = new List<Kitap>();
        List<User> users = new List<User>();
        public OduncVerPanel()
        {
            InitializeComponent();
        }


        private void KitapAra(bool isbuttonclicked = false)
        {

            if (string.IsNullOrEmpty(kitapaditextBox.Text) && string.IsNullOrEmpty(kitapyazartextBox.Text))
            {
                MessageBox.Show("Lütfen en az 1 alanı doldurunuz.");
                return;
            }

            kitaplar = Helper.GetBookList(kitapaditextBox.Text, kitapyazartextBox.Text);
            listView1.Items.Clear();

            if (kitaplar == null)
            {
                if (isbuttonclicked) MessageBox.Show("Kitap bulunamadı.");
                return;
            }

            foreach (Kitap book in kitaplar)
            {
                ListViewItem item = new ListViewItem(book.id);

                item.SubItems.Add(book.isim);
                item.SubItems.Add(book.yazar);
                item.SubItems.Add(book.kopyasayisi);

                listView1.Items.Add(item);
            }

        }

        private void KullaniciAra(bool isbuttonclicked = false)
        {

            if (string.IsNullOrEmpty(kullaniciaditextBox.Text) && string.IsNullOrEmpty(kullanicisoyaditextBox.Text))
            {
                MessageBox.Show("Lütfen en az 1 alanı doldurunuz.");
                return;
            }

            users = Helper.GetUserList(kullaniciaditextBox.Text, kullanicisoyaditextBox.Text);
            listView2.Items.Clear();

            if (users == null)
            {
                if (isbuttonclicked) MessageBox.Show("Kullanıcı bulunamadı.");
                return;
            }

            foreach (User user in users)
            {
                ListViewItem item = new ListViewItem(user.id);

                item.SubItems.Add(user.isim);
                item.SubItems.Add(user.soyisim);
                item.SubItems.Add(user.kullaniciadi);

                listView2.Items.Add(item);
            }

        }
        private void kitaparabutton_Click(object sender, EventArgs e)
        {
            KitapAra(true);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;

            ListViewItem selecteditem = listView1.SelectedItems[0]; //bir tane seçilir.

            kitapidtextBox.Text = selecteditem.SubItems[0].Text; // seçilen kitabın ismini designdaki isim kısmına doldurur.
        }

        private void kullaniciarabutton_Click(object sender, EventArgs e)
        {
            KullaniciAra(true);
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count == 0) return;

            ListViewItem selecteditem = listView2.SelectedItems[0]; 

            kullanicidtextBox.Text = selecteditem.SubItems[0].Text; 
        }

        private void OduncVerPanel_Load(object sender, EventArgs e)
        {
            verilisdateTimePicker1.Value = DateTime.Now;
            teslimdateTimePicker2.Value = DateTime.Now + TimeSpan.FromDays(14);
        }

        private void verilisdateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            teslimdateTimePicker2.Value = verilisdateTimePicker1.Value + TimeSpan.FromDays(14);
        }

        private void onaylabutton_Click(object sender, EventArgs e)
        {
            string id = kullanicidtextBox.Text; //seçilen kişinin idsi alınır.

            foreach (User user in users)
            {
                if (user.id == id) //idler eşit mi diye kontrol edilir
                {
                    if (Convert.ToInt32(user.penalty) > 0)
                    {
                        MessageBox.Show("Kullanıcı cezalıdır. Ödemesi gereken ücret:" + user.penalty);
                        return;
                    }
                    if (user.borrowbook != "0")
                    {
                        MessageBox.Show("Kullanıcı 1'den fazla kitap ödünç alamaz." );
                        return;
                    }
                    user.borrowdate = verilisdateTimePicker1.Value.ToString("yyyy-MM-dd");
                    user.duedate = teslimdateTimePicker2.Value.ToString("yyyy-MM-dd");
                    user.borrowbook = kitapidtextBox.Text;

                    Helper.UpdateUser(user);
                    foreach(Kitap kitap in kitaplar)
                    {
                        if (kitap.id == kitapidtextBox.Text)
                        {
                            kitap.kopyasayisi=$"{Convert.ToInt32(kitap.kopyasayisi)-1}"; //kitap kopya sayısı azaltılır
                            Helper.UpdateBook(kitap);
                            break;

                        }
                    }

                    MessageBox.Show("Kullanıcıya başarıyla kitap ödünç verildi.");
                    
                    return;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPanel menu = new MenuPanel();
            menu.Show();
        }
    }
}
