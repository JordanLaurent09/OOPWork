using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class TwoDShape
    {
        public double Width;
        public double Height;


        public void ShowDimension()
        {
            Console.WriteLine($"Height and width equals {Height} and {Width}");
        }
    }
}
