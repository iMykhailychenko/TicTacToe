using System;

namespace TicTacToe
{
    public enum RoleEnum
    {
        USER,
        COMPUTER,
    }

    public class Controller
    {
        private Table table;
        private bool isEnd = false;
        private RoleEnum whoseMove = RoleEnum.USER;


        public Controller()
        {
            table = new Table();
        }

        public void Start()
        {
            while (!isEnd)
            {
                table.Render();

                GetUserMove();
            }
        }

        private void GetUserMove()
        {
            Console.WriteLine("\nEnter the index: ");
            int index = GameIO.GetCellIndex(table.EmtyCells());

            if (whoseMove == RoleEnum.USER)
            {
                table.UpdateCell(index, CellStateEnum.CROSS);
                whoseMove = RoleEnum.COMPUTER;
            }
            else
            {
                table.UpdateCell(index, CellStateEnum.ZERO);
                whoseMove = RoleEnum.USER;
            }
        }
    }
}
