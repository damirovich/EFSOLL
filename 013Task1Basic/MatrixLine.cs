using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _013Task1Basic
{
    class MatrixLine
    {
        private const int MinLength = 3;
        private const int MaxLength = 12;
        private const int MinUpdateTime = 10;
        private const int MaxUpdateTime = 100;

        private const string Symbols = "01";
        private readonly int Column;

        private readonly int Length;
        private readonly int UpdateTime;
        private char _previous1 = ' ';
        private char _previous2 = ' ';
        private int Row;

        private MatrixLine(int column)
        {
            Length = RandomHelper.Rand(MinLength, MaxLength + 1);
            UpdateTime = RandomHelper.Rand(MinUpdateTime, MaxUpdateTime + 1);
            Column = column;
        }

        public static async Task StartNew(int column)
        {
            var ml = new MatrixLine(column);
            await ml.Start();
        }

        private async Task Start()
        {
            for (var i = 0; i < Matrix.Height + Length; i++)
            {
                Step();
                await Task.Delay(UpdateTime);
            }
        }

        private static bool InBounds(int row)
        {
            return row > 0 && row < Matrix.Height;
        }

        private void Step()
        {
            if (InBounds(Row - 2))
            {
                ConsoleHelper.Display(new ConsoleTask(Column, Row - 2, _previous2, ConsoleColor.DarkGreen));
            }

            if (InBounds(Row - 1))
            {
                ConsoleHelper.Display(new ConsoleTask(Column, Row - 1, _previous1, ConsoleColor.Green));
                _previous2 = _previous1;
            }

            if (InBounds(Row))
            {
                var symbol = Symbols[RandomHelper.Rand(0, Symbols.Length)];
                ConsoleHelper.Display(new ConsoleTask(Column, Row, symbol, ConsoleColor.White));
                _previous1 = symbol;
            }

            if (InBounds(Row - Length))
            {
                ConsoleHelper.Display(new ConsoleTask(Column, Row - Length, ' ', ConsoleColor.Black));
            }

            Row++;
        }
    }
}

