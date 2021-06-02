using System;
using System.IO;
using System.Text;

namespace _003Task1Professional
{
    class Program
    {
        static void Main(string[] args)
        {
            string writePath = @"C:\3 курс\test.txt";
            Console.WriteLine("Введите текст");
            string text = Console.ReadLine();
            try
            {
                if (File.Exists(writePath))
                {
                    File.Delete(writePath);
                }
                using (FileStream fs = File.Create(writePath))
                {
                    // Add some text to file    
                    Byte[] title = new UTF8Encoding(true).GetBytes("");
                    fs.Write(title, 0, title.Length);
                    Console.WriteLine("Файл создался");
                    Console.WriteLine(new string('-', 30));

                }
                using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine(text);
                }
                Console.WriteLine("Текст записан в файл");
                Console.WriteLine(new string('-', 30));
                using (StreamReader sr = new StreamReader(writePath, System.Text.Encoding.Default))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine("Текст из файла");
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
