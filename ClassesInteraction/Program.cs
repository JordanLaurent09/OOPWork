﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesInteraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point(4, 3);
            point.Print();
            Console.WriteLine(point.LengthOrigin());
        }
    }
}
