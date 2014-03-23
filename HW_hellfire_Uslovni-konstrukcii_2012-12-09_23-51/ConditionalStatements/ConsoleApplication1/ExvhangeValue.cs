using System;
class ExvhangeValue
    {
        static void Main()
        {
            Console.WriteLine("Program that examines two integer and exchanges their values if the first one is greater.");
            Console.WriteLine("Enter first integer:");
            int firstInt = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second integer:");
            int secondInt = int.Parse(Console.ReadLine());
            if (firstInt > secondInt)
            {
                int tempInt = secondInt;
                secondInt = firstInt;
                firstInt = tempInt;
                Console.WriteLine("The first integer {0} was greater than the second one {1}, so the program exchanged their values.", firstInt, secondInt);
            }
            else
            {
                Console.WriteLine("The first integer {0} was Not greater than the second one {1}, so the program did not exchanged there values", firstInt , secondInt );
            }
        }
    }

