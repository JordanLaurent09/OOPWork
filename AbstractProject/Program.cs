using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Person");
            Employee employee = new Employee("Employee", "Company");
            Client client = new Client("Client", "Bank");

            List<Person> data = new List<Person>();
            data.Add(person);
            data.Add(employee);
            data.Add(client);

            foreach(Person item in data)
            {
                item.Display();
            }
        }
    }
}
