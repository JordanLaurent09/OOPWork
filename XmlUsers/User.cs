using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlUsers
{
    public class User
    {
        public string Name { get; set; }

        public string Password { get; set; }
        public int Age { get; set; }

        public User(string name, string password, int age)
        {
            Name = name;
            Password = password;
            Age = age;
        }

        public void CreateNewUser(List<User> users)
        {
            Console.WriteLine("Введите имя нового пользователя");
            string name = Console.ReadLine();
            Console.WriteLine("Введите пароль нового пользователя");
            string password = Console.ReadLine();
            Console.WriteLine("Введите возраст нового пользователя");
            int age = Convert.ToInt32(Console.ReadLine());

            if (users.Count == 0)
            {
                User newUser = new User(name, password, age);
                users.Add(newUser);
                Console.WriteLine("Новый пользователь успешно добавлен");
            }
            else
            {
                bool isOccupied = false;


                foreach (User user in users)
                {
                    if (user.Name == name || user.Password == password)
                    {
                        isOccupied = true;
                    }
                }

                if (isOccupied == false)
                {
                    User newUser = new User(name, password, age);
                    users.Add(newUser);
                    Console.WriteLine("Новый пользователь успешно добавлен");
                }
                else Console.WriteLine("Такой пользователь уже есть");
            }

        }
    }
}
