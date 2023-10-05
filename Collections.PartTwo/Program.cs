using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.PartTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Управление списком задач

            List<string> tasks = new List<string>();

            Console.WriteLine("\t\t****СПИСОК ЗАДАЧ****\t\t");
            Console.WriteLine("Доступные команды:\n-write - добавить запись в список;\n-delete - удалить запись;\n-show - вывести все задачи из списка;\n-out - закрыть программу.");

            while (true)
            {

                string request = Console.ReadLine();

                string currentTask;

                switch (request)
                {
                    case "-write":
                        Console.WriteLine("Введите задачу:");
                        currentTask = Console.ReadLine();
                        WriteTask(currentTask, tasks);
                        Console.WriteLine("Введите следующую команду:");
                        break;
                    case "-delete":
                        Console.WriteLine("Введите задачу, предназначенную для удаления:");
                        currentTask = Console.ReadLine();
                        DeleteTask(currentTask, tasks);
                        Console.WriteLine("Введите следующую команду:");
                        break;
                    case "-show":
                        Console.WriteLine("Список текущих задач:");
                        ShowAll(tasks);
                        Console.WriteLine("Введите следующую команду:");
                        break;
                    case "-out": return;
                    default:
                        Console.WriteLine("Непонятная команда, попробуйте ввести еще раз:");
                        break;

                }
            }




            // 2. Учет посещений мгазина
            Dictionary<string, int> shopVisits = new Dictionary<string, int>();

            string visitorName = "";

            while (true)
            {
                Console.Write("Введите свое имя: ");

                visitorName = Console.ReadLine();

                if (visitorName == "выход") break;

                if (shopVisits.ContainsKey(visitorName))
                {
                    shopVisits[visitorName]++;
                }
                else
                {
                    shopVisits.Add(visitorName, 1);
                }
            }

            foreach (var item in shopVisits)
            {
                Console.WriteLine("Покупатель по имени " + item.Key + " посетил магазин " + item.Value + " раз.");
            }


            // 3. Проверка на уникальность

            double[] doubleNumbers = new double[] { 2, 3, 4, 5, 6 };

            bool isUnique = IsUnique(doubleNumbers);

            Console.WriteLine(isUnique);


            // 9. Календарь событий

            Dictionary<string, DateTime> calendar = new Dictionary<string, DateTime>();

            Console.WriteLine("\t\t****КАЛЕНДАРЬ СОБЫТИЙ****\t\t");
            Console.WriteLine("Доступные команды:\n-add - добавить событие в календарь;\n-remove - удалить календарь;\n-show - вывести все события из календаря;\n-out - закрыть программу.");

            while (true)
            {

                string request = Console.ReadLine();

                switch (request)
                {
                    case "-add":
                        AddEvent(calendar);
                        Console.WriteLine("Введите следующую команду:");
                        break;
                    case "-remove":
                        RemoveEvent(calendar);
                        Console.WriteLine("Введите следующую команду:");
                        break;
                    case "-show":
                        Console.WriteLine("Список текущих событий:");
                        ShowEvents(calendar);
                        Console.WriteLine("Введите следующую команду:");
                        break;
                    case "-out": return;
                    default:
                        Console.WriteLine("Непонятная команда, попробуйте ввести еще раз:");
                        break;

                }
            }
        }

        // 9. Дополнительные функции для задачи 9.

        // Добавление события в календарь
        public static void AddEvent(Dictionary<string, DateTime> calendar)
        {
            Console.WriteLine("Введите название события:");
            string eventName = Console.ReadLine();
            if (calendar.ContainsKey(eventName))
            {
                Console.WriteLine("Такое событие уже есть!");
            }
            else
            {
                Console.WriteLine("Введите дату события в виде ГОД-МЕСЯЦ-ДЕНЬ");
                int year = int.Parse(Console.ReadLine());
                int month = int.Parse(Console.ReadLine());
                if (month < 1 || month > 12) month = 5;
                int day = int.Parse(Console.ReadLine());
                if (day < 1 || day > 31) day = 5;
                DateTime date = new DateTime(year, month, day);
                calendar.Add(eventName, date);
                Console.WriteLine("Событие успешно добавлено.");
            }
        }


        // Удаление события из календаря
        public static void RemoveEvent(Dictionary<string, DateTime> calendar)
        {
            Console.WriteLine("Введите название события:");
            string eventName = Console.ReadLine();
            if (calendar.ContainsKey(eventName))
            {
                calendar.Remove(eventName);
                Console.WriteLine("Событие успешно удалено.");
            }

            else
            {
                Console.WriteLine("Такого события не найдено. Удостоверьтесь в правильности введенной информации.");
            }
        }

        public static void ShowEvents(Dictionary<string, DateTime> calendar)
        {
            foreach (KeyValuePair<string, DateTime> item in calendar)
            {
                Console.WriteLine(item.Key + " : " + item.Value.ToLongDateString());
            }
        }

        // 1. Дополнительные функции для задачи 1.

        // Добавление данных в список
        public static void WriteTask(string data, List<string> list)
        {
            list.Add(data);
            Console.WriteLine("Задача успешно добавлена!");
        }

        // Удаление данных из списка
        public static void DeleteTask(string data, List<string> list)
        {
            if (!list.Contains(data))
            {
                Console.WriteLine("Попытка удалить несуществующую запись!");
            }
            else
            {
                list.Remove(data);
                Console.WriteLine("Задача успешно удалена!");
            }
        }

        // Вывод всех задач на экран
        public static void ShowAll(List<string> list)
        {
            if (list.Count == 0)
            {
                Console.WriteLine("Список задач пуст! Можете его заполнить.");
            }

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }


        // 3. Проверка на уникальность

        public static bool IsUnique(double[] elementsArray)
        {
            HashSet<double> uniqueValues = new HashSet<double>();
            foreach (double item in elementsArray)
            {
                uniqueValues.Add(item);
            }

            if (uniqueValues.Count == elementsArray.Length)
            {
                return true;
            }

            return false;
        }
    }
}
