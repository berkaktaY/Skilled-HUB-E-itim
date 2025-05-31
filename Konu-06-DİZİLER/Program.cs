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
        }
    }
}
