using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002Task3Async
{
    class Program
    {
        public static int[] SortArray(bool isAscending, params int[] array){
           
            if (isAscending == true)
            {
                Array.Sort(array);
            }
            else {
                Array.Reverse(array);
            }
            return array;
        }

        static void Main()
        {
            Console.WriteLine("Сортировка пузырьком");
            Console.Write("Введите элементы массива: ");
            var parts = Console.ReadLine().Split(new[] { " ", ",", ";" }, StringSplitOptions.RemoveEmptyEntries);
            var array = new int[parts.Length];
            Console.WriteLine("Введите true чтобы сортировать массив по возрастанию\n" +
                "Введите false чтобы сортировать массив по убыванию");
            bool chech = bool.Parse(Console.ReadLine());
            for (int i = 0; i < parts.Length; i++)
            {
                array[i] = Convert.ToInt32(parts[i]);
            }

            Console.WriteLine("Отсортированный массив: {0}", string.Join(", ", SortArray(chech,array)));

            Console.ReadLine();
        }
    }
}
