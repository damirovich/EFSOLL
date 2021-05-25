using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001Task4Basic
{
    class Title
    {
        public string BookName { get; set; }
        public void Show()
        {
            Console.WriteLine("Название книги: " + BookName);
        }
    }
}
