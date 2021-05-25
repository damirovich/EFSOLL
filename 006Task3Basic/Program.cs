using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006Task3Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            Book.Notes notes = new Book.Notes(); 
            Console.WriteLine("Введите заметку из книги который прочли");
            notes.Text = Console.ReadLine();
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Ваша заметка");
            Console.WriteLine(notes.Text);
            Console.ReadKey();
        }
    }
}
