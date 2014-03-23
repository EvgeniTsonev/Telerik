//You are given a sequence of positive integer values written into a string,
//separated by spaces. Write a function that reads these values from given string and calculates their sum. Example:
//		string = "43 68 9 23 318"  result = 461


using System;

namespace _06.SplitStrings
{
    class SplitStrings
    {
        static void Main()
        {
            Console.WriteLine("Enter string: ");
            string myString = Console.ReadLine();

            //string myString = "43 68,9   , 23 / 318";

            int sum = SumOfStrings(myString);

            Console.WriteLine(sum);
        }
        //method that processes the string
        private static int SumOfStrings(string myString)
        {
            int sum;
            char[] charSeparators = new char[] { ' ', ',', '-', '/' };
            string[] splittedArray = myString.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);

            sum = CompleteSum(splittedArray);

            return sum;
        }
        //method that calculates the sum
        private static int CompleteSum(string[] splittedArray)
        {
            int total = 0;
            foreach (string number in splittedArray)
            {
                total += int.Parse(number);
            }

            return total;
        }
    }
}