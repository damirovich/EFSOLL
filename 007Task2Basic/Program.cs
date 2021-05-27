using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.IO;

namespace _007Task2Basic
{
    struct Train
    {
        public string PunktNaz;
        public int Number;
        public DateTime Time;
        public Train(string punktnaz, int number, DateTime time)
        {
            this.PunktNaz = punktnaz;
            this.Number = number;
            this.Time = time;

        }

        public override string ToString()
        {
            return string.Format("Пункт назначения: {0}, № поезда: {1}, Отправление: {2}", PunktNaz, Number, Time);
        }
    }

    class Program
    {
        static void Main()
        {
            Train[] trains = new Train[2];

            for (int i = 0; i < trains.Length; i++)
            {
                Console.WriteLine("Введите название пункта назначения:  ");
                string punktnaz = Console.ReadLine();

                Console.WriteLine("Введите номер поезда: ");
                int number = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите дату отправления: ");
                DateTime time = DateTime.Parse(Console.ReadLine());

                trains[i] = new Train(punktnaz, number, time);
            }

            Console.WriteLine("Введите название пункта назначения для поиска или end для выхода");
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                bool trainFound = false;
                for (int i = 0; i < trains.Length; i++)
                {
                    if (trains[i].PunktNaz == input)
                    {
                        Console.WriteLine(trains[i]);
                        trainFound = true;
                    }
                }

                if (!trainFound)
                    Console.WriteLine("Ничего не найдено. Повторите попытку");
            }
            //Array.Sort<Train>(trains, (x, y) => x.Number.CompareTo(y.Number));
        }
    }
}