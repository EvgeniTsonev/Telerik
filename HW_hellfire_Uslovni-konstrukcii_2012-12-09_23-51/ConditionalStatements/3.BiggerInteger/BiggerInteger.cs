using System;
class BiggerInteger
    {
        static void Main()
        {
            Console.WriteLine("This is a program that finds the biggest of three integers");
            Console.WriteLine("Please enter first integer:");
            int firstInt = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second integer:");
            int secondInt = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the third integer:");
            int thirdInt = int.Parse(Console.ReadLine());
            if ((firstInt > secondInt) & (firstInt > thirdInt))
            {
                Console.WriteLine("The first integer you entered is bigger than the other two.");
            }
            else
            {
                if ((secondInt > firstInt) & (secondInt > thirdInt))
                {
                    Console.WriteLine("The second integer you entered is bigger than the first {0} and the third one {1}.", firstInt, thirdInt);
                }
                else
                
                    {
                        Console.WriteLine("The third integer {0} is bigger than the first {1} and second {2}. ", thirdInt, firstInt, secondInt);

                    }
                
            }
        }
    }

