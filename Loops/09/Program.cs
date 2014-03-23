//Write a program to calculate the Nth Catalan number by given N.


using System;
using System.Numerics;
class Program
{
    static void Main()
    {

        Console.WriteLine("Prdogram that calculates N'th Catalan number by given n.");
        Console.Write("Please enter n : ");
        int n = int.Parse(Console.ReadLine());
        while (n < 0)                                                   //check for n > 0
        {
            Console.Write("Please enter n >= 0 : ");
            n = int.Parse(Console.ReadLine());
        }
        BigInteger c = 1;                                              // c = 2n
        BigInteger b = 1;                                              // b = n+1
        BigInteger a = 1;                                              // a = n
        for (int i = 1; i <= 2 * n; i++)
        {
            c *= i;
            if (i <= (n + 1))                                           //the same variant is possible with for loop
            {
                b *= i;
            }
            if (i <= n)
            {
                a *= i;
            }
        }
        Console.WriteLine("The {0}-th Catalan Number is {1} .", n, (c / (b * a)));
    }
}

