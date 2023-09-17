using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractProject
{
    class Person
    {
        public string Name
        {
            get; set;
        }

        public Person(string name)
        {
            Name = name;
        }

        public void Display()
        {
            Console.WriteLine($"Person: {Name}");
        }
    }
}
