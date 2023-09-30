using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberDigitProject
{
    class ChildClass:BaseClass
    {
        public int anotherNumber;

        // Переопределенный индексатор с одним индексом 

        public override int this[int value]
        {
            get
            {
                // Определяем длину поля number
                int numberLength = 0;

                int digits = number + anotherNumber;

                while (digits > 0)
                {
                    digits /= 10;
                    numberLength++;
                }

                digits = number + anotherNumber;

                // Заполняем массив цифрами поля number
                int[] digitsArray = new int[numberLength];

                for (int i = 0; i < numberLength; i++)
                {
                    digitsArray[i] = digits % 10;
                    digits /= 10;
                }

                return digitsArray[value];
            }
        }

        // Новый индексатор с двумя индексами

        public int this[int fieldNumber, int value]
        {
            get
            {
                // Выбор нужного целочисленного поля
                int digits;

                if (fieldNumber == 0)
                {
                    digits = number;
                }
                else if (fieldNumber == 1)
                {
                    digits = anotherNumber;
                }
                else
                {
                    Console.WriteLine("Введено ошибочное значение; по умолчанию будет использовано значение поля number");
                    digits = number;
                }


                // Определяем длину поля number
                int numberLength = 0;

                int temp = digits;

                while (temp > 0)
                {
                    temp /= 10;
                    numberLength++;
                }

                // Заполняем массив цифрами поля number
                int[] digitsArray = new int[numberLength];

                for (int i = 0; i < numberLength; i++)
                {
                    digitsArray[i] = digits % 10;
                    digits /= 10;
                }

                return digitsArray[value];

            }
        }
    }
}
