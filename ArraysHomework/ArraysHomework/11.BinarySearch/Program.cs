using System;
class BinarySearch
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
        //now we sort it
        Array.Sort(arr);
        //binary search

        Console.WriteLine("Write the num we are searching :");
        int target = int.Parse(Console.ReadLine());          //we take the length of the array
        int index = 0 ;

        int maxLength = n-1 ;
        int iMin = 0;
        while (maxLength >= iMin)                               // взето от binary search от wiki
        {
            int middlePoint = (iMin + maxLength) / 2;
            if (arr[middlePoint] < target)
            {
                iMin = middlePoint + 1;
            }
            else if (arr[middlePoint] > target)
            {
                maxLength = middlePoint - 1;
            }
            else
            {
                index = middlePoint;
                break;
            }
            index = -1;
        }
        Console.WriteLine("The searched number {0} is on index {1}.",target ,index);

    }
}

