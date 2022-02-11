using System;
using System.Collections.Generic;

namespace TicTacToe
{
    public enum CellStateEnum
    {
        CROSS,
        ZERO,
        EMPTY,
    }

    public class Cell
    {
        public String State { get; private set; }
        private readonly Dictionary<CellStateEnum, string> CellEnumMap = new();


        public Cell(int index)
        {
            CellEnumMap.Add(CellStateEnum.CROSS, " ⤬ ");
            CellEnumMap.Add(CellStateEnum.ZERO, " ◯ ");
            CellEnumMap.Add(CellStateEnum.EMPTY, $" {index} ");

            State = CellEnumMap[CellStateEnum.EMPTY];
        }

        public void SetState(CellStateEnum value)
        {
            State = CellEnumMap[value];
        }

        public bool IsEmpty()
        {
           return CellEnumMap[CellStateEnum.EMPTY] == State;
        }
    }
}
