using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesInteraction
{
    class Point
    {
        // private fields
        private int x;
        private int y;


        // constructor with two arguments
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        // default constructor

        public Point() : this(0,0)
        {
        }

        // public property for x
        public int X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }

        // public property for y
        public int Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }

        // method Print for printing coordinate's values

        public void Print()
        {
            Console.WriteLine($"Coordinate x has value {x} and coordinate y has value {y}");
        }

        // method LengthOrigin for calculate distance between zero point and point (x; y)

        public double LengthOrigin()
        {
            return Math.Sqrt(x * x + y * y);
        }
    }
}
