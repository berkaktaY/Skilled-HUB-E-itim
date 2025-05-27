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



            // --------- Diğer Tür Değişim Yöntemleri ----------

            Console.WriteLine("Diğer Tür Dönüşümleri");

            int TamSayı = 10;

            double KesirliSayı3= 5.25;

            bool İslemSonuc = true;

            Console.WriteLine("Lütfen Bir Sayı Giriniz: ");

            var GirilenDeğer = Console.ReadLine(); // var ' ı kullanıcının gireceği değer belirsiz olduğu için var sayesinde sistem otomatik türünü belirler

            Console.WriteLine("Girilen değerin türü: " + GirilenDeğer.GetType());

            var parsSayı = int.Parse(GirilenDeğer); // Girilen değeri string türünden , int türüne dönüştürür

            Console.WriteLine("int.parse + Tamsayı2: " + (int.Parse(GirilenDeğer)) + TamSayi);
            Console.WriteLine("Double.parse + Tamsayı2: " + (double.Parse(GirilenDeğer)) + TamSayi);

            Console.WriteLine("Decimal.parse + Tamsayı2: " + (decimal.Parse(GirilenDeğer)) + TamSayi);


            //-------------- Convert Tür Dönüşümü --------------

            Console.WriteLine("Convert Tür Dönüşümü");
            Console.WriteLine(Convert.ToString(TamSayı).GetType());
            Console.WriteLine(Convert.ToDouble(TamSayı).GetType());
            Console.WriteLine(Convert.ToInt32(KesirliSayı3).GetType());
            Console.WriteLine(Convert.ToString(İslemSonuc).GetType());

            //---------------- object -----------------

            object nesne = "10153416"; // object türü her türlü veriyi tutabilir

            Console.WriteLine("Nesnenin veri tipi: " + nesne.GetType());

            nesne = Convert.ToDecimal(nesne); // nesne artık decimal türünde

            Console.WriteLine("Nesnenin türü: " + nesne.GetType());
            Console.WriteLine("Nesne değeri: " + nesne);
            


        }

    }
}
