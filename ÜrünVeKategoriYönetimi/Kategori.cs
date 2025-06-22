using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÜrünVeKategoriYönetimi
{
    public class Kategori : BaseClass
    { 
        

        public string Acıklama { get; set; }

        public Kategori(int id,string ad)
        {
            ID = id;
            Name = ad;
        }

        public Kategori(int id, string name, string aciklama, bool aktifMi) : base(id, name)
        //Amacı: Bu yapıcı metot (constructor),
        //yeni bir Kategori nesnesi oluşturulduğunda çağrılır ve bu nesnenin başlangıç değerlerini belirlememizi
        //sağlar.

        {
            ID = id;
            Name = name;
            Acıklama= aciklama;
            AktifMi = aktifMi;


        }
        //Metot içinde, dışarıdan alınan id, ad ve aciklama değerleri,
        //Kategori nesnesinin ilgili özelliklerine atanır.
        //Id özelliğinin atanmasına dikkat et, bu özellik BaseClass'tan miras alınmıştır.

        public string Tostring()
        {
            return $"{base.ToString()}, Kategori Adı: {Name}, ID: {ID}, Acıklama: {Acıklama} , Stok Durumu: {AktifMi} ";
        }
    }

    


}

