using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMeth
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass bc = new BaseClass(4);
            bc.Show();
            Console.WriteLine(bc.code);
            ChildClass cc = new ChildClass(6, 13);
            cc.Show();
            Console.WriteLine(cc.code);

            // Work with an animals

            Animal animal = new Animal("An Animal");
            animal.WhatTheAnimal();
            animal.Voice();
            animal.Info();
            Snake snake = new Snake("Snake");
            snake.WhatTheAnimal();
            snake.Voice();
            snake.Info();

        }
    }
}
