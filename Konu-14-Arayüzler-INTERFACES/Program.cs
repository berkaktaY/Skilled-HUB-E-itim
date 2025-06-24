namespace Konu_14_Arayüzler_INTERFACES
{
    interface Arayüz // class yerine interface yazıyoruz
    {
        public int Id { get; set; }

    }

    interface Iicerebilecekler : IDemo
    {
        public int sayı1 { get; set; }

        int sayı { get; set; }

        static int sayı2 { get; set; }

        void topla();
        int ToplamaYap();
    }

    class ArayüzKullanımı : Iicerebilecekler
    {

        public int sayı1 { get; set; }
        public int sayı { get; set; }

        public void Goster()
        {
            Console.WriteLine(sayı1);
        }

        public void topla()
        {
            Console.WriteLine();
        }

        public int ToplamaYap()
        {
            return 18;

        }
    }

    interface IDemo
    {
        void Goster(); // interface sadece bu kadar yazılır metot tanımlanmaz
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("KONU 14: ARAYÜZLER-INTERFACES");

            ArayüzKullanımı arayüzKullanımı = new();
            arayüzKullanımı.sayı1 = 18;
            arayüzKullanımı.Goster();

            Urun URUN = new();
            Console.WriteLine("ÜRün Adı Giriniz? :");
            string urunAdı = Console.ReadLine();
            if(!string.IsNullOrWhiteSpace(urunAdı))
            {
                URUN.Name = urunAdı;
                URUN.Add(URUN.Name);
            }
            else
            {
                Console.WriteLine("Lütfen Bir Ürün Giriniz.");

            }

            Console.WriteLine();

            Console.WriteLine("Kategori Adı Giriniz: ");

            string kategoriadı= Console.ReadLine();

            if(!string.IsNullOrWhiteSpace(kategoriadı))
            {
                Kategori kategori = new();
                kategori.Name=kategoriadı;
                kategori.Add(kategori.Name);
            }

            else
            {
                Console.WriteLine("Lütfen Kategori Adı Giriniz");
            }
        }
    }
}
