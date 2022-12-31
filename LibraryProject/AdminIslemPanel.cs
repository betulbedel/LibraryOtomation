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
    public partial class AdminIslemPanel : Form
    {
        List<User> users = new List<User>();

        public AdminIslemPanel()
        {
            InitializeComponent();
        }


        private void AdminAra(bool isbuttonclicked = false)
        {

            if (string.IsNullOrEmpty(adminaditextBox.Text))
            {
                MessageBox.Show("Lütfen isim alanını doldurunuz.");
                return;
            }
            if (string.IsNullOrEmpty(adminsoyaditextBox.Text))
            {
                MessageBox.Show("Lütfen soyisim giriniz.");
                return;
            }
            users = Helper.GetAdminList(adminaditextBox.Text, adminsoyaditextBox.Text);

            listView1.Items.Clear();

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

                listView1.Items.Add(item);
            }

        }

        private void adminarabutton_Click(object sender, EventArgs e)
        {
            AdminAra(true);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;

            ListViewItem selecteditem = listView1.SelectedItems[0]; //bir tane seçilir.

            isimtextBox.Text = selecteditem.SubItems[1].Text; // seçilen kullanıcının ismini designdaki isim kısmına doldurur.
            soyisimtextBox.Text = selecteditem.SubItems[2].Text;
            kullaniciaditextBox.Text = selecteditem.SubItems[3].Text;
        }

        private void guncellebutton_Click(object sender, EventArgs e)
        {
            string id = listView1.SelectedItems[0].SubItems[0].Text; //seçilen kişinin idsi alınır.

            foreach (User user in users)
            {
                if (user.id == id) //idler eşit mi diye kontrol edilir
                {
                    user.isim = isimtextBox.Text;
                    user.soyisim = soyisimtextBox.Text;
                    user.kullaniciadi = kullaniciaditextBox.Text;

                    Helper.UpdateAdmin(user);
                    MessageBox.Show("Kullanıcı güncellendi.");
                    AdminAra();
                    return;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string id = listView1.SelectedItems[0].SubItems[0].Text;

            foreach (User user in users)
            {
                if (user.id == id) //idler eşit mi diye kontrol edilir
                {

                    Helper.DeleteAdmin(user);
                    MessageBox.Show("Kullanıcı silindi.");
                    AdminAra();
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
