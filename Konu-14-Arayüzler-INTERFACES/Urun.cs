using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Konu_14_Arayüzler_INTERFACES
{
    internal class Urun : I_Sınıf_Gereksinimleri, IveriTabanıİslemleri
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }

        // Ürün class ının Özellikleri

        public decimal Fiyat { get; set; }
        public int Stock { get; set; }

        public string? İmage { get; set; }
        public int ID { get; set; }

        public void Add(string Name)
        {
            Console.WriteLine(Name + " İsimli Ürün Eklendi ");
        }

        public void Delete(int ID)
        {
            Console.WriteLine(Name + " İsimli Ürün Silindi");        }

        public void GetAll()
        {
            Console.WriteLine();
        }

        public void Update(int ID)
        {
            Console.WriteLine();
        }
    }
}
