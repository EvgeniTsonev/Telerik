//Write a program that finds in given array of integers
//a sequence of given sum S (if present). Example:
//{4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}

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

        Console.WriteLine("Write the sum we are searching :");
        int sum = int.Parse(Console.ReadLine());          //reading the sum
        int tempSum = 0;
        int startIndex = 0;
        int endIndex = 0;
        bool found = false;


        for (int i = 0; i < n; i++)     //searching the sum
        {
            for (int j = 0; j < n; j++)
            {
                if (i + j < n)
                {
                    tempSum += arr[i + j];
                    if (tempSum == sum)     //if we found it
                    {
                        found = true;       
                        startIndex = i;
                        endIndex = i + j;
                    }
                }
            }
            tempSum = 0;
        }
        if (found == true)              //if found printing the numbers
        {
            Console.Write("There is sum = {0} of these numbers : ", sum);
            for (int i = startIndex; i <= endIndex; i++)
            {
                Console.Write(arr[i] + ", ");
            }
            Console.WriteLine();
        }
        else if (found == false)        
        {
            Console.WriteLine("There is no such sum in the array.");
        }
    }
}


