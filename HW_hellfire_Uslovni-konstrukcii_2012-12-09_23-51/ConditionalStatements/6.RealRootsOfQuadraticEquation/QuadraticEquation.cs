using System;
class QuadraticEquation
    {
        static void Main()
        {
            Console.WriteLine("This is a program that prints the real roots of the quadratic equation ax^2+bx+c=0 ");
            Console.WriteLine("Please enter tree coefficients: ");
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("If coeficient a is 0, this is not a quadratic equation. Please enter coeficient a again.");
                a = double.Parse(Console.ReadLine());
            }
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());
            double D = b * b - 4 * a * c;
            if ( D < 0 )
            {
            Console.WriteLine("The descriminant is negative, there are no real roots");
            }
            else
            {
                if (D == 0)
                {
                    double x = -(b / (2 * a));
                    Console.WriteLine("The descriminant is zero so there is 1 real root x = {0} ", x);
                }
                else
                {
                    double root1 = ( (-b) +  Math.Sqrt(D) ) / (2 * a);
                    double root2 = ( (-b) -  Math.Sqrt(D) ) / (2 * a);
                    Console.WriteLine("The descriminant is positive so there are 2 real roots.");
                    Console.WriteLine("x1 = {0}", root1 );
                    Console.WriteLine("x2 = {0}", root2);
                }
            }
        }
    }

