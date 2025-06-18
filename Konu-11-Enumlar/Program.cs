namespace Konu_11_Enumlar
{
    internal class Program
    {
        //Enum(Numaratör) lar öğeleri numaralandırmak için kullanılır
        /* * Enum tipler üzerindeki kısıtlamalar 
         * * 1-Enum bloğunda metot tanımlanamaz 
         * * 2-Arayüz(Interface) kullanamazlar 
         * * 3-enum blokunda özellik kullanılmaz 
         */

        enum Aylar : byte// byter koleksiyonda ki numaraların
                         // veri tipinin byte olacağoını belirtir
            {
                Ocak,Şubat,Mart,Nisan,Mayıs,Haziran,Temmuz
                ,Ağustos,Eylül,Ekim,Kasım,Aralık
            }

        enum SiparişDurumu
        {
            Hazırlanıyor, Hazırlandı, KargoBekleniyor, KargoyaVerildi
        }

        enum Meyveler : int
        {
            Elma=3,Armut=7,Şeftali=1//sıra numarsını kendimiz de atayabiliriz
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Konu-11-ENUMLAR");

            byte a = (byte)Meyveler.Armut;
            byte b = (byte)Meyveler.Elma;
            byte c = (byte)Meyveler.Şeftali;
            Console.WriteLine($"{Meyveler.Armut}= {a} , {Meyveler.Elma} = {b} , {Meyveler.Şeftali} = {c}");
            Ornek1(SiparisDurumu:1);
        }

        static void Ornek1(int SiparisDurumu)
        {
            if (SiparisDurumu == (int)SiparişDurumu.Hazırlanıyor) ;
            Console.WriteLine("Siparişiniz Hazırlanıyor");

            if (SiparisDurumu == (int)SiparişDurumu.Hazırlandı);
            Console.WriteLine("Siparişiniz Hazırlandı");

            if (SiparisDurumu == (int)SiparişDurumu.KargoBekleniyor) ;
            Console.WriteLine("Siparişiniz Kargoyu Bekliyor");

            if (SiparisDurumu == (int)SiparişDurumu.KargoyaVerildi) ;
            Console.WriteLine("Siparişiniz Kargolandı");

        }
    }
}
