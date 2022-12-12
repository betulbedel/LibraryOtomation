using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject
{
    class User
    {
        public string isim { get; private set; } //setlenemez
        public string soyisim { get; private set; }
        public string kullaniciadi { get; private set; }
        public string mailadresi { get; private set; }
        public string sifre { get; private set; }

        public User(string isim, string soyisim, string kullaniciadi, string mailadresi, string sifre)
        {
            this.isim = isim;
            this.kullaniciadi = kullaniciadi;
            this.mailadresi = mailadresi;
            this.sifre = sifre;
            this.soyisim = soyisim;
        }


    }
}
