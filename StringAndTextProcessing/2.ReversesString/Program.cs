//Write a program that reads a string, reverses it and prints the result at the console.
//Example: "sample"  "elpmas


using System;
class Program
    {
        static void Main()
        {
            string str = Console.ReadLine();
            int length = str.Length;
            //string is read only, we can't affect it, so we need onother var
            char[] reversedStr = new Char[length];
            for (int i = 0; i < length; i++)
            {
                reversedStr[i] = str[length-i-1];
            }
            //printing the reversed char array

            for (int i = 0; i < length; i++)
            {
                Console.Write(reversedStr[i]);
            }
            Console.WriteLine();
        }
    }

