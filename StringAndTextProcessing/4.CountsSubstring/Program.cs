//Write a program that finds how many times a substring 
//is contained in a given text (perform case insensitive search).

using System;
class Program
{
    static void Main()
    {
        //string text = "in In";
        string text = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        int counter = 0;
        int length =text.Length; 
        string substring = "in";
        for (int i = 0; i < length-1; i++)
        {
            //case insensitive, using ToLower to count all matches
            if (text.Substring(i, 2).ToLower() == substring)
            {
                counter++;
            }
        }
        Console.WriteLine("The substring \"{0}\" is contained {1} times in the text.",substring,counter);
    }
}

