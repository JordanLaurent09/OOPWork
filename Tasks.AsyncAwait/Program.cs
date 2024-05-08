using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.AsyncAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            //GetSumAsync(20, 1);

            //Console.WriteLine("Enter the line");
            //string line = Console.ReadLine();
            //Console.WriteLine(line);

            //GetSomeDataAsync(5);


            GetFactAsync(5);
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"Секунда: {i}");
                Task.Delay(i * 1000).Wait();
            }
        }

        // Первый простой пример по работе с асинхронными операциями без возвращаемого значения
        static int GetSum(int firstNumber, int secondNumber)
        {
            Task.Delay(3000).Wait();
            return firstNumber + secondNumber;
        }

        static async void GetSumAsync(int firstNumber, int secondNumber)
        {
            int result = 0;
            Console.WriteLine("Метод поиска суммы стартовал");

            await Task.Run(() =>
            {
                result = GetSum(firstNumber, secondNumber);
            });

            Console.WriteLine(result);
        }
        
        // Второй пример асинхронных операций, теперь уже с возвращаемым значением

        private static Task<int> FetchDataAsync(int param)
        {
            int result = 1;

            for(int i = 1; i <= param; i++)
            {
                result *= i;
            }

            return Task.FromResult(result);
        }

        private static async void GetSomeDataAsync(int param)
        {
            int data = await FetchDataAsync(param);

            Console.WriteLine(data);
        }

        // Третий пример (самостоятельный)

        // Метод, вычисляющий факториал
        private static int GetFactorial(int number)
        {
            int result = 1;
            for(int i = 1; i <= number; i++)
            {
                Task.Delay(2500).Wait();
                result *= i;
               
            }
            return result;
        }

        // Асинхронный метод, вызывающий вычисляющий факториал метод
        private static async void GetFactAsync(int number)
        {
            int result = 1;
            await Task.Run(() =>
            {
                result = GetFactorial(number);
            });
            Console.WriteLine($"Факториал числа {number} = {result}");
        }
    }
}
