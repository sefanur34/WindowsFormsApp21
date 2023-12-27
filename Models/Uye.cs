using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Uye
    {
        public int id { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string tc { get; set; }
        public string tel { get; set; }
        public string mail { get; set; }
        public string sifre { get; set; }
        public string adres { get; set; }

        public string a_kitap_sayisi { get; set; }
        public bool kayit_durumu { get; set; }
        public bool yetki_durumu { get; set; }
        public string borc { get; set; }
    }
}
