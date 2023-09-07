using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Triangle : TwoDShape
    {
        string Type; // Type of the triangle

        // Create constructors

        public Triangle()
        {
            Type = null;
        }

        public Triangle(double side):base(side)
        {
            Type = "Равнобедренный";
        }

        public Triangle(string type, double width, double height):base(width, height)
        {
            Type = type;
        }

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
