
// Declare five variables choosing for each of them the 
// most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong
// to represent the following values: 52130, -115, 4825932, 97, -10000

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Program
    {
        static void Main()
        {
            uint a = 52130;
            sbyte b = -115;
            uint c = 4825932;
            sbyte d = 97;
            short e = -10000;

            var f = a + b + c + d + e;
        }
    }

