using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009Task2Professional
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Размер памяти в байтах в управляемой куче: {0}", GC.GetTotalMemory(false));
            Console.WriteLine("Система поддерживает {0} поколение.\n", (GC.MaxGeneration + 1));
            Employee employee = new Employee("Бактилек", "Директор", 22);
            Console.WriteLine(employee.ToString());
            Console.WriteLine("\nОбъект empployee относится к {0} поколению.\n", GC.GetGeneration(employee));
            Console.WriteLine("Размер памяти в байтах в управляемоей куче: {0}", GC.GetTotalMemory(false));
            object[] array= new object[1000000];
            ShowGC();
            for (int i = 0; i < array.Length; i++) {
                array[i] = new object();
            }
            
            Console.WriteLine("Размер памяти в байтах в управляемой куче: {0}", GC.GetTotalMemory(false));
            array = null;
            Console.WriteLine("\nМассив построен запускаем GC");
            ShowGC();
            var start = DateTime.Now;
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Console.WriteLine("GC отработал миллисекунды                  " + (DateTime.Now - start).TotalMilliseconds + "\n");
            Console.WriteLine("Размер памяти в байтах в управляемой куче: {0}", GC.GetTotalMemory(false));
            Console.WriteLine("\nОбъект empployee относится к {0} поколению.\n", GC.GetGeneration(employee));
            ShowGC();
            Console.ReadKey();
        }
        public static void ShowGC() {
            Console.WriteLine("\nПоколение 0 проверялось {0} раз", GC.CollectionCount(0));
            Console.WriteLine("\nПоколение 1 проверялось {0} раз", GC.CollectionCount(1));
            Console.WriteLine("\nПоколение 2 проверялось {0} раз", GC.CollectionCount(2));
        }

    }
}
