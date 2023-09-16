using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractProject
{
    class Triangle:Figure
    {
        public double a, b, c;

        public Triangle(double sideA, double sideB, double sideC)
        {
            a = sideA;
            b = sideB;
            c = sideC;
        }
        public override double Area()
        {
            double halfP = (a + b + c) / 2;
            return Math.Sqrt(halfP * (halfP - a) * (halfP - b) * (halfP - c));
        }
    }
}
