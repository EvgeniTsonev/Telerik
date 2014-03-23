//Write a program that creates an array containing all letters
//from the alphabet (A-Z). Read a word from the console
//and print the index of each of its letters in the array.


using System;

class Program
{
    static void Main()
    {
        string s = Console.ReadLine();
        char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        string upperCase = s.ToUpper();     //the problem with small letters could be solved in many ways
        for (int i = 0; i < upperCase.Length; i++)
        {
            for (int j = 0; j < alphabet.Length; j++)       //we iterrate the entered word and when we find match we print it
            {
                if (upperCase[i] == alphabet[j])
                {
                    Console.WriteLine("Index of letter {0} -> {1}", s[i], j);
                }
            }
        }
    }
}

