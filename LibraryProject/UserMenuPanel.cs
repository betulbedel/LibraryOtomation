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
    public partial class UserMenuPanel : Form
    {
        public UserMenuPanel()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserKitapAraPanel kitapara = new UserKitapAraPanel();
            kitapara.Show();
        }

        private void cikisbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.giris.Logout();
        }

        private void uyeislembutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserUyeIslem islem = new UserUyeIslem();
            islem.Show();
        }

        private void odunctakipbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserOduncTakip odunc = new UserOduncTakip();
            odunc.Show();
        }
    }
}
