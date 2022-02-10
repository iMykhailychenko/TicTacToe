using System;

namespace TicTacToe
{
    public class Table
    {
        private int tableLength;
        private int rowLength;

        public Cell[] GameField { get; private set; }

        public Table(int length)
        {
            double row = Math.Sqrt(length);

            if (row % 1 == 0)
            {
                tableLength = length;
                rowLength = (int)row;

                GameField = new Cell[length];

                for (int i = 0; i < length; i++)
                {
                    GameField[i] = new Cell(i);
                }
            }
            else
            {
                throw new Exception("Invalid length. The playing field must be a square");
            }
        }

        public void Render()
        {
            for (int i = 0; i < tableLength; i++)
            {
                if ((i + 1) % rowLength == 0)
                {
                    Console.WriteLine(GameField[i].State);
                }
                else
                {
                    Console.Write(GameField[i].State);
                }
            }
        }
    }
}
