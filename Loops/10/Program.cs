//Write a program that prints all possible cards from a standard deck
//of 52 cards (without jokers). The cards should be printed with their English names.
//Use nested for loops and switch-case

using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Program that prints standart deck of 52 cards.");
        for (int i = 2; i <= 14; i++)
        {

            for (int n = 1; n <= 4; n++)
            {
                switch (i)
                {
                    case 2: Console.Write("Two of ");
                        break;
                    case 3: Console.Write("Three of ");
                        break;
                    case 4: Console.Write("Four of ");
                        break;
                    case 5: Console.Write("Five of ");
                        break;
                    case 6: Console.Write("Six of ");
                        break;
                    case 7: Console.Write("Seven of ");
                        break;
                    case 8: Console.Write("Eight of ");
                        break;
                    case 9: Console.Write("Nine of ");
                        break;
                    case 10: Console.Write("Ten of ");
                        break;
                    case 11: Console.Write("Jack of ");
                        break;
                    case 12: Console.Write("Queen of ");
                        break;
                    case 13: Console.Write("King of ");
                        break;
                    case 14: Console.Write("Ace of ");
                        break;
                    default: Console.WriteLine(" ");
                        break;
                }
                switch (n)
                {
                    case 1: Console.WriteLine("Clubs");
                        break;
                    case 2: Console.WriteLine("Diamonds");
                        break;
                    case 3: Console.WriteLine("Hearts");
                        break;
                    case 4: Console.WriteLine("Spades");
                        break;
                    default: Console.WriteLine(" ");
                        break;
                }
                Console.WriteLine(new string('*', 20));        //разделя картите с *
            }
        }
    }
}

