
//Write a program that prints all the numbers from 1 to N.

using System;
    class Program
    {
        static void Main()
        {
            int n;                                          //very important for me how to escape exception*****
            string consoleInput;
            do 
            {
                Console.WriteLine("pls enter inv number: ");
                consoleInput = Console.ReadLine();
            }
            while(!int.TryParse(consoleInput, out n)||n<=1);



            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }

