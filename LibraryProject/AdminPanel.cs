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

        private void button1_Click(object sender, EventArgs e)
        {
            //odev
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
    }
}
