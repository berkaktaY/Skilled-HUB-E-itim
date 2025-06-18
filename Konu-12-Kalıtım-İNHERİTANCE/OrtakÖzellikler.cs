using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konu_12_Kalıtım_İNHERİTANCE
{
    public class OrtakÖzellikler // base class

    {
        public int ID { get; set; }

        public string Name { get; set; }
        public string? Description { get; set; } // ? boş geçilebilir
        public DateTime CreateDate { get; set; }
    }
}
