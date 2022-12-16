using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject
{
    public static class Helper
    {
        const string connectionstring = "Server= LAPTOP-2AAHS9KO\\SQLEXPRESS;Database= master;Integrated Security= True";
        public static SifreDurumu isPasswordValid(string password)
        {
            
            if (password.Length < 6)
            {
                return SifreDurumu.yetersizkarakter;
            }
            bool haschar = false;
            bool hasnum = false;
            foreach (char c in password)
            {
                if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))
                {
                    haschar = true;

                }
                else if ((c >= '0' && c <= '9'))
                {
                    hasnum = true;
                }
                else
                {
                    
                    return SifreDurumu.gecersiz;
                }
            }
            if (hasnum == false || haschar == false)
            {
              
                return SifreDurumu.gecersiz;
            }

            return SifreDurumu.basarili;
        }

        public static void AddBookToDatabase(Kitap k)
        {
            SqlConnection connection = new SqlConnection(connectionstring);
            string findid = "SELECT MAX(id) from dbo.books;";
            SqlCommand findidcommand = new SqlCommand(findid, connection);
            connection.Open();

            object a = findidcommand.ExecuteScalar();
            int id = 0;

            if (!(a is DBNull))
            {
                id = ((int)a) + 1;
            }

            string query = $"insert into dbo.books (id, name, author, pubyear, copycount, type, pagecount) values ('{id}','{k.isim}','{k.yazar}','{k.basimyili}','{k.kopyasayisi}','{k.tur}','{k.sayfasayisi}');";
            
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static void AddUserToDatabase(User u)
        {
            SqlConnection connection = new SqlConnection(connectionstring);
            string finduserid = "SELECT MAX(id) from dbo.users;";
            SqlCommand findidcommand = new SqlCommand(finduserid, connection);
            connection.Open();

            object a = findidcommand.ExecuteScalar();
            int id = 0;

            if (!(a is DBNull))
            {
                id = ((int)a) + 1;
            }
           

            string query = $"insert into dbo.users (id,name,surname,username,mail,password,status,borrowbooks,borrowdate,duedate,penalty) values('{id}','{u.isim}','{u.soyisim}','{u.kullaniciadi}','{u.mailadresi}','{u.sifre}','0','0','{null}','{null}','0');";

            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();

        }
    }
}
