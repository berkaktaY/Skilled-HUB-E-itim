namespace Konu_02_TIP_DONUSUMLEI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tip Dönüşümleri");

            // --- Implicit Casting ---- Otomatik dönüşüm
            // ---- Char > Int > long > float > double

            //---- Explicit Casting ---- Manuel Dönüşüm
            // --- Double > Float > Long > Int > Char

            // Implicit Casting daha küçük boyutlu bir türü daha büyük bir bouyat çevirirken otomatik yapar

            Console.WriteLine("Imlicit Casting");

            int sayi = 15;

            double KesirliSayi = sayi; // int dan double a otomatik dönüşür

            Console.WriteLine(sayi);    // çıktı 15

            Console.WriteLine(KesirliSayi); // çıktı 15


            // Explicit Casting türü değerin önüne parantez içine alarak manuel yapar

            Console.WriteLine("Explicit Casting:");

            double sayi2 = 9.75;

            int TamSayi= (int)sayi2;  // double den  int manuel dönüştürme

            Console.WriteLine("Kesirli Sayı Değeri: " + sayi2);
            Console.WriteLine("Tam Sayı Değeri:" + TamSayi);
            Console.WriteLine();
        }
    }
}
