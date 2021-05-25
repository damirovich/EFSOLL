using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001TAsk2Basic
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine("Введите первую длину прямоугольника ");
            double side1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите вторую длину прямоугольника ");
            double side2 = double.Parse(Console.ReadLine());
            Rectangle rectangle = new Rectangle(side1, side2);
            Console.WriteLine("Площадь прямоугольника {0}, Перийметр прямоугольника {1}",rectangle.Area,rectangle.Perimeter);
            Console.ReadKey();
        }
    }
}
