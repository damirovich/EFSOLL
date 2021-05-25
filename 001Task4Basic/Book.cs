using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001Task4Basic
{
    class Book
    {
        public Content content { get; set; }
        public Title title { get; set; }
        public Author author { get; set; }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            author.Show();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            content.Show();
            Console.ForegroundColor = ConsoleColor.Green;
            title.Show();
        }

        public Book(string autName, string bookTitle, string bookContent)
        {
            author = new Author();
            title = new Title();
            content = new Content();
            content.BookContent = bookContent;
            author.AutName = autName;
            title.BookName = bookTitle;
        }
    }
}
