namespace Konu_4_KARAR_YAPİLARİ
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // ---------- 1-KARAR YAPILARI ----------

            Console.WriteLine("KARAR YAPILARI");

            Console.WriteLine("Lütfen bir Sayı Giriniz: ");

            var Sayı = Convert.ToInt32(Console.ReadLine());

            if (Sayı > 0) // Sayı" değişkeni 0'dan büyükse
            {
                Console.WriteLine("Sayı Pozitif");
            }
            else if (Sayı < 0) // Sayı" değişkeni 0'dan küçükse
            {
                Console.WriteLine("Sayı Negatif");
            }
            else // Sayı" değişkeni 0'a eşitse
            {
                Console.WriteLine("Sayı Sıfır");
            }
        }
    }
}
