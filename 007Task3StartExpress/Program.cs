using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007Task3StartExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите суммы дененг в сомах");
            double sum = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите валюту");
            string valu = Console.ReadLine();
            Console.WriteLine("Введите курс валют ");
            double kurs = double.Parse(Console.ReadLine());
            Console.WriteLine(valu + Doll(sum, kurs) + "$");
        }
        static double Doll(double a, double b)
        {

            return a / b;
        }
    }
}
