//Write a program that reads from the console a string of maximum 20 characters.
//If the length of the string is less than 20, the rest of the characters should be filled with '*'.
//Print the result string into the console


using System;
using System.Text;
class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            StringBuilder tempText = new StringBuilder();
            tempText.Append(text.ToString());
            //i'm using stringbuilder append, we can olso do it with padRight(text, '*')
            if (text.Length < 20 )
                for (int i = text.Length; i < 20; i++)
                {
                    tempText.Append('*');
                }
            Console.WriteLine(tempText);
        }
    }

