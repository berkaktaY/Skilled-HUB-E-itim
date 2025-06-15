using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konu_8_SINIFLAR_CLASS
{
    internal class KullanıcıArayüzü
    {
        public int Id { get; set; }
        public string İsim { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string UserName { get; set; }

        public DateTime CreateDate {  get; set; } // prob > tab olarak kısa yol

        public bool KullanıcıGiris(string mail,string sifre)
        {
            string veritabanındaKayıtlıEmail = "info@uygulama.com";
            string VeriTabanındaKayıtlıSifre = "123456";
            bool islemSonucu = false;

            if (mail == veritabanındaKayıtlıEmail && sifre == VeriTabanındaKayıtlıSifre) ;

            {
                islemSonucu = true;
            }

            return islemSonucu;

        }

    }
   
}
