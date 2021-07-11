using _010Task1ASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010Task1ASP
{
    static class Repository
    {
        public static void Create() {
            using (Context db = new Context()) {
                Console.WriteLine("Введите имя пользователя");
                string name = Console.ReadLine();
                Console.WriteLine("Введите фамилию пользователя");
                string surname = Console.ReadLine();
                Console.WriteLine("Введите возраст пользователя");
                short age = short.Parse(Console.ReadLine());
                User user = new User() { Name = name, SurName = surname, Age = age };
                db.Users.Add(user);
                db.SaveChanges();
            }
        }
        public static void Read() {
            using (Context db = new Context()) {
                List<User> users = db.Users.ToList();
                foreach (User us in users)
                {
                    Console.WriteLine("№ {0} {1} {2} {3}", us.Id, us.Name,us.SurName,us.Age);
                }

            }
        }
        public static void Update(int Id) {
            using (Context db = new Context()) {
                User user = db.Users.Find(Id);
                Console.WriteLine("Введите Имя пользователя");
                string name = Console.ReadLine();
                Console.WriteLine("Введите фамилию пользователя");
                string surname = Console.ReadLine();
                Console.WriteLine("Введите возраст пользователя");
                short age = short.Parse(Console.ReadLine());
                user.Name = name;
                user.SurName = surname;
                user.Age = age;
                db.Users.Update(user);
                db.SaveChanges();
            }
        }
        public  static void Delete(int Id) {
            using (Context db = new Context()) {
                User user = db.Users.Find(Id);
                db.Users.Remove(user);
                db.SaveChanges();
            }
        }
    }
}
