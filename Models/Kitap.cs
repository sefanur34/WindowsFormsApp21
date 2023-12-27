using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Kitap
    {
        public int id { get; set; }
        public string kitapAdi { get; set; }
        public string isbn { get; set; }
        public string yazarId { get; set; }
        public string baskiYili { get; set; }
        public string yayineviId { get; set; }
        public string kategoriId { get; set; }
        public string kitapDurumu { get; set; }
        public string stok { get; set; }
        public string ekleyenId { get; set; }


    }
}
