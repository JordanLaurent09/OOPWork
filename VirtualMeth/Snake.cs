using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMeth
{
    class Snake : Animal
    {
        public Snake(string name):base(name)
        {
        }

        public override void WhatTheAnimal()
        {
            Console.WriteLine($"An animal is {name}");
        }

        new public void Voice()
        {
            Console.WriteLine("Hisssssss");
        }
    }
}
