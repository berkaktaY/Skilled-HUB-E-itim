namespace Konu_10_String_Sinifi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu10--String--Sinifi");

            string Degisken;
            char Karakter = 'f'; // Char tek karakter alır            
            string Metinlerİcin = "Metinler İçin mi Kullanıyorduk";
            Console.WriteLine(Metinlerİcin);
            Ornek1();
            StringMetotları();
            SplitMetodu();
        }

        static void Ornek1()
        {
            string BirMetin = "Ankara Başkenttir";
            String BirSayı = "06";
            System.String BirTarih = "17-06-2025";
            string kod = "//abcdef123\n";
            // burada \n kodu enter görevi görür ve bir sonraki satıra yazdırır.

            Console.WriteLine(BirMetin.GetType());
            Console.WriteLine(BirSayı.GetType());
            Console.WriteLine(BirTarih.GetType());
            Console.WriteLine(kod);

            string s = "Berk Aktay";
            Console.WriteLine("For DÖngüsü Çıktısı");
            for (int i = 0; i <s.Length; i++) // lenght = karakter sayısı kadar döner
            {
                Console.WriteLine("s[" + i + " ] = " + s[i]);
            }

            Console.WriteLine("Foreach Döngüü Çıktısı");

            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
        }

        static void StringMetotları()
        {
            string metin = "Stringin bir çok metotları vardır";
            Console.WriteLine("metin'in karakter sayısı metin.lenght= " + metin.Length);
            // lenght metinde kaç karakter olduğunu gösterir

            var klon = metin.Clone();
            // clone metodu metin değişkeninin klonlayıp klon değişkenine atar

            Console.WriteLine("metin klonu= " + klon);
            metin = "My name is Berk";
            Console.WriteLine(metin + " " + metin.EndsWith("k"));
            // endswith son karakteri doğru mu
            Console.WriteLine(metin + " " + metin.StartsWith("M"));
            // startswith ilk yazılan karakter doğru mu

            Console.WriteLine();

            Console.WriteLine(metin + " Index OF name= " + metin.IndexOf("name"));
            // indexOf cümlede bulmak istediğimiz kelimeyi bulur
            Console.WriteLine(metin + " Index OF name= " + metin.IndexOf("Name"));

            Console.WriteLine();

            Console.WriteLine(metin + " Last Index OF= " + metin.LastIndexOf("k"));
            // birden fazla karakter olduğunda en son karakteri getirir

            Console.WriteLine();

            Console.WriteLine(metin + " Insert 0= " + metin.Insert(0 , "Merhaba "));
            // ınsert sabit bir metne sonradan ekleme yapmak için kullanılır
            Console.WriteLine(metin);

            Console.WriteLine();
            Console.WriteLine(metin + " Substring= " + metin.Substring(2));

            // string yapısını bölmeye yarar            // string yapısını parçalamaya yarar
            Console.WriteLine(metin + " Substring= " + metin.Substring(2,5));
            // string yapısını parçalamaya yarar 

            Console.WriteLine();

            Console.WriteLine(metin + " Tolower= " + metin.ToLower());
            // metinleri küçük harfe çevirir
            Console.WriteLine(metin + " ToUpper= " + metin.ToUpper());
            // Metinleri büyük harfe çevirir
            Console.WriteLine(metin + " Tolower().replace= " + metin.ToLower().Replace(" " , "-"));
            // cümlede boşluk olan yerlere ne getirlmek isteniliyorsa .Replace kullanılır

            Console.WriteLine();

            Console.WriteLine(metin + " Remove 2 = " + metin.Remove(2));
            // 
            Console.WriteLine(metin + " Remove 2.5 = " + metin.Remove(2,5));









        }

        static void SplitMetodu()
        {
            string Sehirler = "Ankara,İstanbul,İzmir,Balıkesir,Batman,Kars,Antalya";
            string[] SehirlerArry = Sehirler.Split(',');
            Console.WriteLine("4.sehir= " + SehirlerArry[3]);
            foreach (var item in SehirlerArry)
            {
                Console.WriteLine("Şehir: " + item);
            }

            Console.WriteLine();

            Console.WriteLine("Tarih Parçalama");
            var tarih = DateTime.Now.ToShortDateString();
            Console.WriteLine("Tarih: " + tarih);
            var TarihParcaları = tarih.Split(".");
            var gün = TarihParcaları[0];
            var ay = TarihParcaları[1];
            var yıl = TarihParcaları[2];
            Console.WriteLine("\nGün: " + gün + "\n Ay: " + ay + "\n Yıl: " + yıl);
        }
    }

}

