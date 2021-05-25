using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005Task4Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            Store instance = new Store();
            for (int i = 0; i < instance.Size(); i++)
                Console.WriteLine(instance[i]);

            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Поиск, введите наименование товара");
            string s = Console.ReadLine();
            Console.WriteLine(instance[s]);
            Console.ReadKey();
        }
    }
}
