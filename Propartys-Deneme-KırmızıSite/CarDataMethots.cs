using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propartys_Deneme_KırmızıSite
{
    public class CarDataMethots
    {

        internal void CarAdd(CarData1 CarName)
        {
            Console.WriteLine(CarName.CarName + " Aracınız İlana Eklenmiştir");
        }

        internal void CarClean(CarData1 CarName)
        {
            Console.WriteLine(CarName.CarName + " Aracınız Silinmiştir");
        }

        internal void CarUpdate(CarData1 CarName)
        {
            Console.WriteLine(CarName.CarName + " Aracınız Tekrar Yayınlanmıştır");
        }

        internal CarData1 CarsBring()

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

            return Cars;



        }

        public static CarData1[] ActiveCars()
        {
            return new CarData1[]
            {
                new()
                {
                    CarName = "Ford",
                    CarModel = "Fiesta",
                    ID = 1,
                    Payments = 425000,
                    CarYear = 2008,
                    CarType = "Hatchback-4",
                    CarKM = 199587,
                    CarColor = "Siyah",
                    CarExplanation = "Aracımda güneş yanıkları mevcut , bakımları zamanında yapılmıştır"

                },

                new()
                {
                  CarName = "BMW",
                  CarModel = "M3",
                  ID = 2,
                  Payments = 600000,
                  CarYear = 2015,
                  CarType = "Sedan",
                  CarKM = 120000,
                  CarColor = "Beyaz",
                  CarExplanation = "Yolcu kapısı paslandı"
                }
            };
        }
    }
}
