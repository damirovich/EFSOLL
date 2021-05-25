using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002Task3Basic
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Фамилия сотрудника");
            string fullName = Console.ReadLine();
            Console.WriteLine("Введите Имя сотрудника");
            string NameEmpl = Console.ReadLine();
            check:
            Console.WriteLine("Выберите должность");
            Console.WriteLine("Junior, Middle, Senior");
            string PosEmpl = Console.ReadLine();
            if (PosEmpl != "Junior" && PosEmpl != "Middle" && PosEmpl != "Senior")
            {
                Console.WriteLine("Введите из существующих должностей");
                goto check;
            }
                Console.WriteLine("Введите Зарплату сотрудника");
                double salary = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите стаж работы сотрудника");
                int exspr = int.Parse(Console.ReadLine());
                Employee e = new Employee(fullName, NameEmpl, salary, exspr, PosEmpl);
                Console.WriteLine("Name: {0}\nSurname: {1}\nPosition: {2}\nSalary: {3}", e.Name, e.Surname, e.Position, e.Salary);
                e.CalculateSalary();
           

            Console.ReadLine();
        }
    }
}
