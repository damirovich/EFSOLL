using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace _011Task2Professional
{
    class Program
    {
        static object blok = new object();
        public static string textfile1 = @"C:\Users\Baktilek\source\repos\EFSOLL\011Task2Professional\011Task2ProfessionalTest1.txt";
        public static string textfile2 = @"C:\Users\Baktilek\source\repos\EFSOLL\011Task2Professional\011Task2ProfessionalTest2.txt";
        public static string textfile3 = @"C:\Users\Baktilek\source\repos\EFSOLL\011Task2Professional\filetext3.txt";
        public static StreamReader streamReader1 = File.OpenText(textfile1);
        public static StreamReader streamReader2 = File.OpenText(textfile2);
        public static StreamWriter streamWriter3 = File.CreateText(textfile3);

        static void OpenFileText1()
        {
            
            using (StreamReader sr = new StreamReader(textfile1))
            {
                Console.WriteLine(sr.ReadToEnd());
            }
            streamReader1.Close();

            lock (blok)
            {
                using (StreamReader sr = new StreamReader(textfile1))
                {  
                    streamWriter3.WriteLine(sr.ReadToEnd());
                }
                
            }    
           
        }
        static void OpenFileText2()
        {  
            using (StreamReader sr = new StreamReader(textfile2))
            {
                Console.WriteLine(sr.ReadToEnd());
            }
            streamReader2.Close();
            lock (blok)
            {
                using (StreamReader sr = new StreamReader(textfile2))
                {

                    streamWriter3.WriteLine(sr.ReadToEnd());
                }
            }
            
        }

        static void Main(string[] args)
        {
            Thread[] array = new Thread[] { new Thread(OpenFileText1), new Thread(OpenFileText2) };

            for (int i = 0; i < array.Length; i++)
            {
                array[i].Start();
                Thread.Sleep(500);
            }

            for (int i = 0; i < array.Length; i++)
            {
                array[i].Join();
                Thread.Sleep(500);
            }

            streamWriter3.Close();

            Console.ReadKey();
        }
    }
}
