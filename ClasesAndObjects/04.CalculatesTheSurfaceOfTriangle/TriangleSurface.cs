//Write methods that calculate the surface of a triangle

using System;

class TriangleSurface
{
    static void Main()
    {
        double a = 3;       //using hardcode
        double b = 4;
        double c = 5;
        double h = 4;
        double angle = Convert.ToDouble((Math.PI * 90) / 180);
        //double a = 5;
        //double b = 7;
        //double c = 3;
        //double h = 7;
        //double angle = Convert.ToDouble((Math.PI * 90) / 180);
        Console.WriteLine("How you want to calculate the area of triangle?\n");
        Console.WriteLine("1. By side and altitude.\n2. By three sides\n3. Two sides and an angle between them.");
        int choice = int.Parse(Console.ReadLine());
        //choosing the way we want to calculate the surface
        switch (choice)
        {
            case 1: BySideAndAttitude(a, h);
                break;
            case 2: ByThreeSides(a, b, c);
                break;
            case 3: ByTwoSidesAndAngle(a, b, angle);
                break;
            default: Console.WriteLine("Enter correct number!");
                break;
        } 
        
    }
    //and now are the tree methods wich are static
    static void BySideAndAttitude(double side, double att)
    {
        double surface = (side * att) / 2;
        Console.WriteLine("Surface of the triangle by given side and attitude to it: {0}sm", surface);
    }
    static void ByThreeSides(double s1, double s2, double s3)
    {
        double p = (s1 + s2 + s3) / 2;
        double surface = Convert.ToDouble(Math.Sqrt(p * (p - s1) * (p - s2) * (p - s3)));
        Console.WriteLine("Surface of the triangle by given all its sides: {0}sm", surface);
    }
    static void ByTwoSidesAndAngle(double s1, double s2, double ang)
    {
        double surface = Convert.ToDouble((s1 * s2 * Math.Sin(ang)) / 2);
        Console.WriteLine("Surface of the triangle by given two sides and angle between them: {0}sm", surface);
    }
}