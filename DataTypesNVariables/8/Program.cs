
//Declare two string variables and assign them with following value: 
//"The "use" of quotation causes difficulties"
//Do the above in two different ways: with and without using quoted strings.


using System;
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "The use of quotation causes difficulties.";
            string str2 = @"The ""use"" of quotation causes difficulties.";
            Console.WriteLine(str1);
            Console.WriteLine(str2);
        }
    }

