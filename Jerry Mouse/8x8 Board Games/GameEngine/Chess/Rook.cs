using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameEngine
{
    class Rook : Figure
    {
        internal Rook(FigureColor color, FigureType type, Position position)
            : base(color, type, position)
        {
        }
    }
}
