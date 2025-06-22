using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÜrünVeKategoriYönetimi
{
    public abstract class  BaseClass
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public bool AktifMi {  get; set; }

        public DateTime? GüncellemeTarihi { get; set; }

        public DateTime EklenmeTarihi = DateTime.Now;


        //------------- Yapıcı Metot/ Constructor --------------

        public BaseClass()
        {
            EklenmeTarihi = DateTime.Now; // Nesne oluşturulduğunda otomatik ayarlanır
            AktifMi = true; // Varsayılan olarak aktif başlar
            GüncellemeTarihi = null; // Başlangıçta null
        }
        // 2. ID ve Name parametrelerini alan Yapıcı Metot (En sık kullanılan)
        // : this() ile parametresiz constructor'ı zincirleyerek EklenmeTarihi ve AktifMi'nin ayarlanmasını sağlarız
        public BaseClass(int id, string name) : this()
        {
            ID = id; // Parametre 'id'yi property 'ID'ye atama
            Name = name; // Parametre 'name'i property 'Name'e atama
            // AktifMi, EklenmeTarihi, GüncellemeTarihi zaten this() ile ayarlandı
        }

        public override string ToString()
        {
            return $" ID: {ID} , Eklenme Tarihi: {EklenmeTarihi.ToShortDateString()} , Güncelleme Tarihi: {GüncellemeTarihi}, Stok Durumu: {AktifMi}";
            
        }
    }
}

    
