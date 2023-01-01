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
    public partial class UserOduncTakip : Form
    {
        public UserOduncTakip()
        {
            InitializeComponent();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserMenuPanel MENU = new UserMenuPanel();
            MENU.Show();
        }

        private void UserOduncTakip_Load(object sender, EventArgs e)
        {
            if (Program.CurrentUser.borrowbook == "0")
            {
                MessageBox.Show("Henüz bir kitap ödünç almadınız.");
                return;
            }

            Kitap book = Helper.GetBook(Program.CurrentUser.borrowbook);

            kitapisimlabel.Text = book.isim;
            kitapyazarlabel.Text = book.yazar;
            odunclabel.Text = Program.CurrentUser.borrowdate.Split()[0];
            teslimlabel.Text = Program.CurrentUser.duedate.Split()[0];
            DateTime.TryParse(Program.CurrentUser.duedate, out DateTime duedate);
            if(duedate > DateTime.Now)
            {
                kalangunlabel.Text =(duedate-DateTime.Now).Days.ToString();
                cezalabel.Text = "0";
                gecikmegunlabel.Text = "0";
            }
            else
            {
                gecikmegunlabel.Text = (DateTime.Now - duedate).Days.ToString();
                cezalabel.Text =$"{(DateTime.Now - duedate).Days * 0.1:0.##} tl" ;
                kalangunlabel.Text = "0";
            }
        }
    }
}
