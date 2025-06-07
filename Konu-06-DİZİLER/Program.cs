namespace Konu_06_DİZİLER
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Diziler!");

            // dizi oluşturma

            int[] sayi;
            int[] ögrenciler = new int[6]; // öğrenciler isimli veri tipi taşıyan ve
            //7 elemandan oluşan bir dizi oluşturduk dizi boyutu artmaz - azalmaz

                    // dizilerde indis denilen yapı vardır ve içine eklenevcvek yapılar 0 dan başlar
            ögrenciler[0] = 100; // diziye veri atama
            ögrenciler[1] = 200; // diziye veri atama
            ögrenciler[2] = 300; // diziye veri atama
            ögrenciler[3] = 400; // diziye veri atama
            ögrenciler[4] = 500; // diziye veri atama
            ögrenciler[5] = 600; // diziye veri atama
            Console.WriteLine("Seçilen Öğrenci No: " + ögrenciler[5]);
            ögrenciler[5] = 550;
            Console.WriteLine("Seçilen Öğrenci No: " + ögrenciler[5]);
            //öğrenciler[6] = 666; // Dizilere başlangıçta kaç eleman olduğu tanımlanmışsa o kadar eleman
                                 // olak zorunda aksi taktirde hatalar verir (new int[6])

            string[] isimler = new string[5];

            isimler[0] = "Berk";
            isimler[1] = "Ayşe";
            isimler[2] = "Buket";
            isimler[3] = "Merve";
            isimler[4] = "İbrahim";

            Console.WriteLine("Kardeşler: " + "/" + isimler[0] +"/" + isimler[2]);
            Console.WriteLine();

            Console.WriteLine("Kardeşler: " + "/" + isimler[1] + "/" + isimler[3] +"/" + isimler[4]);

            Console.WriteLine();

            int[] ogrenciler = { 100, 200, 300, 400, 500 };
            Console.WriteLine("Seçilen Öğrenci No: " + ogrenciler[3]);
            ogrenciler[3] = 550; // yeni girilen veri eski verinin üerine yazar/yerini alır
            Console.WriteLine("Seçilen Öğrenci No: " + ogrenciler[3]);
            Console.WriteLine();

            string[] kategoriler = { "Bilgisayar", "Elektronik", "Cep telefonu", "Beyaz eşya", "Kitap" };
            // dizide ekleneceek kayıt sayısı belirsiz ise bu şekilde diziye ekleme yapılabilir

            Console.WriteLine("Kategoriler 1: " + kategoriler[1]);
            kategoriler[1] = "Aksesuar";
            Console.WriteLine("Kategoriler 1: " + kategoriler[1]);

            string[] ürünler = { "ürün-1", "ürün-2", "ürün-3" };

            Console.WriteLine("Ürün: " + ürünler[1]);
            ürünler[1] = "ürün-3";
            Console.WriteLine("Ürün: " + ürünler[1]);
        }
    }
}
