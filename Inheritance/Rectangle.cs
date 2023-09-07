using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Rectangle : TwoDShape
    {
        // Checking whether rectagle is square or not 
        public bool IsSquare()
        {
            if (Height == Width) return true;
            return false;
        }

        public double Area()
        {
            return Width * Height;
        }
    }
}
