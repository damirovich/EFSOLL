using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001Task2Ppofessional
{
    class Program
    {
        static void Main(string[] args)
        {
            Calendar calendar = new Calendar();

            foreach (var item in calendar)
            {
                Console.WriteLine(item);
            }
           
            Console.WriteLine("1: Поиск по порядкому месяцу\n2: Поиск по колличество дней месяце");
            int countMonth = int.Parse(Console.ReadLine());
            while (true)
            {
                switch (countMonth)
                {
                    case 1:
                        Console.WriteLine("Введите порядковый номер месяца");
                        int numMonth = int.Parse(Console.ReadLine());
                        Console.WriteLine(calendar.GetDaysByMonth(numMonth));
                        break;
                    case 2:
                        Console.WriteLine("Введите колличество дней месяца");
                        int numDay = int.Parse(Console.ReadLine());
                        Console.WriteLine(calendar.GetMonthByDays(numDay));
                        break;
                    default:
                        Console.WriteLine("Ошибка!");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
