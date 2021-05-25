using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003Task4Basic
{
    class ExpertDocumentWorker:ProDocumentWorker
    {
        public override void SaveDocument()
        { 
            Console.WriteLine("Документ сохранен в новом формате");
        }
    }
}
