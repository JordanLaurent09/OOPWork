using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractProject
{
    class Rectangle:Figure
    {
        public double a, b;

        public Rectangle(double sideA, double sideB)
        {
            a = sideA;
            b = sideB;
        }

        public override double Area()
        {
            return a * b;
        }
    }
}
