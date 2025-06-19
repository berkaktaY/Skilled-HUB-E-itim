using System.Reflection.Emit;

namespace Konu_12_Kalıtım_İNHERİTANCE
{
    class Arac
    {
        public string AracTuru;
        public void KornaCal()
        {
            Console.WriteLine("Aracın Kornası Çaldı");
        }

        
    }
    class Otomobil : Arac// Motorsiklet üst üste nokta koyduğumuzda araç sınıfını 
                         // eklersek motorsiklet sınıfında da aynı özellikler kullanılmış olur        
    {
        public string Marka { get; set; }
        public string Model { get; set; }
    }

    class yat : Arac
    {
        public int Uzunluk { get; set; }
        public int Kamara { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
         
            Console.WriteLine("Kalıtım Yapısı- İnheritance");

            Arac arac = new Arac();
            arac.AracTuru = "Araba";
            Console.WriteLine("Araba Türü: " + arac.AracTuru);
            Console.WriteLine();

             Otomobil otomobil = new Otomobil();
            otomobil.AracTuru = "Otomobil"; // normalde otomobil class araç türü yok
            Console.WriteLine("Araç türü: " + otomobil.AracTuru);
            otomobil.KornaCal(); // korna çal metodu bir üst sınıf olan arac sınıfından geliyor
            Console.WriteLine();

            yat Yat = new();
            Yat.AracTuru = "Gökselen Yat";
            Console.WriteLine("Araç Türü: " + Yat.AracTuru);
            Yat.KornaCal();
            Console.WriteLine();

            Kategori kategori = new()
            {
                Name = "Elektronik",
                ÜstMenüdeGöster = true,
                CreateDate = DateTime.Now,

            };
            if (kategori.ÜstMenüdeGöster == true)
            {
                Console.WriteLine($"Ürün Bilgileri: \n Ürün Adı: {kategori.Name} - Eklenme Tarihi: {kategori.CreateDate}");
            }

            Console.WriteLine();

            Urun ürün = new()
            {
                Name ="Klavye",
                Fiyat=299,
                KDV=20,
                CreateDate= DateTime.Now,
            };

            Console.WriteLine($"Ürün bilgileri: \n Ürün Adı: {ürün.Name} - Ürün Fiyatı: {ürün.Fiyat}" +
                $"Ürün KDV: {ürün.KDV} - Eklenme Tarihi: {ürün.CreateDate}");
            Console.WriteLine();

            Çizici[] Bircizici = new Çizici[4];
            Bircizici[0] = new Çizici();
            Bircizici[1] = new DaireCiz();
            Bircizici[2] = new KareCiz();
            Bircizici[3] = new DogruCiz();

            foreach (var item in Bircizici)
            {
                item.Ciz(); // çiz metodunu çalıştırır
            }
            

            

        }

        //--------- Polifornizm Çokbiçimlilik ------------

        public class Çizici
        {
            public virtual void Ciz()// virtual ile bu metodu override-ezilebilir 
                // hale getiriyoruz
            {
                Console.WriteLine("Çizici");
            }
        }

        public class DaireCiz:Çizici
        {
            public override void Ciz() 
            {
                Console.WriteLine("Daire");
            }
        }

        public class KareCiz : Çizici
        {
            public override void Ciz()
            {
                Console.WriteLine("Kare");
            }
        }
        public class DogruCiz : Çizici
        {
            public override void Ciz()
            {
                Console.WriteLine("Düz Çizgi");
            }
        }
    }
}
