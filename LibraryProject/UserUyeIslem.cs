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
    public partial class UserUyeIslem : Form
    {
        public UserUyeIslem()
        {
            InitializeComponent();
        }

        private void UserUyeIslem_Load(object sender, EventArgs e)
        {
            isimtextBox.Text = Program.CurrentUser.isim;
            soyisimtextBox.Text = Program.CurrentUser.soyisim;
            kullaniciaditextBox.Text = Program.CurrentUser.kullaniciadi;
            sifretextBox.Text = Program.CurrentUser.sifre.Trim();
        }

        private void guncellebutton_Click(object sender, EventArgs e)
        {

            bool isemptytextboxexist = false;
            if (isimtextBox.Text == string.Empty)
            {
                isimtextBox.BackColor = Color.Red;
                isemptytextboxexist = true;

            }
            if (soyisimtextBox.Text == string.Empty)
            {
                soyisimtextBox.BackColor = Color.Red;
                isemptytextboxexist = true;
            }
            if (kullaniciaditextBox.Text == string.Empty)
            {
                kullaniciaditextBox.BackColor = Color.Red;
                isemptytextboxexist = true;
            }
            if (sifretextBox.Text == string.Empty)
            {
                sifretextBox.BackColor = Color.Red;
                isemptytextboxexist = true;
            }
          

            if (isemptytextboxexist)
            {
                return;
            }
            switch (Helper.isPasswordValid(sifretextBox.Text))
            {

                case SifreDurumu.yetersizkarakter:
                    sifreinfolabel.Text = "Şifre en az 6 karakterli olmalıdır.";
                    return;
                case SifreDurumu.gecersiz:
                    sifreinfolabel.Text = "Şifre harf ve sayı içermelidir";
                    return;
                default:
                    break;
            }

            Program.CurrentUser.isim = isimtextBox.Text;
            Program.CurrentUser.soyisim = soyisimtextBox.Text;
            Program.CurrentUser.kullaniciadi = kullaniciaditextBox.Text;
            Program.CurrentUser.sifre = sifretextBox.Text;

            Helper.UpdateUser(Program.CurrentUser);

            MessageBox.Show("Bilgileriniz başarıyla güncellendi.");
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserMenuPanel menu = new UserMenuPanel();
            menu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           DialogResult result= MessageBox.Show("Bu işlem geri alınamaz. Kaydınızı silmek istediğinizden emin misiniz?", "UYARI!",MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Helper.DeleteUser(Program.CurrentUser);
                this.Hide();
                Program.giris.Logout();
            }
           
        }
    }
}
