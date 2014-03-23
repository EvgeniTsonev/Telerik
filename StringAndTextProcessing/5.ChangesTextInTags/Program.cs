//You are given a text. Write a program that changes the text
//in all regions surrounded by the tags <upcase> and </upcase>
//to uppercase. The tags cannot be nested. 

using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string str = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        //nice regular expression explained in http://en.wikipedia.org/wiki/Regular_expression#Lazy_quantification
        //and with LAMBDA expression we select the second group and we make it toUpper case
        Console.WriteLine(Regex.Replace(str, "<upcase>(.*?)</upcase>", m => m.Groups[1].Value.ToUpper()));
    }
}
