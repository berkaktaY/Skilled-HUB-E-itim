namespace DENEME_01_ATM
{
    internal class KayıtlıEvAdresi
    {
        internal string SokakAdi;
        internal string MahalleAdi;
        internal string İlceAdi;
        internal string İlAdi;
        internal int KapiNo;
        internal int ApNo;

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ATM'mize Hoşgeldiniz");
            Console.WriteLine();
            Console.WriteLine("\t Kartsız İşlemler İçin Giriş Yapınız: -1-");
            Console.WriteLine("\t Kartla İşlemler İçin Giriş Yapınız: -2-");

            var KullanıcıGirisi = Console.ReadLine();

            // ---------- VARSAYILAN DEĞERLER -------------

            double VarsayılanTutar = 15485.75;
            double VarsayılanKrediKartBorcu = 55785.33;
            double VarsayılanTcno = 15994125332;
            double VarsayılanKartNo = 15994125332;
            string VarsayılanIsım = "Rüstem Berk Aktay";

            // ---------- SINIF-CLASS BİLGİLERİ ------------

            KayıtlıEvAdresi EvAdresi = new();

            EvAdresi.İlAdi = "Ankara";
            EvAdresi.İlceAdi = "Sincan";
            EvAdresi.MahalleAdi = "Ahievran Mahallesi";
            EvAdresi.SokakAdi = "Diyet Sokak";
            EvAdresi.ApNo = 24;
            EvAdresi.KapiNo = 1;

            // ----------- KULLANICIDAN ALINAN VERİLER -------------

            if (KullanıcıGirisi == "1")
            {
                Console.WriteLine("Kartsız İşlemler Menüsü");
                Console.WriteLine("\t T.C numaranızı giriniz: ");
                var TCno = Console.ReadLine();

                //------------- String bir değeri long a cevirme

                long Tc;
                bool sonuc = long.TryParse(TCno, out Tc);
                if (sonuc)
                {

                    // --------- Girilen TC numarasının yanlış doğru olması için -------------

                    if (Tc > 10000000000)
                    {
                        Console.WriteLine("Doğrulama Başarılı");
                        Console.WriteLine("Hoşgeldiniz: " + Tc);
                        Console.WriteLine();


                        Console.WriteLine("\t Lütfen Seçiminizi Yapınız");
                        Console.WriteLine("\t 1a- Para Yatırma");
                        Console.WriteLine("\t 2a- Para Çekme");
                        Console.WriteLine("\t 3a- Kredi Kartı Borcu Ödeme");
                        Console.WriteLine("\t 4a- Başvurular");
                        var KartsızSecim = Console.ReadLine();

                        if (KartsızSecim == "1a")
                        {
                            Console.WriteLine("Yatırılacak Tutar Giriniz: ");
                            var YatırılacakTutar = Console.ReadLine();
                            // --------- string değeri double a çevirme ----------
                            double Ytutar;
                            bool sonucTutar = double.TryParse(YatırılacakTutar, out Ytutar);

                            if (sonucTutar)
                            {
                                double Tutar = ToplamSonuc(VarsayılanTutar, Ytutar);
                                Console.WriteLine("Kalan Bakiye: " + Tutar);
                            }
                            else
                            {
                                Console.WriteLine("Geçersiz tutar girdiniz.");
                            }

                        }
                        else if (KartsızSecim == "2a")
                        {
                            Console.WriteLine("Çekmek İstediğiniz Tutarı Giriniz: ");
                            var CekilenTutar = Console.ReadLine();

                            // -------- string değeri double a dönüştürme ----------

                            double Ctutar;
                            bool Csonuc = double.TryParse(CekilenTutar, out Ctutar);
                            if (Csonuc)
                            {
                                double tutar2 = CıkanSonuc(VarsayılanTutar, Ctutar);
                                Console.WriteLine("Kalan Bakiye: " + tutar2);
                            }
                            else
                            {
                                Console.WriteLine("Yanlış Bir Giriş Yaptınız!");
                            }
                        }

                        else if (KartsızSecim == "3a")
                        {
                            Console.WriteLine("Toplam Ödenecek Borç: " + VarsayılanKrediKartBorcu);
                            Console.WriteLine("Ödemek İstediğiniz Tutarı Giriniz: ");
                            var KrediKartBorcu = Console.ReadLine();
                            // string değeri double a dönüştürme
                            double KKBödeme;
                            bool KKBsonuc = double.TryParse(KrediKartBorcu, out KKBödeme);
                            if (KKBsonuc)
                            {
                                double KKBtutar = CıkanSonuc(VarsayılanKrediKartBorcu, KKBödeme);
                                Console.WriteLine("Kalan Borç: " + KKBtutar);
                            }
                            else
                            {
                                Console.WriteLine("Yanlış Tutar Girdiniz!");
                            }
                        }
                        else if (KartsızSecim == "4a")
                        {
                            Console.WriteLine("Lütfen Secim Yapınız: ");
                            Console.WriteLine("\t 1b- Banka Kartı Başvurusu");
                            Console.WriteLine("\t 2b- Kredi Kartı Başvurusu");
                            var Basvurular = Console.ReadLine();

                            if (Basvurular == "1b")
                            {

                                Console.WriteLine("Cep Telefonu Numaranızı Giriniz: ");
                                var CepNumara = Console.ReadLine();
                              
                                Console.WriteLine("Cep Numaranıza Bir Kod Gönderilecektir.Onaylıyor Musunuz ?");
                                Console.WriteLine("Evet/Hayır");
                                var cevap= Console.ReadLine();
                                                             
                                    if (cevap == "Evet")
                                        {
                                        Console.WriteLine("Cep Telefonunuza Gelen Kodu Giriniz: ");
                                        var GelenKod = Console.ReadLine();
                                         Console.WriteLine("Başvurunuz Başarıyla Onaylanmıştır.Kayıtlı Ev Adresinize Gönderilecektir");
                                        Console.WriteLine("Kayıtlı Ev Adresiniz: " + EvAdresi.İlAdi + "/" + EvAdresi.İlceAdi + "/" + EvAdresi.MahalleAdi + "/" + EvAdresi.SokakAdi + "/" + EvAdresi.ApNo + "/" + EvAdresi.KapiNo + " Adresine Gönderilecektir");
                                        }

                                    else if (cevap == "Hayır")
                                        {
                                            Console.WriteLine("Anasayfaya Yönlendiriliyorsunuz");
                                        }
                                else
                                {
                                    Console.WriteLine("Yanlış Giriş Sağladınız");
                                }

                            }
                            else if (Basvurular == "2b")
                            {
                                Console.WriteLine("Cep Numaranıza Bir Kod Gönderilecektir.Onaylıyor Musunuz ?");
                                Console.WriteLine("Evet/Hayır");
                                var Cevap2 = Console.ReadLine();
                                Console.WriteLine("Cep Telefonu Numaranızı Giriniz: ");
                                var CepNumara2 = Console.ReadLine();

                                if (Cevap2 == "Evet")
                                {
                                    Console.WriteLine("Cep Telefonunuza Gelen Kodu Giriniz: ");
                                    var GelenKod2 = Console.ReadLine();
                                    Console.WriteLine("Başvurunuz Başarıyla Onaylanmıştır.Kayıtlı Ev Adresinize Gönderilecektir");
                                    Console.WriteLine("Kayıtlı Ev Adresiniz: " + EvAdresi.İlAdi + "/" + EvAdresi.İlceAdi + "/" + EvAdresi.MahalleAdi + "/" + EvAdresi.SokakAdi + "/" + EvAdresi.ApNo + "/" + EvAdresi.KapiNo + " Adresine Gönderilecektir");
                                }

                                else if (Cevap2 == "Hayır")
                                {
                                    Console.WriteLine("Anasayfaya Yönlendiriliyorsunuz");
                                }

                            }
                            else
                            {
                                Console.WriteLine("Yanlış Bir Giriş Yaptınız!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Yanlış Giriş Yaptınız");
                        }

                    
                    }
                }
                else if (KullanıcıGirisi == "2")
                {
                    Console.WriteLine("Kartı No Veya Tc No Giriniz: ");

                    var KartNo = Console.ReadLine();
                    long Kart;
                    bool sonuc1 = long.TryParse(KartNo, out Kart);
                    if (sonuc1)
                    {
                        if (Kart > 10000000000)
                        {
                            Console.WriteLine("Giriş Başarılı");
                            Console.WriteLine("Hoşgeldiniz: " + VarsayılanIsım);

                            Console.WriteLine();

                            Console.WriteLine("\t Lütfen Seçiminizi Yapınız");
                            Console.WriteLine("\t 1a- Para Yatırma");
                            Console.WriteLine("\t 2a- Para Çekme");
                            Console.WriteLine("\t 3a- Kredi Kartı Borcu Ödeme");
                            Console.WriteLine("\t 4a- Başvurular");
                            var KartlıSecim = Console.ReadLine();

                            if (KartlıSecim == "1a")
                            {
                                Console.WriteLine("Yatırılacak Tutar Giriniz: ");

                                var KartaYatırılacakTutar = Console.ReadLine();

                                double KartaYatan;
                                bool KartSonuc = double.TryParse(KartaYatırılacakTutar, out KartaYatan);
                                if (KartSonuc)
                                {
                                    double KartTutarı = ToplamSonuc(VarsayılanTutar, KartaYatan);
                                    Console.WriteLine("Toplam Bakiye: " + KartTutarı);
                                }
                                else
                                {
                                    Console.WriteLine("Lütfen Tekrar Deneyiniz");
                                }
                            }

                            else if (KartlıSecim == "2a")
                            {
                                Console.WriteLine("Çekebileceğiniz Bakiye: " + VarsayılanTutar);
                                Console.WriteLine("Çekmek İstediğiniz Bakiye: ");
                                var CekilecekBakiye = Console.ReadLine();

                                double CekilenBakiye;
                                bool CekilenBakiyeBool = double.TryParse(CekilecekBakiye, out CekilenBakiye);
                                if (CekilenBakiyeBool)
                                {
                                    double CekilenBakiyeKalan = CıkanSonuc(VarsayılanTutar, CekilenBakiye);
                                    Console.WriteLine("Kalan Bakiye: " + CekilenBakiyeKalan);
                                }
                                else
                                {
                                    Console.WriteLine("İşlem Başarısız! Lütfen Tekrar Deneyiniz");
                                }

                            }

                            else if (KartlıSecim == "3a")
                            {
                                Console.WriteLine("Toplam Kart Borcunuz: " + VarsayılanKrediKartBorcu);
                                Console.WriteLine("Ödemek İstediğiniz Tutar: ");
                                var ÖdenenKart = Console.ReadLine();

                                double ÖdenecekKart;
                                bool ÖdenecekKartBool = double.TryParse(ÖdenenKart, out ÖdenecekKart);
                                if (ÖdenecekKartBool)
                                {
                                    double KrediKartıBakiye = CıkanSonuc(VarsayılanTutar, ÖdenecekKart);
                                    Console.WriteLine("Kalan Kredi Kartı Borcu: " + KrediKartıBakiye);
                                }
                                else
                                {
                                    Console.WriteLine("İşlem Başarısız.Lütfen Tekrar Deneyiniz!");
                                }
                            }
                            else if (KartlıSecim == "4a")
                            {
                                Console.WriteLine("\t Banka Kartı Başvurusu İçin -1b-");
                                Console.WriteLine("\t Kredi Kartı Başvurusu İçin -2b");
                                Console.ReadLine();
                                var BasvuruSecim = Console.ReadLine();

                                if (BasvuruSecim == "1b")
                                {
                                    Console.WriteLine("Cep Telefonu Numaranızı Giriniz: ");
                                    var CepNumara3 = Console.ReadLine();

                                    int CepNo3;
                                    bool CepNoo = int.TryParse(CepNumara3, out CepNo3);
                                    if (CepNo3 > 01000000000)
                                    {
                                        Console.WriteLine("Cep Numaranıza Bir Kod Gönderilecektir.Onaylıyor Musunuz ?");
                                        Console.WriteLine("Evet/Hayır");
                                        Console.ReadLine();

                                        var Onay = Console.ReadLine();

                                        if (Onay == "Evet")
                                        {
                                            Console.WriteLine("Başvurunuz Başarıyla Onaylanmıştır.Kayıtlı Ev Adresinize Gönderilecektir");
                                            Console.WriteLine("Kayıtlı Ev Adresiniz: " + EvAdresi.İlAdi + "/" + EvAdresi.İlceAdi + "/" + EvAdresi.MahalleAdi + "/" + EvAdresi.SokakAdi + "/" + EvAdresi.ApNo + "/" + EvAdresi.KapiNo + " Adresine Gönderilecektir");
                                        }

                                        else if (Onay == "Hayır")
                                        {
                                            Console.WriteLine("Anasayfaya Yönlendiriliyorsunuz");
                                        }

                                        else
                                        {
                                            Console.WriteLine("Yanlış Giriş Sağladınız !!!");
                                        }
                                    }
                                }

                                else if (BasvuruSecim == "2b")
                                {
                                    Console.WriteLine("Cep Telefonu Numaranızı Giriniz: ");
                                    var CepNumara = Console.ReadLine();

                                    int CepNo;
                                    bool CepNoo = int.TryParse(CepNumara, out CepNo);
                                    if (CepNo > 01000000000)
                                    {
                                        Console.WriteLine("Cep Numaranıza Bir Kod Gönderilecektir.Onaylıyor Musunuz ?");
                                        Console.WriteLine("Evet/Hayır");
                                        Console.ReadLine();

                                        var Onay = Console.ReadLine();

                                        if (Onay == "Evet")
                                        {
                                            Console.WriteLine("Başvurunuz Başarıyla Onaylanmıştır.Kayıtlı Ev Adresinize Gönderilecektir");
                                            Console.WriteLine("Kayıtlı Ev Adresiniz: " + EvAdresi.İlAdi + "/" + EvAdresi.İlceAdi + "/" + EvAdresi.MahalleAdi + "/" + EvAdresi.SokakAdi + "/" + EvAdresi.ApNo + "/" + EvAdresi.KapiNo + " Adresine Gönderilecektir");
                                        }

                                        else if (Onay == "Hayır")
                                        {
                                            Console.WriteLine("Anasayfaya Yönlendiriliyorsunuz");
                                        }

                                        else
                                        {
                                            Console.WriteLine("Yanlış Giriş Sağladınız !!!");
                                        }
                                    }
                                }
                            }

                        }
                        else
                        {
                            Console.WriteLine("Yanlış TC Yada Kart Numarası Girdiniz!");
                        }


                    }
                }
                else
                {
                    Console.WriteLine("Yanlış Bir Giriş Yaptınız!");
                }
                // -------------- Metotların Kullanımı --------------

                
            }
            else if (KullanıcıGirisi == "2")
            {
                Console.WriteLine("Kartı No Veya Tc No Giriniz: ");

                var KartNo = Console.ReadLine();
                long Kart;
                bool sonuc1 = long.TryParse(KartNo, out Kart);
                if (sonuc1)
                {
                    if (Kart > 10000000000)
                    {
                        Console.WriteLine("Giriş Başarılı");
                        Console.WriteLine("Hoşgeldiniz: " + VarsayılanIsım);

                        Console.WriteLine();

                        Console.WriteLine("\t Lütfen Seçiminizi Yapınız");
                        Console.WriteLine("\t 1a- Para Yatırma");
                        Console.WriteLine("\t 2a- Para Çekme");
                        Console.WriteLine("\t 3a- Kredi Kartı Borcu Ödeme");
                        Console.WriteLine("\t 4a- Başvurular");
                        var KartlıSecim = Console.ReadLine();

                        if (KartlıSecim == "1a")
                        {
                            Console.WriteLine("Yatırılacak Tutar Giriniz: ");

                            var KartaYatırılacakTutar = Console.ReadLine();

                            double KartaYatan;
                            bool KartSonuc = double.TryParse(KartaYatırılacakTutar, out KartaYatan);
                            if (KartSonuc)
                            {
                                double KartTutarı = ToplamSonuc(VarsayılanTutar, KartaYatan);
                                Console.WriteLine("Toplam Bakiye: " + KartTutarı);
                            }
                            else
                            {
                                Console.WriteLine("Lütfen Tekrar Deneyiniz");
                            }
                        }

                        else if (KartlıSecim == "2a")
                        {
                            Console.WriteLine("Çekebileceğiniz Bakiye: " + VarsayılanTutar);
                            Console.WriteLine("Çekmek İstediğiniz Bakiye: ");
                            var CekilecekBakiye = Console.ReadLine();

                            double CekilenBakiye;
                            bool CekilenBakiyeBool = double.TryParse(CekilecekBakiye, out CekilenBakiye);
                            if (CekilenBakiyeBool)
                            {
                                double CekilenBakiyeKalan = CıkanSonuc(VarsayılanTutar, CekilenBakiye);
                                Console.WriteLine("Kalan Bakiye: " + CekilenBakiyeKalan);
                            }
                            else
                            {
                                Console.WriteLine("İşlem Başarısız! Lütfen Tekrar Deneyiniz");
                            }

                        }

                        else if (KartlıSecim == "3a")
                        {
                            Console.WriteLine("Toplam Kart Borcunuz: " + VarsayılanKrediKartBorcu);
                            Console.WriteLine("Ödemek İstediğiniz Tutar: ");
                            var ÖdenenKart = Console.ReadLine();

                            double ÖdenecekKart;
                            bool ÖdenecekKartBool = double.TryParse(ÖdenenKart, out ÖdenecekKart);
                            if (ÖdenecekKartBool)
                            {
                                double KrediKartıBakiye = CıkanSonuc(VarsayılanKrediKartBorcu, ÖdenecekKart);
                                Console.WriteLine("Kalan Kredi Kartı Borcu: " + KrediKartıBakiye);
                            }
                            else
                            {
                                Console.WriteLine("İşlem Başarısız.Lütfen Tekrar Deneyiniz!");
                            }
                        }
                        else if (KartlıSecim == "4a")
                        {
                            Console.WriteLine("Lütfen Seçim Yapınız: ");
                            Console.WriteLine("\t Banka Kartı Başvurusu İçin 1b");
                            Console.WriteLine("\t Kredi Kartı Başvurusu İçin 2b");
                            var BasvuruSecim = Console.ReadLine();

                            if (BasvuruSecim == "1b")
                            {
                                Console.WriteLine("Cep Telefonu Numaranızı Giriniz: ");
                                var CepNumara3 = Console.ReadLine();

                                    Console.WriteLine("Cep Numaranıza Bir Kod Gönderilecektir.Onaylıyor Musunuz ?");
                                    Console.WriteLine("Evet/Hayır");
                                    Console.ReadLine();

                                    var Onay = Console.ReadLine();

                                    if (Onay == "Evet")
                                    {
                                        Console.WriteLine("Cep Telefonunuza Gelen Kodu Giriniz: ");
                                        var GelenKod = Console.ReadLine();
                                        Console.WriteLine("Başvurunuz Başarıyla Onaylanmıştır.Kayıtlı Ev Adresinize Gönderilecektir");
                                        Console.WriteLine("Kayıtlı Ev Adresiniz: " + EvAdresi.İlAdi + "/" + EvAdresi.İlceAdi + "/" + EvAdresi.MahalleAdi + "/" + EvAdresi.SokakAdi + "/" + EvAdresi.ApNo + "/" + EvAdresi.KapiNo + " Adresine Gönderilecektir");
                                    }

                                    else if (Onay == "Hayır")
                                    {
                                        Console.WriteLine("Anasayfaya Yönlendiriliyorsunuz");
                                    }

                                    else
                                    {
                                        Console.WriteLine("Yanlış Giriş Sağladınız !!!");
                                    }
                                }
                            else if (BasvuruSecim == "2b")
                            {
                                Console.WriteLine("Cep Telefonu Numaranızı Giriniz: ");
                                var CepNumara = Console.ReadLine();

                                Console.WriteLine("Cep Numaranıza Bir Kod Gönderilecektir.Onaylıyor Musunuz ?");
                                Console.WriteLine("Evet/Hayır");
                                
                                var Onay = Console.ReadLine();

                                if (Onay == "Evet")
                                {
                                    Console.WriteLine("Cep Telefonunuza Gelen Kodu Giriniz: ");
                                    var GelenKod= Console.ReadLine();
                                    Console.WriteLine("Başvurunuz Başarıyla Onaylanmıştır.Kayıtlı Ev Adresinize Gönderilecektir");
                                    Console.WriteLine("Kayıtlı Ev Adresiniz: " + EvAdresi.İlAdi + "/" + EvAdresi.İlceAdi + "/" + EvAdresi.MahalleAdi + "/" + EvAdresi.SokakAdi + "/" + EvAdresi.ApNo + "/" + EvAdresi.KapiNo + " Adresine Gönderilecektir");
                                }

                                else if (Onay == "Hayır")
                                {
                                    Console.WriteLine("Anasayfaya Yönlendiriliyorsunuz");
                                }

                                else
                                {
                                    Console.WriteLine("Yanlış Giriş Sağladınız !!!");
                                }
                            }


                            
                                }
                            }
                        }

                    }
                    else
                    {
                        Console.WriteLine("Yanlış TC Yada Kart Numarası Girdiniz!");
                    }
            static double ToplamSonuc(double VarsayılanTutar, double Ytutar)
            {
                return VarsayılanTutar + Ytutar;
            }
            static double CıkanSonuc(double VarsayılanTutar, double CTutar)
            {
                return VarsayılanTutar - CTutar;
            }
        }
            }
        }
        
    


