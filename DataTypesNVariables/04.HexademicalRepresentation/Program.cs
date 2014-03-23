
//Declare an integer variable and assign it with the value 254 in hexadecimal format.
//Use Windows Calculator to find its hexadecimal representation

using System;

    class Program
    {
        static void Main(string[] args)
        {
            int decValue = 254;
            // Store integer 254
            //int decValue = 182;
            // Convert integer 254 as a hex in a string variable
            string hexValue = decValue.ToString("X");
            Console.WriteLine(hexValue);
        }
    }

