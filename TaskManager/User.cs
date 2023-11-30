using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }

        public string Password { get; set; }

        public Role Role { get; set; }


        public User(int userId, string username, string password, Role role)
        {
            UserId = userId;
            Username = username;
            Password = password;
            Role = role;
        }


        public void Login()
        {
            Console.WriteLine("Вы успешно вошли в систему");
        }
        public void Logout()
        {
            Console.WriteLine("Вы успешно вышли из  системы");
        }
    }
}
