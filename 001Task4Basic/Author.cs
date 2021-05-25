using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001Task4Basic
{
    class Author
    {
        

        public string AutName { get; set; }
        public void Show()
        {
            Console.WriteLine("Автор книги: " + AutName);
        }

    }
}
