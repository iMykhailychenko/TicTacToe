using System;

namespace TicTacToe
{
    public class Controller
    {
        public static void Start()
        {
            var table = new Table(9);

            table.Render();
        }
    }
}
