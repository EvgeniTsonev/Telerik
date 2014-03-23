//Write a program that reads from the console a sequence
//of N integer numbers and returns the minimal and maximal of them

using System;
class Program
{
    static void Main()
    {
        {
            Console.WriteLine("Program that reads sequence of n numbers and prints minimal and amximal of them.");
            Console.Write("Please enter n : ");
            int n = int.Parse(Console.ReadLine());
            int minValue = int.MaxValue;
            int maxValue = int.MinValue;

            for (int count = 1; count <= n; count++)
            {
                Console.Write("{0} --> ", count);
                int a = int.Parse(Console.ReadLine());
                if (a < minValue)                       //checks evry entered number if its bigger or smaller than min and maxValue, and exchanges there values
                {
                    minValue = a;
                }
                if (a > maxValue)
                {
                    maxValue = a;
                }
            }
            Console.WriteLine("Max value = {0}", maxValue);
            Console.WriteLine("Min value = {0}", minValue);

        }
         
    }
}

