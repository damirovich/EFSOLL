using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010Task2Basic
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите размер массива:");
            int array =int.Parse(Console.ReadLine()); 
            MyList<int> list = new MyList<int>(); 
            Random t = new Random(); 
            for (int x = 0; x < array; x++)
            {
                list.Add(t.Next(100));
            }
            Console.WriteLine("Массив элементов:");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " "); 
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
