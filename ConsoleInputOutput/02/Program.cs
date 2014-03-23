
//Write a program that reads the radius r of a circle and prints its perimeter and area

using System;
using System.Collections.Generic;
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter the radius of the circle: ");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine("The perimeter is: {0}", (2*Math.PI*r));
            Console.WriteLine("The area is: {0}", (Math.PI*r*r));
        }
    }

