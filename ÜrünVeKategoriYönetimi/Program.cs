using Microsoft.VisualBasic;
using System.ComponentModel.Design;

namespace ÜrünVeKategoriYönetimi
{
    internal class Program
    {
        static VEriYönetimi VeriYönetimi = new();
        static void Main(string[] args)
        {
            Console.WriteLine("--- Ürün ve Kategori Yönetim Sistemine Hoş Geldiniz ---");
            Console.WriteLine();

            

            while (true) // süreklilik
            {
                Console.WriteLine("\n\nYapmak İstediğiniz İşlemi Seçin");
                Console.WriteLine("\n\n\n1. Kategori Ekle");
                Console.WriteLine("\n\n\n2. Kategori Güncelle");
                Console.WriteLine("\n\n\n3. Kategori Sil");
                Console.WriteLine("\n\n\n4. Ürün Ekle");
                Console.WriteLine("\n\n\n5. Ürün Güncelle");
                Console.WriteLine("\n\n\n6. Ürün Sil");
                Console.WriteLine("\n\n\n7. ÇIKIŞ");

                Console.WriteLine("Seçiminiz: ");
                var Secim=Console.ReadLine();

                if (Secim == "1")
                {
                    Console.WriteLine("--------- KATEGORİ EKLE ------------");
                    Console.WriteLine("Kategori ID: ");
                    int ıd = int.Parse(Console.ReadLine());
                    Console.WriteLine("KAtegori Adı: ");
                    string ad = Console.ReadLine();

                    Kategori YeniKategori = new Kategori(ıd, ad);
                    VeriYönetimi.KategoriEkle(YeniKategori);


                }

                else if (Secim == "2")
                {
                    Console.WriteLine("----------- KATEGORİ GÜNCELLE ---------");
                    Console.WriteLine("Kategori ID: ");
                    var ıd = int.Parse(Console.ReadLine());
                    Console.WriteLine("Yeni Kategori Adı: ");
                    string YeniKatAdı = Console.ReadLine();
                    Console.WriteLine("Stokta Mı?");
                    bool stok = bool.Parse(Console.ReadLine());

                    Kategori GüncelKategori = new Kategori(ıd, YeniKatAdı);
                    GüncelKategori.AktifMi = true;
                    VeriYönetimi.KategoriGüncelle(GüncelKategori);
                }

                else if (Secim == "3")
                {
                    Console.WriteLine("---------- KATEGORİ SİL -----------");
                    Console.WriteLine("Silinecek KAtegori ID: ");
                    var Id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Silinecek Kategori Adı: ");
                    string Idad = Console.ReadLine();

                    Kategori SilinecekKategori = new Kategori(Id, Idad);

                }

                else if (Secim == "4")
                {
                    Console.WriteLine("------------- ÜRÜN EKLE -------------");
                    Console.WriteLine("ÜRÜN ID: ");
                    var urunID=int.Parse(Console.ReadLine());
                    Console.WriteLine("Ürün Adı:");
                    string urunAd= Console.ReadLine();

                    URUNLER yeniUrun = new URUNLER(urunID, urunAd);
                    VeriYönetimi.UrunEkle(yeniUrun);
                }
                else if(Secim == "5" )
                {
                    Console.WriteLine("------------ ÜRÜN GÜNCELLE -----------");
                    Console.WriteLine("Ürün ID: ");
                    var UrunId=int.Parse(Console.ReadLine());
                    Console.WriteLine("Yeni Ürün Adı: ");
                    string UrunAd= Console.ReadLine();
                    Console.WriteLine("Stokta Mı: ");
                    bool Stokvar =bool.Parse(Console.ReadLine());

                    URUNLER UrunGuncel = new URUNLER(UrunId, UrunAd);
                    UrunGuncel.AktifMi = true;
                    VeriYönetimi.UrunGuncelle(UrunGuncel);
                }
                else if(Secim == "6")
                {
                    Console.WriteLine("-------------- ÜRÜN SİL --------------");
                    Console.WriteLine("Silinecek Ürün ID: ");
                    var SilID=int.Parse(Console.ReadLine());
                    Console.WriteLine("Silinecek Ürün Adı: ");
                    string SilAd= Console.ReadLine();

                    URUNLER SilUrunler = new URUNLER(SilID, SilAd);
                }

                else if(Secim == "7" )
                {
                    Console.WriteLine($"{DateTime.Now} İyi Günler");
                    return;
                }

                else
                { Console.WriteLine("HATA06: Hatalı Bir Giriş Yaptınız.LÜTFEN TEKRAR DENEYİNİZ!!!"); }
            }
        }
    }
}