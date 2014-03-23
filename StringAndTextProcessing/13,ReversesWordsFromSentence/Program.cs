//Write a program that reverses the words in given sentence.

using System;
    class Program
    {
        static void Main()
        {
            string sentence = "C# is not C++, not PHP and not Delphi!";
            string[] words = sentence.Split(' ');
            Array.Reverse(words);
            foreach (string word in words)
            Console.WriteLine(word);
        }
    }

