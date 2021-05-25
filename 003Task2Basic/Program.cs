using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003Task2Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            ExcelentPupil a = new ExcelentPupil();
            GoodPupil b = new GoodPupil();
            BadPupil c = new BadPupil();

            ClassRoom class1 = new ClassRoom(a, b, c, c);
            ClassRoom class2 = new ClassRoom(a, b);
            Console.Read();
        }
    }
}
