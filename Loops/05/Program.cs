//Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K)

using System;
using System.Numerics;
class Program
{
    static void Main()
    {
        Console.WriteLine("Prdogram that calculates N!*K!/(N-K) for (1<K<N)");
        Console.Write("Please enter N : ");
        byte n = byte.Parse(Console.ReadLine());
        Console.Write("Now enter K : ");
        byte k = byte.Parse(Console.ReadLine());
        BigInteger factK = 1;
        BigInteger factN = 1;
        BigInteger nMinusKFact = 1;
        BigInteger nMinusK = (n - k);
        for (int i = 1; i <= n; i++)            //i'm calculating all the factorials separate...
        {                                       //i think there is more efficient way
            factN *= i;
        }
        for (int i = 1; i <= k; i++)
        {
            factK *= i;
        }

        for (int i = 1; i <= nMinusK; i++)
        {
            nMinusKFact *= i;
        }
        Console.WriteLine("The result of the product of N!*K!/(N-K) is : {0}", (factK * factN) / (nMinusKFact));
    }
}

