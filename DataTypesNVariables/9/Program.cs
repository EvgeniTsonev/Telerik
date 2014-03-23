
//Write a program that prints an isosceles triangle
//of 9 copyright symbols ©. Use Windows Character Map
//to find the Unicode code of the © symbol.
//Note: the © symbol may be displayed incorrectly

using System;
using System.Text;
class Program
{
    static void Main(string[] args)
    {
        char c = '\u00a9';  //the symbol copyright
        Console.OutputEncoding = Encoding.UTF8;  //osven tozi red, za da izliza simvola copyright pravilno trqbva shrifta na conzolata da e Luicida consolas
        Console.WriteLine(c);
        Console.WriteLine("©");
        System.Console.WriteLine("\u00a9");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(  @"              
        {0},                    
     {0}, {0}, {0}
  {0}, {0}, {0}, {0}, {0}", c);
        Console.WriteLine();
    }
}

