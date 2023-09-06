using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexators
{
    class Program
    {
        static void Main(string[] args)
        {
            BoundsArray array = new BoundsArray(10);
            array[0] = 12;
            array[1] = 9;
            Console.WriteLine(array.ErrorBounds);
            array[13] = 11;
            Console.WriteLine(array.ErrorBounds);

            int x, y;
            x = array[0];
            Console.WriteLine(x);
            Console.WriteLine(array.ErrorBounds);
            y = array[11];
            Console.WriteLine(y);
            Console.WriteLine(array.ErrorBounds);
        }
    }
}
