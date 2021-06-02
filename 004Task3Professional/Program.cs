using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _004Task3Professional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово для замены предлогов");
            string val2 = Console.ReadLine();
            try
            {
                string text = File.ReadAllText(@"C:\3 курс\004Task3Professional.txt");
                string replace = @"\s[а-я]{1,3}\s";
                text = Regex.Replace(text, replace, " " + val2 + " ");

                File.WriteAllText(@"C:\3 курс\004Task3Professional.txt", text);
                Console.WriteLine("Текст из файла");
                Console.WriteLine(new string('-', 50));
                Console.WriteLine(text);
            }
            catch (Exception e) {
                Console.WriteLine(e);
            }
            Console.ReadKey();
        }
       
    }
}
