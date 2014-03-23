using System;
class DigitName
    {
        static void Main()
        {
            Console.WriteLine("Please enter a digit frorm 0 to 9 :");
            int digit = int.Parse(Console.ReadLine());
            switch (digit)
            {
                case 1: Console.WriteLine("You entered digit ONE"); break;
                case 2: Console.WriteLine("You entered digit TWO"); break;
                case 3: Console.WriteLine("You entered digit Three"); break;
                case 4: Console.WriteLine("You entered digit FOUR"); break;
                case 5: Console.WriteLine("You entered digit FIVE"); break;
                case 6: Console.WriteLine("You entered digit SIX"); break;
                case 7: Console.WriteLine("You entered digit SEVEN"); break;
                case 8: Console.WriteLine("You entered digit EIGHT"); break;
                case 9: Console.WriteLine("You entered digit NINE"); break;
                case 0: Console.WriteLine("You entered digit ZERO"); break;
                default: Console.WriteLine("WRONG DIGIT"); break;
            }
        }
    }

