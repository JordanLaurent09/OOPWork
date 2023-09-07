using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Triangle : TwoDShape
    {
        public string Type; // Type of the triangle


        // Area of triangle
        public double Area()
        {
            return Width * Height / 2;
        }

        public void ShowType()
        {
            Console.WriteLine($"Type of current triangle is {Type}");
        }
    }
}
