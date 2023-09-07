using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create instance of TwoDShape class and work with it fields and method 
            TwoDShape shape = new TwoDShape(13, 20);
            shape.ShowDimension();

            // Create instance of Triangle class and work with it fields and methods 
            Triangle triangle = new Triangle("Прямоугольный", 11, 21);
            triangle.ShowDimension();
            triangle.ShowType();
            Console.WriteLine($"Triangle area is {triangle.Area()}");

            Rectangle square = new Rectangle();
            square.Height = 21;
            square.Width = 21;
            Console.WriteLine(square.IsSquare());
            Console.WriteLine(square.Area());

        }
    }
}
