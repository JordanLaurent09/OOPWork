using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesWork.Deep
{
    public enum Priority
    {
        HIGH,
        MEDIUM, 
        LOWER
    }


    class Program
    {
        static void Main(string[] args)
        {
            Employee first = new Employee()
            {
                Name = "Tommy",
                Id = 48,
                Tasks =  
                { 
                    new Task("read the article", Priority.LOWER, new DateTime(2023, 11, 19)),
                    new Task("repair the engine", Priority.HIGH, new DateTime(2023, 7, 19)),
                    new Task("open the gates", Priority.MEDIUM, new DateTime(2023, 9, 22)),
                    new Task("learn c#", Priority.HIGH, new DateTime(2023, 11, 20))
                }
            };

            Employee second = new Employee()
            {
                Name = "Bella",
                Id = 28,
                Tasks =
                {
                    new Task("buy a car", Priority.LOWER, new DateTime(2023, 12, 23)),
                    new Task("destroy the engine", Priority.HIGH, new DateTime(2023, 7, 25)),
                    new Task("write the article", Priority.MEDIUM, new DateTime(2023, 12, 30))
                    
                }
            };

            Employee third = new Employee()
            {
                Name = "Ronnie",
                Id = 11,
                Tasks =
                {
                    new Task("build the house", Priority.HIGH, new DateTime(2023, 10, 6)),
                    new Task("repair destroyed engine", Priority.HIGH, new DateTime(2023, 7, 27)),
                    new Task("close the gates", Priority.LOWER, new DateTime(2023, 10, 15)),
                    new Task("participate in champioship", Priority.MEDIUM, new DateTime(2023, 10, 28))
                }
            };


            Employee[] workers = new Employee[3];
            workers[0] = first;
            workers[1] = second;
            workers[2] = third;

            // Сортировка списка сотрудников, используя реализованный интерйейс IComparable

            Array.Sort(workers);


            foreach(var item in workers)
            {
                Console.WriteLine(item.Name);
            }

            // Перебор задач сотрудников с помощью интерфейса IEnumerable

            foreach(Employee item in workers)
            {
                IEnumerator<Task> e = item.GetEnumerator();
                while (e.MoveNext())
                {
                    Task t = e.Current;
                    Console.WriteLine($"{t.Title} {t.Priority} {t.DueDate.ToShortDateString()}");
                }
            }

            
            
        }
    }

    class Employee:IComparable<Employee>, IEnumerable<Task>
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public List<Task> Tasks { get; set; } = new List<Task>();


        // Реализация метода CompareTo

        public int CompareTo(Employee another)
        {
            return Tasks.Count.CompareTo(another.Tasks.Count);
        }


        // Реализация интерфейса IEnumerable
        public IEnumerator<Task> GetEnumerator()
        {
            return ((IEnumerable<Task>)Tasks).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)Tasks).GetEnumerator();
        }
    }

    
    // Класс Task реализует интерфейс ICloneable
    class Task:ICloneable
    {
        public string Title { get; set; }
        public Priority Priority { get; set; }
        public DateTime DueDate { get; set; }

        public Task(string title, Priority priority, DateTime dueDate)
        {
            Title = title;
            Priority = priority;
            DueDate = dueDate;
        }

        // Реализация глубокого копирования
        public object Clone()
        {
            Priority priorityClone = Priority;
            DateTime dueDateClone = new DateTime(DueDate.Year, DueDate.Month, DueDate.Day);
            return new Task(Title, priorityClone, dueDateClone);
        }
    }

}
