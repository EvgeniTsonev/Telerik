//Write a program that finds the maximal increasing sequence in an array. Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.


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
            arr[i] = int.Parse(Console.ReadLine());
        }

        int length = 1;
        int bestLength = 0;
        int endIndex = 0;

        for (int i = 0; i < (arr.Length - 1); i++)                                    //from second to last element
        {
            if (arr[i] < arr[i + 1])                                            //if is equal the element with the previous element
            {

                length++;
            }
            else
            {
                if (length > bestLength)
                {
                    bestLength = length;
                    endIndex = i;
                }
                length = 1;
            }
        }
        if (length > bestLength)                                        // If we have reached the end of the array
        {
            bestLength = length;
            endIndex = arr.Length - 1;
        }
        length = 1;
        Console.Write("The longest sequence of increasing elemints is: { ");
        for (int i = (endIndex - bestLength + 1); i < endIndex + 1; i++)        
        {                                                                       // endIndex - the index of the last elememt
            Console.Write("{0},", arr[i]);                                    // bestLength - length of the sequence
        }
        Console.WriteLine("}");
    }
}



