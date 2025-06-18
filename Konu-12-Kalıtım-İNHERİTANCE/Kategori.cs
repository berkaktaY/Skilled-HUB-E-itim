using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konu_12_Kalıtım_İNHERİTANCE
{
    public class Kategori : OrtakÖzellikler
    {
        public string KategoriBanner { get; set; }
       
        public bool ÜstMenüdeGöster { get; set; }
        public bool YanMenüdeGöster { get; set; }

        public bool AltMenüdeGöster { get; set; }


    }
}
