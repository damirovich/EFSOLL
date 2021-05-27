using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009Task3Basic
{
    public delegate int Number(); 
    public delegate double MediumCalc(Number[] arrayX); 
    class Program
    {
        static Random rand = new Random();

        static int Randomizer() {
            return rand.Next(1, 10);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число элментов массива");
            int array = int.Parse(Console.ReadLine());
            Number[] numArr = new Number[array];
            for (int i = 0; i < numArr.Length; i++)
            {
                numArr[i] = Randomizer;
                Console.Write(" " + numArr[i].Invoke() + " ");
            }
            Console.WriteLine();

            MediumCalc mediumCalc = delegate (Number[] arrayX)
            {
                int sum = 0;
                for (int i = 0; i < arrayX.Length; i++)
                {
                    sum += arrayX[i]();
                }
                return sum / arrayX.Length;
            };

            Console.WriteLine(mediumCalc(numArr)); 
            Console.ReadKey(); 
        } 
    }
}
