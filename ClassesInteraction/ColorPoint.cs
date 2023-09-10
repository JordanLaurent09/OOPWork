using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesInteraction
{

    enum Colors
    {
        GREEN,
        BLUE,
        BLACK,
        YELLOW,
        ORANGE,
        BROWN,
        VIOLET,
        WHITE,
        GOLDEN,
        SILVER
    }

    class ColorPoint : Point
    {
        // private field
        Colors color;

        public ColorPoint(int x, int y, Colors color):base(x, y)
        {
            this.color = color;
        }



        new public void Print()
        {
            Console.Write($"Color is {color}. ");
            base.Print();
        }

        // public property
        public Colors Color
        {
            get
            {
                return color;
            }

            set
            {
                color = value;
            }
        }
    }
}
