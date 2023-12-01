using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlUsers
{
    class Program
    {
        private static List<User> _users = UserXML.DeserializeUsers(); // Все содержимое xml-файла автоматически подгружается в список при начале работы
        static void Main(string[] args)
        {
            MainMenu();         
        }



        /// <summary>
        /// / метод, определяющий, сумел ли пользователь аутентифицироваться,
        /// или его данных нет в списке пользователей
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public static bool Authentificate(List<User> users)
        {
            bool isAuthentificated = false;

            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();
            Console.WriteLine("Введите пароль");
            string password = Console.ReadLine();


            foreach(User items in users)
            {
                if(items.Name == name && items.Password == password)
                {
                    isAuthentificated = true;
                }
            }
            return isAuthentificated;

        }

        /// <summary>
        /// метод,выводящий на экран именя и возраст пользователей
        /// </summary>
        public static void ShowUsers()
        {
            foreach (User item in _users)
            {
                Console.WriteLine(item.Name + " " + item.Age);
            }
        }


        /// <summary>
        /// Метод, предоставляющий пользователю определенные действия
        /// после успешной аутентификации
        /// </summary>
        public static void Actions()
        {
            string userOption = string.Empty;
            Console.WriteLine("Вы успешно зашли в систему!");
            while (userOption != "РАЗЛОГИНИТЬСЯ")
            {
                Console.WriteLine("Выберите действие\nСОЗДАТЬ - создает нового пользователя\n" +
                    "СМОТРЕТЬ - увидеть информацию о всех пользователях\nРАЗЛОГИНИТЬСЯ - выйти в основное меню.");

                userOption = Console.ReadLine();
                switch (userOption)
                {
                    case "СОЗДАТЬ":
                        User.CreateNewUser(_users);
                        break;
                    case "СМОТРЕТЬ":
                        ShowUsers();
                        break;
                }
            }
        }

        /// <summary>
        /// Основной рабочий метод, представляющий собой общую логику 
        /// взаимодействия пользователей с системой
        /// </summary>
        public static void MainMenu()
        {
            string option = string.Empty;

            while (option != "ВЫЙТИ")
            {
                Console.WriteLine("Выберите желаемое действие:\nЗАРЕГИСТРИРОВАТЬСЯ\nАУТЕНТИФИЦИРОВАТЬСЯ\nВЫЙТИ");
                option = Console.ReadLine();
                switch (option)
                {
                    case "ЗАРЕГИСТРИРОВАТЬСЯ":
                        Console.WriteLine("Введите свое имя:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Придумайте свой пароль:");
                        string password = Console.ReadLine();
                        Console.WriteLine("Укажите свой возраст");
                        int age = int.Parse(Console.ReadLine());
                        bool isRegistrationSuccessful = true;
                        foreach (User user in _users)
                        {
                            if (user.Name == name || user.Password == password)
                            {
                                isRegistrationSuccessful = false;
                            }
                        }

                        if (isRegistrationSuccessful == true)
                        {
                            _users.Add(new User(name, password, age));
                            Console.WriteLine("Вы успешно зарегистрировались");
                            UserXML.SerializeUsers(_users);
                        }
                        else
                        {
                            Console.WriteLine("Такой пользователь уже есть");
                        }
                        break;
                    case "АУТЕНТИФИЦИРОВАТЬСЯ":
                        bool isAuthentificate = Authentificate(_users);
                        if (isAuthentificate == true)
                        {
                            Actions();
                        }
                        else
                        {
                            Console.WriteLine("Неверные имя или пароль");
                        }
                        break;
                }
            }
        }
}
}
