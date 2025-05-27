
// WriteLine = ayrı satırlara yazıyor
Console.WriteLine("Hello, World");
Console.WriteLine("Merhaba, Dünya");
Console.WriteLine("Merhaba Dünya");

// ---------------------------------------------------------------------------------------------------------

// Write = Aynı Satır içinde Yan Yana Yazar --- Boşluk bırakabiliriz
// Console.Write("Seni Çok Seviyorum "); bu kod yorum satırı olduğu için uygulama bu kodu tanımaz!!!!
Console.Write("Seni Çok Seviyorum ");
Console.WriteLine(" Ayşemmmm <3");

// ---------------------------------------------------------------------------------------------------------

Console.WriteLine("Lütfen Devam etmek için Bir Tuşa Basınız!");
Console.Read(); // Ekranda Bir Karakter bekler  -------- Devam etmek için bir tuşa basın olayı gibi işlem görür.
Console.ReadLine(); // Ekranda Bir Satır Bekler -------- Devam etmek için bir tuşa basın olayı gibi işlem görür.
Console.WriteLine("Giriş Başarılı!");

//---------------------------------- C# Degısken Tanımlama -------------------------------------------//

// ---------- TAM SAYI DEĞİŞKENLERİ----------- //

byte plaka_kodu;  // 0-255 arası değer alır ve 1 byte olarak yer kaplar.

plaka_kodu=34;    // Değişkene değer atama.

Console.WriteLine(plaka_kodu); // Değişkeni yazdırma.

byte BirSayi, BirSayıDaha; // Bir Tiple Birden Fazla Değer Tanımlanabilir
BirSayıDaha = 3;
BirSayi = 5;
Console.WriteLine(BirSayıDaha); // 3
Console.WriteLine(BirSayi);     // 5
Console.WriteLine(BirSayi + BirSayıDaha);   // 8


sbyte SbyteTuru = 127;   // +127 ile -128 arası değer alabilir

short kısa = -32768;        // -32768 ile +32767 arası değer alabilir

ushort BirazUzun = 65535; //  0 ile 65535 arası değer alabilir

int Tamsayı = 2147483647; // 32-Bit 4-Byte 2147483647 ile 2147483648 arası değer alır

uint uzunTamsayı = 7567892;  // 0 ile 4294967295 arası değer alabilir

long DahaUzunTamSayi = 1234567891011121314;

ulong EnUzunTamSayi = 123456789101112;

// ------------ KESİRLİ SAYI DEĞİŞKENLERİ -----------

float KesirliSayi = 4.5f;   // 4-byte yer kaplar 6 - 7 basamak

double KesirliSayi2 = 4.5;  // 8-byte yer kaplar 15 - 16 basamak


// ----------- DECİMAL VERİ TİPİ ------------

decimal ÜrünFiyati = 5500; // 32-byte yer kaplar duyarlı basamak 28 - 29

// ----------- CHAR VERİ TİPİ -------------

char Karakter= 'ç'; // char bir tane değer alı ve tırnak içinde yazılır

// ------------------ STRİNG VERİ TİPİ --------------------

string Degişken;
string Degişken1,Degişken2;
string metin = "String Veri Tipinde \n \t Tüm Karakterleri Kullanabiliriz";  
// "\n" metinde kendinden sonraki alanın bir alt satırdan devam etmesini sağlar
// "\t" ise klavyeden TAB tuşuna basmış gibi ileri atar

Console.WriteLine(metin);

// ----------------- BOOLEAN VERİ TİPİ ----------------

// Geriye dönen TRUE veya FALSE veri tipidir. 1-byte yer kaplar

bool İşlemSonuç = true;

byte? Kilo = null; // başlangıç değerinin boş olmasını istersek null kullanılır

Kilo = 66;


// --------------------- ÖRNEKLER -------------------

short KDV = 20;

int TamSayi2 = 118;

long TamSayi_2;  // Değişken tanımlamak için değişkenin adını ve veri tipini belirtilmesi gerekir

TamSayi2 = 100000000;
TamSayi2 = 20;


// Müşteri ID sini tutacak bir değişken tanımlayalım

string Müşteri_ID = "VCŞSVNCMKV123354";

// Bir Ürünün Satışta Olup Olmadığının Tutulduğu Değişken

bool? iŞsatışTami = null;

iŞsatışTami = true;

//boolen

bool aktif = true;

//* Maaş bilgisini tutacak bir değişken

decimal MaaşBilgisi = 22104.55m;


// C# ta değişkenler bellegte  stack ve heap adı altında tutulur
// Değişkenler değer tipi ve referans olarak ikiye ayrılır


// ---------------- VAR İLE DEĞİŞKEN OLUŞTURMA ---------------

// var ile oluşturan değişkenlerde C# kendisi otomatik algılar

var birDegisken = 18;

var StringMetin = "Strıng Metın";

var sonuç = false;

Console.WriteLine("Degisken: " + birDegisken.GetType()); // GetType kütüphaneeden veri tipinin özelliğinin gösterir.
Console.WriteLine("StrinMetin:" + StringMetin.GetType());
Console.WriteLine("sonuç:" + sonuç.GetType());

sonuç= true;

//  sonuç = 18; var ile tanımlanan bir değişkenin türünü sonradan değiştirilemez ancak içerisinde ki bilgi değiştirilebilir

Console.WriteLine("sonuç:" + sonuç);


// -------------------- OBJE (NESNE) VERİ TİPİ --------------------------

Console.WriteLine("Object Veri Tipi:");

object nesne = "bu bir nesnedir";    // Bu değişken tipine her türlü veri tipi eklenebilir

Console.WriteLine(nesne + "-Tipi" + nesne.GetType());

nesne = 18;  // object ile tanımlanan veri değiştirilebilir

Console.WriteLine(nesne + "-TİPİ" + nesne.GetType());


object a = 10;  // int
object b = "k"; // karakter
object c = "string"; // string
object d = 14.5f;   // float


// ------------------------- C# SABİT TANIMLAMA ---------------------------

const int KdvOrani = 20;  // Sabitleri const olarak tanımlayıp program içince kullanılabilir fakat sonradan değiştirilemez !!!


const int İskonto = 25;  // sonradan değiiştirlemez sabittir


Console.WriteLine(TamSayi2);
Console.WriteLine("Yaşınız ?");
var değer = Console.ReadLine(); // Bu komut ekrandan girilen değeri yakalamamızı sağlar
Console.WriteLine("Girilen Değer: " + değer);