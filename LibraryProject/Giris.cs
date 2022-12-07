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
        }

        private void kayitolbuttonclick(object sender, EventArgs e)
        {
            this.Hide();
            Kayit kayitekrani = new Kayit();
            kayitekrani.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); //Pencere gizlemek icin
            AdminPanel adminpanel = new AdminPanel();
            adminpanel.Show();
        }
    }
}
