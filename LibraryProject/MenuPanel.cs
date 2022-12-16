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
    }
}
