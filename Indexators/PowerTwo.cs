using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexators
{
    /*Class with indexer, but without ar array.
     * Calculating the powers of number 2 from 0 to 15. 
     */

    class PowerTwo
    {
        public int this[int index]
        {
            get
            {
                if(index >= 0 && index < 16)
                {
                    return Power(index);
                }
                else
                {
                    return -1;
                }
            }
        }


        int Power(int power)
        {
            int result = 1;
            for(int i = 0; i < power; i++)
            {
                result *= 2;
            }
            return result;
        }
    }
}
