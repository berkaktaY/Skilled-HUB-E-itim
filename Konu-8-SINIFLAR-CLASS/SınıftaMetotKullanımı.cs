using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Konu_8_SINIFLAR_CLASS
{
    public class SınıftaMetotKullanımı
    {

        string KurucuMetot;
        public SınıftaMetotKullanımı() // constructor kurucu metot = ctor > tab kısayalu ile açılır 
        {
            Console.WriteLine(
                "kurucuMetot = \"Sınıflarda constructor (kurucu metot) " +
                "özelliği vardır ve bu metotlar sınıftan bir nesne oluşturulduğunda otomatik " +
                "olarak çalışır ve içerisindeki kodları çalıştrır. Kurucu metotlar değişkenler " +
                "" +
                "gibi veri tipi almazlar ve void ifadesi de bulunmaz, sınıfın adıyla aynı " +
                "ad kullanılarak oluşturulur.\";" 
                );
            //yukarda tanımladığımız kurucumetot değişkenine sınıfımızın kurucu metodunda değer
            //ataması yaptık

            Console.WriteLine(KurucuMetot);
            Console.WriteLine();
        }

        public bool LoginKontrol(string kullanıcı, string sifre)
        {
            if(kullanıcı == "admin" && sifre == "123456")
            {
                return true;
            }
            return false;
        }

        public int ToplamaYap(int Sayı1, int Sayı2)
        {
            return Sayı1 + Sayı2;
        }

        public static string Statikdeğisken = "Sınıflarda metot ve değişkenlerde de kullanabiliriz";
        public string DinamikDeğisken = "Bu değişken statik değildir";

         
    }
}
