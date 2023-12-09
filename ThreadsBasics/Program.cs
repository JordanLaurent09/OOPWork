using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadsBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            CounterResource resource = new CounterResource();

            Console.WriteLine($"На начало счетчик равен {resource.CurrentCount()}");

            Thread threadOne = new Thread(resource.CounterAdd);
            Thread threadTwo = new Thread(resource.CounterSubs);

            threadOne.Start();
            threadTwo.Start();

            threadOne.Join();
            threadTwo.Join();

            Console.WriteLine($"В результате счетчик равен {resource.CurrentCount()}");
            Console.WriteLine($"Всего операций совершено {CounterResource.totalOperations}");
        }
    }

    class CounterResource
    {
        private static readonly object lockObject = new object();
        public static int count = 0;
        public static int totalOperations = 0;
        /// <summary>
        /// Метод, увеличивающий значение счетчика в безопасном режиме(lock)
        /// </summary>
        public void CounterAdd()
        {
            for(int i = 0; i < 50; i++)
            {
                lock (lockObject)
                {
                    count++;
                    Console.WriteLine($"Счетчик увеличен, сейчас он равен {CurrentCount()}");
                    totalOperations++;
                }
            }
        }
        /// <summary>
        /// Метод, уменьшающий значение счетчика в безопасном режиме(lock)
        /// </summary>
        public void CounterSubs()
        {
            for(int i = 0; i < 150; i++)
            {
                lock (lockObject)
                {
                    count--;
                    Console.WriteLine($"Счетчик уменьшен, сейчас он равен {CurrentCount()}");
                    totalOperations++;
                }
            }
        }

        /// <summary>
        /// Метод, возвращающий текущее значение счетчика
        /// </summary>
        /// <returns></returns>
        public int CurrentCount()
        {
            return count;
        }
    }
}
