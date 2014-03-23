//Write a program that calculates N!/K! for given N and K (1<K<N).


using System;
class Program
{
    static void Main()
    {
        Console.Write("Please enter N : ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Now enter K : ");
        int k = int.Parse(Console.ReadLine());
        int result = 1;
        for (int i = (k + 1); i <= n; i++)      //N must be bigger than K, or the result will be not true
        {                                       //we must write some check for that occassion
            result *= i;
        }
        Console.WriteLine("The result is : {0}", result);
    }
}

