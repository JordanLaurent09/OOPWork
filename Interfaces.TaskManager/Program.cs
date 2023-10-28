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

            manager.Display();

            manager.DeleteTask("Поход к врачу");
            manager.Display();

            manager.DeleteTask("День рождения");
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

        public void Display()
        {
            foreach (var item in DataList)
            {
                item.Display();
            }
        }
    }
}
