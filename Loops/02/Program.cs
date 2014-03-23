
//Write a program that prints all the numbers from 1 to N,
//that are not divisible by 3 and 7 at the same time.


using System;
class Program
{
    static void Main()
    {
        int n;                                          //very important for me how to escape exception*****
        string consoleInput;
        do
        {
            Console.Write("pls enter inv number: ");
            consoleInput = Console.ReadLine();
        }
        while (!int.TryParse(consoleInput, out n) || n <= 1);

        for (int count = 1; count <= n; count++)
        {
            if ((count % 3 == 0) & (count % 7 == 0))    //if divisible to 3 and 7 prints empty position
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine(count);               //if its not divisible prints the num
            }
        }
    }
}

