using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutobaseProject
{
    class Run
    {
        public Automobile Auto { get; set; }
        public bool IsCompleted { get; set; }
        public double Mileage { get; set; }

        public Run(Automobile auto)
        {
            Auto = auto;
            IsCompleted = false;
        }

    }
}
