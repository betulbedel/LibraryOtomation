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
    public partial class Kayit : Form
    {
        public Kayit()
        {
            InitializeComponent();
        }
     /*   
      *   private void PaintSquare(TextBox box, PaintEventArgs e)
        {
            box.BorderStyle = BorderStyle.None;
            Pen p = new Pen(Color.Red);
            Graphics graph = e.Graphics;
            graph.DrawRectangle(p, new Rectangle(box.Location.X, box.Location.Y, box.Width, box.Height));
        } */

        
        private void button1_Click(object sender, EventArgs e)
        {
            bool isemptytextboxexist=false;
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
            if (mailtextBox.Text == string.Empty)
            {
                mailtextBox.BackColor = Color.Red;
                isemptytextboxexist = true;
            }

            if (sifretextBox.Text == string.Empty)
            {
                sifretextBox.BackColor = Color.Red;
                isemptytextboxexist = true;
            }
            if (sifrekontroltextBox.Text == string.Empty)
            {
                sifrekontroltextBox.BackColor = Color.Red;
                isemptytextboxexist = true;
            }


            if (isemptytextboxexist)
            {
                return;
            }
            switch (Helper.isPasswordValid(sifretextBox.Text))
            {
                
                case SifreDurumu.yetersizkarakter:
                    sifreinfo.Text = "Şifre en az 6 karakterli olmalıdır.";
                    return;
                case SifreDurumu.gecersiz:
                    sifreinfo.Text = "Şifre harf ve sayı içermelidir";
                    return;
                default:
                    break;
            }
            if(sifretextBox.Text != sifrekontroltextBox.Text)
            {
                sifrekontrolinfo.Text = "Şifre birbiriyle eşleşmelidir.";
                return;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void isimtextBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            isimtextBox.BackColor = Color.White;
        }

        private void sifretextBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            sifretextBox.BackColor = Color.White;
            sifreinfo.Text = string.Empty;
        }

        private void soyisimtextBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            soyisimtextBox.BackColor = Color.White;
        }
        private void kullaniciaditextBox_PreviewKeyDown_1(object sender, PreviewKeyDownEventArgs e)
        {
            kullaniciaditextBox.BackColor = Color.White;
        }

        private void mailtextBox_PreviewKeyDown_1(object sender, PreviewKeyDownEventArgs e)
        {
            mailtextBox.BackColor = Color.White;
        }

        private void sifrekontroltextBox_PreviewKeyDown_1(object sender, PreviewKeyDownEventArgs e)
        {
            sifrekontroltextBox.BackColor = Color.White;
            sifrekontrolinfo.Text = string.Empty;
        }
    }
}
