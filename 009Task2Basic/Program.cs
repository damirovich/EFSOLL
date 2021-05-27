using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009Task2Basic
{
    public delegate double OperationDelegate(double a, double b);

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            double num1 = Convert.ToDouble(Console.ReadLine());
            check:
            Console.WriteLine("Введите действие  +,-,*,/");
            string opertion = Console.ReadLine();
            if (opertion != "+" && opertion != "-" && opertion != "*" && opertion != "/") {
                Console.WriteLine("Выберите из предложанного списка");
                goto check;
            }
            Console.WriteLine("Введите второе число");
            double num2 = Convert.ToDouble(Console.ReadLine());
            OperationDelegate opdel;
            switch (opertion)
            {
                case "+":
                    opdel= (c, b) => c + b;
                    double del = opdel(num1, num2);
                    Console.WriteLine("Ответ:{0}", del);
                    break;
                case "-":
                    opdel = (c, b) => c - b;
                    double del1 = opdel(num1, num2);
                    Console.WriteLine("Ответ:{0}", del1);
                    break;
                case "*":
                    opdel = (c, b) => c * b;
                    double del2 = opdel(num1, num2);
                    Console.WriteLine("Ответ:{0}", del2);
                    break;
                case "/":
                    opdel = (c, b) => b == 0 ? 0 : c / b;
                    double del3 = opdel(num1, num2);
                    Console.WriteLine("Ответ:{0}", del3);
                    break;
            }

            Console.ReadKey();
        }
    }
}
