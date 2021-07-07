using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006Task2Async
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Введите текст: ");
            string text=Console.ReadLine();
            await Task.Run(()=> WriteToFileAsync(text));
            Console.Read();
        }
        static async void WriteToFileAsync(string s)
        {
            using (StreamWriter writer = new StreamWriter("Lesson6Task2.txt", false))
            {
                
                await writer.WriteLineAsync(s);
                Console.WriteLine("Текст в файл записан");
            }
            using (StreamReader reader = new StreamReader("Lesson6Task2.txt"))
            {
                Console.WriteLine(new string('-', 50));
                Console.WriteLine("Текст из файла");
                string result = await reader.ReadToEndAsync(); 
                Console.WriteLine(result);
            }
        }
    }
}
