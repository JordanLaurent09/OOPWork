using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlUsers
{
    class Program
    {
        private static List<User> _users = new List<User>();
        static void Main(string[] args)
        {
            
        }


        public bool Authentificate(List<User> users)
        {
            bool isAuthentificated = false;

            Console.WriteLine();
            string name = Console.ReadLine();
            Console.WriteLine();
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
    }
}
