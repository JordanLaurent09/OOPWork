using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverridingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Lemon one = new Lemon(32.12, 0.12);
            Lemon two = new Lemon(11.22, 0.43);
            double three = one + two;
            Console.WriteLine(three);
            Lemon four = one++;
            Console.WriteLine(four);

            while(two)
            {
                Console.Write($"{two.Price} ");
                two.Price--;
            }

            MyData dataOne = new MyData('A');
            MyData dataTwo = new MyData('B');
            MyData dataThree = new MyData('E');

            Console.WriteLine($"A&&B: {(dataOne && dataTwo).Symb}");
            Console.WriteLine($"B&&A: {(dataTwo && dataOne).Symb}");
            Console.WriteLine($"A&&E: {(dataOne && dataThree).Symb}");
            Console.WriteLine($"E&&A: {(dataThree && dataOne).Symb}");
            Console.WriteLine($"A||B: {(dataOne || dataTwo).Symb}");
            Console.WriteLine($"B||A: {(dataTwo || dataOne).Symb}");
            Console.WriteLine($"A||E: {(dataOne || dataThree).Symb}");
            Console.WriteLine($"E||A: {(dataThree || dataOne).Symb}");


        }
    }
}
