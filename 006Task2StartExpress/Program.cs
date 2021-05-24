using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006Task2StartExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = 0;
            Console.WriteLine("Введите первое число ");
            int val1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int val2 = int.Parse(Console.ReadLine());
            while (val1 < val2)
            {
                val1++;
                if (val1 < val2)
                {
                    res += val1;
                }
            }
            //Через цикл for 
            //for (int i = val1 + 1; i < val2; i++)
            //{
            //    res += i;
            //}
            Console.WriteLine(res);

            ////0006 задача 2 под задача 2
            //int res = 0;
            //Console.WriteLine("Введите первое число ");
            //int val1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введите второе число");
            //int val2 = int.Parse(Console.ReadLine());

            //for (int i = val1 + 1; i < val2; i++)
            //{
            //    if (i % 2 == 1) {
            //        Console.WriteLine("Не четные числа " + i);
            //    }
            //}
        }
    }
}
