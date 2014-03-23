using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameEngine
{
    internal class Knight : Figure
    {
        internal Knight(FigureColor color, FigureType type, Position position)
            : base(color, type, position)
        {
        }
    }
}
