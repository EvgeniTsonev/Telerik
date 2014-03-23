
//Write a program that reads two positive integer numbers and prints
//how many numbers p exist between them such that the reminder of the division
//by 5 is 0 (inclusive). Example: p(17,25) = 2.


using System;
using System.Collections.Generic;
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter the first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the first number: ");
            int b = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = a; i < b; i++)
            {
                //prints all numbers between a and b such that the reminder of the division
                //by 5 is 0
                if (i%5==0) 
                {
                    Console.WriteLine("p({0},{1}) = {2}",a, b, i);
                    counter++;
                }
                
            }
            //and know we can print the counter
            Console.WriteLine("Counter : {0} ", counter);
        }
    }

