using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EF002
{
    class Program
    {
        static void Main(string[] args)
        {
            using (EFDbContext db = new EFDbContext())
            {
                Teacher t1 = new Teacher { Name = "Рамтов Кубаныч Садинович" };
                Teacher t2 = new Teacher { Name = "Айзада Жаасынбековна"};
                Teacher t3 = new Teacher { Name = "Тен Иосиф Григорьевич" };
                db.Teachers.AddRange(new List<Teacher> { t1, t2, t3 });
                db.SaveChanges();

                Groupp groupp1 = new Groupp { NameGroup = "ПИ-1-17",StudentCount=18 };
                groupp1.Teachers.Add(t1);
                groupp1.Teachers.Add(t3);
                Groupp groupp2 = new Groupp { NameGroup = "ПИ-(Англ)-1-18",StudentCount=5 };
                groupp2.Teachers.Add(t2);
                db.Groupps.Add(groupp1);
                db.Groupps.Add(groupp2);
                db.SaveChanges();
                foreach (Groupp t in db.Groupps.Include(x=>x.Teachers))
                {
                    Console.WriteLine("Группа: {0}", t.NameGroup);
                    foreach (Teacher pl in t.Teachers)
                    {
                        Console.WriteLine("Преподователь-{0}", pl.Name);
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
