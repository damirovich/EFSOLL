using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009Task2StartExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Размерность массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                ////Чтобы пользователь все элементы массива мог ввести сам
                //Console.Write("array[{0}] = ", i);
                //array[i] = Convert.ToInt32(Console.ReadLine());

                ////Заполнение массива случайными числами по размеру который ввел пользователь
                array[i] = rand.Next(1, 100);//ограничение до 100 случайных чисел
                Console.WriteLine(array[i]);
            }
            /////Нахождение минимальный элемент массива через цикл for 
            //int min = 0;
            //for (int i = 1; i < array.Length; i++)
            //{
            //    if (array[i] < array[i - 1]) min = i;
            //}
            ///Нахождение нечетных элементов массива
            Console.WriteLine("Нечетные элементы");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 1)
                {
                    Console.WriteLine("{0} ", array[i]);
                }
            }
            /////Нахождение среднее арифметическое всех элементов массива
            int temp = 0;
            int result;
            for (int i = 0; i < array.Length; i++)
            {
                temp = temp + array[i];
            }

            result = temp / array.Length;
            /////Нахождение сумма всех элементов массива 
            int sum = 0;
            foreach (int value in array)
            {
                sum += value;
            }
            //Выводим результат
            Console.WriteLine("Сумма элементов массива: " + sum);
            Console.WriteLine("Максимальное число элементов массива: " + array.Max());
            Console.WriteLine("среднее арифметическое всех элементов: " + result);
            Console.WriteLine("Минимальное значение массива: " + array.Min());


            Console.ReadKey();
        }
    }
}
