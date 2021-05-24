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
            double PayEmpl;
            Console.WriteLine("Введите заработной платы сотрудника");
            double payment = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите выслуга лет сотрудника");
            int work = int.Parse(Console.ReadLine());
            if (work < 5)
            {
                PayEmpl = (payment * 10) / 100;
                Console.WriteLine("Премия этого сотрудника составляет:" + PayEmpl + " Сом");
                Console.WriteLine("Процент премии 10% от зарабатной платы");
            }
            else if (work < 10)
            {
                PayEmpl = (payment * 15) / 100;
                Console.WriteLine("Премия этого сотрудника составляет:" + PayEmpl + " Сом");
                Console.WriteLine("Процент премии 15% от зарабатной платы");
            }
            else if (work < 15)
            {
                PayEmpl = (payment * 25) / 100;
                Console.WriteLine("Премия этого сотрудника составляет:" + PayEmpl + " Сом");
                Console.WriteLine("Процент премии 25% от зарабатной платы");
            }
            else if (work < 20)
            {
                PayEmpl = (payment * 35) / 100;
                Console.WriteLine("Премия этого сотрудника составляет:" + PayEmpl + " Сом");
                Console.WriteLine("Процент премии 35% от зарабатной платы");
            }
            else if (work < 25)
            {
                PayEmpl = (payment * 45) / 100;
                Console.WriteLine("Премия этого сотрудника составляет:" + PayEmpl + " Сом");
                Console.WriteLine("Процент премии 45% от зарабатной платы");
            }
            else {
                Console.WriteLine("Ошибка!");
            }
            Console.ReadKey();
        }
    }
}
