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
            Teacher teacher = new Teacher(180, 65, 'ж', Color.Brown, "Мария Ивановна", 34, "Улица Ленина, 15", "1234567",
                                          22, "Завуч", 66500.22m, new DateTime(2018, 9, 1), "Математика", 5);

            Student student = new Student(165, 52, 'ж', Color.Green, "Наталья Сергеевна", 31, "Улица Челнокова, 20", "8787765",
                                          111, "Студентка", 1500.33m, new DateTime(2019, 5, 1), 4, "Физика", 4.4);

            Manager manager  = new Manager(191, 88, 'м', Color.Blue, "Семен Семенов", 41, "Улица Горького, 18", "987654",
                                          77, "Начальник отдела", 150000.00m, new DateTime(2011, 6, 1), "Снабжение", 20, 10);

            Programmer programmer = new Programmer(185, 75, 'м', Color.Gray, "Николай Николаев", 27, "Улица Чайковского, 21", "33503864",
                                          66, "Джун", 300000.00m, new DateTime(2019, 7, 1), "C#", new List<string>() {"Файловый менеджер", "Система регистрации"},
                                          "Бэкенд");

            teacher.GetBasicInfo();
            teacher.GetWorkerInfo();
            Console.WriteLine();

            student.GetBasicInfo();
            student.GetWorkerInfo();
            Console.WriteLine();

            manager.GetBasicInfo();
            manager.GetWorkerInfo();
            Console.WriteLine();

            programmer.GetBasicInfo();
            programmer.GetWorkerInfo();
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

        public Person(double heigth,double weight, char sex, Color color, string name, int age, string address, string phone)
        {
            Height = heigth;
            Weight = weight;
            Sex = sex;
            Colour = color;
            Name = name;
            Age = age;
            Address = address;
            PhoneNumber = phone;
        }

        public void GetBasicInfo()
        {
            Console.WriteLine($"Рост - {Weight}, вес - {Height}, пол - {Sex}, цвет глаз - {Colour}, " +
                $"имя - {Name}, возраст - {Age}, адрес - {Address}, телефон - {PhoneNumber}");
        }
    }

    class Employee : Person
    {
        public int Id { get; set; }

        public string Position { get; set; }

        public decimal Salary { get; set; }

        public DateTime JobStartDate { get; set; }

        public Employee(double height, double weight, char sex, Color color, string name, int age, string address, string phone,
                        int id, string position, decimal salary, DateTime jobStart):
                        base(height, weight, sex, color, name, age, address,phone)
        {
            Id = id;
            Position = position;
            Salary = salary;
            JobStartDate = jobStart;
        }

        public virtual void  GetWorkerInfo()
        {
            Console.WriteLine($"Текущий идентификатор - {Id}, текущая должность - {Position}, " +
                $"зарплата - {Salary} рублей, а дата приема на работу - {JobStartDate.ToShortDateString()}.");
        }
    }

    class Teacher : Employee
    {
        public string Subject { get; set; }
        public int WorkExperience { get; set; }

        public Teacher(double height, double weight, char sex, Color color, string name, int age, string address, string phone,
                       int id, string position, decimal salary, DateTime jobStart, string subject, int experience) :
                       base(height, weight, sex, color, name, age, address, phone, id, position, salary, jobStart)
        {
            Subject = subject;
            WorkExperience = experience;
        }

        public override void GetWorkerInfo()
        {
            base.GetWorkerInfo();
            Console.WriteLine($"Предмет, ведомый учителем - {Subject}, а общий стаж преподавания - {WorkExperience}");
        } 
    }

    class Student : Employee
    {
        public int Course { get; set; }
        public string Speciality { get; set; }
        public double AverageMark { get; set; }

        public Student(double height, double weight, char sex, Color color, string name, int age, string address, string phone,
                        int id, string position, decimal salary, DateTime jobStart, int course, string speciality, double mark) :
                        base(height, weight, sex, color, name, age, address, phone, id, position, salary, jobStart)
        { 
            Course = course;
            Speciality = speciality;
            AverageMark = mark;
        }

        public override void GetWorkerInfo()
        {
            base.GetWorkerInfo();
            Console.WriteLine($"Студент учится на {Course} курсе по специальности {Speciality}, его средний балл - {AverageMark}.");
        }
    }

    class Manager : Employee
    {
        public string ControlArea { get; set; }
        public int WorkersNumber { get; set; }
        public int ControlExperience { get; set; }

        public Manager(double height, double weight, char sex, Color color, string name, int age, string address, string phone,
                        int id, string position, decimal salary, DateTime jobStart, string area, int workers, int experience) :
                        base(height, weight, sex, color, name, age, address, phone, id, position, salary, jobStart)
        {
            ControlArea = area;
            WorkersNumber = workers;
            ControlExperience = experience;
        }

        public override void GetWorkerInfo()
        {
            base.GetWorkerInfo();
            Console.WriteLine($"Область управления менеджера - {ControlArea}, количество его подчиненных - {WorkersNumber}, " +
                              $"а его общий стажв управлении - {ControlExperience}.");
        }
    }

    class Programmer : Employee
    {
        public string ProgrammingLanguage { get; set; }
        public List<string> Projects { get; set; }
        public string Specialization { get; set; }

        public Programmer(double height, double weight, char sex, Color color, string name, int age, string address, string phone,
                          int id, string position, decimal salary, DateTime jobStart, string language, List<string> proj, string spec) :
                          base(height, weight, sex, color, name, age, address, phone, id, position, salary, jobStart)
        {
            ProgrammingLanguage = language;
            Projects = proj;
            Specialization = spec;
         
        }

        public override void GetWorkerInfo()
        {
            base.GetWorkerInfo();
            Console.WriteLine($"Программист пишет на языке {ProgrammingLanguage}, а его специализация это {Specialization}.");
            Console.WriteLine("Список проектов программиста:");
            foreach(string item in Projects)
            {
                Console.WriteLine(item);
            }
        }
    }
}
