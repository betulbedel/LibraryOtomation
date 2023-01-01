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


            string query = $"insert into dbo.users (id,name,surname,username,mail,password,status,borrowbooks,borrowdate,duedate,penalty) values('{id}','{u.isim}','{u.soyisim}','{u.kullaniciadi}','{u.mailadresi}','{u.sifre}','-1','0','{null}','{null}','0');";

            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();

        }


        public static User IsUserExist(string kullaniciadi, string sifre)
        {
            SqlConnection connection = new SqlConnection(connectionstring);
            string query = $"select * from dbo.users where username = '{kullaniciadi}' and password='{sifre}';";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (!reader.HasRows)
            {
                return null;

            }
            reader.Read();
            User user = new User(reader["name"].ToString(), reader["surname"].ToString(), reader["username"].ToString(), reader["mail"].ToString(), reader["password"].ToString());
            user.id = reader["id"].ToString();
            user.borrowdate = reader["borrowdate"].ToString();
            user.duedate = reader["duedate"].ToString();
            user.penalty = reader["penalty"].ToString();
            user.borrowbook = reader["borrowbooks"].ToString();
            user.status = reader["status"].ToString();
            connection.Close();
            return user;
        }

        public static List<User> GetUserList(string isim, string soyisim)
        {
            SqlConnection connection = new SqlConnection(connectionstring);
            string query = $"select * from dbo.users where name like '%{isim}%' and surname like '%{soyisim}%';";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (!reader.HasRows)
            {
                return null;

            }
            List<User> users = new List<User>();

            while (reader.Read())
            {
                if (reader["status"].ToString() == "1" || reader["status"].ToString() == "-1")
                {
                    continue; //admin olanları listelemez.
                }
                User user = new User(reader["name"].ToString(), reader["surname"].ToString(), reader["username"].ToString(), reader["mail"].ToString(), reader["password"].ToString());
                user.id = reader["id"].ToString();
                user.borrowdate = reader["borrowdate"].ToString();
                user.duedate = reader["duedate"].ToString();
                user.penalty = reader["penalty"].ToString();
                user.borrowbook = reader["borrowbooks"].ToString();

                users.Add(user);

            }
            connection.Close();
            return users;
        }

        public static void UpdateUser(User user)
        {
            SqlConnection connection = new SqlConnection(connectionstring);
            string query = $"update dbo.users set name='{user.isim}',surname='{user.soyisim}',username='{user.kullaniciadi}',password='{user.sifre}',status='{user.status}',borrowbooks='{user.borrowbook}',duedate='{user.duedate}',penalty='{user.penalty}',borrowdate='{user.borrowdate}' where id={user.id};";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();


        }

        public static void DeleteUser(User user)
        {
            SqlConnection connection = new SqlConnection(connectionstring);
            string query = $"delete from  dbo.users where id={user.id};";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static List<User> GetUserList(string status)
        {
            SqlConnection connection = new SqlConnection(connectionstring);
            string query = $"select * from dbo.users where status=  '{status}';";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (!reader.HasRows)
            {
                return null;

            }
            List<User> users = new List<User>();

            while (reader.Read())
            {

                User user = new User(reader["name"].ToString(), reader["surname"].ToString(), reader["username"].ToString(), reader["mail"].ToString(), reader["password"].ToString());
                user.id = reader["id"].ToString();
                user.borrowdate = reader["borrowdate"].ToString();
                user.duedate = reader["duedate"].ToString();
                user.penalty = reader["penalty"].ToString();
                user.borrowbook = reader["borrowbooks"].ToString();

                users.Add(user);

            }
            connection.Close();
            return users;
        }

        public static List<Kitap> GetBookList(string isim, string yazar)
        {
            SqlConnection connection = new SqlConnection(connectionstring);
            string query = $"select * from dbo.books where name like '%{isim}%' and author like '%{yazar}%';";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (!reader.HasRows)
            {
                return null;

            }
            List<Kitap> books = new List<Kitap>();

            while (reader.Read())
            {

                Kitap book = new Kitap();

                book.id = reader["id"].ToString();
                book.yazar = reader["author"].ToString();
                book.isim = reader["name"].ToString();
                book.basimyili = DateTime.Parse(reader["pubyear"].ToString()).Year.ToString();
                book.kopyasayisi = reader["copycount"].ToString();
                book.tur = reader["type"].ToString();
                book.sayfasayisi = Convert.ToInt32(reader["pagecount"].ToString());
                books.Add(book);

            }
            connection.Close();
            return books;
        }


        public static void UpdateBook(Kitap book)
        {
            SqlConnection connection = new SqlConnection(connectionstring);
            string query = $"update dbo.books set name='{book.isim}',author='{book.yazar}',type='{book.tur}',pubyear='{book.basimyili}',pagecount='{book.sayfasayisi}',copycount='{book.kopyasayisi}' where id={book.id};";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

        }

        public static void DeleteBook(Kitap book)
        {
            SqlConnection connection = new SqlConnection(connectionstring);
            string query = $"delete from  dbo.books where id={book.id};";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }



        public static List<User> GetAdminList(string isim, string soyisim)
        {
            SqlConnection connection = new SqlConnection(connectionstring);
            string query = $"select * from dbo.users where name like '%{isim}%' and surname like '%{soyisim}%';";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (!reader.HasRows)
            {
                return null;

            }
            List<User> users = new List<User>();

            while (reader.Read())
            {
                if (reader["status"].ToString() == "0" || reader["status"].ToString() == "-1")
                {
                    continue; //user olanları listelemez.
                }
                User user = new User(reader["name"].ToString(), reader["surname"].ToString(), reader["username"].ToString(), reader["mail"].ToString(), reader["password"].ToString());
                user.id = reader["id"].ToString();
                users.Add(user);

            }
            connection.Close();
            return users;
        }

        public static void UpdateAdmin(User user)
        {
            SqlConnection connection = new SqlConnection(connectionstring);
            string query = $"update dbo.users set name='{user.isim}',surname='{user.soyisim}',username='{user.kullaniciadi}',password='{user.sifre}',status='1' where id={user.id};";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();


        }

        public static void DeleteAdmin(User user)
        {
            SqlConnection connection = new SqlConnection(connectionstring);
            string query = $"delete from  dbo.users where id={user.id};";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }


        public static Kitap GetBook(string id)
        {
            SqlConnection connection = new SqlConnection(connectionstring);
            string query = $"select * from dbo.books where id='{id}';";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (!reader.HasRows)
            {
                return null;

            }


            reader.Read();


            Kitap book = new Kitap();

            book.id = reader["id"].ToString();
            book.yazar = reader["author"].ToString();
            book.isim = reader["name"].ToString();
            book.basimyili = DateTime.Parse(reader["pubyear"].ToString()).Year.ToString();
            book.kopyasayisi = reader["copycount"].ToString();
            book.tur = reader["type"].ToString();
            book.sayfasayisi = Convert.ToInt32(reader["pagecount"].ToString());


            connection.Close();
            return book;
        }


    }
}
