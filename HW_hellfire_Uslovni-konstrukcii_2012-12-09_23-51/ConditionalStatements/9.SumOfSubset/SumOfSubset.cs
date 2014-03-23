using System;
class SumOfSubset
   {
    static void Main()
            {
                int[] elements = new int[5];
                for (int q = 0; q <= 4; q++)
                {
                    elements[q] = int.Parse(Console.ReadLine());
                }
     
                int numberOfSubsets = 32; // the number of the subsets of a given domain is 2^N, where N is the number of elements.
                for (int i = 1; i <= numberOfSubsets; i++)
                {
                    int currentSum = 0;
                    for (int j = 0; j <= 4; j++)
                    {
                        if (((i >> j) & 1) == 1)
                        {
                            currentSum = currentSum + elements[j];
                        }
                    }
                    if (currentSum == 0)
                    {
                        // This displays the subset.
                        for (int p = 0; p <= 4; p++)
                        {
                            if (((i >> p) & 1) == 1)
                            {
                                Console.Write("{0,2} ", elements[p]);
                            }
                        }
                        Console.WriteLine();
                    }
                }
     
            }
        }
   





