using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMeth
{
    class ChildClass : BaseClass
    {
        new public int code;
        public ChildClass(int n, int m) : base(n)
        {
            code = m;
        }

        new public void Show()
        {
            base.Show();
            Console.WriteLine($"Child class: {code}");
        }
    }
}
