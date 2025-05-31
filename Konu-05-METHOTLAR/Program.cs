using System.ComponentModel.Design;

namespace Konu_05_METHOTLAR
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //---------------- METOTLAR ------------------


            Console.WriteLine("METOTLAR");    
            ToplamaYap(); // Metot çağrısı olamadan ekrana yazdırmaz.
            ToplamaYap(50, 8);

            Console.WriteLine("Geriye Döndüren Metot: ");
            int sonuc = ToplamaYap(10, 20, 30); // Metot çağrısı yapıldıktan sonra geriye dönen değer değişkene atanır.

            Console.WriteLine("Sonuç: " + sonuc);

            Console.WriteLine("Lütfen mail adresinizi giriniz: ");

            var mail = Console.ReadLine();

            if (MailGonder(mail) == false)

            {
                Console.WriteLine("Mail Bilgileriniz Yanlış");
            }

            else
                Console.WriteLine("Giriş Başarılı");

            KdvHesapla();
            MatematikselMetotlar();
        }
       
        
        static void ToplamaYap()
        {
            Console.WriteLine(10 + 8);
            
        }

        // void olan metotlar geriye değer döndürmez.

        // Aynı isimde metotlar farklı marametrelerde kullanılırsa bu metot aşırı yükleme (overloading) olarak adlandırılır.

        //metot kullanımında kullanılan parametreler (Sayı1 Sayı2) metotun kullanıldığı yerde metoda gönderilmek zorundaıdır.
        //aksi halde hata verilir.

        static void ToplamaYap( int sayı1 , int sayı2)
        {
            Console.WriteLine("Sonuç: " +(sayı1 + sayı2));

        }

        static int ToplamaYap(int sayı1, int sayı2 ,int sayı3)

        // Geriye döndürülen metotllarda metot isminin önüne geriye döndürülecek veri tipini yazmak gerekir.

        // metotun aldığı parametre ile geri dönüş veri tipi aynı olmak zorunda DEĞİLDİR

        // bir metot parametre olarak int, string, double, float, char gibi veri tiplerini alabilir ve
        // geriye de int, string, double, float, char gibi veri tiplerini döndürebilir.


        {
            return sayı1 + sayı2 + sayı3; // int olan metotlar geriye değer döndürür. Return ifadesi ile geriye değer döndürülür.

        }

        static bool MailGonder(String MailAdresi)

        {
            if (!string.IsNullOrEmpty(MailAdresi)) // eğer mail adresi değişkenine bir değer girilmişse,yani mail adresi boş değilse

            { return true; } // geriye true değeri gönderir

            else return false; // mail adresş boş ise geriye false değeri gönderir
        }

        static void KdvHesapla()

        {
            double fiyat, kdv, toplma;
            Console.WriteLine("Fiyat Bilgisi Giriniz: ");
            fiyat = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("KDV Giriniz: ");
            var KdvMiktarı = Convert.ToDouble(Console.ReadLine);
            kdv = fiyat * KdvMiktarı / 100;
            toplma = fiyat + kdv;
            Console.WriteLine("Ürün KDV tutarı: " + kdv);
            Console.WriteLine("Ürün Toplam Tutarı: " + toplma);
        }

        static void MatematikselMetotlar ()

            // Belirli matematiksel işlemlar yapan bazı metotlar
        {
            int max = Math.Max(10, 34); // x ve y sayılarının en büyüğünü tutar

            int min = Math.Min(10, 34); // x ve y sayılarının en küçüğünü tutar

            double c = Math.Ceiling(12.67); // x sayısından büyük en küçük tam sayıyı tutar ( yukarı yuvarlar)

            double d = Math.Floor(12.67); // x sayısından küçük en büyük tam sayıyı tutar ( aşağı yuvarlama )

            Console.WriteLine("max: " + max , "min: " + min, "Ceiling: " + c, "Floor: " + d);
        }
    }
}
