using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyboardSim
{
    public class Handler
    {
        public void EmulationMessage(string key)
        {
            Console.WriteLine("Нажата клавиша " + key);
        }
    }
}
