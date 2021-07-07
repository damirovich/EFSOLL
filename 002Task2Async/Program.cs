using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _002Task2Async
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(new ParameterizedThreadStart(WriteChar));
            thread.Start('!');
            for (int i = 0; i < 160; i++)
            {
                Console.Write('$');
                Thread.Sleep(500);
            }
            Console.WriteLine();
            Console.WriteLine("Метод Main закончил свою работу");
            Console.ReadKey();
        }
        private static void WriteChar(object symbol)
        {
            char item = (char)symbol;
            for (int i = 0; i < 160; i++)
            {
                Console.Write(item);
                Thread.Sleep(500);
            }
        }
    }
}
