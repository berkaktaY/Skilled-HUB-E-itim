using System.ComponentModel.Design;
namespace Hesap_Makinesi_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Yapmak İstediğiniz İşlemi Seçiniz: ");
            Console.WriteLine("1-Toplama");
            Console.WriteLine("2-Çıkarma");
            Console.WriteLine("3-Çarpma");
            Console.WriteLine("4-Bölme");
            Console.WriteLine("5-KDV");

            string secim = Console.ReadLine();
            Console.WriteLine("Birinci Sayıyı Giriniz: ");


            var sayı1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("İkinci Sayıyı Giriniz: ");


            var sayı2 = Convert.ToDouble(Console.ReadLine());

            if (secim == "Toplama")

            {
                Console.WriteLine("Sonuç: " + ToplamaYap(sayı1, sayı2));
            }

            else if (secim == "Çıkarma")
            {
                Console.WriteLine("Sonuç: " + Cıkarmayap(sayı1, sayı2));
            }

            else if (secim == "Çarpma")
            {
                Console.WriteLine("Sonuç: " + CarpmaYap(sayı1, sayı2));
            }


            else if (secim == "Bölme")

                if (sayı2 == 0)

                { Console.WriteLine("Bir Sayı Sıfıra Bölünemez"); }

                else
                {
                    Console.WriteLine("Sonuç: " + BölmeYap(sayı1, sayı2));
                }

            else if (secim == "KDV")

            {
                Console.WriteLine("Kdv Oranı Giriniz: ");
                var KdvOrani = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Sonuç: " + KdvBul(sayı1, KdvOrani));
            }

            else
            {
                Console.WriteLine("Yanlış Bir Değer Girdiniz. Lütfen Tekrar Deneyiniz !!!");
            }
        }

        static double ToplamaYap(double sayı1, double sayı2)

        {
            return sayı1 + sayı2;
        }

        static double Cıkarmayap(double sayı1, double sayı2)

        {
            return sayı1 - sayı2;
        }

        static double CarpmaYap(double sayı1, double sayı2)

        {
            return sayı1 * sayı2;
        }

        static double BölmeYap(double sayı1, double sayı2)

        {
            return sayı1 / sayı2;
        }

        static double KdvBul(double sayı1, double sayı2)

        {
            return sayı1 * sayı2 / 100;
        }
    }
}
