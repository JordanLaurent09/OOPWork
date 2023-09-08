using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMeth
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass bc = new BaseClass(4);
            bc.Show();
            Console.WriteLine(bc.code);
            ChildClass cc = new ChildClass(6, 13);
            cc.Show();
            Console.WriteLine(cc.code);
        }
    }
}
