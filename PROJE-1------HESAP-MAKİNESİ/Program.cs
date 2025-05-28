using System.Globalization;

namespace PROJE_1______HESAP_MAKİNESİ
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // ------------------------- HESAP MAKİNESİ -------------------------

            /*
             
            Console.WriteLine("Yapmak İstediğiniz İşlemi Seçiniz Lütfen:");

            Console.WriteLine("1-Toplama");
            Console.WriteLine("2-Çıkarma");
            Console.WriteLine("3-Çarpma");
            Console.WriteLine("4-Bölme");
            Console.WriteLine("5-Mod Alma");

            Console.WriteLine("Lütfen Sayısal Olarak Seçiniz: ");

            string Secim = Console.ReadLine();


            Console.WriteLine("Birinci Sayıyı Giriniz: ");

            var Sayı1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İkinci Sayıyı Giriniz: ");

            var Sayı2 = Convert.ToInt32(Console.ReadLine());

            if (Secim == "1")
            {
                Console.WriteLine("Sonuç: " + (Sayı1 + Sayı2));
                
            }

            else if (Secim == "2")
            {
                Console.WriteLine("Sonuç: " + (Sayı1 - Sayı2));
                
            }
            else if (Secim == "3")
            {
                Console.WriteLine("Sonuç: " + (Sayı1 * Sayı2));
                
            }
            else if (Secim == "4")
            {
                Console.WriteLine("Sonuç: " + Sayı1 / Sayı2);
                
            }
            else if (Secim == "5")
            {
                Console.WriteLine("Sonuç: " + (Sayı1 % Sayı2));

            }
            else
            {
                Console.WriteLine("Yanlış Bir Değer Girildi !!");
            }

            

            Console.WriteLine("Kullanıcı Adı Giriniz: ");

               string KullanıcıAdı = Console.ReadLine();

            Console.WriteLine("Şifre Giriniz: ");

                string Şifre = Console.ReadLine();

            string DoğruKullanıcıAdı = "admin";
            string DoğruŞifre = "12345";

            if (KullanıcıAdı == DoğruKullanıcıAdı && Şifre == DoğruŞifre)

            {
                Console.WriteLine("Giriş Başarılı");
            }

            else
            {
                Console.WriteLine("Kullanıcı Adı veya Şifre Hatalı");
            }

            


            int saat = DateTime.Now.Hour; // bilgisayardan şuan ki saati alır

            if (saat < 18)
            {
                Console.WriteLine("İyi Günler. Saat: " + saat);
            }

            else
            {
                Console.WriteLine("İyi Akşamlar. Saat: " + saat);

            }

            Console.WriteLine("Ternay Operatörü");

            Console.WriteLine((saat < 12)? "İyi Günler. Saat: " + saat : ("İyi Akşamlar. Saat: "));

            */

            // ------------ Switch Case Kullanımı ------------

            Console.WriteLine("Switch case akış kontrolü");

            int Ay = DateTime.Now.Month; // bilgisayardan şuan ki ayı alır

            Console.WriteLine("Merhaba Bulunduğumuz Ay: " + Ay);

            switch (Ay)

            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kış Mevsimindesiniz");
                    Console.WriteLine();
                    break;

                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İlkbahar Mevsimindesiniz");
                    Console.WriteLine();
                    break;

                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yaz Mevsimindesiniz");
                    Console.WriteLine();
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Sonbahar Mevsimindesiniz");
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Bir hata oluştu. Lütfen tekrar Deneyiniz");
                    break;
                    

            }
        }
    }
}
