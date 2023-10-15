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

        public string Position { get; set; }

        public decimal Salary { get; set; }

        public DateTime JobStartDate { get; set; }

        public Employee(int id, string position, decimal salary, DateTime jobStart)
        {
            Id = id;
            Position = position;
            Salary = salary;
            JobStartDate = jobStart;
        }

        public override string ToString()
        {
            return $"Текущий идентификатор - {Id}, текущая должность - {Position}, " +
                $"зарплата - {Salary} рублей, а дата приема на работу - {JobStartDate.ToShortDateString()}.";
        }
    }

    class Teacher : Employee
    {
        public string Subject { get; set; }
        public int WorkExperience { get; set; }

        public Teacher(int id, string position, decimal salary, DateTime jobTime, string subject, int workExperience):base(id,position,salary, jobTime)
        {
            Subject = subject;
            WorkExperience = workExperience;
        }
    }

    class Student : Employee
    {
        public int Course { get; set; }
        public string Speciality { get; set; }
        public double AverageMark { get; set; }

        public Student(int id, string position, decimal salary, DateTime jobTime, int course, string speciality, double mark) : base(id, position, salary, jobTime)
        {
            Course = course;
            Speciality = speciality;
            AverageMark = mark;
        }
    }

    class Manager : Employee
    {
        public string ControlArea { get; set; }
        public int WorkersNumber { get; set; }
        public int ControlExperience { get; set; }

        public Manager(int id, string position, decimal salary, DateTime jobTime, string area, int workers, int experience) : base(id, position, salary, jobTime)
        {
            ControlArea = area;
            WorkersNumber = workers;
            ControlExperience = experience;
        }
    }

    class Programmer : Employee
    {
        public string ProgrammingLanguage { get; set; }
        public List<string> Projects { get; set; }
        public string Specialization { get; set; }

        public Programmer(int id, string position, decimal salary, DateTime jobTime, string language, List<string> proj, string spec) : base(id, position, salary, jobTime)
        {
            ProgrammingLanguage = language;
            Projects = proj;
            Specialization = spec;
         
        }
    }
}
