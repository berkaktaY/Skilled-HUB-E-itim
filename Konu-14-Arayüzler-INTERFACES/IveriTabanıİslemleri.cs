namespace Konu_14_Arayüzler_INTERFACES
{
    internal interface IveriTabanıİslemleri 
    {
        // Bu arayüzü kullanacak class lar bu metotları kullanmak zorundadır

        //----------------- CRUD METOT İMZALARI ---------------

        void Add(string Name); // EKLE
        void Update(int ID); // GÜNCELLE

        void Delete(int ID); // SİL
        void GetAll(); // LİSTELE

        // interface lerde metotlar açıkca yazılmaz  sadece geri dönüş tipi , adı ve parametresi belirtilir
    }
}
