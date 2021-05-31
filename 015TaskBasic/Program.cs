using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _015TaskBasic
{
    public struct Worker
    {
        public string FullName { get; set; }
        public string Position { get; set; }
        public DateTime Date { get; set; }
        public int SeniorityYear
        {
            get { return DateTime.Now.Year - Date.Year; }
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int count;
            Console.WriteLine("Введите колличество сотурдников");
            count = int.Parse(Console.ReadLine());
            Worker[] workers = new Worker[count];
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Введите данные о {0} работнике:", i + 1);
                Console.Write("Введите ФИО сотрудника: ");
                workers[i].FullName = Console.ReadLine();
                Console.Write("Введите должность сотрудника: ");
                workers[i].Position = Console.ReadLine();
                check:
                try
                {
                    Console.Write("Введите дата приступления к работе: ");
                    workers[i].Date = Convert.ToDateTime(Console.ReadLine());
                }
                catch {
                    Console.WriteLine("Введита дату формате (yyyy-MM-dd)");
                    goto check;
                }

                Console.WriteLine(new string('-',50 ));
            }
            while (true)
            {
                Console.Write("Введите необходимый стаж работы сотрудника: ");
                int st = Convert.ToInt32(Console.ReadLine());
                var result = workers.Where(w => w.SeniorityYear >= st).OrderBy(w => w.FullName);
                if (result.Count() > 0)
                {
                    Console.WriteLine("Работники со стажем {0}:", st);
                    foreach (Worker w in result)
                    {
                        Console.WriteLine(new string('-', 50));
                        Console.WriteLine("Сотрудник: "+w.FullName);
                        Console.WriteLine("Должность сотрудника: " + w.Position);
                        Console.WriteLine("Дата приянтие на должность: "+ w.Date.ToString("D"));
                        Console.WriteLine("Стаж работы в годах: " + w.SeniorityYear);
                    }
                }
                else
                    Console.WriteLine("Работников со стажем {0} не обнаружено:", st);
                Console.ReadLine();
            }
        }
    }
}
