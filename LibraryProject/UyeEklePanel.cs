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
    public partial class UyeEklePanel : Form
    {
        public UyeEklePanel()
        {
            InitializeComponent();
        }

        private void anasayfabutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPanel menupanel = new MenuPanel();
            menupanel.Show();
        }
    }
}
