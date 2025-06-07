namespace Konu_07_Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DÖNGÜLER!");

            //---------------- 1-FOR DÖNGÜSÜ---------------

            Console.WriteLine("1-FOR DÖNGÜSÜ ");

            for (int i = 0; i < 10; i++)
            // i değişkeni oluştur ve 0 dan başla, i 5 den küçük olduğu sürece dön,her dönüşte i yi 1 arttır
            {
                Console.WriteLine("İ değerinin değeri={0}",i);
            }

            Console.WriteLine();

            //----------------2-WHİLE DÖNGÜSÜ------------------

            Console.WriteLine("2- WHİLE DÖNGÜSÜ");

            int j = 0;// dışarıdan bir değişken tanımlanır
                while (j < 10)// while döngüsünün şartı; anlamı toplam 10 dan küçükse döngü dönsün
            { 

                Console.WriteLine("While sayı = {0}", j); // toplam değerini ekrana yazdırıyoruz

                j++; // toplam sayısını arttırıyoruz
            }

            Console.WriteLine();
            //---------------- 3-Do-While Döngüsü
            Console.WriteLine("3-Do-While Döngüsü"); 
            int toplam = 7;

            do  // şart tutmasa bile önce çalıştırır sonra şarta bakar
            {
                Console.WriteLine("Toplam Değeri: " + toplam);
                
            } while (toplam < 5);

            Console.WriteLine();

            string[] kategoriler = { "Cep telefonu", "bilgisayar", "Elektronik" };

            //---------------- 4- FOREACH DÖNGÜSÜ -----------------------

            Console.WriteLine("4- FOREACH DÖNGÜSÜ");
            Console.WriteLine();

            foreach (string kategori in kategoriler)
                // kategori(dizi öğesi) kategorilerde ki her bir elemanın karşılığını verir
            {

                Console.WriteLine(kategori);

            }

            // İÇ-İÇE DÖNGÜ

            string[] ürünler = { "ürün-1", "ürün-2", "ürün-3" };

            foreach (string kategori in kategoriler)

            {
                Console.WriteLine(kategori);
                foreach(string ürün in ürünler)
                {
                    Console.WriteLine(ürün);
                }
            }

            Console.WriteLine();

            Console.WriteLine("FOR İÇ İÇE DÖNGÜ");

            for (int i = 0; i < 5; i++)

            {
                Console.WriteLine("İ değerinin değeri={0}", i);
                for (int k = 0; k < 3; k++)
                {
                    Console.WriteLine($" \t değerinin değeri {k}"); // \t yazının ortadan başlamsını sağlar
                }
            }



















        }
    }
}
