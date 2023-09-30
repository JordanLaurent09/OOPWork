using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberDigitProject
{
    class BaseClass
    {
        public int number;

        public virtual int this[int value]
        {
            get
            {
                // Определяем длину поля number
                int numberLength = 0;

                int digits = number;

                while (digits > 0)
                {
                    digits /= 10;
                    numberLength++;
                }

                // Заполняем массив цифрами поля number
                int[] digitsArray = new int[numberLength];

                for (int i = 0; i < numberLength; i++)
                {
                    digitsArray[i] = number % 10;
                    number /= 10;
                }

                return digitsArray[value];
            }
        }
    }
}
