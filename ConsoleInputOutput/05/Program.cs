
//Write a program that gets two numbers
//from the console and prints the greater of them. Don’t use if statements.


using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter the first number: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the first number: ");
        int b = int.Parse(Console.ReadLine());
        //thats one of the variants, using .net library's functions
        Console.WriteLine("The greater of the two entered numbers is {0}", Math.Max(a, b));

        //the second variant is using ternary operator

        int greaterNum = a > b ? a : b;
        Console.WriteLine("The greater number is {0}", greaterNum);
    }
}


