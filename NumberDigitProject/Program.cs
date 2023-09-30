using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberDigitProject
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass bc = new BaseClass();
            bc.number = 2346736;
            Console.WriteLine("Обработка числа индексатором базового класса:");
            Console.WriteLine(bc[6]);
            ChildClass cc = new ChildClass();
            cc.number = 789;
            cc.anotherNumber = 123;
            Console.WriteLine("Обработка индексатором производного класса с двумя индексами:");
            Console.WriteLine(cc[0, 0]);
            Console.WriteLine("Обработка переопределенным индексатором производного класса с одним индексом:");
            Console.WriteLine(cc[0]);

        }
    }
}
