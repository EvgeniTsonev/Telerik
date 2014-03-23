using System;
class TheGreatestVariable
    {
    static void Main()
        {
            Console.WriteLine("This is a program that find the greatest of 5 variables.");  
            double greatestNum = 0;
            for (int count = 1; count < 6; count++)
            {
                Console.WriteLine("Please enter real number : ");
                double Value = double.Parse(Console.ReadLine());
                if ( greatestNum < Value)
                {
                    greatestNum = Value;
                }
            }
            Console.WriteLine("The greatest of the 5 variables you entered is : {0}", greatestNum);
        }
    }

