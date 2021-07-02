using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF004
{
    class Program
    {
        static void Main(string[] args)
        {
            
            using (EFDbContext db = new EFDbContext())
            {
                Position p1 = new Position { Name = "Менеджеeeр" };
                Position p2 = new Position { Name = "Продовец" };
                db.Positions.Add(p1);
                db.Positions.Add(p2);
                db.SaveChanges();
                Employee e1 = new Employee { FullName = "Ашыров Бактилек", Position = p2 };
                Employee e2 = new Employee { FullName = "Сарыева Клара", Position = p1 };
                Employee e3 = new Employee { FullName = "Сеитмуртов Самат",  Position = p2 };
                db.Employees.AddRange(new List<Employee> { e1, e2, e3 });
                db.SaveChanges();

                foreach (Position position in db.Positions.Include(p=>p.Employees))
                {
                    Console.WriteLine("Должность: {0}", position.Name);
                    foreach (Employee empl in position.Employees)
                    {
                        Console.WriteLine("{0} - {1}", empl.FullName, empl.Position.Name);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine(new string('-', 50));
              
            }
            Console.ReadKey();
        }
    }
}
