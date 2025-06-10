using System.Diagnostics.Tracing;
using System.Net.Mail;
using System.Threading.Channels;

namespace Konu_8_SINIFLAR_CLASS
{
    internal class EV // Sınıf Tanımlama
    {
        internal string SokakAdi;
        internal int KapiNo;
    }

    /*C# nesnel özelliklerili bir programlama dili olduğu için her şey sınıflar içinde sağlanır. 
     * sınıflara ve sınıflara erişim kısıtlanabilir veya belirli düzeylerde erişime izin verilebilir.
     * Öğelere bağlantıyı kısıtlayan ya da yetki veren anahtar çizelgesine
     * "Erişim Belirteçleri" (erişim değiştiricileri) denir. 
     * * Erişim belirteçleri 4 ana sınıfa ayrılmıştır 
     * * public : Erişim kısıtlaması yoktur, her yerden erişilebilir 
     * * protected : Ait olduğu sınıftan ve o sınıftan türetilen sınıflardan erişilebilir 
     * * internal : Etkin projeye ait sınıflardan erişilebilir, bunların dışında erişilemez 
     * * özel : Yalnız sınıftan erişilebilir, dıştaki sınıflardan erişilemez 
     * * Bir öğe yalnızca 1 belirteci alabilirsiniz 
     * * namespace belirteci alırsınız çünkü o daima public tir
     * * Sınıflar public yada internal nitelemesi alamazlar 
     * * enum erişim belirteci almaz çünkü daima public tir */

    public class deneme
    {
        public string ÜrünAdi = "Public sınıfına herkes erişebilir";

        protected class test // ait olduğu sunuftan ve o sınıftan türetilen sınıfları kapsar

        {
            string ÜrünAdi;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SINIFLAR- CLASSES");

            #region Örnek1

            

            EV İlkEv = new EV(); // soyut bir yapı olan EV sınıfından , somut bir nesne
            // olan İlkEv i oluşturduk

            İlkEv.SokakAdi = "Diyet Sokak";
            İlkEv.KapiNo = 24;

            Console.WriteLine("İlkEv Sokak Adı: " + İlkEv.SokakAdi);
            Console.WriteLine("İlkEv Kapı No: " + İlkEv.KapiNo);

            Console.WriteLine();

            EV YazlıkEv = new EV();

            YazlıkEv.SokakAdi = "Çiçek SOkak";
            YazlıkEv.KapiNo = 7;

            Console.WriteLine("Yazlık Ev Sokak: " + YazlıkEv.SokakAdi);
            Console.WriteLine("Yazlık Ev Kapı No: " + YazlıkEv.KapiNo);

            Console.WriteLine();

            EV KöyEvi = new()

            {

                SokakAdi = "Pınar Sokak", // bu kullanımda ";" yerine " , " kullanılır
                KapiNo = 34

            };

            Console.WriteLine("Köy Evi Sokak: " + KöyEvi.SokakAdi);
            Console.WriteLine("Köy Evi Kapı No: " + KöyEvi.KapiNo);
            #endregion
            Console.WriteLine();
            #region Örnek2

            
            kullanıcı Kullanici = new()
            {
                Ad = "Rüstem Berk",
                Soyad = "Aktay",
                Mail = "Berkaktay56@gmail.com",
                ID = 1,
                KullanıcıAdı = "berkaktaY1",
                Sifre = "berkaktaY1.",
            };

            kullanıcı Aysenur = new()
            {
                Ad = "Ayşenur ",
                Soyad = "Ademir Aktay",
                Mail = "aysenuray@gmail.com",
                ID = 2,
                KullanıcıAdı = "aysenuraydmr",
                Sifre = "aysenuraydemR1.",
            };

            Console.WriteLine("Kullanıcı Bilgileri: ");
            Console.WriteLine("Adı: " + Kullanici.Ad);
            Console.WriteLine("SoyAdı: " + Kullanici.Soyad);
            #endregion
            /*
                        Console.WriteLine("Kullanıcı Adınız: ");
                        var KullanıcıAdi = Console.ReadLine();
                        Console.WriteLine("Şifre Giriniz: ");
                        var KullanıcıSifre= Console.ReadLine();

                        if (KullanıcıAdi == Kullanici.Ad && KullanıcıSifre ==Kullanici.Sifre)
                        {
                            Console.WriteLine("Hoşgeldiniz: " + Kullanici.Ad + " "+ Kullanici.Soyad);
                        }
                        else 
                        {
                            Console.WriteLine("Giriş Başarısız !!!");
                        }
            */

            Console.WriteLine();
            Araba araba = new()
            {
                ID = 1,
                Marka="Ford",
                Model="Fiesta-Comfor",
                Yıl=2008,
                KasaTipi="HatchBack-5",
                VitesTürü="Manuel",
                YakıtTipi="Dizel",
                renk="Siyah",
            };

            Console.WriteLine("Araç Bilgileri: ");
            Console.WriteLine($"Marka:  {araba.Marka} \n Model: {araba.Model} \n yıl: {araba.Yıl} \n Kasa-Tipi: {araba.KasaTipi} \n Vİtes: {araba.VitesTürü} \n Yakıt: {araba.YakıtTipi} \n Renk:{araba.renk}");
        }



    }

    class kullanıcı
    {
        internal int ID;
        internal string KullanıcıAdı;
        internal string Sifre;
        internal string Mail;
        internal string Ad;
        internal string Soyad;
    }

    class Araba
    {
        internal int ID;
        internal string Marka;
        internal string Model;
        internal int Yıl;
        internal string KasaTipi;
        internal string VitesTürü;
        internal string YakıtTipi;
        internal string renk;
    }
}
