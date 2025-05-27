namespace Konu_3_OERATÖRLER
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //---------- 1-ARİTMETİK OPERATÖRLER ----------

            int Sayı1= 3;
            int Sayı2 = 4;
            int SAyı3 = 5;
            Console.WriteLine(Sayı1+Sayı2+SAyı3);// Toplama işlemi         
            Console.WriteLine(Sayı1/Sayı2/SAyı3);// Bölme işlemi         
            Console.WriteLine(Sayı1*Sayı2*SAyı3);// çarpma işlemi         
            Console.WriteLine($"Sayılar: Sayı1: {Sayı1} Sayı2: {Sayı2} Sayı3: {SAyı3}" );
            // String tırnağınınn önüne $ işaretini koyarak  Interpolation ile değişkenleri yazdırma

            Console.WriteLine("1234" + SAyı3);
            // String ile int türünü birleştirme (+) işlemi yapılırsa string türü öncelikli olduğu için int türü string türüne dönüşür ve string olarak yazdırılır.

            Console.WriteLine();

            // --------- Hesaplama İşlemleri ----------

            Console.WriteLine("HEsaplama İşlemleri: ");
            Console.WriteLine("Sayı1 + Sayı2: " + (Sayı1 + Sayı2));
            Console.WriteLine("Sayı1 - Sayı2: " + (Sayı1 - Sayı2));
            Console.WriteLine("Sayı1 / Sayı2: " + (Sayı1 / Sayı2));
            Console.WriteLine("Sayı1 * Sayı2: " + (Sayı1 * Sayı2));
            Console.WriteLine("Sayı1 % Sayı2: " + (Sayı1 % Sayı2));

            // --------- Artırma ve Azaltma İşlemleri ----------

            Console.WriteLine();

            Console.WriteLine("Artırım ve Azaltım Operatörleri");

            Sayı2++; // Sayı2'yi 1 artırır

            Console.WriteLine("Sayı2: " + Sayı2);

            Sayı2--; // Sayı2'yi 1 azaltır

            Console.WriteLine("Sayı2: " +Sayı2);

            Console.WriteLine();

            // ----------- Atama Operatörleri ----------

            Console.WriteLine("Atama Operatörleri");

            Console.WriteLine($"Sayılar: Sayı1: {Sayı1} Sayı2: {Sayı2} Sayı3: {SAyı3}");
            Console.WriteLine("Sayı1 += Sayı2: " + (Sayı1 += Sayı2));
            Console.WriteLine("Sayı1 -= Sayı2: " + (Sayı1 -= Sayı2));
            Console.WriteLine("Sayı1 /= Sayı2: " + (Sayı1 /= Sayı2));
            Console.WriteLine("Sayı1 *= Sayı2: " + (Sayı1 *= Sayı2));
            Console.WriteLine("Sayı1 %= Sayı2: " + (Sayı1 %= Sayı2));

            Console.WriteLine();

            // --------- İlişkisel Operatörler ----------

            Console.WriteLine("İlişkisel Operatörler");
            // İlişkisel operatörler, iki değeri karşılaştırmak için kullanılır ve boolean (true/false) değer döner.

            Console.WriteLine($"Sayılar: Sayı1: {Sayı1} Sayı2: {Sayı2} Sayı3: {SAyı3}");

            Console.WriteLine("Sayı1 Sayı 2 ye eşit mi?: " + (Sayı1 == Sayı2));
            Console.WriteLine("Sayı1 Sayı 2 den eşit değil mi?: " + (Sayı1 != Sayı2));
            Console.WriteLine("Sayı1 Sayı 2 den küçük mü?: " + (Sayı1 < Sayı2));
            Console.WriteLine("Sayı1 Sayı 2 den büyük mü?: " + (Sayı1 > Sayı2));
            Console.WriteLine("Sayı1 Sayı 2 den büyük mü veya eşit mi?: " + (Sayı1 >= Sayı2));
            Console.WriteLine("Sayı1 Sayı 2 den küçük mü veya eşit mi?: " + (Sayı1 <= Sayı2));
            Console.WriteLine();

            // --------- Ternay Operatörler ----------

            Console.WriteLine("Ternary Operatörler");
            // Ternary operatörler, bir koşulu kontrol etmek için kullanılır ve iki farklı değer döner.

            Console.WriteLine("Ternary: " + ((Sayı1 == Sayı2) ? "Sayı 1 Sayı 2 ye eşit" : " Sayı 1 Sayı 2 ye eşit değil: "));

            Console.WriteLine();
            Console.WriteLine("Ternary: " + ((Sayı1 == Sayı2) ? $"Sayı 1 ({Sayı1}) Sayı 2 ({Sayı2}) ye eşit" : $" Sayı 1 ({Sayı1}) Sayı 2 ({Sayı2}) ye eşit değil: "));

            Console.WriteLine();

            // ------------ MAntıksal Operatörler ----------

            Console.WriteLine("Mantıksal Operatörler");

            Console.WriteLine();

            Console.WriteLine("and & Operatörü");

            Console.WriteLine($"Sayılar: Sayı1: {Sayı1} Sayı2: {Sayı2} Sayı3: {SAyı3}");
            Console.WriteLine("Sayı1 Sayı 2 ye eşit mi?: " + (Sayı1 == Sayı2));
            Console.WriteLine("Sayı1 Sayı 2 den büyük mü?: " + (Sayı1 > Sayı2));
            Console.WriteLine("Sayı 1 Sayı 2 ye eşit mi VE Sayı 1 Sayı 2 den küçük mü: " + ((Sayı1==Sayı2) && (Sayı1<Sayı2)));
            // sonuçların her hangi biri FALSE olursa sonuç FALSE olur. tamamı TRUE dönmesgerekir.
            Console.WriteLine();

            // ------------ VEya Operatörü ----------

            Console.WriteLine("VEYA OPERATÖRÜ: || simgesi");

            Console.WriteLine($"Sayılar: Sayı1: {Sayı1} Sayı2: {Sayı2} Sayı3: {SAyı3}");

            Console.WriteLine("Sayı 1 Sayı 2 ye eşit mi VEYA Sayı 1 Sayı 2 den küçük mü: " + ((Sayı1 == Sayı2) || (Sayı1 < Sayı2)));










        }
    }
}
