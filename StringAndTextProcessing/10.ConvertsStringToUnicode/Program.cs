//Write a program that converts a string to a sequence
//of C# Unicode character literals. Use format strings. 

using System;
class Program
    {
        static void Main()
        {
            string text = "Hi!";
            char[] str = text.ToCharArray();
            foreach (char ch in str)
                Console.WriteLine("\\u{0:X4}", (int)ch);
        }
    }

