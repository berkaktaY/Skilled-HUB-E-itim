using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konu_8_SINIFLAR_CLASS
{
    public class UrunDataMEtotlari1
    {

        internal void UrunEkle(Urun urun)
        {
            Console.WriteLine(urun.Adi + " Ürün Eklendi");
        }

        internal void UrunGuncelle(Urun urun)
        {
            Console.WriteLine(urun.Adi + " Ürün Güncellendi");
        }

        internal void UrunSıl(Urun urun)
        {
            Console.WriteLine(urun.Adi + " Ürün Silindi");
        }

        internal Urun UrunGetir()
        {
            Urun urun = new Urun()

            {
                Adi = "Tv",
                Durum = true,
                Fiyati = 175,
            };

            return urun;
        }

        internal Urun[] Urunler()
        {
            return new Urun[]
            {
                new()
                {
                    Adi="Laptop",
                    Durum=false,
                    Fiyati=37000,
                    ID=1,
                    Markasi="Monster",
                    UrunAcıklamasi="Oyun Bilgisayarı",
                },

                new()
                {
                    Adi="Cep Telefonu",
                    Durum=true,
                    Fiyati=9000,
                    ID=2,
                    Markasi="Iphone",
                    UrunAcıklamasi="Iphone 8 Plus",
                },

                new()
                {
                    Adi="Bilgisayar",
                    Durum=false,
                    Fiyati=19000,
                    ID=3,
                    Markasi="Monster",
                    UrunAcıklamasi="Masaüstü Bilgisayarı",
                }
            };


        }
    }
}

