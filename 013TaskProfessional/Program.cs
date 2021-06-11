using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _013TaskProfessional
{
    class Program
    {
        static void Main(string[] args)
        {
            var handler = new Action(Display);
            var callback = new AsyncCallback(AsyncCompleted);
            handler.BeginInvoke(AsyncCompleted, "Асинхронные вызовы");
            Console.WriteLine("Продолжается работа метода Main");
            Console.ReadLine();
        }

        static void Display()
        {
            Console.WriteLine("Начинается работа метода Display....");
            Thread.Sleep(3000);
            Console.WriteLine("Завершается работа метода Display....");
        }

        static void AsyncCompleted(IAsyncResult resObj)
        {
            string mes = (string)resObj.AsyncState;
            Console.WriteLine(mes);
            Console.WriteLine("Работа асинхронного делегата завершена");
        }

    }
}
