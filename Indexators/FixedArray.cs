using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexators
{
    class FixedArray
    {
        private string[] array;
        private int arrayLength;
        private int elementLength;

        // Индексатор
        public string this[int i]
        {
            get
            {
                return array[i];
            }
            set
            {
                if (value.Length == elementLength)
                {

                    array[i] = value;
                }
                else array[i] = value.Substring(0, elementLength);
            }
        }

        // Конструктор 
        public FixedArray(int arrayLength, int elementLength)
        {
            if (arrayLength <= 0 || elementLength <= 0) throw new Exception("Неверное значение длины массива или длины элемента");
            else
            {
                this.arrayLength = arrayLength;
                this.elementLength = elementLength;
                this.array = new string[arrayLength];
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Введите элемент массива:");
                string element = Console.ReadLine();
                if (element.Length == elementLength) array[i] = element;
                else array[i] = element.Substring(0, elementLength);
            }
        }




        // Вывод на экран элемента массива по индексу
        public void PrintElement(int index)
        {
            Console.WriteLine(array[index]);
        }

        // Вывод на экран всего массива

        public void PrintArray()
        {
            foreach (string item in array)
            {
                Console.Write(item + " ");
            }
        }
        // Слияние двух массивов с исключением повторяющихся элементов
        public List<string> JoinArraysDistinct(FixedArray array)
        {
            List<string> letters = new List<string>();

            for (int i = 0; i < this.array.Length; i++)
            {
                letters.Add(this.array[i]);
            }

            for (int i = 0; i < array.arrayLength; i++)
            {
                letters.Add(array[i]);
            }

            List<string> disLet = letters.Distinct().ToList();

            return disLet;
        }

        // Поэлементное сцепление двух массивов
        public List<string> UnityArrays(FixedArray fixeArray)
        {
            List<string> resultArray = new List<string>();
            if (this.arrayLength == fixeArray.arrayLength)
            {
                for (int i = 0; i < fixeArray.arrayLength; i++)
                {
                    resultArray.Add(this.array[i] + fixeArray[i]);
                }
            }
            else
            {
                Console.WriteLine("Размеры массивов не совпадают!");
            }
            return resultArray;
        }
    }
}
