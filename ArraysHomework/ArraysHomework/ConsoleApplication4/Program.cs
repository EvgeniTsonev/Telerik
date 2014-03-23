//Write a program that finds the maximal sequence of equal elements in an array.
//        Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.



using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Write the lenmgth of the arrays :");
        int n = int.Parse(Console.ReadLine());          //we take the length of the array 
        int[] arr = new int[n];

        int tempMaxSequenceSize = 0;
        int tempSequenceNum = 0;
        int maxSequenceSize = 1;
        int sequenceNum = 0;

        for (int i = 0; i < n; i++)                     //readin the arrays
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 1; i < arr.Length; i++)                                    //from second to last element
        {
            if (arr[i - 1] == arr[i])                                            //if is equal the element with the previous element
            {
                tempSequenceNum = arr[i];
                tempMaxSequenceSize++;
                if (tempMaxSequenceSize >= maxSequenceSize)
                {                                                                   //тук се прави проверка дали временно присвоените стоиности не са по големи от търсения резултат, ако да им се разменят местата 
                    if ((tempSequenceNum > sequenceNum) || (tempMaxSequenceSize > maxSequenceSize))
                    {
                        //   maxSequenceSize = tempMaxSequenceSize;
                        sequenceNum = tempSequenceNum;
                    }
                    maxSequenceSize = tempMaxSequenceSize;
                }
            }
            else
            {
                tempMaxSequenceSize = 1;
            }
        }
        Console.WriteLine("Max Sequence size {0} of element {1} .", maxSequenceSize, sequenceNum);      
    }
}
