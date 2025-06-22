using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÜrünVeKategoriYönetimi
{
    public class URUNLER : BaseClass
    {
        
        public string Marka { get; set; }

        public string Model { get; set; }

        public decimal Fiyat { get; set; }

        public string Acıklama { get; set; }

        public string UrunTipi { get; set; }

        public Kategori Kategori { get; set; } // HANGİ KATEGORİYE AİT OLDUĞUNNU BELİRLEYECEK

        public URUNLER(int id,string name) : base(id,name)
        {
            
            this.Marka = "IPHONE";
            this.Model = "8 PLUS";
            this.Fiyat = 7850m;
            this.Acıklama = "Garantili,Pİl seviyesi %100,kılcal çizik dahi yok.";
            this.UrunTipi = "Genel";
            this.Kategori = null;
        }

        public URUNLER(int id, string name, string marka, string model, decimal fiyat, string aciklama, string urunTipi, Kategori kategori) : base(id, name)
        {
            Marka = marka;
            Model = model;
            Fiyat = fiyat;
            Acıklama = aciklama;
            this.UrunTipi = urunTipi;
            Kategori = kategori;
            
        }

        public string ToString()
        {
            return $"Marka: {Marka}, Model: {Model}, Fiyat: {Fiyat}, Açıklama: {Acıklama}, Tip: {UrunTipi}, Kategori: {Kategori}";
        }
    }
}
