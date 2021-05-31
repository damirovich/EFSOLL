using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace _013Task1Basic
{
    static class ConsoleHelper
    {
        private static readonly ConcurrentQueue<ConsoleTask> Queue = new ConcurrentQueue<ConsoleTask>();
        private static bool _inProcess;

        static ConsoleHelper()
        {
            Console.CursorVisible = false;
            Console.OutputEncoding = Encoding.UTF8;
        }

        public static void Display(ConsoleTask task)
        {
            Queue.Enqueue(task);
            DisplayCore();
        }

        private static void DisplayCore()
        {
            while (true)
            {
                if (_inProcess)
                {
                    return;
                }

                lock (Queue)
                {
                    if (_inProcess)
                    {
                        return;
                    }

                    _inProcess = true;
                }

                while (Queue.TryDequeue(out var task))
                {
                    Console.SetCursorPosition(task.Column, task.Row);
                    Console.ForegroundColor = task.Color;
                    Console.Write(task.Symbol);
                }

                lock (Queue)
                {
                    _inProcess = false;
                    if (!Queue.IsEmpty)
                    {
                        continue;
                    }
                }

                break;
            }
        }
    }
}
