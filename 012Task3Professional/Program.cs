using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _012Task3Professional
{
    class Program
    {
        //Если программы запустить из exe файл не закрывая первого запущенного программы
        //то второй запущенный автоматические закрывается то есть программа может запустить в одном экземпляре
        static void Main(string[] args) {
            bool existed;
            string guid =
                Marshal.GetTypeLibGuidForAssembly(
                    Assembly.GetExecutingAssembly()).ToString();
            Mutex mutexObj = new Mutex(true,guid,out existed);
            if (existed) {
                Console.WriteLine("Приложение работает"); 
            }
            else
            {
                Console.WriteLine("Приложение уже было запущенно\nи сейчас будет закрыто\nЭто приложение может запускаться только в одном экземпляре");
                Thread.Sleep(6000);
                return;
            }
            Console.ReadLine();
        }
    }
}
