namespace Konu_4_KARAR_YAPİLARİ
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // ---------- 1-KARAR YAPILARI ----------

            /*
             
            Console.WriteLine("KARAR YAPILARI");

            Console.WriteLine("Lütfen bir Sayı Giriniz: ");

            var Sayı = Convert.ToInt32(Console.ReadLine());

            if (Sayı > 0) // Sayı" değişkeni 0'dan büyükse
            {
                Console.WriteLine("Sayı Pozitif");
            }
            else if (Sayı < 0) // Sayı" değişkeni 0'dan küçükse
            {
                Console.WriteLine("Sayı Negatif");
            }
            else // Sayı" değişkeni 0'a eşitse
            {
                Console.WriteLine("Sayı Sıfır");
            }

            */

            Console.WriteLine("Kullanıcı Adınızı Giriniz: ");

            string KullanıcıAdı = Console.ReadLine();

            Console.WriteLine("Şifrenizi Giriniz: ");

            string Şifre = Console.ReadLine();

            string DoğruKullanıcıAdı = "admin";

            string DoğruŞifre = "12345";

            if (KullanıcıAdı == DoğruKullanıcıAdı && Şifre == DoğruŞifre)

            { Console.WriteLine("Giriş Başarılı"); 
            
            }

            else
                
            { Console.WriteLine("Kullanıcı Adı Hatalı Veya Şifre Yanlış"); }


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

            Console.WriteLine((saat < 12) ? "İyi Günler. Saat: " + saat : ("İyi Akşamlar. Saat: "));

            

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

        }
    }
}
