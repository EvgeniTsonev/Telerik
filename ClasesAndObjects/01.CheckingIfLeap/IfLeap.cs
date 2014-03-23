//Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.


using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a year (yyyy) : ");
        short myYear = short.Parse(Console.ReadLine());

        if (myYear % 4 == 0 && myYear % 100 != 0 || myYear % 400 == 0)
        {
            Console.WriteLine("{0} is leap", myYear);
        }
        else
        {
            Console.WriteLine("{0} is not leap", myYear);
        }
    }
}