using System.Globalization;

namespace PROJE_1______HESAP_MAKİNESİ
{
    internal class Program
    {
        static void Main(string[] args)
        {

             // ------------------------- HESAP MAKİNESİ -------------------------



Console.WriteLine("Yapmak İstediğiniz İşlemi Seçiniz Lütfen:");

Console.WriteLine("1-Toplama");
Console.WriteLine("2-Çıkarma");
Console.WriteLine("3-Çarpma");
Console.WriteLine("4-Bölme");
Console.WriteLine("5-Mod Alma");

Console.WriteLine("Lütfen Sayısal Olarak Seçiniz: ");

string Secim = Console.ReadLine();


Console.WriteLine("Birinci Sayıyı Giriniz: ");

var Sayı1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("İkinci Sayıyı Giriniz: ");

var Sayı2 = Convert.ToInt32(Console.ReadLine());

if (Secim == "1")
{
    Console.WriteLine("Sonuç: " + (Sayı1 + Sayı2));

}

else if (Secim == "2")
{
    Console.WriteLine("Sonuç: " + (Sayı1 - Sayı2));

}
else if (Secim == "3")
{
    Console.WriteLine("Sonuç: " + (Sayı1 * Sayı2));

}
else if (Secim == "4")
{
    Console.WriteLine("Sonuç: " + Sayı1 / Sayı2);

}
else if (Secim == "5")
{
    Console.WriteLine("Sonuç: " + (Sayı1 % Sayı2));

}
else
{
    Console.WriteLine("Yanlış Bir Değer Girildi !!");
}

}

}

}




