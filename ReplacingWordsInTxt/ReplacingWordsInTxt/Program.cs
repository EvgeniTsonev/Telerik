//this program is replacing words from one file(dictionary) to onother, in this case empty space
//and at the end we write new file with the replaced words...
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
namespace ReplacingWordsInTXTFromDictionaryFile
{
    internal class Program
    {
        private static void Main()
        {
            List<string> dictionary = new List<string>();
            using (StreamReader reader = new StreamReader("..\\..\\dictionary.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(new char[]{' '});
                    string[] array = words;
                    for (int i = 0; i < array.Length; i++)
                    {
                        string word2 = array[i];
                        dictionary.Add(word2);
                    }
                }
                dictionary.ForEach(delegate(string word)
                {
                    Console.WriteLine(word);
                });
            }
            using (StreamReader reader2 = new StreamReader("..\\..\\txtforprocessing.txt"))
            {
                using (StreamWriter writer = new StreamWriter("..\\..\\processedtxt.txt"))
                {
                    string line;
                    while ((line = reader2.ReadLine()) != null)
                    {
                        //my favourite regex, but it replaces only single words not attached
                        foreach (string word2 in dictionary)
                        {
                            line = Regex.Replace(line, "\\b" + word2 + "\\b", " replaced");
                        }
                        Console.WriteLine(line);
                        writer.WriteLine(line);
                    }
                }
            }
        }
    }
}