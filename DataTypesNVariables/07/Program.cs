﻿
//Declare two string variables and assign them with “Hello” and “World”.
//Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval).
//Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).


using System;

class Program
{
    static void Main(string[] args)
    {
        string str1 = "Hello";
        string str2 = "World";
        object str = str1 + " " + str2;
        Console.WriteLine(str);

        string str3 = str.ToString();
        Console.WriteLine(str3);
    }
}

