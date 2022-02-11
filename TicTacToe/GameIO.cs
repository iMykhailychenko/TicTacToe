using System;
using System.Collections.Generic;

namespace TicTacToe
{
    public class GameIO
    {
        public static int GetCellIndex(List<int> availableCells)
        {   
            while (true)
            {
               bool isInt = int.TryParse(Console.ReadLine(), out int value);

                if (isInt && availableCells.Contains(value))
                {
                    return value;
                }

                Console.WriteLine("Invalid value. Enter a value from 0 to 8 and do not repeat already filled fields");
            }

        }
    }
}
