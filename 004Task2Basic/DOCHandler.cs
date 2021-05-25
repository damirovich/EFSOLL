using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004Task2Basic
{
    class DOCHandler:AbstractHandler
    {
        public override void open()
        {
            Console.WriteLine("Open DOC");
        }
        public override void create()
        {
            Console.WriteLine("Create DOC");
        }

        public override void change()
        {
            Console.WriteLine("Change DOC");
        }


        public override void save()
        {
            Console.WriteLine("Save DOC");
        }
    }
}
