using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractProject
{
    class Circle:Figure
    {
        public double r;

        public Circle(double radius)
        {
            r = radius;
        }

        public override double Area()
        {
            return Math.PI * r * r;
        }
    }
}
