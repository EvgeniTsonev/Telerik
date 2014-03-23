using System;
class SortByDescendingOrder
{
    static void Main()
        {
            Console.WriteLine("This is a program that sorts 3 real values in descending order. The entered values must be diferent.");  //Nqma da pravq proverka za ravenstvo
            Console.WriteLine("Please enter first value:");
            double firstValue = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second value:");
            double secondValue = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the third value:");
            double thirdValue = double.Parse(Console.ReadLine());
            if ((firstValue < secondValue) & (firstValue < thirdValue) )
            {
                if (secondValue < thirdValue)
                {
                  Console.WriteLine("The values in descending order : {0}, {1}, {2}", firstValue, secondValue, thirdValue);
                }
                else
                {
                Console.WriteLine("The values in descending order : {0}, {1}, {2}", firstValue, thirdValue, secondValue);
                }
            }
            else
            {
                if ((secondValue < firstValue) & (secondValue < thirdValue))
                {
                    if (firstValue < thirdValue)
                    {
                        Console.WriteLine("The values in descending order : {0}, {1}, {2}", secondValue, firstValue, thirdValue);
                    }
                    else
                    {
                        Console.WriteLine("The values in descending order : {0}, {1}, {2}", secondValue, thirdValue, firstValue);
                    }
                }
                else 
                {
                    if (firstValue < secondValue)
                    {
                        Console.WriteLine("The values in descending order are : {0}, {1}, {2}", thirdValue, firstValue, secondValue);
                    }
                    else
                    {
                        Console.WriteLine("The values in descending order : {0}, {1}, {2}", thirdValue, secondValue, firstValue);
                    }
                }
            }

            
        }

}

