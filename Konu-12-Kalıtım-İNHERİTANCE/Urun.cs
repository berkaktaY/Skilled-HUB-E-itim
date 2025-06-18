using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konu_12_Kalıtım_İNHERİTANCE
{
    public class Urun:OrtakÖzellikler
    {
        public string? UrunÖZellikleri { get; set; } //? boş geçilebilir demek
        public decimal Fiyat { get; set; }
        public int ISkonto { get; set; }
        public int KDV { get; set; }
    }
}
