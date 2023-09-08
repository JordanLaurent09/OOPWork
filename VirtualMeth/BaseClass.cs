using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMeth
{
    class BaseClass
    {
        public int code;

        public BaseClass(int n)
        {
            this.code = n;
        }

        public void Show()
        {
            Console.WriteLine($"Class base: {code}");
        }
    }
}
