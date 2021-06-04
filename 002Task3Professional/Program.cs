using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002Task3Professional
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Dictionary<int,double> dict = new Dictionary<int, double>();
            dict.Add(1, 1.5);
            dict.Add(22, 45.66);
            Console.WriteLine("Первый способ");
            foreach (KeyValuePair<int, double> keyValue in dict)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }
            SortedDictionary<int,double> dict2 = new SortedDictionary<int, double>();
            dict2.Add(222222, 33333.3);
            dict2.Add(123467, 12344.333);
            Console.WriteLine("Второй способ");
            foreach (KeyValuePair<int, double> keyValue2 in dict2)
            { 
                Console.WriteLine(keyValue2.Key + " - " + keyValue2.Value);
            }
            Console.ReadKey();
        }
    }
}
