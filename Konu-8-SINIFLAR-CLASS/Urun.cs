using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konu_8_SINIFLAR_CLASS
{
    public class Urun
    {
        //----------------- Class İçinde Değişken // -field kullanımı --------------------
        internal int ID;
        internal string Adi;
        internal decimal Fiyati;

        //---------------- Class İçinde Property Kullanımı ------------------

        public string UrunAcıklamasi { get; set; } // prop -tab kısayolu // değişkenlein gelişmiş hali
        public string Markasi { get; set; }

        public bool Durum { get; set; }
    }
}
