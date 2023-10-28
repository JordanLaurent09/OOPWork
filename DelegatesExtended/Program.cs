using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExtended
{
    class Program
    {
        public delegate int DelegateSum(int firstNumber, int secondNumber);
        public delegate string[] DelegateWordsArraySort(string[] initialArray); 
        static void Main(string[] args)
        {
            // 1.
            DelegateSum sum = delegate (int one, int two)
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
        }
    }
}
