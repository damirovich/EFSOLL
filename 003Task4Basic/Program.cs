using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003Task4Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ключ если он у вас есть ");
            string key = Console.ReadLine();
            if (key == "pro")
            {
                ProDocumentWorker proDocument = new ProDocumentWorker();
                proDocument.EditDocument();
                proDocument.SaveDocument();
            }
            else if (key == "exp")
            {
                ExpertDocumentWorker expertDocument = new ExpertDocumentWorker();
                expertDocument.SaveDocument();
            }
            else {
                DocumentWorker documentWorker = new DocumentWorker();
                documentWorker.OpenDocument();
                documentWorker.EditDocument();
                documentWorker.SaveDocument();
            }
            Console.ReadKey();
        }
    }
}
