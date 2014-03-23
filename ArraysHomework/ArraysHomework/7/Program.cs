//Sorting an array means to arrange its elements in increasing order.
//Write a program to sort an array. Use the "selection sort" algorithm:
//Find the smallest element, move it at the first position,
//find the smallest from the rest, move it at the second position, etc.


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

        
        for (int i = 0; i < n; i++)
        {
            int smallest = i;
            for (int j = i+1; j < n; j++)   //from next element we choose the smallest
            {
                if (arr[smallest] > arr[j])
                {
                    smallest = j;
                }
                
            }
            int temp = arr[smallest];       //now changing the values of the current element with the smallest
            arr[smallest] = arr[i];
            arr[i] = temp;

        }
        for (int i = 0; i < n; i++)         //printing the sorted array
        {
            Console.WriteLine(arr[i]);
        }

    }
}
