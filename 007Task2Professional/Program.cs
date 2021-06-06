using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007Task2Professional
{
    public class Employee {
       // [Obsolete]//Проосто Предупреждение
        [Obsolete("Предупреждение! поменай на false", false)]//Если true то препятствует компиляции.
                                                             //и вывод сообщение
        public string Message { get { return "Что бы вывести Предупреждение поменяй атрибут Obsolete на true"; } }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee empl = new Employee();
            Console.WriteLine(empl.Message);
            Console.ReadKey();
            
        }
    }
}
