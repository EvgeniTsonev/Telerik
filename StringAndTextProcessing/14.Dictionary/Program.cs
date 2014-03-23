//A dictionary is stored as a sequence of text lines
//containing words and their explanations. Write a program that enters a word
//and translates it by using the dictionary.

using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        Dictionary<string, string> dictionary = new Dictionary<string, string>();
        dictionary.Add(".NET", "platform for applications from Microsoft");
        dictionary.Add("CLR", "managed execution environment for .NET");
        dictionary.Add("namespace", " hierarchical organization of classes");
        string key = Console.ReadLine();
        //watch out, its case sensitive...
        //and there is only three records in the dictionary...
        if (dictionary.ContainsKey(key))
        {
            Console.WriteLine("{0} -> {1}",key ,dictionary[key]);
        }
        else
            Console.WriteLine("No such key...");
    }
}

