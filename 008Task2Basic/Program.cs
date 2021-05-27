using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008Task2Basic
{
    class Program
    {
        static class ConsolePrinter
        {
            public enum OutputColors { Blue = 9, Green = 10, Red = 12, DarkGray=8, Magenta=13 }

            public static void Print(string text, OutputColors outputColor)
            {
                Console.ForegroundColor = (ConsoleColor)Convert.ToInt32(outputColor);
                Console.WriteLine(text);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            che:
            Console.WriteLine("Выберите цвет");
            Console.WriteLine("Blue, Red, Green,DarkGray,Magenta");
            string cpl = Console.ReadLine();
            if (cpl == "Blue")
            {
                ConsolePrinter.Print(str, ConsolePrinter.OutputColors.Blue);
            }
            else if (cpl == "Red")
            {
                ConsolePrinter.Print(str, ConsolePrinter.OutputColors.Red);
            }
            else if (cpl == "Green")
            {
                ConsolePrinter.Print(str, ConsolePrinter.OutputColors.Red);
            }
            else if (cpl == "DarkGray")
            {
                ConsolePrinter.Print(str, ConsolePrinter.OutputColors.DarkGray);
            }
            else if (cpl == "Magenta")
            {
                ConsolePrinter.Print(str, ConsolePrinter.OutputColors.Magenta);
            }
            else
            {
                goto che;
            }
            Console.ReadKey(true);
            
 
            
        }
    }
}
