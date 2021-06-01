using System;
using System.Collections.Generic;

namespace _014Task2Basic
{
    class Program
    {
        static void Main()
        {
            
            Console.WriteLine("Введите размер массива:");
            int array = int.Parse(Console.ReadLine());
            MyList<int> list = new MyList<int>();
            Random t = new Random();
            for (int i=0;i<array;i++)
            {
                list.Add(t.Next(100));
            }
            Console.WriteLine("Массив элементов:");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Введите элемент массива для поиска:");
            int a = int.Parse(Console.ReadLine());
            list.Search(a);
            Console.ReadKey();
        }
    }
}
