using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001Task4Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите называение книги");
            string NameBook = Console.ReadLine();
            Console.WriteLine("Введите автор книги");
            string authorBook = Console.ReadLine();
            Console.WriteLine("Введите Содержание книги");
            string contentBook = Console.ReadLine();
            Book book = new Book(NameBook,authorBook,contentBook);
            book.Show();
            Console.ReadKey();
        }
    }
}
