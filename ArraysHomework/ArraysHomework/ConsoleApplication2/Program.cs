
//Write a program that reads two arrays from the console and compares them element by element

using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Write the lenmgth of the arrays :");
        int n = int.Parse(Console.ReadLine());          //we take the length of the array 
        int[] arr1 = new int[n];
        int[] arr2 = new int[n];
        bool isSimetric = false;
        for (int i = 0; i < n; i++)                     //readin the arrays
        {
            arr1[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
            arr2[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)                     //comparing the arrays
        {
            if (arr1[i] == arr2[i])
             isSimetric = true; 
        }
        {
            if (isSimetric)                             //writing the result
            {
                Console.WriteLine("The arrays are simetrc.");
            }
            else
            {
                Console.WriteLine("The array are not simetric.");
            }
            
        }
    }
}

