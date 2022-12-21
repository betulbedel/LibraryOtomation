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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
            Program.giris = this;
        }
        public void Logout()
        {
            Program.menu.Hide();
            Program.menu = null;
            this.Show();
        }

        private void kayitolbuttonclick(object sender, EventArgs e)
        {
            this.Hide();
            Kayit kayitekrani = new Kayit();
            kayitekrani.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (string.IsNullOrEmpty(kullanicitextBox.Text))
            {
                MessageBox.Show("Lütfen kullanıcı adını doldurunuz.");
                return;
            }
            if (string.IsNullOrEmpty(sifretextBox.Text))
            {
                MessageBox.Show("Lütfen şifreyi giriniz.");
                return;
            }
            Program.CurrentUser = Helper.IsUserExist(kullanicitextBox.Text,sifretextBox.Text);
            if (Program.CurrentUser == null)
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış.");
                return;
            }
            MessageBox.Show("Giriş başarılı", " TEBRİKLER", MessageBoxButtons.OK );

            if (Program.CurrentUser.status == "1")
            {
                this.Hide(); //Pencere gizlemek icin
                /* AdminPanel adminpanel = new AdminPanel();
                 adminpanel.Show(); */
                Program.menu = new MenuPanel();
                Program.menu.Show();
                
            }
        }
    }
}
