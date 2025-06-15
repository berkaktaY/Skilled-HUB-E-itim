using System.Reflection.Metadata;

namespace Propartys_Deneme_KırmızıSite
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Misafir Giriş-1");
            Console.WriteLine("Giriş Yap-2");
            var secim = Console.ReadLine();

            if (secim == "1")
            {
                Console.WriteLine("Anasayfaya Yönlendiriliyorsunuz");
            }

            else if (secim == "2")
            {
                UserOpen Kullanıcı = new();

                Console.WriteLine("Email : ");
                Kullanıcı.Email = Console.ReadLine();

                Console.WriteLine("Şifre : ");
                Kullanıcı.Password = Console.ReadLine();

                var open = Kullanıcı.Users(Kullanıcı.Email, Kullanıcı.Password);

                if (open == true)
                {
                    Console.WriteLine("Hoşgeldiniz" + Kullanıcı.Name);

                    Console.WriteLine("Yapmak İstediğniz İşlem Nedir" + Kullanıcı.Name);
                    Console.WriteLine("Araç Ekle-1");
                    Console.WriteLine("Araç Sil-2");
                    Console.WriteLine("Araç Güncelle-3");
                    Console.WriteLine("İlanda Ki Aracım-4");

                    var secım2 = Console.ReadLine();

                    if (secım2 == "1")

                    {
                        CarData1 Cars = new CarData1

                        {
                            CarName = "Ford",
                            ID = 1,
                            Payments = 425000,
                            CarYear = 2008,
                            CarKM = 189587,
                            CarColor = "Siyah",
                            CarExplanation = "Aracımda güneş yanıkları mevcut , bakımları zamanında yapılmıştır"
                        };

                        CarDataMethots CarS = new();
                        CarS.CarAdd(Cars);
                        Console.WriteLine($"Arac Bilgileri: {Cars.CarName} Aracın Modeli: {Cars.CarModel} Arac yılı: {Cars.CarYear} Aracın Km Bilgisi: {Cars.CarKM} Aracın rengi: {Cars.CarColor} Arac Açıklama: {Cars.CarExplanation}");


                    }

                    else if (secım2 == "2")
                    {
                        CarData1 Cars = new CarData1

                        {
                            CarName = "Ford",
                            ID = 1,
                            Payments = 425000,
                            CarYear = 2008,
                            CarKM = 189587,
                            CarColor = "Siyah",
                            CarExplanation = "Aracımda güneş yanıkları mevcut , bakımları zamanında yapılmıştır"
                        };

                        CarDataMethots CarS = new();
                        CarS.CarUpdate(Cars);

                        Console.WriteLine($"Arac Bilgileri: {Cars.CarName} Aracın Modeli: {Cars.CarModel} Arac yılı: {Cars.CarYear} Aracın Km Bilgisi: {Cars.CarKM} Aracın rengi: {Cars.CarColor} Arac Açıklama: {Cars.CarExplanation}" );
                    }

                    else if (secım2 == "3")
                    {
                        CarData1 Cars = new CarData1

                        {
                            CarName = "Ford",
                            ID = 1,
                            Payments = 425000,
                            CarYear = 2008,
                            CarKM = 199587,
                            CarColor = "Siyah",
                            CarExplanation = "Aracımda güneş yanıkları mevcut , bakımları zamanında yapılmıştır" +
                            ""
                        };
                        CarDataMethots CarS = new();
                        CarS.CarClean(Cars);

                        Console.WriteLine($"Arac Bilgileri: {Cars.CarName} Aracın Modeli: {Cars.CarModel} Arac yılı: {Cars.CarYear} Aracın Km Bilgisi: {Cars.CarKM} Aracın rengi: {Cars.CarColor} Arac Açıklama: {Cars.CarExplanation}");
                    }

                    else if (secım2 == "4")
                    {

                        
                        foreach (var item in CarDataMethots.ActiveCars())
                        {
                            Console.WriteLine("Arac İsmi: " + item.CarName);
                            Console.WriteLine("Arac Model: " + item.CarModel);
                            Console.WriteLine("Arac Yılı: " + item.CarYear);
                            Console.WriteLine("Arac Kilometre Bilgisi: " + item.CarKM);
                            Console.WriteLine("Arac Rengi: " + item.CarColor);
                            Console.WriteLine("Arac Tipi: " + item.CarType);
                            Console.WriteLine("Arac Açıklama: " + item.CarExplanation);
                            Console.WriteLine();
                        }
                    }

                    else
                    {
                        Console.WriteLine("Hatalı Şifre veya Kullanıcı Adı");
                    }

                }



            }
        }

    }
}





