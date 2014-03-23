using System;
class UsersChoice
    {
        static void Main()
        {
            Console.WriteLine("Please choose input. '1' for integer, '2' for double and '3' for string. :");
            int inputChoice = int.Parse(Console.ReadLine());
            switch (inputChoice)
            {    
                case 1: Console.Write("You choose integer. please your integer : ");
                int intNum = int.Parse(Console.ReadLine());
                intNum++;
                Console.WriteLine("Your integer increased with one : {0}", intNum );
                break;
                case 2:
                Console.Write("You choose double variable. Please enter your variable : ");
                double doubleNum = double.Parse(Console.ReadLine());
                doubleNum++;
                Console.WriteLine("Your variable increased with one is - {0}", doubleNum );
                break;
                case 3:
                Console.Write("You choose string. Enter your string here : ");
                string someString = Console.ReadLine();
                Console.WriteLine("Your string with * at the end : {0} ", someString + "*");
                break;
                default : 
                    Console.WriteLine("No such choice."); break;
        
            }
        }
    }

