using System.ComponentModel.Design;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

namespace Konu_13_Kapsülleme_EnKapsulation
{
    internal class Program
    {
        public class Bölüm()
        {
            private string BölümAdı; // Dışarıdan erişime kapalı değişkenimiz // Accessor Getter

            public string GetBölümAdı()
            {
                return BölümAdı; // Geriye Private BölümAdı değişkenini döndüren metot
            }

            public void SetBölümAdi(string İstenenEğitim)
            {
                if (İstenenEğitim == "Yazılım Mühendisliği")
                {
                    Console.WriteLine("Üniversitemizde {0} Bölüm Bulunmamaktadır", İstenenEğitim);

                }

                else BölümAdı = İstenenEğitim;
            }
            // Özgen (Property) Kullanarak Kapsülleme

            public class Fakülte()
            {
                private string bölüm;
                // Fakülte sınıfıın içinde ki bölüm değişkenini private tanımlayarak kapsüllemiş oluruz
                // Böylece bu değişkene sadece get set metoduyla erişilebilir

                public string Bölüm
                {
                    get { return bölüm; }
                    //get içindeki return(dön) bloğunun anlaşılacağı üzere geriye içeride ki private
                    //tanımladığımız kapsüllenen bölüm değişkenine atanan veriyi döndürür
                    set
                    {
                        if (value == "Yazılım Mühendisliği")
                        {
                            Console.WriteLine("Üniversitemizde {0} Bölüm Bulunmamaktadır", value);

                        }

                        else bölüm = value;
                    }
                    // set bloğu ise dışarıya acık bölüm değişkenine atanan veriyi alıp içeride
                    // kapsüllediğimiz private bölüm değikenine atar
                }
            }

            //  Yalnız Okunur (Read Only Property)
            public class Üniversite
            {
                private string Bölüm;
                public Üniversite(string str)
                {
                    Bölüm = str;
                }
                public string bölüm
                {
                    get
                    {
                        return Bölüm;
                    }

                static void Main(string[] args)
        {

            Console.WriteLine("------ Kapsülleme // EnKapsülation --------");


            // Olası Yanlışlar olmaması için kullanılır//

            Bölüm bölüm = new Bölüm();
            Console.WriteLine("Kurumumuzda Ki Böülümler");
            Console.WriteLine("\n 1-Elektronik");
            Console.WriteLine("\n 2-Bilgasayar Mühendisliği");
            Console.WriteLine("\n 3-Grafik Tasarım");
            Console.WriteLine("Lütfen Bölüm Adını Giriniz: ");
            var BölümAdı = Console.ReadLine();
            // Ekrandan alınan değeri okuyup var ile BölümAdi na atadık
            bölüm.SetBölümAdi(BölümAdı);
            // Bölüm içerisinde ki SetBölümAdı na bölüm adını gönderdik ,private değişkenine atama yapıldı
            Console.WriteLine();
            Console.WriteLine("Kayıt Olunacak Bölüm Adı:" +
            bölüm.GetBölümAdı);
            // bölüm içerisinde ki GetBölümAdı() metodunu direct ekrana yazdırdık

            Fakülte fakülte = new Fakülte()
            {
                Bölüm = "Yazılım mühendisliği"
            };
            Console.WriteLine("Fakülte = {0} {1}" , fakülte.Bölüm, "2.Değer");

                    Üniversite üniversite = new("Maliye");
                    
                    Console.WriteLine("Üniversite Bölümü= ", üniversite.bölüm);

        }
    }
    
        }







    }
}
    



    


    



