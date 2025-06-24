using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konu_14_Arayüzler_INTERFACES
{
    internal class Kategori : I_Sınıf_Gereksinimleri , IveriTabanıİslemleri
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }

        // Kategoriye Ait Özellikler

        public bool ÜstMenüyüGöster { get; set; }

        public bool YanMenüdeGöster { get; set; }

        public void Add(string Name)
        {
            Console.WriteLine(Name + " İsimli Kategori Eklenmiştir");        }

        public void Delete(int ID)
        {
            Console.WriteLine(Name + " İsimli Kategori silinmiştir");        }

        public void GetAll()
        {
            Console.WriteLine();        }

        public void Update(int ID)
        {
            Console.WriteLine();        }
    }
}
