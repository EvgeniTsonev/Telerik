
//Find online more information about ASCII
//(American Standard Code for Information Interchange)
//and write a program that prints the entire ASCII table of characters on the console.


using System;

using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.Unicode;

        for (int code = 0; code <= 255; code++)
        {
            char symbol = (char)code;
            Console.WriteLine("{0} {1}", code, symbol);
        }
    }
}

