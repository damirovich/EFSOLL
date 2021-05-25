using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004Task2Basic
{
    class XMLHandler:AbstractHandler
    {
       
        public override void open()
        {
            Console.WriteLine("Open XML");
        }
        public override void create()
        {
            Console.WriteLine("Create XML");
        }

        public override void change()
        {
            Console.WriteLine("Change XML");
        }

       
         public override void save()
        {
            Console.WriteLine("Save XML");
        }
    }
}
