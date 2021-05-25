using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001Task4Basic
{
    class Content
    {
        public string BookContent { get; set; }
        public void Show()
        {
            Console.WriteLine("Содержание книги: " + BookContent);
        }
    }
}
