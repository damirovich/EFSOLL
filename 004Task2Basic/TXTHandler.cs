using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004Task2Basic
{
    class TXTHandler:AbstractHandler
    {
        public override void open()
        {
            Console.WriteLine("Open TXT");
        }
        public override void create()
        {
            Console.WriteLine("Create TXT");
        }

        public override void change()
        {
            Console.WriteLine("Change TXT");
        }


        public override void save()
        {
            Console.WriteLine("Save XML");
        }
    }
}
