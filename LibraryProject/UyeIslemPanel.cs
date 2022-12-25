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
    public partial class UyeIslemPanel : Form
    {
        List<User> users = new List<User>();
        public UyeIslemPanel()
        {
            InitializeComponent();
        }

        private void UyeAra(bool isbuttonclicked=false)
        {

            if (string.IsNullOrEmpty(uyeaditextBox.Text))
            {
                MessageBox.Show("Lütfen isim alanını doldurunuz.");
                return;
            }
            if (string.IsNullOrEmpty(uyesoyaditextBox.Text))
            {
                MessageBox.Show("Lütfen soyisim giriniz.");
                return;
            }
            users = Helper.GetUserList(uyeaditextBox.Text, uyesoyaditextBox.Text);
            listView1.Items.Clear();

            if (users == null )
            {
               if(isbuttonclicked) MessageBox.Show("Kullanıcı bulunamadı.");
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
        private void uyearabutton_Click(object sender, EventArgs e)
        {

            UyeAra(true);

        }

        private void UyeIslemPanel_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e) //event
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

            foreach(User user in users)
            {
                if (user.id == id) //idler eşit mi diye kontrol edilir
                {
                    user.isim = isimtextBox.Text;
                    user.soyisim = soyisimtextBox.Text;
                    user.kullaniciadi = kullaniciaditextBox.Text;

                    Helper.UpdateUser(user);
                    MessageBox.Show("Kullanıcı güncellendi.");
                    UyeAra();
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
                   
                    Helper.DeleteUser(user);
                    MessageBox.Show("Kullanıcı silindi.");
                    UyeAra();
                    return;
                }
            }

        }
    }
}
