using System;
using System.Threading;
using System.Globalization;
class RevealTheSign
    {
        static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("This program shows the sign of the product of three real numbers.");
        Console.WriteLine("Please enter first number: ");
        double firstNum = double.Parse(Console.ReadLine());                         //числата са с запетайка....
        Console.WriteLine("Now enter the second number: ");
        double secondNum = double.Parse(Console.ReadLine());
        Console.WriteLine("...and enter the third one. :");
        double thirdNum = double.Parse(Console.ReadLine());
        if (firstNum == 0 ^ secondNum == 0 ^ thirdNum == 0)
        {
            Console.WriteLine("The product of the three number you entered is zero.");
        }
            else
            {
                if (Math.Sign(firstNum) * Math.Sign(secondNum) * Math.Sign(thirdNum) < 0)
                {
                    Console.WriteLine("The sign of the product is negative.");
                }
                else
                {
                    Console.WriteLine("The sign is positive.");
                }
            }

    }
    }

