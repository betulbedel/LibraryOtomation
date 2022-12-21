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
    public partial class AdminEklePanel : Form
    {
        public AdminEklePanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(isimtextBox.Text))
            {
                MessageBox.Show("Lütfen isim alanını doldurunuz.");
                return;
            }
            if (string.IsNullOrEmpty(soyisimtextBox.Text))
            {
                MessageBox.Show("Lütfen soyisim giriniz.");
                return;
            }
            List<User> users = Helper.GetUserList(isimtextBox.Text, soyisimtextBox.Text);
            listBox1.Items.Clear();
            if (users == null)
            {
                MessageBox.Show("Kullanıcı bulunamadı.");
                return;
            }

            foreach(User user in users)
            {
                listBox1.Items.Add(user);
            }



        }

        private void adminbutton_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                Helper.UpdateUser((User)listBox1.SelectedItem);
                MessageBox.Show("Üye admin olarak değiştirildi.");
            }
        }
    }
}
