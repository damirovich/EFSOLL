using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _002Task4Async
{
    public class Box {
        public int number;
        public Box(int number)
        {
            this.number = number;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число N");
            int a = int.Parse(Console.ReadLine());
            Task<double> task1 = new Task<double>(FindLastFibonacciNumber, new Box(a));
            task1.Start();

            task1.ContinueWith((t) => Continuation(t), TaskContinuationOptions.LongRunning);
            Console.WriteLine("Последнее число из последовательности Фибоначчи " + task1.Result);

            Console.ReadKey();
        }
        private static void Continuation(Task task)
        {
            Console.WriteLine($"Продолжение выполнилось в потоке {Thread.CurrentThread.ManagedThreadId}");
        }
        private static double FindLastFibonacciNumber(object obj)
        {
            Box box = (Box)obj;
            return FindLastFibonacciNumber(box.number);
        }
        private static double FindLastFibonacciNumber(int number) {
            Func<int, double> fib = null;
            fib = (x) => x > 1 ? fib(x - 1) + fib(x - 2) : x;
            return fib.Invoke(number);
        }
    }
}
