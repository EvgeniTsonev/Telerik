//Write a program that compares two char arrays lexicographically (letter by letter).

using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Write the lenmgth of the arrays :");
        int n = int.Parse(Console.ReadLine());          //we take the length of the array 
        char[] arr1 = new char[n];
        char[] arr2 = new char[n];
        bool isSimetric = false;

        for (int i = 0; i < n; i++)                     //readin the arrays
        {
            arr1[i] = char.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n; i++)                     //readin the arrays
        {
            arr2[i] = char.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)                     //comparing the arrays
        {
            if (arr1[i] == arr2[i])
                isSimetric = true;
        }
        {
            if (isSimetric)                             //writing the result, case sensitive
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
