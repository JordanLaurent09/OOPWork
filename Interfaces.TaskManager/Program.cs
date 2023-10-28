using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.TaskManager
{
    public enum Priority
    {
        HIGH,
        MEDIUM,
        LOW
    }
    class Program
    {
        static void Main(string[] args)
        {
            TaskManager manager = new TaskManager();
            manager.AddTask(new Task("Поход к врачу", new DateTime(2003, 3, 3), Priority.LOW));
            manager.AddTask(new Task("Поход в кафе", new DateTime(2023, 10, 13), Priority.HIGH));
            manager.AddTask(new Task("Отдых", new DateTime(2005, 6, 1), Priority.MEDIUM));

            manager.AddEvent(new Event("День рождения", new DateTime(2019, 6, 5), Priority.HIGH, "My house"));
            manager.EditData();
            manager.Display();

            manager.DeleteTask("Поход к врачу");
            manager.Display();

            manager.DeleteTask("День рождения");
            manager.Display();

            manager.EditData();
            manager.Display();

            

            
        }
    }

    public interface ITask
    {
        string Title { get; set; }
        DateTime DueDate { get; set; }
        Priority Priority { get; set; }

        void Display();
    }

    public class Task : ITask
    {
        public string Title { get; set; }
        public DateTime DueDate { get; set; }
        public Priority Priority { get; set; }

        public void Display()
        {
            Console.WriteLine(
                        "{0}\n{1}\n{2}\n",
                        this.Title,
                        this.DueDate.ToShortDateString(),
                        this.Priority
                        );
        }

        public Task(string title, DateTime dueDate, Priority priority)
        {
            Title = title;
            DueDate = dueDate;
            Priority = priority;
        }

        public override string ToString()
        {
            return "Task";
        }
    }

    public class Event : ITask
    {
        public string Title { get; set; }
        public DateTime DueDate { get; set; }
        public Priority Priority { get; set; }

        public string Location { get; set; }

        public Event(string title, DateTime dueDate, Priority priority, string location)
        {
            Title = title;
            DueDate = dueDate;
            Priority = priority;
            Location = location;
        }

        public void Display()
        {
            Console.WriteLine(
                        "{0}\n{1}\n{2}\n{3}\n",
                        this.Title,
                        this.DueDate.ToShortDateString(),
                        this.Priority,
                        this.Location
                        );
        }

        public override string ToString()
        {
            return "Event";
        }
    }

    public class TaskManager
    {
        public List<ITask> DataList { get; set; }

        public TaskManager()
        {
            DataList = new List<ITask>();
        }

        public void AddTask(Task task)
        {
            DataList.Add(task);
        }

        public void AddEvent(Event someEvent)
        {
            DataList.Add(someEvent);
        }

        public void DeleteTask(string title)
        {
            foreach (ITask item in DataList)
            {
                if (item.Title.Equals(title))
                {
                    DataList.Remove(item);
                    break;
                }
            }
        }

        public void EditData()
        {
            Console.WriteLine("Введите название события или задачи:");
            string title = Console.ReadLine();

            for(int i = 0; i < DataList.Count; i++)
            {
                if (DataList[i].Title.Equals(title))
                {
                    string type = DataList[i].ToString();

                    switch (type)
                    {
                        case "Task":
                            Console.WriteLine("Что необходимо поменять?\n1.Название\n2.Дату\n3.Приоритет");
                            int option = int.Parse(Console.ReadLine());
                            switch (option)
                            {
                                case 1:
                                    DataList[i].Title = Console.ReadLine();
                                    break;
                                case 2:
                                    DataList[i].DueDate = new DateTime(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
                                    break;
                                case 3:
                                    Console.WriteLine("Введите нужную цифру\n0 - Высокий приоритет\n1 - Средний приоритет\n2 - Низкий приоритет");
                                    DataList[i].Priority = (Priority) int.Parse(Console.ReadLine());
                                    break;
                                default:
                                    Console.WriteLine("Такой команды не существует");
                                    break;
                            }
                            break;                        
                    }
                }
            }
        }

        public void Display()
        {
            foreach (var item in DataList)
            {
                item.Display();
            }
        }
    }
}
