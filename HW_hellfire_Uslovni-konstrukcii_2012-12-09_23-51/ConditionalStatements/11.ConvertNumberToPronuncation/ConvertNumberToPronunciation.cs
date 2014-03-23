using System;
class ConvertNumberToPronunciation
    {
        static void Main()
        {
            Console.WriteLine("A program that converts number in the range [0..999] to a text corresponding to its English pronunciation.");
            Console.WriteLine("Please enter number in the range [0..999] : ");
            int number = int.Parse(Console.ReadLine());
            while (number > 999)
                {
                Console.WriteLine("Wrong number.Please enter onother number : ");      //ako se vavede po golqmo chislo ot 999
                number = int.Parse(Console.ReadLine());
                };
            int hundred = number / 100;
            int tens = (number - hundred*100) / 10;
            int ones = number % 10;
            Console.Write("{0} --> ", number);
            switch (hundred)
            {
                case 1: Console.Write("One hundred "); break;
                case 2: Console.Write("Two hundreds "); break;
                case 3: Console.Write("Three hundreds "); break;
                case 4: Console.Write("Four hundreds "); break;
                case 5: Console.Write("Five hundreds "); break;
                case 6: Console.Write("Six hundreds "); break;
                case 7: Console.Write("Seven hundreds "); break;
                case 8: Console.Write("Eight hundreds "); break;
                case 9: Console.Write("Nine hundreds "); break;
                default: Console.Write(""); break;
            }
            if (hundred != 0 && (tens != 0 || (tens == 0 && ones != 0)))
            {
                Console.Write("and ");
            }
            else
            {
                Console.Write("");
            }
            if (tens != 1)
            {
                switch (tens)
                {
                    case 2: Console.Write("twenty "); break;
                    case 3: Console.Write("thirty "); break;
                    case 4: Console.Write("fourty "); break;
                    case 5: Console.Write("fifty "); break;
                    case 6: Console.Write("sixty "); break;
                    case 7: Console.Write("seventy "); break;
                    case 8: Console.Write("eighty "); break;
                    case 9: Console.Write("ninety "); break;
                    default: Console.Write(""); break;
                }
                switch (ones)
                {
                    case 1: Console.WriteLine("one"); break;
                    case 2: Console.WriteLine("two"); break;
                    case 3: Console.WriteLine("three"); break;
                    case 4: Console.WriteLine("four"); break;
                    case 5: Console.WriteLine("five"); break;
                    case 6: Console.WriteLine("six"); break;
                    case 7: Console.WriteLine("seven"); break;
                    case 8: Console.WriteLine("eight"); break;
                    case 9: Console.WriteLine("nine"); break;
                    default: Console.WriteLine(""); break;
                }

            }
            else
            {
                switch (ones)
                {
                    case 1: Console.WriteLine("eleven"); break;
                    case 2: Console.WriteLine("twelve"); break;
                    case 3: Console.WriteLine("thirteen"); break;
                    case 4: Console.WriteLine("fourteen"); break;
                    case 5: Console.WriteLine("fifteen"); break;
                    case 6: Console.WriteLine("sixteen"); break;
                    case 7: Console.WriteLine("seventeen"); break;
                    case 8: Console.WriteLine("eighteen"); break;
                    case 9: Console.WriteLine("nineteen"); break;
                    default: Console.WriteLine("ten"); break;
                }
            }

        }
    }

