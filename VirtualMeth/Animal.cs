using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMeth
{
    class Animal
    {
        public string name;

        public Animal(string name)
        {
            this.name = name;
        }

        public void Voice()
        {
            Console.WriteLine("Makes some noise");
        }

        public virtual void WhatTheAnimal()
        {
            Console.WriteLine($"An animal is {name}");
        }

        public void Info()
        {
            WhatTheAnimal();
            Voice();
        }
    }
}
