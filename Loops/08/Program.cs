//Write a program that calculates the greatest common divisor (GCD)
//of given two numbers. Use the Euclidean algorithm (find it in Internet).

using System;
class Program
{
    static void Main()
    {
       Console.WriteLine("Prdogram that calculates the greatest common diviser (GCD) of given two numbers.");
            Console.Write("Please enter first number : ");
            int firstInt = int.Parse(Console.ReadLine());
            Console.Write("Now enter second number : ");
            int secondInt = int.Parse(Console.ReadLine());
            int reminder = 1;                                   //we are using Euclidean algorithm
            if (firstInt < secondInt)                           //if the first is smaller than the secon one we change there values
            {
                int temp = secondInt;
                secondInt = firstInt;
                firstInt = temp;
            }
            while ( reminder != 0)                              //and now is the euclidian algorithm for finding the greatest common deviser of two integer 
            {
                reminder = firstInt % secondInt;
                firstInt = secondInt;
                secondInt = reminder;
           }
            Console.WriteLine("Greatest Common Deviser is : {0}", firstInt);   //printing the result
    }
}

