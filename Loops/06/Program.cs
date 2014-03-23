//Write a program that, for a given two integer numbers N and X,
//calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN


using System;
using System.Numerics;
class Program
{
    static void Main()
    {
        Console.WriteLine("Prdogram that calculates S = 1 + 1!/x + 2!/x^2 + 3!/x^3 +...+ N!/x^N");
        Console.Write("Please enter N : ");
        byte n = byte.Parse(Console.ReadLine());
        Console.Write("Now enter x : ");
        byte x = byte.Parse(Console.ReadLine());
        BigInteger nFact = 1;
        BigInteger sqrX = x;
        Double sum = 1;     //it begins from 1 plus...
        for (int i = 1; i <= n; i++)
        {
            nFact *= i;         //again i'm calculating n! and x1*x2...*xn separately...
            sqrX *= x;
            sum += (double)(nFact) / (double)(sqrX);
        }
        Console.WriteLine("The sum is {0}", sum);
    }
}

