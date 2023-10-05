using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateProject
{
    class Building
    {
        public string BuildingName { get; set; }
        public double Height { get; set; }
        public int Floor { get; set; }
        public double TotalArea { get; set; }
        public string Location { get; set; }


        public Building(string name, double height, int floor, double area, string location)
        {
            BuildingName = name;
            Height = height;
            Floor = floor;
            TotalArea = area;
            Location = location;
        }

        public static double CalculateVolume(double height, double areaTotal)
        {
            return height * areaTotal;
        }


    }
}
