using System;
class BonusScores
    {
        static void Main()
        {
            Console.WriteLine("Please enter a score in the range [1..9] : ");
            int score = int.Parse(Console.ReadLine());
            switch (score)
            {
                case 1:
                case 2:
                case 3:
                    score = score * 10;
                    Console.WriteLine("Your applied bonus scores are : {0}", score );
                    break;
                case 4:
                case 5:
                case 6:
                    score = score * 100;
                    Console.WriteLine("Your applied bonus scores are : {0}", score );
                    break;
                case 7:
                case 8:
                case 9:
                    score = score * 1000;
                    Console.WriteLine("Your applied bonus scores are : {0}", score );
                    break;
                case 0:
                default:
                    Console.WriteLine("ERROR");
                    break;
            }
        }
    }

