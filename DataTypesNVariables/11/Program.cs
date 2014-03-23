
//Declare  two integer variables and assign them with 5 and 10 and after that exchange their values.

using System;

    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            a = a + b;          //razmenqme stoinostite na a i b bez da deklarirame treta promenliva
            b = a - b;
            a = a - b;
            Console.WriteLine("{0} {1}", a, b);

        }
    }

