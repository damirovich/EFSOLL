using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002ASPAdvancedTask2
{
    public class SendFile
    {
        public void Send(string path, string pathbase) {
            string writePath = @"C:\Users\Baktilek\source\repos\EFSOLL\002ASPAdvancedTask2\test.txt"; 
            using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
            {
               sw.WriteLine(path,pathbase);
            }
        }
    }
}
