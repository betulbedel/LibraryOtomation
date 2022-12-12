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
            string connectionstring = "Server= LAPTOP-2AAHS9KO\\SQLEXPRESS;Database= master;Integrated Security= True";
            SqlConnection connection = new SqlConnection(connectionstring);
            string query = $"insert into dbo.books (id, name, author, pubyear, copycount, type, pagecount) values ('0','{k.isim}','{k.yazar}','{k.basimyili}','{k.kopyasayisi}','{k.tur}','{k.sayfasayisi}');";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
