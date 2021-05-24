using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int PayEmpl;
            Console.WriteLine("Введите заработной платы сотрудника");
            int payment = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите выслуга лет сотрудника");
            int work = int.Parse(Console.ReadLine());
            if (work < 5) {
                PayEmpl = (payment * 10) / 100;
                Console.WriteLine("Премия этого сотрудника составляет:" + PayEmpl);
            }
            Console.ReadKey();
        }
    }
}
