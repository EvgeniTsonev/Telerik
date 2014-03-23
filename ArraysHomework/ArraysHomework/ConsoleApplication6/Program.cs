//Write a program that reads two integer numbers N and K
//and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.


using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Write the length of the arrays :");
        int n = int.Parse(Console.ReadLine());          //we take the length of the array 

        Console.WriteLine("Write the number of the element within the array :");
        int k = int.Parse(Console.ReadLine());          //we take the number of the sub array we are searching (n>k) 

        int[] arr = new int[n];

        for (int i = 0; i < n; i++)                     //readin the arrays
        {
            Console.WriteLine("Enter element : ");
            arr[i] = int.Parse(Console.ReadLine());
        }
        int sum = 0;
        int bestSum = 0;
        for (int i = 0; i <= (n-k); i++)
        {
            sum = 0;
            for ( int j = i; j < (i+k); j++)
            {
                sum +=arr[j];
            }
            if (bestSum < sum)
            {
                bestSum = sum;
            }
        }
        Console.WriteLine("Max sum of {0} elements is {1}", k, bestSum);
    }
}

