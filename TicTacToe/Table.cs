using System;
using System.Collections.Generic;

namespace TicTacToe
{
    public class Table
    {
        private int length = 9;
        private int rowLength = 3;

        public Cell[] GameField { get; private set; }

        public Table()
        {
            GameField = new Cell[length];

            for (int i = 0; i < length; i++)
            {
                GameField[i] = new Cell(i);
            }
        }

        public void Render()
        {
            Console.Clear();

            for (int i = 0; i < length; i++)
            {
                if ((i + 1)  % rowLength == 0)
                {
                    Console.WriteLine(GameField[i].State);
                }
                else
                {
                    Console.Write(GameField[i].State);
                }
            }
        }

        public void UpdateCell(int index, CellStateEnum type)
        {
            if (index < length)
            {
                GameField[index].SetState(type);
            }
        }

        public List<int> GetEmtyCells()
        {
            var data = new List<int>();

            for (int i = 0; i < length; i++)
            {
                if (GameField[i].IsEmpty())
                {
                    data.Add(i);
                }
            }

            return data;
        }
    }
}
