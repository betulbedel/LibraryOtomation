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
    public partial class MenuPanel : Form
    {
        public MenuPanel()
        {
            InitializeComponent();
        }

        private void kitapeklebutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPanel adminpanel = new AdminPanel();
            adminpanel.Show();
        }

        private void uyeislembutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            UyeIslemPanel kitapislem = new UyeIslemPanel();
            kitapislem.Show();
        }

        private void uyeklebutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            UyeEklePanel uyeklepanel = new UyeEklePanel();
            uyeklepanel.Show();
        }

        private void cikisbutton_Click(object sender, EventArgs e)
        {
            Program.giris.Logout(); //hide and destroy menupanel on logout

        }

        private void admineklebutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminEklePanel adminekle = new AdminEklePanel();
            adminekle.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            KitapIslemPanel kitapislem = new KitapIslemPanel();
            kitapislem.Show();
        }
    }
}
