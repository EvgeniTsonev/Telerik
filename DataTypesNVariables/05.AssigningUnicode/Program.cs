
//Declare a character variable and assign it with the symbol that has Unicode code 72.
//Hint: first use the Windows Calculator to find the hexadecimal representation of 72.


using System;

    class Program
    {
        static void Main(string[] args)
        {
            char charVar = '\u0048';    //72 in hex is 48
            Console.WriteLine(charVar); //H
        }
    }

