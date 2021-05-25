using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004Task2Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            string formatDoc;
         

            Console.WriteLine("Enter document format: ");
            formatDoc = Console.ReadLine();

            if (formatDoc == "DOC")
            {
                AbstractHandler doc = new DOCHandler();
                doc.open();
                doc.create();
                doc.change();
                doc.save();
            }
            else if (formatDoc == "XML")
            {
                AbstractHandler xml = new XMLHandler();
                xml.open();
                xml.create();
                xml.change();
                xml.save();
            }
            else if (formatDoc == "TXT")
            {
                AbstractHandler txt = new TXTHandler();
                txt.open();
                txt.create();
                txt.change();
                txt.save();
            }
            else
               Console.WriteLine("Failed format! Enter again!");
            Console.ReadKey();
}
    }
}
