//Write a program that finds the sequence of maximal sum in given array. Example:
//{2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
//Can you do it with only one loop (with single scan through the elements of the array)?


using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Write the length of the arrays :");
        int n = int.Parse(Console.ReadLine());          //we take the length of the array

        int[] arr = new int[n];

        for (int i = 0; i < n; i++)                     //readin the arrays
        {
            Console.WriteLine("Enter element : ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        int maxTemp = int.MinValue;
        int maxEnd = 0;
        int start = 0;
        int startTemp = 0;
        int end = 0;
        for (int i = 0; i < arr.Length; i++)                    // usin Kadane's algorithm
        {                                                       
            maxEnd += arr[i];
            if (arr[i] > maxEnd)
            {
                maxEnd = arr[i];
                startTemp = i;
            }
            if (maxEnd > maxTemp)
            {
                maxTemp = maxEnd;
                start = startTemp;
                end = i;
            }
        }

        Console.WriteLine("Maximal sum is: {0}", maxTemp);
        Console.Write("The sequence is : ");
        for (int j = start; j <= end; j++)
        {
            Console.Write(" " + arr[j]);
        }
        Console.WriteLine();

    }
}

    