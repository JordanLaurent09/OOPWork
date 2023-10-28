using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExtended
{
    class Program
    {
        public delegate double DelegateSum(double firstNumber, double secondNumber);
        
        public delegate string[] DelegateWordsArraySort(string[] initialArray);

        public delegate double MathOperation(double numberOne, double numberTwo);
        
        static void Main(string[] args)
        {
            // 1.
            DelegateSum sum = delegate (double one, double two)
            {
                return one + two;
            };

            Console.WriteLine(sum(13, 15));

            // 2.
            DelegateWordsArraySort sortedArray = (array) =>
            {
                string[] sortedWords;
                int counter = 0;
                //int j = 0;
                for(int i = 0; i < array.Length; i++)
                {
                    if (array[i].StartsWith("A"))
                    {
                        counter++;
                    }
                }

                sortedWords = new string[counter];

                for (int i = 0, j = 0; i < array.Length; i++)
                {
                    if (array[i].StartsWith("A"))
                    {
                        sortedWords[j] = array[i];
                        j++;
                    }
                }

                return sortedWords;
            };

            string[] words = new string[] {"Army", "Armour", "Stream", "Tender", "Guitar", "Array" };

            string[] sorted = sortedArray(words);

            foreach(string item in sorted)
            {
                Console.Write(item + " ");
            }

            // 3.

            MathOperation[] ops = new MathOperation[4] {delegate(double one, double two) { return one + two; }, delegate (double one, double two) { return one - two; },
            delegate(double one, double two) { return one * two; },delegate(double one, double two) { return one / two; }};

            Console.WriteLine("Введите первое число: ");

            double firstNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");

            double secondNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите желаемую операцию: ");

            string operation = Console.ReadLine();

            switch (operation)
            {
                case "Сложение":
                    Console.WriteLine(ops[0](firstNumber, secondNumber));
                    break;
                case "Вычитание":
                    Console.WriteLine(ops[1](firstNumber, secondNumber));
                    break;
                case "Умножение":
                    Console.WriteLine(ops[2](firstNumber, secondNumber));
                    break;
                case "Деление":
                    Console.WriteLine(ops[3](firstNumber, secondNumber));
                    break;
                default:
                    Console.WriteLine("Такой операции нет!");
                    break;
            }


        }
    }
}
