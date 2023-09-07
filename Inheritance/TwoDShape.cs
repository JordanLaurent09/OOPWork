using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class TwoDShape
    {
        double private_width;
        double private_height;


        public TwoDShape()
        {
            Width = Height = 0.0;
        }

        public TwoDShape(double value)
        {
            Width = Height = value;
        }
        public TwoDShape(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public double Width
        {
            get 
            { 
                return private_width; 
            }
            set
            {
                private_width = value < 0 ? -value : value;
            }
        }
        public double Height
        {
            get
            {
                return private_height;
            }

            set
            {
                private_height = value < 0 ? -value : value;
            }
        }


        public void ShowDimension()
        {
            Console.WriteLine($"Height and width equals {Height} and {Width}");
        }
    }
}
