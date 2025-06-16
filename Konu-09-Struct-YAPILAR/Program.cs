
namespace Konu_09_Struct_YAPILAR
{

    public struct Yapi

    {


        // public struct ad= "ALİ"; struct kullanımında class dan farklı olarak
        //öğelere başlangıç değeri atanmaz

        public int sayi;
        public string metin;
        public void metot()
        {
            Console.WriteLine("Yapı içinde ki metot çalıştı");
        }
    }
    internal class Program
    {

        struct Kimlik
        {
            public string Ad;
            public string Soyad;
            public int Yas;
            public string DogumYeri;

            public struct Adres
            {
                 public int Id { get; set; }
                 public int KapıNo { get; set; }
                 public string Sehir { get; set; }
                 public string İlce { get; set; }
                 public string AcıkAdres { get; set; }
        
             }

            internal string Birlestir(string Ad,string Soyad)
            {
                return Ad + " " + Soyad.ToUpper();
            }
            
            public void ToplamYaz(int sayı1,int sayı2)
            {
                Console.WriteLine("Sayı-1 ve Sayı-2 Toplamı:");
                Console.WriteLine(sayı1+sayı2);
            }

            
        }
static void Main(string[] args)
{
    Console.WriteLine("STRUCT-----YAPILAR!");
    
        Yapi İlkyapi = new Yapi();
            İlkyapi.metin = "İlk Yapı";
            İlkyapi.sayi = 18;
            İlkyapi.metot();
            Console.WriteLine(İlkyapi.metin);

            // struct ile yapı kurma

            Kimlik Kimliknew = new Kimlik();
            Kimliknew.Ad = "Berk";
            Kimliknew.Soyad = "Aktay";
            Kimliknew.Yas = 29;
            Kimliknew.DogumYeri = "Polatlı";

            // struck ile lurulan yapıyı yazdırma

            Console.WriteLine("Kimlik Bilgileri: ");
            Console.WriteLine("Ad: {0} , Soyad: {1}", Kimliknew.Ad , Kimliknew.Soyad );
            Console.WriteLine("Yaş: {0} ", Kimliknew.Yas);
            Console.WriteLine("Doğum Yeri: {0} ",Kimliknew.DogumYeri);

            Console.WriteLine(Kimliknew.Birlestir(Kimliknew.Ad,Kimliknew.Soyad));
            Kimliknew.ToplamYaz(10, 8);

            Kimlik.Adres adres = new Kimlik.Adres();
            adres.AcıkAdres = "Ahievran mahallesi diyet sokak no:24-1";
            adres.İlce = "Sincan";
            adres.Sehir = "ANKARA";
            Console.WriteLine();

            Console.WriteLine("Kullanıcı Adres Bilgileri");
            Console.WriteLine();

            Console.WriteLine("\tŞehir: {0}" , adres.Sehir);
            Console.WriteLine("\tİlçe: {0}",adres.İlce);
            Console.WriteLine("\tAçık adres: {0}",adres.AcıkAdres);
            
        
        }
    }
}
