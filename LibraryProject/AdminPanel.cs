using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace LibraryProject
{
    public partial class AdminPanel : Form
    {
        List<string> Turler = new List<string>()
        {
            "Macera",
            "Korku",
            "Psikoloji",
            "Romantik",
            "Tarih",
            "Edebiyat"
        };
        public AdminPanel()
        {
            InitializeComponent();
            comboBox1.DataSource = Turler;
        }
        
        private bool isNumValid(string control)
        {
            bool hasnum = false;
            foreach (char c in control)
            {
               
                if((c >= '0' && c <= '9'))
                {
                    hasnum = true;
                }
                else
                {
                    sayfainfo.Text = " Sayfa sayısı ve adedi sayı içermelidir.";
                    return false;
                }
            }

            if (hasnum == false)
            {
                sayfainfo.Text= " Sayfa sayısı ve adedi sadece sayı içermelidir.";
                return false;
            }
            return true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            bool isemptytextboxexist = false;
            if (kitapismitextbox.Text == string.Empty)
            {
                kitapismitextbox.BackColor = Color.Red;
                isemptytextboxexist = true;
            }
            if (yazartextBox.Text == string.Empty)
            {
                yazartextBox.BackColor = Color.Red;
                isemptytextboxexist = true;
            }
            if (sayfatextBox.Text == string.Empty)
            {
                sayfatextBox.BackColor = Color.Red;
                isemptytextboxexist = true;
            }
            if (copytextBox.Text == string.Empty)
            {
                copytextBox.BackColor = Color.Red;
                isemptytextboxexist = true;
            }
            if (kitapismitextbox.Text == string.Empty)
            {
                kitapismitextbox.BackColor = Color.Red;
                isemptytextboxexist = true;
            }

            if (isemptytextboxexist)
            {
                return;
            }
            if (!isNumValid(sayfatextBox.Text))
            {
                return;
            }
            if (!isNumValid(copytextBox.Text))
            {
                return;
            }

            Kitap kitap = new Kitap();

            kitap.isim = kitapismitextbox.Text;
            kitap.yazar = yazartextBox.Text;
            kitap.tur = (string)comboBox1.SelectedItem;
            kitap.basimyili=dateTimePicker1.Value.Year.ToString();
            kitap.sayfasayisi = Convert.ToInt32(sayfatextBox.Text);
            kitap.kopyasayisi = copytextBox.Text;

            Helper.AddBookToDatabase(kitap);
            // MessageBox.Show("Kitap başarıyla eklendi."); //

            basarilitextBox.Visible = true;
            /* Thread.Sleep(3000);
            basarilitextBox.Visible = false; */
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void kitapismitextbox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            kitapismitextbox.BackColor = Color.White;
        }

        private void yazartextBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            yazartextBox.BackColor = Color.White;
        }

        private void sayfatextBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            sayfatextBox.BackColor = Color.White;
        }

        private void copytextBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            copytextBox.BackColor = Color.White;
        }

        private void anasayfabutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPanel menupanel = new MenuPanel();
            menupanel.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "json dosyası |*.json";
          
            
            if (dialog.ShowDialog()==DialogResult.OK) //klasörde seçilip ok a basılmasını bekler.
            {
                string path = dialog.FileName;
                string content = File.ReadAllText(path); //dosyayı string olarak okur.

               List<Kitap> books= Newtonsoft.Json.JsonConvert.DeserializeObject<List<Kitap>>(content);
                foreach(Kitap book in books)
                {
                    Helper.AddBookToDatabase(book);
                }

                MessageBox.Show("Kitap listesi eklendi.");
                return;
            }

        }
    }
}
