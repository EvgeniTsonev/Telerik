
//Create a program that assigns null values to an integer and to double variables.
//Try to print them on the console, try to add some values or the null literal to them and see the result.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            int? a = null;      //za da se dobavi stroinost null kym scopa na int se izpolzva vyprositelen znak
            double? b = null;
            Console.WriteLine("{0} {1}", a, b);
        }
    }

