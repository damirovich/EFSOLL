using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _014Task2Professional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Основной поток запущен.");

            //Task.Factory.StartNew(() =>
            Parallel.Invoke(Method1, Method2,() =>
            {
                //Method1();
                Thread.Sleep(3000);
            },
            () =>
            {
               // Method2();
                Thread.Sleep(3000);
            });

            //Task[] tasks = new Task[2] {
            //    new Task(()=>Method1()),
            //    new Task(()=>Method2())
            //};
            //foreach (var t in tasks)
            //    t.Start();
            //Task.WaitAll(tasks);

            Console.WriteLine("Основной поток завершен.");
            Console.ReadKey();
        }
        static void Method1()
        {
            Console.WriteLine("Method1 запущен");
            for (int i = 0; i <5; i++)
            {
                Console.WriteLine($"Method1 Выполняется задача "+i);
                Thread.Sleep(3000);
            }
        }

        static void Method2()
        {
            Console.WriteLine("Method2 запущен");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Method2 Выполняется задача "+i);
                Thread.Sleep(3000);
            }
        }

    }
}
