using _010Task1ASP.Models;
using System;

namespace _010Task1ASP
{
    class Program
    {
        static void Main(string[] args)
        {
            bool user = true;
            while (user)
            {
                Console.WriteLine(new string('-', 50));
                Console.WriteLine("Список пользователей");
                Repository.Read();
                Console.WriteLine(new string('-', 50));
                Console.WriteLine("Выберите действие\n" +
                    "1)Обновить данные пользователя\n" +
                    "2)Удалить данные пользователя\n" +
                    "3)Добавить пользователя");
                int operation = int.Parse(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        Console.WriteLine("Введите номер пользователя");
                        int num = int.Parse(Console.ReadLine());
                        Repository.Update(num);
                        break;
                    case 2:
                        Console.WriteLine("Введите номер пользователя");
                        int num2 = int.Parse(Console.ReadLine());
                        Repository.Delete(num2);
                        break;
                    case 3:
                        Repository.Create();
                        break;
                    default:
                        Console.WriteLine("Вы ввели не правильный номер");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
