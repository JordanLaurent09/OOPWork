using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.PartOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            // 1. Arrays

            int[] digits = new int[6];

            for (int i = 0; i < digits.Length; i++)
            {
                digits[i] = random.Next(-10, 11);
            }

            // 2. List

            List<string> names = new List<string>();
            names.Add("Иван");
            names.Add("Стас");
            names.Add("Максим");


            // 3. Stack

            Stack<int> numbers = new Stack<int>();

            // 4.
            // Операции добавления элементов в стек
            numbers.Push(22);
            numbers.Push(20);
            numbers.Push(25);

            // Операции извлечения элементов из стека
            int elementOne = numbers.Pop();
            int elementTwo = numbers.Pop();
            int elementThree = numbers.Pop();

            Console.WriteLine(elementOne + " " + elementTwo + " " + elementThree);


            // 5. Queue

            Queue<string> lines = new Queue<string>();

            lines.Enqueue("Первая добавленная");
            lines.Enqueue("Вторая добавленная");

            // 6. Dictionary

            Dictionary<string, int> words = new Dictionary<string, int>();

            string word;
            int number;

            for (int i = 0; i < 4; i++)
            {
                word = Console.ReadLine();
                number = word.Length;
                words.Add(word, number);
            }


            foreach (var item in words)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }


            // 7. HashSet, SortedSet

            HashSet<int> hashSet = new HashSet<int>();
            hashSet.Add(2);
            hashSet.Add(20);
            hashSet.Add(13);
            hashSet.Add(2);

            foreach (int item in hashSet)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            SortedSet<int> sortedSet = new SortedSet<int>();
            sortedSet.Add(20);
            sortedSet.Add(15);
            sortedSet.Add(13);
            sortedSet.Add(2);


            foreach (int item in sortedSet)
            {
                Console.WriteLine(item);
            }

            // 8. KeyValuePair


            KeyValuePair<string, int> pairOne = new KeyValuePair<string, int>("Джон", 20);
            KeyValuePair<string, int> pairTwo = new KeyValuePair<string, int>("Том", 25);
            KeyValuePair<string, int> pairThree = new KeyValuePair<string, int>("Дима", 21);

            HashSet<KeyValuePair<string, int>> pairs = new HashSet<KeyValuePair<string, int>>();
            pairs.Add(pairOne);
            pairs.Add(pairTwo);
            pairs.Add(pairThree);

            Dictionary<string, int> allPairs = new Dictionary<string, int>();

            foreach (var item in pairs)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
                allPairs.Add(item.Key, item.Value);
            }

        }
    }
}
