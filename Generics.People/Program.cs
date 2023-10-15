using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.People
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    abstract class People<TCharacteristics, TSex, TRace, TColor>
    {
        public abstract TCharacteristics Height { get; set; }
        public abstract TCharacteristics Weight { get; set; }

        public abstract TSex Sex { get; set; }
        public abstract TColor Colour { get; set; }
    }

    class Person:People<double, char, string, Color>
    {
        public override double Height { get; set; }
        public override double Weight { get; set; }
        public override char Sex { get; set; }
        public override Color Colour { get; set; }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
    }

    class Employee : Person
    {
        public int Id { get; set; }
        public string Rang { get; set; }

        public string Position { get; set; }

        public decimal Salary { get; set; }

        public DateTime JobStartDate { get; set; }

        
    }

    class Teacher : Employee
    {
        public string Subject { get; set; }
        public int WorkExperience { get; set; }
    }

    class Student : Employee
    {
        public int Course { get; set; }
        public string Speciality { get; set; }
        public double AverageMark { get; set; }
    }

    class Manager : Employee
    {
        public string ControlArea { get; set; }
        public int WorkersNumber { get; set; }
        public int ControlExperience { get; set; }
    }

    class Programmer : Employee
    {
        public string ProgramminLanguage { get; set; }
        public List<string> Projects { get; set; }
        public string Specialization { get; set; }
    }
}
