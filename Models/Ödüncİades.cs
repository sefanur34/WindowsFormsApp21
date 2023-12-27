using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Ödüncİades
    {
        public int id { get; set; }
        public int UyeId { get; set; }
        public int kitapId { get; set; }
        public DateTime islemTarihi { get; set; }
        public DateTime sistemİadeTarihi { get; set; }
        public DateTime kullaniciİadeTarihi { get; set; }
        public bool islemDurumu { get; set; }
    }
}
