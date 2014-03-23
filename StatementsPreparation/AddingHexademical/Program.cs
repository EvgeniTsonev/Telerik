using System;
using System.Numerics;
class AddingHex
{

    static void Main()
    {
        int a = 0x2;
        int b = 0x5f;
        int value = a + b; //adding hex values

        string maxHex = int.MaxValue.ToString("x"); //maximum range of hex value as int
        Console.WriteLine(value);
        Console.WriteLine(maxHex);
        BigInteger bi1 = BigInteger.Parse("123456789012345678901234567890123456789012345678901234567890abc5", System.Globalization.NumberStyles.HexNumber);
        BigInteger bi2 = BigInteger.Parse("123456789012345678901234567890123456789012345678901234567890abc1", System.Globalization.NumberStyles.HexNumber);
        BigInteger sum = BigInteger.Add(bi1, bi2);
        Console.WriteLine("{0:x}", sum); //or sum.ToString("x")
    }
}
