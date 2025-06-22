using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÜrünVeKategoriYönetimi
{
    public class VEriYönetimi
    {

        //-------------- Maksimum Kapasiteleri Belirleyelim --------------

        private const int MaxKategori = 10; // maksimum kategori
        private const int MaxUrun = 50; // maksimum ürün

        // -------------- Kategori Ve Ürünleri Tutacak Diziler -------------

        private Kategori[] _kategori;
        private URUNLER[] _ürünler;
        // ------------- Mevcut Eleman Sayısı ------------

        private int _kategoriSayısı;
        private int _ürünSayısı;

        public VEriYönetimi()
        {
            _kategori = new Kategori[MaxKategori];
            _ürünler = new URUNLER[MaxUrun];
            _kategoriSayısı = 0;
            _ürünSayısı = 0;

        }

        //---------- Kategori Metotları -----------
        public void KategoriEkle(Kategori YeniKategori)
        {
            if (_kategoriSayısı >= MaxKategori)
            {
                Console.WriteLine("HATA01: Kategori Dolu. Ekleme Yapamazsınız");
                return;
            }

            {

                for (int i = 0; i < _kategoriSayısı; i++)
                    if (_kategori[i].ID == YeniKategori.ID)
                    {
                        Console.WriteLine($"HATA02: {YeniKategori.ID} ID'li Kategori Zaten Mevcut. Kaydedilemedi");
                        return;
                    }

                // --------------- Geçerlilik kontrollerini -------------
                if (YeniKategori.ID <= 0)
                {
                    Console.WriteLine("Hata: Kategori ID'si pozitif olmalı. Kaydedilemedi.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(YeniKategori.Name))
                {
                    Console.WriteLine("Hata: Kategori Adı boş olamaz. Kaydedilemedi.");
                    return;
                }

                Console.WriteLine($"{YeniKategori.Name} adlı kategori (ID: {YeniKategori.ID}) kaydedildi.");

                _kategori[_kategoriSayısı] = YeniKategori;
                _kategoriSayısı++;

                Console.WriteLine($"{YeniKategori} Adlı kategori (ID: {YeniKategori.ID}) Başarıyla Eklenmiştir.");
            }
        }

        public void KategoriGüncelle(Kategori GüncelKategori)
        {
            //------ 1- Güncellenecek Kategoriyi Bul

            if (GüncelKategori.ID <= 0)
            {
                Console.WriteLine("HATA03: Güncellenecek Kategori ID'si Pozitif Olmalıdır");
                return;
            }

            if (string.IsNullOrWhiteSpace(GüncelKategori.Name))
            {
                Console.WriteLine("HATA04: Güncellenecek Kategori Boş OLAMAZ");
                return;
            }

            bool KategoriBulundu = false;

            foreach (var MevcutKategori in _kategori)
            {
                if (MevcutKategori != null && MevcutKategori.ID == GüncelKategori.ID)
                {
                    MevcutKategori.Name = GüncelKategori.Name;
                    MevcutKategori.AktifMi = GüncelKategori.AktifMi;
                    MevcutKategori.GüncellemeTarihi = DateTime.Now;

                    KategoriBulundu = true;
                    Console.WriteLine($"{GüncelKategori.Name} adlı kategori (ID: {GüncelKategori.ID}) başarıyla güncellendi.");
                    break;
                }
            }
            if (!KategoriBulundu)
            {
                Console.WriteLine($"HATA05: {GüncelKategori.ID} Kategori Bulunamadı!!!!");
            }
        }

        public void KategoriSil(int KategoriSil)
        {

            //---------- Silinecek Kategoriyi Bul -----------
            int Baslangıc = -1;

            for (int i = 0; i >= _kategoriSayısı; i++)
            {
                if (_kategori[i] != null && _kategori[i].ID == KategoriSil)
                {
                    Baslangıc = i;
                    break;
                }
            }

            //------------- Kategori Bulundu mu ------------

            if (Baslangıc == -1)
            {
                for (int i = Baslangıc; i < _kategoriSayısı - 1; i++)
                {
                    _kategori[i] = _kategori[i + 1];
                }
                Console.WriteLine($"{KategoriSil} ID'li kategori başarıyla silindi.");
            }
        }

        public void UrunEkle(URUNLER YeniUrun)
        {
            if (_ürünSayısı >= MaxUrun)
            {
                Console.WriteLine("HATA01: Ürün Listesi Dolu. Ekleme Yapamazsınız");
                return;
            }

            for (int i = 0; i <= _ürünSayısı; i++)
                if (_ürünler[i].ID == YeniUrun.ID)
                {
                    Console.WriteLine($"HATA02: {YeniUrun.ID} ID'li Ürün Eklenemedi");
                    return;
                }

            if (YeniUrun.ID <= 0)
            {
                Console.WriteLine("HATA03: ID pozitif bir sayıl olmalıdır.");
                return;
            }

            if (string.IsNullOrWhiteSpace(YeniUrun.Name))
            {
                Console.WriteLine("HATA04: Ürün İSmi Boş Geçilemez");
                return;
            }

            Console.WriteLine($"{YeniUrun.Name} adlı kategori (ID: {YeniUrun.ID}) kaydedildi.");


            _ürünler[_ürünSayısı] = YeniUrun;
            _ürünSayısı++;

            Console.WriteLine($"{YeniUrun} Adlı kategori (ID: {YeniUrun.ID}) Başarıyla Eklenmiştir.");


        }

        public void UrunGuncelle(URUNLER UrunGuncelle)
        {
            if (UrunGuncelle.ID <= 0)
            {
                Console.WriteLine("HATA03: Güncellenecek Ürün ID'si Pozitif Olmalıdır");
                return;
            }
            if (string.IsNullOrWhiteSpace(UrunGuncelle.Name))
            {
                Console.WriteLine("HATA04: Güncellenecek Ürün İsmi Boş Geçilemez");
                return;
            }

            bool UrunBulundu = false;

            foreach (var MevcutUrun in _ürünler)
            {
                if (MevcutUrun != null && MevcutUrun.ID == UrunGuncelle.ID)
                {
                    MevcutUrun.Name = UrunGuncelle.Name;
                    MevcutUrun.AktifMi = UrunGuncelle.AktifMi;
                    MevcutUrun.GüncellemeTarihi = DateTime.Now;

                    UrunBulundu = true;
                    Console.WriteLine($"{UrunGuncelle.Name} adlı ürün ve ID: {UrunGuncelle.ID} numaralı ID güncellenmiştir");
                    break;
                }

            }
            if (!UrunBulundu)
            {
                Console.WriteLine($"HATA05: {UrunGuncelle.ID} Ürün Bulunamadı!!!!");
            }

        }

        public void UrunSil(URUNLER UrunSil)
        {
            int baslangıc = -1;

            for (int i = 0; i <= _ürünSayısı; i++)
            {
                if (_ürünler[i] != null && _ürünler[i] == UrunSil)
                {
                    baslangıc = i;
                    break;
                }
            }
            if(baslangıc == -1)
            {
                for (int i = 0; i >= _ürünSayısı; i++)
                {
                    _ürünler[i] = _ürünler[i + 1]; 
                }
                Console.WriteLine($"{UrunSil.ID} numaralı ürün başarıyla silinmiştir");
            }
            
        }
    }
}