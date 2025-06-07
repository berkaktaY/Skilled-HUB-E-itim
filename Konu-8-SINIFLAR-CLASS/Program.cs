using System.Diagnostics.Tracing;

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

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SINIFLAR- CLASSES");

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

            Console.WriteLine();


        }
    }
}
