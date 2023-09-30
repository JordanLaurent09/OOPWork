using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutobaseProject
{
    class Automobile
    {
        public string Condition { get; set; }
        public string RepairRequest { get; set; }

        public Automobile()
        {
            Condition = "Отличное состояние";
        }
    }
}
