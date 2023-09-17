using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractProject
{
    class Employee:Person
    {
        public string Company { get; set; }
        
        public Employee(string name,string company):base(name)
        {
            Company = company;
        }
    }
}
