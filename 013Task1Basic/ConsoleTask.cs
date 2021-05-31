using System;
using System.Collections.Generic;
using System.Text;

namespace _013Task1Basic
{
    class ConsoleTask
    {

        public readonly ConsoleColor Color;
        public readonly int Column;
        public readonly int Row;
        public readonly char Symbol;

        public ConsoleTask(int column, int row, char symbol, ConsoleColor color)
        {
            Color = color;
            Column = column;
            Row = row;
            Symbol = symbol;
        }
    }
}
