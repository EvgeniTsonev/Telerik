//Write a program that finds the most frequent number in an array. Example:
//    {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)


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


        for (int i = 0; i < n; i++)            //sorting the array
        {
            int smallest = i;
            for (int j = i + 1; j < n; j++)   //from next element we choose the smallest
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


        int count = 0;
        int number = 0;
        for (int i = 0; i < n; i++)
        {

            int tempCount = 1;
            for (int j = (i + 1); j < n; j++)           //searching the most frequent number
            {
                if (arr[i] == arr[j])
                {
                    tempCount++;
                }

                if (count < tempCount || arr[j] > arr[i])
                {
                    count = tempCount;
                    number = arr[i];
                }
            }
        }
        Console.WriteLine("Most frequent num {0} -> {1}", number, count);   //printing the result
                
    }
}

