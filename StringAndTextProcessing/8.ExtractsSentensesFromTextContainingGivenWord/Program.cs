//Write a program that extracts from a given text all sentences containing given word


using System;
//using System.Text.RegularExpressions;
    class Program
    {
        static void Main()
        {
            string text = "jgfjhggchvkhljhv. We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            //there are two ways
            string keyWord = " in ";
            //first we must separate the text in sentences by "."
            string[] sentences = text.Split('.');

            //Console.WriteLine(sentences[2]);
            for (int i = 0; i < sentences.Length; i++)
            {
                if (sentences[i].Contains(keyWord))
                    Console.WriteLine(sentences[i]);
            }
            //we can solve the problem with regex foreach (Match sentence in Regex.Matches(str, @"\s*([^\.]*\b" + word + @"\b.*?\.)"))
            //Console.WriteLine(sentence.Groups[1]);
        }
    }

