
//Write a program that safely compares floating-point numbers
// with precision of 0.000001. 
// Examples:(5.3 ; 6.01)  false;  (5.00000001 ; 5.00000003)  true


using System;


    class Program
    {
        static void Main()
        {
            float float1 = 3.12312343f;
            float float2 = 3.34534543f;       //not equal, 
            //float float2 = 3.12312343f;       //equal

            bool equal = false;

            if (Math.Abs(float1 - float2) == 0)
                equal = true;
            if (equal) 
            {
                Console.WriteLine("{0} is equal to {1}", float1, float2);
            }
            else Console.WriteLine("not equal");

        }
    }

