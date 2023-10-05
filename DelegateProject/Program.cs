using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Building[] buildings = new Building[3]{

            new Building("House Garden", 6, 2, 172.2, "Garden"),
            new Building("Business House", 48, 15, 2345.7, "City Center"),
            new Building("Living House", 20, 5, 863.1, "Suburban area")

            };


            AreaDelegate areaDelegate = Building.CalculateVolume;
            AreaInfo(buildings, areaDelegate);
        }

        public static void AreaInfo(Building[] buildings, AreaDelegate d)
        {
            foreach (Building item in buildings)
            {
                d = Building.CalculateVolume;
                Console.WriteLine(d(item.Height, item.TotalArea));
            }
        }


        public delegate double AreaDelegate(double height, double areaTotal);
    }
}
