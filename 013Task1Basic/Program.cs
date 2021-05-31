using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _013Task1Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(Matrix.Width, Matrix.Height);

            var task = Task.Run(Matrix.Start);

            Console.ReadKey();
        }
        
    }
}
