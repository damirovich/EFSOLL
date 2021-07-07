using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _004Task3Async
{
    class Program
    {
        static async Task Main()
        {
            Console.Write("Введите число N: ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine($"Метод Main начал свою работу в потоке {Thread.CurrentThread.ManagedThreadId}.");
            if (N >= 0 && N <= 65)
            {
                await Task.Run(()=> CalculateFactorialAsync(N));
                for (int i = 0; i < 50; i++)
                {
                    Console.Write("#");
                }
            }
            else
            {
                Console.WriteLine("Ошибка! Введите другое число");
            }
            Console.WriteLine($"\nМетод Main закончил свою работу в потоке {Thread.CurrentThread.ManagedThreadId}.");
            Console.ReadKey();
        }

        static long CalculateFactorial(int N)
        {
            long factotial = 1;
            if (N != 0)
            {
                for (int i = 2; i <= N; i++)
                {
                    factotial *= i;
                }
            }
            return factotial;
        }
        static async void CalculateFactorialAsync(int m)
        {
            Console.WriteLine($"Метод CalculateFactorialAsync начал свою работу в потоке {Thread.CurrentThread.ManagedThreadId}.");
            long x = await Task.Run(() => CalculateFactorial(m));
            Console.WriteLine($"\nФакториал числа равен {x} ");
            Console.WriteLine($"Метод CalculateFactorialAsync закончил свою работу в потоке {Thread.CurrentThread.ManagedThreadId}.");
        }

    }
}
