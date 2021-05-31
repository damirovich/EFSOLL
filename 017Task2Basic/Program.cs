using System;
using System.Collections.Generic;
using System.Linq;

namespace _017Task2Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            int countauto = 0;
            int countcustomer = 0;
            List<Auto> listAuto = new List<Auto>();
            Console.WriteLine("Введите колличество автомобилей");
            countauto = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('-', 30));
            for (int i = 0; i < countauto; i++) {
                Console.WriteLine("Введите марку автомобиля");
                string markain = Console.ReadLine();
                Console.WriteLine("Введите модель автомобиля");
                string modelin = Console.ReadLine();
                Console.WriteLine("Введите год выпуска автомобиля");
                int yearin = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите цвет автомобиля");
                string colorin = Console.ReadLine();
                listAuto.Add(new Auto( markain, modelin, yearin, colorin));
                Console.WriteLine(new string('-', 30));
            }
          
            foreach (var auto in listAuto)
            {
                Console.WriteLine(auto.ToString()); 
            }

            Console.WriteLine(new string('-', 30));
            List<Customer> listCustomer = new List<Customer>();
            Console.WriteLine("Введите колличество покупателей");
            countcustomer = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('-', 30));
            for (int i = 0; i < countcustomer; i++)
            {
                Console.WriteLine("Введите ФИО клиента");
                string NameCust = Console.ReadLine();
                Console.WriteLine("Введите модель автомобиля");
                string modelin = Console.ReadLine();
                Console.WriteLine("Введите номер телефона клиента");
                string tell = Console.ReadLine();
                listCustomer.Add(new Customer(NameCust, modelin, tell));
                Console.WriteLine(new string('-', 30));
            }

            foreach (var customer in listCustomer)
            {
                Console.WriteLine(customer.ToString()); 
            }

            Console.WriteLine(new string('-', 30));

            var query = from auto in listAuto
                        select new { Marka = auto.Marka, Color = auto.Color };

            foreach (var item in query)
            {
                Console.WriteLine("Марка авто: {0}  - {1}", item.Marka, item.Color);
            }

            Console.WriteLine(new string('-', 30));

            var query1 = from customer in listCustomer 
                         join auto in listAuto on customer.Model equals auto.Marka 
                         select new
                         {
                             Name = customer.Name,
                             Tel = customer.Tel,
                             Model = customer.Model,
                             Color = auto.Color,
                             Marka = auto.Model,
                             Year = auto.Year
                         };

            Console.WriteLine(new string('-', 30));

            foreach (var item in query1)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5}", item.Name, item.Tel, item.Model, item.Marka, item.Color, item.Year); //Отображение данных
            }

            // Delay.
            Console.ReadKey();
        }
    }
    
}
