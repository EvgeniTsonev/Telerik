﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JerryMouse
{
    internal class Queen : Figure
    {
        internal Queen(FigureColor color, FigureType type, Position position)
            : base(color, type, position)
        {
        }

        public override void CalculateValidMoves(Position currentPosition)
        {
            Figure.AddHorizontalMoves(currentPosition, this);
            Figure.AddVerticalMoves(currentPosition, this);
            Figure.AddDiagonalMoves(currentPosition, this);
        }
    }
}
