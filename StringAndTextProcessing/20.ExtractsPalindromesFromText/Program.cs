//Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".

using System;
using System.Text.RegularExpressions;
class Program
{
    static bool IsPalindrome(string str)
    {
        bool isPalindrome = false;

        for (int i = 0; i < (str.Length / 2); i++)
        //we check if is punctoation or char
        {
            if ((str[i] == str[(str.Length - 1) - i]) && (!char.IsPunctuation(str[i])) && (str.Length > 1))
            {
                isPalindrome = true;
            }
            else isPalindrome = false;
        }
        return isPalindrome;
    }

    static void Main()
    {
        string text = "safvas jkjfhvksdfjhj sbfisa abba , ? lamal knodksfj safvas \\ ,hjklmkjh exekjdfn k asdfgdsa. goog hjkjh asddsa asdfsa";
        string[] words = text.Split(' ');

        foreach (string word in words)
        {
            if (IsPalindrome(word))
                Console.WriteLine(word);
        }
    }
}

