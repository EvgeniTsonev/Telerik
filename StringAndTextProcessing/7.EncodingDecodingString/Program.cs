//Write a program that encodes and decodes a string using given encryption key (cipher).
//The key consists of a sequence of characters. The encoding/decoding is done by performing XOR (exclusive or)
//operation over the first letter of the string with the first of the key,
//the second – with the second, etc. When the last key character is reached, the next is the first

using System;
using System.Text;
class Program
{
    static void Main()
    {
        //to encode and to decode is the same for this method
        string str = "123456789";   //the two strings are meaning the same
        //string str = "PAWRTES^X";
        char[] text = str.ToCharArray();
        char[] cipher = { 'a', 's', 'd', 'f' };
        StringBuilder encodedText = new StringBuilder();
        //for ease we make array of the repeating cipher
        char[] keyArr = new char[text.Length];
        for (int i = 0, k = 0; i < keyArr.Length; k++, i++)
        {
            if (!(k < cipher.Length))
            {
                k = 0;
            }
            keyArr[i] = cipher[k];
        }
        //and know we xor the cipher and the text...
        for (int i = 0; i < text.Length; i++)
        {
            encodedText.Append((char)(text[i] ^ keyArr[i]));
        }
        Console.WriteLine(encodedText);
    }
}

