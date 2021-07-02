using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF005
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new CodeContext()) {
                foreach (Blog blog in db.Blogs.Include(b => b.Articles))
                {
                    Console.WriteLine("Блог: {0}", blog.Name);
                    foreach (Articles art in blog.Articles)
                    {
                        Console.WriteLine("Называние блога: {0}\nСодержание блога:\n{1}", art.Title, art.Text);
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
