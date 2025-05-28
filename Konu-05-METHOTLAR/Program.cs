namespace Konu_05_METHOTLAR
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //---------------- METOTLAR ------------------


            Console.WriteLine("METOTLAR");    
            ToplamaYap(); // Metot çağrısı olamadan ekrana yazdırmaz.
            ToplamaYap(50, 8);

            Console.WriteLine("Geriye Döndüren Metot: ");
            int sonuc = ToplamaYap(10, 20, 30); // Metot çağrısı yapıldıktan sonra geriye dönen değer değişkene atanır.

            Console.WriteLine("Sonuç: " + sonuc);
        }

        static void ToplamaYap()
        {
            Console.WriteLine(10 + 8);
            
        }

        // void olan metotlar geriye değer döndürmez.

        // Aynı isimde metotlar farklı marametrelerde kullanılırsa bu metot aşırı yükleme (overloading) olarak adlandırılır.

        //metot kullanımında kullanılan parametreler (Sayı1 Sayı2) metotun kullanıldığı yerde metoda gönderilmek zorundaıdır.
        //aksi halde hata verilir.

        static void ToplamaYap( int sayı1 , int sayı2)
        {
            Console.WriteLine("Sonuç: " +(sayı1 + sayı2));

        }

        static int ToplamaYap(int sayı1, int sayı2 ,int sayı3)

        // Geriye döndürülen metotllarda metot isminin önüne geriye döndürülecek veri tipini yazmak gerekir.

        // metotun aldığı parametre ile geri dönüş veri tipi aynı olmak zorunda DEĞİLDİR

        // bir metot parametre olarak int, string, double, float, char gibi veri tiplerini alabilir ve
        // geriye de int, string, double, float, char gibi veri tiplerini döndürebilir.


        {
            return sayı1 + sayı2 + sayı3; // int olan metotlar geriye değer döndürür. Return ifadesi ile geriye değer döndürülür.

        }

    }
}
