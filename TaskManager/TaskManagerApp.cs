using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    public enum Role
    {
        Администратор,
        Пользователь
    }

    public enum Status
    {
        ВПРОЦЕССЕ,
        ВЫПОЛНЕН,
        ПРОСРОЧЕН
    }

    public enum Priority
    {
        ВЫСОКИЙ,
        НИЗКИЙ
    }

    class TaskManagerApp
    {
        private static List<User> _users = new List<User>() { new User(0, "Admin", "Admin", Role.Администратор)};
        private static List<Project> _projects = new List<Project>() { new Project(1, "Лаба", "Вычисление колебаний") { 
            Tasks = 
            {
                new Task(1, "Снять показания", "Надо снять показания", Status.ВПРОЦЕССЕ, Priority.ВЫСОКИЙ, new DateTime (2010, 5,5)),
                new Task(2, "Интерпретация показаний", "Надо интерпретировать показания", Status.ВПРОЦЕССЕ, Priority.ВЫСОКИЙ, new DateTime (2010, 5,12))
            } 
        } 
        };

        static void Main(string[] args)
        {
            MainMenu();
        }


        public static void TasksProjectsWork(User user)
        {
            string option = string.Empty;
            while (option != "РАЗЛОГИНИТЬСЯ")
            {
                Console.WriteLine("Что желаете?\nПРОЕКТЫ - просмотреть все проекты c их задачами\n" +
                    "НОВЫЙПРОЕКТ - создать проект\nУДАЛИТЬПРОЕКТ - удалить проект\nРАЗЛОГИНИТЬСЯ - выход в основное меню");
                option = Console.ReadLine();
                if (option == "РАЗЛОГИНИТЬСЯ") user.Logout();
                switch (option)
                {
                    case "ПРОЕКТЫ":
                        ReportGenerator rg = new ReportGenerator();
                        foreach (Project eachProject in _projects)
                        {
                            rg.GenerateProjectReport(eachProject);
                        }
                        break;
                    case "НОВЫЙПРОЕКТ":
                        Console.WriteLine("Введите номер проекта");
                        int number = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите название проекта");
                        string title = Console.ReadLine();
                        Console.WriteLine("Введите описание проекта");
                        string description = Console.ReadLine();
                        Project project = new Project(number, title, description);

                        Console.WriteLine("Введите число задач в проекте");
                        int tasksNumber = int.Parse(Console.ReadLine());
                        for (int i = 0; i < tasksNumber; i++)
                        {
                            Console.WriteLine("Введите номер задачи");
                            int taskID = int.Parse(Console.ReadLine());
                            Console.WriteLine("Введите название задачи");
                            string taskTitle = Console.ReadLine();
                            Console.WriteLine("Введите описание задачи");
                            string taskDescription = Console.ReadLine();


                            Console.WriteLine("Введите дедлайн для задачи - год-месяц-день");
                            int year = int.Parse(Console.ReadLine());
                            int month = int.Parse(Console.ReadLine());
                            int day = int.Parse(Console.ReadLine());
                            project.AddTask(new Task(taskID, taskTitle, taskDescription, Status.ВПРОЦЕССЕ, Priority.ВЫСОКИЙ, new DateTime(year, month, day)));


                        }
                        _projects.Add(project);
                        break;
                    case "УДАЛИТЬПРОЕКТ":
                        Console.WriteLine($"В данный момент имеется {_projects.Count} проектов. Введите номер проекта, необходимый к удалению, начиная с числа 1");
                        int num = int.Parse(Console.ReadLine());
                        _projects.RemoveAt(num - 1);
                        Console.WriteLine("Проект успешно удален!");
                        break;
                }
            }
        }

        public static void MainMenu()
        {
            string choice = string.Empty;
            while (choice != "ВЫХОД")
            {
                Console.WriteLine("Выберите желаемое действие: \nВОЙТИ - войти в систему\nВЫХОД - закончить работу с менеджером\n" +
                    "ЗАРЕГИСТРИРОВАТЬСЯ - зарегистрироваться в системе");

                choice = Console.ReadLine();
                switch (choice)
                {
                    case "ВОЙТИ":

                        Console.WriteLine("Введите свои логин и пароль");
                        string login = Console.ReadLine();
                        string password = Console.ReadLine();
                        foreach (var item in _users)
                        {
                            if (item.Username == login && item.Password == password)
                            {
                                User user = item;
                                user.Login();
                                TasksProjectsWork(user);
                            }

                        }
                        break;
                    case "ЗАРЕГИСТРИРОВАТЬСЯ":
                        Console.WriteLine("Введите поочередно свой Id, логин, и пароль");
                        int newId = int.Parse(Console.ReadLine());
                        string newLog = Console.ReadLine();
                        string newPass = Console.ReadLine();


                        foreach (var item in _users)
                        {
                            if (item.Username == newLog) Console.WriteLine("Такой пользователь уже есть");
                            break;
                        }
                        _users.Add(new User(newId, newLog, newPass, Role.Пользователь));
                        break;



                }
            }
        }
    }
}
