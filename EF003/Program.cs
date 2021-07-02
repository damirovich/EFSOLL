using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF003
{
    class Program
    {
        static void Main(string[] args)
        {
            using (EFDbContext db = new EFDbContext())
            {
                Groupp g1 = new Groupp { Name = "ПИ-1-17" };
                Groupp g2 = new Groupp { Name = "ПИ-1-18" };
                db.Groupps.Add(g1);
                db.Groupps.Add(g2);
                db.SaveChanges();
                Student s1 = new Student { Name = "Ашыров Бактилек", Age = 22, Groupp = g2 };
                Student s2 = new Student { Name = "Сарыева Клара", Age = 20, Groupp = g2 };
                Student s3 = new Student { Name = "Сеитмуртов Самат", Age = 21, Groupp = g1 };
                db.Students.AddRange(new List<Student> { s1, s2, s3 });
                db.SaveChanges();
                ////Вывод через include 
                foreach (Groupp groupp in db.Groupps.Include(t => t.Students))
                {
                    Console.WriteLine("Группа: {0}", groupp.Name);
                    foreach (Student pl in groupp.Students)
                    {
                        Console.WriteLine("{0} - {1}", pl.Name, pl.Age);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine(new string('-', 50));
                ////Вывод через linq
                List<Student> students = new List<Student> { s1, s2, s3 };
                List<Groupp> groupps = new List<Groupp> { g1, g2 };
               
                
                var group = from gr in groupps 
                            join st in students on gr equals st.Groupp
                             select new { grname = gr.Name, stname = st.Name };
                foreach (var g in group)
                    Console.WriteLine("{0} {1}", g.grname, g.stname);

                Console.WriteLine(new string('-', 50));
                ////Вывод через select 
                var student = db.Students.Select(x => new {x.Name, x.Age, Groupp=x.Groupp.Name });
                foreach (var s in student) {
                    Console.WriteLine("ФИО студента: {0} Возраст: {1} Группа: {2}", s.Name, s.Age, s.Groupp);
                }
                Console.WriteLine(new string('-', 50));
                ////Вывод через условие find 
                Groupp groupp1 = db.Groupps.Find(44);
                Console.WriteLine("{0} {1}", groupp1.Id, groupp1.Name);
            }
            Console.ReadKey();
        }
    }
}
