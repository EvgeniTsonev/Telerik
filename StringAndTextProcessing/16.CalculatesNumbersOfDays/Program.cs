//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.

using System;
using System.Globalization;
class Program
{
    static void Main()
    {
        string start = "27.02.2006";
        string end = "3.03.2006";
        //there is one very interesting structure'called TimeSpan...we can do whatever we want with time
        DateTime startDate = DateTime.ParseExact(start, "d.MM.yyyy", CultureInfo.InvariantCulture);
        DateTime endDate = DateTime.ParseExact(end, "d.MM.yyyy", CultureInfo.InvariantCulture);
        Console.WriteLine((endDate - startDate).TotalDays);
    }
}

