﻿//Write a program that generates and prints to the console
//10 random values in the range [100, 200].


using System;
namespace _02.RandomGenerator
{
    class RandomGenerator
    {
        static void Main()
        {
            Random randomNumber = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0}", randomNumber.Next(100, 201));
            }
        }
    }
}