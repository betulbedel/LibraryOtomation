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


            string kitapismi = kitapismitextbox.Text;
            string yazar = yazartextBox.Text;
            string tur = (string)comboBox1.SelectedItem;
            string basimyili=dateTimePicker1.Value.Year.ToString();
            string sayfasayisi = sayfatextBox.Text;
            string adetsayisi = copytextBox.Text;

            string connectionstring = "Server= LAPTOP-2AAHS9KO\\SQLEXPRESS;Database= master;Integrated Security= True";
            SqlConnection connection = new SqlConnection(connectionstring);
            string query = $"insert into dbo.books (id, name, author, pubyear, copycount, type, pagecount) values ('0','{kitapismi}','{yazar}','{basimyili}','{adetsayisi}','{tur}','{sayfasayisi}');";
            connection.Open();
            SqlCommand command = new SqlCommand(query,connection);
            command.ExecuteNonQuery();
            connection.Close();
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
    }
}
