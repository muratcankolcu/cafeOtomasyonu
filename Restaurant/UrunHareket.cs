using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class UrunHareket
    {
        public string MasaKodu { get; set; }
        public string UrunKodu { get; set; }
        public string UrunAdi { get; set; }
        public string Biriimi { get; set; }
        public double Fiyat { get; set; }
        public double Miktar { get; set; }
        public string MusteriAdi { get; set; }
    }
}
