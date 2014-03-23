//Write a program that reads a number N and calculates the sum
//of the first N members of the sequence of Fibonacci:
//0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
//Each member of the Fibonacci sequence (except the
//first two) is a sum of the previous two members.


using System;
using System.Numerics;
class Program
{
    static void Main()
    {
        Console.WriteLine("Prdogram that calculates the sum of the first N members of the Fibonachi sequence.");
        Console.Write("Please enter N : ");
        int count = int.Parse(Console.ReadLine());
        BigInteger firstNum = 0;
        BigInteger lastNum = 1;
        BigInteger totalSum = 0;
        for (int i = 1; i <= count; i++)
        {
            Console.WriteLine("Member {0,-4} -  {1}", i, firstNum);
            firstNum = firstNum + lastNum;
            lastNum = firstNum - lastNum;
            totalSum = +((firstNum + lastNum) - 1);
       }
        Console.WriteLine();
        Console.WriteLine("The sum of first {0} members is {1}.", count, totalSum);
    }
}

