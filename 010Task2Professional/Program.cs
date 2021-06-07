using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010Task2Professional
{
    class Program
    {
        static void Main(string[] args)
        {

            Car car = new Car();
            car.TemplateMethod();
            Bike bike = new Bike();
            bike.TemplateMethod();
            Console.ReadKey();
        }
        
    }
}
