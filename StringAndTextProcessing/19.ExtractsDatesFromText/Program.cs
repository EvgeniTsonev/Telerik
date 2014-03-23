//Write a program that extracts from a given text all dates
//that match the format DD.MM.YYYY. Display them in the standard date format for Canada.



using System;
using System.Text.RegularExpressions;
using System.Globalization;
class Program
{
    static void Main()
    {
        string text = @"Краен срок: 23:59 часа на 31.01.2013.
 Видео - 22.01.2013.
 Видео - 23 януари 2013 - Наков.
 Видео - 23.01.2013 - Наков.
 Краен срок: 23:59 часа на 03.02.2013.";
        DateTime date;
        foreach (Match item in Regex.Matches(text, @"\b\d{2}.\d{2}.\d{4}\b"))
            if (DateTime.TryParseExact(item.Value, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                Console.WriteLine(date.ToString(CultureInfo.GetCultureInfo("en-CA").DateTimeFormat.ShortDatePattern));
    }
}

