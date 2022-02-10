﻿using System;
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
        private Dictionary<CellStateEnum, string> CellEnumMap = new Dictionary<CellStateEnum, string>();

        public String State { get; private set; }


        public Cell(int index)
        {
            CellEnumMap.Add(CellStateEnum.CROSS, " X ");
            CellEnumMap.Add(CellStateEnum.ZERO, " O ");
            CellEnumMap.Add(CellStateEnum.EMPTY, $" {index} ");

            State = CellEnumMap[CellStateEnum.EMPTY];
        }

        public void SetState(CellStateEnum value)
        {
            State = CellEnumMap[value];
        }
    }
}