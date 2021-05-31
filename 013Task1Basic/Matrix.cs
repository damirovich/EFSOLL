using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _013Task1Basic
{
    static class Matrix
    {
        public const int Width = 80;
        public const int Height = 40;
        public const int Lines = 50;
        public const int StartDelay = 10;

        public static async Task Start()
        {
            var tasks = new List<Task>();
            for (var i = 0; i < Lines; i++)
            {
                var task = Task.Run(LoopLine);
                tasks.Add(task);
                await Task.Delay(StartDelay);
            }
        }

        private static async Task LoopLine()
        {
            while (true)
            {
                var column = RandomHelper.Rand(0, Width);


                await MatrixLine.StartNew(column);
            }
        }
    }
}
