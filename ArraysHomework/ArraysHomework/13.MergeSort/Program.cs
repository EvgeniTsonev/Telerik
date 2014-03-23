//Write a program that sorts an array of integers using the merge sort algorithm 

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





        }
    }
