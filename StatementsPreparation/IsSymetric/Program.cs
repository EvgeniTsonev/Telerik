using System;
namespace IsSymetric
{
    class Program
    {
        static void Main()
        {
            int[] n = new int[5];
            n[1] =  1;

            int[] m = new int[5];

            int[] myArray = {1, 2, 3, 4, 5 };
            int[] myArray2 = {5, 4, 3, 2, 1 };
            int length = myArray.Length;
            if (myArray.Length == myArray2.Length)
            {
                for (int i = 0; i < length; i++)
                {
                    if (myArray[i]== myArray2[length])
                    {

                        length--;
                    }
                }
            
            
            }
        }
    }
}
